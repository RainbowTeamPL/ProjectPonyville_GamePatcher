<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDKeyForm
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
        Me.CDKeyTextBox = New System.Windows.Forms.TextBox()
        Me.VerifyBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KeyCorrectLabel = New System.Windows.Forms.Label()
        Me.IncorrectKeyLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CDKeyTextBox
        '
        Me.CDKeyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CDKeyTextBox.Location = New System.Drawing.Point(12, 25)
        Me.CDKeyTextBox.MaxLength = 29
        Me.CDKeyTextBox.Name = "CDKeyTextBox"
        Me.CDKeyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CDKeyTextBox.TabIndex = 0
        Me.CDKeyTextBox.Text = "36WTE-4G440-XZS7S-77FP6-OVALL"
        Me.CDKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VerifyBtn
        '
        Me.VerifyBtn.Location = New System.Drawing.Point(12, 80)
        Me.VerifyBtn.Name = "VerifyBtn"
        Me.VerifyBtn.Size = New System.Drawing.Size(200, 23)
        Me.VerifyBtn.TabIndex = 1
        Me.VerifyBtn.Text = "Close"
        Me.VerifyBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please input Your CD-Key below:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Key Status:"
        '
        'KeyCorrectLabel
        '
        Me.KeyCorrectLabel.AutoSize = True
        Me.KeyCorrectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.KeyCorrectLabel.ForeColor = System.Drawing.Color.Lime
        Me.KeyCorrectLabel.Location = New System.Drawing.Point(121, 48)
        Me.KeyCorrectLabel.Name = "KeyCorrectLabel"
        Me.KeyCorrectLabel.Size = New System.Drawing.Size(58, 16)
        Me.KeyCorrectLabel.TabIndex = 4
        Me.KeyCorrectLabel.Text = "Correct"
        Me.KeyCorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IncorrectKeyLabel
        '
        Me.IncorrectKeyLabel.AutoSize = True
        Me.IncorrectKeyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.IncorrectKeyLabel.ForeColor = System.Drawing.Color.Red
        Me.IncorrectKeyLabel.Location = New System.Drawing.Point(121, 48)
        Me.IncorrectKeyLabel.Name = "IncorrectKeyLabel"
        Me.IncorrectKeyLabel.Size = New System.Drawing.Size(68, 16)
        Me.IncorrectKeyLabel.TabIndex = 5
        Me.IncorrectKeyLabel.Text = "Incorrect"
        Me.IncorrectKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CDKeyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 109)
        Me.Controls.Add(Me.IncorrectKeyLabel)
        Me.Controls.Add(Me.KeyCorrectLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VerifyBtn)
        Me.Controls.Add(Me.CDKeyTextBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CDKeyForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CDKeyTextBox As TextBox
    Friend WithEvents VerifyBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents KeyCorrectLabel As Label
    Friend WithEvents IncorrectKeyLabel As Label
End Class
