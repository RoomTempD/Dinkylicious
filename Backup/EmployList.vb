Public Class EmployList
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
    Friend WithEvents cmdCancel As System.Windows.Forms.Label
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents lstJob As System.Windows.Forms.ListBox
    Friend WithEvents lstNamePK As System.Windows.Forms.ListBox
    Friend WithEvents lstJobPK As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdSignIn = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Label
        Me.lstName = New System.Windows.Forms.ListBox
        Me.lstJob = New System.Windows.Forms.ListBox
        Me.lstNamePK = New System.Windows.Forms.ListBox
        Me.lstJobPK = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'cmdSignIn
        '
        Me.cmdSignIn.BackColor = System.Drawing.Color.Transparent
        Me.cmdSignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdSignIn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSignIn.ForeColor = System.Drawing.Color.Black
        Me.cmdSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSignIn.Location = New System.Drawing.Point(288, 56)
        Me.cmdSignIn.Name = "cmdSignIn"
        Me.cmdSignIn.Size = New System.Drawing.Size(80, 72)
        Me.cmdSignIn.TabIndex = 0
        Me.cmdSignIn.Text = "Sign In"
        Me.cmdSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdCancel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.Black
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancel.Location = New System.Drawing.Point(288, 248)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 72)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstName
        '
        Me.lstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstName.ItemHeight = 20
        Me.lstName.Location = New System.Drawing.Point(16, 16)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(112, 364)
        Me.lstName.TabIndex = 4
        '
        'lstJob
        '
        Me.lstJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstJob.ItemHeight = 20
        Me.lstJob.Location = New System.Drawing.Point(128, 16)
        Me.lstJob.Name = "lstJob"
        Me.lstJob.Size = New System.Drawing.Size(120, 364)
        Me.lstJob.TabIndex = 5
        '
        'lstNamePK
        '
        Me.lstNamePK.Location = New System.Drawing.Point(16, 16)
        Me.lstNamePK.Name = "lstNamePK"
        Me.lstNamePK.Size = New System.Drawing.Size(112, 160)
        Me.lstNamePK.TabIndex = 6
        Me.lstNamePK.Visible = False
        '
        'lstJobPK
        '
        Me.lstJobPK.Location = New System.Drawing.Point(128, 16)
        Me.lstJobPK.Name = "lstJobPK"
        Me.lstJobPK.Size = New System.Drawing.Size(120, 160)
        Me.lstJobPK.TabIndex = 7
        Me.lstJobPK.Visible = False
        '
        'EmployList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.lstJob)
        Me.Controls.Add(Me.lstName)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSignIn)
        Me.Controls.Add(Me.lstNamePK)
        Me.Controls.Add(Me.lstJobPK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignInOut"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub EmployList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstName.Items.Clear()
        lstNamePK.Items.Clear()
        lstJob.Items.Clear()
        lstJobPK.Items.Clear()

        Saved.EmpRST.MoveFirst()
        Do Until Saved.EmpRST.EOF
            lstNamePK.Items.Add(Saved.EmpEmpNum.Value)
            lstName.Items.Add(Saved.EmpEmpName.Value)
            Saved.EmpRST.MoveNext()
        Loop
    End Sub

    Private Sub cmdSignIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSignIn.Click
        Saved.EMPNUM = lstNamePK.SelectedItem
        Saved.JOBNUM = lstJobPK.SelectedItem
        Saved.GO(0) = True
        Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Saved.GO(0) = False
        Close()
    End Sub

    Private Sub lstName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstName.SelectedIndexChanged
        lstJob.Items.Clear()
        lstJobPK.Items.Clear()

        lstNamePK.SelectedIndex = lstName.SelectedIndex
        Saved.EmpJobRST.MoveFirst()
        Do Until Saved.EmpJobRST.EOF
            If Saved.EmpJobEmpNum.Value = lstNamePK.SelectedItem Then
                lstJobPK.Items.Add(Saved.EmpJobJobNum.Value)

                Saved.JobsRST.MoveFirst()
                Do Until Saved.JobsRST.EOF()
                    If Saved.JobsJobNum.Value = Saved.EmpJobJobNum.Value Then
                        lstJob.Items.Add(Saved.JobsJobTitle.Value)
                    End If
                    Saved.JobsRST.MoveNext()
                Loop
            End If
            Saved.EmpJobRST.MoveNext()
        Loop
        lstJob.SelectedIndex = 0
    End Sub

    Private Sub lstJob_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstJob.SelectedIndexChanged
        lstJobPK.SelectedIndex = lstJob.SelectedIndex
    End Sub
End Class
