<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week3pt2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week3pt2))
        TextBox3 = New TextBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.Menu
        TextBox3.Location = New Point(65, 616)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(1176, 105)
        TextBox3.TabIndex = 4
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(486, 517)
        Label1.Name = "Label1"
        Label1.Size = New Size(343, 55)
        Label1.TabIndex = 5
        Label1.Text = "Exploring the IDE"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(23, 25)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(431, 369)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(911, 25)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(450, 370)
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Desktop
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(1181, 711)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 78)
        Button2.TabIndex = 11
        Button2.Text = "EXIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(990, 711)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 78)
        Button1.TabIndex = 12
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Week3pt2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImage = My.Resources.Resources.images__6_
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1373, 812)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Name = "Week3pt2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week3pt2"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
