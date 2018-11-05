<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenufrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenufrm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HangmanPic = New System.Windows.Forms.PictureBox()
        Me.BlackjackPic = New System.Windows.Forms.PictureBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.HangmanLbl = New System.Windows.Forms.Label()
        Me.BlackjackLbl = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.HangmanPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlackjackPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 99)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HangmanPic
        '
        Me.HangmanPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HangmanPic.Image = CType(resources.GetObject("HangmanPic.Image"), System.Drawing.Image)
        Me.HangmanPic.Location = New System.Drawing.Point(36, 124)
        Me.HangmanPic.Name = "HangmanPic"
        Me.HangmanPic.Size = New System.Drawing.Size(178, 203)
        Me.HangmanPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HangmanPic.TabIndex = 1
        Me.HangmanPic.TabStop = False
        Me.ToolTip1.SetToolTip(Me.HangmanPic, "Click to play Hangman")
        '
        'BlackjackPic
        '
        Me.BlackjackPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BlackjackPic.Image = CType(resources.GetObject("BlackjackPic.Image"), System.Drawing.Image)
        Me.BlackjackPic.Location = New System.Drawing.Point(243, 124)
        Me.BlackjackPic.Name = "BlackjackPic"
        Me.BlackjackPic.Size = New System.Drawing.Size(178, 203)
        Me.BlackjackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BlackjackPic.TabIndex = 2
        Me.BlackjackPic.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BlackjackPic, "Click to play Blackjack")
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.LimeGreen
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(350, 374)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(89, 32)
        Me.ExitBtn.TabIndex = 3
        Me.ExitBtn.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitBtn, "Click to exit the application")
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'HangmanLbl
        '
        Me.HangmanLbl.AutoSize = True
        Me.HangmanLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HangmanLbl.Location = New System.Drawing.Point(85, 330)
        Me.HangmanLbl.Name = "HangmanLbl"
        Me.HangmanLbl.Size = New System.Drawing.Size(79, 18)
        Me.HangmanLbl.TabIndex = 4
        Me.HangmanLbl.Text = "Hangman"
        '
        'BlackjackLbl
        '
        Me.BlackjackLbl.AutoSize = True
        Me.BlackjackLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlackjackLbl.Location = New System.Drawing.Point(301, 330)
        Me.BlackjackLbl.Name = "BlackjackLbl"
        Me.BlackjackLbl.Size = New System.Drawing.Size(81, 18)
        Me.BlackjackLbl.TabIndex = 5
        Me.BlackjackLbl.Text = "Blackjack"
        '
        'MainMenufrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(451, 418)
        Me.Controls.Add(Me.BlackjackLbl)
        Me.Controls.Add(Me.HangmanLbl)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.BlackjackPic)
        Me.Controls.Add(Me.HangmanPic)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "MainMenufrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.HangmanPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlackjackPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HangmanPic As System.Windows.Forms.PictureBox
    Friend WithEvents BlackjackPic As System.Windows.Forms.PictureBox
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents HangmanLbl As System.Windows.Forms.Label
    Friend WithEvents BlackjackLbl As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
