<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlterWordsfrm
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
        Me.ListOfWordslst = New System.Windows.Forms.ListBox()
        Me.AddWordBtn = New System.Windows.Forms.Button()
        Me.DeleteWordsbtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.AlterWordsLbl = New System.Windows.Forms.Label()
        Me.InputWordstxt = New System.Windows.Forms.TextBox()
        Me.DeleteWordtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'ListOfWordslst
        '
        Me.ListOfWordslst.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ListOfWordslst.ForeColor = System.Drawing.Color.DarkRed
        Me.ListOfWordslst.FormattingEnabled = True
        Me.ListOfWordslst.Location = New System.Drawing.Point(12, 70)
        Me.ListOfWordslst.Name = "ListOfWordslst"
        Me.ListOfWordslst.Size = New System.Drawing.Size(129, 264)
        Me.ListOfWordslst.TabIndex = 0
        '
        'AddWordBtn
        '
        Me.AddWordBtn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.AddWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddWordBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddWordBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.AddWordBtn.Location = New System.Drawing.Point(187, 121)
        Me.AddWordBtn.Name = "AddWordBtn"
        Me.AddWordBtn.Size = New System.Drawing.Size(120, 29)
        Me.AddWordBtn.TabIndex = 1
        Me.AddWordBtn.Text = "Add New Word"
        Me.ToolTip1.SetToolTip(Me.AddWordBtn, "Click to add the word in the box above")
        Me.AddWordBtn.UseVisualStyleBackColor = False
        '
        'DeleteWordsbtn
        '
        Me.DeleteWordsbtn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.DeleteWordsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteWordsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteWordsbtn.ForeColor = System.Drawing.Color.DarkRed
        Me.DeleteWordsbtn.Location = New System.Drawing.Point(187, 219)
        Me.DeleteWordsbtn.Name = "DeleteWordsbtn"
        Me.DeleteWordsbtn.Size = New System.Drawing.Size(120, 29)
        Me.DeleteWordsbtn.TabIndex = 2
        Me.DeleteWordsbtn.Text = "Delete Words"
        Me.ToolTip1.SetToolTip(Me.DeleteWordsbtn, "Click to delete the input word above")
        Me.DeleteWordsbtn.UseVisualStyleBackColor = False
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.BackBtn.Location = New System.Drawing.Point(248, 305)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(85, 29)
        Me.BackBtn.TabIndex = 3
        Me.BackBtn.Text = "Back"
        Me.ToolTip1.SetToolTip(Me.BackBtn, "Click to go back to the Hangman Menu")
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'AlterWordsLbl
        '
        Me.AlterWordsLbl.AutoSize = True
        Me.AlterWordsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlterWordsLbl.ForeColor = System.Drawing.Color.DarkRed
        Me.AlterWordsLbl.Location = New System.Drawing.Point(9, 42)
        Me.AlterWordsLbl.Name = "AlterWordsLbl"
        Me.AlterWordsLbl.Size = New System.Drawing.Size(170, 15)
        Me.AlterWordsLbl.TabIndex = 4
        Me.AlterWordsLbl.Text = "Words Currently Available"
        '
        'InputWordstxt
        '
        Me.InputWordstxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.InputWordstxt.Location = New System.Drawing.Point(187, 76)
        Me.InputWordstxt.Name = "InputWordstxt"
        Me.InputWordstxt.Size = New System.Drawing.Size(120, 20)
        Me.InputWordstxt.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.InputWordstxt, "Type word here to add to the list")
        '
        'DeleteWordtxt
        '
        Me.DeleteWordtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DeleteWordtxt.Location = New System.Drawing.Point(187, 179)
        Me.DeleteWordtxt.Name = "DeleteWordtxt"
        Me.DeleteWordtxt.Size = New System.Drawing.Size(120, 20)
        Me.DeleteWordtxt.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.DeleteWordtxt, "Enter word to delete from list here")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Note: Words must be between 2 and 8 letters inclusive."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ToolTip1
        '
        '
        'AlterWordsfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(345, 346)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DeleteWordtxt)
        Me.Controls.Add(Me.InputWordstxt)
        Me.Controls.Add(Me.AlterWordsLbl)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.DeleteWordsbtn)
        Me.Controls.Add(Me.AddWordBtn)
        Me.Controls.Add(Me.ListOfWordslst)
        Me.MaximizeBox = False
        Me.Name = "AlterWordsfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alter Words"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListOfWordslst As System.Windows.Forms.ListBox
    Friend WithEvents AddWordBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteWordsbtn As System.Windows.Forms.Button
    Friend WithEvents BackBtn As System.Windows.Forms.Button
    Friend WithEvents AlterWordsLbl As System.Windows.Forms.Label
    Friend WithEvents InputWordstxt As System.Windows.Forms.TextBox
    Friend WithEvents DeleteWordtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
