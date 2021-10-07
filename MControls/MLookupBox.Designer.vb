<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MLookupBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MLookupBox))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(3, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(224, 16)
        Me.txtSearch.TabIndex = 9
        '
        'btnMore
        '
        Me.btnMore.BackColor = System.Drawing.Color.White
        Me.btnMore.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMore.FlatAppearance.BorderSize = 0
        Me.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMore.Image = CType(resources.GetObject("btnMore.Image"), System.Drawing.Image)
        Me.btnMore.Location = New System.Drawing.Point(231, 2)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(17, 19)
        Me.btnMore.TabIndex = 8
        Me.btnMore.UseVisualStyleBackColor = False
        '
        'MLookupBox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnMore)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MLookupBox"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(250, 23)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As Windows.Forms.TextBox
    Friend WithEvents btnMore As Windows.Forms.Button
End Class
