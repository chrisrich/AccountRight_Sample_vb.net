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
Imports System.Linq
Imports System.Windows.Forms
Imports VisualBasicSamples.Common.Forms
Imports VisualBasicSamples.Account.Controllers
Imports VisualBasicSamples.Account.Models

Namespace VisualBasicSamples.Account.Forms
    Partial Public Class AccountList
        Inherits Form
        Private _controller As AccountController
        Private ReadOnly Property Controller() As AccountController
            Get
                If _controller Is Nothing Then
                    _controller = New AccountController()
                End If
                Return _controller
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Dim searchFields As Dictionary(Of String, String) = New Dictionary(Of String, String)()
            searchFields.Add("AccountType", "Account Type")
            searchFields.Add("SubType", "Sub Type")
            searchFields.Add("AccountLevel", "Level")
            cmbFieldSearch.DataSource = searchFields.ToList()
            cmbFieldSearch.DisplayMember = "value"
            cmbFieldSearch.ValueMember = "key"
            dgvAccountList.AutoGenerateColumns = False
        End Sub

        Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
            SearchAccount()
        End Sub

        Private Sub AccountList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If Not Controller.IsLogon Then
                LoginCompanyFile()
            End If
        End Sub

        Private Sub SearchAccount()
            Dim account As IEnumerable(Of AccountModel) = Controller.Search(cmbFieldSearch.SelectedValue.ToString(), txtSearch.Text,)
            dgvAccountList.DataSource = account
        End Sub

        'Private Sub btnNew_Click(sender As Object, e As EventArgs)
        '    Dim _account As Account = New Account(Nothing)
        '    _account.ShowDialog(Me)
        'End Sub


        Private Sub LoginCompanyFile()
            Dim companyFileList As CompanyFileList = New CompanyFileList() With { _
             .StartPosition = FormStartPosition.CenterParent _
            }
            companyFileList.ShowDialog(Me)
            If Controller.IsLogon Then
                lnkSwitchCompany.Text = String.Format("{0} | switch", Controller.CurrentCompany.Name)
                SearchAccount()
            Else
                lnkSwitchCompany.Text = "Select Company"
            End If
        End Sub


    End Class
End Namespace
