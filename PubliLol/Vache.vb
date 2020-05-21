Public Class Vache
    Private Sub Vache_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Vache_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim Tander2 As New Tander
            Tander2.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Porc11 As New porc
        Porc11.Show()
    End Sub
End Class