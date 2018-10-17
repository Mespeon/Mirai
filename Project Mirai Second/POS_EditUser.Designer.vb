<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POS_EditUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRemoveUser = New System.Windows.Forms.Button()
        Me.lblAddUser = New System.Windows.Forms.Label()
        Me.cbxLastName = New System.Windows.Forms.CheckBox()
        Me.cbxFirstName = New System.Windows.Forms.CheckBox()
        Me.cbxMiddleName = New System.Windows.Forms.CheckBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDateHired = New System.Windows.Forms.TextBox()
        Me.dtpDateHired = New System.Windows.Forms.DateTimePicker()
        Me.cbxEmployeeID = New System.Windows.Forms.CheckBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.cbxDateHired = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbxPosition = New System.Windows.Forms.ComboBox()
        Me.txtAccessLevel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxUsername = New System.Windows.Forms.CheckBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPasscode = New System.Windows.Forms.TextBox()
        Me.cbxPasscode = New System.Windows.Forms.CheckBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.cbxPosition = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRemoveUser
        '
        Me.btnRemoveUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemoveUser.FlatAppearance.BorderSize = 0
        Me.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveUser.ForeColor = System.Drawing.Color.White
        Me.btnRemoveUser.Location = New System.Drawing.Point(534, 307)
        Me.btnRemoveUser.Name = "btnRemoveUser"
        Me.btnRemoveUser.Size = New System.Drawing.Size(347, 76)
        Me.btnRemoveUser.TabIndex = 8
        Me.btnRemoveUser.Text = "Remove User"
        Me.btnRemoveUser.UseVisualStyleBackColor = False
        '
        'lblAddUser
        '
        Me.lblAddUser.Font = New System.Drawing.Font("WeblySleek UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddUser.Location = New System.Drawing.Point(14, 31)
        Me.lblAddUser.Margin = New System.Windows.Forms.Padding(9, 22, 9, 22)
        Me.lblAddUser.Name = "lblAddUser"
        Me.lblAddUser.Size = New System.Drawing.Size(192, 40)
        Me.lblAddUser.TabIndex = 43
        Me.lblAddUser.Text = "Edit User"
        Me.lblAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxLastName
        '
        Me.cbxLastName.AutoSize = True
        Me.cbxLastName.Location = New System.Drawing.Point(13, 35)
        Me.cbxLastName.Margin = New System.Windows.Forms.Padding(10)
        Me.cbxLastName.Name = "cbxLastName"
        Me.cbxLastName.Size = New System.Drawing.Size(101, 25)
        Me.cbxLastName.TabIndex = 44
        Me.cbxLastName.Text = "Last Name"
        Me.cbxLastName.UseVisualStyleBackColor = True
        '
        'cbxFirstName
        '
        Me.cbxFirstName.AutoSize = True
        Me.cbxFirstName.Location = New System.Drawing.Point(13, 80)
        Me.cbxFirstName.Margin = New System.Windows.Forms.Padding(10)
        Me.cbxFirstName.Name = "cbxFirstName"
        Me.cbxFirstName.Size = New System.Drawing.Size(103, 25)
        Me.cbxFirstName.TabIndex = 45
        Me.cbxFirstName.Text = "First Name"
        Me.cbxFirstName.UseVisualStyleBackColor = True
        '
        'cbxMiddleName
        '
        Me.cbxMiddleName.AutoSize = True
        Me.cbxMiddleName.Location = New System.Drawing.Point(13, 125)
        Me.cbxMiddleName.Margin = New System.Windows.Forms.Padding(10)
        Me.cbxMiddleName.Name = "cbxMiddleName"
        Me.cbxMiddleName.Size = New System.Drawing.Size(122, 25)
        Me.cbxMiddleName.TabIndex = 46
        Me.cbxMiddleName.Text = "Middle Name"
        Me.cbxMiddleName.UseVisualStyleBackColor = True
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Enabled = False
        Me.txtMiddleName.Location = New System.Drawing.Point(148, 123)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(342, 29)
        Me.txtMiddleName.TabIndex = 47
        '
        'txtFirstName
        '
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Location = New System.Drawing.Point(148, 78)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(342, 29)
        Me.txtFirstName.TabIndex = 48
        '
        'txtLastName
        '
        Me.txtLastName.Enabled = False
        Me.txtLastName.Location = New System.Drawing.Point(148, 33)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(342, 29)
        Me.txtLastName.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxLastName)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.cbxFirstName)
        Me.GroupBox1.Controls.Add(Me.txtMiddleName)
        Me.GroupBox1.Controls.Add(Me.cbxMiddleName)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 170)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(887, 307)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 76)
        Me.btnCancel.TabIndex = 51
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDateHired)
        Me.GroupBox2.Controls.Add(Me.dtpDateHired)
        Me.GroupBox2.Controls.Add(Me.cbxEmployeeID)
        Me.GroupBox2.Controls.Add(Me.txtEmployeeID)
        Me.GroupBox2.Controls.Add(Me.cbxDateHired)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(503, 158)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employment Information"
        '
        'txtDateHired
        '
        Me.txtDateHired.Enabled = False
        Me.txtDateHired.Location = New System.Drawing.Point(148, 78)
        Me.txtDateHired.Name = "txtDateHired"
        Me.txtDateHired.Size = New System.Drawing.Size(342, 29)
        Me.txtDateHired.TabIndex = 57
        '
        'dtpDateHired
        '
        Me.dtpDateHired.Enabled = False
        Me.dtpDateHired.Location = New System.Drawing.Point(148, 113)
        Me.dtpDateHired.Name = "dtpDateHired"
        Me.dtpDateHired.Size = New System.Drawing.Size(342, 29)
        Me.dtpDateHired.TabIndex = 56
        '
        'cbxEmployeeID
        '
        Me.cbxEmployeeID.AutoSize = True
        Me.cbxEmployeeID.Location = New System.Drawing.Point(13, 35)
        Me.cbxEmployeeID.Margin = New System.Windows.Forms.Padding(10)
        Me.cbxEmployeeID.Name = "cbxEmployeeID"
        Me.cbxEmployeeID.Size = New System.Drawing.Size(114, 25)
        Me.cbxEmployeeID.TabIndex = 50
        Me.cbxEmployeeID.Text = "Employee ID"
        Me.cbxEmployeeID.UseVisualStyleBackColor = True
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Enabled = False
        Me.txtEmployeeID.Location = New System.Drawing.Point(148, 33)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(342, 29)
        Me.txtEmployeeID.TabIndex = 55
        '
        'cbxDateHired
        '
        Me.cbxDateHired.AutoSize = True
        Me.cbxDateHired.Location = New System.Drawing.Point(13, 80)
        Me.cbxDateHired.Margin = New System.Windows.Forms.Padding(10)
        Me.cbxDateHired.Name = "cbxDateHired"
        Me.cbxDateHired.Size = New System.Drawing.Size(102, 25)
        Me.cbxDateHired.TabIndex = 51
        Me.cbxDateHired.Text = "Date Hired"
        Me.cbxDateHired.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbxPosition)
        Me.GroupBox3.Controls.Add(Me.txtAccessLevel)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cbxUsername)
        Me.GroupBox3.Controls.Add(Me.txtUsername)
        Me.GroupBox3.Controls.Add(Me.txtPasscode)
        Me.GroupBox3.Controls.Add(Me.cbxPasscode)
        Me.GroupBox3.Controls.Add(Me.txtPosition)
        Me.GroupBox3.Controls.Add(Me.cbxPosition)
        Me.GroupBox3.Location = New System.Drawing.Point(534, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(503, 202)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mirai System Information"
        '
        'cmbxPosition
        '
        Me.cmbxPosition.Enabled = False
        Me.cmbxPosition.FormattingEnabled = True
        Me.cmbxPosition.Items.AddRange(New Object() {"ITDEPT", "RGM", "SARM", "JARM", "MT", "RTM"})
        Me.cmbxPosition.Location = New System.Drawing.Point(13, 158)
        Me.cmbxPosition.Name = "cmbxPosition"
        Me.cmbxPosition.Size = New System.Drawing.Size(240, 29)
        Me.cmbxPosition.TabIndex = 52
        '
        'txtAccessLevel
        '
        Me.txtAccessLevel.Enabled = False
        Me.txtAccessLevel.Location = New System.Drawing.Point(359, 158)
        Me.txtAccessLevel.Name = "txtAccessLevel"
        Me.txtAccessLevel.Size = New System.Drawing.Size(131, 29)
        Me.txtAccessLevel.TabIndex = 51
        Me.txtAccessLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(259, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Access Level"
        '
        'cbxUsername
        '
        Me.cbxUsername.AutoSize = True
        Me.cbxUsername.Location = New System.Drawing.Point(13, 35)
        Me.cbxUsername.Margin = New System.Windows.Forms.Padding(10)
        Me.cbxUsername.Name = "cbxUsername"
        Me.cbxUsername.Size = New System.Drawing.Size(98, 25)
        Me.cbxUsername.TabIndex = 44
        Me.cbxUsername.Text = "Username"
        Me.cbxUsername.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(148, 33)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(342, 29)
        Me.txtUsername.TabIndex = 49
        '
        'txtPasscode
        '
        Me.txtPasscode.Enabled = False
        Me.txtPasscode.Location = New System.Drawing.Point(148, 78)
        Me.txtPasscode.Name = "txtPasscode"
        Me.txtPasscode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPasscode.Size = New System.Drawing.Size(342, 29)
        Me.txtPasscode.TabIndex = 48
        '
        'cbxPasscode
        '
        Me.cbxPasscode.AutoSize = True
        Me.cbxPasscode.Location = New System.Drawing.Point(13, 80)
        Me.cbxPasscode.Margin = New System.Windows.Forms.Padding(10)
        Me.cbxPasscode.Name = "cbxPasscode"
        Me.cbxPasscode.Size = New System.Drawing.Size(92, 25)
        Me.cbxPasscode.TabIndex = 45
        Me.cbxPasscode.Text = "Passcode"
        Me.cbxPasscode.UseVisualStyleBackColor = True
        '
        'txtPosition
        '
        Me.txtPosition.Enabled = False
        Me.txtPosition.Location = New System.Drawing.Point(148, 123)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.ReadOnly = True
        Me.txtPosition.Size = New System.Drawing.Size(342, 29)
        Me.txtPosition.TabIndex = 47
        '
        'cbxPosition
        '
        Me.cbxPosition.AutoSize = True
        Me.cbxPosition.Location = New System.Drawing.Point(13, 125)
        Me.cbxPosition.Margin = New System.Windows.Forms.Padding(10)
        Me.cbxPosition.Name = "cbxPosition"
        Me.cbxPosition.Size = New System.Drawing.Size(84, 25)
        Me.cbxPosition.TabIndex = 46
        Me.cbxPosition.Text = "Position"
        Me.cbxPosition.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(530, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 21)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Editor:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(591, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(446, 25)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Authorizing Manager Name goes here"
        '
        'btnCommit
        '
        Me.btnCommit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCommit.FlatAppearance.BorderSize = 0
        Me.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommit.ForeColor = System.Drawing.Color.White
        Me.btnCommit.Location = New System.Drawing.Point(534, 389)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(503, 41)
        Me.btnCommit.TabIndex = 57
        Me.btnCommit.Text = "Commit Changes to Database"
        Me.btnCommit.UseVisualStyleBackColor = False
        '
        'POS_EditUser
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1049, 445)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblAddUser)
        Me.Controls.Add(Me.btnRemoveUser)
        Me.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "POS_EditUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit User"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemoveUser As Button
    Friend WithEvents lblAddUser As Label
    Friend WithEvents cbxLastName As CheckBox
    Friend WithEvents cbxFirstName As CheckBox
    Friend WithEvents cbxMiddleName As CheckBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDateHired As TextBox
    Friend WithEvents dtpDateHired As DateTimePicker
    Friend WithEvents cbxEmployeeID As CheckBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents cbxDateHired As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbxUsername As CheckBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPasscode As TextBox
    Friend WithEvents cbxPasscode As CheckBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents cbxPosition As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAccessLevel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCommit As Button
    Friend WithEvents cmbxPosition As ComboBox
End Class
