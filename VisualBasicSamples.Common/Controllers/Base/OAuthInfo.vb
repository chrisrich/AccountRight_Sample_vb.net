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

Namespace VisualBasicSamples.Common
    Public Class OAuthInfo
        Public Property AuthorizationUrl() As String
        Public Property TokenUrl() As String
        Public Property ClientId() As String
        Public Property ClientSecret() As String
        Public Property RedirectUri() As String
        Public Property Scope() As String
        Private Shared _token As OAuthToken

        Public Property Token() As OAuthToken
            Get
                Return _token
            End Get
            Set(value As OAuthToken)
                _token = value
            End Set
        End Property


        Public ReadOnly Property AccessToken As String
            Get
                If (Token Is Nothing) Then
                    Return ""
                Else
                    Return Token.Access_Token
                End If
            End Get
        End Property

        Public ReadOnly Property RefreshToken As String
            Get
                If (Token Is Nothing) Then
                    Return ""
                Else
                    Return Token.Refresh_Token
                End If
            End Get
        End Property
        Public Property Code() As String
    End Class
End Namespace
