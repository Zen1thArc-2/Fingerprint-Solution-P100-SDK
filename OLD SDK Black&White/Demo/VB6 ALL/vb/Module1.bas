Attribute VB_Name = "Module1"
Public connFP As New ADODB.Connection
Public recFP As New ADODB.Recordset
Public week(6) As String

Function Str2Byte(s As String, Index As Long) As Byte
    Dim b1 As Byte, b2 As Byte
    Dim s1 As String, s2 As String
    
    s1 = Mid(s, Index * 2 + 1, 1)
    s2 = Mid(s, Index * 2 + 2, 1)
    If s1 >= "A" Then
        b1 = Asc(s1) - Asc("A") + 10
    Else
        b1 = Asc(s1) - Asc("0")
    End If
    If s2 >= "A" Then
        b2 = Asc(s2) - Asc("A") + 10
    Else
        b2 = Asc(s2) - Asc("0")
    End If
    Str2Byte = b1 * 16 + b2
End Function

Function Str2ByteArray(s As String, b() As Byte) As Integer
    Dim i As Long
    Dim l As Long
    
    l = Len(s) / 2
    For i = 0 To l - 1 Step 1
        b(i) = Str2Byte(s, i)
    Next
    Str2ByteArray = l
End Function
