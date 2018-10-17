Public Class Dashboard

    Public clickCounter As Integer = 0
    Dim oprTimer = 0
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Form Display Settings
        FormBorderStyle = FormBorderStyle.None
        Size = SystemInformation.PrimaryMonitorSize
        Location = New Point(0, 0)

        'Operation Timer Settings - used to enable/disable the Log Out button
        OperationTimer.Enabled = True
        oprTimer = 43190

        'Update Dashboard details on load
        Omnibus.CheckBusinessDay()
        Omnibus.UpdatePOSUsers()

        'Set details on title bars and Dashboard nameplate
        lblActiveUsername.Text = globalManagerFirstName + " " + globalManagerMiddleName + " " + globalManagerLastName
        lblFormUserSummary.Text = globalManagerFirstName + " " + globalManagerMiddleName + " " + globalManagerLastName + " (" + globalManagerEmployeeID + ")" + " - " + globalManagerPosition
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Omnibus.InitializeLogOut()
    End Sub

    Private Sub btnToggleBusinessDay_Click(sender As Object, e As EventArgs) Handles btnToggleBusinessDay.Click
        If btnToggleBusinessDay.Text = "End Business Day" Then
            Dim BusinessDayEndPrompt = MessageBox.Show("You are about to close the business day for " + DateString + ". Make sure that all reports and other necessary information have been entered into the system before closing the business day. A closed business day will no longer accept additional information input." + vbCrLf + vbCrLf + "If there are still remaining information needed to be entered, click No. Otherwise, click Yes." + vbCrLf + vbCrLf + "Are you sure you want to end the business day?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If BusinessDayEndPrompt = MsgBoxResult.Yes Then
                Omnibus.ToggleBusinessDay()
            End If
        Else
            Omnibus.ToggleBusinessDay()
        End If
    End Sub

    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        POS.Show()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Sales.Show()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Reports.Show()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Inventory.Show()
    End Sub

    Private Sub lnkRefreshUserPanel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRefreshUserPanel.LinkClicked
        Omnibus.UpdatePOSUsers()
    End Sub

    Private Sub OperationTimer_Tick(sender As Object, e As EventArgs) Handles OperationTimer.Tick
        oprTimer = oprTimer + 1
        If oprTimer >= 43200 Then
            btnClose.Enabled = True
        End If
    End Sub
End Class