<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmName
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
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.btnReady = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOne
        '
        Me.txtOne.Location = New System.Drawing.Point(49, 48)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(137, 20)
        Me.txtOne.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Player 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pl&ayer 2:"
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(294, 48)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(137, 20)
        Me.txtTwo.TabIndex = 3
        '
        'btnReady
        '
        Me.btnReady.Location = New System.Drawing.Point(203, 111)
        Me.btnReady.Name = "btnReady"
        Me.btnReady.Size = New System.Drawing.Size(75, 23)
        Me.btnReady.TabIndex = 4
        Me.btnReady.Text = "&Ready!"
        Me.btnReady.UseVisualStyleBackColor = True
        '
        'frmName
        '
        Me.AcceptButton = Me.btnReady
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 159)
        Me.Controls.Add(Me.btnReady)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOne)
        Me.Name = "frmName"
        Me.Text = "Wheel of Fortune"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOne As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTwo As TextBox
    Friend WithEvents btnReady As Button
End Class
