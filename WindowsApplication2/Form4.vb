Imports System.Net
Imports System.Text

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim client As WebClient = New WebClient()
        client.Encoding = Encoding.UTF8
        Dim result As String = client.DownloadString("http://optmusic.oa.to/search.php?query=" & TextBox1.Text)
        MsgBox(result)
        For Each itm In result.Split("afdfesfsdfsd")
            ListBox1.Items.Add(itm)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class