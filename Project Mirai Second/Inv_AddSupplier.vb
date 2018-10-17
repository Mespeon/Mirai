Public Class Inv_AddSupplier
    Private Sub btnSchedGuide_Click(sender As Object, e As EventArgs) Handles btnSchedGuide.Click
        MessageBox.Show("DAILY - supplier delivers supply and/or supplies daily to the store" + vbCrLf + vbCrLf + "SKIP - supplier delivers every other day" + vbCrLf + vbCrLf + "DEMAND - supplier only delivers on demand", "Schedule Guide", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtSupplierName.Text = "" Or txtContactNumber.Text = "" Or cbxSchedule.SelectedItem = "" Then
            lblAddSupplierWarning.Visible = True
            lblAddSupplierWarning.Text = "All fields must be filled up."
        Else
            RegisterSupplier()
        End If
    End Sub

    Private Sub btnResetForm_Click(sender As Object, e As EventArgs) Handles btnResetForm.Click
        txtSupplierName.Clear()
        txtContactNumber.Clear()
        cbxSchedule.ResetText()
        txtSupplierName.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class