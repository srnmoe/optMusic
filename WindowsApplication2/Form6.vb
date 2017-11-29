Imports System.ComponentModel
Imports WebKit

Public Class Form6
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub WebBrowser1_NewWindow(sender As Object, e As CancelEventArgs) Handles WebBrowser1.NewWindow
        e.Cancel = True
    End Sub

    Private Sub WebBrowser1_FileDownload(sender As Object, e As EventArgs) Handles WebBrowser1.FileDownload
        MessageBox.Show("You are in the WebBrowser.FileDownload event.")

        '     Form2.ListBox1.Items.Add("[YT]" & Label3.Text)
        '     Form2.playfulladdr.Add(WebBrowser1.Url.ToString())
        '     MsgBox("추가완료!" & WebBrowser1.Url.ToString())
        '     Me.Close()
    End Sub

    Private Sub WebKitBrowser1_Load(sender As Object, e As EventArgs) Handles WebKitBrowser1.Load

    End Sub

    Private Sub WebKitBrowser1_DownloadBegin(sender As Object, e As FileDownloadBeginEventArgs) Handles WebKitBrowser1.DownloadBegin
        Form2.ListBox1.Items.Add("[YT]" & Label3.Text)
        Form2.playfulladdr.Add(e.Download.FilePath)
        MsgBox("추가완료!" & e.Download.FilePath)
        Me.Close()


    End Sub
End Class