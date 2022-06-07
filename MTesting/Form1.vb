Imports System.Reflection
Imports MControls

Public Class Form1
    Private _PopupMain As ToolStripDropDown = New ToolStripDropDown()
    Private _HostMain As ToolStripControlHost
    Private PanelMain As Panel

    Private dateTimePickerHost As ToolStripControlHost
    Dim TestAutoComplete As New AutoCompleteStringCollection

    Private Sub InitializeDateTimePickerHost()

        ' Create a new ToolStripControlHost, passing in a control.
        dateTimePickerHost = New ToolStripControlHost(New DateTimePicker())

        ' Set the font on the ToolStripControlHost, this will affect the hosted control.
        dateTimePickerHost.Font = New Font("Arial", 7.0F, FontStyle.Italic)

        ' Set the Width property, this will also affect the hosted control.
        dateTimePickerHost.Width = 100
        dateTimePickerHost.DisplayStyle = ToolStripItemDisplayStyle.Text

        ' Setting the Text property requires a string that converts to a  
        ' DateTime type since that is what the hosted control requires.
        dateTimePickerHost.Text = "12/23/2005"

        ' Cast the Control property back to the original type to set a  
        ' type-specific property. 
        CType(dateTimePickerHost.Control, DateTimePicker).Format = DateTimePickerFormat.Short

        ' Add the control host to the ToolStrip.
        'ToolStrip1.Items.Add(dateTimePickerHost)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Shadows Sub DoubleBuffered(ByVal formControl As Control, ByVal setting As Boolean)
        Dim conType As Type = formControl.GetType()
        Dim pi As PropertyInfo = conType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(formControl, setting, Nothing)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        PopupForm1.Show(Me)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'InitializeDateTimePickerHost()

        'PanelMain = New Panel
        'PanelMain.AutoSize = False
        'PanelMain.BackColor = Color.Green
        'PanelMain.Font = New Font("Segoe UI", 10.5F)


        '_HostMain = New ToolStripControlHost(PanelMain)
        '_HostMain.AutoSize = False
        '_HostMain.Margin = Padding.Empty
        '_HostMain.Padding = Padding.Empty

        '_PopupMain.AutoClose = True
        '' _PopupMain.BackColor = Color.Transparent
        '_PopupMain.Margin = Padding.Empty
        '_PopupMain.Padding = Padding.Empty
        '_PopupMain.Items.Add(_HostMain)
        '_PopupMain.DropShadowEnabled = False
        '_PopupMain.AllowTransparency = True
        '_PopupMain.Opacity = 50
        '_PopupMain.AutoSize = True


        'PopupForm1.HostForm = Form2

        Dim i As Byte

        Dim colNames As String() = [Enum].GetNames(GetType(KnownColor))
        Do While i < colNames.Length - 1
            TestAutoComplete.Add(colNames(i).ToString)
            i = i + 1
        Loop

        MLookupBox2.AutoCompleteCustomSource = TestAutoComplete

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PanelMain.Size = New Size(Me.ClientRectangle.Width / 2, Me.ClientRectangle.Height)
        _PopupMain.Show(Me, Me.ClientRectangle.Width / 2 + 1, 0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles Me.Move

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.DrawLine(New Pen(Color.Red, 1.5), New PointF(1, 1), New PointF(10, 10))
        e.Graphics.DrawLine(New Pen(Color.Red, 1.5), New PointF(1, 10), New PointF(10, 1))
    End Sub
End Class
