Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader
Public Class Seats

    Dim cmd As OleDbCommand
    Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Updated\MTMS\MovieDb.accdb; Persist Security Info=False")


    Public Sub conopen()
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Your MSaccess database file has been misplaced,help to locate resources folder")

        End Try

    End Sub

    Public Sub SetStatus(ByVal x As Integer)
        conopen()
        Dim sql As String
        If x = 1 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=1"

        ElseIf x = 2 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=2"

        ElseIf x = 3 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=3"

        ElseIf x = 4 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=4"

        ElseIf x = 5 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=5"

        ElseIf x = 6 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=6"

        ElseIf x = 7 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=7"

        ElseIf x = 8 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=8"

        ElseIf x = 9 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=9"

        ElseIf x = 10 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=10"

        ElseIf x = 11 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=11"

        ElseIf x = 12 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=12"

        ElseIf x = 13 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=13"

        ElseIf x = 14 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=14"

        ElseIf x = 15 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=15"

        ElseIf x = 16 Then
            sql = "Update Seatinfo set SeatStatus=1 where Seatid=16"

        End If
        Dim cmd As New OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Status Updated " & x)
        conn.Close()
    End Sub
    Public Sub clearColor()
        conopen()
        Dim sql As String
        sql = "Update Seatinfo set SeatStatus=0"
        Dim cmd As New OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        A1.BackColor = Color.Green
        A2.BackColor = Color.Green
        A3.BackColor = Color.Green
        A4.BackColor = Color.Green
        B1.BackColor = Color.Green
        B2.BackColor = Color.Green
        B3.BackColor = Color.Green
        B4.BackColor = Color.Green
        C1.BackColor = Color.Green
        C2.BackColor = Color.Green
        C3.BackColor = Color.Green
        C4.BackColor = Color.Green
        D1.BackColor = Color.Green
        D2.BackColor = Color.Green
        D3.BackColor = Color.Green
        D4.BackColor = Color.Green
        MsgBox("Updated to 0")

    End Sub
    Public Sub changecolor()
        A1.BackColor = Color.Blue

    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        'conopen()

        'Dim sql As String
        'sql = "select * from Seatinfo where SeatId=2"
        'cmd = New OleDbCommand(sql, conn)
        'Dim myreader As OleDbDataReader
        'myreader = cmd.ExecuteReader()
        'myreader.Read()
        'Dim seatstat As Integer
        'Dim seatid As String

        'seatstat = myreader("SeatStatus")

        'If seatstat = 0 Then
        '    'A2.BackColor = Color.Red
        '    MsgBox("Red")
        'Else
        'MsgBox("Already Booked")
        ''ElseIf seatstat = 1 Then
        ''    'MsgBox("Booked Sucessfully")
        ''    MsgBox("Already Booked")
        'End If
        'conn.Close()
        'Me.BackColor = Color.Red
        'conopen()
        'Dim sql As String
        'sql = "Update Seatinfo set SeatStatus=1 where Seatid=2"
        'Dim cmd As New OleDbCommand(sql, conn)
        'cmd.ExecuteNonQuery()
        'MsgBox("Status Updated")
        'conn.Close()
        SetStatus(7)



    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim i As Integer
        Dim a() As Integer

        conopen()


        Dim sql As String
        sql = "select * from Seatinfo where SeatId=1"
        cmd = New OleDbCommand(sql, conn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader()
            myreader.Read()
            Dim seatstat As Integer
            Dim seatid As String

            seatstat = myreader("SeatStatus")
        If seatstat = 1 Then
            A1.BackColor = Color.Red
        Else
            A1.BackColor = Color.Green
        End If


        Dim sql2 As String
        sql2 = "select * from Seatinfo where SeatId=2"
        Dim cmd2 As New OleDbCommand(sql2, conn)
        Dim myreader2 As OleDbDataReader
        myreader2 = cmd2.ExecuteReader()
        myreader2.Read()
        Dim seatstat2 As Integer
        Dim seatid2 As String

        seatstat2 = myreader2("SeatStatus")
        If seatstat2 = 1 Then
            A2.BackColor = Color.Red
        Else
            A2.BackColor = Color.Green
        End If



        Dim sql3 As String
        sql3 = "select * from Seatinfo where SeatId=3"
        Dim cmd3 As New OleDbCommand(sql3, conn)
        Dim myreader3 As OleDbDataReader
        myreader3 = cmd3.ExecuteReader()
        myreader3.Read()
        Dim seatstat3 As Integer
        Dim seatid3 As String

        seatstat3 = myreader3("SeatStatus")
        If seatstat3 = 1 Then
            A3.BackColor = Color.Red
        Else
            A3.BackColor = Color.Green
        End If



        Dim sql4 As String
        sql4 = "select * from Seatinfo where SeatId=4"
        Dim cmd4 As New OleDbCommand(sql4, conn)
        Dim myreader4 As OleDbDataReader
        myreader4 = cmd4.ExecuteReader()
        myreader4.Read()
        Dim seatstat4 As Integer
        Dim seatid4 As String
        seatstat4 = myreader4("SeatStatus")
        If seatstat4 = 1 Then
            A4.BackColor = Color.Red
        Else
            A4.BackColor = Color.Green
        End If


        Dim sql5 As String
        sql5 = "select * from Seatinfo where SeatId=5"
        Dim cmd5 As New OleDbCommand(sql5, conn)
        Dim myreader5 As OleDbDataReader
        myreader5 = cmd5.ExecuteReader()
        myreader5.Read()
        Dim seatstat5 As Integer
        Dim seatid5 As String
        seatstat5 = myreader5("SeatStatus")
        If seatstat5 = 1 Then
            B1.BackColor = Color.Red
        Else
            B1.BackColor = Color.Green
        End If



        Dim sql6 As String
        sql6 = "select * from Seatinfo where SeatId=6"
        Dim cmd6 As New OleDbCommand(sql6, conn)
        Dim myreader6 As OleDbDataReader
        myreader6 = cmd6.ExecuteReader()
        myreader6.Read()
        Dim seatstat6 As Integer
        Dim seatid6 As String
        seatstat6 = myreader6("SeatStatus")
        If seatstat6 = 1 Then
            B2.BackColor = Color.Red
        Else
            B2.BackColor = Color.Green
        End If



        Dim sql7 As String
        sql7 = "select * from Seatinfo where SeatId=7"
        Dim cmd7 As New OleDbCommand(sql7, conn)
        Dim myreader7 As OleDbDataReader
        myreader7 = cmd7.ExecuteReader()
        myreader7.Read()
        Dim seatstat7 As Integer
        Dim seatid7 As String
        seatstat7 = myreader7("SeatStatus")
        If seatstat7 = 1 Then
            B3.BackColor = Color.Red
        Else
            B3.BackColor = Color.Green
        End If



        Dim sql8 As String
        sql8 = "select * from Seatinfo where SeatId=8"
        Dim cmd8 As New OleDbCommand(sql8, conn)
        Dim myreader8 As OleDbDataReader
        myreader8 = cmd8.ExecuteReader()
        myreader8.Read()
        Dim seatstat8 As Integer
        Dim seatid8 As String
        seatstat8 = myreader8("SeatStatus")
        If seatstat8 = 1 Then
            B4.BackColor = Color.Red
        Else
            B4.BackColor = Color.Green
        End If


        Dim sql9 As String
        sql9 = "select * from Seatinfo where SeatId=9"
        Dim cmd9 As New OleDbCommand(sql9, conn)
        Dim myreader9 As OleDbDataReader
        myreader9 = cmd9.ExecuteReader()
        myreader9.Read()
        Dim seatstat9 As Integer
        Dim seatid9 As String
        seatstat9 = myreader9("SeatStatus")
        If seatstat9 = 1 Then
            C1.BackColor = Color.Red
        Else
            C1.BackColor = Color.Green
        End If


        Dim sql10 As String
        sql10 = "select * from Seatinfo where SeatId=10"
        Dim cmd10 As New OleDbCommand(sql10, conn)
        Dim myreader10 As OleDbDataReader
        myreader10 = cmd10.ExecuteReader()
        myreader10.Read()
        Dim seatstat10 As Integer
        Dim seatid10 As String
        seatstat10 = myreader10("SeatStatus")
        If seatstat10 = 1 Then
            C2.BackColor = Color.Red
        Else
            C2.BackColor = Color.Green
        End If



        Dim sql11 As String
        sql11 = "select * from Seatinfo where SeatId=11"
        Dim cmd11 As New OleDbCommand(sql11, conn)
        Dim myreader11 As OleDbDataReader
        myreader11 = cmd11.ExecuteReader()
        myreader11.Read()
        Dim seatstat11 As Integer
        Dim seatid11 As String
        seatstat11 = myreader11("SeatStatus")
        If seatstat11 = 1 Then
            C3.BackColor = Color.Red
        Else
            C3.BackColor = Color.Green
        End If



        Dim sql12 As String
        sql12 = "select * from Seatinfo where SeatId=12"
        Dim cmd12 As New OleDbCommand(sql12, conn)
        Dim myreader12 As OleDbDataReader
        myreader12 = cmd12.ExecuteReader()
        myreader12.Read()
        Dim seatstat12 As Integer
        Dim seatid12 As String
        seatstat12 = myreader12("SeatStatus")
        If seatstat12 = 1 Then
            C4.BackColor = Color.Red
        Else
            C4.BackColor = Color.Green
        End If


        Dim sql13 As String
        sql13 = "select * from Seatinfo where SeatId=13"
        Dim cmd13 As New OleDbCommand(sql13, conn)
        Dim myreader13 As OleDbDataReader
        myreader13 = cmd13.ExecuteReader()
        myreader13.Read()
        Dim seatstat13 As Integer
        Dim seatid13 As String
        seatstat13 = myreader13("SeatStatus")
        If seatstat13 = 1 Then
            D1.BackColor = Color.Red
        Else
            D1.BackColor = Color.Green
        End If


        Dim sql14 As String
        sql14 = "select * from Seatinfo where SeatId=14"
        Dim cmd14 As New OleDbCommand(sql14, conn)
        Dim myreader14 As OleDbDataReader
        myreader14 = cmd14.ExecuteReader()
        myreader14.Read()
        Dim seatstat14 As Integer
        Dim seatid14 As String
        seatstat14 = myreader14("SeatStatus")
        If seatstat14 = 1 Then
            D2.BackColor = Color.Red
        Else
            D2.BackColor = Color.Green
        End If



        Dim sql15 As String
        sql15 = "select * from Seatinfo where SeatId=15"
        Dim cmd15 As New OleDbCommand(sql15, conn)
        Dim myreader15 As OleDbDataReader
        myreader15 = cmd15.ExecuteReader()
        myreader15.Read()
        Dim seatstat15 As Integer
        Dim seatid15 As String
        seatstat15 = myreader15("SeatStatus")
        If seatstat15 = 1 Then
            D3.BackColor = Color.Red
        Else
            D3.BackColor = Color.Green
        End If



        Dim sql16 As String
        sql16 = "select * from Seatinfo where SeatId=16"
        Dim cmd16 As New OleDbCommand(sql16, conn)
        Dim myreader16 As OleDbDataReader
        myreader16 = cmd16.ExecuteReader()
        myreader16.Read()
        Dim seatstat16 As Integer
        Dim seatid16 As String
        seatstat16 = myreader16("SeatStatus")
        If seatstat16 = 1 Then
            D4.BackColor = Color.Red
        Else
            D4.BackColor = Color.Green
        End If



        conn.Close()
    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        changecolor()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clearColor()
    End Sub
End Class