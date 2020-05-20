Public Class porc
    Private Sub porc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub porc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim poison3 As New poison
            poison3.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vraipoison4 As New vraipoison
        vraipoison4.Show()
    End Sub
End Class