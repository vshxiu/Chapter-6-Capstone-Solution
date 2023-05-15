<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(22, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 56)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "You've guessed correctly! Would you like to:"
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(130, 80)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(75, 23)
        Me.btnSolve.TabIndex = 4
        Me.btnSolve.Text = "&Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(25, 80)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(75, 23)
        Me.btnSpin.TabIndex = 3
        Me.btnSpin.Text = "Spin &Again"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(74, 54)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(100, 20)
        Me.txtWord.TabIndex = 6
        Me.txtWord.Visible = False
        '
        'frmPop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 124)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.btnSpin)
        Me.Name = "frmPop"
        Me.Text = "Pop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSolve As Button
    Friend WithEvents btnSpin As Button
    Friend WithEvents txtWord As TextBox
End Class
