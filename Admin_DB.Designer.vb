<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_DB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-9, -13)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(264, 709)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(3, 131)
        Button1.Name = "Button1"
        Button1.Size = New Size(261, 48)
        Button1.TabIndex = 0
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(3, 185)
        Button2.Name = "Button2"
        Button2.Size = New Size(261, 48)
        Button2.TabIndex = 1
        Button2.Text = "Create Shift"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Location = New Point(3, 239)
        Button3.Name = "Button3"
        Button3.Size = New Size(261, 48)
        Button3.TabIndex = 2
        Button3.Text = "Schedule"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ButtonFace
        Button4.Location = New Point(3, 293)
        Button4.Name = "Button4"
        Button4.Size = New Size(261, 48)
        Button4.TabIndex = 3
        Button4.Text = "Nurse"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ButtonFace
        Button5.Location = New Point(3, 347)
        Button5.Name = "Button5"
        Button5.Size = New Size(261, 48)
        Button5.TabIndex = 4
        Button5.Text = "Report"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = SystemColors.ButtonFace
        Button6.Location = New Point(3, 401)
        Button6.Name = "Button6"
        Button6.Size = New Size(261, 48)
        Button6.TabIndex = 5
        Button6.Text = "Profile"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = SystemColors.ButtonFace
        Button7.Location = New Point(3, 455)
        Button7.Name = "Button7"
        Button7.Size = New Size(261, 48)
        Button7.TabIndex = 6
        Button7.Text = "Account"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = SystemColors.ButtonFace
        Button8.Location = New Point(3, 649)
        Button8.Name = "Button8"
        Button8.Size = New Size(261, 48)
        Button8.TabIndex = 7
        Button8.Text = "Log out"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Admin_DB
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 681)
        Controls.Add(Panel1)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4)
        Name = "Admin_DB"
        Text = "Admin Dashboard"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button

End Class
