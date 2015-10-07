Option Explicit On 

Module Saved
    Dim dbE As DAO.DBEngine
    Public db As DAO.Database
    Dim rs As DAO.Recordset
    Dim strCon As String
    Public GO(5) As Boolean
    Public EMPNUM As Integer = 0
    Public JOBNUM As Integer = 0
    Public CURSERVER As Integer = 0
    Public CURSERVER2 As Integer = 0
    Public CURSERVERNAME As String = ""
    Public CURGUESTCOUNT As Integer = 0
    Public CURCUSTOM As Double = 0
    Public CURGUEST As Integer = 0
    Public CURTABLE As Integer = 0
    Public CURSTOOL As Integer = 0
    Public CURORDER As Integer = 0
    Public CURTICKET As Integer = 0
    Public CURTABLENAME As String = ""
    Public CURRETABLE As Integer = 0
    Public CURRETRANS As Integer = 0
    Public GUESTTRANSFER As Boolean = False
    Public CURSPECIAL(6) As Integer
    Public SPECIALLINK(6) As Boolean
    Public ACTIVEORDER As String ' BAR or TABLE
    Public ORDERTYPE As String ' BAR or TABLE
    Public LOGON As String ' SERVER or BAR
    Public TABLEFOR As String
    Public STATUS As String 'OPEN or CLOSED or QUICK
    Public TEMPMONEY As Double
    Public BarSeat As Boolean = False

    Public ClosedTableInfoRST As DAO.Recordset
    Public ClosedTableInfoTableNum As DAO.Field
    Public ClosedTableInfoTableName As DAO.Field
    Public ClosedTableInfoAvailable As DAO.Field
    Public ClosedTableInfoGuestCount As DAO.Field
    Public ClosedTableInfoEmpNum1 As DAO.Field
    Public ClosedTableInfoEmpNum2 As DAO.Field
    Public ClosedTableInfoDateOut As DAO.Field
    Public ClosedTableInfoTimeOut As DAO.Field
    Public ClosedTableInfoReTable As DAO.Field
    Public ClosedTableInfoReTrans As DAO.Field
    Public ClosedTableInfoStoolNum As DAO.Field

    Public ClosedStoolInfoRST As DAO.Recordset
    Public ClosedStoolInfoStoolNum As DAO.Field
    Public ClosedStoolInfoAvailable As DAO.Field
    Public ClosedStoolInfoDateOut As DAO.Field
    Public ClosedStoolInfoTimeOut As DAO.Field
    Public ClosedStoolInfoReTable As DAO.Field
    Public ClosedStoolInfoReTrans As DAO.Field

    Public ClosedOrderRST As DAO.Recordset
    Public ClosedOrderOrderNum As DAO.Field
    Public ClosedOrderLineNum As DAO.Field
    Public ClosedOrderItemNum As DAO.Field
    Public ClosedOrderQuotedPrice As DAO.Field
    Public ClosedOrderReTable As DAO.Field
    Public ClosedOrderReTrans As DAO.Field

    Public ClosedTicketRST As DAO.Recordset
    Public ClosedTicketTicketNum As DAO.Field
    Public ClosedTicketGuestNum As DAO.Field
    Public ClosedTicketOrderNum As DAO.Field
    Public ClosedTicketDateIn As DAO.Field
    Public ClosedTicketTimeIn As DAO.Field
    Public ClosedTicketTipAtBar As DAO.Field
    Public ClosedTicketTimeSat As DAO.Field
    Public ClosedTicketTippedOn As DAO.Field
    Public ClosedTicketTableNum As DAO.Field
    Public ClosedTicketStoolNum As DAO.Field
    Public ClosedTicketSubTotal As DAO.Field
    Public ClosedTicketTax As DAO.Field
    Public ClosedTicketBarTotal As DAO.Field
    Public ClosedTicketFoodTotal As DAO.Field
    Public ClosedTicketTotal As DAO.Field
    Public ClosedTicketPaid As DAO.Field
    Public ClosedTicketCheck As DAO.Field
    Public ClosedTicketCash As DAO.Field
    Public ClosedTicketCard As DAO.Field
    Public ClosedTicketGiftCert As DAO.Field
    Public ClosedTicketChange As DAO.Field
    Public ClosedTicketDateOut As DAO.Field
    Public ClosedTicketTimeOut As DAO.Field
    Public ClosedTicketReTable As DAO.Field
    Public ClosedTicketReTrans As DAO.Field
    Public ClosedTicketTip As DAO.Field

    Public ClosedBarOrderRST As DAO.Recordset
    Public ClosedBarOrderOrderNum As DAO.Field
    Public ClosedBarOrderLineNum As DAO.Field
    Public ClosedBarOrderItemNum As DAO.Field
    Public ClosedBarOrderQuotedPrice As DAO.Field
    Public ClosedBarOrderReTable As DAO.Field
    Public ClosedBarOrderReTrans As DAO.Field

    Public EmpJobRST As DAO.Recordset
    Public EmpJobEmpNum As DAO.Field
    Public EmpJobJobNum As DAO.Field

    Public EmpRST As DAO.Recordset
    Public EmpEmpNum As DAO.Field
    Public EmpEmpName As DAO.Field

    Public ItemRST As DAO.Recordset
    Public ItemItemNum As DAO.Field
    Public ItemItemName As DAO.Field
    Public ItemItemPrice As DAO.Field

    Public JobsRST As DAO.Recordset
    Public JobsJobNum As DAO.Field
    Public JobsJobTitle As DAO.Field

    Public OldTableInfoRST As DAO.Recordset
    Public OldTableInfoTableNum As DAO.Field
    Public OldTableInfoTableName As DAO.Field
    Public OldTableInfoAvailable As DAO.Field
    Public OldTableInfoGuestCount As DAO.Field
    Public OldTableInfoEmpNum1 As DAO.Field
    Public OldTableInfoEmpNum2 As DAO.Field
    Public OldTableInfoDateOut As DAO.Field
    Public OldTableInfoTimeOut As DAO.Field
    Public OldTableInfoReTable As DAO.Field
    Public OldTableInfoReTrans As DAO.Field
    Public OldTableInfoStoolNum As DAO.Field

    Public OldStoolInfoRST As DAO.Recordset
    Public OldStoolInfoStoolNum As DAO.Field
    Public OldStoolInfoAvailable As DAO.Field
    Public OldStoolInfoDateOut As DAO.Field
    Public OldStoolInfoTimeOut As DAO.Field
    Public OldStoolInfoReTable As DAO.Field
    Public OldStoolInfoReTrans As DAO.Field

    Public OldOrderRST As DAO.Recordset
    Public OldOrderOrderNum As DAO.Field
    Public OldOrderLineNum As DAO.Field
    Public OldOrderItemNum As DAO.Field
    Public OldOrderQuotedPrice As DAO.Field
    Public OldOrderReTable As DAO.Field
    Public OldOrderReTrans As DAO.Field

    Public OldTicketRST As DAO.Recordset
    Public OldTicketTicketNum As DAO.Field
    Public OldTicketGuestNum As DAO.Field
    Public OldTicketOrderNum As DAO.Field
    Public OldTicketDateIn As DAO.Field
    Public OldTicketTimeIn As DAO.Field
    Public OldTicketTipAtBar As DAO.Field
    Public OldTicketTimeSat As DAO.Field
    Public OldTicketTippedOn As DAO.Field
    Public OldTicketTableNum As DAO.Field
    Public OldTicketStoolNum As DAO.Field
    Public OldTicketSubTotal As DAO.Field
    Public OldTicketTax As DAO.Field
    Public OldTicketBarTotal As DAO.Field
    Public OldTicketFoodTotal As DAO.Field
    Public OldTicketTotal As DAO.Field
    Public OldTicketPaid As DAO.Field
    Public OldTicketCheck As DAO.Field
    Public OldTicketCash As DAO.Field
    Public OldTicketCard As DAO.Field
    Public OldTicketGiftCert As DAO.Field
    Public OldTicketChange As DAO.Field
    Public OldTicketDateOut As DAO.Field
    Public OldTicketTimeOut As DAO.Field
    Public OldTicketReTable As DAO.Field
    Public OldTicketReTrans As DAO.Field
    Public OldTicketTip As DAO.Field

    Public OldBarOrderRST As DAO.Recordset
    Public OldBarOrderOrderNum As DAO.Field
    Public OldBarOrderLineNum As DAO.Field
    Public OldBarOrderItemNum As DAO.Field
    Public OldBarOrderQuotedPrice As DAO.Field
    Public OldBarOrderReTable As DAO.Field
    Public OldBarOrderReTrans As DAO.Field

    Public SavedRST As DAO.Recordset
    Public SavedReTable As DAO.Field
    Public SavedReTrans As DAO.Field
    Public SavedTicketNum As DAO.Field
    Public SavedOrderNum As DAO.Field
    Public SavedLineNum As DAO.Field
    Public SavedTableNum As DAO.Field
    Public SavedCustomNum As DAO.Field
    Public SavedBarTicketNum As DAO.Field
    Public SavedMessageForBar As DAO.Field
    Public SavedBarLineNum As DAO.Field

    Public SIORST As DAO.Recordset
    Public SIOEmpNum As DAO.Field
    Public SIOSignInDate As DAO.Field
    Public SIOSignInTime As DAO.Field
    Public SIOSignOutDate As DAO.Field
    Public SIOSignOutTime As DAO.Field
    Public SIOJobNum As DAO.Field

    Public OpenTableInfoRST As DAO.Recordset
    Public OpenTableInfoTableNum As DAO.Field
    Public OpenTableInfoTableName As DAO.Field
    Public OpenTableInfoAvailable As DAO.Field
    Public OpenTableInfoGuestCount As DAO.Field
    Public OpenTableInfoEmpNum1 As DAO.Field
    Public OpenTableInfoEmpNum2 As DAO.Field
    Public OpenTableInfoDateOut As DAO.Field
    Public OpenTableInfoTimeOut As DAO.Field
    Public OpenTableInfoReTable As DAO.Field
    Public OpenTableInfoReTrans As DAO.Field
    Public OpenTableInfoStoolNum As DAO.Field
    Public OpenTableInfoTipAtBar As DAO.Field

    Public OpenStoolInfoRST As DAO.Recordset
    Public OpenStoolInfoStoolNum As DAO.Field
    Public OpenStoolInfoAvailable As DAO.Field
    Public OpenStoolInfoDateOut As DAO.Field
    Public OpenStoolInfoTimeOut As DAO.Field
    Public OpenStoolInfoReTable As DAO.Field
    Public OpenStoolInfoReTrans As DAO.Field
    Public OpenStoolInfoReference As DAO.Field

    Public OpenOrderRST As DAO.Recordset
    Public OpenOrderOrderNum As DAO.Field
    Public OpenOrderLineNum As DAO.Field
    Public OpenOrderItemNum As DAO.Field
    Public OpenOrderQuotedPrice As DAO.Field
    Public OpenOrderReTable As DAO.Field
    Public OpenOrderReTrans As DAO.Field

    Public OpenTicketRST As DAO.Recordset
    Public OpenTicketTicketNum As DAO.Field
    Public OpenTicketGuestNum As DAO.Field
    Public OpenTicketOrderNum As DAO.Field
    Public OpenTicketDateIn As DAO.Field
    Public OpenTicketTimeIn As DAO.Field
    Public OpenTicketTipAtBar As DAO.Field
    Public OpenTicketTimeSat As DAO.Field
    Public OpenTicketTippedOn As DAO.Field
    Public OpenTicketTableNum As DAO.Field
    Public OpenTicketStoolNum As DAO.Field
    Public OpenTicketSubTotal As DAO.Field
    Public OpenTicketTax As DAO.Field
    Public OpenTicketTotal As DAO.Field
    Public OpenTicketFoodTotal As DAO.Field
    Public OpenTicketBarTotal As DAO.Field
    Public OpenTicketReTable As DAO.Field
    Public OpenTicketReTrans As DAO.Field

    Public OpenBarOrderRST As DAO.Recordset
    Public OpenBarOrderOrderNum As DAO.Field
    Public OpenBarOrderLineNum As DAO.Field
    Public OpenBarOrderItemNum As DAO.Field
    Public OpenBarOrderQuotedPrice As DAO.Field
    Public OpenBarOrderReTable As DAO.Field
    Public OpenBarOrderReTrans As DAO.Field

    Public BarItemRST As DAO.Recordset
    Public BarItemItemNum As DAO.Field
    Public BarItemItemName As DAO.Field
    Public BarItemItemPrice As DAO.Field

    Public SpecialsRST As DAO.Recordset
    Public SpecialsItemNum As DAO.Field
    Public SpecialsItemName As DAO.Field
    Public SpecialsItemPrice As DAO.Field
    Public SpecialsSpecial2 As DAO.Field
    Public SpecialsSpecial3 As DAO.Field
    Public SpecialsSpecial4 As DAO.Field
    Public SpecialsSpecial5 As DAO.Field
    Public SpecialsSpecial6 As DAO.Field

    Public Sub Database_Connect()

        


        Dim FILE_NAME As String = "connection.txt"
        Dim TextLine As String

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
            Loop

        Else

            MsgBox("File Does Not Exist")


        End If
        dbE = New DAO.DBEngine
        strCon = TextLine
        db = dbE.OpenDatabase(strCon)
    End Sub

    Public Sub Database_Disconnect()
        db.Close()
    End Sub

    Public Sub ClosedTableInfo_Open()
        ClosedTableInfoRST = db.OpenRecordset("CLOSED_TABLEINFO", 2)
        ClosedTableInfoTableNum = ClosedTableInfoRST("TABLE_NUM")
        ClosedTableInfoTableName = ClosedTableInfoRST("TABLE_NAME")
        ClosedTableInfoGuestCount = ClosedTableInfoRST("GUEST_COUNT")
        ClosedTableInfoEmpNum1 = ClosedTableInfoRST("EMP_NUM")
        ClosedTableInfoEmpNum2 = ClosedTableInfoRST("EMP_NUM2")
        ClosedTableInfoDateOut = ClosedTableInfoRST("DATE_OUT")
        ClosedTableInfoTimeOut = ClosedTableInfoRST("TIME_OUT")
        ClosedTableInfoReTable = ClosedTableInfoRST("RETABLE")
        ClosedTableInfoReTrans = ClosedTableInfoRST("RETRANS")
        ClosedTableInfoStoolNum = ClosedTableInfoRST("STOOL_NUM")
    End Sub

    Public Sub ClosedTableInfo_Close()
        ClosedTableInfoRST.Close()
        ClosedTableInfoRST = Nothing
    End Sub

    Public Sub ClosedStoolInfo_Open()
        ClosedStoolInfoRST = db.OpenRecordset("CLOSED_STOOLINFO", 2)
        ClosedStoolInfoStoolNum = ClosedStoolInfoRST("STOOL_NUM")
        ClosedStoolInfoDateOut = ClosedStoolInfoRST("DATE_OUT")
        ClosedStoolInfoTimeOut = ClosedStoolInfoRST("TIME_OUT")
        ClosedStoolInfoReTable = ClosedStoolInfoRST("RETABLE")
        ClosedStoolInfoReTrans = ClosedStoolInfoRST("RETRANS")
    End Sub

    Public Sub ClosedStoolInfo_Close()
        ClosedStoolInfoRST.Close()
        ClosedStoolInfoRST = Nothing
    End Sub

    Public Sub ClosedOrder_Open()
        ClosedOrderRST = db.OpenRecordset("CLOSED_ORDER", 2)
        ClosedOrderOrderNum = ClosedOrderRST("ORDER_NUM")
        ClosedOrderLineNum = ClosedOrderRST("LINE_NUM")
        ClosedOrderItemNum = ClosedOrderRST("ITEM_NUM")
        ClosedOrderQuotedPrice = ClosedOrderRST("QUOTED_PRICE")
        ClosedOrderReTable = ClosedOrderRST("RETABLE")
        ClosedOrderReTrans = ClosedOrderRST("RETRANS")
    End Sub

    Public Sub ClosedOrder_Close()
        ClosedOrderRST.Close()
        ClosedOrderRST = Nothing
    End Sub

    Public Sub ClosedTicket_Open()
        ClosedTicketRST = db.OpenRecordset("CLOSED_TICKET", 2)
        ClosedTicketTicketNum = ClosedTicketRST("TICKET_NUM")
        ClosedTicketGuestNum = ClosedTicketRST("GUEST_NUM")
        ClosedTicketOrderNum = ClosedTicketRST("ORDER_NUM")
        ClosedTicketDateIn = ClosedTicketRST("DATE_IN")
        ClosedTicketTimeIn = ClosedTicketRST("TIME_IN")
        ClosedTicketTipAtBar = ClosedTicketRST("TIP_AT_BAR")
        ClosedTicketTimeSat = ClosedTicketRST("TIME_SAT")
        ClosedTicketTippedOn = ClosedTicketRST("TIPPED_ON")
        ClosedTicketTableNum = ClosedTicketRST("TABLE_NUM")
        ClosedTicketStoolNum = ClosedTicketRST("STOOL_NUM")
        ClosedTicketSubTotal = ClosedTicketRST("SUBTOTAL")
        ClosedTicketTax = ClosedTicketRST("TAX")
        ClosedTicketBarTotal = ClosedTicketRST("BAR_TOTAL")
        closedticketfoodtotal = ClosedTicketRST("FOOD_TOTAL")
        ClosedTicketTotal = ClosedTicketRST("TOTAL")
        ClosedTicketPaid = ClosedTicketRST("PAID")
        ClosedTicketCheck = ClosedTicketRST("CHECK")
        ClosedTicketCash = ClosedTicketRST("CASH")
        ClosedTicketCard = ClosedTicketRST("CARD")
        ClosedTicketGiftCert = ClosedTicketRST("GIFT_CERT")
        ClosedTicketChange = ClosedTicketRST("CHANGE")
        ClosedTicketDateOut = ClosedTicketRST("DATE_OUT")
        ClosedTicketTimeOut = ClosedTicketRST("TIME_OUT")
        ClosedTicketReTable = ClosedTicketRST("RETABLE")
        ClosedTicketReTrans = ClosedTicketRST("RETRANS")
        ClosedTicketTip = ClosedTicketRST("TIP")
    End Sub

    Public Sub ClosedTicket_Close()
        ClosedTicketRST.Close()
        ClosedTicketRST = Nothing
    End Sub

    Public Sub ClosedBarOrder_Open()
        ClosedBarOrderRST = db.OpenRecordset("CLOSED_BAR_ORDER", 2)
        ClosedBarOrderOrderNum = ClosedBarOrderRST("ORDER_NUM")
        ClosedBarOrderLineNum = ClosedBarOrderRST("LINE_NUM")
        ClosedBarOrderItemNum = ClosedBarOrderRST("ITEM_NUM")
        ClosedBarOrderQuotedPrice = ClosedBarOrderRST("QUOTED_PRICE")
        ClosedBarOrderReTable = ClosedBarOrderRST("RETABLE")
        ClosedBarOrderReTrans = ClosedBarOrderRST("RETRANS")
    End Sub

    Public Sub ClosedBarOrder_Close()
        ClosedBarOrderRST.Close()
        ClosedBarOrderRST = Nothing
    End Sub

    Public Sub EmpJob_Open()
        EmpJobRST = db.OpenRecordset("EMPJOB", 2)
        EmpJobEmpNum = EmpJobRST("EMP_NUM")
        EmpJobJobNum = EmpJobRST("JOB_NUM")
    End Sub

    Public Sub EmpJob_Close()
        EmpJobRST.Close()
        EmpJobRST = Nothing
    End Sub

    Public Sub Emp_Open()
        EmpRST = db.OpenRecordset("EMPLOYEE", 2)
        EmpEmpNum = EmpRST("EMP_NUM")
        EmpEmpName = EmpRST("EMP_NAME")
    End Sub

    Public Sub Emp_Close()
        EmpRST.Close()
        EmpRST = Nothing
    End Sub

    Public Sub Item_Open()
        ItemRST = db.OpenRecordset("ITEM", 2)
        ItemItemNum = ItemRST("ITEM_NUM")
        ItemItemName = ItemRST("ITEM_NAME")
        ItemItemPrice = ItemRST("ITEM_PRICE")
    End Sub

    Public Sub Item_Close()
        ItemRST.Close()
        ItemRST = Nothing
    End Sub

    Public Sub Jobs_Open()
        JobsRST = db.OpenRecordset("JOBS", 2)
        JobsJobNum = JobsRST("JOB_NUM")
        JobsJobTitle = JobsRST("JOB_TITLE")
    End Sub

    Public Sub Jobs_Close()
        JobsRST.Close()
        JobsRST = Nothing
    End Sub

    Public Sub OldTableInfo_Open()
        OldTableInfoRST = db.OpenRecordset("OLD_TABLEINFO", 2)
        OldTableInfoTableNum = OldTableInfoRST("TABLE_NUM")
        OldTableInfoTableName = OldTableInfoRST("TABLE_NAME")
        OldTableInfoAvailable = OldTableInfoRST("AVAILABLE")
        OldTableInfoGuestCount = OldTableInfoRST("GUEST_COUNT")
        OldTableInfoEmpNum1 = OldTableInfoRST("EMP_NUM")
        OldTableInfoEmpNum2 = OldTableInfoRST("EMP_NUM2")
        OldTableInfoDateOut = OldTableInfoRST("DATE_OUT")
        OldTableInfoTimeOut = OldTableInfoRST("TIME_OUT")
        OldTableInfoReTable = OldTableInfoRST("RETABLE")
        OldTableInfoReTrans = OldTableInfoRST("RETRANS")
        OldTableInfoStoolNum = OldTableInfoRST("STOOL_NUM")
    End Sub

    Public Sub OldTableInfo_Close()
        OldTableInfoRST.Close()
        OldTableInfoRST = Nothing
    End Sub

    Public Sub OldStoolInfo_Open()
        OldStoolInfoRST = db.OpenRecordset("OLD_STOOLINFO", 2)
        OldStoolInfoStoolNum = OldStoolInfoRST("STOOL_NUM")
        OldStoolInfoAvailable = OldStoolInfoRST("AVAILABLE")
        OldStoolInfoDateOut = OldStoolInfoRST("DATE_OUT")
        OldStoolInfoTimeOut = OldStoolInfoRST("TIME_OUT")
        OldStoolInfoReTable = OldStoolInfoRST("RETABLE")
        OldStoolInfoReTrans = OldStoolInfoRST("RETRANS")
    End Sub

    Public Sub OldStoolInfo_Close()
        OldStoolInfoRST.Close()
        OldStoolInfoRST = Nothing
    End Sub

    Public Sub OldOrder_Open()
        OldOrderRST = db.OpenRecordset("OLD_ORDER", 2)
        OldOrderOrderNum = OldOrderRST("ORDER_NUM")
        OldOrderLineNum = OldOrderRST("LINE_NUM")
        OldOrderItemNum = OldOrderRST("ITEM_NUM")
        OldOrderQuotedPrice = OldOrderRST("QUOTED_PRICE")
        OldOrderReTable = OldOrderRST("RETABLE")
        OldOrderReTrans = OldOrderRST("RETRANS")
    End Sub

    Public Sub OldOrder_Close()
        OldOrderRST.Close()
        OldOrderRST = Nothing
    End Sub

    Public Sub OldTicket_Open()
        OldTicketRST = db.OpenRecordset("OLD_TICKET", 2)
        OldTicketTicketNum = OldTicketRST("TICKET_NUM")
        OldTicketGuestNum = OldTicketRST("GUEST_NUM")
        OldTicketOrderNum = OldTicketRST("ORDER_NUM")
        OldTicketDateIn = OldTicketRST("DATE_IN")
        OldTicketTimeIn = OldTicketRST("TIME_IN")
        OldTicketTipAtBar = OldTicketRST("TIP_AT_BAR")
        OldTicketTimeSat = OldTicketRST("TIME_SAT")
        OldTicketTippedOn = OldTicketRST("TIPPED_ON")
        OldTicketTableNum = OldTicketRST("TABLE_NUM")
        OldTicketStoolNum = OldTicketRST("STOOL_NUM")
        OldTicketSubTotal = OldTicketRST("SUBTOTAL")
        OldTicketTax = OldTicketRST("TAX")
        OldTicketBarTotal = OldTicketRST("BAR_TOTAL")
        OldTicketFoodTotal = OldTicketRST("FOOD_TOTAL")
        OldTicketTotal = OldTicketRST("TOTAL")
        OldTicketPaid = OldTicketRST("PAID")
        OldTicketCheck = OldTicketRST("CHECK")
        OldTicketCash = OldTicketRST("CASH")
        OldTicketCard = OldTicketRST("CARD")
        OldTicketGiftCert = OldTicketRST("GIFT_CERT")
        OldTicketChange = OldTicketRST("CHECK_CHANGE")
        OldTicketDateOut = OldTicketRST("DATE_OUT")
        OldTicketTimeOut = OldTicketRST("TIME_OUT")
        OldTicketReTable = OldTicketRST("RETABLE")
        OldTicketReTrans = OldTicketRST("RETRANS")
        OldTicketTip = OldTicketRST("TIP")
    End Sub

    Public Sub OldTicketOrder_Close()
        OldTicketRST.Close()
        OldTicketRST = Nothing
    End Sub

    Public Sub OldBarOrder_Open()
        OldBarOrderRST = db.OpenRecordset("OLD_BAR_ORDER", 2)
        OldBarOrderOrderNum = OldBarOrderRST("ORDER_NUM")
        OldBarOrderLineNum = OldBarOrderRST("LINE_NUM")
        OldBarOrderItemNum = OldBarOrderRST("ITEM_NUM")
        OldBarOrderQuotedPrice = OldBarOrderRST("QUOTED_PRICE")
        OldBarOrderReTable = OldBarOrderRST("RETABLE")
        OldBarOrderReTrans = OldBarOrderRST("RETRANS")
    End Sub

    Public Sub OldBarOrder_Close()
        OldBarOrderRST.Close()
        OldBarOrderRST = Nothing
    End Sub

    Public Sub Saved_Open()
        SavedRST = db.OpenRecordset("SAVED", 2)
        SavedReTable = SavedRST("RETABLE")
        SavedReTrans = SavedRST("RETRANS")
        SavedTicketNum = SavedRST("TICKET_NUM")
        SavedOrderNum = SavedRST("ORDER_NUM")
        SavedLineNum = SavedRST("LINE_NUM")
        SavedTableNum = SavedRST("TABLE_NUM")
        SavedCustomNum = SavedRST("CUSTOM_NUM")
        SavedMessageForBar = SavedRST("MESSAGE_FOR_BAR")
    End Sub

    Public Sub Saved_Close()
        SavedRST.Close()
        SavedRST = Nothing
    End Sub

    Public Sub SIO_Open()
        SIORST = db.OpenRecordset("SIGNINOUT", 2)
        SIOEmpNum = SIORST("EMP_NUM")
        SIOSignInDate = SIORST("SIGNIN_DATE")
        SIOSignInTime = SIORST("SIGNIN_TIME")
        SIOSignOutDate = SIORST("SIGNOUT_DATE")
        SIOSignOutTime = SIORST("SIGNOUT_TIME")
        SIOJobNum = SIORST("JOB_NUM")
    End Sub

    Public Sub SIO_Close()
        SIORST.Close()
        SIORST = Nothing
    End Sub

    Public Sub OpenTableInfo_Open()
        OpenTableInfoRST = db.OpenRecordset("OPEN_TABLEINFO", 2)
        OpenTableInfoTableNum = OpenTableInfoRST("TABLE_NUM")
        OpenTableInfoTableName = OpenTableInfoRST("TABLE_NAME")
        OpenTableInfoAvailable = OpenTableInfoRST("AVAILABLE")
        OpenTableInfoGuestCount = OpenTableInfoRST("GUEST_COUNT")
        OpenTableInfoEmpNum1 = OpenTableInfoRST("EMP_NUM")
        OpenTableInfoEmpNum2 = OpenTableInfoRST("EMP_NUM2")
        OpenTableInfoReTable = OpenTableInfoRST("RETABLE")
        OpenTableInfoReTrans = OpenTableInfoRST("RETRANS")
        OpenTableInfoStoolNum = OpenTableInfoRST("STOOL_NUM")
        OpenTableInfoTipAtBar = OpenTableInfoRST("TIP_AT_BAR")
    End Sub

    Public Sub OpenTableInfo_Close()
        OpenTableInfoRST.Close()
        OpenTableInfoRST = Nothing
    End Sub

    Public Sub OpenStoolInfo_Open()
        OpenStoolInfoRST = db.OpenRecordset("OPEN_STOOLINFO", 2)
        OpenStoolInfoStoolNum = OpenStoolInfoRST("STOOL_NUM")
        OpenStoolInfoAvailable = OpenStoolInfoRST("AVAILABLE")
        OpenStoolInfoReTable = OpenStoolInfoRST("RETABLE")
        OpenStoolInfoReTrans = OpenStoolInfoRST("RETRANS")
        OpenStoolInfoReference = OpenStoolInfoRST("REFERENCE")
    End Sub

    Public Sub OpenStoolInfo_Close()
        OpenStoolInfoRST.Close()
        OpenStoolInfoRST = Nothing
    End Sub

    Public Sub OpenOrder_Open()
        OpenOrderRST = db.OpenRecordset("OPEN_ORDER", 2)
        OpenOrderOrderNum = OpenOrderRST("ORDER_NUM")
        OpenOrderLineNum = OpenOrderRST("LINE_NUM")
        OpenOrderItemNum = OpenOrderRST("ITEM_NUM")
        OpenOrderQuotedPrice = OpenOrderRST("QUOTED_PRICE")
        OpenOrderReTable = OpenOrderRST("RETABLE")
        OpenOrderReTrans = OpenOrderRST("RETRANS")
    End Sub

    Public Sub OpenOrder_Close()
        OpenOrderRST.Close()
        OpenOrderRST = Nothing
    End Sub

    Public Sub OpenTicket_Open()
        OpenTicketRST = db.OpenRecordset("OPEN_TICKET", 2)
        OpenTicketTicketNum = OpenTicketRST("TICKET_NUM")
        OpenTicketGuestNum = OpenTicketRST("GUEST_NUM")
        OpenTicketOrderNum = OpenTicketRST("ORDER_NUM")
        OpenTicketDateIn = OpenTicketRST("DATE_IN")
        OpenTicketTimeIn = OpenTicketRST("TIME_IN")
        OpenTicketTipAtBar = OpenTicketRST("TIP_AT_BAR")
        OpenTicketTimeSat = OpenTicketRST("TIME_SAT")
        OpenTicketTippedOn = OpenTicketRST("TIPPED_ON")
        OpenTicketTableNum = OpenTicketRST("TABLE_NUM")
        OpenTicketStoolNum = OpenTicketRST("STOOL_NUM")
        OpenTicketSubTotal = OpenTicketRST("SUBTOTAL")
        OpenTicketTax = OpenTicketRST("TAX")
        OpenTicketFoodTotal = OpenTicketRST("FOOD_TOTAL")
        OpenTicketBarTotal = OpenTicketRST("BAR_TOTAL")
        OpenTicketTotal = OpenTicketRST("TOTAL")
        OpenTicketReTable = OpenTicketRST("RETABLE")
        OpenTicketReTrans = OpenTicketRST("RETRANS")
    End Sub

    Public Sub OpenTicket_Close()
        OpenTicketRST.Close()
        OpenTicketRST = Nothing
    End Sub

    Public Sub OpenBarOrder_Open()
        OpenBarOrderRST = db.OpenRecordset("OPEN_BAR_ORDER", 2)
        OpenBarOrderOrderNum = OpenBarOrderRST("ORDER_NUM")
        OpenBarOrderLineNum = OpenBarOrderRST("LINE_NUM")
        OpenBarOrderItemNum = OpenBarOrderRST("ITEM_NUM")
        OpenBarOrderQuotedPrice = OpenBarOrderRST("QUOTED_PRICE")
        OpenBarOrderReTable = OpenBarOrderRST("RETABLE")
        OpenBarOrderReTrans = OpenBarOrderRST("RETRANS")
    End Sub

    Public Sub OpenBarOrder_Close()
        OpenBarOrderRST.Close()
        OpenBarOrderRST = Nothing
    End Sub

    Public Sub Specials_Open()
        SpecialsRST = db.OpenRecordset("SPECIALS", 2)
        SpecialsItemNum = SpecialsRST("ITEM_NUM")
        SpecialsItemName = SpecialsRST("ITEM_NAME")
        SpecialsItemPrice = SpecialsRST("ITEM_PRICE")
        SpecialsSpecial2 = SpecialsRST("SPECIAL2")
        SpecialsSpecial3 = SpecialsRST("SPECIAL3")
        SpecialsSpecial4 = SpecialsRST("SPECIAL4")
        SpecialsSpecial5 = SpecialsRST("SPECIAL5")
        SpecialsSpecial6 = SpecialsRST("SPECIAL6")
    End Sub

    Public Sub Specials_Close()
        SpecialsRST.Close()
        SpecialsRST = Nothing
    End Sub

    Public Sub BarItem_Open()
        BarItemRST = db.OpenRecordset("BAR_ITEM", 2)
        BarItemItemNum = BarItemRST("ITEM_NUM")
        BarItemItemName = BarItemRST("ITEM_NAME")
        BarItemItemPrice = BarItemRST("ITEM_PRICE")
    End Sub

    Public Sub BarItem_Close()
        BarItemRST.Close()
        BarItemRST = Nothing
    End Sub

    Public Sub Clear_Currents()
        EMPNUM = 0
        JOBNUM = 0
        CURSERVER = 0
        CURSERVERNAME = ""
        CURGUESTCOUNT = 0
        CURGUEST = 0
        CURTABLE = 0
        CURSTOOL = 0
        CURORDER = 0
        CURTICKET = 0
        CURTABLENAME = ""
        CURRETABLE = 0
        CURRETRANS = 0
    End Sub
End Module