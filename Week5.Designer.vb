<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week5))
        Label1 = New Label()
        TextBox3 = New TextBox()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(32, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(304, 55)
        Label1.TabIndex = 17
        Label1.Text = "Handling Data"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(32, 67)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.ScrollBars = ScrollBars.Vertical
        TextBox3.Size = New Size(1176, 134)
        TextBox3.TabIndex = 18
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_09_17_180303
        PictureBox1.Location = New Point(1001, 265)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(266, 132)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(32, 277)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(922, 120)
        TextBox1.TabIndex = 20
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(32, 219)
        Label2.Name = "Label2"
        Label2.Size = New Size(276, 55)
        Label2.TabIndex = 21
        Label2.Text = "Types of Data"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(32, 403)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(406, 275)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(444, 403)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(482, 275)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 23
        PictureBox3.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.ForeColor = Color.DarkOliveGreen
        Button2.Location = New Point(1042, 662)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 78)
        Button2.TabIndex = 24
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1214, 662)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 78)
        Button1.TabIndex = 25
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Week5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1392, 752)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox3)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Week5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
