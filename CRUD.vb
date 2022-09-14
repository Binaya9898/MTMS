'Imports System.Data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader

Public Class crud


    Public cmd As OleDb.OleDbCommand
    Public dtr As OleDb.OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Updated\MTMS\MovieDb.accdb")
    Dim oledbAdapter As New OleDbDataAdapter
    Dim da As New OleDbDataAdapter
    Dim strqry As String
    'conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearchAll.Click
        Datashow()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        'Dim conn As OleDbConnection = New OleDbConnection()
        'Dim oledbAdapter As New OleDbDataAdapter
        'Dim da As New OleDbDataAdapter
        'Dim strqry As String
        'conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")

        strqry = "delete * from Userinfo where UserName='" & Cusername.Text & "' "
        Try
            conn.Open()
            oledbAdapter.DeleteCommand = conn.CreateCommand
            oledbAdapter.DeleteCommand.CommandText = strqry
            oledbAdapter.DeleteCommand.ExecuteNonQuery()
            MsgBox("Record Deleted !! ")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Datashow()
        'Dim strqry As String
        'Dim conn As OleDbConnection = New OleDbConnection()
        'conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        conn.Open()
        da = New OleDbDataAdapter("select * from Userinfo", conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Show()

        conn.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        'Dim cmd As OleDbCommand
        'Dim conn As OleDbConnection = New OleDbConnection()
        'Dim strqry As String

        'conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")
        conn.Open()
        Dim strsql As String
        strsql = "select * from Userinfo where UserName='" & Cusername.Text & "'"
        cmd = New OleDbCommand(strsql, conn)


        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader()
        myreader.Read()
        Dim Uname, pass As String
        Try

            Uname = myreader("UserName")
            pass = myreader("Password")
            If Uname = Cusername.Text Then
                Panel1.Show()

                conn.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        conn.Close()
    End Sub

    Private Sub crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Hide()
        Panel1.Hide()

    End Sub

    Private Sub BtnSrch_Click(sender As Object, e As EventArgs) Handles BtnSrch.Click
        'Try
        '    Dim dt As New DataTable
        '    Dim ds As New DataSet
        '    ds.Tables.Add(dt)
        '    Dim da As New OleDbDataAdapter
        '    conn.Open()
        '    strqry = "select * from UserInfo where UserName='" & Cusername.Text & "' "
        '    da = New OleDbDataAdapter(strqry, conn)
        '    da.Fill(dt)
        '    DataGridView1.DataSource = dt.DefaultView
        '    conn.Close()
        '    'Cusername.Text = ""
        '    'Cusername.Text = ""
        'Catch ex As Exception
        '    MsgBox("No Data Found", MsgBoxStyle.Critical)
        'End Try
        conn.Open()
        Dim myreader As OleDbDataReader
        strqry = "select * from UserInfo where UserName='" & Cusername.Text & "'"
        cmd = New OleDbCommand(strqry, conn)
        myreader = cmd.ExecuteReader()
        myreader.Read()
        Sid.Text = myreader("ID")
        SName.Text = myreader("Name")
        SAddress.Text = myreader("Address")
        SUname.Text = myreader("UserName")
        Spassword.Text = myreader("Password")
        Srole.Text = myreader("Role")
        Panel1.Show()
        conn.Close()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        conn.Open()
        strqry = "Update UserInfo set ID = " & Sid.Text & ",Name='" & SName.Text & "',Address='" & SAddress.Text & "',UserName='" & SUname.Text & "',[Password]='" & Spassword.Text & "',Role='" & Srole.Text & "' where UserName='" & Cusername.Text & "'"
        cmd = New OleDbCommand(strqry, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Sucess")
        conn.Close()

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Hide()
        AdminPannel.Show()

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Application.Exit()

    End Sub


End Class