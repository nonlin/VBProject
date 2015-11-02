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
        Me.HostSettingsLabel = New System.Windows.Forms.Label()
        Me.RoundTimeTextField = New System.Windows.Forms.TextBox()
        Me.RoundLabel = New System.Windows.Forms.Label()
        Me.RoleComboBox = New System.Windows.Forms.ComboBox()
        Me.AddRolesLabel = New System.Windows.Forms.Label()
        Me.AddRoleButton = New System.Windows.Forms.Button()
        CType(Me.FontSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayerNameField
        '
        Me.PlayerNameField.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayerNameField.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerNameField.Location = New System.Drawing.Point(172, 26)
        Me.PlayerNameField.Name = "PlayerNameField"
        Me.PlayerNameField.Size = New System.Drawing.Size(110, 23)
        Me.PlayerNameField.TabIndex = 0
        '
        'PlayerNameLabel
        '
        Me.PlayerNameLabel.AutoSize = True
        Me.PlayerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerNameLabel.Location = New System.Drawing.Point(12, 29)
        Me.PlayerNameLabel.Name = "PlayerNameLabel"
        Me.PlayerNameLabel.Size = New System.Drawing.Size(114, 20)
        Me.PlayerNameLabel.TabIndex = 1
        Me.PlayerNameLabel.Text = "Player Name:"
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SaveButton.Location = New System.Drawing.Point(155, 332)
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
        Me.FontSizeLabel.Location = New System.Drawing.Point(12, 69)
        Me.FontSizeLabel.Name = "FontSizeLabel"
        Me.FontSizeLabel.Size = New System.Drawing.Size(134, 20)
        Me.FontSizeLabel.TabIndex = 3
        Me.FontSizeLabel.Text = "Chat Font Size:"
        '
        'FontSizeValue
        '
        Me.FontSizeValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FontSizeValue.Location = New System.Drawing.Point(172, 69)
        Me.FontSizeValue.Maximum = 14
        Me.FontSizeValue.Minimum = 8
        Me.FontSizeValue.Name = "FontSizeValue"
        Me.FontSizeValue.Size = New System.Drawing.Size(115, 45)
        Me.FontSizeValue.TabIndex = 5
        Me.FontSizeValue.Value = 10
        '
        'AudioCheckBox
        '
        Me.AudioCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AudioCheckBox.AutoSize = True
        Me.AudioCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioCheckBox.Location = New System.Drawing.Point(172, 129)
        Me.AudioCheckBox.Name = "AudioCheckBox"
        Me.AudioCheckBox.Size = New System.Drawing.Size(135, 24)
        Me.AudioCheckBox.TabIndex = 6
        Me.AudioCheckBox.Text = "Enable Audio"
        Me.AudioCheckBox.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Cancel.Location = New System.Drawing.Point(256, 332)
        Me.Cancel.MaximumSize = New System.Drawing.Size(75, 23)
        Me.Cancel.MinimumSize = New System.Drawing.Size(75, 23)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'HostSettingsLabel
        '
        Me.HostSettingsLabel.AutoSize = True
        Me.HostSettingsLabel.Location = New System.Drawing.Point(13, 154)
        Me.HostSettingsLabel.Name = "HostSettingsLabel"
        Me.HostSettingsLabel.Size = New System.Drawing.Size(207, 13)
        Me.HostSettingsLabel.TabIndex = 8
        Me.HostSettingsLabel.Text = "Master Settings (Only Master Can Change)"
        '
        'RoundTimeTextField
        '
        Me.RoundTimeTextField.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoundTimeTextField.Enabled = False
        Me.RoundTimeTextField.Location = New System.Drawing.Point(172, 179)
        Me.RoundTimeTextField.Name = "RoundTimeTextField"
        Me.RoundTimeTextField.Size = New System.Drawing.Size(31, 20)
        Me.RoundTimeTextField.TabIndex = 9
        '
        'RoundLabel
        '
        Me.RoundLabel.AutoSize = True
        Me.RoundLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundLabel.Location = New System.Drawing.Point(12, 177)
        Me.RoundLabel.Name = "RoundLabel"
        Me.RoundLabel.Size = New System.Drawing.Size(110, 20)
        Me.RoundLabel.TabIndex = 10
        Me.RoundLabel.Text = "Round Time:"
        '
        'RoleComboBox
        '
        Me.RoleComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RoleComboBox.FormattingEnabled = True
        Me.RoleComboBox.Items.AddRange(New Object() {"Drunk", "Hunter", "Insomniac", "Minion", "Tanner", "Villager"})
        Me.RoleComboBox.Location = New System.Drawing.Point(172, 223)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.Size = New System.Drawing.Size(110, 21)
        Me.RoleComboBox.Sorted = True
        Me.RoleComboBox.TabIndex = 11
        '
        'AddRolesLabel
        '
        Me.AddRolesLabel.AutoSize = True
        Me.AddRolesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRolesLabel.Location = New System.Drawing.Point(16, 224)
        Me.AddRolesLabel.Name = "AddRolesLabel"
        Me.AddRolesLabel.Size = New System.Drawing.Size(97, 20)
        Me.AddRolesLabel.TabIndex = 12
        Me.AddRolesLabel.Text = "Add Roles:"
        '
        'AddRoleButton
        '
        Me.AddRoleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddRoleButton.Location = New System.Drawing.Point(304, 223)
        Me.AddRoleButton.Name = "AddRoleButton"
        Me.AddRoleButton.Size = New System.Drawing.Size(41, 23)
        Me.AddRoleButton.TabIndex = 13
        Me.AddRoleButton.Text = "Add"
        Me.AddRoleButton.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 367)
        Me.Controls.Add(Me.AddRoleButton)
        Me.Controls.Add(Me.AddRolesLabel)
        Me.Controls.Add(Me.RoleComboBox)
        Me.Controls.Add(Me.RoundLabel)
        Me.Controls.Add(Me.RoundTimeTextField)
        Me.Controls.Add(Me.HostSettingsLabel)
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
    Friend WithEvents HostSettingsLabel As System.Windows.Forms.Label
    Friend WithEvents RoundTimeTextField As System.Windows.Forms.TextBox
    Friend WithEvents RoundLabel As System.Windows.Forms.Label
    Friend WithEvents RoleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddRolesLabel As System.Windows.Forms.Label
    Friend WithEvents AddRoleButton As System.Windows.Forms.Button
End Class
