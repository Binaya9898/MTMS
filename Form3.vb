Imports System.Data
Imports System.Data.OleDb
Imports System
Public Class Form3
    Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")

    Dim strqry As String
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim user As String
        crud.Cusername.Text = user

        Con.Open()
        strqry = "update Userinfo set[Id] " & Sid.Text & ",[Name]='" & SName.Text & "',[Address]='" & SAddress.Text & "',[UserName]='" & SUname.Text & "',[Password]='" & Spassword.Text & "'where UserName=User"
        Dim Cmd As OleDbCommand = New OleDbCommand(strqry, Con)
        Cmd.ExecuteNonQuery()
        MsgBox("Sucess")
        Con.Close()

    End Sub
End Class