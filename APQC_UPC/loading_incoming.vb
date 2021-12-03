Public Class loading_incoming

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 50
        ElseIf ProgressBar1.Value = 100 Then
            InputIncoming.Show()
            Me.Close()
        End If
    End Sub

    Private Sub loading_incoming_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class