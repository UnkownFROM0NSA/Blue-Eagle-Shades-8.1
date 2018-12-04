<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm))
        Me.BlackShadesNetForm1 = New Blackshades.BlackShadesNetForm()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestroyFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayMusicInHiddenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViweeditTextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrypteDecryptTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAsWallpaperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowPicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompressRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BlackShadesNetButton3 = New Blackshades.BlackShadesNetButton()
        Me.BlackShadesNetButton2 = New Blackshades.BlackShadesNetButton()
        Me.BlackShadesNetButton1 = New Blackshades.BlackShadesNetButton()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BlackShadesNetButton10 = New Blackshades.BlackShadesNetButton()
        Me.BlackShadesNetButton11 = New Blackshades.BlackShadesNetButton()
        Me.BlackShadesNetButton8 = New Blackshades.BlackShadesNetButton()
        Me.BlackShadesNetButton9 = New Blackshades.BlackShadesNetButton()
        Me.BlackShadesNetButton6 = New Blackshades.BlackShadesNetButton()
        Me.BlackShadesNetButton7 = New Blackshades.BlackShadesNetButton()
        Me.BlackShadesNetButton5 = New Blackshades.BlackShadesNetButton()
        Me.BlackShadesNetButton4 = New Blackshades.BlackShadesNetButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BlackShadesNetForm1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BlackShadesNetForm1
        '
        Me.BlackShadesNetForm1.CloseButtonExitsApp = False
        Me.BlackShadesNetForm1.Controls.Add(Me.Panel5)
        Me.BlackShadesNetForm1.Controls.Add(Me.Panel4)
        Me.BlackShadesNetForm1.Controls.Add(Me.Panel3)
        Me.BlackShadesNetForm1.Controls.Add(Me.Panel2)
        Me.BlackShadesNetForm1.Controls.Add(Me.Panel1)
        Me.BlackShadesNetForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlackShadesNetForm1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BlackShadesNetForm1.Location = New System.Drawing.Point(0, 0)
        Me.BlackShadesNetForm1.MinimizeButton = True
        Me.BlackShadesNetForm1.Name = "BlackShadesNetForm1"
        Me.BlackShadesNetForm1.Size = New System.Drawing.Size(860, 517)
        Me.BlackShadesNetForm1.TabIndex = 0
        Me.BlackShadesNetForm1.Text = "FileManager"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ListView1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(253, 130)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(607, 387)
        Me.Panel5.TabIndex = 25
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(607, 387)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 465
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Size"
        Me.ColumnHeader2.Width = 136
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunToolStripMenuItem, Me.RenameToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.UpToolStripMenuItem, Me.DownToolStripMenuItem, Me.OpToolStripMenuItem, Me.DestroyFileToolStripMenuItem, Me.HideFileToolStripMenuItem, Me.ShowFileToolStripMenuItem, Me.NewFolderToolStripMenuItem, Me.PlayMusicInHiddenToolStripMenuItem, Me.NewTextFileToolStripMenuItem, Me.ViweeditTextFileToolStripMenuItem, Me.CrypteDecryptTextToolStripMenuItem, Me.SetAsWallpaperToolStripMenuItem, Me.ShowPicToolStripMenuItem, Me.CompressRARToolStripMenuItem, Me.DecToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(202, 400)
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.RunToolStripMenuItem.Image = CType(resources.GetObject("RunToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.RenameToolStripMenuItem.Image = CType(resources.GetObject("RenameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete "
        '
        'UpToolStripMenuItem
        '
        Me.UpToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.UpToolStripMenuItem.Name = "UpToolStripMenuItem"
        Me.UpToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.UpToolStripMenuItem.Text = "Upload"
        '
        'DownToolStripMenuItem
        '
        Me.DownToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.DownToolStripMenuItem.Name = "DownToolStripMenuItem"
        Me.DownToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DownToolStripMenuItem.Text = "Download"
        '
        'OpToolStripMenuItem
        '
        Me.OpToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.OpToolStripMenuItem.Name = "OpToolStripMenuItem"
        Me.OpToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.OpToolStripMenuItem.Text = "Open Downloads Folder"
        '
        'DestroyFileToolStripMenuItem
        '
        Me.DestroyFileToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.DestroyFileToolStripMenuItem.Name = "DestroyFileToolStripMenuItem"
        Me.DestroyFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DestroyFileToolStripMenuItem.Text = "Destroy file"
        '
        'HideFileToolStripMenuItem
        '
        Me.HideFileToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.HideFileToolStripMenuItem.Name = "HideFileToolStripMenuItem"
        Me.HideFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.HideFileToolStripMenuItem.Text = "Hide File "
        '
        'ShowFileToolStripMenuItem
        '
        Me.ShowFileToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.ShowFileToolStripMenuItem.Name = "ShowFileToolStripMenuItem"
        Me.ShowFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ShowFileToolStripMenuItem.Text = "Show File"
        '
        'NewFolderToolStripMenuItem
        '
        Me.NewFolderToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.NewFolderToolStripMenuItem.Name = "NewFolderToolStripMenuItem"
        Me.NewFolderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.NewFolderToolStripMenuItem.Text = "New Folder "
        '
        'PlayMusicInHiddenToolStripMenuItem
        '
        Me.PlayMusicInHiddenToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.PlayMusicInHiddenToolStripMenuItem.Name = "PlayMusicInHiddenToolStripMenuItem"
        Me.PlayMusicInHiddenToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.PlayMusicInHiddenToolStripMenuItem.Text = "Play Music In Hidden"
        '
        'NewTextFileToolStripMenuItem
        '
        Me.NewTextFileToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.NewTextFileToolStripMenuItem.Name = "NewTextFileToolStripMenuItem"
        Me.NewTextFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.NewTextFileToolStripMenuItem.Text = "New Text File"
        '
        'ViweeditTextFileToolStripMenuItem
        '
        Me.ViweeditTextFileToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.ViweeditTextFileToolStripMenuItem.Name = "ViweeditTextFileToolStripMenuItem"
        Me.ViweeditTextFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ViweeditTextFileToolStripMenuItem.Text = "View/Edit Text"
        '
        'CrypteDecryptTextToolStripMenuItem
        '
        Me.CrypteDecryptTextToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.CrypteDecryptTextToolStripMenuItem.Name = "CrypteDecryptTextToolStripMenuItem"
        Me.CrypteDecryptTextToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CrypteDecryptTextToolStripMenuItem.Text = "Crypte/Decrypt Text"
        '
        'SetAsWallpaperToolStripMenuItem
        '
        Me.SetAsWallpaperToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.SetAsWallpaperToolStripMenuItem.Name = "SetAsWallpaperToolStripMenuItem"
        Me.SetAsWallpaperToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SetAsWallpaperToolStripMenuItem.Text = "Set as Wallpaper"
        '
        'ShowPicToolStripMenuItem
        '
        Me.ShowPicToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.ShowPicToolStripMenuItem.Name = "ShowPicToolStripMenuItem"
        Me.ShowPicToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ShowPicToolStripMenuItem.Text = "Show Pic"
        '
        'CompressRARToolStripMenuItem
        '
        Me.CompressRARToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.CompressRARToolStripMenuItem.Image = CType(resources.GetObject("CompressRARToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CompressRARToolStripMenuItem.Name = "CompressRARToolStripMenuItem"
        Me.CompressRARToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CompressRARToolStripMenuItem.Text = "Compress (RAR)"
        '
        'DecToolStripMenuItem
        '
        Me.DecToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.DecToolStripMenuItem.Image = CType(resources.GetObject("DecToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DecToolStripMenuItem.Name = "DecToolStripMenuItem"
        Me.DecToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DecToolStripMenuItem.Text = "Decompress (UNRAR)"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel4.Controls.Add(Me.BlackShadesNetButton3)
        Me.Panel4.Controls.Add(Me.BlackShadesNetButton2)
        Me.Panel4.Controls.Add(Me.BlackShadesNetButton1)
        Me.Panel4.Controls.Add(Me.pic1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(17, 130)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(236, 387)
        Me.Panel4.TabIndex = 24
        '
        'BlackShadesNetButton3
        '
        Me.BlackShadesNetButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton3.ForeColor = System.Drawing.Color.Lime
        Me.BlackShadesNetButton3.Location = New System.Drawing.Point(0, 341)
        Me.BlackShadesNetButton3.Name = "BlackShadesNetButton3"
        Me.BlackShadesNetButton3.Size = New System.Drawing.Size(236, 44)
        Me.BlackShadesNetButton3.TabIndex = 23
        Me.BlackShadesNetButton3.Text = "List View"
        Me.BlackShadesNetButton3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BlackShadesNetButton2
        '
        Me.BlackShadesNetButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton2.ForeColor = System.Drawing.Color.Lime
        Me.BlackShadesNetButton2.Location = New System.Drawing.Point(0, 291)
        Me.BlackShadesNetButton2.Name = "BlackShadesNetButton2"
        Me.BlackShadesNetButton2.Size = New System.Drawing.Size(236, 44)
        Me.BlackShadesNetButton2.TabIndex = 22
        Me.BlackShadesNetButton2.Text = "Details View"
        Me.BlackShadesNetButton2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BlackShadesNetButton1
        '
        Me.BlackShadesNetButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton1.ForeColor = System.Drawing.Color.Lime
        Me.BlackShadesNetButton1.Location = New System.Drawing.Point(0, 241)
        Me.BlackShadesNetButton1.Name = "BlackShadesNetButton1"
        Me.BlackShadesNetButton1.Size = New System.Drawing.Size(233, 44)
        Me.BlackShadesNetButton1.TabIndex = 21
        Me.BlackShadesNetButton1.Text = "Large Icons View"
        Me.BlackShadesNetButton1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.Transparent
        Me.pic1.BackgroundImage = CType(resources.GetObject("pic1.BackgroundImage"), System.Drawing.Image)
        Me.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic1.Location = New System.Drawing.Point(0, 0)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(236, 234)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 20
        Me.pic1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.BlackShadesNetButton10)
        Me.Panel3.Controls.Add(Me.BlackShadesNetButton11)
        Me.Panel3.Controls.Add(Me.BlackShadesNetButton8)
        Me.Panel3.Controls.Add(Me.BlackShadesNetButton9)
        Me.Panel3.Controls.Add(Me.BlackShadesNetButton6)
        Me.Panel3.Controls.Add(Me.BlackShadesNetButton7)
        Me.Panel3.Controls.Add(Me.BlackShadesNetButton5)
        Me.Panel3.Controls.Add(Me.BlackShadesNetButton4)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(17, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(843, 103)
        Me.Panel3.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Quck Paths"
        '
        'BlackShadesNetButton10
        '
        Me.BlackShadesNetButton10.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton10.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton10.ForeColor = System.Drawing.Color.White
        Me.BlackShadesNetButton10.Location = New System.Drawing.Point(221, 78)
        Me.BlackShadesNetButton10.Name = "BlackShadesNetButton10"
        Me.BlackShadesNetButton10.Size = New System.Drawing.Size(119, 25)
        Me.BlackShadesNetButton10.TabIndex = 32
        Me.BlackShadesNetButton10.Text = "MyPictures"
        Me.BlackShadesNetButton10.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BlackShadesNetButton11
        '
        Me.BlackShadesNetButton11.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton11.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton11.ForeColor = System.Drawing.Color.White
        Me.BlackShadesNetButton11.Location = New System.Drawing.Point(96, 78)
        Me.BlackShadesNetButton11.Name = "BlackShadesNetButton11"
        Me.BlackShadesNetButton11.Size = New System.Drawing.Size(119, 25)
        Me.BlackShadesNetButton11.TabIndex = 31
        Me.BlackShadesNetButton11.Text = "MyMusic"
        Me.BlackShadesNetButton11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BlackShadesNetButton8
        '
        Me.BlackShadesNetButton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton8.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton8.ForeColor = System.Drawing.Color.White
        Me.BlackShadesNetButton8.Location = New System.Drawing.Point(721, 49)
        Me.BlackShadesNetButton8.Name = "BlackShadesNetButton8"
        Me.BlackShadesNetButton8.Size = New System.Drawing.Size(119, 25)
        Me.BlackShadesNetButton8.TabIndex = 30
        Me.BlackShadesNetButton8.Text = "My Documents"
        Me.BlackShadesNetButton8.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BlackShadesNetButton9
        '
        Me.BlackShadesNetButton9.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton9.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton9.ForeColor = System.Drawing.Color.White
        Me.BlackShadesNetButton9.Location = New System.Drawing.Point(596, 49)
        Me.BlackShadesNetButton9.Name = "BlackShadesNetButton9"
        Me.BlackShadesNetButton9.Size = New System.Drawing.Size(119, 25)
        Me.BlackShadesNetButton9.TabIndex = 29
        Me.BlackShadesNetButton9.Text = "Temp"
        Me.BlackShadesNetButton9.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BlackShadesNetButton6
        '
        Me.BlackShadesNetButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton6.ForeColor = System.Drawing.Color.White
        Me.BlackShadesNetButton6.Location = New System.Drawing.Point(471, 49)
        Me.BlackShadesNetButton6.Name = "BlackShadesNetButton6"
        Me.BlackShadesNetButton6.Size = New System.Drawing.Size(119, 25)
        Me.BlackShadesNetButton6.TabIndex = 28
        Me.BlackShadesNetButton6.Text = "Desktop"
        Me.BlackShadesNetButton6.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BlackShadesNetButton7
        '
        Me.BlackShadesNetButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton7.ForeColor = System.Drawing.Color.White
        Me.BlackShadesNetButton7.Location = New System.Drawing.Point(346, 49)
        Me.BlackShadesNetButton7.Name = "BlackShadesNetButton7"
        Me.BlackShadesNetButton7.Size = New System.Drawing.Size(119, 25)
        Me.BlackShadesNetButton7.TabIndex = 27
        Me.BlackShadesNetButton7.Text = "History"
        Me.BlackShadesNetButton7.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BlackShadesNetButton5
        '
        Me.BlackShadesNetButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton5.ForeColor = System.Drawing.Color.White
        Me.BlackShadesNetButton5.Location = New System.Drawing.Point(221, 49)
        Me.BlackShadesNetButton5.Name = "BlackShadesNetButton5"
        Me.BlackShadesNetButton5.Size = New System.Drawing.Size(119, 25)
        Me.BlackShadesNetButton5.TabIndex = 26
        Me.BlackShadesNetButton5.Text = "Recent"
        Me.BlackShadesNetButton5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BlackShadesNetButton4
        '
        Me.BlackShadesNetButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton4.ForeColor = System.Drawing.Color.White
        Me.BlackShadesNetButton4.Location = New System.Drawing.Point(96, 49)
        Me.BlackShadesNetButton4.Name = "BlackShadesNetButton4"
        Me.BlackShadesNetButton4.Size = New System.Drawing.Size(119, 25)
        Me.BlackShadesNetButton4.TabIndex = 24
        Me.BlackShadesNetButton4.Text = "Startup"
        Me.BlackShadesNetButton4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(6, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(744, 20)
        Me.TextBox1.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(756, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Physical Path"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(17, 490)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 27)
        Me.Panel1.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "0.png")
        Me.ImageList1.Images.SetKeyName(1, "1.png")
        Me.ImageList1.Images.SetKeyName(2, "2.png")
        Me.ImageList1.Images.SetKeyName(3, "3.png")
        Me.ImageList1.Images.SetKeyName(4, "4.png")
        Me.ImageList1.Images.SetKeyName(5, "5.png")
        Me.ImageList1.Images.SetKeyName(6, "6.png")
        Me.ImageList1.Images.SetKeyName(7, "7.png")
        Me.ImageList1.Images.SetKeyName(8, "8.png")
        '
        'fm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 517)
        Me.Controls.Add(Me.BlackShadesNetForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileManager"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BlackShadesNetForm1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlackShadesNetForm1 As Blackshades.BlackShadesNetForm
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents BlackShadesNetButton3 As Blackshades.BlackShadesNetButton
    Friend WithEvents BlackShadesNetButton2 As Blackshades.BlackShadesNetButton
    Friend WithEvents BlackShadesNetButton1 As Blackshades.BlackShadesNetButton
    Friend WithEvents BlackShadesNetButton5 As Blackshades.BlackShadesNetButton
    Friend WithEvents BlackShadesNetButton4 As Blackshades.BlackShadesNetButton
    Friend WithEvents BlackShadesNetButton10 As Blackshades.BlackShadesNetButton
    Friend WithEvents BlackShadesNetButton11 As Blackshades.BlackShadesNetButton
    Friend WithEvents BlackShadesNetButton8 As Blackshades.BlackShadesNetButton
    Friend WithEvents BlackShadesNetButton9 As Blackshades.BlackShadesNetButton
    Friend WithEvents BlackShadesNetButton6 As Blackshades.BlackShadesNetButton
    Friend WithEvents BlackShadesNetButton7 As Blackshades.BlackShadesNetButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DestroyFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayMusicInHiddenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViweeditTextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrypteDecryptTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAsWallpaperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowPicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompressRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
