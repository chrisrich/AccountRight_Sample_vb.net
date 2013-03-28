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
Imports VisualBasicSamples.Common.Models
Namespace VisualBasicSamples.Common.Controllers
    Public Class LibraryBrowserController
        Inherits BusinessController(Of CompanyModel)
        Protected Overrides ReadOnly Property CompanyFileId() As String
            Get
                Return String.Empty
            End Get
        End Property

        Public Function Search(field As String, _search As String) As IEnumerable(Of CompanyModel)
            If (String.IsNullOrEmpty(_search) OrElse String.IsNullOrEmpty(field)) Then
                Return GetAll(Of List(Of CompanyModel))(New List(Of SearchCriteria)(), LogicalOperator.[and])
            End If
            Dim searchCriteria As List(Of SearchCriteria) = New List(Of SearchCriteria)()
            If Not String.IsNullOrEmpty(_search) AndAlso Not String.IsNullOrEmpty(field) Then
                searchCriteria.Add(New SearchCriteria() With { _
                  .Field = field, _
                  .SearchText = _search, _
                  .FieldType = GetSearchType(field) _
                })
            End If
            Return GetAll(Of List(Of CompanyModel))(searchCriteria, LogicalOperator.[and])
        End Function

        Private Function GetSearchType(field As String) As Type
            Select Case field
                Case "Id"
                    Return GetType(Guid)
                Case Else
                    Return GetType(String)
            End Select
        End Function

    End Class
End Namespace
