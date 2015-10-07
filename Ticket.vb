Public Class Ticket
    Private TicketNumber As Integer
    Private GuestNumber As Integer
    Private OrderNumber As Integer
    Private DateIn As Date
    Private TimeIn As Date
    Private TipAtBar As Boolean
    Private TimeSat As Date
    Private TableNumber As Integer
    Private TippedOn As Decimal
    Private StoolNumber As Integer
    Private SubTotal As Decimal
    Private Tax As Decimal
    Private FoodTotal As Decimal
    Private BarTotal As Decimal
    Private Total As Decimal
    Private QuickSale As Boolean

    Public Function isQuickSale() As Boolean
        Return QuickSale
    End Function

    Public Sub CreateNewTicket(Optional ByVal StoolNumber As Integer = 0, Optional ByVal TableNumber As Integer = 0)

        ' Dim TableSet As Integer = Saved.GetNextNum("TableSet")
        Dim TicketNum As Integer = data.GetNextNum("TICKET_NUM")
        'will need to revisit when order is added...
        Dim OrderNum As Integer = data.GetNextNum("ORDER_NUM")

        data.RunSQL("INSERT INTO OPEN_TICKET (STOOL_NUM, TABLE_NUM, TICKET_NUM, GUEST_NUM, ORDER_NUM, TIME_IN, DATE_IN)VALUES(" & StoolNumber & "," & TableNumber & "," & TicketNum & ",1," & OrderNum & ",Now(),Now())")

    End Sub

    Private Function getTicketInfo(ByVal SQL As String) As Ticket
        Dim indTicket As New Ticket

        Dim dsTicketInfo As DataSet = data.GetData(SQL)

        If dsTicketInfo.Tables(0).Rows.Count > 0 Then
            indTicket.TicketNumber = dsTicketInfo.Tables(0).Rows(0).Item("TICKET_NUM")
            indTicket.GuestNumber = dsTicketInfo.Tables(0).Rows(0).Item("GUEST_NUM")
            indTicket.OrderNumber = dsTicketInfo.Tables(0).Rows(0).Item("ORDER_NUM")
            indTicket.DateIn = dsTicketInfo.Tables(0).Rows(0).Item("DATE_IN")
            indTicket.TimeIn = dsTicketInfo.Tables(0).Rows(0).Item("TIME_IN")
            indTicket.TipAtBar = IIf(IsDBNull(dsTicketInfo.Tables(0).Rows(0).Item("TIP_AT_BAR")), False, dsTicketInfo.Tables(0).Rows(0).Item("TIP_AT_BAR"))
            indTicket.TimeSat = IIf(IsDBNull(dsTicketInfo.Tables(0).Rows(0).Item("TIME_SAT")), DateTime.MinValue, dsTicketInfo.Tables(0).Rows(0).Item("TIME_SAT"))
            indTicket.TableNumber = dsTicketInfo.Tables(0).Rows(0).Item("TABLE_NUM")
            indTicket.TippedOn = dsTicketInfo.Tables(0).Rows(0).Item("TIPPED_ON")
            indTicket.StoolNumber = dsTicketInfo.Tables(0).Rows(0).Item("STOOL_NUM")
            indTicket.SubTotal = dsTicketInfo.Tables(0).Rows(0).Item("SUBTOTAL")
            indTicket.Tax = dsTicketInfo.Tables(0).Rows(0).Item("TAX")
            indTicket.FoodTotal = dsTicketInfo.Tables(0).Rows(0).Item("FOOD_TOTAL")
            indTicket.BarTotal = dsTicketInfo.Tables(0).Rows(0).Item("BAR_TOTAL")
            indTicket.Total = dsTicketInfo.Tables(0).Rows(0).Item("TOTAL")
        End If

        indTicket.QuickSale = indTicket.TableNumber.Equals(-99)

        Return indTicket
    End Function

    Public Function getTicketInfoByTableNumber(ByVal TableNumber As Integer) As Ticket
        Return getTicketInfo("SELECT * FROM OPEN_TICKET WHERE TABLE_NUM = " & TableNumber)
    End Function

    Public Function getTicketInfoByStoolNumber(ByVal StoolNumber As Integer) As Ticket
        Return getTicketInfo("SELECT * FROM OPEN_TICKET WHERE STOOL_NUM = " & StoolNumber)
    End Function

    Public Function getTicketInfoByTicketNumber(ByVal TicketNumber As Integer) As Ticket
        Return getTicketInfo("SELECT * FROM OPEN_TICKET WHERE TICKET_NUM = " & TicketNumber)
    End Function

    Public Function GetTicketNumber() As Integer
        Return TicketNumber
    End Function

    Public Function GetOrderNumber(ByVal TicketNumber As Integer, ByVal GuestNumber As Integer) As Integer
        Return data.GetValue("SELECT ORDER_NUM FROM OPEN_TICKET WHERE TICKET_NUM = " & TicketNumber & " AND GUEST_NUM = " & GuestNumber)
        'Return OrderNumber
    End Function

    Public Sub SeatStoolToTable(ByVal StoolNumber As Integer, ByVal TableNumber As Integer, Optional ByVal GuestCount As Integer = 0, Optional ByVal EmpNum As Integer = 0)
        'copy stool info to table
        data.RunSQL("UPDATE OPEN_TABLEINFO SET AVAILABLE = FALSE, STOOL_NUM = " & StoolNumber & ", " & "GUEST_COUNT = " & GuestCount & ", EMP_NUM = " & EmpNum & ", EMP_NUM2 = 0, TIP_AT_BAR = 'NEED' WHERE TABLE_NUM = " & TableNumber)

        'make stool available
        data.RunSQL("UPDATE OPEN_STOOLINFO SET AVAILABLE = TRUE, RETRANS = 0 WHERE STOOL_NUM = " & StoolNumber)

        'add information to ticket
        data.RunSQL("UPDATE OPEN_TICKET SET STOOL_NUM = STOOL_NUM * -1, TABLE_NUM = " & TableNumber & ", TIPPED_ON = BAR_TOTAL + FOOD_TOTAL, TIME_SAT = Now() WHERE STOOL_NUM = " & StoolNumber)
    End Sub

    Public Sub ClaimTable(ByVal TableNumber As Integer, ByVal ServerNumber As Integer)
        data.RunSQL("UPDATE OPEN_TABLEINFO SET EMP_NUM = " & ServerNumber & ", WHERE TABLE_NUM = " & TableNumber)
    End Sub

    Public Function GetTicketInfoByTicketAndGuest(ByVal TicketNumber As Integer, ByVal GuestNumber As Integer) As Integer
        Return data.GetValue("SELECT ORDER_NUM FROM OPEN_TICKET WHERE TICKET_NUM = " & TicketNumber & " AND GUEST_NUM = " & GuestNumber)
    End Function
End Class



