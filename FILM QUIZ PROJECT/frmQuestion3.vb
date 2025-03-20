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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer3.Checked Then
            playerScore = playerScore + 1
        End If
        frmHighScore.Show()
        frmHighScore.doScore()

        Me.Hide()
    End Sub
    Private Sub tmrQuestion_Tick(sender As Object, e As EventArgs) Handles tmrQuestion.Tick
        progressCount += 1

        ProgressBarQ.PerformStep()

        If progressCount = 10 Then
            tmrQuestion.Enabled = False
            MsgBox("Too Slow Try Again")
            frmHighScore.Show()
            frmHighScore.doScore()

            Me.Hide()
        End If
    End Sub

    Private Sub ProgressBarQ_Click(sender As Object, e As EventArgs) Handles ProgressBarQ.Click

    End Sub
End Class