Public Class Truthtable
    Private Sub Truthtable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function GetInputValue(txt As TextBox) As Boolean
        Dim val As String = txt.Text.Trim().ToUpper()
        If val = "TRUE" Or val = "1" Then Return True
        If val = "FALSE" Or val = "0" Then Return False

        
        MessageBox.Show("Please enter True, False, 1, or 0 into " & txt.Name, "Invalid Input")
        Return False
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim input1 As Boolean = GetInputValue(TextBox1)
        Dim input2 As Boolean = GetInputValue(TextBox2)
        Dim result As Boolean = input1 And input2

        MessageBox.Show($"AND Result: {result}", "Truth Table Result")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim input1 As Boolean = GetInputValue(TextBox1)
        Dim input2 As Boolean = GetInputValue(TextBox2)
        Dim result As Boolean = input1 Or input2

        MessageBox.Show($"OR Result: {result}", "Truth Table Result")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim input1 As Boolean = GetInputValue(TextBox1)
        Dim input2 As Boolean = GetInputValue(TextBox2)
        Dim result As Boolean = input1 Xor input2

        MessageBox.Show($"XOR Result: {result}", "Truth Table Result")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim input1 As Boolean = GetInputValue(TextBox1)
        Dim result As Boolean = Not input1

        MessageBox.Show($"NOT (Input 1) Result: {result}", "Truth Table Result")
    End Sub

End Class