Public Class SettingsForm
    Private player = New Player()
    Private RoundTime As Integer
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
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MainForm.GetIsMaster Then
            RoundTimeTextField.Enabled = True
        Else
            RoundTimeTextField.Enabled = False
        End If
        RoundTimeTextField.Text = MainForm.GetRoundTime
    End Sub
    Private Sub PlayerNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlayerNameField.TextChanged

    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        If PlayerNameField.Text.Length < 20 Then
            player.SetPlayerName(PlayerNameField.Text)
        Else
            MsgBox("Name Not Saved, please make name less than 20 characteres", MsgBoxStyle.Critical, "Error - Name Not Saved")
        End If

        'if the name has changed then we need to update everyone on the change
        If Not player.GetPlayername.Equals(PlayerNameField.Text) Then
            MainForm.NameChanged()
        End If
        MainForm.NameChanged()
        player.SetFontSize(FontSizeValue.Value)
        MainForm.UpdateSettings(AudioCheckBox.Checked)
        MainForm.EnableSettingsButton()
        If Not RoundLabel.Text Is Nothing And Integer.TryParse(RoundTimeTextField.Text, RoundTime) And RoundTime > 0 Then
            If MainForm.GetIsMaster Then
                MainForm.SetRoundTime(RoundTimeTextField.Text)
            End If
            Me.Hide()
        Else
            MsgBox("Please insert a time greater than 0.", MsgBoxStyle.Critical, "Input Error")
        End If
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
    Private Sub RoundTimeTextField_TextChanged(sender As Object, e As EventArgs) Handles RoundTimeTextField.TextChanged

    End Sub
End Class