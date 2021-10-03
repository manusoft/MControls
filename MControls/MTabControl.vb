Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<ToolboxBitmap(GetType(TabControl))>
<Description("Manages and displays to the user a related collection of tabs that can contain controls and components.")>
Public Class MTabControl
    Inherits TabControl

    Public Enum Style
        Flat
        Line
    End Enum

    Private _TabStyle As Style
    Private _ButtonBackColor As Color = Color.WhiteSmoke
    Private _ButtonForeColor As Color = Color.Black
    Private _ButtonSelectedForeColor As Color = Color.CornflowerBlue
    Private _LineBackColor As Color = Color.Gainsboro
    Private _LineForeColor As Color = Color.LightSeaGreen
    Private _HideButton As Boolean = False
    Private _BackgroundColor As Color = Color.FromKnownColor(KnownColor.Control)

    Public Sub New()

        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.UserPaint, True)

        SizeMode = TabSizeMode.Fixed
        ItemSize = New Size(130, 30)
        TabStyle = Style.Line
    End Sub

    <Category("MControls")>
    Public Property TabStyle As Style
        Get
            Return _TabStyle
        End Get
        Set(value As Style)
            _TabStyle = value
            Invalidate()
        End Set
    End Property

    <Category("MControls")>
    Public Property ButtonBackColor As Color
        Get
            Return _ButtonBackColor
        End Get
        Set(value As Color)
            _ButtonBackColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControls")>
    Public Property ButtonForeColor As Color
        Get
            Return _ButtonForeColor
        End Get
        Set(value As Color)
            _ButtonForeColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControls")>
    Public Property LineBackColor As Color
        Get
            Return _LineBackColor
        End Get
        Set(value As Color)
            _LineBackColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControls")>
    Public Property LineForeColor As Color
        Get
            Return _LineForeColor
        End Get
        Set(value As Color)
            _LineForeColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property HideButton As Boolean
        Get
            Return _HideButton
        End Get
        Set(value As Boolean)
            If value Then
                MyBase.ItemSize = New Size(0, 1)
            Else
                MyBase.ItemSize = New Size(130, 30)
            End If
            _HideButton = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property BackgroundColor As Color
        Get
            Return _BackgroundColor
        End Get
        Set(value As Color)
            _BackgroundColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property ButtonSelectedForeColor As Color
        Get
            Return _ButtonSelectedForeColor
        End Get
        Set(value As Color)
            _ButtonSelectedForeColor = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        If Alignment = TabAlignment.Left Or Alignment = TabAlignment.Right Then
            Alignment = TabAlignment.Top
        End If
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If HideButton Then
            e.Graphics.Clear(BackgroundColor)
            Exit Sub
        End If

        Using bitmap As New Bitmap(Width, Height)
            Using g As Graphics = Graphics.FromImage(bitmap)

                g.Clear(BackgroundColor)
                g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

                For I As Integer = 0 To TabCount - 1

                    Dim tabRect As Rectangle = GetTabRect(I)

                    If I = SelectedIndex Then
                        Select Case TabStyle
                            Case Style.Flat
                                g.FillRectangle(New SolidBrush(ButtonBackColor), tabRect)  'Header Button Back Color
                                Exit Select
                            Case Style.Line
                                g.DrawLine(New Pen(LineBackColor, 3), 0, tabRect.Bottom, Me.Width, tabRect.Bottom)
                                g.FillRectangle(New SolidBrush(LineForeColor), New Rectangle(tabRect.Left, tabRect.Bottom - 1, ItemSize.Width, 3))
                                Exit Select
                        End Select

                        If ImageList IsNot Nothing Then
                            Try
                                If ImageList.Images(TabPages(I).ImageIndex) IsNot Nothing Then
                                    g.DrawImage(ImageList.Images(TabPages(I).ImageIndex), New Point(tabRect.Location.X + 8, tabRect.Location.Y + 6))
                                    g.DrawString("     " & TabPages(I).Text, Font, New SolidBrush(ButtonSelectedForeColor), tabRect, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                                Else
                                    g.DrawString(TabPages(I).Text, Font, New SolidBrush(ButtonSelectedForeColor), tabRect, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                                End If
                            Catch ex As Exception
                                g.DrawString(TabPages(I).Text, Font, New SolidBrush(ButtonSelectedForeColor), tabRect, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                            End Try
                        Else
                            g.DrawString(TabPages(I).Text, Font, New SolidBrush(ButtonSelectedForeColor), tabRect, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                        End If

                    Else
                        If ImageList IsNot Nothing Then
                            Try
                                If ImageList.Images(TabPages(I).ImageIndex) IsNot Nothing Then
                                    g.DrawImage(ImageList.Images(TabPages(I).ImageIndex), New Point(tabRect.Location.X + 8, tabRect.Location.Y + 6))
                                    g.DrawString("     " & TabPages(I).Text, Me.Font, New SolidBrush(ButtonForeColor), tabRect, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                                Else
                                    g.DrawString(TabPages(I).Text, Font, New SolidBrush(ButtonForeColor), tabRect, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                                End If
                            Catch ex As Exception
                                g.DrawString(TabPages(I).Text, Font, New SolidBrush(ButtonForeColor), tabRect, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                            End Try
                        Else
                            g.DrawString(TabPages(I).Text, Font, New SolidBrush(ButtonForeColor), tabRect, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                        End If
                    End If

                Next
                MyBase.OnPaint(e)
                e.Graphics.DrawImage(bitmap.Clone, 0, 0)
                g.Dispose()
            End Using
        End Using
    End Sub

    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
        'Nothing
    End Sub
End Class
