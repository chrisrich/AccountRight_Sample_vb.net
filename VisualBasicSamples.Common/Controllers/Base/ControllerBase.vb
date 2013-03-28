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
Imports System.IO
Imports System.Net
Imports VisualBasicSamples.Common.Models
Imports Newtonsoft.Json
Imports System.Text
Namespace VisualBasicSamples.Common
    Public MustInherit Class ControllerBase(Of T As Class)

        Protected Friend Sub DoSave(obj As T, method As String, url As String)
            Try
                Dim json As String = SerializeToJson(obj)
                Dim buff As Byte() = Encoding.ASCII.GetBytes(json)
                Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
                req.KeepAlive = True
                req.Method = method
                req.ContentLength = buff.Length
                req.ContentType = "application/json; charset=utf-8"
                req.Accept = "text/json"
                SetAuthHeaders(req)
                Dim postData As Stream = req.GetRequestStream()
                postData.Write(buff, 0, buff.Length)
                postData.Close()
                Dim postResponse As HttpWebResponse = DoRequestWithRetry(req)
                'SaveAuthToken(postResponse)
                Using respStream As Stream = postResponse.GetResponseStream()
                    If respStream IsNot Nothing Then
                        Using respStreamReader As StreamReader = New StreamReader(respStream)
                            Dim responseString As String = respStreamReader.ReadToEnd()
                        End Using
                    End If
                End Using
            Catch wex As WebException
                HanldeException(wex)
            End Try
        End Sub

        Protected Friend Sub Delete(id As String, url As String)
            Try
                Dim deleteUrl As String = String.Format(url + "/{0}", id)
                Dim req As HttpWebRequest = CType(WebRequest.Create(deleteUrl), HttpWebRequest)
                req.KeepAlive = True
                req.Method = "DELETE"
                req.ContentType = "application/json; charset=utf-8"
                req.Accept = "text/json"
                SetAuthHeaders(req)
                Dim postResponse As HttpWebResponse = DoRequestWithRetry(req)
                'SaveAuthToken(postResponse)
                Using respStream As Stream = postResponse.GetResponseStream()
                    If respStream IsNot Nothing Then
                        Using respStreamReader As StreamReader = New StreamReader(respStream)
                            Dim responseString As String = respStreamReader.ReadToEnd()
                        End Using
                    End If
                End Using
            Catch wex As WebException
                HanldeException(wex)
            End Try
        End Sub
        Protected Friend Function DoRequest(Of TS)(url As String) As TS
            Try
                Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
                req.KeepAlive = True
                req.Method = "GET"
                req.ContentType = "application/json; charset=utf-8"
                req.Accept = "text/json"
                SetAuthHeaders(req)
                Dim resp As HttpWebResponse = DoRequestWithRetry(req)
                If resp Is Nothing Then
                    Return Nothing
                End If
                Using respStream As Stream = resp.GetResponseStream()

                    Using respStreamReader As StreamReader = New StreamReader(respStream)
                        Return DeserializeJson(Of TS)(respStreamReader.ReadToEnd())
                    End Using
                End Using
            Catch wex As WebException
                HanldeException(wex)
            End Try
            Return Nothing
        End Function

        Private Function DoRequestWithRetry(req As HttpWebRequest) As HttpWebResponse
            Dim resp As WebResponse
            Try
                'Dim lStart As Long = DateTime.Now.Ticks
                resp = req.GetResponse()
                'Dim lStop As Long = DateTime.Now.Ticks
                'System.Diagnostics.Debug.WriteLine(req.RequestUri.ToString + ": " + (lStop - lStart).ToString)
                Return TryCast(resp, HttpWebResponse)
            Catch wex As WebException
                If Not (TypeOf wex.Response Is HttpWebResponse) Then
                    Throw
                End If

                If CompanyFileContext.isCloud AndAlso DirectCast(wex.Response, HttpWebResponse).StatusCode = HttpStatusCode.Unauthorized Then
                    If TypeOf Me Is BusinessController(Of T) Then
                        DirectCast(Me, BusinessController(Of T)).CallRefreshToken()
                        SetAuthHeaders(req)
                        Return TryCast(req.GetResponse(), HttpWebResponse)
                    End If
                End If
                Throw
            End Try
        End Function

        Private Function SerializeToJson(obj As T) As String
            Return JsonConvert.SerializeObject(obj)
        End Function
        Private Function DeserializeJson(Of TS)(jsonString As String) As TS
            Return JsonConvert.DeserializeObject(Of TS)(jsonString)
        End Function

        Protected Friend Sub SetAuthHeaders(req As HttpWebRequest)
            Dim encryptCredential As String = EncodeTo64(CompanyFileContext.UserId + ":" + CompanyFileContext.Password)
            req.Headers("Authorization") = "Bearer " + CompanyFileContext.OAuthDetails.AccessToken
            req.Headers("x-myobapi-key") = CompanyFileContext.DevKey
            req.Headers("x-myobapi-cftoken") = encryptCredential
            req.Headers(HttpRequestHeader.AcceptEncoding) = "gzip,deflate"
            req.Host = "api.myob.com"
            req.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
        End Sub
        Friend Shared Function EncodeTo64(toEncode As String) As String
            Return Convert.ToBase64String(Encoding.ASCII.GetBytes(toEncode))
        End Function
        'Protected Friend Sub SaveAuthToken(rep As HttpWebResponse)
        '    CompanyFileContext.AuthorizationToken = TryCast(rep.Headers("Authorization-token"), String)
        'End Sub
        Protected Sub HanldeException(wex As WebException)
            If wex.Status = WebExceptionStatus.ConnectFailure Then
                Throw New Exception(String.Format("Connection failed, please make sure the target server {0} is on.", ""), wex)
            End If
            Using resp As HttpWebResponse = CType(wex.Response, HttpWebResponse)
                If resp Is Nothing Then
                    Throw wex
                End If
                Using respStream As Stream = resp.GetResponseStream()
                    Using respStreamReader As StreamReader = New StreamReader(respStream)
                        Dim responseString As String = respStreamReader.ReadToEnd()
                        If resp.StatusCode = HttpStatusCode.Conflict Then
                            Throw New Exception(String.Format("AccountRight validation message - {0}", responseString))
                        End If
                        Throw New Exception(String.Format("{0} - {1} : {2}", resp.StatusCode.GetHashCode(), resp.StatusDescription, responseString))
                    End Using
                End Using
            End Using
        End Sub
    End Class
End Namespace
