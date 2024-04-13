Public Class ProgressTimer
    Dim seconds As Decimal = 15

    Private Sub ProgressTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 1000
        ProgressBar1.Step = Timer1.Interval / seconds
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.PerformStep()
            Label1.Text = (ProgressBar1.Value / ProgressBar1.Maximum * 100).ToString("N2") + "%"
        Else
            Timer1.Stop()
        End If
    End Sub
End Class
