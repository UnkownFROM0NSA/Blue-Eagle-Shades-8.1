<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cap))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.c2 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.p1 = New System.Windows.Forms.PictureBox()
        Me.c1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CyberButton1 = New System.Windows.Forms.Button()
        CType(Me.c, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(423, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Quality :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(130, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Size :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(123, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Interval :"
        '
        'c
        '
        Me.c.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.c.ForeColor = System.Drawing.Color.Blue
        Me.c.Location = New System.Drawing.Point(486, 12)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(43, 20)
        Me.c.TabIndex = 18
        Me.c.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox2.Location = New System.Drawing.Point(365, 27)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox2.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox2.TabIndex = 17
        Me.CheckBox2.Text = "mouse"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'c2
        '
        Me.c2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.c2.ForeColor = System.Drawing.Color.Blue
        Me.c2.FormattingEnabled = True
        Me.c2.Location = New System.Drawing.Point(189, 24)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(164, 21)
        Me.c2.TabIndex = 15
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox1.Location = New System.Drawing.Point(365, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(42, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "line"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.p1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.p1.Location = New System.Drawing.Point(0, 48)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(745, 425)
        Me.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p1.TabIndex = 19
        Me.p1.TabStop = False
        '
        'c1
        '
        Me.c1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.c1.ForeColor = System.Drawing.Color.Blue
        Me.c1.FormattingEnabled = True
        Me.c1.Location = New System.Drawing.Point(189, 0)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(164, 21)
        Me.c1.TabIndex = 14
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(745, 24)
        Me.MenuStrip2.TabIndex = 20
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(745, 24)
        Me.MenuStrip3.TabIndex = 21
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(12, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CyberButton1
        '
        Me.CyberButton1.BackColor = System.Drawing.Color.Black
        Me.CyberButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CyberButton1.ForeColor = System.Drawing.Color.Blue
        Me.CyberButton1.Location = New System.Drawing.Point(544, 9)
        Me.CyberButton1.Name = "CyberButton1"
        Me.CyberButton1.Size = New System.Drawing.Size(94, 23)
        Me.CyberButton1.TabIndex = 26
        Me.CyberButton1.Text = "Save"
        Me.CyberButton1.UseVisualStyleBackColor = False
        '
        'cap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 473)
        Me.Controls.Add(Me.CyberButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.c2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cap"
        Me.Text = "Remote Desktop Controller"
        CType(Me.c, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents c2 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents p1 As System.Windows.Forms.PictureBox
    Friend WithEvents c1 As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CyberButton1 As System.Windows.Forms.Button
End Class
