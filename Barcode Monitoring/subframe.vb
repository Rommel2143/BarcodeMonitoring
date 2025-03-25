Public Class subframe
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        If btn_menu.ContextMenuStrip IsNot Nothing Then
            btn_menu.ContextMenuStrip.Show(btn_menu, 0, btn_menu.Height)

        End If
    End Sub




    Private Sub ModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModelToolStripMenuItem.Click
        create_model.Show()
        create_model.BringToFront()
    End Sub

    Private Sub RecievingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecievingToolStripMenuItem.Click
        display_inSub(barcode_scan)
    End Sub

    Private Sub ViewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRecordsToolStripMenuItem.Click
        display_inSub(viewrecords)
    End Sub

    Private Sub LineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineToolStripMenuItem.Click
        create_line.Show()
        create_line.BringToFront()
    End Sub

    Private Sub InputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputToolStripMenuItem.Click
        set_input.Show()
        set_input.BringToFront()
    End Sub
End Class