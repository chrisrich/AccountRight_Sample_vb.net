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

Namespace VisualBasicSamples.Common.Helpers
    Public Module StringHelper
        <System.Runtime.CompilerServices.Extension()> _
        Public Function TrimStart(target As String, trimString As String) As String
            Dim result As String = target
            While result.StartsWith(trimString)
                result = result.Substring(trimString.Length)
            End While
            Return result
        End Function
        <System.Runtime.CompilerServices.Extension()> _
        Public Function TrimEnd(target As String, trimString As String) As String
            Dim result As String = target
            While result.EndsWith(trimString)
                result = result.Substring(0, result.Length - trimString.Length)
            End While
            Return result
        End Function
    End Module
End Namespace
