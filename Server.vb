Imports System.Collections.Generic

Public Class Server
    Private EmployeeNumber As Integer
    Private Name As String
    Private Active As Boolean

    Public Function getServerInfo(ByVal EmployeeNumber As Integer) As Server
        Dim indObj As New Server

        Dim dsInfo As DataSet = data.GetData("SELECT * FROM EMPLOYEE WHERE EMP_NUM = " & EmployeeNumber)

        If dsInfo.Tables(0).Rows.Count > 0 Then
            indObj.EmployeeNumber = dsInfo.Tables(0).Rows(0).Item("EMP_NUM")
            indObj.Name = dsInfo.Tables(0).Rows(0).Item("EMP_NAME")
            indObj.Active = dsInfo.Tables(0).Rows(0).Item("Active")
        End If

        Return indObj
    End Function

    Function GetName(EmployeeNumber As Integer) As String
        Return data.GetSingleData("SELECT EMP_NAME FROM EMPLOYEE WHERE EMP_NUM = " & EmployeeNumber)
    End Function

    Public Function GetListOfSIServers() As List(Of Server)
        Dim tmpList As New List(Of Server)

        Dim DS As DataSet = data.GetData("SELECT * FROM SIGNINOUT WHERE SIGNOUT_TIME IS NULL AND SIGNIN_TIME IS NOT NULL AND (JOB_NUM = 1 OR JOB_NUM = 6) ORDER BY EMP_NUM")

        For Each DataRow As DataRow In DS.Tables(0).Rows
            Dim tmpItem As New Server
            tmpItem.EmployeeNumber = DataRow("EMP_NUM").ToString()
            tmpItem.Name = GetName(tmpItem.EmployeeNumber)
            tmpList.Add(tmpItem)
        Next

        Return tmpList

    End Function

    Public Function GetName() As String
        Return Name
    End Function

    Public Function GetNumber() As String
        Return EmployeeNumber
    End Function

End Class
