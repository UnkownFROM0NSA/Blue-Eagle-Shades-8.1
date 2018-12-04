Public Class Information
    Public sock As Integer

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim writer As New IO.StreamWriter(SaveFileDialog1.FileName)
        writer.Write(rtinfo.Text & rtinfo1.Text & rtinfo2.Text)
        writer.Close()
    End Sub

    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        SaveFileDialog1.Filter = " Text Documents (*.txt)|*.txt"
        SaveFileDialog1.Title = "Save Your Txt .. Choose Your Place"
        SaveFileDialog1.ShowDialog()
    End Sub
End Class