<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week6pt7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week6pt7))
        Label1 = New Label()
        TextBox3 = New TextBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(327, 55)
        Label1.TabIndex = 24
        Label1.Text = "The Xor Operator"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.MenuBar
        TextBox3.Location = New Point(12, 67)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.ScrollBars = ScrollBars.Vertical
        TextBox3.Size = New Size(1256, 108)
        TextBox3.TabIndex = 25
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(2, 181)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(655, 156)
        PictureBox3.TabIndex = 33
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(661, 181)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(696, 162)
        PictureBox1.TabIndex = 34
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveCaptionText
        Button4.ForeColor = SystemColors.Control
        Button4.Location = New Point(992, 655)
        Button4.Name = "Button4"
        Button4.Size = New Size(162, 78)
        Button4.TabIndex = 37
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(1160, 655)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 78)
        Button1.TabIndex = 38
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(12, 340)
        Label2.Name = "Label2"
        Label2.Size = New Size(331, 55)
        Label2.TabIndex = 39
        Label2.Text = "The Not Operator"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveCaptionText
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.Window
        TextBox1.Location = New Point(12, 398)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(1256, 108)
        TextBox1.TabIndex = 40
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(12, 512)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(645, 140)
        PictureBox2.TabIndex = 41
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(681, 512)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(533, 122)
        PictureBox4.TabIndex = 42
        PictureBox4.TabStop = False
        ' 
        ' Week6pt7
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download__10_
        ClientSize = New Size(1369, 754)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        Controls.Add(TextBox3)
        Controls.Add(Label1)
        Name = "Week6pt7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week6pt7"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
