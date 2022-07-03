Public Class Form1


    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles About.Click

    End Sub

    Private Sub Contact_Click(sender As Object, e As EventArgs) Handles Contact.Click
        MsgBox("Hello")

    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click

    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click

    End Sub

    Private Sub IconPictureBox3_Click(sender As Object, e As EventArgs) Handles IconPictureBox3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim Name, Password As String
        Name = TxtUsername.Text
        Password = TxtPassword.Text
        If Name = "Binaya" And Password = "Binaya" Then
            AdminPannel.Show()
            'Create.show()
        Else
            MsgBox("Incorrect Password", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        Form2.Show()
    End Sub
End Class
