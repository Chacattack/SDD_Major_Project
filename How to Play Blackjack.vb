Public Class HowToPlayBlackjackfrm

    Private Sub MainMenuBtn_Click(sender As System.Object, e As System.EventArgs) Handles MainMenuBtn.Click
        'Takes user back to main menu
        BlackjackMainMenufrm.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Blackjack")
    End Sub
End Class