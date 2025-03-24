Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        playerScore = 0
        playerName = txtPlayerName.Text
        frmQuestion1.Show()

        Me.Hide()

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub txtPlayerName_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerName.TextChanged

    End Sub
End Class