Public Class Start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button2.Visible = False
        Me.ShowInTaskbar = False
        Label1.Visible = False
        basic.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Start_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        End
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        Dim ask As MsgBoxResult = MsgBox("Quitter PubliLol?", MsgBoxStyle.YesNo, "Quitter PubliLol")
        If ask = MsgBoxResult.Yes Then
            End

        End If
    End Sub
End Class