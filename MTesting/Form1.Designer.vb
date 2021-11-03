<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MComboBox1 = New MControls.MComboBox()
        Me.MDatePicker21 = New MControls.MDatePicker2()
        Me.Mmc1 = New MControls.MMC()
        Me.MPopupMsg1 = New MControls.MPopupMsg()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(86, 73)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(494, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MComboBox1
        '
        Me.MComboBox1.ArrowColor = System.Drawing.Color.CornflowerBlue
        Me.MComboBox1.BackColor = System.Drawing.Color.Teal
        Me.MComboBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.MComboBox1.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MComboBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.MComboBox1.FormattingEnabled = True
        Me.MComboBox1.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.MComboBox1.Location = New System.Drawing.Point(484, 181)
        Me.MComboBox1.Name = "MComboBox1"
        Me.MComboBox1.Size = New System.Drawing.Size(239, 25)
        Me.MComboBox1.TabIndex = 6
        '
        'MDatePicker21
        '
        Me.MDatePicker21.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.MDatePicker21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MDatePicker21.CustomFormat = Nothing
        Me.MDatePicker21.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.MDatePicker21.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.MDatePicker21.Location = New System.Drawing.Point(494, 275)
        Me.MDatePicker21.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.MDatePicker21.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.MDatePicker21.MinimumSize = New System.Drawing.Size(229, 25)
        Me.MDatePicker21.Name = "MDatePicker21"
        Me.MDatePicker21.Padding = New System.Windows.Forms.Padding(2)
        Me.MDatePicker21.Size = New System.Drawing.Size(229, 25)
        Me.MDatePicker21.TabIndex = 5
        Me.MDatePicker21.Value = New Date(2021, 11, 1, 11, 42, 8, 148)
        '
        'Mmc1
        '
        Me.Mmc1.Location = New System.Drawing.Point(99, 292)
        Me.Mmc1.Name = "Mmc1"
        Me.Mmc1.TabIndex = 3
        '
        'MPopupMsg1
        '
        Me.MPopupMsg1.Backcolor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.MPopupMsg1.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.MPopupMsg1.ForeColor = System.Drawing.Color.White
        Me.MPopupMsg1.Style = MControls.MPopupMsg.Styles.Primary
        Me.MPopupMsg1.StyleCustomColor = System.Drawing.Color.Empty
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(933, 508)
        Me.Controls.Add(Me.MComboBox1)
        Me.Controls.Add(Me.MDatePicker21)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Mmc1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MSearchBox1 As MControls.MSearchBox
    Friend WithEvents MLookupBox1 As MControls.MLookupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Mmc1 As MControls.MMC
    Friend WithEvents Button1 As Button
    Friend WithEvents MDatePicker21 As MControls.MDatePicker2
    Friend WithEvents MComboBox1 As MControls.MComboBox
    Friend WithEvents MPopupMsg1 As MControls.MPopupMsg
End Class
