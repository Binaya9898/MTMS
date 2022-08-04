'Imports System.Data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader


Public Class UserPannel
    Public cmd As New OleDbCommand
    Public dtr As OleDb.OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Updated\MTMS\MovieDb.accdb")
    Dim oledbAdapter As New OleDbDataAdapter
    Dim da As New OleDbDataAdapter
    Dim strqry As String

    Private Sub UserPannel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Bookbtn_Click(sender As Object, e As EventArgs) Handles Bookbtn.Click
        Dim dt As New DataTable
        Dim ds As New DataSet
        conn.Open()
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim a As String = "Yes"
        strqry = "select Picture from MovieInfo where Status= a"

        conn.Close()

    End Sub
End Class