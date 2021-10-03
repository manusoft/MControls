Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<ToolboxBitmap(GetType(ToolTip))>
<Description("Displays an error notification.")>
Public Class MErrorLabel
    Public Enum _Styles
        Danger
        Success
        Warning
    End Enum

    Private Count As Integer = 0
    Private _Style As _Styles
    Private _ShowTime As Integer = 1
    Private _Max As Integer = 10

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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

    Private Sub StyleChange()
        Select Case _Style
            Case _Styles.Danger
                lblError.BackColor = Color.Red
            Case _Styles.Success
                lblError.BackColor = Color.Green
            Case _Styles.Warning
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
End Class
