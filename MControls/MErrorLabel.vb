Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<ToolboxBitmap(GetType(ToolTip))>
<Description("Displays an error notification.")>
Public Class MErrorLabel
    Public Enum _Styles
        Danger
        Success
        Warning
    End Enum

    Public Enum _Themes
        Box
        Round
    End Enum

    Private Count As Integer = 0
    Private _Style As _Styles
    Private _Theme As _Themes
    Private _ShowTime As Integer = 3
    Private _Max As Integer = 10

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetStyle(ControlStyles.UserPaint, True)
        MyBase.Visible = False
        tmrTimer.Stop()
    End Sub

    Public Property Style As _Styles
        Get
            Return _Style
        End Get
        Set(value As _Styles)
            _Style = value
            StyleChange()
        End Set
    End Property

    Public Property ShowTime As Integer
        Get
            Return _ShowTime
        End Get
        Set(value As Integer)
            _ShowTime = value
        End Set
    End Property

    Public Property Theme As _Themes
        Get
            Return _Theme
        End Get
        Set(value As _Themes)
            _Theme = value
            Invalidate()
        End Set
    End Property

    Private Sub StyleChange()
        Select Case _Style
            Case _Styles.Danger
                MyBase.BackColor = Color.Red
                lblError.BackColor = Color.Red
            Case _Styles.Success
                MyBase.BackColor = Color.Green
                lblError.BackColor = Color.Green
            Case _Styles.Warning
                MyBase.BackColor = Color.DarkOrange
                lblError.BackColor = Color.DarkOrange
        End Select
    End Sub

    Public Sub ShowError(ErrorText As String)
        Count = 0
        lblError.Text = ErrorText
        tmrTimer.Start()
    End Sub
    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        MyBase.Visible = True
        Count += 1
        _Max = _ShowTime * 10

        If Count = _Max Then
            tmrTimer.Stop()
            MyBase.Visible = False
        End If
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
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        pevent.Graphics.Clear(MyBase.Parent.BackColor)

        If _Theme = _Themes.Round Then
            'Draw Round surface
            pevent.Graphics.FillPath(New SolidBrush(MyBase.BackColor), GetFigurPath())
        Else
            pevent.Graphics.FillRectangle(New SolidBrush(MyBase.BackColor), MyBase.ClientRectangle)
        End If
    End Sub
End Class
