Imports System.IO
Public Class PlayerVsComputerfrm
    Dim CharacterCheck As Boolean
    Dim AlreadyInput As Boolean
    Dim Incorrect As Integer = 0
    Dim Correct As Integer = 0
    Dim CorrectLetter As Boolean
    Dim GuessWords(1000) As String
    Dim Count As Integer
    Dim NumOfWords As Integer
    Dim Reader As StreamReader = New StreamReader("Hangman\words.txt")
    Dim HiddenWord As String
    Dim WordLength As Integer
    Dim Temp As String
    Dim Rand As Integer
    Dim Index As Integer
    Dim Counter As Integer
    Dim CorrectWord(8) As Char

    Public Sub StartGame() 'used to start the entire game
        InputLettertxt.Focus()
        Randomize()
        For Me.Count = 1 To NumOfWords 'used to place all of the words in a text file and jumble up
            Rand = Int(NumOfWords * Rnd()) + 1
            Temp = GuessWords(Count)
            GuessWords(Count) = GuessWords(Rand)
            GuessWords(Rand) = Temp
        Next Count
        HiddenWord = GuessWords(1)
        CorrectWord = HiddenWord.ToCharArray()
        WordLength = Len(HiddenWord)
        If WordLength = 2 Then          'all of these are checking wordlength and showing the appropriate setup
            Character1lbl.Visible = True
            Letter1.Text = CorrectWord(0)
            Character2lbl.Visible = True
            Letter2.Text = CorrectWord(1)
        ElseIf WordLength = 3 Then
            Character1lbl.Visible = True
            Letter1.Text = CorrectWord(0)
            Character2lbl.Visible = True
            Letter2.Text = CorrectWord(1)
            Character3lbl.Visible = True
            Letter3.Text = CorrectWord(2)
        ElseIf WordLength = 4 Then
            Character1lbl.Visible = True
            Letter1.Text = CorrectWord(0)
            Character2lbl.Visible = True
            Letter2.Text = CorrectWord(1)
            Character3lbl.Visible = True
            Letter3.Text = CorrectWord(2)
            Character4lbl.Visible = True
            Letter4.Text = CorrectWord(3)
        ElseIf WordLength = 5 Then
            Character1lbl.Visible = True
            Letter1.Text = CorrectWord(0)
            Character2lbl.Visible = True
            Letter2.Text = CorrectWord(1)
            Character3lbl.Visible = True
            Letter3.Text = CorrectWord(2)
            Character4lbl.Visible = True
            Letter4.Text = CorrectWord(3)
            Character5lbl.Visible = True
            Letter5.Text = CorrectWord(4)
        ElseIf WordLength = 6 Then
            Character1lbl.Visible = True
            Letter1.Text = CorrectWord(0)
            Character2lbl.Visible = True
            Letter2.Text = CorrectWord(1)
            Character3lbl.Visible = True
            Letter3.Text = CorrectWord(2)
            Character4lbl.Visible = True
            Letter4.Text = CorrectWord(3)
            Character5lbl.Visible = True
            Letter5.Text = CorrectWord(4)
            Character6lbl.Visible = True
            Letter6.Text = CorrectWord(5)
        ElseIf WordLength = 7 Then
            Character1lbl.Visible = True
            Letter1.Text = CorrectWord(0)
            Character2lbl.Visible = True
            Letter2.Text = CorrectWord(1)
            Character3lbl.Visible = True
            Letter3.Text = CorrectWord(2)
            Character4lbl.Visible = True
            Letter4.Text = CorrectWord(3)
            Character5lbl.Visible = True
            Letter5.Text = CorrectWord(4)
            Character6lbl.Visible = True
            Letter6.Text = CorrectWord(5)
            Character7lbl.Visible = True
            Letter7.Text = CorrectWord(6)
        Else
            Character1lbl.Visible = True
            Letter1.Text = CorrectWord(0)
            Character2lbl.Visible = True
            Letter2.Text = CorrectWord(1)
            Character3lbl.Visible = True
            Letter3.Text = CorrectWord(2)
            Character4lbl.Visible = True
            Letter4.Text = CorrectWord(3)
            Character5lbl.Visible = True
            Letter5.Text = CorrectWord(4)
            Character6lbl.Visible = True
            Letter6.Text = CorrectWord(5)
            Character7lbl.Visible = True
            Letter7.Text = CorrectWord(6)
            Character8lbl.Visible = True
            Letter8.Text = CorrectWord(7)
        End If
    End Sub

    Public Sub ResetGame() 'used to completely reset the game back to default state
        LettersGuessedlst.Items.Clear()
        Randomize()
        Character1lbl.Visible = False
        Character2lbl.Visible = False
        Character3lbl.Visible = False
        Character4lbl.Visible = False
        Character5lbl.Visible = False
        Character6lbl.Visible = False
        Character7lbl.Visible = False
        Character8lbl.Visible = False
        Line1.Visible = False
        Line2.Visible = False
        Line3.Visible = False
        Line4.Visible = False
        Line5.Visible = False
        Line6.Visible = False
        Line7.Visible = False
        Line8.Visible = False
        Line9.Visible = False
        Line10.Visible = False
        Letter1.Visible = False
        Letter2.Visible = False
        Letter3.Visible = False
        Letter4.Visible = False
        Letter5.Visible = False
        Letter6.Visible = False
        Letter7.Visible = False
        Letter8.Visible = False
        Correct = 0
        Incorrect = 0
        StartGame()
    End Sub

    Private Sub ExitBtn_Click(sender As System.Object, e As System.EventArgs) Handles ExitBtn.Click
        'Returns user to main hangman menu
        Me.Hide()
        HangmanMainMenufrm.Show()
        ResetGame()
    End Sub

    Private Sub EnterLetterBtn_Click(sender As System.Object, e As System.EventArgs) Handles EnterLetterBtn.Click
        AlreadyInput = False
        CorrectLetter = False
        CharacterCheck = IsNumeric(InputLettertxt.Text)     'checks it is a character
        If CharacterCheck = False Then
            If InputLettertxt.Text <> "" Then               'checks something is in the text box
                For Each item As Object In Me.LettersGuessedlst.Items
                    If item.ToString = InputLettertxt.Text Then     'checks to see it hasn't already been input
                        AlreadyInput = True
                    End If
                Next
                If AlreadyInput = False Then
                    LettersGuessedlst.Items.Add(InputLettertxt.Text)
                    Index = -1
                    While Index < (Len(HiddenWord) - 1)
                        Index = Index + 1
                        If InputLettertxt.Text = CorrectWord(Index) Then 'checks to see if the letter matches
                            CorrectLetter = True
                            Correct = Correct + 1
                        End If
                    End While
                    If CorrectLetter = True Then
                        CheckLetter()                               'checks to see which letter(s) need to be shown
                        If Correct = Len(HiddenWord) Then
                            MsgBox("You win!! Congratulations!")
                            Me.Hide()
                            HangmanMainMenufrm.Show()
                            ResetGame()
                        End If
                    Else
                        Incorrect = Incorrect + 1           'used to show the hangman pieces
                        If Incorrect = 1 Then
                            Line1.Visible = True
                        ElseIf Incorrect = 2 Then
                            Line2.Visible = True
                        ElseIf Incorrect = 3 Then
                            Line3.Visible = True
                        ElseIf Incorrect = 4 Then
                            Line4.Visible = True
                        ElseIf Incorrect = 5 Then
                            Line5.Visible = True
                        ElseIf Incorrect = 6 Then
                            Line6.Visible = True
                        ElseIf Incorrect = 7 Then
                            Line7.Visible = True
                        ElseIf Incorrect = 8 Then
                            Line8.Visible = True
                        ElseIf Incorrect = 9 Then
                            Line9.Visible = True
                        Else
                            Line10.Visible = True
                            MsgBox("You have lost. The word was " + HiddenWord)
                            Me.Hide()
                            HangmanMainMenufrm.Show()
                            ResetGame()
                        End If
                    End If
                Else
                    MsgBox("This letter has already been input. Try again.")
                End If
            Else
                MsgBox("Please input a letter into the textbox before clicking Enter Letter.")
            End If
        Else
            MsgBox("The input letter must be a letter. Please try again.")
        End If
        InputLettertxt.Text = ""
        InputLettertxt.Focus()
    End Sub

    Private Sub PlayerVsComputerfrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NumOfWords = IO.File.ReadAllText("Hangman\words.txt").Split(vbNewLine).Count ' used to calculate the number of words
        For Me.Count = 1 To NumOfWords
            GuessWords(Count) = Reader.ReadLine()
        Next Count
        StartGame()
        InputLettertxt.Focus()
    End Sub

    Public Sub CheckLetter()                'used to determine if the letter needs to be shown
        If WordLength = 2 Then
            If Letter1.Text = InputLettertxt.Text Then
                Letter1.Visible = True
                Character1lbl.Visible = False
            End If
            If Letter2.Text = InputLettertxt.Text Then
                Letter2.Visible = True
                Character2lbl.Visible = False
            End If
        ElseIf WordLength = 3 Then
            If Letter1.Text = InputLettertxt.Text Then
                Letter1.Visible = True
                Character1lbl.Visible = False
            End If
            If Letter2.Text = InputLettertxt.Text Then
                Letter2.Visible = True
                Character2lbl.Visible = False
            End If
            If Letter3.Text = InputLettertxt.Text Then
                Letter3.Visible = True
                Character3lbl.Visible = False
            End If
        ElseIf WordLength = 4 Then
            If Letter1.Text = InputLettertxt.Text Then
                Letter1.Visible = True
                Character1lbl.Visible = False
            End If
            If Letter2.Text = InputLettertxt.Text Then
                Letter2.Visible = True
                Character2lbl.Visible = False
            End If
            If Letter3.Text = InputLettertxt.Text Then
                Letter3.Visible = True
                Character3lbl.Visible = False
            End If
            If Letter4.Text = InputLettertxt.Text Then
                Letter4.Visible = True
                Character4lbl.Visible = False
            End If
        ElseIf WordLength = 5 Then
            If Letter1.Text = InputLettertxt.Text Then
                Letter1.Visible = True
                Character1lbl.Visible = False
            End If
            If Letter2.Text = InputLettertxt.Text Then
                Letter2.Visible = True
                Character2lbl.Visible = False
            End If
            If Letter3.Text = InputLettertxt.Text Then
                Letter3.Visible = True
                Character3lbl.Visible = False
            End If
            If Letter4.Text = InputLettertxt.Text Then
                Letter4.Visible = True
                Character4lbl.Visible = False
            End If
            If Letter5.Text = InputLettertxt.Text Then
                Letter5.Visible = True
                Character5lbl.Visible = False
            End If
        ElseIf WordLength = 6 Then
            If Letter1.Text = InputLettertxt.Text Then
                Letter1.Visible = True
                Character1lbl.Visible = False
            End If
            If Letter2.Text = InputLettertxt.Text Then
                Letter2.Visible = True
                Character2lbl.Visible = False
            End If
            If Letter3.Text = InputLettertxt.Text Then
                Letter3.Visible = True
                Character3lbl.Visible = False
            End If
            If Letter4.Text = InputLettertxt.Text Then
                Letter4.Visible = True
                Character4lbl.Visible = False
            End If
            If Letter5.Text = InputLettertxt.Text Then
                Letter5.Visible = True
                Character5lbl.Visible = False
            End If
            If Letter6.Text = InputLettertxt.Text Then
                Letter6.Visible = True
                Character6lbl.Visible = False
            End If
        ElseIf WordLength = 7 Then
            If Letter1.Text = InputLettertxt.Text Then
                Letter1.Visible = True
                Character1lbl.Visible = False
            End If
            If Letter2.Text = InputLettertxt.Text Then
                Letter2.Visible = True
                Character2lbl.Visible = False
            End If
            If Letter3.Text = InputLettertxt.Text Then
                Letter3.Visible = True
                Character3lbl.Visible = False
            End If
            If Letter4.Text = InputLettertxt.Text Then
                Letter4.Visible = True
                Character4lbl.Visible = False
            End If
            If Letter5.Text = InputLettertxt.Text Then
                Letter5.Visible = True
                Character5lbl.Visible = False
            End If
            If Letter6.Text = InputLettertxt.Text Then
                Letter6.Visible = True
                Character6lbl.Visible = False
            End If
            If Letter7.Text = InputLettertxt.Text Then
                Letter7.Visible = True
                Character7lbl.Visible = False
            End If
        Else
            If Letter1.Text = InputLettertxt.Text Then
                Letter1.Visible = True
                Character1lbl.Visible = False
            End If
            If Letter2.Text = InputLettertxt.Text Then
                Letter2.Visible = True
                Character2lbl.Visible = False
            End If
            If Letter3.Text = InputLettertxt.Text Then
                Letter3.Visible = True
                Character3lbl.Visible = False
            End If
            If Letter4.Text = InputLettertxt.Text Then
                Letter4.Visible = True
                Character4lbl.Visible = False
            End If
            If Letter5.Text = InputLettertxt.Text Then
                Letter5.Visible = True
                Character5lbl.Visible = False
            End If
            If Letter6.Text = InputLettertxt.Text Then
                Letter6.Visible = True
                Character6lbl.Visible = False
            End If
            If Letter7.Text = InputLettertxt.Text Then
                Letter7.Visible = True
                Character7lbl.Visible = False
            End If
            If Letter8.Text = InputLettertxt.Text Then
                Letter8.Visible = True
                Character8lbl.Visible = False
            End If
        End If
    End Sub
End Class