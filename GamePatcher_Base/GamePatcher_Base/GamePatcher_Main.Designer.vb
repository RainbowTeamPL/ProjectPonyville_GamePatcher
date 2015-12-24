<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamePatcher_Main
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
        Me.NetworkLabel1 = New System.Windows.Forms.Label()
        Me.NetwrkStatus = New System.Windows.Forms.Label()
        Me.NetworkStatus = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'NetworkLabel1
        '
        Me.NetworkLabel1.AutoSize = True
        Me.NetworkLabel1.Location = New System.Drawing.Point(13, 13)
        Me.NetworkLabel1.Name = "NetworkLabel1"
        Me.NetworkLabel1.Size = New System.Drawing.Size(83, 13)
        Me.NetworkLabel1.TabIndex = 0
        Me.NetworkLabel1.Text = "Network Status:"
        '
        'NetwrkStatus
        '
        Me.NetwrkStatus.AutoSize = True
        Me.NetwrkStatus.Location = New System.Drawing.Point(103, 13)
        Me.NetwrkStatus.Name = "NetwrkStatus"
        Me.NetwrkStatus.Size = New System.Drawing.Size(78, 13)
        Me.NetwrkStatus.TabIndex = 1
        Me.NetwrkStatus.Text = "No Connection"
        '
        'NetworkStatus
        '
        Me.NetworkStatus.BackColor = System.Drawing.SystemColors.Control
        Me.NetworkStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NetworkStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.NetworkStatus.Location = New System.Drawing.Point(102, 13)
        Me.NetworkStatus.Name = "NetworkStatus"
        Me.NetworkStatus.ReadOnly = True
        Me.NetworkStatus.Size = New System.Drawing.Size(100, 13)
        Me.NetworkStatus.TabIndex = 2
        '
        'GamePatcher_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.NetworkStatus)
        Me.Controls.Add(Me.NetwrkStatus)
        Me.Controls.Add(Me.NetworkLabel1)
        Me.Name = "GamePatcher_Main"
        Me.Text = "GamePatcher_Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NetworkLabel1 As Label
    Public WithEvents NetwrkStatus As Label
    Public WithEvents NetworkStatus As TextBox
End Class
