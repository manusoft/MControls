Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<ToolboxBitmap(GetType(PictureBox))>
<Description("Displays an image.")>
Public Class MCirclePictureBox
    Inherits PictureBox

    'Fields
    Private _borderSize As Integer = 2
    Private _borderColor1 As Color = Color.RoyalBlue
    Private _borderColor2 As Color = Color.HotPink
    Private _borderLineStyle As DashStyle = DashStyle.Solid 'No inavlidate
    Private _borderCapStyle As DashCap = DashCap.Flat 'No invalidate
    Private _gradientAngle As Single = 50.0F

    'Contructor
    Public Sub New()
        Size = New Size(100, 100)
        SizeMode = PictureBoxSizeMode.StretchImage

        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.UserPaint, True)
    End Sub

    <Category("MControl")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property BorderColor1 As Color
        Get
            Return _borderColor1
        End Get
        Set(value As Color)
            _borderColor1 = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property BorderColor2 As Color
        Get
            Return _borderColor2
        End Get
        Set(value As Color)
            _borderColor2 = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property BorderLineStyle As DashStyle
        Get
            Return _borderLineStyle
        End Get
        Set(value As DashStyle)
            _borderLineStyle = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property BorderCapStyle As DashCap
        Get
            Return _borderCapStyle
        End Get
        Set(value As DashCap)
            _borderCapStyle = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property GradientAngle As Single
        Get
            Return _gradientAngle
        End Get
        Set(value As Single)
            _gradientAngle = value
            Invalidate()
        End Set
    End Property

    'Overridden methods
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(Me.Width, Me.Height)
    End Sub

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        Dim g = pe.Graphics
        Dim rectContourSmooth = Rectangle.Inflate(Me.ClientRectangle, -1, -1)
        Dim rectBorder = Rectangle.Inflate(rectContourSmooth, -BorderSize, -BorderSize)
        Dim smoothSize = IIf(_borderSize > 0, _borderSize * 3, 1)
        Using borderGColor = New LinearGradientBrush(rectBorder, BorderColor1, BorderColor2, GradientAngle)
            Using pathRegion = New GraphicsPath()
                Using penSmooth = New Pen(Me.Parent.BackColor, smoothSize)
                    Using penBorder = New Pen(BorderColor1, BorderSize)
                        penBorder.DashStyle = BorderLineStyle
                        penBorder.DashCap = BorderCapStyle
                        pathRegion.AddEllipse(rectContourSmooth)
                        Me.Region = New Region(pathRegion)
                        g.SmoothingMode = SmoothingMode.AntiAlias

                        'drawing
                        g.DrawEllipse(penSmooth, rectContourSmooth)
                        If (BorderSize > 0) Then
                            g.DrawEllipse(penBorder, rectBorder)
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
        'nothing
    End Sub
End Class
