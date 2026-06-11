Public Class Form2
    Private Sub btnUploadMaterial_Click(sender As Object, e As EventArgs) Handles btnUploadMaterial.Click
        Form3.Show()
    End Sub

    Private Sub btnAssignment_Click(sender As Object, e As EventArgs) Handles btnAssignment.Click
        Form4.Show()

    End Sub

    Private Sub btnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click
        Form5.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class