Imports System.Data.SQLite
Public Class viewrecords
    Private Sub viewrecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker1.Value = Date.Now
        dtpicker2.Value = Date.Now
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim sql As String = ""
        Dim searchText As String = txt_search.Text.Trim

        If searchText = "" Then
            reload("SELECT datein as 'PD DATE',timein AS TIME, shift AS SHIFT, model AS MODEL, SC, CRCIS, CISM,Name FROM barcodes WHERE datein BETWEEN '" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpicker2.Value.ToString("yyyy-MM-dd") & "'", datagrid1)
        Else
            reload("SELECT datein as 'PD DATE',timein AS TIME, shift AS SHIFT, model AS MODEL, SC, CRCIS, CISM,Name FROM barcodes WHERE datein BETWEEN '" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpicker2.Value.ToString("yyyy-MM-dd") & "' AND (model LIKE '" & searchText & "' OR SC LIKE '" & searchText & "' OR SC LIKE '" & searchText & "' OR CRCIS LIKE '" & searchText & "' OR CISM LIKE '" & searchText & "' )", datagrid1)

        End If
        '

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        exporttoExcel(datagrid1)
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub
End Class