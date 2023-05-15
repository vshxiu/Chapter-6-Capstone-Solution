'Name:        Chapter 6/7 Capstone Project
'Purpose:     Imitate Wheel of Fortune
'Programmer:  Keteyian & Sophia on 04.26.2023


Option Infer Off
Option Strict On
Option Explicit On


Public Class frmName
    Private Sub btnReady_Click(sender As Object, e As EventArgs) Handles btnReady.Click
        Dim strOne As String
        Dim strTwo As String

        strOne = txtOne.Text
        strTwo = txtTwo.Text

        frmSpin.Show()
        Me.Hide()

    End Sub




    Private Sub txtOne_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOne.KeyPress

        Dim strText As String

        Dim strLetter As String

        If txtOne.Text.Length = 1 Then
            strText = txtOne.Text

            strLetter = txtOne.Text.Substring(0, 1).ToUpper

            strText = strText.Remove(0, 1)
            txtOne.Text = strText.Insert(0, strLetter)
            txtOne.SelectionStart = Len(txtOne.Text)
        End If
    End Sub

    Private Sub txtTwo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTwo.KeyPress
        Dim strText As String

        Dim strLetter As String

        If txtTwo.Text.Length = 1 Then
            strText = txtTwo.Text

            strLetter = txtTwo.Text.Substring(0, 1).ToUpper

            strText = strText.Remove(0, 1)
            txtTwo.Text = strText.Insert(0, strLetter)
            txtTwo.SelectionStart = Len(txtTwo.Text)
        End If
    End Sub
End Class