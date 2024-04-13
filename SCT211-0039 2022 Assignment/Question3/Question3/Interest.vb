Public Class Interest
    Dim years As Integer = 10
    Dim principle As Decimal = 1000000
    Dim interestRate As Decimal = 0.05

    Private Sub Interest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For currentYear As Integer = 1 To years
            InterestListBox.Items.Add("Year " + currentYear.ToString)
        Next
    End Sub

    Private Sub InterestListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InterestListBox.SelectedIndexChanged
        Dim selectedYear As String = InterestListBox.SelectedItem.ToString
        Dim words As String() = selectedYear.Split(New Char() {" "c})
        Dim year As Integer = Integer.Parse(words(1))

        AmountLabel.Text = "Ksh " + (principle * (1 + interestRate) ^ year).ToString("N2")
    End Sub
End Class
