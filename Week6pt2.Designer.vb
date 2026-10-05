<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week6pt2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week6pt2))
        Button2 = New Button()
        Button4 = New Button()
        TextBox3 = New TextBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Desktop
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(1178, 627)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 78)
        Button2.TabIndex = 17
        Button2.Text = "Next"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveCaptionText
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(987, 627)
        Button4.Name = "Button4"
        Button4.Size = New Size(162, 78)
        Button4.TabIndex = 16
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.Window
        TextBox3.Location = New Point(23, 450)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.ScrollBars = ScrollBars.Vertical
        TextBox3.Size = New Size(734, 255)
        TextBox3.TabIndex = 18
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(12, 376)
        Label1.Name = "Label1"
        Label1.Size = New Size(601, 55)
        Label1.TabIndex = 19
        Label1.Text = "The If…Then…ElseIf Statement"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(929, 303)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(415, 300)
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(913, 26)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(463, 255)
        PictureBox3.TabIndex = 22
        PictureBox3.TabStop = False
        ' 
        ' Week6pt2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1388, 726)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(Button2)
        Controls.Add(Button4)
        DoubleBuffered = True
        Name = "Week6pt2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week6pt2"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
