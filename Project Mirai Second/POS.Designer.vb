<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlControlBox = New System.Windows.Forms.Panel()
        Me.lblFormUserSummary = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblFormLabel = New System.Windows.Forms.Label()
        Me.lblFormFlag = New System.Windows.Forms.Label()
        Me.POSTabControl = New System.Windows.Forms.TabControl()
        Me.tabconMain = New System.Windows.Forms.TabPage()
        Me.gpxTransactionMonitor = New System.Windows.Forms.GroupBox()
        Me.lblOverallSales = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.transactionPerHour = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTransactionCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabconUsers = New System.Windows.Forms.TabPage()
        Me.lblNoUser = New System.Windows.Forms.Label()
        Me.btnResetList = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lsvUserSearch = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserSearchBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.tabconSales = New System.Windows.Forms.TabPage()
        Me.grpTransactionManagement = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxTransType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpTransDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxPOS = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnApplyTransSettings = New System.Windows.Forms.Button()
        Me.btnExportReport = New System.Windows.Forms.Button()
        Me.btnViewTransaction = New System.Windows.Forms.Button()
        Me.lsvTransactionList = New System.Windows.Forms.ListView()
        Me.tabconBulk = New System.Windows.Forms.TabPage()
        Me.pnlControlBox.SuspendLayout()
        Me.POSTabControl.SuspendLayout()
        Me.tabconMain.SuspendLayout()
        Me.gpxTransactionMonitor.SuspendLayout()
        Me.tabconUsers.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tabconSales.SuspendLayout()
        Me.grpTransactionManagement.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlControlBox
        '
        Me.pnlControlBox.Controls.Add(Me.lblFormUserSummary)
        Me.pnlControlBox.Controls.Add(Me.btnClose)
        Me.pnlControlBox.Controls.Add(Me.lblFormLabel)
        Me.pnlControlBox.Location = New System.Drawing.Point(0, 0)
        Me.pnlControlBox.Name = "pnlControlBox"
        Me.pnlControlBox.Size = New System.Drawing.Size(1366, 29)
        Me.pnlControlBox.TabIndex = 11
        '
        'lblFormUserSummary
        '
        Me.lblFormUserSummary.Location = New System.Drawing.Point(100, 0)
        Me.lblFormUserSummary.Name = "lblFormUserSummary"
        Me.lblFormUserSummary.Size = New System.Drawing.Size(549, 28)
        Me.lblFormUserSummary.TabIndex = 13
        Me.lblFormUserSummary.Text = "NAME (EMPLOYEE ID) - POSITION"
        Me.lblFormUserSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1239, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(127, 28)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblFormLabel
        '
        Me.lblFormLabel.AutoSize = True
        Me.lblFormLabel.Location = New System.Drawing.Point(12, 6)
        Me.lblFormLabel.Name = "lblFormLabel"
        Me.lblFormLabel.Size = New System.Drawing.Size(82, 15)
        Me.lblFormLabel.TabIndex = 0
        Me.lblFormLabel.Text = "POS Dashboard"
        '
        'lblFormFlag
        '
        Me.lblFormFlag.Font = New System.Drawing.Font("WeblySleek UI Semilight", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormFlag.Location = New System.Drawing.Point(-1, 29)
        Me.lblFormFlag.Name = "lblFormFlag"
        Me.lblFormFlag.Size = New System.Drawing.Size(379, 80)
        Me.lblFormFlag.TabIndex = 12
        Me.lblFormFlag.Text = "POS Dashboard"
        '
        'POSTabControl
        '
        Me.POSTabControl.Controls.Add(Me.tabconMain)
        Me.POSTabControl.Controls.Add(Me.tabconUsers)
        Me.POSTabControl.Controls.Add(Me.tabconSales)
        Me.POSTabControl.Controls.Add(Me.tabconBulk)
        Me.POSTabControl.Font = New System.Drawing.Font("WeblySleek UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POSTabControl.Location = New System.Drawing.Point(15, 112)
        Me.POSTabControl.Name = "POSTabControl"
        Me.POSTabControl.Padding = New System.Drawing.Point(10, 5)
        Me.POSTabControl.SelectedIndex = 0
        Me.POSTabControl.Size = New System.Drawing.Size(1339, 644)
        Me.POSTabControl.TabIndex = 13
        '
        'tabconMain
        '
        Me.tabconMain.Controls.Add(Me.gpxTransactionMonitor)
        Me.tabconMain.Location = New System.Drawing.Point(4, 41)
        Me.tabconMain.Name = "tabconMain"
        Me.tabconMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tabconMain.Size = New System.Drawing.Size(1331, 599)
        Me.tabconMain.TabIndex = 0
        Me.tabconMain.Text = "Summary"
        Me.tabconMain.UseVisualStyleBackColor = True
        '
        'gpxTransactionMonitor
        '
        Me.gpxTransactionMonitor.Controls.Add(Me.lblOverallSales)
        Me.gpxTransactionMonitor.Controls.Add(Me.Label10)
        Me.gpxTransactionMonitor.Controls.Add(Me.transactionPerHour)
        Me.gpxTransactionMonitor.Controls.Add(Me.Label8)
        Me.gpxTransactionMonitor.Controls.Add(Me.lblTransactionCount)
        Me.gpxTransactionMonitor.Controls.Add(Me.Label4)
        Me.gpxTransactionMonitor.Location = New System.Drawing.Point(13, 13)
        Me.gpxTransactionMonitor.Margin = New System.Windows.Forms.Padding(10)
        Me.gpxTransactionMonitor.Name = "gpxTransactionMonitor"
        Me.gpxTransactionMonitor.Size = New System.Drawing.Size(438, 260)
        Me.gpxTransactionMonitor.TabIndex = 0
        Me.gpxTransactionMonitor.TabStop = False
        '
        'lblOverallSales
        '
        Me.lblOverallSales.Font = New System.Drawing.Font("WeblySleek UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverallSales.Location = New System.Drawing.Point(7, 203)
        Me.lblOverallSales.Name = "lblOverallSales"
        Me.lblOverallSales.Size = New System.Drawing.Size(424, 50)
        Me.lblOverallSales.TabIndex = 5
        Me.lblOverallSales.Text = "salesAmount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 175)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 28)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Overall Sales"
        '
        'transactionPerHour
        '
        Me.transactionPerHour.Font = New System.Drawing.Font("WeblySleek UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactionPerHour.Location = New System.Drawing.Point(7, 125)
        Me.transactionPerHour.Name = "transactionPerHour"
        Me.transactionPerHour.Size = New System.Drawing.Size(424, 50)
        Me.transactionPerHour.TabIndex = 3
        Me.transactionPerHour.Text = "transCountPerHour"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 97)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 28)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Transaction per Hour"
        '
        'lblTransactionCount
        '
        Me.lblTransactionCount.Font = New System.Drawing.Font("WeblySleek UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionCount.Location = New System.Drawing.Point(7, 47)
        Me.lblTransactionCount.Name = "lblTransactionCount"
        Me.lblTransactionCount.Size = New System.Drawing.Size(424, 50)
        Me.lblTransactionCount.TabIndex = 1
        Me.lblTransactionCount.Text = "transCount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Transaction Count"
        '
        'tabconUsers
        '
        Me.tabconUsers.Controls.Add(Me.lblNoUser)
        Me.tabconUsers.Controls.Add(Me.btnResetList)
        Me.tabconUsers.Controls.Add(Me.Panel1)
        Me.tabconUsers.Controls.Add(Me.txtUserSearchBox)
        Me.tabconUsers.Controls.Add(Me.Label2)
        Me.tabconUsers.Controls.Add(Me.btnEditUser)
        Me.tabconUsers.Controls.Add(Me.btnAddUser)
        Me.tabconUsers.Location = New System.Drawing.Point(4, 41)
        Me.tabconUsers.Name = "tabconUsers"
        Me.tabconUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabconUsers.Size = New System.Drawing.Size(1331, 599)
        Me.tabconUsers.TabIndex = 1
        Me.tabconUsers.Text = "POS Users"
        Me.tabconUsers.UseVisualStyleBackColor = True
        '
        'lblNoUser
        '
        Me.lblNoUser.AutoSize = True
        Me.lblNoUser.Location = New System.Drawing.Point(792, 124)
        Me.lblNoUser.Name = "lblNoUser"
        Me.lblNoUser.Size = New System.Drawing.Size(215, 28)
        Me.lblNoUser.TabIndex = 8
        Me.lblNoUser.Text = "Oops, no users found."
        Me.lblNoUser.Visible = False
        '
        'btnResetList
        '
        Me.btnResetList.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResetList.FlatAppearance.BorderSize = 0
        Me.btnResetList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetList.ForeColor = System.Drawing.Color.White
        Me.btnResetList.Location = New System.Drawing.Point(636, 121)
        Me.btnResetList.Name = "btnResetList"
        Me.btnResetList.Size = New System.Drawing.Size(150, 35)
        Me.btnResetList.TabIndex = 7
        Me.btnResetList.Text = "Reset List"
        Me.btnResetList.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lsvUserSearch)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(13, 169)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1310, 417)
        Me.Panel1.TabIndex = 6
        '
        'lsvUserSearch
        '
        Me.lsvUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsvUserSearch.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvUserSearch.FullRowSelect = True
        Me.lsvUserSearch.GridLines = True
        Me.lsvUserSearch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvUserSearch.Location = New System.Drawing.Point(5, 32)
        Me.lsvUserSearch.MultiSelect = False
        Me.lsvUserSearch.Name = "lsvUserSearch"
        Me.lsvUserSearch.Size = New System.Drawing.Size(1287, 375)
        Me.lsvUserSearch.TabIndex = 8
        Me.lsvUserSearch.UseCompatibleStateImageBehavior = False
        Me.lsvUserSearch.View = System.Windows.Forms.View.Details
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Results"
        '
        'txtUserSearchBox
        '
        Me.txtUserSearchBox.Location = New System.Drawing.Point(13, 121)
        Me.txtUserSearchBox.Name = "txtUserSearchBox"
        Me.txtUserSearchBox.Size = New System.Drawing.Size(617, 35)
        Me.txtUserSearchBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search"
        '
        'btnEditUser
        '
        Me.btnEditUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEditUser.Enabled = False
        Me.btnEditUser.FlatAppearance.BorderSize = 0
        Me.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditUser.ForeColor = System.Drawing.Color.White
        Me.btnEditUser.Location = New System.Drawing.Point(169, 6)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(150, 60)
        Me.btnEditUser.TabIndex = 2
        Me.btnEditUser.Text = "Edit User"
        Me.btnEditUser.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddUser.FlatAppearance.BorderSize = 0
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.Location = New System.Drawing.Point(13, 6)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(150, 60)
        Me.btnAddUser.TabIndex = 0
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'tabconSales
        '
        Me.tabconSales.AutoScroll = True
        Me.tabconSales.Controls.Add(Me.grpTransactionManagement)
        Me.tabconSales.Location = New System.Drawing.Point(4, 41)
        Me.tabconSales.Name = "tabconSales"
        Me.tabconSales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabconSales.Size = New System.Drawing.Size(1331, 599)
        Me.tabconSales.TabIndex = 2
        Me.tabconSales.Text = "Transactions"
        Me.tabconSales.UseVisualStyleBackColor = True
        '
        'grpTransactionManagement
        '
        Me.grpTransactionManagement.Controls.Add(Me.GroupBox1)
        Me.grpTransactionManagement.Controls.Add(Me.btnExportReport)
        Me.grpTransactionManagement.Controls.Add(Me.btnViewTransaction)
        Me.grpTransactionManagement.Controls.Add(Me.lsvTransactionList)
        Me.grpTransactionManagement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTransactionManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpTransactionManagement.Location = New System.Drawing.Point(3, 3)
        Me.grpTransactionManagement.Name = "grpTransactionManagement"
        Me.grpTransactionManagement.Size = New System.Drawing.Size(1325, 593)
        Me.grpTransactionManagement.TabIndex = 5
        Me.grpTransactionManagement.TabStop = False
        Me.grpTransactionManagement.Text = "Transaction Management"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxTransType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpTransDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbxPOS)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnApplyTransSettings)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(3, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 559)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'cbxTransType
        '
        Me.cbxTransType.FormattingEnabled = True
        Me.cbxTransType.Items.AddRange(New Object() {"DINE IN", "TAKE OUT", "BULK"})
        Me.cbxTransType.Location = New System.Drawing.Point(11, 221)
        Me.cbxTransType.Margin = New System.Windows.Forms.Padding(3, 3, 8, 3)
        Me.cbxTransType.Name = "cbxTransType"
        Me.cbxTransType.Size = New System.Drawing.Size(230, 36)
        Me.cbxTransType.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 190)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 28)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Transaction Type"
        '
        'dtpTransDate
        '
        Me.dtpTransDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransDate.Location = New System.Drawing.Point(11, 142)
        Me.dtpTransDate.Name = "dtpTransDate"
        Me.dtpTransDate.Size = New System.Drawing.Size(230, 35)
        Me.dtpTransDate.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Transaction Date"
        '
        'cbxPOS
        '
        Me.cbxPOS.FormattingEnabled = True
        Me.cbxPOS.Location = New System.Drawing.Point(11, 62)
        Me.cbxPOS.Margin = New System.Windows.Forms.Padding(3, 3, 8, 3)
        Me.cbxPOS.Name = "cbxPOS"
        Me.cbxPOS.Size = New System.Drawing.Size(230, 36)
        Me.cbxPOS.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "POS"
        '
        'btnApplyTransSettings
        '
        Me.btnApplyTransSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnApplyTransSettings.FlatAppearance.BorderSize = 0
        Me.btnApplyTransSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyTransSettings.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyTransSettings.ForeColor = System.Drawing.Color.White
        Me.btnApplyTransSettings.Location = New System.Drawing.Point(77, 280)
        Me.btnApplyTransSettings.Margin = New System.Windows.Forms.Padding(3, 20, 3, 10)
        Me.btnApplyTransSettings.Name = "btnApplyTransSettings"
        Me.btnApplyTransSettings.Size = New System.Drawing.Size(98, 32)
        Me.btnApplyTransSettings.TabIndex = 2
        Me.btnApplyTransSettings.Text = "Apply"
        Me.btnApplyTransSettings.UseVisualStyleBackColor = False
        '
        'btnExportReport
        '
        Me.btnExportReport.BackColor = System.Drawing.Color.LimeGreen
        Me.btnExportReport.FlatAppearance.BorderSize = 0
        Me.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportReport.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportReport.ForeColor = System.Drawing.Color.White
        Me.btnExportReport.Location = New System.Drawing.Point(261, 548)
        Me.btnExportReport.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.btnExportReport.Name = "btnExportReport"
        Me.btnExportReport.Size = New System.Drawing.Size(258, 32)
        Me.btnExportReport.TabIndex = 3
        Me.btnExportReport.Text = "Export Report"
        Me.btnExportReport.UseVisualStyleBackColor = False
        '
        'btnViewTransaction
        '
        Me.btnViewTransaction.BackColor = System.Drawing.Color.Orange
        Me.btnViewTransaction.Enabled = False
        Me.btnViewTransaction.FlatAppearance.BorderSize = 0
        Me.btnViewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewTransaction.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTransaction.ForeColor = System.Drawing.Color.White
        Me.btnViewTransaction.Location = New System.Drawing.Point(1055, 548)
        Me.btnViewTransaction.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.btnViewTransaction.Name = "btnViewTransaction"
        Me.btnViewTransaction.Size = New System.Drawing.Size(258, 32)
        Me.btnViewTransaction.TabIndex = 2
        Me.btnViewTransaction.Text = "View Transaction"
        Me.btnViewTransaction.UseVisualStyleBackColor = False
        '
        'lsvTransactionList
        '
        Me.lsvTransactionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsvTransactionList.FullRowSelect = True
        Me.lsvTransactionList.GridLines = True
        Me.lsvTransactionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvTransactionList.HideSelection = False
        Me.lsvTransactionList.Location = New System.Drawing.Point(261, 34)
        Me.lsvTransactionList.MultiSelect = False
        Me.lsvTransactionList.Name = "lsvTransactionList"
        Me.lsvTransactionList.Size = New System.Drawing.Size(1052, 508)
        Me.lsvTransactionList.TabIndex = 1
        Me.lsvTransactionList.UseCompatibleStateImageBehavior = False
        Me.lsvTransactionList.View = System.Windows.Forms.View.Details
        '
        'tabconBulk
        '
        Me.tabconBulk.Location = New System.Drawing.Point(4, 41)
        Me.tabconBulk.Name = "tabconBulk"
        Me.tabconBulk.Padding = New System.Windows.Forms.Padding(3)
        Me.tabconBulk.Size = New System.Drawing.Size(1331, 599)
        Me.tabconBulk.TabIndex = 3
        Me.tabconBulk.Text = "Bulk Orders"
        Me.tabconBulk.UseVisualStyleBackColor = True
        '
        'POS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.POSTabControl)
        Me.Controls.Add(Me.lblFormFlag)
        Me.Controls.Add(Me.pnlControlBox)
        Me.Font = New System.Drawing.Font("WeblySleek UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "POS"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.pnlControlBox.ResumeLayout(False)
        Me.pnlControlBox.PerformLayout()
        Me.POSTabControl.ResumeLayout(False)
        Me.tabconMain.ResumeLayout(False)
        Me.gpxTransactionMonitor.ResumeLayout(False)
        Me.gpxTransactionMonitor.PerformLayout()
        Me.tabconUsers.ResumeLayout(False)
        Me.tabconUsers.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabconSales.ResumeLayout(False)
        Me.grpTransactionManagement.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlControlBox As Panel
    Friend WithEvents lblFormUserSummary As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblFormLabel As Label
    Friend WithEvents lblFormFlag As Label
    Friend WithEvents POSTabControl As TabControl
    Friend WithEvents tabconMain As TabPage
    Friend WithEvents tabconUsers As TabPage
    Friend WithEvents tabconSales As TabPage
    Friend WithEvents tabconBulk As TabPage
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnEditUser As Button
    Friend WithEvents txtUserSearchBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnResetList As Button
    Friend WithEvents lsvUserSearch As ListView
    Friend WithEvents grpTransactionManagement As GroupBox
    Friend WithEvents lsvTransactionList As ListView
    Friend WithEvents btnViewTransaction As Button
    Friend WithEvents btnExportReport As Button
    Friend WithEvents gpxTransactionMonitor As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTransactionCount As Label
    Friend WithEvents transactionPerHour As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblOverallSales As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNoUser As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnApplyTransSettings As Button
    Friend WithEvents cbxPOS As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpTransDate As DateTimePicker
    Friend WithEvents cbxTransType As ComboBox
    Friend WithEvents Label6 As Label
End Class
