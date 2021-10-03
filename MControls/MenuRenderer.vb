Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class MenuRenderer
    Inherits ToolStripProfessionalRenderer

    Private primaryColor As Color
    Private textColor As Color
    Private arrowThickness As Integer

    Public Sub New(ByVal isMainMenu As Boolean, ByVal primaryColor As Color, ByVal textColor As Color)
        MyBase.New(New MenuColorTable(isMainMenu, primaryColor))
        Me.primaryColor = primaryColor

        If isMainMenu Then
            arrowThickness = 3

            If textColor = Color.Empty Then
                Me.textColor = Color.Gainsboro
            Else
                Me.textColor = textColor
            End If
        Else
            arrowThickness = 2

            If textColor = Color.Empty Then
                Me.textColor = Color.DimGray
            Else
                Me.textColor = textColor
            End If
        End If
    End Sub

    Protected Overrides Sub OnRenderItemText(ByVal e As ToolStripItemTextRenderEventArgs)
        MyBase.OnRenderItemText(e)
        e.Item.ForeColor = If(e.Item.Selected, Color.White, textColor)
    End Sub

    Protected Overrides Sub OnRenderArrow(ByVal e As ToolStripArrowRenderEventArgs)
        Dim graph = e.Graphics
        Dim arrowSize = New Size(5, 12)
        Dim arrowColor = If(e.Item.Selected, Color.White, primaryColor)
        Dim rect = New Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - arrowSize.Height) / 2, arrowSize.Width, arrowSize.Height)

        Using path As GraphicsPath = New GraphicsPath()

            Using pen As Pen = New Pen(arrowColor, arrowThickness)
                graph.SmoothingMode = SmoothingMode.AntiAlias
                'path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2)
                'path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height)
                graph.DrawPath(pen, path)
            End Using
        End Using
    End Sub


End Class
