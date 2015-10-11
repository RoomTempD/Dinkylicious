Imports System.Collections.Generic

Public Class POS
    Inherits System.Windows.Forms.Form
    Friend WithEvents guest4 As System.Windows.Forms.Button
    Friend WithEvents guest5 As System.Windows.Forms.Button
    Friend WithEvents guest6 As System.Windows.Forms.Button
    Friend WithEvents guest7 As System.Windows.Forms.Button
    Friend WithEvents guest8 As System.Windows.Forms.Button
    Friend WithEvents cmdDrinks As System.Windows.Forms.Button
    Friend WithEvents lblTotals As System.Windows.Forms.Label

    Public QuickSale As Boolean

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
    Friend WithEvents cmdServer As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents cmdRemoveItem As System.Windows.Forms.Button
    Friend WithEvents cmdRemoveTable As System.Windows.Forms.Button
    Friend WithEvents guest1 As System.Windows.Forms.Button
    Friend WithEvents guest2 As System.Windows.Forms.Button
    Friend WithEvents guest3 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents cmd010101 As System.Windows.Forms.Button
    Friend WithEvents cmd010802 As System.Windows.Forms.Button
    Friend WithEvents cmd010803 As System.Windows.Forms.Button
    Friend WithEvents cmd010801 As System.Windows.Forms.Button
    Friend WithEvents cmd010702 As System.Windows.Forms.Button
    Friend WithEvents cmd010703 As System.Windows.Forms.Button
    Friend WithEvents cmd010704 As System.Windows.Forms.Button
    Friend WithEvents cmd010701 As System.Windows.Forms.Button
    Friend WithEvents cmd010602 As System.Windows.Forms.Button
    Friend WithEvents cmd010601 As System.Windows.Forms.Button
    Friend WithEvents cmd010502 As System.Windows.Forms.Button
    Friend WithEvents cmd010501 As System.Windows.Forms.Button
    Friend WithEvents cmd010302 As System.Windows.Forms.Button
    Friend WithEvents cmd010303 As System.Windows.Forms.Button
    Friend WithEvents cmd010304 As System.Windows.Forms.Button
    Friend WithEvents cmd010305 As System.Windows.Forms.Button
    Friend WithEvents cmd010301 As System.Windows.Forms.Button
    Friend WithEvents cmd010201 As System.Windows.Forms.Button
    Friend WithEvents cmd010206 As System.Windows.Forms.Button
    Friend WithEvents cmd010306 As System.Windows.Forms.Button
    Friend WithEvents cmd010106 As System.Windows.Forms.Button
    Friend WithEvents cmd010102 As System.Windows.Forms.Button
    Friend WithEvents cmd010103 As System.Windows.Forms.Button
    Friend WithEvents cmd010104 As System.Windows.Forms.Button
    Friend WithEvents cmd010105 As System.Windows.Forms.Button
    Friend WithEvents cmd020302 As System.Windows.Forms.Button
    Friend WithEvents cmd020303 As System.Windows.Forms.Button
    Friend WithEvents cmd020304 As System.Windows.Forms.Button
    Friend WithEvents cmd020301 As System.Windows.Forms.Button
    Friend WithEvents cmd020203 As System.Windows.Forms.Button
    Friend WithEvents cmd020205 As System.Windows.Forms.Button
    Friend WithEvents cmd020201 As System.Windows.Forms.Button
    Friend WithEvents cmd020206 As System.Windows.Forms.Button
    Friend WithEvents cmd020106 As System.Windows.Forms.Button
    Friend WithEvents cmd020102 As System.Windows.Forms.Button
    Friend WithEvents cmd020103 As System.Windows.Forms.Button
    Friend WithEvents cmd020104 As System.Windows.Forms.Button
    Friend WithEvents cmd020105 As System.Windows.Forms.Button
    Friend WithEvents cmd020101 As System.Windows.Forms.Button
    Friend WithEvents cmd020802 As System.Windows.Forms.Button
    Friend WithEvents cmd020801 As System.Windows.Forms.Button
    Friend WithEvents cmd020702 As System.Windows.Forms.Button
    Friend WithEvents cmd020703 As System.Windows.Forms.Button
    Friend WithEvents cmd020704 As System.Windows.Forms.Button
    Friend WithEvents cmd020701 As System.Windows.Forms.Button
    Friend WithEvents cmd020602 As System.Windows.Forms.Button
    Friend WithEvents cmd020604 As System.Windows.Forms.Button
    Friend WithEvents cmd020601 As System.Windows.Forms.Button
    Friend WithEvents cmd020504 As System.Windows.Forms.Button
    Friend WithEvents cmd020501 As System.Windows.Forms.Button
    Friend WithEvents cmd020403 As System.Windows.Forms.Button
    Friend WithEvents cmd020401 As System.Windows.Forms.Button
    Friend WithEvents cmd020306 As System.Windows.Forms.Button
    Friend WithEvents cmd030206 As System.Windows.Forms.Button
    Friend WithEvents cmd030306 As System.Windows.Forms.Button
    Friend WithEvents cmd030106 As System.Windows.Forms.Button
    Friend WithEvents cmd030102 As System.Windows.Forms.Button
    Friend WithEvents cmd030101 As System.Windows.Forms.Button
    Friend WithEvents cmd030802 As System.Windows.Forms.Button
    Friend WithEvents cmd030803 As System.Windows.Forms.Button
    Friend WithEvents cmd030801 As System.Windows.Forms.Button
    Friend WithEvents cmd030702 As System.Windows.Forms.Button
    Friend WithEvents cmd030703 As System.Windows.Forms.Button
    Friend WithEvents cmd030704 As System.Windows.Forms.Button
    Friend WithEvents cmd030701 As System.Windows.Forms.Button
    Friend WithEvents cmd030604 As System.Windows.Forms.Button
    Friend WithEvents cmd030501 As System.Windows.Forms.Button
    Friend WithEvents cmd030401 As System.Windows.Forms.Button
    Friend WithEvents cmd030301 As System.Windows.Forms.Button
    Friend WithEvents cmd030201 As System.Windows.Forms.Button
    Friend WithEvents cmd040802 As System.Windows.Forms.Button
    Friend WithEvents cmd040803 As System.Windows.Forms.Button
    Friend WithEvents cmd040804 As System.Windows.Forms.Button
    Friend WithEvents cmd040801 As System.Windows.Forms.Button
    Friend WithEvents cmd040702 As System.Windows.Forms.Button
    Friend WithEvents cmd040703 As System.Windows.Forms.Button
    Friend WithEvents cmd040704 As System.Windows.Forms.Button
    Friend WithEvents cmd040701 As System.Windows.Forms.Button
    Friend WithEvents cmd040602 As System.Windows.Forms.Button
    Friend WithEvents cmd040603 As System.Windows.Forms.Button
    Friend WithEvents cmd040604 As System.Windows.Forms.Button
    Friend WithEvents cmd040601 As System.Windows.Forms.Button
    Friend WithEvents cmd040302 As System.Windows.Forms.Button
    Friend WithEvents cmd040301 As System.Windows.Forms.Button
    Friend WithEvents cmd040202 As System.Windows.Forms.Button
    Friend WithEvents cmd040201 As System.Windows.Forms.Button
    Friend WithEvents cmd040102 As System.Windows.Forms.Button
    Friend WithEvents cmd040103 As System.Windows.Forms.Button
    Friend WithEvents cmd040101 As System.Windows.Forms.Button
    Friend WithEvents cmd050802 As System.Windows.Forms.Button
    Friend WithEvents cmd050801 As System.Windows.Forms.Button
    Friend WithEvents cmd050702 As System.Windows.Forms.Button
    Friend WithEvents cmd050704 As System.Windows.Forms.Button
    Friend WithEvents cmd050705 As System.Windows.Forms.Button
    Friend WithEvents cmd050602 As System.Windows.Forms.Button
    Friend WithEvents cmd050604 As System.Windows.Forms.Button
    Friend WithEvents cmd050605 As System.Windows.Forms.Button
    Friend WithEvents cmd050601 As System.Windows.Forms.Button
    Friend WithEvents cmd050502 As System.Windows.Forms.Button
    Friend WithEvents cmd050504 As System.Windows.Forms.Button
    Friend WithEvents cmd050505 As System.Windows.Forms.Button
    Friend WithEvents cmd050501 As System.Windows.Forms.Button
    Friend WithEvents cmd050302 As System.Windows.Forms.Button
    Friend WithEvents cmd050301 As System.Windows.Forms.Button
    Friend WithEvents cmd050202 As System.Windows.Forms.Button
    Friend WithEvents cmd050201 As System.Windows.Forms.Button
    Friend WithEvents cmd050102 As System.Windows.Forms.Button
    Friend WithEvents cmd050103 As System.Windows.Forms.Button
    Friend WithEvents cmd050101 As System.Windows.Forms.Button
    Friend WithEvents cmd060801 As System.Windows.Forms.Button
    Friend WithEvents cmd060701 As System.Windows.Forms.Button
    Friend WithEvents cmd060602 As System.Windows.Forms.Button
    Friend WithEvents cmd060601 As System.Windows.Forms.Button
    Friend WithEvents cmd060502 As System.Windows.Forms.Button
    Friend WithEvents cmd060501 As System.Windows.Forms.Button
    Friend WithEvents cmd060402 As System.Windows.Forms.Button
    Friend WithEvents cmd060401 As System.Windows.Forms.Button
    Friend WithEvents cmd060301 As System.Windows.Forms.Button
    Friend WithEvents cmd060201 As System.Windows.Forms.Button
    Friend WithEvents cmd060102 As System.Windows.Forms.Button
    Friend WithEvents cmd060101 As System.Windows.Forms.Button
    Friend WithEvents cmd020603 As System.Windows.Forms.Button
    Friend WithEvents cmd010706 As System.Windows.Forms.Button
    Friend WithEvents cmd010606 As System.Windows.Forms.Button
    Friend WithEvents cmd010506 As System.Windows.Forms.Button
    Friend WithEvents cmd010406 As System.Windows.Forms.Button
    Friend WithEvents cmd010806 As System.Windows.Forms.Button
    Friend WithEvents cmd010805 As System.Windows.Forms.Button
    Friend WithEvents cmd020806 As System.Windows.Forms.Button
    Friend WithEvents cmd020606 As System.Windows.Forms.Button
    Friend WithEvents cmd020506 As System.Windows.Forms.Button
    Friend WithEvents cmd020406 As System.Windows.Forms.Button
    Friend WithEvents cmd020706 As System.Windows.Forms.Button
    Friend WithEvents cmd020805 As System.Windows.Forms.Button
    Friend WithEvents cmd030606 As System.Windows.Forms.Button
    Friend WithEvents cmd030506 As System.Windows.Forms.Button
    Friend WithEvents cmd030406 As System.Windows.Forms.Button
    Friend WithEvents cmd030706 As System.Windows.Forms.Button
    Friend WithEvents cmd030805 As System.Windows.Forms.Button
    Friend WithEvents cmd030806 As System.Windows.Forms.Button
    Friend WithEvents cmdFoods As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents bar055 As System.Windows.Forms.Button
    Friend WithEvents bar054 As System.Windows.Forms.Button
    Friend WithEvents bar053 As System.Windows.Forms.Button
    Friend WithEvents bar029 As System.Windows.Forms.Button
    Friend WithEvents bar032 As System.Windows.Forms.Button
    Friend WithEvents bar031 As System.Windows.Forms.Button
    Friend WithEvents bar030 As System.Windows.Forms.Button
    Friend WithEvents bar022 As System.Windows.Forms.Button
    Friend WithEvents bar021 As System.Windows.Forms.Button
    Friend WithEvents bar025 As System.Windows.Forms.Button
    Friend WithEvents bar024 As System.Windows.Forms.Button
    Friend WithEvents bar052 As System.Windows.Forms.Button
    Friend WithEvents bar051 As System.Windows.Forms.Button
    Friend WithEvents bar028 As System.Windows.Forms.Button
    Friend WithEvents bar050 As System.Windows.Forms.Button
    Friend WithEvents bar049 As System.Windows.Forms.Button
    Friend WithEvents bar048 As System.Windows.Forms.Button
    Friend WithEvents bar047 As System.Windows.Forms.Button
    Friend WithEvents bar046 As System.Windows.Forms.Button
    Friend WithEvents bar045 As System.Windows.Forms.Button
    Friend WithEvents bar044 As System.Windows.Forms.Button
    Friend WithEvents bar043 As System.Windows.Forms.Button
    Friend WithEvents bar042 As System.Windows.Forms.Button
    Friend WithEvents bar041 As System.Windows.Forms.Button
    Friend WithEvents bar040 As System.Windows.Forms.Button
    Friend WithEvents bar039 As System.Windows.Forms.Button
    Friend WithEvents bar038 As System.Windows.Forms.Button
    Friend WithEvents bar037 As System.Windows.Forms.Button
    Friend WithEvents bar034 As System.Windows.Forms.Button
    Friend WithEvents bar033 As System.Windows.Forms.Button
    Friend WithEvents bar036 As System.Windows.Forms.Button
    Friend WithEvents bar035 As System.Windows.Forms.Button
    Friend WithEvents bar027 As System.Windows.Forms.Button
    Friend WithEvents bar019 As System.Windows.Forms.Button
    Friend WithEvents bar020 As System.Windows.Forms.Button
    Friend WithEvents bar018 As System.Windows.Forms.Button
    Friend WithEvents bar017 As System.Windows.Forms.Button
    Friend WithEvents bar016 As System.Windows.Forms.Button
    Friend WithEvents bar015 As System.Windows.Forms.Button
    Friend WithEvents bar014 As System.Windows.Forms.Button
    Friend WithEvents bar013 As System.Windows.Forms.Button
    Friend WithEvents bar012 As System.Windows.Forms.Button
    Friend WithEvents bar011 As System.Windows.Forms.Button
    Friend WithEvents bar005 As System.Windows.Forms.Button
    Friend WithEvents bar010 As System.Windows.Forms.Button
    Friend WithEvents bar009 As System.Windows.Forms.Button
    Friend WithEvents bar008 As System.Windows.Forms.Button
    Friend WithEvents bar007 As System.Windows.Forms.Button
    Friend WithEvents bar006 As System.Windows.Forms.Button
    Friend WithEvents bar002 As System.Windows.Forms.Button
    Friend WithEvents bar001 As System.Windows.Forms.Button
    Friend WithEvents bar004 As System.Windows.Forms.Button
    Friend WithEvents bar003 As System.Windows.Forms.Button
    Friend WithEvents bar026 As System.Windows.Forms.Button
    Friend WithEvents bar023 As System.Windows.Forms.Button
    Friend WithEvents cmdMessage As System.Windows.Forms.Button
    Friend WithEvents cmdCloseTable As System.Windows.Forms.Button
    Friend WithEvents cmdMisc As System.Windows.Forms.Button
    Friend WithEvents cmdQuickSale As System.Windows.Forms.Button
    Friend WithEvents cmdTwo As System.Windows.Forms.Button
    Friend WithEvents cmdThree As System.Windows.Forms.Button
    Friend WithEvents cmdFour As System.Windows.Forms.Button
    Friend WithEvents cmdFive As System.Windows.Forms.Button
    Friend WithEvents cmdOne As System.Windows.Forms.Button
    Friend WithEvents cmdSeatStool As System.Windows.Forms.Button
    Friend WithEvents cmd040805 As System.Windows.Forms.Button
    Friend WithEvents cmdOpen As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdCustom As System.Windows.Forms.Button
    Friend WithEvents bar056 As System.Windows.Forms.Button
    Friend WithEvents cmdCustomBar As System.Windows.Forms.Button
    Friend WithEvents cmd040504 As System.Windows.Forms.Button
    Friend WithEvents cmd010603 As System.Windows.Forms.Button
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents cmd040206 As System.Windows.Forms.Button
    Friend WithEvents cmd040306 As System.Windows.Forms.Button
    Friend WithEvents cmd040106 As System.Windows.Forms.Button
    Friend WithEvents cmd050206 As System.Windows.Forms.Button
    Friend WithEvents cmd050306 As System.Windows.Forms.Button
    Friend WithEvents cmd050106 As System.Windows.Forms.Button
    Friend WithEvents cmd010804 As System.Windows.Forms.Button
    Friend WithEvents cmd010705 As System.Windows.Forms.Button
    Friend WithEvents cmd010605 As System.Windows.Forms.Button
    Friend WithEvents cmd010604 As System.Windows.Forms.Button
    Friend WithEvents cmd010505 As System.Windows.Forms.Button
    Friend WithEvents cmd010504 As System.Windows.Forms.Button
    Friend WithEvents cmd010503 As System.Windows.Forms.Button
    Friend WithEvents cmd010405 As System.Windows.Forms.Button
    Friend WithEvents cmd010404 As System.Windows.Forms.Button
    Friend WithEvents cmd010403 As System.Windows.Forms.Button
    Friend WithEvents cmd010402 As System.Windows.Forms.Button
    Friend WithEvents cmd010401 As System.Windows.Forms.Button
    Friend WithEvents cmd010205 As System.Windows.Forms.Button
    Friend WithEvents cmd010204 As System.Windows.Forms.Button
    Friend WithEvents cmd010203 As System.Windows.Forms.Button
    Friend WithEvents cmd010202 As System.Windows.Forms.Button
    Friend WithEvents cmd020804 As System.Windows.Forms.Button
    Friend WithEvents cmd020803 As System.Windows.Forms.Button
    Friend WithEvents cmd020705 As System.Windows.Forms.Button
    Friend WithEvents cmd020605 As System.Windows.Forms.Button
    Friend WithEvents cmd020505 As System.Windows.Forms.Button
    Friend WithEvents cmd020503 As System.Windows.Forms.Button
    Friend WithEvents cmd020405 As System.Windows.Forms.Button
    Friend WithEvents cmd020404 As System.Windows.Forms.Button
    Friend WithEvents cmd020305 As System.Windows.Forms.Button
    Friend WithEvents cmd020502 As System.Windows.Forms.Button
    Friend WithEvents cmd020402 As System.Windows.Forms.Button
    Friend WithEvents cmd020204 As System.Windows.Forms.Button
    Friend WithEvents cmd020202 As System.Windows.Forms.Button
    Friend WithEvents cmd030804 As System.Windows.Forms.Button
    Friend WithEvents cmd030705 As System.Windows.Forms.Button
    Friend WithEvents cmd030605 As System.Windows.Forms.Button
    Friend WithEvents cmd030603 As System.Windows.Forms.Button
    Friend WithEvents cmd030602 As System.Windows.Forms.Button
    Friend WithEvents cmd030601 As System.Windows.Forms.Button
    Friend WithEvents cmd030505 As System.Windows.Forms.Button
    Friend WithEvents cmd030504 As System.Windows.Forms.Button
    Friend WithEvents cmd030503 As System.Windows.Forms.Button
    Friend WithEvents cmd030502 As System.Windows.Forms.Button
    Friend WithEvents cmd030405 As System.Windows.Forms.Button
    Friend WithEvents cmd030404 As System.Windows.Forms.Button
    Friend WithEvents cmd030403 As System.Windows.Forms.Button
    Friend WithEvents cmd030402 As System.Windows.Forms.Button
    Friend WithEvents cmd030305 As System.Windows.Forms.Button
    Friend WithEvents cmd030304 As System.Windows.Forms.Button
    Friend WithEvents cmd030303 As System.Windows.Forms.Button
    Friend WithEvents cmd030302 As System.Windows.Forms.Button
    Friend WithEvents cmd030205 As System.Windows.Forms.Button
    Friend WithEvents cmd030204 As System.Windows.Forms.Button
    Friend WithEvents cmd030203 As System.Windows.Forms.Button
    Friend WithEvents cmd030202 As System.Windows.Forms.Button
    Friend WithEvents cmd030105 As System.Windows.Forms.Button
    Friend WithEvents cmd030104 As System.Windows.Forms.Button
    Friend WithEvents cmd030103 As System.Windows.Forms.Button
    Friend WithEvents cmd040806 As System.Windows.Forms.Button
    Friend WithEvents cmd040706 As System.Windows.Forms.Button
    Friend WithEvents cmd040705 As System.Windows.Forms.Button
    Friend WithEvents cmd040606 As System.Windows.Forms.Button
    Friend WithEvents cmd040605 As System.Windows.Forms.Button
    Friend WithEvents cmd040506 As System.Windows.Forms.Button
    Friend WithEvents cmd040505 As System.Windows.Forms.Button
    Friend WithEvents cmd040503 As System.Windows.Forms.Button
    Friend WithEvents cmd040502 As System.Windows.Forms.Button
    Friend WithEvents cmd040501 As System.Windows.Forms.Button
    Friend WithEvents cmd040406 As System.Windows.Forms.Button
    Friend WithEvents cmd040405 As System.Windows.Forms.Button
    Friend WithEvents cmd040404 As System.Windows.Forms.Button
    Friend WithEvents cmd040403 As System.Windows.Forms.Button
    Friend WithEvents cmd040402 As System.Windows.Forms.Button
    Friend WithEvents cmd040401 As System.Windows.Forms.Button
    Friend WithEvents cmd040305 As System.Windows.Forms.Button
    Friend WithEvents cmd040304 As System.Windows.Forms.Button
    Friend WithEvents cmd040303 As System.Windows.Forms.Button
    Friend WithEvents cmd040205 As System.Windows.Forms.Button
    Friend WithEvents cmd040204 As System.Windows.Forms.Button
    Friend WithEvents cmd040203 As System.Windows.Forms.Button
    Friend WithEvents cmd040105 As System.Windows.Forms.Button
    Friend WithEvents cmd040104 As System.Windows.Forms.Button
    Friend WithEvents cmd050806 As System.Windows.Forms.Button
    Friend WithEvents cmd050805 As System.Windows.Forms.Button
    Friend WithEvents cmd050804 As System.Windows.Forms.Button
    Friend WithEvents cmd050803 As System.Windows.Forms.Button
    Friend WithEvents cmd050706 As System.Windows.Forms.Button
    Friend WithEvents cmd050703 As System.Windows.Forms.Button
    Friend WithEvents cmd050701 As System.Windows.Forms.Button
    Friend WithEvents cmd050606 As System.Windows.Forms.Button
    Friend WithEvents cmd050603 As System.Windows.Forms.Button
    Friend WithEvents cmd050506 As System.Windows.Forms.Button
    Friend WithEvents cmd050503 As System.Windows.Forms.Button
    Friend WithEvents cmd050406 As System.Windows.Forms.Button
    Friend WithEvents cmd050405 As System.Windows.Forms.Button
    Friend WithEvents cmd050404 As System.Windows.Forms.Button
    Friend WithEvents cmd050403 As System.Windows.Forms.Button
    Friend WithEvents cmd050402 As System.Windows.Forms.Button
    Friend WithEvents cmd050401 As System.Windows.Forms.Button
    Friend WithEvents cmd050305 As System.Windows.Forms.Button
    Friend WithEvents cmd050304 As System.Windows.Forms.Button
    Friend WithEvents cmd050303 As System.Windows.Forms.Button
    Friend WithEvents cmd050205 As System.Windows.Forms.Button
    Friend WithEvents cmd050204 As System.Windows.Forms.Button
    Friend WithEvents cmd050203 As System.Windows.Forms.Button
    Friend WithEvents cmd050105 As System.Windows.Forms.Button
    Friend WithEvents cmd050104 As System.Windows.Forms.Button
    Friend WithEvents cmd060806 As System.Windows.Forms.Button
    Friend WithEvents cmd060805 As System.Windows.Forms.Button
    Friend WithEvents cmd060804 As System.Windows.Forms.Button
    Friend WithEvents cmd060803 As System.Windows.Forms.Button
    Friend WithEvents cmd060802 As System.Windows.Forms.Button
    Friend WithEvents cmd060706 As System.Windows.Forms.Button
    Friend WithEvents cmd060705 As System.Windows.Forms.Button
    Friend WithEvents cmd060703 As System.Windows.Forms.Button
    Friend WithEvents cmd060702 As System.Windows.Forms.Button
    Friend WithEvents cmd060704 As System.Windows.Forms.Button
    Friend WithEvents cmd060606 As System.Windows.Forms.Button
    Friend WithEvents cmd060605 As System.Windows.Forms.Button
    Friend WithEvents cmd060604 As System.Windows.Forms.Button
    Friend WithEvents cmd060603 As System.Windows.Forms.Button
    Friend WithEvents cmd060506 As System.Windows.Forms.Button
    Friend WithEvents cmd060505 As System.Windows.Forms.Button
    Friend WithEvents cmd060504 As System.Windows.Forms.Button
    Friend WithEvents cmd060503 As System.Windows.Forms.Button
    Friend WithEvents cmd060406 As System.Windows.Forms.Button
    Friend WithEvents cmd060405 As System.Windows.Forms.Button
    Friend WithEvents cmd060404 As System.Windows.Forms.Button
    Friend WithEvents cmd060403 As System.Windows.Forms.Button
    Friend WithEvents cmd060306 As System.Windows.Forms.Button
    Friend WithEvents cmd060305 As System.Windows.Forms.Button
    Friend WithEvents cmd060304 As System.Windows.Forms.Button
    Friend WithEvents cmd060303 As System.Windows.Forms.Button
    Friend WithEvents cmd060302 As System.Windows.Forms.Button
    Friend WithEvents cmd060206 As System.Windows.Forms.Button
    Friend WithEvents cmd060205 As System.Windows.Forms.Button
    Friend WithEvents cmd060204 As System.Windows.Forms.Button
    Friend WithEvents cmd060203 As System.Windows.Forms.Button
    Friend WithEvents cmd060202 As System.Windows.Forms.Button
    Friend WithEvents cmd060106 As System.Windows.Forms.Button
    Friend WithEvents cmd060105 As System.Windows.Forms.Button
    Friend WithEvents cmd060104 As System.Windows.Forms.Button
    Friend WithEvents dgvOrder As System.Windows.Forms.DataGridView
    Friend WithEvents cmd060103 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POS))
        Me.cmdServer = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.cmdRemoveItem = New System.Windows.Forms.Button()
        Me.cmdRemoveTable = New System.Windows.Forms.Button()
        Me.guest1 = New System.Windows.Forms.Button()
        Me.guest2 = New System.Windows.Forms.Button()
        Me.guest3 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmd010804 = New System.Windows.Forms.Button()
        Me.cmd010705 = New System.Windows.Forms.Button()
        Me.cmd010605 = New System.Windows.Forms.Button()
        Me.cmd010604 = New System.Windows.Forms.Button()
        Me.cmd010505 = New System.Windows.Forms.Button()
        Me.cmd010504 = New System.Windows.Forms.Button()
        Me.cmd010503 = New System.Windows.Forms.Button()
        Me.cmd010405 = New System.Windows.Forms.Button()
        Me.cmd010404 = New System.Windows.Forms.Button()
        Me.cmd010403 = New System.Windows.Forms.Button()
        Me.cmd010402 = New System.Windows.Forms.Button()
        Me.cmd010401 = New System.Windows.Forms.Button()
        Me.cmd010205 = New System.Windows.Forms.Button()
        Me.cmd010204 = New System.Windows.Forms.Button()
        Me.cmd010203 = New System.Windows.Forms.Button()
        Me.cmd010202 = New System.Windows.Forms.Button()
        Me.cmd010603 = New System.Windows.Forms.Button()
        Me.cmd010805 = New System.Windows.Forms.Button()
        Me.cmd010806 = New System.Windows.Forms.Button()
        Me.cmd010606 = New System.Windows.Forms.Button()
        Me.cmd010506 = New System.Windows.Forms.Button()
        Me.cmd010406 = New System.Windows.Forms.Button()
        Me.cmd010706 = New System.Windows.Forms.Button()
        Me.cmd010802 = New System.Windows.Forms.Button()
        Me.cmd010803 = New System.Windows.Forms.Button()
        Me.cmd010801 = New System.Windows.Forms.Button()
        Me.cmd010702 = New System.Windows.Forms.Button()
        Me.cmd010703 = New System.Windows.Forms.Button()
        Me.cmd010704 = New System.Windows.Forms.Button()
        Me.cmd010701 = New System.Windows.Forms.Button()
        Me.cmd010602 = New System.Windows.Forms.Button()
        Me.cmd010601 = New System.Windows.Forms.Button()
        Me.cmd010502 = New System.Windows.Forms.Button()
        Me.cmd010501 = New System.Windows.Forms.Button()
        Me.cmd010302 = New System.Windows.Forms.Button()
        Me.cmd010303 = New System.Windows.Forms.Button()
        Me.cmd010304 = New System.Windows.Forms.Button()
        Me.cmd010305 = New System.Windows.Forms.Button()
        Me.cmd010301 = New System.Windows.Forms.Button()
        Me.cmd010201 = New System.Windows.Forms.Button()
        Me.cmd010206 = New System.Windows.Forms.Button()
        Me.cmd010306 = New System.Windows.Forms.Button()
        Me.cmd010106 = New System.Windows.Forms.Button()
        Me.cmd010102 = New System.Windows.Forms.Button()
        Me.cmd010103 = New System.Windows.Forms.Button()
        Me.cmd010104 = New System.Windows.Forms.Button()
        Me.cmd010105 = New System.Windows.Forms.Button()
        Me.cmd010101 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmd020804 = New System.Windows.Forms.Button()
        Me.cmd020803 = New System.Windows.Forms.Button()
        Me.cmd020705 = New System.Windows.Forms.Button()
        Me.cmd020605 = New System.Windows.Forms.Button()
        Me.cmd020505 = New System.Windows.Forms.Button()
        Me.cmd020503 = New System.Windows.Forms.Button()
        Me.cmd020405 = New System.Windows.Forms.Button()
        Me.cmd020404 = New System.Windows.Forms.Button()
        Me.cmd020305 = New System.Windows.Forms.Button()
        Me.cmd020502 = New System.Windows.Forms.Button()
        Me.cmd020402 = New System.Windows.Forms.Button()
        Me.cmd020204 = New System.Windows.Forms.Button()
        Me.cmd020202 = New System.Windows.Forms.Button()
        Me.cmd020805 = New System.Windows.Forms.Button()
        Me.cmd020806 = New System.Windows.Forms.Button()
        Me.cmd020606 = New System.Windows.Forms.Button()
        Me.cmd020506 = New System.Windows.Forms.Button()
        Me.cmd020406 = New System.Windows.Forms.Button()
        Me.cmd020706 = New System.Windows.Forms.Button()
        Me.cmd020802 = New System.Windows.Forms.Button()
        Me.cmd020801 = New System.Windows.Forms.Button()
        Me.cmd020702 = New System.Windows.Forms.Button()
        Me.cmd020703 = New System.Windows.Forms.Button()
        Me.cmd020704 = New System.Windows.Forms.Button()
        Me.cmd020701 = New System.Windows.Forms.Button()
        Me.cmd020602 = New System.Windows.Forms.Button()
        Me.cmd020603 = New System.Windows.Forms.Button()
        Me.cmd020604 = New System.Windows.Forms.Button()
        Me.cmd020601 = New System.Windows.Forms.Button()
        Me.cmd020504 = New System.Windows.Forms.Button()
        Me.cmd020501 = New System.Windows.Forms.Button()
        Me.cmd020403 = New System.Windows.Forms.Button()
        Me.cmd020401 = New System.Windows.Forms.Button()
        Me.cmd020302 = New System.Windows.Forms.Button()
        Me.cmd020303 = New System.Windows.Forms.Button()
        Me.cmd020304 = New System.Windows.Forms.Button()
        Me.cmd020301 = New System.Windows.Forms.Button()
        Me.cmd020203 = New System.Windows.Forms.Button()
        Me.cmd020205 = New System.Windows.Forms.Button()
        Me.cmd020201 = New System.Windows.Forms.Button()
        Me.cmd020206 = New System.Windows.Forms.Button()
        Me.cmd020306 = New System.Windows.Forms.Button()
        Me.cmd020106 = New System.Windows.Forms.Button()
        Me.cmd020102 = New System.Windows.Forms.Button()
        Me.cmd020103 = New System.Windows.Forms.Button()
        Me.cmd020104 = New System.Windows.Forms.Button()
        Me.cmd020105 = New System.Windows.Forms.Button()
        Me.cmd020101 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmd030804 = New System.Windows.Forms.Button()
        Me.cmd030705 = New System.Windows.Forms.Button()
        Me.cmd030605 = New System.Windows.Forms.Button()
        Me.cmd030603 = New System.Windows.Forms.Button()
        Me.cmd030602 = New System.Windows.Forms.Button()
        Me.cmd030601 = New System.Windows.Forms.Button()
        Me.cmd030505 = New System.Windows.Forms.Button()
        Me.cmd030504 = New System.Windows.Forms.Button()
        Me.cmd030503 = New System.Windows.Forms.Button()
        Me.cmd030502 = New System.Windows.Forms.Button()
        Me.cmd030405 = New System.Windows.Forms.Button()
        Me.cmd030404 = New System.Windows.Forms.Button()
        Me.cmd030403 = New System.Windows.Forms.Button()
        Me.cmd030402 = New System.Windows.Forms.Button()
        Me.cmd030305 = New System.Windows.Forms.Button()
        Me.cmd030304 = New System.Windows.Forms.Button()
        Me.cmd030303 = New System.Windows.Forms.Button()
        Me.cmd030302 = New System.Windows.Forms.Button()
        Me.cmd030205 = New System.Windows.Forms.Button()
        Me.cmd030204 = New System.Windows.Forms.Button()
        Me.cmd030203 = New System.Windows.Forms.Button()
        Me.cmd030202 = New System.Windows.Forms.Button()
        Me.cmd030105 = New System.Windows.Forms.Button()
        Me.cmd030104 = New System.Windows.Forms.Button()
        Me.cmd030103 = New System.Windows.Forms.Button()
        Me.cmd030805 = New System.Windows.Forms.Button()
        Me.cmd030806 = New System.Windows.Forms.Button()
        Me.cmd030606 = New System.Windows.Forms.Button()
        Me.cmd030506 = New System.Windows.Forms.Button()
        Me.cmd030406 = New System.Windows.Forms.Button()
        Me.cmd030706 = New System.Windows.Forms.Button()
        Me.cmd030802 = New System.Windows.Forms.Button()
        Me.cmd030803 = New System.Windows.Forms.Button()
        Me.cmd030801 = New System.Windows.Forms.Button()
        Me.cmd030702 = New System.Windows.Forms.Button()
        Me.cmd030703 = New System.Windows.Forms.Button()
        Me.cmd030704 = New System.Windows.Forms.Button()
        Me.cmd030701 = New System.Windows.Forms.Button()
        Me.cmd030604 = New System.Windows.Forms.Button()
        Me.cmd030501 = New System.Windows.Forms.Button()
        Me.cmd030401 = New System.Windows.Forms.Button()
        Me.cmd030301 = New System.Windows.Forms.Button()
        Me.cmd030201 = New System.Windows.Forms.Button()
        Me.cmd030206 = New System.Windows.Forms.Button()
        Me.cmd030306 = New System.Windows.Forms.Button()
        Me.cmd030106 = New System.Windows.Forms.Button()
        Me.cmd030102 = New System.Windows.Forms.Button()
        Me.cmd030101 = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.cmd040806 = New System.Windows.Forms.Button()
        Me.cmd040706 = New System.Windows.Forms.Button()
        Me.cmd040705 = New System.Windows.Forms.Button()
        Me.cmd040606 = New System.Windows.Forms.Button()
        Me.cmd040605 = New System.Windows.Forms.Button()
        Me.cmd040506 = New System.Windows.Forms.Button()
        Me.cmd040505 = New System.Windows.Forms.Button()
        Me.cmd040503 = New System.Windows.Forms.Button()
        Me.cmd040502 = New System.Windows.Forms.Button()
        Me.cmd040501 = New System.Windows.Forms.Button()
        Me.cmd040406 = New System.Windows.Forms.Button()
        Me.cmd040405 = New System.Windows.Forms.Button()
        Me.cmd040404 = New System.Windows.Forms.Button()
        Me.cmd040403 = New System.Windows.Forms.Button()
        Me.cmd040402 = New System.Windows.Forms.Button()
        Me.cmd040401 = New System.Windows.Forms.Button()
        Me.cmd040305 = New System.Windows.Forms.Button()
        Me.cmd040304 = New System.Windows.Forms.Button()
        Me.cmd040303 = New System.Windows.Forms.Button()
        Me.cmd040205 = New System.Windows.Forms.Button()
        Me.cmd040204 = New System.Windows.Forms.Button()
        Me.cmd040203 = New System.Windows.Forms.Button()
        Me.cmd040105 = New System.Windows.Forms.Button()
        Me.cmd040104 = New System.Windows.Forms.Button()
        Me.cmd040206 = New System.Windows.Forms.Button()
        Me.cmd040306 = New System.Windows.Forms.Button()
        Me.cmd040106 = New System.Windows.Forms.Button()
        Me.cmd040504 = New System.Windows.Forms.Button()
        Me.cmd040805 = New System.Windows.Forms.Button()
        Me.cmd040802 = New System.Windows.Forms.Button()
        Me.cmd040803 = New System.Windows.Forms.Button()
        Me.cmd040804 = New System.Windows.Forms.Button()
        Me.cmd040801 = New System.Windows.Forms.Button()
        Me.cmd040702 = New System.Windows.Forms.Button()
        Me.cmd040703 = New System.Windows.Forms.Button()
        Me.cmd040704 = New System.Windows.Forms.Button()
        Me.cmd040701 = New System.Windows.Forms.Button()
        Me.cmd040602 = New System.Windows.Forms.Button()
        Me.cmd040603 = New System.Windows.Forms.Button()
        Me.cmd040604 = New System.Windows.Forms.Button()
        Me.cmd040601 = New System.Windows.Forms.Button()
        Me.cmd040302 = New System.Windows.Forms.Button()
        Me.cmd040301 = New System.Windows.Forms.Button()
        Me.cmd040202 = New System.Windows.Forms.Button()
        Me.cmd040201 = New System.Windows.Forms.Button()
        Me.cmd040102 = New System.Windows.Forms.Button()
        Me.cmd040103 = New System.Windows.Forms.Button()
        Me.cmd040101 = New System.Windows.Forms.Button()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.cmd050806 = New System.Windows.Forms.Button()
        Me.cmd050805 = New System.Windows.Forms.Button()
        Me.cmd050804 = New System.Windows.Forms.Button()
        Me.cmd050803 = New System.Windows.Forms.Button()
        Me.cmd050706 = New System.Windows.Forms.Button()
        Me.cmd050703 = New System.Windows.Forms.Button()
        Me.cmd050701 = New System.Windows.Forms.Button()
        Me.cmd050606 = New System.Windows.Forms.Button()
        Me.cmd050603 = New System.Windows.Forms.Button()
        Me.cmd050506 = New System.Windows.Forms.Button()
        Me.cmd050503 = New System.Windows.Forms.Button()
        Me.cmd050406 = New System.Windows.Forms.Button()
        Me.cmd050405 = New System.Windows.Forms.Button()
        Me.cmd050404 = New System.Windows.Forms.Button()
        Me.cmd050403 = New System.Windows.Forms.Button()
        Me.cmd050402 = New System.Windows.Forms.Button()
        Me.cmd050401 = New System.Windows.Forms.Button()
        Me.cmd050305 = New System.Windows.Forms.Button()
        Me.cmd050304 = New System.Windows.Forms.Button()
        Me.cmd050303 = New System.Windows.Forms.Button()
        Me.cmd050205 = New System.Windows.Forms.Button()
        Me.cmd050204 = New System.Windows.Forms.Button()
        Me.cmd050203 = New System.Windows.Forms.Button()
        Me.cmd050105 = New System.Windows.Forms.Button()
        Me.cmd050104 = New System.Windows.Forms.Button()
        Me.cmd050206 = New System.Windows.Forms.Button()
        Me.cmd050306 = New System.Windows.Forms.Button()
        Me.cmd050106 = New System.Windows.Forms.Button()
        Me.cmd050802 = New System.Windows.Forms.Button()
        Me.cmd050801 = New System.Windows.Forms.Button()
        Me.cmd050702 = New System.Windows.Forms.Button()
        Me.cmd050704 = New System.Windows.Forms.Button()
        Me.cmd050705 = New System.Windows.Forms.Button()
        Me.cmd050602 = New System.Windows.Forms.Button()
        Me.cmd050604 = New System.Windows.Forms.Button()
        Me.cmd050605 = New System.Windows.Forms.Button()
        Me.cmd050601 = New System.Windows.Forms.Button()
        Me.cmd050502 = New System.Windows.Forms.Button()
        Me.cmd050504 = New System.Windows.Forms.Button()
        Me.cmd050505 = New System.Windows.Forms.Button()
        Me.cmd050501 = New System.Windows.Forms.Button()
        Me.cmd050302 = New System.Windows.Forms.Button()
        Me.cmd050301 = New System.Windows.Forms.Button()
        Me.cmd050202 = New System.Windows.Forms.Button()
        Me.cmd050201 = New System.Windows.Forms.Button()
        Me.cmd050102 = New System.Windows.Forms.Button()
        Me.cmd050103 = New System.Windows.Forms.Button()
        Me.cmd050101 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.cmd060806 = New System.Windows.Forms.Button()
        Me.cmd060805 = New System.Windows.Forms.Button()
        Me.cmd060804 = New System.Windows.Forms.Button()
        Me.cmd060803 = New System.Windows.Forms.Button()
        Me.cmd060802 = New System.Windows.Forms.Button()
        Me.cmd060706 = New System.Windows.Forms.Button()
        Me.cmd060705 = New System.Windows.Forms.Button()
        Me.cmd060703 = New System.Windows.Forms.Button()
        Me.cmd060702 = New System.Windows.Forms.Button()
        Me.cmd060704 = New System.Windows.Forms.Button()
        Me.cmd060606 = New System.Windows.Forms.Button()
        Me.cmd060605 = New System.Windows.Forms.Button()
        Me.cmd060604 = New System.Windows.Forms.Button()
        Me.cmd060603 = New System.Windows.Forms.Button()
        Me.cmd060506 = New System.Windows.Forms.Button()
        Me.cmd060505 = New System.Windows.Forms.Button()
        Me.cmd060504 = New System.Windows.Forms.Button()
        Me.cmd060503 = New System.Windows.Forms.Button()
        Me.cmd060406 = New System.Windows.Forms.Button()
        Me.cmd060405 = New System.Windows.Forms.Button()
        Me.cmd060404 = New System.Windows.Forms.Button()
        Me.cmd060403 = New System.Windows.Forms.Button()
        Me.cmd060306 = New System.Windows.Forms.Button()
        Me.cmd060305 = New System.Windows.Forms.Button()
        Me.cmd060304 = New System.Windows.Forms.Button()
        Me.cmd060303 = New System.Windows.Forms.Button()
        Me.cmd060302 = New System.Windows.Forms.Button()
        Me.cmd060206 = New System.Windows.Forms.Button()
        Me.cmd060205 = New System.Windows.Forms.Button()
        Me.cmd060204 = New System.Windows.Forms.Button()
        Me.cmd060203 = New System.Windows.Forms.Button()
        Me.cmd060202 = New System.Windows.Forms.Button()
        Me.cmd060106 = New System.Windows.Forms.Button()
        Me.cmd060105 = New System.Windows.Forms.Button()
        Me.cmd060104 = New System.Windows.Forms.Button()
        Me.cmd060103 = New System.Windows.Forms.Button()
        Me.cmd060801 = New System.Windows.Forms.Button()
        Me.cmd060701 = New System.Windows.Forms.Button()
        Me.cmd060602 = New System.Windows.Forms.Button()
        Me.cmd060601 = New System.Windows.Forms.Button()
        Me.cmd060502 = New System.Windows.Forms.Button()
        Me.cmd060501 = New System.Windows.Forms.Button()
        Me.cmd060402 = New System.Windows.Forms.Button()
        Me.cmd060401 = New System.Windows.Forms.Button()
        Me.cmd060301 = New System.Windows.Forms.Button()
        Me.cmd060201 = New System.Windows.Forms.Button()
        Me.cmd060102 = New System.Windows.Forms.Button()
        Me.cmd060101 = New System.Windows.Forms.Button()
        Me.cmdFoods = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCustomBar = New System.Windows.Forms.Button()
        Me.bar056 = New System.Windows.Forms.Button()
        Me.bar023 = New System.Windows.Forms.Button()
        Me.bar026 = New System.Windows.Forms.Button()
        Me.bar055 = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.bar054 = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.bar053 = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.bar029 = New System.Windows.Forms.Button()
        Me.bar032 = New System.Windows.Forms.Button()
        Me.bar031 = New System.Windows.Forms.Button()
        Me.bar030 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.bar022 = New System.Windows.Forms.Button()
        Me.bar021 = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.bar025 = New System.Windows.Forms.Button()
        Me.bar024 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bar052 = New System.Windows.Forms.Button()
        Me.bar051 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bar028 = New System.Windows.Forms.Button()
        Me.bar050 = New System.Windows.Forms.Button()
        Me.bar049 = New System.Windows.Forms.Button()
        Me.bar048 = New System.Windows.Forms.Button()
        Me.bar047 = New System.Windows.Forms.Button()
        Me.bar046 = New System.Windows.Forms.Button()
        Me.bar045 = New System.Windows.Forms.Button()
        Me.bar044 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.bar043 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.bar042 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.bar041 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.bar040 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.bar039 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.bar038 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.bar037 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.bar034 = New System.Windows.Forms.Button()
        Me.bar033 = New System.Windows.Forms.Button()
        Me.bar036 = New System.Windows.Forms.Button()
        Me.bar035 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.bar027 = New System.Windows.Forms.Button()
        Me.bar019 = New System.Windows.Forms.Button()
        Me.bar020 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bar018 = New System.Windows.Forms.Button()
        Me.bar017 = New System.Windows.Forms.Button()
        Me.bar016 = New System.Windows.Forms.Button()
        Me.bar015 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bar014 = New System.Windows.Forms.Button()
        Me.bar013 = New System.Windows.Forms.Button()
        Me.bar012 = New System.Windows.Forms.Button()
        Me.bar011 = New System.Windows.Forms.Button()
        Me.bar005 = New System.Windows.Forms.Button()
        Me.bar010 = New System.Windows.Forms.Button()
        Me.bar009 = New System.Windows.Forms.Button()
        Me.bar008 = New System.Windows.Forms.Button()
        Me.bar007 = New System.Windows.Forms.Button()
        Me.bar006 = New System.Windows.Forms.Button()
        Me.bar002 = New System.Windows.Forms.Button()
        Me.bar001 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bar004 = New System.Windows.Forms.Button()
        Me.bar003 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdMessage = New System.Windows.Forms.Button()
        Me.cmdCloseTable = New System.Windows.Forms.Button()
        Me.cmdMisc = New System.Windows.Forms.Button()
        Me.cmdQuickSale = New System.Windows.Forms.Button()
        Me.cmdTwo = New System.Windows.Forms.Button()
        Me.cmdThree = New System.Windows.Forms.Button()
        Me.cmdFour = New System.Windows.Forms.Button()
        Me.cmdFive = New System.Windows.Forms.Button()
        Me.cmdOne = New System.Windows.Forms.Button()
        Me.cmdSeatStool = New System.Windows.Forms.Button()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdCustom = New System.Windows.Forms.Button()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.guest4 = New System.Windows.Forms.Button()
        Me.guest5 = New System.Windows.Forms.Button()
        Me.guest6 = New System.Windows.Forms.Button()
        Me.guest7 = New System.Windows.Forms.Button()
        Me.guest8 = New System.Windows.Forms.Button()
        Me.cmdDrinks = New System.Windows.Forms.Button()
        Me.lblTotals = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdServer
        '
        Me.cmdServer.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServer.Location = New System.Drawing.Point(1008, 680)
        Me.cmdServer.Name = "cmdServer"
        Me.cmdServer.Size = New System.Drawing.Size(248, 48)
        Me.cmdServer.TabIndex = 1
        Me.cmdServer.Text = "Select Table"
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(16, 580)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(184, 96)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "Exit"
        '
        'lblTable
        '
        Me.lblTable.BackColor = System.Drawing.Color.Transparent
        Me.lblTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTable.Location = New System.Drawing.Point(992, 12)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(280, 69)
        Me.lblTable.TabIndex = 4
        Me.lblTable.Text = "Select a Table"
        Me.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdRemoveItem
        '
        Me.cmdRemoveItem.Location = New System.Drawing.Point(840, 576)
        Me.cmdRemoveItem.Name = "cmdRemoveItem"
        Me.cmdRemoveItem.Size = New System.Drawing.Size(136, 48)
        Me.cmdRemoveItem.TabIndex = 9
        Me.cmdRemoveItem.Text = "Remove Item"
        '
        'cmdRemoveTable
        '
        Me.cmdRemoveTable.Location = New System.Drawing.Point(840, 628)
        Me.cmdRemoveTable.Name = "cmdRemoveTable"
        Me.cmdRemoveTable.Size = New System.Drawing.Size(136, 48)
        Me.cmdRemoveTable.TabIndex = 10
        Me.cmdRemoveTable.Text = "Remove Table"
        '
        'guest1
        '
        Me.guest1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest1.Location = New System.Drawing.Point(1224, 137)
        Me.guest1.Name = "guest1"
        Me.guest1.Size = New System.Drawing.Size(56, 48)
        Me.guest1.TabIndex = 11
        Me.guest1.Tag = "1"
        Me.guest1.Text = "1"
        Me.guest1.Visible = False
        '
        'guest2
        '
        Me.guest2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest2.Location = New System.Drawing.Point(1224, 191)
        Me.guest2.Name = "guest2"
        Me.guest2.Size = New System.Drawing.Size(56, 48)
        Me.guest2.TabIndex = 12
        Me.guest2.Tag = "2"
        Me.guest2.Text = "2"
        Me.guest2.Visible = False
        '
        'guest3
        '
        Me.guest3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest3.Location = New System.Drawing.Point(1224, 245)
        Me.guest3.Name = "guest3"
        Me.guest3.Size = New System.Drawing.Size(56, 48)
        Me.guest3.TabIndex = 13
        Me.guest3.Tag = "3"
        Me.guest3.Text = "3"
        Me.guest3.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(200, 28)
        Me.TabControl1.Location = New System.Drawing.Point(16, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(15, 5)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(960, 536)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.cmd010804)
        Me.TabPage1.Controls.Add(Me.cmd010705)
        Me.TabPage1.Controls.Add(Me.cmd010605)
        Me.TabPage1.Controls.Add(Me.cmd010604)
        Me.TabPage1.Controls.Add(Me.cmd010505)
        Me.TabPage1.Controls.Add(Me.cmd010504)
        Me.TabPage1.Controls.Add(Me.cmd010503)
        Me.TabPage1.Controls.Add(Me.cmd010405)
        Me.TabPage1.Controls.Add(Me.cmd010404)
        Me.TabPage1.Controls.Add(Me.cmd010403)
        Me.TabPage1.Controls.Add(Me.cmd010402)
        Me.TabPage1.Controls.Add(Me.cmd010401)
        Me.TabPage1.Controls.Add(Me.cmd010205)
        Me.TabPage1.Controls.Add(Me.cmd010204)
        Me.TabPage1.Controls.Add(Me.cmd010203)
        Me.TabPage1.Controls.Add(Me.cmd010202)
        Me.TabPage1.Controls.Add(Me.cmd010603)
        Me.TabPage1.Controls.Add(Me.cmd010805)
        Me.TabPage1.Controls.Add(Me.cmd010806)
        Me.TabPage1.Controls.Add(Me.cmd010606)
        Me.TabPage1.Controls.Add(Me.cmd010506)
        Me.TabPage1.Controls.Add(Me.cmd010406)
        Me.TabPage1.Controls.Add(Me.cmd010706)
        Me.TabPage1.Controls.Add(Me.cmd010802)
        Me.TabPage1.Controls.Add(Me.cmd010803)
        Me.TabPage1.Controls.Add(Me.cmd010801)
        Me.TabPage1.Controls.Add(Me.cmd010702)
        Me.TabPage1.Controls.Add(Me.cmd010703)
        Me.TabPage1.Controls.Add(Me.cmd010704)
        Me.TabPage1.Controls.Add(Me.cmd010701)
        Me.TabPage1.Controls.Add(Me.cmd010602)
        Me.TabPage1.Controls.Add(Me.cmd010601)
        Me.TabPage1.Controls.Add(Me.cmd010502)
        Me.TabPage1.Controls.Add(Me.cmd010501)
        Me.TabPage1.Controls.Add(Me.cmd010302)
        Me.TabPage1.Controls.Add(Me.cmd010303)
        Me.TabPage1.Controls.Add(Me.cmd010304)
        Me.TabPage1.Controls.Add(Me.cmd010305)
        Me.TabPage1.Controls.Add(Me.cmd010301)
        Me.TabPage1.Controls.Add(Me.cmd010201)
        Me.TabPage1.Controls.Add(Me.cmd010206)
        Me.TabPage1.Controls.Add(Me.cmd010306)
        Me.TabPage1.Controls.Add(Me.cmd010106)
        Me.TabPage1.Controls.Add(Me.cmd010102)
        Me.TabPage1.Controls.Add(Me.cmd010103)
        Me.TabPage1.Controls.Add(Me.cmd010104)
        Me.TabPage1.Controls.Add(Me.cmd010105)
        Me.TabPage1.Controls.Add(Me.cmd010101)
        Me.TabPage1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(952, 500)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Steaks/Chops"
        '
        'cmd010804
        '
        Me.cmd010804.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010804.Location = New System.Drawing.Point(836, 256)
        Me.cmd010804.Name = "cmd010804"
        Me.cmd010804.Size = New System.Drawing.Size(96, 64)
        Me.cmd010804.TabIndex = 129
        Me.cmd010804.Tag = ""
        Me.cmd010804.Visible = False
        '
        'cmd010705
        '
        Me.cmd010705.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010705.Location = New System.Drawing.Point(719, 336)
        Me.cmd010705.Name = "cmd010705"
        Me.cmd010705.Size = New System.Drawing.Size(96, 64)
        Me.cmd010705.TabIndex = 128
        Me.cmd010705.Tag = ""
        Me.cmd010705.Visible = False
        '
        'cmd010605
        '
        Me.cmd010605.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010605.Location = New System.Drawing.Point(602, 336)
        Me.cmd010605.Name = "cmd010605"
        Me.cmd010605.Size = New System.Drawing.Size(96, 64)
        Me.cmd010605.TabIndex = 127
        Me.cmd010605.Tag = ""
        Me.cmd010605.Visible = False
        '
        'cmd010604
        '
        Me.cmd010604.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010604.Location = New System.Drawing.Point(602, 256)
        Me.cmd010604.Name = "cmd010604"
        Me.cmd010604.Size = New System.Drawing.Size(96, 64)
        Me.cmd010604.TabIndex = 126
        Me.cmd010604.Tag = ""
        Me.cmd010604.Visible = False
        '
        'cmd010505
        '
        Me.cmd010505.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010505.Location = New System.Drawing.Point(485, 336)
        Me.cmd010505.Name = "cmd010505"
        Me.cmd010505.Size = New System.Drawing.Size(96, 64)
        Me.cmd010505.TabIndex = 125
        Me.cmd010505.Tag = ""
        Me.cmd010505.Visible = False
        '
        'cmd010504
        '
        Me.cmd010504.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010504.Location = New System.Drawing.Point(485, 256)
        Me.cmd010504.Name = "cmd010504"
        Me.cmd010504.Size = New System.Drawing.Size(96, 64)
        Me.cmd010504.TabIndex = 124
        Me.cmd010504.Tag = ""
        Me.cmd010504.Visible = False
        '
        'cmd010503
        '
        Me.cmd010503.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010503.Location = New System.Drawing.Point(485, 176)
        Me.cmd010503.Name = "cmd010503"
        Me.cmd010503.Size = New System.Drawing.Size(96, 64)
        Me.cmd010503.TabIndex = 123
        Me.cmd010503.Tag = ""
        Me.cmd010503.Visible = False
        '
        'cmd010405
        '
        Me.cmd010405.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010405.Location = New System.Drawing.Point(368, 336)
        Me.cmd010405.Name = "cmd010405"
        Me.cmd010405.Size = New System.Drawing.Size(96, 64)
        Me.cmd010405.TabIndex = 122
        Me.cmd010405.Tag = ""
        Me.cmd010405.Visible = False
        '
        'cmd010404
        '
        Me.cmd010404.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010404.Location = New System.Drawing.Point(368, 256)
        Me.cmd010404.Name = "cmd010404"
        Me.cmd010404.Size = New System.Drawing.Size(96, 64)
        Me.cmd010404.TabIndex = 121
        Me.cmd010404.Tag = ""
        Me.cmd010404.Visible = False
        '
        'cmd010403
        '
        Me.cmd010403.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010403.Location = New System.Drawing.Point(368, 176)
        Me.cmd010403.Name = "cmd010403"
        Me.cmd010403.Size = New System.Drawing.Size(96, 64)
        Me.cmd010403.TabIndex = 120
        Me.cmd010403.Tag = ""
        Me.cmd010403.Visible = False
        '
        'cmd010402
        '
        Me.cmd010402.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010402.Location = New System.Drawing.Point(368, 96)
        Me.cmd010402.Name = "cmd010402"
        Me.cmd010402.Size = New System.Drawing.Size(96, 64)
        Me.cmd010402.TabIndex = 119
        Me.cmd010402.Tag = ""
        Me.cmd010402.Visible = False
        '
        'cmd010401
        '
        Me.cmd010401.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010401.Location = New System.Drawing.Point(368, 16)
        Me.cmd010401.Name = "cmd010401"
        Me.cmd010401.Size = New System.Drawing.Size(96, 64)
        Me.cmd010401.TabIndex = 118
        Me.cmd010401.Tag = ""
        Me.cmd010401.Visible = False
        '
        'cmd010205
        '
        Me.cmd010205.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010205.Location = New System.Drawing.Point(134, 336)
        Me.cmd010205.Name = "cmd010205"
        Me.cmd010205.Size = New System.Drawing.Size(96, 64)
        Me.cmd010205.TabIndex = 117
        Me.cmd010205.Tag = ""
        Me.cmd010205.Visible = False
        '
        'cmd010204
        '
        Me.cmd010204.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010204.Location = New System.Drawing.Point(134, 256)
        Me.cmd010204.Name = "cmd010204"
        Me.cmd010204.Size = New System.Drawing.Size(96, 64)
        Me.cmd010204.TabIndex = 116
        Me.cmd010204.Tag = ""
        Me.cmd010204.Visible = False
        '
        'cmd010203
        '
        Me.cmd010203.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010203.Location = New System.Drawing.Point(134, 176)
        Me.cmd010203.Name = "cmd010203"
        Me.cmd010203.Size = New System.Drawing.Size(96, 64)
        Me.cmd010203.TabIndex = 115
        Me.cmd010203.Tag = ""
        Me.cmd010203.Visible = False
        '
        'cmd010202
        '
        Me.cmd010202.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010202.Location = New System.Drawing.Point(134, 96)
        Me.cmd010202.Name = "cmd010202"
        Me.cmd010202.Size = New System.Drawing.Size(96, 64)
        Me.cmd010202.TabIndex = 114
        Me.cmd010202.Tag = ""
        Me.cmd010202.Visible = False
        '
        'cmd010603
        '
        Me.cmd010603.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010603.Image = CType(resources.GetObject("cmd010603.Image"), System.Drawing.Image)
        Me.cmd010603.Location = New System.Drawing.Point(602, 176)
        Me.cmd010603.Name = "cmd010603"
        Me.cmd010603.Size = New System.Drawing.Size(96, 64)
        Me.cmd010603.TabIndex = 113
        Me.cmd010603.Tag = "itm140"
        Me.cmd010603.Visible = False
        '
        'cmd010805
        '
        Me.cmd010805.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010805.Image = CType(resources.GetObject("cmd010805.Image"), System.Drawing.Image)
        Me.cmd010805.Location = New System.Drawing.Point(836, 336)
        Me.cmd010805.Name = "cmd010805"
        Me.cmd010805.Size = New System.Drawing.Size(96, 64)
        Me.cmd010805.TabIndex = 112
        Me.cmd010805.Tag = ""
        Me.cmd010805.Visible = False
        '
        'cmd010806
        '
        Me.cmd010806.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010806.Image = CType(resources.GetObject("cmd010806.Image"), System.Drawing.Image)
        Me.cmd010806.Location = New System.Drawing.Point(836, 416)
        Me.cmd010806.Name = "cmd010806"
        Me.cmd010806.Size = New System.Drawing.Size(96, 64)
        Me.cmd010806.TabIndex = 111
        Me.cmd010806.Tag = ""
        Me.cmd010806.Visible = False
        '
        'cmd010606
        '
        Me.cmd010606.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010606.Image = CType(resources.GetObject("cmd010606.Image"), System.Drawing.Image)
        Me.cmd010606.Location = New System.Drawing.Point(602, 416)
        Me.cmd010606.Name = "cmd010606"
        Me.cmd010606.Size = New System.Drawing.Size(96, 64)
        Me.cmd010606.TabIndex = 110
        Me.cmd010606.Tag = ""
        Me.cmd010606.Visible = False
        '
        'cmd010506
        '
        Me.cmd010506.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010506.Image = CType(resources.GetObject("cmd010506.Image"), System.Drawing.Image)
        Me.cmd010506.Location = New System.Drawing.Point(485, 416)
        Me.cmd010506.Name = "cmd010506"
        Me.cmd010506.Size = New System.Drawing.Size(96, 64)
        Me.cmd010506.TabIndex = 109
        Me.cmd010506.Tag = ""
        Me.cmd010506.Visible = False
        '
        'cmd010406
        '
        Me.cmd010406.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010406.Image = CType(resources.GetObject("cmd010406.Image"), System.Drawing.Image)
        Me.cmd010406.Location = New System.Drawing.Point(368, 416)
        Me.cmd010406.Name = "cmd010406"
        Me.cmd010406.Size = New System.Drawing.Size(96, 64)
        Me.cmd010406.TabIndex = 108
        Me.cmd010406.Tag = ""
        Me.cmd010406.Visible = False
        '
        'cmd010706
        '
        Me.cmd010706.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010706.Image = CType(resources.GetObject("cmd010706.Image"), System.Drawing.Image)
        Me.cmd010706.Location = New System.Drawing.Point(719, 416)
        Me.cmd010706.Name = "cmd010706"
        Me.cmd010706.Size = New System.Drawing.Size(96, 64)
        Me.cmd010706.TabIndex = 107
        Me.cmd010706.Tag = ""
        Me.cmd010706.Visible = False
        '
        'cmd010802
        '
        Me.cmd010802.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010802.Image = CType(resources.GetObject("cmd010802.Image"), System.Drawing.Image)
        Me.cmd010802.Location = New System.Drawing.Point(836, 96)
        Me.cmd010802.Name = "cmd010802"
        Me.cmd010802.Size = New System.Drawing.Size(96, 64)
        Me.cmd010802.TabIndex = 106
        Me.cmd010802.Tag = "itm009"
        Me.cmd010802.Visible = False
        '
        'cmd010803
        '
        Me.cmd010803.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010803.Image = CType(resources.GetObject("cmd010803.Image"), System.Drawing.Image)
        Me.cmd010803.Location = New System.Drawing.Point(836, 176)
        Me.cmd010803.Name = "cmd010803"
        Me.cmd010803.Size = New System.Drawing.Size(96, 64)
        Me.cmd010803.TabIndex = 105
        Me.cmd010803.Tag = "itm010"
        Me.cmd010803.Visible = False
        '
        'cmd010801
        '
        Me.cmd010801.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010801.Image = CType(resources.GetObject("cmd010801.Image"), System.Drawing.Image)
        Me.cmd010801.Location = New System.Drawing.Point(836, 16)
        Me.cmd010801.Name = "cmd010801"
        Me.cmd010801.Size = New System.Drawing.Size(96, 64)
        Me.cmd010801.TabIndex = 102
        Me.cmd010801.Tag = "itm008"
        Me.cmd010801.Visible = False
        '
        'cmd010702
        '
        Me.cmd010702.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010702.Image = CType(resources.GetObject("cmd010702.Image"), System.Drawing.Image)
        Me.cmd010702.Location = New System.Drawing.Point(719, 96)
        Me.cmd010702.Name = "cmd010702"
        Me.cmd010702.Size = New System.Drawing.Size(96, 64)
        Me.cmd010702.TabIndex = 101
        Me.cmd010702.Tag = "itm019"
        Me.cmd010702.Visible = False
        '
        'cmd010703
        '
        Me.cmd010703.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010703.Image = CType(resources.GetObject("cmd010703.Image"), System.Drawing.Image)
        Me.cmd010703.Location = New System.Drawing.Point(719, 176)
        Me.cmd010703.Name = "cmd010703"
        Me.cmd010703.Size = New System.Drawing.Size(96, 64)
        Me.cmd010703.TabIndex = 100
        Me.cmd010703.Tag = "itm025"
        Me.cmd010703.Visible = False
        '
        'cmd010704
        '
        Me.cmd010704.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010704.Location = New System.Drawing.Point(719, 256)
        Me.cmd010704.Name = "cmd010704"
        Me.cmd010704.Size = New System.Drawing.Size(96, 64)
        Me.cmd010704.TabIndex = 99
        Me.cmd010704.Tag = "itm023"
        Me.cmd010704.Visible = False
        '
        'cmd010701
        '
        Me.cmd010701.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010701.Image = CType(resources.GetObject("cmd010701.Image"), System.Drawing.Image)
        Me.cmd010701.Location = New System.Drawing.Point(719, 16)
        Me.cmd010701.Name = "cmd010701"
        Me.cmd010701.Size = New System.Drawing.Size(96, 64)
        Me.cmd010701.TabIndex = 97
        Me.cmd010701.Tag = "itm018"
        Me.cmd010701.Visible = False
        '
        'cmd010602
        '
        Me.cmd010602.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010602.Image = CType(resources.GetObject("cmd010602.Image"), System.Drawing.Image)
        Me.cmd010602.Location = New System.Drawing.Point(602, 96)
        Me.cmd010602.Name = "cmd010602"
        Me.cmd010602.Size = New System.Drawing.Size(96, 64)
        Me.cmd010602.TabIndex = 96
        Me.cmd010602.Tag = "itm014"
        Me.cmd010602.Visible = False
        '
        'cmd010601
        '
        Me.cmd010601.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010601.Image = CType(resources.GetObject("cmd010601.Image"), System.Drawing.Image)
        Me.cmd010601.Location = New System.Drawing.Point(602, 16)
        Me.cmd010601.Name = "cmd010601"
        Me.cmd010601.Size = New System.Drawing.Size(96, 64)
        Me.cmd010601.TabIndex = 92
        Me.cmd010601.Tag = "itm013"
        Me.cmd010601.Visible = False
        '
        'cmd010502
        '
        Me.cmd010502.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010502.Image = CType(resources.GetObject("cmd010502.Image"), System.Drawing.Image)
        Me.cmd010502.Location = New System.Drawing.Point(485, 96)
        Me.cmd010502.Name = "cmd010502"
        Me.cmd010502.Size = New System.Drawing.Size(96, 64)
        Me.cmd010502.TabIndex = 91
        Me.cmd010502.Tag = "itm012"
        Me.cmd010502.Visible = False
        '
        'cmd010501
        '
        Me.cmd010501.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010501.Image = CType(resources.GetObject("cmd010501.Image"), System.Drawing.Image)
        Me.cmd010501.Location = New System.Drawing.Point(485, 16)
        Me.cmd010501.Name = "cmd010501"
        Me.cmd010501.Size = New System.Drawing.Size(96, 64)
        Me.cmd010501.TabIndex = 87
        Me.cmd010501.Tag = "itm011"
        Me.cmd010501.Visible = False
        '
        'cmd010302
        '
        Me.cmd010302.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010302.Location = New System.Drawing.Point(251, 96)
        Me.cmd010302.Name = "cmd010302"
        Me.cmd010302.Size = New System.Drawing.Size(96, 64)
        Me.cmd010302.TabIndex = 81
        Me.cmd010302.Tag = "itm020"
        Me.cmd010302.Visible = False
        '
        'cmd010303
        '
        Me.cmd010303.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010303.Image = CType(resources.GetObject("cmd010303.Image"), System.Drawing.Image)
        Me.cmd010303.Location = New System.Drawing.Point(251, 176)
        Me.cmd010303.Name = "cmd010303"
        Me.cmd010303.Size = New System.Drawing.Size(96, 64)
        Me.cmd010303.TabIndex = 80
        Me.cmd010303.Tag = "itm021"
        Me.cmd010303.Visible = False
        '
        'cmd010304
        '
        Me.cmd010304.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010304.Image = CType(resources.GetObject("cmd010304.Image"), System.Drawing.Image)
        Me.cmd010304.Location = New System.Drawing.Point(251, 256)
        Me.cmd010304.Name = "cmd010304"
        Me.cmd010304.Size = New System.Drawing.Size(96, 64)
        Me.cmd010304.TabIndex = 79
        Me.cmd010304.Tag = "itm022"
        Me.cmd010304.Visible = False
        '
        'cmd010305
        '
        Me.cmd010305.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010305.Image = CType(resources.GetObject("cmd010305.Image"), System.Drawing.Image)
        Me.cmd010305.Location = New System.Drawing.Point(251, 336)
        Me.cmd010305.Name = "cmd010305"
        Me.cmd010305.Size = New System.Drawing.Size(96, 64)
        Me.cmd010305.TabIndex = 78
        Me.cmd010305.Tag = "itm024"
        Me.cmd010305.Visible = False
        '
        'cmd010301
        '
        Me.cmd010301.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010301.Image = CType(resources.GetObject("cmd010301.Image"), System.Drawing.Image)
        Me.cmd010301.Location = New System.Drawing.Point(251, 16)
        Me.cmd010301.Name = "cmd010301"
        Me.cmd010301.Size = New System.Drawing.Size(96, 64)
        Me.cmd010301.TabIndex = 77
        Me.cmd010301.Tag = "itm003"
        Me.cmd010301.Visible = False
        '
        'cmd010201
        '
        Me.cmd010201.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010201.Image = CType(resources.GetObject("cmd010201.Image"), System.Drawing.Image)
        Me.cmd010201.Location = New System.Drawing.Point(134, 16)
        Me.cmd010201.Name = "cmd010201"
        Me.cmd010201.Size = New System.Drawing.Size(96, 64)
        Me.cmd010201.TabIndex = 72
        Me.cmd010201.Tag = "itm004"
        Me.cmd010201.Visible = False
        '
        'cmd010206
        '
        Me.cmd010206.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010206.Image = CType(resources.GetObject("cmd010206.Image"), System.Drawing.Image)
        Me.cmd010206.Location = New System.Drawing.Point(134, 416)
        Me.cmd010206.Name = "cmd010206"
        Me.cmd010206.Size = New System.Drawing.Size(96, 64)
        Me.cmd010206.TabIndex = 68
        Me.cmd010206.Tag = "itm016"
        Me.cmd010206.Visible = False
        '
        'cmd010306
        '
        Me.cmd010306.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010306.Image = CType(resources.GetObject("cmd010306.Image"), System.Drawing.Image)
        Me.cmd010306.Location = New System.Drawing.Point(251, 416)
        Me.cmd010306.Name = "cmd010306"
        Me.cmd010306.Size = New System.Drawing.Size(96, 64)
        Me.cmd010306.TabIndex = 67
        Me.cmd010306.Tag = "itm017"
        Me.cmd010306.Visible = False
        '
        'cmd010106
        '
        Me.cmd010106.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010106.Image = CType(resources.GetObject("cmd010106.Image"), System.Drawing.Image)
        Me.cmd010106.Location = New System.Drawing.Point(17, 416)
        Me.cmd010106.Name = "cmd010106"
        Me.cmd010106.Size = New System.Drawing.Size(96, 64)
        Me.cmd010106.TabIndex = 64
        Me.cmd010106.Tag = "itm015"
        Me.cmd010106.Visible = False
        '
        'cmd010102
        '
        Me.cmd010102.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010102.Image = CType(resources.GetObject("cmd010102.Image"), System.Drawing.Image)
        Me.cmd010102.Location = New System.Drawing.Point(17, 96)
        Me.cmd010102.Name = "cmd010102"
        Me.cmd010102.Size = New System.Drawing.Size(96, 64)
        Me.cmd010102.TabIndex = 63
        Me.cmd010102.Tag = "itm002"
        Me.cmd010102.Visible = False
        '
        'cmd010103
        '
        Me.cmd010103.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010103.Image = CType(resources.GetObject("cmd010103.Image"), System.Drawing.Image)
        Me.cmd010103.Location = New System.Drawing.Point(17, 176)
        Me.cmd010103.Name = "cmd010103"
        Me.cmd010103.Size = New System.Drawing.Size(96, 64)
        Me.cmd010103.TabIndex = 62
        Me.cmd010103.Tag = "itm005"
        Me.cmd010103.Visible = False
        '
        'cmd010104
        '
        Me.cmd010104.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010104.Image = CType(resources.GetObject("cmd010104.Image"), System.Drawing.Image)
        Me.cmd010104.Location = New System.Drawing.Point(17, 256)
        Me.cmd010104.Name = "cmd010104"
        Me.cmd010104.Size = New System.Drawing.Size(96, 64)
        Me.cmd010104.TabIndex = 61
        Me.cmd010104.Tag = "itm007"
        Me.cmd010104.Visible = False
        '
        'cmd010105
        '
        Me.cmd010105.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010105.Image = CType(resources.GetObject("cmd010105.Image"), System.Drawing.Image)
        Me.cmd010105.Location = New System.Drawing.Point(17, 336)
        Me.cmd010105.Name = "cmd010105"
        Me.cmd010105.Size = New System.Drawing.Size(96, 64)
        Me.cmd010105.TabIndex = 60
        Me.cmd010105.Tag = "itm006"
        Me.cmd010105.Visible = False
        '
        'cmd010101
        '
        Me.cmd010101.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd010101.Location = New System.Drawing.Point(17, 16)
        Me.cmd010101.Name = "cmd010101"
        Me.cmd010101.Size = New System.Drawing.Size(96, 64)
        Me.cmd010101.TabIndex = 59
        Me.cmd010101.Tag = "itm001"
        Me.cmd010101.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.cmd020804)
        Me.TabPage2.Controls.Add(Me.cmd020803)
        Me.TabPage2.Controls.Add(Me.cmd020705)
        Me.TabPage2.Controls.Add(Me.cmd020605)
        Me.TabPage2.Controls.Add(Me.cmd020505)
        Me.TabPage2.Controls.Add(Me.cmd020503)
        Me.TabPage2.Controls.Add(Me.cmd020405)
        Me.TabPage2.Controls.Add(Me.cmd020404)
        Me.TabPage2.Controls.Add(Me.cmd020305)
        Me.TabPage2.Controls.Add(Me.cmd020502)
        Me.TabPage2.Controls.Add(Me.cmd020402)
        Me.TabPage2.Controls.Add(Me.cmd020204)
        Me.TabPage2.Controls.Add(Me.cmd020202)
        Me.TabPage2.Controls.Add(Me.cmd020805)
        Me.TabPage2.Controls.Add(Me.cmd020806)
        Me.TabPage2.Controls.Add(Me.cmd020606)
        Me.TabPage2.Controls.Add(Me.cmd020506)
        Me.TabPage2.Controls.Add(Me.cmd020406)
        Me.TabPage2.Controls.Add(Me.cmd020706)
        Me.TabPage2.Controls.Add(Me.cmd020802)
        Me.TabPage2.Controls.Add(Me.cmd020801)
        Me.TabPage2.Controls.Add(Me.cmd020702)
        Me.TabPage2.Controls.Add(Me.cmd020703)
        Me.TabPage2.Controls.Add(Me.cmd020704)
        Me.TabPage2.Controls.Add(Me.cmd020701)
        Me.TabPage2.Controls.Add(Me.cmd020602)
        Me.TabPage2.Controls.Add(Me.cmd020603)
        Me.TabPage2.Controls.Add(Me.cmd020604)
        Me.TabPage2.Controls.Add(Me.cmd020601)
        Me.TabPage2.Controls.Add(Me.cmd020504)
        Me.TabPage2.Controls.Add(Me.cmd020501)
        Me.TabPage2.Controls.Add(Me.cmd020403)
        Me.TabPage2.Controls.Add(Me.cmd020401)
        Me.TabPage2.Controls.Add(Me.cmd020302)
        Me.TabPage2.Controls.Add(Me.cmd020303)
        Me.TabPage2.Controls.Add(Me.cmd020304)
        Me.TabPage2.Controls.Add(Me.cmd020301)
        Me.TabPage2.Controls.Add(Me.cmd020203)
        Me.TabPage2.Controls.Add(Me.cmd020205)
        Me.TabPage2.Controls.Add(Me.cmd020201)
        Me.TabPage2.Controls.Add(Me.cmd020206)
        Me.TabPage2.Controls.Add(Me.cmd020306)
        Me.TabPage2.Controls.Add(Me.cmd020106)
        Me.TabPage2.Controls.Add(Me.cmd020102)
        Me.TabPage2.Controls.Add(Me.cmd020103)
        Me.TabPage2.Controls.Add(Me.cmd020104)
        Me.TabPage2.Controls.Add(Me.cmd020105)
        Me.TabPage2.Controls.Add(Me.cmd020101)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(952, 500)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Fish/Seafood"
        '
        'cmd020804
        '
        Me.cmd020804.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020804.Location = New System.Drawing.Point(836, 256)
        Me.cmd020804.Name = "cmd020804"
        Me.cmd020804.Size = New System.Drawing.Size(96, 64)
        Me.cmd020804.TabIndex = 131
        Me.cmd020804.Tag = ""
        Me.cmd020804.Visible = False
        '
        'cmd020803
        '
        Me.cmd020803.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020803.Location = New System.Drawing.Point(836, 176)
        Me.cmd020803.Name = "cmd020803"
        Me.cmd020803.Size = New System.Drawing.Size(96, 64)
        Me.cmd020803.TabIndex = 130
        Me.cmd020803.Tag = ""
        Me.cmd020803.Visible = False
        '
        'cmd020705
        '
        Me.cmd020705.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020705.Location = New System.Drawing.Point(719, 336)
        Me.cmd020705.Name = "cmd020705"
        Me.cmd020705.Size = New System.Drawing.Size(96, 64)
        Me.cmd020705.TabIndex = 129
        Me.cmd020705.Tag = ""
        Me.cmd020705.Visible = False
        '
        'cmd020605
        '
        Me.cmd020605.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020605.Location = New System.Drawing.Point(602, 336)
        Me.cmd020605.Name = "cmd020605"
        Me.cmd020605.Size = New System.Drawing.Size(96, 64)
        Me.cmd020605.TabIndex = 128
        Me.cmd020605.Tag = ""
        Me.cmd020605.Visible = False
        '
        'cmd020505
        '
        Me.cmd020505.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020505.Location = New System.Drawing.Point(485, 336)
        Me.cmd020505.Name = "cmd020505"
        Me.cmd020505.Size = New System.Drawing.Size(96, 64)
        Me.cmd020505.TabIndex = 127
        Me.cmd020505.Tag = ""
        Me.cmd020505.Visible = False
        '
        'cmd020503
        '
        Me.cmd020503.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020503.Location = New System.Drawing.Point(485, 176)
        Me.cmd020503.Name = "cmd020503"
        Me.cmd020503.Size = New System.Drawing.Size(96, 64)
        Me.cmd020503.TabIndex = 126
        Me.cmd020503.Tag = ""
        Me.cmd020503.Visible = False
        '
        'cmd020405
        '
        Me.cmd020405.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020405.Location = New System.Drawing.Point(368, 336)
        Me.cmd020405.Name = "cmd020405"
        Me.cmd020405.Size = New System.Drawing.Size(96, 64)
        Me.cmd020405.TabIndex = 125
        Me.cmd020405.Tag = ""
        Me.cmd020405.Visible = False
        '
        'cmd020404
        '
        Me.cmd020404.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020404.Location = New System.Drawing.Point(368, 256)
        Me.cmd020404.Name = "cmd020404"
        Me.cmd020404.Size = New System.Drawing.Size(96, 64)
        Me.cmd020404.TabIndex = 124
        Me.cmd020404.Tag = ""
        Me.cmd020404.Visible = False
        '
        'cmd020305
        '
        Me.cmd020305.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020305.Location = New System.Drawing.Point(251, 336)
        Me.cmd020305.Name = "cmd020305"
        Me.cmd020305.Size = New System.Drawing.Size(96, 64)
        Me.cmd020305.TabIndex = 123
        Me.cmd020305.Tag = ""
        Me.cmd020305.Visible = False
        '
        'cmd020502
        '
        Me.cmd020502.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020502.Location = New System.Drawing.Point(485, 96)
        Me.cmd020502.Name = "cmd020502"
        Me.cmd020502.Size = New System.Drawing.Size(96, 64)
        Me.cmd020502.TabIndex = 122
        Me.cmd020502.Tag = ""
        Me.cmd020502.Visible = False
        '
        'cmd020402
        '
        Me.cmd020402.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020402.Location = New System.Drawing.Point(368, 96)
        Me.cmd020402.Name = "cmd020402"
        Me.cmd020402.Size = New System.Drawing.Size(96, 64)
        Me.cmd020402.TabIndex = 121
        Me.cmd020402.Tag = ""
        Me.cmd020402.Visible = False
        '
        'cmd020204
        '
        Me.cmd020204.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020204.Location = New System.Drawing.Point(134, 256)
        Me.cmd020204.Name = "cmd020204"
        Me.cmd020204.Size = New System.Drawing.Size(96, 64)
        Me.cmd020204.TabIndex = 120
        Me.cmd020204.Tag = ""
        Me.cmd020204.Visible = False
        '
        'cmd020202
        '
        Me.cmd020202.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020202.Location = New System.Drawing.Point(134, 96)
        Me.cmd020202.Name = "cmd020202"
        Me.cmd020202.Size = New System.Drawing.Size(96, 64)
        Me.cmd020202.TabIndex = 119
        Me.cmd020202.Tag = ""
        Me.cmd020202.Visible = False
        '
        'cmd020805
        '
        Me.cmd020805.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020805.Image = CType(resources.GetObject("cmd020805.Image"), System.Drawing.Image)
        Me.cmd020805.Location = New System.Drawing.Point(836, 336)
        Me.cmd020805.Name = "cmd020805"
        Me.cmd020805.Size = New System.Drawing.Size(96, 64)
        Me.cmd020805.TabIndex = 118
        Me.cmd020805.Tag = ""
        Me.cmd020805.Visible = False
        '
        'cmd020806
        '
        Me.cmd020806.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020806.Image = CType(resources.GetObject("cmd020806.Image"), System.Drawing.Image)
        Me.cmd020806.Location = New System.Drawing.Point(836, 416)
        Me.cmd020806.Name = "cmd020806"
        Me.cmd020806.Size = New System.Drawing.Size(96, 64)
        Me.cmd020806.TabIndex = 117
        Me.cmd020806.Tag = ""
        Me.cmd020806.Visible = False
        '
        'cmd020606
        '
        Me.cmd020606.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020606.Image = CType(resources.GetObject("cmd020606.Image"), System.Drawing.Image)
        Me.cmd020606.Location = New System.Drawing.Point(602, 416)
        Me.cmd020606.Name = "cmd020606"
        Me.cmd020606.Size = New System.Drawing.Size(96, 64)
        Me.cmd020606.TabIndex = 116
        Me.cmd020606.Tag = ""
        Me.cmd020606.Visible = False
        '
        'cmd020506
        '
        Me.cmd020506.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020506.Image = CType(resources.GetObject("cmd020506.Image"), System.Drawing.Image)
        Me.cmd020506.Location = New System.Drawing.Point(485, 416)
        Me.cmd020506.Name = "cmd020506"
        Me.cmd020506.Size = New System.Drawing.Size(96, 64)
        Me.cmd020506.TabIndex = 115
        Me.cmd020506.Tag = ""
        Me.cmd020506.Visible = False
        '
        'cmd020406
        '
        Me.cmd020406.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020406.Image = CType(resources.GetObject("cmd020406.Image"), System.Drawing.Image)
        Me.cmd020406.Location = New System.Drawing.Point(368, 416)
        Me.cmd020406.Name = "cmd020406"
        Me.cmd020406.Size = New System.Drawing.Size(96, 64)
        Me.cmd020406.TabIndex = 114
        Me.cmd020406.Tag = ""
        Me.cmd020406.Visible = False
        '
        'cmd020706
        '
        Me.cmd020706.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020706.Image = CType(resources.GetObject("cmd020706.Image"), System.Drawing.Image)
        Me.cmd020706.Location = New System.Drawing.Point(719, 416)
        Me.cmd020706.Name = "cmd020706"
        Me.cmd020706.Size = New System.Drawing.Size(96, 64)
        Me.cmd020706.TabIndex = 113
        Me.cmd020706.Tag = ""
        Me.cmd020706.Visible = False
        '
        'cmd020802
        '
        Me.cmd020802.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020802.Image = CType(resources.GetObject("cmd020802.Image"), System.Drawing.Image)
        Me.cmd020802.Location = New System.Drawing.Point(836, 96)
        Me.cmd020802.Name = "cmd020802"
        Me.cmd020802.Size = New System.Drawing.Size(96, 64)
        Me.cmd020802.TabIndex = 106
        Me.cmd020802.Tag = "itm029"
        Me.cmd020802.Visible = False
        '
        'cmd020801
        '
        Me.cmd020801.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020801.Image = CType(resources.GetObject("cmd020801.Image"), System.Drawing.Image)
        Me.cmd020801.Location = New System.Drawing.Point(836, 16)
        Me.cmd020801.Name = "cmd020801"
        Me.cmd020801.Size = New System.Drawing.Size(96, 64)
        Me.cmd020801.TabIndex = 102
        Me.cmd020801.Tag = "itm049"
        Me.cmd020801.Visible = False
        '
        'cmd020702
        '
        Me.cmd020702.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020702.Image = CType(resources.GetObject("cmd020702.Image"), System.Drawing.Image)
        Me.cmd020702.Location = New System.Drawing.Point(719, 96)
        Me.cmd020702.Name = "cmd020702"
        Me.cmd020702.Size = New System.Drawing.Size(96, 64)
        Me.cmd020702.TabIndex = 101
        Me.cmd020702.Tag = "itm046"
        Me.cmd020702.Visible = False
        '
        'cmd020703
        '
        Me.cmd020703.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020703.Image = CType(resources.GetObject("cmd020703.Image"), System.Drawing.Image)
        Me.cmd020703.Location = New System.Drawing.Point(719, 176)
        Me.cmd020703.Name = "cmd020703"
        Me.cmd020703.Size = New System.Drawing.Size(96, 64)
        Me.cmd020703.TabIndex = 100
        Me.cmd020703.Tag = "itm044"
        Me.cmd020703.Visible = False
        '
        'cmd020704
        '
        Me.cmd020704.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020704.Image = CType(resources.GetObject("cmd020704.Image"), System.Drawing.Image)
        Me.cmd020704.Location = New System.Drawing.Point(719, 256)
        Me.cmd020704.Name = "cmd020704"
        Me.cmd020704.Size = New System.Drawing.Size(96, 64)
        Me.cmd020704.TabIndex = 99
        Me.cmd020704.Tag = "itm023"
        Me.cmd020704.Visible = False
        '
        'cmd020701
        '
        Me.cmd020701.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020701.Image = CType(resources.GetObject("cmd020701.Image"), System.Drawing.Image)
        Me.cmd020701.Location = New System.Drawing.Point(719, 16)
        Me.cmd020701.Name = "cmd020701"
        Me.cmd020701.Size = New System.Drawing.Size(96, 64)
        Me.cmd020701.TabIndex = 97
        Me.cmd020701.Tag = "itm048"
        Me.cmd020701.Visible = False
        '
        'cmd020602
        '
        Me.cmd020602.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020602.Image = CType(resources.GetObject("cmd020602.Image"), System.Drawing.Image)
        Me.cmd020602.Location = New System.Drawing.Point(602, 96)
        Me.cmd020602.Name = "cmd020602"
        Me.cmd020602.Size = New System.Drawing.Size(96, 64)
        Me.cmd020602.TabIndex = 96
        Me.cmd020602.Tag = "itm045"
        Me.cmd020602.Visible = False
        '
        'cmd020603
        '
        Me.cmd020603.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020603.Image = CType(resources.GetObject("cmd020603.Image"), System.Drawing.Image)
        Me.cmd020603.Location = New System.Drawing.Point(602, 176)
        Me.cmd020603.Name = "cmd020603"
        Me.cmd020603.Size = New System.Drawing.Size(96, 64)
        Me.cmd020603.TabIndex = 95
        Me.cmd020603.Tag = "itm043"
        Me.cmd020603.Visible = False
        '
        'cmd020604
        '
        Me.cmd020604.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020604.Image = CType(resources.GetObject("cmd020604.Image"), System.Drawing.Image)
        Me.cmd020604.Location = New System.Drawing.Point(602, 256)
        Me.cmd020604.Name = "cmd020604"
        Me.cmd020604.Size = New System.Drawing.Size(96, 64)
        Me.cmd020604.TabIndex = 94
        Me.cmd020604.Tag = "itm035"
        Me.cmd020604.Visible = False
        '
        'cmd020601
        '
        Me.cmd020601.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020601.Image = CType(resources.GetObject("cmd020601.Image"), System.Drawing.Image)
        Me.cmd020601.Location = New System.Drawing.Point(602, 16)
        Me.cmd020601.Name = "cmd020601"
        Me.cmd020601.Size = New System.Drawing.Size(96, 64)
        Me.cmd020601.TabIndex = 92
        Me.cmd020601.Tag = "itm047"
        Me.cmd020601.Visible = False
        '
        'cmd020504
        '
        Me.cmd020504.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020504.Image = CType(resources.GetObject("cmd020504.Image"), System.Drawing.Image)
        Me.cmd020504.Location = New System.Drawing.Point(485, 256)
        Me.cmd020504.Name = "cmd020504"
        Me.cmd020504.Size = New System.Drawing.Size(96, 64)
        Me.cmd020504.TabIndex = 89
        Me.cmd020504.Tag = "itm050"
        Me.cmd020504.Visible = False
        '
        'cmd020501
        '
        Me.cmd020501.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020501.Image = CType(resources.GetObject("cmd020501.Image"), System.Drawing.Image)
        Me.cmd020501.Location = New System.Drawing.Point(485, 16)
        Me.cmd020501.Name = "cmd020501"
        Me.cmd020501.Size = New System.Drawing.Size(96, 64)
        Me.cmd020501.TabIndex = 87
        Me.cmd020501.Tag = "itm042"
        Me.cmd020501.Visible = False
        '
        'cmd020403
        '
        Me.cmd020403.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020403.Image = CType(resources.GetObject("cmd020403.Image"), System.Drawing.Image)
        Me.cmd020403.Location = New System.Drawing.Point(368, 176)
        Me.cmd020403.Name = "cmd020403"
        Me.cmd020403.Size = New System.Drawing.Size(96, 64)
        Me.cmd020403.TabIndex = 85
        Me.cmd020403.Tag = "itm040"
        Me.cmd020403.Visible = False
        '
        'cmd020401
        '
        Me.cmd020401.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020401.Image = CType(resources.GetObject("cmd020401.Image"), System.Drawing.Image)
        Me.cmd020401.Location = New System.Drawing.Point(368, 16)
        Me.cmd020401.Name = "cmd020401"
        Me.cmd020401.Size = New System.Drawing.Size(96, 64)
        Me.cmd020401.TabIndex = 82
        Me.cmd020401.Tag = "itm034"
        Me.cmd020401.Visible = False
        '
        'cmd020302
        '
        Me.cmd020302.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020302.Image = CType(resources.GetObject("cmd020302.Image"), System.Drawing.Image)
        Me.cmd020302.Location = New System.Drawing.Point(251, 96)
        Me.cmd020302.Name = "cmd020302"
        Me.cmd020302.Size = New System.Drawing.Size(96, 64)
        Me.cmd020302.TabIndex = 81
        Me.cmd020302.Tag = "itm036"
        Me.cmd020302.Visible = False
        '
        'cmd020303
        '
        Me.cmd020303.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020303.Image = CType(resources.GetObject("cmd020303.Image"), System.Drawing.Image)
        Me.cmd020303.Location = New System.Drawing.Point(251, 176)
        Me.cmd020303.Name = "cmd020303"
        Me.cmd020303.Size = New System.Drawing.Size(96, 64)
        Me.cmd020303.TabIndex = 80
        Me.cmd020303.Tag = "itm039"
        Me.cmd020303.Visible = False
        '
        'cmd020304
        '
        Me.cmd020304.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020304.Image = CType(resources.GetObject("cmd020304.Image"), System.Drawing.Image)
        Me.cmd020304.Location = New System.Drawing.Point(251, 256)
        Me.cmd020304.Name = "cmd020304"
        Me.cmd020304.Size = New System.Drawing.Size(96, 64)
        Me.cmd020304.TabIndex = 79
        Me.cmd020304.Tag = "itm041"
        Me.cmd020304.Visible = False
        '
        'cmd020301
        '
        Me.cmd020301.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020301.Image = CType(resources.GetObject("cmd020301.Image"), System.Drawing.Image)
        Me.cmd020301.Location = New System.Drawing.Point(251, 16)
        Me.cmd020301.Name = "cmd020301"
        Me.cmd020301.Size = New System.Drawing.Size(96, 64)
        Me.cmd020301.TabIndex = 77
        Me.cmd020301.Tag = "itm033"
        Me.cmd020301.Visible = False
        '
        'cmd020203
        '
        Me.cmd020203.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020203.Image = CType(resources.GetObject("cmd020203.Image"), System.Drawing.Image)
        Me.cmd020203.Location = New System.Drawing.Point(134, 176)
        Me.cmd020203.Name = "cmd020203"
        Me.cmd020203.Size = New System.Drawing.Size(96, 64)
        Me.cmd020203.TabIndex = 75
        Me.cmd020203.Tag = "itm031"
        Me.cmd020203.Visible = False
        '
        'cmd020205
        '
        Me.cmd020205.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020205.Image = CType(resources.GetObject("cmd020205.Image"), System.Drawing.Image)
        Me.cmd020205.Location = New System.Drawing.Point(134, 336)
        Me.cmd020205.Name = "cmd020205"
        Me.cmd020205.Size = New System.Drawing.Size(96, 64)
        Me.cmd020205.TabIndex = 73
        Me.cmd020205.Tag = "itm038"
        Me.cmd020205.Visible = False
        '
        'cmd020201
        '
        Me.cmd020201.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020201.Image = CType(resources.GetObject("cmd020201.Image"), System.Drawing.Image)
        Me.cmd020201.Location = New System.Drawing.Point(134, 16)
        Me.cmd020201.Name = "cmd020201"
        Me.cmd020201.Size = New System.Drawing.Size(96, 64)
        Me.cmd020201.TabIndex = 72
        Me.cmd020201.Tag = "itm027"
        Me.cmd020201.Visible = False
        '
        'cmd020206
        '
        Me.cmd020206.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020206.Image = CType(resources.GetObject("cmd020206.Image"), System.Drawing.Image)
        Me.cmd020206.Location = New System.Drawing.Point(134, 416)
        Me.cmd020206.Name = "cmd020206"
        Me.cmd020206.Size = New System.Drawing.Size(96, 64)
        Me.cmd020206.TabIndex = 68
        Me.cmd020206.Tag = "itm016"
        Me.cmd020206.Visible = False
        '
        'cmd020306
        '
        Me.cmd020306.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020306.Image = CType(resources.GetObject("cmd020306.Image"), System.Drawing.Image)
        Me.cmd020306.Location = New System.Drawing.Point(251, 416)
        Me.cmd020306.Name = "cmd020306"
        Me.cmd020306.Size = New System.Drawing.Size(96, 64)
        Me.cmd020306.TabIndex = 67
        Me.cmd020306.Tag = "itm017"
        Me.cmd020306.Visible = False
        '
        'cmd020106
        '
        Me.cmd020106.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020106.Image = CType(resources.GetObject("cmd020106.Image"), System.Drawing.Image)
        Me.cmd020106.Location = New System.Drawing.Point(17, 416)
        Me.cmd020106.Name = "cmd020106"
        Me.cmd020106.Size = New System.Drawing.Size(96, 64)
        Me.cmd020106.TabIndex = 64
        Me.cmd020106.Tag = "itm015"
        Me.cmd020106.Visible = False
        '
        'cmd020102
        '
        Me.cmd020102.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020102.Image = CType(resources.GetObject("cmd020102.Image"), System.Drawing.Image)
        Me.cmd020102.Location = New System.Drawing.Point(17, 96)
        Me.cmd020102.Name = "cmd020102"
        Me.cmd020102.Size = New System.Drawing.Size(96, 64)
        Me.cmd020102.TabIndex = 63
        Me.cmd020102.Tag = "itm028"
        Me.cmd020102.Visible = False
        '
        'cmd020103
        '
        Me.cmd020103.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020103.Image = CType(resources.GetObject("cmd020103.Image"), System.Drawing.Image)
        Me.cmd020103.Location = New System.Drawing.Point(17, 176)
        Me.cmd020103.Name = "cmd020103"
        Me.cmd020103.Size = New System.Drawing.Size(96, 64)
        Me.cmd020103.TabIndex = 62
        Me.cmd020103.Tag = "itm030"
        Me.cmd020103.Visible = False
        '
        'cmd020104
        '
        Me.cmd020104.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020104.Image = CType(resources.GetObject("cmd020104.Image"), System.Drawing.Image)
        Me.cmd020104.Location = New System.Drawing.Point(17, 256)
        Me.cmd020104.Name = "cmd020104"
        Me.cmd020104.Size = New System.Drawing.Size(96, 64)
        Me.cmd020104.TabIndex = 61
        Me.cmd020104.Tag = "itm032"
        Me.cmd020104.Visible = False
        '
        'cmd020105
        '
        Me.cmd020105.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020105.Image = CType(resources.GetObject("cmd020105.Image"), System.Drawing.Image)
        Me.cmd020105.Location = New System.Drawing.Point(17, 336)
        Me.cmd020105.Name = "cmd020105"
        Me.cmd020105.Size = New System.Drawing.Size(96, 64)
        Me.cmd020105.TabIndex = 60
        Me.cmd020105.Tag = "itm037"
        Me.cmd020105.Visible = False
        '
        'cmd020101
        '
        Me.cmd020101.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd020101.Image = CType(resources.GetObject("cmd020101.Image"), System.Drawing.Image)
        Me.cmd020101.Location = New System.Drawing.Point(17, 16)
        Me.cmd020101.Name = "cmd020101"
        Me.cmd020101.Size = New System.Drawing.Size(96, 64)
        Me.cmd020101.TabIndex = 59
        Me.cmd020101.Tag = "itm026"
        Me.cmd020101.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.cmd030804)
        Me.TabPage3.Controls.Add(Me.cmd030705)
        Me.TabPage3.Controls.Add(Me.cmd030605)
        Me.TabPage3.Controls.Add(Me.cmd030603)
        Me.TabPage3.Controls.Add(Me.cmd030602)
        Me.TabPage3.Controls.Add(Me.cmd030601)
        Me.TabPage3.Controls.Add(Me.cmd030505)
        Me.TabPage3.Controls.Add(Me.cmd030504)
        Me.TabPage3.Controls.Add(Me.cmd030503)
        Me.TabPage3.Controls.Add(Me.cmd030502)
        Me.TabPage3.Controls.Add(Me.cmd030405)
        Me.TabPage3.Controls.Add(Me.cmd030404)
        Me.TabPage3.Controls.Add(Me.cmd030403)
        Me.TabPage3.Controls.Add(Me.cmd030402)
        Me.TabPage3.Controls.Add(Me.cmd030305)
        Me.TabPage3.Controls.Add(Me.cmd030304)
        Me.TabPage3.Controls.Add(Me.cmd030303)
        Me.TabPage3.Controls.Add(Me.cmd030302)
        Me.TabPage3.Controls.Add(Me.cmd030205)
        Me.TabPage3.Controls.Add(Me.cmd030204)
        Me.TabPage3.Controls.Add(Me.cmd030203)
        Me.TabPage3.Controls.Add(Me.cmd030202)
        Me.TabPage3.Controls.Add(Me.cmd030105)
        Me.TabPage3.Controls.Add(Me.cmd030104)
        Me.TabPage3.Controls.Add(Me.cmd030103)
        Me.TabPage3.Controls.Add(Me.cmd030805)
        Me.TabPage3.Controls.Add(Me.cmd030806)
        Me.TabPage3.Controls.Add(Me.cmd030606)
        Me.TabPage3.Controls.Add(Me.cmd030506)
        Me.TabPage3.Controls.Add(Me.cmd030406)
        Me.TabPage3.Controls.Add(Me.cmd030706)
        Me.TabPage3.Controls.Add(Me.cmd030802)
        Me.TabPage3.Controls.Add(Me.cmd030803)
        Me.TabPage3.Controls.Add(Me.cmd030801)
        Me.TabPage3.Controls.Add(Me.cmd030702)
        Me.TabPage3.Controls.Add(Me.cmd030703)
        Me.TabPage3.Controls.Add(Me.cmd030704)
        Me.TabPage3.Controls.Add(Me.cmd030701)
        Me.TabPage3.Controls.Add(Me.cmd030604)
        Me.TabPage3.Controls.Add(Me.cmd030501)
        Me.TabPage3.Controls.Add(Me.cmd030401)
        Me.TabPage3.Controls.Add(Me.cmd030301)
        Me.TabPage3.Controls.Add(Me.cmd030201)
        Me.TabPage3.Controls.Add(Me.cmd030206)
        Me.TabPage3.Controls.Add(Me.cmd030306)
        Me.TabPage3.Controls.Add(Me.cmd030106)
        Me.TabPage3.Controls.Add(Me.cmd030102)
        Me.TabPage3.Controls.Add(Me.cmd030101)
        Me.TabPage3.Location = New System.Drawing.Point(4, 32)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(952, 500)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Pasta/Ribs/Chicken"
        '
        'cmd030804
        '
        Me.cmd030804.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030804.Location = New System.Drawing.Point(836, 256)
        Me.cmd030804.Name = "cmd030804"
        Me.cmd030804.Size = New System.Drawing.Size(96, 64)
        Me.cmd030804.TabIndex = 149
        Me.cmd030804.Tag = ""
        Me.cmd030804.Visible = False
        '
        'cmd030705
        '
        Me.cmd030705.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030705.Location = New System.Drawing.Point(719, 336)
        Me.cmd030705.Name = "cmd030705"
        Me.cmd030705.Size = New System.Drawing.Size(96, 64)
        Me.cmd030705.TabIndex = 148
        Me.cmd030705.Tag = ""
        Me.cmd030705.Visible = False
        '
        'cmd030605
        '
        Me.cmd030605.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030605.Location = New System.Drawing.Point(602, 336)
        Me.cmd030605.Name = "cmd030605"
        Me.cmd030605.Size = New System.Drawing.Size(96, 64)
        Me.cmd030605.TabIndex = 147
        Me.cmd030605.Tag = ""
        Me.cmd030605.Visible = False
        '
        'cmd030603
        '
        Me.cmd030603.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030603.Location = New System.Drawing.Point(602, 176)
        Me.cmd030603.Name = "cmd030603"
        Me.cmd030603.Size = New System.Drawing.Size(96, 64)
        Me.cmd030603.TabIndex = 146
        Me.cmd030603.Tag = ""
        Me.cmd030603.Visible = False
        '
        'cmd030602
        '
        Me.cmd030602.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030602.Location = New System.Drawing.Point(602, 96)
        Me.cmd030602.Name = "cmd030602"
        Me.cmd030602.Size = New System.Drawing.Size(96, 64)
        Me.cmd030602.TabIndex = 145
        Me.cmd030602.Tag = ""
        Me.cmd030602.Visible = False
        '
        'cmd030601
        '
        Me.cmd030601.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030601.Location = New System.Drawing.Point(602, 16)
        Me.cmd030601.Name = "cmd030601"
        Me.cmd030601.Size = New System.Drawing.Size(96, 64)
        Me.cmd030601.TabIndex = 144
        Me.cmd030601.Tag = ""
        Me.cmd030601.Visible = False
        '
        'cmd030505
        '
        Me.cmd030505.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030505.Location = New System.Drawing.Point(485, 336)
        Me.cmd030505.Name = "cmd030505"
        Me.cmd030505.Size = New System.Drawing.Size(96, 64)
        Me.cmd030505.TabIndex = 143
        Me.cmd030505.Tag = ""
        Me.cmd030505.Visible = False
        '
        'cmd030504
        '
        Me.cmd030504.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030504.Location = New System.Drawing.Point(485, 256)
        Me.cmd030504.Name = "cmd030504"
        Me.cmd030504.Size = New System.Drawing.Size(96, 64)
        Me.cmd030504.TabIndex = 142
        Me.cmd030504.Tag = ""
        Me.cmd030504.Visible = False
        '
        'cmd030503
        '
        Me.cmd030503.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030503.Location = New System.Drawing.Point(485, 176)
        Me.cmd030503.Name = "cmd030503"
        Me.cmd030503.Size = New System.Drawing.Size(96, 64)
        Me.cmd030503.TabIndex = 141
        Me.cmd030503.Tag = ""
        Me.cmd030503.Visible = False
        '
        'cmd030502
        '
        Me.cmd030502.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030502.Location = New System.Drawing.Point(485, 96)
        Me.cmd030502.Name = "cmd030502"
        Me.cmd030502.Size = New System.Drawing.Size(96, 64)
        Me.cmd030502.TabIndex = 140
        Me.cmd030502.Tag = ""
        Me.cmd030502.Visible = False
        '
        'cmd030405
        '
        Me.cmd030405.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030405.Location = New System.Drawing.Point(368, 336)
        Me.cmd030405.Name = "cmd030405"
        Me.cmd030405.Size = New System.Drawing.Size(96, 64)
        Me.cmd030405.TabIndex = 139
        Me.cmd030405.Tag = ""
        Me.cmd030405.Visible = False
        '
        'cmd030404
        '
        Me.cmd030404.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030404.Location = New System.Drawing.Point(368, 256)
        Me.cmd030404.Name = "cmd030404"
        Me.cmd030404.Size = New System.Drawing.Size(96, 64)
        Me.cmd030404.TabIndex = 138
        Me.cmd030404.Tag = ""
        Me.cmd030404.Visible = False
        '
        'cmd030403
        '
        Me.cmd030403.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030403.Location = New System.Drawing.Point(368, 176)
        Me.cmd030403.Name = "cmd030403"
        Me.cmd030403.Size = New System.Drawing.Size(96, 64)
        Me.cmd030403.TabIndex = 137
        Me.cmd030403.Tag = ""
        Me.cmd030403.Visible = False
        '
        'cmd030402
        '
        Me.cmd030402.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030402.Location = New System.Drawing.Point(368, 96)
        Me.cmd030402.Name = "cmd030402"
        Me.cmd030402.Size = New System.Drawing.Size(96, 64)
        Me.cmd030402.TabIndex = 136
        Me.cmd030402.Tag = ""
        Me.cmd030402.Visible = False
        '
        'cmd030305
        '
        Me.cmd030305.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030305.Location = New System.Drawing.Point(251, 336)
        Me.cmd030305.Name = "cmd030305"
        Me.cmd030305.Size = New System.Drawing.Size(96, 64)
        Me.cmd030305.TabIndex = 135
        Me.cmd030305.Tag = ""
        Me.cmd030305.Visible = False
        '
        'cmd030304
        '
        Me.cmd030304.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030304.Location = New System.Drawing.Point(251, 256)
        Me.cmd030304.Name = "cmd030304"
        Me.cmd030304.Size = New System.Drawing.Size(96, 64)
        Me.cmd030304.TabIndex = 134
        Me.cmd030304.Tag = ""
        Me.cmd030304.Visible = False
        '
        'cmd030303
        '
        Me.cmd030303.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030303.Location = New System.Drawing.Point(251, 176)
        Me.cmd030303.Name = "cmd030303"
        Me.cmd030303.Size = New System.Drawing.Size(96, 64)
        Me.cmd030303.TabIndex = 133
        Me.cmd030303.Tag = ""
        Me.cmd030303.Visible = False
        '
        'cmd030302
        '
        Me.cmd030302.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030302.Location = New System.Drawing.Point(251, 96)
        Me.cmd030302.Name = "cmd030302"
        Me.cmd030302.Size = New System.Drawing.Size(96, 64)
        Me.cmd030302.TabIndex = 132
        Me.cmd030302.Tag = ""
        Me.cmd030302.Visible = False
        '
        'cmd030205
        '
        Me.cmd030205.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030205.Location = New System.Drawing.Point(134, 336)
        Me.cmd030205.Name = "cmd030205"
        Me.cmd030205.Size = New System.Drawing.Size(96, 64)
        Me.cmd030205.TabIndex = 131
        Me.cmd030205.Tag = ""
        Me.cmd030205.Visible = False
        '
        'cmd030204
        '
        Me.cmd030204.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030204.Location = New System.Drawing.Point(134, 256)
        Me.cmd030204.Name = "cmd030204"
        Me.cmd030204.Size = New System.Drawing.Size(96, 64)
        Me.cmd030204.TabIndex = 130
        Me.cmd030204.Tag = ""
        Me.cmd030204.Visible = False
        '
        'cmd030203
        '
        Me.cmd030203.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030203.Location = New System.Drawing.Point(134, 176)
        Me.cmd030203.Name = "cmd030203"
        Me.cmd030203.Size = New System.Drawing.Size(96, 64)
        Me.cmd030203.TabIndex = 129
        Me.cmd030203.Tag = ""
        Me.cmd030203.Visible = False
        '
        'cmd030202
        '
        Me.cmd030202.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030202.Location = New System.Drawing.Point(134, 96)
        Me.cmd030202.Name = "cmd030202"
        Me.cmd030202.Size = New System.Drawing.Size(96, 64)
        Me.cmd030202.TabIndex = 128
        Me.cmd030202.Tag = ""
        Me.cmd030202.Visible = False
        '
        'cmd030105
        '
        Me.cmd030105.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030105.Location = New System.Drawing.Point(17, 336)
        Me.cmd030105.Name = "cmd030105"
        Me.cmd030105.Size = New System.Drawing.Size(96, 64)
        Me.cmd030105.TabIndex = 127
        Me.cmd030105.Tag = ""
        Me.cmd030105.Visible = False
        '
        'cmd030104
        '
        Me.cmd030104.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030104.Location = New System.Drawing.Point(17, 256)
        Me.cmd030104.Name = "cmd030104"
        Me.cmd030104.Size = New System.Drawing.Size(96, 64)
        Me.cmd030104.TabIndex = 126
        Me.cmd030104.Tag = ""
        Me.cmd030104.Visible = False
        '
        'cmd030103
        '
        Me.cmd030103.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030103.Location = New System.Drawing.Point(17, 176)
        Me.cmd030103.Name = "cmd030103"
        Me.cmd030103.Size = New System.Drawing.Size(96, 64)
        Me.cmd030103.TabIndex = 125
        Me.cmd030103.Tag = ""
        Me.cmd030103.Visible = False
        '
        'cmd030805
        '
        Me.cmd030805.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030805.Image = CType(resources.GetObject("cmd030805.Image"), System.Drawing.Image)
        Me.cmd030805.Location = New System.Drawing.Point(836, 336)
        Me.cmd030805.Name = "cmd030805"
        Me.cmd030805.Size = New System.Drawing.Size(96, 64)
        Me.cmd030805.TabIndex = 124
        Me.cmd030805.Tag = ""
        Me.cmd030805.Visible = False
        '
        'cmd030806
        '
        Me.cmd030806.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030806.Image = CType(resources.GetObject("cmd030806.Image"), System.Drawing.Image)
        Me.cmd030806.Location = New System.Drawing.Point(836, 416)
        Me.cmd030806.Name = "cmd030806"
        Me.cmd030806.Size = New System.Drawing.Size(96, 64)
        Me.cmd030806.TabIndex = 123
        Me.cmd030806.Tag = ""
        Me.cmd030806.Visible = False
        '
        'cmd030606
        '
        Me.cmd030606.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030606.Image = CType(resources.GetObject("cmd030606.Image"), System.Drawing.Image)
        Me.cmd030606.Location = New System.Drawing.Point(602, 416)
        Me.cmd030606.Name = "cmd030606"
        Me.cmd030606.Size = New System.Drawing.Size(96, 64)
        Me.cmd030606.TabIndex = 122
        Me.cmd030606.Tag = ""
        Me.cmd030606.Visible = False
        '
        'cmd030506
        '
        Me.cmd030506.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030506.Image = CType(resources.GetObject("cmd030506.Image"), System.Drawing.Image)
        Me.cmd030506.Location = New System.Drawing.Point(485, 416)
        Me.cmd030506.Name = "cmd030506"
        Me.cmd030506.Size = New System.Drawing.Size(96, 64)
        Me.cmd030506.TabIndex = 121
        Me.cmd030506.Tag = ""
        Me.cmd030506.Visible = False
        '
        'cmd030406
        '
        Me.cmd030406.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030406.Image = CType(resources.GetObject("cmd030406.Image"), System.Drawing.Image)
        Me.cmd030406.Location = New System.Drawing.Point(368, 416)
        Me.cmd030406.Name = "cmd030406"
        Me.cmd030406.Size = New System.Drawing.Size(96, 64)
        Me.cmd030406.TabIndex = 120
        Me.cmd030406.Tag = ""
        Me.cmd030406.Visible = False
        '
        'cmd030706
        '
        Me.cmd030706.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030706.Image = CType(resources.GetObject("cmd030706.Image"), System.Drawing.Image)
        Me.cmd030706.Location = New System.Drawing.Point(719, 416)
        Me.cmd030706.Name = "cmd030706"
        Me.cmd030706.Size = New System.Drawing.Size(96, 64)
        Me.cmd030706.TabIndex = 119
        Me.cmd030706.Tag = ""
        Me.cmd030706.Visible = False
        '
        'cmd030802
        '
        Me.cmd030802.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030802.Image = CType(resources.GetObject("cmd030802.Image"), System.Drawing.Image)
        Me.cmd030802.Location = New System.Drawing.Point(836, 96)
        Me.cmd030802.Name = "cmd030802"
        Me.cmd030802.Size = New System.Drawing.Size(96, 64)
        Me.cmd030802.TabIndex = 106
        Me.cmd030802.Tag = "itm058"
        Me.cmd030802.Visible = False
        '
        'cmd030803
        '
        Me.cmd030803.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030803.Image = CType(resources.GetObject("cmd030803.Image"), System.Drawing.Image)
        Me.cmd030803.Location = New System.Drawing.Point(836, 176)
        Me.cmd030803.Name = "cmd030803"
        Me.cmd030803.Size = New System.Drawing.Size(96, 64)
        Me.cmd030803.TabIndex = 105
        Me.cmd030803.Tag = "itm059"
        Me.cmd030803.Visible = False
        '
        'cmd030801
        '
        Me.cmd030801.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030801.Image = CType(resources.GetObject("cmd030801.Image"), System.Drawing.Image)
        Me.cmd030801.Location = New System.Drawing.Point(836, 16)
        Me.cmd030801.Name = "cmd030801"
        Me.cmd030801.Size = New System.Drawing.Size(96, 64)
        Me.cmd030801.TabIndex = 102
        Me.cmd030801.Tag = "itm056"
        Me.cmd030801.Visible = False
        '
        'cmd030702
        '
        Me.cmd030702.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030702.Image = CType(resources.GetObject("cmd030702.Image"), System.Drawing.Image)
        Me.cmd030702.Location = New System.Drawing.Point(719, 96)
        Me.cmd030702.Name = "cmd030702"
        Me.cmd030702.Size = New System.Drawing.Size(96, 64)
        Me.cmd030702.TabIndex = 101
        Me.cmd030702.Tag = "itm061"
        Me.cmd030702.Visible = False
        '
        'cmd030703
        '
        Me.cmd030703.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030703.Image = CType(resources.GetObject("cmd030703.Image"), System.Drawing.Image)
        Me.cmd030703.Location = New System.Drawing.Point(719, 176)
        Me.cmd030703.Name = "cmd030703"
        Me.cmd030703.Size = New System.Drawing.Size(96, 64)
        Me.cmd030703.TabIndex = 100
        Me.cmd030703.Tag = "itm062"
        Me.cmd030703.Visible = False
        '
        'cmd030704
        '
        Me.cmd030704.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030704.Image = CType(resources.GetObject("cmd030704.Image"), System.Drawing.Image)
        Me.cmd030704.Location = New System.Drawing.Point(719, 256)
        Me.cmd030704.Name = "cmd030704"
        Me.cmd030704.Size = New System.Drawing.Size(96, 64)
        Me.cmd030704.TabIndex = 99
        Me.cmd030704.Tag = "itm023"
        Me.cmd030704.Visible = False
        '
        'cmd030701
        '
        Me.cmd030701.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030701.Image = CType(resources.GetObject("cmd030701.Image"), System.Drawing.Image)
        Me.cmd030701.Location = New System.Drawing.Point(719, 16)
        Me.cmd030701.Name = "cmd030701"
        Me.cmd030701.Size = New System.Drawing.Size(96, 64)
        Me.cmd030701.TabIndex = 97
        Me.cmd030701.Tag = "itm060"
        Me.cmd030701.Visible = False
        '
        'cmd030604
        '
        Me.cmd030604.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030604.Image = CType(resources.GetObject("cmd030604.Image"), System.Drawing.Image)
        Me.cmd030604.Location = New System.Drawing.Point(602, 256)
        Me.cmd030604.Name = "cmd030604"
        Me.cmd030604.Size = New System.Drawing.Size(96, 64)
        Me.cmd030604.TabIndex = 94
        Me.cmd030604.Tag = "itm064"
        Me.cmd030604.Visible = False
        '
        'cmd030501
        '
        Me.cmd030501.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030501.Image = CType(resources.GetObject("cmd030501.Image"), System.Drawing.Image)
        Me.cmd030501.Location = New System.Drawing.Point(485, 16)
        Me.cmd030501.Name = "cmd030501"
        Me.cmd030501.Size = New System.Drawing.Size(96, 64)
        Me.cmd030501.TabIndex = 87
        Me.cmd030501.Tag = "itm055"
        Me.cmd030501.Visible = False
        '
        'cmd030401
        '
        Me.cmd030401.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030401.Image = CType(resources.GetObject("cmd030401.Image"), System.Drawing.Image)
        Me.cmd030401.Location = New System.Drawing.Point(368, 16)
        Me.cmd030401.Name = "cmd030401"
        Me.cmd030401.Size = New System.Drawing.Size(96, 64)
        Me.cmd030401.TabIndex = 82
        Me.cmd030401.Tag = "itm054"
        Me.cmd030401.Visible = False
        '
        'cmd030301
        '
        Me.cmd030301.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030301.Image = CType(resources.GetObject("cmd030301.Image"), System.Drawing.Image)
        Me.cmd030301.Location = New System.Drawing.Point(251, 16)
        Me.cmd030301.Name = "cmd030301"
        Me.cmd030301.Size = New System.Drawing.Size(96, 64)
        Me.cmd030301.TabIndex = 77
        Me.cmd030301.Tag = "itm053"
        Me.cmd030301.Visible = False
        '
        'cmd030201
        '
        Me.cmd030201.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030201.Image = CType(resources.GetObject("cmd030201.Image"), System.Drawing.Image)
        Me.cmd030201.Location = New System.Drawing.Point(134, 16)
        Me.cmd030201.Name = "cmd030201"
        Me.cmd030201.Size = New System.Drawing.Size(96, 64)
        Me.cmd030201.TabIndex = 72
        Me.cmd030201.Tag = "itm051"
        Me.cmd030201.Visible = False
        '
        'cmd030206
        '
        Me.cmd030206.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030206.Image = CType(resources.GetObject("cmd030206.Image"), System.Drawing.Image)
        Me.cmd030206.Location = New System.Drawing.Point(134, 416)
        Me.cmd030206.Name = "cmd030206"
        Me.cmd030206.Size = New System.Drawing.Size(96, 64)
        Me.cmd030206.TabIndex = 68
        Me.cmd030206.Tag = "itm016"
        Me.cmd030206.Visible = False
        '
        'cmd030306
        '
        Me.cmd030306.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030306.Image = CType(resources.GetObject("cmd030306.Image"), System.Drawing.Image)
        Me.cmd030306.Location = New System.Drawing.Point(251, 416)
        Me.cmd030306.Name = "cmd030306"
        Me.cmd030306.Size = New System.Drawing.Size(96, 64)
        Me.cmd030306.TabIndex = 67
        Me.cmd030306.Tag = "itm017"
        Me.cmd030306.Visible = False
        '
        'cmd030106
        '
        Me.cmd030106.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030106.Image = CType(resources.GetObject("cmd030106.Image"), System.Drawing.Image)
        Me.cmd030106.Location = New System.Drawing.Point(17, 416)
        Me.cmd030106.Name = "cmd030106"
        Me.cmd030106.Size = New System.Drawing.Size(96, 64)
        Me.cmd030106.TabIndex = 64
        Me.cmd030106.Tag = "itm015"
        Me.cmd030106.Visible = False
        '
        'cmd030102
        '
        Me.cmd030102.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030102.Image = CType(resources.GetObject("cmd030102.Image"), System.Drawing.Image)
        Me.cmd030102.Location = New System.Drawing.Point(17, 96)
        Me.cmd030102.Name = "cmd030102"
        Me.cmd030102.Size = New System.Drawing.Size(96, 64)
        Me.cmd030102.TabIndex = 63
        Me.cmd030102.Tag = "itm063"
        Me.cmd030102.Visible = False
        '
        'cmd030101
        '
        Me.cmd030101.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd030101.Image = CType(resources.GetObject("cmd030101.Image"), System.Drawing.Image)
        Me.cmd030101.Location = New System.Drawing.Point(17, 16)
        Me.cmd030101.Name = "cmd030101"
        Me.cmd030101.Size = New System.Drawing.Size(96, 64)
        Me.cmd030101.TabIndex = 59
        Me.cmd030101.Tag = "itm052"
        Me.cmd030101.Visible = False
        '
        'TabPage5
        '
        Me.TabPage5.BackgroundImage = CType(resources.GetObject("TabPage5.BackgroundImage"), System.Drawing.Image)
        Me.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage5.Controls.Add(Me.cmd040806)
        Me.TabPage5.Controls.Add(Me.cmd040706)
        Me.TabPage5.Controls.Add(Me.cmd040705)
        Me.TabPage5.Controls.Add(Me.cmd040606)
        Me.TabPage5.Controls.Add(Me.cmd040605)
        Me.TabPage5.Controls.Add(Me.cmd040506)
        Me.TabPage5.Controls.Add(Me.cmd040505)
        Me.TabPage5.Controls.Add(Me.cmd040503)
        Me.TabPage5.Controls.Add(Me.cmd040502)
        Me.TabPage5.Controls.Add(Me.cmd040501)
        Me.TabPage5.Controls.Add(Me.cmd040406)
        Me.TabPage5.Controls.Add(Me.cmd040405)
        Me.TabPage5.Controls.Add(Me.cmd040404)
        Me.TabPage5.Controls.Add(Me.cmd040403)
        Me.TabPage5.Controls.Add(Me.cmd040402)
        Me.TabPage5.Controls.Add(Me.cmd040401)
        Me.TabPage5.Controls.Add(Me.cmd040305)
        Me.TabPage5.Controls.Add(Me.cmd040304)
        Me.TabPage5.Controls.Add(Me.cmd040303)
        Me.TabPage5.Controls.Add(Me.cmd040205)
        Me.TabPage5.Controls.Add(Me.cmd040204)
        Me.TabPage5.Controls.Add(Me.cmd040203)
        Me.TabPage5.Controls.Add(Me.cmd040105)
        Me.TabPage5.Controls.Add(Me.cmd040104)
        Me.TabPage5.Controls.Add(Me.cmd040206)
        Me.TabPage5.Controls.Add(Me.cmd040306)
        Me.TabPage5.Controls.Add(Me.cmd040106)
        Me.TabPage5.Controls.Add(Me.cmd040504)
        Me.TabPage5.Controls.Add(Me.cmd040805)
        Me.TabPage5.Controls.Add(Me.cmd040802)
        Me.TabPage5.Controls.Add(Me.cmd040803)
        Me.TabPage5.Controls.Add(Me.cmd040804)
        Me.TabPage5.Controls.Add(Me.cmd040801)
        Me.TabPage5.Controls.Add(Me.cmd040702)
        Me.TabPage5.Controls.Add(Me.cmd040703)
        Me.TabPage5.Controls.Add(Me.cmd040704)
        Me.TabPage5.Controls.Add(Me.cmd040701)
        Me.TabPage5.Controls.Add(Me.cmd040602)
        Me.TabPage5.Controls.Add(Me.cmd040603)
        Me.TabPage5.Controls.Add(Me.cmd040604)
        Me.TabPage5.Controls.Add(Me.cmd040601)
        Me.TabPage5.Controls.Add(Me.cmd040302)
        Me.TabPage5.Controls.Add(Me.cmd040301)
        Me.TabPage5.Controls.Add(Me.cmd040202)
        Me.TabPage5.Controls.Add(Me.cmd040201)
        Me.TabPage5.Controls.Add(Me.cmd040102)
        Me.TabPage5.Controls.Add(Me.cmd040103)
        Me.TabPage5.Controls.Add(Me.cmd040101)
        Me.TabPage5.Location = New System.Drawing.Point(4, 32)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(952, 500)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Dessert/Kids Menu"
        '
        'cmd040806
        '
        Me.cmd040806.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040806.Location = New System.Drawing.Point(836, 416)
        Me.cmd040806.Name = "cmd040806"
        Me.cmd040806.Size = New System.Drawing.Size(96, 64)
        Me.cmd040806.TabIndex = 149
        Me.cmd040806.Tag = ""
        Me.cmd040806.Visible = False
        '
        'cmd040706
        '
        Me.cmd040706.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040706.Location = New System.Drawing.Point(719, 416)
        Me.cmd040706.Name = "cmd040706"
        Me.cmd040706.Size = New System.Drawing.Size(96, 64)
        Me.cmd040706.TabIndex = 148
        Me.cmd040706.Tag = ""
        Me.cmd040706.Visible = False
        '
        'cmd040705
        '
        Me.cmd040705.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040705.Location = New System.Drawing.Point(719, 336)
        Me.cmd040705.Name = "cmd040705"
        Me.cmd040705.Size = New System.Drawing.Size(96, 64)
        Me.cmd040705.TabIndex = 147
        Me.cmd040705.Tag = ""
        Me.cmd040705.Visible = False
        '
        'cmd040606
        '
        Me.cmd040606.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040606.Location = New System.Drawing.Point(602, 416)
        Me.cmd040606.Name = "cmd040606"
        Me.cmd040606.Size = New System.Drawing.Size(96, 64)
        Me.cmd040606.TabIndex = 146
        Me.cmd040606.Tag = ""
        Me.cmd040606.Visible = False
        '
        'cmd040605
        '
        Me.cmd040605.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040605.Location = New System.Drawing.Point(602, 336)
        Me.cmd040605.Name = "cmd040605"
        Me.cmd040605.Size = New System.Drawing.Size(96, 64)
        Me.cmd040605.TabIndex = 145
        Me.cmd040605.Tag = ""
        Me.cmd040605.Visible = False
        '
        'cmd040506
        '
        Me.cmd040506.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040506.Location = New System.Drawing.Point(485, 416)
        Me.cmd040506.Name = "cmd040506"
        Me.cmd040506.Size = New System.Drawing.Size(96, 64)
        Me.cmd040506.TabIndex = 144
        Me.cmd040506.Tag = ""
        Me.cmd040506.Visible = False
        '
        'cmd040505
        '
        Me.cmd040505.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040505.Location = New System.Drawing.Point(485, 336)
        Me.cmd040505.Name = "cmd040505"
        Me.cmd040505.Size = New System.Drawing.Size(96, 64)
        Me.cmd040505.TabIndex = 143
        Me.cmd040505.Tag = ""
        Me.cmd040505.Visible = False
        '
        'cmd040503
        '
        Me.cmd040503.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040503.Location = New System.Drawing.Point(485, 176)
        Me.cmd040503.Name = "cmd040503"
        Me.cmd040503.Size = New System.Drawing.Size(96, 64)
        Me.cmd040503.TabIndex = 142
        Me.cmd040503.Tag = ""
        Me.cmd040503.Visible = False
        '
        'cmd040502
        '
        Me.cmd040502.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040502.Location = New System.Drawing.Point(485, 96)
        Me.cmd040502.Name = "cmd040502"
        Me.cmd040502.Size = New System.Drawing.Size(96, 64)
        Me.cmd040502.TabIndex = 141
        Me.cmd040502.Tag = ""
        Me.cmd040502.Visible = False
        '
        'cmd040501
        '
        Me.cmd040501.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040501.Location = New System.Drawing.Point(485, 16)
        Me.cmd040501.Name = "cmd040501"
        Me.cmd040501.Size = New System.Drawing.Size(96, 64)
        Me.cmd040501.TabIndex = 140
        Me.cmd040501.Tag = ""
        Me.cmd040501.Visible = False
        '
        'cmd040406
        '
        Me.cmd040406.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040406.Location = New System.Drawing.Point(368, 416)
        Me.cmd040406.Name = "cmd040406"
        Me.cmd040406.Size = New System.Drawing.Size(96, 64)
        Me.cmd040406.TabIndex = 139
        Me.cmd040406.Tag = ""
        Me.cmd040406.Visible = False
        '
        'cmd040405
        '
        Me.cmd040405.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040405.Location = New System.Drawing.Point(368, 336)
        Me.cmd040405.Name = "cmd040405"
        Me.cmd040405.Size = New System.Drawing.Size(96, 64)
        Me.cmd040405.TabIndex = 138
        Me.cmd040405.Tag = ""
        Me.cmd040405.Visible = False
        '
        'cmd040404
        '
        Me.cmd040404.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040404.Location = New System.Drawing.Point(368, 256)
        Me.cmd040404.Name = "cmd040404"
        Me.cmd040404.Size = New System.Drawing.Size(96, 64)
        Me.cmd040404.TabIndex = 137
        Me.cmd040404.Tag = ""
        Me.cmd040404.Visible = False
        '
        'cmd040403
        '
        Me.cmd040403.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040403.Location = New System.Drawing.Point(368, 176)
        Me.cmd040403.Name = "cmd040403"
        Me.cmd040403.Size = New System.Drawing.Size(96, 64)
        Me.cmd040403.TabIndex = 136
        Me.cmd040403.Tag = ""
        Me.cmd040403.Visible = False
        '
        'cmd040402
        '
        Me.cmd040402.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040402.Location = New System.Drawing.Point(368, 96)
        Me.cmd040402.Name = "cmd040402"
        Me.cmd040402.Size = New System.Drawing.Size(96, 64)
        Me.cmd040402.TabIndex = 135
        Me.cmd040402.Tag = ""
        Me.cmd040402.Visible = False
        '
        'cmd040401
        '
        Me.cmd040401.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040401.Location = New System.Drawing.Point(368, 16)
        Me.cmd040401.Name = "cmd040401"
        Me.cmd040401.Size = New System.Drawing.Size(96, 64)
        Me.cmd040401.TabIndex = 134
        Me.cmd040401.Tag = ""
        Me.cmd040401.Visible = False
        '
        'cmd040305
        '
        Me.cmd040305.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040305.Location = New System.Drawing.Point(251, 336)
        Me.cmd040305.Name = "cmd040305"
        Me.cmd040305.Size = New System.Drawing.Size(96, 64)
        Me.cmd040305.TabIndex = 133
        Me.cmd040305.Tag = ""
        Me.cmd040305.Visible = False
        '
        'cmd040304
        '
        Me.cmd040304.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040304.Location = New System.Drawing.Point(251, 256)
        Me.cmd040304.Name = "cmd040304"
        Me.cmd040304.Size = New System.Drawing.Size(96, 64)
        Me.cmd040304.TabIndex = 132
        Me.cmd040304.Tag = ""
        Me.cmd040304.Visible = False
        '
        'cmd040303
        '
        Me.cmd040303.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040303.Location = New System.Drawing.Point(251, 176)
        Me.cmd040303.Name = "cmd040303"
        Me.cmd040303.Size = New System.Drawing.Size(96, 64)
        Me.cmd040303.TabIndex = 131
        Me.cmd040303.Tag = ""
        Me.cmd040303.Visible = False
        '
        'cmd040205
        '
        Me.cmd040205.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040205.Location = New System.Drawing.Point(134, 336)
        Me.cmd040205.Name = "cmd040205"
        Me.cmd040205.Size = New System.Drawing.Size(96, 64)
        Me.cmd040205.TabIndex = 130
        Me.cmd040205.Tag = ""
        Me.cmd040205.Visible = False
        '
        'cmd040204
        '
        Me.cmd040204.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040204.Location = New System.Drawing.Point(134, 256)
        Me.cmd040204.Name = "cmd040204"
        Me.cmd040204.Size = New System.Drawing.Size(96, 64)
        Me.cmd040204.TabIndex = 129
        Me.cmd040204.Tag = ""
        Me.cmd040204.Visible = False
        '
        'cmd040203
        '
        Me.cmd040203.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040203.Location = New System.Drawing.Point(134, 176)
        Me.cmd040203.Name = "cmd040203"
        Me.cmd040203.Size = New System.Drawing.Size(96, 64)
        Me.cmd040203.TabIndex = 128
        Me.cmd040203.Tag = ""
        Me.cmd040203.Visible = False
        '
        'cmd040105
        '
        Me.cmd040105.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040105.Location = New System.Drawing.Point(17, 336)
        Me.cmd040105.Name = "cmd040105"
        Me.cmd040105.Size = New System.Drawing.Size(96, 64)
        Me.cmd040105.TabIndex = 127
        Me.cmd040105.Tag = ""
        Me.cmd040105.Visible = False
        '
        'cmd040104
        '
        Me.cmd040104.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040104.Location = New System.Drawing.Point(17, 256)
        Me.cmd040104.Name = "cmd040104"
        Me.cmd040104.Size = New System.Drawing.Size(96, 64)
        Me.cmd040104.TabIndex = 126
        Me.cmd040104.Tag = ""
        Me.cmd040104.Visible = False
        '
        'cmd040206
        '
        Me.cmd040206.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040206.Image = CType(resources.GetObject("cmd040206.Image"), System.Drawing.Image)
        Me.cmd040206.Location = New System.Drawing.Point(134, 416)
        Me.cmd040206.Name = "cmd040206"
        Me.cmd040206.Size = New System.Drawing.Size(96, 64)
        Me.cmd040206.TabIndex = 111
        Me.cmd040206.Tag = "itm016"
        Me.cmd040206.Visible = False
        '
        'cmd040306
        '
        Me.cmd040306.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040306.Image = CType(resources.GetObject("cmd040306.Image"), System.Drawing.Image)
        Me.cmd040306.Location = New System.Drawing.Point(251, 416)
        Me.cmd040306.Name = "cmd040306"
        Me.cmd040306.Size = New System.Drawing.Size(96, 64)
        Me.cmd040306.TabIndex = 110
        Me.cmd040306.Tag = "itm017"
        Me.cmd040306.Visible = False
        '
        'cmd040106
        '
        Me.cmd040106.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040106.Image = CType(resources.GetObject("cmd040106.Image"), System.Drawing.Image)
        Me.cmd040106.Location = New System.Drawing.Point(17, 416)
        Me.cmd040106.Name = "cmd040106"
        Me.cmd040106.Size = New System.Drawing.Size(96, 64)
        Me.cmd040106.TabIndex = 109
        Me.cmd040106.Tag = "itm015"
        Me.cmd040106.Visible = False
        '
        'cmd040504
        '
        Me.cmd040504.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040504.Image = CType(resources.GetObject("cmd040504.Image"), System.Drawing.Image)
        Me.cmd040504.Location = New System.Drawing.Point(485, 256)
        Me.cmd040504.Name = "cmd040504"
        Me.cmd040504.Size = New System.Drawing.Size(96, 64)
        Me.cmd040504.TabIndex = 108
        Me.cmd040504.Tag = "itm140"
        Me.cmd040504.Visible = False
        '
        'cmd040805
        '
        Me.cmd040805.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040805.Image = CType(resources.GetObject("cmd040805.Image"), System.Drawing.Image)
        Me.cmd040805.Location = New System.Drawing.Point(836, 336)
        Me.cmd040805.Name = "cmd040805"
        Me.cmd040805.Size = New System.Drawing.Size(96, 64)
        Me.cmd040805.TabIndex = 107
        Me.cmd040805.Tag = "itm153"
        Me.cmd040805.Visible = False
        '
        'cmd040802
        '
        Me.cmd040802.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040802.Image = CType(resources.GetObject("cmd040802.Image"), System.Drawing.Image)
        Me.cmd040802.Location = New System.Drawing.Point(836, 96)
        Me.cmd040802.Name = "cmd040802"
        Me.cmd040802.Size = New System.Drawing.Size(96, 64)
        Me.cmd040802.TabIndex = 106
        Me.cmd040802.Tag = "itm120"
        Me.cmd040802.Visible = False
        '
        'cmd040803
        '
        Me.cmd040803.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040803.Image = CType(resources.GetObject("cmd040803.Image"), System.Drawing.Image)
        Me.cmd040803.Location = New System.Drawing.Point(836, 176)
        Me.cmd040803.Name = "cmd040803"
        Me.cmd040803.Size = New System.Drawing.Size(96, 64)
        Me.cmd040803.TabIndex = 105
        Me.cmd040803.Tag = "itm121"
        Me.cmd040803.Visible = False
        '
        'cmd040804
        '
        Me.cmd040804.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040804.Image = CType(resources.GetObject("cmd040804.Image"), System.Drawing.Image)
        Me.cmd040804.Location = New System.Drawing.Point(836, 256)
        Me.cmd040804.Name = "cmd040804"
        Me.cmd040804.Size = New System.Drawing.Size(96, 64)
        Me.cmd040804.TabIndex = 104
        Me.cmd040804.Tag = "itm125"
        Me.cmd040804.Visible = False
        '
        'cmd040801
        '
        Me.cmd040801.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040801.Image = CType(resources.GetObject("cmd040801.Image"), System.Drawing.Image)
        Me.cmd040801.Location = New System.Drawing.Point(836, 16)
        Me.cmd040801.Name = "cmd040801"
        Me.cmd040801.Size = New System.Drawing.Size(96, 64)
        Me.cmd040801.TabIndex = 102
        Me.cmd040801.Tag = "itm119"
        Me.cmd040801.Visible = False
        '
        'cmd040702
        '
        Me.cmd040702.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040702.Image = CType(resources.GetObject("cmd040702.Image"), System.Drawing.Image)
        Me.cmd040702.Location = New System.Drawing.Point(719, 96)
        Me.cmd040702.Name = "cmd040702"
        Me.cmd040702.Size = New System.Drawing.Size(96, 64)
        Me.cmd040702.TabIndex = 101
        Me.cmd040702.Tag = "itm114"
        Me.cmd040702.Visible = False
        '
        'cmd040703
        '
        Me.cmd040703.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040703.Image = CType(resources.GetObject("cmd040703.Image"), System.Drawing.Image)
        Me.cmd040703.Location = New System.Drawing.Point(719, 176)
        Me.cmd040703.Name = "cmd040703"
        Me.cmd040703.Size = New System.Drawing.Size(96, 64)
        Me.cmd040703.TabIndex = 100
        Me.cmd040703.Tag = "itm116"
        Me.cmd040703.Visible = False
        '
        'cmd040704
        '
        Me.cmd040704.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040704.Image = CType(resources.GetObject("cmd040704.Image"), System.Drawing.Image)
        Me.cmd040704.Location = New System.Drawing.Point(719, 256)
        Me.cmd040704.Name = "cmd040704"
        Me.cmd040704.Size = New System.Drawing.Size(96, 64)
        Me.cmd040704.TabIndex = 99
        Me.cmd040704.Tag = "itm124"
        Me.cmd040704.Visible = False
        '
        'cmd040701
        '
        Me.cmd040701.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040701.Image = CType(resources.GetObject("cmd040701.Image"), System.Drawing.Image)
        Me.cmd040701.Location = New System.Drawing.Point(719, 16)
        Me.cmd040701.Name = "cmd040701"
        Me.cmd040701.Size = New System.Drawing.Size(96, 64)
        Me.cmd040701.TabIndex = 97
        Me.cmd040701.Tag = "itm113"
        Me.cmd040701.Visible = False
        '
        'cmd040602
        '
        Me.cmd040602.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040602.Image = CType(resources.GetObject("cmd040602.Image"), System.Drawing.Image)
        Me.cmd040602.Location = New System.Drawing.Point(602, 96)
        Me.cmd040602.Name = "cmd040602"
        Me.cmd040602.Size = New System.Drawing.Size(96, 64)
        Me.cmd040602.TabIndex = 96
        Me.cmd040602.Tag = "itm115"
        Me.cmd040602.Visible = False
        '
        'cmd040603
        '
        Me.cmd040603.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040603.Image = CType(resources.GetObject("cmd040603.Image"), System.Drawing.Image)
        Me.cmd040603.Location = New System.Drawing.Point(602, 176)
        Me.cmd040603.Name = "cmd040603"
        Me.cmd040603.Size = New System.Drawing.Size(96, 64)
        Me.cmd040603.TabIndex = 95
        Me.cmd040603.Tag = "itm122"
        Me.cmd040603.Visible = False
        '
        'cmd040604
        '
        Me.cmd040604.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040604.Image = CType(resources.GetObject("cmd040604.Image"), System.Drawing.Image)
        Me.cmd040604.Location = New System.Drawing.Point(602, 256)
        Me.cmd040604.Name = "cmd040604"
        Me.cmd040604.Size = New System.Drawing.Size(96, 64)
        Me.cmd040604.TabIndex = 94
        Me.cmd040604.Tag = "itm123"
        Me.cmd040604.Visible = False
        '
        'cmd040601
        '
        Me.cmd040601.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040601.Image = CType(resources.GetObject("cmd040601.Image"), System.Drawing.Image)
        Me.cmd040601.Location = New System.Drawing.Point(602, 16)
        Me.cmd040601.Name = "cmd040601"
        Me.cmd040601.Size = New System.Drawing.Size(96, 64)
        Me.cmd040601.TabIndex = 92
        Me.cmd040601.Tag = "itm117"
        Me.cmd040601.Visible = False
        '
        'cmd040302
        '
        Me.cmd040302.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040302.Image = CType(resources.GetObject("cmd040302.Image"), System.Drawing.Image)
        Me.cmd040302.Location = New System.Drawing.Point(251, 96)
        Me.cmd040302.Name = "cmd040302"
        Me.cmd040302.Size = New System.Drawing.Size(96, 64)
        Me.cmd040302.TabIndex = 81
        Me.cmd040302.Tag = "itm132"
        Me.cmd040302.Visible = False
        '
        'cmd040301
        '
        Me.cmd040301.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040301.Image = CType(resources.GetObject("cmd040301.Image"), System.Drawing.Image)
        Me.cmd040301.Location = New System.Drawing.Point(251, 16)
        Me.cmd040301.Name = "cmd040301"
        Me.cmd040301.Size = New System.Drawing.Size(96, 64)
        Me.cmd040301.TabIndex = 77
        Me.cmd040301.Tag = "itm131"
        Me.cmd040301.Visible = False
        '
        'cmd040202
        '
        Me.cmd040202.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040202.Image = CType(resources.GetObject("cmd040202.Image"), System.Drawing.Image)
        Me.cmd040202.Location = New System.Drawing.Point(134, 96)
        Me.cmd040202.Name = "cmd040202"
        Me.cmd040202.Size = New System.Drawing.Size(96, 64)
        Me.cmd040202.TabIndex = 76
        Me.cmd040202.Tag = "itm130"
        Me.cmd040202.Visible = False
        '
        'cmd040201
        '
        Me.cmd040201.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040201.Image = CType(resources.GetObject("cmd040201.Image"), System.Drawing.Image)
        Me.cmd040201.Location = New System.Drawing.Point(134, 16)
        Me.cmd040201.Name = "cmd040201"
        Me.cmd040201.Size = New System.Drawing.Size(96, 64)
        Me.cmd040201.TabIndex = 72
        Me.cmd040201.Tag = "itm129"
        Me.cmd040201.Visible = False
        '
        'cmd040102
        '
        Me.cmd040102.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040102.Image = CType(resources.GetObject("cmd040102.Image"), System.Drawing.Image)
        Me.cmd040102.Location = New System.Drawing.Point(17, 96)
        Me.cmd040102.Name = "cmd040102"
        Me.cmd040102.Size = New System.Drawing.Size(96, 64)
        Me.cmd040102.TabIndex = 63
        Me.cmd040102.Tag = "itm127"
        Me.cmd040102.Visible = False
        '
        'cmd040103
        '
        Me.cmd040103.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040103.Image = CType(resources.GetObject("cmd040103.Image"), System.Drawing.Image)
        Me.cmd040103.Location = New System.Drawing.Point(17, 176)
        Me.cmd040103.Name = "cmd040103"
        Me.cmd040103.Size = New System.Drawing.Size(96, 64)
        Me.cmd040103.TabIndex = 62
        Me.cmd040103.Tag = "itm128"
        Me.cmd040103.Visible = False
        '
        'cmd040101
        '
        Me.cmd040101.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd040101.Image = CType(resources.GetObject("cmd040101.Image"), System.Drawing.Image)
        Me.cmd040101.Location = New System.Drawing.Point(17, 16)
        Me.cmd040101.Name = "cmd040101"
        Me.cmd040101.Size = New System.Drawing.Size(96, 64)
        Me.cmd040101.TabIndex = 59
        Me.cmd040101.Tag = "itm126"
        Me.cmd040101.Visible = False
        '
        'TabPage7
        '
        Me.TabPage7.BackgroundImage = CType(resources.GetObject("TabPage7.BackgroundImage"), System.Drawing.Image)
        Me.TabPage7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage7.Controls.Add(Me.cmd050806)
        Me.TabPage7.Controls.Add(Me.cmd050805)
        Me.TabPage7.Controls.Add(Me.cmd050804)
        Me.TabPage7.Controls.Add(Me.cmd050803)
        Me.TabPage7.Controls.Add(Me.cmd050706)
        Me.TabPage7.Controls.Add(Me.cmd050703)
        Me.TabPage7.Controls.Add(Me.cmd050701)
        Me.TabPage7.Controls.Add(Me.cmd050606)
        Me.TabPage7.Controls.Add(Me.cmd050603)
        Me.TabPage7.Controls.Add(Me.cmd050506)
        Me.TabPage7.Controls.Add(Me.cmd050503)
        Me.TabPage7.Controls.Add(Me.cmd050406)
        Me.TabPage7.Controls.Add(Me.cmd050405)
        Me.TabPage7.Controls.Add(Me.cmd050404)
        Me.TabPage7.Controls.Add(Me.cmd050403)
        Me.TabPage7.Controls.Add(Me.cmd050402)
        Me.TabPage7.Controls.Add(Me.cmd050401)
        Me.TabPage7.Controls.Add(Me.cmd050305)
        Me.TabPage7.Controls.Add(Me.cmd050304)
        Me.TabPage7.Controls.Add(Me.cmd050303)
        Me.TabPage7.Controls.Add(Me.cmd050205)
        Me.TabPage7.Controls.Add(Me.cmd050204)
        Me.TabPage7.Controls.Add(Me.cmd050203)
        Me.TabPage7.Controls.Add(Me.cmd050105)
        Me.TabPage7.Controls.Add(Me.cmd050104)
        Me.TabPage7.Controls.Add(Me.cmd050206)
        Me.TabPage7.Controls.Add(Me.cmd050306)
        Me.TabPage7.Controls.Add(Me.cmd050106)
        Me.TabPage7.Controls.Add(Me.cmd050802)
        Me.TabPage7.Controls.Add(Me.cmd050801)
        Me.TabPage7.Controls.Add(Me.cmd050702)
        Me.TabPage7.Controls.Add(Me.cmd050704)
        Me.TabPage7.Controls.Add(Me.cmd050705)
        Me.TabPage7.Controls.Add(Me.cmd050602)
        Me.TabPage7.Controls.Add(Me.cmd050604)
        Me.TabPage7.Controls.Add(Me.cmd050605)
        Me.TabPage7.Controls.Add(Me.cmd050601)
        Me.TabPage7.Controls.Add(Me.cmd050502)
        Me.TabPage7.Controls.Add(Me.cmd050504)
        Me.TabPage7.Controls.Add(Me.cmd050505)
        Me.TabPage7.Controls.Add(Me.cmd050501)
        Me.TabPage7.Controls.Add(Me.cmd050302)
        Me.TabPage7.Controls.Add(Me.cmd050301)
        Me.TabPage7.Controls.Add(Me.cmd050202)
        Me.TabPage7.Controls.Add(Me.cmd050201)
        Me.TabPage7.Controls.Add(Me.cmd050102)
        Me.TabPage7.Controls.Add(Me.cmd050103)
        Me.TabPage7.Controls.Add(Me.cmd050101)
        Me.TabPage7.Location = New System.Drawing.Point(4, 32)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(952, 500)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Beverages/Ala Cart"
        '
        'cmd050806
        '
        Me.cmd050806.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050806.Location = New System.Drawing.Point(836, 416)
        Me.cmd050806.Name = "cmd050806"
        Me.cmd050806.Size = New System.Drawing.Size(96, 64)
        Me.cmd050806.TabIndex = 150
        Me.cmd050806.Tag = ""
        Me.cmd050806.Visible = False
        '
        'cmd050805
        '
        Me.cmd050805.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050805.Location = New System.Drawing.Point(836, 336)
        Me.cmd050805.Name = "cmd050805"
        Me.cmd050805.Size = New System.Drawing.Size(96, 64)
        Me.cmd050805.TabIndex = 149
        Me.cmd050805.Tag = ""
        Me.cmd050805.Visible = False
        '
        'cmd050804
        '
        Me.cmd050804.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050804.Location = New System.Drawing.Point(836, 256)
        Me.cmd050804.Name = "cmd050804"
        Me.cmd050804.Size = New System.Drawing.Size(96, 64)
        Me.cmd050804.TabIndex = 148
        Me.cmd050804.Tag = ""
        Me.cmd050804.Visible = False
        '
        'cmd050803
        '
        Me.cmd050803.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050803.Location = New System.Drawing.Point(836, 176)
        Me.cmd050803.Name = "cmd050803"
        Me.cmd050803.Size = New System.Drawing.Size(96, 64)
        Me.cmd050803.TabIndex = 147
        Me.cmd050803.Tag = ""
        Me.cmd050803.Visible = False
        '
        'cmd050706
        '
        Me.cmd050706.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050706.Location = New System.Drawing.Point(719, 416)
        Me.cmd050706.Name = "cmd050706"
        Me.cmd050706.Size = New System.Drawing.Size(96, 64)
        Me.cmd050706.TabIndex = 146
        Me.cmd050706.Tag = ""
        Me.cmd050706.Visible = False
        '
        'cmd050703
        '
        Me.cmd050703.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050703.Location = New System.Drawing.Point(719, 176)
        Me.cmd050703.Name = "cmd050703"
        Me.cmd050703.Size = New System.Drawing.Size(96, 64)
        Me.cmd050703.TabIndex = 145
        Me.cmd050703.Tag = ""
        Me.cmd050703.Visible = False
        '
        'cmd050701
        '
        Me.cmd050701.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050701.Location = New System.Drawing.Point(719, 16)
        Me.cmd050701.Name = "cmd050701"
        Me.cmd050701.Size = New System.Drawing.Size(96, 64)
        Me.cmd050701.TabIndex = 144
        Me.cmd050701.Tag = ""
        Me.cmd050701.Visible = False
        '
        'cmd050606
        '
        Me.cmd050606.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050606.Location = New System.Drawing.Point(602, 416)
        Me.cmd050606.Name = "cmd050606"
        Me.cmd050606.Size = New System.Drawing.Size(96, 64)
        Me.cmd050606.TabIndex = 143
        Me.cmd050606.Tag = ""
        Me.cmd050606.Visible = False
        '
        'cmd050603
        '
        Me.cmd050603.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050603.Location = New System.Drawing.Point(602, 176)
        Me.cmd050603.Name = "cmd050603"
        Me.cmd050603.Size = New System.Drawing.Size(96, 64)
        Me.cmd050603.TabIndex = 142
        Me.cmd050603.Tag = ""
        Me.cmd050603.Visible = False
        '
        'cmd050506
        '
        Me.cmd050506.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050506.Location = New System.Drawing.Point(485, 416)
        Me.cmd050506.Name = "cmd050506"
        Me.cmd050506.Size = New System.Drawing.Size(96, 64)
        Me.cmd050506.TabIndex = 141
        Me.cmd050506.Tag = ""
        Me.cmd050506.Visible = False
        '
        'cmd050503
        '
        Me.cmd050503.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050503.Location = New System.Drawing.Point(485, 176)
        Me.cmd050503.Name = "cmd050503"
        Me.cmd050503.Size = New System.Drawing.Size(96, 64)
        Me.cmd050503.TabIndex = 140
        Me.cmd050503.Tag = ""
        Me.cmd050503.Visible = False
        '
        'cmd050406
        '
        Me.cmd050406.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050406.Location = New System.Drawing.Point(368, 416)
        Me.cmd050406.Name = "cmd050406"
        Me.cmd050406.Size = New System.Drawing.Size(96, 64)
        Me.cmd050406.TabIndex = 139
        Me.cmd050406.Tag = ""
        Me.cmd050406.Visible = False
        '
        'cmd050405
        '
        Me.cmd050405.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050405.Location = New System.Drawing.Point(368, 336)
        Me.cmd050405.Name = "cmd050405"
        Me.cmd050405.Size = New System.Drawing.Size(96, 64)
        Me.cmd050405.TabIndex = 138
        Me.cmd050405.Tag = ""
        Me.cmd050405.Visible = False
        '
        'cmd050404
        '
        Me.cmd050404.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050404.Location = New System.Drawing.Point(368, 256)
        Me.cmd050404.Name = "cmd050404"
        Me.cmd050404.Size = New System.Drawing.Size(96, 64)
        Me.cmd050404.TabIndex = 137
        Me.cmd050404.Tag = ""
        Me.cmd050404.Visible = False
        '
        'cmd050403
        '
        Me.cmd050403.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050403.Location = New System.Drawing.Point(368, 176)
        Me.cmd050403.Name = "cmd050403"
        Me.cmd050403.Size = New System.Drawing.Size(96, 64)
        Me.cmd050403.TabIndex = 136
        Me.cmd050403.Tag = ""
        Me.cmd050403.Visible = False
        '
        'cmd050402
        '
        Me.cmd050402.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050402.Location = New System.Drawing.Point(368, 96)
        Me.cmd050402.Name = "cmd050402"
        Me.cmd050402.Size = New System.Drawing.Size(96, 64)
        Me.cmd050402.TabIndex = 135
        Me.cmd050402.Tag = ""
        Me.cmd050402.Visible = False
        '
        'cmd050401
        '
        Me.cmd050401.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050401.Location = New System.Drawing.Point(368, 16)
        Me.cmd050401.Name = "cmd050401"
        Me.cmd050401.Size = New System.Drawing.Size(96, 64)
        Me.cmd050401.TabIndex = 134
        Me.cmd050401.Tag = ""
        Me.cmd050401.Visible = False
        '
        'cmd050305
        '
        Me.cmd050305.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050305.Location = New System.Drawing.Point(251, 336)
        Me.cmd050305.Name = "cmd050305"
        Me.cmd050305.Size = New System.Drawing.Size(96, 64)
        Me.cmd050305.TabIndex = 133
        Me.cmd050305.Tag = ""
        Me.cmd050305.Visible = False
        '
        'cmd050304
        '
        Me.cmd050304.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050304.Location = New System.Drawing.Point(251, 256)
        Me.cmd050304.Name = "cmd050304"
        Me.cmd050304.Size = New System.Drawing.Size(96, 64)
        Me.cmd050304.TabIndex = 132
        Me.cmd050304.Tag = ""
        Me.cmd050304.Visible = False
        '
        'cmd050303
        '
        Me.cmd050303.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050303.Location = New System.Drawing.Point(251, 176)
        Me.cmd050303.Name = "cmd050303"
        Me.cmd050303.Size = New System.Drawing.Size(96, 64)
        Me.cmd050303.TabIndex = 131
        Me.cmd050303.Tag = ""
        Me.cmd050303.Visible = False
        '
        'cmd050205
        '
        Me.cmd050205.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050205.Location = New System.Drawing.Point(134, 336)
        Me.cmd050205.Name = "cmd050205"
        Me.cmd050205.Size = New System.Drawing.Size(96, 64)
        Me.cmd050205.TabIndex = 130
        Me.cmd050205.Tag = ""
        Me.cmd050205.Visible = False
        '
        'cmd050204
        '
        Me.cmd050204.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050204.Location = New System.Drawing.Point(134, 256)
        Me.cmd050204.Name = "cmd050204"
        Me.cmd050204.Size = New System.Drawing.Size(96, 64)
        Me.cmd050204.TabIndex = 129
        Me.cmd050204.Tag = ""
        Me.cmd050204.Visible = False
        '
        'cmd050203
        '
        Me.cmd050203.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050203.Location = New System.Drawing.Point(134, 176)
        Me.cmd050203.Name = "cmd050203"
        Me.cmd050203.Size = New System.Drawing.Size(96, 64)
        Me.cmd050203.TabIndex = 128
        Me.cmd050203.Tag = ""
        Me.cmd050203.Visible = False
        '
        'cmd050105
        '
        Me.cmd050105.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050105.Location = New System.Drawing.Point(17, 336)
        Me.cmd050105.Name = "cmd050105"
        Me.cmd050105.Size = New System.Drawing.Size(96, 64)
        Me.cmd050105.TabIndex = 127
        Me.cmd050105.Tag = ""
        Me.cmd050105.Visible = False
        '
        'cmd050104
        '
        Me.cmd050104.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050104.Location = New System.Drawing.Point(17, 256)
        Me.cmd050104.Name = "cmd050104"
        Me.cmd050104.Size = New System.Drawing.Size(96, 64)
        Me.cmd050104.TabIndex = 126
        Me.cmd050104.Tag = ""
        Me.cmd050104.Visible = False
        '
        'cmd050206
        '
        Me.cmd050206.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050206.Image = CType(resources.GetObject("cmd050206.Image"), System.Drawing.Image)
        Me.cmd050206.Location = New System.Drawing.Point(134, 416)
        Me.cmd050206.Name = "cmd050206"
        Me.cmd050206.Size = New System.Drawing.Size(96, 64)
        Me.cmd050206.TabIndex = 109
        Me.cmd050206.Tag = "itm016"
        Me.cmd050206.Visible = False
        '
        'cmd050306
        '
        Me.cmd050306.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050306.Image = CType(resources.GetObject("cmd050306.Image"), System.Drawing.Image)
        Me.cmd050306.Location = New System.Drawing.Point(251, 416)
        Me.cmd050306.Name = "cmd050306"
        Me.cmd050306.Size = New System.Drawing.Size(96, 64)
        Me.cmd050306.TabIndex = 108
        Me.cmd050306.Tag = "itm017"
        Me.cmd050306.Visible = False
        '
        'cmd050106
        '
        Me.cmd050106.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050106.Image = CType(resources.GetObject("cmd050106.Image"), System.Drawing.Image)
        Me.cmd050106.Location = New System.Drawing.Point(17, 416)
        Me.cmd050106.Name = "cmd050106"
        Me.cmd050106.Size = New System.Drawing.Size(96, 64)
        Me.cmd050106.TabIndex = 107
        Me.cmd050106.Tag = "itm015"
        Me.cmd050106.Visible = False
        '
        'cmd050802
        '
        Me.cmd050802.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050802.Image = CType(resources.GetObject("cmd050802.Image"), System.Drawing.Image)
        Me.cmd050802.Location = New System.Drawing.Point(836, 96)
        Me.cmd050802.Name = "cmd050802"
        Me.cmd050802.Size = New System.Drawing.Size(96, 64)
        Me.cmd050802.TabIndex = 106
        Me.cmd050802.Tag = "itm135"
        Me.cmd050802.Visible = False
        '
        'cmd050801
        '
        Me.cmd050801.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050801.Image = CType(resources.GetObject("cmd050801.Image"), System.Drawing.Image)
        Me.cmd050801.Location = New System.Drawing.Point(836, 16)
        Me.cmd050801.Name = "cmd050801"
        Me.cmd050801.Size = New System.Drawing.Size(96, 64)
        Me.cmd050801.TabIndex = 102
        Me.cmd050801.Tag = "itm136"
        Me.cmd050801.Visible = False
        '
        'cmd050702
        '
        Me.cmd050702.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050702.Image = CType(resources.GetObject("cmd050702.Image"), System.Drawing.Image)
        Me.cmd050702.Location = New System.Drawing.Point(719, 96)
        Me.cmd050702.Name = "cmd050702"
        Me.cmd050702.Size = New System.Drawing.Size(96, 64)
        Me.cmd050702.TabIndex = 101
        Me.cmd050702.Tag = "itm140"
        Me.cmd050702.Visible = False
        '
        'cmd050704
        '
        Me.cmd050704.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050704.Image = CType(resources.GetObject("cmd050704.Image"), System.Drawing.Image)
        Me.cmd050704.Location = New System.Drawing.Point(719, 256)
        Me.cmd050704.Name = "cmd050704"
        Me.cmd050704.Size = New System.Drawing.Size(96, 64)
        Me.cmd050704.TabIndex = 99
        Me.cmd050704.Tag = "itm139"
        Me.cmd050704.Visible = False
        '
        'cmd050705
        '
        Me.cmd050705.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050705.Image = CType(resources.GetObject("cmd050705.Image"), System.Drawing.Image)
        Me.cmd050705.Location = New System.Drawing.Point(719, 336)
        Me.cmd050705.Name = "cmd050705"
        Me.cmd050705.Size = New System.Drawing.Size(96, 64)
        Me.cmd050705.TabIndex = 98
        Me.cmd050705.Tag = "itm145"
        Me.cmd050705.Visible = False
        '
        'cmd050602
        '
        Me.cmd050602.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050602.Image = CType(resources.GetObject("cmd050602.Image"), System.Drawing.Image)
        Me.cmd050602.Location = New System.Drawing.Point(602, 96)
        Me.cmd050602.Name = "cmd050602"
        Me.cmd050602.Size = New System.Drawing.Size(96, 64)
        Me.cmd050602.TabIndex = 96
        Me.cmd050602.Tag = "itm143"
        Me.cmd050602.Visible = False
        '
        'cmd050604
        '
        Me.cmd050604.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050604.Image = CType(resources.GetObject("cmd050604.Image"), System.Drawing.Image)
        Me.cmd050604.Location = New System.Drawing.Point(602, 256)
        Me.cmd050604.Name = "cmd050604"
        Me.cmd050604.Size = New System.Drawing.Size(96, 64)
        Me.cmd050604.TabIndex = 94
        Me.cmd050604.Tag = "itm137"
        Me.cmd050604.Visible = False
        '
        'cmd050605
        '
        Me.cmd050605.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050605.Image = CType(resources.GetObject("cmd050605.Image"), System.Drawing.Image)
        Me.cmd050605.Location = New System.Drawing.Point(602, 336)
        Me.cmd050605.Name = "cmd050605"
        Me.cmd050605.Size = New System.Drawing.Size(96, 64)
        Me.cmd050605.TabIndex = 93
        Me.cmd050605.Tag = "itm138"
        Me.cmd050605.Visible = False
        '
        'cmd050601
        '
        Me.cmd050601.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050601.Image = CType(resources.GetObject("cmd050601.Image"), System.Drawing.Image)
        Me.cmd050601.Location = New System.Drawing.Point(602, 16)
        Me.cmd050601.Name = "cmd050601"
        Me.cmd050601.Size = New System.Drawing.Size(96, 64)
        Me.cmd050601.TabIndex = 92
        Me.cmd050601.Tag = "itm144"
        Me.cmd050601.Visible = False
        '
        'cmd050502
        '
        Me.cmd050502.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050502.Image = CType(resources.GetObject("cmd050502.Image"), System.Drawing.Image)
        Me.cmd050502.Location = New System.Drawing.Point(485, 96)
        Me.cmd050502.Name = "cmd050502"
        Me.cmd050502.Size = New System.Drawing.Size(96, 64)
        Me.cmd050502.TabIndex = 91
        Me.cmd050502.Tag = "itm141"
        Me.cmd050502.Visible = False
        '
        'cmd050504
        '
        Me.cmd050504.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050504.Image = CType(resources.GetObject("cmd050504.Image"), System.Drawing.Image)
        Me.cmd050504.Location = New System.Drawing.Point(485, 256)
        Me.cmd050504.Name = "cmd050504"
        Me.cmd050504.Size = New System.Drawing.Size(96, 64)
        Me.cmd050504.TabIndex = 89
        Me.cmd050504.Tag = "itm134"
        Me.cmd050504.Visible = False
        '
        'cmd050505
        '
        Me.cmd050505.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050505.Image = CType(resources.GetObject("cmd050505.Image"), System.Drawing.Image)
        Me.cmd050505.Location = New System.Drawing.Point(485, 336)
        Me.cmd050505.Name = "cmd050505"
        Me.cmd050505.Size = New System.Drawing.Size(96, 64)
        Me.cmd050505.TabIndex = 88
        Me.cmd050505.Tag = "itm133"
        Me.cmd050505.Visible = False
        '
        'cmd050501
        '
        Me.cmd050501.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050501.Image = CType(resources.GetObject("cmd050501.Image"), System.Drawing.Image)
        Me.cmd050501.Location = New System.Drawing.Point(485, 16)
        Me.cmd050501.Name = "cmd050501"
        Me.cmd050501.Size = New System.Drawing.Size(96, 64)
        Me.cmd050501.TabIndex = 87
        Me.cmd050501.Tag = "itm142"
        Me.cmd050501.Visible = False
        '
        'cmd050302
        '
        Me.cmd050302.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050302.Image = CType(resources.GetObject("cmd050302.Image"), System.Drawing.Image)
        Me.cmd050302.Location = New System.Drawing.Point(251, 96)
        Me.cmd050302.Name = "cmd050302"
        Me.cmd050302.Size = New System.Drawing.Size(96, 64)
        Me.cmd050302.TabIndex = 81
        Me.cmd050302.Tag = "itm151"
        Me.cmd050302.Visible = False
        '
        'cmd050301
        '
        Me.cmd050301.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050301.Image = CType(resources.GetObject("cmd050301.Image"), System.Drawing.Image)
        Me.cmd050301.Location = New System.Drawing.Point(251, 16)
        Me.cmd050301.Name = "cmd050301"
        Me.cmd050301.Size = New System.Drawing.Size(96, 64)
        Me.cmd050301.TabIndex = 77
        Me.cmd050301.Tag = "itm152"
        Me.cmd050301.Visible = False
        '
        'cmd050202
        '
        Me.cmd050202.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050202.Image = CType(resources.GetObject("cmd050202.Image"), System.Drawing.Image)
        Me.cmd050202.Location = New System.Drawing.Point(134, 96)
        Me.cmd050202.Name = "cmd050202"
        Me.cmd050202.Size = New System.Drawing.Size(96, 64)
        Me.cmd050202.TabIndex = 76
        Me.cmd050202.Tag = "itm149"
        Me.cmd050202.Visible = False
        '
        'cmd050201
        '
        Me.cmd050201.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050201.Image = CType(resources.GetObject("cmd050201.Image"), System.Drawing.Image)
        Me.cmd050201.Location = New System.Drawing.Point(134, 16)
        Me.cmd050201.Name = "cmd050201"
        Me.cmd050201.Size = New System.Drawing.Size(96, 64)
        Me.cmd050201.TabIndex = 72
        Me.cmd050201.Tag = "itm150"
        Me.cmd050201.Visible = False
        '
        'cmd050102
        '
        Me.cmd050102.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050102.Image = CType(resources.GetObject("cmd050102.Image"), System.Drawing.Image)
        Me.cmd050102.Location = New System.Drawing.Point(17, 96)
        Me.cmd050102.Name = "cmd050102"
        Me.cmd050102.Size = New System.Drawing.Size(96, 64)
        Me.cmd050102.TabIndex = 63
        Me.cmd050102.Tag = "itm147"
        Me.cmd050102.Visible = False
        '
        'cmd050103
        '
        Me.cmd050103.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050103.Image = CType(resources.GetObject("cmd050103.Image"), System.Drawing.Image)
        Me.cmd050103.Location = New System.Drawing.Point(17, 176)
        Me.cmd050103.Name = "cmd050103"
        Me.cmd050103.Size = New System.Drawing.Size(96, 64)
        Me.cmd050103.TabIndex = 62
        Me.cmd050103.Tag = "itm148"
        Me.cmd050103.Visible = False
        '
        'cmd050101
        '
        Me.cmd050101.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd050101.Image = CType(resources.GetObject("cmd050101.Image"), System.Drawing.Image)
        Me.cmd050101.Location = New System.Drawing.Point(17, 16)
        Me.cmd050101.Name = "cmd050101"
        Me.cmd050101.Size = New System.Drawing.Size(96, 64)
        Me.cmd050101.TabIndex = 59
        Me.cmd050101.Tag = "itm146"
        Me.cmd050101.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage4.Controls.Add(Me.cmd060806)
        Me.TabPage4.Controls.Add(Me.cmd060805)
        Me.TabPage4.Controls.Add(Me.cmd060804)
        Me.TabPage4.Controls.Add(Me.cmd060803)
        Me.TabPage4.Controls.Add(Me.cmd060802)
        Me.TabPage4.Controls.Add(Me.cmd060706)
        Me.TabPage4.Controls.Add(Me.cmd060705)
        Me.TabPage4.Controls.Add(Me.cmd060703)
        Me.TabPage4.Controls.Add(Me.cmd060702)
        Me.TabPage4.Controls.Add(Me.cmd060704)
        Me.TabPage4.Controls.Add(Me.cmd060606)
        Me.TabPage4.Controls.Add(Me.cmd060605)
        Me.TabPage4.Controls.Add(Me.cmd060604)
        Me.TabPage4.Controls.Add(Me.cmd060603)
        Me.TabPage4.Controls.Add(Me.cmd060506)
        Me.TabPage4.Controls.Add(Me.cmd060505)
        Me.TabPage4.Controls.Add(Me.cmd060504)
        Me.TabPage4.Controls.Add(Me.cmd060503)
        Me.TabPage4.Controls.Add(Me.cmd060406)
        Me.TabPage4.Controls.Add(Me.cmd060405)
        Me.TabPage4.Controls.Add(Me.cmd060404)
        Me.TabPage4.Controls.Add(Me.cmd060403)
        Me.TabPage4.Controls.Add(Me.cmd060306)
        Me.TabPage4.Controls.Add(Me.cmd060305)
        Me.TabPage4.Controls.Add(Me.cmd060304)
        Me.TabPage4.Controls.Add(Me.cmd060303)
        Me.TabPage4.Controls.Add(Me.cmd060302)
        Me.TabPage4.Controls.Add(Me.cmd060206)
        Me.TabPage4.Controls.Add(Me.cmd060205)
        Me.TabPage4.Controls.Add(Me.cmd060204)
        Me.TabPage4.Controls.Add(Me.cmd060203)
        Me.TabPage4.Controls.Add(Me.cmd060202)
        Me.TabPage4.Controls.Add(Me.cmd060106)
        Me.TabPage4.Controls.Add(Me.cmd060105)
        Me.TabPage4.Controls.Add(Me.cmd060104)
        Me.TabPage4.Controls.Add(Me.cmd060103)
        Me.TabPage4.Controls.Add(Me.cmd060801)
        Me.TabPage4.Controls.Add(Me.cmd060701)
        Me.TabPage4.Controls.Add(Me.cmd060602)
        Me.TabPage4.Controls.Add(Me.cmd060601)
        Me.TabPage4.Controls.Add(Me.cmd060502)
        Me.TabPage4.Controls.Add(Me.cmd060501)
        Me.TabPage4.Controls.Add(Me.cmd060402)
        Me.TabPage4.Controls.Add(Me.cmd060401)
        Me.TabPage4.Controls.Add(Me.cmd060301)
        Me.TabPage4.Controls.Add(Me.cmd060201)
        Me.TabPage4.Controls.Add(Me.cmd060102)
        Me.TabPage4.Controls.Add(Me.cmd060101)
        Me.TabPage4.Location = New System.Drawing.Point(4, 32)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(952, 500)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Appetizers"
        '
        'cmd060806
        '
        Me.cmd060806.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060806.Location = New System.Drawing.Point(836, 416)
        Me.cmd060806.Name = "cmd060806"
        Me.cmd060806.Size = New System.Drawing.Size(96, 64)
        Me.cmd060806.TabIndex = 160
        Me.cmd060806.Tag = ""
        Me.cmd060806.Visible = False
        '
        'cmd060805
        '
        Me.cmd060805.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060805.Location = New System.Drawing.Point(836, 336)
        Me.cmd060805.Name = "cmd060805"
        Me.cmd060805.Size = New System.Drawing.Size(96, 64)
        Me.cmd060805.TabIndex = 159
        Me.cmd060805.Tag = ""
        Me.cmd060805.Visible = False
        '
        'cmd060804
        '
        Me.cmd060804.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060804.Location = New System.Drawing.Point(836, 256)
        Me.cmd060804.Name = "cmd060804"
        Me.cmd060804.Size = New System.Drawing.Size(96, 64)
        Me.cmd060804.TabIndex = 158
        Me.cmd060804.Tag = ""
        Me.cmd060804.Visible = False
        '
        'cmd060803
        '
        Me.cmd060803.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060803.Location = New System.Drawing.Point(836, 176)
        Me.cmd060803.Name = "cmd060803"
        Me.cmd060803.Size = New System.Drawing.Size(96, 64)
        Me.cmd060803.TabIndex = 157
        Me.cmd060803.Tag = ""
        Me.cmd060803.Visible = False
        '
        'cmd060802
        '
        Me.cmd060802.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060802.Location = New System.Drawing.Point(836, 96)
        Me.cmd060802.Name = "cmd060802"
        Me.cmd060802.Size = New System.Drawing.Size(96, 64)
        Me.cmd060802.TabIndex = 156
        Me.cmd060802.Tag = ""
        Me.cmd060802.Visible = False
        '
        'cmd060706
        '
        Me.cmd060706.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060706.Location = New System.Drawing.Point(719, 416)
        Me.cmd060706.Name = "cmd060706"
        Me.cmd060706.Size = New System.Drawing.Size(96, 64)
        Me.cmd060706.TabIndex = 155
        Me.cmd060706.Tag = ""
        Me.cmd060706.Visible = False
        '
        'cmd060705
        '
        Me.cmd060705.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060705.Location = New System.Drawing.Point(719, 336)
        Me.cmd060705.Name = "cmd060705"
        Me.cmd060705.Size = New System.Drawing.Size(96, 64)
        Me.cmd060705.TabIndex = 154
        Me.cmd060705.Tag = ""
        Me.cmd060705.Visible = False
        '
        'cmd060703
        '
        Me.cmd060703.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060703.Location = New System.Drawing.Point(719, 176)
        Me.cmd060703.Name = "cmd060703"
        Me.cmd060703.Size = New System.Drawing.Size(96, 64)
        Me.cmd060703.TabIndex = 153
        Me.cmd060703.Tag = ""
        Me.cmd060703.Visible = False
        '
        'cmd060702
        '
        Me.cmd060702.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060702.Location = New System.Drawing.Point(719, 96)
        Me.cmd060702.Name = "cmd060702"
        Me.cmd060702.Size = New System.Drawing.Size(96, 64)
        Me.cmd060702.TabIndex = 152
        Me.cmd060702.Tag = ""
        Me.cmd060702.Visible = False
        '
        'cmd060704
        '
        Me.cmd060704.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060704.Location = New System.Drawing.Point(719, 256)
        Me.cmd060704.Name = "cmd060704"
        Me.cmd060704.Size = New System.Drawing.Size(96, 64)
        Me.cmd060704.TabIndex = 152
        Me.cmd060704.Tag = ""
        Me.cmd060704.Visible = False
        '
        'cmd060606
        '
        Me.cmd060606.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060606.Location = New System.Drawing.Point(602, 416)
        Me.cmd060606.Name = "cmd060606"
        Me.cmd060606.Size = New System.Drawing.Size(96, 64)
        Me.cmd060606.TabIndex = 151
        Me.cmd060606.Tag = ""
        Me.cmd060606.Visible = False
        '
        'cmd060605
        '
        Me.cmd060605.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060605.Location = New System.Drawing.Point(602, 336)
        Me.cmd060605.Name = "cmd060605"
        Me.cmd060605.Size = New System.Drawing.Size(96, 64)
        Me.cmd060605.TabIndex = 150
        Me.cmd060605.Tag = ""
        Me.cmd060605.Visible = False
        '
        'cmd060604
        '
        Me.cmd060604.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060604.Location = New System.Drawing.Point(602, 256)
        Me.cmd060604.Name = "cmd060604"
        Me.cmd060604.Size = New System.Drawing.Size(96, 64)
        Me.cmd060604.TabIndex = 149
        Me.cmd060604.Tag = ""
        Me.cmd060604.Visible = False
        '
        'cmd060603
        '
        Me.cmd060603.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060603.Location = New System.Drawing.Point(602, 176)
        Me.cmd060603.Name = "cmd060603"
        Me.cmd060603.Size = New System.Drawing.Size(96, 64)
        Me.cmd060603.TabIndex = 148
        Me.cmd060603.Tag = ""
        Me.cmd060603.Visible = False
        '
        'cmd060506
        '
        Me.cmd060506.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060506.Location = New System.Drawing.Point(485, 416)
        Me.cmd060506.Name = "cmd060506"
        Me.cmd060506.Size = New System.Drawing.Size(96, 64)
        Me.cmd060506.TabIndex = 147
        Me.cmd060506.Tag = ""
        Me.cmd060506.Visible = False
        '
        'cmd060505
        '
        Me.cmd060505.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060505.Location = New System.Drawing.Point(485, 336)
        Me.cmd060505.Name = "cmd060505"
        Me.cmd060505.Size = New System.Drawing.Size(96, 64)
        Me.cmd060505.TabIndex = 146
        Me.cmd060505.Tag = ""
        Me.cmd060505.Visible = False
        '
        'cmd060504
        '
        Me.cmd060504.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060504.Location = New System.Drawing.Point(485, 256)
        Me.cmd060504.Name = "cmd060504"
        Me.cmd060504.Size = New System.Drawing.Size(96, 64)
        Me.cmd060504.TabIndex = 145
        Me.cmd060504.Tag = ""
        Me.cmd060504.Visible = False
        '
        'cmd060503
        '
        Me.cmd060503.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060503.Location = New System.Drawing.Point(485, 176)
        Me.cmd060503.Name = "cmd060503"
        Me.cmd060503.Size = New System.Drawing.Size(96, 64)
        Me.cmd060503.TabIndex = 144
        Me.cmd060503.Tag = ""
        Me.cmd060503.Visible = False
        '
        'cmd060406
        '
        Me.cmd060406.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060406.Location = New System.Drawing.Point(368, 416)
        Me.cmd060406.Name = "cmd060406"
        Me.cmd060406.Size = New System.Drawing.Size(96, 64)
        Me.cmd060406.TabIndex = 143
        Me.cmd060406.Tag = ""
        Me.cmd060406.Visible = False
        '
        'cmd060405
        '
        Me.cmd060405.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060405.Location = New System.Drawing.Point(368, 336)
        Me.cmd060405.Name = "cmd060405"
        Me.cmd060405.Size = New System.Drawing.Size(96, 64)
        Me.cmd060405.TabIndex = 142
        Me.cmd060405.Tag = ""
        Me.cmd060405.Visible = False
        '
        'cmd060404
        '
        Me.cmd060404.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060404.Location = New System.Drawing.Point(368, 256)
        Me.cmd060404.Name = "cmd060404"
        Me.cmd060404.Size = New System.Drawing.Size(96, 64)
        Me.cmd060404.TabIndex = 141
        Me.cmd060404.Tag = ""
        Me.cmd060404.Visible = False
        '
        'cmd060403
        '
        Me.cmd060403.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060403.Location = New System.Drawing.Point(368, 176)
        Me.cmd060403.Name = "cmd060403"
        Me.cmd060403.Size = New System.Drawing.Size(96, 64)
        Me.cmd060403.TabIndex = 140
        Me.cmd060403.Tag = ""
        Me.cmd060403.Visible = False
        '
        'cmd060306
        '
        Me.cmd060306.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060306.Location = New System.Drawing.Point(251, 416)
        Me.cmd060306.Name = "cmd060306"
        Me.cmd060306.Size = New System.Drawing.Size(96, 64)
        Me.cmd060306.TabIndex = 139
        Me.cmd060306.Tag = ""
        Me.cmd060306.Visible = False
        '
        'cmd060305
        '
        Me.cmd060305.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060305.Location = New System.Drawing.Point(251, 336)
        Me.cmd060305.Name = "cmd060305"
        Me.cmd060305.Size = New System.Drawing.Size(96, 64)
        Me.cmd060305.TabIndex = 138
        Me.cmd060305.Tag = ""
        Me.cmd060305.Visible = False
        '
        'cmd060304
        '
        Me.cmd060304.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060304.Location = New System.Drawing.Point(251, 256)
        Me.cmd060304.Name = "cmd060304"
        Me.cmd060304.Size = New System.Drawing.Size(96, 64)
        Me.cmd060304.TabIndex = 137
        Me.cmd060304.Tag = ""
        Me.cmd060304.Visible = False
        '
        'cmd060303
        '
        Me.cmd060303.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060303.Location = New System.Drawing.Point(251, 176)
        Me.cmd060303.Name = "cmd060303"
        Me.cmd060303.Size = New System.Drawing.Size(96, 64)
        Me.cmd060303.TabIndex = 136
        Me.cmd060303.Tag = ""
        Me.cmd060303.Visible = False
        '
        'cmd060302
        '
        Me.cmd060302.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060302.Location = New System.Drawing.Point(251, 96)
        Me.cmd060302.Name = "cmd060302"
        Me.cmd060302.Size = New System.Drawing.Size(96, 64)
        Me.cmd060302.TabIndex = 135
        Me.cmd060302.Tag = ""
        Me.cmd060302.Visible = False
        '
        'cmd060206
        '
        Me.cmd060206.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060206.Location = New System.Drawing.Point(134, 416)
        Me.cmd060206.Name = "cmd060206"
        Me.cmd060206.Size = New System.Drawing.Size(96, 64)
        Me.cmd060206.TabIndex = 134
        Me.cmd060206.Tag = ""
        Me.cmd060206.Visible = False
        '
        'cmd060205
        '
        Me.cmd060205.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060205.Location = New System.Drawing.Point(134, 336)
        Me.cmd060205.Name = "cmd060205"
        Me.cmd060205.Size = New System.Drawing.Size(96, 64)
        Me.cmd060205.TabIndex = 133
        Me.cmd060205.Tag = ""
        Me.cmd060205.Visible = False
        '
        'cmd060204
        '
        Me.cmd060204.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060204.Location = New System.Drawing.Point(134, 256)
        Me.cmd060204.Name = "cmd060204"
        Me.cmd060204.Size = New System.Drawing.Size(96, 64)
        Me.cmd060204.TabIndex = 132
        Me.cmd060204.Tag = ""
        Me.cmd060204.Visible = False
        '
        'cmd060203
        '
        Me.cmd060203.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060203.Location = New System.Drawing.Point(134, 176)
        Me.cmd060203.Name = "cmd060203"
        Me.cmd060203.Size = New System.Drawing.Size(96, 64)
        Me.cmd060203.TabIndex = 131
        Me.cmd060203.Tag = ""
        Me.cmd060203.Visible = False
        '
        'cmd060202
        '
        Me.cmd060202.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060202.Location = New System.Drawing.Point(134, 96)
        Me.cmd060202.Name = "cmd060202"
        Me.cmd060202.Size = New System.Drawing.Size(96, 64)
        Me.cmd060202.TabIndex = 130
        Me.cmd060202.Tag = ""
        Me.cmd060202.Visible = False
        '
        'cmd060106
        '
        Me.cmd060106.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060106.Location = New System.Drawing.Point(17, 416)
        Me.cmd060106.Name = "cmd060106"
        Me.cmd060106.Size = New System.Drawing.Size(96, 64)
        Me.cmd060106.TabIndex = 129
        Me.cmd060106.Tag = ""
        Me.cmd060106.Visible = False
        '
        'cmd060105
        '
        Me.cmd060105.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060105.Location = New System.Drawing.Point(17, 336)
        Me.cmd060105.Name = "cmd060105"
        Me.cmd060105.Size = New System.Drawing.Size(96, 64)
        Me.cmd060105.TabIndex = 128
        Me.cmd060105.Tag = ""
        Me.cmd060105.Visible = False
        '
        'cmd060104
        '
        Me.cmd060104.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060104.Location = New System.Drawing.Point(17, 256)
        Me.cmd060104.Name = "cmd060104"
        Me.cmd060104.Size = New System.Drawing.Size(96, 64)
        Me.cmd060104.TabIndex = 127
        Me.cmd060104.Tag = ""
        Me.cmd060104.Visible = False
        '
        'cmd060103
        '
        Me.cmd060103.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060103.Location = New System.Drawing.Point(17, 176)
        Me.cmd060103.Name = "cmd060103"
        Me.cmd060103.Size = New System.Drawing.Size(96, 64)
        Me.cmd060103.TabIndex = 126
        Me.cmd060103.Tag = ""
        Me.cmd060103.Visible = False
        '
        'cmd060801
        '
        Me.cmd060801.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060801.Location = New System.Drawing.Point(836, 16)
        Me.cmd060801.Name = "cmd060801"
        Me.cmd060801.Size = New System.Drawing.Size(96, 64)
        Me.cmd060801.TabIndex = 102
        Me.cmd060801.Tag = "itm069"
        Me.cmd060801.Visible = False
        '
        'cmd060701
        '
        Me.cmd060701.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060701.Location = New System.Drawing.Point(719, 16)
        Me.cmd060701.Name = "cmd060701"
        Me.cmd060701.Size = New System.Drawing.Size(96, 64)
        Me.cmd060701.TabIndex = 97
        Me.cmd060701.Tag = "itm070"
        Me.cmd060701.Visible = False
        '
        'cmd060602
        '
        Me.cmd060602.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060602.Location = New System.Drawing.Point(602, 96)
        Me.cmd060602.Name = "cmd060602"
        Me.cmd060602.Size = New System.Drawing.Size(96, 64)
        Me.cmd060602.TabIndex = 96
        Me.cmd060602.Tag = "itm068"
        Me.cmd060602.Visible = False
        '
        'cmd060601
        '
        Me.cmd060601.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060601.Location = New System.Drawing.Point(602, 16)
        Me.cmd060601.Name = "cmd060601"
        Me.cmd060601.Size = New System.Drawing.Size(96, 64)
        Me.cmd060601.TabIndex = 92
        Me.cmd060601.Tag = "itm066"
        Me.cmd060601.Visible = False
        '
        'cmd060502
        '
        Me.cmd060502.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060502.Location = New System.Drawing.Point(485, 96)
        Me.cmd060502.Name = "cmd060502"
        Me.cmd060502.Size = New System.Drawing.Size(96, 64)
        Me.cmd060502.TabIndex = 91
        Me.cmd060502.Tag = "itm071"
        Me.cmd060502.Visible = False
        '
        'cmd060501
        '
        Me.cmd060501.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060501.Location = New System.Drawing.Point(485, 16)
        Me.cmd060501.Name = "cmd060501"
        Me.cmd060501.Size = New System.Drawing.Size(96, 64)
        Me.cmd060501.TabIndex = 87
        Me.cmd060501.Tag = "itm065"
        Me.cmd060501.Visible = False
        '
        'cmd060402
        '
        Me.cmd060402.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060402.Location = New System.Drawing.Point(368, 96)
        Me.cmd060402.Name = "cmd060402"
        Me.cmd060402.Size = New System.Drawing.Size(96, 64)
        Me.cmd060402.TabIndex = 86
        Me.cmd060402.Tag = "itm067"
        Me.cmd060402.Visible = False
        '
        'cmd060401
        '
        Me.cmd060401.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060401.Location = New System.Drawing.Point(368, 16)
        Me.cmd060401.Name = "cmd060401"
        Me.cmd060401.Size = New System.Drawing.Size(96, 64)
        Me.cmd060401.TabIndex = 82
        Me.cmd060401.Tag = "itm072"
        Me.cmd060401.Visible = False
        '
        'cmd060301
        '
        Me.cmd060301.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060301.Location = New System.Drawing.Point(251, 16)
        Me.cmd060301.Name = "cmd060301"
        Me.cmd060301.Size = New System.Drawing.Size(96, 64)
        Me.cmd060301.TabIndex = 77
        Me.cmd060301.Tag = "itm073"
        Me.cmd060301.Visible = False
        '
        'cmd060201
        '
        Me.cmd060201.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060201.Location = New System.Drawing.Point(134, 16)
        Me.cmd060201.Name = "cmd060201"
        Me.cmd060201.Size = New System.Drawing.Size(96, 64)
        Me.cmd060201.TabIndex = 72
        Me.cmd060201.Tag = "itm074"
        Me.cmd060201.Visible = False
        '
        'cmd060102
        '
        Me.cmd060102.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060102.Location = New System.Drawing.Point(17, 96)
        Me.cmd060102.Name = "cmd060102"
        Me.cmd060102.Size = New System.Drawing.Size(96, 64)
        Me.cmd060102.TabIndex = 63
        Me.cmd060102.Tag = "itm017"
        Me.cmd060102.Visible = False
        '
        'cmd060101
        '
        Me.cmd060101.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd060101.Location = New System.Drawing.Point(17, 16)
        Me.cmd060101.Name = "cmd060101"
        Me.cmd060101.Size = New System.Drawing.Size(96, 64)
        Me.cmd060101.TabIndex = 59
        Me.cmd060101.Tag = "itm075"
        Me.cmd060101.Visible = False
        '
        'cmdFoods
        '
        Me.cmdFoods.Location = New System.Drawing.Point(990, 81)
        Me.cmdFoods.Name = "cmdFoods"
        Me.cmdFoods.Size = New System.Drawing.Size(136, 48)
        Me.cmdFoods.TabIndex = 17
        Me.cmdFoods.Text = "Food"
        Me.cmdFoods.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.cmdCustomBar)
        Me.Panel1.Controls.Add(Me.bar056)
        Me.Panel1.Controls.Add(Me.bar023)
        Me.Panel1.Controls.Add(Me.bar026)
        Me.Panel1.Controls.Add(Me.bar055)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.bar054)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.bar053)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.bar029)
        Me.Panel1.Controls.Add(Me.bar032)
        Me.Panel1.Controls.Add(Me.bar031)
        Me.Panel1.Controls.Add(Me.bar030)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.bar022)
        Me.Panel1.Controls.Add(Me.bar021)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.bar025)
        Me.Panel1.Controls.Add(Me.bar024)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.bar052)
        Me.Panel1.Controls.Add(Me.bar051)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.bar028)
        Me.Panel1.Controls.Add(Me.bar050)
        Me.Panel1.Controls.Add(Me.bar049)
        Me.Panel1.Controls.Add(Me.bar048)
        Me.Panel1.Controls.Add(Me.bar047)
        Me.Panel1.Controls.Add(Me.bar046)
        Me.Panel1.Controls.Add(Me.bar045)
        Me.Panel1.Controls.Add(Me.bar044)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.bar043)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.bar042)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.bar041)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.bar040)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.bar039)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.bar038)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.bar037)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.bar034)
        Me.Panel1.Controls.Add(Me.bar033)
        Me.Panel1.Controls.Add(Me.bar036)
        Me.Panel1.Controls.Add(Me.bar035)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.bar027)
        Me.Panel1.Controls.Add(Me.bar019)
        Me.Panel1.Controls.Add(Me.bar020)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.bar018)
        Me.Panel1.Controls.Add(Me.bar017)
        Me.Panel1.Controls.Add(Me.bar016)
        Me.Panel1.Controls.Add(Me.bar015)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.bar014)
        Me.Panel1.Controls.Add(Me.bar013)
        Me.Panel1.Controls.Add(Me.bar012)
        Me.Panel1.Controls.Add(Me.bar011)
        Me.Panel1.Controls.Add(Me.bar005)
        Me.Panel1.Controls.Add(Me.bar010)
        Me.Panel1.Controls.Add(Me.bar009)
        Me.Panel1.Controls.Add(Me.bar008)
        Me.Panel1.Controls.Add(Me.bar007)
        Me.Panel1.Controls.Add(Me.bar006)
        Me.Panel1.Controls.Add(Me.bar002)
        Me.Panel1.Controls.Add(Me.bar001)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.bar004)
        Me.Panel1.Controls.Add(Me.bar003)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(16, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 560)
        Me.Panel1.TabIndex = 18
        '
        'cmdCustomBar
        '
        Me.cmdCustomBar.BackColor = System.Drawing.Color.Gray
        Me.cmdCustomBar.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomBar.ForeColor = System.Drawing.Color.Black
        Me.cmdCustomBar.Location = New System.Drawing.Point(856, 424)
        Me.cmdCustomBar.Name = "cmdCustomBar"
        Me.cmdCustomBar.Size = New System.Drawing.Size(96, 40)
        Me.cmdCustomBar.TabIndex = 92
        Me.cmdCustomBar.Text = "Custom"
        Me.cmdCustomBar.UseVisualStyleBackColor = False
        '
        'bar056
        '
        Me.bar056.BackColor = System.Drawing.Color.Gray
        Me.bar056.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar056.ForeColor = System.Drawing.Color.Black
        Me.bar056.Location = New System.Drawing.Point(864, 312)
        Me.bar056.Name = "bar056"
        Me.bar056.Size = New System.Drawing.Size(96, 40)
        Me.bar056.TabIndex = 91
        Me.bar056.Text = "pitcher"
        Me.bar056.UseVisualStyleBackColor = False
        '
        'bar023
        '
        Me.bar023.BackColor = System.Drawing.Color.Gray
        Me.bar023.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar023.ForeColor = System.Drawing.Color.Black
        Me.bar023.Location = New System.Drawing.Point(288, 432)
        Me.bar023.Name = "bar023"
        Me.bar023.Size = New System.Drawing.Size(96, 40)
        Me.bar023.TabIndex = 90
        Me.bar023.Text = "Virgin"
        Me.bar023.UseVisualStyleBackColor = False
        '
        'bar026
        '
        Me.bar026.BackColor = System.Drawing.Color.Gray
        Me.bar026.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar026.ForeColor = System.Drawing.Color.Black
        Me.bar026.Location = New System.Drawing.Point(328, 392)
        Me.bar026.Name = "bar026"
        Me.bar026.Size = New System.Drawing.Size(104, 40)
        Me.bar026.TabIndex = 89
        Me.bar026.Text = "Mike's Hard Lemonade"
        Me.bar026.UseVisualStyleBackColor = False
        '
        'bar055
        '
        Me.bar055.BackColor = System.Drawing.Color.Gray
        Me.bar055.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar055.ForeColor = System.Drawing.Color.Black
        Me.bar055.Location = New System.Drawing.Point(808, 504)
        Me.bar055.Name = "bar055"
        Me.bar055.Size = New System.Drawing.Size(96, 40)
        Me.bar055.TabIndex = 88
        Me.bar055.Text = "Tier 3"
        Me.bar055.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label27.Location = New System.Drawing.Point(792, 472)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(128, 32)
        Me.Label27.TabIndex = 87
        Me.Label27.Text = "Menage Trois, Roscato, Malbec"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bar054
        '
        Me.bar054.BackColor = System.Drawing.Color.Gray
        Me.bar054.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar054.ForeColor = System.Drawing.Color.Black
        Me.bar054.Location = New System.Drawing.Point(648, 504)
        Me.bar054.Name = "bar054"
        Me.bar054.Size = New System.Drawing.Size(96, 40)
        Me.bar054.TabIndex = 86
        Me.bar054.Text = "Tier 2"
        Me.bar054.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label28.Location = New System.Drawing.Point(612, 472)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(168, 32)
        Me.Label28.TabIndex = 85
        Me.Label28.Text = "Lambrusco, Pino, Reisling, Shiraz"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bar053
        '
        Me.bar053.BackColor = System.Drawing.Color.Gray
        Me.bar053.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar053.ForeColor = System.Drawing.Color.Black
        Me.bar053.Location = New System.Drawing.Point(480, 504)
        Me.bar053.Name = "bar053"
        Me.bar053.Size = New System.Drawing.Size(96, 40)
        Me.bar053.TabIndex = 84
        Me.bar053.Text = "Tier 1"
        Me.bar053.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label29.Location = New System.Drawing.Point(448, 464)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(160, 40)
        Me.Label29.TabIndex = 83
        Me.Label29.Text = "Chardonney, Cabernet, Merlot, White Zin, NA FRE"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Coral
        Me.Label30.Location = New System.Drawing.Point(592, 432)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(144, 24)
        Me.Label30.TabIndex = 82
        Me.Label30.Text = "Wine"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bar029
        '
        Me.bar029.BackColor = System.Drawing.Color.Gray
        Me.bar029.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar029.ForeColor = System.Drawing.Color.Black
        Me.bar029.Location = New System.Drawing.Point(328, 512)
        Me.bar029.Name = "bar029"
        Me.bar029.Size = New System.Drawing.Size(96, 40)
        Me.bar029.TabIndex = 80
        Me.bar029.Text = "N/A"
        Me.bar029.UseVisualStyleBackColor = False
        '
        'bar032
        '
        Me.bar032.BackColor = System.Drawing.Color.Gray
        Me.bar032.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar032.ForeColor = System.Drawing.Color.Black
        Me.bar032.Location = New System.Drawing.Point(232, 512)
        Me.bar032.Name = "bar032"
        Me.bar032.Size = New System.Drawing.Size(96, 40)
        Me.bar032.TabIndex = 79
        Me.bar032.Text = "High Call"
        Me.bar032.UseVisualStyleBackColor = False
        '
        'bar031
        '
        Me.bar031.BackColor = System.Drawing.Color.Gray
        Me.bar031.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar031.ForeColor = System.Drawing.Color.Black
        Me.bar031.Location = New System.Drawing.Point(136, 512)
        Me.bar031.Name = "bar031"
        Me.bar031.Size = New System.Drawing.Size(96, 40)
        Me.bar031.TabIndex = 78
        Me.bar031.Text = "Low Call"
        Me.bar031.UseVisualStyleBackColor = False
        '
        'bar030
        '
        Me.bar030.BackColor = System.Drawing.Color.Gray
        Me.bar030.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar030.ForeColor = System.Drawing.Color.Black
        Me.bar030.Location = New System.Drawing.Point(40, 512)
        Me.bar030.Name = "bar030"
        Me.bar030.Size = New System.Drawing.Size(96, 40)
        Me.bar030.TabIndex = 77
        Me.bar030.Text = "Rail"
        Me.bar030.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label10.Location = New System.Drawing.Point(24, 496)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(224, 24)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Hot Chocolate, Coffee, Hot Spiced Cider"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Coral
        Me.Label26.Location = New System.Drawing.Point(8, 472)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(296, 24)
        Me.Label26.TabIndex = 76
        Me.Label26.Text = "Hot Drinks"
        '
        'bar022
        '
        Me.bar022.BackColor = System.Drawing.Color.Gray
        Me.bar022.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar022.ForeColor = System.Drawing.Color.Black
        Me.bar022.Location = New System.Drawing.Point(192, 392)
        Me.bar022.Name = "bar022"
        Me.bar022.Size = New System.Drawing.Size(96, 40)
        Me.bar022.TabIndex = 74
        Me.bar022.Text = "Small"
        Me.bar022.UseVisualStyleBackColor = False
        '
        'bar021
        '
        Me.bar021.BackColor = System.Drawing.Color.Gray
        Me.bar021.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar021.ForeColor = System.Drawing.Color.Black
        Me.bar021.Location = New System.Drawing.Point(96, 392)
        Me.bar021.Name = "bar021"
        Me.bar021.Size = New System.Drawing.Size(96, 40)
        Me.bar021.TabIndex = 73
        Me.bar021.Text = "Reg"
        Me.bar021.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label25.Location = New System.Drawing.Point(8, 400)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(192, 24)
        Me.Label25.TabIndex = 75
        Me.Label25.Text = "White Russian"
        '
        'bar025
        '
        Me.bar025.BackColor = System.Drawing.Color.Gray
        Me.bar025.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar025.ForeColor = System.Drawing.Color.Black
        Me.bar025.Location = New System.Drawing.Point(192, 432)
        Me.bar025.Name = "bar025"
        Me.bar025.Size = New System.Drawing.Size(96, 40)
        Me.bar025.TabIndex = 35
        Me.bar025.Text = "add chaser"
        Me.bar025.UseVisualStyleBackColor = False
        '
        'bar024
        '
        Me.bar024.BackColor = System.Drawing.Color.Gray
        Me.bar024.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar024.ForeColor = System.Drawing.Color.Black
        Me.bar024.Location = New System.Drawing.Point(96, 432)
        Me.bar024.Name = "bar024"
        Me.bar024.Size = New System.Drawing.Size(96, 40)
        Me.bar024.TabIndex = 34
        Me.bar024.Text = "Reg"
        Me.bar024.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label11.Location = New System.Drawing.Point(8, 440)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 24)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Bloody Mary"
        '
        'bar052
        '
        Me.bar052.BackColor = System.Drawing.Color.Gray
        Me.bar052.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar052.ForeColor = System.Drawing.Color.Black
        Me.bar052.Location = New System.Drawing.Point(760, 392)
        Me.bar052.Name = "bar052"
        Me.bar052.Size = New System.Drawing.Size(96, 40)
        Me.bar052.TabIndex = 71
        Me.bar052.Text = "large (tub)"
        Me.bar052.UseVisualStyleBackColor = False
        '
        'bar051
        '
        Me.bar051.BackColor = System.Drawing.Color.Gray
        Me.bar051.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar051.ForeColor = System.Drawing.Color.Black
        Me.bar051.Location = New System.Drawing.Point(664, 392)
        Me.bar051.Name = "bar051"
        Me.bar051.Size = New System.Drawing.Size(96, 40)
        Me.bar051.TabIndex = 70
        Me.bar051.Text = "small (stem)"
        Me.bar051.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Coral
        Me.Label9.Location = New System.Drawing.Point(696, 368)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 24)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Juice"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bar028
        '
        Me.bar028.BackColor = System.Drawing.Color.Gray
        Me.bar028.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar028.ForeColor = System.Drawing.Color.Black
        Me.bar028.Location = New System.Drawing.Point(328, 352)
        Me.bar028.Name = "bar028"
        Me.bar028.Size = New System.Drawing.Size(104, 40)
        Me.bar028.TabIndex = 68
        Me.bar028.Text = "N/A Ice Cream Drink"
        Me.bar028.UseVisualStyleBackColor = False
        '
        'bar050
        '
        Me.bar050.BackColor = System.Drawing.Color.Gray
        Me.bar050.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar050.ForeColor = System.Drawing.Color.Black
        Me.bar050.Location = New System.Drawing.Point(768, 312)
        Me.bar050.Name = "bar050"
        Me.bar050.Size = New System.Drawing.Size(96, 40)
        Me.bar050.TabIndex = 67
        Me.bar050.Text = "mug"
        Me.bar050.UseVisualStyleBackColor = False
        '
        'bar049
        '
        Me.bar049.BackColor = System.Drawing.Color.Gray
        Me.bar049.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar049.ForeColor = System.Drawing.Color.Black
        Me.bar049.Location = New System.Drawing.Point(672, 312)
        Me.bar049.Name = "bar049"
        Me.bar049.Size = New System.Drawing.Size(96, 40)
        Me.bar049.TabIndex = 66
        Me.bar049.Text = "small"
        Me.bar049.UseVisualStyleBackColor = False
        '
        'bar048
        '
        Me.bar048.BackColor = System.Drawing.Color.Gray
        Me.bar048.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar048.ForeColor = System.Drawing.Color.Black
        Me.bar048.Location = New System.Drawing.Point(504, 392)
        Me.bar048.Name = "bar048"
        Me.bar048.Size = New System.Drawing.Size(96, 40)
        Me.bar048.TabIndex = 65
        Me.bar048.Text = "kiddie cocktail"
        Me.bar048.UseVisualStyleBackColor = False
        '
        'bar047
        '
        Me.bar047.BackColor = System.Drawing.Color.Gray
        Me.bar047.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar047.ForeColor = System.Drawing.Color.Black
        Me.bar047.Location = New System.Drawing.Point(552, 352)
        Me.bar047.Name = "bar047"
        Me.bar047.Size = New System.Drawing.Size(96, 40)
        Me.bar047.TabIndex = 64
        Me.bar047.Text = "pitcher"
        Me.bar047.UseVisualStyleBackColor = False
        '
        'bar046
        '
        Me.bar046.BackColor = System.Drawing.Color.Gray
        Me.bar046.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar046.ForeColor = System.Drawing.Color.Black
        Me.bar046.Location = New System.Drawing.Point(552, 312)
        Me.bar046.Name = "bar046"
        Me.bar046.Size = New System.Drawing.Size(96, 40)
        Me.bar046.TabIndex = 63
        Me.bar046.Text = "large (flag)"
        Me.bar046.UseVisualStyleBackColor = False
        '
        'bar045
        '
        Me.bar045.BackColor = System.Drawing.Color.Gray
        Me.bar045.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar045.ForeColor = System.Drawing.Color.Black
        Me.bar045.Location = New System.Drawing.Point(456, 352)
        Me.bar045.Name = "bar045"
        Me.bar045.Size = New System.Drawing.Size(96, 40)
        Me.bar045.TabIndex = 62
        Me.bar045.Text = "medium (tub)"
        Me.bar045.UseVisualStyleBackColor = False
        '
        'bar044
        '
        Me.bar044.BackColor = System.Drawing.Color.Gray
        Me.bar044.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar044.ForeColor = System.Drawing.Color.Black
        Me.bar044.Location = New System.Drawing.Point(456, 312)
        Me.bar044.Name = "bar044"
        Me.bar044.Size = New System.Drawing.Size(96, 40)
        Me.bar044.TabIndex = 61
        Me.bar044.Text = "small (stem)"
        Me.bar044.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Coral
        Me.Label24.Location = New System.Drawing.Point(704, 288)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(144, 24)
        Me.Label24.TabIndex = 60
        Me.Label24.Text = "1919 Root Beer"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Coral
        Me.Label23.Location = New System.Drawing.Point(480, 288)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(144, 24)
        Me.Label23.TabIndex = 59
        Me.Label23.Text = "Soda"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bar043
        '
        Me.bar043.BackColor = System.Drawing.Color.Gray
        Me.bar043.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar043.ForeColor = System.Drawing.Color.Black
        Me.bar043.Location = New System.Drawing.Point(816, 240)
        Me.bar043.Name = "bar043"
        Me.bar043.Size = New System.Drawing.Size(96, 40)
        Me.bar043.TabIndex = 58
        Me.bar043.Text = "Reg"
        Me.bar043.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Black
        Me.Label18.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label18.Location = New System.Drawing.Point(744, 248)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(192, 24)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "pitcher"
        '
        'bar042
        '
        Me.bar042.BackColor = System.Drawing.Color.Gray
        Me.bar042.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar042.ForeColor = System.Drawing.Color.Black
        Me.bar042.Location = New System.Drawing.Point(816, 200)
        Me.bar042.Name = "bar042"
        Me.bar042.Size = New System.Drawing.Size(96, 40)
        Me.bar042.TabIndex = 56
        Me.bar042.Text = "Reg"
        Me.bar042.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Black
        Me.Label19.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label19.Location = New System.Drawing.Point(744, 200)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 32)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "20 oz mug"
        '
        'bar041
        '
        Me.bar041.BackColor = System.Drawing.Color.Gray
        Me.bar041.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar041.ForeColor = System.Drawing.Color.Black
        Me.bar041.Location = New System.Drawing.Point(816, 160)
        Me.bar041.Name = "bar041"
        Me.bar041.Size = New System.Drawing.Size(96, 40)
        Me.bar041.TabIndex = 54
        Me.bar041.Text = "Reg"
        Me.bar041.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Black
        Me.Label20.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label20.Location = New System.Drawing.Point(744, 168)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(192, 24)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "12 oz glass"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label21.Location = New System.Drawing.Point(744, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(192, 24)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "Killians, Amber Bock, Spotted Cow"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Coral
        Me.Label22.Location = New System.Drawing.Point(728, 96)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(144, 24)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Beer - Draft"
        '
        'bar040
        '
        Me.bar040.BackColor = System.Drawing.Color.Gray
        Me.bar040.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar040.ForeColor = System.Drawing.Color.Black
        Me.bar040.Location = New System.Drawing.Point(640, 240)
        Me.bar040.Name = "bar040"
        Me.bar040.Size = New System.Drawing.Size(96, 40)
        Me.bar040.TabIndex = 49
        Me.bar040.Text = "Reg"
        Me.bar040.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label17.Location = New System.Drawing.Point(528, 248)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(192, 24)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "O'Doul's and Amber"
        '
        'bar039
        '
        Me.bar039.BackColor = System.Drawing.Color.Gray
        Me.bar039.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar039.ForeColor = System.Drawing.Color.Black
        Me.bar039.Location = New System.Drawing.Point(640, 200)
        Me.bar039.Name = "bar039"
        Me.bar039.Size = New System.Drawing.Size(96, 40)
        Me.bar039.TabIndex = 47
        Me.bar039.Text = "Reg"
        Me.bar039.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label16.Location = New System.Drawing.Point(528, 200)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 32)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Heineken, Becks, Buckler, Carona"
        '
        'bar038
        '
        Me.bar038.BackColor = System.Drawing.Color.Gray
        Me.bar038.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar038.ForeColor = System.Drawing.Color.Black
        Me.bar038.Location = New System.Drawing.Point(640, 160)
        Me.bar038.Name = "bar038"
        Me.bar038.Size = New System.Drawing.Size(96, 40)
        Me.bar038.TabIndex = 45
        Me.bar038.Text = "Reg"
        Me.bar038.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label15.Location = New System.Drawing.Point(528, 168)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(192, 24)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Leinenkugels"
        '
        'bar037
        '
        Me.bar037.BackColor = System.Drawing.Color.Gray
        Me.bar037.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar037.ForeColor = System.Drawing.Color.Black
        Me.bar037.Location = New System.Drawing.Point(640, 120)
        Me.bar037.Name = "bar037"
        Me.bar037.Size = New System.Drawing.Size(96, 40)
        Me.bar037.TabIndex = 43
        Me.bar037.Text = "Reg"
        Me.bar037.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label12.Location = New System.Drawing.Point(528, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(192, 24)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Domestic"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Coral
        Me.Label14.Location = New System.Drawing.Point(512, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 24)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Beer - Bottles"
        '
        'bar034
        '
        Me.bar034.BackColor = System.Drawing.Color.Gray
        Me.bar034.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar034.ForeColor = System.Drawing.Color.Black
        Me.bar034.Location = New System.Drawing.Point(640, 48)
        Me.bar034.Name = "bar034"
        Me.bar034.Size = New System.Drawing.Size(96, 40)
        Me.bar034.TabIndex = 38
        Me.bar034.Text = "Low Call"
        Me.bar034.UseVisualStyleBackColor = False
        '
        'bar033
        '
        Me.bar033.BackColor = System.Drawing.Color.Gray
        Me.bar033.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar033.ForeColor = System.Drawing.Color.Black
        Me.bar033.Location = New System.Drawing.Point(544, 48)
        Me.bar033.Name = "bar033"
        Me.bar033.Size = New System.Drawing.Size(96, 40)
        Me.bar033.TabIndex = 37
        Me.bar033.Text = "Rail"
        Me.bar033.UseVisualStyleBackColor = False
        '
        'bar036
        '
        Me.bar036.BackColor = System.Drawing.Color.Gray
        Me.bar036.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar036.ForeColor = System.Drawing.Color.Black
        Me.bar036.Location = New System.Drawing.Point(832, 48)
        Me.bar036.Name = "bar036"
        Me.bar036.Size = New System.Drawing.Size(96, 40)
        Me.bar036.TabIndex = 40
        Me.bar036.Text = "Ultra High"
        Me.bar036.UseVisualStyleBackColor = False
        '
        'bar035
        '
        Me.bar035.BackColor = System.Drawing.Color.Gray
        Me.bar035.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar035.ForeColor = System.Drawing.Color.Black
        Me.bar035.Location = New System.Drawing.Point(736, 48)
        Me.bar035.Name = "bar035"
        Me.bar035.Size = New System.Drawing.Size(96, 40)
        Me.bar035.TabIndex = 39
        Me.bar035.Text = "High Call"
        Me.bar035.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Coral
        Me.Label13.Location = New System.Drawing.Point(512, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(344, 24)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Shots  &&  Snifters  &&  Cordials"
        '
        'bar027
        '
        Me.bar027.BackColor = System.Drawing.Color.Gray
        Me.bar027.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar027.ForeColor = System.Drawing.Color.Black
        Me.bar027.Location = New System.Drawing.Point(232, 352)
        Me.bar027.Name = "bar027"
        Me.bar027.Size = New System.Drawing.Size(96, 40)
        Me.bar027.TabIndex = 32
        Me.bar027.Text = "Ice Cream Drink"
        Me.bar027.UseVisualStyleBackColor = False
        '
        'bar019
        '
        Me.bar019.BackColor = System.Drawing.Color.Gray
        Me.bar019.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar019.ForeColor = System.Drawing.Color.Black
        Me.bar019.Location = New System.Drawing.Point(136, 352)
        Me.bar019.Name = "bar019"
        Me.bar019.Size = New System.Drawing.Size(96, 40)
        Me.bar019.TabIndex = 31
        Me.bar019.Text = "Blended Drink"
        Me.bar019.UseVisualStyleBackColor = False
        '
        'bar020
        '
        Me.bar020.BackColor = System.Drawing.Color.Gray
        Me.bar020.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar020.ForeColor = System.Drawing.Color.Black
        Me.bar020.Location = New System.Drawing.Point(40, 352)
        Me.bar020.Name = "bar020"
        Me.bar020.Size = New System.Drawing.Size(96, 40)
        Me.bar020.TabIndex = 29
        Me.bar020.Text = "Long Island"
        Me.bar020.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Coral
        Me.Label8.Location = New System.Drawing.Point(8, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(296, 24)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Miscellaneous"
        '
        'bar018
        '
        Me.bar018.BackColor = System.Drawing.Color.Gray
        Me.bar018.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar018.ForeColor = System.Drawing.Color.Black
        Me.bar018.Location = New System.Drawing.Point(328, 280)
        Me.bar018.Name = "bar018"
        Me.bar018.Size = New System.Drawing.Size(96, 40)
        Me.bar018.TabIndex = 24
        Me.bar018.Text = "Ultra High"
        Me.bar018.UseVisualStyleBackColor = False
        '
        'bar017
        '
        Me.bar017.BackColor = System.Drawing.Color.Gray
        Me.bar017.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar017.ForeColor = System.Drawing.Color.Black
        Me.bar017.Location = New System.Drawing.Point(232, 280)
        Me.bar017.Name = "bar017"
        Me.bar017.Size = New System.Drawing.Size(96, 40)
        Me.bar017.TabIndex = 23
        Me.bar017.Text = "High Call"
        Me.bar017.UseVisualStyleBackColor = False
        '
        'bar016
        '
        Me.bar016.BackColor = System.Drawing.Color.Gray
        Me.bar016.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar016.ForeColor = System.Drawing.Color.Black
        Me.bar016.Location = New System.Drawing.Point(136, 280)
        Me.bar016.Name = "bar016"
        Me.bar016.Size = New System.Drawing.Size(96, 40)
        Me.bar016.TabIndex = 22
        Me.bar016.Text = "Low Call"
        Me.bar016.UseVisualStyleBackColor = False
        '
        'bar015
        '
        Me.bar015.BackColor = System.Drawing.Color.Gray
        Me.bar015.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar015.ForeColor = System.Drawing.Color.Black
        Me.bar015.Location = New System.Drawing.Point(40, 280)
        Me.bar015.Name = "bar015"
        Me.bar015.Size = New System.Drawing.Size(96, 40)
        Me.bar015.TabIndex = 21
        Me.bar015.Text = "Rail"
        Me.bar015.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label7.Location = New System.Drawing.Point(24, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 24)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "( Small - 7oz stem )"
        '
        'bar014
        '
        Me.bar014.BackColor = System.Drawing.Color.Gray
        Me.bar014.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar014.ForeColor = System.Drawing.Color.Black
        Me.bar014.Location = New System.Drawing.Point(328, 224)
        Me.bar014.Name = "bar014"
        Me.bar014.Size = New System.Drawing.Size(96, 40)
        Me.bar014.TabIndex = 16
        Me.bar014.Text = "Ultra High"
        Me.bar014.UseVisualStyleBackColor = False
        '
        'bar013
        '
        Me.bar013.BackColor = System.Drawing.Color.Gray
        Me.bar013.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar013.ForeColor = System.Drawing.Color.Black
        Me.bar013.Location = New System.Drawing.Point(232, 224)
        Me.bar013.Name = "bar013"
        Me.bar013.Size = New System.Drawing.Size(96, 40)
        Me.bar013.TabIndex = 15
        Me.bar013.Text = "High Call"
        Me.bar013.UseVisualStyleBackColor = False
        '
        'bar012
        '
        Me.bar012.BackColor = System.Drawing.Color.Gray
        Me.bar012.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar012.ForeColor = System.Drawing.Color.Black
        Me.bar012.Location = New System.Drawing.Point(136, 224)
        Me.bar012.Name = "bar012"
        Me.bar012.Size = New System.Drawing.Size(96, 40)
        Me.bar012.TabIndex = 14
        Me.bar012.Text = "Low Call"
        Me.bar012.UseVisualStyleBackColor = False
        '
        'bar011
        '
        Me.bar011.BackColor = System.Drawing.Color.Gray
        Me.bar011.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar011.ForeColor = System.Drawing.Color.Black
        Me.bar011.Location = New System.Drawing.Point(40, 224)
        Me.bar011.Name = "bar011"
        Me.bar011.Size = New System.Drawing.Size(96, 40)
        Me.bar011.TabIndex = 13
        Me.bar011.Text = "Rail"
        Me.bar011.UseVisualStyleBackColor = False
        '
        'bar005
        '
        Me.bar005.BackColor = System.Drawing.Color.Gray
        Me.bar005.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar005.ForeColor = System.Drawing.Color.Black
        Me.bar005.Location = New System.Drawing.Point(328, 88)
        Me.bar005.Name = "bar005"
        Me.bar005.Size = New System.Drawing.Size(96, 40)
        Me.bar005.TabIndex = 5
        Me.bar005.Text = "with juice"
        Me.bar005.UseVisualStyleBackColor = False
        '
        'bar010
        '
        Me.bar010.BackColor = System.Drawing.Color.Gray
        Me.bar010.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar010.ForeColor = System.Drawing.Color.Black
        Me.bar010.Location = New System.Drawing.Point(328, 176)
        Me.bar010.Name = "bar010"
        Me.bar010.Size = New System.Drawing.Size(96, 40)
        Me.bar010.TabIndex = 11
        Me.bar010.Text = "extra garnish"
        Me.bar010.UseVisualStyleBackColor = False
        '
        'bar009
        '
        Me.bar009.BackColor = System.Drawing.Color.Gray
        Me.bar009.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar009.ForeColor = System.Drawing.Color.Black
        Me.bar009.Location = New System.Drawing.Point(328, 136)
        Me.bar009.Name = "bar009"
        Me.bar009.Size = New System.Drawing.Size(96, 40)
        Me.bar009.TabIndex = 10
        Me.bar009.Text = "Ultra High"
        Me.bar009.UseVisualStyleBackColor = False
        '
        'bar008
        '
        Me.bar008.BackColor = System.Drawing.Color.Gray
        Me.bar008.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar008.ForeColor = System.Drawing.Color.Black
        Me.bar008.Location = New System.Drawing.Point(232, 136)
        Me.bar008.Name = "bar008"
        Me.bar008.Size = New System.Drawing.Size(96, 40)
        Me.bar008.TabIndex = 9
        Me.bar008.Text = "High Call"
        Me.bar008.UseVisualStyleBackColor = False
        '
        'bar007
        '
        Me.bar007.BackColor = System.Drawing.Color.Gray
        Me.bar007.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar007.ForeColor = System.Drawing.Color.Black
        Me.bar007.Location = New System.Drawing.Point(136, 136)
        Me.bar007.Name = "bar007"
        Me.bar007.Size = New System.Drawing.Size(96, 40)
        Me.bar007.TabIndex = 8
        Me.bar007.Text = "Low Call"
        Me.bar007.UseVisualStyleBackColor = False
        '
        'bar006
        '
        Me.bar006.BackColor = System.Drawing.Color.Gray
        Me.bar006.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar006.ForeColor = System.Drawing.Color.Black
        Me.bar006.Location = New System.Drawing.Point(40, 136)
        Me.bar006.Name = "bar006"
        Me.bar006.Size = New System.Drawing.Size(96, 40)
        Me.bar006.TabIndex = 7
        Me.bar006.Text = "Rail"
        Me.bar006.UseVisualStyleBackColor = False
        '
        'bar002
        '
        Me.bar002.BackColor = System.Drawing.Color.Gray
        Me.bar002.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar002.ForeColor = System.Drawing.Color.Black
        Me.bar002.Location = New System.Drawing.Point(136, 48)
        Me.bar002.Name = "bar002"
        Me.bar002.Size = New System.Drawing.Size(96, 40)
        Me.bar002.TabIndex = 2
        Me.bar002.Text = "Low Call"
        Me.bar002.UseVisualStyleBackColor = False
        '
        'bar001
        '
        Me.bar001.BackColor = System.Drawing.Color.Gray
        Me.bar001.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar001.ForeColor = System.Drawing.Color.Black
        Me.bar001.Location = New System.Drawing.Point(40, 48)
        Me.bar001.Name = "bar001"
        Me.bar001.Size = New System.Drawing.Size(96, 40)
        Me.bar001.TabIndex = 1
        Me.bar001.Text = "Rail"
        Me.bar001.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label6.Location = New System.Drawing.Point(24, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "( Tub and Martini glass-up )"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label5.Location = New System.Drawing.Point(24, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "( Tub )"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label4.Location = New System.Drawing.Point(24, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "( Tub )"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Coral
        Me.Label3.Location = New System.Drawing.Point(8, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Martini, Manhattan, Gimlet"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(8, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cocktails"
        '
        'bar004
        '
        Me.bar004.BackColor = System.Drawing.Color.Gray
        Me.bar004.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar004.ForeColor = System.Drawing.Color.Black
        Me.bar004.Location = New System.Drawing.Point(328, 48)
        Me.bar004.Name = "bar004"
        Me.bar004.Size = New System.Drawing.Size(96, 40)
        Me.bar004.TabIndex = 4
        Me.bar004.Text = "Ultra High"
        Me.bar004.UseVisualStyleBackColor = False
        '
        'bar003
        '
        Me.bar003.BackColor = System.Drawing.Color.Gray
        Me.bar003.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar003.ForeColor = System.Drawing.Color.Black
        Me.bar003.Location = New System.Drawing.Point(232, 48)
        Me.bar003.Name = "bar003"
        Me.bar003.Size = New System.Drawing.Size(96, 40)
        Me.bar003.TabIndex = 3
        Me.bar003.Text = "High Call"
        Me.bar003.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Highball"
        '
        'cmdMessage
        '
        Me.cmdMessage.BackColor = System.Drawing.Color.Red
        Me.cmdMessage.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMessage.Location = New System.Drawing.Point(16, 680)
        Me.cmdMessage.Name = "cmdMessage"
        Me.cmdMessage.Size = New System.Drawing.Size(184, 48)
        Me.cmdMessage.TabIndex = 19
        Me.cmdMessage.Text = "Message"
        Me.cmdMessage.UseVisualStyleBackColor = False
        Me.cmdMessage.Visible = False
        '
        'cmdCloseTable
        '
        Me.cmdCloseTable.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseTable.Location = New System.Drawing.Point(544, 628)
        Me.cmdCloseTable.Name = "cmdCloseTable"
        Me.cmdCloseTable.Size = New System.Drawing.Size(280, 48)
        Me.cmdCloseTable.TabIndex = 20
        Me.cmdCloseTable.Text = "Close Table"
        '
        'cmdMisc
        '
        Me.cmdMisc.Location = New System.Drawing.Point(210, 628)
        Me.cmdMisc.Name = "cmdMisc"
        Me.cmdMisc.Size = New System.Drawing.Size(136, 48)
        Me.cmdMisc.TabIndex = 21
        Me.cmdMisc.Text = "Misc"
        '
        'cmdQuickSale
        '
        Me.cmdQuickSale.Location = New System.Drawing.Point(540, 576)
        Me.cmdQuickSale.Name = "cmdQuickSale"
        Me.cmdQuickSale.Size = New System.Drawing.Size(136, 48)
        Me.cmdQuickSale.TabIndex = 22
        Me.cmdQuickSale.Text = "Quick Sale"
        Me.cmdQuickSale.Visible = False
        '
        'cmdTwo
        '
        Me.cmdTwo.Location = New System.Drawing.Point(276, 576)
        Me.cmdTwo.Name = "cmdTwo"
        Me.cmdTwo.Size = New System.Drawing.Size(56, 48)
        Me.cmdTwo.TabIndex = 23
        Me.cmdTwo.Text = "Button1"
        Me.cmdTwo.Visible = False
        '
        'cmdThree
        '
        Me.cmdThree.Location = New System.Drawing.Point(342, 576)
        Me.cmdThree.Name = "cmdThree"
        Me.cmdThree.Size = New System.Drawing.Size(56, 48)
        Me.cmdThree.TabIndex = 24
        Me.cmdThree.Text = "Button2"
        Me.cmdThree.Visible = False
        '
        'cmdFour
        '
        Me.cmdFour.Location = New System.Drawing.Point(408, 576)
        Me.cmdFour.Name = "cmdFour"
        Me.cmdFour.Size = New System.Drawing.Size(56, 48)
        Me.cmdFour.TabIndex = 25
        Me.cmdFour.Text = "Button3"
        Me.cmdFour.Visible = False
        '
        'cmdFive
        '
        Me.cmdFive.Location = New System.Drawing.Point(474, 576)
        Me.cmdFive.Name = "cmdFive"
        Me.cmdFive.Size = New System.Drawing.Size(56, 48)
        Me.cmdFive.TabIndex = 26
        Me.cmdFive.Text = "Button4"
        Me.cmdFive.Visible = False
        '
        'cmdOne
        '
        Me.cmdOne.Location = New System.Drawing.Point(210, 576)
        Me.cmdOne.Name = "cmdOne"
        Me.cmdOne.Size = New System.Drawing.Size(56, 48)
        Me.cmdOne.TabIndex = 27
        Me.cmdOne.Text = "Button5"
        Me.cmdOne.Visible = False
        '
        'cmdSeatStool
        '
        Me.cmdSeatStool.Location = New System.Drawing.Point(392, 628)
        Me.cmdSeatStool.Name = "cmdSeatStool"
        Me.cmdSeatStool.Size = New System.Drawing.Size(136, 48)
        Me.cmdSeatStool.TabIndex = 28
        Me.cmdSeatStool.Text = "Seat Stool"
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(840, 680)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(136, 48)
        Me.cmdOpen.TabIndex = 29
        Me.cmdOpen.Text = "Open Drawer"
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Impact", 12.0!)
        Me.cmdPrint.Location = New System.Drawing.Point(544, 628)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(280, 48)
        Me.cmdPrint.TabIndex = 30
        Me.cmdPrint.Text = "Print"
        '
        'cmdCustom
        '
        Me.cmdCustom.Location = New System.Drawing.Point(210, 680)
        Me.cmdCustom.Name = "cmdCustom"
        Me.cmdCustom.Size = New System.Drawing.Size(136, 48)
        Me.cmdCustom.TabIndex = 31
        Me.cmdCustom.Text = "Custom Item"
        '
        'cmdDone
        '
        Me.cmdDone.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDone.Location = New System.Drawing.Point(1008, 628)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(248, 48)
        Me.cmdDone.TabIndex = 32
        Me.cmdDone.Text = "Done"
        '
        'dgvOrder
        '
        Me.dgvOrder.AllowUserToAddRows = False
        Me.dgvOrder.AllowUserToDeleteRows = False
        Me.dgvOrder.AllowUserToResizeColumns = False
        Me.dgvOrder.AllowUserToResizeRows = False
        Me.dgvOrder.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvOrder.Location = New System.Drawing.Point(990, 137)
        Me.dgvOrder.MultiSelect = False
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.ReadOnly = True
        Me.dgvOrder.RowHeadersVisible = False
        Me.dgvOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrder.Size = New System.Drawing.Size(225, 426)
        Me.dgvOrder.TabIndex = 33
        Me.dgvOrder.Visible = False
        '
        'guest4
        '
        Me.guest4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest4.Location = New System.Drawing.Point(1224, 299)
        Me.guest4.Name = "guest4"
        Me.guest4.Size = New System.Drawing.Size(56, 48)
        Me.guest4.TabIndex = 34
        Me.guest4.Tag = "4"
        Me.guest4.Text = "4"
        Me.guest4.Visible = False
        '
        'guest5
        '
        Me.guest5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest5.Location = New System.Drawing.Point(1224, 353)
        Me.guest5.Name = "guest5"
        Me.guest5.Size = New System.Drawing.Size(56, 48)
        Me.guest5.TabIndex = 35
        Me.guest5.Tag = "5"
        Me.guest5.Text = "5"
        Me.guest5.Visible = False
        '
        'guest6
        '
        Me.guest6.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest6.Location = New System.Drawing.Point(1224, 407)
        Me.guest6.Name = "guest6"
        Me.guest6.Size = New System.Drawing.Size(56, 48)
        Me.guest6.TabIndex = 36
        Me.guest6.Tag = "6"
        Me.guest6.Text = "6"
        Me.guest6.Visible = False
        '
        'guest7
        '
        Me.guest7.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest7.Location = New System.Drawing.Point(1224, 461)
        Me.guest7.Name = "guest7"
        Me.guest7.Size = New System.Drawing.Size(56, 48)
        Me.guest7.TabIndex = 37
        Me.guest7.Tag = "7"
        Me.guest7.Text = "7"
        Me.guest7.Visible = False
        '
        'guest8
        '
        Me.guest8.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guest8.Location = New System.Drawing.Point(1224, 515)
        Me.guest8.Name = "guest8"
        Me.guest8.Size = New System.Drawing.Size(56, 48)
        Me.guest8.TabIndex = 38
        Me.guest8.Tag = "8"
        Me.guest8.Text = "8"
        Me.guest8.Visible = False
        '
        'cmdDrinks
        '
        Me.cmdDrinks.Location = New System.Drawing.Point(1144, 81)
        Me.cmdDrinks.Name = "cmdDrinks"
        Me.cmdDrinks.Size = New System.Drawing.Size(136, 48)
        Me.cmdDrinks.TabIndex = 39
        Me.cmdDrinks.Text = "Drinks"
        Me.cmdDrinks.Visible = False
        '
        'lblTotals
        '
        Me.lblTotals.BackColor = System.Drawing.Color.Transparent
        Me.lblTotals.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotals.Location = New System.Drawing.Point(992, 566)
        Me.lblTotals.Name = "lblTotals"
        Me.lblTotals.Size = New System.Drawing.Size(280, 60)
        Me.lblTotals.TabIndex = 40
        Me.lblTotals.Text = "   Bar Total:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Food Total:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         Total:"
        Me.lblTotals.Visible = False
        '
        'POS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1292, 732)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTotals)
        Me.Controls.Add(Me.cmdDrinks)
        Me.Controls.Add(Me.guest8)
        Me.Controls.Add(Me.guest7)
        Me.Controls.Add(Me.guest6)
        Me.Controls.Add(Me.guest5)
        Me.Controls.Add(Me.guest4)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.cmdCustom)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.cmdSeatStool)
        Me.Controls.Add(Me.cmdOne)
        Me.Controls.Add(Me.cmdFive)
        Me.Controls.Add(Me.cmdFour)
        Me.Controls.Add(Me.cmdThree)
        Me.Controls.Add(Me.cmdTwo)
        Me.Controls.Add(Me.cmdQuickSale)
        Me.Controls.Add(Me.cmdMisc)
        Me.Controls.Add(Me.cmdMessage)
        Me.Controls.Add(Me.cmdFoods)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.guest3)
        Me.Controls.Add(Me.guest2)
        Me.Controls.Add(Me.guest1)
        Me.Controls.Add(Me.cmdRemoveTable)
        Me.Controls.Add(Me.cmdRemoveItem)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdServer)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdCloseTable)
        Me.Controls.Add(Me.dgvOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "POS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    'Dim da As New OleDb.OleDbDataAdapter

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Close()
    End Sub

    Private Sub Update_Order()
        lblTable.Text = d.GetTableName(Active.Table) & " " & Active.Ticket

        dgvOrder.DataSource = ""

        If Active.OrderType = "Food" Then
            dgvOrder.DataSource = data.GetData("SELECT LINE_NUM, ITEM_NAME AS Name, QUOTED_PRICE AS Price FROM OPEN_ORDER INNER JOIN ITEM ON ITEM.ITEM_NUM = OPEN_ORDER.ITEM_NUM WHERE ORDER_NUM = " & d.GetOrderNumber(Active.Ticket, Active.Guest)).Tables(0)
        ElseIf Active.OrderType = "Drinks" Then
            dgvOrder.DataSource = data.GetData("SELECT LINE_NUM, ITEM_NAME AS Name, QUOTED_PRICE AS Price FROM OPEN_BAR_ORDER INNER JOIN BAR_ITEM ON BAR_ITEM.ITEM_NUM = OPEN_BAR_ORDER.ITEM_NUM WHERE ORDER_NUM = " & d.GetOrderNumber(Active.Ticket, Active.Guest)).Tables(0)
        End If

        dgvOrder.Columns("LINE_NUM").Visible = False
        dgvOrder.Columns("Name").Width = 175
        dgvOrder.Columns("Price").Width = 50

        If dgvOrder.RowCount > 1 Then
            dgvOrder.FirstDisplayedScrollingRowIndex = dgvOrder.RowCount - 1
            dgvOrder.Rows(dgvOrder.RowCount - 1).Selected = True
        End If


    End Sub

    Private Sub cmdServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdServer.Click, lblTable.Click

        If QuickSale Then
            MsgBox("Need to close current order before selecting a different one.")
        Else
            Active.Clear()
            Dim formSelectTable As New SelectTable
            formSelectTable.ShowDialog()
            active.Guest = 1
            QuickSale = False
        End If

        Update_Order()
        Update_Screen()
    End Sub

    Private Sub Update_Screen()

        If Active.OrderType = "Food" Then
            TabControl1.Visible = True
            Panel1.Visible = False
            cmdFoods.BackColor = Color.LightGreen
            cmdDrinks.BackColor = Color.LightGray
            'cControl.BackColor = Color.DarkGreen
        ElseIf Active.OrderType = "Drinks" Then
            cmdFoods.BackColor = Color.LightGray
            cmdDrinks.BackColor = Color.LightGreen
            TabControl1.Visible = False
            Panel1.Visible = True
        End If


        'If Active.Computer = "BAR" Then
        '    If Saved.STATUS = "OPEN" Then
        '        cmdRemoveTable.Visible = True
        '        cmdRemoveItem.Visible = True
        '        cmdFoods.Visible = True
        '        cmdDrinks.Visible = True
        '        cmdCustom.Visible = True
        '        guest1.Visible = True
        '        guest2.Visible = True
        '        guest3.Visible = True
        '        guest4.Visible = True
        '        guest5.Visible = True
        '        guest6.Visible = True
        '        guest7.Visible = True
        '        guest8.Visible = True
        '        lblTotals.Visible = True
        '        dgvOrder.Visible = True
        '        cmdOne.Visible = False
        '        cmdTwo.Visible = False
        '        cmdThree.Visible = False
        '        cmdFour.Visible = False
        '        cmdFive.Visible = False
        '    End If
        '    If Saved.STATUS = "QUICK" Then
        '        cmdRemoveTable.Visible = True
        '        cmdRemoveItem.Visible = True
        '        cmdFoods.Visible = True
        '        cmdDrinks.Visible = True
        '        cmdCustom.Visible = True
        '        guest1.Visible = True
        '        guest2.Visible = True
        '        guest3.Visible = True
        '        guest4.Visible = True

        '        cmdOne.Visible = True
        '        cmdTwo.Visible = True
        '        cmdThree.Visible = True
        '        cmdFour.Visible = True
        '        cmdFive.Visible = True
        '        cmdRemoveTable.Text = "Cancel Order"
        '        lblTable.Text = "Quick Sale"
        '    End If

        '    If Saved.STATUS = "CLOSE" Then
        '        cmdRemoveTable.Visible = False
        '        cmdRemoveItem.Visible = False
        '        cmdFoods.Visible = False
        '        cmdCustom.Visible = False
        '        guest1.Visible = False
        '        guest2.Visible = False
        '        guest3.Visible = False
        '        guest4.Visible = False
        '        lblTable.Text = "Select a Table"
        '        TabControl1.Visible = False
        '        'lstOrderPK.Items.Clear()
        '        'lstOrderName.Items.Clear()
        '        'lstOrderPrice.Items.Clear()
        '        'lstGN.Items.Clear()
        '        cmdOne.Visible = False
        '        cmdTwo.Visible = False
        '        cmdThree.Visible = False
        '        cmdFour.Visible = False
        '        cmdFive.Visible = False
        '        cmdRemoveTable.Text = "Remove Table"
        '    End If
        'End If
        If Active.Computer = "SERVER" Then
            If Active.Ticket <> 0 Then

                cmdRemoveTable.Visible = True
                cmdRemoveItem.Visible = True
                cmdFoods.Visible = True
                cmdDrinks.Visible = True
                dgvOrder.Visible = True
                lblTotals.Visible = True
                cmdCustom.Visible = True
                cmdSeatStool.Visible = False
                guest1.Visible = True
                guest2.Visible = True
                guest3.Visible = True
                guest4.Visible = True
                guest5.Visible = True
                guest6.Visible = True
                guest7.Visible = True
                guest8.Visible = True
                cmdPrint.Visible = True

            Else






                cmdRemoveTable.Visible = False
                cmdRemoveItem.Visible = False
                cmdSeatStool.Visible = False
                cmdFoods.Visible = False
                cmdDrinks.Visible = False
                dgvOrder.Visible = False
                lblTotals.Visible = False
                cmdCustom.Visible = False
                guest1.Visible = False
                guest2.Visible = False
                guest3.Visible = False
                guest4.Visible = False
                guest5.Visible = False
                guest6.Visible = False
                guest7.Visible = False
                guest8.Visible = False
                cmdPrint.Visible = False
                lblTable.Text = "Select a Table"
                Panel1.Visible = False
                TabControl1.Visible = False
                'lstOrderPK.Items.Clear()
                'lstOrderName.Items.Clear()
                'lstOrderPrice.Items.Clear()
                'lstGN.Items.Clear()
            End If
        End If

    End Sub

    Private Sub POS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data.SetComputerToDefault()

        ds = data.GetData("SELECT MENU_ITEMS.MENU_NUM AS MenuNum, MENU_ITEMS.COLUMN AS ItemColumn, MENU_ITEMS.ROW AS ItemRow, MENU_ITEMS.ITEM_NUM AS ItemNum, COLORS.COLOR_NAME AS Color, ITEM.ITEM_NAME AS ItemName FROM COLORS INNER JOIN (ITEM INNER JOIN MENU_ITEMS ON ITEM.[ITEM_NUM] = MENU_ITEMS.[ITEM_NUM]) ON COLORS.COLOR_NUM = MENU_ITEMS.COLOR_NUM ORDER BY MENU_ITEMS.MENU_NUM, MENU_ITEMS.COLUMN, MENU_ITEMS.ROW")


        For Each DataRow As DataRow In ds.Tables(0).Rows
            For Each oTab As TabPage In TabControl1.TabPages
                For Each oControl As Button In oTab.Controls
                    If TypeOf oControl Is Button Then
                        If oControl.Name = "cmd0" & DataRow("MenuNum").ToString & "0" & DataRow("ItemColumn").ToString & "0" & DataRow("ItemRow").ToString Then
                            oControl.Text = DataRow("ItemName").ToString
                            oControl.Tag = "itm" & Format(DataRow("ItemNum"), "000")
                            oControl.Visible = True
                            Select Case DataRow("Color").ToString
                                Case "Blue"
                                    oControl.Image = My.Resources.Resource2.Text_Blue
                                Case "Green"
                                    oControl.Image = My.Resources.Resource2.Text_Green
                                Case "Teal"
                                    oControl.Image = My.Resources.Resource2.Text_Cyan
                                Case "Red"
                                    oControl.Image = My.Resources.Resource2.Text_Red
                                Case "Yellow"
                                    oControl.Image = My.Resources.Resource2.Text_Yellow
                                Case "Orange"
                                    oControl.Image = My.Resources.Resource2.Text_Orange
                                Case "Purple"
                                    oControl.Image = My.Resources.Resource2.Text_Purple
                            End Select
                        End If
                    End If
                Next
            Next
        Next
        Update_Screen()
    End Sub

    Private Sub Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd010101.Click, cmd010102.Click, cmd010103.Click, cmd010104.Click, cmd010105.Click, cmd010106.Click, cmd010201.Click, cmd010202.Click, cmd010203.Click, cmd010204.Click, cmd010205.Click, cmd010206.Click, cmd010301.Click, cmd010302.Click, cmd010303.Click, cmd010304.Click, cmd010305.Click, cmd010306.Click, cmd010401.Click, cmd010402.Click, cmd010403.Click, cmd010404.Click, cmd010405.Click, cmd010406.Click, cmd010501.Click, cmd010502.Click, cmd010503.Click, cmd010504.Click, cmd010505.Click, cmd010506.Click, cmd010601.Click, cmd010602.Click, cmd010603.Click, cmd010604.Click, cmd010605.Click, cmd010606.Click, cmd010701.Click, cmd010702.Click, cmd010703.Click, cmd010704.Click, cmd010705.Click, cmd010706.Click, cmd010801.Click, cmd010802.Click, cmd010803.Click, cmd010804.Click, cmd010805.Click, cmd010806.Click, cmd020101.Click, cmd020102.Click, cmd020103.Click, cmd020104.Click, cmd020105.Click, cmd020106.Click, cmd020201.Click, cmd020202.Click, cmd020203.Click, cmd020204.Click, cmd020205.Click, cmd020206.Click, cmd020301.Click, cmd020302.Click, cmd020303.Click, cmd020304.Click, cmd020305.Click, cmd020306.Click, cmd020401.Click, cmd020402.Click, cmd020403.Click, cmd020404.Click, cmd020405.Click, cmd020406.Click, cmd020501.Click, cmd020502.Click, cmd020503.Click, cmd020504.Click, cmd020505.Click, cmd020506.Click, cmd020601.Click, cmd020602.Click, cmd020603.Click, cmd020604.Click, cmd020605.Click, cmd020606.Click, cmd020701.Click, cmd020702.Click, cmd020703.Click, cmd020704.Click, cmd020705.Click, cmd020706.Click, cmd020801.Click, cmd020802.Click, cmd020803.Click, cmd020804.Click, cmd020805.Click, cmd020806.Click, cmd030101.Click, cmd030102.Click, cmd030103.Click, cmd030104.Click, cmd030105.Click, cmd030106.Click, cmd030201.Click, cmd030202.Click, cmd030203.Click, cmd030204.Click, cmd030205.Click, cmd030206.Click, cmd030301.Click, cmd030302.Click, cmd030303.Click, cmd030304.Click, cmd030305.Click, cmd030306.Click, cmd030401.Click, cmd030402.Click, cmd030403.Click, cmd030404.Click, cmd030405.Click, cmd030406.Click, cmd030501.Click, cmd030502.Click, cmd030503.Click, cmd030504.Click, cmd030505.Click, cmd030506.Click, cmd030601.Click, cmd030602.Click, cmd030603.Click, cmd030604.Click, cmd030605.Click, cmd030606.Click, cmd030701.Click, cmd030702.Click, cmd030703.Click, cmd030704.Click, cmd030705.Click, cmd030706.Click, cmd030801.Click, cmd030802.Click, cmd030803.Click, cmd030804.Click, cmd030805.Click, cmd030806.Click, cmd040101.Click, cmd040102.Click, cmd040103.Click, cmd040104.Click, cmd040105.Click, cmd040106.Click, cmd040201.Click, cmd040202.Click, cmd040203.Click, cmd040204.Click, cmd040205.Click, cmd040206.Click, cmd040301.Click, cmd040302.Click, cmd040303.Click, cmd040304.Click, cmd040305.Click, cmd040306.Click, cmd040401.Click, cmd040402.Click, cmd040403.Click, cmd040404.Click, cmd040405.Click, cmd040406.Click, cmd040501.Click, cmd040502.Click, cmd040503.Click, cmd040504.Click, cmd040505.Click, cmd040506.Click, cmd040601.Click, cmd040602.Click, cmd040603.Click, cmd040604.Click, cmd040605.Click, cmd040606.Click, cmd040701.Click, cmd040702.Click, cmd040703.Click, cmd040704.Click, cmd040705.Click, cmd040706.Click, cmd040801.Click, cmd040802.Click, cmd040803.Click, cmd040804.Click, cmd040805.Click, cmd040806.Click, cmd050101.Click, cmd050102.Click, cmd050103.Click, cmd050104.Click, cmd050105.Click, cmd050106.Click, cmd050201.Click, cmd050202.Click, cmd050203.Click, cmd050204.Click, cmd050205.Click, cmd050206.Click, cmd050301.Click, cmd050302.Click, cmd050303.Click, cmd050304.Click, cmd050305.Click, cmd050306.Click, cmd050401.Click, cmd050402.Click, cmd050403.Click, cmd050404.Click, cmd050405.Click, cmd050406.Click, cmd050501.Click, cmd050502.Click, cmd050503.Click, cmd050504.Click, cmd050505.Click, cmd050506.Click, cmd050601.Click, cmd050602.Click, cmd050603.Click, cmd050604.Click, cmd050605.Click, cmd050606.Click, cmd050701.Click, cmd050702.Click, cmd050703.Click, cmd050704.Click, cmd050705.Click, cmd050706.Click, cmd050801.Click, cmd050802.Click, cmd050803.Click, cmd050804.Click, cmd050805.Click, cmd050806.Click, cmd060101.Click, cmd060102.Click, cmd060103.Click, cmd060104.Click, cmd060105.Click, cmd060106.Click, cmd060201.Click, cmd060202.Click, cmd060203.Click, cmd060204.Click, cmd060205.Click, cmd060206.Click, cmd060301.Click, cmd060302.Click, cmd060303.Click, cmd060304.Click, cmd060305.Click, cmd060306.Click, cmd060401.Click, cmd060402.Click, cmd060403.Click, cmd060404.Click, cmd060405.Click, cmd060406.Click, cmd060501.Click, cmd060502.Click, cmd060503.Click, cmd060504.Click, cmd060505.Click, cmd060506.Click, cmd060601.Click, cmd060602.Click, cmd060603.Click, cmd060604.Click, cmd060605.Click, cmd060606.Click, cmd060701.Click, cmd060702.Click, cmd060703.Click, cmd060704.Click, cmd060705.Click, cmd060706.Click, cmd060801.Click, cmd060802.Click, cmd060803.Click, cmd060804.Click, cmd060805.Click, cmd060806.Click

        d.AddFoodItem(Active.Ticket, Active.Guest, Mid(sender.Tag, 4, 3))
        Update_Order()
    End Sub

    Private Sub cmdMisc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMisc.Click
        Dim frmMisc As New Misc
        frmMisc.ShowDialog()

    End Sub

    Public Sub UpdateSpecials()
        If Saved.SPECIALLINK(0) = True Then
            cmd010806.Tag = "itm" & Format(Saved.CURSPECIAL(0), "000")
            cmd010806.Text = Saved.SPECIALTEXT(0)
            cmd010806.Visible = True
            cmd020806.Tag = "itm" & Format(Saved.CURSPECIAL(0), "000")
            cmd020806.Text = Saved.SPECIALTEXT(0)
            cmd020806.Visible = True
            cmd030806.Tag = "itm" & Format(Saved.CURSPECIAL(0), "000")
            cmd030806.Text = Saved.SPECIALTEXT(0)
            cmd030806.Visible = True
        Else
            cmd010806.Tag = ""
            cmd010806.Text = ""
            cmd010806.Visible = False
            cmd020806.Tag = ""
            cmd020806.Text = ""
            cmd020806.Visible = False
            cmd030806.Tag = ""
            cmd030806.Text = ""
            cmd030806.Visible = False
        End If

        If Saved.SPECIALLINK(1) = True Then
            cmd010706.Tag = "itm" & Format(Saved.CURSPECIAL(1), "000")
            cmd010706.Text = Saved.SPECIALTEXT(1)
            cmd010706.Visible = True
            cmd020706.Tag = "itm" & Format(Saved.CURSPECIAL(1), "000")
            cmd020706.Text = Saved.SPECIALTEXT(1)
            cmd020706.Visible = True
            cmd030706.Tag = "itm" & Format(Saved.CURSPECIAL(1), "000")
            cmd030706.Text = Saved.SPECIALTEXT(1)
            cmd030706.Visible = True
        Else
            cmd010706.Tag = ""
            cmd010706.Text = ""
            cmd010706.Visible = False
            cmd020706.Tag = ""
            cmd020706.Text = ""
            cmd020706.Visible = False
            cmd030706.Tag = ""
            cmd030706.Text = ""
            cmd030706.Visible = False
        End If

        If Saved.SPECIALLINK(2) = True Then
            cmd010606.Tag = "itm" & Format(Saved.CURSPECIAL(2), "000")
            cmd010606.Text = Saved.SPECIALTEXT(2)
            cmd010606.Visible = True
            cmd020606.Tag = "itm" & Format(Saved.CURSPECIAL(2), "000")
            cmd020606.Text = Saved.SPECIALTEXT(2)
            cmd020606.Visible = True
            cmd030606.Tag = "itm" & Format(Saved.CURSPECIAL(2), "000")
            cmd030606.Text = Saved.SPECIALTEXT(2)
            cmd030606.Visible = True
        Else
            cmd010606.Tag = ""
            cmd010606.Text = ""
            cmd010606.Visible = False
            cmd020606.Tag = ""
            cmd020606.Text = ""
            cmd020606.Visible = False
            cmd030606.Tag = ""
            cmd030606.Text = ""
            cmd030606.Visible = False
        End If

        If Saved.SPECIALLINK(3) = True Then
            cmd010506.Tag = "itm" & Format(Saved.CURSPECIAL(3), "000")
            cmd010506.Text = Saved.SPECIALTEXT(3)
            cmd010506.Visible = True
            cmd020506.Tag = "itm" & Format(Saved.CURSPECIAL(3), "000")
            cmd020506.Text = Saved.SPECIALTEXT(3)
            cmd020506.Visible = True
            cmd030506.Tag = "itm" & Format(Saved.CURSPECIAL(3), "000")
            cmd030506.Text = Saved.SPECIALTEXT(3)
            cmd030506.Visible = True
        Else
            cmd010506.Tag = ""
            cmd010506.Text = ""
            cmd010506.Visible = False
            cmd020506.Tag = ""
            cmd020506.Text = ""
            cmd020506.Visible = False
            cmd030506.Tag = ""
            cmd030506.Text = ""
            cmd030506.Visible = False
        End If

        If Saved.SPECIALLINK(4) = True Then
            cmd010406.Tag = "itm" & Format(Saved.CURSPECIAL(4), "000")
            cmd010406.Text = Saved.SPECIALTEXT(4)
            cmd010406.Visible = True
            cmd020406.Tag = "itm" & Format(Saved.CURSPECIAL(4), "000")
            cmd020406.Text = Saved.SPECIALTEXT(4)
            cmd020406.Visible = True
            cmd030406.Tag = "itm" & Format(Saved.CURSPECIAL(4), "000")
            cmd030406.Text = Saved.SPECIALTEXT(4)
            cmd030406.Visible = True
        Else
            cmd010406.Tag = ""
            cmd010406.Text = ""
            cmd010406.Visible = False
            cmd020406.Tag = ""
            cmd020406.Text = ""
            cmd020406.Visible = False
            cmd030406.Tag = ""
            cmd030406.Text = ""
            cmd030406.Visible = False
        End If

        If Saved.SPECIALLINK(5) = True Then
            cmd010805.Tag = "itm" & Format(Saved.CURSPECIAL(5), "000")
            cmd010805.Text = Saved.SPECIALTEXT(5)
            cmd010805.Visible = True
            cmd020805.Tag = "itm" & Format(Saved.CURSPECIAL(5), "000")
            cmd020805.Text = Saved.SPECIALTEXT(5)
            cmd020805.Visible = True
            cmd030805.Tag = "itm" & Format(Saved.CURSPECIAL(5), "000")
            cmd030805.Text = Saved.SPECIALTEXT(5)
            cmd030805.Visible = True
        Else
            cmd010805.Tag = ""
            cmd010805.Text = ""
            cmd010805.Visible = False
            cmd020805.Tag = ""
            cmd020805.Text = ""
            cmd020805.Visible = False
            cmd030805.Tag = ""
            cmd030805.Text = ""
            cmd030805.Visible = False
        End If
    End Sub

    Private Sub cmdDone_Click(sender As System.Object, e As System.EventArgs) Handles cmdDone.Click
        Active.Clear()
        Update_Screen()
    End Sub

    Private Sub cmdRemoveItem_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemoveItem.Click
        If Active.OrderType = "Food" Then
            d.RemoveFoodItem(dgvOrder.SelectedRows(0).Cells(0).Value)
        ElseIf Active.OrderType = "Drinks" Then
            d.RemoveBarItem(dgvOrder.SelectedRows(0).Cells(0).Value)
        End If

        Update_Order()
    End Sub

    Private Sub cmdFoods_Click(sender As System.Object, e As System.EventArgs) Handles cmdFoods.Click
        If Active.OrderType <> "Food" Then
            Active.OrderType = "Food"
            Update_Screen()
            Update_Order()
        End If
    End Sub

    Private Sub cmdDrinks_Click(sender As System.Object, e As System.EventArgs) Handles cmdDrinks.Click
        If Active.OrderType <> "Drinks" Then
            Active.OrderType = "Drinks"
            Update_Screen()
            Update_Order()
        End If
    End Sub

    Private Sub guest_Click(sender As System.Object, e As System.EventArgs) Handles guest1.Click, guest2.Click, guest3.Click, guest4.Click, guest5.Click, guest6.Click, guest7.Click, guest8.Click
        active.Guest = sender.tag
        Update_Order()
    End Sub

    Private Sub barItem_Click(sender As System.Object, e As System.EventArgs) Handles bar001.Click, bar002.Click, bar003.Click, bar004.Click, bar005.Click, bar006.Click, bar007.Click, bar008.Click, bar009.Click, bar010.Click, bar011.Click, bar012.Click, bar013.Click, bar014.Click, bar015.Click, bar016.Click, bar017.Click, bar018.Click, bar019.Click, bar020.Click, bar021.Click, bar022.Click, bar023.Click, bar024.Click, bar025.Click, bar026.Click, bar027.Click, bar028.Click, bar029.Click, bar030.Click, bar031.Click, bar032.Click, bar033.Click, bar034.Click, bar035.Click, bar036.Click, bar037.Click, bar038.Click, bar039.Click, bar040.Click, bar041.Click, bar042.Click, bar043.Click, bar044.Click, bar045.Click, bar046.Click, bar047.Click, bar048.Click, bar049.Click, bar050.Click, bar051.Click, bar052.Click, bar053.Click, bar054.Click, bar055.Click, bar056.Click
        d.AddBarItem(Active.Ticket, Active.Guest, Mid(sender.name, 4, 3))
        Update_Order()
    End Sub
End Class
