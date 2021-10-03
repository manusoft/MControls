Imports System.Drawing
Imports System.Windows.Forms

Public Class MenuColorTable
    Inherits ProfessionalColorTable

    Private backColor As Color
    Private leftColumnColor As Color
    Private borderColor As Color
    Private menuItemBorderColor As Color
    Private menuItemSelectedColor As Color

    Public Sub New(ByVal isMainMenu As Boolean, ByVal primaryColor As Color)
        If isMainMenu Then
            backColor = Color.FromArgb(37, 39, 60)
            leftColumnColor = Color.FromArgb(32, 33, 51)
            borderColor = Color.FromArgb(32, 33, 51)
            menuItemBorderColor = primaryColor
            menuItemSelectedColor = primaryColor
        Else
            backColor = Color.White
            leftColumnColor = Color.LightGray
            borderColor = Color.LightGray
            menuItemBorderColor = primaryColor
            menuItemSelectedColor = primaryColor
        End If
    End Sub

    Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
        Get
            Return backColor
        End Get
    End Property

    Public Overrides ReadOnly Property MenuBorder As Color
        Get
            Return borderColor
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder As Color
        Get
            Return menuItemBorderColor
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelected As Color
        Get
            Return menuItemSelectedColor
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
        Get
            Return leftColumnColor
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
        Get
            Return leftColumnColor
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
        Get
            Return leftColumnColor
        End Get
    End Property

End Class
