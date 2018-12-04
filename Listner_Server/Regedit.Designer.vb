<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regedit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Regedit))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_CLASSES_ROOT")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_CURRENT_USER")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_LOCAL_MACHINE")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_USERS")
        Me.l1 = New System.Windows.Forms.ImageList(Me.components)
        Me.crgk = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.crg = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackShadesNetForm1 = New Blackshades.BlackShadesNetForm()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RGLIST = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RGk = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pr = New System.Windows.Forms.ToolStripProgressBar()
        Me.crgk.SuspendLayout()
        Me.crg.SuspendLayout()
        Me.BlackShadesNetForm1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'l1
        '
        Me.l1.ImageStream = CType(resources.GetObject("l1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.l1.TransparentColor = System.Drawing.Color.Transparent
        Me.l1.Images.SetKeyName(0, "R_1.png")
        Me.l1.Images.SetKeyName(1, "R_3.png")
        Me.l1.Images.SetKeyName(2, "R_2.png")
        '
        'crgk
        '
        Me.crgk.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.CreateKeyToolStripMenuItem, Me.DeleteKeyToolStripMenuItem})
        Me.crgk.Name = "crgk"
        Me.crgk.Size = New System.Drawing.Size(128, 70)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.RefreshToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'CreateKeyToolStripMenuItem
        '
        Me.CreateKeyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CreateKeyToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.CreateKeyToolStripMenuItem.Name = "CreateKeyToolStripMenuItem"
        Me.CreateKeyToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CreateKeyToolStripMenuItem.Text = "CreateKey"
        '
        'DeleteKeyToolStripMenuItem
        '
        Me.DeleteKeyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DeleteKeyToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.DeleteKeyToolStripMenuItem.Image = CType(resources.GetObject("DeleteKeyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteKeyToolStripMenuItem.Name = "DeleteKeyToolStripMenuItem"
        Me.DeleteKeyToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.DeleteKeyToolStripMenuItem.Text = "DeleteKey"
        '
        'crg
        '
        Me.crg.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem1, Me.EditToolStripMenuItem, Me.NewValueToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.crg.Name = "crg"
        Me.crg.Size = New System.Drawing.Size(127, 92)
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.RefreshToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime
        Me.RefreshToolStripMenuItem1.Image = CType(resources.GetObject("RefreshToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.RefreshToolStripMenuItem1.Text = "Refresh"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'NewValueToolStripMenuItem
        '
        Me.NewValueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.NewValueToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.NewValueToolStripMenuItem.Image = CType(resources.GetObject("NewValueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewValueToolStripMenuItem.Name = "NewValueToolStripMenuItem"
        Me.NewValueToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.NewValueToolStripMenuItem.Text = "NewValue"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'BlackShadesNetForm1
        '
        Me.BlackShadesNetForm1.CloseButtonExitsApp = False
        Me.BlackShadesNetForm1.Controls.Add(Me.Panel3)
        Me.BlackShadesNetForm1.Controls.Add(Me.Panel2)
        Me.BlackShadesNetForm1.Controls.Add(Me.Panel1)
        Me.BlackShadesNetForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlackShadesNetForm1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BlackShadesNetForm1.Location = New System.Drawing.Point(0, 0)
        Me.BlackShadesNetForm1.MinimizeButton = True
        Me.BlackShadesNetForm1.Name = "BlackShadesNetForm1"
        Me.BlackShadesNetForm1.Size = New System.Drawing.Size(855, 470)
        Me.BlackShadesNetForm1.TabIndex = 2
        Me.BlackShadesNetForm1.Text = "Registry Editor"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RGLIST)
        Me.Panel3.Controls.Add(Me.RGk)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(20, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(835, 445)
        Me.Panel3.TabIndex = 4
        '
        'RGLIST
        '
        Me.RGLIST.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.RGLIST.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.RGLIST.ContextMenuStrip = Me.crg
        Me.RGLIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RGLIST.ForeColor = System.Drawing.Color.Lime
        Me.RGLIST.Location = New System.Drawing.Point(212, 0)
        Me.RGLIST.Name = "RGLIST"
        Me.RGLIST.Size = New System.Drawing.Size(623, 445)
        Me.RGLIST.SmallImageList = Me.l1
        Me.RGLIST.TabIndex = 15
        Me.RGLIST.UseCompatibleStateImageBehavior = False
        Me.RGLIST.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 127
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 148
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Value"
        Me.ColumnHeader3.Width = 144
        '
        'RGk
        '
        Me.RGk.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.RGk.ContextMenuStrip = Me.crgk
        Me.RGk.Dock = System.Windows.Forms.DockStyle.Left
        Me.RGk.ForeColor = System.Drawing.Color.Lime
        Me.RGk.ImageIndex = 0
        Me.RGk.ImageList = Me.l1
        Me.RGk.Location = New System.Drawing.Point(0, 0)
        Me.RGk.Name = "RGk"
        TreeNode1.ImageIndex = -2
        TreeNode1.Name = "HKEY_CLASSES_ROOT"
        TreeNode1.Text = "HKEY_CLASSES_ROOT"
        TreeNode2.ImageIndex = -2
        TreeNode2.Name = "HKEY_CURRENT_USER"
        TreeNode2.Text = "HKEY_CURRENT_USER"
        TreeNode3.ImageIndex = -2
        TreeNode3.Name = "HKEY_LOCAL_MACHINE"
        TreeNode3.Text = "HKEY_LOCAL_MACHINE"
        TreeNode4.ImageIndex = -2
        TreeNode4.Name = "HKEY_USERS"
        TreeNode4.Text = "HKEY_USERS"
        Me.RGk.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Me.RGk.SelectedImageIndex = 0
        Me.RGk.Size = New System.Drawing.Size(212, 445)
        Me.RGk.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(20, 445)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 25)
        Me.Panel1.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pr})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 448)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(855, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pr
        '
        Me.pr.Name = "pr"
        Me.pr.Size = New System.Drawing.Size(212, 16)
        '
        'Regedit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 470)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BlackShadesNetForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Regedit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registry Editor"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.crgk.ResumeLayout(False)
        Me.crg.ResumeLayout(False)
        Me.BlackShadesNetForm1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents l1 As System.Windows.Forms.ImageList
    Friend WithEvents crgk As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents crg As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlackShadesNetForm1 As Blackshades.BlackShadesNetForm
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RGLIST As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RGk As System.Windows.Forms.TreeView
    Friend WithEvents pr As System.Windows.Forms.ToolStripProgressBar
End Class
