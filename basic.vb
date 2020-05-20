Public Class basic
    Private Sub basic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub basic_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim poison2 As New poison
            poison2.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim porc2 As New porc
        porc2.Show()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        End
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs)
        End
    End Sub
End Class