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
        Me.CardInfoLabel = New System.Windows.Forms.Label()
        Me.Card4 = New System.Windows.Forms.PictureBox()
        Me.Card3 = New System.Windows.Forms.PictureBox()
        Me.Card1 = New System.Windows.Forms.PictureBox()
        Me.Card2 = New System.Windows.Forms.PictureBox()
        Me.Card7 = New System.Windows.Forms.PictureBox()
        Me.Card6 = New System.Windows.Forms.PictureBox()
        Me.Card5 = New System.Windows.Forms.PictureBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Settings.Location = New System.Drawing.Point(1801, 861)
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
        Me.PlayerName2.Font = New System.Drawing.Font("Papyrus", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName2.Location = New System.Drawing.Point(361, 36)
        Me.PlayerName2.Name = "PlayerName2"
        Me.PlayerName2.Size = New System.Drawing.Size(201, 40)
        Me.PlayerName2.TabIndex = 17
        Me.PlayerName2.Text = "Not Connected"
        '
        'PlayerName3
        '
        Me.PlayerName3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PlayerName3.AutoSize = True
        Me.PlayerName3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerName3.Font = New System.Drawing.Font("Papyrus", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName3.Location = New System.Drawing.Point(993, 36)
        Me.PlayerName3.Name = "PlayerName3"
        Me.PlayerName3.Size = New System.Drawing.Size(201, 40)
        Me.PlayerName3.TabIndex = 18
        Me.PlayerName3.Text = "Not Connected"
        '
        'PlayerName1
        '
        Me.PlayerName1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PlayerName1.AutoSize = True
        Me.PlayerName1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerName1.Font = New System.Drawing.Font("Papyrus", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName1.Location = New System.Drawing.Point(993, 729)
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
        Me.PlayerName4.Font = New System.Drawing.Font("Papyrus", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.PlayerName4.Location = New System.Drawing.Point(1598, 36)
        Me.PlayerName4.Name = "PlayerName4"
        Me.PlayerName4.Size = New System.Drawing.Size(201, 40)
        Me.PlayerName4.TabIndex = 20
        Me.PlayerName4.Text = "Not Connected"
        '
        'CardInfoLabel
        '
        Me.CardInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CardInfoLabel.AutoSize = True
        Me.CardInfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardInfoLabel.Location = New System.Drawing.Point(990, 784)
        Me.CardInfoLabel.Name = "CardInfoLabel"
        Me.CardInfoLabel.Size = New System.Drawing.Size(180, 20)
        Me.CardInfoLabel.TabIndex = 21
        Me.CardInfoLabel.Text = "Click Card For More Info"
        Me.CardInfoLabel.Visible = False
        '
        'Card4
        '
        Me.Card4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Card4.InitialImage = CType(resources.GetObject("Card4.InitialImage"), System.Drawing.Image)
        Me.Card4.Location = New System.Drawing.Point(1442, 36)
        Me.Card4.Name = "Card4"
        Me.Card4.Size = New System.Drawing.Size(150, 205)
        Me.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card4.TabIndex = 7
        Me.Card4.TabStop = False
        '
        'Card3
        '
        Me.Card3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Card3.InitialImage = CType(resources.GetObject("Card3.InitialImage"), System.Drawing.Image)
        Me.Card3.Location = New System.Drawing.Point(824, 36)
        Me.Card3.Name = "Card3"
        Me.Card3.Size = New System.Drawing.Size(150, 205)
        Me.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card3.TabIndex = 6
        Me.Card3.TabStop = False
        '
        'Card1
        '
        Me.Card1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Card1.InitialImage = CType(resources.GetObject("Card1.InitialImage"), System.Drawing.Image)
        Me.Card1.Location = New System.Drawing.Point(824, 729)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(150, 205)
        Me.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card1.TabIndex = 5
        Me.Card1.TabStop = False
        '
        'Card2
        '
        Me.Card2.InitialImage = CType(resources.GetObject("Card2.InitialImage"), System.Drawing.Image)
        Me.Card2.Location = New System.Drawing.Point(204, 36)
        Me.Card2.Name = "Card2"
        Me.Card2.Size = New System.Drawing.Size(150, 205)
        Me.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card2.TabIndex = 4
        Me.Card2.TabStop = False
        '
        'Card7
        '
        Me.Card7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Card7.InitialImage = CType(resources.GetObject("Card7.InitialImage"), System.Drawing.Image)
        Me.Card7.Location = New System.Drawing.Point(1041, 347)
        Me.Card7.Name = "Card7"
        Me.Card7.Size = New System.Drawing.Size(150, 205)
        Me.Card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card7.TabIndex = 2
        Me.Card7.TabStop = False
        '
        'Card6
        '
        Me.Card6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Card6.InitialImage = CType(resources.GetObject("Card6.InitialImage"), System.Drawing.Image)
        Me.Card6.Location = New System.Drawing.Point(824, 347)
        Me.Card6.Name = "Card6"
        Me.Card6.Size = New System.Drawing.Size(150, 205)
        Me.Card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card6.TabIndex = 1
        Me.Card6.TabStop = False
        '
        'Card5
        '
        Me.Card5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Card5.InitialImage = CType(resources.GetObject("Card5.InitialImage"), System.Drawing.Image)
        Me.Card5.Location = New System.Drawing.Point(617, 347)
        Me.Card5.Name = "Card5"
        Me.Card5.Size = New System.Drawing.Size(150, 205)
        Me.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card5.TabIndex = 0
        Me.Card5.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1910, 969)
        Me.Controls.Add(Me.CardInfoLabel)
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
        Me.Text = "One Night Ultimate WereWolf PC Edition 1.0 Beta"
        CType(Me.Card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CardInfoLabel As System.Windows.Forms.Label

End Class
