<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.PlayerNameField = New System.Windows.Forms.TextBox()
        Me.PlayerNameLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.FontSizeLabel = New System.Windows.Forms.Label()
        Me.FontSizeValue = New System.Windows.Forms.TrackBar()
        Me.AudioCheckBox = New System.Windows.Forms.CheckBox()
        Me.Cancel = New System.Windows.Forms.Button()
        CType(Me.FontSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayerNameField
        '
        Me.PlayerNameField.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerNameField.Location = New System.Drawing.Point(172, 56)
        Me.PlayerNameField.Name = "PlayerNameField"
        Me.PlayerNameField.Size = New System.Drawing.Size(110, 23)
        Me.PlayerNameField.TabIndex = 0
        '
        'PlayerNameLabel
        '
        Me.PlayerNameLabel.AutoSize = True
        Me.PlayerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerNameLabel.Location = New System.Drawing.Point(12, 59)
        Me.PlayerNameLabel.Name = "PlayerNameLabel"
        Me.PlayerNameLabel.Size = New System.Drawing.Size(114, 20)
        Me.PlayerNameLabel.TabIndex = 1
        Me.PlayerNameLabel.Text = "Player Name:"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(105, 253)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'FontSizeLabel
        '
        Me.FontSizeLabel.AutoSize = True
        Me.FontSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontSizeLabel.Location = New System.Drawing.Point(12, 99)
        Me.FontSizeLabel.Name = "FontSizeLabel"
        Me.FontSizeLabel.Size = New System.Drawing.Size(134, 20)
        Me.FontSizeLabel.TabIndex = 3
        Me.FontSizeLabel.Text = "Chat Font Size:"
        '
        'FontSizeValue
        '
        Me.FontSizeValue.Location = New System.Drawing.Point(172, 99)
        Me.FontSizeValue.Maximum = 14
        Me.FontSizeValue.Minimum = 8
        Me.FontSizeValue.Name = "FontSizeValue"
        Me.FontSizeValue.Size = New System.Drawing.Size(115, 45)
        Me.FontSizeValue.TabIndex = 5
        Me.FontSizeValue.Value = 10
        '
        'AudioCheckBox
        '
        Me.AudioCheckBox.AutoSize = True
        Me.AudioCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioCheckBox.Location = New System.Drawing.Point(172, 150)
        Me.AudioCheckBox.Name = "AudioCheckBox"
        Me.AudioCheckBox.Size = New System.Drawing.Size(135, 24)
        Me.AudioCheckBox.TabIndex = 6
        Me.AudioCheckBox.Text = "Enable Audio"
        Me.AudioCheckBox.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(207, 253)
        Me.Cancel.MaximumSize = New System.Drawing.Size(75, 23)
        Me.Cancel.MinimumSize = New System.Drawing.Size(75, 23)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 288)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.AudioCheckBox)
        Me.Controls.Add(Me.FontSizeValue)
        Me.Controls.Add(Me.FontSizeLabel)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.PlayerNameLabel)
        Me.Controls.Add(Me.PlayerNameField)
        Me.Name = "SettingsForm"
        Me.Text = "SettingsForm"
        CType(Me.FontSizeValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlayerNameField As System.Windows.Forms.TextBox
    Friend WithEvents PlayerNameLabel As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents FontSizeLabel As System.Windows.Forms.Label
    Friend WithEvents FontSizeValue As System.Windows.Forms.TrackBar
    Friend WithEvents AudioCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
