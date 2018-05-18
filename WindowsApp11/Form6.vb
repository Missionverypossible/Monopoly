Public Class Form6
    Dim result As Integer
    Dim deposit As Integer
    Dim bankaccount As Integer = 1000
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        result = MessageBox.Show("Do you want to visit the bank?", "Bank", MessageBoxButtons.YesNo)
        If DialogResult.Yes Then
            Me.Show()
        ElseIf DialogResult.No Then
            Form2.Show()
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        deposit = NumericUpDown1.Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bankaccount = 1000 - deposit
        Label1.Text = "Your total money in your account is " & bankaccount
        MessageBox.Show("You are leaving bank now.")
        Me.Hide()
        Form2.Show()
    End Sub
End Class