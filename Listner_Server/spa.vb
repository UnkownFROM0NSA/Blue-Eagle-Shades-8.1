Public Class spa
    Public sock As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form1.s.Send(sock, "tspam" & "||" & TextBox1.Text & "||" & NumericUpDown1.Value / 1000)
    End Sub
End Class