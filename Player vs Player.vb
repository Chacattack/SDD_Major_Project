Public Class PlayerVsPlayerfrm
    Dim CharacterCheck1 As String
    Dim CharacterCheck2 As String

    Private Sub Rounds_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Rounds.SelectedIndexChanged

    End Sub

    Private Sub PlayerVsPlayerfrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'gives user choice on how many rounds will be played
        Rounds.Items.Add("1")
        Rounds.Items.Add("2")
        Rounds.Items.Add("3")
        Rounds.Items.Add("4")
        Rounds.Items.Add("5")
        Rounds.SelectedIndex = 0
        PlayerOnetxt.Focus()
    End Sub

    Private Sub BackBtn_Click(sender As System.Object, e As System.EventArgs) Handles BackBtn.Click
        'sends user back to Hangman Menu
        HangmanMainMenufrm.Show()
        PlayerOnetxt.Text = ""
        PlayerTwotxt.Text = ""
        Me.Close()
    End Sub

    Private Sub StartBtn_Click(sender As System.Object, e As System.EventArgs) Handles StartBtn.Click
        CharacterCheck1 = IsNumeric(PlayerOnetxt.Text) 'checks to see the names are composed of letters
        CharacterCheck2 = IsNumeric(PlayerTwotxt.Text)
        If CharacterCheck1 = False And PlayerOnetxt.Text <> "" Then
            If CharacterCheck2 = False And PlayerTwotxt.Text <> "" Then
                PlayerOne = PlayerOnetxt.Text           'enters the names into variables
                PlayerTwo = PlayerTwotxt.Text
                RoundsToBePlayed = Rounds.Text
                PlayerVsPlayerLobbyfrm.Show()           'takes the user to the lobby screen to begin play
                PlayerOnetxt.Text = ""
                PlayerTwotxt.Text = ""
                Me.Close()
            ElseIf CharacterCheck2 = True Then
                MsgBox("Player 2's name must be composed of letters. Please re-enter.")
            Else
                MsgBox("Please enter a name for Player 2.")
            End If
        ElseIf CharacterCheck1 = False Then
            MsgBox("Player 1's name must be composed of letters. Please re-enter.")
        Else
            MsgBox("Please enter a name for Player 1.")
        End If

    End Sub
End Class