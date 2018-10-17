<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblWindowBanner = New System.Windows.Forms.Label()
        Me.lblLoginMessage = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblConnectionStatus = New System.Windows.Forms.Label()
        Me.pnlUsername = New System.Windows.Forms.Panel()
        Me.pnlPassword = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lblRecoveredSession = New System.Windows.Forms.Label()
        Me.pnlUsername.SuspendLayout()
        Me.pnlPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("WeblySleek UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(624, 589)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(122, 35)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(128, 25)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(290, 32)
        Me.txtPassword.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("WeblySleek UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(128, 25)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(290, 32)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.Tag = ""
        '
        'lblWindowBanner
        '
        Me.lblWindowBanner.Font = New System.Drawing.Font("WeblySleek UI Semilight", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWindowBanner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblWindowBanner.Location = New System.Drawing.Point(22, 381)
        Me.lblWindowBanner.Margin = New System.Windows.Forms.Padding(3, 15, 3, 10)
        Me.lblWindowBanner.Name = "lblWindowBanner"
        Me.lblWindowBanner.Size = New System.Drawing.Size(1326, 76)
        Me.lblWindowBanner.TabIndex = 1
        Me.lblWindowBanner.Text = "Administrator Dashboard"
        Me.lblWindowBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoginMessage
        '
        Me.lblLoginMessage.Font = New System.Drawing.Font("WeblySleek UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLoginMessage.Location = New System.Drawing.Point(410, 555)
        Me.lblLoginMessage.Name = "lblLoginMessage"
        Me.lblLoginMessage.Size = New System.Drawing.Size(546, 31)
        Me.lblLoginMessage.TabIndex = 6
        Me.lblLoginMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnClose.Location = New System.Drawing.Point(1319, 12)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblConnectionStatus
        '
        Me.lblConnectionStatus.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectionStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblConnectionStatus.Location = New System.Drawing.Point(1276, 729)
        Me.lblConnectionStatus.Name = "lblConnectionStatus"
        Me.lblConnectionStatus.Size = New System.Drawing.Size(78, 30)
        Me.lblConnectionStatus.TabIndex = 9
        Me.lblConnectionStatus.Text = "STATUS"
        Me.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlUsername
        '
        Me.pnlUsername.Controls.Add(Me.txtUsername)
        Me.pnlUsername.Location = New System.Drawing.Point(412, 470)
        Me.pnlUsername.Name = "pnlUsername"
        Me.pnlUsername.Size = New System.Drawing.Size(546, 82)
        Me.pnlUsername.TabIndex = 10
        '
        'pnlPassword
        '
        Me.pnlPassword.Controls.Add(Me.txtPassword)
        Me.pnlPassword.Location = New System.Drawing.Point(412, 470)
        Me.pnlPassword.Name = "pnlPassword"
        Me.pnlPassword.Size = New System.Drawing.Size(546, 82)
        Me.pnlPassword.TabIndex = 11
        Me.pnlPassword.Visible = False
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("WeblySleek UI Semilight", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(541, 17)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(289, 30)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "DATE"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Font = New System.Drawing.Font("WeblySleek UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGreeting.Location = New System.Drawing.Point(613, 323)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(145, 43)
        Me.lblGreeting.TabIndex = 13
        Me.lblGreeting.Text = "Welcome"
        Me.lblGreeting.Visible = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Location = New System.Drawing.Point(1278, 12)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(35, 35)
        Me.btnAbout.TabIndex = 14
        Me.btnAbout.Text = "i"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'lblRecoveredSession
        '
        Me.lblRecoveredSession.AutoSize = True
        Me.lblRecoveredSession.Font = New System.Drawing.Font("WeblySleek UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecoveredSession.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRecoveredSession.Location = New System.Drawing.Point(599, 634)
        Me.lblRecoveredSession.Name = "lblRecoveredSession"
        Me.lblRecoveredSession.Size = New System.Drawing.Size(172, 19)
        Me.lblRecoveredSession.TabIndex = 15
        Me.lblRecoveredSession.Text = "This is a recovered session."
        Me.lblRecoveredSession.Visible = False
        '
        'Login
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblRecoveredSession)
        Me.Controls.Add(Me.pnlUsername)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblConnectionStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblLoginMessage)
        Me.Controls.Add(Me.lblWindowBanner)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.pnlPassword)
        Me.Font = New System.Drawing.Font("WeblySleek UI Semilight", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - Mirai RMS v.1.0.0"
        Me.pnlUsername.ResumeLayout(False)
        Me.pnlUsername.PerformLayout()
        Me.pnlPassword.ResumeLayout(False)
        Me.pnlPassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblWindowBanner As System.Windows.Forms.Label
    Friend WithEvents lblLoginMessage As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblConnectionStatus As System.Windows.Forms.Label
    Friend WithEvents pnlUsername As System.Windows.Forms.Panel
    Friend WithEvents pnlPassword As System.Windows.Forms.Panel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents lblRecoveredSession As Label
End Class
