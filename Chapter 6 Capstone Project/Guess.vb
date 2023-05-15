'Name:        Chapter 6/7 Capstone Project
'Purpose:     Imitate Wheel of Fortune
'Programmer:  Keteyian & Sophia on 04.26.2023


Option Infer Off
Option Strict On
Option Explicit On



Public Class frmGuess
    Private strFile1Name As String

    Function GuessLetter(ByVal strLetter As String) As Boolean

        Dim strWord As String
        Dim boo As Boolean
        Dim strResult As String
        strWord = txtWord.Text.Trim.ToUpper



        strResult = lblWord.Text
        If strWord.Contains(strLetter) Then
            'Replace the hyphen(s) in strResult.
            For intIndex As Integer = 0 To strWord.Length - 1
                If strWord(intIndex) = strLetter Then
                    strResult = strResult.Remove(intIndex, 1)
                    strResult = strResult.Insert(intIndex, strLetter)
                End If
            Next intIndex
            'Display the contents of strResult.
            lblWord.Text = strResult
            'Determine whether strResult contains any hyphens.
            boo = True
            If strResult.Contains("_") = False Then
                MessageBox.Show("You guessed it: " & strWord, "Guess the
Word game", MessageBoxButtons.OK,
                MessageBoxIcon.Information)


            End If

        Else
            MessageBox.Show("Try again!", "Guess the Word Game",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            boo = False
        End If
        'txtLetter.Text = String.Empty



        Return boo
    End Function
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'btnGenerate.Enabled = False
        Dim randNum As New Random


        Dim inFile As IO.StreamReader
        Dim strLine As String

        If IO.File.Exists(strFile1Name) Then
            Dim intCount As Integer = 0

            inFile = IO.File.OpenText(strFile1Name)
            Do Until inFile.Peek = -1
                strLine = inFile.ReadLine


            Loop



            inFile.Close()

        End If
        Dim sr As New System.IO.StreamReader(strFile1Name)
        Dim sr2 As New System.IO.StreamReader(strFile1Name)
        Dim index As Integer = 0
        Dim currentline As Integer = 0
        Dim random As Integer = 0
        lblWord.Text = ""
        Do Until sr.EndOfStream = True
            sr.ReadLine()
            index += 1
        Loop
        random = randNum.Next(1, index + 1)

        Do Until currentline = random
            txtWord.Text = sr2.ReadLine
            currentline += 1
        Loop

        Dim intLength As Integer
        intLength = txtWord.Text.Length

        For intx As Integer = 1 To intLength
            lblWord.Text += "_ "
        Next intx



        Dim strWord As String
        Dim boo As Boolean
        Dim strResult As String
        strWord = txtWord.Text.Trim.ToUpper



        strResult = lblWord.Text
        For intIndex As Integer = 0 To strWord.Length - 1
            If strWord(intIndex) = " " Then
                strResult = strResult.Remove(intIndex, 1)
                strResult = strResult.Insert(intIndex, " ")
            End If
        Next intIndex
    End Sub


    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectToolStripMenuItem.Click
        Dim file1 As OpenFileDialog = New OpenFileDialog()



        file1.Title = "Open File Dialog"
        file1.InitialDirectory = "C:\"
        file1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        file1.FilterIndex = 1
        file1.RestoreDirectory = True

        If file1.ShowDialog() = DialogResult.OK Then
            strFile1Name = file1.FileName
            'outFile = IO.File.CreateText(strFile1Name)

        End If
    End Sub

    Private Async Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        btnQ.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "Q"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnQ.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnQ.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If



    End Sub

    Private Async Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        btnW.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "W"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnW.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnW.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If


    End Sub

    Private Async Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        btnE.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "E"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnE.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnE.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If



    End Sub

    Private Async Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        btnR.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "R"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnR.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnR.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If



    End Sub

    Private Async Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        btnT.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "T"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnT.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnT.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        btnY.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "Y"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnY.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnY.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        btnU.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "U"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnU.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnU.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        btnI.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "I"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnI.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnI.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        btnO.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "O"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnO.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnO.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        btnP.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "P"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnP.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnP.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        btnA.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "A"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnA.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnA.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        btnS.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "S"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnS.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnS.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        btnD.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "D"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnD.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnD.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        btnF.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "F"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnF.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnF.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        btnG.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "G"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnG.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnG.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        btnH.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "H"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnH.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnH.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        btnJ.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "J"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnJ.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnJ.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        btnK.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "K"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnK.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnK.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        btnL.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "L"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnL.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnL.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        btnZ.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "Z"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnZ.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnZ.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        btnX.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "X"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnX.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnX.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        btnC.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "C"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnC.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnC.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        btnV.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "V"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnV.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnV.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        btnB.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "B"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnB.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnB.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        btnN.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "N"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnN.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()
        Else
            btnN.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If

    End Sub

    Private Async Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        btnM.Enabled = False
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "M"
        boo = GuessLetter(strLetter)
        If boo = True Then

            btnM.BackColor = Color.Green
            Await Task.Delay(800)
            SpinAgain.Show()
            Me.Hide()

        Else
            btnM.BackColor = Color.Red
            Await Task.Delay(800)
            frmSpin.Show()
            Me.Hide()
        End If






    End Sub

    'Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
    '    frmSpin.Show()
    ''    Me.Hide()

    'End Sub
End Class