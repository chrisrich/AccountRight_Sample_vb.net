'  Copyright:   Copyright 2013 MYOB Technology Pty Ltd. All rights reserved.
'  Website:     http://www.myob.com
'  Author:      MYOB
'  E-mail:      info@myob.com
'
' Documentation, code and sample applications provided by MYOB Australia are for 
' information purposes only. MYOB Technology Pty Ltd and its suppliers make no 
' warranties, either express or implied, in this document. 
'
' Information in this document or code, including website references, is subject
' to change without notice. Unless otherwise noted, the example companies, 
' organisations, products, domain names, email addresses, people, places, and 
' events are fictitious. 
'
' The entire risk of the use of this documentation or code remains with the user. 
' Complying with all applicable copyright laws is the responsibility of the user. 
'
' Copyright 2013 MYOB Technology Pty Ltd. All rights reserved.

Imports System
Imports System.Windows.Forms
Imports VisualBasicSamples.Common.Controllers
Namespace VisualBasicSamples.Common.Forms
    Partial Public Class OAuthSetting
        Inherits Form
        Public Property Controller() As LibraryBrowserController
        Public Sub New()
            InitializeComponent()
            Controller = New LibraryBrowserController()
            txtAuthorisationURI.Text = Controller.OAuthInformation.AuthorizationUrl
            txtClientId.Text = Controller.OAuthInformation.ClientId
            txtClientSecret.Text = Controller.OAuthInformation.ClientSecret
            txtEndptURI.Text = Controller.OAuthInformation.TokenUrl
            txtScope.Text = Controller.OAuthInformation.Scope
            txtRedirectURI.Text = Controller.OAuthInformation.RedirectUri
        End Sub
        Private Sub btnReqAuthorise_Click(sender As Object, e As EventArgs) Handles btnReqAuthorise.Click
            toggleButtons(False)
            Controller.SetOAuthInfo(txtAuthorisationURI.Text, txtEndptURI.Text, txtClientId.Text, txtClientSecret.Text, txtRedirectURI.Text, txtScope.Text)
            Controller.CallOAuthAuthentication()
            Controller.CallRequestAccessToken()
            txtAccessToken.Text = Controller.OAuthInformation.AccessToken
            txtRefreshToken.Text = Controller.OAuthInformation.Token.Refresh_Token
            CompanyFileContext.DevKey = txtClientId.Text
            toggleButtons(True)
        End Sub
        Private Sub btnSaveSetting_Click(sender As Object, e As EventArgs) Handles btnSaveSetting.Click
            CompanyFileContext.isCloud = chkIsCould.Checked
            CompanyFileContext.ApiUrl = txtWebAPIUri.Text
            Close()
        End Sub
        Private Sub btnRefreshToken_Click(sender As Object, e As EventArgs) Handles btnRefreshToken.Click
            toggleButtons(False)
            Controller.OAuthInformation.Token = Nothing
            Controller.CallRefreshToken()
            txtAccessToken.Text = Controller.OAuthInformation.AccessToken
            txtRefreshToken.Text = Controller.OAuthInformation.RefreshToken
            toggleButtons(True)
        End Sub
        Private Sub chkIsCould_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsCould.CheckedChanged
            If chkIsCould.Checked Then
                txtWebAPIUri.Text = "https://api.myob.com/accountright/"
                panel1.Enabled = True
                If txtAccessToken.Text.Length = 0 Then
                    btnSaveSetting.Enabled = False
                End If
            Else
                txtWebAPIUri.Text = "https://localhost:8080/accountright/"
                panel1.Enabled = False
                btnSaveSetting.Enabled = True
            End If
        End Sub
        Private Sub toggleButtons(enabled As Boolean)
            btnRefreshToken.Enabled = enabled
            btnReqAuthorise.Enabled = enabled
            btnSaveSetting.Enabled = enabled
            Me.Cursor = If(enabled, Cursors.[Default], Cursors.WaitCursor)
        End Sub
    End Class
End Namespace
