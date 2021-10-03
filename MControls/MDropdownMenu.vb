Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<ToolboxBitmap(GetType(ContextMenuStrip))>
<Description("Displays a shortcut menu when the user right-click the assosiated control.")>
Public Class MDropdownMenu
    Inherits ContextMenuStrip

    Private _isMainMenu As Boolean
    Private _menuItemHeight As Integer = 25
    Private _menuItemTextColor As Color = Color.Empty
    Private _primaryColor As Color = Color.Empty

    Private menuItemHeaderSize As Bitmap

    Public Sub New(ByVal container As IContainer)
        MyBase.New(container)
    End Sub

    <Browsable(False)>
    Public Property IsMainMenu As Boolean
        Get
            Return _isMainMenu
        End Get
        Set(ByVal value As Boolean)
            _isMainMenu = value
        End Set
    End Property

    <Browsable(False)>
    Public Property MenuItemHeight As Integer
        Get
            Return _menuItemHeight
        End Get
        Set(ByVal value As Integer)
            _menuItemHeight = value
        End Set
    End Property

    <Browsable(False)>
    Public Property MenuItemTextColor As Color
        Get
            Return _menuItemTextColor
        End Get
        Set(ByVal value As Color)
            _menuItemTextColor = value
        End Set
    End Property

    <Browsable(False)>
    Public Property PrimaryColor As Color
        Get
            Return _primaryColor
        End Get
        Set(ByVal value As Color)
            _primaryColor = value
        End Set
    End Property

    Private Sub LoadMenuItemHeight()
        If isMainMenu Then
            menuItemHeaderSize = New Bitmap(25, 45)
        Else
            menuItemHeaderSize = New Bitmap(20, menuItemHeight)
        End If

        For Each menuItemL1 As ToolStripMenuItem In Me.Items
            menuItemL1.ImageScaling = ToolStripItemImageScaling.None
            If menuItemL1.Image Is Nothing Then menuItemL1.Image = menuItemHeaderSize

            For Each menuItemL2 As ToolStripMenuItem In menuItemL1.DropDownItems
                menuItemL2.ImageScaling = ToolStripItemImageScaling.None
                If menuItemL2.Image Is Nothing Then menuItemL2.Image = menuItemHeaderSize

                For Each menuItemL3 As ToolStripMenuItem In menuItemL2.DropDownItems
                    menuItemL3.ImageScaling = ToolStripItemImageScaling.None
                    If menuItemL3.Image Is Nothing Then menuItemL3.Image = menuItemHeaderSize

                    For Each menuItemL4 As ToolStripMenuItem In menuItemL3.DropDownItems
                        menuItemL4.ImageScaling = ToolStripItemImageScaling.None
                        If menuItemL4.Image Is Nothing Then menuItemL4.Image = menuItemHeaderSize
                    Next
                Next
            Next
        Next
    End Sub

    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)

        If Me.DesignMode = False Then
            Me.Renderer = New MenuRenderer(isMainMenu, primaryColor, menuItemTextColor)
            LoadMenuItemHeight()
        End If
    End Sub
End Class
