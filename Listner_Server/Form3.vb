Public Class Form3
    Dim x, y As Integer
    Dim loc As Object
    Dim loc2 As Object
    Dim speechobject
    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        y = Screen.PrimaryScreen.WorkingArea.Height




        loc = Screen.PrimaryScreen.WorkingArea.Location.X
        loc2 = Screen.PrimaryScreen.WorkingArea.Location.Y



        Me.Location = New Point(loc, y)
        Me.TopMost = True
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Not y <= Screen.PrimaryScreen.WorkingArea.Height - Me.Height Then
            y -= 5
            Me.Location = New Point(loc, y)
        Else
            'HACX XCODER

            speechobject = CreateObject("sapi.spvoice")
            speechobject.speak("Welcome to Blue Shades RAT , Programmed by saher blue eagle ")
            Threading.Thread.Sleep(1000)
            Me.Close()
        End If
        'HACX XCODER
    End Sub
End Class