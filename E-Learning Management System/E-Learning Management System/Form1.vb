Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text =
            "level300" And cmbRole.Text = "Lecturer" Then
            Form2.Show()
            Me.Hide()

        ElseIf txtUsername.Text = "admin" And txtPassword.Text =
                "level300" And cmbRole.Text = "Student" Then
            Form6.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalide Login")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Add("Lecturere")
        cmbRole.Items.Add("Student")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class