Public Class Form1
    Private Sub MLookupBox1_TextChanged(sender As Object, e As EventArgs) Handles MLookupBox1.TextChanged
        Debug.Print(MLookupBox1.Text)
    End Sub

    Private Sub MLookupBox1_LookupClick() Handles MLookupBox1.LookupClick
        MsgBox(MLookupBox1.Text)
    End Sub
End Class
