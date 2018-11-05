<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackjackGamefrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RaiseBtn = New System.Windows.Forms.Button()
        Me.BetBtn = New System.Windows.Forms.Button()
        Me.LowerBtn = New System.Windows.Forms.Button()
        Me.AnotherCardBtn = New System.Windows.Forms.Button()
        Me.HoldBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.InfoLbl = New System.Windows.Forms.Label()
        Me.TotalLbl = New System.Windows.Forms.Label()
        Me.PlayerCardTwo = New System.Windows.Forms.PictureBox()
        Me.PlayerCardOne = New System.Windows.Forms.PictureBox()
        Me.PlayerCardThree = New System.Windows.Forms.PictureBox()
        Me.PlayerCardFour = New System.Windows.Forms.PictureBox()
        Me.PlayerCardFive = New System.Windows.Forms.PictureBox()
        Me.DealerCardFive = New System.Windows.Forms.PictureBox()
        Me.DealerCardFour = New System.Windows.Forms.PictureBox()
        Me.DealerCardThree = New System.Windows.Forms.PictureBox()
        Me.DealerCardOne = New System.Windows.Forms.PictureBox()
        Me.DealerCardTwo = New System.Windows.Forms.PictureBox()
        Me.PlayerSumlbl = New System.Windows.Forms.Label()
        Me.BetEverythingBtn = New System.Windows.Forms.Button()
        Me.BetMinimumBtn = New System.Windows.Forms.Button()
        Me.DealerSumLbl = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PlayerCardTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCardOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCardThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCardFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCardFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCardFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCardFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCardThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCardOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCardTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RaiseBtn
        '
        Me.RaiseBtn.BackColor = System.Drawing.Color.Firebrick
        Me.RaiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RaiseBtn.ForeColor = System.Drawing.Color.White
        Me.RaiseBtn.Location = New System.Drawing.Point(62, 459)
        Me.RaiseBtn.Name = "RaiseBtn"
        Me.RaiseBtn.Size = New System.Drawing.Size(75, 23)
        Me.RaiseBtn.TabIndex = 0
        Me.RaiseBtn.Text = "Raise"
        Me.ToolTip1.SetToolTip(Me.RaiseBtn, "Increase bet by $5")
        Me.RaiseBtn.UseVisualStyleBackColor = False
        '
        'BetBtn
        '
        Me.BetBtn.BackColor = System.Drawing.Color.Firebrick
        Me.BetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BetBtn.ForeColor = System.Drawing.Color.White
        Me.BetBtn.Location = New System.Drawing.Point(167, 459)
        Me.BetBtn.Name = "BetBtn"
        Me.BetBtn.Size = New System.Drawing.Size(75, 23)
        Me.BetBtn.TabIndex = 1
        Me.BetBtn.Text = "Bet"
        Me.ToolTip1.SetToolTip(Me.BetBtn, "Bet the current amount of money")
        Me.BetBtn.UseVisualStyleBackColor = False
        '
        'LowerBtn
        '
        Me.LowerBtn.BackColor = System.Drawing.Color.Firebrick
        Me.LowerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LowerBtn.ForeColor = System.Drawing.Color.White
        Me.LowerBtn.Location = New System.Drawing.Point(276, 459)
        Me.LowerBtn.Name = "LowerBtn"
        Me.LowerBtn.Size = New System.Drawing.Size(75, 23)
        Me.LowerBtn.TabIndex = 2
        Me.LowerBtn.Text = "Lower"
        Me.ToolTip1.SetToolTip(Me.LowerBtn, "Lower your bet by $5")
        Me.LowerBtn.UseVisualStyleBackColor = False
        '
        'AnotherCardBtn
        '
        Me.AnotherCardBtn.BackColor = System.Drawing.Color.Firebrick
        Me.AnotherCardBtn.Enabled = False
        Me.AnotherCardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AnotherCardBtn.ForeColor = System.Drawing.Color.White
        Me.AnotherCardBtn.Location = New System.Drawing.Point(114, 415)
        Me.AnotherCardBtn.Name = "AnotherCardBtn"
        Me.AnotherCardBtn.Size = New System.Drawing.Size(71, 23)
        Me.AnotherCardBtn.TabIndex = 3
        Me.AnotherCardBtn.Text = "Hit"
        Me.ToolTip1.SetToolTip(Me.AnotherCardBtn, "Add another card")
        Me.AnotherCardBtn.UseVisualStyleBackColor = False
        '
        'HoldBtn
        '
        Me.HoldBtn.BackColor = System.Drawing.Color.Firebrick
        Me.HoldBtn.Enabled = False
        Me.HoldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HoldBtn.ForeColor = System.Drawing.Color.White
        Me.HoldBtn.Location = New System.Drawing.Point(236, 415)
        Me.HoldBtn.Name = "HoldBtn"
        Me.HoldBtn.Size = New System.Drawing.Size(75, 23)
        Me.HoldBtn.TabIndex = 4
        Me.HoldBtn.Text = "Hold"
        Me.ToolTip1.SetToolTip(Me.HoldBtn, "Take no more cards and reveal dealers hand")
        Me.HoldBtn.UseVisualStyleBackColor = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Firebrick
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExitBtn.ForeColor = System.Drawing.Color.White
        Me.ExitBtn.Location = New System.Drawing.Point(358, 504)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 5
        Me.ExitBtn.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitBtn, "Exit the game")
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'InfoLbl
        '
        Me.InfoLbl.AutoSize = True
        Me.InfoLbl.ForeColor = System.Drawing.Color.White
        Me.InfoLbl.Location = New System.Drawing.Point(164, 383)
        Me.InfoLbl.Name = "InfoLbl"
        Me.InfoLbl.Size = New System.Drawing.Size(39, 13)
        Me.InfoLbl.TabIndex = 6
        Me.InfoLbl.Text = "Label1"
        '
        'TotalLbl
        '
        Me.TotalLbl.AutoSize = True
        Me.TotalLbl.ForeColor = System.Drawing.Color.White
        Me.TotalLbl.Location = New System.Drawing.Point(219, 9)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(39, 13)
        Me.TotalLbl.TabIndex = 7
        Me.TotalLbl.Text = "Label1"
        '
        'PlayerCardTwo
        '
        Me.PlayerCardTwo.Location = New System.Drawing.Point(111, 269)
        Me.PlayerCardTwo.Name = "PlayerCardTwo"
        Me.PlayerCardTwo.Size = New System.Drawing.Size(72, 96)
        Me.PlayerCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PlayerCardTwo.TabIndex = 9
        Me.PlayerCardTwo.TabStop = False
        '
        'PlayerCardOne
        '
        Me.PlayerCardOne.Location = New System.Drawing.Point(33, 269)
        Me.PlayerCardOne.Name = "PlayerCardOne"
        Me.PlayerCardOne.Size = New System.Drawing.Size(72, 96)
        Me.PlayerCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PlayerCardOne.TabIndex = 10
        Me.PlayerCardOne.TabStop = False
        '
        'PlayerCardThree
        '
        Me.PlayerCardThree.Location = New System.Drawing.Point(189, 269)
        Me.PlayerCardThree.Name = "PlayerCardThree"
        Me.PlayerCardThree.Size = New System.Drawing.Size(72, 96)
        Me.PlayerCardThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PlayerCardThree.TabIndex = 11
        Me.PlayerCardThree.TabStop = False
        '
        'PlayerCardFour
        '
        Me.PlayerCardFour.Location = New System.Drawing.Point(267, 269)
        Me.PlayerCardFour.Name = "PlayerCardFour"
        Me.PlayerCardFour.Size = New System.Drawing.Size(72, 96)
        Me.PlayerCardFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PlayerCardFour.TabIndex = 12
        Me.PlayerCardFour.TabStop = False
        '
        'PlayerCardFive
        '
        Me.PlayerCardFive.Location = New System.Drawing.Point(345, 269)
        Me.PlayerCardFive.Name = "PlayerCardFive"
        Me.PlayerCardFive.Size = New System.Drawing.Size(72, 96)
        Me.PlayerCardFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PlayerCardFive.TabIndex = 13
        Me.PlayerCardFive.TabStop = False
        '
        'DealerCardFive
        '
        Me.DealerCardFive.Location = New System.Drawing.Point(345, 35)
        Me.DealerCardFive.Name = "DealerCardFive"
        Me.DealerCardFive.Size = New System.Drawing.Size(72, 96)
        Me.DealerCardFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DealerCardFive.TabIndex = 18
        Me.DealerCardFive.TabStop = False
        '
        'DealerCardFour
        '
        Me.DealerCardFour.Location = New System.Drawing.Point(267, 35)
        Me.DealerCardFour.Name = "DealerCardFour"
        Me.DealerCardFour.Size = New System.Drawing.Size(72, 96)
        Me.DealerCardFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DealerCardFour.TabIndex = 17
        Me.DealerCardFour.TabStop = False
        '
        'DealerCardThree
        '
        Me.DealerCardThree.Location = New System.Drawing.Point(189, 35)
        Me.DealerCardThree.Name = "DealerCardThree"
        Me.DealerCardThree.Size = New System.Drawing.Size(72, 96)
        Me.DealerCardThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DealerCardThree.TabIndex = 16
        Me.DealerCardThree.TabStop = False
        '
        'DealerCardOne
        '
        Me.DealerCardOne.Location = New System.Drawing.Point(33, 35)
        Me.DealerCardOne.Name = "DealerCardOne"
        Me.DealerCardOne.Size = New System.Drawing.Size(72, 96)
        Me.DealerCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DealerCardOne.TabIndex = 15
        Me.DealerCardOne.TabStop = False
        '
        'DealerCardTwo
        '
        Me.DealerCardTwo.Location = New System.Drawing.Point(111, 35)
        Me.DealerCardTwo.Name = "DealerCardTwo"
        Me.DealerCardTwo.Size = New System.Drawing.Size(72, 96)
        Me.DealerCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.DealerCardTwo.TabIndex = 14
        Me.DealerCardTwo.TabStop = False
        '
        'PlayerSumlbl
        '
        Me.PlayerSumlbl.AutoSize = True
        Me.PlayerSumlbl.ForeColor = System.Drawing.Color.White
        Me.PlayerSumlbl.Location = New System.Drawing.Point(164, 228)
        Me.PlayerSumlbl.Name = "PlayerSumlbl"
        Me.PlayerSumlbl.Size = New System.Drawing.Size(39, 13)
        Me.PlayerSumlbl.TabIndex = 19
        Me.PlayerSumlbl.Text = "Label1"
        '
        'BetEverythingBtn
        '
        Me.BetEverythingBtn.BackColor = System.Drawing.Color.Firebrick
        Me.BetEverythingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BetEverythingBtn.ForeColor = System.Drawing.Color.White
        Me.BetEverythingBtn.Location = New System.Drawing.Point(52, 504)
        Me.BetEverythingBtn.Name = "BetEverythingBtn"
        Me.BetEverythingBtn.Size = New System.Drawing.Size(108, 23)
        Me.BetEverythingBtn.TabIndex = 20
        Me.BetEverythingBtn.Text = "Bet Maximum"
        Me.ToolTip1.SetToolTip(Me.BetEverythingBtn, "Bet all the money you have")
        Me.BetEverythingBtn.UseVisualStyleBackColor = False
        '
        'BetMinimumBtn
        '
        Me.BetMinimumBtn.BackColor = System.Drawing.Color.Firebrick
        Me.BetMinimumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BetMinimumBtn.ForeColor = System.Drawing.Color.White
        Me.BetMinimumBtn.Location = New System.Drawing.Point(203, 504)
        Me.BetMinimumBtn.Name = "BetMinimumBtn"
        Me.BetMinimumBtn.Size = New System.Drawing.Size(108, 23)
        Me.BetMinimumBtn.TabIndex = 21
        Me.BetMinimumBtn.Text = "Bet Minimum"
        Me.ToolTip1.SetToolTip(Me.BetMinimumBtn, "Bet $5")
        Me.BetMinimumBtn.UseVisualStyleBackColor = False
        '
        'DealerSumLbl
        '
        Me.DealerSumLbl.AutoSize = True
        Me.DealerSumLbl.ForeColor = System.Drawing.Color.White
        Me.DealerSumLbl.Location = New System.Drawing.Point(12, 9)
        Me.DealerSumLbl.Name = "DealerSumLbl"
        Me.DealerSumLbl.Size = New System.Drawing.Size(0, 13)
        Me.DealerSumLbl.TabIndex = 22
        '
        'BlackjackGamefrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(445, 539)
        Me.Controls.Add(Me.DealerSumLbl)
        Me.Controls.Add(Me.BetMinimumBtn)
        Me.Controls.Add(Me.BetEverythingBtn)
        Me.Controls.Add(Me.PlayerSumlbl)
        Me.Controls.Add(Me.DealerCardFive)
        Me.Controls.Add(Me.DealerCardFour)
        Me.Controls.Add(Me.DealerCardThree)
        Me.Controls.Add(Me.DealerCardOne)
        Me.Controls.Add(Me.DealerCardTwo)
        Me.Controls.Add(Me.PlayerCardFive)
        Me.Controls.Add(Me.PlayerCardFour)
        Me.Controls.Add(Me.PlayerCardThree)
        Me.Controls.Add(Me.PlayerCardOne)
        Me.Controls.Add(Me.PlayerCardTwo)
        Me.Controls.Add(Me.TotalLbl)
        Me.Controls.Add(Me.InfoLbl)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.HoldBtn)
        Me.Controls.Add(Me.AnotherCardBtn)
        Me.Controls.Add(Me.LowerBtn)
        Me.Controls.Add(Me.BetBtn)
        Me.Controls.Add(Me.RaiseBtn)
        Me.MaximizeBox = False
        Me.Name = "BlackjackGamefrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blackjack"
        CType(Me.PlayerCardTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCardOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCardThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCardFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCardFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCardFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCardFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCardThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCardOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCardTwo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RaiseBtn As System.Windows.Forms.Button
    Friend WithEvents BetBtn As System.Windows.Forms.Button
    Friend WithEvents LowerBtn As System.Windows.Forms.Button
    Friend WithEvents AnotherCardBtn As System.Windows.Forms.Button
    Friend WithEvents HoldBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents InfoLbl As System.Windows.Forms.Label
    Friend WithEvents TotalLbl As System.Windows.Forms.Label
    Friend WithEvents PlayerCardTwo As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerCardOne As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerCardThree As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerCardFour As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerCardFive As System.Windows.Forms.PictureBox
    Friend WithEvents DealerCardFive As System.Windows.Forms.PictureBox
    Friend WithEvents DealerCardFour As System.Windows.Forms.PictureBox
    Friend WithEvents DealerCardThree As System.Windows.Forms.PictureBox
    Friend WithEvents DealerCardOne As System.Windows.Forms.PictureBox
    Friend WithEvents DealerCardTwo As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerSumlbl As System.Windows.Forms.Label
    Friend WithEvents BetEverythingBtn As System.Windows.Forms.Button
    Friend WithEvents BetMinimumBtn As System.Windows.Forms.Button
    Friend WithEvents DealerSumLbl As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
