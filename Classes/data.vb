Module data
    Public Function ReadFromFile(ByVal FileName As String) As String
        Dim TextLine As String = ""

        If System.IO.File.Exists(FileName) = True Then
            Dim objReader As New System.IO.StreamReader(FileName)
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
            Loop
        Else
            MsgBox("File Does Not Exist")
        End If

        Return TextLine
    End Function

    Private Function GetDBConnectionString() As String
        Return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & ReadFromFile("connection.txt")
    End Function

    Public Sub SetComputerToDefault()
        Active.Computer = ReadFromFile("logon.txt")
    End Sub

    Public Sub RunSQL(ByVal SQL As String)
        Console.WriteLine(SQL)
        Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(GetDBConnectionString)
        Dim ds As New DataSet

        Connection.Open()

        Dim newcommand As New OleDb.OleDbCommand(SQL, Connection)
        newcommand.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Public Function GetData(ByVal Query As String) As DataSet
        'Console.WriteLine(Query)
        Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(GetDBConnectionString)
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter

        Connection.Open()
        da.SelectCommand = New OleDb.OleDbCommand(Query, Connection)
        Connection.Close()

        da.Fill(ds, "dbTable")
        If ds.Tables(0).Rows.Count < 1 Then
            ds.Tables(0).Rows.Add(0)
        End If

        Return ds
    End Function

    Public Function GetNextNum(ByVal Variable As String) As Integer
        RunSQL("UPDATE SAVED SET " & Variable & " = " & Variable & " + 1")
        Return GetData("SELECT " & Variable & " FROM SAVED").Tables(0).Rows(0).Item(0)
    End Function

    Public Function GetSingleValue(ByVal SQL As String) As Integer
        Return GetData(SQL).Tables(0).Rows(0).Item(0)
    End Function

    Public Function GetDoubleValue(ByVal SQL As String) As Double
        Return GetData(SQL).Tables(0).Rows(0).Item(0)
    End Function

    Public Function GetSingleData(ByVal SQL As String) As String
        Return GetData(SQL).Tables(0).Rows(0).Item(0)
    End Function

End Module
