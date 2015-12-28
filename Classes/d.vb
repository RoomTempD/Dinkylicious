Imports System.Collections.Generic

Module d

    Public Sub CreateNewTicket(Optional ByVal StoolNumber As Integer = 0, Optional ByVal TableNumber As Integer = 0)

        ' Dim TableSet As Integer = Saved.GetNextNum("TableSet")
        Dim TicketNum As Integer = data.GetNextNum("TICKET_NUM")
        'will need to revisit when order is added...
        Dim OrderNum As Integer = data.GetNextNum("ORDER_NUM")
        Dim ReTable As Integer = data.GetNextNum("RETABLE")

        data.RunSQL("INSERT INTO OPEN_TICKET (STOOL_NUM, TABLE_NUM, TICKET_NUM, GUEST_NUM, ORDER_NUM, TIME_IN, DATE_IN, RETABLE)VALUES(" & StoolNumber & "," & TableNumber & "," & TicketNum & ",1," & OrderNum & ",Now(),Now()," & ReTable & ")")

    End Sub

    Public Sub SeatStoolToTable(ByVal StoolNumber As Integer, ByVal TableNumber As Integer, Optional ByVal GuestCount As Integer = 0, Optional ByVal EmpNum As Integer = 0)
        Dim ReTableNumber As Integer

        ReTableNumber = GetSingleValue("SELECT RETABLE FROM OPEN_STOOLINFO WHERE STOOL_NUM = " & StoolNumber)
        'If table exists, merge orders

        'copy stool info to table
        data.RunSQL("UPDATE OPEN_TABLEINFO SET AVAILABLE = FALSE, STOOL_NUM = " & StoolNumber & ", " & "GUEST_COUNT = " & GuestCount & ", EMP_NUM = " & EmpNum & ", EMP_NUM2 = 0, TIP_AT_BAR = 'NEED', RETABLE = " & ReTableNumber & " WHERE TABLE_NUM = " & TableNumber)

        'make stool available
        data.RunSQL("UPDATE OPEN_STOOLINFO SET AVAILABLE = TRUE, RETRANS = 0 WHERE STOOL_NUM = " & StoolNumber)

        'add information to ticket
        data.RunSQL("UPDATE OPEN_TICKET SET STOOL_NUM = STOOL_NUM * -1, TABLE_NUM = " & TableNumber & ", TIPPED_ON = BAR_TOTAL + FOOD_TOTAL, TIME_SAT = Now() WHERE STOOL_NUM = " & StoolNumber)
    End Sub

    Public Sub ClaimTable(ByVal TableNumber As Integer, ByVal ServerNumber As Integer)
        data.RunSQL("UPDATE OPEN_TABLEINFO SET EMP_NUM = " & ServerNumber & ", WHERE TABLE_NUM = " & TableNumber)
    End Sub


    Public Sub CreateNewTable(ByVal TableNumber As Integer, Optional ByVal GuestCount As Integer = 0, Optional ByVal EmpNum As Integer = 0)
        Dim ReTableNumber As Integer
        Dim indTicket As New Ticket

        CreateNewTicket(, TableNumber)
        indTicket = indTicket.getTicketInfoByTableNumber(TableNumber)
        ReTableNumber = GetReTableNumber(indTicket.GetTicketNumber)

        data.RunSQL("UPDATE OPEN_TABLEINFO SET AVAILABLE = FALSE, TICKET_NUM = " & indTicket.GetTicketNumber & ", GUEST_COUNT = " & GuestCount & ", EMP_NUM = " & EmpNum & ", RETABLE = " & ReTableNumber & " WHERE TABLE_NUM = " & TableNumber)


    End Sub

    Public Sub CreateNewStool(ByVal StoolNumber As Integer)
        Dim ReTableNumber As Integer
        Dim indTicket As New Ticket

        CreateNewTicket(StoolNumber)
        indTicket = indTicket.getTicketInfoByStoolNumber(StoolNumber)
        ReTableNumber = GetReTableNumber(indTicket.GetTicketNumber)

        data.RunSQL("UPDATE OPEN_STOOLINFO SET AVAILABLE = FALSE, TICKET_NUM = " & indTicket.GetTicketNumber & ", RETABLE = " & ReTableNumber & " WHERE STOOL_NUM = " & StoolNumber)

    End Sub

    Public Function GetOrderNumber(ByVal TicketNumber As Integer, ByVal GuestNumber As Integer) As Integer
        Dim OrderNumber As Integer = 0

        OrderNumber = data.GetSingleValue("SELECT ORDER_NUM FROM OPEN_TICKET WHERE TICKET_NUM = " & TicketNumber & " AND GUEST_NUM = " & GuestNumber)

        If OrderNumber = 0 Then
            OrderNumber = data.GetNextNum("ORDER_NUM")
            'insert into OPEN_TICKET 

            data.RunSQL("INSERT INTO OPEN_TICKET(TICKET_NUM, GUEST_NUM, ORDER_NUM, DATE_IN, TIME_IN, TIP_AT_BAR, TIME_SAT, TIPPED_ON, TABLE_NUM, STOOL_NUM, RETABLE) SELECT TICKET_NUM, " & GuestNumber & ", " & OrderNumber & ", DATE_IN, TIME_IN, TIP_AT_BAR, TIME_SAT, TIPPED_ON, TABLE_NUM, STOOL_NUM, RETABLE FROM (OPEN_TICKET) WHERE (TICKET_NUM) = " & TicketNumber & " AND GUEST_NUM = 1")

            'data.RunSQL("INSERT INTO OPEN_TICKET (TICKET_NUM, GUEST_NUM, ORDER_NUM)VALUES(" & TicketNumber & "," & GuestNumber & "," & OrderNumber & ")")
        End If

        Return OrderNumber
    End Function

    Public Function GetReTableNumber(ByVal TicketNumber As Integer) As Integer
        Dim ReTableNumber As Integer = 0

        ReTableNumber = data.GetSingleValue("SELECT RETABLE FROM OPEN_TICKET WHERE TICKET_NUM = " & TicketNumber)

        Return ReTableNumber
    End Function

    Public Function GetReTableNumberByOrderNumber(ByVal OrderNumber As Integer) As Integer
        Dim ReTableNumber As Integer = 0

        ReTableNumber = data.GetSingleValue("SELECT RETABLE FROM OPEN_TICKET WHERE ORDER_NUM = " & OrderNumber)

        Return ReTableNumber
    End Function

    Public Sub AddFoodItem(ByVal TicketNumber As Integer, ByVal GuestNumber As Integer, ByVal ItemNumber As Integer)
        Dim Price As Decimal
        Dim LineNumber As Integer
        Dim OrderNumber As Integer
        Dim ReTableNumber As Integer

        OrderNumber = GetOrderNumber(TicketNumber, GuestNumber)
        ReTableNumber = GetReTableNumber(TicketNumber)

        Price = data.GetSingleData("SELECT ITEM_PRICE FROM ITEM WHERE ITEM_NUM = " & ItemNumber)
        LineNumber = data.GetNextNum("LINE_NUM")

        data.RunSQL("INSERT INTO OPEN_ORDER (ORDER_NUM, LINE_NUM, ITEM_NUM, QUOTED_PRICE, RETABLE) VALUES (" & OrderNumber & "," & LineNumber & "," & ItemNumber & "," & Price & "," & ReTableNumber & ")")
    End Sub

    Public Sub RemoveFoodItem(ByVal LineNumber As Integer)
        data.RunSQL("DELETE FROM OPEN_ORDER WHERE LINE_NUM = " & LineNumber)
        'if its last one, remove order
    End Sub

    Public Sub AddBarItem(ByVal TicketNumber As Integer, ByVal GuestNumber As Integer, ByVal ItemNumber As Integer)
        Dim Price As Decimal
        Dim LineNumber As Integer
        Dim OrderNumber As Integer
        Dim ReTableNumber As Integer

        OrderNumber = GetOrderNumber(TicketNumber, GuestNumber)
        ReTableNumber = GetReTableNumber(TicketNumber)

        Price = data.GetSingleData("SELECT ITEM_PRICE FROM BAR_ITEM WHERE ITEM_NUM = " & ItemNumber)
        LineNumber = data.GetNextNum("LINE_NUM")

        data.RunSQL("INSERT INTO OPEN_BAR_ORDER (ORDER_NUM, LINE_NUM, ITEM_NUM, QUOTED_PRICE, RETABLE) VALUES (" & OrderNumber & "," & LineNumber & "," & ItemNumber & "," & Price & "," & ReTableNumber & ")")
    End Sub

    Public Sub RemoveBarItem(ByVal LineNumber As Integer)
        data.RunSQL("DELETE FROM OPEN_BAR_ORDER WHERE LINE_NUM = " & LineNumber)
    End Sub

    Public Function GetTableName(ByVal TableNumber As Integer) As String
        Return data.GetSingleData("SELECT TABLE_NAME FROM OPEN_TABLEINFO WHERE TABLE_NUM = " & TableNumber)
    End Function

    Public Function GetGuestsOfTicket(ByVal TicketNumber As Integer) As List(Of Integer)
        Dim tmpList As New List(Of Integer)

        Dim ds As DataSet
        ds = data.GetData("SELECT * FROM OPEN_TICKET WHERE TICKET_NUM = " & TicketNumber)

        For Each DataRow As DataRow In ds.Tables(0).Rows
            If DataRow("GUEST_NUM").ToString() <> "" Then
                tmpList.Add(DataRow("GUEST_NUM").ToString())
            End If
        Next


        Return tmpList
    End Function

    Public Sub UpdateOrderTotals(ByVal OrderNumber As Integer, ByRef FoodTotal As Double, ByRef BarTotal As Double, ByRef TotalTotal As Double)
        Dim SubTotal As Double = 0
        Dim Tax As Double = 0
        FoodTotal = Math.Round(data.GetSingleValue("SELECT Sum(QUOTED_PRICE) AS SumOfQUOTED_PRICE FROM OPEN_ORDER WHERE ORDER_NUM = " & OrderNumber & " GROUP BY ORDER_NUM"), 2)
        BarTotal = Math.Round(data.GetSingleValue("SELECT Sum(QUOTED_PRICE) AS SumOfQUOTED_PRICE FROM OPEN_BAR_ORDER WHERE ORDER_NUM = " & OrderNumber & " GROUP BY ORDER_NUM"), 2)
        SubTotal = Math.Round(FoodTotal + BarTotal, 2)
        Tax = Math.Round(FoodTotal * 0.055, 2)
        TotalTotal = Math.Round(SubTotal + Tax, 2)

        data.RunSQL("UPDATE OPEN_TICKET SET SUBTOTAL = " & SubTotal & ", TAX = " & Tax & ",FOOD_TOTAL = " & FoodTotal & ", BAR_TOTAL = " & BarTotal & ", TOTAL = " & TotalTotal & " WHERE ORDER_NUM = " & OrderNumber)
    End Sub

    Public Function GetTotalOwed(ByVal OrderNumber As Integer) As Double
        Return data.GetDoubleValue("SELECT TOTAL FROM OPEN_TICKET WHERE ORDER_NUM = " & OrderNumber)
    End Function

    Public Sub CloseOrder(ByVal OrderNumber As Integer, ByVal Check As Double, ByVal Cash As Double, ByVal Card As Double, ByVal GiftCert As Double, ByVal Change As Double, ByVal Tip As Double)
        Dim ReTransNumber As Integer
        Dim ReTableNumber As Integer

        ReTransNumber = GetNextNum("RETRANS")
        ReTableNumber = GetReTableNumberByOrderNumber(OrderNumber)

        data.RunSQL("INSERT INTO CLOSED_TICKET SELECT TICKET_NUM, GUEST_NUM, ORDER_NUM, DATE_IN, TIME_IN, TIP_AT_BAR, TIME_SAT, TIPPED_ON, TABLE_NUM, STOOL_NUM, SUBTOTAL, TAX, FOOD_TOTAL, BAR_TOTAL, TOTAL, 1 as [PAID], " & Check & " as [CHECK], " & Cash & " as [CASH], " & Card & " as [CARD], " & GiftCert & " as [GIFT_CERT], " & Change & " as [CHANGE], " & Tip & " as [TIP], Now() as [DATE_OUT], Now() as [TIME_OUT], " & ReTableNumber & " as [RETABLE], " & ReTransNumber & " as [RETRANS] FROM OPEN_TICKET WHERE ORDER_NUM = " & OrderNumber)

        data.RunSQL("INSERT INTO CLOSED_ORDER SELECT ORDER_NUM, LINE_NUM, ITEM_NUM, QUOTED_PRICE, " & ReTableNumber & " as [RETABLE], " & ReTransNumber & " as [RETRANS] FROM OPEN_ORDER WHERE ORDER_NUM = " & OrderNumber)

        data.RunSQL("INSERT INTO CLOSED_BAR_ORDER SELECT ORDER_NUM, LINE_NUM, ITEM_NUM, QUOTED_PRICE, " & ReTableNumber & " as [RETABLE], " & ReTransNumber & " as [RETRANS] FROM OPEN_BAR_ORDER WHERE ORDER_NUM = " & OrderNumber)

        data.RunSQL("DELETE FROM OPEN_TICKET WHERE ORDER_NUM = " & OrderNumber)
        data.RunSQL("DELETE FROM OPEN_ORDER WHERE ORDER_NUM = " & OrderNumber)
        data.RunSQL("DELETE FROM OPEN_BAR_ORDER WHERE ORDER_NUM = " & OrderNumber)

        CloseTable(ReTableNumber)
    End Sub

    Private Sub CloseTable(ByVal ReTableNumber As Integer)
        If data.GetSingleValue("SELECT COUNT(*) FROM OPEN_TICKET WHERE RETABLE = " & ReTableNumber) = 0 Then
            'data.RunSQL("INSERT INTO ORDER SELECT ORDER_NUM, LINE_NUM, ITEM_NUM, QUOTED_PRICE, " & ReTableNumber & " as [RETABLE], " & ReTransNumber & " as [RETRANS] FROM OPEN_ORDER WHERE ORDER_NUM = " & OrderNumber)
            'insert data into closed table

            'insert data into closed stool

            'reset data in open table

            'reset data in open stool

        End If

        'check to see if retable exists in open_tickets,
        'if not, insert into closedtable and closedstool
    End Sub

End Module