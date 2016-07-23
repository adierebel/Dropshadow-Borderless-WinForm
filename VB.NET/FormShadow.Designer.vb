<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormShadow
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
        Me.PanelMove = New System.Windows.Forms.PictureBox
        Me.PanelExit = New System.Windows.Forms.PictureBox
        Me.LabelExit = New System.Windows.Forms.Label
        CType(Me.PanelMove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMove
        '
        Me.PanelMove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelMove.Location = New System.Drawing.Point(0, 0)
        Me.PanelMove.Name = "PanelMove"
        Me.PanelMove.Size = New System.Drawing.Size(300, 25)
        Me.PanelMove.TabIndex = 0
        Me.PanelMove.TabStop = False
        '
        'PanelExit
        '
        Me.PanelExit.BackColor = System.Drawing.Color.Red
        Me.PanelExit.Location = New System.Drawing.Point(270, 0)
        Me.PanelExit.Name = "PanelExit"
        Me.PanelExit.Size = New System.Drawing.Size(30, 25)
        Me.PanelExit.TabIndex = 1
        Me.PanelExit.TabStop = False
        '
        'LabelExit
        '
        Me.LabelExit.AutoSize = True
        Me.LabelExit.BackColor = System.Drawing.Color.Red
        Me.LabelExit.ForeColor = System.Drawing.Color.White
        Me.LabelExit.Location = New System.Drawing.Point(278, 6)
        Me.LabelExit.Name = "LabelExit"
        Me.LabelExit.Size = New System.Drawing.Size(14, 13)
        Me.LabelExit.TabIndex = 2
        Me.LabelExit.Text = "X"
        '
        'FormShadow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 250)
        Me.Controls.Add(Me.LabelExit)
        Me.Controls.Add(Me.PanelExit)
        Me.Controls.Add(Me.PanelMove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormShadow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borderless Form Dropshadow"
        CType(Me.PanelMove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelMove As System.Windows.Forms.PictureBox
    Friend WithEvents PanelExit As System.Windows.Forms.PictureBox
    Friend WithEvents LabelExit As System.Windows.Forms.Label

End Class
