Public Class create_model
    Dim sql As String = "SELECT model AS MODEL FROM MODEL"
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        InsertData(txt_model.Text)
        reload(sql, datagrid1)
        txt_model.Clear()
    End Sub

    Private Sub create_model_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload(sql, datagrid1)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        exporttoExcel(datagrid1)
    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub


    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick

    End Sub

    Private Sub datagrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellDoubleClick



    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub datagrid1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagrid1.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim model As String = datagrid1.Rows(e.RowIndex).Cells(0).Value.ToString()
            If MessageBox.Show("Do you want to delete this model: " & model & "?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                Try
                    deleteModel(model)
                    reload(sql, datagrid1)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
End Class