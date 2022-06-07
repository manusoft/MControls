Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<ToolboxBitmap(GetType(RadioButton))>
<Description("Enables the user to select a single option from a group of choices when paired with other MRadioButtons.")>
Public Class MRadioButton
    Inherits RadioButton

    'Fields
    Private _checkedColor As Color = Color.DeepPink
    Private _uncheckedColor As Color = Color.Gray

    Public Sub New()
        Me.MinimumSize = New Size(0, 21)
        'Add a padding of 10 to the left to have a considerable distance between the text and the RadioButton.
        Me.Padding = New Padding(10, 0, 0, 0)
    End Sub

    Public Property CheckedColor As Color
        Get
            Return _checkedColor
        End Get
        Set(value As Color)
            _checkedColor = value
            Invalidate()
        End Set
    End Property

    Public Property UncheckedColor As Color
        Get
            Return _uncheckedColor
        End Get
        Set(value As Color)
            _uncheckedColor = value
            Invalidate()
        End Set
    End Property

    'Overridden methods
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        'Fields
        Dim g As Graphics = pevent.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim rbBorderSize As Single = 18.0F
        Dim rbCheckSize As Single = 12.0F
        Dim rectRbBorder As RectangleF = New RectangleF() With
        {
            .X = 0.5F,
            .Y = (Me.Height - rbBorderSize) / 2, ' Center
            .Width = rbBorderSize,
            .Height = rbBorderSize
        }

        Dim rectRbCheck As RectangleF = New RectangleF() With
        {
            .X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2), 'Center
            .Y = (Me.Height - rbCheckSize) / 2, 'Center
            .Width = rbCheckSize,
            .Height = rbCheckSize
        }

        'Drawing
        Using penBorder As Pen = New Pen(CheckedColor, 1.6F)
            Using brushRbCheck As SolidBrush = New SolidBrush(CheckedColor)
                Using brushText As SolidBrush = New SolidBrush(Me.ForeColor)
                    'Draw surface
                    g.Clear(Me.BackColor)

                    'Draw Radio Button
                    If (Me.Checked) Then
                        g.DrawEllipse(penBorder, rectRbBorder) 'Circle border
                        g.FillEllipse(brushRbCheck, rectRbCheck) 'Circle Radio Check
                    Else
                        penBorder.Color = UncheckedColor
                        g.DrawEllipse(penBorder, rectRbBorder) 'Circle border
                    End If

                    'Draw text
                    g.DrawString(Me.Text, Me.Font, brushText, rbBorderSize + 8, (Me.Height - TextRenderer.MeasureText(Me.Text, Me.Font).Height) / 2) '//Y=Center
                End Using
            End Using
        End Using
    End Sub

End Class
