
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<ToolboxBitmap(GetType(Panel))>
<Description("Enables you to group collection of controls.")>
Public Class MPanel
    Inherits Panel

    'Constants
    Const WM_PAINT As Integer = &HF

    Private _BorderColor As Color = Color.Gainsboro

    Public Sub New()
        Me.SuspendLayout()

        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)

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
                g.DrawRectangle(New Pen(_BorderColor), New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
            End Using
            ReleaseDC(m.HWnd, hDC)
        End If
    End Sub

End Class
