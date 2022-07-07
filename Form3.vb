Imports System.Data
Imports System.Data.OleDb
Imports System
Public Class Form3
    Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")

    Dim strqry As string
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Con.Open()
        strqry = "update Userinfo set " & Sid.Text & ",'" & SName.Text & "','" & SAddress.Text & "','" & SUname.Text & "','" & Spassword.Text & "'"
        Dim Cmd As OleDbCommand = New OleDbCommand(strqry, Con)
        Cmd.ExecuteNonQuery()
        MsgBox("Sucess")
        Con.Close()

    End Sub
End Class