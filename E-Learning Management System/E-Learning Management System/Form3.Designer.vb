<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        lstMaterials = New ListBox()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        btnChooseFile = New Button()
        btnUpload = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(80, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 0
        Label1.Text = "Material Title"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(186, 126)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(174, 23)
        TextBox1.TabIndex = 1
        ' 
        ' lstMaterials
        ' 
        lstMaterials.FormattingEnabled = True
        lstMaterials.Items.AddRange(New Object() {"items", "\"})
        lstMaterials.Location = New Point(16, 22)
        lstMaterials.Name = "lstMaterials"
        lstMaterials.Size = New Size(546, 139)
        lstMaterials.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lstMaterials)
        GroupBox1.Location = New Point(67, 240)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(568, 177)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Uploaded Material"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(282, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(222, 25)
        Label2.TabIndex = 5
        Label2.Text = "Upload Course Material"
        ' 
        ' btnChooseFile
        ' 
        btnChooseFile.Location = New Point(134, 181)
        btnChooseFile.Name = "btnChooseFile"
        btnChooseFile.Size = New Size(115, 23)
        btnChooseFile.TabIndex = 6
        btnChooseFile.Text = "Choose File"
        btnChooseFile.UseVisualStyleBackColor = True
        ' 
        ' btnUpload
        ' 
        btnUpload.Location = New Point(329, 181)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(75, 23)
        btnUpload.TabIndex = 7
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        ClientSize = New Size(800, 450)
        Controls.Add(btnUpload)
        Controls.Add(btnChooseFile)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Upload_Material"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lstMaterials As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnChooseFile As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
