Imports System.IO
Public Class AlterWordsfrm
    Dim Read As String
    Dim Reader As String()
    Dim NewWords As String
    Dim DeleteWord As String
    Dim CharacterCheck As Boolean
    Dim posFirstFound As Integer
    Dim Found = False
    Dim Count As Integer
    Dim NumOfWords As Integer
    Public Position As Integer
    Dim temp As String

    Private Sub AlterWordsfrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'read the file's lines into an ArrayList
        ListOfWordslst.Items.Clear()  'clears the List Box
        Read = My.Computer.FileSystem.ReadAllText("Hangman\words.txt")
        Reader = Read.Split(vbNewLine)
        ListOfWordslst.Items.AddRange(Reader)
    End Sub

    Private Sub BackBtn_Click(sender As System.Object, e As System.EventArgs) Handles BackBtn.Click
        'Sends user back to the hangman menu
        HangmanMainMenufrm.Show()
        Me.Close()
    End Sub

    Private Sub AddWordsBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddWordBtn.Click
        'inputs the new word into the listbox
        CharacterCheck = IsNumeric(InputWordstxt.Text)
        If CharacterCheck = False And InputWordstxt.Text <> "" Then
            If Len(InputWordstxt.Text) <= 8 And Len(InputWordstxt.Text) >= 2 Then
                Search()
                If Found = False Then
                    NewWords = InputWordstxt.Text
                    My.Computer.FileSystem.WriteAllText("Hangman\Words.txt", vbNewLine, True) 'writes out a new line before writing out the actual word
                    My.Computer.FileSystem.WriteAllText("Hangman\Words.txt", NewWords, True)
                    ListOfWordslst.Items.Clear()  'clears the List Box
                    Read = My.Computer.FileSystem.ReadAllText("Hangman\Words.txt")
                    Reader = Read.Split(vbNewLine)
                    ListOfWordslst.Items.AddRange(Reader)
                    NumOfWords = IO.File.ReadAllText("Hangman\words.txt").Split(vbNewLine).Count
                    If NumOfWords > 1 Then
                        DeleteWordsbtn.Enabled = True
                    End If
                Else
                    MsgBox("This word already exists, please enter a new word")
                End If

            ElseIf Len(InputWordstxt.Text) > 8 Then
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
        InputWordstxt.Text = ""
    End Sub

    Private Sub DeleteWordsbtn_Click(sender As System.Object, e As System.EventArgs) Handles DeleteWordsbtn.Click
        DeleteWord = DeleteWordtxt.Text
        CharacterCheck = IsNumeric(DeleteWord)
        If CharacterCheck = False And DeleteWordtxt.Text <> "" Then
            If Len(DeleteWordtxt.Text) <= 8 And Len(DeleteWordtxt.Text) >= 2 Then
                SearchAndDelete()
                If Found = False Then
                    MsgBox("The word does not exist. Please re-enter.")
                End If
            ElseIf Len(DeleteWordtxt.Text) > 8 Then
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
        DeleteWordtxt.Text = ""
    End Sub

    Public Sub Search()
        Dim Words() = IO.File.ReadAllLines("Hangman\words.txt")
        NumOfWords = IO.File.ReadAllText("Hangman\words.txt").Split(vbNewLine).Count ' used to calculate the number of words
        Count = 0
        Found = False
        While Count < NumOfWords And Found = False
            If InputWordstxt.Text = Words(Count) Then
                Found = True
                Position = Count
            End If
            Count += 1
        End While
    End Sub

    Public Sub SearchAndDelete()
        Dim Words() = IO.File.ReadAllLines("Hangman\words.txt")
        NumOfWords = IO.File.ReadAllText("Hangman\words.txt").Split(vbNewLine).Count ' used to calculate the number of words
        Count = 0
        Found = False
        While Count < NumOfWords And Found = False
            If DeleteWordtxt.Text = Words(Count) Then
                Position = Count
                Found = True
            End If
            Count += 1
        End While
        If Found = True Then
            Dim lines As New List(Of String)(File.ReadAllLines("Hangman\words.txt"))
            lines.RemoveAt(Position)
            FileOpen(1, "words.txt", OpenMode.Output) ' Open file for output.
            PrintLine(1, lines(0))
            FileClose(1)
            FileOpen(1, "words.txt", OpenMode.Append) ' Open file for appending.
            For Me.Count = 1 To (lines.Count - 2)
                PrintLine(1, lines(Count))              'prints each line in successively from list
            Next
            Print(1, lines(Count))                      'prints last line and no return carriage
            FileClose(1)                                'closes file
            ListOfWordslst.Items.Clear()
            Read = My.Computer.FileSystem.ReadAllText("Hangman\Words.txt")
            Reader = Read.Split(vbNewLine)
            ListOfWordslst.Items.AddRange(Reader)
            Words = File.ReadAllLines("Hangman\words.txt")
            NumOfWords = IO.File.ReadAllText("Hangman\words.txt").Split(vbNewLine).Count
            If NumOfWords = 1 Then
                DeleteWordsbtn.Enabled = False      'stops user from deleting all the words
            End If
        End If
    End Sub

    Private Sub ToolTip1_Popup(sender As System.Object, e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class


