Module Omnibus

    ' Global variables to be used for creating and recovering sessions
    Dim activeManagerUserID As String
    Dim currSessionID As String
    Public sessionSet As Boolean

    ' Global variables for session data
    Public globalManagerFirstName As String
    Public globalManagerMiddleName As String
    Public globalManagerLastName As String
    Public globalManagerEmployeeID As String
    Public globalManagerPosition As String

    ' CHECK EXISTING SESSIONS
    ' This sub is used to recover the sessions as well.
    Public Sub CheckSessions()
        ' Check the session table for SUSPENDED sessions for the current day
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        ' SQL query sequence
        sqlQuery = "SELECT * FROM local_user_session WHERE start_date = CURRENT_DATE() AND status = 'SUSPENDED' AND Terminal_ID = " + Foresight.sysid
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = sqlQuery
        sqlDataReader = sqlCommand.ExecuteReader
        sqlDataReader.Read()

        If sqlDataReader.HasRows = 0 Then
            sqlDataReader.Close()
            sqlConnection.Close()
            sqlCommand.Dispose()
            Exit Sub
        Else
            sqlDataReader.Close()   ' Close the first data reader
            sqlCommand.Dispose()    ' Dispose the first query

            ' Recover session
            Try
                sqlQuery = "SELECT * FROM local_user_session LEFT JOIN local_user_data ON local_user_data.User_ID = local_user_session.User_ID LEFT JOIN terminals ON local_user_session.Terminal_ID = terminals.Terminal_ID WHERE local_user_session.status = 'SUSPENDED' AND local_user_session.Terminal_ID = " + Foresight.sysid
                sqlCommand.CommandText = sqlQuery
                sqlDataReader = sqlCommand.ExecuteReader
                sqlDataReader.Read()

                'Capture data
                Dim activeManagerFirstName As String = sqlDataReader.Item("first_name")
                Dim activeManagerMiddleName As String = sqlDataReader.Item("middle_name")
                Dim activeManagerLastName As String = sqlDataReader.Item("last_name")
                Dim activeManagerEmployeeID As String = sqlDataReader.Item("Employee_ID")
                Dim activeManagerPosition As String = sqlDataReader.Item("employee_position")
                currSessionID = sqlDataReader.Item("Session_ID")
                Dim terminalID As String = Foresight.sysid

                'Set values to Login and Dashboard on load
                sessionSet = True
                activeManagerUserID = sqlDataReader.Item("User_ID")
                Login.lblGreeting.Visible = True
                Login.lblRecoveredSession.Visible = True
                Login.lblWindowBanner.Text = activeManagerFirstName + " " + activeManagerMiddleName + " " + activeManagerLastName

                'Push values to global session variables
                globalManagerFirstName = activeManagerFirstName
                globalManagerMiddleName = activeManagerMiddleName
                globalManagerLastName = activeManagerLastName
                globalManagerEmployeeID = activeManagerEmployeeID
                globalManagerPosition = activeManagerPosition

                sqlDataReader.Close()
                sqlConnection.Close()
                sqlCommand.Dispose()
                InitializeLogin()
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ErrorToString, "Session Recovery Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sqlConnection.Close()
            End Try
        End If
    End Sub

    ' LOGIN
    Public Sub InitializeLogin()
        Dim loginMessageCtr = 0
        If sessionSet = True Then
            Login.pnlPassword.Visible = True
            Login.pnlUsername.Visible = False
            GoTo skipUsername
        End If

        Select Case Login.clickCounter
            ' Process username (bypass this case if a session is recovered)
            Case 0
                If Login.txtUsername.Text = "" Then
                    Login.lblLoginMessage.Text = "An empty field Is not allowed."
                    Exit Sub
                Else
                    Dim usernameByUser As String = Login.txtUsername.Text

                    'Open Connection
                    If sqlConnection.State = ConnectionState.Closed Then
                        sqlConnection.Open()
                    End If

                    'Change query string
                    sqlQuery = "Select * FROM local_user_data WHERE username = '" + usernameByUser + "' OR Employee_ID = '" + usernameByUser + "'"

                    'Pass query
                    sqlCommand.Connection = sqlConnection
                    sqlCommand.CommandText = sqlQuery

                    'Activate Reader
                    sqlDataReader = sqlCommand.ExecuteReader()
                    sqlDataReader.Read()

                    If sqlDataReader.HasRows = 0 Then
                        Login.lblLoginMessage.Text = "Username / ID is not found."
                        Login.txtUsername.Clear()

                        'Close connection and reader
                        'Dispose command text
                        sqlDataReader.Close()
                        sqlConnection.Close()
                        sqlCommand.Dispose()
                        Exit Sub

                    ElseIf Not (sqlDataReader.Item("access_level") > 1) Then
                        Login.lblLoginMessage.Text = "This ID has no administrative privileges."
                        Login.txtUsername.Clear()

                        'Close connection and reader
                        'Dispose command text
                        sqlDataReader.Close()
                        sqlConnection.Close()
                        sqlCommand.Dispose()
                        Exit Sub

                    Else
                        Login.lblGreeting.Visible = True
                        Login.lblWindowBanner.Text = sqlDataReader.Item("first_name") + " " + sqlDataReader.Item("middle_name") + " " + sqlDataReader.Item("last_name")
                        Login.txtUsername.Clear()
                        Login.pnlPassword.Visible = True
                        Login.pnlUsername.Visible = False
                        Login.clickCounter += 1

                        'Close connection and reader
                        sqlDataReader.Close()
                        sqlConnection.Close()
                    End If
                End If

            ' Process password
            Case 1
skipUsername:
                If Login.txtPassword.Text = "" Then
                    Login.lblLoginMessage.Text = "An empty password field is not allowed."
                    Exit Sub
                Else
                    Dim passwordByUser As String = Login.txtPassword.Text

                    'Open connection
                    If sqlConnection.State = ConnectionState.Closed Then
                        sqlConnection.Open()
                    End If

                    'Recover password, if session is recovered
                    If sessionSet = True Then
                        sqlQuery = "SELECT passcode FROM local_user_data WHERE User_ID = '" + activeManagerUserID + "'"
                        sqlCommand.Connection = sqlConnection
                        sqlCommand.CommandText = sqlQuery
                    End If

                    'Reactivate reader
                    sqlDataReader = sqlCommand.ExecuteReader()
                    sqlDataReader.Read()

                    If passwordByUser <> sqlDataReader.Item("passcode") Then
                        Login.lblLoginMessage.Text = "Incorrect password"
                        Login.txtPassword.Clear()

                        'Close connection and reader
                        'Dispose command
                        sqlDataReader.Close()
                        sqlConnection.Close()
                        sqlCommand.Dispose()
                    Else
                        Login.txtPassword.Clear()
                        Login.lblLoginMessage.ResetText()

                        If sessionSet = False Then
                            activeManagerUserID = sqlDataReader.Item("User_ID")
                            sqlDataReader.Close()
                            SetUserSession()
                        Else
                            sqlDataReader.Close()
                            sqlCommand.Dispose()
                            ReactivateSession()
                        End If

                        Login.Hide()

                        'Close reader and connection
                        'Dispose command
                        sqlDataReader.Close()
                        sqlConnection.Close()
                        sqlCommand.Dispose()
                    End If
                End If
        End Select
    End Sub

    ' CREATE NEW SESSION (if no session for the current terminal is recovered)
    Public Sub SetUserSession()
        'Open connection
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Dim terminalID As String = Foresight.sysid

        ' Push data into session table
        Try
            'Open connection
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            'Set Query
            sqlQuery = "INSERT INTO local_user_session(User_ID, start_time, start_date, Terminal_ID) VALUES(" + activeManagerUserID + ", CURRENT_TIME(), CURRENT_DATE(), " + terminalID + ")"

            'Pass query to command
            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            'Execute query
            sqlCommand.ExecuteNonQuery()

            'Change sessionSet to TRUE
            sessionSet = True

            'Close reader and dispose command
            sqlCommand.Dispose()
            sqlDataReader.Close()

            ' Fetch latest session added from session table
            Try
                'Query String
                sqlQuery = "SELECT * FROM local_user_session LEFT JOIN local_user_data ON local_user_data.User_ID = local_user_session.User_ID WHERE local_user_session.User_ID = " + activeManagerUserID + " AND local_user_session.start_date = CURRENT_DATE()"

                'Pass query to command
                sqlCommand.Connection = sqlConnection
                sqlCommand.CommandText = sqlQuery

                'Activate data reader
                sqlDataReader = sqlCommand.ExecuteReader
                sqlDataReader.Read()

                'Push values to global session variables
                currSessionID = sqlDataReader.Item("Session_ID")
                globalManagerFirstName = sqlDataReader.Item("first_name")
                globalManagerMiddleName = sqlDataReader.Item("middle_name")
                globalManagerLastName = sqlDataReader.Item("last_name")
                globalManagerEmployeeID = sqlDataReader.Item("Employee_ID")
                globalManagerPosition = sqlDataReader.Item("employee_position")

                'Close connection and data reader and dispose command
                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()

                'Show Dashboard
                Dashboard.Show()
            Catch ex As Exception
                MessageBox.Show(ErrorToString, "Get User Data Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sqlConnection.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Set Session Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    ' SUSPEND ADMIN SESSION (applicable only to ADMIN terminal)
    Public Sub SuspendAdminSession()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        If sqlDataReader.IsClosed = False Then
            sqlDataReader.Close()
        End If

        ' Suspends admin session if Dashboard or admin program is forcibly closed
        Try
            sqlQuery = "UPDATE local_user_session SET status = 'SUSPENDED' WHERE start_date = CURRENT_DATE() AND User_ID = " + activeManagerUserID
            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery
            sqlCommand.ExecuteNonQuery()
            sqlConnection.Close()
            sqlCommand.Dispose()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Suspend Session Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' REACTIVATE SESSION
    Public Sub ReactivateSession()
        Try
            ' Open connection
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' Set query
            sqlQuery = "UPDATE local_user_session SET status = 'ACTIVE' WHERE User_ID = " + activeManagerUserID + " AND start_date = CURRENT_DATE() AND status = 'SUSPENDED'" + " AND Terminal_ID = " + Foresight.sysid

            'Pass command
            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            'Execute query
            sqlCommand.ExecuteNonQuery()

            'Close and dispose
            sqlCommand.Dispose()
            sqlConnection.Close()

            'Show Dashboard
            Dashboard.Show()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Reactivate Session Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    ' LOG OUT
    Public Sub InitializeLogOut()
        Dim prompt = MessageBox.Show("Logging out will end the business day. Are you sure?", "Notice", MessageBoxButtons.YesNo)

        If prompt = MsgBoxResult.Yes Then
            Dashboard.Close()
            Login.Refresh()
            Login.Show()
        End If

    End Sub

    ' CHECK BUSINESS DAY
    Public BusinessDayStarted As Boolean = False    ' By default, this is false. Set to True once Business Day is started.
    Public Sub CheckBusinessDay()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        If sqlDataReader.IsClosed = False Then
            sqlDataReader.Close()
        End If

        Try
            ' Query Business Day Today
            sqlQuery = "SELECT * FROM local_business_day WHERE start_date = CURRENT_DATE() AND status = 'OPEN'"

            ' Pass Query and Connection
            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            ' Activate Reader
            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            ' Set messages to display if a business day is present or is not yet started
            If sqlDataReader.HasRows = 0 Then
                Dashboard.lblBusinessDateNotification.Text = "Business Day is not yet started."
                Dashboard.lblBusinessDateNotification.ForeColor = Color.Crimson
                Dashboard.btnToggleBusinessDay.Text = "Start Business Day"
            Else
                Dashboard.lblBusinessDateNotification.Text = "Current Business Date: " + sqlDataReader.Item("start_date")
                Dashboard.lblBusinessDateNotification.ForeColor = Color.FromArgb(64, 64, 64)
                Dashboard.btnToggleBusinessDay.Text = "End Business Day"
            End If

            ' Program will execute this block if the business day button is clicked twice
            If Dashboard.clickCounter >= 2 Then
                Dashboard.lblBusinessDateNotification.Text = "Business Day has been closed."
                Dashboard.lblBusinessDateNotification.ForeColor = Color.Crimson
                Dashboard.btnToggleBusinessDay.Visible = False
            End If
            ' Close connection and reader, dispose command
            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Business Day Read Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    ' START/END BUSINESS DAY
    Public Sub ToggleBusinessDay()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        If Dashboard.btnToggleBusinessDay.Text = "Start Business Day" Then
            Try
                ' Push business day data into table
                sqlQuery = "INSERT INTO local_business_day(Session_ID, start_date, start_time, status) VALUES (" + currSessionID + ", CURRENT_DATE(), CURRENT_TIME(), 'OPEN')"

                ' Pass Query and Connection
                sqlCommand.Connection = sqlConnection
                sqlCommand.CommandText = sqlQuery

                ' Push query
                sqlCommand.ExecuteNonQuery()

                ' Set Business Day to True
                BusinessDayStarted = True

                ' Close connection and reader, dispose command
                sqlCommand.Dispose()
                sqlConnection.Close()

                ' Increment business day button click counter by 1
                Dashboard.clickCounter += 1

                ' Display message box for confirmation
                MessageBox.Show("Business day for " + DateString + " is successfully started as of " + TimeOfDay + ".", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Call Check Business Day
                CheckBusinessDay()

            Catch ex As Exception
                MessageBox.Show(ErrorToString, "Business Day Write Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sqlConnection.Close()
            End Try

        Else
            Try
                ' Update business day data from table
                sqlQuery = "UPDATE local_business_day SET end_date = CURRENT_DATE(), end_time = CURRENT_TIME(), status = 'CLOSED' WHERE start_date = CURRENT_DATE()"

                ' Pass Query and Connection
                sqlCommand.Connection = sqlConnection
                sqlCommand.CommandText = sqlQuery

                ' Push query
                sqlCommand.ExecuteNonQuery()

                ' Set Business Day to False
                BusinessDayStarted = False

                ' Close connection and reader, dispose command
                sqlCommand.Dispose()
                sqlConnection.Close()

                ' Increment business day button click counter by 1
                Dashboard.clickCounter += 1

                ' Display message box for confirmation
                MessageBox.Show("Business day for " + DateString + " is successfully closed as of " + TimeOfDay + ".", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Call Check Business Day
                CheckBusinessDay()

            Catch ex As Exception
                MessageBox.Show(ErrorToString, "Business Day Write Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sqlConnection.Close()
            End Try
        End If
    End Sub


    ' CHECK POS USERS
    Public Sub UpdatePOSUsers()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        If sqlDataReader.IsClosed = False Then
            sqlDataReader.Close()
        End If

        ' Set new SQL command
        sqlQuery = "SELECT *, local_user_data.first_name, local_user_data.last_name FROM local_user_session INNER JOIN local_user_data ON local_user_session.User_ID = local_user_data.User_ID WHERE local_user_session.start_date = CURRENT_DATE() AND local_user_session.status = 'ACTIVE' AND local_user_session.Terminal_ID != 1"

        ' Push command
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = sqlQuery

        ' Activate reader
        sqlDataReader = sqlCommand.ExecuteReader
        sqlDataReader.Read()

        If sqlDataReader.HasRows = 0 Then
            Dashboard.lblPOS1User.Text = "No User"
            Dashboard.lblPOS2User.Text = "No User"
            Dashboard.lblPOS3User.Text = "No User"
            Dashboard.lblPOS4User.Text = "No User"
            Dashboard.lblPOS5User.Text = "No User"
            Dashboard.lblPOS6User.Text = "No User"
            sqlDataReader.Close()
            sqlConnection.Close()
            sqlCommand.Dispose()
            Exit Sub
        Else
            Dim posNumberOnSession = sqlDataReader.Item("Terminal_ID")
            Dim posSessionStatus = sqlDataReader.Item("status")

            Select Case posNumberOnSession
                Case 2
                    If posSessionStatus = "SUSPENDED" Then
                        Dashboard.lblPOS1User.Text = "No User"
                    Else
                        Dashboard.lblPOS1User.Text = sqlDataReader.Item("first_name") + " " + sqlDataReader.Item("last_name")
                        Dashboard.lblPOS1Status.Text = "ONLINE"
                        Dashboard.lblPOS1Status.BackColor = Color.LimeGreen
                    End If
                Case 3
                    If posSessionStatus = "SUSPENDED" Then
                        Dashboard.lblPOS2User.Text = "No User"
                    Else
                        Dashboard.lblPOS2User.Text = sqlDataReader.Item("first_name") + " " + sqlDataReader.Item("last_name")
                        Dashboard.lblPOS2Status.Text = "ONLINE"
                        Dashboard.lblPOS2Status.BackColor = Color.LimeGreen
                    End If
                Case 4
                    If posSessionStatus = "SUSPENDED" Then
                        Dashboard.lblPOS3User.Text = "No User"
                    Else
                        Dashboard.lblPOS3User.Text = sqlDataReader.Item("first_name") + " " + sqlDataReader.Item("last_name")
                        Dashboard.lblPOS3Status.Text = "ONLINE"
                        Dashboard.lblPOS3Status.BackColor = Color.LimeGreen
                    End If
                Case 5
                    If posSessionStatus = "SUSPENDED" Then
                        Dashboard.lblPOS4User.Text = "No User"
                    Else
                        Dashboard.lblPOS4User.Text = sqlDataReader.Item("first_name") + " " + sqlDataReader.Item("last_name")
                        Dashboard.lblPOS4Status.Text = "ONLINE"
                        Dashboard.lblPOS4Status.BackColor = Color.LimeGreen
                    End If
                Case 6
                    If posSessionStatus = "SUSPENDED" Then
                        Dashboard.lblPOS5User.Text = "No User"
                    Else
                        Dashboard.lblPOS5User.Text = sqlDataReader.Item("first_name") + " " + sqlDataReader.Item("last_name")
                        Dashboard.lblPOS5Status.Text = "ONLINE"
                        Dashboard.lblPOS5Status.BackColor = Color.LimeGreen
                    End If
                Case 7
                    If posSessionStatus = "SUSPENDED" Then
                        Dashboard.lblPOS6User.Text = "No User"
                    Else
                        Dashboard.lblPOS6User.Text = sqlDataReader.Item("first_name") + " " + sqlDataReader.Item("last_name")
                        Dashboard.lblPOS6Status.Text = "ONLINE"
                        Dashboard.lblPOS6Status.BackColor = Color.LimeGreen
                    End If
            End Select
        End If
    End Sub

    ' CHECK USER INPUT
    Public Sub CheckRegistrationForm()
        If POS_AddUser.txtEmployeeID.Text = "" Or POS_AddUser.txtLastName.Text = "" Or POS_AddUser.txtFirstName.Text = "" Or POS_AddUser.txtMiddleName.Text = "" Or POS_AddUser.txtUsername.Text = "" Or POS_AddUser.txtPassword.Text = "" Or POS_AddUser.txtConfirmPassword.Text = "" Then
            MessageBox.Show("All fields are required. Please fill up all the blank fields in order to complete the registration.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If POS_AddUser.txtPassword.Text <> POS_AddUser.txtConfirmPassword.Text Then
                MessageBox.Show("Passwords do not match.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                RegisterUser()
            End If
        End If
    End Sub

    ' ADD USER
    Public Sub RegisterUser()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            Dim employeeIDByUser As String = POS_AddUser.txtEmployeeID.Text
            Dim lastnameByUser As String = POS_AddUser.txtLastName.Text
            Dim firstnameByUser As String = POS_AddUser.txtFirstName.Text
            Dim middlenameByUser As String = POS_AddUser.txtMiddleName.Text
            Dim usernameByUser As String = POS_AddUser.txtUsername.Text
            Dim passcodeByUser As String = POS_AddUser.txtPassword.Text
            Dim positionByUser As String = POS_AddUser.cbxPosition.SelectedItem
            Dim accesslevelByUser As String = POS_AddUser.cbxAccessLevel.SelectedItem

            sqlQuery = "INSERT INTO local_user_data(Employee_ID, last_name, first_name, middle_name, username, passcode, employee_position, access_level) VALUES(" + employeeIDByUser + ", '" + lastnameByUser + "', '" + firstnameByUser + "', '" + middlenameByUser + "', '" + usernameByUser + "', '" + passcodeByUser + "', '" + positionByUser + "', " + accesslevelByUser + ")"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlCommand.ExecuteNonQuery()

            MessageBox.Show("User registration is successful.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

            sqlCommand.Dispose()
            sqlConnection.Close()

            POS_AddUser.Close()
            GetUserList()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    ' UPDATE USER
    Public Sub UpdateUserInformation()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            Dim lastNameByUser As String = POS_EditUser.txtLastName.Text
            Dim firstNameByUser As String = POS_EditUser.txtFirstName.Text
            Dim middleNameByUser As String = POS_EditUser.txtMiddleName.Text
            Dim employeeIdByUser As String = POS_EditUser.txtEmployeeID.Text
            'Dim dateHiredByUser As Date = POS_EditUser.txtDateHired.Text
            Dim usernameByUser As String = POS_EditUser.txtUsername.Text
            Dim passcodeByUser As String = POS_EditUser.txtPasscode.Text
            Dim positionByUser As String = POS_EditUser.txtPosition.Text
            Dim accesslevelByUser As String = POS_EditUser.txtAccessLevel.Text

            sqlQuery = "UPDATE local_user_data SET last_name = '" + lastNameByUser + "', first_name = '" + firstNameByUser + "', middle_name = '" + middleNameByUser + "', Employee_ID = '" + employeeIdByUser + "', username = '" + usernameByUser + "', passcode = '" + passcodeByUser + "', employee_position = '" + positionByUser + "', access_level = '" + accesslevelByUser + "' WHERE User_ID = '" + POS_EditUser.userid + "'"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlCommand.ExecuteNonQuery()

            MessageBox.Show("Update is successful.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

            sqlCommand.Dispose()
            sqlConnection.Close()

            POS_EditUser.Close()
            GetUserList()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Failed to update user information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    ' REMOVE USER
    Public Sub RemoveUser()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlQuery = "DELETE FROM local_user_data WHERE User_ID = '" + POS_EditUser.userid + "'"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlCommand.ExecuteNonQuery()

            MessageBox.Show("User is successfully removed.", "Remove User", MessageBoxButtons.OK, MessageBoxIcon.Information)

            sqlCommand.Dispose()
            sqlConnection.Close()

            POS_EditUser.Close()
            GetUserList()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Failed to remove user", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    ' GET USER LIST
    Public Sub GetUserList()
        POS.lsvUserSearch.Items.Clear()

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlQuery = "SELECT * FROM local_user_data"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader

            While sqlDataReader.Read()
                Dim newItem As ListViewItem
                newItem = POS.lsvUserSearch.Items.Add(sqlDataReader("last_name"))
                newItem.SubItems.Add(sqlDataReader("first_name"))
                newItem.SubItems.Add(sqlDataReader("middle_name"))
                newItem.SubItems.Add(sqlDataReader("Employee_ID"))
                newItem.SubItems.Add(sqlDataReader("date_hired".ToString))
            End While

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Fetch User List Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub SearchUser()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            Dim searchFor As String = POS.txtUserSearchBox.Text
            sqlQuery = "SELECT * FROM local_user_data WHERE last_name LIKE '" + searchFor + "' OR first_name LIKE '" + searchFor + "' OR middle_name LIKE '" + searchFor + "' OR Employee_ID LIKE '" + searchFor + "'"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then
                POS.lsvUserSearch.Items.Clear()
                Dim newItem As ListViewItem
                newItem = POS.lsvUserSearch.Items.Add(sqlDataReader("last_name"))
                newItem.SubItems.Add(sqlDataReader("first_name"))
                newItem.SubItems.Add(sqlDataReader("middle_name"))
                newItem.SubItems.Add(sqlDataReader("Employee_ID"))
                newItem.SubItems.Add(sqlDataReader("date_hired".ToString))
            Else
                POS.lblNoUser.Visible = True
                POS.lsvUserSearch.Items.Clear()
            End If

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Failed to search for user", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub GetTransactionList()
        POS.lsvTransactionList.Items.Clear()

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            'sqlQuery = "Select Terminal_ID, transaction_number, transaction_gross_amount, transaction_net_amount, transaction_type, transaction_date, transaction_time FROM local_transactions WHERE transaction_date = CURRENT_DATE()"
            sqlQuery = "SELECT * FROM local_transactions LEFT JOIN local_saved_orders ON local_transactions.Order_ID = local_saved_orders.Order_ID WHERE local_transactions.transaction_date = CURRENT_DATE()"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader

            While sqlDataReader.Read()
                Dim newItem As ListViewItem
                Dim time As TimeSpan = sqlDataReader.Item("transaction_time")
                newItem = POS.lsvTransactionList.Items.Add(sqlDataReader("transaction_number"))
                newItem.SubItems.Add(sqlDataReader("Terminal_ID"))
                newItem.SubItems.Add(sqlDataReader("order_totalAmt"))
                newItem.SubItems.Add(sqlDataReader("transaction_type"))
                newItem.SubItems.Add(sqlDataReader("transaction_date"))
                newItem.SubItems.Add(time.ToString)
            End While

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Fetch Transaction List Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    ' ADD SUPPLIER
    Public Sub RegisterSupplier()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            ' Catch details from form
            Dim supplierNameByUser As String = Inv_AddSupplier.txtSupplierName.Text
            Dim supplierContactNumByUser As String = Inv_AddSupplier.txtContactNumber.Text
            Dim supplierScheduleByUser As String = Inv_AddSupplier.cbxSchedule.SelectedItem

            sqlQuery = "INSERT INTO local_supplier(supplier_name, supplier_contact_number, supplier_schedule) VALUES('" + supplierNameByUser + "', '" + supplierContactNumByUser + "', '" + supplierScheduleByUser + "')"

            sqlCommand.CommandText = sqlQuery
            sqlCommand.Connection = sqlConnection

            sqlCommand.ExecuteNonQuery()

            MessageBox.Show("Supplier has been successfully added.", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information)

            sqlCommand.Dispose()
            sqlConnection.Close()

            Inv_AddSupplier.Close()
            GetInventoryList()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Register Supplier Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub GetInventoryList()
        Inventory.lsvInventoryList.Items.Clear()

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        ' Get raw material's data
        Try
            sqlQuery = "SELECT * FROM local_inventory LEFT JOIN local_supplier ON local_supplier.Supplier_ID = local_inventory.Supplier_ID"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader

            While sqlDataReader.Read()
                Dim newItem As ListViewItem
                newItem = Inventory.lsvInventoryList.Items.Add(sqlDataReader("item_name"))
                newItem.SubItems.Add(sqlDataReader("supplier_name"))
                newItem.SubItems.Add(sqlDataReader("item_type"))
                newItem.SubItems.Add(sqlDataReader("item_inStock_amt"))
                newItem.SubItems.Add(sqlDataReader("item_inStock_packQty"))
                newItem.SubItems.Add(sqlDataReader("item_inStock_multiplier"))
                newItem.SubItems.Add(sqlDataReader("item_last_DeliveryDate"))
                newItem.SubItems.Add(sqlDataReader("item_last_UseBeforeDate"))
            End While

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Retrieve Inventory List Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub GetSuppliersList()
        Inv_AddInventory.cbxSupplier.Items.Clear()

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        ' Get suppliers list
        Try
            sqlQuery = "SELECT supplier_name FROM local_supplier"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader

            While sqlDataReader.Read
                Inv_AddInventory.cbxSupplier.Items.Add(sqlDataReader.Item("supplier_name"))
            End While

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Failed to retrieve suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub AddInventoryItem()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        ' Push data into database
        Try
            ' Data from form
            Dim supplierByUser As String = Inv_AddInventory.cbxSupplier.SelectedIndex + Inv_AddInventory.multiplier
            Dim itemnameByUser As String = Inv_AddInventory.txtItemName.Text
            Dim qtymultiplierByUser As String = Inv_AddInventory.txtItemQtyMultiplier.Text
            Dim itemtypeByUser As String = Inv_AddInventory.cbxItemType.SelectedItem
            Dim shelflifeByUser As String = Inv_AddInventory.txtShelfLife.Text
            Dim unitpriceByUser As String = Inv_AddInventory.txtItemUnitPrice.Text
            Dim initialstockByUser As String = Inv_AddInventory.txtInitialStock.Text    ' this is initial stock by the shipped container 
            Dim actualstockcount As String = Val(initialstockByUser) * Val(qtymultiplierByUser)     ' this is the actual stock count by piece

            ' Prepare push
            sqlQuery = "INSERT INTO local_inventory (Supplier_ID, item_name, item_type, item_shelf_life, item_inStock_amt, item_inStock_packQty, item_inStock_multiplier, item_price, item_last_DeliveryDate, item_last_UseBeforeDate) VALUES('" + supplierByUser + "', '" + itemnameByUser + "', '" + itemtypeByUser + "', '" + shelflifeByUser + "', " + actualstockcount + ", '" + initialstockByUser + "', '" + qtymultiplierByUser + "', '" + unitpriceByUser + "', CURRENT_DATE(), CURRENT_DATE())"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlCommand.ExecuteNonQuery()

            MessageBox.Show("Inventory item has been successfully added.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

            sqlCommand.Dispose()
            sqlConnection.Close()

            GetInventoryList()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Failed to add new inventory item", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub GetItemList()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader

            If Inv_Transfers.cbxTransferItem.SelectedItem = "" Then
                While sqlDataReader.Read()
                    Inv_Transfers.cbxTransferItem.Items.Add(sqlDataReader.Item("item_name"))
                End While
            End If

            If Inv_Transfers.cbxTransferItem.SelectedItem <> "" Then
                sqlDataReader.Read()
                Inv_Transfers.txtQtyOnHand.Text = sqlDataReader.Item("item_inStock_amt")
                Inv_Transfers.selectedItemID = sqlDataReader.Item("RawItem_ID")
                Inv_Transfers.qtyMultiplier = sqlDataReader.Item("item_inStock_multiplier")
            End If

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Failed to retrieve item list", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub ProcessInventoryListViews()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader

            If Inventory.rbSupplier.Checked Then
                While sqlDataReader.Read()
                    Dim newItem As ListViewItem
                    newItem = Inventory.lsvInventoryList.Items.Add(sqlDataReader("supplier_name"))
                    newItem.SubItems.Add(sqlDataReader("supplier_contact_number"))
                    newItem.SubItems.Add(sqlDataReader("supplier_schedule"))
                End While
            End If

            If Inventory.rbStockMovements.Checked Then
                While sqlDataReader.Read()
                    Dim newItem As ListViewItem
                    newItem = Inventory.lsvInventoryList.Items.Add(sqlDataReader("item_name"))
                    newItem.SubItems.Add(sqlDataReader("qty_received"))
                    newItem.SubItems.Add(sqlDataReader("acquisition_method"))
                End While
            End If

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Failed to retrieve supplier list", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlCommand.Dispose()
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub ProcessTransferItems()
        ' Capture current item row data
        ' then push to stock movement table
        Dim itemName As String
        Dim direction As String
        Dim onHand As String
        Dim qtyForTransfer As String
        Dim qtyAfterTransfer As String
        Try
            MessageBox.Show("Capturing updated inventory data ...", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim row As Integer = 1
            Dim col As Integer = 1

            For Each item As ListViewItem In Inv_Transfers.lsvTransferItems.Items
                For i As Integer = 0 To item.SubItems.Count - 1
                    itemName = item.SubItems(0).Text
                    direction = item.SubItems(1).Text
                    onHand = item.SubItems(2).Text
                    qtyForTransfer = item.SubItems(3).Text
                    qtyAfterTransfer = item.SubItems(4).Text
                    col = col + 1
                Next
                row += 1
                col = 1
            Next
            MessageBox.Show("Pushing newly updated inventory data into database ...", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' Push to local_stock_movement table
            Try
                Dim itemID As String
                ' First get the item ID of the current selected item by performing a SELECT
                sqlQuery = "SELECT RawItem_ID FROM local_inventory WHERE item_name = '" + itemName + "'"

                sqlCommand.Connection = sqlConnection
                sqlCommand.CommandText = sqlQuery

                sqlDataReader = sqlCommand.ExecuteReader
                sqlDataReader.Read()

                itemID = sqlDataReader.Item("RawItem_ID")

                ' Dispose first command and close reader
                sqlCommand.Dispose()
                sqlDataReader.Close()

                ' Prepare INSERT now that a row lock is possible
                Dim acquisitionMethod As String
                If Inv_Transfers.rbTransIn.Checked Then
                    acquisitionMethod = "TRANSIN"
                End If

                If Inv_Transfers.rbTransOut.Checked Then
                    acquisitionMethod = "TRANSOUT"
                End If

                sqlQuery = "INSERT INTO local_stock_movement(RawItem_ID, qty_received, acquisition_method) VALUES('" + itemID + "', '" + qtyForTransfer + "', '" + acquisitionMethod + "')"

                sqlCommand.Connection = sqlConnection
                sqlCommand.CommandText = sqlQuery

                sqlCommand.ExecuteNonQuery()
                sqlCommand.Dispose()

                ' Prepare UPDATE
                Dim packsInHand As String = Inv_Transfers.remainingOnHand / Inv_Transfers.qtyMultiplier
                sqlQuery = "UPDATE local_inventory SET item_inStock_amt = '" + Inv_Transfers.remainingOnHand + "', item_inStock_packQty = '" + packsInHand + "' WHERE RawItem_ID = '" + itemID + "'"

                sqlCommand.Connection = sqlConnection
                sqlCommand.CommandText = sqlQuery

                sqlCommand.ExecuteNonQuery()
                sqlCommand.Dispose()

                MessageBox.Show("Inventory successfully updated. Please make sure that a report is exported before closing this window.", "Update Stock Movement Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                sqlConnection.Close()
                GetInventoryList()
            Catch ex As Exception
                MessageBox.Show(ErrorToString, "Failed to write data into database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Failed to capture data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Module
