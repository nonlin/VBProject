Public Class CardInfoForm
    Private Sub CardInforForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.woodlightdark
        'Prevents Window Flickers from resizing, on launch or moving
        Me.DoubleBuffered = True
    End Sub
    Private Sub Card1_Click(sender As Object, e As EventArgs) Handles Card1.Click
        DisplayCardInfo("WereWolf")
    End Sub

    Private Sub Card2_Click(sender As Object, e As EventArgs) Handles Card2.Click
        DisplayCardInfo("Seer")
    End Sub

    Private Sub Card3_Click(sender As Object, e As EventArgs) Handles Card3.Click
        DisplayCardInfo("Robber")
    End Sub

    Private Sub Card4_Click(sender As Object, e As EventArgs) Handles Card4.Click
        DisplayCardInfo("TroubleMaker")
    End Sub

    Private Sub Card5_Click(sender As Object, e As EventArgs) Handles Card5.Click
        DisplayCardInfo("Villager")
    End Sub
    Private Sub DisplayCardInfo(ByVal role As String)
        Select Case role
            Case "WereWolf"
                MsgBox(
                       "The Werewolf has 5 seconds to see one of the middle card so long as there are no other Werewolf or do nothing. Window of Action is 10 - 15 Seconds", , "Card Information")
            Case "Seer"
                MsgBox(
                     "The Seer has 5 seconds to see two of the middle cards, one other player's card or do nothing. Window of Action is 15 - 20 Seconds", , "Card Information")
            Case "Villager"
                MsgBox(
                    "The Villager has no special powers, use your wits.", , "Card Information")
            Case "Robber"
                MsgBox(
                    "The Robber has 5 seconds to switch cards with another player, viewing that other players card as a result or do nothing. Window of Action is 20 - 25 Seconds", , "Card Information")
            Case "TroubleMaker"
                MsgBox(
                    "The Troublemaker has 5 seconds swap the cards between two other players or do nothing. Window of Action is 25 - 30 Seconds", , "Card Information")

        End Select
    End Sub
End Class