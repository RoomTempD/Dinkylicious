Imports System.Collections.Generic

Public Class BarOrder
    Private OrderNumber As Integer
    Private LineNumber As Integer
    Private ItemNumber As Integer
    Private QuotedPrice As Decimal
    Private ItemName As String

    Public Function getOrderItems() As List(Of BarOrder)
        Dim tmpList As New List(Of BarOrder)

        Dim DS As DataSet = data.GetData("SELECT ORDER_NUM, LINE_NUM, OPEN_BAR_ORDER.ITEM_NUM AS ITEM_NUM, QUOTED_PRICE, RETRANS, ITEM_NAME FROM OPEN_ORDER_BAR INNER JOIN BAR_ITEM ON BAR_ITEM.ITEM_NUM = OPEN_BAR_ORDER.ITEM_NUM WHERE ORDER_NUM = " & OrderNumber)

        For Each DataRow As DataRow In DS.Tables(0).Rows
            Dim tmpItem As New BarOrder
            tmpItem.OrderNumber = DataRow("ORDER_NUM").ToString()
            tmpItem.LineNumber = DataRow("LINE_NUM").ToString()
            tmpItem.ItemNumber = DataRow("ITEM_NUM").ToString()
            tmpItem.QuotedPrice = DataRow("QUOTED_PRICE").ToString()
            tmpItem.LineNumber = DataRow("ITEM_NAME").ToString()
            tmpList.Add(tmpItem)
        Next

        Return tmpList

    End Function

    'Public Sub addItem(ByVal ItemNumber As Integer)
    '    Dim Price As Decimal
    '    Dim LineNumber As Integer

    '    Price = data.GetSingleData("SELECT ITEM_PRICE FROM BAR_ITEM WHERE ITEM_NUM = " & ItemNumber)
    '    LineNumber = data.GetNextNum("LINE_NUM")

    '    data.RunSQL("INSERT INTO OPEN_BAR_ORDER (ORDER_NUM, LINE_NUM, ITEM_NUM, QUOTED_PRICE, RETRANS) VALUES (" & OrderNumber & "," & LineNumber & "," & ItemNumber & "," & Price & ",0)")
    'End Sub

    'Public Sub removeItem(ByVal ItemNumber As Integer)
    '    data.RunSQL("DELETE FROM OPEN_BAR_ORDER WHERE LINE_NUM = " & LineNumber)
    'End Sub

End Class



