
Imports System.Data
Imports System.Data.OleDb
Imports System
Public Class InsMovie
    'Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")
    'Dim Cmd As OleDbCommand

    Dim conn As New OleDb.OleDbConnection
    Dim Myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Updated\MTMS\MovieDb.accdb"
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    Dim strqry As String
    Dim cn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Updated\MTMS\MovieDb.accdb")

    Private Sub Minsert_Click(sender As Object, e As EventArgs) Handles Minsert.Click

        'conn.ConnectionString = Myconnection
        If (Mstatus.Text = "Yes" And Mhall.Text = "East") Then
            strqry = "select * from Movieinfo where Hall='" & Mhall.Text & "' "
            cn.Open()
            Dim cmd15 As New OleDbCommand(strqry, cn)
            Dim myreader As OleDbDataReader
            myreader = cmd15.ExecuteReader()
            myreader.Read()
            Dim status = myreader("Status")
            Dim hall = myreader("Hall")
            MsgBox(hall)
            Dim stat = status.ToString()
            MsgBox(stat)
            If stat = "East" And hall = Mhall.Text Then
                MsgBox("Cannot add to the showing")
            Else
                Try

                    Dim mstream As New System.IO.MemoryStream()

                    Mpicture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    arrImage = mstream.GetBuffer()
                    Dim FileSize As UInt32
                    FileSize = mstream.Length
                    mstream.Close()

                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "INSERT INTO Movieinfo(ID,Name, Release_Date, Show_Time, Genre, Hall,Picture,Status) " &
                " VALUES (@id, @name, @date, @time, @genre, @hall,@picture,@status)"

                    cmd.Connection = conn
                    cmd.CommandText = sql
                    cmd.Parameters.AddWithValue("@id", Mid.Text)
                    cmd.Parameters.AddWithValue("@name", Mname.Text)
                    cmd.Parameters.AddWithValue("@date", DateTime.Parse(Mdate.Value))
                    cmd.Parameters.AddWithValue("@time", Mshowtime.Text)
                    cmd.Parameters.AddWithValue("@genre", Mgenre.Text)
                    cmd.Parameters.AddWithValue("@hall", Mhall.Text)
                    cmd.Parameters.AddWithValue("@picture", arrImage)
                    cmd.Parameters.AddWithValue("@status", Mstatus.Text)


                    'MsgBox(DateTime.Parse(Mdate.Value))

                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Movie Added Sucessfully!")
                        ClearAll()
                    Else
                        MsgBox("Process Failed!")
                    End If
                    conn.Close()

                Catch ex As Exception
                    MsgBox("Process Failed!")
                End Try
            End If
            cn.Close()
        Else

            Try

                Dim mstream As New System.IO.MemoryStream()

                Mpicture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
                Dim FileSize As UInt32
                FileSize = mstream.Length
                mstream.Close()

                conn.ConnectionString = Myconnection
                conn.Open()
                sql = "INSERT INTO Movieinfo(ID,Name, Release_Date, Show_Time, Genre, Hall,Picture,Status) " &
            " VALUES (@id, @name, @date, @time, @genre, @hall,@picture,@status)"

                cmd.Connection = conn
                cmd.CommandText = sql
                cmd.Parameters.AddWithValue("@id", Mid.Text)
                cmd.Parameters.AddWithValue("@name", Mname.Text)
                cmd.Parameters.AddWithValue("@date", DateTime.Parse(Mdate.Value))
                cmd.Parameters.AddWithValue("@time", Mshowtime.Text)
                cmd.Parameters.AddWithValue("@genre", Mgenre.Text)
                cmd.Parameters.AddWithValue("@hall", Mhall.Text)
                cmd.Parameters.AddWithValue("@picture", arrImage)
                cmd.Parameters.AddWithValue("@status", Mstatus.Text)


                'MsgBox(DateTime.Parse(Mdate.Value))

                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Movie Added Sucessfully!")
                Else
                    MsgBox("Process Failed!")
                End If
                conn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()
            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                Mpicture.ImageLocation = imgpath
            End If
            OFD = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
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

End Class