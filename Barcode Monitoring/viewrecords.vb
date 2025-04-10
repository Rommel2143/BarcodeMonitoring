Imports System.Data.SQLite
Public Class viewrecords
    Dim rad As Integer = 0
    Private Sub viewrecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker1.Value = Date.Now
        dtpicker2.Value = Date.Now
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If rad_sc.Checked Then
            others()
        Else
            fvi()
        End If
    End Sub


    Private Sub others()
        Dim sql As String = ""
        Dim searchText As String = txt_search.Text.Trim

        If searchText = "" Then
            reload("SELECT id, datein as 'PD DATE',timein AS TIME, shift AS SHIFT, model AS MODEL, SC, CRCIS, CISM,ADF,Name,judgement,remarks FROM barcodes WHERE datein BETWEEN '" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpicker2.Value.ToString("yyyy-MM-dd") & "'", datagrid1)
        Else
            reload("SELECT id, datein as 'PD DATE',timein AS TIME, shift AS SHIFT, model AS MODEL, SC, CRCIS, CISM,ADF,Name,judgement,remarks FROM barcodes WHERE datein BETWEEN '" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpicker2.Value.ToString("yyyy-MM-dd") & "' AND (model LIKE '" & searchText & "' OR SC LIKE '" & searchText & "' OR SC LIKE '" & searchText & "' OR CRCIS LIKE '" & searchText & "' OR CISM LIKE '" & searchText & "' )", datagrid1)

        End If
        SetupJudgementComboBox()
    End Sub

    Private Sub fvi()
        Dim sql As String = ""
        Dim searchText As String = txt_search.Text.Trim

        If searchText = "" Then
            reload("SELECT id, datein as 'PD DATE',timein AS TIME, shift AS SHIFT, model AS MODEL,FVI AS 'FVI SERIAL',Name AS 'Operator',judgement AS Judgement,remarks AS Remarks FROM barcodes_fvi WHERE datein BETWEEN '" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpicker2.Value.ToString("yyyy-MM-dd") & "'", datagrid1)
        Else
            reload("SELECT id, datein as 'PD DATE',timein AS TIME, shift AS SHIFT, model AS MODEL, FVI AS 'FVI SERIAL',Name  AS 'Operator',judgement AS Judgement,remarks AS Remarks FROM barcodes_fvi WHERE datein BETWEEN '" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpicker2.Value.ToString("yyyy-MM-dd") & "' AND (model LIKE '" & searchText & "' OR FVI LIKE '" & searchText & "' )", datagrid1)
        End If

        ' After data is loaded, set up the ComboBox for "judgement" column
        SetupJudgementComboBox()
    End Sub


    Private Sub adf()
        Dim sql As String = ""
        Dim searchText As String = txt_search.Text.Trim

        If searchText = "" Then
            reload("SELECT id, datein as 'PD DATE',timein AS TIME, shift AS SHIFT, model AS MODEL,ADF AS 'ADF SERIAL',Name AS 'Operator',judgement AS Judgement,remarks AS Remarks FROM barcodes_adf WHERE datein BETWEEN '" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpicker2.Value.ToString("yyyy-MM-dd") & "'", datagrid1)
        Else
            reload("SELECT id, datein as 'PD DATE',timein AS TIME, shift AS SHIFT, model AS MODEL, ADF AS 'ADF SERIAL',Name  AS 'Operator',judgement AS Judgement,remarks AS Remarks FROM barcodes_adf WHERE datein BETWEEN '" & dtpicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpicker2.Value.ToString("yyyy-MM-dd") & "' AND (model LIKE '" & searchText & "' OR FVI LIKE '" & searchText & "' )", datagrid1)
        End If

        ' After data is loaded, set up the ComboBox for "judgement" column
        SetupJudgementComboBox()
    End Sub

    Private Sub SetupJudgementComboBox()
        ' Remove existing ComboBox column if it already exists
        If datagrid1.Columns.Contains("judgement") Then
            datagrid1.Columns.Remove("judgement")
        End If

        ' Fetch judgment values from the database
        Dim judgementList As New List(Of String)()
        Dim sql As String = "SELECT judge FROM judgement"

        Try
            Using cmd As New SQLiteCommand(sql, con)
                con.Open()
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        judgementList.Add(reader("judge").ToString())
                    End While
                End Using
                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching judgments: " & ex.Message)
        End Try

        ' Create ComboBox Column
        Dim comboColumn As New DataGridViewComboBoxColumn()
        comboColumn.Name = "judgement"
        comboColumn.HeaderText = "Judgement"
        comboColumn.DataPropertyName = "judgement" ' Bind to database column

        ' Add fetched items from database
        comboColumn.Items.AddRange(judgementList.ToArray())

        ' Add ComboBox column to DataGridView
        datagrid1.Columns.Add(comboColumn)
    End Sub




    'Private Sub datagrid1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellValueChanged
    '    ' Ensure we're editing the "judgement" column
    '    If e.ColumnIndex = datagrid1.Columns("judgement").Index Then
    '        Dim selectedJudgement As String = datagrid1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

    '        ' Update the "judgement" value in the database
    '        UpdateJudgementInDatabase(datagrid1.Rows(e.RowIndex).Cells("id").Value.ToString(), selectedJudgement, datagrid1.Rows(e.RowIndex).Cells("remarks").Value.ToString())
    '    End If
    'End Sub




    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        exporttoExcel(datagrid1)
    End Sub

    Private Sub InitializeSaveButton()
        ' Set properties for the button
        btnsavechanges.Text = "Save Changes"
        btnsavechanges.Size = New Size(120, 40)
        btnsavechanges.Location = New Point(20, 300) ' Set the position as needed
        Me.Controls.Add(btnsavechanges)
    End Sub

    ' Event handler when Save Changes button is clicked
    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnsavechanges.Click
        SaveJudgementChanges()
        MessageBox.Show("Changes Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Save changes to the database
    Private Sub SaveJudgementChanges()
        Dim qtable As String = ""
        Select Case rad
            Case 0
                qtable = "barcodes"
            Case 1
                qtable = "barcodes_fvi"
            Case 2
                qtable = "barcodes_adf"

        End Select


        For Each row As DataGridViewRow In datagrid1.Rows
            If row.IsNewRow Then Continue For ' Skip new rows

            Dim recordId As Integer = Convert.ToInt32(row.Cells("id").Value)
            Dim newJudgement As String = row.Cells("judgement").Value.ToString()
            Dim newRemarks As String = row.Cells("remarks").Value.ToString()

            ' Only update if values have changed
            If newJudgement <> row.Cells("judgement").Tag OrElse newRemarks <> row.Cells("remarks").Tag Then
                UpdateJudgementInDatabase(recordId, newJudgement, newRemarks, qtable)
                row.Cells("judgement").Tag = newJudgement
                row.Cells("remarks").Tag = newRemarks

            End If
        Next
    End Sub


    ' Update the "judgement" value in the database for the given "datein"
    Private Sub UpdateJudgementInDatabase(recordId As Integer, judgement As String, remarks As String, tb As String)
        Dim sql As String = "UPDATE " & tb & " SET judgement = @judgement, remarks = @remarks WHERE id = @id"

        Try
            Using cmd As New SQLiteCommand(sql, con)
                cmd.Parameters.AddWithValue("@judgement", judgement)
                cmd.Parameters.AddWithValue("@remarks", remarks)
                cmd.Parameters.AddWithValue("@id", recordId) ' Ensure correct ID is used

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()


            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving changes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guna2RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rad_sc.CheckedChanged

    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rad_fvi.CheckedChanged

    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        rad = 2
    End Sub
End Class