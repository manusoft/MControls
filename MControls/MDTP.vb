Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Compatibility.VB6

Public Class MDTP
    Private _popup As ToolStripDropDown = New ToolStripDropDown()
    Private _host As ToolStripControlHost
    Private pnl As Panel
    Private dtp As DateTimePicker
    Private mc As MonthCalendar
    Private btn As Button



    Private _Text As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Size = New Size(235, 25)

        pnl = New Panel
        pnl.BackColor = Color.Red
        'pnl.Font = Me.Font
        pnl.Padding = New Padding(2, 2, 2, 2)
        pnl.Size = New Size(231, 214)

        dtp = New DateTimePicker
        dtp.Format = DateTimePickerFormat.Short
        dtp.ShowUpDown = True
        dtp.Dock = DockStyle.Top
        dtp.MaxDate = CDate("12/31/9998")
        dtp.Value = Date.Now
        AddHandler dtp.ValueChanged, AddressOf dtp_ValueChanged

        lblText.Text = dtp.Value

        mc = New MonthCalendar
        mc.Dock = DockStyle.Top
        AddHandler mc.DateChanged, AddressOf mc_DateChanged

        btn = New Button
        btn.FlatStyle = FlatStyle.Flat
        btn.Font = Me.Font
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.BorderColor = btn.BackColor
        btn.Dock = DockStyle.Top
        btn.Text = "SELECT"
        btn.Height = 25
        AddHandler btn.Click, AddressOf btn_Click

        pnl.Controls.Add(btn)
        pnl.Controls.Add(mc)
        pnl.Controls.Add(dtp)

        Me.Text = dtp.Text

        _host = New ToolStripControlHost(pnl)

        _popup.AutoClose = True
        _popup.BackColor = Color.Red
        _popup.Margin = Padding.Empty
        _popup.Padding = Padding.Empty
        _popup.Items.Add(_host)

    End Sub

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    <Bindable(True)>
    <Category("MControl")>
    Public Overrides Property Text As String
        Get
            Return lblText.Text
        End Get
        Set(ByVal value As String)
            lblText.Text = value
        End Set
    End Property

    Private Sub btn_Click(sender As Object, e As EventArgs)
        _popup.Close()
    End Sub

    Private Sub mc_DateChanged(sender As Object, e As DateRangeEventArgs)
        dtp.Value = mc.SelectionStart
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs)
        mc.SelectionStart = dtp.Value
        lblText.Text = dtp.Text
    End Sub

    Private Sub btnDropdown_Click(sender As Object, e As EventArgs) Handles btnDropdown.Click
        If Not IsNothing(_host) Then
            _host.AutoSize = False
            _host.Margin = New Padding(2, 2, 2, 2)
            _host.Padding = Padding.Empty
            _popup.Show(ParentForm, New Point(Me.Left, Me.Bottom))
        End If
    End Sub

    <Category("MControl")> <DescriptionAttribute("DateTimePickerMaxDateDescr")>
    Public Property MaxDate As Date
End Class
