<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BlackShadesNetForm1 = New Blackshades.BlackShadesNetForm()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BlackShadesNetForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'BlackShadesNetForm1
        '
        Me.BlackShadesNetForm1.CloseButtonExitsApp = False
        Me.BlackShadesNetForm1.Controls.Add(Me.Label3)
        Me.BlackShadesNetForm1.Controls.Add(Me.Label2)
        Me.BlackShadesNetForm1.Controls.Add(Me.Label1)
        Me.BlackShadesNetForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlackShadesNetForm1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BlackShadesNetForm1.Location = New System.Drawing.Point(0, 0)
        Me.BlackShadesNetForm1.MinimizeButton = True
        Me.BlackShadesNetForm1.Name = "BlackShadesNetForm1"
        Me.BlackShadesNetForm1.Size = New System.Drawing.Size(288, 174)
        Me.BlackShadesNetForm1.TabIndex = 0
        Me.BlackShadesNetForm1.Text = "Blue Shades RAT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(26, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "My Best Friend : Cyber Splitter Vbs "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(3, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Version 8.0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(3, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 42)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Programmed By     Saher Blue Eagle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (The Trojaner)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 174)
        Me.Controls.Add(Me.BlackShadesNetForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Blue Shades RAT"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BlackShadesNetForm1.ResumeLayout(False)
        Me.BlackShadesNetForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BlackShadesNetForm1 As Blackshades.BlackShadesNetForm
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
