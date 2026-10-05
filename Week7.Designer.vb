<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week7))
        TextBox3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.Window
        TextBox3.Location = New Point(12, 81)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.ScrollBars = ScrollBars.Vertical
        TextBox3.Size = New Size(1171, 122)
        TextBox3.TabIndex = 23
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(35, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 55)
        Label1.TabIndex = 24
        Label1.Text = "Arrays"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(21, 406)
        Label2.Name = "Label2"
        Label2.Size = New Size(439, 55)
        Label2.TabIndex = 25
        Label2.Text = "Arrays Characteristics"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveCaptionText
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.Window
        TextBox1.Location = New Point(21, 464)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(1171, 122)
        TextBox1.TabIndex = 26
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveCaptionText
        Button4.ForeColor = SystemColors.ButtonFace
        Button4.Location = New Point(860, 618)
        Button4.Name = "Button4"
        Button4.Size = New Size(162, 78)
        Button4.TabIndex = 28
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(1030, 618)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 78)
        Button1.TabIndex = 29
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Week7
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1229, 708)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        DoubleBuffered = True
        Name = "Week7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week7"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
End Class
