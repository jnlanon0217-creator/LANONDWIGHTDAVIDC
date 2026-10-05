<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week4))
        Label1 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(42, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(432, 55)
        Label1.TabIndex = 2
        Label1.Text = "VB.Net Basic Controls"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = Color.FloralWhite
        TextBox3.Location = New Point(42, 100)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(1176, 152)
        TextBox3.TabIndex = 4
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(42, 255)
        Label2.Name = "Label2"
        Label2.Size = New Size(342, 55)
        Label2.TabIndex = 5
        Label2.Text = "Control Properties"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveCaptionText
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.InactiveBorder
        TextBox1.Location = New Point(42, 313)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(1176, 152)
        TextBox1.TabIndex = 6
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(42, 479)
        Label3.Name = "Label3"
        Label3.Size = New Size(322, 55)
        Label3.TabIndex = 7
        Label3.Text = "Control Methods"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ActiveCaptionText
        TextBox2.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.InactiveBorder
        TextBox2.Location = New Point(42, 537)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.ScrollBars = ScrollBars.Vertical
        TextBox2.Size = New Size(1176, 152)
        TextBox2.TabIndex = 8
        TextBox2.Text = resources.GetString("TextBox2.Text")
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1000, 722)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 78)
        Button1.TabIndex = 13
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1184, 722)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 78)
        Button2.TabIndex = 14
        Button2.Text = "Next"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Week4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._683f000ecbb775c5462258ce625d9ebe
        ClientSize = New Size(1373, 812)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(Label1)
        Name = "Week4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
