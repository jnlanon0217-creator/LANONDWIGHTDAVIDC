<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Polymorphism
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Polymorphism))
        TextBox3 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(25, 162)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.ScrollBars = ScrollBars.Vertical
        TextBox3.Size = New Size(526, 492)
        TextBox3.TabIndex = 7
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(130, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(277, 50)
        Label1.TabIndex = 8
        Label1.Text = "Polymorphism"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(753, 287)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(303, 86)
        TextBox2.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(753, 218)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 50)
        Label2.TabIndex = 10
        Label2.Text = "Dog"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(814, 577)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 15
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1014, 577)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 16
        Button1.Text = "Execute"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Polymorphism
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2026_09_09_232038
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1318, 666)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        DoubleBuffered = True
        Name = "Polymorphism"
        Text = "Polymorphism"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
