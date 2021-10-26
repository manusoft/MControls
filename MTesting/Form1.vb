Public Class Form1
    Private Sub MLookupBox1_TextChanged(sender As Object, e As EventArgs)
        Debug.Print(MLookupBox1.Text)
    End Sub

    Private Sub MLookupBox1_LookupClick()
        MsgBox(MLookupBox1.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Debug.Print(MonthCalendar1.SelectionStart)
    End Sub
End Class
