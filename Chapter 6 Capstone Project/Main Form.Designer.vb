<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.picWheel = New System.Windows.Forms.PictureBox()
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(705, 267)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(75, 23)
        Me.btnSpin.TabIndex = 0
        Me.btnSpin.Text = "&Spin!"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'picWheel
        '
        Me.picWheel.Image = Global.Chapter_6_Capstone_Project.My.Resources.Resources.j00
        Me.picWheel.Location = New System.Drawing.Point(31, 25)
        Me.picWheel.Margin = New System.Windows.Forms.Padding(2)
        Me.picWheel.Name = "picWheel"
        Me.picWheel.Size = New System.Drawing.Size(644, 512)
        Me.picWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWheel.TabIndex = 1
        Me.picWheel.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSpin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(817, 609)
        Me.Controls.Add(Me.picWheel)
        Me.Controls.Add(Me.btnSpin)
        Me.Name = "frmMain"
        Me.Text = "???"
        CType(Me.picWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSpin As Button
    Friend WithEvents picWheel As PictureBox
End Class
