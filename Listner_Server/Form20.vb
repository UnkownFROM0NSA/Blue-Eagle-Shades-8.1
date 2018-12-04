Imports Microsoft.Win32

Public Class Form20
    Public progname As String
    Public sock As Integer

    Private Sub Form20_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Form1.s.Send(sock, "openinstall")
    End Sub

    Private Sub UnistallChangerProgramToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UnistallChangerProgramToolStripMenuItem.Click
        progname = ProgramsLvw.FocusedItem.Text

        Form15.Show()
        Form15.TextBox1.Text = progname
    End Sub

    Private Sub ProgramsLvw_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ProgramsLvw.SelectedIndexChanged
        Form15.TextBox1.Text = ProgramsLvw.FocusedItem.Text
    End Sub
End Class