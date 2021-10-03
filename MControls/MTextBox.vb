Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<ToolboxBitmap(GetType(TextBox))>
<Description("Enables the user to enter text, and provides multiline editing and password character nasking.")>
Public Class MTextBox
    Inherits TextBox

    'Constants
    Const WM_PAINT As Integer = &HF

    Private _BorderColor As Color = Color.Gainsboro
    Private _BorderFocusColor As Color = Color.CornflowerBlue
    Private _PlaceHolderText As String = ""
    Private _NumberMode As Boolean = False

    Private Const _SetPlaceHolder As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer,
            ByVal wParam As Integer, ByVal lParam As String) As Int32
    End Function

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        If Not String.IsNullOrEmpty(PlaceHolderText) Then UpdatePlaceHolder()
    End Sub

    Private Sub UpdatePlaceHolder()
        SendMessage(Me.Handle, _SetPlaceHolder, 0, PlaceHolderText)
    End Sub

    Public Sub New()
        Me.SuspendLayout()

        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)

        Me.MinimumSize = New Size(0, 23)

        Me.ResumeLayout()
    End Sub

    <Category("MControl")>
    Public Property BorderColor As Color
        Get
            Return _BorderColor
        End Get
        Set(value As Color)
            _BorderColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property BorderFocusColor As Color
        Get
            Return _BorderFocusColor
        End Get
        Set(value As Color)
            _BorderFocusColor = value
            Invalidate()
        End Set
    End Property

    <Category("MControl")>
    Public Property PlaceHolderText As String
        Get
            Return _PlaceHolderText
        End Get
        Set(value As String)
            _PlaceHolderText = value
            UpdatePlaceHolder()
        End Set
    End Property

    <Category("MControl")>
    Public Property NumberMode As Boolean
        Get
            Return _NumberMode
        End Get
        Set(value As Boolean)
            _NumberMode = value
        End Set
    End Property

    <Flags()>
    Private Enum RedrawWindowFlags As UInteger
        Invalidate = &H1
        InternalPaint = &H2
        [Erase] = &H4
        Validate = &H8
        NoInternalPaint = &H10
        NoErase = &H20
        NoChildren = &H40
        AllChildren = &H80
        UpdateNow = &H100
        EraseNow = &H200
        Frame = &H400
        NoFrame = &H800
    End Enum

    <DllImport("User32.dll")>
    Public Shared Function GetWindowDC(ByVal hWnd As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Private Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function RedrawWindow(hWnd As IntPtr, lprcUpdate As IntPtr, hrgnUpdate As IntPtr, flags As RedrawWindowFlags) As Boolean
    End Function

    Protected Overrides Sub OnResize(e As System.EventArgs)
        MyBase.OnResize(e)
        RedrawWindow(Me.Handle, IntPtr.Zero, IntPtr.Zero, RedrawWindowFlags.Frame Or RedrawWindowFlags.UpdateNow Or RedrawWindowFlags.Invalidate)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        Dim skinBrush As SolidBrush = New SolidBrush(BackColor)
        Dim textBrush As SolidBrush = New SolidBrush(Me.ForeColor)
        Dim textFormat As StringFormat = New StringFormat()

        If m.Msg = WM_PAINT Then
            Dim clientArea As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
            Dim hDC As IntPtr = GetWindowDC(m.HWnd)
            Using g As Graphics = Graphics.FromHdc(hDC)
                If Me.Focused Then
                    g.DrawRectangle(New Pen(_BorderFocusColor), New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
                Else
                    g.DrawRectangle(New Pen(_BorderColor), New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
                End If
            End Using
            ReleaseDC(m.HWnd, hDC)
        End If
    End Sub

    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)
        If _NumberMode = True Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Delete) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class
