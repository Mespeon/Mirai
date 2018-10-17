<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inv_AddSupplier
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
        Me.lblAddUser = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.cbxSchedule = New System.Windows.Forms.ComboBox()
        Me.btnSchedGuide = New System.Windows.Forms.Button()
        Me.lblAddSupplierWarning = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnResetForm = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAddUser
        '
        Me.lblAddUser.Font = New System.Drawing.Font("WeblySleek UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddUser.Location = New System.Drawing.Point(80, 24)
        Me.lblAddUser.Margin = New System.Windows.Forms.Padding(9, 22, 9, 22)
        Me.lblAddUser.Name = "lblAddUser"
        Me.lblAddUser.Size = New System.Drawing.Size(267, 40)
        Me.lblAddUser.TabIndex = 5
        Me.lblAddUser.Text = "Add Supplier"
        Me.lblAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 21)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Supplier Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Supplier Schedule"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 21)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Contact Number"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(164, 83)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(237, 29)
        Me.txtSupplierName.TabIndex = 29
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(164, 131)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(237, 29)
        Me.txtContactNumber.TabIndex = 30
        '
        'cbxSchedule
        '
        Me.cbxSchedule.FormattingEnabled = True
        Me.cbxSchedule.Items.AddRange(New Object() {"DAILY", "SKIP", "DEMAND"})
        Me.cbxSchedule.Location = New System.Drawing.Point(164, 179)
        Me.cbxSchedule.Name = "cbxSchedule"
        Me.cbxSchedule.Size = New System.Drawing.Size(186, 29)
        Me.cbxSchedule.TabIndex = 32
        '
        'btnSchedGuide
        '
        Me.btnSchedGuide.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSchedGuide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSchedGuide.FlatAppearance.BorderSize = 0
        Me.btnSchedGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedGuide.ForeColor = System.Drawing.Color.White
        Me.btnSchedGuide.Location = New System.Drawing.Point(356, 179)
        Me.btnSchedGuide.Name = "btnSchedGuide"
        Me.btnSchedGuide.Size = New System.Drawing.Size(45, 29)
        Me.btnSchedGuide.TabIndex = 33
        Me.btnSchedGuide.Text = "?"
        Me.btnSchedGuide.UseVisualStyleBackColor = False
        '
        'lblAddSupplierWarning
        '
        Me.lblAddSupplierWarning.ForeColor = System.Drawing.Color.Red
        Me.lblAddSupplierWarning.Location = New System.Drawing.Point(30, 221)
        Me.lblAddSupplierWarning.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblAddSupplierWarning.Name = "lblAddSupplierWarning"
        Me.lblAddSupplierWarning.Size = New System.Drawing.Size(371, 35)
        Me.lblAddSupplierWarning.TabIndex = 34
        Me.lblAddSupplierWarning.Text = "WARNING GOES HERE"
        Me.lblAddSupplierWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAddSupplierWarning.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(290, 259)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 39)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnResetForm
        '
        Me.btnResetForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResetForm.FlatAppearance.BorderSize = 0
        Me.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetForm.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetForm.ForeColor = System.Drawing.Color.White
        Me.btnResetForm.Location = New System.Drawing.Point(143, 259)
        Me.btnResetForm.Name = "btnResetForm"
        Me.btnResetForm.Size = New System.Drawing.Size(141, 39)
        Me.btnResetForm.TabIndex = 36
        Me.btnResetForm.Text = "Reset Form"
        Me.btnResetForm.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Chartreuse
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(27, 259)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(110, 39)
        Me.btnSubmit.TabIndex = 35
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Inv_AddSupplier
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(426, 322)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnResetForm)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblAddSupplierWarning)
        Me.Controls.Add(Me.btnSchedGuide)
        Me.Controls.Add(Me.cbxSchedule)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAddUser)
        Me.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inv_AddSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Supplier"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddUser As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents cbxSchedule As ComboBox
    Friend WithEvents btnSchedGuide As Button
    Friend WithEvents lblAddSupplierWarning As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnResetForm As Button
    Friend WithEvents btnSubmit As Button
End Class
