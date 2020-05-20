Public Class wow
    Private Sub wow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub wow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim porc8 As New porc
            porc8.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vraipoison9 As New vraipoison
        vraipoison9.Show()
    End Sub
End Class