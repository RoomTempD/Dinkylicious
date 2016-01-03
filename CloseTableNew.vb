Public Class CloseTableNew
    Inherits System.Windows.Forms.Form
    Dim CHANGE As Double
    Friend WithEvents dgvGuestList As System.Windows.Forms.DataGridView
    Dim DEC As Integer = 0

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
    Friend WithEvents cmdCloseGuest As System.Windows.Forms.Button
    Friend WithEvents cmdExitWithOutClosing As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTableName As System.Windows.Forms.Label
    Friend WithEvents lstGNPK As System.Windows.Forms.ListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lstGN As System.Windows.Forms.ListBox
    Friend WithEvents txtGuestOwes As System.Windows.Forms.TextBox
    Friend WithEvents txtNetDue As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdChangeAsTip As System.Windows.Forms.Button
    Friend WithEvents cmdGRA As System.Windows.Forms.Button
    Friend WithEvents cmdCSH As System.Windows.Forms.Button
    Friend WithEvents cmdEXTCSH As System.Windows.Forms.Button
    Friend WithEvents cmdCHK As System.Windows.Forms.Button
    Friend WithEvents cmdEXTCHK As System.Windows.Forms.Button
    Friend WithEvents cmdCRD As System.Windows.Forms.Button
    Friend WithEvents cmdCRT As System.Windows.Forms.Button
    Friend WithEvents cmdEXTCRD As System.Windows.Forms.Button
    Friend WithEvents lstTotal As System.Windows.Forms.ListBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents txtGRA As System.Windows.Forms.TextBox
    Friend WithEvents txtCSH As System.Windows.Forms.TextBox
    Friend WithEvents txtCRD As System.Windows.Forms.TextBox
    Friend WithEvents txtCHK As System.Windows.Forms.TextBox
    Friend WithEvents txtCRT As System.Windows.Forms.TextBox
    Friend WithEvents lblHide As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCloseGuest = New System.Windows.Forms.Button()
        Me.cmdExitWithOutClosing = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTableName = New System.Windows.Forms.Label()
        Me.lstGNPK = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvGuestList = New System.Windows.Forms.DataGridView()
        Me.lstTotal = New System.Windows.Forms.ListBox()
        Me.lstGN = New System.Windows.Forms.ListBox()
        Me.txtGuestOwes = New System.Windows.Forms.TextBox()
        Me.txtGRA = New System.Windows.Forms.TextBox()
        Me.txtCSH = New System.Windows.Forms.TextBox()
        Me.txtCRD = New System.Windows.Forms.TextBox()
        Me.txtCHK = New System.Windows.Forms.TextBox()
        Me.txtNetDue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdGRA = New System.Windows.Forms.Button()
        Me.cmdChangeAsTip = New System.Windows.Forms.Button()
        Me.cmdCSH = New System.Windows.Forms.Button()
        Me.cmdEXTCSH = New System.Windows.Forms.Button()
        Me.cmdCHK = New System.Windows.Forms.Button()
        Me.cmdEXTCHK = New System.Windows.Forms.Button()
        Me.cmdCRD = New System.Windows.Forms.Button()
        Me.cmdCRT = New System.Windows.Forms.Button()
        Me.cmdEXTCRD = New System.Windows.Forms.Button()
        Me.txtCRT = New System.Windows.Forms.TextBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.lblHide = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvGuestList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCloseGuest
        '
        Me.cmdCloseGuest.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCloseGuest.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseGuest.ForeColor = System.Drawing.Color.Green
        Me.cmdCloseGuest.Location = New System.Drawing.Point(456, 416)
        Me.cmdCloseGuest.Name = "cmdCloseGuest"
        Me.cmdCloseGuest.Size = New System.Drawing.Size(296, 48)
        Me.cmdCloseGuest.TabIndex = 13
        Me.cmdCloseGuest.Text = "Close Guest"
        Me.cmdCloseGuest.UseVisualStyleBackColor = False
        '
        'cmdExitWithOutClosing
        '
        Me.cmdExitWithOutClosing.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdExitWithOutClosing.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExitWithOutClosing.ForeColor = System.Drawing.Color.Maroon
        Me.cmdExitWithOutClosing.Location = New System.Drawing.Point(72, 416)
        Me.cmdExitWithOutClosing.Name = "cmdExitWithOutClosing"
        Me.cmdExitWithOutClosing.Size = New System.Drawing.Size(296, 48)
        Me.cmdExitWithOutClosing.TabIndex = 14
        Me.cmdExitWithOutClosing.Text = "Exit without closing"
        Me.cmdExitWithOutClosing.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTableName)
        Me.Panel1.Location = New System.Drawing.Point(8, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 80)
        Me.Panel1.TabIndex = 19
        '
        'lblTableName
        '
        Me.lblTableName.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableName.Location = New System.Drawing.Point(8, 16)
        Me.lblTableName.Name = "lblTableName"
        Me.lblTableName.Size = New System.Drawing.Size(248, 48)
        Me.lblTableName.TabIndex = 0
        Me.lblTableName.Text = "Waitress"
        '
        'lstGNPK
        '
        Me.lstGNPK.Location = New System.Drawing.Point(56, 16)
        Me.lstGNPK.Name = "lstGNPK"
        Me.lstGNPK.Size = New System.Drawing.Size(328, 121)
        Me.lstGNPK.TabIndex = 20
        Me.lstGNPK.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.dgvGuestList)
        Me.Panel2.Controls.Add(Me.lstTotal)
        Me.Panel2.Controls.Add(Me.lstGN)
        Me.Panel2.Controls.Add(Me.lstGNPK)
        Me.Panel2.Location = New System.Drawing.Point(8, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 264)
        Me.Panel2.TabIndex = 20
        '
        'dgvGuestList
        '
        Me.dgvGuestList.AllowUserToAddRows = False
        Me.dgvGuestList.AllowUserToDeleteRows = False
        Me.dgvGuestList.AllowUserToResizeColumns = False
        Me.dgvGuestList.AllowUserToResizeRows = False
        Me.dgvGuestList.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvGuestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvGuestList.Location = New System.Drawing.Point(58, 16)
        Me.dgvGuestList.MultiSelect = False
        Me.dgvGuestList.Name = "dgvGuestList"
        Me.dgvGuestList.ReadOnly = True
        Me.dgvGuestList.RowHeadersVisible = False
        Me.dgvGuestList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvGuestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGuestList.Size = New System.Drawing.Size(336, 234)
        Me.dgvGuestList.TabIndex = 46
        '
        'lstTotal
        '
        Me.lstTotal.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTotal.ItemHeight = 23
        Me.lstTotal.Location = New System.Drawing.Point(112, 16)
        Me.lstTotal.Name = "lstTotal"
        Me.lstTotal.Size = New System.Drawing.Size(280, 234)
        Me.lstTotal.TabIndex = 22
        '
        'lstGN
        '
        Me.lstGN.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGN.ItemHeight = 23
        Me.lstGN.Location = New System.Drawing.Point(56, 16)
        Me.lstGN.Name = "lstGN"
        Me.lstGN.Size = New System.Drawing.Size(56, 234)
        Me.lstGN.TabIndex = 21
        '
        'txtGuestOwes
        '
        Me.txtGuestOwes.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtGuestOwes.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestOwes.Location = New System.Drawing.Point(640, 16)
        Me.txtGuestOwes.Name = "txtGuestOwes"
        Me.txtGuestOwes.Size = New System.Drawing.Size(152, 27)
        Me.txtGuestOwes.TabIndex = 23
        '
        'txtGRA
        '
        Me.txtGRA.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtGRA.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGRA.Location = New System.Drawing.Point(680, 328)
        Me.txtGRA.Name = "txtGRA"
        Me.txtGRA.Size = New System.Drawing.Size(152, 27)
        Me.txtGRA.TabIndex = 24
        '
        'txtCSH
        '
        Me.txtCSH.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCSH.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCSH.Location = New System.Drawing.Point(680, 72)
        Me.txtCSH.Name = "txtCSH"
        Me.txtCSH.Size = New System.Drawing.Size(152, 27)
        Me.txtCSH.TabIndex = 25
        '
        'txtCRD
        '
        Me.txtCRD.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCRD.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCRD.Location = New System.Drawing.Point(680, 200)
        Me.txtCRD.Name = "txtCRD"
        Me.txtCRD.Size = New System.Drawing.Size(152, 27)
        Me.txtCRD.TabIndex = 26
        '
        'txtCHK
        '
        Me.txtCHK.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCHK.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCHK.Location = New System.Drawing.Point(680, 136)
        Me.txtCHK.Name = "txtCHK"
        Me.txtCHK.Size = New System.Drawing.Size(152, 27)
        Me.txtCHK.TabIndex = 27
        '
        'txtNetDue
        '
        Me.txtNetDue.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtNetDue.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetDue.Location = New System.Drawing.Point(680, 376)
        Me.txtNetDue.Name = "txtNetDue"
        Me.txtNetDue.Size = New System.Drawing.Size(152, 27)
        Me.txtNetDue.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(464, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 32)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Guest Owes:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(512, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 32)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Net Due:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdGRA
        '
        Me.cmdGRA.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdGRA.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGRA.Location = New System.Drawing.Point(456, 312)
        Me.cmdGRA.Name = "cmdGRA"
        Me.cmdGRA.Size = New System.Drawing.Size(104, 56)
        Me.cmdGRA.TabIndex = 31
        Me.cmdGRA.Text = "Gratuity"
        Me.cmdGRA.UseVisualStyleBackColor = False
        '
        'cmdChangeAsTip
        '
        Me.cmdChangeAsTip.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdChangeAsTip.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChangeAsTip.Location = New System.Drawing.Point(568, 312)
        Me.cmdChangeAsTip.Name = "cmdChangeAsTip"
        Me.cmdChangeAsTip.Size = New System.Drawing.Size(104, 56)
        Me.cmdChangeAsTip.TabIndex = 32
        Me.cmdChangeAsTip.Text = "Use Change As Tip"
        Me.cmdChangeAsTip.UseVisualStyleBackColor = False
        '
        'cmdCSH
        '
        Me.cmdCSH.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCSH.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCSH.Location = New System.Drawing.Point(456, 56)
        Me.cmdCSH.Name = "cmdCSH"
        Me.cmdCSH.Size = New System.Drawing.Size(104, 56)
        Me.cmdCSH.TabIndex = 33
        Me.cmdCSH.Text = "Cash"
        Me.cmdCSH.UseVisualStyleBackColor = False
        '
        'cmdEXTCSH
        '
        Me.cmdEXTCSH.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEXTCSH.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEXTCSH.Location = New System.Drawing.Point(568, 56)
        Me.cmdEXTCSH.Name = "cmdEXTCSH"
        Me.cmdEXTCSH.Size = New System.Drawing.Size(104, 56)
        Me.cmdEXTCSH.TabIndex = 34
        Me.cmdEXTCSH.Text = "Exact Cash"
        Me.cmdEXTCSH.UseVisualStyleBackColor = False
        '
        'cmdCHK
        '
        Me.cmdCHK.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCHK.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCHK.Location = New System.Drawing.Point(456, 120)
        Me.cmdCHK.Name = "cmdCHK"
        Me.cmdCHK.Size = New System.Drawing.Size(104, 56)
        Me.cmdCHK.TabIndex = 35
        Me.cmdCHK.Text = "Check"
        Me.cmdCHK.UseVisualStyleBackColor = False
        '
        'cmdEXTCHK
        '
        Me.cmdEXTCHK.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEXTCHK.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEXTCHK.Location = New System.Drawing.Point(568, 120)
        Me.cmdEXTCHK.Name = "cmdEXTCHK"
        Me.cmdEXTCHK.Size = New System.Drawing.Size(104, 56)
        Me.cmdEXTCHK.TabIndex = 36
        Me.cmdEXTCHK.Text = "Exact Check"
        Me.cmdEXTCHK.UseVisualStyleBackColor = False
        '
        'cmdCRD
        '
        Me.cmdCRD.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCRD.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCRD.Location = New System.Drawing.Point(456, 184)
        Me.cmdCRD.Name = "cmdCRD"
        Me.cmdCRD.Size = New System.Drawing.Size(104, 56)
        Me.cmdCRD.TabIndex = 37
        Me.cmdCRD.Text = "Card"
        Me.cmdCRD.UseVisualStyleBackColor = False
        '
        'cmdCRT
        '
        Me.cmdCRT.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCRT.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCRT.Location = New System.Drawing.Point(456, 248)
        Me.cmdCRT.Name = "cmdCRT"
        Me.cmdCRT.Size = New System.Drawing.Size(216, 56)
        Me.cmdCRT.TabIndex = 38
        Me.cmdCRT.Text = "Gift Certificate"
        Me.cmdCRT.UseVisualStyleBackColor = False
        '
        'cmdEXTCRD
        '
        Me.cmdEXTCRD.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEXTCRD.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEXTCRD.Location = New System.Drawing.Point(568, 184)
        Me.cmdEXTCRD.Name = "cmdEXTCRD"
        Me.cmdEXTCRD.Size = New System.Drawing.Size(104, 56)
        Me.cmdEXTCRD.TabIndex = 39
        Me.cmdEXTCRD.Text = "Exact Card"
        Me.cmdEXTCRD.UseVisualStyleBackColor = False
        '
        'txtCRT
        '
        Me.txtCRT.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCRT.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCRT.Location = New System.Drawing.Point(680, 264)
        Me.txtCRT.Name = "txtCRT"
        Me.txtCRT.Size = New System.Drawing.Size(152, 27)
        Me.txtCRT.TabIndex = 40
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdClear.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(344, 376)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(104, 32)
        Me.cmdClear.TabIndex = 41
        Me.cmdClear.Text = "Clear All"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'lblHide
        '
        Me.lblHide.Location = New System.Drawing.Point(8, 8)
        Me.lblHide.Name = "lblHide"
        Me.lblHide.Size = New System.Drawing.Size(824, 456)
        Me.lblHide.TabIndex = 42
        Me.lblHide.Visible = False
        '
        'CloseTableNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(840, 472)
        Me.Controls.Add(Me.lblHide)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtCRT)
        Me.Controls.Add(Me.cmdEXTCRD)
        Me.Controls.Add(Me.cmdCRT)
        Me.Controls.Add(Me.cmdCRD)
        Me.Controls.Add(Me.cmdEXTCHK)
        Me.Controls.Add(Me.cmdCHK)
        Me.Controls.Add(Me.cmdEXTCSH)
        Me.Controls.Add(Me.cmdCSH)
        Me.Controls.Add(Me.cmdChangeAsTip)
        Me.Controls.Add(Me.cmdGRA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNetDue)
        Me.Controls.Add(Me.txtCHK)
        Me.Controls.Add(Me.txtCRD)
        Me.Controls.Add(Me.txtCSH)
        Me.Controls.Add(Me.txtGRA)
        Me.Controls.Add(Me.txtGuestOwes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdExitWithOutClosing)
        Me.Controls.Add(Me.cmdCloseGuest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CloseTableNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EnterGuestCount"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvGuestList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub Update_Due()
        txtNetDue.Text = FormatCurrency(IIf(txtGuestOwes.Text <> "", txtGuestOwes.Text, 0) - IIf(txtCSH.Text <> "", txtCSH.Text, 0) - IIf(txtCHK.Text <> "", txtCHK.Text, 0) - IIf(txtCRD.Text <> "", txtCRD.Text, 0) - IIf(txtCRT.Text <> "", txtCRT.Text, 0) - IIf(txtGRA.Text <> "", txtGRA.Text, 0) * -1)
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseGuest.Click
        If Not txtNetDue.Text = "" Then
            If Val(txtNetDue.Text) < 0.01 Then
                CHANGE = Val(txtNetDue.Text)

                d.CloseOrder(d.GetOrderNumber(Active.Ticket, dgvGuestList.SelectedRows(0).Cells(0).Value), IIf(txtCHK.Text <> "", txtCHK.Text, 0), IIf(txtCSH.Text <> "", txtCSH.Text, 0), IIf(txtCRD.Text <> "", txtCRD.Text, 0), IIf(txtCRT.Text <> "", txtCRT.Text, 0), CHANGE, IIf(txtGRA.Text <> "", txtGRA.Text, 0))
                SendKeys.Send("/")
                MsgBox("Guest was closed. Change is " & CHANGE)
                Clear_All()
                'insert all open ticket info (table, ticket, order) into closed ticket orders, with payment methods.

                'remove all open ticket info for order

                '    Saved.SavedRST.Edit()
                '    Saved.SavedReTrans.Value = Saved.SavedReTrans.Value + 1
                '    Saved.SavedRST.Update()

                '    Saved.OpenTicketRST.FindFirst("ORDER_NUM = " & Active.Order)
                '    If OpenTicketRST.NoMatch = False Then
                '        'close for table

                '        Saved.OpenTicketRST.MoveFirst()
                '        Do Until Saved.OpenTicketRST.EOF
                '            If Saved.OpenTicketOrderNum.Value = Active.Order Then
                '                Saved.OpenTableInfoRST.FindFirst("RETABLE = " & Saved.CURRETABLE)

                '                Saved.ClosedTicketRST.AddNew()
                '                Saved.ClosedTicketTicketNum.Value = Saved.OpenTicketTicketNum.Value
                '                Saved.ClosedTicketGuestNum.Value = Saved.OpenTicketGuestNum.Value
                '                Saved.ClosedTicketOrderNum.Value = Saved.OpenTicketOrderNum.Value
                '                Saved.ClosedTicketDateIn.Value = Saved.OpenTicketDateIn.Value
                '                Saved.ClosedTicketTimeIn.Value = Saved.OpenTicketTimeIn.Value
                '                Saved.ClosedTicketTipAtBar.Value = Saved.OpenTableInfoTipAtBar.Value
                '                Saved.ClosedTicketTableNum.Value = Saved.OpenTicketTableNum.Value
                '                Saved.ClosedTicketStoolNum.Value = Saved.OpenTicketStoolNum.Value
                '                Saved.ClosedTicketSubTotal.Value = Saved.OpenTicketSubTotal.Value
                '                Saved.ClosedTicketTax.Value = Saved.OpenTicketTax.Value
                '                Saved.ClosedTicketBarTotal.Value = Saved.OpenTicketBarTotal.Value
                '                Saved.ClosedTicketFoodTotal.Value = Saved.OpenTicketFoodTotal.Value
                '                Saved.ClosedTicketTotal.Value = Saved.OpenTicketTotal.Value
                '                Saved.ClosedTicketTimeSat.Value = Saved.OpenTicketTimeSat.Value
                '                Saved.ClosedTicketTippedOn.Value = Saved.OpenTicketTippedOn.Value
                '                Saved.ClosedTicketCheck.Value = Val(txtCHK.Text)
                '                Saved.ClosedTicketCash.Value = Val(txtCSH.Text)
                '                Saved.ClosedTicketCard.Value = Val(txtCRD.Text)
                '                Saved.ClosedTicketGiftCert.Value = Val(txtCRT.Text)
                '                Saved.ClosedTicketTip.Value = Val(txtGRA.Text)
                '                Saved.ClosedTicketChange.Value = CHANGE
                '                Saved.ClosedTicketDateOut.Value = Format(Now(), "Short Date")
                '                Saved.ClosedTicketTimeOut.Value = Format(Now(), "Short Time")
                '                Saved.ClosedTicketReTable.Value = Saved.OpenTicketReTable.Value
                '                Saved.ClosedTicketReTrans.Value = Saved.SavedReTrans.Value
                '                Saved.ClosedTicketRST.Update()
                '                Saved.OpenTicketRST.Delete()
                '            End If
                '            Saved.OpenTicketRST.MoveNext()
                '        Loop

                '        Saved.OpenOrderRST.MoveFirst()
                '        Do Until Saved.OpenOrderRST.EOF
                '            If Saved.OpenOrderOrderNum.Value = Active.Order Then
                '                Saved.ClosedOrderRST.AddNew()
                '                Saved.ClosedOrderOrderNum.Value = Saved.OpenOrderOrderNum.Value
                '                Saved.ClosedOrderLineNum.Value = Saved.OpenOrderLineNum.Value
                '                Saved.ClosedOrderItemNum.Value = Saved.OpenOrderItemNum.Value
                '                Saved.ClosedOrderQuotedPrice.Value = Saved.OpenOrderQuotedPrice.Value
                '                Saved.ClosedOrderReTable.Value = Saved.OpenOrderReTable.Value
                '                Saved.ClosedOrderReTrans.Value = Saved.SavedReTrans.Value
                '                Saved.ClosedOrderRST.Update()
                '                Saved.OpenOrderRST.Delete()
                '            End If
                '            Saved.OpenOrderRST.MoveNext()
                '        Loop

                '        Saved.OpenBarOrderRST.MoveFirst()
                '        Do Until Saved.OpenBarOrderRST.EOF
                '            If Saved.OpenBarOrderOrderNum.Value = Active.Order Then
                '                Saved.ClosedBarOrderRST.AddNew()
                '                Saved.ClosedBarOrderOrderNum.Value = Saved.OpenBarOrderOrderNum.Value
                '                Saved.ClosedBarOrderLineNum.Value = Saved.OpenBarOrderLineNum.Value
                '                Saved.ClosedBarOrderItemNum.Value = Saved.OpenBarOrderItemNum.Value
                '                Saved.ClosedBarOrderQuotedPrice.Value = Saved.OpenBarOrderQuotedPrice.Value
                '                Saved.ClosedBarOrderReTable.Value = Saved.OpenBarOrderReTable.Value
                '                Saved.ClosedBarOrderReTrans.Value = Saved.SavedReTrans.Value
                '                Saved.ClosedBarOrderRST.Update()
                '                Saved.OpenBarOrderRST.Delete()
                '            End If
                '            Saved.OpenBarOrderRST.MoveNext()
                '        Loop
                '    End If

                '    Saved.OpenTicketRST.FindFirst("TABLE_NUM = " & Active.Table)
                '    If Saved.OpenTicketRST.NoMatch = True Then
                '        Saved.OpenTableInfoRST.FindFirst("TABLE_NUM = " & Active.Table)
                '        If Saved.OpenTableInfoRST.NoMatch = False Then
                '            Saved.ClosedTableInfoRST.AddNew()
                '            Saved.ClosedTableInfoTableNum.Value = Saved.OpenTableInfoTableNum.Value
                '            Saved.ClosedTableInfoGuestCount.Value = Saved.OpenTableInfoGuestCount.Value
                '            Saved.ClosedTableInfoEmpNum1.Value = Saved.OpenTableInfoEmpNum1.Value
                '            Saved.ClosedTableInfoEmpNum2.Value = Saved.OpenTableInfoEmpNum2.Value
                '            Saved.ClosedTableInfoDateOut.Value = Format(Now(), "Short Date")
                '            Saved.ClosedTableInfoTimeOut.Value = Format(Now(), "Short Time")
                '            Saved.ClosedTableInfoReTable.Value = Saved.OpenTableInfoReTable.Value
                '            Saved.ClosedTableInfoReTrans.Value = Saved.SavedReTrans.Value
                '            Saved.ClosedTableInfoStoolNum.Value = Saved.OpenTableInfoStoolNum.Value

                '            If Saved.OpenTableInfoTableNum.Value < 25 Then
                '                Saved.OpenTableInfoRST.Edit()
                '                Saved.OpenTableInfoAvailable.Value = True
                '                Saved.OpenTableInfoGuestCount.Value = 0
                '                Saved.OpenTableInfoEmpNum1.Value = 0
                '                Saved.OpenTableInfoEmpNum2.Value = 0
                '                Saved.OpenTableInfoReTable.Value = 0
                '                Saved.OpenTableInfoReTrans.Value = 0
                '                Saved.OpenTableInfoTipAtBar.Value = "DID"
                '                Saved.OpenTableInfoStoolNum.Value = 0
                '                Saved.OpenTableInfoRST.Update()
                '            Else
                '                Saved.OpenTableInfoRST.Delete()
                '            End If

                '            Saved.ClosedTableInfoRST.Update()
                '            'Saved.Clear_Currents()
                '            Saved.GO(1) = True
                '        End If
                '    End If

                '    'close for bar
                '    Saved.OpenTicketRST.FindFirst("STOOL_NUM = " & Active.Stool)
                '    If Saved.OpenTicketRST.NoMatch = True Then
                '        Saved.OpenStoolInfoRST.FindFirst("STOOL_NUM = " & Active.Stool)
                '        If Saved.OpenStoolInfoRST.NoMatch = False Then
                '            Saved.ClosedStoolInfoRST.AddNew()
                '            Saved.ClosedStoolInfoStoolNum.Value = Saved.OpenStoolInfoStoolNum.Value
                '            Saved.ClosedStoolInfoDateOut.Value = Format(Now(), "Short Date")
                '            Saved.ClosedStoolInfoTimeOut.Value = Format(Now(), "Short Time")
                '            Saved.ClosedStoolInfoReTable.Value = Saved.OpenStoolInfoReTable.Value
                '            Saved.ClosedStoolInfoReTrans.Value = Saved.SavedReTrans.Value
                '            Saved.ClosedStoolInfoStoolNum.Value = Saved.OpenStoolInfoStoolNum.Value

                '            Saved.OpenStoolInfoRST.Edit()
                '            Saved.OpenStoolInfoAvailable.Value = True
                '            Saved.OpenStoolInfoReTable.Value = 0
                '            Saved.OpenStoolInfoReTrans.Value = 0

                '            Saved.OpenStoolInfoRST.Update()
                '            Saved.ClosedStoolInfoRST.Update()
                '            'Saved.Clear_Currents()
                '            Saved.GO(1) = True
                '        End If
                '    End If
                '    Dim intFileNo As Integer = FreeFile()
                '    'FileOpen(1, "print.txt", OpenMode.Output)
                '    'PrintLine(1, Chr(25))
                '    'PrintLine(1, Chr(27) + Chr(100) + Chr(51))
                '    'FileClose(1)
                '    'Shell("print /d:\\fireside-bar\star print.txt", AppWinStyle.Hide)
                '    MsgBox("Guest was closed. Change is $" & CHANGE)

                'Else
                '    MsgBox("Guest still owes money.  They are not closed.")
                'End If

            Else
                MsgBox("Guest still owes money.  They are not closed.")
            End If
            Update_Guest()
        End If
    End Sub

    Private Sub cmdExitWithOutClosing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExitWithOutClosing.Click
        Close()
    End Sub

    Private Sub Cash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCSH.Click, cmdCHK.Click, cmdCRD.Click, cmdCRT.Click, cmdGRA.Click, txtCSH.Click, txtCHK.Click, txtCRD.Click, txtCRT.Click, txtGRA.Click
        lblHide.Visible = True
        Dim formNumPad As New NumPad
        Saved.GO(2) = False
        formNumPad.ShowDialog()
        If Saved.GO(2) = True Then
            If Mid(sender.name, 4, 3) = "CSH" Then
                txtCSH.Text = FormatCurrency(Saved.TEMPMONEY)
            End If
            If Mid(sender.name, 4, 3) = "CRD" Then
                txtCRD.Text = FormatCurrency(Saved.TEMPMONEY)
            End If
            If Mid(sender.name, 4, 3) = "CHK" Then
                txtCHK.Text = FormatCurrency(Saved.TEMPMONEY)
            End If
            If Mid(sender.name, 4, 3) = "CRT" Then
                txtCRT.Text = FormatCurrency(Saved.TEMPMONEY)
            End If
            If Mid(sender.name, 4, 3) = "GRA" Then
                txtGRA.Text = FormatCurrency(Saved.TEMPMONEY)
            End If

            Update_Due()
        End If
        lblHide.Visible = False
    End Sub

    Private Sub CloseTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Active.Clear()
        Dim formSelectTable As New SelectTable
        formSelectTable.ShowDialog()
        lblTableName.Text = d.GetTableName(Active.Table)
        Update_Guest()
    End Sub

    Private Sub Update_Guest()
        If data.GetSingleValue("SELECT GUEST_NUM AS Guest, TOTAL AS Total FROM OPEN_TICKET WHERE TICKET_NUM = " & Active.Ticket) <> 0 Then

            dgvGuestList.DataSource = data.GetData("SELECT GUEST_NUM AS Guest, TOTAL AS Total FROM OPEN_TICKET WHERE TICKET_NUM = " & Active.Ticket).Tables(0)



            dgvGuestList.Columns("Guest").Width = 175
            dgvGuestList.Columns("Total").Width = 50

            txtGuestOwes.Text = FormatCurrency(d.GetTotalOwed(d.GetOrderNumber(Active.Ticket, dgvGuestList.SelectedRows(0).Cells(0).Value)))
            'MsgBox(dgvGuestList.RowCount)
        Else
            Close()
            Active.Clear()
            POS.Update_Screen()
        End If


    End Sub

    Public Sub Clear_All()
        txtGuestOwes.Text = ""
        txtCSH.Text = ""
        txtCHK.Text = ""
        txtCRD.Text = ""
        txtCRT.Text = ""
        txtGRA.Text = ""
        txtNetDue.Text = ""
    End Sub

    Private Sub cmdEXTCSH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEXTCSH.Click, cmdEXTCHK.Click, cmdEXTCRD.Click
        If Mid(sender.name, 7, 3) = "CSH" Then
            txtCSH.Text = FormatCurrency(txtGuestOwes.Text)
        End If
        If Mid(sender.name, 7, 3) = "CRD" Then
            txtCRD.Text = FormatCurrency(txtGuestOwes.Text)
        End If
        If Mid(sender.name, 7, 3) = "CHK" Then
            txtCHK.Text = FormatCurrency(txtGuestOwes.Text)
        End If

        Update_Due()
    End Sub

    Private Sub cmdChangeAsTip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeAsTip.Click
        If Val(txtNetDue.Text) < 0.01 Then
            txtGRA.Text = FormatCurrency(txtNetDue.Text * -1)
        Else
            MsgBox("There is no change")
        End If

        Update_Due()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtCSH.Text = ""
        txtCHK.Text = ""
        txtCRD.Text = ""
        txtCRT.Text = ""
        txtGRA.Text = ""
        txtNetDue.Text = ""
    End Sub

    Private Sub dgvGuestList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGuestList.CellClick
        Clear_All()
        txtGuestOwes.Text = FormatCurrency(d.GetTotalOwed(d.GetOrderNumber(Active.Ticket, dgvGuestList.SelectedRows(0).Cells(0).Value)))
    End Sub
End Class
