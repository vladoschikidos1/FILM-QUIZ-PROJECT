Public Class frmHighScore
    Public Sub doScore()
        If playerScore < 1 Then
            lblMessage.Text = "Sorry Your Score Was Not Good Enough"
        Else
            lblMessage.Text = "Congratulation Your Score Will Be added to The Hall Of Fame"

            lstHighScore.Items.Add(playerName & vbTab & playerScore)

        End If
    End Sub
    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub lstHighScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHighScore.SelectedIndexChanged


    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub
End Class