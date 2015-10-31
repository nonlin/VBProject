<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoteMenuForm
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.VoteKillLabel = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.EndRoundCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(43, 73)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(118, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'VoteKillLabel
        '
        Me.VoteKillLabel.AutoSize = True
        Me.VoteKillLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoteKillLabel.Location = New System.Drawing.Point(39, 29)
        Me.VoteKillLabel.Name = "VoteKillLabel"
        Me.VoteKillLabel.Size = New System.Drawing.Size(118, 24)
        Me.VoteKillLabel.TabIndex = 1
        Me.VoteKillLabel.Text = "Vote To Kill"
        Me.VoteKillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(43, 106)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(118, 24)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(43, 138)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(118, 24)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'EndRoundCheckBox
        '
        Me.EndRoundCheckBox.AutoSize = True
        Me.EndRoundCheckBox.Enabled = False
        Me.EndRoundCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndRoundCheckBox.Location = New System.Drawing.Point(43, 255)
        Me.EndRoundCheckBox.Name = "EndRoundCheckBox"
        Me.EndRoundCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.EndRoundCheckBox.TabIndex = 9
        Me.EndRoundCheckBox.Text = "Kill Em Now"
        Me.EndRoundCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Vote To End Round Early"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(43, 168)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(118, 24)
        Me.CheckBox4.TabIndex = 10
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'VoteMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 397)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.EndRoundCheckBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.VoteKillLabel)
        Me.Controls.Add(Me.CheckBox1)
        Me.Name = "VoteMenuForm"
        Me.Text = "Cast Your Vote!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents VoteKillLabel As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents EndRoundCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
End Class
