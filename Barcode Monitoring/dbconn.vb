Imports System.Data.SQLite
Module dbconn
    Public con As New SQLiteConnection("Data Source=database.db;Version=3;")
    Public da As New SQLiteDataAdapter
    Public dr As SQLiteDataReader
    Public dt As New DataTable






    Public Sub InsertData(text As String)
        Try
            Dim sql As String = "INSERT INTO model (model) VALUES ( @model);"
            con.Close()
            con.Open()
            Using cmd As New SQLiteCommand(sql, con)
                cmd.Parameters.AddWithValue("@model", text)

                cmd.ExecuteNonQuery()
                MessageBox.Show(text & " Added Sucessfully!")
            End Using
        Catch ex As SQLiteException
            ' Handle SQLite constraint violation (Error Code 19)
            If ex.ErrorCode = SQLiteErrorCode.Constraint Then
                MessageBox.Show("Error: " & text & " already exists in the database!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("SQLite Error ", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub





    Public Sub InsertLine(text As String)
        Try
            Dim sql As String = "INSERT INTO LINE (line) VALUES (@line);"
            con.Close()
            con.Open()
            Using cmd As New SQLiteCommand(sql, con)
                cmd.Parameters.AddWithValue("@line", text)

                cmd.ExecuteNonQuery()
                MessageBox.Show(text & "Changes Saved!")
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub



    Public Sub deleteModel(text As String)
        Try
            Dim sql As String = "DELETE FROM MODEL WHERE model = '" & text & "'"
            con.Close()
            con.Open()
            Using cmd As New SQLiteCommand(sql, con)

                cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub deleteLine(text As String)
        Try
            Dim sql As String = "DELETE FROM LINE WHERE line = 'test'"
            con.Close()
            con.Open()
            Using cmd As New SQLiteCommand(sql, con)

                cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getLine() As String
        Dim sql As String = "SELECT line FROM LINE"
        Try
            con.Close()
            con.Open()
            Using cmd As New SQLiteCommand(sql, con)
                Using dr As SQLiteDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        Return dr.GetString(0)
                    Else
                        Return "LINE NOT REGISTERED! Please call IT"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return "LINE ERROR"
        Finally
            con.Close()
        End Try
    End Function
    Public Sub Insertbarcode(shift As String, model As String, sc As String, crcis As String, cism As String, name As String, line As String)
        Try
            Dim sql As String = "INSERT INTO barcodes (datein,shift,model,SC,CRCIS,CISM,Name,line,timein) VALUES (@datein,@shift,@model,@SC,@CRCIS,@CISM,@Name,'" & line & "','" & Date.Now.ToString("HH:mm") & "');"
            con.Close()
            con.Open()
            Using cmd As New SQLiteCommand(sql, con)
                cmd.Parameters.AddWithValue("@datein", Date.Now.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@shift", shift)
                cmd.Parameters.AddWithValue("@model", model)
                cmd.Parameters.AddWithValue("@SC", sc)
                cmd.Parameters.AddWithValue("@CRCIS", crcis)
                cmd.Parameters.AddWithValue("@CISM", cism)
                cmd.Parameters.AddWithValue("@Name", name)
                cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
        End Try
    End Sub




    Public Sub reload(ByVal sql As String, ByVal datagrid As DataGridView)
        Try
            Dim localDt As New DataTable() ' Create a new DataTable instance for each DataGridView

            ' Unbind the DataGridView before reloading data
            datagrid.DataSource = Nothing

            ' Close and open connection
            con.Close()
            con.Open()

            Using loadSql As New SQLiteCommand(sql, con)
                Using da As New SQLiteDataAdapter(loadSql)
                    da.Fill(localDt)
                    datagrid.DataSource = localDt ' Rebind DataGridView after filling data
                End Using
            End Using

        Catch ex As Exception
            show_error("Unable to load data: " & ex.Message, 0)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub


    Public Sub cmb_display(query As String, cmb As ComboBox)
        Try

            con.Close()
            con.Open()

            Using cmd As New SQLiteCommand(query, con)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()

                    cmb.Items.Clear()


                    While reader.Read()
                        cmb.Items.Add(reader.GetString(0))
                    End While


                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
