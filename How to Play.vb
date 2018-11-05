Public Class HowToPlayfrm

    Private Sub BackBtn_Click(sender As System.Object, e As System.EventArgs) Handles BackBtn.Click
        'Sends user back to the menu
        Me.Hide()
        HangmanMainMenufrm.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://en.wikipedia.org/wiki/Hangman_(game)")
    End Sub
End Class