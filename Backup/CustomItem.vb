Public Class CustomItem
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents cmdPeriod As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdDiscount As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdPeriod = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
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
        Me.cmdOK = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdDiscount = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdPeriod
        '
        Me.cmdPeriod.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdPeriod.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPeriod.Location = New System.Drawing.Point(124, 304)
        Me.cmdPeriod.Name = "cmdPeriod"
        Me.cmdPeriod.Size = New System.Drawing.Size(88, 80)
        Me.cmdPeriod.TabIndex = 31
        Me.cmdPeriod.Text = "."
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdClear.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(228, 304)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(88, 80)
        Me.cmdClear.TabIndex = 32
        Me.cmdClear.Text = "Clear"
        '
        'cmd1
        '
        Me.cmd1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd1.Location = New System.Drawing.Point(20, 16)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(88, 80)
        Me.cmd1.TabIndex = 18
        Me.cmd1.Text = "1"
        '
        'cmd2
        '
        Me.cmd2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd2.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd2.Location = New System.Drawing.Point(124, 16)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(88, 80)
        Me.cmd2.TabIndex = 19
        Me.cmd2.Text = "2"
        '
        'cmd3
        '
        Me.cmd3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd3.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd3.Location = New System.Drawing.Point(228, 16)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(88, 80)
        Me.cmd3.TabIndex = 20
        Me.cmd3.Text = "3"
        '
        'cmd4
        '
        Me.cmd4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd4.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd4.Location = New System.Drawing.Point(20, 112)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(88, 80)
        Me.cmd4.TabIndex = 21
        Me.cmd4.Text = "4"
        '
        'cmd5
        '
        Me.cmd5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd5.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd5.Location = New System.Drawing.Point(124, 112)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(88, 80)
        Me.cmd5.TabIndex = 22
        Me.cmd5.Text = "5"
        '
        'cmd6
        '
        Me.cmd6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd6.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd6.Location = New System.Drawing.Point(228, 112)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(88, 80)
        Me.cmd6.TabIndex = 23
        Me.cmd6.Text = "6"
        '
        'cmd7
        '
        Me.cmd7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd7.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd7.Location = New System.Drawing.Point(20, 208)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(88, 80)
        Me.cmd7.TabIndex = 24
        Me.cmd7.Text = "7"
        '
        'cmd8
        '
        Me.cmd8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd8.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd8.Location = New System.Drawing.Point(124, 208)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(88, 80)
        Me.cmd8.TabIndex = 25
        Me.cmd8.Text = "8"
        '
        'cmd9
        '
        Me.cmd9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd9.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd9.Location = New System.Drawing.Point(228, 208)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(88, 80)
        Me.cmd9.TabIndex = 26
        Me.cmd9.Text = "9"
        '
        'cmd0
        '
        Me.cmd0.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd0.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd0.Location = New System.Drawing.Point(20, 304)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(88, 80)
        Me.cmd0.TabIndex = 27
        Me.cmd0.Text = "0"
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtValue.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(148, 400)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(152, 27)
        Me.txtValue.TabIndex = 28
        Me.txtValue.Text = ""
        '
        'lblValue
        '
        Me.lblValue.BackColor = System.Drawing.Color.Transparent
        Me.lblValue.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(36, 400)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(96, 32)
        Me.lblValue.TabIndex = 29
        Me.lblValue.Text = "Value:"
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOK.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.Color.Green
        Me.cmdOK.Location = New System.Drawing.Point(20, 440)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(296, 48)
        Me.cmdOK.TabIndex = 30
        Me.cmdOK.Text = "Add"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(20, 552)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(296, 48)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Cancel"
        '
        'cmdDiscount
        '
        Me.cmdDiscount.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdDiscount.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiscount.ForeColor = System.Drawing.Color.Red
        Me.cmdDiscount.Location = New System.Drawing.Point(20, 496)
        Me.cmdDiscount.Name = "cmdDiscount"
        Me.cmdDiscount.Size = New System.Drawing.Size(296, 48)
        Me.cmdDiscount.TabIndex = 34
        Me.cmdDiscount.Text = "Subtract"
        '
        'CustomItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(336, 608)
        Me.Controls.Add(Me.cmdDiscount)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdPeriod)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmd1)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd3)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.cmd5)
        Me.Controls.Add(Me.cmd6)
        Me.Controls.Add(Me.cmd7)
        Me.Controls.Add(Me.cmd8)
        Me.Controls.Add(Me.cmd9)
        Me.Controls.Add(Me.cmd0)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.cmdOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EnterGuestCount"
        Me.ResumeLayout(False)

    End Sub

#End Region

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

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If Val(txtValue.Text) = 0 Then
        Else
            Saved.CURCUSTOM = Val(txtValue.Text)
            Saved.GO(0) = True
        End If
        Close()
    End Sub

    Private Sub cmdPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPeriod.Click
        txtValue.Text = txtValue.Text & "."
        DEC = 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub cmdDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiscount.Click
        If Val(txtValue.Text) = 0 Then
        Else
            Saved.CURCUSTOM = Val(txtValue.Text) * -1
            Saved.GO(0) = True
        End If
        Close()
    End Sub
End Class
