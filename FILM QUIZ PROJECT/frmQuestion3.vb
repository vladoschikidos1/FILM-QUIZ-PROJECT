Public Class frmQuestion3
    Public Sub init()

        progressCount = 0
        tmrQuestion3.Enabled = True
        ProgressBarQ3.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub tmrQuestion_Tick(sender As Object, e As EventArgs) Handles tmrQuestion3.Tick

    End Sub
End Class