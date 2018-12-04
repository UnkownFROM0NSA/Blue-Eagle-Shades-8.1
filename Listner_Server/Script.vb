Public Class Script

    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        If TextBox1.Text.Replace(" ", "") = "" Then
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Script_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "" : TextBox1.Focus()
    End Sub
    Public ReadOnly Property scriptText
        Get
            Return TextBox1.Text
        End Get
    End Property
End Class