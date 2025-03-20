Public Class frmQuestion1
    Public Sub init()

        progressCount = 0
        tmrQuestion.Enabled = True
        ProgressBarQ.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        tmrQuestion.Enabled = False
        If btnAnswer2.Checked Then
            playerScore = playerScore + 1
        End If
        frmQuestion2.Show()
        Me.Hide()





    End Sub

    Private Sub tmrQuestion_Tick(sender As Object, e As EventArgs) Handles tmrQuestion.Tick
        progressCount = progressCount + 1

        ProgressBarQ.PerformStep()
        If progressCount = 10 Then
            tmrQuestion.Enabled = False
            MsgBox("Too Slow Try Again")
            frmQuestion2.Show()
            frmQuestion2.init()
            Me.Hide()
        End If
    End Sub
End Class