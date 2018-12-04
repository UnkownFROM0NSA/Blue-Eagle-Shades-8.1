Public Class info
    Public sock As Integer
    Public i As Integer
    Public jj As Integer
    Private Sub info_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Form1.s.Send(sock, "getinfonow")
    End Sub
End Class