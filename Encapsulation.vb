Public Class Encapsulation

    Private account As New BankAccount(0)

    Private Sub Encapsulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox4.Text = account.GetBalance()
        TextBox4.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If account.Withdraw(Val(TextBox1.Text)) Then
            TextBox4.Text = account.GetBalance()
            TextBox1.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If account.Deposit(Val(TextBox2.Text)) Then
            TextBox4.Text = account.GetBalance()
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Public Class BankAccount
        Private _balance As Decimal

        Public Sub New(ByVal initialBalance As Decimal)
            _balance = initialBalance
        End Sub

        Public Function GetBalance() As Decimal
            Return _balance
        End Function

        Public Function Deposit(ByVal amount As Decimal) As Boolean
            If amount > 0 Then
                _balance += amount
                Return True
            End If
            Return False
        End Function

        Public Function Withdraw(ByVal amount As Decimal) As Boolean
            If amount > 0 AndAlso amount <= _balance Then
                _balance -= amount
                Return True
            End If
            Return False
        End Function
    End Class

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class