<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnUploadMaterial = New Button()
        btnAssignment = New Button()
        btnLogout = New Button()
        btnQuiz = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(201, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 25)
        Label1.TabIndex = 0
        Label1.Text = "LECTURER DASHBOARD"
        ' 
        ' btnUploadMaterial
        ' 
        btnUploadMaterial.BackColor = Color.Blue
        btnUploadMaterial.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUploadMaterial.Location = New Point(201, 102)
        btnUploadMaterial.Name = "btnUploadMaterial"
        btnUploadMaterial.Size = New Size(226, 47)
        btnUploadMaterial.TabIndex = 1
        btnUploadMaterial.Text = "Upload Course Material"
        btnUploadMaterial.UseVisualStyleBackColor = False
        ' 
        ' btnAssignment
        ' 
        btnAssignment.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        btnAssignment.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAssignment.Location = New Point(221, 177)
        btnAssignment.Name = "btnAssignment"
        btnAssignment.Size = New Size(175, 40)
        btnAssignment.TabIndex = 2
        btnAssignment.Text = "Assignment"
        btnAssignment.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Yellow
        btnLogout.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(252, 346)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(97, 35)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnQuiz
        ' 
        btnQuiz.BackColor = Color.RosyBrown
        btnQuiz.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnQuiz.Location = New Point(237, 252)
        btnQuiz.Name = "btnQuiz"
        btnQuiz.Size = New Size(130, 37)
        btnQuiz.TabIndex = 4
        btnQuiz.Text = "Quiz"
        btnQuiz.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chartreuse
        ClientSize = New Size(686, 450)
        Controls.Add(btnQuiz)
        Controls.Add(btnLogout)
        Controls.Add(btnAssignment)
        Controls.Add(btnUploadMaterial)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "LECTURER_DASHBOARD"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnUploadMaterial As Button
    Friend WithEvents btnAssignment As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnQuiz As Button
End Class
