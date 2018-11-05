<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackjackMainMenufrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewGameBtn = New System.Windows.Forms.Button()
        Me.MainMenuBtn = New System.Windows.Forms.Button()
        Me.ContinueGameBtn = New System.Windows.Forms.Button()
        Me.ClearDataBtn = New System.Windows.Forms.Button()
        Me.HowToPlayBlackjackbtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the Blackjack Game. Click below to start the game, see the options or " & _
    "return to the Main Menu."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NewGameBtn
        '
        Me.NewGameBtn.BackColor = System.Drawing.Color.Firebrick
        Me.NewGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewGameBtn.ForeColor = System.Drawing.Color.White
        Me.NewGameBtn.Location = New System.Drawing.Point(148, 150)
        Me.NewGameBtn.Name = "NewGameBtn"
        Me.NewGameBtn.Size = New System.Drawing.Size(149, 47)
        Me.NewGameBtn.TabIndex = 1
        Me.NewGameBtn.Text = "New Game"
        Me.ToolTip1.SetToolTip(Me.NewGameBtn, "Click to start a new game")
        Me.NewGameBtn.UseVisualStyleBackColor = False
        '
        'MainMenuBtn
        '
        Me.MainMenuBtn.BackColor = System.Drawing.Color.Firebrick
        Me.MainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainMenuBtn.ForeColor = System.Drawing.Color.White
        Me.MainMenuBtn.Location = New System.Drawing.Point(313, 366)
        Me.MainMenuBtn.Name = "MainMenuBtn"
        Me.MainMenuBtn.Size = New System.Drawing.Size(117, 40)
        Me.MainMenuBtn.TabIndex = 2
        Me.MainMenuBtn.Text = "Back to Main Menu"
        Me.ToolTip1.SetToolTip(Me.MainMenuBtn, "Click to go back to the Main Menu")
        Me.MainMenuBtn.UseVisualStyleBackColor = False
        '
        'ContinueGameBtn
        '
        Me.ContinueGameBtn.BackColor = System.Drawing.Color.Firebrick
        Me.ContinueGameBtn.Enabled = False
        Me.ContinueGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContinueGameBtn.ForeColor = System.Drawing.Color.White
        Me.ContinueGameBtn.Location = New System.Drawing.Point(148, 75)
        Me.ContinueGameBtn.Name = "ContinueGameBtn"
        Me.ContinueGameBtn.Size = New System.Drawing.Size(149, 47)
        Me.ContinueGameBtn.TabIndex = 3
        Me.ContinueGameBtn.Text = "Continue Game"
        Me.ToolTip1.SetToolTip(Me.ContinueGameBtn, "Click to continue a previous game")
        Me.ContinueGameBtn.UseVisualStyleBackColor = False
        '
        'ClearDataBtn
        '
        Me.ClearDataBtn.BackColor = System.Drawing.Color.Firebrick
        Me.ClearDataBtn.Enabled = False
        Me.ClearDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearDataBtn.ForeColor = System.Drawing.Color.White
        Me.ClearDataBtn.Location = New System.Drawing.Point(148, 289)
        Me.ClearDataBtn.Name = "ClearDataBtn"
        Me.ClearDataBtn.Size = New System.Drawing.Size(149, 47)
        Me.ClearDataBtn.TabIndex = 4
        Me.ClearDataBtn.Text = "Clear Data"
        Me.ToolTip1.SetToolTip(Me.ClearDataBtn, "Click to clear saved data")
        Me.ClearDataBtn.UseVisualStyleBackColor = False
        '
        'HowToPlayBlackjackbtn
        '
        Me.HowToPlayBlackjackbtn.BackColor = System.Drawing.Color.Firebrick
        Me.HowToPlayBlackjackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HowToPlayBlackjackbtn.ForeColor = System.Drawing.Color.White
        Me.HowToPlayBlackjackbtn.Location = New System.Drawing.Point(148, 220)
        Me.HowToPlayBlackjackbtn.Name = "HowToPlayBlackjackbtn"
        Me.HowToPlayBlackjackbtn.Size = New System.Drawing.Size(149, 47)
        Me.HowToPlayBlackjackbtn.TabIndex = 5
        Me.HowToPlayBlackjackbtn.Text = "How to Play"
        Me.ToolTip1.SetToolTip(Me.HowToPlayBlackjackbtn, "Click to see the rules of how to play")
        Me.HowToPlayBlackjackbtn.UseVisualStyleBackColor = False
        '
        'BlackjackMainMenufrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(442, 418)
        Me.Controls.Add(Me.HowToPlayBlackjackbtn)
        Me.Controls.Add(Me.ClearDataBtn)
        Me.Controls.Add(Me.ContinueGameBtn)
        Me.Controls.Add(Me.MainMenuBtn)
        Me.Controls.Add(Me.NewGameBtn)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "BlackjackMainMenufrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blackjack"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewGameBtn As System.Windows.Forms.Button
    Friend WithEvents MainMenuBtn As System.Windows.Forms.Button
    Friend WithEvents ContinueGameBtn As System.Windows.Forms.Button
    Friend WithEvents ClearDataBtn As System.Windows.Forms.Button
    Friend WithEvents HowToPlayBlackjackbtn As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
