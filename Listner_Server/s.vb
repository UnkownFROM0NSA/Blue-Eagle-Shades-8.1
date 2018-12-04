Public Class s
    Dim x, y As Integer

    Private Sub s_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim speechobject
        speechobject = CreateObject("sapi.spvoice")
        speechobject.speak("New client Connected ")



        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        y = Screen.PrimaryScreen.WorkingArea.Height
        Me.Location = New Point(x, y)
        Me.TopMost = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        If Not y <= Screen.PrimaryScreen.WorkingArea.Height - Me.Height Then
            y -= 90
            Me.Location = New Point(x, y)
        Else
            Threading.Thread.Sleep(500)
            Me.Close()
        End If
    End Sub
End Class