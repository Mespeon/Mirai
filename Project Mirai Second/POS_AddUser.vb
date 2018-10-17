Public Class POS_AddUser
    Private Sub cbxPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPosition.SelectedIndexChanged
        If cbxPosition.SelectedIndex = 0 Then
            cbxAccessLevel.SelectedIndex = 0

        ElseIf cbxPosition.SelectedIndex = 1
            cbxAccessLevel.SelectedIndex = 1

        ElseIf cbxPosition.SelectedIndex = 2
            cbxAccessLevel.SelectedIndex = 1

        ElseIf cbxPosition.SelectedIndex = 3
            cbxAccessLevel.SelectedIndex = 2

        ElseIf cbxPosition.SelectedIndex = 4
            cbxAccessLevel.SelectedIndex = 3

        ElseIf cbxPosition.SelectedIndex = 5
            cbxAccessLevel.SelectedIndex = 4
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Omnibus.CheckRegistrationForm()
    End Sub

    Private Sub btnResetForm_Click(sender As Object, e As EventArgs) Handles btnResetForm.Click
        txtEmployeeID.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        cbxPosition.ResetText()
        cbxAccessLevel.ResetText()
    End Sub
End Class