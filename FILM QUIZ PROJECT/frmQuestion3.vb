Public Class frmQuestion3
    Public Sub init()

        progressCount = 0
        tmrQuestion.Enabled = True
        ProgressBarQ.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class