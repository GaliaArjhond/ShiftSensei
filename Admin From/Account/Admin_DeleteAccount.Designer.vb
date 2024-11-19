<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_DeleteAccount
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
        ComboBox2 = New ComboBox()
        RichTextBox1 = New RichTextBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 18)
        Label1.TabIndex = 0
        Label1.Text = "Nurse Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 18)
        Label2.TabIndex = 1
        Label2.Text = "License Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 18)
        Label3.TabIndex = 2
        Label3.Text = "Reason for Deletion: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 412)
        Label4.Name = "Label4"
        Label4.Size = New Size(175, 18)
        Label4.TabIndex = 3
        Label4.Text = "Password Confirmation:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(259, 49)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(297, 26)
        ComboBox1.TabIndex = 4
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(259, 122)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(297, 26)
        ComboBox2.TabIndex = 5
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(259, 210)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(297, 163)
        RichTextBox1.TabIndex = 6
        RichTextBox1.Text = ""
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(259, 409)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(297, 26)
        TextBox1.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(430, 479)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 31)
        Button1.TabIndex = 8
        Button1.Text = "Delete Account"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(48, 479)
        Button2.Name = "Button2"
        Button2.Size = New Size(126, 31)
        Button2.TabIndex = 9
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Admin_DeleteAccount
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(603, 535)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(RichTextBox1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "Admin_DeleteAccount"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin_DeleteAccount"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
