<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DemoDGV
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MTextBox1 = New MControls.MTextBox()
        Me.MComboBox2 = New MControls.MComboBox()
        Me.MComboBox1 = New MControls.MComboBox()
        Me.MDataGridView1 = New MControls.MDataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MComboBox3 = New MControls.MComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 40
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(337, 312)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "First Name"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Last Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Location"
        Me.Column3.Name = "Column3"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridView2.Location = New System.Drawing.Point(402, 387)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(429, 150)
        Me.DataGridView2.TabIndex = 2
        '
        'Column7
        '
        Me.Column7.HeaderText = "Column7"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Column8"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Column9"
        Me.Column9.Name = "Column9"
        '
        'MTextBox1
        '
        Me.MTextBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.MTextBox1.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MTextBox1.Location = New System.Drawing.Point(29, 485)
        Me.MTextBox1.MinimumSize = New System.Drawing.Size(4, 23)
        Me.MTextBox1.Name = "MTextBox1"
        Me.MTextBox1.NumberMode = False
        Me.MTextBox1.PlaceHolderText = "hello"
        Me.MTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MTextBox1.TabIndex = 5
        '
        'MComboBox2
        '
        Me.MComboBox2.ArrowColor = System.Drawing.Color.CornflowerBlue
        Me.MComboBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.MComboBox2.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MComboBox2.FormattingEnabled = True
        Me.MComboBox2.Items.AddRange(New Object() {"Manoj", "Babu", "Sumej", "Ragunath"})
        Me.MComboBox2.Location = New System.Drawing.Point(39, 425)
        Me.MComboBox2.Name = "MComboBox2"
        Me.MComboBox2.Size = New System.Drawing.Size(244, 21)
        Me.MComboBox2.TabIndex = 4
        '
        'MComboBox1
        '
        Me.MComboBox1.ArrowColor = System.Drawing.Color.CornflowerBlue
        Me.MComboBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.MComboBox1.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MComboBox1.FormattingEnabled = True
        Me.MComboBox1.Items.AddRange(New Object() {"Manoj", "Babu", "Sumej", "Ragunath"})
        Me.MComboBox1.Location = New System.Drawing.Point(39, 378)
        Me.MComboBox1.Name = "MComboBox1"
        Me.MComboBox1.Size = New System.Drawing.Size(244, 21)
        Me.MComboBox1.TabIndex = 3
        '
        'MDataGridView1
        '
        Me.MDataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.MDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.MDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6})
        Me.MDataGridView1.Location = New System.Drawing.Point(402, 12)
        Me.MDataGridView1.ModernTheme = MControls.MDataGridView.Theme.Windows
        Me.MDataGridView1.Name = "MDataGridView1"
        Me.MDataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.MDataGridView1.Size = New System.Drawing.Size(429, 312)
        Me.MDataGridView1.TabIndex = 1
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 143
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 143
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 143
        '
        'MComboBox3
        '
        Me.MComboBox3.ArrowColor = System.Drawing.Color.CornflowerBlue
        Me.MComboBox3.BackColor = System.Drawing.Color.Gray
        Me.MComboBox3.BorderColor = System.Drawing.Color.Gainsboro
        Me.MComboBox3.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.MComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MComboBox3.FormattingEnabled = True
        Me.MComboBox3.Location = New System.Drawing.Point(903, 156)
        Me.MComboBox3.Name = "MComboBox3"
        Me.MComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.MComboBox3.TabIndex = 6
        '
        'DemoDGV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 599)
        Me.Controls.Add(Me.MComboBox3)
        Me.Controls.Add(Me.MTextBox1)
        Me.Controls.Add(Me.MComboBox2)
        Me.Controls.Add(Me.MComboBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.MDataGridView1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DemoDGV"
        Me.Text = "DemoDGV"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents MDataGridView1 As MControls.MDataGridView
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents MComboBox1 As MControls.MComboBox
    Friend WithEvents MComboBox2 As MControls.MComboBox
    Friend WithEvents MTextBox1 As MControls.MTextBox
    Friend WithEvents MComboBox3 As MControls.MComboBox
End Class
