Imports AxWMPLib
Imports WMPLib



Public Class Form2

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HTCAPTION As Integer = &H2

    Public playfulladdr As New ArrayList()
    <Runtime.InteropServices.DllImport("User32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    <Runtime.InteropServices.DllImport("User32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    End Function



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HScrollBar1.Value = 50
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.Filter = "MP3 Files|*.mp3|Windows Media Audio Files|*.wma|Wave Files|*.wav"
        If OpenFileDialog1.ShowDialog() Then
            If (OpenFileDialog1.SafeFileName.EndsWith("mp3")) Then

                ListBox1.Items.Add(OpenFileDialog1.SafeFileName)
                playfulladdr.Add(OpenFileDialog1.FileName)
            Else
                MsgBox("mp3파일이 아닙니다.")
            End If

        End If

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = HScrollBar1.Value
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'AxWindowsMediaPlayer1.URL = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (ListBox1.SelectedIndex = -1) Then
            MsgBox("선택된 항목이 없습니다.")
        Else
            If AxWindowsMediaPlayer1.URL = playfulladdr.Item(ListBox1.SelectedIndex) Then
            Else

                AxWindowsMediaPlayer1.URL = playfulladdr.Item(ListBox1.SelectedIndex)
            End If
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
        MsgBox("PlayDest " & playfulladdr.Item(ListBox1.SelectedIndex))

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' ListBox1.SelectedItems.Clear() 선택된 하나만 삭제되도록 하기
        If (ListBox1.SelectedIndex = -1) Then
            MsgBox("지울 항목이 없습니다.")
        Else

            playfulladdr.RemoveAt(ListBox1.SelectedIndex)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If (e.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form3.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form4.Show()
    End Sub
End Class


