Imports System.Data
Imports System.Data.OleDb

Public Class Register



    Private Sub SInsert_Click(sender As Object, e As EventArgs) Handles SInsert.Click
        Cmd = New OleDbCommand("insert into userinfo(Name,Address,Username,Password) values('" & SName.Text & "','" & SAddress.Text & "','" & SUname.Text & "','" & Spassword.Text & "')", Con)
        Con.Open()
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