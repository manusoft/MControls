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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MTextBox1 = New MControls.MTextBox()
        Me.MLookupList1 = New MControls.MLookupList()
        Me.MLookupBox2 = New MControls.MLookupBox()
        Me.PopupForm1 = New MControls.MPopupForm()
        Me.MPopupMsg1 = New MControls.MPopupMsg()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 191)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(387, 261)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MTextBox1
        '
        Me.MTextBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.MTextBox1.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MTextBox1.Location = New System.Drawing.Point(169, 321)
        Me.MTextBox1.MinimumSize = New System.Drawing.Size(4, 23)
        Me.MTextBox1.Name = "MTextBox1"
        Me.MTextBox1.NumberMode = False
        Me.MTextBox1.PlaceHolderText = ""
        Me.MTextBox1.Size = New System.Drawing.Size(235, 23)
        Me.MTextBox1.TabIndex = 6
        '
        'MLookupList1
        '
        Me.MLookupList1.BackColor = System.Drawing.Color.White
        Me.MLookupList1.BorderColor = System.Drawing.Color.Gray
        Me.MLookupList1.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MLookupList1.DataSource = Nothing
        Me.MLookupList1.IsFocused = False
        Me.MLookupList1.Location = New System.Drawing.Point(366, 162)
        Me.MLookupList1.MinimumSize = New System.Drawing.Size(0, 25)
        Me.MLookupList1.Name = "MLookupList1"
        Me.MLookupList1.Padding = New System.Windows.Forms.Padding(2)
        Me.MLookupList1.PlaceholderText = ""
        Me.MLookupList1.Size = New System.Drawing.Size(323, 25)
        Me.MLookupList1.TabIndex = 5
        '
        'MLookupBox2
        '
        Me.MLookupBox2.AutoCompleteCustomSource.AddRange(New String() {"manoj", "babu", "vengara"})
        Me.MLookupBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MLookupBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.MLookupBox2.BackColor = System.Drawing.Color.White
        Me.MLookupBox2.BorderColor = System.Drawing.Color.Gray
        Me.MLookupBox2.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MLookupBox2.IsFocused = False
        Me.MLookupBox2.Location = New System.Drawing.Point(12, 234)
        Me.MLookupBox2.MinimumSize = New System.Drawing.Size(0, 25)
        Me.MLookupBox2.Name = "MLookupBox2"
        Me.MLookupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.MLookupBox2.PlaceholderText = ""
        Me.MLookupBox2.Size = New System.Drawing.Size(250, 25)
        Me.MLookupBox2.TabIndex = 4
        '
        'PopupForm1
        '
        Me.PopupForm1.AutoClose = False
        Me.PopupForm1.Backcolor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.PopupForm1.DropShadowEnabled = False
        Me.PopupForm1.Font = Nothing
        Me.PopupForm1.ForeColor = System.Drawing.Color.Silver
        Me.PopupForm1.Height = 500
        Me.PopupForm1.HostForm = Nothing
        Me.PopupForm1.ShowTitle = False
        Me.PopupForm1.TitleBackcolor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.PopupForm1.TitleText = "Title"
        Me.PopupForm1.Width = 400
        '
        'MPopupMsg1
        '
        Me.MPopupMsg1.Backcolor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.MPopupMsg1.Font = Nothing
        Me.MPopupMsg1.ForeColor = System.Drawing.Color.White
        Me.MPopupMsg1.Height = 150
        Me.MPopupMsg1.Style = MControls.MPopupMsg.Styles.Primary
        Me.MPopupMsg1.StyleCustomColor = System.Drawing.Color.Empty
        Me.MPopupMsg1.Width = 300
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(557, 272)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(884, 508)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.MTextBox1)
        Me.Controls.Add(Me.MLookupList1)
        Me.Controls.Add(Me.MLookupBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MSearchBox1 As MControls.MSearchBox
    Friend WithEvents MLookupBox1 As MControls.MLookupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PopupForm1 As MControls.MPopupForm
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MPopupMsg1 As MControls.MPopupMsg
    Friend WithEvents MLookupBox2 As MControls.MLookupBox
    Friend WithEvents MLookupList1 As MControls.MLookupList
    Friend WithEvents MTextBox1 As MControls.MTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
