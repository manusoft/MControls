
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

<ToolboxBitmap(GetType(CheckBox))>
<Description("Enables the user to select or clear the associated option.")>
Public Class MCheckBox
    Inherits CheckBox

    ' Fields
    Private _checkedColor As Color = Color.Teal
    Private _unCheckedColor As Color = Color.Gray

    Public Sub New()
        Me.MinimumSize = New Size(0, 21)

        ' Add a padding of 10 to the left to have a considerable distance between the text And the RadioButton.
        Me.Padding = New Padding(10, 0, 0, 0)
    End Sub

    ' Properties
    <Category("MControls")>
    Public Property CheckedColor As Color
        Get
            Return _checkedColor
        End Get
        Set(value As Color)
            _checkedColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("MControls")>
    Public Property UnCheckedColor As Color
        Get
            Return _unCheckedColor
        End Get
        Set(value As Color)
            _unCheckedColor = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        ' Fields
        Dim g As Graphics = pevent.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim rbBorderSize As Integer = 18

        Dim rectBorder As New Rectangle(
            x:=0,
            y:=(Me.Height - rbBorderSize) / 2,
            Width = rbBorderSize,
            Height = rbBorderSize
        )

        Using penBorder As New Pen(CheckedColor, 1.6F)
            Using penCheck As New Pen(CheckedColor, 2)
                Using brushText As New SolidBrush(Me.ForeColor)

                    ' Draw surface
                    g.Clear(Me.BackColor)
                    ' Draw Radio Button
                    If (Me.Checked) Then
                        ' Box border
                        g.DrawRectangle(penBorder, rectBorder)

                        ' Draw the tick
                        g.DrawLine(penCheck, 3, 10, 7, 15) '\
                        g.DrawLine(penCheck, 6, 15, 15, 5) ' /
                    Else
                        penBorder.Color = UnCheckedColor
                        g.DrawRectangle(penBorder, rectBorder) ' Box border
                    End If

                    ' Draw text
                    g.DrawString(Me.Text, Me.Font, brushText, rbBorderSize + 8, (Me.Height - TextRenderer.MeasureText(Me.Text, Me.Font).Height) / 2) ' Y=Center
                End Using
            End Using
        End Using

    End Sub
End Class
