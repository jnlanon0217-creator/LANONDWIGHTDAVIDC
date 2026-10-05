<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week5pt4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Week5pt4))
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(1185, 651)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 78)
        Button1.TabIndex = 27
        Button1.Text = "EXIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(998, 651)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 78)
        Button2.TabIndex = 28
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(22, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(406, 55)
        Label1.TabIndex = 29
        Label1.Text = "Arithmetic Operators"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.InactiveBorder
        TextBox3.Location = New Point(22, 102)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.ScrollBars = ScrollBars.Vertical
        TextBox3.Size = New Size(689, 221)
        TextBox3.TabIndex = 30
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Bradley Hand ITC", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(22, 327)
        Label2.Name = "Label2"
        Label2.Size = New Size(708, 55)
        Label2.TabIndex = 31
        Label2.Text = "Assignment Operators and Formulas"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveCaptionText
        TextBox1.Font = New Font("Bradley Hand ITC", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.InactiveBorder
        TextBox1.Location = New Point(22, 385)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(708, 221)
        TextBox1.TabIndex = 32
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' Week5pt4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.dgi1v5e_4bdf25e2_e70d_42d2_ac1b_5f216b6a6f3e1
        ClientSize = New Size(1376, 751)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Week5pt4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week5pt4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
