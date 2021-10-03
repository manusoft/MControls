Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<ToolboxBitmap(GetType(DateTimePicker))>
<Description("Enables the user to select date and time, and to display that date and time in a specified format.")>
Public Class MDatePicker
    Inherits DateTimePicker

    'Appearance
    Private _skinColor As Color = SystemColors.Window
    Private _textColor As Color = Color.Black
    Private _borderColor As Color = Color.Gainsboro
    Private _borderFocusColor As Color = Color.CornflowerBlue
    Private _borderSize As Integer = 1
    Private _IsFocused As Boolean = False
    Private _showIcon As Boolean = False

    'Other Values
    Private _DateText As String = Me.Text
    Private _droppedDown As Boolean = False
    Private _calendarIcon As Image = My.Resources.calendar
    Private _iconButtonArea As RectangleF
    Private Const _calendarIconWidth As Integer = 34
    Private Const _arrowIconWidth As Integer = 17

    Public Sub New()

        SetStyle(ControlStyles.UserPaint, True)

        Me.MinimumSize = New Size(0, 23)
        Me.Font = New Font(Me.Font.Name, 9.0F)
    End Sub

    'Properties
    <Category("MControl")>
    Public Property DateText As String
        Get
            Return _DateText
        End Get
        Set(value As String)
            _DateText = value
            If IsDate(value) Then
                Me.Value = value
                Me.Text = value
            End If
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property SkinColor As Color
        Get
            Return _skinColor
        End Get
        Set(value As Color)
            _skinColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property TextColor As Color
        Get
            Return _textColor
        End Get
        Set(value As Color)
            _textColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property BorderFocusColor As Color
        Get
            Return _borderFocusColor
        End Get
        Set(value As Color)
            _borderFocusColor = value
            Invalidate()
        End Set
    End Property

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
    Public Property IsFocused As Boolean
        Get
            Return _IsFocused
        End Get
        Set(value As Boolean)
            _IsFocused = value
            Invalidate()
        End Set
    End Property

    Public Property ShowIcon As Boolean
        Get
            Return _showIcon
        End Get
        Set(value As Boolean)
            _showIcon = value
            Invalidate()
        End Set
    End Property

    'Overridden methods
    Protected Overrides Sub OnDragDrop(drgevent As DragEventArgs)
        _droppedDown = True
    End Sub

    Protected Overrides Sub OnCloseUp(eventargs As EventArgs)
        _droppedDown = False
    End Sub

    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Protected Overrides Sub OnEnter(e As EventArgs)
        IsFocused = True
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnLeave(e As EventArgs)
        IsFocused = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnValueChanged(eventargs As EventArgs)
        DateText = Me.Text
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            DateText = ""
            Invalidate()
        End If
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim penBorder As Pen = New Pen(BorderColor, BorderSize)
        Dim penFocusBorder As Pen = New Pen(_borderFocusColor, BorderSize)
        Dim skinBrush As SolidBrush = New SolidBrush(SkinColor)
        Dim openIconBrush As SolidBrush = New SolidBrush(Color.FromArgb(50, 64, 64, 64))

        Using g As Graphics = Me.CreateGraphics()
            Dim clientArea As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
            Dim iconArea As RectangleF = New RectangleF(clientArea.Width - _calendarIconWidth, 0, _calendarIconWidth, clientArea.Height)
            penBorder.Alignment = PenAlignment.Inset
            'textFormat.LineAlignment = StringAlignment.Center

            g.SmoothingMode = SmoothingMode.AntiAlias

            ' Draw surface
            g.FillRectangle(skinBrush, clientArea)

            'Draw Text
            TextRenderer.DrawText(g, DateText, Me.Font, New Point(0, 3), TextColor)

            'Draw open calendar icon hilight
            If (_droppedDown = True) Then
                g.FillRectangle(openIconBrush, iconArea)
            End If
            'Draw Icon
            If ShowIcon Then
                g.DrawImage(_calendarIcon, Me.Width - _calendarIcon.Width - 3, (Me.Height - _calendarIcon.Height) - 2)
            End If

            If (IsFocused) Then
                'Draw broder
                If (_borderSize >= 1) Then
                    g.DrawRectangle(penFocusBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height)
                End If
            Else
                'Draw broder
                If (_borderSize >= 1) Then
                    g.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height)
                End If
            End If
        End Using
    End Sub

    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
        'Nothing
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        Me.DateText = Me.Text
        Invalidate()
    End Sub
End Class
