<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_ChangePassword
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
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 18)
        Label1.TabIndex = 0
        Label1.Text = "Security Question:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 18)
        Label2.TabIndex = 1
        Label2.Text = "Answer:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 18)
        Label3.TabIndex = 2
        Label3.Text = "New Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 306)
        Label4.Name = "Label4"
        Label4.Size = New Size(176, 18)
        Label4.TabIndex = 3
        Label4.Text = "Confirm New Password:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(231, 55)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(283, 26)
        ComboBox1.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(231, 131)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(283, 26)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(231, 219)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(283, 26)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(231, 299)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(283, 26)
        TextBox3.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(311, 369)
        Button1.Name = "Button1"
        Button1.Size = New Size(202, 28)
        Button1.TabIndex = 8
        Button1.Text = "Change Password"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(30, 369)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 28)
        Button2.TabIndex = 9
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Admin_ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 435)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "Admin_ChangePassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin_ChangePassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
