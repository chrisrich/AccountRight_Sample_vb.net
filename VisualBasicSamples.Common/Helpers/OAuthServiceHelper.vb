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

Option Strict Off
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Windows.Forms
Imports Newtonsoft.Json

Namespace VisualBasicSamples.Common.Helpers
    Friend Module OAuthServiceHelper

        <System.Runtime.CompilerServices.Extension()> _
        Public Sub RequestAccessToken(info As OAuthInfo)
            Dim accessTokenBody As String = String.Format("client_id={0}&client_secret={1}&scope={2}&code={3}&redirect_uri={4}&grant_type=authorization_code", info.ClientId, info.ClientSecret, info.Scope, info.Code, info.RedirectUri)
            Dim reply As String = DoPost(info.TokenUrl, accessTokenBody)
            info.Token = JsonConvert.DeserializeObject(Of OAuthToken)(reply)
        End Sub


        <System.Runtime.CompilerServices.Extension()> _
        Public Function RefreshAccessToken(info As OAuthInfo) As OAuthToken
            Dim accessTokenBody As String = String.Format("client_id={0}&client_secret={1}&refresh_token={2}&grant_type=refresh_token", info.ClientId, info.ClientSecret, info.Token.Refresh_Token)
            Dim reply As String = DoPost(info.TokenUrl, accessTokenBody)
            info.Token = JsonConvert.DeserializeObject(Of OAuthToken)(reply)
            Return info.Token
        End Function

        Private Function DoPost(url As String, body As String) As String
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/x-www-form-urlencoded"
            Dim bytes As Byte() = Encoding.ASCII.GetBytes(body)
            If bytes.Length > 0 Then
                request.ContentLength = bytes.Length
                Using requestStream As Stream = request.GetRequestStream()
                    requestStream.Write(bytes, 0, bytes.Length)
                End Using
            End If
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using responseStream As Stream = response.GetResponseStream()
                    If responseStream Is Nothing Then
                        Throw New InvalidOperationException("WebReponse not received.")
                    End If
                    Using sr As StreamReader = New StreamReader(responseStream)
                        Return sr.ReadToEnd()
                    End Using
                End Using
            End Using
        End Function

        <System.Runtime.CompilerServices.Extension()> _
        Public Sub GetAuthorizationCode(info As OAuthInfo)
            Dim frm As Form = New Form()
            Dim webB As WebBrowser = New WebBrowser()
            Dim txtCode As TextBox = New TextBox()
            Dim authorizationParams As String = String.Format("?client_id={0}&redirect_uri={1}&scope={2}&response_type=code", info.ClientId, HttpUtility.UrlEncode(info.RedirectUri), info.Scope)
            Dim url As String = info.AuthorizationUrl + authorizationParams
            frm.Controls.Add(webB)
            frm.Controls.Add(txtCode)
            txtCode.Visible = False
            txtCode.Name = "txtCode"
            webB.Dock = DockStyle.Fill
            webB.Navigate(url)
            AddHandler webB.DocumentTitleChanged, AddressOf webB_DocumentTitleChanged
            frm.Size = New Size(1000, 450)
            frm.ShowDialog()
            info.Code = txtCode.Text
        End Sub

        Public Sub webB_DocumentTitleChanged(sender As Object, e As EventArgs)
            Dim webB As WebBrowser = TryCast(sender, WebBrowser)
            Dim frm As Form = TryCast(webB.Parent, Form)
            Diagnostics.Debug.Print(webB.Document.Title)
            If webB.DocumentText.Contains("code=") Then
                Dim ctrls As Control() = frm.Controls.Find("txtCode", False)
                If ctrls.Length > 0 AndAlso TypeOf ctrls(0) Is TextBox Then
                    Dim txtCode As TextBox = TryCast(ctrls(0), TextBox)
                    'txtCode.Text = webB.DocumentTitle.Replace("code=", "")
                    txtCode.Text = ExtractSubstring(webB.DocumentText, "code=", "<")
                End If
                frm.Close()
                Return
            End If
            frm.Text = webB.DocumentTitle
        End Sub

        Private Function ExtractSubstring(input As String, startsWith As String, endsWith As String) As String

            Dim match As Match = Regex.Match(input, startsWith + "(.*)" + endsWith)
            Dim code As String = match.Groups(1).Value
            Return code
        End Function

    End Module
End Namespace
