'Imports System.Data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader

'Imports System
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
        Dim cmd As OleDbCommand
        Dim conn As OleDbConnection = New OleDbConnection()
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Updated\MTMS\MovieDb.accdb; Persist Security Info=False")
        conn.Open()
        Dim strsql As String
        strsql = "select * from Userinfo where UserName='" & TxtUsername.Text & "'"
        cmd = New OleDbCommand(strsql, conn)

        'MsgBox(strsql)
        'MsgBox(TxtUsername.Text)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader()
        myreader.Read()
        Dim Uname, pass, role As String
        Try

            Uname = myreader("UserName")
            pass = myreader("Password")
            role = myreader("Role")
            MsgBox(role + Uname + pass)

            If Uname = TxtUsername.Text And pass = TxtPassword.Text And role = "User" Then
                Form3.Show()

            ElseIf Uname = TxtUsername.Text And pass = TxtPassword.Text And role = "Admin" Then
                Me.Hide()
                AdminPannel.Show()
            Else
                MsgBox("Incorrect")
            End If

        Catch ex As Exception
            MsgBox("Exc")
        End Try




        conn.Close()
    End Sub

    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        NewUser.Show()
    End Sub


End Class
