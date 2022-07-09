Imports System.Data
Imports System.Data.OleDb
Imports System

Public Class NewUser
    Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Updated\MTMS\MovieDb.accdb; Persist Security Info=False")
    Dim Cmd As OleDbCommand


    Private Sub SInsert_Click(sender As Object, e As EventArgs) Handles SInsert.Click
        Con.Open()
        Cmd = New OleDbCommand("insert into userinfo values(" & Sid.Text & ",'" & SName.Text & "','" & SAddress.Text & "','" & SUname.Text & "','" & Spassword.Text & "','" & Srole.Text & "')", Con)
        Dim i
        i = Cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Sucesfully Saved")
        Else
            MsgBox("Sucesfully Not SAVED", MsgBoxStyle.Critical)

        End If
        Con.Close()

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Application.Exit()

    End Sub
End Class
