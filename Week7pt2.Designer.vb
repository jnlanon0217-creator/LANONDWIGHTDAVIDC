<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week7pt2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week7pt2))
        TextBox3 = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.Window
        TextBox3.Location = New Point(12, 343)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.ScrollBars = ScrollBars.Vertical
        TextBox3.Size = New Size(455, 323)
        TextBox3.TabIndex = 24
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(12, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(385, 55)
        Label1.TabIndex = 25
        Label1.Text = "Declaring an Array"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_09_30_172425
        PictureBox1.Location = New Point(12, 105)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(449, 210)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(473, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(417, 55)
        Label2.TabIndex = 27
        Label2.Text = "Default Initialization"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveCaptionText
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.Window
        TextBox1.Location = New Point(473, 105)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(663, 203)
        TextBox1.TabIndex = 28
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(473, 318)
        Label3.Name = "Label3"
        Label3.Size = New Size(777, 55)
        Label3.TabIndex = 29
        Label3.Text = "Implicit Array Sizing and Initialization"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ActiveCaptionText
        TextBox2.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.Window
        TextBox2.Location = New Point(473, 441)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.ScrollBars = ScrollBars.Vertical
        TextBox2.Size = New Size(663, 203)
        TextBox2.TabIndex = 30
        TextBox2.Text = resources.GetString("TextBox2.Text")
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(473, 386)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(790, 49)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 31
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(1151, 674)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 78)
        Button1.TabIndex = 32
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(964, 674)
        Button2.Name = "Button2"
        Button2.Size = New Size(162, 78)
        Button2.TabIndex = 33
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Week7pt2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download__7_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1337, 764)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Name = "Week7pt2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week7pt2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
