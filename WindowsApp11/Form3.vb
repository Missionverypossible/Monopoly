Public Class RollDice
    Public roll As Integer
    Dim rolltotal As Integer
    Dim dice1 As Bitmap
    Dim dice2 As Bitmap
    Dim dice3 As Bitmap
    Dim dice4 As Bitmap
    Dim dice5 As Bitmap
    Dim dice6 As Bitmap
    Dim rnd As New Random
    Public judgement As Boolean = False
    Dim result As Integer

    Private Sub BtnRollDice_Click(sender As Object, e As EventArgs) Handles BtnRollDice.Click
        roll = rnd.Next(1, 7)
        PicDice1.Show()
        PicDice2.Show()
        PicDice3.Show()
        PicDice4.Show()
        PicDice5.Show()
        PicDice6.Show()
        If roll = 1 Then
            PicDice6.Hide()
            PicDice2.Hide()
            PicDice3.Hide()
            PicDice5.Hide()
            PicDice4.Hide()
        ElseIf roll = 2 Then
            dice2 = My.Resources.dice2
            PicDice6.Hide()
            PicDice1.Hide()
            PicDice3.Hide()
            PicDice5.Hide()
            PicDice4.Hide()
        ElseIf roll = 3 Then
            dice3 = My.Resources.dice3
            PicDice6.Hide()
            PicDice2.Hide()
            PicDice1.Hide()
            PicDice5.Hide()
            PicDice6.Hide()
            PicDice4.Hide()
        ElseIf roll = 4 Then
            dice4 = My.Resources.dice4
            PicDice6.Hide()
            PicDice2.Hide()
            PicDice3.Hide()
            PicDice5.Hide()
            PicDice1.Hide()
        ElseIf roll = 5 Then
            dice5 = My.Resources.dice5
            PicDice6.Hide()
            PicDice2.Hide()
            PicDice3.Hide()
            PicDice1.Hide()
            PicDice4.Hide()
        ElseIf roll = 6 Then
            dice6 = My.Resources.dice6
            PicDice1.Hide()
            PicDice2.Hide()
            PicDice3.Hide()
            PicDice5.Hide()
            PicDice4.Hide()
        End If
        lbltotal.Text = roll
        result = MessageBox.Show("You rolled a " & roll, "Roll Dice", MessageBoxButtons.OK)
        If result = DialogResult.OK Then
            judgement = True
        End If
        Me.Hide()
        Form2.Show()
    End Sub
End Class