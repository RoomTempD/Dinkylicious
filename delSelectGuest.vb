Public Class delSelectGuest
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
    Friend WithEvents guest4 As System.Windows.Forms.Button
    Friend WithEvents guest5 As System.Windows.Forms.Button
    Friend WithEvents guest6 As System.Windows.Forms.Button
    Friend WithEvents guest7 As System.Windows.Forms.Button
    Friend WithEvents guest8 As System.Windows.Forms.Button
    Friend WithEvents guest9 As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.guest4 = New System.Windows.Forms.Button
        Me.guest5 = New System.Windows.Forms.Button
        Me.guest6 = New System.Windows.Forms.Button
        Me.guest7 = New System.Windows.Forms.Button
        Me.guest8 = New System.Windows.Forms.Button
        Me.guest9 = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'guest4
        '
        Me.guest4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.guest4.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest4.Location = New System.Drawing.Point(16, 16)
        Me.guest4.Name = "guest4"
        Me.guest4.Size = New System.Drawing.Size(88, 80)
        Me.guest4.TabIndex = 3
        Me.guest4.Text = "4"
        '
        'guest5
        '
        Me.guest5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.guest5.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest5.Location = New System.Drawing.Point(120, 16)
        Me.guest5.Name = "guest5"
        Me.guest5.Size = New System.Drawing.Size(88, 80)
        Me.guest5.TabIndex = 4
        Me.guest5.Text = "5"
        '
        'guest6
        '
        Me.guest6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.guest6.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest6.Location = New System.Drawing.Point(224, 16)
        Me.guest6.Name = "guest6"
        Me.guest6.Size = New System.Drawing.Size(88, 80)
        Me.guest6.TabIndex = 5
        Me.guest6.Text = "6"
        '
        'guest7
        '
        Me.guest7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.guest7.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest7.Location = New System.Drawing.Point(16, 112)
        Me.guest7.Name = "guest7"
        Me.guest7.Size = New System.Drawing.Size(88, 80)
        Me.guest7.TabIndex = 6
        Me.guest7.Text = "7"
        '
        'guest8
        '
        Me.guest8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.guest8.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest8.Location = New System.Drawing.Point(120, 112)
        Me.guest8.Name = "guest8"
        Me.guest8.Size = New System.Drawing.Size(88, 80)
        Me.guest8.TabIndex = 7
        Me.guest8.Text = "8"
        '
        'guest9
        '
        Me.guest9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.guest9.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest9.Location = New System.Drawing.Point(224, 112)
        Me.guest9.Name = "guest9"
        Me.guest9.Size = New System.Drawing.Size(88, 80)
        Me.guest9.TabIndex = 8
        Me.guest9.Text = "9"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCancel.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(24, 208)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(280, 48)
        Me.cmdCancel.TabIndex = 14
        Me.cmdCancel.Text = "Cancel"
        '
        'SelectGuest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(328, 272)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.guest9)
        Me.Controls.Add(Me.guest8)
        Me.Controls.Add(Me.guest7)
        Me.Controls.Add(Me.guest6)
        Me.Controls.Add(Me.guest5)
        Me.Controls.Add(Me.guest4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SelectGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EnterGuestCount"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub SelectGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cControl As Control
        If Saved.GUESTTRANSFER = True Then
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    If Mid(cControl.Name, 1, 5) = "guest" Then
                        If Mid(cControl.Name, 6, 1) = Saved.CURGUEST Then
                            cControl.BackColor = Color.DarkRed
                        Else
                            cControl.BackColor = Color.LightGray
                        End If
                    End If
                End If
            Next cControl
        Else
            For Each cControl In Me.Controls
                If (TypeOf cControl Is Button) Then
                    If Mid(cControl.Name, 1, 5) = "guest" Then
                        If Mid(cControl.Name, 6, 1) = Saved.CURGUEST Then
                            cControl.BackColor = Color.DarkGreen
                        Else
                            cControl.BackColor = Color.LightGray
                        End If
                    End If
                End If
            Next cControl
        End If
    End Sub

    Private Sub Guest_Check(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guest4.Click, guest5.Click, guest6.Click, guest7.Click, guest8.Click, guest9.Click
        If Saved.CURGUEST = Mid(sender.name, 6, 1) And Saved.GUESTTRANSFER = True Then
            Saved.GUESTTRANSFER = False
        Else
            If Saved.CURGUEST = Mid(sender.name, 6, 1) Then
                Saved.CURGUEST = Mid(sender.name, 6, 1)
                Saved.GUESTTRANSFER = True
            Else
                Saved.CURGUEST = Mid(sender.name, 6, 1)
                Saved.GUESTTRANSFER = False
            End If
        End If
        Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub
End Class
