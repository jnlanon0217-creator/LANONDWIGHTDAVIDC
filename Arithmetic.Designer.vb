<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arithmetic
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
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(42, 32)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(206, 54)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Addition"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(363, 32)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(261, 54)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Subtraction"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RadioButton3.Location = New Point(730, 32)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(301, 54)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Multiplication"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RadioButton4.Location = New Point(1102, 23)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(193, 54)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "Division"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Bradley Hand ITC", 72F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(838, 205)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(420, 194)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Bradley Hand ITC", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(457, 251)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(240, 99)
        TextBox3.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(711, 636)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 78)
        Button2.TabIndex = 27
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1118, 636)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 78)
        Button1.TabIndex = 28
        Button1.Text = "Execute"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(928, 636)
        Button3.Name = "Button3"
        Button3.Size = New Size(166, 78)
        Button3.TabIndex = 29
        Button3.Text = "Clear"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Bradley Hand ITC", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(104, 251)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(240, 99)
        TextBox1.TabIndex = 4
        ' 
        ' Arithmetic
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2026_09_19_213914
        ClientSize = New Size(1384, 754)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        DoubleBuffered = True
        Name = "Arithmetic"
        Text = "Arithmetic"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
