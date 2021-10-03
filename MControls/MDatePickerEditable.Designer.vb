<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDatePickerEditable
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
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnCalendar = New System.Windows.Forms.Button()
        Me.dtPicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDate.BackColor = System.Drawing.Color.White
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(3, 3)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(221, 16)
        Me.txtDate.TabIndex = 9
        '
        'btnCalendar
        '
        Me.btnCalendar.BackColor = System.Drawing.Color.White
        Me.btnCalendar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCalendar.FlatAppearance.BorderSize = 0
        Me.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalendar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalendar.Image = Global.MControls.My.Resources.Resources.calendar
        Me.btnCalendar.Location = New System.Drawing.Point(225, 2)
        Me.btnCalendar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCalendar.Name = "btnCalendar"
        Me.btnCalendar.Size = New System.Drawing.Size(23, 19)
        Me.btnCalendar.TabIndex = 8
        Me.btnCalendar.UseVisualStyleBackColor = False
        '
        'dtPicker
        '
        Me.dtPicker.Location = New System.Drawing.Point(0, 0)
        Me.dtPicker.Name = "dtPicker"
        Me.dtPicker.Size = New System.Drawing.Size(0, 25)
        Me.dtPicker.TabIndex = 10
        '
        'MDatePickerEditable
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dtPicker)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnCalendar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MDatePickerEditable"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(250, 23)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDate As Windows.Forms.TextBox
    Friend WithEvents btnCalendar As Windows.Forms.Button
    Friend WithEvents dtPicker As Windows.Forms.DateTimePicker
End Class
