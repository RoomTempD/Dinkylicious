'Imports System.runtime.InteropServices
Public Class SignInOut
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
    Friend WithEvents cmdSignIn As System.Windows.Forms.Label
    Friend WithEvents cmdSignOut As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Label
    Friend WithEvents lstSISO1 As System.Windows.Forms.ListBox
    Friend WithEvents lstSISO2 As System.Windows.Forms.ListBox
    Friend WithEvents lstSISO3 As System.Windows.Forms.ListBox
    Friend WithEvents lstSISO4 As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdSignIn = New System.Windows.Forms.Label
        Me.cmdSignOut = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Label
        Me.lstSISO1 = New System.Windows.Forms.ListBox
        Me.lstSISO2 = New System.Windows.Forms.ListBox
        Me.lstSISO3 = New System.Windows.Forms.ListBox
        Me.lstSISO4 = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'cmdSignIn
        '
        Me.cmdSignIn.BackColor = System.Drawing.Color.Transparent
        Me.cmdSignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdSignIn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSignIn.ForeColor = System.Drawing.Color.Black
        Me.cmdSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSignIn.Location = New System.Drawing.Point(72, 112)
        Me.cmdSignIn.Name = "cmdSignIn"
        Me.cmdSignIn.Size = New System.Drawing.Size(80, 72)
        Me.cmdSignIn.TabIndex = 0
        Me.cmdSignIn.Text = "Sign In"
        Me.cmdSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdSignOut
        '
        Me.cmdSignOut.BackColor = System.Drawing.Color.Transparent
        Me.cmdSignOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdSignOut.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSignOut.ForeColor = System.Drawing.Color.Black
        Me.cmdSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSignOut.Location = New System.Drawing.Point(544, 104)
        Me.cmdSignOut.Name = "cmdSignOut"
        Me.cmdSignOut.Size = New System.Drawing.Size(80, 72)
        Me.cmdSignOut.TabIndex = 1
        Me.cmdSignOut.Text = "Sign Out"
        Me.cmdSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdCancel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.Black
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancel.Location = New System.Drawing.Point(544, 224)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 72)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstSISO1
        '
        Me.lstSISO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lstSISO1.ItemHeight = 20
        Me.lstSISO1.Location = New System.Drawing.Point(176, 16)
        Me.lstSISO1.Name = "lstSISO1"
        Me.lstSISO1.Size = New System.Drawing.Size(32, 304)
        Me.lstSISO1.TabIndex = 3
        Me.lstSISO1.Visible = False
        '
        'lstSISO2
        '
        Me.lstSISO2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lstSISO2.ItemHeight = 20
        Me.lstSISO2.Location = New System.Drawing.Point(208, 16)
        Me.lstSISO2.Name = "lstSISO2"
        Me.lstSISO2.Size = New System.Drawing.Size(80, 304)
        Me.lstSISO2.TabIndex = 4
        '
        'lstSISO3
        '
        Me.lstSISO3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lstSISO3.ItemHeight = 20
        Me.lstSISO3.Location = New System.Drawing.Point(288, 16)
        Me.lstSISO3.Name = "lstSISO3"
        Me.lstSISO3.Size = New System.Drawing.Size(120, 304)
        Me.lstSISO3.TabIndex = 5
        '
        'lstSISO4
        '
        Me.lstSISO4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lstSISO4.ItemHeight = 20
        Me.lstSISO4.Location = New System.Drawing.Point(408, 16)
        Me.lstSISO4.Name = "lstSISO4"
        Me.lstSISO4.Size = New System.Drawing.Size(88, 304)
        Me.lstSISO4.TabIndex = 6
        '
        'SignInOut
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.ClientSize = New System.Drawing.Size(744, 344)
        Me.Controls.Add(Me.lstSISO4)
        Me.Controls.Add(Me.lstSISO3)
        Me.Controls.Add(Me.lstSISO2)
        Me.Controls.Add(Me.lstSISO1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSignOut)
        Me.Controls.Add(Me.cmdSignIn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignInOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignInOut"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub SignInOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Update_SISO()
    End Sub

    Private Sub Update_SISO()
        'Open used tables
        Saved.Database_Connect()
        Saved.Emp_Open()
        Saved.EmpJob_Open()
        Saved.SIO_Open()
        Saved.Jobs_Open()

        'Clear listboxes
        lstSISO1.Items.Clear()
        lstSISO2.Items.Clear()
        lstSISO3.Items.Clear()
        lstSISO4.Items.Clear()

        Saved.SIORST.MoveFirst()
        Do Until Saved.SIORST.EOF
            If Not IsDBNull(Saved.SIOSignInTime.Value) And IsDBNull(Saved.SIOSignOutTime.Value) Then
                Saved.EmpRST.FindFirst("[EMP_NUM] = " & Saved.SIOEmpNum.Value)
                If Saved.EmpRST.NoMatch = False Then
                    Saved.EmpJobRST.FindFirst("[EMP_NUM] = " & Saved.SIOEmpNum.Value & " AND [JOB_NUM] = " & Saved.SIOJobNum.Value)
                    If Saved.EmpJobRST.NoMatch = False Then
                        lstSISO1.Items.Add(Saved.SIOEmpNum.Value)
                        lstSISO2.Items.Add(Saved.EmpEmpName.Value)
                        Saved.JobsRST.MoveFirst()
                        Do Until Saved.JobsRST.EOF()
                            If Saved.JobsJobNum.Value = Saved.SIOJobNum.Value Then
                                lstSISO3.Items.Add(Saved.JobsJobTitle.Value)
                            End If
                            Saved.JobsRST.MoveNext()
                        Loop
                        lstSISO4.Items.Add(Format(Saved.SIOSignInTime.Value, "Short Time"))
                        'lstSISO4.Items.Add(Format(DateTime.Now.Add(-Saved.SIOSignInTime.Value), "Short Time"))
                    End If
                End If
            End If
            Saved.SIORST.MoveNext()
        Loop

        Saved.Emp_Close()
        Saved.EmpJob_Close()
        Saved.SIO_Close()
        Saved.Jobs_Close()
        Saved.Database_Disconnect()
    End Sub

    Private Sub cmdSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSignOut.Click
        Saved.Database_Connect()
        Saved.Emp_Open()
        Saved.EmpJob_Open()
        Saved.SIO_Open()

        Saved.SIORST.FindFirst("[EMP_NUM] = " & lstSISO1.SelectedItem & " AND [SIGNOUT_TIME] IS NULL")
        If Saved.SIORST.NoMatch = False Then
            Saved.SIORST.Edit()
            Saved.SIOSignOutDate.Value = Format(Now(), "Short Date")
            Saved.SIOSignOutTime.Value = Format(Now(), "Short Time")
            Saved.SIORST.Update()
        End If

        Saved.Emp_Close()
        Saved.EmpJob_Close()
        Saved.SIO_Close()
        Saved.Database_Disconnect()
        Update_SISO()
        cmdSignOut.Enabled = True
    End Sub

    Private Sub lstSISO1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSISO1.SelectedIndexChanged
        lstSISO2.SelectedIndex = lstSISO1.SelectedIndex
        lstSISO3.SelectedIndex = lstSISO1.SelectedIndex
        lstSISO4.SelectedIndex = lstSISO1.SelectedIndex
        If Not IsDBNull(lstSISO1.SelectedItem) Then
            cmdSignOut.Enabled = True
        End If
    End Sub

    Private Sub lstSISO2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSISO2.SelectedIndexChanged
        lstSISO1.SelectedIndex = lstSISO2.SelectedIndex
        lstSISO3.SelectedIndex = lstSISO2.SelectedIndex
        lstSISO4.SelectedIndex = lstSISO2.SelectedIndex
    End Sub

    Private Sub lstSISO3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSISO3.SelectedIndexChanged
        lstSISO1.SelectedIndex = lstSISO3.SelectedIndex
        lstSISO2.SelectedIndex = lstSISO3.SelectedIndex
        lstSISO4.SelectedIndex = lstSISO3.SelectedIndex
    End Sub

    Private Sub lstSISO4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSISO4.SelectedIndexChanged
        lstSISO1.SelectedIndex = lstSISO4.SelectedIndex
        lstSISO2.SelectedIndex = lstSISO4.SelectedIndex
        lstSISO3.SelectedIndex = lstSISO4.SelectedIndex
    End Sub

    Private Sub cmdSignIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSignIn.Click
        Saved.Database_Connect()
        Saved.Emp_Open()
        Saved.EmpJob_Open()
        Saved.Jobs_Open()
        Saved.SIO_Open()

        'Change... 
        
        Dim form As New EmployList
        Saved.GO(0) = False
        form.ShowDialog()

        'EMPNUM = InputBox("Please enter employee number")
        'JOBNUM = InputBox("Please enter job number", , 1)
        '...change
        If GO(0) = True Then
            Saved.SIORST.FindNext("EMP_NUM = " & Saved.EMPNUM & " AND SIGNOUT_TIME IS NULL")
            If Saved.SIORST.NoMatch = True Then
                Saved.SIORST.AddNew()
                Saved.SIOEmpNum.Value = Saved.EMPNUM
                Saved.SIOSignInDate.Value = Format(Now(), "Short Date")
                Saved.SIOSignInTime.Value = Format(Now(), "Short Time")
                Saved.SIOJobNum.Value = Saved.JOBNUM
                Saved.SIORST.Update()
            Else
                MsgBox("Employee is already signed in.")
            End If
        End If
        Saved.Emp_Close()
        Saved.EmpJob_Close()
        Saved.SIO_Close()
        Saved.Jobs_Close()
        Saved.Database_Disconnect()
        Update_SISO()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub
End Class