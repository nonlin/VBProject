Public Class SettingsForm
    Private player = New Player()

    Public Sub New(ByVal p As Player)
        InitializeComponent()
        player = p
        PlayerNameField.Text = player.GetPlayerName()
        Me.AcceptButton = SaveButton
        AudioCheckBox.Checked = MainForm.GetAudioEnabledBool
        Me.MaximumSize = New Size(400, 350)
        Me.MinimumSize = Me.MaximumSize
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub PlayerNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlayerNameField.TextChanged

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        player.SetPlayerName(PlayerNameField.Text)
        player.SetFontSize(FontSizeValue.Value)
        MainForm.UpdateSettings(AudioCheckBox.Checked)
        MainForm.EnableSettingsButton()
        Me.Hide()


    End Sub

    Private Sub FontSizeValue_Scroll(sender As Object, e As EventArgs) Handles FontSizeValue.Scroll
        player.SetFontSize(FontSizeValue.Value)
        MainForm.UpdateSettings(AudioCheckBox.Checked)
    End Sub

    Private Sub SettingForm_Closing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.EnableSettingsButton()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        MainForm.EnableSettingsButton()
        Me.Close()
    End Sub
End Class