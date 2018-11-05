<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerVsPlayerfrm
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
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Welcomelbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlayerOnetxt = New System.Windows.Forms.TextBox()
        Me.PlayerTwotxt = New System.Windows.Forms.TextBox()
        Me.Rounds = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'StartBtn
        '
        Me.StartBtn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.StartBtn.Location = New System.Drawing.Point(170, 300)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(126, 41)
        Me.StartBtn.TabIndex = 1
        Me.StartBtn.Text = "Start Game"
        Me.ToolTip1.SetToolTip(Me.StartBtn, "Click to start the game with current settings")
        Me.StartBtn.UseVisualStyleBackColor = False
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.BackBtn.Location = New System.Drawing.Point(332, 382)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(103, 37)
        Me.BackBtn.TabIndex = 2
        Me.BackBtn.Text = "Back to Menu"
        Me.ToolTip1.SetToolTip(Me.BackBtn, "Click to exit back to the Hangman Menu")
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'Welcomelbl
        '
        Me.Welcomelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcomelbl.ForeColor = System.Drawing.Color.DarkRed
        Me.Welcomelbl.Location = New System.Drawing.Point(12, 9)
        Me.Welcomelbl.Name = "Welcomelbl"
        Me.Welcomelbl.Size = New System.Drawing.Size(423, 44)
        Me.Welcomelbl.TabIndex = 3
        Me.Welcomelbl.Text = "Welcome to Two Player Hangman. Enter your names, choose the amount of rounds, and" & _
    " click start to begin."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(20, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Player 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(20, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Player 2"
        '
        'PlayerOnetxt
        '
        Me.PlayerOnetxt.Location = New System.Drawing.Point(182, 114)
        Me.PlayerOnetxt.Name = "PlayerOnetxt"
        Me.PlayerOnetxt.Size = New System.Drawing.Size(138, 20)
        Me.PlayerOnetxt.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.PlayerOnetxt, "Add Player Ones name here")
        '
        'PlayerTwotxt
        '
        Me.PlayerTwotxt.Location = New System.Drawing.Point(182, 179)
        Me.PlayerTwotxt.Name = "PlayerTwotxt"
        Me.PlayerTwotxt.Size = New System.Drawing.Size(138, 20)
        Me.PlayerTwotxt.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.PlayerTwotxt, "Add Player Two's name here")
        '
        'Rounds
        '
        Me.Rounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Rounds.FormattingEnabled = True
        Me.Rounds.Location = New System.Drawing.Point(182, 234)
        Me.Rounds.Name = "Rounds"
        Me.Rounds.Size = New System.Drawing.Size(138, 21)
        Me.Rounds.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.Rounds, "Define the number of rounds you wish to play")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(20, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Number of Rounds"
        '
        'PlayerVsPlayerfrm
        '
        Me.AcceptButton = Me.StartBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(447, 431)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Rounds)
        Me.Controls.Add(Me.PlayerTwotxt)
        Me.Controls.Add(Me.PlayerOnetxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Welcomelbl)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.StartBtn)
        Me.MaximizeBox = False
        Me.Name = "PlayerVsPlayerfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Player vs Player"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartBtn As System.Windows.Forms.Button
    Friend WithEvents BackBtn As System.Windows.Forms.Button
    Friend WithEvents Welcomelbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PlayerOnetxt As System.Windows.Forms.TextBox
    Friend WithEvents PlayerTwotxt As System.Windows.Forms.TextBox
    Friend WithEvents Rounds As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
