<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MErrorLabel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.lblError = New System.Windows.Forms.Label()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblError
        '
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblError.ForeColor = System.Drawing.Color.White
        Me.lblError.Location = New System.Drawing.Point(5, 5)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(252, 25)
        Me.lblError.TabIndex = 0
        Me.lblError.Text = "Message"
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        '
        'MErrorLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.lblError)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 35)
        Me.Name = "MErrorLabel"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(262, 35)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblError As Windows.Forms.Label
    Friend WithEvents tmrTimer As Windows.Forms.Timer
End Class
