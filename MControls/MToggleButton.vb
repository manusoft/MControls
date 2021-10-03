Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<ToolboxBitmap(GetType(CheckBox))>
<Description("Enables the user to select or clear the associated option.")>
Public Class MToggleButton
    Inherits CheckBox

    'Fields
    Private _onBackColor As Color = Color.MediumSlateBlue
    Private _onToggleColor As Color = Color.WhiteSmoke
    Private _offBackColor As Color = Color.Gray
    Private _offToggleColor As Color = Color.Gainsboro
    Private _solidStyle As Boolean = True

    'Properties
    <Category("MControl")>
    Public Property OnBackColor As Color
        Get
            Return _onBackColor
        End Get
        Set(value As Color)
            _onBackColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property OnToggleColor As Color
        Get
            Return _onToggleColor
        End Get
        Set(value As Color)
            _onToggleColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property OffBackColor As Color
        Get
            Return _offBackColor
        End Get
        Set(value As Color)
            _offBackColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property OffToggleColor As Color
        Get
            Return _offToggleColor
        End Get
        Set(value As Color)
            _offToggleColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    <DefaultValue(True)>
    Public Property SolidStyle As Boolean
        Get
            Return _solidStyle
        End Get
        Set(value As Boolean)
            _solidStyle = value
            Invalidate()
        End Set
    End Property

    'Contructor
    Public Sub New()

        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.UserPaint, True)

        MyBase.MaximumSize = New Size(45, 22)
    End Sub

    'Methods
    Private Function GetFigurPath()
        Dim arcSize As Integer = MyBase.Height - 1
        Dim leftArc As Rectangle = New Rectangle(0, 0, arcSize, arcSize)
        Dim rightArc As Rectangle = New Rectangle(MyBase.Width - arcSize - 2, 0, arcSize, arcSize)

        Dim path As GraphicsPath = New GraphicsPath
        path.StartFigure()
        path.AddArc(leftArc, 90, 180)
        path.AddArc(rightArc, 270, 180)
        path.CloseFigure()

        Return path
    End Function

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim toggleSize As Integer = MyBase.Height - 5
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        pevent.Graphics.Clear(MyBase.Parent.BackColor)

        If (MyBase.Checked) Then 'ON
            'Draw control surface
            If (SolidStyle) Then
                pevent.Graphics.FillPath(New SolidBrush(OnBackColor), GetFigurPath())
            Else
                pevent.Graphics.DrawPath(New Pen(OnBackColor, 2), GetFigurPath())
            End If
            'Draw toggle
            pevent.Graphics.FillEllipse(New SolidBrush(OnToggleColor), New Rectangle(Me.Width - Me.Height + 1, 2, toggleSize, toggleSize))
        Else 'OFF
            'Draw control surface
            If (SolidStyle) Then
                pevent.Graphics.FillPath(New SolidBrush(OffBackColor), GetFigurPath())
            Else
                pevent.Graphics.DrawPath(New Pen(OffBackColor, 2), GetFigurPath())
            End If
            'Draw toggle
            pevent.Graphics.FillEllipse(New SolidBrush(OffToggleColor), New Rectangle(2, 2, toggleSize, toggleSize))
        End If
    End Sub

    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
        'nothing
    End Sub

End Class
