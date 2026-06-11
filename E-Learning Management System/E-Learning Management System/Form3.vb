Imports System.Runtime.CompilerServices

Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If filePath = "" Then
            MessaageBox.Show("Please Select a File")
        Else
            Dim destination As String = "C:\ELerningMaterial\" &
                IO.Path.GetFileName(filePath)
            IO.File.Copy(filePath,
                    destination, True)
            Materials.Add(destination)
            lstMaterial.Items.Add(destination)
            MessageBox.Show("File Uploaded Successfully")

        End If
    End Sub

    Private Sub btnChooseFile_Click(sender As Object, e As EventArgs) Handles btnChooseFile.Click
        OpenFileDialog1.Filter = DialogResult.OK Then
            FilePath = OpenFileDialog1.FileName
        txtMaterial.Text = filePath
    End Sub
End Class