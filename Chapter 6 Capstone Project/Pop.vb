Public Class frmPop
    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        frmSpin.Show()
        Me.Hide()
    End Sub

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        frmGuess.Show()
        Me.Hide()
        txtWord.Text = "7"
    End Sub
End Class