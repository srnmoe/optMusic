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
                urls.Add("http://optmusic.oa.to/uploads/" & datas(1))
            End If
            ListBox1.Items.Add(datas(0))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        If (ListBox1.SelectedItem = "") Then
        Else

            Form2.ListBox1.Items.Add(ListBox1.SelectedItem)
            Form2.playfulladdr.Add(urls.Item(ListBox1.SelectedIndex))
            MsgBox("추가되었습니다.")
        End If
    End Sub
End Class