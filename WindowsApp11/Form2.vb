Public Class Form2
    Public player1money As Integer = 1000
    Dim player2money As Integer = 1000
    Dim imagelocation(14) As Point
    Dim rnd As New Random
    Dim chance As Integer = 0
    Dim communitychest As Integer = 0
    Dim cheque As String
    Dim montreal As String
    Dim beijing As String
    Dim shanghaip As String
    Dim player1movement As Integer = 0
    Dim player2movement As Integer = 0
    Dim jail As Boolean = False
    Dim turn As Integer
    Dim player1position As Integer = 1
    Dim player2position As Integer = 1
    Dim turn1 As Boolean = False
    Dim turn2 As Boolean = False
    Dim torontoplayer2 As Boolean = True
    Dim torontoplayer1 As Boolean = True
    Dim shanghaiplayer1 As Boolean = True
    Dim beijingplayer1 As Boolean = True
    Dim beijingplayer2 As Boolean = True
    Dim montrealplayer2 As Boolean = True
    Dim montrealplayer1 As Boolean = True
    Dim shanghaiplayer2 As Boolean = True
    Sub Afterrolldiceplayer1()
        If Player1.Location = imagelocation(1) Then
            MessageBox.Show("Salary Day, you gain $1000")
            player1money += 1000
        End If
        If Player1.Location = imagelocation(2) Then
            chance = rnd.Next(1, 4)
            If chance = 1 Then
                MessageBox.Show("You found a wallet on the street! You gain $100!", "Chance")
                player1money += 150
                player1position = 2
            ElseIf chance = 2 Then
                MessageBox.Show("You fell on the stairs and get injured. Hopsital charge you $100", "Chance")
                player1money -= 100
                player1position = 2
            ElseIf chance = 3 Then
                MessageBox.Show("School awarded you scholarship for keep on getting a 60 average. You gain $200", "Chance")
                player1money += 200
                player1position = 2
            Else
                MessageBox.Show("You broke your neighbor's window. You are asked to buy a new one. You lose $200", "Chance")
                player1money -= 100
                player1position = 2
            End If
        End If
        If Player1.Location = imagelocation(3) Then
            Dim toronto As Integer = MessageBox.Show("You are in Toronto. The price for this land is $300 and you gain $100 if someone else is on it.", "Toronto Government", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                MessageBox.Show("You are now the owner of Toronto", "Government of Toronto")
                player1money -= 300
                player1position = 3
                torontoplayer1 = True
            ElseIf DialogResult.No Then
                MessageBox.Show("You have decided not to buy Toronto and was asked to leave at once.", "Government of Toronto")
                player1money += 0
                player1position = 3
                torontoplayer1 = False
            End If
        ElseIf Player1.Location = imagelocation(4) Then
            Dim montreal As Integer = MessageBox.Show("You are in Montreal. The price for this land is $200 and you gain $50 if someone else is on it.", "Government of Montreal", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                MessageBox.Show("You are now the owner of Montreal", "Government of Montreal")
                player1money -= 300
                player1position = 3
                montrealplayer1 = True
            ElseIf DialogResult.No Then
                MessageBox.Show("You have decided not to buy Montreal and was asked to leave at once.", "Government of Montreal")
                player1money += 0
                player1position = 3
                montrealplayer1 = False
            End If
        End If
        If Player1.Location = imagelocation(5) Then
            MessageBox.Show("You are caught stealing things, you are arrested. Cannot move For a round.", "Police Man")
            jail = True
            Player1.Location = imagelocation(12)
            player1position = 12
        End If
        If Player1.Location = imagelocation(6) Then
            MessageBox.Show("Your electricity does not work anymore and you asked an elctric company To fix it for you. They charge you $150", "Electricity Company Notice")
            player1money -= 150
            player1position = 6
        End If
        If Player1.Location = imagelocation(7) Then
            communitychest = rnd.Next(1, 4)
            If communitychest = 1 Then
                MessageBox.Show("You were doing community service And the coordinator liked you very much. She introduced you To Shanghai where she was born, Would you like to go?.", "Community Chest", MessageBoxButtons.YesNo)
                If DialogResult.Yes Then
                    MessageBox.Show("You are travelling to Shanghai now, the plane ticket costed you $100", "Airport")
                    player1money -= 100
                    Player1.Location = imagelocation(9)
                    player1position = 9
                ElseIf DialogResult.No Then
                    MessageBox.Show("You have decided not travel, so stayed at where you are.", "Community Chest")
                    player1money += 0
                    player1position = 7
                ElseIf communitychest = 2 Then
                    MessageBox.Show("You found a wallet And gave it To Policeman, but he thinks you stole it. You are arrested.", "Community Chest")
                    Player1.Location = imagelocation(12)
                ElseIf communitychest = 3 Then
                    MessageBox.Show("You went To see a Raptors Game, they lost And the ticket Is $100", "Community Chest")
                    player1money -= 100
                    player1position = 7
                ElseIf communitychest = 4 Then
                    cheque = InputBox("You found an empty amount cheque With signature On it, what are you going to do? Press Return to give it to the bank Or Press use to use the cheque", "Community Chest")
                    Form4.Show()
                    player1position = 7
                End If
            End If
        End If
        If Player1.Location = imagelocation(8) Then
            Dim beijing As Integer = MessageBox.Show("You are in Beijing. The price for this land is $300 and you gain $75 if someone else is on it.", "Governmnt of Beijing", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                MessageBox.Show("You are now the owner of Beijing", "Government of Beijing")
                player1money -= 300
                player1position = 8
                beijingplayer1 = True
            ElseIf DialogResult.No Then
                MessageBox.Show("You have decided not to buy Beijing and was asked to leave at once.", "Government of Beijing")
                player1money += 0
                player1position = 8
                beijingplayer1 = False
            End If
        ElseIf Player1.Location = imagelocation(9) Then
            Dim shanghaip As Integer = MessageBox.Show("You are in Shanghai. The price for this land is $400 and you gain $100 if someone else is on it.", "Governmnt of Shanghai", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                MessageBox.Show("You are now the owner of Shanghai", "Government of Shanghai")
                player1money -= 400
                player1position = 9
                shanghaiplayer1 = True
            ElseIf DialogResult.No Then
                MessageBox.Show("You have decided not to buy Shanghai and was asked to leave at once.", "Government of Shanghai")
                player1money += 0
                player1position = 9
                shanghaiplayer1 = False
            End If
        End If
        If Player1.Location = imagelocation(10) Then
            chance = rnd.Next(1, 4)
            If chance = 1 Then
                MessageBox.Show("You found a wallet on the street! You gain $100!", "Chance")
                player1money += 100
                player1position = 10
            ElseIf chance = 2 Then
                MessageBox.Show("You fell on the stairs And get injured. Hopsital charge you $100", "Chance")
                player1money -= 100
                player1position = 10
            ElseIf chance = 3 Then
                MessageBox.Show("School awarded you scholarship for being so nice to others. You gain $200", "Chance")
                player1money += 200
                player1position = 10
            Else
                MessageBox.Show("You broke your neighbor's window. You are asked to buy a new one. You lose $200", "Chance")
                player1money -= 200
                player1position = 10
            End If
        End If
        If Player1.Location = imagelocation(11) Then
            MessageBox.Show("You bought too many luxurious things, therefore, the tax department are charging you $75 for showing off.", "Tax Department")
            player1money -= 75
            player1position = 11
        End If
        If Player1.Location = imagelocation(12) Then
            If jail = True Then
                MessageBox.Show("You are in jail, cannot play for one round.")
                player1position = 12
            ElseIf jail = False Then
                MessageBox.Show("Welcome to visit the jail.")
                'another form about jail
                player1position = 12
            End If
        End If
        If Player1.Location = imagelocation(13) Then
            communitychest = rnd.Next(1, 4)
            If communitychest = 1 Then
                Dim communitychesttravel As Integer = MessageBox.Show("You were doing community service And the coordinator liked you very much. She introduced you To Shanghai where she was born, Would you like to go?.", "Community Chest", MessageBoxButtons.YesNo)
                If DialogResult.Yes Then
                    MessageBox.Show("You are travelling to Shanghai now, the plane ticket costed you $100", "Airport")
                    player1money -= 100
                    Player1.Location = imagelocation(9)
                    player1position = 9
                ElseIf DialogResult.No Then
                    MessageBox.Show("You have decided not travel, so stayed at where you are.", "Community Chest")
                    player1money += 0
                    player1position = 13
                ElseIf communitychest = 2 Then
                    MessageBox.Show("You found a wallet And gave it To Policeman, but he thinks you stole it. You are arrested.", "Community Chest")
                    Player1.Location = imagelocation(12)
                    player1position = 12
                ElseIf communitychest = 3 Then
                    MessageBox.Show("You went To see a Raptors Game, they lost And the ticket Is $100", "Community Chest")
                    player1money -= 100
                    player1position = 13
                ElseIf communitychest = 4 Then
                    cheque = InputBox("You found an empty amount cheque With signature On it, what are you going to do? Press Return to give it to the bank Or Press use to use the cheque", "Community Chest")
                    Form4.Show()
                    player1position = 13
                End If
            End If
        End If
        If Player1.Location = imagelocation(14) Then
            Me.Hide()
            Form6.Show()
            player1position = 14
        End If
    End Sub
    Sub Afterrolldiceplayer2()
        If Player2.Location = imagelocation(1) Then
            MessageBox.Show("Salary Day, you gain $1000")
            player2money += 1000
            player2position = 1
        End If
        If Player2.Location = imagelocation(2) Then
            chance = rnd.Next(1, 4)
            If chance = 1 Then
                MessageBox.Show("You found a wallet on the street! You gain $100!", "Chance")
                player2money += 150
                player2position = 2
            ElseIf chance = 2 Then
                MessageBox.Show("You fell on the stairs and get injured. Hopsital charge you $100", "Chance")
                player2money -= 100
                player2position = 2
            ElseIf chance = 3 Then
                MessageBox.Show("School awarded you scholarship for keep on getting a 60 average. You gain $200", "Chance")
                player2money += 200
                player2position = 2
            Else
                MessageBox.Show("You broke your neighbor's window. You are asked to buy a new one. You lose $200", "Chance")
                player2money -= 100
                player2position = 2
            End If
        End If
        If Player2.Location = imagelocation(3) Then
            Dim toronto As Integer = MessageBox.Show("You are in Toronto. The price for this land is $300 and you gain $100 if someone else is on it.", "Toronto Government", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                MessageBox.Show("You are now the owner of Toronto", "Government of Toronto")
                player1money -= 300
                player2position = 3
                torontoplayer2 = True
            ElseIf DialogResult.No Then
                MessageBox.Show("You have decided not to buy Toronto and was asked to leave at once.", "Government of Toronto")
                player2money += 0
                player2position = 3
                torontoplayer2 = False
            End If
        ElseIf Player2.Location = imagelocation(4) Then
            Dim montreal As Integer = MessageBox.Show("You are in Montreal. The price for this land is $200 and you gain $50 if someone else is on it.", "Government of Montreal", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                MessageBox.Show("You are now the owner of Montreal", "Government of Montreal")
                player2money -= 300
                player2position = 3
                montrealplayer2 = True
            ElseIf DialogResult.No Then
                MessageBox.Show("You have decided not to buy Montreal and was asked to leave at once.", "Government of Montreal")
                player2money += 0
                player2position = 3
                montrealplayer2 = False
            End If
        End If
        If Player2.Location = imagelocation(5) Then
            MessageBox.Show("You are caught stealing things, you are arrested. Cannot move For a round.", "Police Man")
            jail = True
            Player1.Location = imagelocation(12)
            player2position = 12
        End If
        If Player2.Location = imagelocation(6) Then
            MessageBox.Show("Your electricity does not work anymore and you asked an elctric company To fix it for you. They charge you $150", "Electricity Company Notice")
            player2money -= 150
            player2position = 6
        End If
        If Player2.Location = imagelocation(7) Then
            communitychest = rnd.Next(1, 4)
            If communitychest = 1 Then
                MessageBox.Show("You were doing community service And the coordinator liked you very much. She introduced you To Shanghai where she was born, Would you like to go?.", "Community Chest", MessageBoxButtons.YesNo)
                If DialogResult.Yes Then
                    MessageBox.Show("You are travelling to Shanghai now, the plane ticket costed you $100", "Airport")
                    player2money -= 100
                    Player2.Location = imagelocation(9)
                    player2position = 9
                ElseIf DialogResult.No Then
                    MessageBox.Show("You have decided not travel, so stayed at where you are.", "Community Chest")
                    player2money += 0
                    player2position = 7
                ElseIf communitychest = 2 Then
                    MessageBox.Show("You found a wallet And gave it To Policeman, but he thinks you stole it. You are arrested.", "Community Chest")
                    Player2.Location = imagelocation(12)
                ElseIf communitychest = 3 Then
                    MessageBox.Show("You went To see a Raptors Game, they lost And the ticket Is $100", "Community Chest")
                    player2money -= 100
                    player2position = 7
                ElseIf communitychest = 4 Then
                    cheque = InputBox("You found an empty amount cheque With signature On it, what are you going to do? Press Return to give it to the bank Or Press use to use the cheque", "Community Chest")
                    Form4.Show()
                    player2position = 7
                End If
            End If
        End If
        If Player2.Location = imagelocation(8) Then
            Dim beijing As Integer = MessageBox.Show("You are in Beijing. The price for this land is $300 and you gain $75 if someone else is on it.", "Governmnt of Beijing", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                MessageBox.Show("You are now the owner of Beijing", "Government of Beijing")
                player2money -= 300
                player2position = 8
                beijingplayer2 = True
            ElseIf DialogResult.No Then
                MessageBox.Show("You have decided not to buy Beijing and was asked to leave at once.", "Government of Beijing")
                player2money += 0
                player2position = 8
                beijingplayer2 = False
            End If
        ElseIf Player2.Location = imagelocation(9) Then
            Dim shanghaip As Integer = MessageBox.Show("You are in Shanghai. The price for this land is $400 and you gain $100 if someone else is on it.", "Governmnt of Shanghai", MessageBoxButtons.YesNo)
            If DialogResult.Yes Then
                MessageBox.Show("You are now the owner of Shanghai", "Government of Shanghai")
                player2money -= 400
                player2position = 9
                shanghaiplayer2 = True
            ElseIf DialogResult.No Then
                MessageBox.Show("You have decided not to buy Shanghai and was asked to leave at once.", "Government of Shanghai")
                player2money += 0
                player2position = 9
                shanghaiplayer2 = False
            End If
        End If
        If Player2.Location = imagelocation(10) Then
            chance = rnd.Next(1, 4)
            If chance = 1 Then
                MessageBox.Show("You found a wallet on the street! You gain $100!", "Chance")
                player2money += 100
                player2position = 10
            ElseIf chance = 2 Then
                MessageBox.Show("You fell on the stairs And get injured. Hopsital charge you $100", "Chance")
                player2money -= 100
                player2position = 10
            ElseIf chance = 3 Then
                MessageBox.Show("School awarded you scholarship for being so nice to others. You gain $200", "Chance")
                player2money += 200
                player2position = 10
            Else
                MessageBox.Show("You broke your neighbor's window. You are asked to buy a new one. You lose $200", "Chance")
                player2money -= 200
                player2position = 10
            End If
        End If
        If Player2.Location = imagelocation(11) Then
            MessageBox.Show("You bought too many luxurious things, therefore, the tax department are charging you $75 for showing off.", "Tax Department")
            player2money -= 75
            player2position = 11
        End If
        If Player2.Location = imagelocation(12) Then
            If jail = True Then
                MessageBox.Show("You are in jail, cannot play for one round.")
                player2position = 12
            ElseIf jail = False Then
                MessageBox.Show("Welcome to visit the jail.")
                'another form about jail
                player2position = 12
            End If
        End If
        If Player2.Location = imagelocation(13) Then
            communitychest = rnd.Next(1, 4)
            If communitychest = 1 Then
                Dim communitychesttravel As Integer = MessageBox.Show("You were doing community service And the coordinator liked you very much. She introduced you To Shanghai where she was born, Would you like to go?.", "Community Chest", MessageBoxButtons.YesNo)
                If DialogResult.Yes Then
                    MessageBox.Show("You are travelling to Shanghai now, the plane ticket costed you $100", "Airport")
                    player2money -= 100
                    Player1.Location = imagelocation(9)
                    player2position = 9
                ElseIf DialogResult.No Then
                    MessageBox.Show("You have decided not travel, so stayed at where you are.", "Community Chest")
                    player2money += 0
                    player2position = 13
                ElseIf communitychest = 2 Then
                    MessageBox.Show("You found a wallet And gave it To Policeman, but he thinks you stole it. You are arrested.", "Community Chest")
                    Player2.Location = imagelocation(12)
                    player2position = 12
                ElseIf communitychest = 3 Then
                    MessageBox.Show("You went To see a Raptors Game, they lost And the ticket Is $100", "Community Chest")
                    player2money -= 100
                    player2position = 13
                ElseIf communitychest = 4 Then
                    cheque = InputBox("You found an empty amount cheque With signature On it, what are you going to do? Press Return to give it to the bank Or Press use to use the cheque", "Community Chest")
                    Form4.Show()
                    player2position = 13
                End If
            End If
        End If
        If Player2.Location = imagelocation(14) Then
            Me.Hide()
            Form6.Show()
        End If
        If torontoplayer1 = True Then
            If Player2.Location = imagelocation(3) Then
                MessageBox.Show("You just stepped on Player1's Toronto, you need to pay $100 rent.")
                player2money -= 100
                player1money += 100
            End If
        End If
        If torontoplayer2 = True Then
            If Player1.Location = imagelocation(3) Then
                MessageBox.Show("You just stepped on Player2's Toronto, you need to pay $100 rent.")
                player1money -= 100
                player2money += 100
            End If
        End If
        If montrealplayer1 = True Then
            If Player1.Location = imagelocation(4) Then
                MessageBox.Show("You just stepped on Player1's Montreal, you need to pay $50 rent.")
                player1money += 50
                player2money -= 50
            End If
        End If
        If montrealplayer2 = True Then
            If Player1.Location = imagelocation(4) Then
                MessageBox.Show("You just stepped on Player2's Montreal, you need to pay $100 rent.")
                player1money -= 50
                player2money += 50
            End If
        End If
        If shanghaiplayer1 = True Then
            If Player1.Location = imagelocation(9) Then
                MessageBox.Show("You just stepped on Player1's Shanghai, you need to pay $100 rent.")
                player1money += 100
                player2money -= 100
            End If
        End If
        If shanghaiplayer2 = True Then
            If Player1.Location = imagelocation(9) Then
                MessageBox.Show("You just stepped on Player2's Shanghai, you need to pay $100 rent.")
                player1money -= 100
                player2money += 100
            End If
        End If
        If beijingplayer1 = True Then
            If Player1.Location = imagelocation(8) Then
                MessageBox.Show("You just stepped on Player1's Beijing, you need to pay $75 rent.")
                player1money += 75
                player2money -= 75
            End If
        End If
        If beijingplayer2 = True Then
            If Player2.Location = imagelocation(8) Then
                MessageBox.Show("You just stepped on Player2's Beijing, you need to pay $75 rent.")
                player1money -= 75
                player2money += 75
            End If
        End If
    End Sub
    Private Sub BtnRollDice_Click(sender As Object, e As EventArgs) Handles BtnRollDice.Click
        RollDice.Show()
        player1movement = RollDice.roll
        player2movement = Form7.roll
        If RollDice.judgement = True Then
            If turn = 1 Then
                player1shift()
                RollDice.Hide()
                Afterrolldiceplayer1()
            ElseIf turn = 2 Then
                player2shift()
                RollDice.Hide()
                Afterrolldiceplayer2()
            End If
            BtnRollDice.Enabled = False
            BtnEndTurn.Enabled = True
        End If
    End Sub
    Sub player1shift()
        If player1position + player1movement > 14 Then
            Player1.Location = imagelocation(-1 * (14 - (player1position + player1movement)))
        End If
        Player1.Location = imagelocation(player1position + player1movement)
        Afterrolldiceplayer1()
        lblplayermoney1.Text = "Player1 Money: $" & player1money
    End Sub
    Sub player2shift()
        Player2.Location = imagelocation(player2position + player2movement)
        If player2position + player2movement > 14 Then
            Player2.Location = imagelocation(14 - (player2position + player2movement))
        End If
        Afterrolldiceplayer2()
        lblplayermoney2.Text = "Player2 Money: $" & player2money
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnEndTurn.Enabled = False
        turn = 1
        Me.Text = "Monopoly"
        imagelocation(1) = PictureBox1.Location
        imagelocation(2) = chancebox1.Location
        imagelocation(3) = Torontopic.Location
        imagelocation(4) = Montrealpic.Location
        imagelocation(5) = gotojail.Location
        imagelocation(6) = PictureBox7.Location
        imagelocation(7) = communitychest1.Location
        imagelocation(8) = beijingpic.Location
        imagelocation(9) = shanghai.Location
        imagelocation(10) = chancebox2.Location
        imagelocation(11) = PictureBox8.Location
        imagelocation(12) = jailpic1.Location
        imagelocation(13) = communitychest2.Location
        imagelocation(14) = Bank.Location
        Player1.Location = imagelocation(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        MessageBox.Show("Are you sure you want to exit the game?", "Exit game?", MessageBoxButtons.YesNo)
        If DialogResult.Yes Then
            Application.Exit()
        ElseIf DialogResult.No Then
            Me.Show()
        End If
    End Sub

    Private Sub BtnEndTurn_Click(sender As Object, e As EventArgs) Handles BtnEndTurn.Click
        turn = 2
        BtnRollDice.Enabled = True
        BtnEndTurn.Enabled = False
        If turn = 2 Then
            turn = 1
        ElseIf turn = 1 Then
            turn = 2
        End If
        lblturn.Text = "Player" & turn & " 's turn"
    End Sub
End Class