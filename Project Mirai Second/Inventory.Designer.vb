<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventory
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnEditInventoryData = New System.Windows.Forms.Button()
        Me.btnAddInventoryData = New System.Windows.Forms.Button()
        Me.btnAddSupplier = New System.Windows.Forms.Button()
        Me.lsvInventoryList = New System.Windows.Forms.ListView()
        Me.btnTransfers = New System.Windows.Forms.Button()
        Me.txtUserSearchBox = New System.Windows.Forms.TextBox()
        Me.rbInventory = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbSupplier = New System.Windows.Forms.RadioButton()
        Me.rbStockMovements = New System.Windows.Forms.RadioButton()
        Me.pnlControlBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlControlBox
        '
        Me.pnlControlBox.Controls.Add(Me.lblFormUserSummary)
        Me.pnlControlBox.Controls.Add(Me.btnClose)
        Me.pnlControlBox.Controls.Add(Me.lblFormLabel)
        Me.pnlControlBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControlBox.Font = New System.Drawing.Font("WeblySleek UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlControlBox.Location = New System.Drawing.Point(0, 0)
        Me.pnlControlBox.Name = "pnlControlBox"
        Me.pnlControlBox.Size = New System.Drawing.Size(1350, 29)
        Me.pnlControlBox.TabIndex = 12
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
        Me.lblFormFlag.Location = New System.Drawing.Point(2, 32)
        Me.lblFormFlag.Name = "lblFormFlag"
        Me.lblFormFlag.Size = New System.Drawing.Size(464, 80)
        Me.lblFormFlag.TabIndex = 13
        Me.lblFormFlag.Text = "Inventory Dashboard"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(1084, 115)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(254, 29)
        Me.btnSearch.TabIndex = 20
        Me.btnSearch.Text = "Search Inventory"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnEditInventoryData
        '
        Me.btnEditInventoryData.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEditInventoryData.Enabled = False
        Me.btnEditInventoryData.FlatAppearance.BorderSize = 0
        Me.btnEditInventoryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditInventoryData.ForeColor = System.Drawing.Color.White
        Me.btnEditInventoryData.Location = New System.Drawing.Point(328, 115)
        Me.btnEditInventoryData.Name = "btnEditInventoryData"
        Me.btnEditInventoryData.Size = New System.Drawing.Size(150, 60)
        Me.btnEditInventoryData.TabIndex = 17
        Me.btnEditInventoryData.Text = "Edit Inventory Data"
        Me.btnEditInventoryData.UseVisualStyleBackColor = False
        '
        'btnAddInventoryData
        '
        Me.btnAddInventoryData.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddInventoryData.FlatAppearance.BorderSize = 0
        Me.btnAddInventoryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddInventoryData.ForeColor = System.Drawing.Color.White
        Me.btnAddInventoryData.Location = New System.Drawing.Point(172, 115)
        Me.btnAddInventoryData.Name = "btnAddInventoryData"
        Me.btnAddInventoryData.Size = New System.Drawing.Size(150, 60)
        Me.btnAddInventoryData.TabIndex = 16
        Me.btnAddInventoryData.Text = "Enter New Inventory Data"
        Me.btnAddInventoryData.UseVisualStyleBackColor = False
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddSupplier.FlatAppearance.BorderSize = 0
        Me.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSupplier.ForeColor = System.Drawing.Color.White
        Me.btnAddSupplier.Location = New System.Drawing.Point(16, 115)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(150, 60)
        Me.btnAddSupplier.TabIndex = 15
        Me.btnAddSupplier.Text = "Add Supplier"
        Me.btnAddSupplier.UseVisualStyleBackColor = False
        '
        'lsvInventoryList
        '
        Me.lsvInventoryList.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvInventoryList.FullRowSelect = True
        Me.lsvInventoryList.GridLines = True
        Me.lsvInventoryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvInventoryList.HideSelection = False
        Me.lsvInventoryList.Location = New System.Drawing.Point(16, 193)
        Me.lsvInventoryList.MultiSelect = False
        Me.lsvInventoryList.Name = "lsvInventoryList"
        Me.lsvInventoryList.Size = New System.Drawing.Size(1334, 524)
        Me.lsvInventoryList.TabIndex = 21
        Me.lsvInventoryList.UseCompatibleStateImageBehavior = False
        Me.lsvInventoryList.View = System.Windows.Forms.View.Details
        '
        'btnTransfers
        '
        Me.btnTransfers.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTransfers.FlatAppearance.BorderSize = 0
        Me.btnTransfers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransfers.ForeColor = System.Drawing.Color.White
        Me.btnTransfers.Location = New System.Drawing.Point(484, 115)
        Me.btnTransfers.Name = "btnTransfers"
        Me.btnTransfers.Size = New System.Drawing.Size(150, 60)
        Me.btnTransfers.TabIndex = 22
        Me.btnTransfers.Text = "Transfers"
        Me.btnTransfers.UseVisualStyleBackColor = False
        '
        'txtUserSearchBox
        '
        Me.txtUserSearchBox.Location = New System.Drawing.Point(640, 115)
        Me.txtUserSearchBox.Name = "txtUserSearchBox"
        Me.txtUserSearchBox.Size = New System.Drawing.Size(438, 29)
        Me.txtUserSearchBox.TabIndex = 19
        '
        'rbInventory
        '
        Me.rbInventory.AutoSize = True
        Me.rbInventory.Location = New System.Drawing.Point(713, 150)
        Me.rbInventory.Name = "rbInventory"
        Me.rbInventory.Size = New System.Drawing.Size(156, 25)
        Me.rbInventory.TabIndex = 23
        Me.rbInventory.TabStop = True
        Me.rbInventory.Text = "Inventory (Default)"
        Me.rbInventory.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(640, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "View by:"
        '
        'rbSupplier
        '
        Me.rbSupplier.AutoSize = True
        Me.rbSupplier.Location = New System.Drawing.Point(875, 150)
        Me.rbSupplier.Name = "rbSupplier"
        Me.rbSupplier.Size = New System.Drawing.Size(84, 25)
        Me.rbSupplier.TabIndex = 25
        Me.rbSupplier.TabStop = True
        Me.rbSupplier.Text = "Supplier"
        Me.rbSupplier.UseVisualStyleBackColor = True
        '
        'rbStockMovements
        '
        Me.rbStockMovements.AutoSize = True
        Me.rbStockMovements.Location = New System.Drawing.Point(965, 150)
        Me.rbStockMovements.Name = "rbStockMovements"
        Me.rbStockMovements.Size = New System.Drawing.Size(148, 25)
        Me.rbStockMovements.TabIndex = 26
        Me.rbStockMovements.TabStop = True
        Me.rbStockMovements.Text = "Stock Movements"
        Me.rbStockMovements.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.rbStockMovements)
        Me.Controls.Add(Me.rbSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbInventory)
        Me.Controls.Add(Me.btnTransfers)
        Me.Controls.Add(Me.lsvInventoryList)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtUserSearchBox)
        Me.Controls.Add(Me.btnEditInventoryData)
        Me.Controls.Add(Me.btnAddInventoryData)
        Me.Controls.Add(Me.btnAddSupplier)
        Me.Controls.Add(Me.lblFormFlag)
        Me.Controls.Add(Me.pnlControlBox)
        Me.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        Me.pnlControlBox.ResumeLayout(False)
        Me.pnlControlBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlControlBox As Panel
    Friend WithEvents lblFormUserSummary As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblFormLabel As Label
    Friend WithEvents lblFormFlag As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnEditInventoryData As Button
    Friend WithEvents btnAddInventoryData As Button
    Friend WithEvents btnAddSupplier As Button
    Friend WithEvents lsvInventoryList As ListView
    Friend WithEvents btnTransfers As Button
    Friend WithEvents txtUserSearchBox As TextBox
    Friend WithEvents rbInventory As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents rbSupplier As RadioButton
    Friend WithEvents rbStockMovements As RadioButton
End Class
