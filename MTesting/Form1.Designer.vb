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
        Me.MLookupBox1 = New MControls.MLookupBox()
        Me.MSearchBox1 = New MControls.MSearchBox()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8_bell_26px_1.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8_camel_26px.png")
        '
        'MLookupBox1
        '
        Me.MLookupBox1.BackColor = System.Drawing.Color.White
        Me.MLookupBox1.BorderColor = System.Drawing.Color.Gray
        Me.MLookupBox1.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MLookupBox1.IsFocused = False
        Me.MLookupBox1.Location = New System.Drawing.Point(256, 216)
        Me.MLookupBox1.MinimumSize = New System.Drawing.Size(0, 25)
        Me.MLookupBox1.Name = "MLookupBox1"
        Me.MLookupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.MLookupBox1.PlaceholderText = ""
        Me.MLookupBox1.Size = New System.Drawing.Size(250, 25)
        Me.MLookupBox1.TabIndex = 1
        '
        'MSearchBox1
        '
        Me.MSearchBox1.BackColor = System.Drawing.Color.White
        Me.MSearchBox1.BorderColor = System.Drawing.Color.Gray
        Me.MSearchBox1.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MSearchBox1.IsFocused = False
        Me.MSearchBox1.Location = New System.Drawing.Point(256, 148)
        Me.MSearchBox1.MinimumSize = New System.Drawing.Size(0, 25)
        Me.MSearchBox1.Name = "MSearchBox1"
        Me.MSearchBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.MSearchBox1.PlaceholderText = ""
        Me.MSearchBox1.Size = New System.Drawing.Size(250, 25)
        Me.MSearchBox1.TabIndex = 0
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(933, 508)
        Me.Controls.Add(Me.MLookupBox1)
        Me.Controls.Add(Me.MSearchBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents MSearchBox1 As MControls.MSearchBox
    Friend WithEvents MLookupBox1 As MControls.MLookupBox
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
End Class
