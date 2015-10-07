Public Class ChangeServer
    Inherits System.Windows.Forms.Form
    Public frmPOS As POS

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmd1 = New System.Windows.Forms.Button
        Me.cmd2 = New System.Windows.Forms.Button
        Me.cmd3 = New System.Windows.Forms.Button
        Me.cmd4 = New System.Windows.Forms.Button
        Me.cmd5 = New System.Windows.Forms.Button
        Me.cmd6 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmd1
        '
        Me.cmd1.BackColor = System.Drawing.Color.DarkCyan
        Me.cmd1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd1.Location = New System.Drawing.Point(24, 24)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(96, 64)
        Me.cmd1.TabIndex = 0
        Me.cmd1.Text = "Button1"
        Me.cmd1.Visible = False
        '
        'cmd2
        '
        Me.cmd2.BackColor = System.Drawing.Color.DarkCyan
        Me.cmd2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd2.Location = New System.Drawing.Point(152, 24)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(96, 64)
        Me.cmd2.TabIndex = 1
        Me.cmd2.Text = "Button2"
        Me.cmd2.Visible = False
        '
        'cmd3
        '
        Me.cmd3.BackColor = System.Drawing.Color.DarkCyan
        Me.cmd3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd3.Location = New System.Drawing.Point(280, 24)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(96, 64)
        Me.cmd3.TabIndex = 2
        Me.cmd3.Text = "Button3"
        Me.cmd3.Visible = False
        '
        'cmd4
        '
        Me.cmd4.BackColor = System.Drawing.Color.DarkCyan
        Me.cmd4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd4.Location = New System.Drawing.Point(24, 112)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(96, 64)
        Me.cmd4.TabIndex = 3
        Me.cmd4.Text = "Button4"
        Me.cmd4.Visible = False
        '
        'cmd5
        '
        Me.cmd5.BackColor = System.Drawing.Color.DarkCyan
        Me.cmd5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd5.Location = New System.Drawing.Point(152, 112)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(96, 64)
        Me.cmd5.TabIndex = 4
        Me.cmd5.Text = "Button2"
        Me.cmd5.Visible = False
        '
        'cmd6
        '
        Me.cmd6.BackColor = System.Drawing.Color.DarkCyan
        Me.cmd6.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd6.Location = New System.Drawing.Point(280, 112)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(96, 64)
        Me.cmd6.TabIndex = 5
        Me.cmd6.Text = "Button3"
        Me.cmd6.Visible = False
        '
        'ChangeServer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.cmd6)
        Me.Controls.Add(Me.cmd5)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.cmd3)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChangeServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignInOut"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ChangeServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Saved.Database_Connect()
        Saved.Emp_Open()
        Saved.EmpJob_Open()
        Saved.Jobs_Open()
        Saved.SIO_Open()

        Saved.SIORST.MoveFirst()
        Do Until Saved.SIORST.EOF
            If IsDBNull(Saved.SIOSignOutTime.Value) And Not IsDBNull(Saved.SIOSignInTime.Value) And Saved.SIOJobNum.Value = 1 Then
                Saved.EmpRST.FindFirst("EMP_NUM = " & Saved.SIOEmpNum.Value)
                If cmd1.Visible = False Then
                    cmd1.Visible = True
                    cmd1.Text = Saved.EmpEmpName.Value
                Else
                    If cmd2.Visible = False Then
                        cmd2.Visible = True
                        cmd2.Text = Saved.EmpEmpName.Value
                    Else
                        If cmd3.Visible = False Then
                            cmd3.Visible = True
                            cmd3.Text = Saved.EmpEmpName.Value
                        Else
                            If cmd4.Visible = False Then
                                cmd4.Visible = True
                                cmd4.Text = Saved.EmpEmpName.Value
                            Else
                                If cmd5.Visible = False Then
                                    cmd5.Visible = True
                                    cmd5.Text = Saved.EmpEmpName.Value
                                Else
                                    If cmd6.Visible = False Then
                                        cmd6.Visible = True
                                        cmd6.Text = Saved.EmpEmpName.Value
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            Saved.SIORST.MoveNext()
        Loop
        ' Saved.Emp_Close()
        ' Saved.EmpJob_Close()
        ' Saved.SIO_Close()
        ' Saved.Jobs_Close()
        ' Saved.Database_Disconnect()
    End Sub

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click, cmd2.Click, cmd3.Click, cmd4.Click, cmd5.Click, cmd6.Click
        Saved.Database_Connect()
        Saved.Emp_Open()

        Saved.EmpRST.FindFirst("EMP_NAME = '" & sender.Text & "'")
        If Saved.EmpRST.NoMatch = False Then
            Saved.CURSERVER = Saved.EmpEmpNum.Value
            Saved.CURSERVERNAME = Saved.EmpEmpName.Value
            Saved.CURSERVER2 = Saved.EmpEmpNum.Value
        End If

        Saved.EmpRST.FindFirst("EMP_NUM = " & Saved.CURSERVER)
        If Saved.EmpRST.NoMatch = False Then

        End If

        ' Saved.Emp_Close()
        ' Saved.Database_Disconnect()
        Close()
    End Sub

End Class
