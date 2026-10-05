Public Class DigitalClock

    Private Sub DigitalClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = True

        UpdateClockAndDates()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateClockAndDates()
    End Sub

    Private Sub UpdateClockAndDates()
        Dim now As DateTime = DateTime.Now


        lblDigitalClock.Text = now.ToString("HH:mm:ss")


        txtShortDate2.Text = now.ToString("M/d/yyyy")

        txtFormattedDate.Text = "Formatted Date: " & now.ToString("hh:mm tt")

        txtLongDate.Text = now.ToString("dddd, d MMMM yyyy")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Selected Date: " & DateTime.Now.ToShortDateString(), "Date Info")
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Current Day of Week: " & DateTime.Now.DayOfWeek.ToString(), "Week Info")
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Current Month: " & DateTime.Now.ToString("MMMM"), "Month Info")
    End Sub

    Private Sub txtShortDate1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txtFormattedDate_Click(sender As Object, e As EventArgs) Handles txtFormattedDate.Click

    End Sub

    Private Sub txtShortDate2_Click(sender As Object, e As EventArgs) Handles txtShortDate2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class