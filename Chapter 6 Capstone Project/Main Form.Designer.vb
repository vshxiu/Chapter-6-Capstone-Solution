﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(277, 202)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(75, 23)
        Me.btnSpin.TabIndex = 0
        Me.btnSpin.Text = "&Spin!"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 258)
        Me.Controls.Add(Me.btnSpin)
        Me.Name = "frmMain"
        Me.Text = "???"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSpin As Button
End Class
