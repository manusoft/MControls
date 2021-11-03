<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDatePicker2
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnDropdown = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblText.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblText.Location = New System.Drawing.Point(2, 2)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(204, 21)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "2021/10/25"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDropdown
        '
        Me.btnDropdown.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDropdown.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDropdown.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDropdown.FlatAppearance.BorderSize = 0
        Me.btnDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDropdown.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnDropdown.Image = Global.MControls.My.Resources.Resources.black_calendar
        Me.btnDropdown.Location = New System.Drawing.Point(206, 2)
        Me.btnDropdown.Name = "btnDropdown"
        Me.btnDropdown.Size = New System.Drawing.Size(21, 21)
        Me.btnDropdown.TabIndex = 1
        Me.btnDropdown.UseVisualStyleBackColor = False
        '
        'MDTP
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnDropdown)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.MinimumSize = New System.Drawing.Size(229, 25)
        Me.Name = "MDTP"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(229, 25)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblText As Windows.Forms.Label
    Friend WithEvents btnDropdown As Windows.Forms.Button
End Class
