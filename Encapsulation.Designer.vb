<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encapsulation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Encapsulation))
        TextBox3 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(73, 133)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.ScrollBars = ScrollBars.Vertical
        TextBox3.Size = New Size(526, 492)
        TextBox3.TabIndex = 3
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(174, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(277, 50)
        Label1.TabIndex = 4
        Label1.Text = "Encapsulation"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(711, 103)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(303, 86)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(711, 269)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(303, 86)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(711, 453)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(303, 86)
        TextBox4.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1073, 130)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 9
        Button1.Text = "Withdraw"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(639, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(251, 50)
        Label2.TabIndex = 10
        Label2.Text = "WITHDRAW"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(639, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 50)
        Label3.TabIndex = 11
        Label3.Text = "DEPOSIT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(639, 400)
        Label4.Name = "Label4"
        Label4.Size = New Size(214, 50)
        Label4.TabIndex = 12
        Label4.Text = "BALANCE"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1073, 291)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 13
        Button2.Text = "Deposit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1073, 477)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 14
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Encapsulation
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2026_09_16_090352
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1318, 666)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        DoubleBuffered = True
        Name = "Encapsulation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Encapsulation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
