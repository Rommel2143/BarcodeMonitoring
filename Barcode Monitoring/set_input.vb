Imports System.Data.SQLite
Public Class set_input
    Private Sub set_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSet()
    End Sub

    Private Sub getSet()
        Dim sql As String = "SELECT SC,CRCIS,CISM,FVI,ADF FROM input_set"
        Try
            con.Close()
            con.Open()
            Using cmd As New SQLiteCommand(sql, con)
                Using dr As SQLiteDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        chk_sc.Checked = Convert.ToBoolean(dr("SC"))
                        chk_cr.Checked = Convert.ToBoolean(dr("CRCIS"))
                        chk_cism.Checked = Convert.ToBoolean(dr("CISM"))
                        chk_fvi.Checked = Convert.ToBoolean(dr("FVI"))
                        chk_fvi.Checked = Convert.ToBoolean(dr("ADF"))
                    Else

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
        End Try




    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim sql As String = "UPDATE input_set SET SC = @SC, CRCIS = @CRCIS, CISM = @CISM, FVI = @FVI,ADF = @ADF"
        Try
            con.Close()
            con.Open()
            Using cmd As New SQLiteCommand(sql, con)
                cmd.Parameters.AddWithValue("@SC", If(chk_sc.Checked, 1, 0))
                cmd.Parameters.AddWithValue("@CRCIS", If(chk_cr.Checked, 1, 0))
                cmd.Parameters.AddWithValue("@CISM", If(chk_cism.Checked, 1, 0))
                cmd.Parameters.AddWithValue("@FVI", If(chk_fvi.Checked, 1, 0))
                cmd.Parameters.AddWithValue("@ADF", If(chk_adf.Checked, 1, 0))
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Settings updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    barcode_scan.getSet()
                    Me.Close()
                Else
                    MessageBox.Show("No records were updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_fvi.CheckedChanged
        If chk_fvi.Checked = True Then
            chk_cr.Checked = False
            chk_sc.Checked = False
            chk_cism.Checked = False
            chk_adf.Checked = False
        End If
    End Sub

    Private Sub chk_sc_CheckedChanged(sender As Object, e As EventArgs) Handles chk_sc.CheckedChanged
        chk_fvi.Checked = False

    End Sub

    Private Sub chk_cr_CheckedChanged(sender As Object, e As EventArgs) Handles chk_cr.CheckedChanged
        chk_fvi.Checked = False

    End Sub

    Private Sub chk_cism_CheckedChanged(sender As Object, e As EventArgs) Handles chk_cism.CheckedChanged
        chk_fvi.Checked = False

    End Sub

    Private Sub chk_adf_CheckedChanged(sender As Object, e As EventArgs) Handles chk_adf.CheckedChanged
        chk_fvi.Checked = False
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class