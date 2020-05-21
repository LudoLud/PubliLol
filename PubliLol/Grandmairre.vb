Public Class Grandmairre
    Private Sub Grandmairre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Grandmairre_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class