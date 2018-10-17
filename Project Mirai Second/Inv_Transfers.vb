Imports Microsoft.Office.Interop
Public Class Inv_Transfers
    Public selectedItemID As String
    Public qtyMultiplier As String
    Public remainingOnHand As String

    Private Sub Inv_Transfers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAuthorizedManager.Text = globalManagerFirstName + " " + globalManagerMiddleName + " " + globalManagerLastName
        pbxPhotoNotice.BackgroundImage = My.Resources._10_device_access_location_off

        ' Get item list with variable SQL query
        sqlQuery = "SELECT * FROM local_inventory"
        GetItemList()

        ' Set Inventory ListView display settings
        lsvTransferItems.Columns.Add("Item Name", CInt(lsvTransferItems.Width / 6))
        lsvTransferItems.Columns.Add("Direction", CInt(lsvTransferItems.Width / 6))
        lsvTransferItems.Columns.Add("On Hand", CInt(lsvTransferItems.Width / 6))
        lsvTransferItems.Columns.Add("Qty Multiplier", CInt(lsvTransferItems.Width / 6))
        lsvTransferItems.Columns.Add("Qty for Transfer", CInt(lsvTransferItems.Width / 6))
        lsvTransferItems.Columns.Add("Qty after Transfer", CInt(lsvTransferItems.Width / 6))
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnResetList_Click(sender As Object, e As EventArgs) Handles btnResetList.Click
        lsvTransferItems.Clear()
        ' Set Inventory ListView display settings
        lsvTransferItems.Columns.Add("Item Name", CInt(lsvTransferItems.Width / 5))
        lsvTransferItems.Columns.Add("Direction", CInt(lsvTransferItems.Width / 5))
        lsvTransferItems.Columns.Add("On Hand", CInt(lsvTransferItems.Width / 5))
        lsvTransferItems.Columns.Add("Qty for Transfer", CInt(lsvTransferItems.Width / 5))
        lsvTransferItems.Columns.Add("Qty after Transfer", CInt(lsvTransferItems.Width / 5))
    End Sub

    Private Sub rbTransIn_CheckedChanged(sender As Object, e As EventArgs) Handles rbTransIn.CheckedChanged
        rbTransOut.Enabled = False
        lblTransferDirection.Text = "Transfer is going in."
        pbxPhotoNotice.BackgroundImage = My.Resources._9_av_download
        txtTransferee.Enabled = False
        txtRequestor.Enabled = False
        txtQtyOnHand.Enabled = False
        gpxTransferItems.Enabled = True
    End Sub

    Private Sub rbTransOut_CheckedChanged(sender As Object, e As EventArgs) Handles rbTransOut.CheckedChanged
        If txtTransferee.Enabled = False And txtRequestor.Enabled = False Then
            txtTransferee.Enabled = True
            txtRequestor.Enabled = True
        End If
        rbTransIn.Enabled = False
        lblTransferDirection.Text = "Transfer is going out."
        pbxPhotoNotice.BackgroundImage = My.Resources._9_av_upload
        gpxTransferItems.Enabled = True
    End Sub

    Private Sub cbxTransferItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTransferItem.SelectedIndexChanged
        btnAddItem.Enabled = True

        If txtTransferItem.Enabled = True Then
            txtTransferItem.Enabled = False
        End If

        If cbxTransferItem.SelectedIndex = 0 Then
            txtTransferItem.Enabled = True
        End If

        ' Pass new query
        Dim selectedItem As String = cbxTransferItem.SelectedItem.ToString
        sqlQuery = "SELECT * FROM local_inventory WHERE item_name = '" + selectedItem + "'"
        GetItemList()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim newItem As ListViewItem

        If txtTransferItem.Text = "" Then
            newItem = lsvTransferItems.Items.Add(cbxTransferItem.SelectedItem.ToString)
        Else
            newItem = lsvTransferItems.Items.Add(txtTransferItem.Text)
        End If

        If rbTransIn.Checked Then
            newItem.SubItems.Add("IN")
            remainingOnHand = (qtyMultiplier * Val(txtTransferQty.Text)) + Val(txtQtyOnHand.Text)
        End If

        If rbTransOut.Checked Then
            newItem.SubItems.Add("OUT")
            remainingOnHand = Val(txtQtyOnHand.Text) - Val(txtTransferQty.Text)
            If remainingOnHand < 0 Then
                MessageBox.Show("Trans out failed. Item quantity is below 0." + vbCrLf + vbCrLf + "Kindly reset the list before adding a new item.", "Add Item Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        newItem.SubItems.Add(txtQtyOnHand.Text)
        newItem.SubItems.Add(qtyMultiplier)
        newItem.SubItems.Add(txtTransferQty.Text)
        newItem.SubItems.Add(remainingOnHand)

        cbxTransferItem.ResetText()
        txtQtyOnHand.Clear()
        txtTransferQty.Clear()
        btnAddItem.Enabled = False

        ' Push updated inventory data into database
        ProcessTransferItems()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If lsvTransferItems.Items.Count = 0 Then
            MessageBox.Show("Nothing to export.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            ' Create Save File dialog box
            ' This will export the generated in-system report as an Excel file for printing
            ' At this point, all items added in the list is already pushed in the database
            ' and will only require updating the parent table using the values listed in the bridge.
            MessageBox.Show("Auto-increment for duplicated file names is currently unavailable. Please make sure that you add an incrementor to the file name before saving if there are already multiple reports for the given day.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog
            saveFileDialog.Title = "Export Item Transfer Report"
            saveFileDialog.Filter = "Excel files (*.xls)|*.xls|Excel Files (*.xlsx)|*.xlsx"
            If rbTransIn.Checked Then
                saveFileDialog.FileName = "Trans_In_Report_" + Today.ToLongDateString
            End If

            If rbTransOut.Checked Then
                saveFileDialog.FileName = "Trans_Out_Report_" + Today.ToLongDateString
            End If
            saveFileDialog.InitialDirectory = "C:\Mirai\ExportedReports"
            saveFileDialog.ShowDialog()

            ' Begin creating the Excel objects
            Dim newxls As New Excel.Application
            Dim newbook As Excel.Workbook
            Dim newsheet As Excel.Worksheet

            ' Create the workbook then reference the first worksheet
            newxls.Workbooks.Add()
            newbook = newxls.ActiveWorkbook
            newsheet = newxls.ActiveSheet

            ' Format workbook
            newsheet.Cells.RowHeight = 20
            newsheet.StandardWidth = 20
            newsheet.Cells.HorizontalAlignment = HorizontalAlignment.Center

            ' Loop through the rows and columns to get data
            Dim row As Integer = 2
            Dim col As Integer = 1

            ' Copy column names
            newsheet.Cells(1, 1) = lsvTransferItems.Columns(0).Text
            newsheet.Cells(1, 2) = lsvTransferItems.Columns(1).Text
            newsheet.Cells(1, 3) = lsvTransferItems.Columns(2).Text
            newsheet.Cells(1, 4) = lsvTransferItems.Columns(3).Text
            newsheet.Cells(1, 5) = lsvTransferItems.Columns(4).Text

            For Each item As ListViewItem In lsvTransferItems.Items
                For i As Integer = 0 To item.SubItems.Count - 1
                    newsheet.Cells(row, col) = item.SubItems(i).Text
                    col = col + 1
                Next
                row += 1
                col = 1
            Next

            ' Save workbook then clean up resources
            newbook.SaveAs(saveFileDialog.FileName)
            newxls.Workbooks.Close()
            newxls.Quit()

            releaseObject(newsheet)
            releaseObject(newbook)
            releaseObject(newxls)

            MessageBox.Show("Report has been successfully exported. If you wish to generate another report, simply reopen the Transfers window.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Close()
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class