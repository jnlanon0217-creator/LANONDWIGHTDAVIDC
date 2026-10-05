<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week4pt3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week4pt3))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox7 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(397, 55)
        Label1.TabIndex = 4
        Label1.Text = "Appearance of forms"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Screenshot_2026_09_16_085606
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(332, 94)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(293, 276)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(12, 94)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(299, 439)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(999, 453)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(293, 276)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(646, 94)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(319, 353)
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(999, 94)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(326, 353)
        PictureBox5.TabIndex = 9
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(646, 453)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(293, 276)
        PictureBox6.TabIndex = 10
        PictureBox6.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Desktop
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(1195, 792)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 78)
        Button2.TabIndex = 15
        Button2.Text = "Next"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(999, 792)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 78)
        Button1.TabIndex = 16
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BorderStyle = BorderStyle.Fixed3D
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(29, 601)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(485, 349)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 17
        PictureBox7.TabStop = False
        ' 
        ' Week4pt3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1373, 901)
        Controls.Add(PictureBox7)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "Week4pt3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week4pt3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox7 As PictureBox
End Class
