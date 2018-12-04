<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Script
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
        Me.BlackShadesNetButton1 = New Blackshades.BlackShadesNetButton()
        Me.TextBox1 = New Blackshades.BlackShadesNetMultiLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BlackShadesNetForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BlackShadesNetForm1
        '
        Me.BlackShadesNetForm1.CloseButtonExitsApp = False
        Me.BlackShadesNetForm1.Controls.Add(Me.BlackShadesNetButton1)
        Me.BlackShadesNetForm1.Controls.Add(Me.TextBox1)
        Me.BlackShadesNetForm1.Controls.Add(Me.Label1)
        Me.BlackShadesNetForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlackShadesNetForm1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BlackShadesNetForm1.Location = New System.Drawing.Point(0, 0)
        Me.BlackShadesNetForm1.MinimizeButton = True
        Me.BlackShadesNetForm1.Name = "BlackShadesNetForm1"
        Me.BlackShadesNetForm1.Size = New System.Drawing.Size(329, 270)
        Me.BlackShadesNetForm1.TabIndex = 0
        Me.BlackShadesNetForm1.Text = "Run Script"
        '
        'BlackShadesNetButton1
        '
        Me.BlackShadesNetButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BlackShadesNetButton1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetButton1.ForeColor = System.Drawing.Color.Lime
        Me.BlackShadesNetButton1.Location = New System.Drawing.Point(3, 228)
        Me.BlackShadesNetButton1.Name = "BlackShadesNetButton1"
        Me.BlackShadesNetButton1.Size = New System.Drawing.Size(323, 30)
        Me.BlackShadesNetButton1.TabIndex = 5
        Me.BlackShadesNetButton1.Text = "Run Code"
        Me.BlackShadesNetButton1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(3, 47)
        Me.TextBox1.MaxCharacters = 32767
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(314, 175)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(3, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Script :"
        '
        'Script
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 270)
        Me.Controls.Add(Me.BlackShadesNetForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Script"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Run Script"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BlackShadesNetForm1.ResumeLayout(False)
        Me.BlackShadesNetForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlackShadesNetForm1 As Blackshades.BlackShadesNetForm
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BlackShadesNetButton1 As Blackshades.BlackShadesNetButton
    Friend WithEvents TextBox1 As Blackshades.BlackShadesNetMultiLineTextBox
End Class
