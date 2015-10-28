Public Class SettingsForm
    Private player = New Player()

    Public Sub New(ByVal p As Player)
        InitializeComponent()
        player = p
        PlayerNameField.Text = player.GetPlayerName()
        Me.AcceptButton = SaveButton
        AudioCheckBox.Checked = MainForm.GetAudioEnabledBool
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
End Class