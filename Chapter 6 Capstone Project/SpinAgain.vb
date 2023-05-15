Public Class SpinAgain
    Private Sub btnSpinagain_Click(sender As Object, e As EventArgs) Handles btnSpinagain.Click
        frmSpin.Show()
        Me.Hide()

    End Sub

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        frmGuess.Show()
        Me.Hide()

    End Sub
End Class