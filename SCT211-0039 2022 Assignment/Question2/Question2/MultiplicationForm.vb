Public Class MultiplicationForm
    Dim rows As Integer
    Dim maxRow As Integer = 22

    Dim columns As Integer
    Dim maxColumn As Integer = 15

    Dim gap As Integer
    Dim maxGap As Integer = 8

    Public Function ValidateInput() As Boolean
        If Integer.TryParse(factor1TextBox.Text, columns) Then
            If columns > maxColumn Then
                factor1TextBox.Clear()
            End If
        Else
            factor1TextBox.Clear()
        End If

        If Integer.TryParse(factor2TextBox.Text, rows) Then
            If rows > maxRow Then
                factor2TextBox.Clear()
            End If
        Else
            factor2TextBox.Clear()
        End If

        If String.IsNullOrEmpty(factor1TextBox.Text) Or String.IsNullOrEmpty(factor2TextBox.Text) Then
            Return False
        End If

        Return True
    End Function

    Private Sub GenTableButton_Click(sender As Object, e As EventArgs) Handles GenTableButton.Click
        If ValidateInput() Then
            MultTextBox.Clear()

            For i As Integer = 0 To columns
                gap = maxGap - 2 * CInt(Fix(Math.Log10(i + 1)))

                If i = 0 Then
                    MultTextBox.Text &= "*" + StrDup(gap, " ")
                    Continue For
                End If

                MultTextBox.Text += i.ToString() + StrDup(gap, " ")
            Next

            For i As Integer = 1 To rows
                gap = maxGap - 4 * CInt(Fix(Math.Log10(i)))
                MultTextBox.Text &= Environment.NewLine & i.ToString() + StrDup(gap, " ")

                For j As Integer = 1 To columns
                    gap = maxGap - 2 * CInt(Fix(Math.Log10(i * (j + 1))))
                    MultTextBox.Text += (i * j).ToString() + StrDup(gap, " ")
                Next
            Next
        End If
    End Sub

End Class
