Public Class Tutu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Poids12 As New poids
        Poids12.Show()
    End Sub

    Private Sub Tutu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tutu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim poison13 As New poison
            poison13.Show()
        End If
    End Sub
End Class