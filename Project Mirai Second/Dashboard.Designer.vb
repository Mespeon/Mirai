<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.lblFormLabel = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlControlBox = New System.Windows.Forms.Panel()
        Me.lblFormUserSummary = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.pnlMenuStrip = New System.Windows.Forms.Panel()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.lblActiveUsername = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnPOS = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPOS6Status = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPOS5Status = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPOS4Status = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPOS3Status = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPOS2Status = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPOS1Status = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lnkRefreshUserPanel = New System.Windows.Forms.LinkLabel()
        Me.lblPOS6User = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblPOS5User = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblPOS4User = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblPOS3User = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblPOS2User = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblPOS1User = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.pnlBusinessDate = New System.Windows.Forms.Panel()
        Me.btnToggleBusinessDay = New System.Windows.Forms.Button()
        Me.lblBusinessDateNotification = New System.Windows.Forms.Label()
        Me.OperationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlControlBox.SuspendLayout()
        Me.pnlMenuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.pnlBusinessDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFormLabel
        '
        Me.lblFormLabel.AutoSize = True
        Me.lblFormLabel.Location = New System.Drawing.Point(12, 5)
        Me.lblFormLabel.Name = "lblFormLabel"
        Me.lblFormLabel.Size = New System.Drawing.Size(71, 15)
        Me.lblFormLabel.TabIndex = 0
        Me.lblFormLabel.Text = "DASHBOARD"
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
        Me.btnClose.Size = New System.Drawing.Size(127, 24)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Log Out"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlControlBox
        '
        Me.pnlControlBox.Controls.Add(Me.lblFormUserSummary)
        Me.pnlControlBox.Controls.Add(Me.Label2)
        Me.pnlControlBox.Controls.Add(Me.txtSearchBox)
        Me.pnlControlBox.Controls.Add(Me.btnClose)
        Me.pnlControlBox.Controls.Add(Me.lblFormLabel)
        Me.pnlControlBox.Location = New System.Drawing.Point(0, 0)
        Me.pnlControlBox.Name = "pnlControlBox"
        Me.pnlControlBox.Size = New System.Drawing.Size(1366, 25)
        Me.pnlControlBox.TabIndex = 10
        '
        'lblFormUserSummary
        '
        Me.lblFormUserSummary.Location = New System.Drawing.Point(90, 0)
        Me.lblFormUserSummary.Name = "lblFormUserSummary"
        Me.lblFormUserSummary.Size = New System.Drawing.Size(549, 24)
        Me.lblFormUserSummary.TabIndex = 13
        Me.lblFormUserSummary.Text = "NAME (EMPLOYEE ID) - POSITION"
        Me.lblFormUserSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(972, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "QUICK SEARCH"
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Location = New System.Drawing.Point(1059, 3)
        Me.txtSearchBox.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(170, 22)
        Me.txtSearchBox.TabIndex = 11
        Me.txtSearchBox.TabStop = False
        '
        'pnlMenuStrip
        '
        Me.pnlMenuStrip.Controls.Add(Me.btnInventory)
        Me.pnlMenuStrip.Controls.Add(Me.btnReports)
        Me.pnlMenuStrip.Controls.Add(Me.lblActiveUsername)
        Me.pnlMenuStrip.Controls.Add(Me.Label3)
        Me.pnlMenuStrip.Controls.Add(Me.btnSales)
        Me.pnlMenuStrip.Controls.Add(Me.btnPOS)
        Me.pnlMenuStrip.Location = New System.Drawing.Point(0, 31)
        Me.pnlMenuStrip.Name = "pnlMenuStrip"
        Me.pnlMenuStrip.Size = New System.Drawing.Size(1366, 50)
        Me.pnlMenuStrip.TabIndex = 11
        '
        'btnInventory
        '
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Location = New System.Drawing.Point(399, 3)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(122, 44)
        Me.btnInventory.TabIndex = 17
        Me.btnInventory.Text = "INVENTORY"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Location = New System.Drawing.Point(271, 3)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(122, 44)
        Me.btnReports.TabIndex = 16
        Me.btnReports.Text = "REPORTS"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'lblActiveUsername
        '
        Me.lblActiveUsername.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveUsername.Location = New System.Drawing.Point(1083, 18)
        Me.lblActiveUsername.Name = "lblActiveUsername"
        Me.lblActiveUsername.Size = New System.Drawing.Size(280, 29)
        Me.lblActiveUsername.TabIndex = 12
        Me.lblActiveUsername.Text = "NAME GOES IN HERE"
        Me.lblActiveUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1083, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "You are logged in as:"
        '
        'btnSales
        '
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Location = New System.Drawing.Point(143, 3)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(122, 44)
        Me.btnSales.TabIndex = 14
        Me.btnSales.Text = "SALES"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnPOS
        '
        Me.btnPOS.FlatAppearance.BorderSize = 0
        Me.btnPOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOS.Location = New System.Drawing.Point(15, 3)
        Me.btnPOS.Name = "btnPOS"
        Me.btnPOS.Size = New System.Drawing.Size(122, 44)
        Me.btnPOS.TabIndex = 13
        Me.btnPOS.Text = "POS"
        Me.btnPOS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPOS6Status)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblPOS5Status)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblPOS4Status)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblPOS3Status)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblPOS2Status)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblPOS1Status)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("WeblySleek UI Semilight", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(727, 527)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 222)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "POS Connection"
        '
        'lblPOS6Status
        '
        Me.lblPOS6Status.BackColor = System.Drawing.Color.Crimson
        Me.lblPOS6Status.ForeColor = System.Drawing.Color.White
        Me.lblPOS6Status.Location = New System.Drawing.Point(373, 156)
        Me.lblPOS6Status.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPOS6Status.Name = "lblPOS6Status"
        Me.lblPOS6Status.Size = New System.Drawing.Size(233, 52)
        Me.lblPOS6Status.TabIndex = 11
        Me.lblPOS6Status.Text = "OFFLINE"
        Me.lblPOS6Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(309, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 26)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "POS 6"
        '
        'lblPOS5Status
        '
        Me.lblPOS5Status.BackColor = System.Drawing.Color.Crimson
        Me.lblPOS5Status.ForeColor = System.Drawing.Color.White
        Me.lblPOS5Status.Location = New System.Drawing.Point(373, 99)
        Me.lblPOS5Status.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPOS5Status.Name = "lblPOS5Status"
        Me.lblPOS5Status.Size = New System.Drawing.Size(233, 52)
        Me.lblPOS5Status.TabIndex = 9
        Me.lblPOS5Status.Text = "OFFLINE"
        Me.lblPOS5Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(309, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 26)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "POS 5"
        '
        'lblPOS4Status
        '
        Me.lblPOS4Status.BackColor = System.Drawing.Color.Crimson
        Me.lblPOS4Status.ForeColor = System.Drawing.Color.White
        Me.lblPOS4Status.Location = New System.Drawing.Point(373, 42)
        Me.lblPOS4Status.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPOS4Status.Name = "lblPOS4Status"
        Me.lblPOS4Status.Size = New System.Drawing.Size(233, 52)
        Me.lblPOS4Status.TabIndex = 7
        Me.lblPOS4Status.Text = "OFFLINE"
        Me.lblPOS4Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(309, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 26)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "POS 4"
        '
        'lblPOS3Status
        '
        Me.lblPOS3Status.BackColor = System.Drawing.Color.Crimson
        Me.lblPOS3Status.ForeColor = System.Drawing.Color.White
        Me.lblPOS3Status.Location = New System.Drawing.Point(70, 156)
        Me.lblPOS3Status.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPOS3Status.Name = "lblPOS3Status"
        Me.lblPOS3Status.Size = New System.Drawing.Size(233, 52)
        Me.lblPOS3Status.TabIndex = 5
        Me.lblPOS3Status.Text = "OFFLINE"
        Me.lblPOS3Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 26)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "POS 3"
        '
        'lblPOS2Status
        '
        Me.lblPOS2Status.BackColor = System.Drawing.Color.Crimson
        Me.lblPOS2Status.ForeColor = System.Drawing.Color.White
        Me.lblPOS2Status.Location = New System.Drawing.Point(70, 99)
        Me.lblPOS2Status.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPOS2Status.Name = "lblPOS2Status"
        Me.lblPOS2Status.Size = New System.Drawing.Size(233, 52)
        Me.lblPOS2Status.TabIndex = 3
        Me.lblPOS2Status.Text = "OFFLINE"
        Me.lblPOS2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "POS 2"
        '
        'lblPOS1Status
        '
        Me.lblPOS1Status.BackColor = System.Drawing.Color.Crimson
        Me.lblPOS1Status.ForeColor = System.Drawing.Color.White
        Me.lblPOS1Status.Location = New System.Drawing.Point(70, 42)
        Me.lblPOS1Status.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPOS1Status.Name = "lblPOS1Status"
        Me.lblPOS1Status.Size = New System.Drawing.Size(233, 52)
        Me.lblPOS1Status.TabIndex = 1
        Me.lblPOS1Status.Text = "OFFLINE"
        Me.lblPOS1Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "POS 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lnkRefreshUserPanel)
        Me.GroupBox2.Controls.Add(Me.lblPOS6User)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lblPOS5User)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.lblPOS4User)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.lblPOS3User)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.lblPOS2User)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.lblPOS1User)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("WeblySleek UI Semilight", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(727, 285)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(620, 222)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "POS Users"
        '
        'lnkRefreshUserPanel
        '
        Me.lnkRefreshUserPanel.AutoSize = True
        Me.lnkRefreshUserPanel.Font = New System.Drawing.Font("WeblySleek UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkRefreshUserPanel.Location = New System.Drawing.Point(536, 0)
        Me.lnkRefreshUserPanel.Name = "lnkRefreshUserPanel"
        Me.lnkRefreshUserPanel.Size = New System.Drawing.Size(84, 17)
        Me.lnkRefreshUserPanel.TabIndex = 12
        Me.lnkRefreshUserPanel.TabStop = True
        Me.lnkRefreshUserPanel.Text = "Refresh Panel"
        '
        'lblPOS6User
        '
        Me.lblPOS6User.BackColor = System.Drawing.SystemColors.Control
        Me.lblPOS6User.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPOS6User.Location = New System.Drawing.Point(373, 156)
        Me.lblPOS6User.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPOS6User.Name = "lblPOS6User"
        Me.lblPOS6User.Size = New System.Drawing.Size(233, 52)
        Me.lblPOS6User.TabIndex = 11
        Me.lblPOS6User.Text = "No User"
        Me.lblPOS6User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(309, 172)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 26)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "POS 6"
        '
        'lblPOS5User
        '
        Me.lblPOS5User.BackColor = System.Drawing.SystemColors.Control
        Me.lblPOS5User.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPOS5User.Location = New System.Drawing.Point(373, 99)
        Me.lblPOS5User.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPOS5User.Name = "lblPOS5User"
        Me.lblPOS5User.Size = New System.Drawing.Size(233, 52)
        Me.lblPOS5User.TabIndex = 9
        Me.lblPOS5User.Text = "No User"
        Me.lblPOS5User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(309, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 26)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "POS 5"
        '
        'lblPOS4User
        '
        Me.lblPOS4User.BackColor = System.Drawing.SystemColors.Control
        Me.lblPOS4User.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPOS4User.Location = New System.Drawing.Point(373, 42)
        Me.lblPOS4User.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPOS4User.Name = "lblPOS4User"
        Me.lblPOS4User.Size = New System.Drawing.Size(233, 52)
        Me.lblPOS4User.TabIndex = 7
        Me.lblPOS4User.Text = "No User"
        Me.lblPOS4User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(309, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 26)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "POS 4"
        '
        'lblPOS3User
        '
        Me.lblPOS3User.BackColor = System.Drawing.SystemColors.Control
        Me.lblPOS3User.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPOS3User.Location = New System.Drawing.Point(70, 156)
        Me.lblPOS3User.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPOS3User.Name = "lblPOS3User"
        Me.lblPOS3User.Size = New System.Drawing.Size(233, 52)
        Me.lblPOS3User.TabIndex = 5
        Me.lblPOS3User.Text = "No User"
        Me.lblPOS3User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 172)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 26)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "POS 3"
        '
        'lblPOS2User
        '
        Me.lblPOS2User.BackColor = System.Drawing.SystemColors.Control
        Me.lblPOS2User.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPOS2User.Location = New System.Drawing.Point(70, 99)
        Me.lblPOS2User.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPOS2User.Name = "lblPOS2User"
        Me.lblPOS2User.Size = New System.Drawing.Size(233, 52)
        Me.lblPOS2User.TabIndex = 3
        Me.lblPOS2User.Text = "No User"
        Me.lblPOS2User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 115)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(61, 26)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "POS 2"
        '
        'lblPOS1User
        '
        Me.lblPOS1User.BackColor = System.Drawing.SystemColors.Control
        Me.lblPOS1User.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPOS1User.Location = New System.Drawing.Point(70, 42)
        Me.lblPOS1User.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPOS1User.Name = "lblPOS1User"
        Me.lblPOS1User.Size = New System.Drawing.Size(233, 52)
        Me.lblPOS1User.TabIndex = 1
        Me.lblPOS1User.Text = "No User"
        Me.lblPOS1User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 58)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 26)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "POS 1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("WeblySleek UI Semilight", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(727, 94)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(620, 171)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "POS Statistics"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Crimson
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(384, 99)
        Me.Label29.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(202, 52)
        Me.Label29.TabIndex = 9
        Me.Label29.Text = "POS"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(309, 115)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(74, 26)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "Slowest"
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Crimson
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(384, 42)
        Me.Label31.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(202, 52)
        Me.Label31.TabIndex = 7
        Me.Label31.Text = "0"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(309, 58)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(69, 26)
        Me.Label32.TabIndex = 6
        Me.Label32.Text = "Lowest"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.LimeGreen
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(101, 99)
        Me.Label35.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(203, 52)
        Me.Label35.TabIndex = 3
        Me.Label35.Text = "POS"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(6, 115)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(68, 26)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "Fastest"
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.LimeGreen
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(101, 42)
        Me.Label37.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(202, 52)
        Me.Label37.TabIndex = 1
        Me.Label37.Text = "0"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(6, 58)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(89, 26)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "Top Sales"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Controls.Add(Me.Label46)
        Me.GroupBox5.Controls.Add(Me.Label47)
        Me.GroupBox5.Controls.Add(Me.Label48)
        Me.GroupBox5.Controls.Add(Me.Label49)
        Me.GroupBox5.Controls.Add(Me.Label50)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Font = New System.Drawing.Font("WeblySleek UI Semilight", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(44, 313)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(620, 171)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Store Sales Statistics"
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.Control
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(398, 99)
        Me.Label43.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(202, 52)
        Me.Label43.TabIndex = 9
        Me.Label43.Text = "0"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(323, 115)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(57, 26)
        Me.Label44.TabIndex = 8
        Me.Label44.Text = "VS LY"
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.Control
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(398, 42)
        Me.Label45.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(202, 52)
        Me.Label45.TabIndex = 7
        Me.Label45.Text = "0"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(323, 58)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(71, 26)
        Me.Label46.TabIndex = 6
        Me.Label46.Text = "VS TGT"
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.Control
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(115, 99)
        Me.Label47.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(203, 52)
        Me.Label47.TabIndex = 3
        Me.Label47.Text = "0"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(20, 115)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(72, 26)
        Me.Label48.TabIndex = 2
        Me.Label48.Text = "VS LBD"
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.Control
        Me.Label49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label49.Location = New System.Drawing.Point(115, 42)
        Me.Label49.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(202, 52)
        Me.Label49.TabIndex = 1
        Me.Label49.Text = "0"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(20, 58)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(61, 26)
        Me.Label50.TabIndex = 0
        Me.Label50.Text = "Today"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.pnlBusinessDate)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox6.Font = New System.Drawing.Font("WeblySleek UI Semilight", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(41, 91)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(620, 202)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Business Date"
        '
        'pnlBusinessDate
        '
        Me.pnlBusinessDate.Controls.Add(Me.btnToggleBusinessDay)
        Me.pnlBusinessDate.Controls.Add(Me.lblBusinessDateNotification)
        Me.pnlBusinessDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBusinessDate.Location = New System.Drawing.Point(3, 39)
        Me.pnlBusinessDate.Name = "pnlBusinessDate"
        Me.pnlBusinessDate.Size = New System.Drawing.Size(614, 160)
        Me.pnlBusinessDate.TabIndex = 0
        '
        'btnToggleBusinessDay
        '
        Me.btnToggleBusinessDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnToggleBusinessDay.FlatAppearance.BorderSize = 0
        Me.btnToggleBusinessDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggleBusinessDay.Font = New System.Drawing.Font("WeblySleek UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleBusinessDay.ForeColor = System.Drawing.Color.White
        Me.btnToggleBusinessDay.Location = New System.Drawing.Point(241, 92)
        Me.btnToggleBusinessDay.Name = "btnToggleBusinessDay"
        Me.btnToggleBusinessDay.Size = New System.Drawing.Size(122, 44)
        Me.btnToggleBusinessDay.TabIndex = 18
        Me.btnToggleBusinessDay.Text = "START/END"
        Me.btnToggleBusinessDay.UseVisualStyleBackColor = False
        '
        'lblBusinessDateNotification
        '
        Me.lblBusinessDateNotification.Font = New System.Drawing.Font("WeblySleek UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusinessDateNotification.Location = New System.Drawing.Point(2, 25)
        Me.lblBusinessDateNotification.Name = "lblBusinessDateNotification"
        Me.lblBusinessDateNotification.Size = New System.Drawing.Size(611, 64)
        Me.lblBusinessDateNotification.TabIndex = 0
        Me.lblBusinessDateNotification.Text = "INSERT TEXT NOTIFICATION HERE"
        Me.lblBusinessDateNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OperationTimer
        '
        Me.OperationTimer.Interval = 1000
        '
        'Dashboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlMenuStrip)
        Me.Controls.Add(Me.pnlControlBox)
        Me.Font = New System.Drawing.Font("WeblySleek UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.pnlControlBox.ResumeLayout(False)
        Me.pnlControlBox.PerformLayout()
        Me.pnlMenuStrip.ResumeLayout(False)
        Me.pnlMenuStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.pnlBusinessDate.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFormLabel As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents pnlControlBox As System.Windows.Forms.Panel
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlMenuStrip As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnPOS As System.Windows.Forms.Button
    Friend WithEvents lblActiveUsername As System.Windows.Forms.Label
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPOS1Status As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPOS6Status As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblPOS5Status As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblPOS4Status As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblPOS3Status As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblPOS2Status As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPOS6User As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblPOS5User As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblPOS4User As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblPOS3User As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblPOS2User As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblPOS1User As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFormUserSummary As System.Windows.Forms.Label
    Friend WithEvents pnlBusinessDate As System.Windows.Forms.Panel
    Friend WithEvents btnToggleBusinessDay As System.Windows.Forms.Button
    Friend WithEvents lblBusinessDateNotification As System.Windows.Forms.Label
    Friend WithEvents lnkRefreshUserPanel As LinkLabel
    Friend WithEvents OperationTimer As Timer
End Class
