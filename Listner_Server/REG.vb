Public Class REG
    Public sock As Integer

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Button11.Enabled = False
        Form1.s.Send(sock, "startrec")
        Button22.Enabled = True
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        Button11.Enabled = True
        Form1.s.Send(sock, "stoprec")
        Button22.Enabled = False
    End Sub
End Class