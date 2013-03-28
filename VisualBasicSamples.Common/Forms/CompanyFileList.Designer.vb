Namespace VisualBasicSamples.Common.Forms
    Partial Class CompanyFileList
        Private components As System.ComponentModel.IContainer = Nothing
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.linkServer = New System.Windows.Forms.LinkLabel()
            Me.btnRefresh = New System.Windows.Forms.Button()
            Me.lblHeader = New System.Windows.Forms.Label()
            Me.dgvCompanyList = New System.Windows.Forms.DataGridView()
            Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.pnlCompanyList = New System.Windows.Forms.Panel()
            Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colLibraryPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colProductVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.bindSourceCompanyList = New System.Windows.Forms.BindingSource(Me.components)
            Me.pnlHeader.SuspendLayout()
            CType(Me.dgvCompanyList, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flowLayoutPanel1.SuspendLayout()
            Me.pnlCompanyList.SuspendLayout()
            CType(Me.bindSourceCompanyList, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.Controls.Add(Me.linkServer)
            Me.pnlHeader.Controls.Add(Me.btnRefresh)
            Me.pnlHeader.Controls.Add(Me.lblHeader)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(731, 44)
            Me.pnlHeader.TabIndex = 0
            '
            'linkServer
            '
            Me.linkServer.AutoSize = True
            Me.linkServer.Location = New System.Drawing.Point(535, 14)
            Me.linkServer.Name = "linkServer"
            Me.linkServer.Size = New System.Drawing.Size(87, 13)
            Me.linkServer.TabIndex = 18
            Me.linkServer.TabStop = True
            Me.linkServer.Text = "select API server"
            '
            'btnRefresh
            '
            Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnRefresh.Location = New System.Drawing.Point(644, 9)
            Me.btnRefresh.Name = "btnRefresh"
            Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
            Me.btnRefresh.TabIndex = 1
            Me.btnRefresh.Text = "Refresh"
            Me.btnRefresh.UseVisualStyleBackColor = True
            '
            'lblHeader
            '
            Me.lblHeader.AutoSize = True
            Me.lblHeader.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHeader.Location = New System.Drawing.Point(12, 9)
            Me.lblHeader.Name = "lblHeader"
            Me.lblHeader.Size = New System.Drawing.Size(395, 24)
            Me.lblHeader.TabIndex = 0
            Me.lblHeader.Text = "Please double click to select a company file."
            '
            'dgvCompanyList
            '
            Me.dgvCompanyList.AllowUserToAddRows = False
            Me.dgvCompanyList.AllowUserToDeleteRows = False
            Me.dgvCompanyList.AllowUserToResizeRows = False
            Me.dgvCompanyList.AutoGenerateColumns = False
            Me.dgvCompanyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvCompanyList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.colLibraryPath, Me.colProductVersion})
            Me.dgvCompanyList.DataSource = Me.bindSourceCompanyList
            Me.dgvCompanyList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvCompanyList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.dgvCompanyList.GridColor = System.Drawing.SystemColors.ButtonFace
            Me.dgvCompanyList.Location = New System.Drawing.Point(3, 3)
            Me.dgvCompanyList.MaximumSize = New System.Drawing.Size(720, 320)
            Me.dgvCompanyList.MinimumSize = New System.Drawing.Size(720, 320)
            Me.dgvCompanyList.MultiSelect = False
            Me.dgvCompanyList.Name = "dgvCompanyList"
            Me.dgvCompanyList.ReadOnly = True
            Me.dgvCompanyList.RowHeadersVisible = False
            Me.dgvCompanyList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            Me.dgvCompanyList.RowTemplate.ReadOnly = True
            Me.dgvCompanyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCompanyList.ShowCellErrors = False
            Me.dgvCompanyList.ShowCellToolTips = False
            Me.dgvCompanyList.ShowEditingIcon = False
            Me.dgvCompanyList.ShowRowErrors = False
            Me.dgvCompanyList.Size = New System.Drawing.Size(720, 320)
            Me.dgvCompanyList.TabIndex = 1
            '
            'flowLayoutPanel1
            '
            Me.flowLayoutPanel1.AutoSize = True
            Me.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.flowLayoutPanel1.Controls.Add(Me.dgvCompanyList)
            Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.flowLayoutPanel1.Location = New System.Drawing.Point(0, 44)
            Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
            Me.flowLayoutPanel1.Size = New System.Drawing.Size(731, 339)
            Me.flowLayoutPanel1.TabIndex = 2
            '
            'pnlCompanyList
            '
            Me.pnlCompanyList.Controls.Add(Me.flowLayoutPanel1)
            Me.pnlCompanyList.Controls.Add(Me.pnlHeader)
            Me.pnlCompanyList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCompanyList.Location = New System.Drawing.Point(0, 0)
            Me.pnlCompanyList.Name = "pnlCompanyList"
            Me.pnlCompanyList.Size = New System.Drawing.Size(731, 383)
            Me.pnlCompanyList.TabIndex = 2
            '
            'colName
            '
            Me.colName.DataPropertyName = "Name"
            Me.colName.HeaderText = "Name"
            Me.colName.Name = "colName"
            Me.colName.ReadOnly = True
            '
            'colLibraryPath
            '
            Me.colLibraryPath.DataPropertyName = "LibraryPath"
            Me.colLibraryPath.HeaderText = "LibraryPath"
            Me.colLibraryPath.Name = "colLibraryPath"
            Me.colLibraryPath.ReadOnly = True
            '
            'colProductVersion
            '
            Me.colProductVersion.DataPropertyName = "ProductVersion"
            Me.colProductVersion.HeaderText = "ProductVersion"
            Me.colProductVersion.Name = "colProductVersion"
            Me.colProductVersion.ReadOnly = True
            '
            'bindSourceCompanyList
            '
            Me.bindSourceCompanyList.AllowNew = False
            Me.bindSourceCompanyList.DataSource = GetType(VisualBasicSamples.Common.Models.CompanyModel)
            '
            'CompanyFileList
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(731, 383)
            Me.Controls.Add(Me.pnlCompanyList)
            Me.Name = "CompanyFileList"
            Me.Text = "MYOB AccountRight API"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            CType(Me.dgvCompanyList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.flowLayoutPanel1.ResumeLayout(False)
            Me.pnlCompanyList.ResumeLayout(False)
            Me.pnlCompanyList.PerformLayout()
            CType(Me.bindSourceCompanyList, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private pnlHeader As System.Windows.Forms.Panel
        Private lblHeader As System.Windows.Forms.Label
        Private WithEvents dgvCompanyList As System.Windows.Forms.DataGridView
        Private WithEvents btnRefresh As System.Windows.Forms.Button
        Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Private pnlCompanyList As System.Windows.Forms.Panel
        Private WithEvents linkServer As System.Windows.Forms.LinkLabel
        Friend WithEvents bindSourceCompanyList As System.Windows.Forms.BindingSource
        Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colLibraryPath As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colProductVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace
