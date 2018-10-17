Imports System.Xml
Module Foresight
    Public sysid As String
    Sub SystemCheck()
        ' Parse systeminfo XML (used to check whether the terminal being used is allowed to run the program being run)
        Dim xmlreader As XmlTextReader
        Try
            xmlreader = New XmlTextReader("C:\Mirai\mirai_systeminfo.xml")
            xmlreader.WhitespaceHandling = WhitespaceHandling.None
            xmlreader.Read()    ' Advance to terminal tag
            xmlreader.Read()    ' Advance from terminal to name tag
            sysid = xmlreader.ReadElementString("id")
            Dim sysname As String = xmlreader.ReadElementString("name")
            Dim sysclass As String = xmlreader.ReadElementString("class")
            xmlreader.Close()

            If sysclass <> "ADMIN" Then
                MessageBox.Show("Terminal " + sysname + " is not allowed to run the Administrator program due to restricted permissions. Program will now shutdown.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End
            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString() + vbCr + vbCr + "Contact Helpdesk for assistance in this matter.", "System Check Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub
End Module
