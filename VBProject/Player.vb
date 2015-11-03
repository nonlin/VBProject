Public Class Player

    Private PlayerNumber As Integer
    Private CardType As String
    Private PlayerName As String
    Private FontSize As Integer = 10
    Private UniquePlayerID As String = ""
    Private VoteCount As Integer = 0
    'If hunter voted for player set HunterSights to True to indicate Hunter is aiming for this person
    Private HunterSights As Boolean = False

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

    Public Sub AddVote()
        VoteCount = VoteCount + 1
    End Sub

    Public Sub SetVoteCount(ByVal vote As Integer)
        VoteCount = VoteCount + vote
    End Sub

    Public ReadOnly Property GetVoteCount()
        Get
            Return VoteCount
        End Get
    End Property
    Public Sub SetHunterSights(ByVal bool As Boolean)
        HunterSights = bool
    End Sub
    Public ReadOnly Property GetHunterSights()
        Get
            Return HunterSights
        End Get
    End Property
End Class
