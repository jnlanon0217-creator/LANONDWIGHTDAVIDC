<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class game2
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(game2))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Timer3 = New Timer(components)
        Label1 = New Label()
        Button3 = New Button()
        Timer4 = New Timer(components)
        PictureBox3 = New PictureBox()
        Timer5 = New Timer(components)
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Screenshot_2026_10_01_134953_removebg_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(278, 259)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 286)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        PictureBox1.WaitOnLoad = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.Screenshot_2026_10_01_135310_removebg_preview
        PictureBox2.Location = New Point(707, 241)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(424, 323)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Font = New Font("Bradley Hand ITC", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(130, 586)
        Button1.Name = "Button1"
        Button1.Size = New Size(241, 96)
        Button1.TabIndex = 2
        Button1.Text = "Slash"
        Button1.UseCompatibleTextRendering = True
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.Font = New Font("Bradley Hand ITC", 16F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(377, 586)
        Button2.Name = "Button2"
        Button2.Size = New Size(239, 96)
        Button2.TabIndex = 3
        Button2.Text = "Injection"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.InfoText
        TextBox1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.ForestGreen
        TextBox1.Location = New Point(863, 189)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 46)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Black
        TextBox2.Font = New Font("Bradley Hand ITC", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.Chartreuse
        TextBox2.Location = New Point(278, 189)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 46)
        TextBox2.TabIndex = 7
        ' 
        ' Timer1
        ' 
        ' 
        ' Timer2
        ' 
        ' 
        ' Timer3
        ' 
        Timer3.Interval = 30
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Britannic Bold", 22F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(162, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 48)
        Label1.TabIndex = 8
        Label1.Text = "DAMAGED"
        Label1.Visible = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaptionText
        Button3.Font = New Font("Bradley Hand ITC", 16F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Red
        Button3.Location = New Point(622, 586)
        Button3.Name = "Button3"
        Button3.Size = New Size(239, 96)
        Button3.TabIndex = 9
        Button3.Text = "Blood moon"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Timer4
        ' 
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(707, 241)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(398, 339)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        PictureBox3.Visible = False
        ' 
        ' Timer5
        ' 
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(190, 241)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(238, 286)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        PictureBox4.Visible = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(190, 241)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(250, 312)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 12
        PictureBox5.TabStop = False
        PictureBox5.Visible = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(202, 241)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(238, 312)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 13
        PictureBox6.TabStop = False
        PictureBox6.Visible = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(403, 145)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(376, 408)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 14
        PictureBox7.TabStop = False
        PictureBox7.Visible = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(278, 136)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(611, 417)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 15
        PictureBox8.TabStop = False
        PictureBox8.Visible = False
        ' 
        ' game2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BackgroundImage = My.Resources.Resources.Lake_of_Rot__1_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1300, 705)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "game2"
        Text = "game2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer4 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer5 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
