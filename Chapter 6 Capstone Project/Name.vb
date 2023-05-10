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


End Class