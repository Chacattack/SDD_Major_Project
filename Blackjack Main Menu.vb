Public Class BlackjackMainMenufrm
    Dim Read As String

    Private Sub MainMenuBtn_Click(sender As System.Object, e As System.EventArgs) Handles MainMenuBtn.Click
        'takes user back to the main menu
        MainMenufrm.Show()
        Me.Close()
    End Sub

    Private Sub ContinueGameBtn_Click(sender As System.Object, e As System.EventArgs) Handles ContinueGameBtn.Click
        'enables user to continue game
        Total = My.Computer.FileSystem.ReadAllText("Blackjack\Save File.txt")
        BlackjackGamefrm.Show()
        Me.Close()
    End Sub

    Private Sub NewGameBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewGameBtn.Click
        'allows user to start new game
        Total = 100
        BlackjackGamefrm.Show()
        Me.Close()
    End Sub

    Private Sub ClearDataBtn_Click(sender As System.Object, e As System.EventArgs) Handles ClearDataBtn.Click
        'Clears current saved data
        ContinueGameBtn.Enabled = False
        System.IO.File.WriteAllText("Blackjack\Save File.txt", "")
        ClearDataBtn.Enabled = False
    End Sub

    Private Sub BlackjackMainMenufrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Checks to see if there is saved data
        If FileLen("Blackjack\Save File.txt") <> 0 Then
            ContinueGameBtn.Enabled = True
            ClearDataBtn.Enabled = True
        End If
    End Sub

    Private Sub HowToPlayBlackjackbtn_Click(sender As System.Object, e As System.EventArgs) Handles HowToPlayBlackjackbtn.Click
        'Takes user to How to Play Blackjack Screen
        Me.Hide()
        HowToPlayBlackjackfrm.Show()
    End Sub
End Class