Public Class BlackjackGamefrm
    Dim CardNumber As Integer
    Dim i, r, temp As Integer
    Public nums(52) As Integer
    Dim Count As Integer
    Private CardSum As Integer
    Dim Value As Integer
    Dim CardValue As Integer
    Public PlayerCardSum As Integer
    Public DealerCardSum As Integer
    Dim BetMoney As Integer
    Dim Ask As MsgBoxResult
    Dim DealerCount As Integer
    Dim FiveCards As Boolean
    Dim PlayerBlackjack As Boolean
    Dim DealerBlackjack As Boolean
    Dim DealerBust As Boolean
    Dim AceOne As Boolean
    Dim AceTwo As Boolean
    Dim DealerCardSumSeventeen As Boolean

    Private Sub NewGamefrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Bet = 5
        InfoLbl.Text = "The current bet is at $" + Str(Bet) + "."
        TotalLbl.Text = "You currently have $" + Str(Total) + "."
        CardSum = 0
        Shuffle()
        Count = 1
        GetCard(PlayerCardOne, nums(Count))
        PlayerCardSum = CardTotal(Count)
        PlayerSumlbl.Text = "The total of your hand is " + Str(PlayerCardSum) + "."
        DealerCardSum = 0
        DealerCount = 1
        FiveCards = False
        DealerBlackjack = False
        PlayerBlackjack = False
        DealerBust = False
        AceOne = False
        AceTwo = False
        DealerCardSumSeventeen = False
    End Sub

    Private Sub Raise_Click(sender As System.Object, e As System.EventArgs) Handles RaiseBtn.Click
        If Bet + 5 <= Total Then
            Bet = Bet + 5
            InfoLbl.Text = "The current bet is at $" + Str(Bet) + "."
        Else
            MsgBox("You cannot bet more than you have!")
        End If
    End Sub

    Private Sub LowerBtn_Click(sender As System.Object, e As System.EventArgs) Handles LowerBtn.Click
        If Bet - 5 > 0 Then
            Bet = Bet - 5
            InfoLbl.Text = "The current bet is at $" + Str(Bet) + "."
        Else
            MsgBox("You cannot bet nothing!")
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As System.Object, e As System.EventArgs) Handles ExitBtn.Click
        If Total > 0 Then            'ensures the user has money to save
            Ask = MsgBox("Do you want to save before you quit?", MsgBoxStyle.YesNoCancel) 'asks the user if they want to save
            If Ask = MsgBoxResult.Yes Then
                FileOpen(1, "Blackjack\Save File.txt", OpenMode.Output)
                Print(1, Total)
                FileClose(1)
                BlackjackMainMenufrm.ContinueGameBtn.Enabled = True
                BlackjackMainMenufrm.Show()
                Me.Close()
            ElseIf Ask = MsgBoxResult.No Then
                BlackjackMainMenufrm.Show()
                Me.Close()
            End If
        Else
            BlackjackMainMenufrm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub HoldBtn_Click(sender As System.Object, e As System.EventArgs) Handles HoldBtn.Click
        FindDealerHand()
    End Sub

    Private Sub GetCard(Card, CardNumber)
        If CardNumber = 1 Then
            Card.Image = Image.FromFile("Blackjack\Ace of Diamonds.png")
        ElseIf CardNumber = 2 Then
            Card.Image = Image.FromFile("Blackjack\Two of Diamonds.png")
        ElseIf CardNumber = 3 Then
            Card.Image = Image.FromFile("Blackjack\Three of Diamonds.png")
        ElseIf CardNumber = 4 Then
            Card.Image = Image.FromFile("Blackjack\Four of Diamonds.png")
        ElseIf CardNumber = 5 Then
            Card.Image = Image.FromFile("Blackjack\Five of Diamonds.png")
        ElseIf CardNumber = 6 Then
            Card.Image = Image.FromFile("Blackjack\Six of Diamonds.png")
        ElseIf CardNumber = 7 Then
            Card.Image = Image.FromFile("Blackjack\Seven of Diamonds.png")
        ElseIf CardNumber = 8 Then
            Card.Image = Image.FromFile("Blackjack\Eight of Diamonds.png")
        ElseIf CardNumber = 9 Then
            Card.Image = Image.FromFile("Blackjack\Nine of Diamonds.png")
        ElseIf CardNumber = 10 Then
            Card.Image = Image.FromFile("Blackjack\Ten of Diamonds.png")
        ElseIf CardNumber = 11 Then
            Card.Image = Image.FromFile("Blackjack\Jack of Diamonds.png")
        ElseIf CardNumber = 12 Then
            Card.Image = Image.FromFile("Blackjack\Queen of Diamonds.png")
        ElseIf CardNumber = 13 Then
            Card.Image = Image.FromFile("Blackjack\King of Diamonds.png")
        ElseIf CardNumber = 14 Then
            Card.Image = Image.FromFile("Blackjack\Ace of Clubs.png")
        ElseIf CardNumber = 15 Then
            Card.Image = Image.FromFile("Blackjack\Two of Clubs.png")
        ElseIf CardNumber = 16 Then
            Card.Image = Image.FromFile("Blackjack\Three of Clubs.png")
        ElseIf CardNumber = 17 Then
            Card.Image = Image.FromFile("Blackjack\Four of Clubs.png")
        ElseIf CardNumber = 18 Then
            Card.Image = Image.FromFile("Blackjack\Five of Clubs.png")
        ElseIf CardNumber = 19 Then
            Card.Image = Image.FromFile("Blackjack\Six of Clubs.png")
        ElseIf CardNumber = 20 Then
            Card.Image = Image.FromFile("Blackjack\Seven of Clubs.png")
        ElseIf CardNumber = 21 Then
            Card.Image = Image.FromFile("Blackjack\Eight of Clubs.png")
        ElseIf CardNumber = 22 Then
            Card.Image = Image.FromFile("Blackjack\Nine of Clubs.png")
        ElseIf CardNumber = 23 Then
            Card.Image = Image.FromFile("Blackjack\Ten of Clubs.png")
        ElseIf CardNumber = 24 Then
            Card.Image = Image.FromFile("Blackjack\Jack of Clubs.png")
        ElseIf CardNumber = 25 Then
            Card.Image = Image.FromFile("Blackjack\Queen of Clubs.png")
        ElseIf CardNumber = 26 Then
            Card.Image = Image.FromFile("Blackjack\King of Clubs.png")
        ElseIf CardNumber = 27 Then
            Card.Image = Image.FromFile("Blackjack\Ace of Hearts.png")
        ElseIf CardNumber = 28 Then
            Card.Image = Image.FromFile("Blackjack\Two of Hearts.png")
        ElseIf CardNumber = 29 Then
            Card.Image = Image.FromFile("Blackjack\Three of Hearts.png")
        ElseIf CardNumber = 30 Then
            Card.Image = Image.FromFile("Blackjack\Four of Hearts.png")
        ElseIf CardNumber = 31 Then
            Card.Image = Image.FromFile("Blackjack\Five of Hearts.png")
        ElseIf CardNumber = 32 Then
            Card.Image = Image.FromFile("Blackjack\Six of Hearts.png")
        ElseIf CardNumber = 33 Then
            Card.Image = Image.FromFile("Blackjack\Seven of Hearts.png")
        ElseIf CardNumber = 34 Then
            Card.Image = Image.FromFile("Blackjack\Eight of Hearts.png")
        ElseIf CardNumber = 35 Then
            Card.Image = Image.FromFile("Blackjack\Nine of Hearts.png")
        ElseIf CardNumber = 36 Then
            Card.Image = Image.FromFile("Blackjack\Ten of Hearts.png")
        ElseIf CardNumber = 37 Then
            Card.Image = Image.FromFile("Blackjack\Jack of Hearts.png")
        ElseIf CardNumber = 38 Then
            Card.Image = Image.FromFile("Blackjack\Queen of Hearts.png")
        ElseIf CardNumber = 39 Then
            Card.Image = Image.FromFile("Blackjack\King of Hearts.png")
        ElseIf CardNumber = 40 Then
            Card.Image = Image.FromFile("Blackjack\Ace of Spades.png")
        ElseIf CardNumber = 41 Then
            Card.Image = Image.FromFile("Blackjack\Two of Spades.png")
        ElseIf CardNumber = 42 Then
            Card.Image = Image.FromFile("Blackjack\Three of Spades.png")
        ElseIf CardNumber = 43 Then
            Card.Image = Image.FromFile("Blackjack\Four of Spades.png")
        ElseIf CardNumber = 44 Then
            Card.Image = Image.FromFile("Blackjack\Five of Spades.png")
        ElseIf CardNumber = 45 Then
            Card.Image = Image.FromFile("Blackjack\Six of Spades.png")
        ElseIf CardNumber = 46 Then
            Card.Image = Image.FromFile("Blackjack\Seven of Spades.png")
        ElseIf CardNumber = 47 Then
            Card.Image = Image.FromFile("Blackjack\Eight of Spades.png")
        ElseIf CardNumber = 48 Then
            Card.Image = Image.FromFile("Blackjack\Nine of Spades.png")
        ElseIf CardNumber = 49 Then
            Card.Image = Image.FromFile("Blackjack\Ten of Spades.png")
        ElseIf CardNumber = 50 Then
            Card.Image = Image.FromFile("Blackjack\Jack of Spades.png")
        ElseIf CardNumber = 51 Then
            Card.Image = Image.FromFile("Blackjack\Queen of Spades.png")
        Else
            Card.Image = Image.FromFile("Blackjack\King of Spades.png")
        End If
    End Sub

    Public Sub Shuffle() 'used to shuffle the cards after every round
        'Fills the elements in the array with the numbers 1 to 52
        For Me.i = 1 To 52
            nums(i) = i
        Next

        'Shuffles the numbers inside the array
        Randomize()
        For Me.i = 1 To 52
            r = Int(52 * Rnd()) + 1
            temp = nums(i)
            nums(i) = nums(r)
            nums(r) = temp
        Next
    End Sub

    Private Sub AnotherCardBtn_Click(sender As System.Object, e As System.EventArgs) Handles AnotherCardBtn.Click
        Count += 1
        If Count = 3 Then
            GetCard(PlayerCardThree, nums(Count))
        ElseIf Count = 4 Then
            GetCard(PlayerCardFour, nums(Count))
        Else
            GetCard(PlayerCardFive, nums(Count))
            FiveCards = True
        End If
        PlayerCardSum += CardTotal(Count)
        If PlayerCardSum > 21 And AceOne = True Then
            PlayerCardSum -= 10
            AceOne = False
        ElseIf PlayerCardSum > 21 And AceTwo = True Then
            PlayerCardSum -= 10
            AceTwo = False
        End If
        PlayerSumlbl.Text = "The total of your hand is " + Str(PlayerCardSum) + "."
        If PlayerCardSum > 21 Then
            MsgBox("You are bust, the dealer wins.")
            ResetGame()
            If Total = 0 Then
                MsgBox("You are currently out of money. You have lost the game.")
                BlackjackMainMenufrm.Show()
                Me.Close()
            End If
        ElseIf Count = 5 Then
            FindDealerHand()
        ElseIf PlayerCardSum = 21 Then
            AnotherCardBtn.Enabled = False
        End If
    End Sub

    Private Function CardTotal(Count)
        If Count = 1 Then
            CardValues(Count, CardSum)
        ElseIf Count = 2 Then
            CardValues(Count, CardSum)
        ElseIf Count = 3 Then
            CardValues(Count, CardSum)
        ElseIf Count = 4 Then
            CardValues(Count, CardSum)
        Else
            CardValues(Count, CardSum)
        End If
        Return CardSum
    End Function

    Private Sub CardValues(Count, ByRef CardSum)
        CardSum = 0
        If nums(Count) = 2 Or nums(Count) = 15 Or nums(Count) = 28 Or nums(Count) = 41 Then
            CardSum += 2
        ElseIf nums(Count) = 3 Or nums(Count) = 16 Or nums(Count) = 29 Or nums(Count) = 42 Then
            CardSum += 3
        ElseIf nums(Count) = 4 Or nums(Count) = 17 Or nums(Count) = 30 Or nums(Count) = 43 Then
            CardSum += 4
        ElseIf nums(Count) = 5 Or nums(Count) = 18 Or nums(Count) = 31 Or nums(Count) = 44 Then
            CardSum += 5
        ElseIf nums(Count) = 6 Or nums(Count) = 19 Or nums(Count) = 32 Or nums(Count) = 45 Then
            CardSum += 6
        ElseIf nums(Count) = 7 Or nums(Count) = 20 Or nums(Count) = 33 Or nums(Count) = 46 Then
            CardSum += 7
        ElseIf nums(Count) = 8 Or nums(Count) = 21 Or nums(Count) = 34 Or nums(Count) = 47 Then
            CardSum += 8
        ElseIf nums(Count) = 9 Or nums(Count) = 22 Or nums(Count) = 35 Or nums(Count) = 48 Then
            CardSum += 9
        ElseIf nums(Count) = 10 Or nums(Count) = 11 Or nums(Count) = 12 Or nums(Count) = 13 Or nums(Count) = 23 Or nums(Count) = 24 Or _
            nums(Count) = 25 Or nums(Count) = 26 Or nums(Count) = 36 Or nums(Count) = 37 Or nums(Count) = 38 Or nums(Count) = 39 _
            Or nums(Count) = 49 Or nums(Count) = 50 Or nums(Count) = 51 Or nums(Count) = 52 Then
            CardSum += 10
        ElseIf nums(Count) = 1 Or nums(Count) = 14 Or nums(Count) = 27 Or nums(Count) = 40 Then
            CardSum += 11
            If AceOne = False Then
                AceOne = True
            Else
                AceTwo = True
            End If
        End If
    End Sub

    Private Sub ResetGame()
        Count = 1
        Randomize()
        PlayerCardOne.Image = Nothing
        PlayerCardTwo.Image = Nothing
        PlayerCardThree.Image = Nothing
        PlayerCardFour.Image = Nothing
        PlayerCardFive.Image = Nothing
        DealerCardOne.Image = Nothing
        DealerCardTwo.Image = Nothing
        DealerCardThree.Image = Nothing
        DealerCardFour.Image = Nothing
        DealerCardFive.Image = Nothing
        PlayerCardSum = 0
        DealerCardSum = 0
        DealerCount = 1
        DealerCardSumSeventeen = False
        Shuffle()
        BetBtn.Enabled = True
        RaiseBtn.Enabled = True
        LowerBtn.Enabled = True
        BetEverythingBtn.Enabled = True
        BetMinimumBtn.Enabled = True
        AnotherCardBtn.Enabled = False
        HoldBtn.Enabled = False
        FiveCards = False
        DealerBlackjack = False
        PlayerBlackjack = False
        DealerBust = False
        AceOne = False
        AceTwo = False
        GetCard(PlayerCardOne, nums(Count))
        PlayerCardSum += CardTotal(Count)
        PlayerSumlbl.Text = "The total of your hand is " + Str(PlayerCardSum) + "."
        Bet = 5
        InfoLbl.Text = "The current bet is at $" + Str(Bet) + "."
        TotalLbl.Text = "You currently have $" + Str(Total) + "."
        DealerSumLbl.Text = ""
    End Sub

    Private Sub BetBtn_Click(sender As System.Object, e As System.EventArgs) Handles BetBtn.Click
        Count = 2
        AnotherCardBtn.Enabled = True
        HoldBtn.Enabled = True
        BetBtn.Enabled = False
        RaiseBtn.Enabled = False
        LowerBtn.Enabled = False
        BetEverythingBtn.Enabled = False
        BetMinimumBtn.Enabled = False
        BetMoney = Bet
        Total -= Bet
        TotalLbl.Text = "You currently have $" + Str(Total) + "."
        GetCard(PlayerCardTwo, nums(Count))
        PlayerCardSum += CardTotal(Count)
        If PlayerCardSum > 21 And AceOne = True Then
            PlayerCardSum -= 10
            AceOne = False
        End If
        InfoLbl.Text = "You have bet $" + Str(Bet) + "."
        PlayerSumlbl.Text = "The total of your hand is " + Str(PlayerCardSum) + "."
        If PlayerCardSum = 21 Then
            PlayerBlackjack = True
        End If
    End Sub

    Public Sub FindDealerHand()
        AceOne = False
        AceTwo = False
        DealerCardSumSeventeen = False
        While DealerCardSumSeventeen = False
            Count += 1
            If DealerCount = 1 Then
                GetCard(DealerCardOne, nums(Count))
            ElseIf DealerCount = 2 Then
                GetCard(DealerCardTwo, nums(Count))
            ElseIf DealerCount = 3 Then
                GetCard(DealerCardThree, nums(Count))
            ElseIf DealerCount = 4 Then
                GetCard(DealerCardFour, nums(Count))
            Else
                GetCard(DealerCardFive, nums(Count))
            End If
            DealerCardSum += CardTotal(Count)
            DealerCount += 1
            If DealerCardSum > 21 And AceOne = True Then
                DealerCardSum -= 10
                AceOne = False
            ElseIf DealerCardSum > 21 And AceTwo = True Then
                DealerCardSum -= 10
                AceTwo = False
            End If
            DealerSumLbl.Text = "The total of the dealers hand is " + Str(DealerCardSum) + "."
            If DealerCardSum >= 17 Or DealerCount = 5 Then
                DealerCardSumSeventeen = True
            End If
        End While
        If DealerCardSum > 21 Then
            DealerBust = True
        End If
        If DealerCount = 2 And DealerCardSum = 21 Then
            DealerBlackjack = True
        End If
        Compare()
    End Sub

    Private Sub Compare()
        
        If PlayerBlackjack = True And DealerBlackjack = False Then
            Total += (BetMoney * 3)
            MsgBox("You have beaten the dealer and tripled your bet!")
        ElseIf PlayerBlackjack = True And DealerBlackjack = True Then
            Total += BetMoney
            MsgBox("You have drawn with the dealer. You get the money you bet returned.")
        ElseIf FiveCards = True And DealerBlackjack = False Then
            Total += (BetMoney * 4)
            MsgBox("You have beaten the dealer and quadrupled your bet!")
        ElseIf FiveCards = True And DealerBlackjack = True Then
            MsgBox("You have lost to the dealer. You lose your bet")
        ElseIf PlayerCardSum > DealerCardSum Or DealerBust = True Then
            Total += (BetMoney * 2)
            MsgBox("You have beaten the dealer and doubled your bet!")
        ElseIf PlayerCardSum = DealerCardSum Then
            Total += BetMoney
            MsgBox("You have drawn with the dealer. You get the money you bet returned.")
        Else
            MsgBox("You have lost to the dealer. You lose your bet")
        End If
        If Total = 0 Then
            MsgBox("You are currently out of money. You have lost the game.")
            BlackjackMainMenufrm.Show()
            Me.Close()
        Else
            ResetGame()
        End If
    End Sub

    Private Sub BetEverythingBtn_Click(sender As System.Object, e As System.EventArgs) Handles BetEverythingBtn.Click
        Bet = Total
        InfoLbl.Text = "The current bet is at $" + Str(Bet) + "."
    End Sub

    Private Sub BetMinimumBtn_Click(sender As System.Object, e As System.EventArgs) Handles BetMinimumBtn.Click
        Bet = 5
        InfoLbl.Text = "The current bet is at $" + Str(Bet) + "."
    End Sub
End Class