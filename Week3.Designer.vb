<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week3))
        TextBox3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.InactiveBorder
        TextBox3.Location = New Point(36, 56)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(1176, 152)
        TextBox3.TabIndex = 3
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(319, -2)
        Label1.Name = "Label1"
        Label1.Size = New Size(644, 55)
        Label1.TabIndex = 4
        Label1.Text = "What is Computer Programming?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(417, 211)
        Label2.Name = "Label2"
        Label2.Size = New Size(505, 55)
        Label2.TabIndex = 5
        Label2.Text = "Programming Languages"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.InactiveCaptionText
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.HighlightText
        TextBox1.Location = New Point(49, 269)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(1193, 180)
        TextBox1.TabIndex = 6
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ActiveCaptionText
        TextBox2.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.Window
        TextBox2.Location = New Point(49, 514)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.ScrollBars = ScrollBars.Vertical
        TextBox2.Size = New Size(1193, 169)
        TextBox2.TabIndex = 7
        TextBox2.Text = resources.GetString("TextBox2.Text")
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(392, 456)
        Label3.Name = "Label3"
        Label3.Size = New Size(558, 55)
        Label3.TabIndex = 8
        Label3.Text = "What is a Program Made Of?"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(976, 722)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 78)
        Button1.TabIndex = 9
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(1175, 722)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 78)
        Button2.TabIndex = 10
        Button2.Text = "Next"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Week3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1373, 812)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Name = "Week3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
