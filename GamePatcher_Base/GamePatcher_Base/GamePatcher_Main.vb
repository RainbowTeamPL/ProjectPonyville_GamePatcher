Imports System.IO
Imports Microsoft.VisualBasic.Devices

Public Class GamePatcher_Main
    Private Sub GamePatcher_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GamePatcher_Splash.Close()
        VersionLabel.Text = GlobalVariables.TMPVersion
        Reload()
    End Sub

    Public Event NetworkAvailabilityChanged As NetworkAvailableEventHandler
    Private Sub MyApplication_NetworkAvailabilityChanged(
    ByVal sender As Object,
    ByVal e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs
) Handles Me.NetworkAvailabilityChanged
        My.Forms.Workaround1.SetConnectionStatus(e.IsNetworkAvailable)
    End Sub

    Private Sub GamePatcher_Main_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing
        My.Forms.Workaround1.MainClosed = True
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub InsertCDKeyMenu_Click(sender As Object, e As EventArgs) Handles InsertCDKeyMenu.Click
        CDKeyForm.Show()
        CDKeyForm.RegistryRead()
    End Sub

    Private Sub InstallBtn_Click(sender As Object, e As EventArgs) Handles InstallBtn.Click
        My.Forms.InstallGameForm.Show()
        My.Forms.InstallGameForm.Activate()

    End Sub

    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        Dim game As New ProcessStartInfo(Application.StartupPath & "\ProjectPonyville\ProjectPonyville.exe", "-game")
        Process.Start(game)

    End Sub

    Public Sub Reload()
        If (My.Computer.FileSystem.FileExists(Application.StartupPath & "\ProjectPonyville\ProjectPonyville.exe")) Then
            InstallBtn.Enabled = False
            PlayBtn.Enabled = True
            UninstallToolStripMenuItem.Enabled = True

        Else
            InstallBtn.Enabled = True
            PlayBtn.Enabled = False
            UninstallToolStripMenuItem.Enabled = False

            'InstallBtn.Enabled = False
            'PlayBtn.Enabled = True

        End If
    End Sub

    Private Sub UninstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UninstallToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Do you really want to uninstall ProjectPonyville?", "Confirm uninstallation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Uninstall()
        End If
        If result = DialogResult.No Then

        End If
        Reload()
    End Sub

    Sub Uninstall()
        Directory.Delete(Application.StartupPath & "\ProjectPonyville\", True)
        'Dim uninstallpp As New ProcessStartInfo(Application.StartupPath & "uninstall_pp.cmd")
        'Process.Start(uninstallpp)

        'Dim objProcess As System.Diagnostics.Process
        'Try
        '    objProcess = New System.Diagnostics.Process()
        '    objProcess.StartInfo.FileName = Application.StartupPath & "\uninstall_pp.cmd"
        '    objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        '    objProcess.Start()

        '    'Wait until the process passes back an exit code
        '    objProcess.WaitForExit()

        '    'Free Resources associated with this process
        '    objProcess.Close()
        'Catch
        '    MessageBox.Show("Could not uninstall", "Error")
        'End Try

    End Sub
End Class