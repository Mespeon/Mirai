<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inv_Transfers
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.gpxTransferType = New System.Windows.Forms.GroupBox()
        Me.rbTransIn = New System.Windows.Forms.RadioButton()
        Me.rbTransOut = New System.Windows.Forms.RadioButton()
        Me.lblAddUser = New System.Windows.Forms.Label()
        Me.gpxTransferItems = New System.Windows.Forms.GroupBox()
        Me.lsvTransferItems = New System.Windows.Forms.ListView()
        Me.txtTransferee = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxTransferItem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTransferItem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransferQty = New System.Windows.Forms.TextBox()
        Me.txtQtyOnHand = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTransferDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAuthorizedManager = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnResetList = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRequestor = New System.Windows.Forms.TextBox()
        Me.lblTransferDirection = New System.Windows.Forms.Label()
        Me.pbxPhotoNotice = New System.Windows.Forms.PictureBox()
        Me.gpxTransferType.SuspendLayout()
        Me.gpxTransferItems.SuspendLayout()
        CType(Me.pbxPhotoNotice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(187, 541)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 39)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Chartreuse
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(13, 541)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(166, 39)
        Me.btnSubmit.TabIndex = 38
        Me.btnSubmit.Text = "Generate Report"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'gpxTransferType
        '
        Me.gpxTransferType.Controls.Add(Me.rbTransOut)
        Me.gpxTransferType.Controls.Add(Me.rbTransIn)
        Me.gpxTransferType.Location = New System.Drawing.Point(13, 98)
        Me.gpxTransferType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpxTransferType.Name = "gpxTransferType"
        Me.gpxTransferType.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpxTransferType.Size = New System.Drawing.Size(295, 75)
        Me.gpxTransferType.TabIndex = 41
        Me.gpxTransferType.TabStop = False
        Me.gpxTransferType.Text = "Transfer Type"
        '
        'rbTransIn
        '
        Me.rbTransIn.AutoSize = True
        Me.rbTransIn.Location = New System.Drawing.Point(24, 30)
        Me.rbTransIn.Name = "rbTransIn"
        Me.rbTransIn.Size = New System.Drawing.Size(99, 25)
        Me.rbTransIn.TabIndex = 0
        Me.rbTransIn.TabStop = True
        Me.rbTransIn.Text = "Transfer In"
        Me.rbTransIn.UseVisualStyleBackColor = True
        '
        'rbTransOut
        '
        Me.rbTransOut.AutoSize = True
        Me.rbTransOut.Location = New System.Drawing.Point(158, 30)
        Me.rbTransOut.Name = "rbTransOut"
        Me.rbTransOut.Size = New System.Drawing.Size(112, 25)
        Me.rbTransOut.TabIndex = 1
        Me.rbTransOut.TabStop = True
        Me.rbTransOut.Text = "Transfer Out"
        Me.rbTransOut.UseVisualStyleBackColor = True
        '
        'lblAddUser
        '
        Me.lblAddUser.Font = New System.Drawing.Font("WeblySleek UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddUser.Location = New System.Drawing.Point(27, 31)
        Me.lblAddUser.Margin = New System.Windows.Forms.Padding(9, 22, 9, 22)
        Me.lblAddUser.Name = "lblAddUser"
        Me.lblAddUser.Size = New System.Drawing.Size(267, 40)
        Me.lblAddUser.TabIndex = 42
        Me.lblAddUser.Text = "Stock Transfer"
        Me.lblAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gpxTransferItems
        '
        Me.gpxTransferItems.Controls.Add(Me.btnResetList)
        Me.gpxTransferItems.Controls.Add(Me.btnAddItem)
        Me.gpxTransferItems.Controls.Add(Me.Label5)
        Me.gpxTransferItems.Controls.Add(Me.dtpTransferDate)
        Me.gpxTransferItems.Controls.Add(Me.txtQtyOnHand)
        Me.gpxTransferItems.Controls.Add(Me.Label4)
        Me.gpxTransferItems.Controls.Add(Me.txtTransferQty)
        Me.gpxTransferItems.Controls.Add(Me.Label3)
        Me.gpxTransferItems.Controls.Add(Me.txtTransferItem)
        Me.gpxTransferItems.Controls.Add(Me.Label2)
        Me.gpxTransferItems.Controls.Add(Me.cbxTransferItem)
        Me.gpxTransferItems.Enabled = False
        Me.gpxTransferItems.Location = New System.Drawing.Point(13, 181)
        Me.gpxTransferItems.Name = "gpxTransferItems"
        Me.gpxTransferItems.Size = New System.Drawing.Size(295, 352)
        Me.gpxTransferItems.TabIndex = 43
        Me.gpxTransferItems.TabStop = False
        Me.gpxTransferItems.Text = "Transfer Items"
        '
        'lsvTransferItems
        '
        Me.lsvTransferItems.FullRowSelect = True
        Me.lsvTransferItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvTransferItems.Location = New System.Drawing.Point(314, 190)
        Me.lsvTransferItems.Name = "lsvTransferItems"
        Me.lsvTransferItems.ShowItemToolTips = True
        Me.lsvTransferItems.Size = New System.Drawing.Size(700, 343)
        Me.lsvTransferItems.TabIndex = 44
        Me.lsvTransferItems.UseCompatibleStateImageBehavior = False
        Me.lsvTransferItems.View = System.Windows.Forms.View.Details
        '
        'txtTransferee
        '
        Me.txtTransferee.Font = New System.Drawing.Font("WeblySleek UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferee.Location = New System.Drawing.Point(314, 128)
        Me.txtTransferee.Name = "txtTransferee"
        Me.txtTransferee.Size = New System.Drawing.Size(252, 39)
        Me.txtTransferee.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(310, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Transfer to:"
        '
        'cbxTransferItem
        '
        Me.cbxTransferItem.FormattingEnabled = True
        Me.cbxTransferItem.Items.AddRange(New Object() {"As defined:"})
        Me.cbxTransferItem.Location = New System.Drawing.Point(3, 49)
        Me.cbxTransferItem.Name = "cbxTransferItem"
        Me.cbxTransferItem.Size = New System.Drawing.Size(283, 29)
        Me.cbxTransferItem.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item for transfer:"
        '
        'txtTransferItem
        '
        Me.txtTransferItem.Enabled = False
        Me.txtTransferItem.Location = New System.Drawing.Point(3, 84)
        Me.txtTransferItem.Name = "txtTransferItem"
        Me.txtTransferItem.Size = New System.Drawing.Size(283, 29)
        Me.txtTransferItem.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(156, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Transfer Quantity:"
        '
        'txtTransferQty
        '
        Me.txtTransferQty.Location = New System.Drawing.Point(160, 151)
        Me.txtTransferQty.Name = "txtTransferQty"
        Me.txtTransferQty.Size = New System.Drawing.Size(127, 29)
        Me.txtTransferQty.TabIndex = 4
        '
        'txtQtyOnHand
        '
        Me.txtQtyOnHand.Enabled = False
        Me.txtQtyOnHand.Location = New System.Drawing.Point(11, 151)
        Me.txtQtyOnHand.Name = "txtQtyOnHand"
        Me.txtQtyOnHand.Size = New System.Drawing.Size(127, 29)
        Me.txtQtyOnHand.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "On Hand:"
        '
        'dtpTransferDate
        '
        Me.dtpTransferDate.Enabled = False
        Me.dtpTransferDate.Location = New System.Drawing.Point(11, 233)
        Me.dtpTransferDate.Name = "dtpTransferDate"
        Me.dtpTransferDate.Size = New System.Drawing.Size(275, 29)
        Me.dtpTransferDate.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 199)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Transfer Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 550)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Authorized by:"
        '
        'lblAuthorizedManager
        '
        Me.lblAuthorizedManager.Location = New System.Drawing.Point(430, 542)
        Me.lblAuthorizedManager.Name = "lblAuthorizedManager"
        Me.lblAuthorizedManager.Size = New System.Drawing.Size(445, 36)
        Me.lblAuthorizedManager.TabIndex = 10
        Me.lblAuthorizedManager.Text = "AUTHORIZING MANAGER NAME GOES HERE"
        Me.lblAuthorizedManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddItem.Enabled = False
        Me.btnAddItem.FlatAppearance.BorderSize = 0
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(12, 285)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(125, 61)
        Me.btnAddItem.TabIndex = 9
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnResetList
        '
        Me.btnResetList.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResetList.FlatAppearance.BorderSize = 0
        Me.btnResetList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetList.ForeColor = System.Drawing.Color.White
        Me.btnResetList.Location = New System.Drawing.Point(157, 285)
        Me.btnResetList.Name = "btnResetList"
        Me.btnResetList.Size = New System.Drawing.Size(125, 61)
        Me.btnResetList.TabIndex = 10
        Me.btnResetList.Text = "Reset List"
        Me.btnResetList.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(593, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 21)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Requested by:"
        '
        'txtRequestor
        '
        Me.txtRequestor.Font = New System.Drawing.Font("WeblySleek UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestor.Location = New System.Drawing.Point(597, 128)
        Me.txtRequestor.Name = "txtRequestor"
        Me.txtRequestor.Size = New System.Drawing.Size(417, 39)
        Me.txtRequestor.TabIndex = 47
        '
        'lblTransferDirection
        '
        Me.lblTransferDirection.Location = New System.Drawing.Point(443, 65)
        Me.lblTransferDirection.Name = "lblTransferDirection"
        Me.lblTransferDirection.Size = New System.Drawing.Size(256, 39)
        Me.lblTransferDirection.TabIndex = 49
        Me.lblTransferDirection.Text = "Transfer is currently going nowhere."
        Me.lblTransferDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxPhotoNotice
        '
        Me.pbxPhotoNotice.Location = New System.Drawing.Point(539, 3)
        Me.pbxPhotoNotice.Name = "pbxPhotoNotice"
        Me.pbxPhotoNotice.Size = New System.Drawing.Size(64, 64)
        Me.pbxPhotoNotice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxPhotoNotice.TabIndex = 50
        Me.pbxPhotoNotice.TabStop = False
        '
        'Inv_Transfers
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1026, 594)
        Me.Controls.Add(Me.pbxPhotoNotice)
        Me.Controls.Add(Me.lblTransferDirection)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRequestor)
        Me.Controls.Add(Me.lblAuthorizedManager)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTransferee)
        Me.Controls.Add(Me.lsvTransferItems)
        Me.Controls.Add(Me.gpxTransferItems)
        Me.Controls.Add(Me.lblAddUser)
        Me.Controls.Add(Me.gpxTransferType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Font = New System.Drawing.Font("WeblySleek UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inv_Transfers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Transfers"
        Me.TopMost = True
        Me.gpxTransferType.ResumeLayout(False)
        Me.gpxTransferType.PerformLayout()
        Me.gpxTransferItems.ResumeLayout(False)
        Me.gpxTransferItems.PerformLayout()
        CType(Me.pbxPhotoNotice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents gpxTransferType As GroupBox
    Friend WithEvents rbTransOut As RadioButton
    Friend WithEvents rbTransIn As RadioButton
    Friend WithEvents lblAddUser As Label
    Friend WithEvents gpxTransferItems As GroupBox
    Friend WithEvents lsvTransferItems As ListView
    Friend WithEvents txtTransferee As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxTransferItem As ComboBox
    Friend WithEvents txtTransferItem As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTransferQty As TextBox
    Friend WithEvents txtQtyOnHand As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpTransferDate As DateTimePicker
    Friend WithEvents lblAuthorizedManager As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnResetList As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRequestor As TextBox
    Friend WithEvents lblTransferDirection As Label
    Friend WithEvents pbxPhotoNotice As PictureBox
End Class
