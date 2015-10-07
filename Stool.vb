Public Class Stool
    Private Property StoolNumber As Integer
    Private Property Available As Boolean
    Private Property TicketNumber As Integer
    Private Property Reference As String

    Public Function getTicketNumber() As Boolean
        Return TicketNumber
    End Function

    Public Function isAvailable() As Boolean
        Return Available
    End Function

    Public Function getStoolInfo(ByVal StoolNumber As Integer) As Stool
        Dim indStool As New Stool

        Dim dsStoolInfo As DataSet = data.GetData("SELECT * FROM OPEN_STOOLINFO WHERE STOOL_NUM = " & StoolNumber)

        If dsStoolInfo.Tables(0).Rows.Count > 0 Then
            indStool.Available = dsStoolInfo.Tables(0).Rows(0).Item("AVAILABLE")
            indStool.StoolNumber = dsStoolInfo.Tables(0).Rows(0).Item("STOOL_NUM")
            indStool.TicketNumber = dsStoolInfo.Tables(0).Rows(0).Item("TICKET_NUM")
            indStool.Reference = dsStoolInfo.Tables(0).Rows(0).Item("REFERENCE")
        End If

        Return indStool
    End Function

    Public Sub CreateNewStool(ByVal StoolNumber As Integer)

        Dim indTicket As New Ticket

        indTicket.CreateNewTicket(StoolNumber)
        indTicket = indTicket.getTicketInfoByStoolNumber(StoolNumber)

        data.RunSQL("UPDATE OPEN_STOOLINFO SET AVAILABLE = FALSE, TICKET_NUM = " & indTicket.GetTicketNumber & " WHERE STOOL_NUM = " & StoolNumber)

    End Sub
End Class