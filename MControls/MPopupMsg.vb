Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<ToolboxBitmap(GetType(Form))>
<Description("Displays a popup window.")>
Public Class MPopupMsg
    Inherits BackgroundWorker

    Private _popup As ToolStripDropDown = New ToolStripDropDown()
    Private _host As ToolStripControlHost

    Private pnl As Panel
    Private lbl As Label

    Public Enum Styles
        Primary
        Seconday
        Success
        Danger
        Warning
        Info
        Custom
    End Enum

    Private _Style As Styles = Styles.Primary
    Private _StyleCustomColor As Color
    Private _Backcolor As Color = Color.DeepSkyBlue
    Private _ForeColor As Color = Color.White
    Private _autoClose As Boolean = True
    Private _dropShadowEnabled As Boolean = True
    Private _enabled As Boolean = True
    Private _font As Font
    Private myColor As Color = Color.Empty

    Public Property Style As Styles
        Get
            Return _Style
        End Get
        Set(value As Styles)
            _Style = value
            StyleChange()
        End Set
    End Property

    Public Property StyleCustomColor As Color
        Get
            Return _StyleCustomColor
        End Get
        Set(value As Color)
            _StyleCustomColor = value
            If Style = Styles.Custom Then
                Backcolor = value
            End If
        End Set
    End Property

    Public Property Backcolor As Color
        Get
            Return _Backcolor
        End Get
        Set(value As Color)
            _Backcolor = value
        End Set
    End Property

    <DefaultValue(True)>
    Public Property AutoClose As Boolean
        Get
            Return _autoClose
        End Get
        Set(value As Boolean)
            _autoClose = value
            _popup.AutoClose = value
        End Set
    End Property

    <CategoryAttribute("MControl")>
    <DefaultValue(True)>
    <DescriptionAttribute(" Gets or sets a value indicating whether a three-dimensional shadow effect appears")>
    Public Property DropShadowEnabled As Boolean
        Get
            Return _dropShadowEnabled
        End Get
        Set(value As Boolean)
            _dropShadowEnabled = value
            _popup.DropShadowEnabled = value
        End Set
    End Property

    <DefaultValue(True)>
    Public Property Enabled As Boolean
        Get
            Return _enabled
        End Get
        Set(value As Boolean)
            _enabled = value
            _popup.Enabled = value
        End Set
    End Property

    Public Property Font As Font
        Get
            Return _font
        End Get
        Set(value As Font)
            _font = value
            lbl.Font = value
        End Set
    End Property

    Public Property ForeColor As Color
        Get
            Return _ForeColor
        End Get
        Set(value As Color)
            _ForeColor = value
            lbl.ForeColor = value
        End Set
    End Property

    Private Sub StyleChange()
        Select Case Style
            Case Styles.Primary
                Backcolor = Color.FromArgb(13, 110, 253)
            Case Styles.Seconday
                Backcolor = Color.FromArgb(108, 117, 125)
            Case Styles.Success
                Backcolor = Color.FromArgb(25, 135, 84)
            Case Styles.Danger
                Backcolor = Color.FromArgb(220, 53, 69)
            Case Styles.Warning
                Backcolor = Color.FromArgb(255, 193, 7)
            Case Styles.Info
                Backcolor = Color.FromArgb(13, 202, 240)
            Case Styles.Custom
                Backcolor = StyleCustomColor
        End Select
    End Sub

    Public Sub New()

        ' This call is required by the designer.

        ' Add any initialization after the InitializeComponent() call.

        pnl = New Panel
        pnl.BackColor = Backcolor
        pnl.Font = New Font("Segoe UI", 10.5F)
        pnl.Padding = New Padding(1, 1, 1, 1)
        pnl.Size = New Size(200, 100)

        lbl = New Label
        lbl.AutoSize = False
        lbl.AutoEllipsis = True
        lbl.Dock = DockStyle.Fill
        lbl.Font = pnl.Font
        lbl.Text = "Sample Popup Message."
        lbl.TextAlign = ContentAlignment.MiddleCenter

        pnl.Controls.Add(lbl)

        _host = New ToolStripControlHost(pnl)

        _popup.AutoClose = True
        _popup.BackColor = Backcolor
        _popup.Margin = Padding.Empty
        _popup.Padding = Padding.Empty
        _popup.Items.Add(_host)

    End Sub

    Public Sub Show(ByVal control As Control,
                    ByVal Text As String,
                    Optional ByVal background As Styles = Styles.Custom,
                    Optional ByVal x As Integer = 0,
                    Optional ByVal y As Integer = 0,
                    Optional ByVal width As Integer = 300,
                    Optional ByVal height As Integer = 150)

        If Not IsNothing(_host) Then
            pnl.Width = width
            pnl.Height = height

            lbl.Text = Text
            Style = background

            _host.AutoSize = False
            _host.Margin = Padding.Empty
            _host.Padding = Padding.Empty

            If x = 0 And y = 0 Then
                _popup.Show(control, New Point((control.Width / 2) - _popup.Width / 2, (control.Height / 2) - _popup.Height / 2))
            Else
                _popup.Show(control, New Point(x, y))
            End If

            pnl.BackColor = Backcolor
            If (Backcolor.GetBrightness() >= 0.6F) Then
                lbl.ForeColor = Color.Black
            Else
                lbl.ForeColor = Color.White
            End If

        End If
    End Sub
End Class
