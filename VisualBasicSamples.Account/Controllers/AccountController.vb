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
Imports System.Globalization
Imports System.Linq
Imports VisualBasicSamples.Common
Imports VisualBasicSamples.Account.Models
Imports System.Collections.Generic

Namespace VisualBasicSamples.Account.Controllers
    Public Class AccountController
        Inherits BusinessController(Of AccountModel)

        Protected Overrides ReadOnly Property [Module]() As String
            Get
                Return "Account"
            End Get
        End Property

        Public Function Index() As IEnumerable(Of AccountModel)
            If Not IsLogon Then
                Return Enumerable.Empty(Of AccountModel)()
            End If

            Return GetAll()
        End Function

        Public Function Details(id As String, isNew As Boolean) As AccountModel
            Dim account As AccountModel = GetById(id)
            If account Is Nothing Then
                Throw New Exception("Record does not exists")
            End If
            Return account
        End Function

        Public Sub Save(account As AccountModel)
            If account.IsNew Then
                Post(account)
            Else
                Put(account, account.Id)
            End If
        End Sub

        Public Shadows Sub Delete(id As String)
            MyBase.Delete(id)
        End Sub

        Public Function Search(field As String, _search As String, Optional _orderby As String = "Id", Optional _direction As String = "asc") As IEnumerable(Of AccountModel)
            If (String.IsNullOrEmpty(_search) OrElse String.IsNullOrEmpty(field)) Then
                Return GetAll("Id")
            End If
            Dim searchCriteria As List(Of SearchCriteria) = New List(Of SearchCriteria)()

            If Not String.IsNullOrEmpty(_search) AndAlso Not String.IsNullOrEmpty(field) Then
                If field = "AccountLevel" Then
                    searchCriteria.Add(New SearchCriteria() With { _
                      .Field = field, _
                      .SearchText = _search, _
                      .FieldType = GetType(Integer), _
                      .OperandType = OperandType.LessThanOrEqual _
                    })
                Else
                    searchCriteria.Add(New SearchCriteria() With { _
                      .Field = field, _
                      .SearchText = _search, _
                      .FieldType = GetSearchType(field) _
                    })
                End If
            End If
            Return GetAll(searchCriteria, , "Id")
        End Function

        Private Function GetSearchType(field As String) As Type
            Select Case field
                Case "AccountType"
                    Return GetType(AccountTypes)
                Case "SubType"
                    Return GetType(SubTypes)
            End Select
            Return GetType(String)
        End Function

    End Class
End Namespace
