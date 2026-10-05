<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week5pt2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week5pt2))
        Label1 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(38, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(824, 55)
        Label1.TabIndex = 18
        Label1.Text = "Naming Rules for Variables and Constants"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ControlDarkDark
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(38, 86)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.ScrollBars = ScrollBars.Vertical
        TextBox3.Size = New Size(727, 134)
        TextBox3.TabIndex = 19
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(38, 223)
        Label2.Name = "Label2"
        Label2.Size = New Size(381, 55)
        Label2.TabIndex = 20
        Label2.Text = "Declaring Variables"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ControlDarkDark
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(38, 281)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(727, 134)
        TextBox1.TabIndex = 21
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(38, 427)
        Label3.Name = "Label3"
        Label3.Size = New Size(401, 55)
        Label3.TabIndex = 22
        Label3.Text = "Declaring Constants"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ControlDarkDark
        TextBox2.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(38, 496)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.ScrollBars = ScrollBars.Vertical
        TextBox2.Size = New Size(727, 134)
        TextBox2.TabIndex = 23
        TextBox2.Text = resources.GetString("TextBox2.Text")
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlDarkDark
        Button2.Location = New Point(1002, 662)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 78)
        Button2.TabIndex = 25
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlDarkDark
        Button1.Location = New Point(1197, 662)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 78)
        Button1.TabIndex = 26
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Week5pt2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2026_09_19_213711
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1375, 752)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Week5pt2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week5pt2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
