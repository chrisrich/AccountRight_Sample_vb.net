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

Imports System.Windows.Forms
Namespace VisualBasicSamples.Common.Forms
    Partial Public Class CompanyLogonForm
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Property UserName() As String
        Public Property Password() As String
        Private Sub btnLogin_Click(sender As Object, e As System.EventArgs) Handles btnLogin.Click
            UserName = txtUserName.Text
            Password = txtPwd.Text
            DialogResult = DialogResult.OK
            Close()
        End Sub
        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs) Handles btnCancel.Click
            txtPwd.Text = ""
            txtUserName.Text = ""
            DialogResult = DialogResult.Cancel
            Close()
        End Sub
    End Class
End Namespace
