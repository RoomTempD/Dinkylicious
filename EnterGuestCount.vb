Public Class EnterGuestCount
    Inherits System.Windows.Forms.Form
    Public Property Value As Integer

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
    Friend WithEvents txtGuestCount As System.Windows.Forms.TextBox
    Friend WithEvents lblGuestCount As System.Windows.Forms.Label
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmd0 As System.Windows.Forms.Button
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
        Me.txtGuestCount = New System.Windows.Forms.TextBox
        Me.lblGuestCount = New System.Windows.Forms.Label
        Me.cmdClear = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmd1
        '
        Me.cmd1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd1.Location = New System.Drawing.Point(16, 16)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(88, 80)
        Me.cmd1.TabIndex = 0
        Me.cmd1.Text = "1"
        '
        'cmd2
        '
        Me.cmd2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd2.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd2.Location = New System.Drawing.Point(120, 16)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(88, 80)
        Me.cmd2.TabIndex = 1
        Me.cmd2.Text = "2"
        '
        'cmd3
        '
        Me.cmd3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd3.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd3.Location = New System.Drawing.Point(224, 16)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(88, 80)
        Me.cmd3.TabIndex = 2
        Me.cmd3.Text = "3"
        '
        'cmd4
        '
        Me.cmd4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd4.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd4.Location = New System.Drawing.Point(16, 112)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(88, 80)
        Me.cmd4.TabIndex = 3
        Me.cmd4.Text = "4"
        '
        'cmd5
        '
        Me.cmd5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd5.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd5.Location = New System.Drawing.Point(120, 112)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(88, 80)
        Me.cmd5.TabIndex = 4
        Me.cmd5.Text = "5"
        '
        'cmd6
        '
        Me.cmd6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd6.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd6.Location = New System.Drawing.Point(224, 112)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(88, 80)
        Me.cmd6.TabIndex = 5
        Me.cmd6.Text = "6"
        '
        'cmd7
        '
        Me.cmd7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd7.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd7.Location = New System.Drawing.Point(16, 208)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(88, 80)
        Me.cmd7.TabIndex = 6
        Me.cmd7.Text = "7"
        '
        'cmd8
        '
        Me.cmd8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd8.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd8.Location = New System.Drawing.Point(120, 208)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(88, 80)
        Me.cmd8.TabIndex = 7
        Me.cmd8.Text = "8"
        '
        'cmd9
        '
        Me.cmd9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd9.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd9.Location = New System.Drawing.Point(224, 208)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(88, 80)
        Me.cmd9.TabIndex = 8
        Me.cmd9.Text = "9"
        '
        'cmd0
        '
        Me.cmd0.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd0.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd0.Location = New System.Drawing.Point(16, 304)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(88, 80)
        Me.cmd0.TabIndex = 9
        Me.cmd0.Text = "0"
        '
        'txtGuestCount
        '
        Me.txtGuestCount.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtGuestCount.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestCount.Location = New System.Drawing.Point(216, 312)
        Me.txtGuestCount.Name = "txtGuestCount"
        Me.txtGuestCount.Size = New System.Drawing.Size(96, 27)
        Me.txtGuestCount.TabIndex = 10
        Me.txtGuestCount.Text = ""
        '
        'lblGuestCount
        '
        Me.lblGuestCount.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblGuestCount.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestCount.Location = New System.Drawing.Point(112, 312)
        Me.lblGuestCount.Name = "lblGuestCount"
        Me.lblGuestCount.Size = New System.Drawing.Size(96, 32)
        Me.lblGuestCount.TabIndex = 11
        Me.lblGuestCount.Text = "Guest Count:"
        Me.lblGuestCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdClear.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(120, 360)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(192, 24)
        Me.cmdClear.TabIndex = 12
        Me.cmdClear.Text = "Clear"
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOK.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Location = New System.Drawing.Point(16, 400)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(296, 48)
        Me.cmdOK.TabIndex = 13
        Me.cmdOK.Text = "OK"
        '
        'EnterGuestCount
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(328, 462)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.lblGuestCount)
        Me.Controls.Add(Me.txtGuestCount)
        Me.Controls.Add(Me.cmd0)
        Me.Controls.Add(Me.cmd9)
        Me.Controls.Add(Me.cmd8)
        Me.Controls.Add(Me.cmd7)
        Me.Controls.Add(Me.cmd6)
        Me.Controls.Add(Me.cmd5)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.cmd3)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EnterGuestCount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EnterGuestCount"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function getGuestCount() As Integer
        Dim GuestCount As Integer = 0
        Dim formEnterGuestCount As New EnterGuestCount
        If formEnterGuestCount.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GuestCount = formEnterGuestCount.Value
        End If
        Return GuestCount
    End Function

    Public Sub Update_Total(ByVal X As Integer)
        txtGuestCount.Text = txtGuestCount.Text & Str(X)
    End Sub

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click, cmd2.Click, cmd3.Click, cmd4.Click, cmd5.Click, cmd6.Click, cmd7.Click, cmd8.Click, cmd9.Click, cmd0.Click
        Update_Total(Mid(sender.name, 4, 1))
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtGuestCount.Text = ""
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click

        If Val(txtGuestCount.Text) <> 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Value = Val(txtGuestCount.Text)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        Close()
    End Sub

End Class
