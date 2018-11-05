<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerVsComputerfrm
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
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.LettersGuessedlst = New System.Windows.Forms.ListBox()
        Me.Infolbl = New System.Windows.Forms.Label()
        Me.InputLettertxt = New System.Windows.Forms.TextBox()
        Me.EnterLetterBtn = New System.Windows.Forms.Button()
        Me.Character1lbl = New System.Windows.Forms.Label()
        Me.Character2lbl = New System.Windows.Forms.Label()
        Me.Character3lbl = New System.Windows.Forms.Label()
        Me.Character4lbl = New System.Windows.Forms.Label()
        Me.Character5lbl = New System.Windows.Forms.Label()
        Me.Character6lbl = New System.Windows.Forms.Label()
        Me.Character7lbl = New System.Windows.Forms.Label()
        Me.Character8lbl = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Letter1 = New System.Windows.Forms.Label()
        Me.Letter2 = New System.Windows.Forms.Label()
        Me.Letter3 = New System.Windows.Forms.Label()
        Me.Letter4 = New System.Windows.Forms.Label()
        Me.Letter5 = New System.Windows.Forms.Label()
        Me.Letter6 = New System.Windows.Forms.Label()
        Me.Letter7 = New System.Windows.Forms.Label()
        Me.Letter8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.ExitBtn.Location = New System.Drawing.Point(359, 404)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(85, 25)
        Me.ExitBtn.TabIndex = 0
        Me.ExitBtn.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitBtn, "Click to exit game back to Hangman Menu")
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'LettersGuessedlst
        '
        Me.LettersGuessedlst.FormattingEnabled = True
        Me.LettersGuessedlst.Location = New System.Drawing.Point(374, 37)
        Me.LettersGuessedlst.Name = "LettersGuessedlst"
        Me.LettersGuessedlst.Size = New System.Drawing.Size(51, 342)
        Me.LettersGuessedlst.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.LettersGuessedlst, "Displays currently guessed letters")
        '
        'Infolbl
        '
        Me.Infolbl.AutoSize = True
        Me.Infolbl.ForeColor = System.Drawing.Color.DarkRed
        Me.Infolbl.Location = New System.Drawing.Point(347, 21)
        Me.Infolbl.Name = "Infolbl"
        Me.Infolbl.Size = New System.Drawing.Size(82, 13)
        Me.Infolbl.TabIndex = 2
        Me.Infolbl.Text = "Letters guessed"
        '
        'InputLettertxt
        '
        Me.InputLettertxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.InputLettertxt.Location = New System.Drawing.Point(98, 345)
        Me.InputLettertxt.MaxLength = 1
        Me.InputLettertxt.Name = "InputLettertxt"
        Me.InputLettertxt.Size = New System.Drawing.Size(75, 20)
        Me.InputLettertxt.TabIndex = 3
        Me.InputLettertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.InputLettertxt, "Enter letter here")
        '
        'EnterLetterBtn
        '
        Me.EnterLetterBtn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.EnterLetterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EnterLetterBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterLetterBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.EnterLetterBtn.Location = New System.Drawing.Point(98, 385)
        Me.EnterLetterBtn.Name = "EnterLetterBtn"
        Me.EnterLetterBtn.Size = New System.Drawing.Size(85, 25)
        Me.EnterLetterBtn.TabIndex = 4
        Me.EnterLetterBtn.Text = "Enter Letter"
        Me.ToolTip1.SetToolTip(Me.EnterLetterBtn, "Click to guess the letter input")
        Me.EnterLetterBtn.UseVisualStyleBackColor = False
        '
        'Character1lbl
        '
        Me.Character1lbl.AutoSize = True
        Me.Character1lbl.Location = New System.Drawing.Point(15, 305)
        Me.Character1lbl.Name = "Character1lbl"
        Me.Character1lbl.Size = New System.Drawing.Size(25, 13)
        Me.Character1lbl.TabIndex = 15
        Me.Character1lbl.Text = "___"
        Me.Character1lbl.Visible = False
        '
        'Character2lbl
        '
        Me.Character2lbl.AutoSize = True
        Me.Character2lbl.Location = New System.Drawing.Point(60, 305)
        Me.Character2lbl.Name = "Character2lbl"
        Me.Character2lbl.Size = New System.Drawing.Size(25, 13)
        Me.Character2lbl.TabIndex = 16
        Me.Character2lbl.Text = "___"
        Me.Character2lbl.Visible = False
        '
        'Character3lbl
        '
        Me.Character3lbl.AutoSize = True
        Me.Character3lbl.Location = New System.Drawing.Point(105, 305)
        Me.Character3lbl.Name = "Character3lbl"
        Me.Character3lbl.Size = New System.Drawing.Size(25, 13)
        Me.Character3lbl.TabIndex = 17
        Me.Character3lbl.Text = "___"
        Me.Character3lbl.Visible = False
        '
        'Character4lbl
        '
        Me.Character4lbl.AutoSize = True
        Me.Character4lbl.Location = New System.Drawing.Point(150, 305)
        Me.Character4lbl.Name = "Character4lbl"
        Me.Character4lbl.Size = New System.Drawing.Size(25, 13)
        Me.Character4lbl.TabIndex = 18
        Me.Character4lbl.Text = "___"
        Me.Character4lbl.Visible = False
        '
        'Character5lbl
        '
        Me.Character5lbl.AutoSize = True
        Me.Character5lbl.Location = New System.Drawing.Point(195, 305)
        Me.Character5lbl.Name = "Character5lbl"
        Me.Character5lbl.Size = New System.Drawing.Size(25, 13)
        Me.Character5lbl.TabIndex = 19
        Me.Character5lbl.Text = "___"
        Me.Character5lbl.Visible = False
        '
        'Character6lbl
        '
        Me.Character6lbl.AutoSize = True
        Me.Character6lbl.Location = New System.Drawing.Point(240, 305)
        Me.Character6lbl.Name = "Character6lbl"
        Me.Character6lbl.Size = New System.Drawing.Size(25, 13)
        Me.Character6lbl.TabIndex = 20
        Me.Character6lbl.Text = "___"
        Me.Character6lbl.Visible = False
        '
        'Character7lbl
        '
        Me.Character7lbl.AutoSize = True
        Me.Character7lbl.Location = New System.Drawing.Point(285, 305)
        Me.Character7lbl.Name = "Character7lbl"
        Me.Character7lbl.Size = New System.Drawing.Size(25, 13)
        Me.Character7lbl.TabIndex = 21
        Me.Character7lbl.Text = "___"
        Me.Character7lbl.Visible = False
        '
        'Character8lbl
        '
        Me.Character8lbl.AutoSize = True
        Me.Character8lbl.Location = New System.Drawing.Point(330, 305)
        Me.Character8lbl.Name = "Character8lbl"
        Me.Character8lbl.Size = New System.Drawing.Size(25, 13)
        Me.Character8lbl.TabIndex = 22
        Me.Character8lbl.Text = "___"
        Me.Character8lbl.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line1, Me.Line2, Me.Line3, Me.Line4, Me.Line10, Me.Line9, Me.Line8, Me.Line7, Me.Line6, Me.Line5})
        Me.ShapeContainer1.Size = New System.Drawing.Size(447, 432)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'Line1
        '
        Me.Line1.Name = "Line1"
        Me.Line1.Visible = False
        Me.Line1.X1 = 38
        Me.Line1.X2 = 162
        Me.Line1.Y1 = 258
        Me.Line1.Y2 = 258
        '
        'Line2
        '
        Me.Line2.Name = "Line2"
        Me.Line2.Visible = False
        Me.Line2.X1 = 38
        Me.Line2.X2 = 38
        Me.Line2.Y1 = 48
        Me.Line2.Y2 = 258
        '
        'Line3
        '
        Me.Line3.Name = "Line3"
        Me.Line3.Visible = False
        Me.Line3.X1 = 38
        Me.Line3.X2 = 129
        Me.Line3.Y1 = 47
        Me.Line3.Y2 = 47
        '
        'Line4
        '
        Me.Line4.Name = "Line4"
        Me.Line4.Visible = False
        Me.Line4.X1 = 130
        Me.Line4.X2 = 130
        Me.Line4.Y1 = 47
        Me.Line4.Y2 = 92
        '
        'Line10
        '
        Me.Line10.Name = "Line10"
        Me.Line10.Visible = False
        Me.Line10.X1 = 128
        Me.Line10.X2 = 105
        Me.Line10.Y1 = 200
        Me.Line10.Y2 = 240
        '
        'Line9
        '
        Me.Line9.Name = "Line9"
        Me.Line9.Visible = False
        Me.Line9.X1 = 128
        Me.Line9.X2 = 157
        Me.Line9.Y1 = 199
        Me.Line9.Y2 = 242
        '
        'Line8
        '
        Me.Line8.Name = "Line8"
        Me.Line8.Visible = False
        Me.Line8.X1 = 88
        Me.Line8.X2 = 129
        Me.Line8.Y1 = 171
        Me.Line8.Y2 = 142
        '
        'Line7
        '
        Me.Line7.Name = "Line7"
        Me.Line7.Visible = False
        Me.Line7.X1 = 129
        Me.Line7.X2 = 172
        Me.Line7.Y1 = 142
        Me.Line7.Y2 = 171
        '
        'Line6
        '
        Me.Line6.Name = "Line6"
        Me.Line6.Visible = False
        Me.Line6.X1 = 129
        Me.Line6.X2 = 129
        Me.Line6.Y1 = 128
        Me.Line6.Y2 = 201
        '
        'Line5
        '
        Me.Line5.Location = New System.Drawing.Point(112, 91)
        Me.Line5.Name = "Line5"
        Me.Line5.Size = New System.Drawing.Size(35, 36)
        Me.Line5.Visible = False
        '
        'Letter1
        '
        Me.Letter1.AutoSize = True
        Me.Letter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Letter1.Location = New System.Drawing.Point(22, 300)
        Me.Letter1.Name = "Letter1"
        Me.Letter1.Size = New System.Drawing.Size(17, 18)
        Me.Letter1.TabIndex = 24
        Me.Letter1.Text = "A"
        Me.Letter1.Visible = False
        '
        'Letter2
        '
        Me.Letter2.AutoSize = True
        Me.Letter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Letter2.Location = New System.Drawing.Point(65, 300)
        Me.Letter2.Name = "Letter2"
        Me.Letter2.Size = New System.Drawing.Size(17, 18)
        Me.Letter2.TabIndex = 25
        Me.Letter2.Text = "A"
        Me.Letter2.Visible = False
        '
        'Letter3
        '
        Me.Letter3.AutoSize = True
        Me.Letter3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Letter3.Location = New System.Drawing.Point(110, 300)
        Me.Letter3.Name = "Letter3"
        Me.Letter3.Size = New System.Drawing.Size(17, 18)
        Me.Letter3.TabIndex = 26
        Me.Letter3.Text = "A"
        Me.Letter3.Visible = False
        '
        'Letter4
        '
        Me.Letter4.AutoSize = True
        Me.Letter4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Letter4.Location = New System.Drawing.Point(158, 300)
        Me.Letter4.Name = "Letter4"
        Me.Letter4.Size = New System.Drawing.Size(17, 18)
        Me.Letter4.TabIndex = 27
        Me.Letter4.Text = "A"
        Me.Letter4.Visible = False
        '
        'Letter5
        '
        Me.Letter5.AutoSize = True
        Me.Letter5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Letter5.Location = New System.Drawing.Point(203, 300)
        Me.Letter5.Name = "Letter5"
        Me.Letter5.Size = New System.Drawing.Size(17, 18)
        Me.Letter5.TabIndex = 28
        Me.Letter5.Text = "A"
        Me.Letter5.Visible = False
        '
        'Letter6
        '
        Me.Letter6.AutoSize = True
        Me.Letter6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Letter6.Location = New System.Drawing.Point(248, 300)
        Me.Letter6.Name = "Letter6"
        Me.Letter6.Size = New System.Drawing.Size(17, 18)
        Me.Letter6.TabIndex = 29
        Me.Letter6.Text = "A"
        Me.Letter6.Visible = False
        '
        'Letter7
        '
        Me.Letter7.AutoSize = True
        Me.Letter7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Letter7.Location = New System.Drawing.Point(293, 300)
        Me.Letter7.Name = "Letter7"
        Me.Letter7.Size = New System.Drawing.Size(17, 18)
        Me.Letter7.TabIndex = 30
        Me.Letter7.Text = "A"
        Me.Letter7.Visible = False
        '
        'Letter8
        '
        Me.Letter8.AutoSize = True
        Me.Letter8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Letter8.Location = New System.Drawing.Point(337, 300)
        Me.Letter8.Name = "Letter8"
        Me.Letter8.Size = New System.Drawing.Size(17, 18)
        Me.Letter8.TabIndex = 31
        Me.Letter8.Text = "A"
        Me.Letter8.Visible = False
        '
        'PlayerVsComputerfrm
        '
        Me.AcceptButton = Me.EnterLetterBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(447, 432)
        Me.Controls.Add(Me.Letter8)
        Me.Controls.Add(Me.Letter7)
        Me.Controls.Add(Me.Letter6)
        Me.Controls.Add(Me.Letter5)
        Me.Controls.Add(Me.Letter4)
        Me.Controls.Add(Me.Letter3)
        Me.Controls.Add(Me.Letter2)
        Me.Controls.Add(Me.Letter1)
        Me.Controls.Add(Me.Character8lbl)
        Me.Controls.Add(Me.Character7lbl)
        Me.Controls.Add(Me.Character6lbl)
        Me.Controls.Add(Me.Character5lbl)
        Me.Controls.Add(Me.Character4lbl)
        Me.Controls.Add(Me.Character3lbl)
        Me.Controls.Add(Me.Character2lbl)
        Me.Controls.Add(Me.Character1lbl)
        Me.Controls.Add(Me.EnterLetterBtn)
        Me.Controls.Add(Me.InputLettertxt)
        Me.Controls.Add(Me.Infolbl)
        Me.Controls.Add(Me.LettersGuessedlst)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MaximizeBox = False
        Me.Name = "PlayerVsComputerfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Player Vs Computer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents LettersGuessedlst As System.Windows.Forms.ListBox
    Friend WithEvents Infolbl As System.Windows.Forms.Label
    Friend WithEvents InputLettertxt As System.Windows.Forms.TextBox
    Friend WithEvents EnterLetterBtn As System.Windows.Forms.Button
    Friend WithEvents Character1lbl As System.Windows.Forms.Label
    Friend WithEvents Character2lbl As System.Windows.Forms.Label
    Friend WithEvents Character3lbl As System.Windows.Forms.Label
    Friend WithEvents Character4lbl As System.Windows.Forms.Label
    Friend WithEvents Character5lbl As System.Windows.Forms.Label
    Friend WithEvents Character6lbl As System.Windows.Forms.Label
    Friend WithEvents Character7lbl As System.Windows.Forms.Label
    Friend WithEvents Character8lbl As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Letter1 As System.Windows.Forms.Label
    Friend WithEvents Letter2 As System.Windows.Forms.Label
    Friend WithEvents Letter3 As System.Windows.Forms.Label
    Friend WithEvents Letter4 As System.Windows.Forms.Label
    Friend WithEvents Letter5 As System.Windows.Forms.Label
    Friend WithEvents Letter6 As System.Windows.Forms.Label
    Friend WithEvents Letter7 As System.Windows.Forms.Label
    Friend WithEvents Letter8 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
