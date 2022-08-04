'Imports System.Data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader

Public Class MCRUD
    Public cmd As OleDb.OleDbCommand
    Public dtr As OleDb.OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb")
    Dim oledbAdapter As New OleDbDataAdapter
    Dim da As New OleDbDataAdapter
    Dim strqry As String

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        strqry = "delete * from Movieinfo where Name='" & smname.Text & "' "
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

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

    End Sub

    Private Sub BtnSearchAll_Click(sender As Object, e As EventArgs) Handles BtnSearchAll.Click
        Dim dt As New DataTable
        Dim ds As New DataSet
        conn.Open()
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("select * from Movieinfo", conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Show()

        conn.Close()
    End Sub

    Private Sub BtnSrch_Click(sender As Object, e As EventArgs) Handles BtnSrch.Click
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            conn.Open()
            strqry = "select * from Movieinfo where Name='" & smname.Text & "' "
            da = New OleDbDataAdapter(strqry, conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            conn.Close()
            'Cusername.Text = ""
            'Cusername.Text = ""
        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Critical)
        End Try
    End Sub


End Class