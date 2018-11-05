Public Class HangmanMainMenufrm

    Private Sub HangmanMainMenufrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles MainMenu1Btn.Click
        'Takes the user back to the main menu
        Me.Hide()
        MainMenufrm.Show()
    End Sub

    Private Sub PlayerVsComputerBtn_Click(sender As System.Object, e As System.EventArgs) Handles PlayerVsComputerBtn.Click
        'Takes user to One player screen
        Me.Hide()
        PlayerVsComputerfrm.Show()
    End Sub

    Private Sub PlayerVsPlayerBtn_Click(sender As System.Object, e As System.EventArgs) Handles PlayerVsPlayerBtn.Click
        'Takes user to Two Player Screen
        Me.Hide()
        PlayerVsPlayerfrm.Show()
    End Sub

    Private Sub AlterWordsBtn_Click(sender As System.Object, e As System.EventArgs) Handles AlterWordsBtn.Click
        'Takes user to Alter Words Screen
        Me.Hide()
        AlterWordsfrm.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles HowToPlaybtn.Click
        'Takes user to how to play screen
        Me.Hide()
        HowToPlayfrm.Show()
    End Sub
End Class