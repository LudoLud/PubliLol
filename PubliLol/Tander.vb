Public Class Tander
    Private Sub Tander_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tander_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim Vache2 As New Vache
            Vache2.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Basic10 As New Tutu
        Basic10.Show()
    End Sub
End Class