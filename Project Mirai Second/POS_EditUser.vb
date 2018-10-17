Public Class POS_EditUser
    Public userid As String
    Public lastName As String
    Public firstName As String
    Public middleName As String
    Public employeeID As String
    Public dateHired As String
    Public username As String
    Public passcode As String
    Public position As String
    Public accessLevel As String
    Private Sub cbxLastName_CheckedChanged(sender As Object, e As EventArgs) Handles cbxLastName.CheckedChanged
        If txtLastName.Enabled = False Then
            txtLastName.Enabled = True
        Else
            txtLastName.Enabled = False
            txtLastName.Text = lastName
        End If
    End Sub

    Private Sub cbxFirstName_CheckedChanged(sender As Object, e As EventArgs) Handles cbxFirstName.CheckedChanged
        If txtFirstName.Enabled = False Then
            txtFirstName.Enabled = True
        Else
            txtFirstName.Enabled = False
            txtFirstName.Text = firstName
        End If
    End Sub

    Private Sub cbxMiddleName_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMiddleName.CheckedChanged
        If txtMiddleName.Enabled = False Then
            txtMiddleName.Enabled = True
        Else
            txtMiddleName.Enabled = False
            txtMiddleName.Text = middleName
        End If
    End Sub

    Private Sub cbxEmployeeID_CheckedChanged(sender As Object, e As EventArgs) Handles cbxEmployeeID.CheckedChanged
        If txtEmployeeID.Enabled = False Then
            txtEmployeeID.Enabled = True
        Else
            txtEmployeeID.Enabled = False
            txtEmployeeID.Text = employeeID
        End If
    End Sub

    Private Sub cbxDateHired_CheckedChanged(sender As Object, e As EventArgs) Handles cbxDateHired.CheckedChanged
        If txtDateHired.Enabled = False Then
            txtDateHired.Enabled = True
            dtpDateHired.Enabled = True
        Else
            txtDateHired.Enabled = False
            dtpDateHired.Enabled = False
            txtDateHired.Text = dateHired
        End If
    End Sub

    Private Sub cbxUsername_CheckedChanged(sender As Object, e As EventArgs) Handles cbxUsername.CheckedChanged
        If txtUsername.Enabled = False Then
            txtUsername.Enabled = True
        Else
            txtUsername.Enabled = False
            txtUsername.Text = username
        End If
    End Sub

    Private Sub cbxPasscode_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPasscode.CheckedChanged
        If txtPasscode.Enabled = False Then
            txtPasscode.Enabled = True
        Else
            txtPasscode.Enabled = False
            txtPasscode.Text = passcode
        End If
    End Sub

    Private Sub cbxPosition_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPosition.CheckedChanged
        If txtPosition.Enabled = False Then
            txtPosition.Enabled = True
            cmbxPosition.Enabled = True
        Else
            txtPosition.Enabled = False
            cmbxPosition.Enabled = False
            cmbxPosition.SelectedText = ""
            txtPosition.Text = position
            txtAccessLevel.Text = accessLevel
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub cmbxPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxPosition.SelectedIndexChanged
        Select Case cmbxPosition.SelectedIndex
            Case 0
                txtPosition.Text = "ITDEPT"
                txtAccessLevel.Text = "5"

            Case 1
                txtPosition.Text = "RGM"
                txtAccessLevel.Text = "4"

            Case 2
                txtPosition.Text = "SARM"
                txtAccessLevel.Text = "3"

            Case 3
                txtPosition.Text = "JARM"
                txtAccessLevel.Text = "2"

            Case 4
                txtPosition.Text = "MT"
                txtAccessLevel.Text = "2"

            Case 5
                txtPosition.Text = "RTM"
                txtAccessLevel.Text = "1"
        End Select
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        UpdateUserInformation()
    End Sub

    Private Sub btnRemoveUser_Click(sender As Object, e As EventArgs) Handles btnRemoveUser.Click
        Dim RemoveUserPrompt = MessageBox.Show("You are about to delete this user. This process is irreversible." + vbCrLf + vbCrLf + "Are you sure?", "Confirm Remove User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If RemoveUserPrompt = MsgBoxResult.Yes Then
            RemoveUser()
        End If
    End Sub
End Class