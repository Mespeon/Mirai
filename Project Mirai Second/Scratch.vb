Imports System.Xml

Public Class Scratch

    Private Sub Scratch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        Size = SystemInformation.PrimaryMonitorSize
        Location = New Point(0, 0)
        Label2.Text = Size.ToString

        ' xml parsing
        Dim xmlreader As XmlTextReader

        Try
            xmlreader = New XmlTextReader("C:\Users\Mark Nolledo\Documents\Mirai\systeminfo.xml")
            xmlreader.WhitespaceHandling = WhitespaceHandling.None
            xmlreader.Read()    ' terminal
            xmlreader.Read()    ' name
            Dim sysname As String = xmlreader.ReadElementString("name")
            Dim runAdmin As String = xmlreader.ReadElementString("runAdmin")
            Dim runPOS As String = xmlreader.ReadElementString("runPOS")
            xmlreader.Close()

            Label1.Text = sysname
            Label3.Text = runAdmin
            Label4.Text = runPOS
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class