'Imports System.runtime.InteropServices
Public Class SelectTable
    Inherits System.Windows.Forms.Form
    Dim isAVAILABLE(50) As Boolean
    Dim isOWN(50) As Boolean
    Dim BARisAVAILABLE(50) As Boolean
    Dim GUESTCOUNT(50) As Integer
    Dim TABLENAME(50) As String
    Dim UNCLAIMED(50) As Boolean
    Dim TABLETOSEAT As Integer = 0
    Dim lstOldValue As Integer = -5
    Friend WithEvents dgvCustomTables As System.Windows.Forms.DataGridView
    Friend WithEvents cmdChangeServer As System.Windows.Forms.Button
    Dim CLAIM As Boolean

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
    Friend WithEvents tbl12 As System.Windows.Forms.Button
    Friend WithEvents tbl11 As System.Windows.Forms.Button
    Friend WithEvents tbl13 As System.Windows.Forms.Button
    Friend WithEvents tbl01 As System.Windows.Forms.Button
    Friend WithEvents tbl02 As System.Windows.Forms.Button
    Friend WithEvents tbl03 As System.Windows.Forms.Button
    Friend WithEvents tbl09 As System.Windows.Forms.Button
    Friend WithEvents tbl08 As System.Windows.Forms.Button
    Friend WithEvents tbl05 As System.Windows.Forms.Button
    Friend WithEvents tbl04 As System.Windows.Forms.Button
    Friend WithEvents tbl06 As System.Windows.Forms.Button
    Friend WithEvents tbl07 As System.Windows.Forms.Button
    Friend WithEvents cmdOtherTable As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tbl01 = New System.Windows.Forms.Button()
        Me.tbl02 = New System.Windows.Forms.Button()
        Me.tbl03 = New System.Windows.Forms.Button()
        Me.tbl09 = New System.Windows.Forms.Button()
        Me.tbl08 = New System.Windows.Forms.Button()
        Me.tbl10 = New System.Windows.Forms.Button()
        Me.tbl13 = New System.Windows.Forms.Button()
        Me.tbl12 = New System.Windows.Forms.Button()
        Me.tbl11 = New System.Windows.Forms.Button()
        Me.tbl05 = New System.Windows.Forms.Button()
        Me.tbl04 = New System.Windows.Forms.Button()
        Me.tbl06 = New System.Windows.Forms.Button()
        Me.tbl07 = New System.Windows.Forms.Button()
        Me.cmdOtherTable = New System.Windows.Forms.Button()
        Me.dgvCustomTables = New System.Windows.Forms.DataGridView()
        Me.cmdChangeServer = New System.Windows.Forms.Button()
        CType(Me.dgvCustomTables, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'tbl01
        '
        Me.tbl01.BackColor = System.Drawing.SystemColors.Control
        Me.tbl01.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl01.Location = New System.Drawing.Point(12, 12)
        Me.tbl01.Name = "tbl01"
        Me.tbl01.Size = New System.Drawing.Size(144, 92)
        Me.tbl01.TabIndex = 0
        Me.tbl01.TabStop = False
        Me.tbl01.Tag = ""
        Me.tbl01.Text = "Close"
        Me.tbl01.UseVisualStyleBackColor = False
        '
        'tbl02
        '
        Me.tbl02.BackColor = System.Drawing.SystemColors.Control
        Me.tbl02.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl02.Location = New System.Drawing.Point(12, 166)
        Me.tbl02.Name = "tbl02"
        Me.tbl02.Size = New System.Drawing.Size(87, 92)
        Me.tbl02.TabIndex = 1
        Me.tbl02.TabStop = False
        Me.tbl02.Tag = ""
        Me.tbl02.Text = "Close"
        Me.tbl02.UseVisualStyleBackColor = False
        '
        'tbl03
        '
        Me.tbl03.BackColor = System.Drawing.SystemColors.Control
        Me.tbl03.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl03.Location = New System.Drawing.Point(271, 106)
        Me.tbl03.Name = "tbl03"
        Me.tbl03.Size = New System.Drawing.Size(144, 92)
        Me.tbl03.TabIndex = 2
        Me.tbl03.TabStop = False
        Me.tbl03.Tag = ""
        Me.tbl03.Text = "Close"
        Me.tbl03.UseVisualStyleBackColor = False
        '
        'tbl09
        '
        Me.tbl09.BackColor = System.Drawing.SystemColors.Control
        Me.tbl09.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl09.Location = New System.Drawing.Point(10, 447)
        Me.tbl09.Name = "tbl09"
        Me.tbl09.Size = New System.Drawing.Size(75, 65)
        Me.tbl09.TabIndex = 3
        Me.tbl09.TabStop = False
        Me.tbl09.Tag = ""
        Me.tbl09.Text = "Close"
        Me.tbl09.UseVisualStyleBackColor = False
        '
        'tbl08
        '
        Me.tbl08.BackColor = System.Drawing.SystemColors.Control
        Me.tbl08.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl08.Location = New System.Drawing.Point(862, 166)
        Me.tbl08.Name = "tbl08"
        Me.tbl08.Size = New System.Drawing.Size(87, 92)
        Me.tbl08.TabIndex = 4
        Me.tbl08.TabStop = False
        Me.tbl08.Tag = ""
        Me.tbl08.Text = "Close"
        Me.tbl08.UseVisualStyleBackColor = False
        '
        'tbl10
        '
        Me.tbl10.BackColor = System.Drawing.SystemColors.Control
        Me.tbl10.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl10.Location = New System.Drawing.Point(98, 447)
        Me.tbl10.Name = "tbl10"
        Me.tbl10.Size = New System.Drawing.Size(75, 65)
        Me.tbl10.TabIndex = 5
        Me.tbl10.TabStop = False
        Me.tbl10.Tag = ""
        Me.tbl10.Text = "Close"
        Me.tbl10.UseVisualStyleBackColor = False
        '
        'tbl13
        '
        Me.tbl13.BackColor = System.Drawing.SystemColors.Control
        Me.tbl13.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl13.Location = New System.Drawing.Point(362, 447)
        Me.tbl13.Name = "tbl13"
        Me.tbl13.Size = New System.Drawing.Size(75, 65)
        Me.tbl13.TabIndex = 7
        Me.tbl13.TabStop = False
        Me.tbl13.Tag = ""
        Me.tbl13.Text = "Close"
        Me.tbl13.UseVisualStyleBackColor = False
        '
        'tbl12
        '
        Me.tbl12.BackColor = System.Drawing.SystemColors.Control
        Me.tbl12.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl12.Location = New System.Drawing.Point(274, 447)
        Me.tbl12.Name = "tbl12"
        Me.tbl12.Size = New System.Drawing.Size(75, 65)
        Me.tbl12.TabIndex = 8
        Me.tbl12.TabStop = False
        Me.tbl12.Tag = ""
        Me.tbl12.Text = "Close"
        Me.tbl12.UseVisualStyleBackColor = False
        '
        'tbl11
        '
        Me.tbl11.BackColor = System.Drawing.SystemColors.Control
        Me.tbl11.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl11.Location = New System.Drawing.Point(186, 447)
        Me.tbl11.Name = "tbl11"
        Me.tbl11.Size = New System.Drawing.Size(75, 65)
        Me.tbl11.TabIndex = 10
        Me.tbl11.TabStop = False
        Me.tbl11.Tag = ""
        Me.tbl11.Text = "Close"
        Me.tbl11.UseVisualStyleBackColor = False
        '
        'tbl05
        '
        Me.tbl05.BackColor = System.Drawing.SystemColors.Control
        Me.tbl05.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl05.Location = New System.Drawing.Point(525, 106)
        Me.tbl05.Name = "tbl05"
        Me.tbl05.Size = New System.Drawing.Size(144, 92)
        Me.tbl05.TabIndex = 11
        Me.tbl05.TabStop = False
        Me.tbl05.Tag = ""
        Me.tbl05.Text = "Close"
        Me.tbl05.UseVisualStyleBackColor = False
        '
        'tbl04
        '
        Me.tbl04.BackColor = System.Drawing.SystemColors.Control
        Me.tbl04.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl04.Location = New System.Drawing.Point(271, 243)
        Me.tbl04.Name = "tbl04"
        Me.tbl04.Size = New System.Drawing.Size(144, 92)
        Me.tbl04.TabIndex = 12
        Me.tbl04.TabStop = False
        Me.tbl04.Tag = ""
        Me.tbl04.Text = "Close"
        Me.tbl04.UseVisualStyleBackColor = False
        '
        'tbl06
        '
        Me.tbl06.BackColor = System.Drawing.SystemColors.Control
        Me.tbl06.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl06.Location = New System.Drawing.Point(525, 243)
        Me.tbl06.Name = "tbl06"
        Me.tbl06.Size = New System.Drawing.Size(144, 92)
        Me.tbl06.TabIndex = 13
        Me.tbl06.TabStop = False
        Me.tbl06.Tag = ""
        Me.tbl06.Text = "Close"
        Me.tbl06.UseVisualStyleBackColor = False
        '
        'tbl07
        '
        Me.tbl07.BackColor = System.Drawing.SystemColors.Control
        Me.tbl07.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl07.Location = New System.Drawing.Point(805, 12)
        Me.tbl07.Name = "tbl07"
        Me.tbl07.Size = New System.Drawing.Size(144, 92)
        Me.tbl07.TabIndex = 14
        Me.tbl07.TabStop = False
        Me.tbl07.Tag = ""
        Me.tbl07.Text = "Close"
        Me.tbl07.UseVisualStyleBackColor = False
        '
        'cmdOtherTable
        '
        Me.cmdOtherTable.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOtherTable.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOtherTable.Location = New System.Drawing.Point(616, 448)
        Me.cmdOtherTable.Name = "cmdOtherTable"
        Me.cmdOtherTable.Size = New System.Drawing.Size(64, 65)
        Me.cmdOtherTable.TabIndex = 41
        Me.cmdOtherTable.TabStop = False
        Me.cmdOtherTable.Tag = ""
        Me.cmdOtherTable.Text = "Other Table"
        Me.cmdOtherTable.UseVisualStyleBackColor = False
        '
        'dgvCustomTables
        '
        Me.dgvCustomTables.AllowUserToAddRows = False
        Me.dgvCustomTables.AllowUserToDeleteRows = False
        Me.dgvCustomTables.AllowUserToResizeColumns = False
        Me.dgvCustomTables.AllowUserToResizeRows = False
        Me.dgvCustomTables.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvCustomTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCustomTables.Location = New System.Drawing.Point(458, 417)
        Me.dgvCustomTables.MultiSelect = False
        Me.dgvCustomTables.Name = "dgvCustomTables"
        Me.dgvCustomTables.ReadOnly = True
        Me.dgvCustomTables.RowHeadersVisible = False
        Me.dgvCustomTables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCustomTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomTables.Size = New System.Drawing.Size(152, 95)
        Me.dgvCustomTables.TabIndex = 45
        '
        'cmdChangeServer
        '
        Me.cmdChangeServer.BackColor = System.Drawing.SystemColors.Control
        Me.cmdChangeServer.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChangeServer.Location = New System.Drawing.Point(686, 448)
        Me.cmdChangeServer.Name = "cmdChangeServer"
        Me.cmdChangeServer.Size = New System.Drawing.Size(92, 65)
        Me.cmdChangeServer.TabIndex = 46
        Me.cmdChangeServer.TabStop = False
        Me.cmdChangeServer.Tag = ""
        Me.cmdChangeServer.Text = "Change Server"
        Me.cmdChangeServer.UseVisualStyleBackColor = False
        '
        'SelectTable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(961, 530)
        Me.Controls.Add(Me.cmdChangeServer)
        Me.Controls.Add(Me.dgvCustomTables)
        Me.Controls.Add(Me.cmdOtherTable)
        Me.Controls.Add(Me.tbl07)
        Me.Controls.Add(Me.tbl06)
        Me.Controls.Add(Me.tbl04)
        Me.Controls.Add(Me.tbl05)
        Me.Controls.Add(Me.tbl11)
        Me.Controls.Add(Me.tbl12)
        Me.Controls.Add(Me.tbl13)
        Me.Controls.Add(Me.tbl10)
        Me.Controls.Add(Me.tbl08)
        Me.Controls.Add(Me.tbl09)
        Me.Controls.Add(Me.tbl03)
        Me.Controls.Add(Me.tbl02)
        Me.Controls.Add(Me.tbl01)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SelectTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvCustomTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub StoolCheck(ByVal StoolNumber As Integer)
        Dim Stool As New Stool
        Dim Ticket As New Ticket

        Stool = Stool.getStoolInfo(StoolNumber)

        If Stool.isAvailable Then
            d.CreateNewStool(StoolNumber)
        End If


        Ticket = Ticket.getTicketInfoByStoolNumber(StoolNumber)
        Active.Clear()
        Active.Ticket = Ticket.GetTicketNumber
        Active.Stool = StoolNumber
        Close()

    End Sub

    Public Sub TableCheck(ByVal TableNumber As Integer)
        Dim Table As New Table
        Dim Ticket As New Ticket
        Dim GuestCount As Integer = 0
        Dim OKToLoadTable As Boolean = False

        Table = Table.getTableInfo(TableNumber)

        If Table.isAvailable Then
            GuestCount = EnterGuestCount.getGuestCount

            If GuestCount > 0 Then
                If TABLETOSEAT = 0 Then
                    d.CreateNewTable(TableNumber, GuestCount, Active.Guest)
                    OKToLoadTable = True
                    'MsgBox("table is available, guest count is " & GuestCount.ToString & ", there is not a bar stool selected")
                Else
                    d.SeatStoolToTable(TABLETOSEAT, TableNumber, GuestCount, Active.Guest)
                    OKToLoadTable = True
                    'MsgBox("table is available, guest count is " & GuestCount.ToString & ", there is a bar stool selected")
                End If
            End If
        ElseIf Table.OwnedByServer(Active.Server) Then
            OKToLoadTable = True
        ElseIf Table.isClaimable Then

            If MsgBox("Are you sure you want to claim this table?", vbYesNo, "Confirmation") = MsgBoxResult.Yes Then
                d.ClaimTable(TableNumber, Active.Guest)
            End If

        ElseIf Not Table.OwnedByServer(Active.Server) Then

            If MsgBox("This is not your table, are you sure you want to open it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                OKToLoadTable = True
            End If

        Else

            MsgBox("table is not available")

        End If



        If OKToLoadTable = True Then
            Ticket = Ticket.getTicketInfoByTableNumber(TableNumber)
            Active.Clear()
            Active.Ticket = Ticket.GetTicketNumber
            Active.Table = TableNumber
            Close()
        End If




    End Sub
    'GTG
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Close()
    End Sub
    'GTG
    Private Sub tbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl10.Click, tbl11.Click, tbl12.Click, tbl13.Click, tbl01.Click, tbl02.Click, tbl03.Click, tbl09.Click, tbl08.Click, tbl05.Click, tbl04.Click, tbl06.Click, tbl07.Click
        TableCheck(Mid(sender.name, 4, 2))
    End Sub
    'GTG
    Private Sub sto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Active.Computer = "BAR" And Saved.BarSeat = False Then
            StoolCheck(Mid(sender.name, 4, 2))
        End If

        If Active.Computer = "SERVER" Or Saved.BarSeat = True Then
            If data.GetData("SELECT AVAILABLE FROM OPEN_STOOLINFO WHERE STOOL_NUM = " & Mid(sender.name, 4, 2)).Tables(0).Rows(0).Item(0) = False Then
                TABLETOSEAT = (Mid(sender.Name, 4, 2))
                Saved.GO(0) = True
            Else
                TABLETOSEAT = 0
                Saved.GO(0) = False
            End If

            If Saved.GO(0) = True Then
                SelectTable_Load(sender, e)
            End If
        End If

    End Sub

    Private Sub SelectTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Active.Computer = "SERVER" Then
            ChangeServer()
        End If

        LoadTables()
        dgvCustomTables.ClearSelection()

    End Sub
    'GTG

    Private Sub cmdOtherTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOtherTable.Click

        TableCheck(data.GetNextNum("TABLE_NUM"))

    End Sub

    Private Sub dgvCustomTables_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomTables.CellContentClick

        If lstOldValue = dgvCustomTables.SelectedRows(0).Cells(0).Value Then
            TableCheck(dgvCustomTables.SelectedRows(0).Cells(0).Value)
        End If

        lstOldValue = dgvCustomTables.SelectedRows(0).Cells(0).Value

    End Sub

    Private Sub ChangeServer()
        Dim newServer As New ChangeServer
        active.Server = newServer.getServer.GetNumber
    End Sub

    Private Sub LoadTables()
        For Each DataRow As DataRow In data.GetData("SELECT * From OPEN_TABLEINFO WHERE TABLE_NUM < 25 AND TABLE_NUM <> -99").Tables(0).Rows
            If DataRow("AVAILABLE") = True Then
                isAVAILABLE(DataRow("TABLE_NUM")) = True
            Else
                isAVAILABLE(DataRow("TABLE_NUM")) = False
                GUESTCOUNT(DataRow("TABLE_NUM")) = DataRow("GUEST_COUNT")

                If DataRow("EMP_NUM") = Active.Server Or DataRow("EMP_NUM2") = Active.Server Then
                    isOWN(DataRow("TABLE_NUM")) = True
                Else
                    isOWN(DataRow("TABLE_NUM")) = False
                End If
                If DataRow("EMP_NUM") = -5 Then
                    UNCLAIMED(DataRow("TABLE_NUM")) = True
                    CLAIM = True
                Else
                    UNCLAIMED(DataRow("TABLE_NUM")) = False
                End If
            End If
            TABLENAME(DataRow("TABLE_NUM")) = DataRow("TABLE_NAME")
        Next

        'Custom Tables
        dgvCustomTables.DataSource = data.GetData("SELECT * From OPEN_TABLEINFO WHERE TABLE_NUM > 24 AND TABLE_NUM <> -99").Tables(0)
        dgvCustomTables.Columns("TABLE_NUM").Visible = False
        dgvCustomTables.Columns("TABLE_NAME").Width = 600
        dgvCustomTables.Columns("GUEST_COUNT").Width = 30

        'Stools
        For Each DataRow As DataRow In data.GetData("SELECT * From OPEN_STOOLINFO").Tables(0).Rows
            If DataRow("AVAILABLE") = True Then
                BARisAVAILABLE(DataRow("STOOL_NUM")) = True
            Else
                BARisAVAILABLE(DataRow("STOOL_NUM")) = False
            End If
        Next

        Dim cControl As Control
        For Each cControl In Me.Controls
            If (TypeOf cControl Is Button) Then
                If Mid(cControl.Name, 1, 3) = "tbl" Then
                    If isAVAILABLE(Mid(cControl.Name, 4, 2)) = True Then
                        cControl.BackColor = Color.LightGray
                        cControl.Text = TABLENAME(Mid(cControl.Name, 4, 2))
                    Else
                        If isOWN(Mid(cControl.Name, 4, 2)) = True Then
                            cControl.BackColor = Color.DarkGreen
                            cControl.Text = TABLENAME(Mid(cControl.Name, 4, 2)) & Chr(13) & Chr(10) & "GC:" & GUESTCOUNT(Mid(cControl.Name, 4, 2))
                        ElseIf UNCLAIMED(Mid(cControl.Name, 4, 2)) = True Then
                            cControl.BackColor = Color.DarkBlue
                            cControl.Text = TABLENAME(Mid(cControl.Name, 4, 2)) & Chr(13) & Chr(10) & "GC:" & GUESTCOUNT(Mid(cControl.Name, 4, 2))
                        Else
                            cControl.BackColor = Color.DarkRed
                            cControl.Text = TABLENAME(Mid(cControl.Name, 4, 2)) & Chr(13) & Chr(10) & "GC:" & GUESTCOUNT(Mid(cControl.Name, 4, 2))
                        End If
                    End If
                End If

                If Mid(cControl.Name, 1, 3) = "sto" Then
                    If BARisAVAILABLE(Mid(cControl.Name, 4, 2)) = True Then
                        cControl.BackColor = Color.LightGray
                    Else
                        If Active.Computer = "SERVER" Or Saved.BarSeat = True Then
                            cControl.BackColor = Color.DarkGray
                        End If
                        If Active.Computer = "BAR" And Saved.BarSeat = False Then
                            cControl.BackColor = Color.DarkGreen
                        End If
                    End If
                    If (Mid(cControl.Name, 4, 2)) = TABLETOSEAT Then
                        cControl.BackColor = Color.DarkBlue
                    End If
                End If
            End If
        Next cControl
    End Sub

    Private Sub cmdChangeServer_Click(sender As System.Object, e As System.EventArgs) Handles cmdChangeServer.Click
        ChangeServer()
        LoadTables()
        dgvCustomTables.ClearSelection()
    End Sub
End Class
