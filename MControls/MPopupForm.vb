Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<ToolboxBitmap(GetType(Form))>
<Description("Displays a popup window.")>
Public Class MPopupForm
    Inherits BackgroundWorker

    Private _PopupMain As ToolStripDropDown = New ToolStripDropDown()
    Private _HostMain As ToolStripControlHost

    Private PanelMain As Panel
    Private PanelTitle As Panel
    Private PanelHost As Panel
    Private lblTitle As Label
    Private btnClose As Button
    Private tipClose As ToolTip

    Private _titleBackcolor As Color = Color.DeepSkyBlue
    Private _titleText As String = "Title"
    Private _showTitle As Boolean = True
    Private _Backcolor As Color = Color.White
    Private _ForeColor As Color = Color.Black
    Private _autoClose As Boolean = True
    Private _dropShadowEnabled As Boolean = True
    Private _enabled As Boolean = True
    Private _font As Font
    Private _width As Integer = 300
    Private _height As Integer = 150
    Private _hostForm As Form

    Public Sub New()

        ' This call is required by the designer.

        ' Add any initialization after the InitializeComponent() call.

        PanelMain = New Panel
        PanelMain.BackColor = Backcolor
        PanelMain.Font = New Font("Segoe UI", 10.5F)
        PanelMain.Size = New Size(400, 400)

        PanelTitle = New Panel
        PanelTitle.BackColor = TitleBackcolor
        PanelTitle.Dock = DockStyle.Top
        PanelTitle.Height = 30

        PanelHost = New Panel
        PanelHost.BackColor = SystemColors.ControlLight
        PanelHost.Dock = DockStyle.Fill

        lblTitle = New Label
        lblTitle.AutoSize = False
        lblTitle.BackColor = TitleBackcolor
        lblTitle.Dock = DockStyle.Left
        lblTitle.Font = PanelMain.Font
        lblTitle.Text = "Popup Title"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        AddHandler lblTitle.BackColorChanged, AddressOf lblTitle_BackColorChanged

        btnClose = New Button
        btnClose.Dock = DockStyle.Right
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.FlatAppearance.BorderColor = btnClose.BackColor
        btnClose.FlatAppearance.MouseOverBackColor = Color.Red
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.Width = 30
        btnClose.Image = My.Resources.close_b_18
        AddHandler btnClose.Click, AddressOf btnClose_Click
        AddHandler btnClose.BackColorChanged, AddressOf btnClose_BackColorChanged

        tipClose = New ToolTip
        tipClose.SetToolTip(btnClose, "Close")

        PanelTitle.Controls.Add(lblTitle)
        PanelTitle.Controls.Add(btnClose)

        PanelMain.Controls.Add(PanelHost)
        PanelMain.Controls.Add(PanelTitle)

        _HostMain = New ToolStripControlHost(PanelMain)

        _PopupMain.AutoClose = True
        _PopupMain.BackColor = Backcolor
        _PopupMain.Margin = Padding.Empty
        _PopupMain.Padding = Padding.Empty
        _PopupMain.Items.Add(_HostMain)
    End Sub

    Private Sub lblTitle_BackColorChanged(sender As Object, e As EventArgs)
        If (lblTitle.BackColor.GetBrightness() >= 0.6F) Then
            lblTitle.ForeColor = Color.Black
        Else
            lblTitle.ForeColor = Color.White
        End If
    End Sub

    Private Sub btnClose_BackColorChanged(sender As Object, e As EventArgs)
        If (btnClose.BackColor.GetBrightness() >= 0.6F) Then
            btnClose.Image = My.Resources.close_b_18
        Else
            btnClose.Image = My.Resources.close_w_18
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Try
            _PopupMain.Close()
        Catch ex As Exception

        End Try
    End Sub

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
            _PopupMain.AutoClose = value
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
            _PopupMain.DropShadowEnabled = value
        End Set
    End Property

    <DefaultValue(True)>
    Public Property Enabled As Boolean
        Get
            Return _enabled
        End Get
        Set(value As Boolean)
            _enabled = value
            _PopupMain.Enabled = value
        End Set
    End Property

    Public Property Font As Font
        Get
            Return _font
        End Get
        Set(value As Font)
            _font = value
            PanelMain.Font = value
        End Set
    End Property

    Public Property ForeColor As Color
        Get
            Return _ForeColor
        End Get
        Set(value As Color)
            _ForeColor = value
            PanelMain.ForeColor = value
        End Set
    End Property

    Public Property Width As Integer
        Get
            Return _width
        End Get
        Set(value As Integer)
            _width = value
            PanelMain.Width = value
        End Set
    End Property

    Public Property Height As Integer
        Get
            Return _height
        End Get
        Set(value As Integer)
            _height = value
            PanelMain.Height = value
        End Set
    End Property

    Public Property HostForm As Form
        Get
            Return _hostForm
        End Get
        Set(value As Form)
            _hostForm = value
        End Set
    End Property

    Public Property TitleBackcolor As Color
        Get
            Return _titleBackcolor
        End Get
        Set(value As Color)
            _titleBackcolor = value
            PanelTitle.BackColor = value
            lblTitle.BackColor = value
            btnClose.BackColor = value
        End Set
    End Property

    Public Property TitleText As String
        Get
            Return _titleText
        End Get
        Set(value As String)
            _titleText = value
            lblTitle.Text = value
        End Set
    End Property

    Public Property ShowTitle As Boolean
        Get
            Return _showTitle
        End Get
        Set(value As Boolean)
            _showTitle = value
            If ShowTitle Then
                PanelTitle.Visible = False
            Else
                PanelTitle.Visible = True
            End If
        End Set
    End Property

    Public Sub Show(ByVal control As Control, Optional ByVal x As Integer = 0, Optional ByVal y As Integer = 0)
        If Not IsNothing(_HostMain) Then
            _HostMain.AutoSize = False
            _HostMain.Margin = Padding.Empty
            _HostMain.Padding = Padding.Empty

            If Not IsNothing(HostForm) Then
                HostForm.TopLevel = False
                HostForm.ControlBox = False
                HostForm.FormBorderStyle = FormBorderStyle.None
                PanelMain.Width = HostForm.ClientRectangle.Width
                PanelMain.Height = HostForm.ClientRectangle.Height + 30
                PanelHost.Controls.Add(HostForm)
                TitleText = HostForm.Text
                HostForm.Show()
            Else
                PanelMain.Width = Width
                PanelMain.Height = Height
            End If

            If x = 0 And y = 0 Then
                _PopupMain.Show(control, New Point((control.ClientRectangle.Width / 2) - _PopupMain.Width / 2, (control.ClientRectangle.Height / 2) - _PopupMain.Height / 2))
            Else
                _PopupMain.Show(control, New Point(x, y))
            End If
        End If
    End Sub
End Class
