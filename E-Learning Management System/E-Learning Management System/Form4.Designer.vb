<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        TextBox1 = New TextBox()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        ListBox1 = New ListBox()
        Label2 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(233, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 25)
        Label1.TabIndex = 1
        Label1.Text = "Assignment Management"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(216, 113)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(256, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.MediumSpringGreen
        Button2.Location = New Point(243, 168)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 23)
        Button2.TabIndex = 3
        Button2.Text = "Add Assignment"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ListBox1)
        GroupBox1.Location = New Point(89, 259)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(587, 165)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Assignment List"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Items.AddRange(New Object() {"Assignment 1", "", "Assignment 2"})
        ListBox1.Location = New Point(6, 20)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(575, 139)
        ListBox1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(89, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 15)
        Label2.TabIndex = 6
        Label2.Text = " Assignment Title :"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button1.Location = New Point(449, 168)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button3.Location = New Point(610, 168)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 8
        Button3.Text = "Previous"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "ASSIGNMENT_MANAGEMENT"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
