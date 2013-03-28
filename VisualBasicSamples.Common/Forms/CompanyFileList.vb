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
Imports System.Drawing
Imports System.Linq
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports VisualBasicSamples.Common.Controllers
Imports VisualBasicSamples.Common.Models
Namespace VisualBasicSamples.Common.Forms
    Partial Public Class CompanyFileList
        Inherits Form
        Private controller As LibraryBrowserController
        Private LogonDialogOpen As Boolean = False
        Public Sub New()
            InitializeComponent()
        End Sub
        Public ReadOnly Property CompanyList() As IList(Of CompanyModel)
            Get
                If _companyList Is Nothing Then
                    GetCompany()
                End If
                Return _companyList
            End Get
        End Property
        Private _companyList As IList(Of CompanyModel)
        Private Sub GetCompany()
            _companyList = controller.Search("", "").ToList()
        End Sub
        Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
            GetCompany()
        End Sub
        Private Sub dgvCompanyList_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCompanyList.CellMouseDoubleClick
            Dim company As CompanyModel = TryCast(dgvCompanyList.Rows(e.RowIndex).DataBoundItem, CompanyModel)
            Dim companyLogon As CompanyLogonForm = New CompanyLogonForm() With { _
              .StartPosition = FormStartPosition.CenterParent _
            }
            LogonDialogOpen = True
            If companyLogon.ShowDialog() = DialogResult.OK Then
                Dim userName As String = companyLogon.UserName
                Dim password As String = companyLogon.Password
                controller.CompanyLogon(company, userName, password)
                Close()
            End If
        End Sub
        Private Sub CompanyFileList_FormClosed(sender As Object, e As FormClosedEventArgs)
            If Not controller.IsLogon AndAlso Not LogonDialogOpen Then
                Application.[Exit]()
            End If
        End Sub
        Private Sub linkServer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkServer.LinkClicked
            Dim OAuth As OAuthSetting = New OAuthSetting() With { _
             .StartPosition = FormStartPosition.CenterParent _
           }
            If OAuth.ShowDialog() = DialogResult.OK Then
                Return
            End If
            controller = New LibraryBrowserController()
            dgvCompanyList.DataSource = CompanyList()
        End Sub

 
    End Class
End Namespace
