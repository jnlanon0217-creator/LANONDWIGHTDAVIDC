<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Truthtable
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(468, 216)
        TextBox1.Margin = New Padding(4, 4, 4, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(208, 37)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(468, 328)
        TextBox2.Margin = New Padding(4, 4, 4, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(208, 37)
        TextBox2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(168, 224)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 30)
        Label1.TabIndex = 2
        Label1.Text = "INPUT 1(TRUE/FALSE)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(174, 330)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(276, 30)
        Label2.TabIndex = 3
        Label2.Text = "INPUT 2 (TRUE/FALSE)"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(868, 230)
        Button2.Margin = New Padding(4, 4, 4, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(157, 41)
        Button2.TabIndex = 5
        Button2.Text = "AND"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaptionText
        Button3.Location = New Point(868, 319)
        Button3.Margin = New Padding(4, 4, 4, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(157, 41)
        Button3.TabIndex = 6
        Button3.Text = "OR"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveCaptionText
        Button4.Location = New Point(1114, 230)
        Button4.Margin = New Padding(4, 4, 4, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(157, 41)
        Button4.TabIndex = 7
        Button4.Text = "XOR"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ActiveCaptionText
        Button5.Location = New Point(1114, 324)
        Button5.Margin = New Padding(4, 4, 4, 4)
        Button5.Name = "Button5"
        Button5.Size = New Size(157, 41)
        Button5.TabIndex = 8
        Button5.Text = "NOT"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Truthtable
        ' 
        AutoScaleDimensions = New SizeF(14F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        BackgroundImage = My.Resources.Resources.images__6_1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1391, 623)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Font = New Font("Bradley Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Coral
        Margin = New Padding(4, 4, 4, 4)
        Name = "Truthtable"
        Text = "Truthtable"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
