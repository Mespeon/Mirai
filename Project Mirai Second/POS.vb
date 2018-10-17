Public Class POS

    Dim activeItemID As String
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form to display as full screen
        FormBorderStyle = FormBorderStyle.None
        Size = SystemInformation.PrimaryMonitorSize
        Location = New Point(0, 0)

        ' Get data from global variables
        lblFormUserSummary.Text = globalManagerFirstName + " " + globalManagerMiddleName + " " + globalManagerLastName + " (" + globalManagerEmployeeID + ")" + " - " + globalManagerPosition

        ' Set User ListView display settings
        lsvUserSearch.Columns.Add("Last Name", CInt(lsvUserSearch.Width / 5))
        lsvUserSearch.Columns.Add("First Name", CInt(lsvUserSearch.Width / 5))
        lsvUserSearch.Columns.Add("Middle Name", CInt(lsvUserSearch.Width / 5))
        lsvUserSearch.Columns.Add("Employee Number", CInt(lsvUserSearch.Width / 5))
        lsvUserSearch.Columns.Add("Date Hired", CInt(lsvUserSearch.Width / 5))

        ' Set Transaction ListView display settings
        lsvTransactionList.Columns.Add("Transaction Number", CInt(lsvTransactionList.Width / 6))
        lsvTransactionList.Columns.Add("Terminal ID", CInt(lsvTransactionList.Width / 6))
        lsvTransactionList.Columns.Add("Net Amount", CInt(lsvTransactionList.Width / 6))
        lsvTransactionList.Columns.Add("Type", CInt(lsvTransactionList.Width / 6))
        lsvTransactionList.Columns.Add("Date", CInt(lsvTransactionList.Width / 6))
        lsvTransactionList.Columns.Add("Time", CInt(lsvTransactionList.Width / 6))

        ' Call fetch data functions
        GetUserList()
        GetTransactionList()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        POS_AddUser.Show()
    End Sub

    Private Sub lsvTransactionList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvTransactionList.SelectedIndexChanged
        btnViewTransaction.Enabled = True
    End Sub

    Private Sub lsvUserSearch_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lsvUserSearch.ItemSelectionChanged
        btnEditUser.Enabled = True

        Dim activeItemName As String = e.Item.Text

        ' Get details based on hightlighted item
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlQuery = "SELECT * FROM local_user_data WHERE last_name = '" & activeItemName & "'"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then
                POS_EditUser.txtLastName.Text = sqlDataReader.Item("last_name")
                POS_EditUser.txtFirstName.Text = sqlDataReader.Item("first_name")
                POS_EditUser.txtMiddleName.Text = sqlDataReader.Item("middle_name")
                POS_EditUser.txtEmployeeID.Text = sqlDataReader.Item("Employee_ID")
                POS_EditUser.txtDateHired.Text = sqlDataReader.Item("date_hired".ToString)
                POS_EditUser.txtUsername.Text = sqlDataReader.Item("username")
                POS_EditUser.txtPasscode.Text = sqlDataReader.Item("passcode")
                POS_EditUser.txtPosition.Text = sqlDataReader.Item("employee_position")
                POS_EditUser.txtAccessLevel.Text = sqlDataReader.Item("access_level")

                POS_EditUser.userid = sqlDataReader.Item("User_ID")
                POS_EditUser.lastName = sqlDataReader.Item("last_name")
                POS_EditUser.firstName = sqlDataReader.Item("first_name")
                POS_EditUser.middleName = sqlDataReader.Item("middle_name")
                POS_EditUser.employeeID = sqlDataReader.Item("Employee_ID")
                POS_EditUser.dateHired = sqlDataReader.Item("date_hired".ToString)
                POS_EditUser.username = sqlDataReader.Item("username")
                POS_EditUser.passcode = sqlDataReader.Item("passcode")
                POS_EditUser.position = sqlDataReader.Item("employee_position")
                POS_EditUser.accessLevel = sqlDataReader.Item("access_level")
            Else
                MessageBox.Show(ErrorToString, "No rows found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()
            End If

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Failed to retrieve selected item", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        POS_EditUser.Show()
    End Sub

    Private Sub btnViewTransaction_Click(sender As Object, e As EventArgs) Handles btnViewTransaction.Click
        POS_TransactionDetails.Show()
    End Sub

    Private Sub txtUserSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtUserSearchBox.TextChanged
        If lblNoUser.Visible = True Then
            lblNoUser.Visible = False
        End If

        SearchUser()
    End Sub

    Private Sub btnResetList_Click(sender As Object, e As EventArgs) Handles btnResetList.Click
        txtUserSearchBox.Clear()
        lblNoUser.Visible = False
        GetUserList()
    End Sub

    Private Sub btnApplyTransSettings_Click(sender As Object, e As EventArgs) Handles btnApplyTransSettings.Click
        MessageBox.Show(dtpTransDate.Text)
    End Sub

End Class