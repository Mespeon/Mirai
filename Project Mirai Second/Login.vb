Imports System.Runtime.InteropServices

Public Class Login

    Public clickCounter As Integer = 0
    Dim savedPassword As String

    ' TO SET A TEXTBOX HINT
    ' DO NOT REMOVE AND CALL ONCE ON LOAD
    <DllImport("user32.dll", charset:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Foresight.SystemCheck() ' used to check if the current system is allowed to run this program
        Hindsight.ConnectToDatabase()
        Omnibus.CheckSessions()
        FormBorderStyle = FormBorderStyle.None
        Size = SystemInformation.PrimaryMonitorSize
        Location = New Point(0, 0)
        SendMessage(Me.txtUsername.Handle, &H1501, 0, "Username / Employee ID")
        SendMessage(Me.txtPassword.Handle, &H1501, 0, "Password")
        lblDate.Text = DateString
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        If Omnibus.sessionSet = False Then
            End
        Else
            Omnibus.SuspendAdminSession()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Omnibus.InitializeLogin()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.Show()
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        txtUsername.Clear()
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        txtPassword.Clear()
    End Sub
End Class