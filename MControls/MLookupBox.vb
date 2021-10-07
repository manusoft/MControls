
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<DefaultEvent("TextChanged")>
<ToolboxBitmap(GetType(MaskedTextBox))>
<Description("SearchBox control.")>
Public Class MLookupBox

    Private _BorderColor As Color = Color.Gray
    Private _BorderFocusColor As Color = Color.CornflowerBlue
    Private _BackColor As Color = Color.White
    Private _ForeColor As Color = Color.Black
    Private _PlaceholderText As String = ""
    Private _Font As Font
    Private _IsFocused As Boolean = False

    Private Const _SetPlaceholder As Integer = &H1501

    Public Event LookupClick()

    <DllImport("User32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Int32
    End Function

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        If Not String.IsNullOrEmpty(PlaceholderText) Then UpdatePlaceHolder()
    End Sub
    Private Sub UpdatePlaceHolder()
        SendMessage(txtSearch.Handle, _SetPlaceholder, 0, PlaceholderText)
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        SetStyle(ControlStyles.UserPaint, True)
        ' Add any initialization after the InitializeComponent() call.

        MinimumSize = New Size(0, 25)
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
            txtSearch.BackColor = value
            btnMore.BackColor = value
            btnMore.FlatAppearance.BorderColor = value
        End Set
    End Property

    Public Overrides Property ForeColor As Color
        Get
            Return _ForeColor
        End Get
        Set(value As Color)
            _ForeColor = value
            MyBase.ForeColor = value
            txtSearch.ForeColor = MyBase.ForeColor
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
            txtSearch.Font = value
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

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    <Bindable(True)>
    <Category("My Control")>
    Public Overrides Property Text As String
        Get
            Return txtSearch.Text
        End Get
        Set(value As String)
            txtSearch.Text = value
        End Set
    End Property

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        If (Height > 23) Then Height = 23
        If (Font.Size > 10) Then txtSearch.Font = New Font(Font, 10)
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

    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click
        RaiseEvent LookupClick()
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RaiseEvent TextChanged(sender, e)
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        _IsFocused = True
        Invalidate()
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        _IsFocused = False
        Invalidate()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        MyBase.OnClick(e)
    End Sub

    Private Sub txtSearch_MouseEnter(sender As Object, e As EventArgs) Handles txtSearch.MouseEnter
        MyBase.OnMouseEnter(e)
    End Sub

    Private Sub txtSearch_MouseLeave(sender As Object, e As EventArgs) Handles txtSearch.MouseLeave
        MyBase.OnMouseLeave(e)
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        MyBase.OnKeyPress(e)
    End Sub

End Class
