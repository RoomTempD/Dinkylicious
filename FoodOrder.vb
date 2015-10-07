Imports System.Collections.Generic

Public Class FoodOrder
    Private OrderNumber As Integer
    Private LineNumber As Integer
    Private ItemNumber As Integer
    Private QuotedPrice As Decimal
    Private ItemName As String

    Public Function getOrderItems(ByVal OrderNumber As Integer) As List(Of FoodOrder)
        Dim tmpList As New List(Of FoodOrder)

        Dim DS As DataSet = data.GetData("SELECT ORDER_NUM, LINE_NUM, OPEN_ORDER.ITEM_NUM AS ITEM_NUM, QUOTED_PRICE, RETRANS, ITEM_NAME FROM OPEN_ORDER INNER JOIN ITEM ON ITEM.ITEM_NUM = OPEN_ORDER.ITEM_NUM WHERE ORDER_NUM = " & OrderNumber)

        For Each DataRow As DataRow In DS.Tables(0).Rows
            Dim tmpItem As New FoodOrder
            tmpItem.OrderNumber = DataRow("ORDER_NUM").ToString()
            tmpItem.LineNumber = DataRow("LINE_NUM").ToString()
            tmpItem.ItemNumber = DataRow("ITEM_NUM").ToString()
            tmpItem.QuotedPrice = DataRow("QUOTED_PRICE").ToString()
            tmpItem.LineNumber = DataRow("ITEM_NAME").ToString()
            tmpList.Add(tmpItem)
        Next

        Return tmpList

    End Function

    Public Sub addItem(ByVal TicketNumber As Integer, ByVal GuestNumber As Integer, ByVal ItemNumber As Integer)
        Dim Price As Decimal
        Dim LineNumber As Integer

        If OrderNumber = 0 Then
            'insert into ticket
        End If

        Price = data.GetSingleData("SELECT ITEM_PRICE FROM ITEM WHERE ITEM_NUM = " & ItemNumber)
        LineNumber = data.GetNextNum("LINE_NUM")

        data.RunSQL("INSERT INTO OPEN_ORDER (ORDER_NUM, LINE_NUM, ITEM_NUM, QUOTED_PRICE, RETRANS) VALUES (" & OrderNumber & "," & LineNumber & "," & ItemNumber & "," & Price & ",0)")
    End Sub

    Public Sub removeItem(ByVal LineNumber As Integer)
        data.RunSQL("DELETE FROM OPEN_ORDER WHERE LINE_NUM = " & LineNumber)
    End Sub
   
End Class



