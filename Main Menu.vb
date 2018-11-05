Public Class MainMenufrm

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles HangmanPic.Click
        'Takes the user to the Hangman part of the game
        Me.Hide()
        HangmanMainMenufrm.Show()
    End Sub

    Private Sub ExitBtn_Click(sender As System.Object, e As System.EventArgs) Handles ExitBtn.Click
        'Closes the application
        Me.Close()
    End Sub

    Private Sub BlackjackPic_Click(sender As System.Object, e As System.EventArgs) Handles BlackjackPic.Click
        'Takes the user to the Blackjack part of the game
        Me.Hide()
        BlackjackMainMenufrm.Show()
    End Sub
End Class
