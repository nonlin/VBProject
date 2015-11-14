Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports System.Net
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices


Public Class MainForm
    'Before I make a player I should check with the game to see how many players there are or get updated from an updated list somehow
    Dim thisPlayer As Player = New Player(0, "Nothing", "FreshBait")
    Dim PlayerList As New List(Of Player)
    Dim isMasterList As New List(Of String)
    Dim CharacterList As New List(Of String)
    Dim isReadyList As New List(Of String)
    Dim MiddleCardsList As New List(Of String)
    Dim MiddleCardPicutreList As New List(Of PictureBox)
    Dim RolePlayTime As New Dictionary(Of String, Integer)

    'List of all player lables to assign later
    Dim ListOfPlayerNameLabels As New List(Of Label)
    Dim ListOfPlayerCards As New List(Of PictureBox)

    Dim recievedID As String = ""
    Dim PlayerExists As Boolean = False
    Dim RoundStarted As Boolean = False
    Dim EnableAudio As Boolean = True
    ' Dim PlayerCount As Integer = 0
    Dim isMaster As Boolean = False
    Dim Pos As Integer = 0
    Dim StartRound As Boolean = True
    Private RoundTime As String = "2"
    Dim voteCount As Integer = 0
    Dim EndRoundVotePassed = False
    Dim TurnTime As Integer = 10
    Dim InitialRole As String = ""
    Dim AlreadyVoted As Boolean = False
    Private Delegate Sub UpdateTextBoxDelegate(ByVal txtBox As RichTextBox, ByVal value As String)
    Private Delegate Sub UpdateReadyMessage(ByVal txtBox As CheckBox, ByVal value As String)
    Private Delegate Sub EnableTimerDelegate(ByVal enable As Boolean)
    Private Delegate Sub UpdateTimerLabelText(ByVal timeText As String)
    Private Delegate Sub GameSetUpDelegate(ByVal type As String)
    Private Delegate Sub SetPlayerNameLabelsDelegate()
    Private Delegate Sub RevealAllCardsDelegate()
    Private Delegate Sub VoteToEndRoundDelegate()
    Private Delegate Sub RestartRoundDelegate()
    Private Delegate Sub SetRestartButtonDelegate(ByVal Enabled As Boolean)
    Private Delegate Sub EnableNewCardForPlayerDelegate(ByVal index As Integer)
    'Roll Time Variables, Might want to make into its own class
    Dim TimeMulti As Integer = 0

    Dim WWFound As Boolean = False
    Dim MFound As Boolean = False
    Dim SFound As Boolean = False
    Dim RFound As Boolean = False
    Dim TMFound As Boolean = False
    Dim DFound As Boolean = False
    Dim IFound As Boolean = False
    'More Game Vairables
    Dim randomIntegerID As Integer = 0
    Dim Time As Integer = 0
    Dim Night = False
    Dim ReverseTimer = False
    'So we can set how many players started a round in case of DC
    Dim GamePlayerCount As Integer = 0
    'Card Turn Boolean Checks
    Dim SawCard As Boolean = False
    Dim OneWereWolf As Boolean = False
    Dim CardCount As Integer = 0
    Dim TurnAllowed As Boolean = False
    Dim TMFirstPickIndex = -1
    Dim RobbersNewRole As String = "Robber"
    Dim DrunksNewRole As String = "Drunk"
    'Forms
    Dim VMF As VoteMenuForm
    'Network Related Variables
    Private Const port As Integer = 9653 'Or whatever port number you want to use
    Private Const broadcastAddress As String = "255.255.255.255"
    Private receivingClient As UdpClient
    Private sendingClient As UdpClient

    Private Const portChat As Integer = 9654 'Or whatever port number you want to use
    Private receivingClientChat As UdpClient
    Private sendingClientChat As UdpClient

    Private Const portPlayerInfo As Integer = 9655 'Or whatever port number you want to use
    Private receivingClientPlayerInfo As UdpClient
    Private sendingClientPlayerInfo As UdpClient

    Private Const portIsReady As Integer = 9656 'Or whatever port number you want to use
    Private receivingClientIsReady As UdpClient
    Private sendingClientIsReady As UdpClient

    Private Const portAssignedCards As Integer = 9657 'Or whatever port number you want to use
    Private receivingAssignedCards As UdpClient
    Private sendingAssignedCards As UdpClient

    Private Const portUpdateCardChanges As Integer = 9658 'Or whatever port number you want to use
    Private receivingUpdateCardChanges As UdpClient
    Private sendingUpdateCardChanges As UdpClient

    Private Const portRevealCards As Integer = 9659 'Or whatever port number you want to use
    Private receivingRevealCards As UdpClient
    Private sendingRevealCards As UdpClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Randomize()
        randomIntegerID = CInt(Int((1000000 * Rnd()) + 1000))
        thisPlayer.SetUniquePlayerID(randomIntegerID.ToString)
        thisPlayer.SetPlayerName("FreshBait" + randomIntegerID.ToString)
        PlayerList.Add(thisPlayer)
        PlayerName1.Text = "Your Card"
        InitializeSender()
        InitializeReceiver()
        Me.AcceptButton = SendButton
        ChatBox.Font = New Font(ChatBox.Font.FontFamily, thisPlayer.GetFontSize)
        Me.BackgroundImage = My.Resources.wooddark
        'Application Game Prep Below
        Card1.Image = My.Resources.back
        Card2.Image = My.Resources.back
        Card3.Image = My.Resources.back
        Card4.Image = My.Resources.back
        Card5.Image = My.Resources.back
        Card6.Image = My.Resources.back
        Card7.Image = My.Resources.back
        Card8.Image = My.Resources.back
        Card9.Image = My.Resources.back
        Card10.Image = My.Resources.back
        Card11.Image = My.Resources.back
        Card12.Image = My.Resources.back
        'assign list of player name labels
        ListOfPlayerNameLabels.Add(PlayerName1)
        ListOfPlayerNameLabels.Add(PlayerName2)
        ListOfPlayerNameLabels.Add(PlayerName3)
        ListOfPlayerNameLabels.Add(PlayerName4)
        ListOfPlayerNameLabels.Add(PlayerName5)
        ListOfPlayerNameLabels.Add(PlayerName6)
        ListOfPlayerNameLabels.Add(PlayerName7)
        ListOfPlayerNameLabels.Add(PlayerName8)
        ListOfPlayerNameLabels.Add(PlayerName9)

        'Assign the picture boxes
        ListOfPlayerCards.Add(Card1)
        ListOfPlayerCards.Add(Card2)
        ListOfPlayerCards.Add(Card3)
        ListOfPlayerCards.Add(Card4)
        ListOfPlayerCards.Add(Card8)
        ListOfPlayerCards.Add(Card9)
        ListOfPlayerCards.Add(Card10)
        ListOfPlayerCards.Add(Card11)
        ListOfPlayerCards.Add(Card12)
        'Middle Cards
        MiddleCardPicutreList.Add(Card5)
        MiddleCardPicutreList.Add(Card6)
        MiddleCardPicutreList.Add(Card7)
        'Add Characters to list
        CharacterList.Add("WereWolf")
        CharacterList.Add("WereWolf")
        CharacterList.Add("Seer")
        'CharacterList.Add("Hunter")
        CharacterList.Add("Robber")
        CharacterList.Add("TroubleMaker")
        TurnLabel.Text = ""
        'Prevents Window Flickers from resizing, on launch or moving
        Me.DoubleBuffered = True
        'Prevent Form from being to sized to small,
        Me.MinimumSize = New System.Drawing.Size(1600, 900)
        Me.Size = New System.Drawing.Size(200, 23)
        'Disable Looking at their own card
        Card1.Enabled = False
        VMF = New VoteMenuForm(PlayerList, AlreadyVoted)
    End Sub

    Private Sub InitializeSender()
        sendingClient = New UdpClient(broadcastAddress, port) 'Use broadcastAddress for sending data locally (on LAN), otherwise you'll need the public (or global) IP address of the machine that you want to send your data to
        sendingClientChat = New UdpClient(broadcastAddress, portChat)
        sendingClientPlayerInfo = New UdpClient(broadcastAddress, portPlayerInfo)
        sendingClientIsReady = New UdpClient(broadcastAddress, portIsReady)
        sendingAssignedCards = New UdpClient(broadcastAddress, portAssignedCards)
        sendingUpdateCardChanges = New UdpClient(broadcastAddress, portUpdateCardChanges)

        sendingClient.EnableBroadcast = True
        sendingClientChat.EnableBroadcast = True
        sendingClientPlayerInfo.EnableBroadcast = True
        sendingClientIsReady.EnableBroadcast = True
        sendingAssignedCards.EnableBroadcast = True
        sendingUpdateCardChanges.EnableBroadcast = True

        sendingClient.AllowNatTraversal(True)
        sendingClientChat.AllowNatTraversal(True)
        sendingClientPlayerInfo.AllowNatTraversal(True)
        sendingClientIsReady.AllowNatTraversal(True)
        sendingAssignedCards.AllowNatTraversal(True)
        sendingUpdateCardChanges.AllowNatTraversal(True)
    End Sub

    Private Sub InitializeReceiver()
        Dim endPoint = New System.Net.IPEndPoint(0, port)
        Dim endPointChat = New System.Net.IPEndPoint(0, portChat)
        Dim endPointPlayerInfo = New System.Net.IPEndPoint(0, portPlayerInfo)
        Dim endPointIsReady = New System.Net.IPEndPoint(0, portIsReady)
        Dim endPointAssigningCards = New System.Net.IPEndPoint(0, portAssignedCards)
        Dim endPointUpdateCardChanges = New System.Net.IPEndPoint(0, portUpdateCardChanges)
        'For Timer
        receivingClient = New System.Net.Sockets.UdpClient()
        receivingClient.ExclusiveAddressUse = False
        receivingClient.Client.SetSocketOption(Net.Sockets.SocketOptionLevel.Socket, Net.Sockets.SocketOptionName.ReuseAddress, True)
        receivingClient.Client.Bind(endPoint)
        receivingClient.AllowNatTraversal(True)
        ThreadPool.QueueUserWorkItem(AddressOf Receiver) 'Start listener on another thread
        'For Chat
        receivingClientChat = New System.Net.Sockets.UdpClient()
        receivingClientChat.ExclusiveAddressUse = False
        receivingClientChat.Client.SetSocketOption(Net.Sockets.SocketOptionLevel.Socket, Net.Sockets.SocketOptionName.ReuseAddress, True)
        receivingClientChat.Client.Bind(endPointChat)
        receivingClientChat.AllowNatTraversal(True)
        ThreadPool.QueueUserWorkItem(AddressOf RecieverChat) 'Start listener on another thread
        'For Sending Player Info
        receivingClientPlayerInfo = New System.Net.Sockets.UdpClient()
        receivingClientPlayerInfo.ExclusiveAddressUse = False
        receivingClientPlayerInfo.Client.SetSocketOption(Net.Sockets.SocketOptionLevel.Socket, Net.Sockets.SocketOptionName.ReuseAddress, True)
        receivingClientPlayerInfo.Client.Bind(endPointPlayerInfo)
        receivingClientPlayerInfo.AllowNatTraversal(True)
        ThreadPool.QueueUserWorkItem(AddressOf RecieverPlayerInfo) 'Start listener on another thread
        'For is ready?
        receivingClientIsReady = New System.Net.Sockets.UdpClient()
        receivingClientIsReady.ExclusiveAddressUse = False
        receivingClientIsReady.Client.SetSocketOption(Net.Sockets.SocketOptionLevel.Socket, Net.Sockets.SocketOptionName.ReuseAddress, True)
        receivingClientIsReady.Client.Bind(endPointIsReady)
        receivingClientIsReady.AllowNatTraversal(True)
        ThreadPool.QueueUserWorkItem(AddressOf RecieverIsReady) 'Start listener on another thread
        'For Assinging Cards over UDP
        receivingAssignedCards = New System.Net.Sockets.UdpClient()
        receivingAssignedCards.ExclusiveAddressUse = False
        receivingAssignedCards.Client.SetSocketOption(Net.Sockets.SocketOptionLevel.Socket, Net.Sockets.SocketOptionName.ReuseAddress, True)
        receivingAssignedCards.Client.Bind(endPointAssigningCards)
        receivingAssignedCards.AllowNatTraversal(True)
        ThreadPool.QueueUserWorkItem(AddressOf RecieverAssigningCards) 'Start listener on another thread
        'For Card Changes
        receivingUpdateCardChanges = New System.Net.Sockets.UdpClient()
        receivingUpdateCardChanges.ExclusiveAddressUse = False
        receivingUpdateCardChanges.Client.SetSocketOption(Net.Sockets.SocketOptionLevel.Socket, Net.Sockets.SocketOptionName.ReuseAddress, True)
        receivingUpdateCardChanges.Client.Bind(endPointUpdateCardChanges)
        receivingUpdateCardChanges.AllowNatTraversal(True)
        ThreadPool.QueueUserWorkItem(AddressOf RecieverUpdateCardChanges) 'Start listener on another thread

        Dim PlayerNum As String = thisPlayer.GetPlayerNumber.ToString()

        'Send First Connect (Initial) Player Data to anyone that is litsening 
        Dim PlayerData() As Byte = Encoding.ASCII.GetBytes(thisPlayer.GetPlayerName() + "<>" + thisPlayer.GetCardType + "<>" + PlayerNum + "<>" + randomIntegerID.ToString + "<>" + isMaster.ToString + "<>" + "InitialSend")
        sendingClientPlayerInfo.Send(PlayerData, PlayerData.Length)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendButton.Click
        Dim stringToSend As String = MessageInput.Text 'Assuming you have a textbox with the data you want to send
        If (Not String.IsNullOrEmpty(stringToSend)) Then
            Dim data() As Byte = Encoding.ASCII.GetBytes(thisPlayer.GetPlayerName & ": " & stringToSend)
            sendingClientChat.Send(data, data.Length)
        End If
    End Sub

    Private Sub RecieverPlayerInfo()

        Dim ClientID As Integer = 0

        Dim endPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, portPlayerInfo)

        Do While True 'Infinite Loop to keep listening for incomming data

            Dim data() As Byte
            data = receivingClientPlayerInfo.Receive(endPoint)
            Dim message As String = Encoding.ASCII.GetString(data) 'Recived data as string
            'Reset PlayerExists
            PlayerExists = False
            Dim StringArray() As String = Split(message, "<>")
            Dim PlayerCount = 0

            'Ignore messages from self
            If Not StringArray(3).Equals(randomIntegerID.ToString) Then
                recievedID = StringArray(3)

                For i As Integer = 0 To PlayerList.Count - 1
                    If PlayerList(i).GetUniquePlayerID.Equals(recievedID) Then
                        'If Player already exists in list don't add him again
                        PlayerExists = True
                        Exit For
                    Else
                        PlayerCount = PlayerCount + 1
                    End If
                Next

                'if player does not exist add him, sensitive area to have this given all the calls 
                If Not PlayerExists Then
                    Dim NewPlayer As Player = New Player(PlayerCount + 1, StringArray(1), StringArray(0))
                    NewPlayer.SetUniquePlayerID(recievedID)
                    UpdateTextBox(ChatBox, "Player " + StringArray(0) + " Joined.")
                    'UpdateTextBox(ChatBox, "Player Count is " + NewPlayer.GetPlayerNumber.ToString)
                    'UpdateTextBox(ChatBox, "Player ip is " + endPoint.ToString())

                    PlayerList.Add(NewPlayer)
                    'Enable a new card for said Player
                    For i As Integer = 0 To PlayerList.Count - 1
                        Me.Invoke(New EnableNewCardForPlayerDelegate(AddressOf EnableNewCardForPlayer), i)
                        Me.Invoke(New SetPlayerNameLabelsDelegate(AddressOf SetPlayerNameLabels))
                    Next
                End If

                'Determine Master Or Not and Resend Data back,
                'initial is to let people know that they connected, and resend is to let those who connected late know who exists
                If StringArray(5).Contains("InitialSend") Then
                    Dim PlayerNum As String = thisPlayer.GetPlayerNumber.ToString()
                    Dim PlayerData() As Byte = Encoding.ASCII.GetBytes(thisPlayer.GetPlayerName() + "<>" + thisPlayer.GetCardType + "<>" + PlayerNum + "<>" + randomIntegerID.ToString + "<>" + isMaster.ToString + "<>" + "ReSend")
                    sendingClientPlayerInfo.Send(PlayerData, PlayerData.Length)
                    'Everyone starts off as not being a master (false) so long as no one sends true then make themselves true
                End If
                If StringArray(5).Contains("ReSend") Then
                    isMasterList.Add(StringArray(4))
                    For i As Integer = 0 To isMasterList.Count - 1
                        If isMasterList(i).Contains("True") Then
                            isMaster = False
                            Exit For
                        Else
                            isMaster = True
                        End If
                    Next
                    If isMaster Then
                        'Update those who joined with RoundTime, in case round time is changed before they connected 
                        Dim PlayerData() As Byte = Encoding.ASCII.GetBytes(thisPlayer.GetPlayerName() + "<>" + thisPlayer.GetCardType + "<>" + "-" + "<>" + randomIntegerID.ToString + "<>" + isMaster.ToString + "<>" + "UpdateRoundTimeLimit" + "<>" + RoundTime)
                        sendingClientPlayerInfo.Send(PlayerData, PlayerData.Length)
                    End If
                End If
                'INdex out of range error when more than one user disconnects at the same time
                If StringArray(5).Contains("Disconnected") Then

                    For i As Integer = 1 To PlayerCount
                        If StringArray(3).Equals(PlayerList(i).GetUniquePlayerID) Then
                            UpdateTextBox(ChatBox, "Player " + PlayerList(i).GetPlayerName + " has disconnected.")
                            PlayerList.RemoveAt(i)
                            PlayerCount = PlayerCount - 1
                        End If
                    Next
                    For i As Integer = 0 To isReadyList.Count - 1
                        'player left and is no longer ready
                        If StringArray(3).Equals(isReadyList(i)) Then
                            isReadyList.RemoveAt(i)
                        End If
                    Next
                    If PlayerList.Count < 3 Then
                        UpdateReadyText(ReadyToStart, "Not Enough Players")
                    End If
                End If
            End If
            'Recieves any name changes
            If StringArray(5).Contains("NameChanged") Then
                For i As Integer = 0 To PlayerList.Count - 1
                    If PlayerList(i).GetUniquePlayerID.Equals(StringArray(3)) Then
                        PlayerList(i).SetPlayerName(StringArray(0))
                    End If
                Next
                Me.Invoke(New SetPlayerNameLabelsDelegate(AddressOf SetPlayerNameLabels))
            End If
            'Recieves Updated Round Time
            If StringArray(5).Contains("UpdateRoundTimeLimit") Then
                'if round time is not the same update otherwise ignore
                If Not StringArray(6).Equals(RoundTime) Then
                    RoundTime = StringArray(6)
                    UpdateTextBox(ChatBox, "Round Time Set to " + RoundTime + " minutes.")
                End If
            End If

            If StringArray(5).Contains("UpdateKillVotes") Then
                For i As Integer = 0 To PlayerList.Count - 1
                    If StringArray(3).Equals(PlayerList(i).GetUniquePlayerID) Then
                        PlayerList(i).AddVote()
                        If StringArray(4).Equals("Hunter") Then
                            PlayerList(i).SetHunterSights(True)
                        End If
                    End If
                Next
            End If

            If StringArray(5).Contains("UpdateVotesToEndRound") Then
                'Just call to increment the vote count
                Me.Invoke(New VoteToEndRoundDelegate(AddressOf VoteToEndRound))
            End If

            'Calls restart round method which essentially brings everything back to the original values
            If StringArray(5).Contains("RestartRound") Then
                Me.Invoke(New RestartRoundDelegate(AddressOf RestartRound))
                UpdateTextBox(ChatBox, "Master Restarted Round.")
            End If

            If StringArray(5).Contains("UpdateCharacterList") Then
                CharacterList.Add(StringArray(6))
                UpdateTextBox(ChatBox, "Master Added " + StringArray(6) + " Role.")
            End If

            'if/when we have enough player we can enable the ready option
            If PlayerList.Count >= 3 And CharacterList.Count = PlayerList.Count + 3 Then
                UpdateReadyText(ReadyToStart, "Ready To Start?")
            ElseIf CharacterList.Count < PlayerList.Count + 3 Then
                UpdateReadyText(ReadyToStart, "Not Enough Roles Added")
            ElseIf PlayerList.Count < 3 Then
                UpdateReadyText(ReadyToStart, "Not Enough Players")
            End If

            'Since we have a master tell clients who is  master, but do it once on InitialSend
            If isMaster And StringArray(5).Contains("InitialSend") Then
                UpdateTextBox(ChatBox, "You are Master.")
                Me.Invoke(New SetRestartButtonDelegate(AddressOf SetRestartRoundButton), True)
                RestartRoundButton.Enabled = True
                Dim data2() As Byte = Encoding.ASCII.GetBytes(thisPlayer.GetPlayerName & " is Master.")
                sendingClientChat.Send(data2, data2.Length)
            Else

            End If

        Loop
    End Sub
    Public Sub EnableNewCardForPlayer(ByVal i As Integer)
        ListOfPlayerCards(i).Visible = True
        ListOfPlayerNameLabels(i).Visible = True
    End Sub
    Public Sub SetRestartRoundButton(ByVal Enabled As Boolean)
        RestartRoundButton.Enabled = Enabled
    End Sub
    Public Sub NameChanged()
        Dim PlayerNum As String = thisPlayer.GetPlayerNumber.ToString()
        Dim PlayerData() As Byte = Encoding.ASCII.GetBytes(thisPlayer.GetPlayerName() + "<>" + thisPlayer.GetCardType + "<>" + PlayerNum + "<>" + randomIntegerID.ToString + "<>" + isMaster.ToString + "<>" + "NameChanged")
        sendingClientPlayerInfo.Send(PlayerData, PlayerData.Length)
    End Sub
    Private Sub RecieverChat()

        Dim endPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, portChat)
        Do While True 'Infinite Loop to keep listening for incomming data
            Dim data() As Byte
            data = receivingClientChat.Receive(endPoint)
            Dim message As String = Encoding.ASCII.GetString(data) 'Recived data as string

            UpdateTextBox(ChatBox, message)
        Loop
    End Sub
    Private Sub Receiver()
        Dim endPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, port) 'Listen for incoming data from any IP on the specified port

        Do While True 'Infinite Loop to keep listening for incomming data
            Dim data() As Byte
            data = receivingClient.Receive(endPoint)
            Dim message As String = Encoding.ASCII.GetString(data) 'Recived data as string

            If isMaster Then
                'If we are master then we have to send to everyone people who connect
                'GameTime.Start()
                'Me.Invoke(New EnableTimerDelegate(AddressOf EnableTimerDlg), New Object() {True})
            End If

            If Not isMaster Then
                'Client
                Me.Invoke(New UpdateTimerLabelText(AddressOf UpdateTimerTextDlg), message)
            End If

        Loop
    End Sub
    Private Sub UpdateTextBox(ByVal txtBox As RichTextBox, ByVal value As String)
        ''//Basically ask the textbox if we need to invoke
        If ChatBox.InvokeRequired Then
            'make delegate
            ChatBox.Invoke(New UpdateTextBoxDelegate(AddressOf UpdateTextBox), txtBox, value)
        Else

            Dim parseValue() As String
            parseValue = Split(value, ": ")
            'ChatBox.Select(ChatBox.TextLength, 0)
            If ChatBox.TextLength > 0 Then
                Pos = ChatBox.GetFirstCharIndexFromLine(ChatBox.Lines.Count - 1)
                If ChatBox.Find(parseValue(0), Pos, RichTextBoxFinds.None) > 0 Then

                    Dim r As Integer = CInt(Int((255 * Rnd()) + 1))
                    Dim b As Integer = CInt(Int((255 * Rnd()) + 1))
                    Dim g As Integer = CInt(Int((255 * Rnd()) + 1))
                    Dim randomColor As Color = Color.FromArgb(r, b, g)
                    ChatBox.SelectionColor = randomColor
                End If
            End If

            ChatBox.AppendText(value & vbCrLf)
            ChatBox.ScrollToCaret()
            'Clear Message Input Text Box'
            MessageInput.Text = "" 'Pos.ToString()
            Pos = 0
        End If
    End Sub
    Private Sub UpdateReadyText(ByVal ReadyCheckBox As CheckBox, ByVal value As String)
        If ReadyCheckBox.InvokeRequired Then
            'make delegate
            ReadyToStart.Invoke(New UpdateReadyMessage(AddressOf UpdateReadyText), ReadyCheckBox, value)
        Else
            If value.Equals("Ready To Start?") Then
                ReadyCheckBox.Enabled = True
                ReadyCheckBox.Text = value
            ElseIf value.Equals("Not Enough Players") Then
                ReadyCheckBox.Enabled = False
                ReadyCheckBox.Checked = False
                ReadyCheckBox.Text = value
            ElseIf value.Equals("Not Enough Roles Added") Then
                ReadyCheckBox.Enabled = False
                ReadyCheckBox.Checked = False
                ReadyCheckBox.Text = value
            End If

        End If
    End Sub
    Private Sub WereWolfMiddleCardCheckLogic(ByVal cardNum As Integer)
        If InitialRole.Equals("WereWolf") And Not SawCard And OneWereWolf And TurnAllowed Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            'PlaySound("G:\Click.mp3", UIntPtr.Zero, &H20000 Or &H1)
            SawCard = True
            'Reveal the number middle middle cards card when clicked
            RevealMiddleCard(cardNum)
        End If
    End Sub
    Private Sub SeerCardCheckTwoLogic(ByVal cardNum As Integer)
        If InitialRole.Equals("Seer") And Not SawCard And TurnAllowed And CardCount < 2 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            CardCount = CardCount + 1
            'Reveal the number middle middle cards card when clicked
            RevealMiddleCard(cardNum)
        End If

        If CardCount = 2 Then
            SawCard = True
        End If

    End Sub
    Private Sub SeerCardCheckLogic(ByVal cardNum As Integer)
        'How many the seer can see

        If InitialRole.Equals("Seer") And Not SawCard And TurnAllowed Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            SawCard = True
            'Reveal the number middle middle cards card when clicked
            RevealPlayerCard(cardNum)
        End If

    End Sub
    Private Sub InsomniacCardCheckLogic(ByVal cardNum As Integer)
        If InitialRole.Equals("Insomniac") And Not SawCard And TurnAllowed Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            SawCard = True
            RevealPlayerCard(cardNum)
        End If
    End Sub
    Private Sub RobberCardSwitchLogic(ByVal cardNum As Integer)
        If InitialRole.Equals("Robber") And TurnAllowed Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            TurnAllowed = False 'Turn is over once Robber picks a person to swap with
            'Reveal cards first
            RevealPlayerCard(cardNum)
            'Swap player role's logic
            RobbersNewRole = PlayerList(cardNum).GetCardType
            PlayerList(cardNum).SetPlayerCardType(thisPlayer.GetCardType)
            thisPlayer.SetPlayerCardType(RobbersNewRole)
            'send out New Robber ID and then Robberes New identity with Id 0 - 1 2  
            Dim data() As Byte = Encoding.ASCII.GetBytes(PlayerList(cardNum).GetCardType + "<>" + PlayerList(cardNum).GetUniquePlayerID + "<>" + thisPlayer.GetCardType + "<>" + thisPlayer.GetUniquePlayerID + "<>" + "PlayerSwap")
            sendingUpdateCardChanges.Send(data, data.Length)

        End If
    End Sub
    Private Sub TroubleMakerCardSwitchLogic(ByVal cardNum As Integer)

        If InitialRole.Equals("TroubleMaker") And TurnAllowed Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            If TMFirstPickIndex > 0 Then
                TurnAllowed = False
                'Means we have picked two people to swap, same swap logic for robber, same process too
                Dim TempRole = PlayerList(cardNum).GetCardType
                PlayerList(cardNum).SetPlayerCardType(PlayerList(TMFirstPickIndex).GetCardType)
                PlayerList(TMFirstPickIndex).SetPlayerCardType(TempRole)
                Dim data() As Byte = Encoding.ASCII.GetBytes(PlayerList(cardNum).GetCardType + "<>" + PlayerList(cardNum).GetUniquePlayerID + "<>" + PlayerList(TMFirstPickIndex).GetCardType + "<>" + PlayerList(TMFirstPickIndex).GetUniquePlayerID + "<>" + "PlayerSwap")
                sendingUpdateCardChanges.Send(data, data.Length)
            End If
            TMFirstPickIndex = cardNum
        End If
    End Sub
    Private Sub DrunkCardSwitchLogic(ByVal cardNum As Integer)
        If InitialRole.Equals("Drunk") And TurnAllowed Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            TurnAllowed = False
            'Swap role's logic
            DrunksNewRole = MiddleCardsList(cardNum)
            MiddleCardsList(cardNum) = thisPlayer.GetCardType
            thisPlayer.SetPlayerCardType(DrunksNewRole)
            'send out New Robber ID and then Robberes New identity with Id 0 - 1 2  
            Dim data() As Byte = Encoding.ASCII.GetBytes(MiddleCardsList(cardNum).ToString + "<>" + cardNum.ToString + "<>" + thisPlayer.GetCardType + "<>" + thisPlayer.GetUniquePlayerID + "<>" + "MiddleSwap")
            sendingUpdateCardChanges.Send(data, data.Length)

        End If
    End Sub
    Private Sub Card5_Click(sender As Object, e As EventArgs) Handles Card5.Click
        WereWolfMiddleCardCheckLogic(0)
        SeerCardCheckTwoLogic(0)
        DrunkCardSwitchLogic(0)
    End Sub
    Private Sub Card6_Click(sender As Object, e As EventArgs) Handles Card6.Click
        WereWolfMiddleCardCheckLogic(1)
        SeerCardCheckTwoLogic(1)
        DrunkCardSwitchLogic(1)
    End Sub
    Private Sub Card7_Click(sender As Object, e As EventArgs) Handles Card7.Click
        WereWolfMiddleCardCheckLogic(2)
        SeerCardCheckTwoLogic(2)
        DrunkCardSwitchLogic(2)
    End Sub
    Private Sub Card12_Click(sender As Object, e As EventArgs) Handles Card12.Click
        PlayerCardClickLogic(8)
    End Sub
    Private Sub Card11_Click(sender As Object, e As EventArgs) Handles Card11.Click
        PlayerCardClickLogic(7)
    End Sub
    Private Sub Card10_Click(sender As Object, e As EventArgs) Handles Card10.Click
        PlayerCardClickLogic(6)
    End Sub
    Private Sub Card9_Click(sender As Object, e As EventArgs) Handles Card9.Click
        PlayerCardClickLogic(5)
    End Sub
    Private Sub Card8_Click(sender As Object, e As EventArgs) Handles Card8.Click
        PlayerCardClickLogic(4)
    End Sub
    Private Sub Card4_Click(sender As Object, e As EventArgs) Handles Card4.Click
        PlayerCardClickLogic(3)
    End Sub
    Private Sub Card3_Click(sender As Object, e As EventArgs) Handles Card3.Click
        PlayerCardClickLogic(2)
    End Sub
    Private Sub Card2_Click(sender As Object, e As EventArgs) Handles Card2.Click
        PlayerCardClickLogic(1)
    End Sub
    Private Sub PlayerCardClickLogic(ByVal CardNum As Integer)
        SeerCardCheckLogic(CardNum)
        RobberCardSwitchLogic(CardNum)
        TroubleMakerCardSwitchLogic(CardNum)

    End Sub
    Private Sub Card1_Click(sender As Object, e As EventArgs) Handles Card1.Click
        InsomniacCardCheckLogic(0)
        Beep()
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        Dim SF As SettingsForm = New SettingsForm(thisPlayer)
        SF.Text = "Game Settings"
        SF.Show()
        Settings.Enabled = False
    End Sub
    Public Sub UpdateSettings(ByVal audio As Boolean)
        ChatBox.Font = New Font(ChatBox.Font.FontFamily, thisPlayer.GetFontSize())
        EnableAudio = audio
    End Sub
    Public Sub EnableSettingsButton()
        Settings.Enabled = True
    End Sub
    Public ReadOnly Property GetAudioEnabledBool() As Boolean
        Get
            Return EnableAudio
        End Get
    End Property
    Public ReadOnly Property GetPlayerList() As List(Of Player)
        Get
            Return PlayerList
        End Get
    End Property
    Private Sub TimerLabel_Click(sender As Object, e As EventArgs) Handles TimerLabel.Click

    End Sub
    'Only Master Runs Ticker
    Private Sub GameTime_Tick(sender As Object, e As EventArgs) Handles GameTime.Tick

        Time = Time + 1
        Dim Sec As Integer = Time Mod 60
        Dim Min As Integer = ((Time - Sec) / 60) Mod 60
        Dim timeData() As Byte
        TimerLabel.Text = Min.ToString() + ":" + Sec.ToString()
        If isMaster Then
            timeData = Encoding.ASCII.GetBytes(TimerLabel.Text)
            sendingClient.Send(timeData, timeData.Length)
        End If
        BeginRound()


    End Sub
    Private Sub EnableTimerDlg(ByVal Enable As Boolean)
        GameTime.Enabled = Enable
    End Sub
    'Only Clients Update Timer through Text sent by master
    Private Sub UpdateTimerTextDlg(ByVal timerText As String)
        TimerLabel.Text = timerText
        BeginRound()

    End Sub
    Private Sub BeginRound()
        'Check Timer Text to Trigger Events at certain times
        If Not TimerLabel.Text.Contains("Timer") Then
            Dim StringTime() As String = Split(TimerLabel.Text, ":")

            'Starts Audio And Hides initial card
            StartRoundSetup(StringTime(1))
            'Only do turns during the night
            If Night Then
                'Enable Turn Display
                TurnLabel.Visible = True
                WereWolfTurnLogic()
                MinionTurnLogic()
                SeerTurnLogic()
                RobberTurnLogic()
                TroubleMakerTurnLogic()
                DrunkTurnLogic()
                InsomniacTurnLogic()
                EndOfTurnsLogic()
            ElseIf Not Night And RoundStarted Then
                Me.BackgroundImage = My.Resources.wooddark
                TurnLabel.Text = "Night is over, day is among you."
                TurnLabel.ForeColor = Color.WhiteSmoke
                RoundOverCheck()
            End If
            If isMaster And GamePlayerCount < PlayerList.Count And Not StartRound Then
                'Someone disconnected pause/stop or restart the game
                EnableTimerDlg(False)
            End If
        End If
    End Sub
    Private Sub StartRoundSetup(ByVal SecondsPassed As String)
        If SecondsPassed.Equals("5") And StartRound Then
            'Before we even start round assign each turn their time to play
            TurnTimeCalcuator()
            StartRound = False
            RoundStarted = True
            GamePlayerCount = PlayerList.Count
            VoteMenuButton.Enabled = True
            Card1.Image = My.Resources.back
            If EnableAudio Then
                My.Computer.Audio.Play(My.Resources.background_horror, AudioPlayMode.BackgroundLoop)
            End If
            Me.BackgroundImage = My.Resources.night
            Night = True
        End If
        'If later user disables the audio stop it
        If Not EnableAudio Then
            My.Computer.Audio.Stop()
        End If
    End Sub
    Private Sub HideAllCards()
        For i As Integer = 0 To PlayerList.Count - 1
            ListOfPlayerCards(i).Image = My.Resources.back
        Next
        For i As Integer = 0 To MiddleCardsList.Count - 1
            MiddleCardPicutreList(i).Image = My.Resources.back
        Next
    End Sub
    Private Sub TurnTimeCalcuator()

        'Look through CharacterList to determine which are in play and then each rolls time is dependent on the amount of rolls that play before it
        'We use the bools to check to make sure we ignore any double cards that might be in play
        For i As Integer = 0 To CharacterList.Count - 1
            If CharacterList(i).Equals("WereWolf") And Not WWFound Then
                RolePlayTime.Add("WereWolf", TurnTime)
                TimeMulti = TimeMulti + 1
                WWFound = True
                Exit For
            End If
        Next
        For i As Integer = 0 To CharacterList.Count - 1
            If CharacterList(i).Equals("Minion") And Not MFound Then
                RolePlayTime.Add("Minion", TurnTime + (5 * TimeMulti))
                TimeMulti = TimeMulti + 1
                MFound = True
                Exit For
            End If
        Next
        For i As Integer = 0 To CharacterList.Count - 1
            If CharacterList(i).Equals("Seer") And Not SFound Then
                RolePlayTime.Add("Seer", TurnTime + (5 * TimeMulti))
                TimeMulti = TimeMulti + 1
                SFound = True
                Exit For
            End If
        Next
        For i As Integer = 0 To CharacterList.Count - 1
            If CharacterList(i).Equals("Robber") And Not RFound Then
                RolePlayTime.Add("Robber", TurnTime + (5 * TimeMulti))
                TimeMulti = TimeMulti + 1
                RFound = True
                Exit For
            End If
        Next
        For i As Integer = 0 To CharacterList.Count - 1
            If CharacterList(i).Equals("TroubleMaker") And Not TMFound Then
                RolePlayTime.Add("TroubleMaker", TurnTime + (5 * TimeMulti))
                TimeMulti = TimeMulti + 1
                TMFound = True
                Exit For
            End If
        Next
        For i As Integer = 0 To CharacterList.Count - 1
            If CharacterList(i).Equals("Drunk") And Not DFound Then
                RolePlayTime.Add("Drunk", TurnTime + (5 * TimeMulti))
                TimeMulti = TimeMulti + 1
                DFound = True
                Exit For
            End If
        Next
        For i As Integer = 0 To CharacterList.Count - 1
            If CharacterList(i).Equals("Insomniac") And Not IFound Then
                RolePlayTime.Add("Insomniac", TurnTime + (5 * TimeMulti))
                TimeMulti = TimeMulti + 1
                IFound = True
                Exit For
            End If
        Next

    End Sub
    Private Sub EndOfTurnLogic()
        TurnAllowed = False
        Card1.Enabled = False
        HideAllCards()
    End Sub
    Private Sub WereWolfTurnLogic()
        'Check Timer Text to Trigger Events at certain times
        Dim StringTime() As String = Split(TimerLabel.Text, ":")
        'Werewolfs go first
        If StringTime(1).Equals(RolePlayTime.Item("WereWolf").ToString) Then
            TurnLabel.Text = "Werewolfs may be prowling..."
            'Only WereWolfs get to see other WereWolfs
            If InitialRole.Contains("WereWolf") Then
                TurnAllowed = True

                For i As Integer = 1 To PlayerList.Count - 1
                    If InitialRole.Contains(PlayerList(i).GetCardType) Then
                        'If we are the same reveal card (WereWolf) show it
                        ListOfPlayerCards(i).Image = My.Resources.w
                        'since a card was revealed 
                        SawCard = True
                    End If
                Next
            End If
        End If

        'Hide all Cards at specified time
        If Convert.ToInt32(StringTime(1)) >= (RolePlayTime.Item("WereWolf") + 5) And InitialRole.Equals("WereWolf") Then
            EndOfTurnLogic()
        End If

    End Sub
    Private Sub MinionTurnLogic()
        'Check Timer Text to Trigger Events at certain times
        Dim StringTime() As String = Split(TimerLabel.Text, ":")
        Dim thisRolesTimeToPlay As Integer
        'Werewolfs go first
        If RolePlayTime.TryGetValue("Minion", thisRolesTimeToPlay) Then

            If StringTime(1).Equals(thisRolesTimeToPlay.ToString) Then
                TurnLabel.Text = "Minions may be looking for beastly allies..."
                'Minion gets to see other WereWolfs too
                If InitialRole.Contains("Minion") Then
                    TurnAllowed = True

                    For i As Integer = 1 To PlayerList.Count - 1
                        If "WereWolf".Contains(PlayerList(i).GetCardType) Then
                            'If we are the same reveal card (WereWolf) show it
                            ListOfPlayerCards(i).Image = My.Resources.w
                            'since a card was revealed 
                            SawCard = True
                        End If
                    Next
                End If
            End If

            'Hide all Cards at specified time
            If Convert.ToInt32(StringTime(1)) >= (thisRolesTimeToPlay + 5) And InitialRole.Equals("Minion") Then
                EndOfTurnLogic()
            End If

        End If

    End Sub
    Private Sub SeerTurnLogic()

        Dim StringTime() As String = Split(TimerLabel.Text, ":")
        If StringTime(1).Equals(RolePlayTime.Item("Seer").ToString) Then

            TurnLabel.Text = "Seer may be seeing..."

            If InitialRole.Equals("Seer") Then
                TurnAllowed = True
            End If
        End If
        'Hide Cards again
        If Convert.ToInt32(StringTime(1)) >= (RolePlayTime.Item("Seer") + 5) And InitialRole.Equals("Seer") Then
            EndOfTurnLogic()
        End If
    End Sub

    Private Sub RobberTurnLogic()

        Dim StringTime() As String = Split(TimerLabel.Text, ":")
        'When Robbers turn is up, he can make the switches
        If StringTime(1).Equals(RolePlayTime.Item("Robber").ToString) Then
            TurnLabel.Text = "Robber may be robbing..."

            If InitialRole.Equals("Robber") Then
                TurnAllowed = True
            End If
        End If
        'Hide Cards again, since robber changes role we have to check for the role he becomes
        If Convert.ToInt32(StringTime(1)) >= ((RolePlayTime.Item("Robber")) + 5) And InitialRole.Equals("Robber") Then
            EndOfTurnLogic()
        End If
    End Sub
    Private Sub TroubleMakerTurnLogic()

        Dim StringTime() As String = Split(TimerLabel.Text, ":")
        'When Robbers turn is up, he can make the switches
        If StringTime(1).Equals(RolePlayTime.Item("TroubleMaker").ToString) Then
            TurnLabel.Text = "Someone may be causing trouble..."
            If InitialRole.Equals("TroubleMaker") Then
                TurnAllowed = True
            End If
        End If

        If Convert.ToInt32(StringTime(1)) >= ((RolePlayTime.Item("TroubleMaker")) + 5) And InitialRole.Equals("TroubleMaker") Then
            EndOfTurnLogic()
        End If
    End Sub
    Private Sub DrunkTurnLogic()
        Dim StringTime() As String = Split(TimerLabel.Text, ":")
        Dim thisRolesTimeToPlay As Integer
        If RolePlayTime.TryGetValue("Drunk", thisRolesTimeToPlay) Then
            If StringTime(1).Equals(thisRolesTimeToPlay.ToString) Then
                TurnLabel.Text = "Drunk may be stumbling around..."
                If InitialRole.Equals("Drunk") Then
                    TurnAllowed = True
                End If
            End If

            If Convert.ToInt32(StringTime(1)) >= (thisRolesTimeToPlay + 5) And InitialRole.Equals("Drunk") Then
                EndOfTurnLogic()
            End If
        End If

    End Sub
    Private Sub InsomniacTurnLogic()
        Dim StringTime() As String = Split(TimerLabel.Text, ":")
        Dim thisRolesTimeToPlay As Integer
        If RolePlayTime.TryGetValue("Insomniac", thisRolesTimeToPlay) Then
            If StringTime(1).Equals(thisRolesTimeToPlay.ToString) Then
                TurnLabel.Text = "Insomniac may be waking up..."
                If InitialRole.Equals("Insomniac") Then
                    TurnAllowed = True
                    'Enable card so Insomniac can click their card
                    Card1.Enabled = True
                End If
            End If

            If Convert.ToInt32(StringTime(1)) >= (thisRolesTimeToPlay + 5) And InitialRole.Equals("Insomniac") Then
                EndOfTurnLogic()
            End If
        End If

    End Sub
    Private Sub EndOfTurnsLogic()
        Dim StringTime() As String = Split(TimerLabel.Text, ":")
        'Round time is last values added to dictinoary plus 5 sesconds after
        If StringTime(1).Equals((RolePlayTime.Values.Last + 5).ToString) Then
            'Me.Invoke(New RevealAllCardsDelegate(AddressOf RevealAllCards))
            'Reset Time, since its called for both server and client master will get updated to update all clients
            Time = 0
            'So turns don't happen again
            Night = False
            ReverseTimer = True
        End If
    End Sub
    Private Sub RoundOverCheck()
        Dim StringTime() As String = Split(TimerLabel.Text, ":")
        Dim HunterDied As Boolean = False
        If StringTime(0).Equals(RoundTime.ToString()) Or EndRoundVotePassed Then
            Me.Invoke(New RevealAllCardsDelegate(AddressOf RevealAllCards))
            'Prevent any more votes from being casted
            VMF.Disable_CheckBoxes()
            'First find those with greatest or equal votes add them to the to die list
            Dim listOfPlayersWhoDie As New List(Of Player)
            Dim tempPlayer = New Player(0, "", "")
            'Find the perosn with the most votes
            For i As Integer = 0 To PlayerList.Count - 1
                If PlayerList(i).GetVoteCount > tempPlayer.GetVoteCount Then
                    tempPlayer = PlayerList(i)

                End If
            Next
            'then check to see if any other votes equal the person with the most and add all those ( to handle ties)
            For i As Integer = 0 To PlayerList.Count - 1
                If PlayerList(i).GetVoteCount.Equals(tempPlayer.GetVoteCount) Then
                    listOfPlayersWhoDie.Add(PlayerList(i))
                    'UpdateTextBox(ChatBox, "Added, " + PlayerList(i).GetPlayerName)
                End If
            Next
            'Now Check to see if Hunter Dies and if so kill the person who was in his sights
            For i As Integer = 0 To listOfPlayersWhoDie.Count - 1
                If listOfPlayersWhoDie(i).GetCardType.Equals("Hunter") Then
                    HunterDied = True
                    Exit For
                End If
            Next
            'Add whomever the hunter tagged to the to die list
            For i As Integer = 0 To PlayerList.Count - 1
                If PlayerList(i).GetHunterSights And HunterDied Then
                    listOfPlayersWhoDie.Add(PlayerList(i))
                    Exit For
                End If
            Next
            'then show who died on screen
            For i As Integer = 0 To listOfPlayersWhoDie.Count - 1
                UpdateTextBox(ChatBox, listOfPlayersWhoDie(i).GetPlayerName + " Got Shot!")
                'Optionally we could update a label with the information
                'TurnLabel.Text = TurnLabel.Text + vbNewLine + listOfPlayersWhoDie(i).GetPlayerName + " Got Shot!"
            Next
            TurnLabel.Text = "Round Over, See Chat For Results!"
            'Stop Timer
            If isMaster Then
                GameTime.Enabled = False
            End If
        End If
    End Sub
    Public Sub SetRoundTime(ByVal time As String)
        RoundTime = time
        'Send to other players the new round time
        Dim PlayerData() As Byte = Encoding.ASCII.GetBytes(thisPlayer.GetPlayerName() + "<>" + thisPlayer.GetCardType + "<>" + "-" + "<>" + randomIntegerID.ToString + "<>" + isMaster.ToString + "<>" + "UpdateRoundTimeLimit" + "<>" + time)
        sendingClientPlayerInfo.Send(PlayerData, PlayerData.Length)
    End Sub
    Public ReadOnly Property GetRoundTime()
        Get
            Return RoundTime
        End Get
    End Property
    Public ReadOnly Property GetIsMaster()
        Get
            Return isMaster
        End Get
    End Property
    Private Sub ReadyToStart_CheckedChanged(sender As Object, e As EventArgs) Handles ReadyToStart.CheckedChanged

        Dim stringToSend As String = thisPlayer.GetPlayerName() + " is Ready." + "<>" + randomIntegerID.ToString()
        If ReadyToStart.Checked Then

            Dim data() As Byte = Encoding.ASCII.GetBytes(stringToSend)
            sendingClientIsReady.Send(data, data.Length)
            ReadyToStart.Enabled = False
        End If
    End Sub
    'We Assign Cards whenever is ready, Master Assigns and updates everyone
    Private Sub RecieverIsReady()

        Dim endPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, portIsReady)
        Do While True 'Infinite Loop to keep listening for incomming data
            Dim data() As Byte
            data = receivingClientIsReady.Receive(endPoint)
            Dim message As String = Encoding.ASCII.GetString(data) 'Recived data as string
            Dim StringArray() As String = Split(message, "<>")

            UpdateTextBox(ChatBox, StringArray(0))
            'If We are master and everyone is ready start the timer/Game
            If isMaster Then
                'We need  a new list to mess with so that Calculating Turns can use the original list before we remove roles 
                Dim RoleList As New List(Of String)(CharacterList)
                isReadyList.Add(StringArray(1))
                'UpdateTextBox(ChatBox, "DEBUG " + isReadyList.Count.ToString)
                'More than 3 Players and same amounnt of player that have joined our ready we can start timer
                If isReadyList.Count >= 3 And isReadyList.Count = PlayerList.Count Then

                    'UpdateTextBox(ChatBox, "ALL READY " + isReadyList.Count.ToString)
                    'Prep Random Seeds
                    Randomize()
                    Dim r As Random = New Random()

                    Dim RandomListOfCharacters As New List(Of String)
                    'randomize a new list before randomly picking from the list to make things a bit more random
                    For i As Integer = 0 To isReadyList.Count - 1

                        Dim randomChar As Integer = r.Next(0, RoleList.Count - 1) 'CInt(Int((RoleList.Count - 1 * Rnd()) + 0))
                        RandomListOfCharacters.Add(RoleList(randomChar))
                        RoleList.RemoveAt(randomChar)

                    Next

                    Dim r2 As Random = New Random()
                    'Send a message for each player
                    For i As Integer = 0 To isReadyList.Count - 1

                        Dim randomChar As Integer = r2.Next(0, RandomListOfCharacters.Count - 1)
                        Dim stringToSend As String = RandomListOfCharacters(randomChar) + "<>" + isReadyList(i)
                        Dim data2() As Byte = Encoding.ASCII.GetBytes(stringToSend)
                        sendingAssignedCards.Send(data2, data2.Length)
                        RandomListOfCharacters.RemoveAt(randomChar)
                    Next

                    'assign the last 3 remaining middle cards
                    For j As Integer = 1 To 3

                        Dim randomChar As Integer = r.Next(0, RoleList.Count - 1) 'Dim randomChar As Integer = CInt(Int((RoleList.Count - 1 * Rnd()) + 0))
                        Dim stringToSend As String = RoleList(randomChar) + "<>" + j.ToString()
                        Dim data2() As Byte = Encoding.ASCII.GetBytes(stringToSend)
                        sendingAssignedCards.Send(data2, data2.Length)
                        RoleList.RemoveAt(randomChar)
                    Next
                End If
            End If
        Loop
    End Sub

    Public Sub RecieverAssigningCards()

        Dim endPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, portAssignedCards)
        Do While True 'Infinite Loop to keep listening for incomming data
            Dim data() As Byte
            data = receivingAssignedCards.Receive(endPoint)
            Dim message As String = Encoding.ASCII.GetString(data) 'Recived data as string
            Dim StringArray() As String = Split(message, "<>")
            'at 0 player type at index 1 player id or middle card
            For i As Integer = 0 To PlayerList.Count - 1
                If PlayerList(i).GetUniquePlayerID.Equals(StringArray(1)) Then
                    PlayerList(i).SetPlayerCardType(StringArray(0))
                End If
                thisPlayer = PlayerList(0)
                'Set an initalRole to refer back to since cards may get switched
                InitialRole = thisPlayer.GetCardType
            Next

            'Assign Middle Cards
            For i As Integer = 0 To 2
                If StringArray(1).Equals((i + 1).ToString) Then
                    MiddleCardsList.Add(StringArray(0))
                    'UpdateTextBox(ChatBox, "Middle Card " + (i + 1).ToString + " is " + MiddleCardsList(i))
                End If

            Next

            'To know if we have one werewolf or not for other werewolfs to know
            For i As Integer = 0 To MiddleCardsList.Count - 1
                If MiddleCardsList(i).Contains("WereWolf") Then
                    OneWereWolf = True
                End If
            Next
            'Call GameSetup Logic To Show Player Cards
            Me.Invoke(New GameSetUpDelegate(AddressOf GameSetUp), thisPlayer.GetCardType)
        Loop
    End Sub
    Public Sub GameSetUp(ByVal type As String)

        Select Case type
            Case "WereWolf"
                Card1.Image = My.Resources.w
            Case "Minion"
                Card1.Image = My.Resources.Minion
            Case "Villager"
                Card1.Image = My.Resources.v
            Case "TroubleMaker"
                Card1.Image = My.Resources.t
            Case "Robber"
                Card1.Image = My.Resources.r
            Case "Seer"
                Card1.Image = My.Resources.s
            Case "Drunk"
                Card1.Image = My.Resources.drunk
            Case "Insomniac"
                Card1.Image = My.Resources.insomniac
            Case "Hunter"
                Card1.Image = My.Resources.hunter
            Case "Tanner"
                Card1.Image = My.Resources.tanner
        End Select

        If isMaster Then
            Me.Invoke(New EnableTimerDelegate(AddressOf EnableTimerDlg), New Object() {True})
        End If

        'if We have a player for the card set player name for card
        Me.Invoke(New SetPlayerNameLabelsDelegate(AddressOf SetPlayerNameLabels))
    End Sub
    Private Sub SetPlayerNameLabels()
        For i As Integer = 1 To PlayerList.Count - 1
            If Not PlayerList(i) Is Nothing Then
                ListOfPlayerNameLabels(i).Text = PlayerList(i).GetPlayerName
            End If
        Next
    End Sub
    Private Sub RecieverUpdateCardChanges()
        Dim endPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, portUpdateCardChanges)
        Do While True 'Infinite Loop to keep listening for incomming data
            Dim data() As Byte
            data = receivingUpdateCardChanges.Receive(endPoint)
            Dim message As String = Encoding.ASCII.GetString(data) 'Recived data as string
            Dim StringArray() As String = Split(message, "<>")

            Dim OriginalRole As String = StringArray(0)
            Dim NewID As String = StringArray(1)
            Dim NewRole As String = StringArray(2)
            Dim OriginalID As String = StringArray(3)
            Dim SwapType As String = StringArray(4)
            If SwapType.Equals("PlayerSwap") Then
                For i As Integer = 0 To PlayerList.Count - 1
                    If PlayerList(i).GetUniquePlayerID.Equals(OriginalID) Then
                        PlayerList(i).SetPlayerCardType(NewRole)
                    End If
                    If PlayerList(i).GetUniquePlayerID.Equals(NewID) Then
                        PlayerList(i).SetPlayerCardType(OriginalRole)
                    End If
                Next
            ElseIf SwapType.Equals("MiddleSwap") Then
                For i As Integer = 0 To PlayerList.Count - 1
                    If PlayerList(i).GetUniquePlayerID.Equals(OriginalID) Then
                        PlayerList(i).SetPlayerCardType(NewRole)
                    End If
                Next
                MiddleCardsList(NewID) = OriginalRole
            End If

        Loop
    End Sub

    Public Sub RevealAllCards()
        For i As Integer = 0 To PlayerList.Count - 1
            RevealPlayerCard(i)
        Next
        'Do middle Cards
        For i As Integer = 0 To MiddleCardsList.Count - 1
            RevealMiddleCard(i)
        Next
    End Sub

    Private Sub RevealPlayerCard(ByVal i As Integer)

        If PlayerList(i).GetCardType.Contains("WereWolf") Then
            ListOfPlayerCards(i).Image = My.Resources.w
        ElseIf PlayerList(i).GetCardType.Contains("Seer") Then
            ListOfPlayerCards(i).Image = My.Resources.s
        ElseIf PlayerList(i).GetCardType.Contains("Villager") Then
            ListOfPlayerCards(i).Image = My.Resources.v
        ElseIf PlayerList(i).GetCardType.Contains("Robber") Then
            ListOfPlayerCards(i).Image = My.Resources.r
        ElseIf PlayerList(i).GetCardType.Contains("TroubleMaker") Then
            ListOfPlayerCards(i).Image = My.Resources.t
        ElseIf PlayerList(i).GetCardType.Contains("Minion") Then
            ListOfPlayerCards(i).Image = My.Resources.Minion
        ElseIf PlayerList(i).GetCardType.Contains("Insomniac") Then
            ListOfPlayerCards(i).Image = My.Resources.insomniac
        ElseIf PlayerList(i).GetCardType.Contains("Drunk") Then
            ListOfPlayerCards(i).Image = My.Resources.drunk
        ElseIf PlayerList(i).GetCardType.Contains("Tanner") Then
            ListOfPlayerCards(i).Image = My.Resources.tanner
        ElseIf PlayerList(i).GetCardType.Contains("Hunter") Then
            ListOfPlayerCards(i).Image = My.Resources.hunter
        End If
    End Sub

    Private Sub RevealMiddleCard(ByVal index As Integer)
        If MiddleCardsList(index).Contains("WereWolf") Then
            MiddleCardPicutreList(index).Image = My.Resources.w
        ElseIf MiddleCardsList(index).Contains("Seer") Then
            MiddleCardPicutreList(index).Image = My.Resources.s
        ElseIf MiddleCardsList(index).Contains("Villager") Then
            MiddleCardPicutreList(index).Image = My.Resources.v
        ElseIf MiddleCardsList(index).Contains("Robber") Then
            MiddleCardPicutreList(index).Image = My.Resources.r
        ElseIf MiddleCardsList(index).Contains("TroubleMaker") Then
            MiddleCardPicutreList(index).Image = My.Resources.t
        ElseIf MiddleCardsList(index).Contains("Minion") Then
            MiddleCardPicutreList(index).Image = My.Resources.Minion
        ElseIf MiddleCardsList(index).Contains("Insomniac") Then
            MiddleCardPicutreList(index).Image = My.Resources.insomniac
        ElseIf MiddleCardsList(index).Contains("Drunk") Then
            MiddleCardPicutreList(index).Image = My.Resources.drunk
        ElseIf MiddleCardsList(index).Contains("Tanner") Then
            MiddleCardPicutreList(index).Image = My.Resources.tanner
        ElseIf MiddleCardsList(index).Contains("Hunter") Then
            MiddleCardPicutreList(index).Image = My.Resources.hunter
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Handles Disconnect
        Disconnect()
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        MsgBox("As a fan of One Night Ultimate Werewolf this game was chosen to be recreated for the PC as a school project for a Visual Basic course." +
               vbNewLine + vbNewLine + "Coded By George Erfesoglou" +
               vbNewLine + vbNewLine + "All card art and background soundtrack property of Bezier Games, Inc." +
               vbNewLine + "Orignal Game concept and idea by Bezier Games.", MsgBoxStyle.ApplicationModal, "About")
    End Sub

    Private Sub Instructions_Click(sender As Object, e As EventArgs) Handles Instructions.Click
        MsgBox("Once at least 3 people have joined and have checked that they are ready, each player is randomly assigned a role that is revealed to them until the 5 second mark." +
               vbNewLine + "Once the cards are shown and even while hidden you can click your card to reveal details about that cards ability and time to play." +
               vbNewLine + vbNewLine + "The game is Humans vs Werewolfs, the Humans are trying to find and hunt the Werewolfs and the Werewolfs are trying to not get hunted" +
               vbNewLine + vbNewLine + "Once everyone has preformed their action the inital game setup is over (Night) and the disccusion begins (Day)." +
               vbNewLine + vbNewLine + "The timer resets and everyone is givin 5 minutes to figure out who is who and vote to kill whomever they beileve the Werewolf to be or convince the others otherwise." +
               vbNewLine + vbNewLine + "Currently the voting can be done in chat by typing out the name of the person you want to kill before the 5 minute mark." +
               vbNewLine + vbNewLine + "Once time is up all the cards are revealed and the player who recieved the most votes dies. In the case of ties all who tied die." +
               vbNewLine + "So long as one Werewolf gets shot the Humans win regardless if a human had to die in the process. However, if no Werewolf dies the Humans lose.", MsgBoxStyle.Information, "Insturctions On How To Play")

    End Sub
    Private Sub VoteMenuButton_Click(sender As Object, e As EventArgs) Handles VoteMenuButton.Click
        If RoundStarted = True Then
            VMF = New VoteMenuForm(PlayerList, AlreadyVoted)
            VMF.Show()
            VoteMenuButton.Enabled = False
        End If
    End Sub
    Public Sub EnableVoteMenuButton()
        VoteMenuButton.Enabled = True
    End Sub

    Public Sub SendVoteToEveryone(ByVal playreVotedFor As Player)
        'Update Everyone's vote to everyone else, we include who did the vote so we can take into account voting perks
        Dim PlayerData() As Byte = Encoding.ASCII.GetBytes(playreVotedFor.GetPlayerName() + "<>" + playreVotedFor.GetCardType + "<>" + "-" + "<>" + playreVotedFor.GetUniquePlayerID.ToString + "<>" + InitialRole + "<>" + "UpdateKillVotes")
        sendingClientPlayerInfo.Send(PlayerData, PlayerData.Length)
        AlreadyVoted = True
    End Sub
    Public Sub SendVotesToEndRound()
        Dim PlayerData() As Byte = Encoding.ASCII.GetBytes(thisPlayer.GetPlayerName() + "<>" + thisPlayer.GetCardType + "<>" + "-" + "<>" + thisPlayer.GetUniquePlayerID.ToString + "<>" + "-" + "<>" + "UpdateVotesToEndRound")
        sendingClientPlayerInfo.Send(PlayerData, PlayerData.Length)
        AlreadyVoted = True
    End Sub
    Public Sub VoteToEndRound()

        voteCount = voteCount + 1
        If voteCount = PlayerList.Count Then
            EndRoundVotePassed = True
        End If
    End Sub
    Public Sub Disconnect()
        Dim PlayerData() As Byte = Encoding.ASCII.GetBytes(thisPlayer.GetPlayerName() + "<>" + thisPlayer.GetCardType + "<>" + "-" + "<>" + thisPlayer.GetUniquePlayerID.ToString + "<>" + "-" + "<>" + "Disconnected")
        sendingClientPlayerInfo.Send(PlayerData, PlayerData.Length)
    End Sub
    Public Sub RestartRound()
        isReadyList.Clear()
        GameTime.Enabled = False
        RoundStarted = False
        VoteMenuButton.Enabled = False
        Me.BackgroundImage = My.Resources.wooddark
        StartRound = True
        voteCount = 0
        EndRoundVotePassed = False
        RolePlayTime.Clear()
        Time = 0
        Night = True
        TimeMulti = 0
        SawCard = False
        OneWereWolf = False
        CardCount = 0
        TurnAllowed = False
        TMFirstPickIndex = -1
        RobbersNewRole = "Robber"
        CharacterList.Clear()
        'Add default essential Characters to list back since they were removed when they were assigned
        CharacterList.Add("WereWolf")
        CharacterList.Add("WereWolf")
        CharacterList.Add("Seer")
        'CharacterList.Add("Villager")
        CharacterList.Add("Robber")
        CharacterList.Add("TroubleMaker")
        'Enable the ready again
        ReadyToStart.Enabled = True
        ReadyToStart.Checked = False
        TimerLabel.Text = "Timer"
        TurnLabel.Text = ""
        My.Computer.Audio.Stop()
        'Hide All Cards, Some may have shown depending on when restarted
        HideAllCards()
    End Sub

    Private Sub RestartRoundButton_Click(sender As Object, e As EventArgs) Handles RestartRoundButton.Click
        If isMaster Then
            Dim PlayerData() As Byte = Encoding.ASCII.GetBytes(thisPlayer.GetPlayerName() + "<>" + thisPlayer.GetCardType + "<>" + "-" + "<>" + randomIntegerID.ToString + "<>" + isMaster.ToString + "<>" + "RestartRound")
            sendingClientPlayerInfo.Send(PlayerData, PlayerData.Length)
        End If
    End Sub
    Public Sub UpdateCharacterList(ByVal RoleToAdd As String)
        Dim PlayerData() As Byte = Encoding.ASCII.GetBytes(thisPlayer.GetPlayerName() + "<>" + thisPlayer.GetCardType + "<>" + "-" + "<>" + randomIntegerID.ToString + "<>" + isMaster.ToString + "<>" + "UpdateCharacterList" + "<>" + RoleToAdd)
        sendingClientPlayerInfo.Send(PlayerData, PlayerData.Length)
    End Sub

    Private Sub CardInfoButton_Click(sender As Object, e As EventArgs) Handles CardInfoButton.Click
        Dim CIF As CardInfoForm = New CardInfoForm
        CIF.Show()
    End Sub
End Class