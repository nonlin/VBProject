<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SendButton = New System.Windows.Forms.Button()
        Me.MessageInput = New System.Windows.Forms.TextBox()
        Me.Settings = New System.Windows.Forms.Button()
        Me.ChatBox = New System.Windows.Forms.RichTextBox()
        Me.GameTime = New System.Windows.Forms.Timer(Me.components)
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.ReadyToStart = New System.Windows.Forms.CheckBox()
        Me.PlayerName2 = New System.Windows.Forms.Label()
        Me.PlayerName3 = New System.Windows.Forms.Label()
        Me.PlayerName1 = New System.Windows.Forms.Label()
        Me.PlayerName4 = New System.Windows.Forms.Label()
        Me.Card4 = New System.Windows.Forms.PictureBox()
        Me.Card3 = New System.Windows.Forms.PictureBox()
        Me.Card1 = New System.Windows.Forms.PictureBox()
        Me.Card2 = New System.Windows.Forms.PictureBox()
        Me.Card7 = New System.Windows.Forms.PictureBox()
        Me.Card6 = New System.Windows.Forms.PictureBox()
        Me.Card5 = New System.Windows.Forms.PictureBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.About = New System.Windows.Forms.Button()
        Me.Instructions = New System.Windows.Forms.Button()
        Me.TurnLabel = New System.Windows.Forms.Label()
        Me.VoteMenuButton = New System.Windows.Forms.Button()
        Me.RestartRoundButton = New System.Windows.Forms.Button()
        Me.PlayerName5 = New System.Windows.Forms.Label()
        Me.Card8 = New System.Windows.Forms.PictureBox()
        Me.PlayerName6 = New System.Windows.Forms.Label()
        Me.Card9 = New System.Windows.Forms.PictureBox()
        Me.PlayerName7 = New System.Windows.Forms.Label()
        Me.Card10 = New System.Windows.Forms.PictureBox()
        Me.PlayerName9 = New System.Windows.Forms.Label()
        Me.Card12 = New System.Windows.Forms.PictureBox()
        Me.PlayerName8 = New System.Windows.Forms.Label()
        Me.Card11 = New System.Windows.Forms.PictureBox()
        Me.CardInfoButton = New System.Windows.Forms.Button()
        CType(Me.Card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SendButton
        '
        Me.SendButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SendButton.Location = New System.Drawing.Point(23, 858)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(75, 23)
        Me.SendButton.TabIndex = 8
        Me.SendButton.Text = "Send"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'MessageInput
        '
        Me.MessageInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MessageInput.Location = New System.Drawing.Point(118, 861)
        Me.MessageInput.Name = "MessageInput"
        Me.MessageInput.Size = New System.Drawing.Size(297, 20)
        Me.MessageInput.TabIndex = 10
        '
        'Settings
        '
        Me.Settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Settings.Location = New System.Drawing.Point(1799, 876)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(75, 23)
        Me.Settings.TabIndex = 12
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'ChatBox
        '
        Me.ChatBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChatBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChatBox.Location = New System.Drawing.Point(23, 718)
        Me.ChatBox.Name = "ChatBox"
        Me.ChatBox.Size = New System.Drawing.Size(392, 124)
        Me.ChatBox.TabIndex = 13
        Me.ChatBox.Text = ""
        '
        'GameTime
        '
        Me.GameTime.Interval = 1000
        '
        'TimerLabel
        '
        Me.TimerLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.BackColor = System.Drawing.SystemColors.Menu
        Me.TimerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimerLabel.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLabel.Location = New System.Drawing.Point(23, 668)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(91, 33)
        Me.TimerLabel.TabIndex = 14
        Me.TimerLabel.Text = "Timer"
        '
        'ReadyToStart
        '
        Me.ReadyToStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ReadyToStart.AutoSize = True
        Me.ReadyToStart.BackColor = System.Drawing.Color.Silver
        Me.ReadyToStart.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReadyToStart.Enabled = False
        Me.ReadyToStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ReadyToStart.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReadyToStart.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ReadyToStart.Location = New System.Drawing.Point(129, 672)
        Me.ReadyToStart.Name = "ReadyToStart"
        Me.ReadyToStart.Size = New System.Drawing.Size(342, 29)
        Me.ReadyToStart.TabIndex = 16
        Me.ReadyToStart.Text = "Not Enough Players To Start"
        Me.ReadyToStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ReadyToStart.UseVisualStyleBackColor = False
        '
        'PlayerName2
        '
        Me.PlayerName2.AutoSize = True
        Me.PlayerName2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerName2.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName2.Location = New System.Drawing.Point(226, 38)
        Me.PlayerName2.Name = "PlayerName2"
        Me.PlayerName2.Size = New System.Drawing.Size(163, 32)
        Me.PlayerName2.TabIndex = 17
        Me.PlayerName2.Text = "Not Connected"
        '
        'PlayerName3
        '
        Me.PlayerName3.AutoSize = True
        Me.PlayerName3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerName3.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName3.Location = New System.Drawing.Point(564, 38)
        Me.PlayerName3.Name = "PlayerName3"
        Me.PlayerName3.Size = New System.Drawing.Size(163, 32)
        Me.PlayerName3.TabIndex = 18
        Me.PlayerName3.Text = "Not Connected"
        '
        'PlayerName1
        '
        Me.PlayerName1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PlayerName1.AutoSize = True
        Me.PlayerName1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerName1.Font = New System.Drawing.Font("Papyrus", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName1.Location = New System.Drawing.Point(1014, 737)
        Me.PlayerName1.Name = "PlayerName1"
        Me.PlayerName1.Size = New System.Drawing.Size(201, 40)
        Me.PlayerName1.TabIndex = 19
        Me.PlayerName1.Text = "Not Connected"
        '
        'PlayerName4
        '
        Me.PlayerName4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayerName4.AutoSize = True
        Me.PlayerName4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerName4.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.PlayerName4.Location = New System.Drawing.Point(1221, 38)
        Me.PlayerName4.Name = "PlayerName4"
        Me.PlayerName4.Size = New System.Drawing.Size(163, 32)
        Me.PlayerName4.TabIndex = 20
        Me.PlayerName4.Text = "Not Connected"
        Me.PlayerName4.Visible = False
        '
        'Card4
        '
        Me.Card4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Card4.BackgroundImage = CType(resources.GetObject("Card4.BackgroundImage"), System.Drawing.Image)
        Me.Card4.Image = CType(resources.GetObject("Card4.Image"), System.Drawing.Image)
        Me.Card4.InitialImage = CType(resources.GetObject("Card4.InitialImage"), System.Drawing.Image)
        Me.Card4.Location = New System.Drawing.Point(1085, 38)
        Me.Card4.Name = "Card4"
        Me.Card4.Size = New System.Drawing.Size(130, 180)
        Me.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card4.TabIndex = 7
        Me.Card4.TabStop = False
        Me.Card4.Visible = False
        '
        'Card3
        '
        Me.Card3.BackgroundImage = CType(resources.GetObject("Card3.BackgroundImage"), System.Drawing.Image)
        Me.Card3.Image = CType(resources.GetObject("Card3.Image"), System.Drawing.Image)
        Me.Card3.InitialImage = CType(resources.GetObject("Card3.InitialImage"), System.Drawing.Image)
        Me.Card3.Location = New System.Drawing.Point(428, 38)
        Me.Card3.Name = "Card3"
        Me.Card3.Size = New System.Drawing.Size(130, 180)
        Me.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card3.TabIndex = 6
        Me.Card3.TabStop = False
        '
        'Card1
        '
        Me.Card1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Card1.Image = Global.ONUWPC.My.Resources.Resources.back
        Me.Card1.InitialImage = CType(resources.GetObject("Card1.InitialImage"), System.Drawing.Image)
        Me.Card1.Location = New System.Drawing.Point(845, 737)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(150, 205)
        Me.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card1.TabIndex = 5
        Me.Card1.TabStop = False
        '
        'Card2
        '
        Me.Card2.BackgroundImage = CType(resources.GetObject("Card2.BackgroundImage"), System.Drawing.Image)
        Me.Card2.Image = CType(resources.GetObject("Card2.Image"), System.Drawing.Image)
        Me.Card2.InitialImage = CType(resources.GetObject("Card2.InitialImage"), System.Drawing.Image)
        Me.Card2.Location = New System.Drawing.Point(90, 38)
        Me.Card2.Name = "Card2"
        Me.Card2.Size = New System.Drawing.Size(130, 180)
        Me.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card2.TabIndex = 4
        Me.Card2.TabStop = False
        '
        'Card7
        '
        Me.Card7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Card7.BackgroundImage = CType(resources.GetObject("Card7.BackgroundImage"), System.Drawing.Image)
        Me.Card7.Image = CType(resources.GetObject("Card7.Image"), System.Drawing.Image)
        Me.Card7.InitialImage = CType(resources.GetObject("Card7.InitialImage"), System.Drawing.Image)
        Me.Card7.Location = New System.Drawing.Point(1062, 317)
        Me.Card7.Name = "Card7"
        Me.Card7.Size = New System.Drawing.Size(130, 180)
        Me.Card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card7.TabIndex = 2
        Me.Card7.TabStop = False
        '
        'Card6
        '
        Me.Card6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Card6.BackgroundImage = CType(resources.GetObject("Card6.BackgroundImage"), System.Drawing.Image)
        Me.Card6.Image = CType(resources.GetObject("Card6.Image"), System.Drawing.Image)
        Me.Card6.InitialImage = CType(resources.GetObject("Card6.InitialImage"), System.Drawing.Image)
        Me.Card6.Location = New System.Drawing.Point(845, 317)
        Me.Card6.Name = "Card6"
        Me.Card6.Size = New System.Drawing.Size(130, 180)
        Me.Card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card6.TabIndex = 1
        Me.Card6.TabStop = False
        '
        'Card5
        '
        Me.Card5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Card5.BackgroundImage = CType(resources.GetObject("Card5.BackgroundImage"), System.Drawing.Image)
        Me.Card5.Image = CType(resources.GetObject("Card5.Image"), System.Drawing.Image)
        Me.Card5.InitialImage = CType(resources.GetObject("Card5.InitialImage"), System.Drawing.Image)
        Me.Card5.Location = New System.Drawing.Point(638, 317)
        Me.Card5.Name = "Card5"
        Me.Card5.Size = New System.Drawing.Size(130, 180)
        Me.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card5.TabIndex = 0
        Me.Card5.TabStop = False
        '
        'About
        '
        Me.About.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.About.Location = New System.Drawing.Point(1799, 934)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(75, 23)
        Me.About.TabIndex = 22
        Me.About.Text = "About"
        Me.About.UseVisualStyleBackColor = True
        '
        'Instructions
        '
        Me.Instructions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Instructions.Location = New System.Drawing.Point(1799, 905)
        Me.Instructions.Name = "Instructions"
        Me.Instructions.Size = New System.Drawing.Size(75, 23)
        Me.Instructions.TabIndex = 23
        Me.Instructions.Text = "Instructions"
        Me.Instructions.UseVisualStyleBackColor = True
        '
        'TurnLabel
        '
        Me.TurnLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TurnLabel.BackColor = System.Drawing.Color.Transparent
        Me.TurnLabel.Font = New System.Drawing.Font("Viner Hand ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurnLabel.ForeColor = System.Drawing.Color.DarkOrange
        Me.TurnLabel.Location = New System.Drawing.Point(641, 577)
        Me.TurnLabel.Name = "TurnLabel"
        Me.TurnLabel.Size = New System.Drawing.Size(574, 132)
        Me.TurnLabel.TabIndex = 24
        Me.TurnLabel.Text = "Turn Display"
        Me.TurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TurnLabel.Visible = False
        '
        'VoteMenuButton
        '
        Me.VoteMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.VoteMenuButton.Enabled = False
        Me.VoteMenuButton.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoteMenuButton.Location = New System.Drawing.Point(1014, 793)
        Me.VoteMenuButton.Name = "VoteMenuButton"
        Me.VoteMenuButton.Size = New System.Drawing.Size(140, 35)
        Me.VoteMenuButton.TabIndex = 25
        Me.VoteMenuButton.Text = "Vote Menu"
        Me.VoteMenuButton.UseVisualStyleBackColor = True
        '
        'RestartRoundButton
        '
        Me.RestartRoundButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.RestartRoundButton.Enabled = False
        Me.RestartRoundButton.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartRoundButton.Location = New System.Drawing.Point(1016, 845)
        Me.RestartRoundButton.Name = "RestartRoundButton"
        Me.RestartRoundButton.Size = New System.Drawing.Size(140, 35)
        Me.RestartRoundButton.TabIndex = 26
        Me.RestartRoundButton.Text = "Restart Round"
        Me.RestartRoundButton.UseVisualStyleBackColor = True
        '
        'PlayerName5
        '
        Me.PlayerName5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayerName5.AutoSize = True
        Me.PlayerName5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerName5.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.PlayerName5.Location = New System.Drawing.Point(1551, 38)
        Me.PlayerName5.Name = "PlayerName5"
        Me.PlayerName5.Size = New System.Drawing.Size(163, 32)
        Me.PlayerName5.TabIndex = 28
        Me.PlayerName5.Text = "Not Connected"
        Me.PlayerName5.Visible = False
        '
        'Card8
        '
        Me.Card8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Card8.Image = Global.ONUWPC.My.Resources.Resources.back
        Me.Card8.InitialImage = Global.ONUWPC.My.Resources.Resources.back
        Me.Card8.Location = New System.Drawing.Point(1415, 38)
        Me.Card8.Name = "Card8"
        Me.Card8.Size = New System.Drawing.Size(130, 180)
        Me.Card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card8.TabIndex = 27
        Me.Card8.TabStop = False
        Me.Card8.Visible = False
        '
        'PlayerName6
        '
        Me.PlayerName6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PlayerName6.AutoSize = True
        Me.PlayerName6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerName6.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.PlayerName6.Location = New System.Drawing.Point(1711, 192)
        Me.PlayerName6.Name = "PlayerName6"
        Me.PlayerName6.Size = New System.Drawing.Size(163, 32)
        Me.PlayerName6.TabIndex = 30
        Me.PlayerName6.Text = "Not Connected"
        Me.PlayerName6.Visible = False
        '
        'Card9
        '
        Me.Card9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Card9.Image = CType(resources.GetObject("Card9.Image"), System.Drawing.Image)
        Me.Card9.InitialImage = CType(resources.GetObject("Card9.InitialImage"), System.Drawing.Image)
        Me.Card9.Location = New System.Drawing.Point(1575, 192)
        Me.Card9.Name = "Card9"
        Me.Card9.Size = New System.Drawing.Size(130, 180)
        Me.Card9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card9.TabIndex = 29
        Me.Card9.TabStop = False
        Me.Card9.Visible = False
        '
        'PlayerName7
        '
        Me.PlayerName7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PlayerName7.AutoSize = True
        Me.PlayerName7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerName7.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.PlayerName7.Location = New System.Drawing.Point(1711, 414)
        Me.PlayerName7.Name = "PlayerName7"
        Me.PlayerName7.Size = New System.Drawing.Size(163, 32)
        Me.PlayerName7.TabIndex = 32
        Me.PlayerName7.Text = "Not Connected"
        Me.PlayerName7.Visible = False
        '
        'Card10
        '
        Me.Card10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Card10.Image = CType(resources.GetObject("Card10.Image"), System.Drawing.Image)
        Me.Card10.InitialImage = CType(resources.GetObject("Card10.InitialImage"), System.Drawing.Image)
        Me.Card10.Location = New System.Drawing.Point(1575, 414)
        Me.Card10.Name = "Card10"
        Me.Card10.Size = New System.Drawing.Size(130, 180)
        Me.Card10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card10.TabIndex = 31
        Me.Card10.TabStop = False
        Me.Card10.Visible = False
        '
        'PlayerName9
        '
        Me.PlayerName9.AutoSize = True
        Me.PlayerName9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerName9.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.PlayerName9.Location = New System.Drawing.Point(226, 357)
        Me.PlayerName9.Name = "PlayerName9"
        Me.PlayerName9.Size = New System.Drawing.Size(163, 32)
        Me.PlayerName9.TabIndex = 34
        Me.PlayerName9.Text = "Not Connected"
        Me.PlayerName9.Visible = False
        '
        'Card12
        '
        Me.Card12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Card12.Image = CType(resources.GetObject("Card12.Image"), System.Drawing.Image)
        Me.Card12.InitialImage = CType(resources.GetObject("Card12.InitialImage"), System.Drawing.Image)
        Me.Card12.Location = New System.Drawing.Point(90, 357)
        Me.Card12.Name = "Card12"
        Me.Card12.Size = New System.Drawing.Size(130, 180)
        Me.Card12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card12.TabIndex = 33
        Me.Card12.TabStop = False
        Me.Card12.Visible = False
        '
        'PlayerName8
        '
        Me.PlayerName8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PlayerName8.AutoSize = True
        Me.PlayerName8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerName8.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.PlayerName8.Location = New System.Drawing.Point(1711, 648)
        Me.PlayerName8.Name = "PlayerName8"
        Me.PlayerName8.Size = New System.Drawing.Size(163, 32)
        Me.PlayerName8.TabIndex = 36
        Me.PlayerName8.Text = "Not Connected"
        Me.PlayerName8.Visible = False
        '
        'Card11
        '
        Me.Card11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Card11.Image = CType(resources.GetObject("Card11.Image"), System.Drawing.Image)
        Me.Card11.InitialImage = CType(resources.GetObject("Card11.InitialImage"), System.Drawing.Image)
        Me.Card11.Location = New System.Drawing.Point(1575, 648)
        Me.Card11.Name = "Card11"
        Me.Card11.Size = New System.Drawing.Size(130, 180)
        Me.Card11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card11.TabIndex = 35
        Me.Card11.TabStop = False
        Me.Card11.Visible = False
        '
        'CardInfoButton
        '
        Me.CardInfoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CardInfoButton.Location = New System.Drawing.Point(1799, 847)
        Me.CardInfoButton.Name = "CardInfoButton"
        Me.CardInfoButton.Size = New System.Drawing.Size(75, 23)
        Me.CardInfoButton.TabIndex = 37
        Me.CardInfoButton.Text = "Card Info"
        Me.CardInfoButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1910, 969)
        Me.Controls.Add(Me.CardInfoButton)
        Me.Controls.Add(Me.PlayerName8)
        Me.Controls.Add(Me.Card11)
        Me.Controls.Add(Me.PlayerName9)
        Me.Controls.Add(Me.Card12)
        Me.Controls.Add(Me.PlayerName7)
        Me.Controls.Add(Me.Card10)
        Me.Controls.Add(Me.PlayerName6)
        Me.Controls.Add(Me.Card9)
        Me.Controls.Add(Me.PlayerName5)
        Me.Controls.Add(Me.Card8)
        Me.Controls.Add(Me.RestartRoundButton)
        Me.Controls.Add(Me.VoteMenuButton)
        Me.Controls.Add(Me.TurnLabel)
        Me.Controls.Add(Me.Instructions)
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.PlayerName4)
        Me.Controls.Add(Me.PlayerName1)
        Me.Controls.Add(Me.PlayerName3)
        Me.Controls.Add(Me.PlayerName2)
        Me.Controls.Add(Me.ReadyToStart)
        Me.Controls.Add(Me.TimerLabel)
        Me.Controls.Add(Me.ChatBox)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.MessageInput)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.Card4)
        Me.Controls.Add(Me.Card3)
        Me.Controls.Add(Me.Card1)
        Me.Controls.Add(Me.Card2)
        Me.Controls.Add(Me.Card7)
        Me.Controls.Add(Me.Card6)
        Me.Controls.Add(Me.Card5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "MainForm"
        Me.Text = "One Night Ultimate WereWolf PC Edition 1.2.8.2 Beta"
        CType(Me.Card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Card5 As System.Windows.Forms.PictureBox
    Friend WithEvents Card6 As System.Windows.Forms.PictureBox
    Friend WithEvents Card7 As System.Windows.Forms.PictureBox
    Friend WithEvents Card2 As System.Windows.Forms.PictureBox
    Friend WithEvents Card1 As System.Windows.Forms.PictureBox
    Friend WithEvents Card3 As System.Windows.Forms.PictureBox
    Friend WithEvents Card4 As System.Windows.Forms.PictureBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SendButton As System.Windows.Forms.Button
    Friend WithEvents MessageInput As System.Windows.Forms.TextBox
    Friend WithEvents Settings As System.Windows.Forms.Button
    Friend WithEvents ChatBox As System.Windows.Forms.RichTextBox
    Friend WithEvents GameTime As System.Windows.Forms.Timer
    Friend WithEvents TimerLabel As System.Windows.Forms.Label
    Friend WithEvents ReadyToStart As System.Windows.Forms.CheckBox
    Friend WithEvents PlayerName2 As System.Windows.Forms.Label
    Friend WithEvents PlayerName3 As System.Windows.Forms.Label
    Friend WithEvents PlayerName1 As System.Windows.Forms.Label
    Friend WithEvents PlayerName4 As System.Windows.Forms.Label
    Friend WithEvents About As System.Windows.Forms.Button
    Friend WithEvents Instructions As System.Windows.Forms.Button
    Friend WithEvents TurnLabel As System.Windows.Forms.Label
    Friend WithEvents VoteMenuButton As System.Windows.Forms.Button
    Friend WithEvents RestartRoundButton As System.Windows.Forms.Button
    Friend WithEvents PlayerName5 As System.Windows.Forms.Label
    Friend WithEvents Card8 As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerName6 As System.Windows.Forms.Label
    Friend WithEvents Card9 As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerName7 As System.Windows.Forms.Label
    Friend WithEvents Card10 As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerName9 As System.Windows.Forms.Label
    Friend WithEvents Card12 As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerName8 As System.Windows.Forms.Label
    Friend WithEvents Card11 As System.Windows.Forms.PictureBox
    Friend WithEvents CardInfoButton As System.Windows.Forms.Button

End Class
