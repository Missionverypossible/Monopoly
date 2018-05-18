Public Class Form7
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

    Private Sub BtnRollDice2_Click(sender As Object, e As EventArgs) Handles BtnRollDice2.Click
        roll = rnd.Next(1, 7)
        Dice6Roll.Show()
        Dice3Roll.Show()
        Dice1Roll.Show()
        Rolldice1.Show()
        Dice5Roll.Show()
        Dice6Roll.Show()
        If roll = 1 Then
            Dice6Roll.Hide()
            Dice2Roll.Hide()
            Dice3Roll.Hide()
            Dice5Roll.Hide()
            Rolldice1.Hide()
        ElseIf roll = 2 Then
            dice2 = My.Resources.dice2
            Dice6Roll.Hide()
            Dice1Roll.Hide()
            Dice3Roll.Hide()
            Dice5Roll.Hide()
            Rolldice1.Hide()
        ElseIf roll = 3 Then
            dice3 = My.Resources.dice3
            Dice6Roll.Hide()
            Dice2Roll.Hide()
            Dice1Roll.Hide()
            Dice5Roll.Hide()
            Dice6Roll.Hide()
            Rolldice1.Hide()
        ElseIf roll = 4 Then
            dice4 = My.Resources.dice4
            Dice6Roll.Hide()
            Dice2Roll.Hide()
            Dice3Roll.Hide()
            Dice5Roll.Hide()
            Dice1Roll.Hide()
        ElseIf roll = 5 Then
            dice5 = My.Resources.dice5
            Dice6Roll.Hide()
            Dice2Roll.Hide()
            Dice3Roll.Hide()
            Dice1Roll.Hide()
            Rolldice1.Hide()
        ElseIf roll = 6 Then
            dice6 = My.Resources.dice6
            Dice1Roll.Hide()
            Dice2Roll.Hide()
            Dice3Roll.Hide()
            Dice5Roll.Hide()
            Rolldice1.Hide()
        End If
        lbltogether.Text = roll
        result = MessageBox.Show("You rolled a " & roll, "Roll Dice", MessageBoxButtons.OK)
        If result = DialogResult.OK Then
            judgement = True
        End If
        Me.Hide()
        Form2.Show()
    End Sub
End Class