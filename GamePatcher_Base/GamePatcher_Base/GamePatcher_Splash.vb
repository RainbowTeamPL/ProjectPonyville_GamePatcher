Imports Microsoft.VisualBasic.Devices

Public Class GamePatcher_Splash
    Private Sub GamePatcher_Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\temp\version.v") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\temp\version.v")
        End If
        My.Computer.Network.DownloadFile(My.Resources.Resource1.VersionURL, Application.StartupPath & "\temp\version.v")


        ProgressBar1.Value = 100
        GamePatcher_Main.Show()
        GlobalVariables.TMPVersion = StringToInt(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\temp\version.v"))
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\temp\version.v")
        Me.Close()
    End Sub
End Class