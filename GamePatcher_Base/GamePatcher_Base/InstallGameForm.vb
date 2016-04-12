Imports System.Net
Public Class InstallGameForm

    Private Sub GamePatcher_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim client As WebClient = New WebClient
        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        'client.DownloadFileAsync(New Uri("https://github.com/RainbowTeamPL/ProjectPonyville/releases/download/0.0.1-pa/0.0.1-pa.7z"), Application.StartupPath & "\temp\download.7z")
        client.DownloadFileAsync(New Uri("http://127.0.0.1/slowdown/0.0.1-pa.7z"), Application.StartupPath & "\temp\download.7z")

        'btnStartDownload.Text = "Download in Progress"
        'btnStartDownload.Enabled = False
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
        Label1.Text = Math.Round(bytesIn / (1024 * 1024), 2) & "MB / " & Math.Round(totalBytes / (1024 * 1024), 2) & "MB"

    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        'MessageBox.Show("Download Complete")
        'Dim unzip As New ProcessStartInfo(Application.StartupPath & "\7z\7za.cmd")
        ProgressBar1.Value = 100%
        unzip()
        'btnStartDownload.Text = "Start Download"
        'btnStartDownload.Enabled = True
    End Sub

    Public Sub unzip()
        'Dim unzip As New ProcessStartInfo(Application.StartupPath & "\7z\7za.exe", "x '" & Application.StartupPath & "\temp\download.7z' -o'" & Application.StartupPath & "\ProjectPonyville' -y")
        Dim unzip As New ProcessStartInfo(Application.StartupPath & "\7z\7za.cmd")

        Dim objProcess As System.Diagnostics.Process
        Try
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = Application.StartupPath & "\7z\7za.cmd"
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            objProcess.Start()

            'Wait until the process passes back an exit code
            objProcess.WaitForExit()
            ProgressBar1.Value = 100%
            CancelBtn.Text = "Close"
            Label1.Text = "Finished"
            My.Forms.GamePatcher_Main.Refresh()
            My.Forms.GamePatcher_Main.Reload()

            'Free resources associated with this process
            objProcess.Close()
        Catch
            MessageBox.Show("Could not start process " & Application.StartupPath & "\7z\7za.cmd", "Error")
        End Try

        'Process.Start(unzip)
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        'My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\temp\download.7z")
        Me.Close()
    End Sub
End Class