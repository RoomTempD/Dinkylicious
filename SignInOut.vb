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
    Friend WithEvents dgvSISO As System.Windows.Forms.DataGridView
    Friend WithEvents lstSISO4 As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdSignIn = New System.Windows.Forms.Label()
        Me.cmdSignOut = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Label()
        Me.lstSISO1 = New System.Windows.Forms.ListBox()
        Me.lstSISO2 = New System.Windows.Forms.ListBox()
        Me.lstSISO3 = New System.Windows.Forms.ListBox()
        Me.lstSISO4 = New System.Windows.Forms.ListBox()
        Me.dgvSISO = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSISO, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgvSISO
        '
        Me.dgvSISO.AllowUserToAddRows = False
        Me.dgvSISO.AllowUserToDeleteRows = False
        Me.dgvSISO.AllowUserToResizeColumns = False
        Me.dgvSISO.AllowUserToResizeRows = False
        Me.dgvSISO.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvSISO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSISO.Location = New System.Drawing.Point(176, 16)
        Me.dgvSISO.MultiSelect = False
        Me.dgvSISO.Name = "dgvSISO"
        Me.dgvSISO.ReadOnly = True
        Me.dgvSISO.RowHeadersVisible = False
        Me.dgvSISO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSISO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSISO.Size = New System.Drawing.Size(320, 304)
        Me.dgvSISO.TabIndex = 34
        '
        'SignInOut
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 344)
        Me.Controls.Add(Me.dgvSISO)
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
        CType(Me.dgvSISO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub SignInOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Update_SISO()
    End Sub

    Private Sub Update_SISO()

        dgvSISO.DataSource = data.GetData("SELECT SIGNINOUT.EMP_NUM AS EmpNum, EMPLOYEE.EMP_NAME AS EmpName, JOBS.JOB_TITLE AS JobTitle, FORMAT(SIGNINOUT.SIGNIN_TIME, ""hh:mm:ss"") AS SITime FROM JOBS INNER JOIN ((EMPLOYEE INNER JOIN EMPJOB ON EMPLOYEE.EMP_NUM = EMPJOB.EMP_NUM) INNER JOIN SIGNINOUT ON EMPLOYEE.EMP_NUM = SIGNINOUT.EMP_NUM) ON (JOBS.JOB_NUM = SIGNINOUT.JOB_NUM) AND (JOBS.JOB_NUM = EMPJOB.JOB_NUM) WHERE (((SIGNINOUT.SIGNOUT_TIME) Is Null) AND ((SIGNINOUT.SIGNIN_TIME) Is Not Null)) AND EMPLOYEE.EMP_NUM <> 99;").Tables(0)
        dgvSISO.Columns("EmpNum").Visible = False
        dgvSISO.Columns("EmpName").Width = 75
        dgvSISO.Columns("JobTitle").Width = 75

    End Sub

    Private Sub cmdSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSignOut.Click

        If dgvSISO.SelectedRows.Count > 0 Then
            data.RunSQL("UPDATE SIGNINOUT SET SIGNOUT_DATE = Now(), SIGNOUT_TIME = NOW() WHERE SIGNOUT_DATE IS NULL AND SIGNOUT_TIME IS NULL AND EMP_NUM = " & dgvSISO.SelectedRows(0).Cells(0).Value)
        End If

        Update_SISO()

    End Sub

    Private Sub cmdSignIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSignIn.Click
        Dim form As New EmployList
        Saved.GO(0) = False
        form.ShowDialog()

        If GO(0) = True Then
            Dim ds As New DataSet
            
            ds = data.GetData("SELECT COUNT(*) FROM SIGNINOUT WHERE EMP_NUM = " & Saved.EMPNUM & " AND SIGNOUT_TIME IS NULL")

            Dim count As Integer = ds.Tables(0).Rows(0).Item(0)

            If count = 0 Then
                data.RunSQL("INSERT INTO SIGNINOUT (EMP_NUM,SIGNIN_DATE,SIGNIN_TIME,JOB_NUM )VALUES (" & Saved.EMPNUM & ",Now(),Now()," & Saved.JOBNUM & ");")
            Else
                MsgBox("Employee is already signed in.")
            End If

        End If

        Update_SISO()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub
End Class