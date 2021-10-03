Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<ToolboxBitmap(GetType(ComboBox))>
<Description("Displays an editable text box and a drop-down list of permitted values.")>
Public Class MComboBox
    Inherits ComboBox

    'Constants
    Const WM_PAINT As Integer = &HF

    Private _ArrowColor As Color = Color.CornflowerBlue
    Private _BorderColor As Color = Color.Gainsboro
    Private _BorderFocusColor As Color = Color.CornflowerBlue

    Public Sub New()

        Me.SuspendLayout()

        Me.MinimumSize = New Size(0, 23)

        Me.ResumeLayout()

        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
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
    Public Property ArrowColor As Color
        Get
            Return _ArrowColor
        End Get
        Set(value As Color)
            _ArrowColor = value
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

        If m.Msg = WM_PAINT Then
            Dim hDC As IntPtr = GetWindowDC(m.HWnd)
            Using g As Graphics = Graphics.FromHdc(hDC)
                g.SmoothingMode = SmoothingMode.AntiAlias

                Dim clientArea As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
                Dim rectIcon = New Rectangle(Me.Width - 16, (Me.Height - 5) / 2, 10, 5)

                'Draw surface
                g.FillRectangle(skinBrush, clientArea)

                'Draw Text
                If Enabled Then
                    TextRenderer.DrawText(g, Me.Text, Me.Font, New Point(0, 3), Me.ForeColor)
                Else
                    TextRenderer.DrawText(g, Me.Text, Me.Font, New Point(0, 3), SystemColors.GrayText)
                End If

                Dim path As GraphicsPath = New GraphicsPath
                g.SmoothingMode = SmoothingMode.AntiAlias
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (10.0F / 2), rectIcon.Bottom)
                path.AddLine(rectIcon.X + (10.0F / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y)
                g.DrawPath(New Pen(_ArrowColor), path)

                If Me.Focused Then
                    g.DrawRectangle(New Pen(_BorderFocusColor), clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height) 'Focus color
                Else
                    g.DrawRectangle(New Pen(_BorderColor), clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height) 'Border
                End If
            End Using
            ReleaseDC(m.HWnd, hDC)
        End If
    End Sub

    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
        'nothing
    End Sub

End Class
