'Imports System.Data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader

Public Class crud


    Public cmd As OleDb.OleDbCommand
    Public dtr As OleDb.OleDbDataReader
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim strqry As String
        Dim conn As OleDbConnection = New OleDbConnection()
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")

        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            conn.Open()
            strqry = "select * from Userinfo where UserName='" & Cusername.Text & "' "
            da = New OleDbDataAdapter(strqry, conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            conn.Close()
            Cusername.Text = ""
            Cid.Text = ""
        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim strqry As String
        Dim conn As OleDbConnection = New OleDbConnection()
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        'Get id of tuple you want to delete record of
        strqry = "delete from from Userinfo where UserName='" & Cusername.Text & "' "
        cmd.CommandText = strqry
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Deleted Successfully!")
        Datashow()
    End Sub

    Public Sub Datashow()
        Dim strqry As String
        Dim conn As OleDbConnection = New OleDbConnection()
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        conn.Open()
        da = New OleDbDataAdapter("select * from Userinfo", conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        conn.Close()
    End Sub

    Private Sub CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class