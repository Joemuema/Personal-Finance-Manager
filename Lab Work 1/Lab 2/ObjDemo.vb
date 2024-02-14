Public Class ObjDemo
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            If CheckBox1.Checked Or CheckBox3.Checked Then
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Bold Or FontStyle.Italic)
            Else
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Bold)
            End If
        Else
            If CheckBox1.Checked Then
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Italic)
            ElseIf CheckBox3.Checked Then
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Bold Or FontStyle.Italic)
            Else
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Regular)
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            If CheckBox2.Checked Or CheckBox3.Checked Then
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Bold Or FontStyle.Italic)
            Else
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Italic)
            End If
        Else
            If CheckBox2.Checked Then
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Bold)
            ElseIf CheckBox3.Checked Then
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Bold Or FontStyle.Italic)
            Else
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Regular)
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Bold Or FontStyle.Italic)
        Else
            If CheckBox1.Checked And CheckBox2.Checked Then
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Bold Or FontStyle.Italic)
            ElseIf CheckBox1.Checked Then
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Italic)
            ElseIf CheckBox2.Checked Then
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Bold)
            Else
                TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Regular)
                End If
            End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox1.Font = New Font("Garamond", TextBox1.Font.Size, TextBox1.Font.Style)
        Else
            TextBox1.Font = New Font("Segoe UI", TextBox1.Font.Size, TextBox1.Font.Style)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TextBox1.Font = New Font("Magneto", TextBox1.Font.Size, TextBox1.Font.Style)
        Else
            TextBox1.Font = New Font("Segoe UI", TextBox1.Font.Size, TextBox1.Font.Style)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            TextBox1.Font = New Font("Tahoma", TextBox1.Font.Size, TextBox1.Font.Style)
        Else
            TextBox1.Font = New Font("Segoe UI", TextBox1.Font.Size, TextBox1.Font.Style)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox1.ForeColor = Color.Green
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TextBox1.ForeColor = Color.Blue
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            TextBox1.ForeColor = Color.Red
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (.jpg; *.jpeg; *.png; *.bmp)|.jpg; *.jpeg; *.png; *.bmp"
        openFileDialog.FilterIndex = 1

        openFileDialog.Multiselect = False

        Dim userClickedOK As DialogResult = openFileDialog.ShowDialog()
        If userClickedOK = DialogResult.OK Then
            Try
                Dim filePath As String = openFileDialog.FileName
                Dim image As New Bitmap(filePath)
                PictureBox1.Image = image
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (.jpg; *.jpeg; *.png; *.bmp)|.jpg; *.jpeg; *.png; *.bmp"
        openFileDialog.FilterIndex = 1

        openFileDialog.Multiselect = False

        Dim userClickedOK As DialogResult = openFileDialog.ShowDialog()
        If userClickedOK = DialogResult.OK Then
            Try
                Dim filePath As String = openFileDialog.FileName
                Dim image As New Bitmap(filePath)
                PictureBox1.Image = image
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub
End Class