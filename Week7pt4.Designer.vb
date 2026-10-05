<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week7pt4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week7pt4))
        Label1 = New Label()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(12, 367)
        Label1.Name = "Label1"
        Label1.Size = New Size(749, 55)
        Label1.TabIndex = 27
        Label1.Text = "Three-Dimensional Arrays and Beyond"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveCaptionText
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.Window
        TextBox1.Location = New Point(12, 445)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(1246, 156)
        TextBox1.TabIndex = 30
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(801, 212)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(449, 210)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(915, 631)
        Button2.Name = "Button2"
        Button2.Size = New Size(162, 78)
        Button2.TabIndex = 35
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(1083, 631)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 78)
        Button1.TabIndex = 36
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Week7pt4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.final_part_the_Leaf_in_black_souls
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1331, 721)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Week7pt4"
        Text = "Week7pt4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
