<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DigitalClock
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
        lblDigitalClock = New Label()
        Label1 = New Label()
        txtShortDate2 = New Label()
        txtFormattedDate = New Label()
        txtLongDate = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' lblDigitalClock
        ' 
        lblDigitalClock.AutoSize = True
        lblDigitalClock.Location = New Point(904, 251)
        lblDigitalClock.Margin = New Padding(6, 0, 6, 0)
        lblDigitalClock.Name = "lblDigitalClock"
        lblDigitalClock.Size = New Size(0, 40)
        lblDigitalClock.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(843, 174)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 40)
        Label1.TabIndex = 1
        Label1.Text = "DATE TIME"
        ' 
        ' txtShortDate2
        ' 
        txtShortDate2.AutoSize = True
        txtShortDate2.BackColor = Color.Transparent
        txtShortDate2.Location = New Point(596, 342)
        txtShortDate2.Margin = New Padding(6, 0, 6, 0)
        txtShortDate2.Name = "txtShortDate2"
        txtShortDate2.Size = New Size(262, 40)
        txtShortDate2.TabIndex = 3
        txtShortDate2.Text = "DIGITAL CLOCK"
        ' 
        ' txtFormattedDate
        ' 
        txtFormattedDate.AutoSize = True
        txtFormattedDate.BackColor = Color.Transparent
        txtFormattedDate.Location = New Point(596, 435)
        txtFormattedDate.Margin = New Padding(6, 0, 6, 0)
        txtFormattedDate.Name = "txtFormattedDate"
        txtFormattedDate.Size = New Size(262, 40)
        txtFormattedDate.TabIndex = 4
        txtFormattedDate.Text = "DIGITAL CLOCK"
        ' 
        ' txtLongDate
        ' 
        txtLongDate.AutoSize = True
        txtLongDate.BackColor = Color.Transparent
        txtLongDate.Location = New Point(618, 551)
        txtLongDate.Margin = New Padding(6, 0, 6, 0)
        txtLongDate.Name = "txtLongDate"
        txtLongDate.Size = New Size(262, 40)
        txtLongDate.TabIndex = 5
        txtLongDate.Text = "DIGITAL CLOCK"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(1100, 328)
        Button1.Margin = New Padding(6, 5, 6, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(213, 54)
        Button1.TabIndex = 6
        Button1.Text = "DATE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Desktop
        Button2.Location = New Point(1111, 435)
        Button2.Margin = New Padding(6, 5, 6, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(213, 54)
        Button2.TabIndex = 7
        Button2.Text = "WEEK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Desktop
        Button3.Location = New Point(1111, 551)
        Button3.Margin = New Padding(6, 5, 6, 5)
        Button3.Name = "Button3"
        Button3.Size = New Size(213, 54)
        Button3.TabIndex = 8
        Button3.Text = "MONTH"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' DigitalClock
        ' 
        AutoScaleDimensions = New SizeF(19F, 40F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Desktop
        BackgroundImage = My.Resources.Resources._130203668
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1523, 936)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtLongDate)
        Controls.Add(txtFormattedDate)
        Controls.Add(txtShortDate2)
        Controls.Add(Label1)
        Controls.Add(lblDigitalClock)
        Font = New Font("Bradley Hand ITC", 16F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ButtonHighlight
        Margin = New Padding(6, 5, 6, 5)
        Name = "DigitalClock"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DigitalClock"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblDigitalClock As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtShortDate2 As Label
    Friend WithEvents txtFormattedDate As Label
    Friend WithEvents txtLongDate As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
End Class
