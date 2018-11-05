<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HangmanMainMenufrm
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
        Me.HangmanWelcomeLbl = New System.Windows.Forms.Label()
        Me.PlayerVsComputerBtn = New System.Windows.Forms.Button()
        Me.PlayerVsPlayerBtn = New System.Windows.Forms.Button()
        Me.AlterWordsBtn = New System.Windows.Forms.Button()
        Me.MainMenu1Btn = New System.Windows.Forms.Button()
        Me.HowToPlaybtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'HangmanWelcomeLbl
        '
        Me.HangmanWelcomeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HangmanWelcomeLbl.Location = New System.Drawing.Point(12, 9)
        Me.HangmanWelcomeLbl.Name = "HangmanWelcomeLbl"
        Me.HangmanWelcomeLbl.Size = New System.Drawing.Size(345, 55)
        Me.HangmanWelcomeLbl.TabIndex = 0
        Me.HangmanWelcomeLbl.Text = "Welcome to the Hangman Game! Select from the options below to customise your game" & _
    " or simple start playing!"
        Me.HangmanWelcomeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PlayerVsComputerBtn
        '
        Me.PlayerVsComputerBtn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.PlayerVsComputerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PlayerVsComputerBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerVsComputerBtn.Location = New System.Drawing.Point(112, 93)
        Me.PlayerVsComputerBtn.Name = "PlayerVsComputerBtn"
        Me.PlayerVsComputerBtn.Size = New System.Drawing.Size(144, 32)
        Me.PlayerVsComputerBtn.TabIndex = 1
        Me.PlayerVsComputerBtn.Text = "Player vs Computer"
        Me.ToolTip1.SetToolTip(Me.PlayerVsComputerBtn, "Click to play a 1 player game")
        Me.PlayerVsComputerBtn.UseVisualStyleBackColor = False
        '
        'PlayerVsPlayerBtn
        '
        Me.PlayerVsPlayerBtn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.PlayerVsPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PlayerVsPlayerBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerVsPlayerBtn.Location = New System.Drawing.Point(112, 146)
        Me.PlayerVsPlayerBtn.Name = "PlayerVsPlayerBtn"
        Me.PlayerVsPlayerBtn.Size = New System.Drawing.Size(144, 32)
        Me.PlayerVsPlayerBtn.TabIndex = 2
        Me.PlayerVsPlayerBtn.Text = "Player vs Player"
        Me.ToolTip1.SetToolTip(Me.PlayerVsPlayerBtn, "Click to play a 2 player game")
        Me.PlayerVsPlayerBtn.UseVisualStyleBackColor = False
        '
        'AlterWordsBtn
        '
        Me.AlterWordsBtn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.AlterWordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AlterWordsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlterWordsBtn.Location = New System.Drawing.Point(112, 248)
        Me.AlterWordsBtn.Name = "AlterWordsBtn"
        Me.AlterWordsBtn.Size = New System.Drawing.Size(144, 32)
        Me.AlterWordsBtn.TabIndex = 3
        Me.AlterWordsBtn.Text = "Alter Words"
        Me.ToolTip1.SetToolTip(Me.AlterWordsBtn, "Click to go and see the list of words")
        Me.AlterWordsBtn.UseVisualStyleBackColor = False
        '
        'MainMenu1Btn
        '
        Me.MainMenu1Btn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.MainMenu1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MainMenu1Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenu1Btn.Location = New System.Drawing.Point(223, 298)
        Me.MainMenu1Btn.Name = "MainMenu1Btn"
        Me.MainMenu1Btn.Size = New System.Drawing.Size(134, 32)
        Me.MainMenu1Btn.TabIndex = 5
        Me.MainMenu1Btn.Text = "Back to Main Menu"
        Me.ToolTip1.SetToolTip(Me.MainMenu1Btn, "Click to go back to the Main Menu")
        Me.MainMenu1Btn.UseVisualStyleBackColor = False
        '
        'HowToPlaybtn
        '
        Me.HowToPlaybtn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.HowToPlaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HowToPlaybtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HowToPlaybtn.Location = New System.Drawing.Point(112, 195)
        Me.HowToPlaybtn.Name = "HowToPlaybtn"
        Me.HowToPlaybtn.Size = New System.Drawing.Size(144, 35)
        Me.HowToPlaybtn.TabIndex = 6
        Me.HowToPlaybtn.Text = "How to Play"
        Me.ToolTip1.SetToolTip(Me.HowToPlaybtn, "Click to see the rules of the game")
        Me.HowToPlaybtn.UseVisualStyleBackColor = False
        '
        'HangmanMainMenufrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(369, 342)
        Me.Controls.Add(Me.HowToPlaybtn)
        Me.Controls.Add(Me.MainMenu1Btn)
        Me.Controls.Add(Me.AlterWordsBtn)
        Me.Controls.Add(Me.PlayerVsPlayerBtn)
        Me.Controls.Add(Me.PlayerVsComputerBtn)
        Me.Controls.Add(Me.HangmanWelcomeLbl)
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.MaximizeBox = False
        Me.Name = "HangmanMainMenufrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hangman"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HangmanWelcomeLbl As System.Windows.Forms.Label
    Friend WithEvents PlayerVsComputerBtn As System.Windows.Forms.Button
    Friend WithEvents PlayerVsPlayerBtn As System.Windows.Forms.Button
    Friend WithEvents AlterWordsBtn As System.Windows.Forms.Button
    Friend WithEvents MainMenu1Btn As System.Windows.Forms.Button
    Friend WithEvents HowToPlaybtn As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
