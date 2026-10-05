Public Class Inheritance
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Public Class Animal
        Public Overridable Function Speak()
            Return "animal speaks"

        End Function
    End Class

    Public Class Dog
        Inherits Animal
        Public Overrides Function Speak()

            Return "Dog barks"
        End Function
    End Class
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myDog As New Dog()
        Dim Animal As New Animal()
        TextBox1.Text = myDog.Speak()
        TextBox2.Text = Animal.Speak()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class


