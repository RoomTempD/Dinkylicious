Module d

    Public Sub CreateNewTicket(Optional ByVal StoolNumber As Integer = 0, Optional ByVal TableNumber As Integer = 0)

        ' Dim TableSet As Integer = Saved.GetNextNum("TableSet")
        Dim TicketNum As Integer = data.GetNextNum("TICKET_NUM")
        'will need to revisit when order is added...
        Dim OrderNum As Integer = data.GetNextNum("ORDER_NUM")

        data.RunSQL("INSERT INTO OPEN_TICKET (STOOL_NUM, TABLE_NUM, TICKET_NUM, GUEST_NUM, ORDER_NUM, TIME_IN, DATE_IN)VALUES(" & StoolNumber & "," & TableNumber & "," & TicketNum & ",1," & OrderNum & ",Now(),Now())")

    End Sub

    Public Sub SeatStoolToTable(ByVal StoolNumber As Integer, ByVal TableNumber As Integer, Optional ByVal GuestCount As Integer = 0, Optional ByVal EmpNum As Integer = 0)

        'If table exists, merge orders

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


    Public Sub CreateNewTable(ByVal TableNumber As Integer, Optional ByVal GuestCount As Integer = 0, Optional ByVal EmpNum As Integer = 0)

        Dim indTicket As New Ticket

        CreateNewTicket(, TableNumber)
        indTicket = indTicket.getTicketInfoByTableNumber(TableNumber)

        data.RunSQL("UPDATE OPEN_TABLEINFO SET AVAILABLE = FALSE, TICKET_NUM = " & indTicket.GetTicketNumber & ", GUEST_COUNT = " & GuestCount & ", EMP_NUM = " & EmpNum & " WHERE TABLE_NUM = " & TableNumber)


    End Sub

    Public Sub CreateNewStool(ByVal StoolNumber As Integer)

        Dim indTicket As New Ticket

        CreateNewTicket(StoolNumber)
        indTicket = indTicket.getTicketInfoByStoolNumber(StoolNumber)

        data.RunSQL("UPDATE OPEN_STOOLINFO SET AVAILABLE = FALSE, TICKET_NUM = " & indTicket.GetTicketNumber & " WHERE STOOL_NUM = " & StoolNumber)

    End Sub

    Public Function GetOrderNumber(ByVal TicketNumber As Integer, ByVal GuestNumber As Integer) As Integer
        Return data.GetSingleValue("SELECT ORDER_NUM FROM OPEN_TICKET WHERE TICKET_NUM = " & TicketNumber & " AND GUEST_NUM = " & GuestNumber)
    End Function

    Public Sub AddFoodItem(ByVal TicketNumber As Integer, ByVal GuestNumber As Integer, ByVal ItemNumber As Integer)
        Dim Price As Decimal
        Dim LineNumber As Integer
        Dim OrderNumber As Integer

        OrderNumber = GetOrderNumber(TicketNumber, GuestNumber)


        If OrderNumber = 0 Then
            'insert into ticket
        End If

        Price = data.GetSingleData("SELECT ITEM_PRICE FROM ITEM WHERE ITEM_NUM = " & ItemNumber)
        LineNumber = data.GetNextNum("LINE_NUM")

        data.RunSQL("INSERT INTO OPEN_ORDER (ORDER_NUM, LINE_NUM, ITEM_NUM, QUOTED_PRICE, RETRANS) VALUES (" & OrderNumber & "," & LineNumber & "," & ItemNumber & "," & Price & ",0)")
    End Sub

    Public Sub RemoveFoodItem(ByVal LineNumber As Integer)
        data.RunSQL("DELETE FROM OPEN_ORDER WHERE LINE_NUM = " & LineNumber)
        'if its last one, remove order
    End Sub

    Public Sub AddBarItem(ByVal TicketNumber As Integer, ByVal GuestNumber As Integer, ByVal ItemNumber As Integer)
        Dim Price As Decimal
        Dim LineNumber As Integer
        Dim OrderNumber As Integer

        OrderNumber = GetOrderNumber(TicketNumber, GuestNumber)


        If OrderNumber = 0 Then
            'insert into ticket
        End If

        Price = data.GetSingleData("SELECT ITEM_PRICE FROM BAR_ITEM WHERE ITEM_NUM = " & ItemNumber)
        LineNumber = data.GetNextNum("LINE_NUM")

        data.RunSQL("INSERT INTO OPEN_BAR_ORDER (ORDER_NUM, LINE_NUM, ITEM_NUM, QUOTED_PRICE, RETRANS) VALUES (" & OrderNumber & "," & LineNumber & "," & ItemNumber & "," & Price & ",0)")
    End Sub

    Public Sub RemoveBarItem(ByVal LineNumber As Integer)
        data.RunSQL("DELETE FROM OPEN_BAR_ORDER WHERE LINE_NUM = " & LineNumber)
    End Sub

#Region "TableInfo"
    Public Function GetTableName(ByVal TableNumber As Integer) As String
        Return data.GetSingleData("SELECT TABLE_NAME FROM OPEN_TABLEINFO WHERE TABLE_NUM = " & TableNumber)
    End Function
#End Region

End Module