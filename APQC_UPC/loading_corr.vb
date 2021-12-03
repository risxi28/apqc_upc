Public Class loading_corr

    Private Sub loading_corr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 50
        ElseIf ProgressBar1.Value = 100 Then
            InputCorr.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
       
    End Sub
End Class