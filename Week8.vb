Public Class Week8

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label9.Text = TrackBar1.Value.ToString() & " / 10"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gender As String = ""
        If RadioButton1.Checked Then
            gender = "Male"
        ElseIf RadioButton2.Checked Then
            gender = "Female"
        End If

        Dim interests As New List(Of String)()
        If CheckBox1.Checked Then interests.Add("Programming")
        If CheckBox2.Checked Then interests.Add("Sports")
        If CheckBox3.Checked Then interests.Add("Music")
        If CheckBox4.Checked Then interests.Add("Reading")

        Dim skills As New List(Of String)()
        For Each item In ListBox1.SelectedItems
            skills.Add(item.ToString())
        Next

        Dim summary As String = "ENROLLMENT SUMMARY" & Environment.NewLine &
                                "Name       : " & TextBox1.Text & Environment.NewLine &
                                "Age        : " & NumericUpDown1.Value.ToString() & Environment.NewLine &
                                "Birthdate  : " & DateTimePicker1.Value.ToShortDateString() & Environment.NewLine &
                                "Course     : " & ComboBox1.Text & Environment.NewLine &
                                "Gender     : " & gender & Environment.NewLine &
                                "Interests  : " & String.Join(", ", interests) & Environment.NewLine &
                                "Satisfaction: " & TrackBar1.Value & "/10" & Environment.NewLine &
                                "Skills     : " & String.Join(", ", skills)

        TextBox2.Text = summary
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        NumericUpDown1.Value = 20
        DateTimePicker1.Value = DateTime.Now
        ComboBox1.SelectedIndex = -1
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        TrackBar1.Value = 10
        Label9.Text = "10 / 10"
        ListBox1.ClearSelected()
        TextBox2.Clear()
        TextBox1.Focus()

        UpdateProgress()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub UpdateProgress()
        Dim progress As Integer = 0

        If Not String.IsNullOrWhiteSpace(TextBox1.Text) Then progress += 25
        If ComboBox1.SelectedIndex <> -1 Then progress += 25
        If RadioButton1.Checked Or RadioButton2.Checked Then progress += 25
        If CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked Or CheckBox4.Checked Then progress += 25

        ProgressBar1.Value = progress
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        UpdateProgress()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        UpdateProgress()
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        UpdateProgress()
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged
        UpdateProgress()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Week8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class