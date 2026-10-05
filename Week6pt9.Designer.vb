<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week6pt9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week6pt9))
        Label2 = New Label()
        TextBox3 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Button4 = New Button()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Font = New Font("Bradley Hand ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(12, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(313, 45)
        Label2.TabIndex = 26
        Label2.Text = "Looping Statement"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.Window
        TextBox3.Location = New Point(12, 71)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.ScrollBars = ScrollBars.Vertical
        TextBox3.Size = New Size(567, 213)
        TextBox3.TabIndex = 27
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Bradley Hand ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(608, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 45)
        Label1.TabIndex = 28
        Label1.Text = "The Do While Loop"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveCaptionText
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.MenuBar
        TextBox1.Location = New Point(608, 71)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(436, 213)
        TextBox1.TabIndex = 29
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(1062, 49)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(266, 235)
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Bradley Hand ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(3, 301)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 45)
        Label3.TabIndex = 33
        Label3.Text = "Nested Loop"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ActiveCaptionText
        TextBox2.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.Window
        TextBox2.Location = New Point(12, 349)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.ScrollBars = ScrollBars.Vertical
        TextBox2.Size = New Size(513, 178)
        TextBox2.TabIndex = 34
        TextBox2.Text = resources.GetString("TextBox2.Text")
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(556, 290)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(528, 237)
        PictureBox2.TabIndex = 35
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(105, 545)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(814, 279)
        PictureBox3.TabIndex = 36
        PictureBox3.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveCaptionText
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(1039, 765)
        Button4.Name = "Button4"
        Button4.Size = New Size(162, 78)
        Button4.TabIndex = 37
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(1233, 765)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 78)
        Button1.TabIndex = 38
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Week6pt9
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download__11_
        ClientSize = New Size(1457, 855)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(Label2)
        Name = "Week6pt9"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week6pt9"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
End Class
