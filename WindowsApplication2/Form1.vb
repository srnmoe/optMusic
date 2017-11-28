Imports System.Net

Public Class Form1
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HTCAPTION As Integer = &H2

    Dim playfulladdr As New ArrayList()
    <Runtime.InteropServices.DllImport("User32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    <Runtime.InteropServices.DllImport("User32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim client As WebClient = New WebClient()
        Try

            Dim reply As String = client.DownloadString("http://optmusic.oa.to/login.php?username=" & TextBox1.Text & "&password=" & TextBox2.Text)
            If (reply = "1") Then
                If MsgBox("로그인 정보 확인 완료!" + vbCrLf + "[로그인 하시겠습니까?]", MsgBoxStyle.YesNo, "Login") = vbYes Then
                    Me.Hide()
                    My.Computer.Audio.Stop()
                    Form2.Show()
                End If
            Else
                MsgBox("로그인 정보가 일치하지 않습니다." & reply, MsgBoxStyle.Information, "로그인 오류!")
            End If
        Catch ex As Exception
            MsgBox("서버에 연결할 수 없습니다. " & ex.Message)
        End Try

        '        If TextBox1.Text = ("kimtae1500") And TextBox2.Text = ("kimtae213") Then
        '       If MsgBox("로그인 정보 확인 완료!" + vbCrLf + "[로그인 하시겠습니까?]", MsgBoxStyle.YesNo, "Login") = vbYes Then
        '      Me.Hide()
        '     Form2.Show()
        '
        ' e nd If
        'Else
        '
        'End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            My.Computer.Audio.Play(My.Resources.no_game, AudioPlayMode.Background)
        End If
        If Me.CheckBox1.Checked = False Then
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim client As WebClient = New WebClient()
        Try

            Dim reply As String = client.DownloadString("http://optmusic.oa.to/user_add.php?username=" & TextBox1.Text & "&password=" & TextBox2.Text)
            If (reply = "1") Then
                MsgBox("회원가입 성공하였습니다.")
            Else
                MsgBox("회원가입에 실패하였습니다. " & reply, MsgBoxStyle.Information, "로그인 오류!")
            End If
        Catch ex As Exception
            MsgBox("서버에 연결할 수 없습니다. " & ex.Message)
        End Try
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If (e.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)

        End If
    End Sub
    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown
        If (e.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form5.Show()
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.Black
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.DarkGray
    End Sub
End Class
