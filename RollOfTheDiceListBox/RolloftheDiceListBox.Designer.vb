<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RolloftheDiceListBox
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.DiceValueLabel = New System.Windows.Forms.Label()
        Me.MostFrequentLabel = New System.Windows.Forms.Label()
        Me.RollCountLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(591, 368)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(145, 75)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(373, 363)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(145, 75)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(181, 363)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(145, 75)
        Me.RollButton.TabIndex = 2
        Me.RollButton.Text = "Roll"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'DiceValueLabel
        '
        Me.DiceValueLabel.AutoSize = True
        Me.DiceValueLabel.Location = New System.Drawing.Point(48, 92)
        Me.DiceValueLabel.Name = "DiceValueLabel"
        Me.DiceValueLabel.Size = New System.Drawing.Size(83, 16)
        Me.DiceValueLabel.TabIndex = 3
        Me.DiceValueLabel.Text = "Dice Values:"
        '
        'MostFrequentLabel
        '
        Me.MostFrequentLabel.AutoSize = True
        Me.MostFrequentLabel.Location = New System.Drawing.Point(48, 272)
        Me.MostFrequentLabel.Name = "MostFrequentLabel"
        Me.MostFrequentLabel.Size = New System.Drawing.Size(122, 16)
        Me.MostFrequentLabel.TabIndex = 4
        Me.MostFrequentLabel.Text = "Most Frequent Roll:"
        '
        'RollCountLabel
        '
        Me.RollCountLabel.AutoSize = True
        Me.RollCountLabel.Location = New System.Drawing.Point(48, 190)
        Me.RollCountLabel.Name = "RollCountLabel"
        Me.RollCountLabel.Size = New System.Drawing.Size(78, 16)
        Me.RollCountLabel.TabIndex = 5
        Me.RollCountLabel.Text = "Roll Counts:"
        '
        'RolloftheDiceListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RollCountLabel)
        Me.Controls.Add(Me.MostFrequentLabel)
        Me.Controls.Add(Me.DiceValueLabel)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "RolloftheDiceListBox"
        Me.Text = "Roll of the Dice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents RollButton As Button
    Friend WithEvents DiceValueLabel As Label
    Friend WithEvents MostFrequentLabel As Label
    Friend WithEvents RollCountLabel As Label
End Class
