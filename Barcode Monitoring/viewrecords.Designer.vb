<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewrecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.datagrid1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel2.Controls.Add(Me.Label11)
        Me.Guna2Panel2.Controls.Add(Me.Label10)
        Me.Guna2Panel2.Controls.Add(Me.Label9)
        Me.Guna2Panel2.Controls.Add(Me.dtpicker2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.txt_search)
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.Controls.Add(Me.Guna2VSeparator1)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.dtpicker1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1015, 161)
        Me.Guna2Panel2.TabIndex = 3
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 3
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(640, 47)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(96, 36)
        Me.Guna2Button2.TabIndex = 24
        Me.Guna2Button2.Text = "View Data"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(295, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Filter Data :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(18, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "To"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(18, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "From"
        '
        'dtpicker2
        '
        Me.dtpicker2.BorderColor = System.Drawing.Color.DimGray
        Me.dtpicker2.BorderRadius = 3
        Me.dtpicker2.BorderThickness = 1
        Me.dtpicker2.Checked = True
        Me.dtpicker2.FillColor = System.Drawing.Color.White
        Me.dtpicker2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker2.Location = New System.Drawing.Point(62, 100)
        Me.dtpicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker2.Name = "dtpicker2"
        Me.dtpicker2.Size = New System.Drawing.Size(200, 36)
        Me.dtpicker2.TabIndex = 20
        Me.dtpicker2.Value = New Date(2025, 3, 21, 9, 20, 47, 605)
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 3
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(640, 89)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(96, 47)
        Me.Guna2Button1.TabIndex = 19
        Me.Guna2Button1.Text = "Export"
        '
        'txt_search
        '
        Me.txt_search.BorderRadius = 3
        Me.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.DefaultText = ""
        Me.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.Location = New System.Drawing.Point(312, 89)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PlaceholderText = "Input Keywords..."
        Me.txt_search.SelectedText = ""
        Me.txt_search.Size = New System.Drawing.Size(216, 36)
        Me.txt_search.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(309, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Search by Serial or Model :"
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(279, 16)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 135)
        Me.Guna2VSeparator1.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(18, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Set Date Range :"
        '
        'dtpicker1
        '
        Me.dtpicker1.BorderColor = System.Drawing.Color.DimGray
        Me.dtpicker1.BorderRadius = 3
        Me.dtpicker1.BorderThickness = 1
        Me.dtpicker1.Checked = True
        Me.dtpicker1.FillColor = System.Drawing.Color.White
        Me.dtpicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker1.Location = New System.Drawing.Point(62, 47)
        Me.dtpicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker1.Name = "dtpicker1"
        Me.dtpicker1.Size = New System.Drawing.Size(200, 36)
        Me.dtpicker1.TabIndex = 0
        Me.dtpicker1.Value = New Date(2025, 3, 21, 9, 20, 47, 605)
        '
        'datagrid1
        '
        Me.datagrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid1.ColumnHeadersHeight = 28
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.Location = New System.Drawing.Point(0, 161)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid1.RowHeadersVisible = False
        Me.datagrid1.Size = New System.Drawing.Size(1015, 465)
        Me.datagrid1.TabIndex = 4
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid1.ThemeStyle.HeaderStyle.Height = 28
        Me.datagrid1.ThemeStyle.ReadOnly = False
        Me.datagrid1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'viewrecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 626)
        Me.Controls.Add(Me.datagrid1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "viewrecords"
        Me.Text = "viewrecords"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents datagrid1 As Guna.UI2.WinForms.Guna2DataGridView
End Class
