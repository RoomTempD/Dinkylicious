Imports Microsoft.Office.Interop.Access
Public Class printReport
    Public Sub PrintSammys()

        Dim objAccApp As New Microsoft.Office.Interop.Access.Application() 'Instantiate Access Application Object
        MsgBox(ReadFromFile("connection.txt"))
        objAccApp.OpenCurrentDatabase("sandwhich.mdb")

        objAccApp.DoCmd.OpenReport("PRINT", AcView.acViewNormal)

        objAccApp = Nothing 'Release Resources

    End Sub
End Class