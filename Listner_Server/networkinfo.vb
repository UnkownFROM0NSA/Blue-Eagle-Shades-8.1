Public Class networkinfo
    Public sock As Integer

    Private Sub networkinfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        Form1.s.Send(sock, "getstat")
    End Sub

    Private Sub RefreshNetworkInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshNetworkInformationToolStripMenuItem.Click
        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        Form1.s.Send(sock, "getstat")
    End Sub
End Class