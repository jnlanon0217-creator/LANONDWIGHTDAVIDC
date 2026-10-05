<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week4pt4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week4pt4))
        Button1 = New Button()
        Button2 = New Button()
        TextBox3 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(966, 659)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 78)
        Button1.TabIndex = 13
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(1171, 659)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 78)
        Button2.TabIndex = 14
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.InactiveBorder
        TextBox3.Location = New Point(49, 67)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(1176, 184)
        TextBox3.TabIndex = 15
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(423, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(472, 55)
        Label1.TabIndex = 16
        Label1.Text = "Anchoring and Docking"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.InfoText
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.InactiveBorder
        TextBox1.Location = New Point(63, 327)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(459, 151)
        TextBox1.TabIndex = 17
        TextBox1.Text = "Start a new windows projects. Add two textboxes to your form, and set the MultiLine properties of both to True. Change the height of the boxes."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(169, 254)
        Label2.Name = "Label2"
        Label2.Size = New Size(222, 55)
        Label2.TabIndex = 18
        Label2.Text = "Anchoring"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ActiveCaptionText
        TextBox2.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.Menu
        TextBox2.Location = New Point(878, 339)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(428, 139)
        TextBox2.TabIndex = 19
        TextBox2.Text = "Docking is similar to Anchoring, but this time the control fills a certain area of the form. To see how it works"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(996, 266)
        Label3.Name = "Label3"
        Label3.Size = New Size(179, 55)
        Label3.TabIndex = 20
        Label3.Text = "Docking"
        ' 
        ' Week4pt4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2026_09_20_213212
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1373, 812)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        DoubleBuffered = True
        Name = "Week4pt4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week4pt4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
End Class
