Public Class Polymorphism
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
    Public Class Dog
        Public Function Speak()
            Return "Dog barks"
        End Function
    End Class
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myDog As New Dog()
        TextBox2.Text = myDog.Speak()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Polymorphism_Load(sender As Object, e As EventArgs)

    End Sub
End Class