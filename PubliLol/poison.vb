Public Class poison
    Private Sub poison_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub poison_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim wow2 As New wow
            wow2.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Vache As New Vache
        Vache.Show()
    End Sub
End Class