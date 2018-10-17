Public Class Inv_AddInventory
    Public multiplier As Integer = 0

    Private Sub Inv_AddInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSuppliersList()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cbxSupplier.SelectedItem = "" Or txtItemName.Text = "" Or cbxItemShipping.SelectedItem = "" Or cbxItemType.SelectedItem = "" Or txtShelfLife.Text = "" Or txtItemUnitPrice.Text = "" Or txtInitialStock.Text = "" Then
            lblAddInventoryWarning.Text = "ALL FIELDS MUST BE FILLED UP."
            lblAddInventoryWarning.Visible = True
        Else
            AddInventoryItem()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub cbxItemShipping_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxItemShipping.SelectedIndexChanged
        If txtItemQtyMultiplier.Enabled = True Then
            txtItemQtyMultiplier.Enabled = False
        End If

        Select Case cbxItemShipping.SelectedIndex
            Case 0
                txtItemQtyMultiplier.Text = 1
            Case 1
                txtItemQtyMultiplier.Text = 16
            Case 2
                txtItemQtyMultiplier.Text = 24
            Case 3
                txtItemQtyMultiplier.Text = 30
            Case 4
                txtItemQtyMultiplier.Enabled = True
        End Select
    End Sub

    Private Sub btnItemTypeGuide_Click(sender As Object, e As EventArgs) Handles btnItemTypeGuide.Click
        MessageBox.Show("DRY - Dry goods include packaging materials, advertising materials, canned/sacked/boxed/bagged raw materials, and non-perishable items." + vbCrLf + vbCrLf +
                        "WET - Wet goods include all dairy and meat products, most perishable materials, and liquids (oil not included) regardless of containers." + vbCrLf + vbCrLf +
                        "OFFICE - As the name suggests, mostly office supplies. Usage of these materials are not tracked, but deliveries of them are monitored.", "Item Type Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnShelfLifeGuide_Click(sender As Object, e As EventArgs) Handles btnShelfLifeGuide.Click
        MessageBox.Show("Shelf life is the average or standard stocking time of an item in chilled, frozen, or room temperatures in standard containers. Please consult the Product Quality Standards manual for the correct shelf life of specific items." + vbCrLf + vbCrLf +
                        "If the item type selected is DRY, it is recommended to set it to 0 unless stated otherwise in the manual." + vbCrLf + vbCrLf +
                        "If the item type selected is OFFICE, this will be automatically set to 0.", "Shelf Life Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cbxItemType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxItemType.SelectedIndexChanged
        If txtShelfLife.Enabled = False Then
            txtShelfLife.Clear()
            txtShelfLife.Enabled = True
        End If

        If cbxItemType.SelectedIndex = 2 Then
            txtShelfLife.Text = 0
            txtShelfLife.Enabled = False
        End If
    End Sub

    Private Sub cbxSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSupplier.SelectedIndexChanged
        If cbxSupplier.SelectedIndex < 2 Then
            multiplier = 1
        Else
            multiplier = 2
        End If
    End Sub
End Class