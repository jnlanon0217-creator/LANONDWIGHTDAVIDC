<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week6pt3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week6pt3))
        Label1 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        PictureBox2 = New PictureBox()
        Button4 = New Button()
        Button1 = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(2, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(399, 55)
        Label1.TabIndex = 20
        Label1.Text = "Relational Operators"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.ButtonHighlight
        TextBox3.Location = New Point(2, 67)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.ScrollBars = ScrollBars.Vertical
        TextBox3.Size = New Size(561, 309)
        TextBox3.TabIndex = 21
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(10, 393)
        Label2.Name = "Label2"
        Label2.Size = New Size(391, 55)
        Label2.TabIndex = 22
        Label2.Text = "Boolean Expressions"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveCaptionText
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.MenuBar
        TextBox1.Location = New Point(2, 470)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(532, 309)
        TextBox1.TabIndex = 23
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(861, 215)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(497, 300)
        PictureBox2.TabIndex = 24
        PictureBox2.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveCaptionText
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(983, 701)
        Button4.Name = "Button4"
        Button4.Size = New Size(162, 78)
        Button4.TabIndex = 25
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = False
        Button4.UseWaitCursor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(1170, 701)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 78)
        Button1.TabIndex = 26
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Week6pt3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2026_09_19_214550
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1370, 806)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Controls.Add(PictureBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Week6pt3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week6pt3"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
End Class
