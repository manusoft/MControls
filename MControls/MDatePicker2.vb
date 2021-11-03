Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Compatibility.VB6

Public Class MDatePicker2
    Private _popup As ToolStripDropDown = New ToolStripDropDown()
    Private _host As ToolStripControlHost
    Private pnl As Panel
    Private dtp As DateTimePicker
    Private mc As MonthCalendar
    Private btn As Button

    Private _BackColor As Color = Color.DeepSkyBlue

    Private _DateText As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Size = New Size(229, 25)

        SuspendLayout()

        pnl = New Panel
        pnl.BackColor = BackColor
        'pnl.Font = Me.Font
        pnl.Padding = New Padding(1, 1, 1, 1)
        pnl.Size = New Size(229, 214)

        dtp = New DateTimePicker
        dtp.CustomFormat = CustomFormat
        dtp.Format = Format
        dtp.ShowUpDown = True
        dtp.Dock = DockStyle.Top
        dtp.Value = Date.Now
        AddHandler dtp.ValueChanged, AddressOf dtp_ValueChanged

        lblText.Text = dtp.Text

        mc = New MonthCalendar
        mc.Dock = DockStyle.Top
        mc.BackColor = Color.Blue
        mc.MaxSelectionCount = 1
        AddHandler mc.DateSelected, AddressOf mc_DateSelected

        btn = New Button
        btn.FlatStyle = FlatStyle.Flat
        btn.Font = Me.Font
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.BorderColor = BackColor
        btn.Dock = DockStyle.Top
        btn.Text = "&OK"
        btn.Height = 25
        AddHandler btn.Click, AddressOf btn_Click

        pnl.Controls.Add(btn)
        pnl.Controls.Add(mc)
        pnl.Controls.Add(dtp)

        Me.Text = dtp.Text

        _host = New ToolStripControlHost(pnl)

        _popup.AutoClose = True
        _popup.BackColor = BackColor
        _popup.Margin = Padding.Empty
        _popup.Padding = Padding.Empty
        _popup.Items.Add(_host)

        ResumeLayout()
    End Sub

    Private Sub mc_DateSelected(sender As Object, e As DateRangeEventArgs)
        dtp.Value = mc.SelectionStart
        lblText.Text = dtp.Text
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs)
        lblText.Text = dtp.Text
        _popup.Close()
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs)
        mc.SelectionStart = dtp.Value
    End Sub

    Private Sub btnDropdown_Click(sender As Object, e As EventArgs) Handles btnDropdown.Click
        If Not IsNothing(_host) Then
            _host.AutoSize = False
            _host.Margin = Padding.Empty
            _host.Padding = Padding.Empty
            _popup.Show(ParentForm, New Point(Me.Left, Me.Bottom))

            pnl.BackColor = BackColor
            If (BackColor.GetBrightness() >= 0.6F) Then
                btn.ForeColor = Color.Black
            Else
                btn.ForeColor = Color.White
            End If
        End If
    End Sub

    <Category("MControl")> <DescriptionAttribute("DateTimePickerMaxDateDescr")>
    Public Property MaxDate As Date
        Get
            Return dtp.MaxDate
        End Get
        Set(value As Date)
            dtp.MaxDate = value
        End Set
    End Property

    <CategoryAttribute("MControl")> <DescriptionAttribute("DateTimePickerMinDateDescr")>
    Public Property MinDate As Date
        Get
            Return dtp.MinDate
        End Get
        Set(value As Date)
            dtp.MinDate = value
        End Set
    End Property


    <RefreshProperties(RefreshProperties.Repaint)> <CategoryAttribute("CatAppearance")> <DescriptionAttribute("DateTimePickerFormatDescr")>
    Public Property Format As DateTimePickerFormat
        Get
            Return dtp.Format
        End Get
        Set(value As DateTimePickerFormat)
            dtp.Format = value
        End Set
    End Property

    Public Overrides Property BackColor As Color
        Get
            Return _BackColor
        End Get
        Set(value As Color)
            _BackColor = value
            MyBase.BackColor = value
            lblText.BackColor = value
            btnDropdown.BackColor = value
            If (BackColor.GetBrightness() >= 0.6F) Then
                btnDropdown.Image = My.Resources.black_calendar
            Else
                btnDropdown.Image = My.Resources.white_calendar
            End If
            'pnl.BackColor = value

        End Set
    End Property


    <Bindable(True)>
    <RefreshProperties(RefreshProperties.All)>
    <CategoryAttribute("MControl")>
    <DescriptionAttribute("DateTimePickerValueDescr")>
    Public Property Value As Date
        Get
            Return dtp.Value
        End Get
        Set(value As Date)
            dtp.Value = value
        End Set
    End Property

    <Localizable(True)> <RefreshProperties(RefreshProperties.Repaint)>
    <CategoryAttribute("MControl")>
    <DescriptionAttribute("DateTimePickerCustomFormatDescr")>
    Public Property CustomFormat As String
        Get
            Return dtp.CustomFormat
        End Get
        Set(value As String)
            dtp.CustomFormat = value
        End Set
    End Property

    <Browsable(True)> <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> <EditorBrowsable(EditorBrowsableState.Advanced)>
    Public Overrides Property Text As String
        Get
            Return dtp.Text
        End Get
        Set(value As String)
            If IsDate(value) Then
                dtp.Text = CDate(value)
            End If
        End Set
    End Property

    Public ReadOnly Property DateText As String
        Get
            Return lblText.Text
        End Get
    End Property

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        If BorderStyle = BorderStyle.Fixed3D Then
            BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub lblText_Click(sender As Object, e As EventArgs) Handles lblText.Click
        btnDropdown.PerformClick()
    End Sub

    Private Sub lblText_DoubleClick(sender As Object, e As EventArgs) Handles lblText.DoubleClick
        lblText.Text = ""
    End Sub
End Class
