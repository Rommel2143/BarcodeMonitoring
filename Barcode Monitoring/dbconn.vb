Imports System.Data.SQLite
Module dbconn
    Public con As New SQLiteConnection("Data Source=" & Application.StartupPath & "\database.db;Version=3;")


    Public da As New SQLiteDataAdapter
    Public dr As SQLiteDataReader
    Public dt As New DataTable

    ' Time format stored in the timein column (24h, with seconds).
    Public Const TimeFormat As String = "HH:mm:ss"

    ' Current time as text for timein. InvariantCulture keeps ":" as separator on any Windows locale.
    Public Function NowTime() As String
        Return Date.Now.ToString(TimeFormat, Globalization.CultureInfo.InvariantCulture)
    End Function

    ' ---- Schema ----------------------------------------------------------------
    ' Each table: CREATE statement + every column it must have (name, type).
    ' Matches the production database.db layout.
    Private ReadOnly SchemaTables As New List(Of Tuple(Of String, String, String()())) From {
        Tuple.Create("LINE",
            "CREATE TABLE IF NOT EXISTS ""LINE"" (""id"" INTEGER, ""line"" TEXT UNIQUE, PRIMARY KEY(""id"" AUTOINCREMENT))",
            New String()() {({"line", "TEXT"})}),
        Tuple.Create("input_set",
            "CREATE TABLE IF NOT EXISTS ""input_set"" (""SC"" INTEGER, ""CRCIS"" INTEGER, ""CISM"" INTEGER, ""FVI"" INTEGER, ""ADF"" INTEGER)",
            New String()() {({"SC", "INTEGER"}), ({"CRCIS", "INTEGER"}), ({"CISM", "INTEGER"}), ({"FVI", "INTEGER"}), ({"ADF", "INTEGER"})}),
        Tuple.Create("judgement",
            "CREATE TABLE IF NOT EXISTS ""judgement"" (""id"" INTEGER, ""judge"" TEXT UNIQUE, PRIMARY KEY(""id"" AUTOINCREMENT))",
            New String()() {({"judge", "TEXT"})}),
        Tuple.Create("MODEL",
            "CREATE TABLE IF NOT EXISTS ""MODEL"" (""id"" INTEGER, ""model"" TEXT UNIQUE, ""sc"" TEXT, ""crcis"" TEXT, ""cism"" TEXT, ""adf"" TEXT, ""fvi"" TEXT, PRIMARY KEY(""id"" AUTOINCREMENT))",
            New String()() {({"model", "TEXT"}), ({"sc", "TEXT"}), ({"crcis", "TEXT"}), ({"cism", "TEXT"}), ({"adf", "TEXT"}), ({"fvi", "TEXT"})}),
        Tuple.Create("barcodes",
            "CREATE TABLE IF NOT EXISTS ""barcodes"" (""id"" INTEGER, ""datein"" TEXT, ""timein"" TEXT, ""shift"" TEXT, ""model"" TEXT, ""SC"" TEXT, ""CRCIS"" TEXT, ""CISM"" TEXT, ""ADF"" TEXT, ""Name"" TEXT, ""line"" TEXT, ""judgement"" TEXT, ""remarks"" TEXT, PRIMARY KEY(""id"" AUTOINCREMENT))",
            New String()() {({"datein", "TEXT"}), ({"timein", "TEXT"}), ({"shift", "TEXT"}), ({"model", "TEXT"}), ({"SC", "TEXT"}), ({"CRCIS", "TEXT"}), ({"CISM", "TEXT"}), ({"ADF", "TEXT"}), ({"Name", "TEXT"}), ({"line", "TEXT"}), ({"judgement", "TEXT"}), ({"remarks", "TEXT"})}),
        Tuple.Create("barcodes_fvi",
            "CREATE TABLE IF NOT EXISTS ""barcodes_fvi"" (""id"" INTEGER, ""datein"" TEXT, ""timein"" TEXT, ""shift"" TEXT, ""model"" TEXT, ""fvi"" TEXT UNIQUE, ""name"" TEXT, ""line"" TEXT, ""judgement"" TEXT, ""remarks"" TEXT, PRIMARY KEY(""id"" AUTOINCREMENT))",
            New String()() {({"datein", "TEXT"}), ({"timein", "TEXT"}), ({"shift", "TEXT"}), ({"model", "TEXT"}), ({"fvi", "TEXT"}), ({"name", "TEXT"}), ({"line", "TEXT"}), ({"judgement", "TEXT"}), ({"remarks", "TEXT"})}),
        Tuple.Create("barcodes_adf",
            "CREATE TABLE IF NOT EXISTS ""barcodes_adf"" (""id"" INTEGER, ""datein"" TEXT, ""timein"" TEXT, ""shift"" TEXT, ""model"" TEXT, ""adf"" TEXT UNIQUE, ""name"" TEXT, ""line"" TEXT, ""judgement"" TEXT, ""remarks"" TEXT, PRIMARY KEY(""id"" AUTOINCREMENT))",
            New String()() {({"datein", "TEXT"}), ({"timein", "TEXT"}), ({"shift", "TEXT"}), ({"model", "TEXT"}), ({"adf", "TEXT"}), ({"name", "TEXT"}), ({"line", "TEXT"}), ({"judgement", "TEXT"}), ({"remarks", "TEXT"})})
    }

    ' Default judgement list for a brand-new database (same as production).
    Private ReadOnly DefaultJudgements As String() = {
        "G", "SCRATCH", "MISSING", "EXCESS", "DENT", "UNHOOK", "DETACHED", "FLOATING",
        "DISCOLORATION", "INSUFFICIENT", "NOT PROPERLY SET", "DEFORMED", "CUT", "TWISTED",
        "WRONG USE", "F.MAT", "SLANTED", "UNDERPUSHED", "OVERPUSHED"}

    ' Creates database.db if it does not exist, then makes sure every table and column
    ' exists and the single-row settings tables have a row. Existing data is never changed,
    ' so an old database.db pasted next to the exe keeps working.
    ' Call once at startup, before any other database access.
    Public Sub EnsureDatabase()
        Try
            con.Close()
            con.Open() ' SQLite creates an empty database.db here if it is missing

            Using tx As SQLiteTransaction = con.BeginTransaction()
                For Each t In SchemaTables
                    ExecSql(t.Item2, tx)

                    ' Add columns that older databases may lack (ALTER keeps existing rows).
                    Dim existing As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
                    Using cmd As New SQLiteCommand("PRAGMA table_info(""" & t.Item1 & """)", con, tx)
                        Using r As SQLiteDataReader = cmd.ExecuteReader()
                            While r.Read()
                                existing.Add(r("name").ToString())
                            End While
                        End Using
                    End Using
                    For Each col In t.Item3
                        If Not existing.Contains(col(0)) Then
                            ExecSql("ALTER TABLE """ & t.Item1 & """ ADD COLUMN """ & col(0) & """ " & col(1), tx)
                        End If
                    Next
                Next

                ' Seed rows the app expects to exist (only when the table is empty).
                If TableIsEmpty("LINE", tx) Then
                    ExecSql("INSERT INTO LINE (line) VALUES ('Please Change LINE first !')", tx)
                End If
                If TableIsEmpty("input_set", tx) Then
                    ExecSql("INSERT INTO input_set (SC, CRCIS, CISM, FVI, ADF) VALUES (1, 1, 1, 0, 1)", tx)
                End If
                If TableIsEmpty("judgement", tx) Then
                    For Each j In DefaultJudgements
                        Using cmd As New SQLiteCommand("INSERT INTO judgement (judge) VALUES (@j)", con, tx)
                            cmd.Parameters.AddWithValue("@j", j)
                            cmd.ExecuteNonQuery()
                        End Using
                    Next
                End If

                ' Fill NULL settings flags added by ALTER TABLE so Convert.ToBoolean does not fail.
                ExecSql("UPDATE input_set SET SC = IFNULL(SC, 0), CRCIS = IFNULL(CRCIS, 0), CISM = IFNULL(CISM, 0), FVI = IFNULL(FVI, 0), ADF = IFNULL(ADF, 0)", tx)

                tx.Commit()
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to prepare the database (" & Application.StartupPath & "\database.db): " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ExecSql(sql As String, tx As SQLiteTransaction)
        Using cmd As New SQLiteCommand(sql, con, tx)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Function TableIsEmpty(table As String, tx As SQLiteTransaction) As Boolean
        Using cmd As New SQLiteCommand("SELECT COUNT(*) FROM """ & table & """", con, tx)
            Return Convert.ToInt32(cmd.ExecuteScalar()) = 0
        End Using
    End Function

    ' Older builds saved timein as "HH:mm". When an old database.db is pasted in,
    ' pad those rows to "HH:mm:ss" (seconds = 00) so all rows share one format.
    ' Safe to run on every start: rows already in HH:mm:ss are not matched.
    ' A table that does not exist in the pasted database is skipped.
    Public Sub UpgradeTimeFormat()
        For Each tbl As String In {"barcodes", "barcodes_fvi", "barcodes_adf"}
            Try
                con.Close()
                con.Open()
                Using cmd As New SQLiteCommand("UPDATE " & tbl & " SET timein = timein || ':00' WHERE timein GLOB '[0-9][0-9]:[0-9][0-9]'", con)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As SQLiteException
                ' Table missing in this database - nothing to upgrade.
            Finally
                con.Close()
            End Try
        Next
    End Sub






    Public Sub InsertData(text As String, sc As String, crcis As String, cism As String, adf As String, fvi As String)
        Try
            Dim sql As String = "INSERT INTO model (model,sc,crcis,cism,adf,fvi) VALUES ( @model,@sc,@crcis,@cism,@adf,@fvi);"
            con.Close()
            con.Open()
            Using cmd As New SQLiteCommand(sql, con)
                cmd.Parameters.AddWithValue("@model", text)
                cmd.Parameters.AddWithValue("@sc", sc)
                cmd.Parameters.AddWithValue("@crcis", crcis)
                cmd.Parameters.AddWithValue("@cism", cism)
                cmd.Parameters.AddWithValue("@adf", adf)
                cmd.Parameters.AddWithValue("@fvi", fvi)
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
    Public Sub Insertbarcode(shift As String, model As String, sc As String, crcis As String, cism As String, adf As String, name As String, line As String)
        Try
            Dim sqlCheck As String = "
SELECT COUNT(*) FROM barcodes 
WHERE 
    (@SC <> '' AND SC = @SC) OR 
    (@CISM <> '' AND CISM = @CISM) OR 
    (@ADF <> '' AND ADF = @ADF);"
            Dim sqlInsert As String = "INSERT INTO barcodes (datein, shift, model, SC, CRCIS, CISM,adf, Name, line, timein,judgement,remarks) VALUES (@datein, @shift, @model, @SC, @CRCIS, @CISM,@adf, @Name, @line, @timein,'G','');"

            con.Close()
            con.Open()

            ' Check for duplicates
            Using cmdCheck As New SQLiteCommand(sqlCheck, con)
                cmdCheck.Parameters.AddWithValue("@SC", sc)
                cmdCheck.Parameters.AddWithValue("@ADF", adf)
                cmdCheck.Parameters.AddWithValue("@CISM", cism)

                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Duplicate record found! Insertion canceled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End Using

            ' Insert if no duplicate
            Using cmdInsert As New SQLiteCommand(sqlInsert, con)
                cmdInsert.Parameters.AddWithValue("@datein", Date.Now.ToString("yyyy-MM-dd"))
                cmdInsert.Parameters.AddWithValue("@shift", shift)
                cmdInsert.Parameters.AddWithValue("@model", model)
                cmdInsert.Parameters.AddWithValue("@SC", sc)
                cmdInsert.Parameters.AddWithValue("@CRCIS", crcis)
                cmdInsert.Parameters.AddWithValue("@CISM", cism)
                cmdInsert.Parameters.AddWithValue("@adf", adf)
                cmdInsert.Parameters.AddWithValue("@Name", name)
                cmdInsert.Parameters.AddWithValue("@line", line)
                cmdInsert.Parameters.AddWithValue("@timein", NowTime())
                cmdInsert.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub


    Public Sub InsertbarcodeFVI(shift As String, model As String, fvi As String, name As String, line As String)
        Try
            Dim sqlCheck As String = "SELECT COUNT(*) FROM barcodes_fvi WHERE FVI = @FVI;"
            Dim sqlInsert As String = "INSERT INTO barcodes_fvi (datein, shift, model, FVI, Name, line, timein,judgement,remarks) VALUES (@datein, @shift, @model, @FVI, @Name, @line, @timein,'G','');"

            con.Close()
            con.Open()

            ' Check for duplicates
            Using cmdCheck As New SQLiteCommand(sqlCheck, con)
                cmdCheck.Parameters.AddWithValue("@FVI", fvi)

                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Duplicate record found! Insertion canceled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End Using

            ' Insert if no duplicate
            Using cmdInsert As New SQLiteCommand(sqlInsert, con)
                cmdInsert.Parameters.AddWithValue("@datein", Date.Now.ToString("yyyy-MM-dd"))
                cmdInsert.Parameters.AddWithValue("@shift", shift)
                cmdInsert.Parameters.AddWithValue("@model", model)

                cmdInsert.Parameters.AddWithValue("@FVI", fvi)
                cmdInsert.Parameters.AddWithValue("@Name", name)
                cmdInsert.Parameters.AddWithValue("@line", line)
                cmdInsert.Parameters.AddWithValue("@timein", NowTime())

                cmdInsert.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub


    Public Sub InsertbarcodeADF(shift As String, model As String, adf As String, name As String, line As String)
        Try
            Dim sqlCheck As String = "SELECT COUNT(*) FROM barcodes_adf WHERE adf= @adf;"
            Dim sqlInsert As String = "INSERT INTO barcodes_adf (datein, shift, model, adf, Name, line, timein,judgement,remarks) VALUES (@datein, @shift, @model, @adf, @Name, @line, @timein,'G','');"

            con.Close()
            con.Open()

            ' Check for duplicates
            Using cmdCheck As New SQLiteCommand(sqlCheck, con)
                cmdCheck.Parameters.AddWithValue("@adf", adf)

                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Duplicate record found! Insertion canceled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End Using

            ' Insert if no duplicate
            Using cmdInsert As New SQLiteCommand(sqlInsert, con)
                cmdInsert.Parameters.AddWithValue("@datein", Date.Now.ToString("yyyy-MM-dd"))
                cmdInsert.Parameters.AddWithValue("@shift", shift)
                cmdInsert.Parameters.AddWithValue("@model", model)

                cmdInsert.Parameters.AddWithValue("@adf", adf)
                cmdInsert.Parameters.AddWithValue("@Name", name)
                cmdInsert.Parameters.AddWithValue("@line", line)
                cmdInsert.Parameters.AddWithValue("@timein", NowTime())

                cmdInsert.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
