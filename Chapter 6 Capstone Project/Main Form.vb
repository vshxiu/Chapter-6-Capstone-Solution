'Name:        Chapter 6/7 Capstone Project
'Purpose:     ???
'Programmer:  Keteyian & Sophia on 04.26.2023


Option Infer Off
Option Strict On
Option Explicit On



Public Class frmMain
    Private Async Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click



        Dim randGen As New Random
        Dim intRand As Integer

        For intTimer As Integer = 1 To 50
            intRand = randGen.Next(1, 26)

            'PictureBox1.Image = My.Resources.j00
            'Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j01
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j02
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j03
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j04
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j05
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j06
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j07
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j08
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j09
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j10
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j11
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j12
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j13
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j14
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j15
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j16
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j17
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j18
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j19
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j20
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j21
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j22
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j23
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j24
            Await Task.Delay(50)
            PictureBox1.Image = My.Resources.j25
            'If PictureBox1.Image = My.Resources.pic Then

            'End If
        Next



    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.j00

    End Sub
End Class
