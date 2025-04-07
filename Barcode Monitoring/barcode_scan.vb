Imports System.Data.SQLite
Public Class barcode_scan

    Dim reloadsql As String = "SELECT  model AS MODEL,SC,CRCIS,CISM FROM barcodes WHERE datein ='" & Date.Now.ToString("yyyy-MM-dd") & "' ORDER BY id DESC"

    Dim reloadfvi As String = "SELECT  model AS MODEL,FVI FROM barcodes_fvi WHERE datein ='" & Date.Now.ToString("yyyy-MM-dd") & "' ORDER BY id DESC"
    Private Function getshift() As String
        Dim currentTime As DateTime = DateTime.Now
        Dim startDayShift As DateTime = currentTime.Date.AddHours(7)  ' 7:00 AM
        Dim endDayShift As DateTime = currentTime.Date.AddHours(19)   ' 7:00 PM

        If currentTime >= startDayShift AndAlso currentTime < endDayShift Then
            Return "DS"
        Else
            Return "NS"
        End If
    End Function


    Private Sub barcode_scan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_date.Text = "DATE : " & Date.Now.ToString("MMMM dd, yyyy")
        lbl_shift.Text = "SHIFT : " & getshift()

        lbl_line.Text = getLine()
        getSet()
        Timer1.Start()
    End Sub
    Public Sub getSet()
        Dim sql As String = "SELECT SC,CRCIS,CISM,FVI FROM input_set"
        Try
            con.Close()
            con.Open()
            Using cmd As New SQLiteCommand(sql, con)
                Using dr As SQLiteDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        txt_sc.Enabled = Convert.ToBoolean(dr("SC"))
                        txt_crcis.Enabled = Convert.ToBoolean(dr("CRCIS"))
                        txt_cism.Enabled = Convert.ToBoolean(dr("CISM"))
                        txt_fvi.Enabled = Convert.ToBoolean(dr("FVI"))
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = "DATE : " & Date.Now.ToString("MMMM dd, yyyy")
        lbl_shift.Text = "SHIFT : " & getshift()

    End Sub

    Private Sub cmb_model_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_model.SelectedIndexChanged, txt_name.TextChanged
        If cmb_model.SelectedIndex = -1 Or txt_name.Text.Trim = "" Then
            panel_chk.Enabled = False
        Else
            panel_chk.Enabled = True
        End If
    End Sub

    Private Sub cmb_model_Click(sender As Object, e As EventArgs) Handles cmb_model.Click
        cmb_display("SELECT CONCAT( model)FROM MODEL", cmb_model)
    End Sub

    Private Function checkcode(text As String, column As String, number As Integer) As Boolean


        Try
            Dim sql As String = "SELECT id FROM MODEL WHERE " & column & " LIKE @text"

            con.Close()
            con.Open()

            Using cmd As New SQLiteCommand(sql, con)
                cmd.Parameters.AddWithValue("@text", "%" + text.Substring(0, number) + "%")
                Using dr As SQLiteDataReader = cmd.ExecuteReader()
                    Return dr.HasRows
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function



    Private Sub txt_model_TextChanged(sender As Object, e As EventArgs) Handles txt_sc.TextChanged

    End Sub

    Private Sub process_sc()

        If txt_crcis.Enabled = True Then

            txt_crcis.Clear()
                txt_crcis.Focus()


        Else
                process_crcis()
        End If

    End Sub
    Private Sub process_crcis()

        If txt_cism.Enabled = True Then

            txt_cism.Clear()
                txt_cism.Focus()

        Else
                process_cism()
        End If
    End Sub

    Private Sub process_cism()
        Dim str As String = cmb_model.Text
        Dim parts() As String = Str.Split(":"c)
        Insertbarcode(getshift, parts(0).Trim().ToUpper, txt_sc.Text.Trim.ToUpper, txt_crcis.Text.Trim.ToUpper, txt_cism.Text.Trim.ToUpper, txt_name.Text.Trim, lbl_line.Text.Trim)
        reload(reloadsql, datagrid1)
        cleartext()
        If txt_sc.Enabled = True Then
            txt_sc.Clear()
            txt_sc.Focus()
        Else
            process_sc()
        End If
    End Sub


    Private Sub txt_model_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sc.KeyDown
        If e.KeyCode = Keys.Enter Then
            If checkcode(txt_sc.Text.Trim.ToUpper, "SC", 3) = True Then

                process_sc()
            Else
                MessageBox.Show("Invalid QR")
            End If
        End If
    End Sub




    Private Sub txt_crcis_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_crcis.KeyDown
        If e.KeyCode = Keys.Enter Then
            If checkcode(txt_crcis.Text.Trim.ToUpper, "crcis", 2) = True Then
                process_crcis()
            Else
                MessageBox.Show("Invalid QR")
            End If
        End If
    End Sub


    Private Sub txt_cism_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cism.KeyDown
        If e.KeyCode = Keys.Enter Then
            If checkcode(txt_cism.Text.Trim.ToUpper, "cism", 3) = True Then
                process_cism()
            Else
                MessageBox.Show("Invalid QR")
            End If
        End If
    End Sub
    Private Sub cleartext()
        txt_sc.Clear()
        txt_cism.Clear()
        txt_crcis.Clear()
    End Sub




    Private Sub txt_fvi_TextChanged(sender As Object, e As EventArgs) Handles txt_fvi.TextChanged

    End Sub

    Private Sub txt_fvi_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fvi.KeyDown
        If e.KeyCode = Keys.Enter Then
            If checkcode(txt_fvi.Text.Trim.ToUpper, "fvi", 3) = True Then
                Dim str As String = cmb_model.Text
                Dim parts() As String = str.Split(":"c)
                InsertbarcodeFVI(getshift, parts(0).Trim().ToUpper, txt_fvi.Text.Trim.ToUpper, txt_name.Text.Trim, lbl_line.Text.Trim)
                reload(reloadfvi, datagrid1)
                txt_fvi.Clear()
                txt_fvi.Focus()
            Else
                MessageBox.Show("Invalid QR")
            End If
        End If

    End Sub
End Class