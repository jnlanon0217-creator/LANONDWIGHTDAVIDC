<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassandObjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassandObjects))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(701, 188)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(303, 86)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(701, 368)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(303, 86)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(73, 142)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(526, 492)
        TextBox3.TabIndex = 2
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(148, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(334, 50)
        Label1.TabIndex = 3
        Label1.Text = "Class and Objects"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(701, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 50)
        Label2.TabIndex = 4
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bradley Hand ITC", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(701, 315)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 50)
        Label3.TabIndex = 5
        Label3.Text = "Age"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(805, 579)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 6
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1011, 579)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 7
        Button2.Text = "Execute"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ClassandObjects
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2026_09_13_213917
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1318, 666)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        DoubleBuffered = True
        Name = "ClassandObjects"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ClassandObjects"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
