Public Class vraipoison
    Private Sub vraipoison_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub vraipoison_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim vraipoison2 As New vraipoison
            vraipoison2.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim poids2 As New poids
        poids2.Show()
    End Sub
End Class