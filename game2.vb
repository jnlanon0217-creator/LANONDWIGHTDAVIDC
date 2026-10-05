Imports System.ComponentModel.Design
Imports System.Windows.Forms.AxHost

Public Class game2
    Dim rand As New Random()
    Dim health As New health_bar()

    Private startX As Integer
    Private startY As Integer

    Private tackleDistance As Integer = 400
    Private etackleDistance As Integer = 400

    Private isTackling As Boolean = False
    Private returning As Boolean = False
    Private currentAttacker As Integer = 1

    Private shakeTarget As PictureBox
    Private originalShakeLeft As Integer
    Private shakeStep As Integer = 0

    Private Sub game2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = health.enemyhealth
        TextBox2.Text = health.myhealth
        Check_rules()

        startX = PictureBox1.Left
        startY = PictureBox2.Left

        Timer1.Interval = 50
        Timer2.Interval = 1000
        Timer4.Interval = 1500
        Timer3.Interval = 30
        Timer5.Interval = 1500
        Button1.Text = "Slash"
        Label1.Text = ""
    End Sub

    ' Helper method to lock or unlock all action buttons at once
    Private Sub SetButtonsEnabled(ByVal isEnabled As Boolean)
        Button1.Enabled = isEnabled
        Button2.Enabled = isEnabled
        Button3.Enabled = isEnabled
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SetButtonsEnabled(False) ' Lock buttons immediately

        Label1.Visible = True
        Timer2.Start()

        Dim damage As Double = 0
        Dim result As Double = 0
        health.enemyhealth2 = rand.Next(2) = 0

        If health.enemyhealth2 = True Then
            result = rand.Next(1, 100)
            health.enemyhealth -= result
            PictureBox6.Visible = True
            Timer5.Start()
            If health.enemyhealth < 0 Then
                health.enemyhealth = 0
            End If
            TextBox1.Text = health.enemyhealth

            If Not isTackling Then
                isTackling = True
                returning = False
                currentAttacker = 1
                Timer1.Start()
            End If
            Check_rules()

            StartShake(PictureBox2)

            Label1.Text = "You slashed the enemy for " & result & " damage!"
        Else
            damage = rand.Next(1, 100)
            health.myhealth -= damage

            If Not isTackling Then
                isTackling = True
                returning = False
                currentAttacker = 2
                Timer1.Start()
                PictureBox3.Visible = True
                Timer4.Start()
            End If

            StartShake(PictureBox1)

            Label1.Text = "Slash missed! Enemy counters for " & damage & " damage."
            If health.myhealth < 0 Then
                health.myhealth = 0
            End If
            TextBox2.Text = health.myhealth
        End If

        Check_rules()
    End Sub

    Public Class health_bar
        Public myhealth As Integer = 100
        Public enemyhealth As Integer = 1000
        Public enemyhealth2 As Boolean = False
        Public enemyhealth3 As Integer = 0
    End Class

    Private Sub Check_rules()
        If TextBox1.Text = "0" Or health.enemyhealth <= 0 Then
            MessageBox.Show("You win")
            Reset()
            PictureBox7.Visible = True
            Timer5.Start()
        ElseIf TextBox2.Text = "0" Or health.myhealth <= 0 Then
            MessageBox.Show("You lost")
            Reset()
            PictureBox8.Visible = True
            Timer5.Start()
        End If
    End Sub

    Private Sub Reset()
        health.myhealth = 1000
        health.enemyhealth = 1000
        TextBox2.Text = health.myhealth
        TextBox1.Text = health.enemyhealth
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SetButtonsEnabled(False) ' Lock buttons immediately

        Label1.Visible = True
        Timer2.Start()

        Dim heal As Double = 0
        Dim damage As Double = 0
        health.enemyhealth2 = rand.Next(2) = 0

        If health.enemyhealth2 = True And health.myhealth < 1000 Then
            heal = rand.Next(30, 70)
            health.myhealth += heal
            PictureBox4.Visible = True
            Timer5.Start()
            If health.myhealth > 1000 Then
                health.myhealth = 1000
            End If

            Label1.Text = "Healed yourself by " & heal
            TextBox2.Text = health.myhealth
        ElseIf health.myhealth >= 1001 Then
            health.myhealth = 1000
            Label1.Text = "Full health"
        Else
            damage = rand.Next(30, 50)
            health.myhealth -= damage

            If Not isTackling Then
                isTackling = True
                returning = False
                currentAttacker = 2
                Timer1.Start()
                PictureBox3.Visible = True
                Timer4.Start()
            End If

            StartShake(PictureBox1)

            Label1.Text = "Action missed, enemy counters for " & damage & " damage."
            If health.myhealth < 0 Then
                health.myhealth = 0
            End If
            TextBox2.Text = health.myhealth
        End If
        Check_rules()
    End Sub

    Private Sub StartShake(pb As PictureBox)
        shakeTarget = pb
        originalShakeLeft = pb.Left
        shakeStep = 0
        Timer3.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If currentAttacker = 1 Then
            If Not returning Then
                PictureBox1.Left += 10000
                PictureBox1.Refresh()

                If PictureBox1.Left >= startX + tackleDistance Then
                    PictureBox1.Left = startX + tackleDistance
                    returning = True
                End If
            Else
                PictureBox1.Left -= 10000
                PictureBox1.Refresh()

                If PictureBox1.Left <= startX Then
                    PictureBox1.Left = startX
                    Timer1.Stop()
                    isTackling = False
                    SetButtonsEnabled(True) ' Re-enable buttons when attack animation finishes!
                End If
            End If

        ElseIf currentAttacker = 2 Then
            If Not returning Then
                PictureBox2.Left -= 10000
                PictureBox2.Refresh()

                If PictureBox2.Left <= startY - etackleDistance Then
                    PictureBox2.Left = startY - etackleDistance
                    returning = True
                End If
            Else
                PictureBox2.Left += 10000
                PictureBox2.Refresh()
                If PictureBox2.Left >= startY Then
                    PictureBox2.Left = startY
                    Timer1.Stop()
                    isTackling = False
                    SetButtonsEnabled(True) ' Re-enable buttons when counter animation finishes!
                End If
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Visible = False

        If Not isTackling Then
            SetButtonsEnabled(True)
        End If

        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If shakeTarget IsNot Nothing Then
            If shakeStep Mod 2 = 0 Then
                shakeTarget.Left = originalShakeLeft + 8
            Else
                shakeTarget.Left = originalShakeLeft - 8
            End If

            shakeTarget.Refresh()
            shakeStep += 1

            If shakeStep > 6 Then
                shakeTarget.Left = originalShakeLeft
                Timer3.Stop()
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SetButtonsEnabled(False) ' Lock buttons immediately

        Label1.Visible = True
        Timer2.Start()

        Dim poison As Double = 0
        Dim damage As Double = 0
        health.enemyhealth3 = rand.Next(1, 120)

        If health.enemyhealth3 < 50 Then
            poison = rand.Next(30, 50)
            health.enemyhealth -= poison
            PictureBox6.Visible = True
            Timer5.Start()

            Label1.Text = "True Damage " & poison
            TextBox1.Text = health.enemyhealth

            StartShake(PictureBox2)
        Else
            damage = rand.Next(1, 100)
            health.myhealth -= damage

            If Not isTackling Then
                isTackling = True
                returning = False
                currentAttacker = 2
                Timer1.Start()
                PictureBox3.Visible = True
                Timer4.Start()
            End If

            StartShake(PictureBox1)

            Label1.Text = "Action missed, enemy counters for " & damage & " damage."
            If health.myhealth < 0 Then
                health.myhealth = 0
            End If
            TextBox2.Text = health.myhealth
        End If
        Check_rules()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PictureBox3.Visible = False
        Timer4.Stop()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        Timer5.Stop()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub
End Class