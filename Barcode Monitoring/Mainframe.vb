Imports Guna.UI2.WinForms
Imports System.Threading
Public Class Mainframe

    Private Sub Mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnsureDatabase()     ' create database.db / missing tables + columns
        UpgradeTimeFormat()  ' pad legacy HH:mm times to HH:mm:ss
        display_inMain(subframe)
    End Sub


End Class
