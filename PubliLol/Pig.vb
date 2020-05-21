Public Class Pig
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Pig15 As New Pig
        Pig15.Show()
    End Sub

    Private Sub Pig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Pig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim Tander14 As New Tander
            Tander14.Show()
        End If
    End Sub
End Class