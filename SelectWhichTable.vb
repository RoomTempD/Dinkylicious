Public Class SelectWhichTable
    Inherits System.Windows.Forms.Form
    Dim isAVAILABLE(50) As Boolean
    Dim BARisAVAILABLE(50) As Boolean
    Dim lstOldValue As Integer = -5
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
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents tbl10 As System.Windows.Forms.Button
    Friend WithEvents tbl14 As System.Windows.Forms.Button
    Friend WithEvents tbl12 As System.Windows.Forms.Button
    Friend WithEvents tbl15 As System.Windows.Forms.Button
    Friend WithEvents tbl11 As System.Windows.Forms.Button
    Friend WithEvents tbl13 As System.Windows.Forms.Button
    Friend WithEvents sto10 As System.Windows.Forms.Button
    Friend WithEvents sto18 As System.Windows.Forms.Button
    Friend WithEvents sto11 As System.Windows.Forms.Button
    Friend WithEvents sto19 As System.Windows.Forms.Button
    Friend WithEvents sto14 As System.Windows.Forms.Button
    Friend WithEvents sto15 As System.Windows.Forms.Button
    Friend WithEvents sto13 As System.Windows.Forms.Button
    Friend WithEvents sto12 As System.Windows.Forms.Button
    Friend WithEvents sto16 As System.Windows.Forms.Button
    Friend WithEvents sto17 As System.Windows.Forms.Button
    Friend WithEvents sto20 As System.Windows.Forms.Button
    Friend WithEvents sto21 As System.Windows.Forms.Button
    Friend WithEvents sto23 As System.Windows.Forms.Button
    Friend WithEvents sto24 As System.Windows.Forms.Button
    Friend WithEvents sto25 As System.Windows.Forms.Button
    Friend WithEvents sto22 As System.Windows.Forms.Button
    Friend WithEvents tbl01 As System.Windows.Forms.Button
    Friend WithEvents tbl02 As System.Windows.Forms.Button
    Friend WithEvents tbl03 As System.Windows.Forms.Button
    Friend WithEvents tbl09 As System.Windows.Forms.Button
    Friend WithEvents tbl08 As System.Windows.Forms.Button
    Friend WithEvents tbl05 As System.Windows.Forms.Button
    Friend WithEvents tbl04 As System.Windows.Forms.Button
    Friend WithEvents tbl06 As System.Windows.Forms.Button
    Friend WithEvents tbl07 As System.Windows.Forms.Button
    Friend WithEvents sto01 As System.Windows.Forms.Button
    Friend WithEvents sto02 As System.Windows.Forms.Button
    Friend WithEvents sto03 As System.Windows.Forms.Button
    Friend WithEvents sto04 As System.Windows.Forms.Button
    Friend WithEvents sto05 As System.Windows.Forms.Button
    Friend WithEvents sto06 As System.Windows.Forms.Button
    Friend WithEvents sto07 As System.Windows.Forms.Button
    Friend WithEvents sto08 As System.Windows.Forms.Button
    Friend WithEvents sto09 As System.Windows.Forms.Button
    Friend WithEvents cmdOtherTable As System.Windows.Forms.Button
    Friend WithEvents lstTablePK As System.Windows.Forms.ListBox
    Friend WithEvents lstTableNum As System.Windows.Forms.ListBox
    Friend WithEvents lstTableGuestCount As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdClose = New System.Windows.Forms.Button
        Me.tbl01 = New System.Windows.Forms.Button
        Me.tbl02 = New System.Windows.Forms.Button
        Me.tbl03 = New System.Windows.Forms.Button
        Me.tbl09 = New System.Windows.Forms.Button
        Me.tbl08 = New System.Windows.Forms.Button
        Me.tbl10 = New System.Windows.Forms.Button
        Me.tbl14 = New System.Windows.Forms.Button
        Me.tbl13 = New System.Windows.Forms.Button
        Me.tbl12 = New System.Windows.Forms.Button
        Me.tbl15 = New System.Windows.Forms.Button
        Me.tbl11 = New System.Windows.Forms.Button
        Me.tbl05 = New System.Windows.Forms.Button
        Me.tbl04 = New System.Windows.Forms.Button
        Me.tbl06 = New System.Windows.Forms.Button
        Me.tbl07 = New System.Windows.Forms.Button
        Me.sto01 = New System.Windows.Forms.Button
        Me.sto02 = New System.Windows.Forms.Button
        Me.sto03 = New System.Windows.Forms.Button
        Me.sto04 = New System.Windows.Forms.Button
        Me.sto05 = New System.Windows.Forms.Button
        Me.sto06 = New System.Windows.Forms.Button
        Me.sto07 = New System.Windows.Forms.Button
        Me.sto08 = New System.Windows.Forms.Button
        Me.sto09 = New System.Windows.Forms.Button
        Me.sto10 = New System.Windows.Forms.Button
        Me.sto18 = New System.Windows.Forms.Button
        Me.sto11 = New System.Windows.Forms.Button
        Me.sto19 = New System.Windows.Forms.Button
        Me.sto14 = New System.Windows.Forms.Button
        Me.sto15 = New System.Windows.Forms.Button
        Me.sto13 = New System.Windows.Forms.Button
        Me.sto12 = New System.Windows.Forms.Button
        Me.sto16 = New System.Windows.Forms.Button
        Me.sto17 = New System.Windows.Forms.Button
        Me.sto20 = New System.Windows.Forms.Button
        Me.sto21 = New System.Windows.Forms.Button
        Me.sto23 = New System.Windows.Forms.Button
        Me.sto24 = New System.Windows.Forms.Button
        Me.sto25 = New System.Windows.Forms.Button
        Me.sto22 = New System.Windows.Forms.Button
        Me.cmdOtherTable = New System.Windows.Forms.Button
        Me.lstTablePK = New System.Windows.Forms.ListBox
        Me.lstTableNum = New System.Windows.Forms.ListBox
        Me.lstTableGuestCount = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(784, 448)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(168, 64)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        '
        'tbl01
        '
        Me.tbl01.BackColor = System.Drawing.SystemColors.Control
        Me.tbl01.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl01.Location = New System.Drawing.Point(16, 16)
        Me.tbl01.Name = "tbl01"
        Me.tbl01.Size = New System.Drawing.Size(75, 65)
        Me.tbl01.TabIndex = 0
        Me.tbl01.TabStop = False
        Me.tbl01.Tag = ""
        Me.tbl01.Text = "Close"
        '
        'tbl02
        '
        Me.tbl02.BackColor = System.Drawing.SystemColors.Control
        Me.tbl02.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl02.Location = New System.Drawing.Point(128, 16)
        Me.tbl02.Name = "tbl02"
        Me.tbl02.Size = New System.Drawing.Size(75, 65)
        Me.tbl02.TabIndex = 1
        Me.tbl02.TabStop = False
        Me.tbl02.Tag = ""
        Me.tbl02.Text = "Close"
        '
        'tbl03
        '
        Me.tbl03.BackColor = System.Drawing.SystemColors.Control
        Me.tbl03.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl03.Location = New System.Drawing.Point(280, 0)
        Me.tbl03.Name = "tbl03"
        Me.tbl03.Size = New System.Drawing.Size(75, 65)
        Me.tbl03.TabIndex = 2
        Me.tbl03.TabStop = False
        Me.tbl03.Tag = ""
        Me.tbl03.Text = "Close"
        '
        'tbl09
        '
        Me.tbl09.BackColor = System.Drawing.SystemColors.Control
        Me.tbl09.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl09.Location = New System.Drawing.Point(24, 432)
        Me.tbl09.Name = "tbl09"
        Me.tbl09.Size = New System.Drawing.Size(75, 65)
        Me.tbl09.TabIndex = 3
        Me.tbl09.TabStop = False
        Me.tbl09.Tag = ""
        Me.tbl09.Text = "Close"
        '
        'tbl08
        '
        Me.tbl08.BackColor = System.Drawing.SystemColors.Control
        Me.tbl08.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl08.Location = New System.Drawing.Point(128, 344)
        Me.tbl08.Name = "tbl08"
        Me.tbl08.Size = New System.Drawing.Size(75, 65)
        Me.tbl08.TabIndex = 4
        Me.tbl08.TabStop = False
        Me.tbl08.Tag = ""
        Me.tbl08.Text = "Close"
        '
        'tbl10
        '
        Me.tbl10.BackColor = System.Drawing.SystemColors.Control
        Me.tbl10.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl10.Location = New System.Drawing.Point(120, 432)
        Me.tbl10.Name = "tbl10"
        Me.tbl10.Size = New System.Drawing.Size(75, 65)
        Me.tbl10.TabIndex = 5
        Me.tbl10.TabStop = False
        Me.tbl10.Tag = ""
        Me.tbl10.Text = "Close"
        '
        'tbl14
        '
        Me.tbl14.BackColor = System.Drawing.SystemColors.Control
        Me.tbl14.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl14.Location = New System.Drawing.Point(808, 344)
        Me.tbl14.Name = "tbl14"
        Me.tbl14.Size = New System.Drawing.Size(88, 65)
        Me.tbl14.TabIndex = 6
        Me.tbl14.TabStop = False
        Me.tbl14.Tag = ""
        Me.tbl14.Text = "Close"
        '
        'tbl13
        '
        Me.tbl13.BackColor = System.Drawing.SystemColors.Control
        Me.tbl13.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl13.Location = New System.Drawing.Point(664, 344)
        Me.tbl13.Name = "tbl13"
        Me.tbl13.Size = New System.Drawing.Size(88, 65)
        Me.tbl13.TabIndex = 7
        Me.tbl13.TabStop = False
        Me.tbl13.Tag = ""
        Me.tbl13.Text = "Close"
        '
        'tbl12
        '
        Me.tbl12.BackColor = System.Drawing.SystemColors.Control
        Me.tbl12.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl12.Location = New System.Drawing.Point(528, 344)
        Me.tbl12.Name = "tbl12"
        Me.tbl12.Size = New System.Drawing.Size(75, 65)
        Me.tbl12.TabIndex = 8
        Me.tbl12.TabStop = False
        Me.tbl12.Tag = ""
        Me.tbl12.Text = "Close"
        '
        'tbl15
        '
        Me.tbl15.BackColor = System.Drawing.SystemColors.Control
        Me.tbl15.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl15.Location = New System.Drawing.Point(808, 248)
        Me.tbl15.Name = "tbl15"
        Me.tbl15.Size = New System.Drawing.Size(88, 65)
        Me.tbl15.TabIndex = 9
        Me.tbl15.TabStop = False
        Me.tbl15.Tag = ""
        Me.tbl15.Text = "Close"
        '
        'tbl11
        '
        Me.tbl11.BackColor = System.Drawing.SystemColors.Control
        Me.tbl11.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl11.Location = New System.Drawing.Point(304, 352)
        Me.tbl11.Name = "tbl11"
        Me.tbl11.Size = New System.Drawing.Size(75, 128)
        Me.tbl11.TabIndex = 10
        Me.tbl11.TabStop = False
        Me.tbl11.Tag = ""
        Me.tbl11.Text = "Close"
        '
        'tbl05
        '
        Me.tbl05.BackColor = System.Drawing.SystemColors.Control
        Me.tbl05.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl05.Location = New System.Drawing.Point(280, 80)
        Me.tbl05.Name = "tbl05"
        Me.tbl05.Size = New System.Drawing.Size(75, 128)
        Me.tbl05.TabIndex = 11
        Me.tbl05.TabStop = False
        Me.tbl05.Tag = ""
        Me.tbl05.Text = "Close"
        '
        'tbl04
        '
        Me.tbl04.BackColor = System.Drawing.SystemColors.Control
        Me.tbl04.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl04.Location = New System.Drawing.Point(0, 136)
        Me.tbl04.Name = "tbl04"
        Me.tbl04.Size = New System.Drawing.Size(144, 64)
        Me.tbl04.TabIndex = 12
        Me.tbl04.TabStop = False
        Me.tbl04.Tag = ""
        Me.tbl04.Text = "Close"
        '
        'tbl06
        '
        Me.tbl06.BackColor = System.Drawing.SystemColors.Control
        Me.tbl06.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl06.Location = New System.Drawing.Point(0, 232)
        Me.tbl06.Name = "tbl06"
        Me.tbl06.Size = New System.Drawing.Size(144, 64)
        Me.tbl06.TabIndex = 13
        Me.tbl06.TabStop = False
        Me.tbl06.Tag = ""
        Me.tbl06.Text = "Close"
        '
        'tbl07
        '
        Me.tbl07.BackColor = System.Drawing.SystemColors.Control
        Me.tbl07.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl07.Location = New System.Drawing.Point(208, 232)
        Me.tbl07.Name = "tbl07"
        Me.tbl07.Size = New System.Drawing.Size(144, 64)
        Me.tbl07.TabIndex = 14
        Me.tbl07.TabStop = False
        Me.tbl07.Tag = ""
        Me.tbl07.Text = "Close"
        '
        'sto01
        '
        Me.sto01.BackColor = System.Drawing.SystemColors.Control
        Me.sto01.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto01.Location = New System.Drawing.Point(888, 168)
        Me.sto01.Name = "sto01"
        Me.sto01.Size = New System.Drawing.Size(32, 32)
        Me.sto01.TabIndex = 15
        Me.sto01.TabStop = False
        Me.sto01.Text = "1"
        '
        'sto02
        '
        Me.sto02.BackColor = System.Drawing.SystemColors.Control
        Me.sto02.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto02.Location = New System.Drawing.Point(832, 168)
        Me.sto02.Name = "sto02"
        Me.sto02.Size = New System.Drawing.Size(32, 32)
        Me.sto02.TabIndex = 16
        Me.sto02.TabStop = False
        Me.sto02.Text = "2"
        '
        'sto03
        '
        Me.sto03.BackColor = System.Drawing.SystemColors.Control
        Me.sto03.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto03.Location = New System.Drawing.Point(784, 168)
        Me.sto03.Name = "sto03"
        Me.sto03.Size = New System.Drawing.Size(32, 32)
        Me.sto03.TabIndex = 17
        Me.sto03.TabStop = False
        Me.sto03.Text = "3"
        '
        'sto04
        '
        Me.sto04.BackColor = System.Drawing.SystemColors.Control
        Me.sto04.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto04.Location = New System.Drawing.Point(728, 168)
        Me.sto04.Name = "sto04"
        Me.sto04.Size = New System.Drawing.Size(32, 32)
        Me.sto04.TabIndex = 18
        Me.sto04.TabStop = False
        Me.sto04.Text = "4"
        '
        'sto05
        '
        Me.sto05.BackColor = System.Drawing.SystemColors.Control
        Me.sto05.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto05.Location = New System.Drawing.Point(680, 168)
        Me.sto05.Name = "sto05"
        Me.sto05.Size = New System.Drawing.Size(32, 32)
        Me.sto05.TabIndex = 19
        Me.sto05.TabStop = False
        Me.sto05.Text = "5"
        '
        'sto06
        '
        Me.sto06.BackColor = System.Drawing.SystemColors.Control
        Me.sto06.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto06.Location = New System.Drawing.Point(640, 216)
        Me.sto06.Name = "sto06"
        Me.sto06.Size = New System.Drawing.Size(32, 32)
        Me.sto06.TabIndex = 20
        Me.sto06.TabStop = False
        Me.sto06.Text = "6"
        '
        'sto07
        '
        Me.sto07.BackColor = System.Drawing.SystemColors.Control
        Me.sto07.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto07.Location = New System.Drawing.Point(616, 264)
        Me.sto07.Name = "sto07"
        Me.sto07.Size = New System.Drawing.Size(32, 32)
        Me.sto07.TabIndex = 21
        Me.sto07.TabStop = False
        Me.sto07.Text = "7"
        '
        'sto08
        '
        Me.sto08.BackColor = System.Drawing.SystemColors.Control
        Me.sto08.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto08.Location = New System.Drawing.Point(568, 296)
        Me.sto08.Name = "sto08"
        Me.sto08.Size = New System.Drawing.Size(32, 32)
        Me.sto08.TabIndex = 22
        Me.sto08.TabStop = False
        Me.sto08.Text = "8"
        '
        'sto09
        '
        Me.sto09.BackColor = System.Drawing.SystemColors.Control
        Me.sto09.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto09.Location = New System.Drawing.Point(520, 296)
        Me.sto09.Name = "sto09"
        Me.sto09.Size = New System.Drawing.Size(32, 32)
        Me.sto09.TabIndex = 23
        Me.sto09.TabStop = False
        Me.sto09.Text = "9"
        '
        'sto10
        '
        Me.sto10.BackColor = System.Drawing.SystemColors.Control
        Me.sto10.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto10.Location = New System.Drawing.Point(424, 248)
        Me.sto10.Name = "sto10"
        Me.sto10.Size = New System.Drawing.Size(32, 32)
        Me.sto10.TabIndex = 24
        Me.sto10.TabStop = False
        Me.sto10.Text = "10"
        '
        'sto18
        '
        Me.sto18.BackColor = System.Drawing.SystemColors.Control
        Me.sto18.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto18.Location = New System.Drawing.Point(586, 72)
        Me.sto18.Name = "sto18"
        Me.sto18.Size = New System.Drawing.Size(32, 32)
        Me.sto18.TabIndex = 25
        Me.sto18.TabStop = False
        Me.sto18.Text = "18"
        '
        'sto11
        '
        Me.sto11.BackColor = System.Drawing.SystemColors.Control
        Me.sto11.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto11.Location = New System.Drawing.Point(424, 200)
        Me.sto11.Name = "sto11"
        Me.sto11.Size = New System.Drawing.Size(32, 32)
        Me.sto11.TabIndex = 26
        Me.sto11.TabStop = False
        Me.sto11.Text = "11"
        '
        'sto19
        '
        Me.sto19.BackColor = System.Drawing.SystemColors.Control
        Me.sto19.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto19.Location = New System.Drawing.Point(636, 72)
        Me.sto19.Name = "sto19"
        Me.sto19.Size = New System.Drawing.Size(32, 32)
        Me.sto19.TabIndex = 36
        Me.sto19.TabStop = False
        Me.sto19.Text = "19"
        '
        'sto14
        '
        Me.sto14.BackColor = System.Drawing.SystemColors.Control
        Me.sto14.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto14.Location = New System.Drawing.Point(408, 48)
        Me.sto14.Name = "sto14"
        Me.sto14.Size = New System.Drawing.Size(32, 32)
        Me.sto14.TabIndex = 34
        Me.sto14.TabStop = False
        Me.sto14.Text = "14"
        '
        'sto15
        '
        Me.sto15.BackColor = System.Drawing.SystemColors.Control
        Me.sto15.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto15.Location = New System.Drawing.Point(448, 16)
        Me.sto15.Name = "sto15"
        Me.sto15.Size = New System.Drawing.Size(32, 32)
        Me.sto15.TabIndex = 33
        Me.sto15.TabStop = False
        Me.sto15.Text = "15"
        '
        'sto13
        '
        Me.sto13.BackColor = System.Drawing.SystemColors.Control
        Me.sto13.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto13.Location = New System.Drawing.Point(416, 96)
        Me.sto13.Name = "sto13"
        Me.sto13.Size = New System.Drawing.Size(32, 32)
        Me.sto13.TabIndex = 32
        Me.sto13.TabStop = False
        Me.sto13.Text = "13"
        '
        'sto12
        '
        Me.sto12.BackColor = System.Drawing.SystemColors.Control
        Me.sto12.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto12.Location = New System.Drawing.Point(424, 152)
        Me.sto12.Name = "sto12"
        Me.sto12.Size = New System.Drawing.Size(32, 32)
        Me.sto12.TabIndex = 31
        Me.sto12.TabStop = False
        Me.sto12.Text = "12"
        '
        'sto16
        '
        Me.sto16.BackColor = System.Drawing.SystemColors.Control
        Me.sto16.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto16.Location = New System.Drawing.Point(488, 40)
        Me.sto16.Name = "sto16"
        Me.sto16.Size = New System.Drawing.Size(32, 32)
        Me.sto16.TabIndex = 30
        Me.sto16.TabStop = False
        Me.sto16.Text = "16"
        '
        'sto17
        '
        Me.sto17.BackColor = System.Drawing.SystemColors.Control
        Me.sto17.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto17.Location = New System.Drawing.Point(536, 72)
        Me.sto17.Name = "sto17"
        Me.sto17.Size = New System.Drawing.Size(32, 32)
        Me.sto17.TabIndex = 29
        Me.sto17.TabStop = False
        Me.sto17.Text = "17"
        '
        'sto20
        '
        Me.sto20.BackColor = System.Drawing.SystemColors.Control
        Me.sto20.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto20.Location = New System.Drawing.Point(686, 72)
        Me.sto20.Name = "sto20"
        Me.sto20.Size = New System.Drawing.Size(32, 32)
        Me.sto20.TabIndex = 28
        Me.sto20.TabStop = False
        Me.sto20.Text = "20"
        '
        'sto21
        '
        Me.sto21.BackColor = System.Drawing.SystemColors.Control
        Me.sto21.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto21.Location = New System.Drawing.Point(736, 72)
        Me.sto21.Name = "sto21"
        Me.sto21.Size = New System.Drawing.Size(32, 32)
        Me.sto21.TabIndex = 27
        Me.sto21.TabStop = False
        Me.sto21.Text = "21"
        '
        'sto23
        '
        Me.sto23.BackColor = System.Drawing.SystemColors.Control
        Me.sto23.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto23.Location = New System.Drawing.Point(832, 16)
        Me.sto23.Name = "sto23"
        Me.sto23.Size = New System.Drawing.Size(32, 32)
        Me.sto23.TabIndex = 37
        Me.sto23.TabStop = False
        Me.sto23.Text = "23"
        '
        'sto24
        '
        Me.sto24.BackColor = System.Drawing.SystemColors.Control
        Me.sto24.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto24.Location = New System.Drawing.Point(896, 56)
        Me.sto24.Name = "sto24"
        Me.sto24.Size = New System.Drawing.Size(32, 32)
        Me.sto24.TabIndex = 38
        Me.sto24.TabStop = False
        Me.sto24.Text = "24"
        '
        'sto25
        '
        Me.sto25.BackColor = System.Drawing.SystemColors.Control
        Me.sto25.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto25.Location = New System.Drawing.Point(880, 16)
        Me.sto25.Name = "sto25"
        Me.sto25.Size = New System.Drawing.Size(32, 32)
        Me.sto25.TabIndex = 39
        Me.sto25.TabStop = False
        Me.sto25.Text = "25"
        '
        'sto22
        '
        Me.sto22.BackColor = System.Drawing.SystemColors.Control
        Me.sto22.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sto22.Location = New System.Drawing.Point(792, 48)
        Me.sto22.Name = "sto22"
        Me.sto22.Size = New System.Drawing.Size(32, 32)
        Me.sto22.TabIndex = 40
        Me.sto22.TabStop = False
        Me.sto22.Text = "22"
        '
        'cmdOtherTable
        '
        Me.cmdOtherTable.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOtherTable.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOtherTable.Location = New System.Drawing.Point(712, 448)
        Me.cmdOtherTable.Name = "cmdOtherTable"
        Me.cmdOtherTable.Size = New System.Drawing.Size(64, 65)
        Me.cmdOtherTable.TabIndex = 41
        Me.cmdOtherTable.TabStop = False
        Me.cmdOtherTable.Tag = ""
        Me.cmdOtherTable.Text = "Other Table"
        '
        'lstTablePK
        '
        Me.lstTablePK.Location = New System.Drawing.Point(616, 424)
        Me.lstTablePK.Name = "lstTablePK"
        Me.lstTablePK.Size = New System.Drawing.Size(32, 95)
        Me.lstTablePK.TabIndex = 42
        Me.lstTablePK.Visible = False
        '
        'lstTableNum
        '
        Me.lstTableNum.Location = New System.Drawing.Point(536, 424)
        Me.lstTableNum.Name = "lstTableNum"
        Me.lstTableNum.Size = New System.Drawing.Size(80, 95)
        Me.lstTableNum.TabIndex = 43
        '
        'lstTableGuestCount
        '
        Me.lstTableGuestCount.Location = New System.Drawing.Point(616, 424)
        Me.lstTableGuestCount.Name = "lstTableGuestCount"
        Me.lstTableGuestCount.Size = New System.Drawing.Size(72, 95)
        Me.lstTableGuestCount.TabIndex = 44
        '
        'SelectWhichTable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(961, 530)
        Me.Controls.Add(Me.lstTableGuestCount)
        Me.Controls.Add(Me.lstTablePK)
        Me.Controls.Add(Me.lstTableNum)
        Me.Controls.Add(Me.cmdOtherTable)
        Me.Controls.Add(Me.sto22)
        Me.Controls.Add(Me.sto25)
        Me.Controls.Add(Me.sto24)
        Me.Controls.Add(Me.sto23)
        Me.Controls.Add(Me.sto19)
        Me.Controls.Add(Me.sto14)
        Me.Controls.Add(Me.sto15)
        Me.Controls.Add(Me.sto13)
        Me.Controls.Add(Me.sto12)
        Me.Controls.Add(Me.sto16)
        Me.Controls.Add(Me.sto17)
        Me.Controls.Add(Me.sto20)
        Me.Controls.Add(Me.sto21)
        Me.Controls.Add(Me.sto11)
        Me.Controls.Add(Me.sto18)
        Me.Controls.Add(Me.sto10)
        Me.Controls.Add(Me.sto09)
        Me.Controls.Add(Me.sto08)
        Me.Controls.Add(Me.sto07)
        Me.Controls.Add(Me.sto06)
        Me.Controls.Add(Me.sto05)
        Me.Controls.Add(Me.sto04)
        Me.Controls.Add(Me.sto03)
        Me.Controls.Add(Me.sto02)
        Me.Controls.Add(Me.sto01)
        Me.Controls.Add(Me.tbl07)
        Me.Controls.Add(Me.tbl06)
        Me.Controls.Add(Me.tbl04)
        Me.Controls.Add(Me.tbl05)
        Me.Controls.Add(Me.tbl11)
        Me.Controls.Add(Me.tbl15)
        Me.Controls.Add(Me.tbl12)
        Me.Controls.Add(Me.tbl13)
        Me.Controls.Add(Me.tbl14)
        Me.Controls.Add(Me.tbl10)
        Me.Controls.Add(Me.tbl08)
        Me.Controls.Add(Me.tbl09)
        Me.Controls.Add(Me.tbl03)
        Me.Controls.Add(Me.tbl02)
        Me.Controls.Add(Me.tbl01)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SelectWhichTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub SelectWhichTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Saved.Database_Connect()
        Saved.OpenTableInfo_Open()
        Saved.OpenStoolInfo_Open()
        Saved.OpenTicket_Open()

        'Initialize info about tables
        Saved.OpenTableInfoRST.MoveFirst()
        Do Until Saved.OpenTableInfoRST.EOF
            If Saved.OpenTableInfoTableNum.Value < 25 And Not Saved.OpenTableInfoTableNum.Value = -99 Then
                If Saved.OpenTableInfoAvailable.Value = True Then
                    isAVAILABLE(Saved.OpenTableInfoTableNum.Value) = True
                Else
                    isAVAILABLE(Saved.OpenTableInfoTableNum.Value) = False
                End If
            Else
                If Not Saved.OpenTableInfoTableNum.Value = -99 Then
                    lstTablePK.Items.Add(Saved.OpenTableInfoTableNum.Value)
                    lstTableNum.Items.Add(Saved.OpenTableInfoTableName.Value)
                    lstTableGuestCount.Items.Add(Saved.OpenTableInfoGuestCount.Value)
                End If
            End If
            Saved.OpenTableInfoRST.MoveNext()
        Loop

        'Initialize info about Stools
        Saved.OpenStoolInfoRST.MoveFirst()
        Do Until Saved.OpenStoolInfoRST.EOF
            If Saved.OpenStoolInfoAvailable.Value = True Then
                BARisAVAILABLE(Saved.OpenStoolInfoStoolNum.Value) = True
            Else
                BARisAVAILABLE(Saved.OpenStoolInfoStoolNum.Value) = False
            End If
            Saved.OpenStoolInfoRST.MoveNext()
        Loop

        Dim cControl As Control
        For Each cControl In Me.Controls
            If (TypeOf cControl Is Button) Then
                If Mid(cControl.Name, 1, 3) = "tbl" Then
                    Saved.OpenTableInfoRST.FindFirst("TABLE_NUM = " & Mid(cControl.Name, 4, 2))
                    If Saved.OpenTableInfoRST.NoMatch = False Then
                        If Saved.TABLEFOR = "SEATEDORDERS" Then
                            If isAVAILABLE(Mid(cControl.Name, 4, 2)) = True Then
                                cControl.BackColor = Color.LightGray
                                cControl.Text = Saved.OpenTableInfoTableName.Value
                            Else
                                cControl.BackColor = Color.DarkGreen
                                cControl.Text = Saved.OpenTableInfoTableName.Value & Chr(13) & Chr(10) & "GC:" & Saved.OpenTableInfoGuestCount.Value
                            End If
                        End If
                        If Saved.TABLEFOR = "TOSEAT" Then
                            If isAVAILABLE(Mid(cControl.Name, 4, 2)) = True Then
                                cControl.BackColor = Color.LightGray
                                cControl.Text = Saved.OpenTableInfoTableName.Value
                            Else
                                cControl.BackColor = Color.DarkRed
                                cControl.Text = Saved.OpenTableInfoTableName.Value & Chr(13) & Chr(10) & "GC:" & Saved.OpenTableInfoGuestCount.Value
                            End If
                        End If
                    End If
                End If

                If Mid(cControl.Name, 1, 3) = "sto" Then
                    Saved.OpenStoolInfoRST.FindFirst("STOOL_NUM = " & Mid(cControl.Name, 4, 2))
                    If Saved.OpenStoolInfoRST.NoMatch = False Then
                        If Saved.TABLEFOR = "SEATEDORDERS" Then
                            If BARisAVAILABLE(Mid(cControl.Name, 4, 2)) = True Then
                                cControl.BackColor = Color.LightGray
                            Else
                                cControl.BackColor = Color.DarkGreen
                            End If
                        End If
                    End If
                End If
            End If
        Next cControl

        Saved.OpenTicket_Close()
        Saved.OpenStoolInfo_Close()
        Saved.OpenTableInfo_Close()
        Saved.Database_Disconnect()
    End Sub

    Public Sub StoolCheck(ByVal X As Integer)
        Saved.Database_Connect()
        Saved.OpenStoolInfo_Open()
        Saved.OpenTicket_Open()
        Saved.OpenBarOrder_Open()
        Saved.Saved_Open()
        Saved.GO(2) = False

        Saved.OpenStoolInfoRST.FindFirst("STOOL_NUM = " & X)
        If Saved.OpenStoolInfoRST.NoMatch = False Then
            'load record of selected stool

            If Saved.OpenStoolInfoAvailable.Value = False Then
                'if bar stool exists

                Saved.OpenTicketRST.FindFirst("STOOL_NUM = " & X)
                If Saved.OpenTicketRST.NoMatch = False Then
                    'load selected stool

                    Saved.CURTICKET = Saved.OpenTicketTicketNum.Value
                    Saved.CURORDER = Saved.OpenTicketOrderNum.Value
                    Saved.CURRETABLE = Saved.OpenStoolInfoReTable.Value
                    Saved.CURTABLENAME = "Bar Stool " & X
                    Saved.CURGUEST = 1
                    Saved.CURSTOOL = X
                    Saved.CURTABLE = 0
                    Saved.GUESTTRANSFER = False

                    Saved.GO(2) = True
                End If
            End If
        End If

        Saved.Saved_Close()
        Saved.OpenStoolInfo_Close()
        Saved.OpenTicket_Close()
        Saved.OpenBarOrder_Close()
        Saved.Database_Disconnect()

        If Saved.GO(2) = True Then
            Saved.GO(1) = True
            Close()
        End If
    End Sub

    Public Sub TableCheck(ByVal X As Integer)
        Saved.Database_Connect()
        Saved.OpenTableInfo_Open()
        Saved.OpenTicket_Open()
        Saved.OpenOrder_Open()
        Saved.Saved_Open()
        Saved.OpenStoolInfo_Open()
        Saved.GO(2) = False
        If Saved.TABLEFOR = "SEATEDORDERS" Then
            Saved.OpenTableInfoRST.FindFirst("TABLE_NUM = " & X)
            If Saved.OpenTableInfoRST.NoMatch = False Then
                'load record of selected stool

                If Saved.OpenTableInfoAvailable.Value = False Then
                    'if bar stool exists

                    Saved.OpenTicketRST.FindFirst("TABLE_NUM = " & X)
                    If Saved.OpenTicketRST.NoMatch = False Then
                        'load selected stool

                        Saved.CURTICKET = Saved.OpenTicketTicketNum.Value
                        Saved.CURORDER = Saved.OpenTicketOrderNum.Value
                        Saved.CURRETABLE = Saved.OpenTableInfoReTable.Value
                        Saved.CURTABLENAME = Saved.OpenTableInfoTableName.Value
                        Saved.CURGUEST = 1
                        Saved.CURSTOOL = 0
                        Saved.CURTABLE = X
                        Saved.GUESTTRANSFER = False

                        Saved.GO(2) = True
                    End If
                End If
            End If
        End If
        If Saved.TABLEFOR = "TOSEAT" Then
            Saved.OpenStoolInfoRST.FindFirst("STOOL_NUM = " & X)
            If Saved.OpenStoolInfoRST.NoMatch = False Then
                'load record of selected stool

                If Saved.OpenTableInfoAvailable.Value = True Then
                    'if bar stool exists

                    Saved.OpenTicketRST.FindFirst("STOOL_NUM = " & Saved.CURSTOOL)
                    If Saved.OpenTicketRST.NoMatch = False Then
                        'load selected stool
                        Saved.CURGUEST = 1
                        Saved.CURTABLE = X
                        Saved.GUESTTRANSFER = False

                        Saved.GO(2) = True
                    End If
                End If
            End If
        End If
        Saved.Saved_Close()
        Saved.OpenTableInfo_Close()
        Saved.OpenTicket_Close()
        Saved.OpenOrder_Close()
        Saved.Database_Disconnect()

        If Saved.GO(2) = True Then
            Saved.GO(1) = True
            Close()
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub tbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl10.Click, tbl11.Click, tbl12.Click, tbl13.Click, tbl14.Click, tbl15.Click, tbl01.Click, tbl02.Click, tbl03.Click, tbl09.Click, tbl08.Click, tbl05.Click, tbl04.Click, tbl06.Click, tbl07.Click
        TableCheck(Mid(sender.name, 4, 2))
    End Sub

    Private Sub sto10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sto10.Click, sto11.Click, sto12.Click, sto13.Click, sto14.Click, sto15.Click, sto16.Click, sto17.Click, sto18.Click, sto19.Click, sto20.Click, sto21.Click, sto22.Click, sto23.Click, sto24.Click, sto25.Click, sto01.Click, sto02.Click, sto03.Click, sto04.Click, sto05.Click, sto06.Click, sto07.Click, sto08.Click, sto09.Click, sto10.Click, sto11.Click, sto12.Click, sto13.Click, sto14.Click, sto15.Click, sto16.Click, sto17.Click, sto18.Click, sto19.Click, sto20.Click, sto21.Click, sto22.Click, sto23.Click, sto24.Click, sto25.Click
        StoolCheck(Mid(sender.name, 4, 2))
    End Sub

    Private Sub lstTableNum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTableNum.SelectedIndexChanged
        lstTablePK.SelectedIndex = lstTableNum.SelectedIndex
        lstTableGuestCount.SelectedIndex = lstTableNum.SelectedIndex
        lstOldValue = lstTablePK.SelectedItem
    End Sub

    Private Sub lstTableGuestCount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTableGuestCount.SelectedIndexChanged
        lstTablePK.SelectedIndex = lstTableGuestCount.SelectedIndex
        lstTableNum.SelectedIndex = lstTableGuestCount.SelectedIndex
        lstOldValue = lstTablePK.SelectedItem
    End Sub

    Private Sub lstTableGuestCount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTableGuestCount.Click, lstTableNum.Click
        If lstOldValue = lstTablePK.SelectedItem Then
            TableCheck(lstTablePK.SelectedItem)
        End If
    End Sub

End Class
