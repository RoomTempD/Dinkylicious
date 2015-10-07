Public Class PayRoll
    Inherits System.Windows.Forms.Form
    Dim CURR_DATE As Date
    Dim START_DATE As Date
    Dim END_DATE As Date
    Dim HoursForDay As Date
    Dim CurEmpTotalHours As TimeSpan
    Dim CurEmpTotalSales As Double
    Dim lstEmpNums(0) As Integer
    Dim lstEmpNumsLength As Integer = 0

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdGo = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'cmdGo
        '
        Me.cmdGo.Location = New System.Drawing.Point(408, 176)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.TabIndex = 2
        Me.cmdGo.Text = "Go"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(240, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(520, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To:"
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(184, 72)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.TabIndex = 5
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(472, 72)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.TabIndex = 6
        '
        'PayRoll
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1112, 450)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdGo)
        Me.Name = "PayRoll"
        Me.Text = "PayRoll"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub EmployeeToList(ByVal NumOfEmp As Integer)
        Dim OKtoADD As Boolean = True
        Dim i As Integer
        For i = 1 To lstEmpNumsLength
            If lstEmpNums(i) = NumOfEmp Then
                OKtoADD = False
            End If
        Next

        If OKtoADD = True Then
            lstEmpNumsLength += 1
            ReDim Preserve lstEmpNums(lstEmpNumsLength)
            lstEmpNums(lstEmpNumsLength) = NumOfEmp

        End If

    End Sub

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        START_DATE = dtpFrom.Value
        END_DATE = dtpTo.Value

        'Saved.Database_Connect()
        Saved.Emp_Open()
        Saved.EmpJob_Open()
        Saved.Jobs_Open()
        Saved.SIO_Open()
        Saved.ClosedTicket_Open()
        Saved.ClosedTableInfo_Open()

        Saved.SIORST.MoveFirst()
        Do Until Saved.SIORST.EOF
            If Saved.SIOSignInDate.Value >= START_DATE And Saved.SIOSignInDate.Value <= END_DATE Then
                EmployeeToList(Saved.SIOEmpNum.Value)
            End If
            Saved.SIORST.MoveNext()
        Loop

        Dim K As Integer
        Dim JOB As Integer

        Dim intFileNo As Integer = FreeFile()
        FileOpen(1, "print.txt", OpenMode.Output)

        PrintLine(1, "Payroll for " & Format(START_DATE, "Short Date") & " through " & Format(END_DATE, "Short Date"))
        PrintLine(1, "")

        For K = 1 To lstEmpNumsLength
            For JOB = 1 To 6
                CurEmpTotalHours = TimeSpan.Zero
                CurEmpTotalSales = 0
                Saved.EmpRST.FindFirst("EMP_NUM = " & lstEmpNums(K))
                If Saved.EmpRST.NoMatch = False Then

                    If JOB = 1 Then
                        Saved.ClosedTableInfoRST.MoveFirst()
                        Do Until Saved.ClosedTableInfoRST.EOF
                            If Saved.ClosedTableInfoDateOut.Value >= START_DATE And Saved.ClosedTableInfoDateOut.Value <= END_DATE And Saved.ClosedTableInfoEmpNum1.Value = lstEmpNums(K) Then
                                Saved.ClosedTicketRST.MoveFirst()
                                Do Until Saved.ClosedTicketRST.EOF
                                    If Saved.ClosedTicketReTable.Value = Saved.ClosedTableInfoReTable.Value Then
                                        CurEmpTotalSales = CurEmpTotalSales + Saved.ClosedTicketFoodTotal.Value
                                    End If
                                    Saved.ClosedTicketRST.MoveNext()
                                Loop
                            End If
                            Saved.ClosedTableInfoRST.MoveNext()
                        Loop
                    End If




                    Saved.SIORST.MoveFirst()
                    Do Until Saved.SIORST.EOF
                        If Saved.SIOSignInDate.Value >= START_DATE And Saved.SIOSignInDate.Value <= END_DATE Then
                            If Saved.SIOEmpNum.Value = lstEmpNums(K) And Saved.SIOJobNum.Value = JOB Then

                                Dim SignInDateTime As DateTime = Saved.SIOSignInTime.Value
                                SignInDateTime.AddHours(Format(Saved.SIOSignInTime.Value, "hh"))
                                SignInDateTime.AddMinutes(Format(Saved.SIOSignInTime.Value, "mm"))


                                Dim SignOutDateTime As DateTime = Saved.SIOSignOutTime.Value
                                SignOutDateTime.AddHours(Format(Saved.SIOSignOutTime.Value, "hh"))
                                SignOutDateTime.AddMinutes(Format(Saved.SIOSignOutTime.Value, "mm"))

                                Dim ts As New TimeSpan
                                ts = SignOutDateTime.Subtract(SignInDateTime)
                                CurEmpTotalHours = CurEmpTotalHours.Add(ts)

                                Saved.JobsRST.FindFirst("JOB_NUM = " & JOB)


                                PrintLine(1, Saved.EmpEmpName.Value & " " & Format(Saved.SIOSignInDate.Value, "Short Date") & " " & Format(Saved.SIOSignInTime.Value, "hh:mm") & " " & Format(Saved.SIOSignOutTime.Value, "hh:mm") & " " & ts.Hours.ToString & ":" & ts.Minutes.ToString)
                            End If


                        End If
                        Saved.SIORST.MoveNext()
                    Loop

                End If
                If CurEmpTotalHours.Hours.ToString > "0" Or CurEmpTotalHours.Minutes.ToString > "0" Then
                    PrintLine(1, Saved.EmpEmpName.Value & " " & Saved.JobsJobTitle.Value & " " & CurEmpTotalHours.Days.ToString * 24 + CurEmpTotalHours.Hours.ToString & ":" & CurEmpTotalHours.Minutes.ToString)

                    If JOB = 1 Then
                        PrintLine(1, Format(CurEmpTotalSales, "Currency"))
                    End If
                    PrintLine(1, "")

                End If
            Next
        Next


        FileClose(1)
        Shell("print /d:\\fireside-bar\star print.txt", AppWinStyle.Hide)






        Saved.Emp_Close()
        Saved.EmpJob_Close()
        Saved.Jobs_Close()
        Saved.SIO_Close()
        Saved.ClosedTicket_Close()
        Saved.ClosedTableInfo_Close()
        'Saved.Database_Disconnect()
    End Sub

    Private Sub dtpTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTo.ValueChanged

    End Sub

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PayRoll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
