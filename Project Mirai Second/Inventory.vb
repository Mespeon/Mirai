Public Class Inventory
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form to display as full screen
        FormBorderStyle = FormBorderStyle.None
        Size = SystemInformation.PrimaryMonitorSize
        Location = New Point(0, 0)

        ' Get data from global variables
        lblFormUserSummary.Text = globalManagerFirstName + " " + globalManagerMiddleName + " " + globalManagerLastName + " (" + globalManagerEmployeeID + ")" + " - " + globalManagerPosition

        ' Set Inventory ListView display settings
        lsvInventoryList.Columns.Add("Item Name", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Supplier", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Type", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Total In Stock", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Qty / Pack", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Multiplier", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Last Delivery Date", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Last Recorded UBD", CInt(lsvInventoryList.Width / 6))

        GetInventoryList()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        Inv_AddSupplier.Show()
    End Sub

    Private Sub btnAddInventoryData_Click(sender As Object, e As EventArgs) Handles btnAddInventoryData.Click
        Inv_AddInventory.Show()
    End Sub

    Private Sub lsvInventoryList_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lsvInventoryList.SelectedIndexChanged
        btnEditInventoryData.Enabled = True
    End Sub

    Private Sub btnTransfers_Click(sender As Object, e As EventArgs) Handles btnTransfers.Click
        Inv_Transfers.Show()
    End Sub

    Private Sub txtUserSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtUserSearchBox.TextChanged

    End Sub

    Private Sub rbInventory_CheckedChanged(sender As Object, e As EventArgs) Handles rbInventory.CheckedChanged
        lsvInventoryList.Clear()
        ' Set Inventory ListView display settings
        lsvInventoryList.Columns.Add("Item Name", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Supplier", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Type", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Total In Stock", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Qty / Pack", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Multiplier", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Last Delivery Date", CInt(lsvInventoryList.Width / 6))
        lsvInventoryList.Columns.Add("Last Recorded UBD", CInt(lsvInventoryList.Width / 6))

        GetInventoryList()
    End Sub

    Private Sub rbSupplier_CheckedChanged(sender As Object, e As EventArgs) Handles rbSupplier.CheckedChanged
        lsvInventoryList.Clear()
        ' Set Inventory ListView display settings
        lsvInventoryList.Columns.Add("Supplier Name", CInt(lsvInventoryList.Width / 3))
        lsvInventoryList.Columns.Add("Supplier Contact Number", CInt(lsvInventoryList.Width / 3))
        lsvInventoryList.Columns.Add("Supplier Schedule", CInt(lsvInventoryList.Width / 3))

        sqlQuery = "SELECT * FROM local_supplier"
        ProcessInventoryListViews()
    End Sub

    Private Sub rbStockMovements_CheckedChanged(sender As Object, e As EventArgs) Handles rbStockMovements.CheckedChanged
        lsvInventoryList.Clear()
        ' Set Inventory ListView display settings
        lsvInventoryList.Columns.Add("Item Name", CInt(lsvInventoryList.Width / 3))
        lsvInventoryList.Columns.Add("Quantity Received", CInt(lsvInventoryList.Width / 3))
        lsvInventoryList.Columns.Add("Method", CInt(lsvInventoryList.Width / 3))

        sqlQuery = "SELECT * FROM local_stock_movement LEFT JOIN local_inventory ON local_inventory.RawItem_ID = local_stock_movement.RawItem_ID"
        ProcessInventoryListViews()
    End Sub
End Class