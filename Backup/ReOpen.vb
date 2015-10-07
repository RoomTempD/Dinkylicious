Public Class ReOpen
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
    Friend WithEvents cmdCancel As System.Windows.Forms.Label
    Friend WithEvents cmdReTable As System.Windows.Forms.Label
    Friend WithEvents cmdReTrans As System.Windows.Forms.Label
    Friend WithEvents lstReTablePK As System.Windows.Forms.ListBox
    Friend WithEvents lstReTableServer As System.Windows.Forms.ListBox
    Friend WithEvents lstReTableName As System.Windows.Forms.ListBox
    Friend WithEvents lstReTableTime As System.Windows.Forms.ListBox
    Friend WithEvents lstReTransTime As System.Windows.Forms.ListBox
    Friend WithEvents lstReTransName As System.Windows.Forms.ListBox
    Friend WithEvents lstReTransServer As System.Windows.Forms.ListBox
    Friend WithEvents lstReTransPK As System.Windows.Forms.ListBox
    Friend WithEvents lstReTransGuestNum As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdReTable = New System.Windows.Forms.Label
        Me.cmdReTrans = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Label
        Me.lstReTablePK = New System.Windows.Forms.ListBox
        Me.lstReTableServer = New System.Windows.Forms.ListBox
        Me.lstReTableName = New System.Windows.Forms.ListBox
        Me.lstReTableTime = New System.Windows.Forms.ListBox
        Me.lstReTransTime = New System.Windows.Forms.ListBox
        Me.lstReTransName = New System.Windows.Forms.ListBox
        Me.lstReTransServer = New System.Windows.Forms.ListBox
        Me.lstReTransPK = New System.Windows.Forms.ListBox
        Me.lstReTransGuestNum = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'cmdReTable
        '
        Me.cmdReTable.BackColor = System.Drawing.Color.Transparent
        Me.cmdReTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdReTable.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReTable.ForeColor = System.Drawing.Color.Black
        Me.cmdReTable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdReTable.Location = New System.Drawing.Point(96, 256)
        Me.cmdReTable.Name = "cmdReTable"
        Me.cmdReTable.Size = New System.Drawing.Size(104, 72)
        Me.cmdReTable.TabIndex = 0
        Me.cmdReTable.Text = "Re Open by Table"
        Me.cmdReTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdReTrans
        '
        Me.cmdReTrans.BackColor = System.Drawing.Color.Transparent
        Me.cmdReTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdReTrans.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReTrans.ForeColor = System.Drawing.Color.Black
        Me.cmdReTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdReTrans.Location = New System.Drawing.Point(536, 256)
        Me.cmdReTrans.Name = "cmdReTrans"
        Me.cmdReTrans.Size = New System.Drawing.Size(104, 72)
        Me.cmdReTrans.TabIndex = 1
        Me.cmdReTrans.Text = "Re Open by Transaction"
        Me.cmdReTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdCancel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.Black
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancel.Location = New System.Drawing.Point(320, 256)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 72)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstReTablePK
        '
        Me.lstReTablePK.Location = New System.Drawing.Point(8, 80)
        Me.lstReTablePK.Name = "lstReTablePK"
        Me.lstReTablePK.Size = New System.Drawing.Size(32, 160)
        Me.lstReTablePK.TabIndex = 3
        '
        'lstReTableServer
        '
        Me.lstReTableServer.Location = New System.Drawing.Point(40, 80)
        Me.lstReTableServer.Name = "lstReTableServer"
        Me.lstReTableServer.Size = New System.Drawing.Size(80, 160)
        Me.lstReTableServer.TabIndex = 4
        '
        'lstReTableName
        '
        Me.lstReTableName.Location = New System.Drawing.Point(120, 80)
        Me.lstReTableName.Name = "lstReTableName"
        Me.lstReTableName.Size = New System.Drawing.Size(120, 160)
        Me.lstReTableName.TabIndex = 5
        '
        'lstReTableTime
        '
        Me.lstReTableTime.Location = New System.Drawing.Point(240, 80)
        Me.lstReTableTime.Name = "lstReTableTime"
        Me.lstReTableTime.Size = New System.Drawing.Size(56, 160)
        Me.lstReTableTime.TabIndex = 6
        '
        'lstReTransTime
        '
        Me.lstReTransTime.Location = New System.Drawing.Point(624, 88)
        Me.lstReTransTime.Name = "lstReTransTime"
        Me.lstReTransTime.Size = New System.Drawing.Size(56, 160)
        Me.lstReTransTime.TabIndex = 10
        '
        'lstReTransName
        '
        Me.lstReTransName.Location = New System.Drawing.Point(504, 88)
        Me.lstReTransName.Name = "lstReTransName"
        Me.lstReTransName.Size = New System.Drawing.Size(120, 160)
        Me.lstReTransName.TabIndex = 9
        '
        'lstReTransServer
        '
        Me.lstReTransServer.Location = New System.Drawing.Point(424, 88)
        Me.lstReTransServer.Name = "lstReTransServer"
        Me.lstReTransServer.Size = New System.Drawing.Size(80, 160)
        Me.lstReTransServer.TabIndex = 8
        '
        'lstReTransPK
        '
        Me.lstReTransPK.Location = New System.Drawing.Point(392, 88)
        Me.lstReTransPK.Name = "lstReTransPK"
        Me.lstReTransPK.Size = New System.Drawing.Size(32, 160)
        Me.lstReTransPK.TabIndex = 7
        '
        'lstReTransGuestNum
        '
        Me.lstReTransGuestNum.Location = New System.Drawing.Point(680, 88)
        Me.lstReTransGuestNum.Name = "lstReTransGuestNum"
        Me.lstReTransGuestNum.Size = New System.Drawing.Size(56, 160)
        Me.lstReTransGuestNum.TabIndex = 11
        '
        'ReOpen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Me.ClientSize = New System.Drawing.Size(744, 344)
        Me.Controls.Add(Me.lstReTransGuestNum)
        Me.Controls.Add(Me.lstReTransTime)
        Me.Controls.Add(Me.lstReTransName)
        Me.Controls.Add(Me.lstReTransServer)
        Me.Controls.Add(Me.lstReTransPK)
        Me.Controls.Add(Me.lstReTableTime)
        Me.Controls.Add(Me.lstReTableName)
        Me.Controls.Add(Me.lstReTableServer)
        Me.Controls.Add(Me.lstReTablePK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdReTrans)
        Me.Controls.Add(Me.cmdReTable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReOpen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignInOut"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub ReOpen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Saved.Database_Connect()
        Saved.Emp_Open()
        Saved.ClosedTicket_Open()
        Saved.ClosedTableInfo_Open()
        Saved.OpenTableInfo_Open()

        Dim Unique(500) As Integer
        Dim Num As Integer = 0
        Dim ADDED As Integer = 0
        Dim ADD As Boolean = True

        lstReTablePK.Items.Clear()
        lstReTableServer.Items.Clear()
        lstReTableName.Items.Clear()
        lstReTableTime.Items.Clear()
        lstReTransPK.Items.Clear()
        lstReTransServer.Items.Clear()
        lstReTransName.Items.Clear()
        lstReTransTime.Items.Clear()
        lstReTransGuestNum.Items.Clear()

        ADDED = 0
        Saved.ClosedTicketRST.MoveLast()
        Do Until Saved.ClosedTicketRST.BOF
            ADD = True
            For Num = 1 To 500
                If Unique(Num) = Saved.ClosedTicketReTable.Value Then
                    ADD = False
                End If
            Next Num
            If ADD = True And Not Saved.ClosedTicketReTable.Value = -99 Then
                ADDED = ADDED + 1
                Unique(ADDED) = Saved.ClosedTicketReTable.Value
                Saved.OpenTableInfoRST.FindFirst("TABLE_NUM = " & Saved.ClosedTicketTableNum.Value)
                Saved.ClosedTableInfoRST.FindFirst("RETABLE = " & Saved.ClosedTicketReTable.Value)
                Saved.EmpRST.FindFirst("EMP_NUM = " & Saved.ClosedTableInfoEmpNum1.Value)

                lstReTablePK.Items.Add(Saved.ClosedTicketReTable.Value)
                lstReTableServer.Items.Add(Saved.EmpEmpName.Value)
                lstReTableName.Items.Add(Saved.OpenTableInfoTableName.Value)
                lstReTableTime.Items.Add(Format(Saved.ClosedTableInfoTimeOut.Value, "Short Time"))
            End If
            Saved.ClosedTicketRST.MovePrevious()
        Loop

        ADDED = 0
        Saved.ClosedTicketRST.MoveLast()
        Do Until Saved.ClosedTicketRST.BOF
            ADD = True
            For Num = 1 To 500
                If Unique(Num) = Saved.ClosedTicketReTrans.Value Then
                    ADD = False
                End If
            Next Num
            If ADD = True And Not Saved.ClosedTicketReTrans.Value = -99 Then
                ADDED = ADDED + 1
                Unique(ADDED) = Saved.ClosedTicketReTable.Value
                Saved.OpenTableInfoRST.FindFirst("TABLE_NUM = " & Saved.ClosedTicketTableNum.Value)
                Saved.ClosedTableInfoRST.FindFirst("RETABLE = " & Saved.ClosedTicketReTable.Value)
                Saved.EmpRST.FindFirst("EMP_NUM = " & Saved.ClosedTableInfoEmpNum1.Value)

                lstReTransPK.Items.Add(Saved.ClosedTicketReTrans.Value)
                lstReTransServer.Items.Add(Saved.EmpEmpName.Value)
                lstReTransName.Items.Add(Saved.OpenTableInfoTableName.Value)
                lstReTransTime.Items.Add(Format(Saved.ClosedTableInfoTimeOut.Value, "Short Time"))
                lstReTransGuestNum.Items.Add(Saved.ClosedTicketGuestNum.Value)
            End If
            Saved.ClosedTicketRST.MovePrevious()
        Loop

        Saved.OpenTableInfo_Close()
        Saved.ClosedTableInfo_Close()
        Saved.ClosedTicket_Close()
        Saved.Emp_Close()
        Saved.Database_Disconnect()
    End Sub

    Private Sub lstReTablePK_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReTablePK.SelectedIndexChanged
        lstReTableServer.SelectedIndex = lstReTablePK.SelectedIndex
        lstReTableName.SelectedIndex = lstReTablePK.SelectedIndex
        lstReTableTime.SelectedIndex = lstReTablePK.SelectedIndex
    End Sub

    Private Sub lstReTableServer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReTableServer.SelectedIndexChanged
        lstReTablePK.SelectedIndex = lstReTableServer.SelectedIndex
        lstReTableName.SelectedIndex = lstReTableServer.SelectedIndex
        lstReTableTime.SelectedIndex = lstReTableServer.SelectedIndex
    End Sub

    Private Sub lstReTableName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReTableName.SelectedIndexChanged
        lstReTablePK.SelectedIndex = lstReTableName.SelectedIndex
        lstReTableServer.SelectedIndex = lstReTableName.SelectedIndex
        lstReTableTime.SelectedIndex = lstReTableName.SelectedIndex
    End Sub

    Private Sub lstReTableTime_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReTableTime.SelectedIndexChanged
        lstReTablePK.SelectedIndex = lstReTableTime.SelectedIndex
        lstReTableServer.SelectedIndex = lstReTableTime.SelectedIndex
        lstReTableName.SelectedIndex = lstReTableTime.SelectedIndex
    End Sub

    Private Sub lstReTransPK_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReTransPK.SelectedIndexChanged
        lstReTransServer.SelectedIndex = lstReTransPK.SelectedIndex
        lstReTransName.SelectedIndex = lstReTransPK.SelectedIndex
        lstReTransTime.SelectedIndex = lstReTransPK.SelectedIndex
        lstReTransGuestNum.SelectedIndex = lstReTransPK.SelectedIndex
    End Sub

    Private Sub lstReTransServer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReTransServer.SelectedIndexChanged
        lstReTransPK.SelectedIndex = lstReTransServer.SelectedIndex
        lstReTransName.SelectedIndex = lstReTransServer.SelectedIndex
        lstReTransTime.SelectedIndex = lstReTransServer.SelectedIndex
        lstReTransGuestNum.SelectedIndex = lstReTransServer.SelectedIndex
    End Sub

    Private Sub lstReTransName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReTransName.SelectedIndexChanged
        lstReTransPK.SelectedIndex = lstReTransName.SelectedIndex
        lstReTransServer.SelectedIndex = lstReTransName.SelectedIndex
        lstReTransTime.SelectedIndex = lstReTransName.SelectedIndex
        lstReTransGuestNum.SelectedIndex = lstReTransName.SelectedIndex
    End Sub

    Private Sub lstReTransTime_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReTransTime.SelectedIndexChanged
        lstReTransPK.SelectedIndex = lstReTransTime.SelectedIndex
        lstReTransServer.SelectedIndex = lstReTransTime.SelectedIndex
        lstReTransName.SelectedIndex = lstReTransTime.SelectedIndex
        lstReTransGuestNum.SelectedIndex = lstReTransTime.SelectedIndex
    End Sub

    Private Sub lstReTransGuestNum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReTransGuestNum.SelectedIndexChanged
        lstReTransName.SelectedIndex = lstReTransGuestNum.SelectedIndex
        lstReTransServer.SelectedIndex = lstReTransGuestNum.SelectedIndex
        lstReTransPK.SelectedIndex = lstReTransGuestNum.SelectedIndex
        lstReTransTime.SelectedIndex = lstReTransGuestNum.SelectedIndex
    End Sub

    Private Sub cmdReTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReTable.Click
        Saved.Database_Connect()
        Saved.OpenTicket_Open()
        Saved.OpenOrder_Open()
        Saved.OpenBarOrder_Open()
        Saved.OpenTableInfo_Open()
        Saved.OpenStoolInfo_Open()
        Saved.ClosedTicket_Open()
        Saved.ClosedOrder_Open()
        Saved.ClosedBarOrder_Open()
        Saved.ClosedTableInfo_Open()
        Saved.ClosedStoolInfo_Open()
        Saved.Saved_Open()


        '        Saved.ClosedTableInfoRST.MoveLast()
        '        Do Until Saved.ClosedTableInfoRST.BOF
        '        If Form_Saved.ClosedTableDaTrans = Val(lstTables.Value) Then
        '        'copy all info over to open table
        '        Form_Saved.OpenTableRST.AddNew()
        '        Form_Saved.OpenTableTableNumber = Form_Saved.ClosedTableTableNumber
        '        Form_Saved.OpenTableGuestCount = Form_Saved.ClosedTableGuestCount
        '        Form_Saved.OpenTableEmployeeNumber = Form_Saved.ClosedTableEmployeeNumber

        '        Form_Saved.OpenTableRST.Update()
        '        Form_Saved.ClosedTableRST.Delete()
        '        End If
        '        Form_Saved.ClosedTableRST.MovePrevious()
        '        Loop

        '        Form_Saved.ClosedOrderRST.MoveLast()
        '        Do Until Form_Saved.ClosedOrderRST.BOF
        '        If Form_Saved.ClosedOrderDaTrans = Val(lstTables.Value) Then
        '        'copy all info over to open table
        '        Form_Saved.OpenOrderRST.AddNew()
        '        Form_Saved.OpenOrderOrderNumber = Form_Saved.ClosedOrderOrderNumber
        '        Form_Saved.OpenOrderLineNumber = Form_Saved.ClosedOrderLineNumber
        '        Form_Saved.OpenOrderItemNumber = Form_Saved.ClosedOrderItemNumber
        '        Form_Saved.OpenOrderQuotedPrice = Form_Saved.ClosedOrderQuotedPrice

        '        Form_Saved.OpenOrderRST.Update()
        '        Form_Saved.ClosedOrderRST.Delete()
        '        End If
        '        Form_Saved.ClosedOrderRST.MovePrevious()
        '        Loop


        '        Form_Saved.ClosedTicketRST.MoveLast()
        '        Do Until Form_Saved.ClosedTicketRST.BOF
        '        If Form_Saved.ClosedTicketDaTrans = Val(lstTables.Value) Then
        '        'copy all info over to open table
        '        Form_Saved.OpenTicketRST.AddNew()
        '        Form_Saved.OpenTicketTableNumber = Form_Saved.ClosedTicketTableNumber
        '        Form_Saved.OpenTicketGuestLetter = Form_Saved.ClosedTicketGuestLetter
        '        Form_Saved.OpenTicketOrderNumber = Form_Saved.ClosedTicketOrderNumber
        '        Form_Saved.OpenTicketDateIn = Form_Saved.ClosedTicketDateIn
        '        Form_Saved.OpenTicketTimeIn = Form_Saved.ClosedTicketTimeIn
        '        Form_Saved.OpenTicketSubtotal = Form_Saved.ClosedTicketSubtotal
        '        Form_Saved.OpenTicketTax = Form_Saved.ClosedTicketTax
        '        Form_Saved.OpenTicketTotal = Form_Saved.ClosedTicketTotal

        '        Form_Saved.OpenTicketRST.Update()
        '        Form_Saved.ClosedTicketRST.Delete()
        '        End If
        '        Form_Saved.ClosedTicketRST.MovePrevious()
        '        Loop


        Saved.OpenTicket_Close()
        Saved.OpenOrder_Close()
        Saved.OpenBarOrder_Close()
        Saved.OpenTableInfo_Close()
        Saved.OpenStoolInfo_Close()
        Saved.ClosedTicket_Close()
        Saved.ClosedOrder_Close()
        Saved.ClosedBarOrder_Close()
        Saved.ClosedTableInfo_Close()
        Saved.ClosedStoolInfo_Close()
        Saved.Saved_Close()
        Saved.Database_Disconnect()
    End Sub
End Class
