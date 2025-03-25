Imports System.Data.SQLite
Public Class create_line

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        UpdateLine(txt_model.Text)
        lbl_line.Text = getLine()
        txt_model.Clear()
    End Sub

    Private Sub create_model_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_line.Text = getLine()
    End Sub





    Public Sub UpdateLine(text As String)
        Try
            Dim sql As String = "UPDATE LINE SET line = '" & text & "' WHERE line='" & lbl_line.Text & "'"
            con.Close()
            con.Open()
            Dim cmd As New SQLiteCommand(sql, con)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Line has changed! Application will close.")
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

End Class