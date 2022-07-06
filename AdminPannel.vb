Public Class AdminPannel
    Private Sub MovieCreate_Click(sender As Object, e As EventArgs) Handles MovieCreate.Click
        Movie1.Show()

    End Sub

    Private Sub CreateUser_Click(sender As Object, e As EventArgs) Handles CreateUser.Click
        Form2.Show()
    End Sub

    Private Sub UpdateUser_Click(sender As Object, e As EventArgs) Handles UpdateUser.Click
        CRUD.show()


    End Sub



    Private Sub DeleteUser_Click(sender As Object, e As EventArgs) Handles DeleteUser.Click


    End Sub

    Private Sub SearchUser_Click(sender As Object, e As EventArgs) Handles SearchUser.Click


    End Sub
End Class