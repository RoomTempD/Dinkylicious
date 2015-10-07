Public Class EndOfDay
    Inherits System.Windows.Forms.Form
    Dim tmpAmount As Double
    Dim Pennies As Double
    Dim Nickles As Double
    Dim Dimes As Double
    Dim Quarters As Double
    Dim Halves As Double
    Dim Ones As Double
    Dim Twos As Double
    Dim Fives As Double
    Dim Tens As Double
    Dim Twenties As Double
    Dim Fifties As Double
    Dim Hundreds As Double
    Dim TotalSales As Double
    Dim Tax As Double
    Dim SubTotal As Double
    Dim Tables As Integer
    Dim People As Integer
    Dim Cash As Double
    Dim Check As Double
    Dim Card As Double
    Dim GiftCert As Double
    Dim FoodTotal As Double
    Dim BarTotal As Double
    Dim OffBy As Double


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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSales As System.Windows.Forms.TextBox
    Friend WithEvents txtCards As System.Windows.Forms.TextBox
    Friend WithEvents txtChecks As System.Windows.Forms.TextBox
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtOffBy As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtBarSales As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtFoodSales As System.Windows.Forms.TextBox
    Friend WithEvents txtPEN As System.Windows.Forms.TextBox
    Friend WithEvents txtHAV As System.Windows.Forms.TextBox
    Friend WithEvents txtQRT As System.Windows.Forms.TextBox
    Friend WithEvents txtDIM As System.Windows.Forms.TextBox
    Friend WithEvents txtNIC As System.Windows.Forms.TextBox
    Friend WithEvents txtTWO As System.Windows.Forms.TextBox
    Friend WithEvents txtFIV As System.Windows.Forms.TextBox
    Friend WithEvents txtTEN As System.Windows.Forms.TextBox
    Friend WithEvents txtTWN As System.Windows.Forms.TextBox
    Friend WithEvents txtONE As System.Windows.Forms.TextBox
    Friend WithEvents txtFIF As System.Windows.Forms.TextBox
    Friend WithEvents txtHUN As System.Windows.Forms.TextBox
    Friend WithEvents txtFIFVAL As System.Windows.Forms.TextBox
    Friend WithEvents txtHUNVAL As System.Windows.Forms.TextBox
    Friend WithEvents txtTWOVAL As System.Windows.Forms.TextBox
    Friend WithEvents txtFIVVAL As System.Windows.Forms.TextBox
    Friend WithEvents txtTENVAL As System.Windows.Forms.TextBox
    Friend WithEvents txtTWNVAL As System.Windows.Forms.TextBox
    Friend WithEvents txtONEVAL As System.Windows.Forms.TextBox
    Friend WithEvents txtNICVAL As System.Windows.Forms.TextBox
    Friend WithEvents txtDIMVAL As System.Windows.Forms.TextBox
    Friend WithEvents txtQRTVAL As System.Windows.Forms.TextBox
    Friend WithEvents txtHAVVAL As System.Windows.Forms.TextBox
    Friend WithEvents txtPENVAL As System.Windows.Forms.TextBox
    Friend WithEvents cmdCloseday As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtGC As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtPEN = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtHAV = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtQRT = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDIM = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNIC = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTWO = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFIV = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTEN = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTWN = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtONE = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtFIF = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtHUN = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTotalSales = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCards = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtChecks = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtCash = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtOffBy = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtBarSales = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtFoodSales = New System.Windows.Forms.TextBox
        Me.txtFIFVAL = New System.Windows.Forms.TextBox
        Me.txtHUNVAL = New System.Windows.Forms.TextBox
        Me.txtTWOVAL = New System.Windows.Forms.TextBox
        Me.txtFIVVAL = New System.Windows.Forms.TextBox
        Me.txtTENVAL = New System.Windows.Forms.TextBox
        Me.txtTWNVAL = New System.Windows.Forms.TextBox
        Me.txtONEVAL = New System.Windows.Forms.TextBox
        Me.txtNICVAL = New System.Windows.Forms.TextBox
        Me.txtDIMVAL = New System.Windows.Forms.TextBox
        Me.txtQRTVAL = New System.Windows.Forms.TextBox
        Me.txtHAVVAL = New System.Windows.Forms.TextBox
        Me.txtPENVAL = New System.Windows.Forms.TextBox
        Me.cmdCloseday = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.txtGC = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtPEN
        '
        Me.txtPEN.Location = New System.Drawing.Point(96, 16)
        Me.txtPEN.Name = "txtPEN"
        Me.txtPEN.Size = New System.Drawing.Size(72, 20)
        Me.txtPEN.TabIndex = 0
        Me.txtPEN.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pennies:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Halves:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHAV
        '
        Me.txtHAV.Location = New System.Drawing.Point(96, 132)
        Me.txtHAV.Name = "txtHAV"
        Me.txtHAV.Size = New System.Drawing.Size(72, 20)
        Me.txtHAV.TabIndex = 2
        Me.txtHAV.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quarters:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQRT
        '
        Me.txtQRT.Location = New System.Drawing.Point(96, 103)
        Me.txtQRT.Name = "txtQRT"
        Me.txtQRT.Size = New System.Drawing.Size(72, 20)
        Me.txtQRT.TabIndex = 4
        Me.txtQRT.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dimes:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDIM
        '
        Me.txtDIM.Location = New System.Drawing.Point(96, 74)
        Me.txtDIM.Name = "txtDIM"
        Me.txtDIM.Size = New System.Drawing.Size(72, 20)
        Me.txtDIM.TabIndex = 6
        Me.txtDIM.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nickles:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNIC
        '
        Me.txtNIC.Location = New System.Drawing.Point(96, 45)
        Me.txtNIC.Name = "txtNIC"
        Me.txtNIC.Size = New System.Drawing.Size(72, 20)
        Me.txtNIC.TabIndex = 8
        Me.txtNIC.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Twos:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTWO
        '
        Me.txtTWO.Location = New System.Drawing.Point(96, 205)
        Me.txtTWO.Name = "txtTWO"
        Me.txtTWO.Size = New System.Drawing.Size(72, 20)
        Me.txtTWO.TabIndex = 18
        Me.txtTWO.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Fives:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFIV
        '
        Me.txtFIV.Location = New System.Drawing.Point(96, 234)
        Me.txtFIV.Name = "txtFIV"
        Me.txtFIV.Size = New System.Drawing.Size(72, 20)
        Me.txtFIV.TabIndex = 16
        Me.txtFIV.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 24)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tens:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTEN
        '
        Me.txtTEN.Location = New System.Drawing.Point(96, 263)
        Me.txtTEN.Name = "txtTEN"
        Me.txtTEN.Size = New System.Drawing.Size(72, 20)
        Me.txtTEN.TabIndex = 14
        Me.txtTEN.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Twenties:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTWN
        '
        Me.txtTWN.Location = New System.Drawing.Point(96, 292)
        Me.txtTWN.Name = "txtTWN"
        Me.txtTWN.Size = New System.Drawing.Size(72, 20)
        Me.txtTWN.TabIndex = 12
        Me.txtTWN.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 24)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Ones:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtONE
        '
        Me.txtONE.Location = New System.Drawing.Point(96, 176)
        Me.txtONE.Name = "txtONE"
        Me.txtONE.Size = New System.Drawing.Size(72, 20)
        Me.txtONE.TabIndex = 10
        Me.txtONE.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 319)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 24)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Fifties:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFIF
        '
        Me.txtFIF.Location = New System.Drawing.Point(96, 321)
        Me.txtFIF.Name = "txtFIF"
        Me.txtFIF.Size = New System.Drawing.Size(72, 20)
        Me.txtFIF.TabIndex = 22
        Me.txtFIF.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 348)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 24)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Hunderds:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHUN
        '
        Me.txtHUN.Location = New System.Drawing.Point(96, 350)
        Me.txtHUN.Name = "txtHUN"
        Me.txtHUN.Size = New System.Drawing.Size(72, 20)
        Me.txtHUN.TabIndex = 20
        Me.txtHUN.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(256, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 24)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Total Sales:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalSales
        '
        Me.txtTotalSales.Location = New System.Drawing.Point(360, 96)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalSales.TabIndex = 24
        Me.txtTotalSales.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(272, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 24)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Cards:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCards
        '
        Me.txtCards.Location = New System.Drawing.Point(360, 152)
        Me.txtCards.Name = "txtCards"
        Me.txtCards.Size = New System.Drawing.Size(96, 20)
        Me.txtCards.TabIndex = 26
        Me.txtCards.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(272, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 24)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Checks:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtChecks
        '
        Me.txtChecks.Location = New System.Drawing.Point(360, 176)
        Me.txtChecks.Name = "txtChecks"
        Me.txtChecks.Size = New System.Drawing.Size(96, 20)
        Me.txtChecks.TabIndex = 28
        Me.txtChecks.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(272, 208)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 24)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Cash:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(360, 208)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(96, 20)
        Me.txtCash.TabIndex = 30
        Me.txtCash.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(272, 288)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 24)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Off By:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOffBy
        '
        Me.txtOffBy.Location = New System.Drawing.Point(360, 288)
        Me.txtOffBy.Name = "txtOffBy"
        Me.txtOffBy.Size = New System.Drawing.Size(96, 20)
        Me.txtOffBy.TabIndex = 32
        Me.txtOffBy.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(256, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 24)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Bar Sales:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBarSales
        '
        Me.txtBarSales.Location = New System.Drawing.Point(360, 64)
        Me.txtBarSales.Name = "txtBarSales"
        Me.txtBarSales.Size = New System.Drawing.Size(96, 20)
        Me.txtBarSales.TabIndex = 34
        Me.txtBarSales.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(256, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 24)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Food Sales:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFoodSales
        '
        Me.txtFoodSales.Location = New System.Drawing.Point(360, 32)
        Me.txtFoodSales.Name = "txtFoodSales"
        Me.txtFoodSales.Size = New System.Drawing.Size(96, 20)
        Me.txtFoodSales.TabIndex = 36
        Me.txtFoodSales.Text = ""
        '
        'txtFIFVAL
        '
        Me.txtFIFVAL.Location = New System.Drawing.Point(168, 321)
        Me.txtFIFVAL.Name = "txtFIFVAL"
        Me.txtFIFVAL.Size = New System.Drawing.Size(72, 20)
        Me.txtFIFVAL.TabIndex = 49
        Me.txtFIFVAL.Text = ""
        '
        'txtHUNVAL
        '
        Me.txtHUNVAL.Location = New System.Drawing.Point(168, 350)
        Me.txtHUNVAL.Name = "txtHUNVAL"
        Me.txtHUNVAL.Size = New System.Drawing.Size(72, 20)
        Me.txtHUNVAL.TabIndex = 48
        Me.txtHUNVAL.Text = ""
        '
        'txtTWOVAL
        '
        Me.txtTWOVAL.Location = New System.Drawing.Point(168, 205)
        Me.txtTWOVAL.Name = "txtTWOVAL"
        Me.txtTWOVAL.Size = New System.Drawing.Size(72, 20)
        Me.txtTWOVAL.TabIndex = 47
        Me.txtTWOVAL.Text = ""
        '
        'txtFIVVAL
        '
        Me.txtFIVVAL.Location = New System.Drawing.Point(168, 234)
        Me.txtFIVVAL.Name = "txtFIVVAL"
        Me.txtFIVVAL.Size = New System.Drawing.Size(72, 20)
        Me.txtFIVVAL.TabIndex = 46
        Me.txtFIVVAL.Text = ""
        '
        'txtTENVAL
        '
        Me.txtTENVAL.Location = New System.Drawing.Point(168, 263)
        Me.txtTENVAL.Name = "txtTENVAL"
        Me.txtTENVAL.Size = New System.Drawing.Size(72, 20)
        Me.txtTENVAL.TabIndex = 45
        Me.txtTENVAL.Text = ""
        '
        'txtTWNVAL
        '
        Me.txtTWNVAL.Location = New System.Drawing.Point(168, 292)
        Me.txtTWNVAL.Name = "txtTWNVAL"
        Me.txtTWNVAL.Size = New System.Drawing.Size(72, 20)
        Me.txtTWNVAL.TabIndex = 44
        Me.txtTWNVAL.Text = ""
        '
        'txtONEVAL
        '
        Me.txtONEVAL.Location = New System.Drawing.Point(168, 176)
        Me.txtONEVAL.Name = "txtONEVAL"
        Me.txtONEVAL.Size = New System.Drawing.Size(72, 20)
        Me.txtONEVAL.TabIndex = 43
        Me.txtONEVAL.Text = ""
        '
        'txtNICVAL
        '
        Me.txtNICVAL.Location = New System.Drawing.Point(168, 45)
        Me.txtNICVAL.Name = "txtNICVAL"
        Me.txtNICVAL.Size = New System.Drawing.Size(72, 20)
        Me.txtNICVAL.TabIndex = 42
        Me.txtNICVAL.Text = ""
        '
        'txtDIMVAL
        '
        Me.txtDIMVAL.Location = New System.Drawing.Point(168, 74)
        Me.txtDIMVAL.Name = "txtDIMVAL"
        Me.txtDIMVAL.Size = New System.Drawing.Size(72, 20)
        Me.txtDIMVAL.TabIndex = 41
        Me.txtDIMVAL.Text = ""
        '
        'txtQRTVAL
        '
        Me.txtQRTVAL.Location = New System.Drawing.Point(168, 103)
        Me.txtQRTVAL.Name = "txtQRTVAL"
        Me.txtQRTVAL.Size = New System.Drawing.Size(72, 20)
        Me.txtQRTVAL.TabIndex = 40
        Me.txtQRTVAL.Text = ""
        '
        'txtHAVVAL
        '
        Me.txtHAVVAL.Location = New System.Drawing.Point(168, 132)
        Me.txtHAVVAL.Name = "txtHAVVAL"
        Me.txtHAVVAL.Size = New System.Drawing.Size(72, 20)
        Me.txtHAVVAL.TabIndex = 39
        Me.txtHAVVAL.Text = ""
        '
        'txtPENVAL
        '
        Me.txtPENVAL.Location = New System.Drawing.Point(168, 16)
        Me.txtPENVAL.Name = "txtPENVAL"
        Me.txtPENVAL.Size = New System.Drawing.Size(72, 20)
        Me.txtPENVAL.TabIndex = 38
        Me.txtPENVAL.Text = ""
        '
        'cmdCloseday
        '
        Me.cmdCloseday.Location = New System.Drawing.Point(376, 320)
        Me.cmdCloseday.Name = "cmdCloseday"
        Me.cmdCloseday.Size = New System.Drawing.Size(80, 40)
        Me.cmdCloseday.TabIndex = 50
        Me.cmdCloseday.Text = "Close Day"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(280, 320)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 40)
        Me.cmdCancel.TabIndex = 51
        Me.cmdCancel.Text = "Cancel"
        '
        'txtGC
        '
        Me.txtGC.Location = New System.Drawing.Point(360, 240)
        Me.txtGC.Name = "txtGC"
        Me.txtGC.Size = New System.Drawing.Size(96, 20)
        Me.txtGC.TabIndex = 52
        Me.txtGC.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(272, 240)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 24)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "GC:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EndOfDay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 382)
        Me.Controls.Add(Me.txtGC)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdCloseday)
        Me.Controls.Add(Me.txtFIFVAL)
        Me.Controls.Add(Me.txtHUNVAL)
        Me.Controls.Add(Me.txtTWOVAL)
        Me.Controls.Add(Me.txtFIVVAL)
        Me.Controls.Add(Me.txtTENVAL)
        Me.Controls.Add(Me.txtTWNVAL)
        Me.Controls.Add(Me.txtONEVAL)
        Me.Controls.Add(Me.txtNICVAL)
        Me.Controls.Add(Me.txtDIMVAL)
        Me.Controls.Add(Me.txtQRTVAL)
        Me.Controls.Add(Me.txtHAVVAL)
        Me.Controls.Add(Me.txtPENVAL)
        Me.Controls.Add(Me.txtFoodSales)
        Me.Controls.Add(Me.txtBarSales)
        Me.Controls.Add(Me.txtOffBy)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.txtChecks)
        Me.Controls.Add(Me.txtCards)
        Me.Controls.Add(Me.txtTotalSales)
        Me.Controls.Add(Me.txtFIF)
        Me.Controls.Add(Me.txtHUN)
        Me.Controls.Add(Me.txtTWO)
        Me.Controls.Add(Me.txtFIV)
        Me.Controls.Add(Me.txtTEN)
        Me.Controls.Add(Me.txtTWN)
        Me.Controls.Add(Me.txtONE)
        Me.Controls.Add(Me.txtNIC)
        Me.Controls.Add(Me.txtDIM)
        Me.Controls.Add(Me.txtQRT)
        Me.Controls.Add(Me.txtHAV)
        Me.Controls.Add(Me.txtPEN)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EndOfDay"
        Me.Text = "EndOfDay"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub EndOfDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Saved.Database_Connect()
        Saved.ClosedTableInfo_Open()
        Saved.ClosedStoolInfo_Open()
        Saved.ClosedTicket_Open()

        Saved.ClosedTableInfoRST.MoveFirst()
        Do Until Saved.ClosedTableInfoRST.EOF
            If Format(Saved.ClosedTableInfoDateOut.Value, "Short Date") = Format(Now(), "Short Date") Then
                People = People + Saved.ClosedTableInfoGuestCount.Value
                Tables = Tables + 1
            End If
            Saved.ClosedTableInfoRST.MoveNext()
        Loop
        'Saved.Daily_Sales_Table_Open()

        'Form_Saved.DailySalesRST.MoveLast()
        'BegAmount = Form_Saved.DailySalesEnding


        'Form_Saved.DailySalesRST.FindFirst("[DATE] = " & Format(Now(), "Short Date"))
        'If Form_Saved.DailySalesRST.NoMatch = True Then

        Saved.ClosedTicketRST.MoveFirst()
        Do Until Saved.ClosedTicketRST.EOF

            If Format(Saved.ClosedTicketDateOut.Value, "Short Date") = Format(Now(), "Short Date") Then
                TotalSales = TotalSales + Saved.ClosedTicketTotal.Value
                BarTotal = BarTotal + Saved.ClosedTicketBarTotal.Value
                FoodTotal = FoodTotal + Saved.ClosedTicketFoodTotal.Value
                Card = Card + Saved.ClosedTicketCard.Value
                Check = Check + Saved.ClosedTicketCheck.Value
                GiftCert = GiftCert + Saved.ClosedTicketGiftCert.Value
            End If
            Saved.ClosedTicketRST.MoveNext()
        Loop

        txtFoodSales.Text = Format(FoodTotal, "Currency")
        txtBarSales.Text = Format(BarTotal, "Currency")
        txtTotalSales.Text = Format(TotalSales, "Currency")
        txtCards.Text = Format(Card, "Currency")
        txtChecks.Text = Format(Check, "Currency")
        txtGC.Text = Format(GiftCert, "Currency")
        'End If


        Saved.ClosedTableInfo_Close()
        Saved.ClosedStoolInfo_Close()
        Saved.ClosedTicket_Close()
        'Saved.Database_Disconnect()
        MsgBox("Total People:" & People & Chr(13) & Chr(10) & _
            "Total Tables:" & Tables)

    End Sub

    Private Sub Pressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPEN.Click, txtNIC.Click, txtDIM.Click, txtQRT.Click, txtHAV.Click, txtONE.Click, txtTWO.Click, txtFIV.Click, txtTEN.Click, txtTWN.Click, txtFIF.Click, txtHUN.Click
        'lblHide.Visible = True
        Dim formNumPad As New NumPad
        Saved.GO(2) = False
        formNumPad.ShowDialog()
        If Saved.GO(2) = True Then
            If Mid(sender.name, 4, 3) = "PEN" Then
                txtPEN.Text = Saved.TEMPMONEY
                Pennies = Saved.TEMPMONEY * 0.01
                txtPENVAL.Text = Format(Pennies, "Currency")
            End If
            If Mid(sender.name, 4, 3) = "NIC" Then
                txtNIC.Text = Saved.TEMPMONEY
                Nickles = Saved.TEMPMONEY * 0.05
                txtNICVAL.Text = Format(Nickles, "Currency")
            End If
            If Mid(sender.name, 4, 3) = "DIM" Then
                txtDIM.Text = Saved.TEMPMONEY
                Dimes = Saved.TEMPMONEY * 0.1
                txtDIMVAL.Text = Format(Dimes, "Currency")
            End If
            If Mid(sender.name, 4, 3) = "QRT" Then
                txtQRT.Text = Saved.TEMPMONEY
                Quarters = Saved.TEMPMONEY * 0.25
                txtQRTVAL.Text = Format(Quarters, "Currency")
            End If
            If Mid(sender.name, 4, 3) = "HAV" Then
                txtHAV.Text = Saved.TEMPMONEY
                Halves = Saved.TEMPMONEY * 0.5
                txtHAVVAL.Text = Format(Halves, "Currency")
            End If
            If Mid(sender.name, 4, 3) = "ONE" Then
                txtONE.Text = Saved.TEMPMONEY
                Ones = Saved.TEMPMONEY * 1
                txtONEVAL.Text = Format(Ones, "Currency")
            End If
            If Mid(sender.name, 4, 3) = "TWO" Then
                txtTWO.Text = Saved.TEMPMONEY
                Twos = Saved.TEMPMONEY * 2
                txtTWOVAL.Text = Format(Twos, "Currency")
            End If
            If Mid(sender.name, 4, 3) = "FIV" Then
                txtFIV.Text = Saved.TEMPMONEY
                Fives = Saved.TEMPMONEY * 5
                txtFIVVAL.Text = Format(Fives, "Currency")
            End If
            If Mid(sender.name, 4, 3) = "TEN" Then
                txtTEN.Text = Saved.TEMPMONEY
                Tens = Saved.TEMPMONEY * 10
                txtTENVAL.Text = Format(Tens, "Currency")
            End If
            If Mid(sender.name, 4, 3) = "TWN" Then
                txtTWN.Text = Saved.TEMPMONEY
                Twenties = Saved.TEMPMONEY * 20
                txtTWNVAL.Text = Format(Twenties, "Currency")
            End If
            If Mid(sender.name, 4, 3) = "FIF" Then
                txtFIF.Text = Saved.TEMPMONEY
                Fifties = Saved.TEMPMONEY * 50
                txtFIFVAL.Text = Format(Fifties, "Currency")
            End If
            If Mid(sender.name, 4, 3) = "HUN" Then
                txtHUN.Text = Saved.TEMPMONEY
                Hundreds = Saved.TEMPMONEY * 100
                txtHUNVAL.Text = Format(Hundreds, "Currency")
            End If
            UpdateTotal()
        End If
        'lblHide.Visible = False
    End Sub

    Private Sub UpdateTotal()
        Cash = Pennies + Nickles + Dimes + Quarters + Halves + Ones + Twos + Fives + Tens + Twenties + Fifties + Hundreds
        txtCash.Text = Format(Cash, "Currency")
        OffBy = (Cash + Check + Card) - TotalSales
        txtOffBy.Text = Format(OffBy, "Currency")
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub cmdCloseday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseday.Click

    End Sub
End Class
