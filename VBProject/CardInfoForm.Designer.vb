<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardInfoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CardInfoForm))
        Me.Card1 = New System.Windows.Forms.PictureBox()
        Me.Card2 = New System.Windows.Forms.PictureBox()
        Me.Card3 = New System.Windows.Forms.PictureBox()
        Me.Card4 = New System.Windows.Forms.PictureBox()
        Me.Card5 = New System.Windows.Forms.PictureBox()
        Me.CardInfoLabel = New System.Windows.Forms.Label()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Card1
        '
        Me.Card1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Card1.BackgroundImage = CType(resources.GetObject("Card1.BackgroundImage"), System.Drawing.Image)
        Me.Card1.Image = Global.ONUWPC.My.Resources.Resources.w
        Me.Card1.InitialImage = CType(resources.GetObject("Card1.InitialImage"), System.Drawing.Image)
        Me.Card1.Location = New System.Drawing.Point(350, 258)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(130, 180)
        Me.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card1.TabIndex = 1
        Me.Card1.TabStop = False
        '
        'Card2
        '
        Me.Card2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Card2.BackgroundImage = CType(resources.GetObject("Card2.BackgroundImage"), System.Drawing.Image)
        Me.Card2.Image = Global.ONUWPC.My.Resources.Resources.s
        Me.Card2.InitialImage = CType(resources.GetObject("Card2.InitialImage"), System.Drawing.Image)
        Me.Card2.Location = New System.Drawing.Point(514, 258)
        Me.Card2.Name = "Card2"
        Me.Card2.Size = New System.Drawing.Size(130, 180)
        Me.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card2.TabIndex = 2
        Me.Card2.TabStop = False
        '
        'Card3
        '
        Me.Card3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Card3.BackgroundImage = CType(resources.GetObject("Card3.BackgroundImage"), System.Drawing.Image)
        Me.Card3.Image = Global.ONUWPC.My.Resources.Resources.r
        Me.Card3.InitialImage = CType(resources.GetObject("Card3.InitialImage"), System.Drawing.Image)
        Me.Card3.Location = New System.Drawing.Point(679, 258)
        Me.Card3.Name = "Card3"
        Me.Card3.Size = New System.Drawing.Size(130, 180)
        Me.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card3.TabIndex = 3
        Me.Card3.TabStop = False
        '
        'Card4
        '
        Me.Card4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Card4.BackgroundImage = CType(resources.GetObject("Card4.BackgroundImage"), System.Drawing.Image)
        Me.Card4.Image = Global.ONUWPC.My.Resources.Resources.t
        Me.Card4.InitialImage = CType(resources.GetObject("Card4.InitialImage"), System.Drawing.Image)
        Me.Card4.Location = New System.Drawing.Point(836, 258)
        Me.Card4.Name = "Card4"
        Me.Card4.Size = New System.Drawing.Size(130, 180)
        Me.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card4.TabIndex = 4
        Me.Card4.TabStop = False
        '
        'Card5
        '
        Me.Card5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Card5.BackgroundImage = CType(resources.GetObject("Card5.BackgroundImage"), System.Drawing.Image)
        Me.Card5.Image = Global.ONUWPC.My.Resources.Resources.v
        Me.Card5.InitialImage = CType(resources.GetObject("Card5.InitialImage"), System.Drawing.Image)
        Me.Card5.Location = New System.Drawing.Point(992, 258)
        Me.Card5.Name = "Card5"
        Me.Card5.Size = New System.Drawing.Size(130, 180)
        Me.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card5.TabIndex = 5
        Me.Card5.TabStop = False
        '
        'CardInfoLabel
        '
        Me.CardInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CardInfoLabel.AutoSize = True
        Me.CardInfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardInfoLabel.Location = New System.Drawing.Point(346, 219)
        Me.CardInfoLabel.Name = "CardInfoLabel"
        Me.CardInfoLabel.Size = New System.Drawing.Size(180, 20)
        Me.CardInfoLabel.TabIndex = 22
        Me.CardInfoLabel.Text = "Click Card For More Info"
        Me.CardInfoLabel.Visible = False
        '
        'CardInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1559, 790)
        Me.Controls.Add(Me.CardInfoLabel)
        Me.Controls.Add(Me.Card5)
        Me.Controls.Add(Me.Card4)
        Me.Controls.Add(Me.Card3)
        Me.Controls.Add(Me.Card2)
        Me.Controls.Add(Me.Card1)
        Me.Name = "CardInfoForm"
        Me.Text = "CardInfoForm"
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Card1 As System.Windows.Forms.PictureBox
    Friend WithEvents Card2 As System.Windows.Forms.PictureBox
    Friend WithEvents Card3 As System.Windows.Forms.PictureBox
    Friend WithEvents Card4 As System.Windows.Forms.PictureBox
    Friend WithEvents Card5 As System.Windows.Forms.PictureBox
    Friend WithEvents CardInfoLabel As System.Windows.Forms.Label
End Class
