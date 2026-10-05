<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week5pt3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week5pt3))
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        TextBox3 = New TextBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1003, 655)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 78)
        Button2.TabIndex = 26
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1175, 655)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 78)
        Button1.TabIndex = 27
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(638, 55)
        Label1.TabIndex = 28
        Label1.Text = "Scope of Variables and Constants"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.InactiveBorder
        TextBox3.Location = New Point(12, 88)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.ScrollBars = ScrollBars.Vertical
        TextBox3.Size = New Size(811, 134)
        TextBox3.TabIndex = 29
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Screenshot_2026_09_17_183353
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(850, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(503, 366)
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(12, 237)
        Label2.Name = "Label2"
        Label2.Size = New Size(588, 55)
        Label2.TabIndex = 31
        Label2.Text = "Converting Output Data Types"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveCaptionText
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.MenuBar
        TextBox1.Location = New Point(12, 304)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(811, 134)
        TextBox1.TabIndex = 32
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(845, 408)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(525, 192)
        PictureBox2.TabIndex = 33
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Image = My.Resources.Resources.black_souls_black_souls_2
        PictureBox3.Location = New Point(12, 482)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(275, 251)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 34
        PictureBox3.TabStop = False
        ' 
        ' Week5pt3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1382, 756)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox3)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Name = "Week5pt3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week5pt3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
