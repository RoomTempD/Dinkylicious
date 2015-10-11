Public Class Table
    Private Property TableNumber As Integer
    Private Property TableName As String
    Private Property Available As Boolean
    Private Property GuestCount As Integer
    Private Property EmpNum As Integer
    Private Property EmpNum2 As Integer
    Private Property StoolNumber As Integer
    Private Property TipAtBar As String
    Private Property TicketNumber As String

    Private Property Claimable As Boolean

    Public Function getTableName() As String
        Return TableName
    End Function

    Public Function getTicketNumber() As String
        Return TicketNumber
    End Function

    Public Function isAvailable() As Boolean
        Return Available
    End Function

    Public Function isClaimable() As Boolean
        Return Claimable
    End Function

    Public Function OwnedByServer(ByVal Server As Integer) As Boolean
        Dim Owned As Boolean = False
        If EmpNum = Server Or EmpNum2 = Server Then
            Owned = True
        End If
        Return Owned
    End Function

    Public Function getTableInfo(ByVal TableNumber As Integer) As Table
        Dim indTable As New Table

        Dim dsTableInfo As DataSet = data.GetData("SELECT * FROM OPEN_TABLEINFO WHERE TABLE_NUM = " & TableNumber)

        If dsTableInfo.Tables(0).Rows.Count > 0 Then
            indTable.TableNumber = dsTableInfo.Tables(0).Rows(0).Item("TABLE_NUM")
            indTable.TableName = dsTableInfo.Tables(0).Rows(0).Item("TABLE_NAME")
            indTable.Available = dsTableInfo.Tables(0).Rows(0).Item("AVAILABLE")
            indTable.GuestCount = dsTableInfo.Tables(0).Rows(0).Item("GUEST_COUNT")
            indTable.EmpNum = dsTableInfo.Tables(0).Rows(0).Item("EMP_NUM")
            indTable.EmpNum2 = dsTableInfo.Tables(0).Rows(0).Item("EMP_NUM2")
            indTable.StoolNumber = dsTableInfo.Tables(0).Rows(0).Item("STOOL_NUM")
            indTable.TipAtBar = dsTableInfo.Tables(0).Rows(0).Item("TIP_AT_BAR")
            indTable.TicketNumber = dsTableInfo.Tables(0).Rows(0).Item("TICKET_NUM")
        End If

        indTable.Claimable = indTable.EmpNum.Equals(-5)

        Return indTable
    End Function

    'Public Sub CreateNewTable(ByVal TableNumber As Integer, Optional ByVal GuestCount As Integer = 0, Optional ByVal EmpNum As Integer = 0)

    '    Dim indTicket As New Ticket

    '    indTicket.CreateNewTicket(, TableNumber)
    '    indTicket = indTicket.getTicketInfoByTableNumber(TableNumber)

    '    data.RunSQL("UPDATE OPEN_TABLEINFO SET AVAILABLE = FALSE, TICKET_NUM = " & indTicket.GetTicketNumber & ", GUEST_COUNT = " & GuestCount & ", EMP_NUM = " & EmpNum & " WHERE TABLE_NUM = " & TableNumber)


    'End Sub
End Class
