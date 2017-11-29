<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WebKitBrowser1 = New WebKit.WebKitBrowser()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "YouTube Music: Download Mp3 버튼을 누르세요"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(64, 249)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(500, 194)
        Me.WebBrowser1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Music Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'WebKitBrowser1
        '
        Me.WebKitBrowser1.BackColor = System.Drawing.Color.White
        Me.WebKitBrowser1.Location = New System.Drawing.Point(19, 56)
        Me.WebKitBrowser1.Name = "WebKitBrowser1"
        Me.WebKitBrowser1.Size = New System.Drawing.Size(531, 175)
        Me.WebKitBrowser1.TabIndex = 4
        Me.WebKitBrowser1.Url = Nothing
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 244)
        Me.Controls.Add(Me.WebKitBrowser1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents WebKitBrowser1 As WebKit.WebKitBrowser
End Class
