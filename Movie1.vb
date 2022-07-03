
Imports System.Data
Imports System.Data.OleDb
Imports System
Public Class Movie1
    Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")
    Dim Cmd As OleDbCommand
    Private Sub Minsert_Click(sender As Object, e As EventArgs) Handles Minsert.Click
        Con.Open()
        Cmd = New OleDbCommand("insert into Movieinfo values(" & Mid.Text & ",'" & Mname.Text & "'," & Mdate.Text & "," & Mshowtime.Text & ",'" & Mhall.Text & "'," & Mseat.Text & ",'" & Mgenre.Text & "')", Con)
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