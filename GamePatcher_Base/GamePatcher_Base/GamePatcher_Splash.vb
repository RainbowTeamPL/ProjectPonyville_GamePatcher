﻿Imports Microsoft.VisualBasic.Devices

Public Class GamePatcher_Splash
    Private Sub GamePatcher_Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\temp\version.v") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\temp\version.v")
        End If
        My.Computer.Network.DownloadFile(My.Resources.Resource1.VersionURL, Application.StartupPath & "\temp\version.v")
        GlobalVariables.TMPVersion = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\temp\version.v")
        GlobalVariables.TMPVersionInt = Convert.ToDecimal(GlobalVariables.TMPVersion)

        VersionLabel.Text = GlobalVariables.TMPVersionInt
        ProgressBar1.Value = 100
        'GamePatcher_Main.Show()
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\temp\version.v")
        'Close()
        'Workaround1.Workaround1_ShowMainMenu()
    End Sub

    Private Sub GamePatcher_Splash_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        My.Forms.Workaround1.SplashClosed = True
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
    End Sub
End Class