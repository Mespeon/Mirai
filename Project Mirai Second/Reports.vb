Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        Size = SystemInformation.PrimaryMonitorSize
        Location = New Point(0, 0)
    End Sub
End Class