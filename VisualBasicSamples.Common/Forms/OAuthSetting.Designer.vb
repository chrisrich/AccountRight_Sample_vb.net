Namespace VisualBasicSamples.Common.Forms
    Partial Class OAuthSetting
        Private components As System.ComponentModel.IContainer = Nothing
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private Sub InitializeComponent()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.btnReqAuthorise = New System.Windows.Forms.Button()
            Me.btnRefreshToken = New System.Windows.Forms.Button()
            Me.label9 = New System.Windows.Forms.Label()
            Me.txtAccessToken = New System.Windows.Forms.TextBox()
            Me.label8 = New System.Windows.Forms.Label()
            Me.txtRefreshToken = New System.Windows.Forms.TextBox()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.txtScope = New System.Windows.Forms.TextBox()
            Me.txtClientSecret = New System.Windows.Forms.TextBox()
            Me.txtClientId = New System.Windows.Forms.TextBox()
            Me.txtAuthorisationURI = New System.Windows.Forms.TextBox()
            Me.txtRedirectURI = New System.Windows.Forms.TextBox()
            Me.txtEndptURI = New System.Windows.Forms.TextBox()
            Me.label10 = New System.Windows.Forms.Label()
            Me.chkIsCould = New System.Windows.Forms.CheckBox()
            Me.label7 = New System.Windows.Forms.Label()
            Me.txtWebAPIUri = New System.Windows.Forms.TextBox()
            Me.btnSaveSetting = New System.Windows.Forms.Button()
            Me.panel3.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.panel1)
            Me.panel3.Controls.Add(Me.label10)
            Me.panel3.Controls.Add(Me.chkIsCould)
            Me.panel3.Controls.Add(Me.label7)
            Me.panel3.Controls.Add(Me.txtWebAPIUri)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel3.Location = New System.Drawing.Point(0, 0)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(654, 487)
            Me.panel3.TabIndex = 6
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.btnReqAuthorise)
            Me.panel1.Controls.Add(Me.btnRefreshToken)
            Me.panel1.Controls.Add(Me.label9)
            Me.panel1.Controls.Add(Me.txtAccessToken)
            Me.panel1.Controls.Add(Me.label8)
            Me.panel1.Controls.Add(Me.txtRefreshToken)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.txtScope)
            Me.panel1.Controls.Add(Me.txtClientSecret)
            Me.panel1.Controls.Add(Me.txtClientId)
            Me.panel1.Controls.Add(Me.txtAuthorisationURI)
            Me.panel1.Controls.Add(Me.txtRedirectURI)
            Me.panel1.Controls.Add(Me.txtEndptURI)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Enabled = False
            Me.panel1.Location = New System.Drawing.Point(0, 105)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(654, 382)
            Me.panel1.TabIndex = 5
            '
            'btnReqAuthorise
            '
            Me.btnReqAuthorise.Location = New System.Drawing.Point(29, 346)
            Me.btnReqAuthorise.Name = "btnReqAuthorise"
            Me.btnReqAuthorise.Size = New System.Drawing.Size(113, 23)
            Me.btnReqAuthorise.TabIndex = 19
            Me.btnReqAuthorise.Text = "Authorize"
            Me.btnReqAuthorise.UseVisualStyleBackColor = True
            '
            'btnRefreshToken
            '
            Me.btnRefreshToken.Location = New System.Drawing.Point(163, 346)
            Me.btnRefreshToken.Name = "btnRefreshToken"
            Me.btnRefreshToken.Size = New System.Drawing.Size(99, 23)
            Me.btnRefreshToken.TabIndex = 20
            Me.btnRefreshToken.Text = "Refresh Token"
            Me.btnRefreshToken.UseVisualStyleBackColor = True
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(40, 221)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(76, 13)
            Me.label9.TabIndex = 15
            Me.label9.Text = "Access Token"
            '
            'txtAccessToken
            '
            Me.txtAccessToken.Location = New System.Drawing.Point(210, 221)
            Me.txtAccessToken.Multiline = True
            Me.txtAccessToken.Name = "txtAccessToken"
            Me.txtAccessToken.Size = New System.Drawing.Size(403, 40)
            Me.txtAccessToken.TabIndex = 14
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(40, 275)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(78, 13)
            Me.label8.TabIndex = 13
            Me.label8.Text = "Refresh Token"
            '
            'txtRefreshToken
            '
            Me.txtRefreshToken.Location = New System.Drawing.Point(210, 275)
            Me.txtRefreshToken.Multiline = True
            Me.txtRefreshToken.Name = "txtRefreshToken"
            Me.txtRefreshToken.Size = New System.Drawing.Size(403, 47)
            Me.txtRefreshToken.TabIndex = 12
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(40, 187)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(38, 13)
            Me.label6.TabIndex = 11
            Me.label6.Text = "Scope"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(40, 153)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(67, 13)
            Me.label5.TabIndex = 10
            Me.label5.Text = "Client Secret"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(40, 119)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(47, 13)
            Me.label4.TabIndex = 9
            Me.label4.Text = "Client ID"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(40, 85)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(69, 13)
            Me.label3.TabIndex = 8
            Me.label3.Text = "Redirect URI"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(40, 51)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(118, 13)
            Me.label2.TabIndex = 7
            Me.label2.Text = "User Authorisation URL"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(40, 17)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(108, 13)
            Me.label1.TabIndex = 6
            Me.label1.Text = "Token Endpoint URL"
            '
            'txtScope
            '
            Me.txtScope.Location = New System.Drawing.Point(210, 187)
            Me.txtScope.Name = "txtScope"
            Me.txtScope.Size = New System.Drawing.Size(403, 20)
            Me.txtScope.TabIndex = 5
            '
            'txtClientSecret
            '
            Me.txtClientSecret.Location = New System.Drawing.Point(210, 153)
            Me.txtClientSecret.Name = "txtClientSecret"
            Me.txtClientSecret.Size = New System.Drawing.Size(403, 20)
            Me.txtClientSecret.TabIndex = 4
            '
            'txtClientId
            '
            Me.txtClientId.Location = New System.Drawing.Point(210, 119)
            Me.txtClientId.Name = "txtClientId"
            Me.txtClientId.Size = New System.Drawing.Size(403, 20)
            Me.txtClientId.TabIndex = 3
            '
            'txtAuthorisationURI
            '
            Me.txtAuthorisationURI.Location = New System.Drawing.Point(210, 51)
            Me.txtAuthorisationURI.Name = "txtAuthorisationURI"
            Me.txtAuthorisationURI.Size = New System.Drawing.Size(403, 20)
            Me.txtAuthorisationURI.TabIndex = 2
            '
            'txtRedirectURI
            '
            Me.txtRedirectURI.Location = New System.Drawing.Point(210, 85)
            Me.txtRedirectURI.Name = "txtRedirectURI"
            Me.txtRedirectURI.Size = New System.Drawing.Size(403, 20)
            Me.txtRedirectURI.TabIndex = 1
            '
            'txtEndptURI
            '
            Me.txtEndptURI.Location = New System.Drawing.Point(210, 17)
            Me.txtEndptURI.Name = "txtEndptURI"
            Me.txtEndptURI.Size = New System.Drawing.Size(403, 20)
            Me.txtEndptURI.TabIndex = 0
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.Location = New System.Drawing.Point(40, 18)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(537, 15)
            Me.label10.TabIndex = 3
            Me.label10.Text = "This dialog is for development purposes only. You should not dispplay to your use" & _
        "rs these settings."
            '
            'chkIsCould
            '
            Me.chkIsCould.AutoSize = True
            Me.chkIsCould.Location = New System.Drawing.Point(212, 82)
            Me.chkIsCould.Name = "chkIsCould"
            Me.chkIsCould.Size = New System.Drawing.Size(99, 17)
            Me.chkIsCould.TabIndex = 2
            Me.chkIsCould.Text = "Cloud Web API"
            Me.chkIsCould.UseVisualStyleBackColor = True
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(40, 58)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(94, 13)
            Me.label7.TabIndex = 0
            Me.label7.Text = "Web API Address:"
            '
            'txtWebAPIUri
            '
            Me.txtWebAPIUri.Location = New System.Drawing.Point(210, 55)
            Me.txtWebAPIUri.Name = "txtWebAPIUri"
            Me.txtWebAPIUri.Size = New System.Drawing.Size(403, 20)
            Me.txtWebAPIUri.TabIndex = 1
            Me.txtWebAPIUri.Text = "http://Localhost:8080/accountright/"
            '
            'btnSaveSetting
            '
            Me.btnSaveSetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSaveSetting.Location = New System.Drawing.Point(538, 491)
            Me.btnSaveSetting.Name = "btnSaveSetting"
            Me.btnSaveSetting.Size = New System.Drawing.Size(75, 23)
            Me.btnSaveSetting.TabIndex = 21
            Me.btnSaveSetting.Text = "Save"
            Me.btnSaveSetting.UseVisualStyleBackColor = True
            '
            'OAuthSetting
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(654, 526)
            Me.Controls.Add(Me.btnSaveSetting)
            Me.Controls.Add(Me.panel3)
            Me.Name = "OAuthSetting"
            Me.Text = "OAuth Setting"
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Private panel3 As System.Windows.Forms.Panel
        Private WithEvents chkIsCould As System.Windows.Forms.CheckBox
        Private label7 As System.Windows.Forms.Label
        Private txtWebAPIUri As System.Windows.Forms.TextBox
        Private label10 As System.Windows.Forms.Label
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents btnSaveSetting As System.Windows.Forms.Button
        Private WithEvents btnReqAuthorise As System.Windows.Forms.Button
        Private WithEvents btnRefreshToken As System.Windows.Forms.Button
        Private label9 As System.Windows.Forms.Label
        Private txtAccessToken As System.Windows.Forms.TextBox
        Private label8 As System.Windows.Forms.Label
        Private txtRefreshToken As System.Windows.Forms.TextBox
        Private label6 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label1 As System.Windows.Forms.Label
        Private txtScope As System.Windows.Forms.TextBox
        Private txtClientSecret As System.Windows.Forms.TextBox
        Private txtClientId As System.Windows.Forms.TextBox
        Private txtAuthorisationURI As System.Windows.Forms.TextBox
        Private txtRedirectURI As System.Windows.Forms.TextBox
        Private txtEndptURI As System.Windows.Forms.TextBox
    End Class
End Namespace
