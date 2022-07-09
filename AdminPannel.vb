Public Class AdminPannel
    Private Sub MovieCreate_Click(sender As Object, e As EventArgs) Handles MovieCreate.Click
        InsMovie.Show()



    End Sub

    Private Sub CreateUser_Click(sender As Object, e As EventArgs) Handles CreateUser.Click
        Me.Hide()
        NewUser.Show()
    End Sub


    Private Sub UpdateUser_Click(sender As Object, e As EventArgs) Handles UpdateUser.Click
        Me.Hide()
        crud.Show()

    End Sub

    Private Sub DeleteUser_Click(sender As Object, e As EventArgs) Handles DeleteUser.Click
        Me.Hide()
        crud.Show()
    End Sub

    Private Sub SearchUser_Click(sender As Object, e As EventArgs) Handles SearchUser.Click
        Me.Hide()
        crud.Show()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Application.Exit()
    End Sub
End Class