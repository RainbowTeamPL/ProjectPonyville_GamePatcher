Option Strict On
Option Explicit On

Imports System.Threading

Public Class Workaround1
    Public Shared MainClosed As Boolean = False
    Public Shared SplashClosed As Boolean = False

    Private Sub Workaround1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GamePatcher_Splash.Show()
        'GamePatcher_Main.Show()
    End Sub

    Public Sub Workaround1_ShowMainMenu()
        'GamePatcher_Splash.Close()
        GamePatcher_Main.Show()
    End Sub

    Public Sub SetConnectionStatus(ByVal bool As Boolean)
        My.Forms.GamePatcher_Main.NetworkStatus.ReadOnly = False
        If bool = True Then

            My.Forms.GamePatcher_Main.NetworkStatus.Text = "EYUP"
        Else
            My.Forms.GamePatcher_Main.NetworkStatus.Text = "NOPE"
        End If
        My.Forms.GamePatcher_Main.NetworkStatus.ReadOnly = True
    End Sub

    Private Sub TimerCheckSplash_Tick(sender As Object, e As EventArgs) Handles TimerCheckSplash.Tick
        If (GamePatcher_Splash.IsDisposed = False) Then
            GamePatcher_Main.Show()
            TimerCheckSplash.Stop()
        End If
    End Sub

    Private Sub TimerCheckWindows_Tick(sender As Object, e As EventArgs) Handles TimerCheckWindows.Tick
        If MainClosed And SplashClosed Then
            Application.Exit()
        End If
    End Sub
End Class