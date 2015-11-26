Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With SaveFileDialog1
            .InitialDirectory = "C:\"
            .FileName = ""
            .Filter = "덤프 파일(*.dmp)|*.dmp"
            .FilterIndex = 1
            .RestoreDirectory = True
        End With
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
    End Sub
End Class