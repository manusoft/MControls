Imports System.Reflection

Public Class Form1
    Private Sub MLookupBox1_TextChanged(sender As Object, e As EventArgs)
        Debug.Print(MLookupBox1.Text)
    End Sub

    Private Sub MLookupBox1_LookupClick()
        MsgBox(MLookupBox1.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered(MComboBox1, True)
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Debug.Print(MonthCalendar1.SelectionStart)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MPopupMsg1.Show(Me, "Welcome to Laksya Solutions.")
        MsgBox("Welcome to Laksya Solutions.")
    End Sub

    Private Shadows Sub DoubleBuffered(ByVal formControl As Control, ByVal setting As Boolean)
        Dim conType As Type = formControl.GetType()
        Dim pi As PropertyInfo = conType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(formControl, setting, Nothing)
    End Sub


End Class
