Imports System.Data
Imports System.Data.OleDb
Module NewReg
    Public Sub DbCon()
        Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\OneDrive\Desktop\MovieDb.accdb; Persist Security Info=False")
        Dim Cmd As OleDbCommand
        Con.Open()

    End Sub
End Module
