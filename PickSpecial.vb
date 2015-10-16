Public Class PickSpecial
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
    Friend WithEvents cmdCancel As System.Windows.Forms.Label
    Friend WithEvents cmdConfirm As System.Windows.Forms.Label
    Friend WithEvents dgvSpecials As System.Windows.Forms.DataGridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdConfirm = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Label()
        Me.dgvSpecials = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSpecials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.Color.Transparent
        Me.cmdConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdConfirm.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.ForeColor = System.Drawing.Color.Black
        Me.cmdConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdConfirm.Location = New System.Drawing.Point(192, 472)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(80, 72)
        Me.cmdConfirm.TabIndex = 1
        Me.cmdConfirm.Text = "Confirm"
        Me.cmdConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdCancel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.Black
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancel.Location = New System.Drawing.Point(64, 472)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 72)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvSpecials
        '
        Me.dgvSpecials.AllowUserToAddRows = False
        Me.dgvSpecials.AllowUserToDeleteRows = False
        Me.dgvSpecials.AllowUserToResizeColumns = False
        Me.dgvSpecials.AllowUserToResizeRows = False
        Me.dgvSpecials.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvSpecials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSpecials.Location = New System.Drawing.Point(40, 20)
        Me.dgvSpecials.MultiSelect = False
        Me.dgvSpecials.Name = "dgvSpecials"
        Me.dgvSpecials.ReadOnly = True
        Me.dgvSpecials.RowHeadersVisible = False
        Me.dgvSpecials.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSpecials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSpecials.Size = New System.Drawing.Size(256, 433)
        Me.dgvSpecials.TabIndex = 6
        '
        'PickSpecial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(337, 560)
        Me.Controls.Add(Me.dgvSpecials)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PickSpecial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignInOut"
        CType(Me.dgvSpecials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub PickSpecial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgvSpecials.DataSource = data.GetData("SELECT ITEM_NUM, ITEM_NAME FROM Specials WHERE ITEM_NUM <> 96").Tables(0)
        dgvSpecials.Columns("ITEM_NUM").Visible = False
        dgvSpecials.Columns("ITEM_NAME").Width = 600

    End Sub

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click

        Dim ds As New DataSet

        If Now.DayOfWeek = 5 Then
            ds = data.GetData("SELECT ITEM_NUM, SPECIAL2, SPECIAL3, SPECIAL4, SPECIAL5, " & dgvSpecials.SelectedRows(0).Cells(0).Value & " AS SPECIAL6, (SELECT ITEM_NAME FROM ITEM WHERE ITEM_NUM = SPECIALS.ITEM_NUM) as SPECIALNAME, (SELECT ITEM_NAME FROM ITEM WHERE ITEM_NUM = SPECIAL2) as SPECIAL2NAME, (SELECT ITEM_NAME FROM ITEM WHERE ITEM_NUM = SPECIAL3) as SPECIAL3NAME, (SELECT ITEM_NAME FROM ITEM WHERE ITEM_NUM = SPECIAL4) as SPECIAL4NAME, (SELECT ITEM_NAME FROM ITEM WHERE ITEM_NUM = SPECIAL5) as SPECIAL5NAME, (SELECT ITEM_NAME FROM ITEM WHERE ITEM_NUM = " & dgvSpecials.SelectedRows(0).Cells(0).Value & ") as SPECIAL6NAME FROM SPECIALS WHERE ITEM_NUM = 96")
        Else
            ds = data.GetData("SELECT ITEM_NUM, SPECIAL2, SPECIAL3, SPECIAL4, SPECIAL5, SPECIAL6, (SELECT ITEM_NAME FROM ITEM WHERE ITEM_NUM = SPECIALS.ITEM_NUM) as SPECIALNAME, (SELECT ITEM_NAME FROM ITEM WHERE ITEM_NUM = SPECIAL2) as SPECIAL2NAME, (SELECT ITEM_NAME FROM ITEM WHERE ITEM_NUM = SPECIAL3) as SPECIAL3NAME, (SELECT ITEM_NAME FROM ITEM WHERE ITEM_NUM = SPECIAL4) as SPECIAL4NAME, (SELECT ITEM_NAME FROM ITEM WHERE ITEM_NUM = SPECIAL5) as SPECIAL5NAME, (SELECT ITEM_NAME FROM ITEM WHERE ITEM_NUM = SPECIAL6) as SPECIAL6NAME FROM SPECIALS WHERE ITEM_NUM = " & dgvSpecials.SelectedRows(0).Cells(0).Value)
        End If

        Saved.CURSPECIAL(0) = ds.Tables(0).Rows(0).Item("ITEM_NUM")
        Saved.CURSPECIAL(1) = ds.Tables(0).Rows(0).Item("SPECIAL2")
        Saved.CURSPECIAL(2) = ds.Tables(0).Rows(0).Item("SPECIAL3")
        Saved.CURSPECIAL(3) = ds.Tables(0).Rows(0).Item("SPECIAL4")
        Saved.CURSPECIAL(4) = ds.Tables(0).Rows(0).Item("SPECIAL5")
        Saved.CURSPECIAL(5) = ds.Tables(0).Rows(0).Item("SPECIAL6")

        Saved.SPECIALTEXT(0) = IIf(Not IsDBNull(ds.Tables(0).Rows(0).Item("SPECIALNAME")), ds.Tables(0).Rows(0).Item("SPECIALNAME"), "")
        Saved.SPECIALTEXT(1) = IIf(Not IsDBNull(ds.Tables(0).Rows(0).Item("SPECIAL2NAME")), ds.Tables(0).Rows(0).Item("SPECIAL2NAME"), "")
        Saved.SPECIALTEXT(2) = IIf(Not IsDBNull(ds.Tables(0).Rows(0).Item("SPECIAL3NAME")), ds.Tables(0).Rows(0).Item("SPECIAL3NAME"), "")
        Saved.SPECIALTEXT(3) = IIf(Not IsDBNull(ds.Tables(0).Rows(0).Item("SPECIAL4NAME")), ds.Tables(0).Rows(0).Item("SPECIAL4NAME"), "")
        Saved.SPECIALTEXT(4) = IIf(Not IsDBNull(ds.Tables(0).Rows(0).Item("SPECIAL5NAME")), ds.Tables(0).Rows(0).Item("SPECIAL5NAME"), "")
        Saved.SPECIALTEXT(5) = IIf(Not IsDBNull(ds.Tables(0).Rows(0).Item("SPECIAL6NAME")), ds.Tables(0).Rows(0).Item("SPECIAL6NAME"), "")

        For x As Integer = 0 To 6
            If Saved.CURSPECIAL(x) <> 0 Then
                Saved.SPECIALLINK(x) = True
            Else
                Saved.SPECIALLINK(x) = False
            End If
        Next
        POS.UpdateSpecials()
        Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub
End Class
