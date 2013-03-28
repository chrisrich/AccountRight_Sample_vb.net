Namespace VisualBasicSamples.Account.Forms
    Partial Class AccountList
        Private components As System.ComponentModel.IContainer = Nothing
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.dgvAccountList = New System.Windows.Forms.DataGridView()
            Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.AccountNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.AccountTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SubTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ParentAccountIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.AccountLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IsInactiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.OpeningAccountBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CurrentAccountBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.bindSrcAccount = New System.Windows.Forms.BindingSource(Me.components)
            Me.cmbFieldSearch = New System.Windows.Forms.ComboBox()
            Me.txtSearch = New System.Windows.Forms.TextBox()
            Me.btnSearch = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.dtpDateOccurred = New System.Windows.Forms.DateTimePicker()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.lnkSwitchCompany = New System.Windows.Forms.LinkLabel()
            Me.label3 = New System.Windows.Forms.Label()
            CType(Me.dgvAccountList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindSrcAccount, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvAccountList
            '
            Me.dgvAccountList.AllowUserToAddRows = False
            Me.dgvAccountList.AllowUserToDeleteRows = False
            Me.dgvAccountList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvAccountList.AutoGenerateColumns = False
            Me.dgvAccountList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAccountList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.AccountNameDataGridViewTextBoxColumn, Me.AccountTypeDataGridViewTextBoxColumn, Me.SubTypeDataGridViewTextBoxColumn, Me.ParentAccountIdDataGridViewTextBoxColumn, Me.AccountLevelDataGridViewTextBoxColumn, Me.IsInactiveDataGridViewCheckBoxColumn, Me.OpeningAccountBalanceDataGridViewTextBoxColumn, Me.CurrentAccountBalanceDataGridViewTextBoxColumn})
            Me.dgvAccountList.DataSource = Me.bindSrcAccount
            Me.dgvAccountList.Location = New System.Drawing.Point(15, 71)
            Me.dgvAccountList.Name = "dgvAccountList"
            Me.dgvAccountList.ReadOnly = True
            Me.dgvAccountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAccountList.Size = New System.Drawing.Size(983, 369)
            Me.dgvAccountList.TabIndex = 0
            '
            'IdDataGridViewTextBoxColumn
            '
            Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
            Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
            Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
            Me.IdDataGridViewTextBoxColumn.ReadOnly = True
            '
            'AccountNameDataGridViewTextBoxColumn
            '
            Me.AccountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName"
            Me.AccountNameDataGridViewTextBoxColumn.HeaderText = "AccountName"
            Me.AccountNameDataGridViewTextBoxColumn.Name = "AccountNameDataGridViewTextBoxColumn"
            Me.AccountNameDataGridViewTextBoxColumn.ReadOnly = True
            '
            'AccountTypeDataGridViewTextBoxColumn
            '
            Me.AccountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType"
            Me.AccountTypeDataGridViewTextBoxColumn.HeaderText = "AccountType"
            Me.AccountTypeDataGridViewTextBoxColumn.Name = "AccountTypeDataGridViewTextBoxColumn"
            Me.AccountTypeDataGridViewTextBoxColumn.ReadOnly = True
            '
            'SubTypeDataGridViewTextBoxColumn
            '
            Me.SubTypeDataGridViewTextBoxColumn.DataPropertyName = "SubType"
            Me.SubTypeDataGridViewTextBoxColumn.HeaderText = "SubType"
            Me.SubTypeDataGridViewTextBoxColumn.Name = "SubTypeDataGridViewTextBoxColumn"
            Me.SubTypeDataGridViewTextBoxColumn.ReadOnly = True
            '
            'ParentAccountIdDataGridViewTextBoxColumn
            '
            Me.ParentAccountIdDataGridViewTextBoxColumn.DataPropertyName = "ParentAccountId"
            Me.ParentAccountIdDataGridViewTextBoxColumn.HeaderText = "ParentAccountId"
            Me.ParentAccountIdDataGridViewTextBoxColumn.Name = "ParentAccountIdDataGridViewTextBoxColumn"
            Me.ParentAccountIdDataGridViewTextBoxColumn.ReadOnly = True
            '
            'AccountLevelDataGridViewTextBoxColumn
            '
            Me.AccountLevelDataGridViewTextBoxColumn.DataPropertyName = "AccountLevel"
            Me.AccountLevelDataGridViewTextBoxColumn.HeaderText = "AccountLevel"
            Me.AccountLevelDataGridViewTextBoxColumn.Name = "AccountLevelDataGridViewTextBoxColumn"
            Me.AccountLevelDataGridViewTextBoxColumn.ReadOnly = True
            '
            'IsInactiveDataGridViewCheckBoxColumn
            '
            Me.IsInactiveDataGridViewCheckBoxColumn.DataPropertyName = "IsInactive"
            Me.IsInactiveDataGridViewCheckBoxColumn.HeaderText = "IsInactive"
            Me.IsInactiveDataGridViewCheckBoxColumn.Name = "IsInactiveDataGridViewCheckBoxColumn"
            Me.IsInactiveDataGridViewCheckBoxColumn.ReadOnly = True
            '
            'OpeningAccountBalanceDataGridViewTextBoxColumn
            '
            Me.OpeningAccountBalanceDataGridViewTextBoxColumn.DataPropertyName = "OpeningAccountBalance"
            Me.OpeningAccountBalanceDataGridViewTextBoxColumn.HeaderText = "OpeningAccountBalance"
            Me.OpeningAccountBalanceDataGridViewTextBoxColumn.Name = "OpeningAccountBalanceDataGridViewTextBoxColumn"
            Me.OpeningAccountBalanceDataGridViewTextBoxColumn.ReadOnly = True
            '
            'CurrentAccountBalanceDataGridViewTextBoxColumn
            '
            Me.CurrentAccountBalanceDataGridViewTextBoxColumn.DataPropertyName = "CurrentAccountBalance"
            Me.CurrentAccountBalanceDataGridViewTextBoxColumn.HeaderText = "CurrentAccountBalance"
            Me.CurrentAccountBalanceDataGridViewTextBoxColumn.Name = "CurrentAccountBalanceDataGridViewTextBoxColumn"
            Me.CurrentAccountBalanceDataGridViewTextBoxColumn.ReadOnly = True
            '
            'bindSrcAccount
            '
            Me.bindSrcAccount.DataSource = GetType(VisualBasicSamples.Account.Models.AccountModel)
            '
            'cmbFieldSearch
            '
            Me.cmbFieldSearch.FormattingEnabled = True
            Me.cmbFieldSearch.Location = New System.Drawing.Point(17, 15)
            Me.cmbFieldSearch.Name = "cmbFieldSearch"
            Me.cmbFieldSearch.Size = New System.Drawing.Size(121, 21)
            Me.cmbFieldSearch.TabIndex = 1
            '
            'txtSearch
            '
            Me.txtSearch.Location = New System.Drawing.Point(144, 16)
            Me.txtSearch.Name = "txtSearch"
            Me.txtSearch.Size = New System.Drawing.Size(195, 20)
            Me.txtSearch.TabIndex = 2
            '
            'btnSearch
            '
            Me.btnSearch.Location = New System.Drawing.Point(345, 14)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(75, 23)
            Me.btnSearch.TabIndex = 3
            Me.btnSearch.Text = "Search"
            Me.btnSearch.UseVisualStyleBackColor = True
            '
            'btnNew
            '
            Me.btnNew.Location = New System.Drawing.Point(17, 42)
            Me.btnNew.Name = "btnNew"
            Me.btnNew.Size = New System.Drawing.Size(75, 23)
            Me.btnNew.TabIndex = 14
            Me.btnNew.Text = "Add"
            Me.btnNew.UseVisualStyleBackColor = True
            '
            'dtpDateOccurred
            '
            Me.dtpDateOccurred.Location = New System.Drawing.Point(144, 16)
            Me.dtpDateOccurred.Name = "dtpDateOccurred"
            Me.dtpDateOccurred.Size = New System.Drawing.Size(200, 20)
            Me.dtpDateOccurred.TabIndex = 15
            Me.dtpDateOccurred.Visible = False
            '
            'panel3
            '
            Me.panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel3.BackColor = System.Drawing.SystemColors.Control
            Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel3.Controls.Add(Me.dgvAccountList)
            Me.panel3.Controls.Add(Me.txtSearch)
            Me.panel3.Controls.Add(Me.cmbFieldSearch)
            Me.panel3.Controls.Add(Me.dtpDateOccurred)
            Me.panel3.Controls.Add(Me.btnSearch)
            Me.panel3.Controls.Add(Me.btnNew)
            Me.panel3.Location = New System.Drawing.Point(12, 36)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(1011, 464)
            Me.panel3.TabIndex = 16
            '
            'lnkSwitchCompany
            '
            Me.lnkSwitchCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lnkSwitchCompany.Location = New System.Drawing.Point(547, 9)
            Me.lnkSwitchCompany.Name = "lnkSwitchCompany"
            Me.lnkSwitchCompany.Size = New System.Drawing.Size(307, 21)
            Me.lnkSwitchCompany.TabIndex = 17
            Me.lnkSwitchCompany.TabStop = True
            Me.lnkSwitchCompany.Text = "Select Company"
            Me.lnkSwitchCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(12, 9)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(97, 24)
            Me.label3.TabIndex = 18
            Me.label3.Text = "Accounts"
            '
            'AccountList
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1036, 512)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.lnkSwitchCompany)
            Me.Controls.Add(Me.panel3)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "AccountList"
            Me.Text = "MYOB AccountRight API"
            CType(Me.dgvAccountList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindSrcAccount, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private cmbFieldSearch As System.Windows.Forms.ComboBox
        Private txtSearch As System.Windows.Forms.TextBox
        Private WithEvents btnSearch As System.Windows.Forms.Button
        Private WithEvents dgvAccountList As System.Windows.Forms.DataGridView
        Private WithEvents btnNew As System.Windows.Forms.Button
        Private dtpDateOccurred As System.Windows.Forms.DateTimePicker
        Private panel3 As System.Windows.Forms.Panel
        Private lnkSwitchCompany As System.Windows.Forms.LinkLabel
        Private label3 As System.Windows.Forms.Label
        Friend WithEvents bindSrcAccount As System.Windows.Forms.BindingSource
        Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents AccountNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents AccountTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SubTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ParentAccountIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents AccountLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IsInactiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents OpeningAccountBalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CurrentAccountBalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace
