Imports System.Data
Imports System.Data.OleDb
Imports System

Public Class Form2
    Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")
    Dim Cmd As OleDbCommand


    Private Sub SInsert_Click(sender As Object, e As EventArgs) Handles SInsert.Click
        Con.Open()
        Cmd = New OleDbCommand("insert into userinfo values(" & Sid.Text & ",'" & SName.Text & "','" & SAddress.Text & "','" & SUname.Text & "','" & Spassword.Text & "')", Con)
        Dim i
        i = Cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Sucesfully Saved")
        Else
            MsgBox("Sucesfully Not SAVED", MsgBoxStyle.Critical)

        End If
        Con.Close()

    End Sub


End Class
