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
    Private Sub Card6_Click(sender As Object, e As EventArgs) Handles Card6.Click
        DisplayCardInfo("Minion")
    End Sub
    Private Sub Card7_Click(sender As Object, e As EventArgs) Handles Card7.Click
        DisplayCardInfo("Hunter")
    End Sub
    Private Sub Card8_Click(sender As Object, e As EventArgs) Handles Card8.Click
        DisplayCardInfo("Tanner")
    End Sub
    Private Sub Card9_Click(sender As Object, e As EventArgs) Handles Card9.Click
        DisplayCardInfo("Insomniac")
    End Sub
    Private Sub Card10_Click(sender As Object, e As EventArgs) Handles Card10.Click
        DisplayCardInfo("Drunk")
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
            Case "Minion"
                MsgBox(
                    "The Minion plays after the Werewolf and gets to see all Werewolfs assuming there are any but the Werewolfs don't get to see the Minion. If the Minion dies and no Werewolves die, the Werewolves (and the Minion) win. If no players are Werewolves, the Minion wins as long as one other player (not the Minion) dies. This role can be a very powerful ally for the werewolf team. This Minion is on the werewolf team and is the only Human not on The Villager Team.", , "Card Information")
            Case "Tanner"
                MsgBox(
                    "The Tanner only wins if he dies and he dies alone. If he dies and a Werewolf dies then Village Team Wins, if he dies and no Werewolfs die then Village team loses.", , "Card Information")
            Case "Hunter"
                MsgBox(
                    "If the Hunter dies, whomever the Hunter voted for dies as well regardless of vote count. The Hunter is on the Villager team.", , "Card Information")
            Case "Insomniac"
                MsgBox(
                    "The Insomniac can look at her card and tends to be the last one to wake up. She is on the Village team and should only be played with the Robber and/or Trouble Maker in play.", , "Card Information")
            Case "Drunk"
                MsgBox(
                    "The Drunk can't recall his role so he swaps his card for one of the center cards and becomes that card without knowing what it is.", , "Card Information")
        End Select
    End Sub
End Class