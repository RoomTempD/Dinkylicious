Public Class Totals
    Inherits System.Windows.Forms.Form
    Dim CURR_DATE As Date
    Dim START_DATE As Date
    Dim END_DATE As Date
    Dim HoursForDay As Date
    Dim CurEmpTotalHours As TimeSpan
    Dim CurEmpTotalSales As Double
    Dim lstEmpNums(0) As Integer
    Dim lstEmpNumsLength As Integer = 0

    Dim Cash As Double
    Dim Check As Double
    Dim Card As Double
    Dim GiftCert As Double
    Dim FoodTotal As Double
    Dim BarTotal As Double
    Dim TotalSales As Double

    Dim GrandCash As Double
    Dim GrandCheck As Double
    Dim GrandCard As Double
    Dim GrandGiftCert As Double
    Dim GrandFoodTotal As Double
    Dim GrandBarTotal As Double
    Dim GrandTotalSales As Double

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
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdGo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(488, 56)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.TabIndex = 11
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(200, 56)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(536, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(256, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "From:"
        '
        'cmdGo
        '
        Me.cmdGo.Location = New System.Drawing.Point(424, 160)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.TabIndex = 7
        Me.cmdGo.Text = "Go"
        '
        'Totals
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(928, 498)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdGo)
        Me.Name = "Totals"
        Me.Text = "Totals"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click

        START_DATE = dtpFrom.Value
        END_DATE = dtpTo.Value

        Saved.Database_Connect()
        Saved.ClosedTableInfo_Open()
        Saved.ClosedStoolInfo_Open()
        Saved.ClosedTicket_Open()

        Dim intFileNo As Integer = FreeFile()
        FileOpen(1, "print.txt", OpenMode.Output)

        PrintLine(1, "Totals for " & Format(START_DATE, "Short Date") & " through " & Format(END_DATE, "Short Date"))
        PrintLine(1, "")

        CURR_DATE = START_DATE
        Do Until CURR_DATE > END_DATE
            TotalSales = 0
            BarTotal = 0
            FoodTotal = 0
            Card = 0
            Check = 0
            GiftCert = 0

            Saved.ClosedTicketRST.MoveFirst()
            Do Until Saved.ClosedTicketRST.EOF

                If Format(Saved.ClosedTicketDateOut.Value, "Short Date") = Format(CURR_DATE, "Short Date") Then
                    TotalSales = TotalSales + Saved.ClosedTicketTotal.Value
                    BarTotal = BarTotal + Saved.ClosedTicketBarTotal.Value
                    FoodTotal = FoodTotal + Saved.ClosedTicketFoodTotal.Value
                    Card = Card + Saved.ClosedTicketCard.Value
                    Check = Check + Saved.ClosedTicketCheck.Value
                    GiftCert = GiftCert + Saved.ClosedTicketGiftCert.Value

                    GrandTotalSales = GrandTotalSales + Saved.ClosedTicketTotal.Value
                    GrandBarTotal = GrandBarTotal + Saved.ClosedTicketBarTotal.Value
                    GrandFoodTotal = GrandFoodTotal + Saved.ClosedTicketFoodTotal.Value
                    GrandCard = GrandCard + Saved.ClosedTicketCard.Value
                    GrandCheck = GrandCheck + Saved.ClosedTicketCheck.Value
                    GrandGiftCert = GrandGiftCert + Saved.ClosedTicketGiftCert.Value

                End If
                Saved.ClosedTicketRST.MoveNext()
            Loop

            PrintLine(1, Format(CURR_DATE, "Short Date") & " - " & CURR_DATE.DayOfWeek.ToString())
            PrintLine(1, "   Total Sales: " & Format(TotalSales, "currency"))
            PrintLine(1, "     Bar Total: " & Format(BarTotal, "currency"))
            PrintLine(1, "    Food Total: " & Format(FoodTotal, "currency"))
            PrintLine(1, "          Card: " & Format(Card, "currency"))
            PrintLine(1, "         Check: " & Format(Check, "currency"))
            PrintLine(1, "     Gift Cert: " & Format(GiftCert, "currency"))
            PrintLine(1, "")

            CURR_DATE = CURR_DATE.AddDays(1)
        Loop

        PrintLine(1, "Grand Totals")
        PrintLine(1, "   Total Sales: " & Format(GrandTotalSales, "currency"))
        PrintLine(1, "     Bar Total: " & Format(GrandBarTotal, "currency"))
        PrintLine(1, "    Food Total: " & Format(GrandFoodTotal, "currency"))
        PrintLine(1, "          Card: " & Format(GrandCard, "currency"))
        PrintLine(1, "         Check: " & Format(GrandCheck, "currency"))
        PrintLine(1, "     Gift Cert: " & Format(GrandGiftCert, "currency"))



        FileClose(1)
        Shell("print /d:\\fireside-bar\star print.txt", AppWinStyle.Hide)




        Saved.ClosedTableInfo_Close()
        Saved.ClosedStoolInfo_Close()
        Saved.ClosedTicket_Close()
        Saved.Database_Disconnect()


       
    End Sub

    Private Sub Totals_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
