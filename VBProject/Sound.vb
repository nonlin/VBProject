Public Class Sound

    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnSTring As String, ByVal uReturnLength As Integer, ByVal hwndCallBack As Integer) As Integer

    Private oName As String = Nothing

    Public Property Name As String
        Set(value As String)
            oName = value
        End Set
        Get
            Return oName
        End Get
    End Property

    Public Sub Play(ByVal id As Integer, ByVal repeat As Boolean, Optional vol As Integer = 1000)
        If repeat = True Then
            mciSendString("Open " & GetFile(id) & " alias " & Name, CStr(0), 0, 0)
            mciSendString("play " & oName & " repeat ", CStr(0), 0, 0)
        Else
            mciSendString("Open " & GetFile(id) & " alias " & Name, CStr(0), 0, 0)
            mciSendString("play " & oName & " repeat ", CStr(0), 0, 0)
        End If
        'Optionally Set Volume
        mciSendString("setaudio " & oName & " volume to " & vol, CStr(0), 0, 0)
    End Sub

    'Media Library
    Private Function GetFile(ByVal Id As Integer) As String
        Dim path As String = ""
        'Spaces cause failter to load
        'Dots in path can fail to load
        Select Case Id
            Case 0
                path = "C:\Siven.wav"
            Case 1
                path = "C:\test.wav"
            Case 2
                path = "C:\Test.wav"
        End Select
        'return path with quotes " "
        path = Chr(34) & path & Chr(34)
        Return path
    End Function
End Class
