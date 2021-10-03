Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<DefaultEvent("TextChanged")>
<ToolboxBitmap(GetType(DateTimePicker))>
<Description("Enables the user to select date and time or type the date, and to display that date and time in a specified format.")>
Public Class MDatePickerEditable
    'Constants
    Const WM_SYSKEYDOWN As UInteger = &H104

    Private _BorderColor As Color = Color.Gray
    Private _BorderFocusColor As Color = Color.CornflowerBlue
    Private _BackColor As Color = Color.White
    Private _ForeColor As Color = Color.Black
    Private _PlaceholderText As String = ""
    Private _Font As Font
    Private _IsFocused As Boolean = False

    Private _CustomFormat As String = ""
    Private _DateFormat As DateTimePickerFormat = DateTimePickerFormat.Long
    Private _DateValue As Date = Date.Now
    Private _MinDate As Date

    Private Const _SetPlaceholder As Integer = &H1501

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        SetStyle(ControlStyles.UserPaint, True)
        ' Add any initialization after the InitializeComponent() call.

        MinimumSize = New Size(0, 23)
        dtPicker.Value = DateValue
    End Sub

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Int32
    End Function

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        If Not String.IsNullOrEmpty(PlaceholderText) Then UpdatePlaceHolder()
    End Sub
    Private Sub UpdatePlaceHolder()
        SendMessage(txtDate.Handle, _SetPlaceholder, 0, PlaceholderText)
    End Sub

    'Properties
    Public Property BorderColor As Color
        Get
            Return _BorderColor
        End Get
        Set(value As Color)
            _BorderColor = value
            Invalidate()
        End Set
    End Property

    Public Property BorderFocusColor As Color
        Get
            Return _BorderFocusColor
        End Get
        Set(value As Color)
            _BorderFocusColor = value
            Invalidate()
        End Set
    End Property

    Public Overrides Property BackColor As Color
        Get
            Return _BackColor
        End Get
        Set(value As Color)
            _BackColor = value
            MyBase.BackColor = value
            txtDate.BackColor = MyBase.BackColor
            btnCalendar.BackColor = MyBase.BackColor
        End Set
    End Property

    Public Overrides Property ForeColor As Color
        Get
            Return _ForeColor
        End Get
        Set(value As Color)
            _ForeColor = value
            MyBase.ForeColor = value
            txtDate.ForeColor = MyBase.ForeColor
        End Set
    End Property

    Public Property PlaceholderText As String
        Get
            Return _PlaceholderText
        End Get
        Set(value As String)
            _PlaceholderText = value
            UpdatePlaceHolder()
        End Set
    End Property

    Public Overrides Property Font As Font
        Get
            Return _Font
        End Get
        Set(value As Font)
            _Font = value
            txtDate.Font = value
        End Set
    End Property

    Public Property IsFocused As Boolean
        Get
            Return _IsFocused
        End Get
        Set(value As Boolean)
            _IsFocused = value
        End Set
    End Property

    Public Property CustomFormat As String
        Get
            Return _CustomFormat
        End Get
        Set(value As String)
            _CustomFormat = value
            dtPicker.CustomFormat = value
        End Set
    End Property

    Public Property DateFormat As DateTimePickerFormat
        Get
            Return _DateFormat
        End Get
        Set(value As DateTimePickerFormat)
            _DateFormat = value

            Select Case value
                Case DateTimePickerFormat.Custom
                    dtPicker.Format = DateTimePickerFormat.Custom
                Case DateTimePickerFormat.Long
                    dtPicker.Format = DateTimePickerFormat.Long
                Case DateTimePickerFormat.Short
                    dtPicker.Format = DateTimePickerFormat.Short
                Case DateTimePickerFormat.Time
                    dtPicker.Format = DateTimePickerFormat.Time
            End Select
        End Set
    End Property

    Public Property MinDate As Date
        Get
            Return _MinDate
        End Get
        Set(value As Date)
            _MinDate = value
            dtPicker.MinDate = value
        End Set
    End Property

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    <Bindable(True)>
    <Category("My Control")>
    Public Overrides Property Text As String
        Get
            Return txtDate.Text
        End Get
        Set(value As String)
            txtDate.Text = value
        End Set
    End Property

    Public Property DateValue As Date
        Get
            Return _DateValue
        End Get
        Set(value As Date)
            _DateValue = value
            dtPicker.Value = value
        End Set
    End Property

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        If (Height > 25) Then Height = 25
        If (Font.Size > 10) Then txtDate.Font = New Font(Font, 10)
    End Sub

    'Event
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    <Bindable(True)>
    <Category("My Control")>
    Public Shadows Event TextChanged As EventHandler

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Using bmp As Bitmap = New Bitmap(Width, Height)
            Using g As Graphics = Me.CreateGraphics()
                g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                Dim clientArea As Rectangle = New Rectangle(0, 0, Me.Width - 1, Height - 1)

                If (_IsFocused) Then
                    'Draw Focus Border
                    g.DrawRectangle(New Pen(_BorderFocusColor, 1), clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height)
                Else
                    'Draw Normal Border
                    g.DrawRectangle(New Pen(_BorderColor, 1), clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height)
                End If
            End Using
            e.Graphics.DrawImage(bmp.Clone, 0, 0)
            bmp.Dispose()
        End Using
        MyBase.OnPaint(e)
    End Sub

    Private Sub btnCalendar_Click(sender As Object, e As EventArgs) Handles btnCalendar.Click
        SendMessage(dtPicker.Handle, WM_SYSKEYDOWN, CInt(Keys.Down), 0)
    End Sub

    Private Sub txtDate_TextChanged(sender As Object, e As EventArgs) Handles txtDate.TextChanged
        'If IsDate(txtDate.Text) Then
        '    dtPicker.Value = CDate(txtDate.Text)
        '    ' txtDate.Text = dtPicker.Text
        'End If
        'If Len(txtDate.Text) = 4 Or Len(txtDate.Text) = 7 Then
        '    txtDate.Text = txtDate.Text & "/"
        '    txtDate.SelectionStart = Len(txtDate.Text)
        'End If
        RaiseEvent TextChanged(sender, e)
    End Sub

    Private Sub txtDate_Enter(sender As Object, e As EventArgs) Handles txtDate.Enter
        _IsFocused = True
        Invalidate()
    End Sub

    Private Sub txtDate_Leave(sender As Object, e As EventArgs) Handles txtDate.Leave
        _IsFocused = False
        Invalidate()
    End Sub

    Private Sub txtDate_Click(sender As Object, e As EventArgs) Handles txtDate.Click
        MyBase.OnClick(e)
    End Sub

    Private Sub txtDate_MouseEnter(sender As Object, e As EventArgs) Handles txtDate.MouseEnter
        MyBase.OnMouseEnter(e)
    End Sub

    Private Sub txtDate_MouseLeave(sender As Object, e As EventArgs) Handles txtDate.MouseLeave
        MyBase.OnMouseLeave(e)
    End Sub

    Private Sub txtDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDate.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Delete) Or e.KeyChar = "/" Then
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub dtPicker_ValueChanged(sender As Object, e As EventArgs) Handles dtPicker.ValueChanged
        txtDate.Text = dtPicker.Text
    End Sub

End Class

'Private Sub Text6_Change()

'    If Len(Text6.Text) = 2 Or Len(Text6.Text) = 5 Then
'        Text6.Text = Text6.Text & "/"
'        Text6.SelStart = Len(Text6.Text)
'    End If

'End Sub