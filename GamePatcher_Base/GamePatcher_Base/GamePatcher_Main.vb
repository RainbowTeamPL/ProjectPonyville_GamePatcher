Imports Microsoft.VisualBasic.Devices

Public Class GamePatcher_Main
    Private Sub GamePatcher_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GamePatcher_Splash.Close()
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

End Class