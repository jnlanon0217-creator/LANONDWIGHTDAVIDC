Public Class game

    Dim boatx As Integer = 580
    Dim targetboatx As Integer = 580
    Dim isanimating As Boolean = False

    Dim allcharacters As List(Of PictureBox)

    Private Sub game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1000, 600)
        Me.StartPosition = FormStartPosition.CenterScreen

        allcharacters = New List(Of PictureBox) From {picM1, picM2, picM3, picC1, picC2, picC3}

        For Each pic In allcharacters
            pic.Tag = "right"
            pic.Size = New Size(100, 100)
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            pic.Cursor = Cursors.Hand
        Next

        resetgame()
    End Sub

    Private Sub character_click(sender As Object, e As EventArgs) Handles _
        picM1.Click, picM2.Click, picM3.Click, picC1.Click, picC2.Click, picC3.Click

        If isanimating Then Return

        Dim pic As PictureBox = CType(sender, PictureBox)
        Dim currentbank As String = If(boatx > 400, "right", "left")

        Dim boatpassengers As Integer = 0
        For Each character In allcharacters
            If character.Tag.ToString() = "boat" Then
                boatpassengers += 1
            End If
        Next

        If pic.Tag.ToString() = "boat" Then
            pic.Tag = currentbank
        ElseIf pic.Tag.ToString() = currentbank Then
            If boatpassengers < 2 Then
                pic.Tag = "boat"
            Else
                MessageBox.Show("Poro is full! (max 2)")
            End If
        End If

        updatepositions()
    End Sub

    Private Sub btngo_click(sender As Object, e As EventArgs) Handles btnGo.Click
        If isanimating Then Return

        Dim boatpassengers As Integer = 0
        For Each character In allcharacters
            If character.Tag.ToString() = "boat" Then
                boatpassengers += 1
            End If
        Next

        If boatpassengers = 0 Then
            MessageBox.Show("You need at least 1 person in the wolf to run!")
            Return
        End If

        If boatx > 400 Then
            targetboatx = 220
        Else
            targetboatx = 580
        End If

        isanimating = True
        gameTimer.Interval = 15
        gameTimer.Start()
    End Sub

    Private Sub gametimer_tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If boatx < targetboatx Then
            boatx += 5
            If boatx >= targetboatx Then boatx = targetboatx
        ElseIf boatx > targetboatx Then
            boatx -= 5
            If boatx <= targetboatx Then boatx = targetboatx
        End If

        updatepositions()
        Me.Invalidate()

        If boatx = targetboatx Then
            gameTimer.Stop()
            isanimating = False

            Dim arrivalbank As String = If(boatx > 400, "right", "left")
            For Each character In allcharacters
                If character.Tag.ToString() = "boat" Then
                    character.Tag = arrivalbank
                End If
            Next

            updatepositions()
            checkrules()
        End If
    End Sub

    Private Sub updatepositions()

        If allcharacters Is Nothing Then Return

        If btnGo IsNot Nothing Then
            btnGo.Location = New Point(400, 30)
            btnGo.Size = New Size(100, 100)
        End If

        If picBoat IsNot Nothing Then
            picBoat.Location = New Point(boatx, 470)
            picBoat.Size = New Size(200, 70)
            picBoat.SendToBack()
        End If

        Dim leftcount As Integer = 0
        Dim rightcount As Integer = 0
        Dim boatcount As Integer = 0

        For Each character In allcharacters
            Dim banklocation As String = character.Tag.ToString()
            character.Size = New Size(60, 100)

            If banklocation = "right" Then
                ' Y = 140 moves characters higher up onto the right grass bank
                character.Location = New Point(580 + (rightcount * 60), 300)
                rightcount += 1
            ElseIf banklocation = "left" Then
                ' Y = 140 moves characters higher up onto the left grass bank
                character.Location = New Point(40 + (leftcount * 60), 300)
                leftcount += 1
            ElseIf banklocation = "boat" Then
                ' Passenger position inside boat
                character.Location = New Point((boatx + 10) + (boatcount * 60), 400)
                boatcount += 1
            End If
        Next
    End Sub

    Private Sub checkrules()
        Dim leftm As Integer = 0, leftc As Integer = 0
        Dim rightm As Integer = 0, rightc As Integer = 0

        If picM1.Tag.ToString() = "left" Then leftm += 1 Else If picM1.Tag.ToString() = "right" Then rightm += 1
        If picM2.Tag.ToString() = "left" Then leftm += 1 Else If picM2.Tag.ToString() = "right" Then rightm += 1
        If picM3.Tag.ToString() = "left" Then leftm += 1 Else If picM3.Tag.ToString() = "right" Then rightm += 1

        If picC1.Tag.ToString() = "left" Then leftc += 1 Else If picC1.Tag.ToString() = "right" Then rightc += 1
        If picC2.Tag.ToString() = "left" Then leftc += 1 Else If picC2.Tag.ToString() = "right" Then rightc += 1
        If picC3.Tag.ToString() = "left" Then leftc += 1 Else If picC3.Tag.ToString() = "right" Then rightc += 1

        If (leftm > 0 AndAlso leftc > leftm) OrElse (rightm > 0 AndAlso rightc > rightm) Then
            MessageBox.Show("Game over")
            resetgame()
        ElseIf leftm = 3 AndAlso leftc = 3 Then
            MessageBox.Show("You win!")
            resetgame()
        End If
    End Sub

    Private Sub resetgame()
        boatx = 580
        targetboatx = 580
        isanimating = False

        If allcharacters IsNot Nothing Then
            For Each character In allcharacters
                character.Tag = "right"
            Next
        End If

        updatepositions()
    End Sub

End Class