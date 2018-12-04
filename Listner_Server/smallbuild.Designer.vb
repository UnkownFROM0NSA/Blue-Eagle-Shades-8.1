<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class smallbuild
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
        Me.BlackShadesNetForm1 = New Blackshades.BlackShadesNetForm()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New Blackshades.BlackShadesNetTextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BlackShadesNetButton1 = New Blackshades.BlackShadesNetButton()
        Me.TextBox2 = New Blackshades.BlackShadesNetTextBox()
        Me.TextBox1 = New Blackshades.BlackShadesNetTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BlackShadesNetForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BlackShadesNetForm1
        '
        Me.BlackShadesNetForm1.CloseButtonExitsApp = False
        Me.BlackShadesNetForm1.Controls.Add(Me.Label4)
        Me.BlackShadesNetForm1.Controls.Add(Me.Label3)
        Me.BlackShadesNetForm1.Controls.Add(Me.TextBox3)
        Me.BlackShadesNetForm1.Controls.Add(Me.ListBox1)
        Me.BlackShadesNetForm1.Controls.Add(Me.Label2)
        Me.BlackShadesNetForm1.Controls.Add(Me.Label1)
        Me.BlackShadesNetForm1.Controls.Add(Me.BlackShadesNetButton1)
        Me.BlackShadesNetForm1.Controls.Add(Me.TextBox2)
        Me.BlackShadesNetForm1.Controls.Add(Me.TextBox1)
        Me.BlackShadesNetForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlackShadesNetForm1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BlackShadesNetForm1.Location = New System.Drawing.Point(0, 0)
        Me.BlackShadesNetForm1.MinimizeButton = True
        Me.BlackShadesNetForm1.Name = "BlackShadesNetForm1"
        Me.BlackShadesNetForm1.Size = New System.Drawing.Size(330, 262)
        Me.BlackShadesNetForm1.TabIndex = 0
        Me.BlackShadesNetForm1.Text = "Small Server Builder"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(3, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Victim Name "
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(79, 89)
        Me.TextBox3.MaxLength = 32767
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(187, 24)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox3.UseSystemPasswordChar = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ForeColor = System.Drawing.Color.Lime
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(0, 163)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(324, 96)
        Me.ListBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Port "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(3, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Host [No-IP]"
        '
        'BlackShadesNetButton1
        '
        Me.BlackShadesNetButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton1.ForeColor = System.Drawing.Color.White
        Me.BlackShadesNetButton1.Location = New System.Drawing.Point(272, 29)
        Me.BlackShadesNetButton1.Name = "BlackShadesNetButton1"
        Me.BlackShadesNetButton1.Size = New System.Drawing.Size(52, 84)
        Me.BlackShadesNetButton1.TabIndex = 4
        Me.BlackShadesNetButton1.Text = "Build Server"
        Me.BlackShadesNetButton1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(79, 59)
        Me.TextBox2.MaxLength = 32767
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(187, 24)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox2.UseSystemPasswordChar = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(79, 29)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 24)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(3, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 48)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Note : You will only be able to open filemanager " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "open remote desktop , open key" & _
    "logger " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and Fun manager "
        '
        'smallbuild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 262)
        Me.Controls.Add(Me.BlackShadesNetForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "smallbuild"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Small Server Builder"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BlackShadesNetForm1.ResumeLayout(False)
        Me.BlackShadesNetForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlackShadesNetForm1 As Blackshades.BlackShadesNetForm
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BlackShadesNetButton1 As Blackshades.BlackShadesNetButton
    Friend WithEvents TextBox2 As Blackshades.BlackShadesNetTextBox
    Friend WithEvents TextBox1 As Blackshades.BlackShadesNetTextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As Blackshades.BlackShadesNetTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
