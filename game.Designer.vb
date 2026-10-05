<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(game))
        btnGo = New Button()
        gameTimer = New Timer(components)
        picBoat = New PictureBox()
        picM1 = New PictureBox()
        picM2 = New PictureBox()
        picM3 = New PictureBox()
        picC1 = New PictureBox()
        picC2 = New PictureBox()
        picC3 = New PictureBox()
        CType(picBoat, ComponentModel.ISupportInitialize).BeginInit()
        CType(picM1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picM2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picM3, ComponentModel.ISupportInitialize).BeginInit()
        CType(picC1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picC2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picC3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGo
        ' 
        btnGo.BackColor = Color.Black
        btnGo.BackgroundImageLayout = ImageLayout.Center
        btnGo.Font = New Font("Showcard Gothic", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnGo.ForeColor = Color.Red
        btnGo.Location = New Point(450, 84)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(138, 63)
        btnGo.TabIndex = 0
        btnGo.Text = "GO!"
        btnGo.UseVisualStyleBackColor = False
        ' 
        ' gameTimer
        ' 
        ' 
        ' picBoat
        ' 
        picBoat.BackColor = Color.Transparent
        picBoat.BackgroundImageLayout = ImageLayout.Stretch
        picBoat.Image = CType(resources.GetObject("picBoat.Image"), Image)
        picBoat.Location = New Point(401, 328)
        picBoat.Name = "picBoat"
        picBoat.Size = New Size(205, 112)
        picBoat.SizeMode = PictureBoxSizeMode.StretchImage
        picBoat.TabIndex = 8
        picBoat.TabStop = False
        ' 
        ' picM1
        ' 
        picM1.BackColor = Color.Transparent
        picM1.BackgroundImageLayout = ImageLayout.Stretch
        picM1.Image = CType(resources.GetObject("picM1.Image"), Image)
        picM1.Location = New Point(47, 72)
        picM1.Name = "picM1"
        picM1.Size = New Size(142, 160)
        picM1.SizeMode = PictureBoxSizeMode.StretchImage
        picM1.TabIndex = 9
        picM1.TabStop = False
        ' 
        ' picM2
        ' 
        picM2.BackColor = Color.Transparent
        picM2.Image = CType(resources.GetObject("picM2.Image"), Image)
        picM2.Location = New Point(213, 72)
        picM2.Name = "picM2"
        picM2.Size = New Size(150, 160)
        picM2.SizeMode = PictureBoxSizeMode.StretchImage
        picM2.TabIndex = 10
        picM2.TabStop = False
        ' 
        ' picM3
        ' 
        picM3.BackColor = Color.Transparent
        picM3.Image = CType(resources.GetObject("picM3.Image"), Image)
        picM3.Location = New Point(690, 72)
        picM3.Name = "picM3"
        picM3.Size = New Size(150, 178)
        picM3.SizeMode = PictureBoxSizeMode.StretchImage
        picM3.TabIndex = 11
        picM3.TabStop = False
        ' 
        ' picC1
        ' 
        picC1.BackColor = Color.Transparent
        picC1.Image = CType(resources.GetObject("picC1.Image"), Image)
        picC1.Location = New Point(856, 72)
        picC1.Name = "picC1"
        picC1.Size = New Size(150, 178)
        picC1.SizeMode = PictureBoxSizeMode.StretchImage
        picC1.TabIndex = 12
        picC1.TabStop = False
        ' 
        ' picC2
        ' 
        picC2.Image = My.Resources.Resources.Screenshot_2026_09_30_162650
        picC2.Location = New Point(1012, 72)
        picC2.Name = "picC2"
        picC2.Size = New Size(150, 178)
        picC2.SizeMode = PictureBoxSizeMode.StretchImage
        picC2.TabIndex = 13
        picC2.TabStop = False
        ' 
        ' picC3
        ' 
        picC3.Image = My.Resources.Resources.Screenshot_2026_09_30_1626501
        picC3.Location = New Point(1178, 72)
        picC3.Name = "picC3"
        picC3.Size = New Size(150, 178)
        picC3.SizeMode = PictureBoxSizeMode.StretchImage
        picC3.TabIndex = 14
        picC3.TabStop = False
        ' 
        ' game
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1408, 944)
        Controls.Add(picC3)
        Controls.Add(picC2)
        Controls.Add(picC1)
        Controls.Add(picM3)
        Controls.Add(picM2)
        Controls.Add(picM1)
        Controls.Add(picBoat)
        Controls.Add(btnGo)
        DoubleBuffered = True
        Name = "game"
        StartPosition = FormStartPosition.CenterScreen
        Text = "game"
        CType(picBoat, ComponentModel.ISupportInitialize).EndInit()
        CType(picM1, ComponentModel.ISupportInitialize).EndInit()
        CType(picM2, ComponentModel.ISupportInitialize).EndInit()
        CType(picM3, ComponentModel.ISupportInitialize).EndInit()
        CType(picC1, ComponentModel.ISupportInitialize).EndInit()
        CType(picC2, ComponentModel.ISupportInitialize).EndInit()
        CType(picC3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents gameTimer As Timer
    Friend WithEvents picBoat As PictureBox
    Friend WithEvents picM1 As PictureBox
    Friend WithEvents picM2 As PictureBox
    Friend WithEvents picM3 As PictureBox
    Friend WithEvents picC1 As PictureBox
    Friend WithEvents picC2 As PictureBox
    Friend WithEvents picC3 As PictureBox
End Class
