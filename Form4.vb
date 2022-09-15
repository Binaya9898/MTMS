Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader

Public Class Form4
    Public sharename, sharetime As String

    Public cmd As OleDb.OleDbCommand
    Public myreader As OleDb.OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Updated\MTMS\MovieDb.accdb")
    Dim oledbAdapter As New OleDbDataAdapter
    Dim da As New OleDbDataAdapter
    Dim strqry As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Seats.Show()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        conn.Open()

        Try

            strqry = "select * from Movieinfo where  Status=@stat and Hall='East' "

            cmd = New OleDbCommand(strqry, conn)
            'cmd.Parameters.AddWithValue("@hall", "East")
            cmd.Parameters.AddWithValue("@stat", "Yes")
            myreader = cmd.ExecuteReader()
            myreader.Read()
            Dim name, showtime, genre As String
            name = myreader("Name").ToString()
            showtime = myreader("Show_Time").ToString
            genre = myreader("Genre").ToString()
            'MsgBox("Sucess")
            MsgBox("Movie Name= " + name & vbCrLf &
                   "Show Time= " & showtime & vbCrLf &
                   "Genre= " + genre, MsgBoxStyle.Information
                   )
            'MsgBox(name)
            sharename = name
            Emname.Text = name
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conn.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Updated\MTMS\MovieDb.accdb")
        Dim cmmd As OleDb.OleDbCommand
        Dim mreader As OleDb.OleDbDataReader
        Dim str As String
        con.Open()
        str = "select * from Movieinfo where  Status=@stat and Hall='East' "

        cmmd = New OleDbCommand(str, con)
        'cmd.Parameters.AddWithValue("@hall", "East")
        cmmd.Parameters.AddWithValue("@stat", "Yes")
        mreader = cmmd.ExecuteReader()
        mreader.Read()
        Dim name, stime, genre As String
        name = mreader("Name").ToString()
        stime = mreader("Show_Time").ToString
        Emname.Text = name
        sharename = name
        sharetime = stime
        con.Close()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Application.Exit()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class