<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        grpOptions = New GroupBox()
        rbOption3 = New RadioButton()
        rbOption2 = New RadioButton()
        rbOption1 = New RadioButton()
        btnSubmitQuiz = New Button()
        lblQuestion = New Label()
        Button1 = New Button()
        grpOptions.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(284, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 25)
        Label1.TabIndex = 0
        Label1.Text = "Quiz Section"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(175, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 17)
        Label2.TabIndex = 1
        Label2.Text = "Question :"
        ' 
        ' grpOptions
        ' 
        grpOptions.Controls.Add(rbOption1)
        grpOptions.Controls.Add(rbOption2)
        grpOptions.Controls.Add(rbOption3)
        grpOptions.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpOptions.Location = New Point(166, 194)
        grpOptions.Name = "grpOptions"
        grpOptions.Size = New Size(394, 146)
        grpOptions.TabIndex = 2
        grpOptions.TabStop = False
        grpOptions.Text = "Choose Answer"
        ' 
        ' rbOption3
        ' 
        rbOption3.AutoSize = True
        rbOption3.Location = New Point(38, 110)
        rbOption3.Name = "rbOption3"
        rbOption3.Size = New Size(33, 21)
        rbOption3.TabIndex = 3
        rbOption3.TabStop = True
        rbOption3.Text = "6"
        rbOption3.UseVisualStyleBackColor = True
        ' 
        ' rbOption2
        ' 
        rbOption2.AutoSize = True
        rbOption2.Location = New Point(38, 76)
        rbOption2.Name = "rbOption2"
        rbOption2.Size = New Size(33, 21)
        rbOption2.TabIndex = 4
        rbOption2.TabStop = True
        rbOption2.Text = "5"
        rbOption2.UseVisualStyleBackColor = True
        ' 
        ' rbOption1
        ' 
        rbOption1.AutoSize = True
        rbOption1.Location = New Point(38, 40)
        rbOption1.Name = "rbOption1"
        rbOption1.Size = New Size(33, 21)
        rbOption1.TabIndex = 5
        rbOption1.TabStop = True
        rbOption1.Text = "4"
        rbOption1.UseVisualStyleBackColor = True
        ' 
        ' btnSubmitQuiz
        ' 
        btnSubmitQuiz.Location = New Point(204, 356)
        btnSubmitQuiz.Name = "btnSubmitQuiz"
        btnSubmitQuiz.Size = New Size(111, 23)
        btnSubmitQuiz.TabIndex = 6
        btnSubmitQuiz.Text = "Submit  Answer"
        btnSubmitQuiz.UseVisualStyleBackColor = True
        ' 
        ' lblQuestion
        ' 
        lblQuestion.AutoSize = True
        lblQuestion.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQuestion.Location = New Point(284, 136)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(90, 17)
        lblQuestion.TabIndex = 7
        lblQuestion.Text = "What is 2 + 2 "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(436, 370)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(lblQuestion)
        Controls.Add(btnSubmitQuiz)
        Controls.Add(grpOptions)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "QUIZ_SECTION"
        grpOptions.ResumeLayout(False)
        grpOptions.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents rbOption3 As RadioButton
    Friend WithEvents rbOption2 As RadioButton
    Friend WithEvents rbOption1 As RadioButton
    Friend WithEvents btnSubmitQuiz As Button
    Friend WithEvents lblQuestion As Label
    Friend WithEvents Button1 As Button
End Class
