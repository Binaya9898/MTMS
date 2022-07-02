Imports System.Data
Imports System.Data.OleDb
Module NewReg
    Public Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\Movie Ticket Management System\MovieDb.accdb; Persist Security Info=False")
    Public Cmd As OleDbCommand
End Module
