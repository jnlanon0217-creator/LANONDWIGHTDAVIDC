Public Class game3
    Dim rand As New Random

    Dim bossMaxLife As Integer = 100
    Dim bossLife As Integer = 100
    Dim playerMaxLife As Integer = 100
    Dim playerLife As Integer = 100

    Dim gameFinished As Boolean = False

    Private Sub game3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PictureBox3 IsNot Nothing Then PictureBox3.Visible = False
        If PictureBox4 IsNot Nothing Then PictureBox4.Visible = False
        If PictureBox5 IsNot Nothing Then PictureBox5.Visible = False

        Timer1.Interval = 2500
        Timer3.Interval = 2000

        If Timer1 IsNot Nothing Then Timer1.Stop()
        If Timer2 IsNot Nothing Then Timer2.Stop()
        If Timer3 IsNot Nothing Then Timer3.Stop()

        ' Hide labels initially
        Label1.Visible = False
        Label2.Visible = False

        ResetGame() ' Initialize fresh stats
        UpdateUI()
    End Sub

    ' --- ACTION 1: STANDARD ATTACK (75% Hit Chance) ---
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If gameFinished Then Exit Sub

        Dim hitChance As Integer = rand.Next(1, 101) ' Roll 1 to 100

        If hitChance <= 75 Then
            ' Success!
            Dim dmg As Integer = rand.Next(12, 22)
            bossLife -= dmg
            Label2.Text = "Your attack hits the Boss for " & dmg & " damage! Hit!"

            If PictureBox5 IsNot Nothing AndAlso PictureBox5.Visible = True Then
                PictureBox4.Visible = False
                Timer1.Stop()
            ElseIf PictureBox4 IsNot Nothing Then
                PictureBox4.Visible = True
                Timer1.Start()

                ' Shake Boss on hit
                ShakeControl(PictureBox2, 5, 6)
            End If
        Else
            ' Miss!
            DisplayMessage("Your attack missed the Boss!", "Miss!")
        End If

        UpdateUI()
        CheckWinCondition()
        If Not gameFinished Then BossTurn()
    End Sub

    ' --- ACTION 2: HEAL POTION (60% Success Chance) ---
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If gameFinished Then Exit Sub

        Dim healChance As Integer = rand.Next(1, 101)

        If healChance <= 100 Then
            Dim healAmount As Integer = rand.Next(15, 30)
            playerLife = Math.Min(playerMaxLife, playerLife + healAmount)
            Label2.Text = "You successfully recovered " & healAmount & " HP! Healed Successfully"
        Else
            DisplayMessage("Your healing attempt was interrupted!", "Failed Heal")
        End If

        UpdateUI()
        If Not gameFinished Then BossTurn()
    End Sub

    ' --- ACTION 3: CRITICAL GAMBLE (40% Success Chance) ---
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If gameFinished Then Exit Sub

        ComboBoxLogics()
        Dim critChance As Integer = rand.Next(1, 101)

        If critChance <= 40 Then
            Dim heavyDmg As Integer = rand.Next(30, 45)
            bossLife -= heavyDmg
            Label2.Text = "CRITICAL GAMBLE! You dealt massive damage (" & heavyDmg & ")! Massive Hit!"

            If PictureBox3 IsNot Nothing Then
                PictureBox3.Visible = True
                Timer1.Start()
            End If

            ' Shake Boss strongly on critical hit using PictureBox2
            ShakeControl(PictureBox2, 10, 10)
        Else
            Dim recoil As Integer = rand.Next(10, 20)
            playerLife -= recoil
            DisplayMessage("Your gamble failed! Backlash hit you for " & recoil & " damage.", "Backlash!")
        End If

        UpdateUI()
        CheckWinCondition()
        If Not gameFinished Then BossTurn()
    End Sub

    ' --- BOSS TURN ---
    Private Sub BossTurn()
        If gameFinished Then Exit Sub

        Dim bossActionRoll As Integer = rand.Next(1, 101)

        If bossActionRoll <= 70 Then
            Dim bossDmg As Integer = rand.Next(10, 20)
            playerLife -= bossDmg
            DisplayMessage("The Boss counter-attacks and deals " & bossDmg & " damage!", "Wallahiii")

            ' Shake the entire screen when boss attacks
            ShakeControl(Me, 5, 6)
        Else
            ' Boss Special Heavy Attack
            Dim heavyBossDmg As Integer = rand.Next(20, 30)
            playerLife -= heavyBossDmg
            DisplayMessage("DANGER! Boss unleashes a special attack for " & heavyBossDmg & " damage!", "Critical!")

            If PictureBox5 IsNot Nothing Then
                PictureBox5.Visible = True
                Timer1.Start()
            End If

            ' Shake the entire screen strongly on boss heavy attack
            ShakeControl(Me, 8, 10)
        End If

        UpdateUI()
        CheckWinCondition()
    End Sub

    ' --- CHECK IF WIN OR LOSS CONDITION MET ---
    Private Sub CheckWinCondition()
        If bossLife <= 0 Then
            bossLife = 0
            gameFinished = True
            UpdateUI()
            MessageBox.Show("u won now u can touch some grass son")
            Label2.Text = "You Win!"
            Label1.Visible = True
            Label2.Visible = True
        ElseIf playerLife <= 0 Then
            playerLife = 0
            gameFinished = True
            UpdateUI()
            MessageBox.Show("U lost quit the game")
            Label2.Text = "You Lost!"
            Label1.Visible = True
            Label2.Visible = True

            ResetGame()
        End If
    End Sub

    ' --- HELPER TO SHOW BOTH LABELS SIMULTANEOUSLY FOR 2 SECONDS ---
    Private Sub DisplayMessage(msg1 As String, msg2 As String)
        Timer3.Stop() ' Stop timer so it doesn't interrupt mid-display
        Label1.Text = msg1
        Label2.Text = msg2
        Label1.Visible = True
        Label2.Visible = True
        Timer3.Start() ' Start 2-second countdown
    End Sub

    ' --- SHAKE ANIMATION SUBROUTINE ---
    Private Sub ShakeControl(ctl As Control, intensity As Integer, duration As Integer)
        Dim originalLocation As Point = ctl.Location
        Dim r As New Random()

        For i As Integer = 0 To duration
            ctl.Location = New Point(originalLocation.X + r.Next(-intensity, intensity + 1),
                                     originalLocation.Y + r.Next(-intensity, intensity + 1))
            ctl.Refresh()
            System.Threading.Thread.Sleep(20) ' Short delay to create shake visual
        Next

        ctl.Location = originalLocation ' Reset back to original position
    End Sub

    ' --- HELPER TO UPDATE UI TEXTBOXES ---
    Private Sub UpdateUI()
        TextBox1.Text = Math.Max(0, bossLife).ToString() ' Boss HP
        If Me.Controls.ContainsKey("TextBox2") Then
            TextBox2.Text = Math.Max(0, playerLife).ToString() ' Player HP
        End If
    End Sub

    ' --- RESET GAME STATS ---
    Public Sub ResetGame()
        bossLife = 100
        bossMaxLife = 100
        playerLife = 100
        playerMaxLife = 100
        gameFinished = False
        UpdateUI()
    End Sub

    Private Sub ComboBoxLogics()
        ' Placeholder if you use it elsewhere
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    ' --- TIMER 3: HIDES BOTH LABELS AFTER 2 SECONDS ---
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label1.Visible = False
        Label2.Visible = False
        Timer3.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class