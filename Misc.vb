Public Class Misc
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
    Friend WithEvents cmdSignInOut As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdGuestNumChange As System.Windows.Forms.Button
    Friend WithEvents cmdReOpen As System.Windows.Forms.Button
    Friend WithEvents cmdSecondServer As System.Windows.Forms.Button
    Friend WithEvents cmdChangeSpecial As System.Windows.Forms.Button
    Friend WithEvents cmdPrintTipReport As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdSignInOut = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdGuestNumChange = New System.Windows.Forms.Button()
        Me.cmdReOpen = New System.Windows.Forms.Button()
        Me.cmdSecondServer = New System.Windows.Forms.Button()
        Me.cmdPrintTipReport = New System.Windows.Forms.Button()
        Me.cmdChangeSpecial = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdSignInOut
        '
        Me.cmdSignInOut.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSignInOut.Location = New System.Drawing.Point(16, 32)
        Me.cmdSignInOut.Name = "cmdSignInOut"
        Me.cmdSignInOut.Size = New System.Drawing.Size(128, 72)
        Me.cmdSignInOut.TabIndex = 4
        Me.cmdSignInOut.Text = "Sign In/Out"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(16, 304)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(128, 72)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "Close"
        '
        'cmdGuestNumChange
        '
        Me.cmdGuestNumChange.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuestNumChange.Location = New System.Drawing.Point(288, 32)
        Me.cmdGuestNumChange.Name = "cmdGuestNumChange"
        Me.cmdGuestNumChange.Size = New System.Drawing.Size(128, 72)
        Me.cmdGuestNumChange.TabIndex = 6
        Me.cmdGuestNumChange.Text = "Change Number of Guests"
        '
        'cmdReOpen
        '
        Me.cmdReOpen.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReOpen.Location = New System.Drawing.Point(288, 112)
        Me.cmdReOpen.Name = "cmdReOpen"
        Me.cmdReOpen.Size = New System.Drawing.Size(128, 72)
        Me.cmdReOpen.TabIndex = 7
        Me.cmdReOpen.Text = "Re Open Closed Table"
        '
        'cmdSecondServer
        '
        Me.cmdSecondServer.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSecondServer.Location = New System.Drawing.Point(152, 112)
        Me.cmdSecondServer.Name = "cmdSecondServer"
        Me.cmdSecondServer.Size = New System.Drawing.Size(128, 72)
        Me.cmdSecondServer.TabIndex = 8
        Me.cmdSecondServer.Text = "Second Server"
        '
        'cmdPrintTipReport
        '
        Me.cmdPrintTipReport.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintTipReport.Location = New System.Drawing.Point(16, 112)
        Me.cmdPrintTipReport.Name = "cmdPrintTipReport"
        Me.cmdPrintTipReport.Size = New System.Drawing.Size(128, 72)
        Me.cmdPrintTipReport.TabIndex = 9
        Me.cmdPrintTipReport.Text = "Print Tip Report"
        '
        'cmdChangeSpecial
        '
        Me.cmdChangeSpecial.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChangeSpecial.Location = New System.Drawing.Point(152, 32)
        Me.cmdChangeSpecial.Name = "cmdChangeSpecial"
        Me.cmdChangeSpecial.Size = New System.Drawing.Size(128, 72)
        Me.cmdChangeSpecial.TabIndex = 10
        Me.cmdChangeSpecial.Text = "Change Special"
        '
        'Misc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 398)
        Me.Controls.Add(Me.cmdChangeSpecial)
        Me.Controls.Add(Me.cmdPrintTipReport)
        Me.Controls.Add(Me.cmdSecondServer)
        Me.Controls.Add(Me.cmdReOpen)
        Me.Controls.Add(Me.cmdGuestNumChange)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSignInOut)
        Me.Name = "Misc"
        Me.Text = "Misc"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdSignInOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSignInOut.Click
        Dim form As New SignInOut
        form.ShowDialog()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdGuestNumChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuestNumChange.Click
        'Saved.Database_Connect()
        Saved.OpenTableInfo_Open()

        Dim frmEnterGuestCount As New EnterGuestCount
        Saved.GO(0) = False
        frmEnterGuestCount.ShowDialog()
        'Get the number of guests

        If Saved.GO(0) = True Then
            Saved.OpenTableInfoRST.FindFirst("TABLE_NUM = " & Saved.CURTABLE)
            If Saved.OpenTableInfoRST.NoMatch = False Then
                Saved.OpenTableInfoRST.Edit()
                Saved.OpenTableInfoGuestCount.Value = Saved.CURGUESTCOUNT
                Saved.OpenTableInfoRST.Update()
            End If
        End If

        Saved.OpenTableInfo_Close()
        'Saved.Database_Disconnect()
    End Sub

    Private Sub cmdReOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReOpen.Click
        Dim form As New ReOpen
        form.ShowDialog()
    End Sub

    Private Sub cmdSecondServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSecondServer.Click
        'Saved.Database_Connect()
        Saved.OpenTableInfo_Open()
        Dim frmChangeServer As New ChangeServer
        frmChangeServer.ShowDialog()

        Saved.OpenTableInfoRST.FindFirst("TABLE_NUM = " & Saved.CURTABLE)
        If Saved.OpenTableInfoRST.NoMatch = False Then
            Saved.OpenTableInfoRST.Edit()
            Saved.OpenTableInfoEmpNum2.Value = Saved.CURSERVER2
            Saved.OpenTableInfoRST.Update()
        End If

        Saved.OpenTableInfo_Close()
        'Saved.Database_Disconnect()
    End Sub

    Private Sub Misc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Saved.LOGON = "BAR" Then
            cmdSignInOut.Enabled = False
        End If
    End Sub

    Private Sub cmdPrintTipReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintTipReport.Click

        Dim intFileNo As Integer = FreeFile()
        FileOpen(1, "print.txt", OpenMode.Output)



        'Open used tables
        'Saved.Database_Connect()
        Saved.ClosedTicket_Open()
        Saved.ClosedTableInfo_Open()
        Saved.Emp_Open()
        Saved.OpenTableInfo_Open()

        Dim TOTALTICKETS As Double = 0
        Dim TOTALGUESTS As Integer = 0
        Dim NUMBEROFTABS As Integer = 0
        Dim NUMBEROFTABSNOTTIPPED As Integer = 0
        Dim MONEYTABSNOTTIPPED As Double = 0
        Dim BARTOTAL As Double = 0
        Dim FOODTOTAL As Double = 0
        Dim TIPTOTAL As Double = 0

        Saved.EmpRST.FindFirst("EMP_NUM = " & Saved.CURSERVER)

        PrintLine(1, "Server: " & Saved.EmpEmpName.Value)
        PrintLine(1, "  Date: " & Format(Now(), "Short Date"))
        PrintLine(1, "_________________________________________")

        Saved.ClosedTicketRST.MoveFirst()
        Do Until Saved.ClosedTicketRST.EOF
            Saved.ClosedTableInfoRST.FindFirst("RETABLE = " & Saved.ClosedTicketReTable.Value)
            If Not IsDBNull(Saved.ClosedTicketTipAtBar.Value) Then
                If Not IsDBNull(Saved.ClosedTicketTippedOn.Value) Then
                    If Format(Saved.ClosedTicketDateOut.Value, "Short Date") = Format(Now(), "Short Date") Then
                        If Saved.ClosedTableInfoEmpNum1.Value = Saved.CURSERVER Then
                            Saved.OpenTableInfoRST.FindFirst("TABLE_NUM = " & Saved.ClosedTicketTableNum.Value)
                            TOTALTICKETS += 1
                            TOTALGUESTS += Saved.ClosedTableInfoGuestCount.Value
                            BARTOTAL += Saved.ClosedTicketBarTotal.Value
                            FOODTOTAL += Saved.ClosedTicketFoodTotal.Value
                            TIPTOTAL += Saved.ClosedTicketTip.Value
                            If Saved.ClosedTicketTippedOn.Value <> 0 Then
                                NUMBEROFTABS += 1
                                If Saved.ClosedTicketTipAtBar.Value = "NO" Then
                                    NUMBEROFTABSNOTTIPPED += 1
                                    MONEYTABSNOTTIPPED += Saved.ClosedTicketTippedOn.Value
                                End If
                            End If
                            PrintLine(1, "RT#: " & Saved.ClosedTicketReTable.Value & " In: " & Format(Saved.ClosedTicketTimeIn.Value, "Short Time") & " Out: " & Format(Saved.ClosedTicketTimeOut.Value, "Short Time"))
                            PrintLine(1, "Tbl: " & Saved.OpenTableInfoTableName.Value & " Gst: " & Saved.ClosedTicketGuestNum.Value)
                            PrintLine(1, "TipAtBar: " & Saved.ClosedTicketTipAtBar.Value & " Tab: " & Format(Saved.ClosedTicketTippedOn.Value, "Currency"))
                            PrintLine(1, "Food: " & Format(Saved.ClosedTicketFoodTotal.Value, "Currency") & " Bar: " & Format(Saved.ClosedTicketBarTotal.Value, "Currency") & " Tip: " & Format(Saved.ClosedTicketTip.Value, "Currency"))
                            PrintLine(1, "")
                        End If
                    End If
                End If
            End If

            Saved.ClosedTicketRST.MoveNext()
        Loop




        PrintLine(1, "____________________________________________")
        PrintLine(1, "")
        PrintLine(1, "                Total Tickets: " & TOTALTICKETS)
        PrintLine(1, "                 Total Guests: " & TOTALGUESTS)
        PrintLine(1, "               Number of tabs: " & NUMBEROFTABS)
        PrintLine(1, "    Number of tabs not tipped: " & NUMBEROFTABSNOTTIPPED)
        PrintLine(1, "     Money of tabs not tipped: " & Format(MONEYTABSNOTTIPPED, "Currency"))
        PrintLine(1, "                    Bar Total: " & Format(BARTOTAL, "Currency"))
        PrintLine(1, "                   Food Total: " & Format(FOODTOTAL, "Currency"))
        PrintLine(1, "                    Tip Total: " & Format(TIPTOTAL, "Currency"))

        FileClose(1)
        Shell("print /d:\\fireside-bar\star print.txt", AppWinStyle.Hide)


        Saved.Emp_Close()
        Saved.OpenTableInfo_Close()
        Saved.ClosedTicket_Close()
        Saved.ClosedTableInfo_Close()
        'Saved.Database_Disconnect()
    End Sub

    Private Sub cmdChangeSpecial_Click(sender As System.Object, e As System.EventArgs) Handles cmdChangeSpecial.Click
         Dim form As New PickSpecial
        form.Show()
    End Sub
End Class
