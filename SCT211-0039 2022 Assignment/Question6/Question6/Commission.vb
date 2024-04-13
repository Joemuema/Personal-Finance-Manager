Public Class Commission
    Dim SalesArr(9, 6) As Decimal
    Dim basePay As Decimal = 2500
    Dim quota As Decimal = 1000
    Dim commissionRate As Decimal = 0.15
    Private Sub Commission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For day As Integer = 1 To 7
            WeekListBox.Items.Add("Day " + day.ToString)
        Next
    End Sub

    Private Sub InsertNameButton_Click(sender As Object, e As EventArgs) Handles InsertNameButton.Click
        If String.IsNullOrEmpty(InsertNameTextBox.Text) Then
            MessageBox.Show("Insert the name of the salesperson to add them.", "Missing salesperson name")
            Return
        End If

        If NamesListBox.Items.Count = 10 Then
            MessageBox.Show("Maximum salesperson count is 10. No more can be added.", "Max person count")
            Return
        End If

        Dim nameExists As Boolean
        For i As Integer = 0 To NamesListBox.Items.Count - 1
            If NamesListBox.Items(i) = InsertNameTextBox.Text Then
                nameExists = True
                Exit For
            End If
        Next

        If nameExists Then
            MessageBox.Show("Salesperson already exists. Choose another name.", "Name exists")
        Else
            NamesListBox.Items.Add(InsertNameTextBox.Text)
            InsertNameTextBox.Clear()
        End If
    End Sub

    Private Sub RecordSalesButton_Click(sender As Object, e As EventArgs) Handles RecordSalesButton.Click
        If NamesListBox.Items.Count = 0 Then
            MessageBox.Show("Insert salespersons in the list and select them to record their sales.", "No salespersons available")
        ElseIf String.IsNullOrEmpty(RecordSalesTextBox.Text) Then
            MessageBox.Show("Insert the sales made by the selected salesperson on the selected sales day.", "Missing sales")
        Else
            If Not Decimal.TryParse(RecordSalesTextBox.Text, SalesArr(NamesListBox.SelectedIndex, WeekListBox.SelectedIndex)) Then
                MessageBox.Show("Sales should be a decimal value.", "Wrong sales value")
            End If
        End If
        RecordSalesTextBox.Clear()
    End Sub

    Private Sub NamesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NamesListBox.SelectedIndexChanged
        NameTextBox.Text = NamesListBox.SelectedItems(0).ToString

        DaySalesTextBox.Clear()
        WeekSalesTextBox.Clear()
        WeekSalaryTextBox.Clear()
    End Sub

    Private Sub WeekListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WeekListBox.SelectedIndexChanged
        DaySalesLabel.Text = WeekListBox.SelectedItems(0).ToString + " sales: "
        DaySalesTextBox.Text = SalesArr(NamesListBox.SelectedIndex, WeekListBox.SelectedIndex).ToString("N2")

        WeekSalesTextBox.Clear()
        WeekSalaryTextBox.Clear()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Dim weekSales As Decimal = 0
        Dim commission As Decimal = 0

        For salesIndex As Integer = 0 To 6
            weekSales += SalesArr(NamesListBox.SelectedIndex, salesIndex)
        Next
        WeekSalesTextBox.Text = weekSales.ToString("N2")

        If weekSales > quota Then
            commission = weekSales * commissionRate
        End If
        WeekSalaryTextBox.Text = (weekSales + commission).ToString("N2")
    End Sub
End Class
