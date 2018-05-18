Public Class Form1
    Public man As Boolean = False
    Public girl As String = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Choose your Character"
        MessageBox.Show("Choose the character you want to play with.", "Choose Your Character")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        man = True
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        girl = True
        Form2.Show()
        Me.Hide()
    End Sub
End Class
