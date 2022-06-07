Public Class Form3
    Dim vConnString As String = "Server=.;Initial Catalog=VetDB;Trusted_Connection = yes"
    Dim ErrorMsg As String = String.Empty
    Dim db As New DBHelper.MSSQLEngine

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not db.Connect(vConnString, ErrorMsg) Then Exit Sub

        Try
            Dim DT = db.Fill("SELECT * FROM Person")

            If Not IsNothing(DT) Then
                'MLookupList1.LoadData(DT)
                ' MLookupList1.DataSource = DT
                'DataGridView1.DataSource = DT
                ' MLookupList1.Data = DT
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' MLookupList1.Data =  
    End Sub
End Class