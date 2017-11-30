Imports System.Net
Imports System.Text

Public Class Form4
    Dim urls As New ArrayList()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        urls.Clear()
        Dim client As WebClient = New WebClient()
        client.Encoding = Encoding.UTF8
        Dim result As String = client.DownloadString("http://optmusic.oa.to/search.php?query=" & TextBox1.Text)
        'MsgBox(result)
        For Each itm In result.Split(vbLf)
            Dim datas = itm.Split("|")
            If (datas.Length = 1) Then
                '1개
                urls.Add("")
            Else
                '2개
                If (datas(1).StartsWith("yt://")) Then

                    urls.Add(datas(1))
                Else

                    urls.Add("http://optmusic.oa.to/uploads/" & datas(1))
                End If
            End If
                ListBox1.Items.Add(datas(0))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If (ListBox1.SelectedItem = "") Then
            ListBox1.ClearSelected()

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        If (ListBox1.SelectedItem = "") Then
        Else
            If (urls.Item(ListBox1.SelectedIndex).startsWith("yt://")) Then
                Form7.Show()
                Form7.WebBrowser1.Navigate("https://odg.youtube6download.top/cnvx.php?id=" & urls.Item(ListBox1.SelectedIndex).Replace("yt://", ""))
                Form7.WebBrowser1.ScriptErrorsSuppressed = True
                Form7.Label2.Text = ListBox1.SelectedItem

            Else
                'Form2.ListBox1.Items.Add("[CLOUD]" & ListBox1.SelectedItem)
                Form2.playfulladdr.Add(urls.Item(ListBox1.SelectedIndex))
                MsgBox("추가되었습니다.")
            End If
        End If
    End Sub
End Class