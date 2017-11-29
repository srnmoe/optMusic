Public Class Form7
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub WebBrowser1_FileDownload(sender As Object, e As EventArgs) Handles WebBrowser1.FileDownload
        MsgBox("다운로드 시작!!!!!!!!!!!!!!!!!!")
    End Sub
End Class