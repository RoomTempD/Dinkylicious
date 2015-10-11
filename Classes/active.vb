Module Active
    Public Computer As String
    Public OrderType As String

    Public Job As Integer

    Public Ticket As Integer
    Public Table As Integer
    Public Stool As Integer
    Public Order As Integer
    Public Server As Integer
    Public Guest As Integer

    Public Sub Clear()
        Ticket = 0
        Table = 0
        Stool = 0
        Order = 0
        Server = 0
        Guest = 0

        If Computer = "BAR" Then
            OrderType = "Drinks"
        ElseIf Computer = "SERVER" Then
            OrderType = "Food"
        End If
    End Sub
End Module
