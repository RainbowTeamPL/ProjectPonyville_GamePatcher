<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GamePatcher_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertCDKeyMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.UninstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.InstallBtn = New System.Windows.Forms.Button()
        Me.PlayBtn = New System.Windows.Forms.Button()
        Me.UpdateText = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(264, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(20, 20)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MinimizeButton.Location = New System.Drawing.Point(238, 0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(20, 20)
        Me.MinimizeButton.TabIndex = 1
        Me.MinimizeButton.Text = "–"
        Me.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MinimizeButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertCDKeyMenu, Me.UninstallToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
        Me.ToolStripMenuItem1.Text = "Tools"
        '
        'InsertCDKeyMenu
        '
        Me.InsertCDKeyMenu.Enabled = False
        Me.InsertCDKeyMenu.Name = "InsertCDKeyMenu"
        Me.InsertCDKeyMenu.Size = New System.Drawing.Size(155, 22)
        Me.InsertCDKeyMenu.Text = "Insert CD-Key..."
        '
        'UninstallToolStripMenuItem
        '
        Me.UninstallToolStripMenuItem.Name = "UninstallToolStripMenuItem"
        Me.UninstallToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.UninstallToolStripMenuItem.Text = "Uninstall..."
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(235, 239)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(0, 13)
        Me.VersionLabel.TabIndex = 4
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InstallBtn
        '
        Me.InstallBtn.Location = New System.Drawing.Point(12, 194)
        Me.InstallBtn.Name = "InstallBtn"
        Me.InstallBtn.Size = New System.Drawing.Size(260, 42)
        Me.InstallBtn.TabIndex = 5
        Me.InstallBtn.Text = "Install"
        Me.InstallBtn.UseVisualStyleBackColor = True
        '
        'PlayBtn
        '
        Me.PlayBtn.Location = New System.Drawing.Point(12, 146)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(260, 42)
        Me.PlayBtn.TabIndex = 6
        Me.PlayBtn.Text = "Play"
        Me.PlayBtn.UseVisualStyleBackColor = True
        '
        'UpdateText
        '
        Me.UpdateText.AutoSize = True
        Me.UpdateText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.UpdateText.ForeColor = System.Drawing.Color.Red
        Me.UpdateText.Location = New System.Drawing.Point(51, 118)
        Me.UpdateText.Name = "UpdateText"
        Me.UpdateText.Size = New System.Drawing.Size(172, 25)
        Me.UpdateText.TabIndex = 7
        Me.UpdateText.Text = "Update Avaible"
        Me.UpdateText.Visible = False
        '
        'GamePatcher_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.UpdateText)
        Me.Controls.Add(Me.PlayBtn)
        Me.Controls.Add(Me.InstallBtn)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GamePatcher_Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InsertCDKeyMenu As ToolStripMenuItem
    Friend WithEvents VersionLabel As Label
    Friend WithEvents InstallBtn As Button
    Friend WithEvents PlayBtn As Button
    Friend WithEvents UninstallToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateText As Label
End Class
