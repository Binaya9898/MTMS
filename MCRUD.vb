'Imports System.Data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader

Public Class MCRUD
    Public cmd As OleDb.OleDbCommand
    Public dtr As OleDb.OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Updated\MTMS\MovieDb.accdb")
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
        smname.Text = ""

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        conn.Open()
        Dim strsql As String
        strsql = "select * from Movieinfo where Name='" & smname.Text & "'"
        cmd = New OleDbCommand(strsql, conn)


        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader()
        myreader.Read()
        Dim Uname As String
        Try

            Uname = myreader("Name")

            If Uname = smname.Text Then
                Panel1.Show()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
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
        smname.Text = ""

    End Sub

    Private Sub BtnSrch_Click(sender As Object, e As EventArgs) Handles BtnSrch.Click
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            conn.Open()
            strqry = "select * from Movieinfo where Name= '" & smname.Text & "'"
            da = New OleDbDataAdapter(strqry, conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            conn.Close()
            'Cusername.Text = ""
            'Cusername.Text = ""
            smname.Text = ""
        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Hide()
        AdminPannel.Show()

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Application.Exit()

    End Sub
    Public Function ClearAll()
        Mid.Text = ""
        Mname.Text = ""
        Mshowtime.Text = ""
        Mhall.Text = ""
        Mgenre.Text = ""
        Mstatus.Text = ""
    End Function

    Private Sub MCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn.Open()
        strqry = "Update Movieinfo set ID = " & Mid.Text & ",Name='" & Mname.Text & "',Release_Date='" & Mdate.Text & "',Show_Time='" & Mshowtime.Text & "',Hall='" & Mhall.Text & "',Genre='" & Mgenre.Text & "',Status='" & Mstatus.Text & "' where Name='" & smname.Text & "'"
        cmd = New OleDbCommand(strqry, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Sucess")
        conn.Close()
    End Sub
End Class