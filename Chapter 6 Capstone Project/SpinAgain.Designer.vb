<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpinAgain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSpinagain = New System.Windows.Forms.Button()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSpinagain
        '
        Me.btnSpinagain.Location = New System.Drawing.Point(51, 77)
        Me.btnSpinagain.Name = "btnSpinagain"
        Me.btnSpinagain.Size = New System.Drawing.Size(75, 23)
        Me.btnSpinagain.TabIndex = 0
        Me.btnSpinagain.Text = "Spin Again!!"
        Me.btnSpinagain.UseVisualStyleBackColor = True
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(254, 77)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(75, 23)
        Me.btnSolve.TabIndex = 1
        Me.btnSolve.Text = "Solve!!"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'SpinAgain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 203)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.btnSpinagain)
        Me.Name = "SpinAgain"
        Me.Text = "SpinAgain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSpinagain As Button
    Friend WithEvents btnSolve As Button
End Class
