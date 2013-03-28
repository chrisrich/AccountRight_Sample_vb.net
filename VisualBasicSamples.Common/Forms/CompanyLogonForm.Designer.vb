Namespace VisualBasicSamples.Common.Forms
    Partial Class CompanyLogonForm
        Private components As System.ComponentModel.IContainer = Nothing
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private Sub InitializeComponent()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtUserName = New System.Windows.Forms.TextBox()
            Me.txtPwd = New System.Windows.Forms.TextBox()
            Me.lblPwd = New System.Windows.Forms.Label()
            Me.btnLogin = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'lblUser
            '
            Me.lblUser.AutoSize = True
            Me.lblUser.Location = New System.Drawing.Point(31, 31)
            Me.lblUser.Name = "lblUser"
            Me.lblUser.Size = New System.Drawing.Size(66, 13)
            Me.lblUser.TabIndex = 0
            Me.lblUser.Text = "User Name :"
            Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtUserName
            '
            Me.txtUserName.Location = New System.Drawing.Point(111, 28)
            Me.txtUserName.Name = "txtUserName"
            Me.txtUserName.Size = New System.Drawing.Size(165, 20)
            Me.txtUserName.TabIndex = 1
            Me.txtUserName.Text = "administrator"
            '
            'txtPwd
            '
            Me.txtPwd.Location = New System.Drawing.Point(111, 64)
            Me.txtPwd.Name = "txtPwd"
            Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPwd.Size = New System.Drawing.Size(165, 20)
            Me.txtPwd.TabIndex = 3
            Me.txtPwd.UseSystemPasswordChar = True
            '
            'lblPwd
            '
            Me.lblPwd.AutoSize = True
            Me.lblPwd.Location = New System.Drawing.Point(35, 67)
            Me.lblPwd.Name = "lblPwd"
            Me.lblPwd.Size = New System.Drawing.Size(62, 13)
            Me.lblPwd.TabIndex = 2
            Me.lblPwd.Text = "Password : "
            Me.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnLogin
            '
            Me.btnLogin.Location = New System.Drawing.Point(111, 116)
            Me.btnLogin.Name = "btnLogin"
            Me.btnLogin.Size = New System.Drawing.Size(75, 23)
            Me.btnLogin.TabIndex = 4
            Me.btnLogin.Text = "Login"
            Me.btnLogin.UseVisualStyleBackColor = True
            '
            'btnCancel
            '
            Me.btnCancel.Location = New System.Drawing.Point(201, 116)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'CompanyLogonForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(288, 151)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnLogin)
            Me.Controls.Add(Me.txtPwd)
            Me.Controls.Add(Me.lblPwd)
            Me.Controls.Add(Me.txtUserName)
            Me.Controls.Add(Me.lblUser)
            Me.Name = "CompanyLogonForm"
            Me.Text = "Company Login "
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private lblUser As System.Windows.Forms.Label
        Private txtUserName As System.Windows.Forms.TextBox
        Private txtPwd As System.Windows.Forms.TextBox
        Private lblPwd As System.Windows.Forms.Label
        Private WithEvents btnLogin As System.Windows.Forms.Button
        Private WithEvents btnCancel As System.Windows.Forms.Button
    End Class
End Namespace
