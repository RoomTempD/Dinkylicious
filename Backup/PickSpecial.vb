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
    Friend WithEvents lstSpecialPK As System.Windows.Forms.ListBox
    Friend WithEvents lstSpecialName As System.Windows.Forms.ListBox
    Friend WithEvents dgSpecials As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdConfirm = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Label
        Me.lstSpecialPK = New System.Windows.Forms.ListBox
        Me.lstSpecialName = New System.Windows.Forms.ListBox
        Me.dgSpecials = New System.Windows.Forms.DataGrid
        CType(Me.dgSpecials, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lstSpecialPK
        '
        Me.lstSpecialPK.Location = New System.Drawing.Point(40, 24)
        Me.lstSpecialPK.Name = "lstSpecialPK"
        Me.lstSpecialPK.Size = New System.Drawing.Size(32, 160)
        Me.lstSpecialPK.TabIndex = 3
        Me.lstSpecialPK.Visible = False
        '
        'lstSpecialName
        '
        Me.lstSpecialName.Location = New System.Drawing.Point(40, 24)
        Me.lstSpecialName.Name = "lstSpecialName"
        Me.lstSpecialName.Size = New System.Drawing.Size(256, 433)
        Me.lstSpecialName.TabIndex = 4
        '
        'dgSpecials
        '
        Me.dgSpecials.AllowNavigation = False
        Me.dgSpecials.AllowSorting = False
        Me.dgSpecials.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgSpecials.CaptionVisible = False
        Me.dgSpecials.DataMember = ""
        Me.dgSpecials.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgSpecials.Location = New System.Drawing.Point(304, 24)
        Me.dgSpecials.Name = "dgSpecials"
        Me.dgSpecials.ParentRowsVisible = False
        Me.dgSpecials.PreferredColumnWidth = 180
        Me.dgSpecials.ReadOnly = True
        Me.dgSpecials.RowHeadersVisible = False
        Me.dgSpecials.RowHeaderWidth = 50
        Me.dgSpecials.Size = New System.Drawing.Size(224, 432)
        Me.dgSpecials.TabIndex = 5
        Me.dgSpecials.TabStop = False
        '
        'PickSpecial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.ClientSize = New System.Drawing.Size(568, 560)
        Me.Controls.Add(Me.dgSpecials)
        Me.Controls.Add(Me.lstSpecialName)
        Me.Controls.Add(Me.lstSpecialPK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PickSpecial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignInOut"
        CType(Me.dgSpecials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub onDataGridMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgSpecials.MouseUp
        Dim pt = New Point(e.X, e.Y)
        Dim hit As DataGrid.HitTestInfo = dgSpecials.HitTest(pt)

        If hit.Type = Windows.Forms.DataGrid.HitTestType.Cell Then
            dgSpecials.CurrentCell = New DataGridCell(hit.Row, hit.Column)
            dgSpecials.Select(hit.Row)
        End If
    End Sub

    Private Sub PickSpecial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Connection As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Fireside.mdb")
        Dim Command As New OleDb.OleDbCommand
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim row As System.Data.DataRow
        Dim Count As Integer

        Connection.Open()
        Command.Connection = Connection

        Dim newcommand As New OleDb.OleDbCommand("DELETE FROM Specials where ITEM_NAME IS NULL", Connection)
        newcommand.ExecuteNonQuery()

        da.SelectCommand = New OleDb.OleDbCommand("SELECT ITEM_NAME FROM Specials WHERE ITEM_NUM <> 96 AND ITEM_NAME IS NOT NULL", Connection)
        
        da.Fill(ds, "Table")

        Count = ds.Tables("Table").Rows.Count
        dgSpecials.DataSource = ds.Tables("Table")

        Dim ts As New DataGridTableStyle
        ts.MappingName = "Employees"
        dgSpecials.TableStyles.Clear()
        dgSpecials.TableStyles.Add(ts)

        dgSpecials.TableStyles("Employees").GridColumnStyles(0).Width = 600
        'Connection.Close()

        Saved.Database_Connect()
        Saved.Specials_Open()


        ''Clear listboxes
        lstSpecialPK.Items.Clear()
        lstSpecialName.Items.Clear()

        ClosedTableInfoRST = db.OpenRecordset("CLOSED_TABLEINFO", 2)
        Saved.SpecialsRST.MoveFirst()
        Do Until Saved.SpecialsRST.EOF
            If Not Saved.SpecialsItemNum.Value = 96 Then
                lstSpecialPK.Items.Add(Saved.SpecialsItemNum.Value)
                lstSpecialName.Items.Add(Saved.SpecialsItemName.Value)
            End If
            Saved.SpecialsRST.MoveNext()
        Loop

        Saved.Specials_Close()
        Saved.Database_Disconnect()
    End Sub

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        Saved.Database_Connect()
        Saved.Specials_Open()

        If Now.DayOfWeek = 5 Then
            Saved.SpecialsRST.FindFirst("ITEM_NUM = " & 96)
            If Saved.SpecialsRST.NoMatch = False Then
                Saved.CURSPECIAL(0) = 96
                Saved.SPECIALLINK(0) = True

                If Not IsDBNull(Saved.SpecialsSpecial2.Value) Then
                    Saved.CURSPECIAL(1) = Saved.SpecialsSpecial2.Value
                    Saved.SPECIALLINK(1) = True
                Else
                    Saved.CURSPECIAL(1) = 0
                    Saved.SPECIALLINK(1) = False
                End If

                If Not IsDBNull(Saved.SpecialsSpecial3.Value) Then
                    Saved.CURSPECIAL(2) = Saved.SpecialsSpecial3.Value
                    Saved.SPECIALLINK(2) = True
                Else
                    Saved.CURSPECIAL(2) = 0
                    Saved.SPECIALLINK(2) = False
                End If

                If Not IsDBNull(Saved.SpecialsSpecial4.Value) Then
                    Saved.CURSPECIAL(3) = Saved.SpecialsSpecial4.Value
                    Saved.SPECIALLINK(3) = True
                Else
                    Saved.CURSPECIAL(3) = 0
                    Saved.SPECIALLINK(3) = False
                End If

                If Not IsDBNull(Saved.SpecialsSpecial5.Value) Then
                    Saved.CURSPECIAL(4) = Saved.SpecialsSpecial5.Value
                    Saved.SPECIALLINK(4) = True
                Else
                    Saved.CURSPECIAL(4) = 0
                    Saved.SPECIALLINK(4) = False
                End If

                If Not IsDBNull(Saved.SpecialsSpecial6.Value) Then
                    Saved.CURSPECIAL(5) = lstSpecialPK.SelectedItem
                    Saved.SPECIALLINK(5) = True
                Else
                    Saved.CURSPECIAL(5) = 0
                    Saved.SPECIALLINK(5) = False
                End If
            End If


        Else

            Saved.SpecialsRST.FindFirst("ITEM_NUM = " & lstSpecialPK.SelectedItem)
            If Saved.SpecialsRST.NoMatch = False Then
                Saved.CURSPECIAL(0) = Saved.SpecialsItemNum.Value
                Saved.SPECIALLINK(0) = True

                If Not IsDBNull(Saved.SpecialsSpecial2.Value) Then
                    Saved.CURSPECIAL(1) = Saved.SpecialsSpecial2.Value
                    Saved.SPECIALLINK(1) = True
                Else
                    Saved.CURSPECIAL(1) = 0
                    Saved.SPECIALLINK(1) = False
                End If

                If Not IsDBNull(Saved.SpecialsSpecial3.Value) Then
                    Saved.CURSPECIAL(2) = Saved.SpecialsSpecial3.Value
                    Saved.SPECIALLINK(2) = True
                Else
                    Saved.CURSPECIAL(2) = 0
                    Saved.SPECIALLINK(2) = False
                End If

                If Not IsDBNull(Saved.SpecialsSpecial4.Value) Then
                    Saved.CURSPECIAL(3) = Saved.SpecialsSpecial4.Value
                    Saved.SPECIALLINK(3) = True
                Else
                    Saved.CURSPECIAL(3) = 0
                    Saved.SPECIALLINK(3) = False
                End If

                If Not IsDBNull(Saved.SpecialsSpecial5.Value) Then
                    Saved.CURSPECIAL(4) = Saved.SpecialsSpecial5.Value
                    Saved.SPECIALLINK(4) = True
                Else
                    Saved.CURSPECIAL(4) = 0
                    Saved.SPECIALLINK(4) = False
                End If

                If Not IsDBNull(Saved.SpecialsSpecial6.Value) Then
                    Saved.CURSPECIAL(5) = Saved.SpecialsSpecial6.Value
                    Saved.SPECIALLINK(5) = True
                Else
                    Saved.CURSPECIAL(5) = 0
                    Saved.SPECIALLINK(5) = False
                End If
            End If
        End If

        Saved.Specials_Close()
        Saved.Database_Disconnect()
        Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub lstSpecialName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSpecialName.SelectedIndexChanged
        lstSpecialPK.SelectedIndex = lstSpecialName.SelectedIndex
    End Sub
End Class
