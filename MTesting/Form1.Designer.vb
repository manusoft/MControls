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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MSearchBox1 = New MControls.MSearchBox()
        Me.MDatePickerEditable2 = New MControls.MDatePickerEditable()
        Me.MDatePickerEditable1 = New MControls.MDatePickerEditable()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8_bell_26px_1.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8_camel_26px.png")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(441, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MSearchBox1
        '
        Me.MSearchBox1.BackColor = System.Drawing.Color.White
        Me.MSearchBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.MSearchBox1.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MSearchBox1.ForeColor = System.Drawing.Color.Maroon
        Me.MSearchBox1.IsFocused = False
        Me.MSearchBox1.Location = New System.Drawing.Point(136, 278)
        Me.MSearchBox1.MinimumSize = New System.Drawing.Size(0, 23)
        Me.MSearchBox1.Name = "MSearchBox1"
        Me.MSearchBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.MSearchBox1.PlaceholderText = ""
        Me.MSearchBox1.Size = New System.Drawing.Size(250, 23)
        Me.MSearchBox1.TabIndex = 3
        '
        'MDatePickerEditable2
        '
        Me.MDatePickerEditable2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.MDatePickerEditable2.BorderColor = System.Drawing.Color.Gainsboro
        Me.MDatePickerEditable2.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MDatePickerEditable2.CustomFormat = "yyyy/MM/dd"
        Me.MDatePickerEditable2.DateFormat = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MDatePickerEditable2.DateValue = New Date(2021, 9, 21, 8, 47, 49, 987)
        Me.MDatePickerEditable2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.MDatePickerEditable2.IsFocused = False
        Me.MDatePickerEditable2.Location = New System.Drawing.Point(367, 201)
        Me.MDatePickerEditable2.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.MDatePickerEditable2.MinimumSize = New System.Drawing.Size(0, 23)
        Me.MDatePickerEditable2.Name = "MDatePickerEditable2"
        Me.MDatePickerEditable2.Padding = New System.Windows.Forms.Padding(2)
        Me.MDatePickerEditable2.PlaceholderText = "Year/Month/Day"
        Me.MDatePickerEditable2.Size = New System.Drawing.Size(200, 25)
        Me.MDatePickerEditable2.TabIndex = 1
        '
        'MDatePickerEditable1
        '
        Me.MDatePickerEditable1.BackColor = System.Drawing.Color.White
        Me.MDatePickerEditable1.BorderColor = System.Drawing.Color.Gainsboro
        Me.MDatePickerEditable1.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MDatePickerEditable1.CustomFormat = Nothing
        Me.MDatePickerEditable1.DateFormat = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MDatePickerEditable1.DateValue = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.MDatePickerEditable1.IsFocused = False
        Me.MDatePickerEditable1.Location = New System.Drawing.Point(367, 137)
        Me.MDatePickerEditable1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.MDatePickerEditable1.MinimumSize = New System.Drawing.Size(0, 23)
        Me.MDatePickerEditable1.Name = "MDatePickerEditable1"
        Me.MDatePickerEditable1.Padding = New System.Windows.Forms.Padding(2)
        Me.MDatePickerEditable1.PlaceholderText = "Year/Month/Day"
        Me.MDatePickerEditable1.Size = New System.Drawing.Size(200, 23)
        Me.MDatePickerEditable1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(933, 508)
        Me.Controls.Add(Me.MSearchBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MDatePickerEditable2)
        Me.Controls.Add(Me.MDatePickerEditable1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents MDatePickerEditable1 As MControls.MDatePickerEditable
    Friend WithEvents MDatePickerEditable2 As MControls.MDatePickerEditable
    Friend WithEvents Button1 As Button
    Friend WithEvents MSearchBox1 As MControls.MSearchBox
End Class
