Public Class Player

    Private PlayerNumber As Integer
    Private CardType As String
    Private PlayerName As String
    Private FontSize As Integer = 10
    Private UniquePlayerID As String = ""

    Public Sub New(ByVal num As Integer, ByVal type As String, ByVal name As String)

        PlayerNumber = num
        CardType = type
        PlayerName = name
    End Sub

    Public Sub New()

    End Sub

    Public ReadOnly Property GetUniquePlayerID As String
        Get
            Return UniquePlayerID
        End Get
    End Property

    Public Sub SetUniquePlayerID(ByVal id As String)
        UniquePlayerID = id
    End Sub

    Public ReadOnly Property GetPlayerNumber() As Integer
        Get
            Return PlayerNumber
        End Get
    End Property

    Public ReadOnly Property GetCardType() As String
        Get
            Return CardType
        End Get
    End Property

    Public ReadOnly Property GetPlayerName() As String
        Get
            Return PlayerName
        End Get
    End Property

    Public Sub SetPlayerName(ByVal name As String)
        PlayerName = name
    End Sub

    Public ReadOnly Property GetFontSize() As Integer
        Get
            Return FontSize
        End Get
    End Property

    Public Sub SetFontSize(ByVal size As Integer)
        FontSize = size
    End Sub

    Public Sub SetPlayerNumber(ByVal num As Integer)
        PlayerNumber = num
    End Sub

    Public Sub SetPlayerCardType(ByVal type As String)
        CardType = type
    End Sub
End Class
