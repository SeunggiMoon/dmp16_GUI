Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .InitialDirectory = "C:\"
            .FileName = ""
            .Filter = "모든 파일(*.*)|*.*"
            .FilterIndex = 1
            .RestoreDirectory = True
        End With
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Shell("cmd.exe /c " + "dmp16_guiaddon " + TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("프로그램을 찾을 수 없습니다.", "dmp16", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Try
            Form2.RichTextBox1.LoadFile(OpenFileDialog1.FileName + ".dmp", RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            MessageBox.Show("덤프 파일을 열 수 없거나 파일이 손상되었습니다.", "dmp16", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("explorer http://moon44432.blog.me")
    End Sub
End Class
