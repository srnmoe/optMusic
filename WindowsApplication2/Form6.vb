Public Class Form6
    Public playfulladdr As New ArrayList()

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (ListBox1.SelectedIndex = -1) Then
            MsgBox("선택된 항목이 없습니다.")
        Else
            If AxWindowsMediaPlayer1.URL = playfulladdr.Item(ListBox1.SelectedIndex) Then
            Else

                AxWindowsMediaPlayer1.URL = playfulladdr.Item(ListBox1.SelectedIndex)
            End If
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        OpenFileDialog1.Filter = "All Files|*.*|Mp3|*.mp3*|Wma|*.wma*|Mp4|*.mp4*|Wav|*.wav*|swf|*.swf*"
        If OpenFileDialog1.ShowDialog() Then
            If (OpenFileDialog1.SafeFileName.EndsWith("mp3")) Or (OpenFileDialog1.SafeFileName.EndsWith("wma")) Or (OpenFileDialog1.SafeFileName.EndsWith("mp4")) Or (OpenFileDialog1.SafeFileName.EndsWith("wav")) Then

                ListBox1.Items.Add(OpenFileDialog1.SafeFileName)
                playfulladdr.Add(OpenFileDialog1.FileName)
            Else
                MsgBox("지원하지 않는 형식의 파일입니다.")
            End If

        End If
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick

    End Sub
End Class