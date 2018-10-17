<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inv_AddInventory
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
        Me.lblAddUser = New System.Windows.Forms.Label()
        Me.cbxSupplier = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxItemShipping = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemQtyMultiplier = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxItemType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtShelfLife = New System.Windows.Forms.TextBox()
        Me.btnItemTypeGuide = New System.Windows.Forms.Button()
        Me.btnShelfLifeGuide = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtItemUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInitialStock = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnResetForm = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblAddInventoryWarning = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAddUser
        '
        Me.lblAddUser.Font = New System.Drawing.Font("WeblySleek UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddUser.Location = New System.Drawing.Point(18, 31)
        Me.lblAddUser.Margin = New System.Windows.Forms.Padding(9, 22, 9, 22)
        Me.lblAddUser.Name = "lblAddUser"
        Me.lblAddUser.Size = New System.Drawing.Size(376, 40)
        Me.lblAddUser.TabIndex = 6
        Me.lblAddUser.Text = "Add New Inventory Item"
        Me.lblAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxSupplier
        '
        Me.cbxSupplier.FormattingEnabled = True
        Me.cbxSupplier.Location = New System.Drawing.Point(112, 96)
        Me.cbxSupplier.Name = "cbxSupplier"
        Me.cbxSupplier.Size = New System.Drawing.Size(282, 29)
        Me.cbxSupplier.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 99)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Supplier"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(112, 137)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(282, 29)
        Me.txtItemName.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Item Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 181)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Shipped in"
        '
        'cbxItemShipping
        '
        Me.cbxItemShipping.FormattingEnabled = True
        Me.cbxItemShipping.Items.AddRange(New Object() {"BY PIECE", "BAGS (CHICKEN)", "BOXES (CANNED ITEMS, ETC.)", "CASES (PREMIXES)", "MANUAL VALUE"})
        Me.cbxItemShipping.Location = New System.Drawing.Point(112, 178)
        Me.cbxItemShipping.Name = "cbxItemShipping"
        Me.cbxItemShipping.Size = New System.Drawing.Size(121, 29)
        Me.cbxItemShipping.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 181)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Multiplier"
        '
        'txtItemQtyMultiplier
        '
        Me.txtItemQtyMultiplier.Enabled = False
        Me.txtItemQtyMultiplier.Location = New System.Drawing.Point(321, 178)
        Me.txtItemQtyMultiplier.Name = "txtItemQtyMultiplier"
        Me.txtItemQtyMultiplier.Size = New System.Drawing.Size(73, 29)
        Me.txtItemQtyMultiplier.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 222)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 21)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Item Type"
        '
        'cbxItemType
        '
        Me.cbxItemType.FormattingEnabled = True
        Me.cbxItemType.Items.AddRange(New Object() {"DRY", "WET", "OFFICE"})
        Me.cbxItemType.Location = New System.Drawing.Point(112, 219)
        Me.cbxItemType.Name = "cbxItemType"
        Me.cbxItemType.Size = New System.Drawing.Size(121, 29)
        Me.cbxItemType.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 263)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Shelf Life in Days"
        '
        'txtShelfLife
        '
        Me.txtShelfLife.Location = New System.Drawing.Point(155, 260)
        Me.txtShelfLife.Name = "txtShelfLife"
        Me.txtShelfLife.Size = New System.Drawing.Size(78, 29)
        Me.txtShelfLife.TabIndex = 18
        '
        'btnItemTypeGuide
        '
        Me.btnItemTypeGuide.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnItemTypeGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemTypeGuide.ForeColor = System.Drawing.Color.White
        Me.btnItemTypeGuide.Location = New System.Drawing.Point(243, 219)
        Me.btnItemTypeGuide.Name = "btnItemTypeGuide"
        Me.btnItemTypeGuide.Size = New System.Drawing.Size(151, 29)
        Me.btnItemTypeGuide.TabIndex = 19
        Me.btnItemTypeGuide.Text = "Item Type Guide"
        Me.btnItemTypeGuide.UseVisualStyleBackColor = False
        '
        'btnShelfLifeGuide
        '
        Me.btnShelfLifeGuide.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnShelfLifeGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShelfLifeGuide.ForeColor = System.Drawing.Color.White
        Me.btnShelfLifeGuide.Location = New System.Drawing.Point(243, 260)
        Me.btnShelfLifeGuide.Name = "btnShelfLifeGuide"
        Me.btnShelfLifeGuide.Size = New System.Drawing.Size(151, 29)
        Me.btnShelfLifeGuide.TabIndex = 20
        Me.btnShelfLifeGuide.Text = "Shelf Life Guide"
        Me.btnShelfLifeGuide.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 304)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 21)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Item Unit Price"
        '
        'txtItemUnitPrice
        '
        Me.txtItemUnitPrice.Location = New System.Drawing.Point(155, 301)
        Me.txtItemUnitPrice.Name = "txtItemUnitPrice"
        Me.txtItemUnitPrice.Size = New System.Drawing.Size(78, 29)
        Me.txtItemUnitPrice.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(239, 304)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 21)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Initial Stock"
        '
        'txtInitialStock
        '
        Me.txtInitialStock.Location = New System.Drawing.Point(333, 301)
        Me.txtInitialStock.Name = "txtInitialStock"
        Me.txtInitialStock.Size = New System.Drawing.Size(61, 29)
        Me.txtInitialStock.TabIndex = 24
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(283, 378)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 39)
        Me.btnCancel.TabIndex = 40
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
        Me.btnResetForm.Location = New System.Drawing.Point(136, 378)
        Me.btnResetForm.Name = "btnResetForm"
        Me.btnResetForm.Size = New System.Drawing.Size(141, 39)
        Me.btnResetForm.TabIndex = 39
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
        Me.btnSubmit.Location = New System.Drawing.Point(20, 378)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(110, 39)
        Me.btnSubmit.TabIndex = 38
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblAddInventoryWarning
        '
        Me.lblAddInventoryWarning.ForeColor = System.Drawing.Color.Red
        Me.lblAddInventoryWarning.Location = New System.Drawing.Point(21, 340)
        Me.lblAddInventoryWarning.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblAddInventoryWarning.Name = "lblAddInventoryWarning"
        Me.lblAddInventoryWarning.Size = New System.Drawing.Size(371, 35)
        Me.lblAddInventoryWarning.TabIndex = 41
        Me.lblAddInventoryWarning.Text = "WARNING GOES HERE"
        Me.lblAddInventoryWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAddInventoryWarning.Visible = False
        '
        'Inv_AddInventory
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(412, 429)
        Me.Controls.Add(Me.lblAddInventoryWarning)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnResetForm)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtInitialStock)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtItemUnitPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnShelfLifeGuide)
        Me.Controls.Add(Me.btnItemTypeGuide)
        Me.Controls.Add(Me.txtShelfLife)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxItemType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtItemQtyMultiplier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxItemShipping)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxSupplier)
        Me.Controls.Add(Me.lblAddUser)
        Me.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inv_AddInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Data"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddUser As Label
    Friend WithEvents cbxSupplier As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxItemShipping As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItemQtyMultiplier As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxItemType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtShelfLife As TextBox
    Friend WithEvents btnItemTypeGuide As Button
    Friend WithEvents btnShelfLifeGuide As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtItemUnitPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtInitialStock As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnResetForm As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblAddInventoryWarning As Label
End Class
