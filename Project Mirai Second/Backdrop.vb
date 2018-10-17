Public Class Backdrop
    Private Sub Backdrop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        Size = SystemInformation.PrimaryMonitorSize
        Location = New Point(0, 0)
        Hindsight.ConnectToDatabase()
        Login.Show()
    End Sub
End Class