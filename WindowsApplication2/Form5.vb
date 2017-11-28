Imports System.Net
Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim client As WebClient = New WebClient()
        Try
            If CheckBox1.Checked And CheckBox2.Checked = True Then
                Dim reply As String = client.DownloadString("http://optmusic.oa.to/user_add.php?username=" & TextBox1.Text & "&password=" & TextBox2.Text)
                If (reply = "1") Then
                    MsgBox("회원가입 성공하였습니다.")
                Else
                    MsgBox("회원가입에 실패하였습니다. " & reply, MsgBoxStyle.Information, "로그인 오류!")
                End If
            Else
                MsgBox("이용약관에 동의가 되어있지 않습니다.", MsgBoxStyle.Information, "로그인 오류!")
            End If

        Catch ex As Exception
            MsgBox("서버에 연결할 수 없습니다. " & ex.Message)
        End Try
    End Sub
End Class