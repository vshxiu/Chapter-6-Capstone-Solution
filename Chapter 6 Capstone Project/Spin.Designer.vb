<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSpin
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
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.picWheel = New System.Windows.Forms.PictureBox()
        Me.btnSpin = New System.Windows.Forms.Button()
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(770, 167)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(0, 13)
        Me.lblAmount.TabIndex = 5
        '
        'picWheel
        '
        Me.picWheel.Image = Global.Chapter_6_Capstone_Project.My.Resources.Resources.j00
        Me.picWheel.Location = New System.Drawing.Point(99, 37)
        Me.picWheel.Margin = New System.Windows.Forms.Padding(2)
        Me.picWheel.Name = "picWheel"
        Me.picWheel.Size = New System.Drawing.Size(644, 512)
        Me.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWheel.TabIndex = 4
        Me.picWheel.TabStop = False
        '
        'btnSpin
        '
        Me.btnSpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSpin.Location = New System.Drawing.Point(325, 579)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(188, 45)
        Me.btnSpin.TabIndex = 3
        Me.btnSpin.Text = "&Spin!"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'frmSpin
        '
        Me.AcceptButton = Me.btnSpin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(844, 660)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.picWheel)
        Me.Controls.Add(Me.btnSpin)
        Me.Name = "frmSpin"
        Me.Text = "???"
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAmount As Label
    Friend WithEvents picWheel As PictureBox
    Friend WithEvents btnSpin As Button
End Class
