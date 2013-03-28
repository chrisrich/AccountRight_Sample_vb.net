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
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports VisualBasicSamples.Common.Helpers
Imports VisualBasicSamples.Common.Models

Namespace VisualBasicSamples.Common
    Public Class BusinessController(Of T As Class)
        Inherits ControllerBase(Of T)
        Shared Sub New()
            ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(Function(sender, certification, chain, sslPolicyErrors)
                                                                                                                  Return True

                                                                                                              End Function)
        End Sub
        Public Sub New()
            If String.IsNullOrEmpty(CompanyFileContext.ApiUrl) Then
                CompanyFileContext.ApiUrl = System.Configuration.ConfigurationManager.AppSettings("WebApiUrl")
            End If
        End Sub
        Public ReadOnly Property IsLogon() As Boolean
            Get
                If String.IsNullOrEmpty(CompanyFileContext.ApiUrl) Then
                    Return False
                End If
                Return Not String.IsNullOrEmpty(CompanyFileId)
            End Get
        End Property
        Public Overridable Sub CompanyLogon(companyModel As CompanyModel, userId As String, password As String)
            CompanyFileContext.CompanyFile = companyModel
            CompanyFileContext.UserId = userId
            CompanyFileContext.Password = password
        End Sub
        Public Sub CompanyLogOut()
            CompanyFileContext.CompanyFile = Nothing
            If Not CompanyFileContext.isCloud Then
                CompanyFileContext.OAuthDetails.Token = Nothing
            End If
            CompanyFileContext.UserId = [String].Empty
            CompanyFileContext.Password = [String].Empty
        End Sub
        Public ReadOnly Property CurrentCompany() As CompanyModel
            Get
                Return CompanyFileContext.CompanyFile
            End Get
        End Property
        Protected Overridable ReadOnly Property CompanyFileId() As String
            Get
                Return If(Not CompanyFileContext.CompanyFile Is Nothing, CompanyFileContext.CompanyFile.Id.ToString(), String.Empty)
            End Get
        End Property
        Protected Overridable ReadOnly Property [Module]() As String
            Get
                Return String.Empty
            End Get
        End Property
        Private ReadOnly Property WebApiUrl() As String
            Get
                Dim uri As UriBuilder = New UriBuilder(CompanyFileContext.ApiUrl)

                If Not String.IsNullOrEmpty(CompanyFileId) Then
                    uri.Path += "/" & CompanyFileId
                End If

                If Not String.IsNullOrEmpty([Module]) Then
                    uri.Path += "/" & [Module]
                End If

                Return uri.ToString()
            End Get
        End Property

        Protected Overloads Sub Delete(id As String)
            Dim isUnAuthorised As Integer = 0
            While isUnAuthorised < 2
                Try
                    Delete(id, WebApiUrl)
                    isUnAuthorised += 2
                    Exit Try
                Catch wex As WebException
                    If Not (TypeOf wex.Response Is HttpWebResponse) Then
                        Throw
                    End If
                    ' Repeat one time
                    If (isUnAuthorised < 2) AndAlso DirectCast(wex.Response, HttpWebResponse).StatusCode = HttpStatusCode.Unauthorized AndAlso CompanyFileContext.isCloud Then
                        isUnAuthorised += 1
                        ' Call Refresh token. 
                        OAuthInformation.RefreshAccessToken()
                    Else
                        Throw
                    End If
                End Try
            End While
        End Sub



        Protected Function GetAll(Optional _orderby As String = "", Optional _direction As String = "asc") As IEnumerable(Of T)
            Return GetAll(New List(Of SearchCriteria)(), , _orderby, _direction)
        End Function

        Protected Function GetAll(searches As IEnumerable(Of SearchCriteria), Optional logical As LogicalOperator = LogicalOperator.[and], Optional _orderby As String = "", Optional _direction As String = "asc") As IEnumerable(Of T)
            Dim pageItems As PageItems(Of T) = GetAll(Of PageItems(Of T))(searches, logical, , _orderby, _direction)
            Return pageItems.Items
        End Function

        Protected Function GetAll(Of TS)(searches As IEnumerable(Of SearchCriteria), Optional logical As LogicalOperator = LogicalOperator.[and], Optional _webApiUrl As String = Nothing, Optional _orderby As String = "", Optional _direction As String = "asc") As TS
            Dim queryString As StringBuilder = New StringBuilder()
            Dim i As Integer = 0
            While i < searches.Count()
                Dim criteria As SearchCriteria = searches.ElementAt(i)
                Dim filterString As String = ConstructUriFilterString(criteria)
                queryString.Append(If(i > 0, String.Format(" {0} {1}", logical.ToString(), filterString), filterString))
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While

            Dim searchUrl As String = If(String.IsNullOrEmpty(_webApiUrl), WebApiUrl, _webApiUrl)
            searchUrl += If((String.IsNullOrEmpty(queryString.ToString())), "", String.Format("?$filter={0}&$orderby={1} {2}", queryString, _orderby, _direction))
            searchUrl += If((String.IsNullOrEmpty(_orderby.ToString())), "", If((String.IsNullOrEmpty(queryString.ToString())), "?", "&") + String.Format("$orderby={0} {1}", _orderby, _direction))
            Return DoRequest(Of TS)(searchUrl)
        End Function


        Protected Function UriLiteral(type As Type, text As String) As String
            If type = GetType(Boolean) Then
                Return text
            End If
            If type = GetType(DateTime) Then
                Return String.Format("datetime'{0}'", text)
            End If
            If type = GetType(Guid) Then
                Return String.Format("guid'{0}'", text)
            End If
            Return String.Format("'{0}'", text)
        End Function
        Private Function ConstructUriFilterString(criteria As SearchCriteria) As String
            Return String.Format("{0} {1} {2}", criteria.Field, GetOperand(criteria.OperandType), UriLiteral(criteria.FieldType, criteria.SearchText))
        End Function
        Private Function GetOperand(type As OperandType) As String
            Select Case type
                Case OperandType.Equal
                    Return "eq"
                Case OperandType.GreaterThan
                    Return "gt"
                Case OperandType.GreaterThanOrEqual
                    Return "ge"
                Case OperandType.LessThan
                    Return "lt"
                Case OperandType.LessThanOrEqual
                    Return "le"
            End Select
            Throw New Exception("Operand parsing failed")
        End Function

        Protected Function GetById(id As String) As T
            Dim getUrl As String = String.Format(WebApiUrl + "/{0}", id)
            Return DoRequest(Of T)(getUrl)
        End Function


        Protected Sub Post(obj As T)
            DoSave(obj, "POST", WebApiUrl)
        End Sub
        Protected Sub Put(obj As T, id As String)
            Dim url As String = Path.Combine(WebApiUrl, id)
            DoSave(obj, "PUT", url)
        End Sub




        Public Sub CallOAuthAuthentication()
            OAuthInformation.GetAuthorizationCode()
        End Sub
        Public Sub CallRequestAccessToken()
            OAuthInformation.RequestAccessToken()
        End Sub
        Public Sub CallRefreshToken()
            OAuthInformation.RefreshAccessToken()
        End Sub
        Public Sub SetOAuthInfo(authorizationUri As String, tokenUri As String, clientId As String, clientSecret As String, redirectUri As String, scope As String)
            OAuthInformation = New OAuthInfo() With { _
              .AuthorizationUrl = authorizationUri, _
              .TokenUrl = tokenUri, _
              .ClientId = clientId, _
              .ClientSecret = clientSecret, _
              .RedirectUri = redirectUri, _
              .Scope = scope _
            }
        End Sub


        Public Property OAuthInformation() As OAuthInfo
            Get
                If CompanyFileContext.OAuthDetails Is Nothing Then
                    CompanyFileContext.OAuthDetails = New OAuthInfo() With { _
                      .AuthorizationUrl = "https://secure.myob.com/oauth2/account/authorize", _
                      .TokenUrl = "https://secure.myob.com/oauth2/v1/authorize", _
                      .ClientId = "<enter developer key>", _
                      .ClientSecret = "<enter developer secret>", _
                      .RedirectUri = "http://desktop", _
                      .Scope = "CompanyFile" _
                    }
                End If
                Return CompanyFileContext.OAuthDetails
            End Get
            Set(value As OAuthInfo)
                CompanyFileContext.OAuthDetails = value
            End Set
        End Property


    End Class
End Namespace
