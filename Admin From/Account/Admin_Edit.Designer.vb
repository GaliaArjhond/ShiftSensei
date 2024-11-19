<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Edit
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button3 = New Button()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        TextBox3 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker3 = New DateTimePicker()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 18)
        Label1.TabIndex = 0
        Label1.Text = "First name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 18)
        Label2.TabIndex = 1
        Label2.Text = "Middle name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 18)
        Label3.TabIndex = 2
        Label3.Text = "Last name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(43, 277)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 18)
        Label4.TabIndex = 3
        Label4.Text = "Experience Level:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(43, 351)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 18)
        Label5.TabIndex = 4
        Label5.Text = "Department:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(25, 68)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 18)
        Label7.TabIndex = 6
        Label7.Text = "Day of week:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(25, 137)
        Label8.Name = "Label8"
        Label8.Size = New Size(117, 18)
        Label8.TabIndex = 7
        Label8.Text = "Available From:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(25, 204)
        Label9.Name = "Label9"
        Label9.Size = New Size(96, 18)
        Label9.TabIndex = 8
        Label9.Text = "Available To:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(ComboBox3)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(27, 11)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(380, 463)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Profile"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DateTimePicker3)
        GroupBox2.Controls.Add(DateTimePicker2)
        GroupBox2.Controls.Add(DateTimePicker1)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Location = New Point(443, 11)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(401, 261)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "Availability"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(625, 310)
        Button1.Name = "Button1"
        Button1.Size = New Size(189, 36)
        Button1.TabIndex = 11
        Button1.Text = "Save changes"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(625, 365)
        Button2.Name = "Button2"
        Button2.Size = New Size(189, 36)
        Button2.TabIndex = 12
        Button2.Text = "Change Password"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(166, 51)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(185, 26)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(166, 131)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(185, 26)
        TextBox2.TabIndex = 1
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(625, 424)
        Button3.Name = "Button3"
        Button3.Size = New Size(189, 36)
        Button3.TabIndex = 13
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(16, 413)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 18)
        Label6.TabIndex = 14
        Label6.Text = "Position:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(166, 258)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(185, 26)
        ComboBox1.TabIndex = 15
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(166, 333)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(185, 26)
        ComboBox2.TabIndex = 16
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(166, 405)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(185, 26)
        ComboBox3.TabIndex = 17
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(166, 187)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(185, 26)
        TextBox3.TabIndex = 18
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(173, 62)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(180, 26)
        DateTimePicker1.TabIndex = 9
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(173, 131)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(180, 26)
        DateTimePicker2.TabIndex = 10
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Location = New Point(173, 203)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(180, 26)
        DateTimePicker3.TabIndex = 11
        ' 
        ' Admin_Edit
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(873, 504)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "Admin_Edit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
