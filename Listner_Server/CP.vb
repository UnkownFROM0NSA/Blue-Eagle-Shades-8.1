Public Class CP
    Public sock As Integer
    Private Sub GetClipBoardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GetClipBoardToolStripMenuItem.Click
        Form1.s.Send(sock, "getcli")
    End Sub
End Class