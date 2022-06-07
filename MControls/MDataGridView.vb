Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows
Imports System.Windows.Forms
Imports SystemColors = System.Drawing.SystemColors

Public Class MDataGridView
    Inherits DataGridView

    Public Enum Theme
        Dark
        Light
        Windows
    End Enum

    Private _modernTheme As Theme = Theme.Windows

    Public Property ModernTheme As Theme
        Get
            Return _modernTheme
        End Get
        Set(value As Theme)
            _modernTheme = value
            SetTheme()
        End Set
    End Property

    Private Sub SetTheme()
        Select Case ModernTheme
            Case Theme.Dark
                DarkTheme()
            Case Theme.Light
                LightTheme()
            Case Theme.Windows
                WindowsTheme()
        End Select
    End Sub

    Private Sub WindowsTheme()
        Me.AllowUserToResizeRows = True

        Me.AlternatingRowsDefaultCellStyle = Nothing

        Me.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        Me.BackgroundColor = SystemColors.Control
        Me.BorderStyle = BorderStyle.FixedSingle
        Me.CellBorderStyle = DataGridViewCellBorderStyle.Single
        Me.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        Me.ColumnHeadersDefaultCellStyle = Nothing

        Me.ColumnHeadersHeight = 21
        Me.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DefaultCellStyle = Nothing

        Me.EnableHeadersVisualStyles = True
        Me.RowHeadersVisible = True
        Me.RowHeadersWidth = 41
        Me.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
        Me.RowTemplate.Height = 22
        Me.RowTemplate.Resizable = DataGridViewTriState.[False]
        Me.SelectionMode = DataGridViewSelectionMode.CellSelect
        Me.Refresh()
    End Sub

    Private Sub DarkTheme()
        Me.AllowUserToResizeRows = False

        Me.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(33, 37, 41)
        Me.AlternatingRowsDefaultCellStyle.ForeColor = Color.White
        Me.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(114, 116, 118)
        Me.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White

        Me.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.BackgroundColor = Color.FromArgb(43, 47, 52)
        Me.BorderStyle = BorderStyle.None
        Me.CellBorderStyle = DataGridViewCellBorderStyle.None
        Me.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Me.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 15, 17)
        Me.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 15, 17)
        Me.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        Me.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.[True]

        Me.ColumnHeadersHeight = 40
        Me.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DefaultCellStyle.BackColor = Color.FromArgb(43, 47, 52)
        Me.DefaultCellStyle.Font = New Font("Segoe UI", 10.0!)
        Me.DefaultCellStyle.ForeColor = Color.White
        Me.DefaultCellStyle.SelectionBackColor = Color.FromArgb(114, 116, 118)
        Me.DefaultCellStyle.SelectionForeColor = Color.White
        Me.DefaultCellStyle.WrapMode = DataGridViewTriState.[False]

        Me.EnableHeadersVisualStyles = False
        Me.RowHeadersVisible = False
        Me.RowHeadersWidth = 40
        Me.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.RowTemplate.Height = 40
        Me.RowTemplate.Resizable = DataGridViewTriState.[False]
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.Refresh()
    End Sub

    Private Sub LightTheme()
        Me.AllowUserToResizeRows = False

        Me.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(210, 232, 254)
        Me.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        Me.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        Me.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black

        Me.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.BackgroundColor = Color.FromArgb(248, 251, 254)
        Me.BorderStyle = BorderStyle.None
        Me.CellBorderStyle = DataGridViewCellBorderStyle.None
        Me.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Me.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 254)
        Me.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 254)
        Me.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        Me.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.[True]

        Me.ColumnHeadersHeight = 40
        Me.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DefaultCellStyle.BackColor = Color.FromArgb(248, 251, 254)
        Me.DefaultCellStyle.Font = New Font("Segoe UI", 10.0!)
        Me.DefaultCellStyle.ForeColor = Color.Black
        Me.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        Me.DefaultCellStyle.SelectionForeColor = Color.Black
        Me.DefaultCellStyle.WrapMode = DataGridViewTriState.[False]

        Me.EnableHeadersVisualStyles = False
        Me.RowHeadersVisible = False
        Me.RowHeadersWidth = 40
        Me.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.RowTemplate.Height = 40
        Me.RowTemplate.Resizable = DataGridViewTriState.[False]
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.Refresh()
    End Sub
End Class
