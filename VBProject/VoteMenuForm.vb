﻿Public Class VoteMenuForm

    Dim CheckBoxList As New List(Of CheckBox)
    Dim PlayerList As New List(Of Player)
    Dim AlreadyVoted As Boolean
    Public Sub New(ByVal PL As List(Of Player), ByVal voted As Boolean)
        InitializeComponent()
        Me.MaximumSize = New Size(470, 500)
        Me.MinimumSize = Me.MaximumSize
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        'CheckBox1.Text = PlayerList(1).GetPlayerName
        CheckBoxList.Add(CheckBox1)
        CheckBoxList.Add(CheckBox2)
        CheckBoxList.Add(CheckBox3)
        CheckBoxList.Add(CheckBox4)
        CheckBoxList.Add(CheckBox5)
        CheckBoxList.Add(CheckBox6)
        CheckBoxList.Add(CheckBox7)
        CheckBoxList.Add(CheckBox8)
        CheckBoxList.Add(CheckBox9)
        PlayerList = PL
        AlreadyVoted = voted
    End Sub
    Private Sub VoteMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCheckBoxNames()
        'Might Have excess checkboxes, if so hide the excess checkboxes
        If PlayerList.Count < CheckBoxList.Count Then
            For i = PlayerList.Count - 1 To CheckBoxList.Count - 1
                CheckBoxList(i).Visible = False
            Next
        End If
        If AlreadyVoted Then
            Disable_CheckBoxes()
            EndRoundCheckBox.Enabled = False
        End If
    End Sub
    Public Sub SetCheckBoxNames()
        'Set Each Checboxes name
        For i As Integer = 1 To PlayerList.Count - 1
            CheckBoxList(i - 1).Text = "Kill " + PlayerList(i).GetPlayerName
        Next
    End Sub
    Public Sub SetPlayerList(ByVal PL As List(Of Player))
        PlayerList = PL
    End Sub
    Public Sub Disable_CheckBoxes()
        For i As Integer = 0 To CheckBoxList.Count - 1
            CheckBoxList(i).Enabled = False
        Next
        'user can now vote to end round since they voted who to kill
        EndRoundCheckBox.Enabled = True
    End Sub
    Public Sub Enable_CheckBoxes()
        For i As Integer = 0 To CheckBoxList.Count - 1
            CheckBoxList(i).Enabled = False
        Next
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'PlayerList(1).AddVote()
        MainForm.SendVoteToEveryone(PlayerList(1))
        Disable_CheckBoxes()
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        'PlayerList(2).AddVote()
        MainForm.SendVoteToEveryone(PlayerList(2))
        Disable_CheckBoxes()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        'PlayerList(3).AddVote()
        MainForm.SendVoteToEveryone(PlayerList(3))
        Disable_CheckBoxes()
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        'PlayerList(4).AddVote()
        MainForm.SendVoteToEveryone(PlayerList(4))
        Disable_CheckBoxes()
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        'PlayerList(4).AddVote()
        MainForm.SendVoteToEveryone(PlayerList(5))
        Disable_CheckBoxes()
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        'PlayerList(6).AddVote()
        MainForm.SendVoteToEveryone(PlayerList(6))
        Disable_CheckBoxes()
    End Sub
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        'PlayerList(7).AddVote()
        MainForm.SendVoteToEveryone(PlayerList(7))
        Disable_CheckBoxes()
    End Sub
    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        'PlayerList(8).AddVote()
        MainForm.SendVoteToEveryone(PlayerList(8))
        Disable_CheckBoxes()
    End Sub
    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        'PlayerList(9).AddVote()
        MainForm.SendVoteToEveryone(PlayerList(9))
        Disable_CheckBoxes()
    End Sub
    Private Sub EndRoundCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EndRoundCheckBox.CheckedChanged
        MainForm.SendVotesToEndRound()
        EndRoundCheckBox.Enabled = False
    End Sub
    Private Sub VoteMenuForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        e.Cancel = True
        MainForm.EnableVoteMenuButton()
    End Sub
End Class