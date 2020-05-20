Public Class poids
    Private Sub poids_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub poids_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim wow7 As New wow
            wow7.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim basic6 As New basic
        basic6.Show()
    End Sub
End Class