'Name:        Chapter 6/7 Capstone Project
'Purpose:     ???
'Programmer:  Keteyian & Sophia on 04.26.2023


Option Infer Off
Option Strict On
Option Explicit On



Public Class frmGuess
    Private strFile1Name As String

    Function GuessLetter(ByVal strLetter As String) As Boolean
        btnQ.Enabled = False
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


        Else
            MessageBox.Show("Try again!", "Guess the Word Game",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            boo = False
        End If
        'txtLetter.Text = String.Empty

        If strResult.Contains("-") = False Then
            MessageBox.Show("You guessed it: " & strWord, "Guess the
Word game", MessageBoxButtons.OK,
            MessageBoxIcon.Information)


            txtWord.Focus()
        End If

        Return boo
    End Function
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        btnGenerate.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


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
        random = randNum.Next(1, index)

        Do Until currentline = random
            txtWord.Text = sr2.ReadLine
            currentline += 1
        Loop

        Dim intLength As Integer
        intLength = txtWord.Text.Length

        For intx As Integer = 1 To intLength
            lblWord.Text += "_ "
        Next intx
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

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        Dim strLetter As String
        Dim boo As Boolean
        strLetter = "Q"
        boo = GuessLetter(strLetter)
        If boo = True Then


        Else

        End If

    End Sub
End Class