Public Class PlayerVsPlayerLobbyfrm
    Dim CharacterCheck As Boolean

    Private Sub Player_Vs_Player_Lobby_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'this whole module updates the score and will determine who wins the game
        PlayerOnelbl.Text = PlayerOne
        PlayerTwolbl.Text = PlayerTwo
        PlayerOneScorelbl.Text = Str(PlayerOneScore)
        PlayerTwoScorelbl.Text = Str(PlayerTwoScore)
        PlayerOneMoveslbl.Text = Str(PlayerOneMoves)
        PlayerTwoMoveslbl.Text = Str(PlayerTwoMoves)
        Player = (Player Mod 2) + 1
        Lobbylbl.Text = "Lobby - After" + Str(Round) + " round(s)"
        If Player = 1 Then
            PlayerTurnlbl.Text = PlayerOne + "'s turn to choose a word"
        Else
            PlayerTurnlbl.Text = PlayerTwo + "'s turn to choose a word"
        End If
        HiddenWordtxt.Focus()
        If Round >= RoundsToBePlayed Then
            MsgBox("These are the final results. Congratulations!")
            StartBtn.Enabled = False
            If PlayerOneScore > PlayerTwoScore Then
                MsgBox(PlayerOne + " wins!!")
            ElseIf PlayerTwoScore > PlayerOneScore Then
                MsgBox(PlayerTwo + " wins!!")
            ElseIf PlayerOneMoves < PlayerTwoMoves Then
                MsgBox(PlayerOne + " wins!!")
            ElseIf PlayerTwoMoves < PlayerOneMoves Then
                MsgBox(PlayerTwo + " wins!!")
            Else
                MsgBox("The match between " + PlayerOne + " and " + PlayerTwo + " is a draw!")
            End If
            PlayerTurnlbl.Visible = False   'used to force user to go back to the main menu
        End If
    End Sub

    Private Sub StartBtn_Click(sender As System.Object, e As System.EventArgs) Handles StartBtn.Click
        CharacterCheck = IsNumeric(HiddenWordtxt.Text) 'checks the word is made up of numbers
        If CharacterCheck = False And HiddenWordtxt.Text <> "" Then
            If Len(HiddenWordtxt.Text) <= 8 And Len(HiddenWordtxt.Text) >= 2 Then
                TwoPlayerHiddenWord = HiddenWordtxt.Text 'places the word in the hangman game
                PlayerVsPlayerGamefrm.Show()            'starts the game
                Me.Close()
                HiddenWordtxt.Text = ""
            ElseIf Len(HiddenWordtxt.Text) > 8 Then
                MsgBox("The word cannot be more than 8 characters. Please re-enter")
            Else
                MsgBox("The word must be 2 characters or longer. Please re-enter.")
            End If
        Else
            If CharacterCheck = True Then
                MsgBox("The new word must contain letters only. Please re-enter.")
            Else
                MsgBox("Please enter a word into the new words box.")
            End If
        End If
    End Sub

    Private Sub QuitBtn_Click(sender As System.Object, e As System.EventArgs) Handles QuitBtn.Click
        'resets everything back to neutral and sends user back to Hangman Menu
        HangmanMainMenufrm.Show()
        PlayerOneScore = 0
        PlayerTwoScore = 0
        PlayerOneMoves = 0
        PlayerTwoMoves = 0
        PlayerOne = ""
        PlayerTwo = ""
        Round = 0
        Player = 0
        PlayerTurnlbl.Visible = True
        StartBtn.Enabled = True
        HiddenWordtxt.Text = ""
        Me.Close()
    End Sub
End Class