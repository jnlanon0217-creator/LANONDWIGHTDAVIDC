Public Class Arithmetic


    Private Sub Arithmetic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num1 As Double = Val(TextBox1.Text)
        Dim num2 As Double = Val(TextBox3.Text)
        Dim result As Double = 0

        If Not Double.TryParse(TextBox1.Text, num1) Or Not Double.TryParse(TextBox3.Text, num2) Then
            MsgBox("Please enter a valid number!")
            Exit Sub
        End If


        If RadioButton1.Checked Then
            result = num1 + num2
        ElseIf RadioButton2.Checked Then
            result = num1 - num2
        ElseIf RadioButton3.Checked Then
            result = num1 * num2
        ElseIf RadioButton4.Checked Then
            If num2 = 0 Then
                MsgBox("Cannot divide by zero!")
                Exit Sub
            End If
            result = num1 / num2
        Else
            MsgBox("Please select an operation.")
            Exit Sub
        End If
        TextBox2.Text = result
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
