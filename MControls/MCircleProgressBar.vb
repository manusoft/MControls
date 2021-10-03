Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<ToolboxBitmap(GetType(ProgressBar))>
<Description("Display a circle bar that fills to indicate to the user the progress of an operation.")>
Public Class MCircleProgressBar
    Inherits UserControl

    Public Enum _ProgressShape
        Arrow
        Diamond
        Flat
        Round
        Triangle
    End Enum

    Public Enum _TextMode
        None
        Value
        Percentage
        [Custom]
    End Enum

    Private _Value As Integer = 0
    Private _Maximum As Integer = 100
    Private _LineWitdh As Integer = 10
    Private _BarWidth As Single = 10
    Private _ProgressColor1 As Color = Color.CornflowerBlue
    Private _ProgressColor2 As Color = Color.CornflowerBlue
    Private _LineColor As Color = Color.LightGray
    Private _GradientMode As LinearGradientMode = LinearGradientMode.ForwardDiagonal
    Private ProgressShapeVal As _ProgressShape
    Private ProgressTextMode As _TextMode
    Private _ShadowOffset As Single = 0
    Private _CustomText As String = ""

    Public Sub New()
        InitializeComponent()

        MyBase.SuspendLayout()

        'SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.Opaque, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.Opaque, True)

        BackColor = SystemColors.Control
        ForeColor = Color.DimGray
        Size = New Size(75, 75)
        Font = New Font("Segoe UI", 15)
        MinimumSize = New Size(58, 58)
        DoubleBuffered = True
        LineColor = Color.LightGray
        Value = 25
        ProgressShape = _ProgressShape.Flat
        TextMode = _TextMode.Percentage
        MyBase.ResumeLayout(False)
        MyBase.PerformLayout()

    End Sub

    <Description("Integer Value that determines the position of the Progress Bar."), Category("MControls")>
    Public Property Value() As Long
        Get
            Return _Value
        End Get
        Set
            If Value > _Maximum Then
                Value = _Maximum
            End If
            _Value = Value
            Invalidate()
        End Set
    End Property

    <Description("Gets or Sets the Maximum Value of the Progress bar."), Category("MControls")>
    Public Property Maximum() As Long
        Get
            Return _Maximum
        End Get
        Set
            If Value < 1 Then
                Value = 1
            End If
            _Maximum = Value
            Invalidate()
        End Set
    End Property

    <Description("Initial Color of Progress Bar"), Category("MControls")>
    Public Property BarColor1() As Color
        Get
            Return _ProgressColor1
        End Get
        Set
            _ProgressColor1 = Value
            Invalidate()
        End Set
    End Property

    <Description("Final Color of Progress Bar"), Category("MControls")>
    Public Property BarColor2() As Color
        Get
            Return _ProgressColor2
        End Get
        Set
            _ProgressColor2 = Value
            Invalidate()
        End Set
    End Property

    <Description("Progress Bar Width"), Category("MControls")>
    Public Property BarWidth() As Single
        Get
            Return _BarWidth
        End Get
        Set
            _BarWidth = Value
            Invalidate()
        End Set
    End Property

    <Description("Modo del Gradiente de Color"), Category("MControls")>
    Public Property GradientMode() As LinearGradientMode
        Get
            Return _GradientMode
        End Get
        Set
            _GradientMode = Value
            Invalidate()
        End Set
    End Property

    <Description("Color de la Linea Intermedia"), Category("MControls")>
    Public Property LineColor() As Color
        Get
            Return _LineColor
        End Get
        Set
            _LineColor = Value
            Invalidate()
        End Set
    End Property

    <Description("Width of Intermediate Line"), Category("MControls")>
    Public Property LineWidth() As Integer
        Get
            Return _LineWitdh
        End Get
        Set
            _LineWitdh = Value
            Invalidate()
        End Set
    End Property

    <Description("Get or Set the Shape of the progress bar terminals."), Category("MControls")>
    Public Property ProgressShape() As _ProgressShape
        Get
            Return ProgressShapeVal
        End Get
        Set
            ProgressShapeVal = Value
            Invalidate()
        End Set
    End Property

    <Description("Modo del Gradiente de Color"), Category("MControls")>
    Public Property ShadowOffset() As Integer
        Get
            Return _ShadowOffset
        End Get
        Set
            If Value > 2 Then
                Value = 2
            End If
            _ShadowOffset = Value
            Invalidate()
        End Set
    End Property

    <Description("Get or Set the Mode as the Text is displayed inside the Progress bar."), Category("MControls")>
    Public Property TextMode() As _TextMode
        Get
            Return ProgressTextMode
        End Get
        Set
            ProgressTextMode = Value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property CustomText As String
        Get
            Return _CustomText
        End Get
        Set(value As String)
            _CustomText = value
            Invalidate()
        End Set
    End Property

    Protected Overloads Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        SetStandardSize()
    End Sub

    Protected Overloads Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        SetStandardSize()
    End Sub

    Protected Overloads Overrides Sub OnPaintBackground(p As PaintEventArgs)
        MyBase.OnPaintBackground(p)
    End Sub

    Private Sub SetStandardSize()
        Dim _Size As Integer = Math.Max(Width, Height)
        Size = New Size(_Size, _Size)
    End Sub

    Public Sub Increment(Val As Integer)
        _Value += Val
        Invalidate()
    End Sub

    Public Sub Decrement(Val As Integer)
        _Value -= Val
        Invalidate()
    End Sub

    'Protected Overloads Overrides Sub OnPaint(e As PaintEventArgs)
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Using bitmap As New Bitmap(Width, Height)
            Using graphics As Graphics = Graphics.FromImage(bitmap)
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
                graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
                PaintTransparentBackground(Me, e)
                Dim rect As Rectangle = New Rectangle(10, 10, MyBase.Width - 20, MyBase.Width - 20)
                Using mBackColor As Brush = New SolidBrush(BackColor)
                    graphics.FillEllipse(mBackColor, rect)
                End Using
                Using pen2 As New Pen(LineColor, LineWidth)
                    graphics.DrawEllipse(pen2, rect)
                End Using
                Using brush As New LinearGradientBrush(ClientRectangle, _ProgressColor1, _ProgressColor2, GradientMode)
                    Using pen As New Pen(brush, BarWidth)
                        Select Case ProgressShapeVal
                            Case _ProgressShape.Arrow
                                pen.StartCap = LineCap.Flat
                                pen.EndCap = LineCap.ArrowAnchor
                                Exit Select
                            Case _ProgressShape.Diamond
                                pen.StartCap = LineCap.Flat
                                pen.EndCap = LineCap.DiamondAnchor
                                Exit Select
                            Case _ProgressShape.Flat
                                pen.StartCap = LineCap.Flat
                                pen.EndCap = LineCap.Flat
                                Exit Select
                            Case _ProgressShape.Round
                                pen.StartCap = LineCap.Round
                                pen.EndCap = LineCap.Round
                                Exit Select
                            Case _ProgressShape.Triangle
                                pen.StartCap = LineCap.Flat
                                pen.EndCap = LineCap.Triangle
                                Exit Select
                        End Select
                        graphics.DrawArc(pen, rect, -90, CType((360 / _Maximum) * _Value, Integer))

                    End Using
                End Using

                Select Case TextMode
                    Case _TextMode.None
                        Text = String.Empty
                        Exit Select
                    Case _TextMode.Value
                        Text = _Value.ToString()
                        Exit Select
                    Case _TextMode.Percentage
                        Text = Convert.ToString((100 / _Maximum) * _Value) & "%"
                        Exit Select
                    Case _TextMode.Custom
                        Text = CustomText
                        Exit Select
                    Case Else
                        Exit Select
                End Select

                If Text IsNot String.Empty Then
                    Dim MS As SizeF = graphics.MeasureString(Text, Font)
                    Dim shadowBrush As New SolidBrush(Color.FromArgb(100, ForeColor))
                    graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
                    If ShadowOffset > 0 Then graphics.DrawString(Text, Font, shadowBrush, (Width / 2 - MS.Width / 2) + ShadowOffset, (Height / 2 - MS.Height / 2) + ShadowOffset)

                    'Draw Text
                    graphics.DrawString(Text, Font, New SolidBrush(ForeColor), (Width / 2 - MS.Width / 2), (Height / 2 - MS.Height / 2))
                End If
                MyBase.OnPaint(e)

                e.Graphics.DrawImage(bitmap, 0, 0)
                graphics.Dispose()
            End Using
        End Using
    End Sub

    Private Shared Sub PaintTransparentBackground(c As Control, e As PaintEventArgs)
        If c.Parent Is Nothing OrElse Not Application.RenderWithVisualStyles Then
            Return
        End If
        ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c)
    End Sub

    Private Sub FillCircle(g As Graphics, brush As Brush, centerX As Single, centerY As Single, radius As Single)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear
        g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Using gp As New System.Drawing.Drawing2D.GraphicsPath()
            g.FillEllipse(brush, centerX - radius, centerY - radius, radius + radius, radius + radius)
        End Using
    End Sub
End Class
