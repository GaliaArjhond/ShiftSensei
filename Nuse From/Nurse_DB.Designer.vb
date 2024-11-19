<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nurse_DB
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
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        btnlogout = New Button()
        btnaccount = New Button()
        btnprofile = New Button()
        btnreport = New Button()
        btnnurse = New Button()
        btnschedule = New Button()
        btncreateShift = New Button()
        btndashboard = New Button()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkBlue
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(0, 1)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(284, 113)
        Panel2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLight
        Label1.Location = New Point(34, 39)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 38)
        Label1.TabIndex = 0
        Label1.Text = "Shift Sensei"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.Controls.Add(btnlogout)
        Panel1.Controls.Add(btnaccount)
        Panel1.Controls.Add(btnprofile)
        Panel1.Controls.Add(btnreport)
        Panel1.Controls.Add(btnnurse)
        Panel1.Controls.Add(btnschedule)
        Panel1.Controls.Add(btncreateShift)
        Panel1.Controls.Add(btndashboard)
        Panel1.Location = New Point(-10, -12)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(294, 749)
        Panel1.TabIndex = 2
        ' 
        ' btnlogout
        ' 
        btnlogout.FlatAppearance.BorderSize = 0
        btnlogout.FlatStyle = FlatStyle.Flat
        btnlogout.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnlogout.ForeColor = SystemColors.ButtonFace
        btnlogout.Location = New Point(4, 646)
        btnlogout.Margin = New Padding(4, 3, 4, 3)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(290, 50)
        btnlogout.TabIndex = 8
        btnlogout.Text = "Log out"
        btnlogout.UseVisualStyleBackColor = True
        ' 
        ' btnaccount
        ' 
        btnaccount.FlatAppearance.BorderSize = 0
        btnaccount.FlatStyle = FlatStyle.Flat
        btnaccount.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnaccount.ForeColor = SystemColors.ButtonFace
        btnaccount.Location = New Point(4, 515)
        btnaccount.Margin = New Padding(4, 3, 4, 3)
        btnaccount.Name = "btnaccount"
        btnaccount.Size = New Size(290, 50)
        btnaccount.TabIndex = 6
        btnaccount.Text = "Account"
        btnaccount.UseVisualStyleBackColor = True
        ' 
        ' btnprofile
        ' 
        btnprofile.FlatAppearance.BorderSize = 0
        btnprofile.FlatStyle = FlatStyle.Flat
        btnprofile.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnprofile.ForeColor = SystemColors.ButtonFace
        btnprofile.Location = New Point(4, 458)
        btnprofile.Margin = New Padding(4, 3, 4, 3)
        btnprofile.Name = "btnprofile"
        btnprofile.Size = New Size(290, 50)
        btnprofile.TabIndex = 5
        btnprofile.Text = "Profile"
        btnprofile.UseVisualStyleBackColor = True
        ' 
        ' btnreport
        ' 
        btnreport.FlatAppearance.BorderSize = 0
        btnreport.FlatStyle = FlatStyle.Flat
        btnreport.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnreport.ForeColor = SystemColors.ButtonFace
        btnreport.Location = New Point(4, 401)
        btnreport.Margin = New Padding(4, 3, 4, 3)
        btnreport.Name = "btnreport"
        btnreport.Size = New Size(290, 50)
        btnreport.TabIndex = 4
        btnreport.Text = "Report"
        btnreport.UseVisualStyleBackColor = True
        ' 
        ' btnnurse
        ' 
        btnnurse.FlatAppearance.BorderSize = 0
        btnnurse.FlatStyle = FlatStyle.Flat
        btnnurse.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnnurse.ForeColor = SystemColors.ButtonFace
        btnnurse.Location = New Point(4, 344)
        btnnurse.Margin = New Padding(4, 3, 4, 3)
        btnnurse.Name = "btnnurse"
        btnnurse.Size = New Size(290, 50)
        btnnurse.TabIndex = 3
        btnnurse.Text = "Nurse"
        btnnurse.UseVisualStyleBackColor = True
        ' 
        ' btnschedule
        ' 
        btnschedule.FlatAppearance.BorderSize = 0
        btnschedule.FlatStyle = FlatStyle.Flat
        btnschedule.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnschedule.ForeColor = SystemColors.ButtonFace
        btnschedule.Location = New Point(4, 287)
        btnschedule.Margin = New Padding(4, 3, 4, 3)
        btnschedule.Name = "btnschedule"
        btnschedule.Size = New Size(290, 50)
        btnschedule.TabIndex = 2
        btnschedule.Text = "Schedule"
        btnschedule.UseVisualStyleBackColor = True
        ' 
        ' btncreateShift
        ' 
        btncreateShift.FlatAppearance.BorderSize = 0
        btncreateShift.FlatStyle = FlatStyle.Flat
        btncreateShift.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btncreateShift.ForeColor = SystemColors.ButtonFace
        btncreateShift.Location = New Point(4, 230)
        btncreateShift.Margin = New Padding(4, 3, 4, 3)
        btncreateShift.Name = "btncreateShift"
        btncreateShift.Size = New Size(290, 50)
        btncreateShift.TabIndex = 1
        btncreateShift.Text = "Create Shift"
        btncreateShift.UseVisualStyleBackColor = True
        ' 
        ' btndashboard
        ' 
        btndashboard.BackColor = Color.MidnightBlue
        btndashboard.FlatAppearance.BorderSize = 0
        btndashboard.FlatStyle = FlatStyle.Flat
        btndashboard.Font = New Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btndashboard.ForeColor = SystemColors.ButtonFace
        btndashboard.Location = New Point(4, 173)
        btndashboard.Margin = New Padding(4, 3, 4, 3)
        btndashboard.Name = "btndashboard"
        btndashboard.Size = New Size(290, 50)
        btndashboard.TabIndex = 0
        btndashboard.Text = "Home"
        btndashboard.UseVisualStyleBackColor = False
        ' 
        ' Nurse_DB
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 681)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "Nurse_DB"
        Text = "Nurse_DB"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnaccount As Button
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnreport As Button
    Friend WithEvents btnnurse As Button
    Friend WithEvents btnschedule As Button
    Friend WithEvents btncreateShift As Button
    Friend WithEvents btndashboard As Button
End Class
