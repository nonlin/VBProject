Imports System.Net.Sockets

Public Class NetworkManager

    Sub Main()
        Console.WriteLine("")
        Dim clientListener As New TcpListener(12380)
        clientListener.Stop()
        clientListener.Start()
        Console.WriteLine("")
        Dim mySocket As Socket = clientListener.AcceptSocket()
        Console.WriteLine("")
        Dim recieveBuff(225) As Byte
        mySocket.Receive(recieveBuff, recieveBuff.Length, SocketFlags.None)
        Dim str As String = System.Text.Encoding.ASCII.GetString(recieveBuff, 0, recieveBuff.Length).Trim(Microsoft.VisualBasic.ChrW(0))
        While Not str.StartsWith(".")
            Console.WriteLine(str)
            mySocket.Receive(recieveBuff, recieveBuff.Length, SocketFlags.None)
            str = System.Text.Encoding.ASCII.GetString(recieveBuff, 0, recieveBuff.Length).Trim(Microsoft.VisualBasic.ChrW(0))
        End While
        Console.WriteLine("")
        clientListener.Stop()
    End Sub

End Class
