'Name:        Chapter 6/7 Capstone Project
'Purpose:     ???
'Programmer:  Keteyian & Sophia on 04.26.2023


Option Infer On
Option Strict Off
Option Explicit Off



Public Class frmMain


    Private strFile1Name As String

    Private Async Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click












        btnSpin.Enabled = False

        Dim randGen As New Random
        Dim intRand As Integer


        intRand = randGen.Next(1, 26)

        If intRand < 13 Then
            For intTimer As Integer = 1 To 1




                picWheel.Image = My.Resources.j01
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(1)

            Next intTimer


        ElseIf intRand > 12 Then
            picWheel.Image = My.Resources.j01
            Await Task.Delay(1)
            picWheel.Image = My.Resources.j02
            Await Task.Delay(1)
            picWheel.Image = My.Resources.j03
            Await Task.Delay(1)
            picWheel.Image = My.Resources.j04
            Await Task.Delay(1)
            picWheel.Image = My.Resources.j05
            Await Task.Delay(1)
            picWheel.Image = My.Resources.j06
            Await Task.Delay(1)
            picWheel.Image = My.Resources.j07
            Await Task.Delay(1)
            picWheel.Image = My.Resources.j08
            Await Task.Delay(1)
            picWheel.Image = My.Resources.j09
            Await Task.Delay(1)
            picWheel.Image = My.Resources.j10
            Await Task.Delay(1)
            picWheel.Image = My.Resources.j11
            Await Task.Delay(1)
            picWheel.Image = My.Resources.j12
            Await Task.Delay(1)

        End If





        Select Case True
            Case intRand = 1

                picWheel.Image = My.Resources.j01
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(350)



                picWheel.Image = My.Resources.j01

                Await Task.Delay(500)
                MsgBox("You pulled : 2,000!")

            Case intRand = 2

                picWheel.Image = My.Resources.j01
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(250)



                picWheel.Image = My.Resources.j01
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j02
                MsgBox("You pulled : 1,000!")

            Case intRand = 3
                picWheel.Image = My.Resources.j01
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(200)



                picWheel.Image = My.Resources.j01
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j03

                MsgBox("You pulled : 2,000!")
            Case intRand = 4

                picWheel.Image = My.Resources.j01
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(175)



                picWheel.Image = My.Resources.j01
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j04

                MsgBox("You pulled : 1,000!")
            Case intRand = 5

                picWheel.Image = My.Resources.j01
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(150)



                picWheel.Image = My.Resources.j01
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j05

                MsgBox("BANKRUPT!")
            Case intRand = 6

                picWheel.Image = My.Resources.j01
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(125)



                picWheel.Image = My.Resources.j01
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j06

                MsgBox("You pulled : 1,000!")
            Case intRand = 7
                picWheel.Image = My.Resources.j01
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(100)



                picWheel.Image = My.Resources.j01
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j07
                MsgBox("You pulled : 2,000!")
            Case intRand = 8
                picWheel.Image = My.Resources.j01
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(95)



                picWheel.Image = My.Resources.j01
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j08

                MsgBox("You pulled : 1,000!")
            Case intRand = 9
                picWheel.Image = My.Resources.j01
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(90)



                picWheel.Image = My.Resources.j01
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j09
                MsgBox("You lose a turn!")
            Case intRand = 10
                picWheel.Image = My.Resources.j01
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(85)



                picWheel.Image = My.Resources.j01
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j10
                MsgBox("You pulled : 1,000!")
            Case intRand = 11
                picWheel.Image = My.Resources.j01
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(80)



                picWheel.Image = My.Resources.j01
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j11

                MsgBox("You pulled : 1,000!")
            Case intRand = 12

                picWheel.Image = My.Resources.j01
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(75)



                picWheel.Image = My.Resources.j01
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j11

                Await Task.Delay(350)
                picWheel.Image = My.Resources.j12
                MsgBox("You pulled : 1,000!")
            Case intRand = 13
                picWheel.Image = My.Resources.j13
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(70)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j13



                MsgBox("You pulled : 10,000!")
            Case intRand = 14
                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(65)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j14
                MsgBox("You lose a turn!")
            Case intRand = 15

                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(60)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j15

                MsgBox("BANKRUPT!")
            Case intRand = 16
                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(55)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j16
                MsgBox("You pulled : 5,000!")
            Case intRand = 17
                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(50)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j17
                MsgBox("You pulled : 2,000!")
            Case intRand = 18
                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(45)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j18
                MsgBox("You pulled : 1,000!")
            Case intRand = 19
                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(40)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j19
                MsgBox("You pulled : 1,000!")
            Case intRand = 20
                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(35)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j20
                MsgBox("You pulled : 2,000!")
            Case intRand = 21

                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(30)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j21
                MsgBox("You pulled : 5,000!")
            Case intRand = 22
                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(25)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j22
                MsgBox("You pulled : 2,000!")
            Case intRand = 23

                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(20)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j23
                MsgBox("You pulled : 1,000!")
            Case intRand = 24
                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(10)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(15)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j24
                MsgBox("You lose a turn!")
            Case intRand = 25

                picWheel.Image = My.Resources.j13
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(1)
                picWheel.Image = My.Resources.j25
                Await Task.Delay(10)

                picWheel.Image = My.Resources.j01
                Await Task.Delay(15)
                picWheel.Image = My.Resources.j02
                Await Task.Delay(20)
                picWheel.Image = My.Resources.j03
                Await Task.Delay(25)
                picWheel.Image = My.Resources.j04
                Await Task.Delay(30)
                picWheel.Image = My.Resources.j05
                Await Task.Delay(35)
                picWheel.Image = My.Resources.j06
                Await Task.Delay(40)
                picWheel.Image = My.Resources.j07
                Await Task.Delay(45)
                picWheel.Image = My.Resources.j08
                Await Task.Delay(50)
                picWheel.Image = My.Resources.j09
                Await Task.Delay(55)
                picWheel.Image = My.Resources.j10
                Await Task.Delay(60)
                picWheel.Image = My.Resources.j11
                Await Task.Delay(65)
                picWheel.Image = My.Resources.j12
                Await Task.Delay(70)
                picWheel.Image = My.Resources.j13
                Await Task.Delay(75)
                picWheel.Image = My.Resources.j14
                Await Task.Delay(80)
                picWheel.Image = My.Resources.j15
                Await Task.Delay(85)
                picWheel.Image = My.Resources.j16
                Await Task.Delay(90)
                picWheel.Image = My.Resources.j17
                Await Task.Delay(95)
                picWheel.Image = My.Resources.j18
                Await Task.Delay(100)
                picWheel.Image = My.Resources.j19
                Await Task.Delay(125)
                picWheel.Image = My.Resources.j20
                Await Task.Delay(150)
                picWheel.Image = My.Resources.j21
                Await Task.Delay(175)
                picWheel.Image = My.Resources.j22
                Await Task.Delay(200)
                picWheel.Image = My.Resources.j23
                Await Task.Delay(250)
                picWheel.Image = My.Resources.j24
                Await Task.Delay(350)
                picWheel.Image = My.Resources.j25

                MsgBox("You pulled : 5,000!")
        End Select

        frmGuess.Show()
        Me.Hide()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picWheel.Image = My.Resources.j00
        'poo
    End Sub




End Class
