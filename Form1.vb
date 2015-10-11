Public Class Form1
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents cmdPOS As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdSpecial As System.Windows.Forms.Button
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents cmdLogonBar As System.Windows.Forms.Button
    Friend WithEvents cmdLogonServer As System.Windows.Forms.Button
    Friend WithEvents cmdTotal As System.Windows.Forms.Button
    Friend WithEvents cmdPayroll As System.Windows.Forms.Button
    Friend WithEvents cmdNuke As System.Windows.Forms.Button
    Friend WithEvents cmdTotals As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdPOS = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdSpecial = New System.Windows.Forms.Button()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.cmdLogonBar = New System.Windows.Forms.Button()
        Me.cmdLogonServer = New System.Windows.Forms.Button()
        Me.cmdTotal = New System.Windows.Forms.Button()
        Me.cmdPayroll = New System.Windows.Forms.Button()
        Me.cmdNuke = New System.Windows.Forms.Button()
        Me.cmdTotals = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdPOS
        '
        Me.cmdPOS.Location = New System.Drawing.Point(160, 40)
        Me.cmdPOS.Name = "cmdPOS"
        Me.cmdPOS.Size = New System.Drawing.Size(96, 64)
        Me.cmdPOS.TabIndex = 0
        Me.cmdPOS.Text = "POS"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(16, 408)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(88, 48)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "Exit"
        '
        'cmdSpecial
        '
        Me.cmdSpecial.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSpecial.Location = New System.Drawing.Point(144, 128)
        Me.cmdSpecial.Name = "cmdSpecial"
        Me.cmdSpecial.Size = New System.Drawing.Size(128, 72)
        Me.cmdSpecial.TabIndex = 5
        Me.cmdSpecial.Text = "Change Special"
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(232, 248)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(112, 56)
        Me.cmdTest.TabIndex = 4
        Me.cmdTest.Text = "test"
        '
        'cmdLogonBar
        '
        Me.cmdLogonBar.Location = New System.Drawing.Point(400, 208)
        Me.cmdLogonBar.Name = "cmdLogonBar"
        Me.cmdLogonBar.Size = New System.Drawing.Size(112, 56)
        Me.cmdLogonBar.TabIndex = 6
        Me.cmdLogonBar.Text = "Change Logon to Bar"
        Me.cmdLogonBar.Visible = False
        '
        'cmdLogonServer
        '
        Me.cmdLogonServer.Location = New System.Drawing.Point(400, 280)
        Me.cmdLogonServer.Name = "cmdLogonServer"
        Me.cmdLogonServer.Size = New System.Drawing.Size(112, 56)
        Me.cmdLogonServer.TabIndex = 7
        Me.cmdLogonServer.Text = "Change Logon to Server"
        Me.cmdLogonServer.Visible = False
        '
        'cmdTotal
        '
        Me.cmdTotal.Location = New System.Drawing.Point(568, 232)
        Me.cmdTotal.Name = "cmdTotal"
        Me.cmdTotal.Size = New System.Drawing.Size(112, 56)
        Me.cmdTotal.TabIndex = 8
        Me.cmdTotal.Text = "Get total for the night"
        Me.cmdTotal.Visible = False
        '
        'cmdPayroll
        '
        Me.cmdPayroll.Location = New System.Drawing.Point(728, 360)
        Me.cmdPayroll.Name = "cmdPayroll"
        Me.cmdPayroll.Size = New System.Drawing.Size(75, 23)
        Me.cmdPayroll.TabIndex = 9
        Me.cmdPayroll.Text = "Payroll"
        Me.cmdPayroll.Visible = False
        '
        'cmdNuke
        '
        Me.cmdNuke.Location = New System.Drawing.Point(728, 392)
        Me.cmdNuke.Name = "cmdNuke"
        Me.cmdNuke.Size = New System.Drawing.Size(75, 23)
        Me.cmdNuke.TabIndex = 10
        Me.cmdNuke.Text = "Nuke"
        Me.cmdNuke.Visible = False
        '
        'cmdTotals
        '
        Me.cmdTotals.Location = New System.Drawing.Point(728, 328)
        Me.cmdTotals.Name = "cmdTotals"
        Me.cmdTotals.Size = New System.Drawing.Size(75, 23)
        Me.cmdTotals.TabIndex = 11
        Me.cmdTotals.Text = "Totals"
        Me.cmdTotals.Visible = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(912, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdTotals)
        Me.Controls.Add(Me.cmdNuke)
        Me.Controls.Add(Me.cmdPayroll)
        Me.Controls.Add(Me.cmdTotal)
        Me.Controls.Add(Me.cmdLogonServer)
        Me.Controls.Add(Me.cmdLogonBar)
        Me.Controls.Add(Me.cmdSpecial)
        Me.Controls.Add(Me.cmdTest)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdPOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdPOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPOS.Click

        Dim form As New POS
        form.ShowDialog()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        'Dim form As New EnterGuestCount
        'form.ShowDialog()
        'If Saved.CURGUESTCOUNT = 5337 Then
        Close()
        'ElseIf Saved.CURGUESTCOUNT = 1234 Then
        '    'cmdTest.Visible = True
        '    cmdLogonBar.Visible = True
        '    cmdLogonServer.Visible = True
        '    cmdTotal.Visible = True
        '    cmdPayroll.Visible = True
        '    cmdNuke.Visible = True
        '    cmdTotals.Visible = True

        'ElseIf Saved.CURGUESTCOUNT = 4321 Then
        '    'cmdTest.Visible = False
        '    cmdLogonBar.Visible = False
        '    cmdLogonServer.Visible = False
        '    cmdTotal.Visible = False
        '    cmdPayroll.Visible = False
        '    cmdNuke.Visible = False
        '    cmdTotals.Visible = False
        'Else
        '    MsgBox("only authorized users may exit program")
        'End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        Dim FILE_NAME As String = "string.txt"
        'Dim TextLine As String
        Dim X As Integer
        Dim Y As Integer
        Dim P As Integer

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader As New System.IO.StreamWriter(FILE_NAME)
            For P = 1 To 6
                For X = 1 To 8
                    For Y = 1 To 6
                        objReader.Write("cmd0" & P & "0" & X & "0" & Y & ".click,")
                    Next Y
                Next X
            Next P
            objReader.Close()

        End If
        'Dim ANS As DialogResult
        'Dim KKKKK As Integer
        'For KKKKK = 1 To 100
        'Dim intFileNo As Integer = FreeFile()
        'FileOpen(1, "print.txt", OpenMode.Output)



        'PrintLine(1, Chr(KKKKK))





        'FileClose(1)
        'Shell("print /d:\\fireside-bar\star print.txt", AppWinStyle.Hide)
        'ANS = MsgBox("Just printed " & KKKKK & " do you want to continue?", MsgBoxStyle.YesNo)

        'If ANS = vbYes Then
        'Else
        'KKKKK = 100
        'End If

        'Next KKKKK




    End Sub

    Private Sub cmdSpecial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSpecial.Click
        Dim form As New PickSpecial
        form.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FILE_NAME As String = "logon.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            Do While objReader.Peek() <> -1
                Active.Computer = objReader.ReadLine()
            Loop

        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogonBar.Click
        Active.Computer = "BAR"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogonServer.Click
        Active.Computer = "SERVER"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTotal.Click
        Dim form As New EndOfDay
        form.Show()
    End Sub

    Private Sub cmdPayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPayroll.Click
        Dim form As New PayRoll
        form.Show()
    End Sub

    Private Sub cmdNuke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuke.Click
        'Saved.Database_Connect()
        Saved.OpenTicket_Open()
        Saved.OpenOrder_Open()
        Saved.OpenBarOrder_Open()
        Saved.OpenTableInfo_Open()
        Saved.OpenStoolInfo_Open()
        Saved.Saved_Open()

        Saved.OpenTicketRST.MoveFirst()
        Do Until Saved.OpenTicketRST.EOF
            If Saved.OpenTicketTicketNum.Value = "-1" Then
            Else
                Saved.OpenTicketRST.Delete()
            End If
            Saved.OpenTicketRST.MoveNext()
        Loop

        Saved.OpenOrderRST.MoveFirst()
        Do Until Saved.OpenOrderRST.EOF
            If Saved.OpenOrderOrderNum.Value = "-1" Then
            Else
                Saved.OpenOrderRST.Delete()
            End If
            Saved.OpenOrderRST.MoveNext()
        Loop

        Saved.OpenBarOrderRST.MoveFirst()
        Do Until Saved.OpenBarOrderRST.EOF
            If Saved.OpenBarOrderOrderNum.Value = "-1" Then
            Else
                Saved.OpenBarOrderRST.Delete()
            End If
            Saved.OpenBarOrderRST.MoveNext()
        Loop

        Saved.OpenTableInfoRST.MoveFirst()
        Do Until Saved.OpenTableInfoRST.EOF
            Saved.OpenTableInfoRST.Edit()
            Saved.OpenTableInfoAvailable.Value = True
            Saved.OpenTableInfoGuestCount.Value = "0"
            Saved.OpenTableInfoEmpNum1.Value = "0"
            Saved.OpenTableInfoEmpNum2.Value = "0"
            Saved.OpenTableInfoReTable.Value = "0"
            Saved.OpenTableInfoReTrans.Value = "0"
            Saved.OpenTableInfoStoolNum.Value = "0"
            Saved.OpenTableInfoTipAtBar.Value = "DID"
            Saved.OpenTableInfoRST.Update()
            Saved.OpenTableInfoRST.MoveNext()
        Loop

        Saved.OpenStoolInfoRST.MoveFirst()
        Do Until Saved.OpenStoolInfoRST.EOF
            Saved.OpenStoolInfoRST.Edit()
            Saved.OpenStoolInfoAvailable.Value = "True"
            Saved.OpenStoolInfoReTable.Value = "0"
            Saved.OpenStoolInfoReTrans.Value = "0"
            Saved.OpenStoolInfoRST.Update()
            Saved.OpenStoolInfoRST.MoveNext()
        Loop

        Saved.OpenTicket_Close()
        Saved.OpenOrder_Close()
        Saved.OpenBarOrder_Close()
        Saved.OpenTableInfo_Close()
        Saved.OpenStoolInfo_Close()
        'Saved.Database_Disconnect()
    End Sub

    Private Sub cmdTotals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTotals.Click
        Dim form As New Totals
        form.Show()
    End Sub
End Class
