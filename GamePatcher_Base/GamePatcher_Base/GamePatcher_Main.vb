Imports Microsoft.VisualBasic.Devices

Public Class GamePatcher_Main
    Private Sub GamePatcher_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GamePatcher_Splash.Close()
        VersionLabel.Text = GlobalVariables.TMPVersionInt
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
End Class