Imports System.ComponentModel

Public Class MText
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If IsNothing(PictureBox1.Image) Then
            PictureBox1.Visible = False
        Else
            PictureBox1.Visible = True
        End If

        If IsNothing(PictureBox2.Image) Then
            PictureBox2.Visible = False
        Else
            PictureBox2.Visible = True
        End If
    End Sub


    Private Sub PictureBox1_LoadCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles PictureBox1.LoadCompleted
        If IsNothing(PictureBox1.Image) Then
            PictureBox1.Visible = False
        Else
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub PictureBox2_LoadCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles PictureBox2.LoadCompleted
        If IsNothing(PictureBox2.Image) Then
            PictureBox2.Visible = False
        Else
            PictureBox2.Visible = True
        End If
    End Sub
End Class
