Imports System.Drawing
Imports System.Windows.Forms

Public Class MMC
    Inherits MonthCalendar

    Public Sub New()
        SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        'e.Graphics.Clear(color:=Color.White)
        'e.Graphics.DrawString(Me.SelectionStart.Month & " " & Me.SelectionStart.Year, Me.Font, New SolidBrush(Color.Black), New Point(75, 2))
        'Debug.Print(Me.SelectionStart.Year)
        'Me.inte
    End Sub
End Class
