Public Class DemoForm
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

    Private Sub DemoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = screenWidth
        Height = screenHeight
        DisplayWidthLabel.Text = Width.ToString()
        DisplayHeightLabel.Text = Height.ToString()
        CenterToScreen()
    End Sub

    Public Sub ChangeFormSize()
        If Width = screenWidth Then
            Width = CInt(3 * screenWidth / 4)
            Height = CInt(screenHeight / 2)
        Else
            Width = screenWidth
            Height = screenHeight
        End If
    End Sub

    Private Sub ResizeButton_Click(sender As Object, e As EventArgs) Handles ResizeButton.Click
        ChangeFormSize()
        CenterToScreen()

        DisplayWidthLabel.Text = Width.ToString()
        DisplayHeightLabel.Text = Height.ToString()
    End Sub
End Class
