Public Class Form6
    Public playfulladdr As New ArrayList()


    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (CheckedListBox1.SelectedIndex = -1) Then
            MsgBox("선택된 항목이 없습니다.")
        Else
            If AxWindowsMediaPlayer1.URL = playfulladdr.Item(CheckedListBox1.SelectedIndex) Then
            Else

                AxWindowsMediaPlayer1.URL = playfulladdr.Item(CheckedListBox1.SelectedIndex)
            End If
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
        Label3.Text = CheckedListBox1.SelectedItem

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        OpenFileDialog1.Filter = "All Files|*.*|Mp3|*.mp3*|Wma|*.wma*|Mp4|*.mp4*|Wav|*.wav*|swf|*.swf*"
        If OpenFileDialog1.ShowDialog() Then
            If (OpenFileDialog1.SafeFileName.EndsWith("mp3")) Or (OpenFileDialog1.SafeFileName.EndsWith("wma")) Or (OpenFileDialog1.SafeFileName.EndsWith("mp4")) Or (OpenFileDialog1.SafeFileName.EndsWith("wav")) Then

                CheckedListBox1.Items.Add(OpenFileDialog1.SafeFileName)
                playfulladdr.Add(OpenFileDialog1.FileName)
            Else
                MsgBox("지원하지 않는 형식의 파일입니다.")
            End If

        End If
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = HScrollBar1.Value
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HScrollBar1.Value = 50
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemChecked(i, True)
            Next
        Else
            While CheckedListBox1.CheckedIndices.Count > 0
                CheckedListBox1.SetItemChecked(CheckedListBox1.CheckedIndices(0), False)
            End While
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ' If (CheckedListBox1.SelectedIndex = -1) Then
        'MsgBox("지울 항목이 없습니다.")
        '  Else
        'playfulladdr.RemoveAt(CheckedListBox1.SelectedIndex)
        'CheckedListBox1.Items.Remove(CheckedListBox1.SelectedItem)
        ' End If
        'If (CheckedListBox1.SelectedIndex = -1) Then
        'MsgBox("지울 항목이 없습니다.")
        'Else
        If CheckedListBox1.CheckedItems.Count > 0 Then
            For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
                playfulladdr.Remove(CheckedListBox1.CheckedItems)
                playfulladdr.RemoveAt(CheckedListBox1.SelectedIndex)
                CheckedListBox1.Items.Remove(CheckedListBox1.CheckedItems(0))
            Next
        Else
            MsgBox("지울 항목이 없습니다.")
        End If


        'Else
        'MsgBox("지울 항목이 없습니다.")
        ' End If


        ' ListBox1.Items.Add(CheckedListBox1.CheckedItems(i))
    End Sub
End Class