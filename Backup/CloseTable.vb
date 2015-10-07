Public Class oldCloseTable
    Inherits System.Windows.Forms.Form
    Dim CHANGE As Double
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
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmd2 As System.Windows.Forms.Button
    Friend WithEvents cmd3 As System.Windows.Forms.Button
    Friend WithEvents cmd4 As System.Windows.Forms.Button
    Friend WithEvents cmd5 As System.Windows.Forms.Button
    Friend WithEvents cmd6 As System.Windows.Forms.Button
    Friend WithEvents cmd7 As System.Windows.Forms.Button
    Friend WithEvents cmd8 As System.Windows.Forms.Button
    Friend WithEvents cmd9 As System.Windows.Forms.Button
    Friend WithEvents cmd0 As System.Windows.Forms.Button
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents cmdCloseGuest As System.Windows.Forms.Button
    Friend WithEvents cmdExitWithOutClosing As System.Windows.Forms.Button
    Friend WithEvents cmdPeriod As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents pnlNumbers As System.Windows.Forms.Panel
    Friend WithEvents pnlDollars As System.Windows.Forms.Panel
    Friend WithEvents cmdD100 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTableName As System.Windows.Forms.Label
    Friend WithEvents lstGNPK As System.Windows.Forms.ListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lstGN As System.Windows.Forms.ListBox
    Friend WithEvents txtGuestOwes As System.Windows.Forms.TextBox
    Friend WithEvents txtGratuity As System.Windows.Forms.TextBox
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtCard As System.Windows.Forms.TextBox
    Friend WithEvents txtCheck As System.Windows.Forms.TextBox
    Friend WithEvents txtNetDue As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdChangeAsTip As System.Windows.Forms.Button
    Friend WithEvents txtGiftCertificate As System.Windows.Forms.TextBox
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents cmdD050 As System.Windows.Forms.Button
    Friend WithEvents cmdD001 As System.Windows.Forms.Button
    Friend WithEvents cmdD005 As System.Windows.Forms.Button
    Friend WithEvents cmdD010 As System.Windows.Forms.Button
    Friend WithEvents cmdD020 As System.Windows.Forms.Button
    Friend WithEvents cmdGRA As System.Windows.Forms.Button
    Friend WithEvents cmdCSH As System.Windows.Forms.Button
    Friend WithEvents cmdEXTCSH As System.Windows.Forms.Button
    Friend WithEvents cmdCHK As System.Windows.Forms.Button
    Friend WithEvents cmdEXTCHK As System.Windows.Forms.Button
    Friend WithEvents cmdCRD As System.Windows.Forms.Button
    Friend WithEvents cmdCRT As System.Windows.Forms.Button
    Friend WithEvents cmdEXTCRD As System.Windows.Forms.Button
    Friend WithEvents lstTotal As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmd1 = New System.Windows.Forms.Button
        Me.cmd2 = New System.Windows.Forms.Button
        Me.cmd3 = New System.Windows.Forms.Button
        Me.cmd4 = New System.Windows.Forms.Button
        Me.cmd5 = New System.Windows.Forms.Button
        Me.cmd6 = New System.Windows.Forms.Button
        Me.cmd7 = New System.Windows.Forms.Button
        Me.cmd8 = New System.Windows.Forms.Button
        Me.cmd9 = New System.Windows.Forms.Button
        Me.cmd0 = New System.Windows.Forms.Button
        Me.txtValue = New System.Windows.Forms.TextBox
        Me.lblValue = New System.Windows.Forms.Label
        Me.cmdCloseGuest = New System.Windows.Forms.Button
        Me.cmdExitWithOutClosing = New System.Windows.Forms.Button
        Me.cmdPeriod = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
        Me.pnlNumbers = New System.Windows.Forms.Panel
        Me.pnlDollars = New System.Windows.Forms.Panel
        Me.cmdD100 = New System.Windows.Forms.Button
        Me.cmdD050 = New System.Windows.Forms.Button
        Me.cmdD001 = New System.Windows.Forms.Button
        Me.cmdD005 = New System.Windows.Forms.Button
        Me.cmdD010 = New System.Windows.Forms.Button
        Me.cmdD020 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblTableName = New System.Windows.Forms.Label
        Me.lstGNPK = New System.Windows.Forms.ListBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lstTotal = New System.Windows.Forms.ListBox
        Me.lstGN = New System.Windows.Forms.ListBox
        Me.txtGuestOwes = New System.Windows.Forms.TextBox
        Me.txtGratuity = New System.Windows.Forms.TextBox
        Me.txtCash = New System.Windows.Forms.TextBox
        Me.txtCard = New System.Windows.Forms.TextBox
        Me.txtCheck = New System.Windows.Forms.TextBox
        Me.txtNetDue = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdGRA = New System.Windows.Forms.Button
        Me.cmdChangeAsTip = New System.Windows.Forms.Button
        Me.cmdCSH = New System.Windows.Forms.Button
        Me.cmdEXTCSH = New System.Windows.Forms.Button
        Me.cmdCHK = New System.Windows.Forms.Button
        Me.cmdEXTCHK = New System.Windows.Forms.Button
        Me.cmdCRD = New System.Windows.Forms.Button
        Me.cmdCRT = New System.Windows.Forms.Button
        Me.cmdEXTCRD = New System.Windows.Forms.Button
        Me.txtGiftCertificate = New System.Windows.Forms.TextBox
        Me.pnlNumbers.SuspendLayout()
        Me.pnlDollars.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd1
        '
        Me.cmd1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd1.Location = New System.Drawing.Point(8, 8)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(88, 80)
        Me.cmd1.TabIndex = 0
        Me.cmd1.Text = "1"
        '
        'cmd2
        '
        Me.cmd2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd2.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd2.Location = New System.Drawing.Point(112, 8)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(88, 80)
        Me.cmd2.TabIndex = 1
        Me.cmd2.Text = "2"
        '
        'cmd3
        '
        Me.cmd3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd3.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd3.Location = New System.Drawing.Point(216, 8)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(88, 80)
        Me.cmd3.TabIndex = 2
        Me.cmd3.Text = "3"
        '
        'cmd4
        '
        Me.cmd4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd4.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd4.Location = New System.Drawing.Point(8, 104)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(88, 80)
        Me.cmd4.TabIndex = 3
        Me.cmd4.Text = "4"
        '
        'cmd5
        '
        Me.cmd5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd5.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd5.Location = New System.Drawing.Point(112, 104)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(88, 80)
        Me.cmd5.TabIndex = 4
        Me.cmd5.Text = "5"
        '
        'cmd6
        '
        Me.cmd6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd6.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd6.Location = New System.Drawing.Point(216, 104)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(88, 80)
        Me.cmd6.TabIndex = 5
        Me.cmd6.Text = "6"
        '
        'cmd7
        '
        Me.cmd7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd7.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd7.Location = New System.Drawing.Point(8, 200)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(88, 80)
        Me.cmd7.TabIndex = 6
        Me.cmd7.Text = "7"
        '
        'cmd8
        '
        Me.cmd8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd8.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd8.Location = New System.Drawing.Point(112, 200)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(88, 80)
        Me.cmd8.TabIndex = 7
        Me.cmd8.Text = "8"
        '
        'cmd9
        '
        Me.cmd9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd9.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd9.Location = New System.Drawing.Point(216, 200)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(88, 80)
        Me.cmd9.TabIndex = 8
        Me.cmd9.Text = "9"
        '
        'cmd0
        '
        Me.cmd0.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd0.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd0.Location = New System.Drawing.Point(8, 296)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(88, 80)
        Me.cmd0.TabIndex = 9
        Me.cmd0.Text = "0"
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtValue.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(136, 392)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(152, 27)
        Me.txtValue.TabIndex = 10
        Me.txtValue.Text = ""
        '
        'lblValue
        '
        Me.lblValue.BackColor = System.Drawing.Color.Transparent
        Me.lblValue.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(24, 392)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(96, 32)
        Me.lblValue.TabIndex = 11
        Me.lblValue.Text = "Value:"
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdCloseGuest
        '
        Me.cmdCloseGuest.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCloseGuest.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseGuest.ForeColor = System.Drawing.Color.Green
        Me.cmdCloseGuest.Location = New System.Drawing.Point(16, 592)
        Me.cmdCloseGuest.Name = "cmdCloseGuest"
        Me.cmdCloseGuest.Size = New System.Drawing.Size(296, 48)
        Me.cmdCloseGuest.TabIndex = 13
        Me.cmdCloseGuest.Text = "Close Guest"
        '
        'cmdExitWithOutClosing
        '
        Me.cmdExitWithOutClosing.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdExitWithOutClosing.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExitWithOutClosing.ForeColor = System.Drawing.Color.Maroon
        Me.cmdExitWithOutClosing.Location = New System.Drawing.Point(16, 528)
        Me.cmdExitWithOutClosing.Name = "cmdExitWithOutClosing"
        Me.cmdExitWithOutClosing.Size = New System.Drawing.Size(296, 48)
        Me.cmdExitWithOutClosing.TabIndex = 14
        Me.cmdExitWithOutClosing.Text = "Exit without closing"
        '
        'cmdPeriod
        '
        Me.cmdPeriod.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdPeriod.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPeriod.Location = New System.Drawing.Point(112, 296)
        Me.cmdPeriod.Name = "cmdPeriod"
        Me.cmdPeriod.Size = New System.Drawing.Size(88, 80)
        Me.cmdPeriod.TabIndex = 15
        Me.cmdPeriod.Text = "."
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdClear.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(216, 296)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(88, 80)
        Me.cmdClear.TabIndex = 16
        Me.cmdClear.Text = "Clear"
        '
        'pnlNumbers
        '
        Me.pnlNumbers.BackColor = System.Drawing.Color.RosyBrown
        Me.pnlNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNumbers.Controls.Add(Me.cmdPeriod)
        Me.pnlNumbers.Controls.Add(Me.cmdClear)
        Me.pnlNumbers.Controls.Add(Me.cmd1)
        Me.pnlNumbers.Controls.Add(Me.cmd2)
        Me.pnlNumbers.Controls.Add(Me.cmd3)
        Me.pnlNumbers.Controls.Add(Me.cmd4)
        Me.pnlNumbers.Controls.Add(Me.cmd5)
        Me.pnlNumbers.Controls.Add(Me.cmd6)
        Me.pnlNumbers.Controls.Add(Me.cmd7)
        Me.pnlNumbers.Controls.Add(Me.cmd8)
        Me.pnlNumbers.Controls.Add(Me.cmd9)
        Me.pnlNumbers.Controls.Add(Me.cmd0)
        Me.pnlNumbers.Controls.Add(Me.txtValue)
        Me.pnlNumbers.Controls.Add(Me.lblValue)
        Me.pnlNumbers.Location = New System.Drawing.Point(8, 88)
        Me.pnlNumbers.Name = "pnlNumbers"
        Me.pnlNumbers.Size = New System.Drawing.Size(312, 424)
        Me.pnlNumbers.TabIndex = 17
        '
        'pnlDollars
        '
        Me.pnlDollars.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.pnlDollars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDollars.Controls.Add(Me.cmdD100)
        Me.pnlDollars.Controls.Add(Me.cmdD050)
        Me.pnlDollars.Controls.Add(Me.cmdD001)
        Me.pnlDollars.Controls.Add(Me.cmdD005)
        Me.pnlDollars.Controls.Add(Me.cmdD010)
        Me.pnlDollars.Controls.Add(Me.cmdD020)
        Me.pnlDollars.Location = New System.Drawing.Point(328, 88)
        Me.pnlDollars.Name = "pnlDollars"
        Me.pnlDollars.Size = New System.Drawing.Size(120, 424)
        Me.pnlDollars.TabIndex = 18
        '
        'cmdD100
        '
        Me.cmdD100.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdD100.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdD100.Location = New System.Drawing.Point(8, 356)
        Me.cmdD100.Name = "cmdD100"
        Me.cmdD100.Size = New System.Drawing.Size(104, 56)
        Me.cmdD100.TabIndex = 5
        Me.cmdD100.Text = "$100"
        '
        'cmdD050
        '
        Me.cmdD050.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdD050.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdD050.Location = New System.Drawing.Point(8, 288)
        Me.cmdD050.Name = "cmdD050"
        Me.cmdD050.Size = New System.Drawing.Size(104, 56)
        Me.cmdD050.TabIndex = 4
        Me.cmdD050.Text = "$50"
        '
        'cmdD001
        '
        Me.cmdD001.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdD001.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdD001.Location = New System.Drawing.Point(8, 220)
        Me.cmdD001.Name = "cmdD001"
        Me.cmdD001.Size = New System.Drawing.Size(104, 56)
        Me.cmdD001.TabIndex = 3
        Me.cmdD001.Text = "$1"
        '
        'cmdD005
        '
        Me.cmdD005.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdD005.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdD005.Location = New System.Drawing.Point(8, 152)
        Me.cmdD005.Name = "cmdD005"
        Me.cmdD005.Size = New System.Drawing.Size(104, 56)
        Me.cmdD005.TabIndex = 2
        Me.cmdD005.Text = "$5"
        '
        'cmdD010
        '
        Me.cmdD010.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdD010.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdD010.Location = New System.Drawing.Point(8, 84)
        Me.cmdD010.Name = "cmdD010"
        Me.cmdD010.Size = New System.Drawing.Size(104, 56)
        Me.cmdD010.TabIndex = 1
        Me.cmdD010.Text = "$10"
        '
        'cmdD020
        '
        Me.cmdD020.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdD020.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdD020.Location = New System.Drawing.Point(8, 16)
        Me.cmdD020.Name = "cmdD020"
        Me.cmdD020.Size = New System.Drawing.Size(104, 56)
        Me.cmdD020.TabIndex = 0
        Me.cmdD020.Text = "$20"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Panel1.Controls.Add(Me.lblTableName)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 80)
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
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Panel2.Controls.Add(Me.lstTotal)
        Me.Panel2.Controls.Add(Me.lstGN)
        Me.Panel2.Controls.Add(Me.lstGNPK)
        Me.Panel2.Location = New System.Drawing.Point(456, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 152)
        Me.Panel2.TabIndex = 20
        '
        'lstTotal
        '
        Me.lstTotal.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTotal.ItemHeight = 23
        Me.lstTotal.Location = New System.Drawing.Point(112, 16)
        Me.lstTotal.Name = "lstTotal"
        Me.lstTotal.Size = New System.Drawing.Size(280, 119)
        Me.lstTotal.TabIndex = 22
        '
        'lstGN
        '
        Me.lstGN.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGN.ItemHeight = 23
        Me.lstGN.Location = New System.Drawing.Point(56, 16)
        Me.lstGN.Name = "lstGN"
        Me.lstGN.Size = New System.Drawing.Size(56, 119)
        Me.lstGN.TabIndex = 21
        '
        'txtGuestOwes
        '
        Me.txtGuestOwes.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtGuestOwes.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestOwes.Location = New System.Drawing.Point(640, 160)
        Me.txtGuestOwes.Name = "txtGuestOwes"
        Me.txtGuestOwes.Size = New System.Drawing.Size(152, 27)
        Me.txtGuestOwes.TabIndex = 23
        Me.txtGuestOwes.Text = ""
        '
        'txtGratuity
        '
        Me.txtGratuity.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtGratuity.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGratuity.Location = New System.Drawing.Point(680, 472)
        Me.txtGratuity.Name = "txtGratuity"
        Me.txtGratuity.Size = New System.Drawing.Size(152, 27)
        Me.txtGratuity.TabIndex = 24
        Me.txtGratuity.Text = ""
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCash.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(680, 216)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(152, 27)
        Me.txtCash.TabIndex = 25
        Me.txtCash.Text = ""
        '
        'txtCard
        '
        Me.txtCard.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCard.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCard.Location = New System.Drawing.Point(680, 344)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Size = New System.Drawing.Size(152, 27)
        Me.txtCard.TabIndex = 26
        Me.txtCard.Text = ""
        '
        'txtCheck
        '
        Me.txtCheck.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCheck.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheck.Location = New System.Drawing.Point(680, 280)
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(152, 27)
        Me.txtCheck.TabIndex = 27
        Me.txtCheck.Text = ""
        '
        'txtNetDue
        '
        Me.txtNetDue.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtNetDue.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetDue.Location = New System.Drawing.Point(640, 579)
        Me.txtNetDue.Name = "txtNetDue"
        Me.txtNetDue.Size = New System.Drawing.Size(152, 27)
        Me.txtNetDue.TabIndex = 28
        Me.txtNetDue.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(464, 160)
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
        Me.Label2.Location = New System.Drawing.Point(480, 576)
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
        Me.cmdGRA.Location = New System.Drawing.Point(456, 456)
        Me.cmdGRA.Name = "cmdGRA"
        Me.cmdGRA.Size = New System.Drawing.Size(104, 56)
        Me.cmdGRA.TabIndex = 31
        Me.cmdGRA.Text = "Gratuity"
        '
        'cmdChangeAsTip
        '
        Me.cmdChangeAsTip.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdChangeAsTip.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChangeAsTip.Location = New System.Drawing.Point(568, 456)
        Me.cmdChangeAsTip.Name = "cmdChangeAsTip"
        Me.cmdChangeAsTip.Size = New System.Drawing.Size(104, 56)
        Me.cmdChangeAsTip.TabIndex = 32
        Me.cmdChangeAsTip.Text = "Use Change As Tip"
        '
        'cmdCSH
        '
        Me.cmdCSH.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCSH.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCSH.Location = New System.Drawing.Point(456, 200)
        Me.cmdCSH.Name = "cmdCSH"
        Me.cmdCSH.Size = New System.Drawing.Size(104, 56)
        Me.cmdCSH.TabIndex = 33
        Me.cmdCSH.Text = "Cash"
        '
        'cmdEXTCSH
        '
        Me.cmdEXTCSH.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEXTCSH.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEXTCSH.Location = New System.Drawing.Point(568, 200)
        Me.cmdEXTCSH.Name = "cmdEXTCSH"
        Me.cmdEXTCSH.Size = New System.Drawing.Size(104, 56)
        Me.cmdEXTCSH.TabIndex = 34
        Me.cmdEXTCSH.Text = "Exact Cash"
        '
        'cmdCHK
        '
        Me.cmdCHK.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCHK.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCHK.Location = New System.Drawing.Point(456, 264)
        Me.cmdCHK.Name = "cmdCHK"
        Me.cmdCHK.Size = New System.Drawing.Size(104, 56)
        Me.cmdCHK.TabIndex = 35
        Me.cmdCHK.Text = "Check"
        '
        'cmdEXTCHK
        '
        Me.cmdEXTCHK.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEXTCHK.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEXTCHK.Location = New System.Drawing.Point(568, 264)
        Me.cmdEXTCHK.Name = "cmdEXTCHK"
        Me.cmdEXTCHK.Size = New System.Drawing.Size(104, 56)
        Me.cmdEXTCHK.TabIndex = 36
        Me.cmdEXTCHK.Text = "Exact Check"
        '
        'cmdCRD
        '
        Me.cmdCRD.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCRD.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCRD.Location = New System.Drawing.Point(456, 328)
        Me.cmdCRD.Name = "cmdCRD"
        Me.cmdCRD.Size = New System.Drawing.Size(104, 56)
        Me.cmdCRD.TabIndex = 37
        Me.cmdCRD.Text = "Card"
        '
        'cmdCRT
        '
        Me.cmdCRT.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCRT.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCRT.Location = New System.Drawing.Point(456, 392)
        Me.cmdCRT.Name = "cmdCRT"
        Me.cmdCRT.Size = New System.Drawing.Size(216, 56)
        Me.cmdCRT.TabIndex = 38
        Me.cmdCRT.Text = "Gift Certificate"
        '
        'cmdEXTCRD
        '
        Me.cmdEXTCRD.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEXTCRD.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEXTCRD.Location = New System.Drawing.Point(568, 328)
        Me.cmdEXTCRD.Name = "cmdEXTCRD"
        Me.cmdEXTCRD.Size = New System.Drawing.Size(104, 56)
        Me.cmdEXTCRD.TabIndex = 39
        Me.cmdEXTCRD.Text = "Exact Card"
        '
        'txtGiftCertificate
        '
        Me.txtGiftCertificate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtGiftCertificate.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiftCertificate.Location = New System.Drawing.Point(680, 408)
        Me.txtGiftCertificate.Name = "txtGiftCertificate"
        Me.txtGiftCertificate.Size = New System.Drawing.Size(152, 27)
        Me.txtGiftCertificate.TabIndex = 40
        Me.txtGiftCertificate.Text = ""
        '
        'CloseTable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(896, 656)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtGiftCertificate)
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
        Me.Controls.Add(Me.txtCheck)
        Me.Controls.Add(Me.txtCard)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.txtGratuity)
        Me.Controls.Add(Me.txtGuestOwes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlDollars)
        Me.Controls.Add(Me.pnlNumbers)
        Me.Controls.Add(Me.cmdExitWithOutClosing)
        Me.Controls.Add(Me.cmdCloseGuest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CloseTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EnterGuestCount"
        Me.pnlNumbers.ResumeLayout(False)
        Me.pnlDollars.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub Update_Due()
        txtNetDue.Text = Format(Val(txtGuestOwes.Text) - Val(txtCash.Text) - Val(txtCheck.Text) - Val(txtCard.Text) - Val(txtGiftCertificate.Text) - Val(txtGratuity.Text) * -1, "0.00")
    End Sub

    Public Sub Update_Value(ByVal X As Integer)
        txtValue.Text = txtValue.Text & Str(X)
    End Sub

    Private Sub Number_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click, cmd2.Click, cmd3.Click, cmd4.Click, cmd5.Click, cmd6.Click, cmd7.Click, cmd8.Click, cmd9.Click, cmd0.Click
        If DEC < 3 Then
            Update_Value(Mid(sender.name, 4, 1))
        End If
        If DEC = 2 Then DEC = 3
        If DEC = 1 Then DEC = 2
    End Sub

    Private Sub Clear_Value(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtValue.Text = ""
        DEC = 0
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseGuest.Click
        If Not txtNetDue.Text = "" Then
            If Val(txtNetDue.Text) < 0.01 Then
                CHANGE = Val(txtNetDue.Text)

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

                Saved.SavedRST.Edit()
                Saved.SavedReTrans.Value = Saved.SavedReTrans.Value + 1
                Saved.SavedRST.Update()

                Saved.OpenTicketRST.FindFirst("ORDER_NUM = " & Saved.CURORDER)
                If OpenTicketRST.NoMatch = False Then
                    'close for table

                    Saved.OpenTicketRST.MoveFirst()
                    Do Until Saved.OpenTicketRST.EOF
                        If Saved.OpenTicketOrderNum.Value = Saved.CURORDER Then
                            Saved.OpenTableInfoRST.FindFirst("RETABLE = " & Saved.CURRETABLE)

                            Saved.ClosedTicketRST.AddNew()
                            Saved.ClosedTicketTicketNum.Value = Saved.OpenTicketTicketNum.Value
                            Saved.ClosedTicketGuestNum.Value = Saved.OpenTicketGuestNum.Value
                            Saved.ClosedTicketOrderNum.Value = Saved.OpenTicketOrderNum.Value
                            Saved.ClosedTicketDateIn.Value = Saved.OpenTicketDateIn.Value
                            Saved.ClosedTicketTimeIn.Value = Saved.OpenTicketTimeIn.Value
                            Saved.ClosedTicketTipAtBar.Value = Saved.OpenTableInfoTipAtBar.Value
                            Saved.ClosedTicketTableNum.Value = Saved.OpenTicketTableNum.Value
                            Saved.ClosedTicketStoolNum.Value = Saved.OpenTicketStoolNum.Value
                            Saved.ClosedTicketSubTotal.Value = Saved.OpenTicketSubTotal.Value
                            Saved.ClosedTicketTax.Value = Saved.OpenTicketTax.Value
                            Saved.ClosedTicketBarTotal.Value = Saved.OpenTicketBarTotal.Value
                            Saved.ClosedTicketFoodTotal.Value = Saved.OpenTicketFoodTotal.Value
                            Saved.ClosedTicketTotal.Value = Saved.OpenTicketTotal.Value
                            Saved.ClosedTicketTimeSat.Value = Saved.OpenTicketTimeSat.Value
                            Saved.ClosedTicketTippedOn.Value = Saved.OpenTicketTippedOn.Value
                            Saved.ClosedTicketCheck.Value = Val(txtCheck.Text)
                            Saved.ClosedTicketCash.Value = Val(txtCash.Text)
                            Saved.ClosedTicketCard.Value = Val(txtCard.Text)
                            Saved.ClosedTicketGiftCert.Value = Val(txtGiftCertificate.Text)
                            Saved.ClosedTicketTip.Value = Val(txtGratuity.Text)
                            Saved.ClosedTicketChange.Value = CHANGE
                            Saved.ClosedTicketDateOut.Value = Format(Now(), "Short Date")
                            Saved.ClosedTicketTimeOut.Value = Format(Now(), "Short Time")
                            Saved.ClosedTicketReTable.Value = Saved.OpenTicketReTable.Value
                            Saved.ClosedTicketReTrans.Value = Saved.SavedReTrans.Value
                            Saved.ClosedTicketRST.Update()
                            Saved.OpenTicketRST.Delete()
                        End If
                        Saved.OpenTicketRST.MoveNext()
                    Loop

                    Saved.OpenOrderRST.MoveFirst()
                    Do Until Saved.OpenOrderRST.EOF
                        If Saved.OpenOrderOrderNum.Value = Saved.CURORDER Then
                            Saved.ClosedOrderRST.AddNew()
                            Saved.ClosedOrderOrderNum.Value = Saved.OpenOrderOrderNum.Value
                            Saved.ClosedOrderLineNum.Value = Saved.OpenOrderLineNum.Value
                            Saved.ClosedOrderItemNum.Value = Saved.OpenOrderItemNum.Value
                            Saved.ClosedOrderQuotedPrice.Value = Saved.OpenOrderQuotedPrice.Value
                            Saved.ClosedOrderReTable.Value = Saved.OpenOrderReTable.Value
                            Saved.ClosedOrderReTrans.Value = Saved.SavedReTrans.Value
                            Saved.ClosedOrderRST.Update()
                            Saved.OpenOrderRST.Delete()
                        End If
                        Saved.OpenOrderRST.MoveNext()
                    Loop

                    Saved.OpenBarOrderRST.MoveFirst()
                    Do Until Saved.OpenBarOrderRST.EOF
                        If Saved.OpenBarOrderOrderNum.Value = Saved.CURORDER Then
                            Saved.ClosedBarOrderRST.AddNew()
                            Saved.ClosedBarOrderOrderNum.Value = Saved.OpenBarOrderOrderNum.Value
                            Saved.ClosedBarOrderLineNum.Value = Saved.OpenBarOrderLineNum.Value
                            Saved.ClosedBarOrderItemNum.Value = Saved.OpenBarOrderItemNum.Value
                            Saved.ClosedBarOrderQuotedPrice.Value = Saved.OpenBarOrderQuotedPrice.Value
                            Saved.ClosedBarOrderReTable.Value = Saved.OpenBarOrderReTable.Value
                            Saved.ClosedBarOrderReTrans.Value = Saved.SavedReTrans.Value
                            Saved.ClosedBarOrderRST.Update()
                            Saved.OpenBarOrderRST.Delete()
                        End If
                        Saved.OpenBarOrderRST.MoveNext()
                    Loop
                End If

                Saved.OpenTicketRST.FindFirst("TABLE_NUM = " & Saved.CURTABLE)
                If Saved.OpenTicketRST.NoMatch = True Then
                    Saved.OpenTableInfoRST.FindFirst("TABLE_NUM = " & Saved.CURTABLE)
                    If Saved.OpenTableInfoRST.NoMatch = False Then
                        Saved.ClosedTableInfoRST.AddNew()
                        Saved.ClosedTableInfoTableNum.Value = Saved.OpenTableInfoTableNum.Value
                        Saved.ClosedTableInfoGuestCount.Value = Saved.OpenTableInfoGuestCount.Value
                        Saved.ClosedTableInfoEmpNum1.Value = Saved.OpenTableInfoEmpNum1.Value
                        Saved.ClosedTableInfoEmpNum2.Value = Saved.OpenTableInfoEmpNum2.Value
                        Saved.ClosedTableInfoDateOut.Value = Format(Now(), "Short Date")
                        Saved.ClosedTableInfoTimeOut.Value = Format(Now(), "Short Time")
                        Saved.ClosedTableInfoReTable.Value = Saved.OpenTableInfoReTable.Value
                        Saved.ClosedTableInfoReTrans.Value = Saved.SavedReTrans.Value
                        Saved.ClosedTableInfoStoolNum.Value = Saved.OpenTableInfoStoolNum.Value

                        If Saved.OpenTableInfoTableNum.Value < 25 Then
                            Saved.OpenTableInfoRST.Edit()
                            Saved.OpenTableInfoAvailable.Value = True
                            Saved.OpenTableInfoGuestCount.Value = 0
                            Saved.OpenTableInfoEmpNum1.Value = 0
                            Saved.OpenTableInfoEmpNum2.Value = 0
                            Saved.OpenTableInfoReTable.Value = 0
                            Saved.OpenTableInfoReTrans.Value = 0
                            Saved.OpenTableInfoTipAtBar.Value = "DID"
                            Saved.OpenTableInfoStoolNum.Value = 0
                            Saved.OpenTableInfoRST.Update()
                        Else
                            Saved.OpenTableInfoRST.Delete()
                        End If

                        Saved.ClosedTableInfoRST.Update()
                        'Saved.Clear_Currents()
                        Saved.GO(1) = True
                    End If
                End If

                'close for bar
                Saved.OpenTicketRST.FindFirst("STOOL_NUM = " & Saved.CURSTOOL)
                If Saved.OpenTicketRST.NoMatch = True Then
                    Saved.OpenStoolInfoRST.FindFirst("STOOL_NUM = " & Saved.CURSTOOL)
                    If Saved.OpenStoolInfoRST.NoMatch = False Then
                        Saved.ClosedStoolInfoRST.AddNew()
                        Saved.ClosedStoolInfoStoolNum.Value = Saved.OpenStoolInfoStoolNum.Value
                        Saved.ClosedStoolInfoDateOut.Value = Format(Now(), "Short Date")
                        Saved.ClosedStoolInfoTimeOut.Value = Format(Now(), "Short Time")
                        Saved.ClosedStoolInfoReTable.Value = Saved.OpenStoolInfoReTable.Value
                        Saved.ClosedStoolInfoReTrans.Value = Saved.SavedReTrans.Value
                        Saved.ClosedStoolInfoStoolNum.Value = Saved.OpenStoolInfoStoolNum.Value

                        Saved.OpenStoolInfoRST.Edit()
                        Saved.OpenStoolInfoAvailable.Value = True
                        Saved.OpenStoolInfoReTable.Value = 0
                        Saved.OpenStoolInfoReTrans.Value = 0

                        Saved.OpenStoolInfoRST.Update()
                        Saved.ClosedStoolInfoRST.Update()
                        'Saved.Clear_Currents()
                        Saved.GO(1) = True
                    End If
                End If
                Dim intFileNo As Integer = FreeFile()
                'FileOpen(1, "print.txt", OpenMode.Output)
                'PrintLine(1, Chr(25))
                'PrintLine(1, Chr(27) + Chr(100) + Chr(51))
                'FileClose(1)
                'Shell("print /d:\\fireside-bar\star print.txt", AppWinStyle.Hide)
                MsgBox("Guest was closed. Change is $" & CHANGE)

            Else
                MsgBox("Guest still owes money.  They are not closed.")
            End If

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
            Update_Guest()
        End If
    End Sub

    Private Sub cmdPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPeriod.Click
        txtValue.Text = txtValue.Text & "."
        DEC = 1
    End Sub

    Private Sub cmdExitWithOutClosing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExitWithOutClosing.Click
        Close()
    End Sub

    Private Sub Cash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCSH.Click, cmdCHK.Click, cmdCRD.Click, cmdCRT.Click, cmdGRA.Click
        If Mid(sender.name, 4, 3) = "CSH" Then
            txtCash.Text = Format(Val(txtValue.Text), "0.00")
            Clear_Value(sender, e)
        End If
        If Mid(sender.name, 4, 3) = "CRD" Then
            txtCard.Text = Format(Val(txtValue.Text), "0.00")
            Clear_Value(sender, e)
        End If
        If Mid(sender.name, 4, 3) = "CHK" Then
            txtCheck.Text = Format(Val(txtValue.Text), "0.00")
            Clear_Value(sender, e)
        End If
        If Mid(sender.name, 4, 3) = "CRT" Then
            txtGiftCertificate.Text = Format(Val(txtValue.Text), "0.00")
            Clear_Value(sender, e)
        End If
        If Mid(sender.name, 4, 3) = "GRA" Then
            txtGratuity.Text = Format(Val(txtValue.Text), "0.00")
            Clear_Value(sender, e)
        End If

        Update_Due()
    End Sub

    Private Sub cmdD020_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdD050.Click, cmdD100.Click, cmdD020.Click, cmdD010.Click, cmdD005.Click, cmdD001.Click
        txtValue.Text = Val(txtValue.Text) + Mid(sender.name, 5, 3)
    End Sub

    Private Sub CloseTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTableName.Text = Saved.CURTABLENAME
        Update_Guest()
    End Sub

    Private Sub Update_Guest()
        'Open used tables
        Saved.Database_Connect()
        Saved.OpenTicket_Open()

        'Clear listboxes
        lstGNPK.Items.Clear()
        lstGN.Items.Clear()
        lstTotal.Items.Clear()

        Saved.GO(0) = False
        Saved.OpenTicketRST.MoveFirst()
        Do Until Saved.OpenTicketRST.EOF
            If Saved.OpenTicketReTable.Value = Saved.CURRETABLE Then
                lstGNPK.Items.Add(Saved.OpenTicketOrderNum.Value)
                lstGN.Items.Add(Saved.OpenTicketGuestNum.Value)
                lstTotal.Items.Add(Format(Saved.OpenTicketTotal.Value, "Currency"))
                Saved.GO(0) = True
            End If
            Saved.OpenTicketRST.MoveNext()
        Loop

        Saved.OpenTicket_Close()
        Saved.Database_Disconnect()
        If Saved.GO(0) = True Then
            lstGN.SelectedIndex = 0
        Else
            Close()
        End If

    End Sub

    Private Sub lstTotal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTotal.SelectedIndexChanged
        lstGN.SelectedIndex = lstTotal.SelectedIndex
        lstGNPK.SelectedIndex = lstTotal.SelectedIndex
        Guest_Selected()
    End Sub

    Private Sub lstGN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstGN.SelectedIndexChanged
        lstTotal.SelectedIndex = lstGN.SelectedIndex
        lstGNPK.SelectedIndex = lstGN.SelectedIndex
        Guest_Selected()
    End Sub

    Public Sub Guest_Selected()
        Clear_All()
        Saved.Database_Connect()
        Saved.OpenTicket_Open()

        Saved.OpenTicketRST.FindFirst("ORDER_NUM = " & lstGNPK.SelectedItem)
        If Saved.OpenTicketRST.NoMatch = False Then
            txtGuestOwes.Text = Format(Saved.OpenTicketTotal.Value, "0.00")
            Saved.CURORDER = Saved.OpenTicketOrderNum.Value
        End If

        Saved.OpenTicket_Close()
        Saved.Database_Disconnect()
    End Sub

    Public Sub Clear_All()
        txtGuestOwes.Text = ""
        txtValue.Text = ""
        txtCash.Text = ""
        txtCheck.Text = ""
        txtCard.Text = ""
        txtGiftCertificate.Text = ""
        txtGratuity.Text = ""
        txtNetDue.Text = ""
    End Sub

    Private Sub cmdEXTCSH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEXTCSH.Click, cmdEXTCHK.Click, cmdEXTCRD.Click
        If Mid(sender.name, 7, 3) = "CSH" Then
            txtCash.Text = Format(Val(txtGuestOwes.Text), "0.00")
            Clear_Value(sender, e)
        End If
        If Mid(sender.name, 7, 3) = "CRD" Then
            txtCard.Text = Format(Val(txtGuestOwes.Text), "0.00")
            Clear_Value(sender, e)
        End If
        If Mid(sender.name, 7, 3) = "CHK" Then
            txtCheck.Text = Format(Val(txtGuestOwes.Text), "0.00")
            Clear_Value(sender, e)
        End If

        Update_Due()
    End Sub

    Private Sub cmdChangeAsTip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeAsTip.Click
        If Val(txtNetDue.Text) < 0.01 Then
            txtGratuity.Text = Format(Val(txtNetDue.Text) * -1, "0.00")
        Else
            MsgBox("There is no change")
        End If

        Update_Due()
    End Sub
End Class
