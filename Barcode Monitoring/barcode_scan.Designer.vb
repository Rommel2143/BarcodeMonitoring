<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class barcode_scan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panel_chk = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cism = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_crcis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_sc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.lbl_line = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_shift = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_model = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.datagrid1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_fvi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.panel_chk.SuspendLayout()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.panel_chk)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel1.Controls.Add(Me.lbl_line)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.txt_name)
        Me.Guna2Panel1.Controls.Add(Me.Label12)
        Me.Guna2Panel1.Controls.Add(Me.lbl_shift)
        Me.Guna2Panel1.Controls.Add(Me.lbl_date)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.cmb_model)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(341, 685)
        Me.Guna2Panel1.TabIndex = 0
        '
        'panel_chk
        '
        Me.panel_chk.Controls.Add(Me.Label6)
        Me.panel_chk.Controls.Add(Me.Label3)
        Me.panel_chk.Controls.Add(Me.txt_fvi)
        Me.panel_chk.Controls.Add(Me.Label2)
        Me.panel_chk.Controls.Add(Me.Label1)
        Me.panel_chk.Controls.Add(Me.txt_cism)
        Me.panel_chk.Controls.Add(Me.txt_crcis)
        Me.panel_chk.Controls.Add(Me.txt_sc)
        Me.panel_chk.Enabled = False
        Me.panel_chk.Location = New System.Drawing.Point(20, 317)
        Me.panel_chk.Name = "panel_chk"
        Me.panel_chk.Size = New System.Drawing.Size(287, 338)
        Me.panel_chk.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(37, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "CISM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(37, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "CR CIS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(37, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "SC"
        '
        'txt_cism
        '
        Me.txt_cism.BorderRadius = 3
        Me.txt_cism.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cism.DefaultText = ""
        Me.txt_cism.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_cism.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_cism.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cism.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cism.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cism.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cism.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cism.Location = New System.Drawing.Point(40, 189)
        Me.txt_cism.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_cism.Name = "txt_cism"
        Me.txt_cism.PlaceholderText = "Scan CISM..."
        Me.txt_cism.SelectedText = ""
        Me.txt_cism.Size = New System.Drawing.Size(209, 31)
        Me.txt_cism.TabIndex = 8
        '
        'txt_crcis
        '
        Me.txt_crcis.BorderRadius = 3
        Me.txt_crcis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_crcis.DefaultText = ""
        Me.txt_crcis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_crcis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_crcis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_crcis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_crcis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_crcis.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_crcis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_crcis.Location = New System.Drawing.Point(40, 107)
        Me.txt_crcis.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_crcis.Name = "txt_crcis"
        Me.txt_crcis.PlaceholderText = "Scan CR CIS..."
        Me.txt_crcis.SelectedText = ""
        Me.txt_crcis.Size = New System.Drawing.Size(209, 31)
        Me.txt_crcis.TabIndex = 6
        '
        'txt_sc
        '
        Me.txt_sc.BorderRadius = 3
        Me.txt_sc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sc.DefaultText = ""
        Me.txt_sc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_sc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_sc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sc.Location = New System.Drawing.Point(43, 26)
        Me.txt_sc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_sc.Name = "txt_sc"
        Me.txt_sc.PlaceholderText = "scan SC..."
        Me.txt_sc.SelectedText = ""
        Me.txt_sc.Size = New System.Drawing.Size(209, 31)
        Me.txt_sc.TabIndex = 3
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(32, 226)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(276, 8)
        Me.Guna2Separator1.TabIndex = 29
        '
        'lbl_line
        '
        Me.lbl_line.AutoSize = True
        Me.lbl_line.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_line.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_line.Location = New System.Drawing.Point(28, 47)
        Me.lbl_line.Name = "lbl_line"
        Me.lbl_line.Size = New System.Drawing.Size(174, 21)
        Me.lbl_line.TabIndex = 28
        Me.lbl_line.Text = "Error LINE NOT FOUND"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(37, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Name/IDno :"
        '
        'txt_name
        '
        Me.txt_name.BorderRadius = 3
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.DefaultText = ""
        Me.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.Location = New System.Drawing.Point(40, 154)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PlaceholderText = "Input Name..."
        Me.txt_name.SelectedText = ""
        Me.txt_name.Size = New System.Drawing.Size(261, 44)
        Me.txt_name.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(25, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(225, 25)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "BARCODE MONITORING"
        '
        'lbl_shift
        '
        Me.lbl_shift.AutoSize = True
        Me.lbl_shift.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shift.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_shift.Location = New System.Drawing.Point(37, 100)
        Me.lbl_shift.Name = "lbl_shift"
        Me.lbl_shift.Size = New System.Drawing.Size(47, 17)
        Me.lbl_shift.TabIndex = 12
        Me.lbl_shift.Text = "SHIFT :"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_date.Location = New System.Drawing.Point(37, 75)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(49, 17)
        Me.lbl_date.TabIndex = 11
        Me.lbl_date.Text = "DATE : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(40, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SELECT MODEL"
        '
        'cmb_model
        '
        Me.cmb_model.BackColor = System.Drawing.Color.Transparent
        Me.cmb_model.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_model.DropDownHeight = 300
        Me.cmb_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_model.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_model.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_model.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_model.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_model.IntegralHeight = False
        Me.cmb_model.ItemHeight = 30
        Me.cmb_model.Location = New System.Drawing.Point(43, 269)
        Me.cmb_model.Name = "cmb_model"
        Me.cmb_model.Size = New System.Drawing.Size(229, 36)
        Me.cmb_model.TabIndex = 4
        '
        'datagrid1
        '
        Me.datagrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagrid1.ColumnHeadersHeight = 28
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid1.DefaultCellStyle = DataGridViewCellStyle7
        Me.datagrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.Location = New System.Drawing.Point(341, 52)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.datagrid1.RowHeadersVisible = False
        Me.datagrid1.Size = New System.Drawing.Size(816, 633)
        Me.datagrid1.TabIndex = 1
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
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(341, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(816, 52)
        Me.Guna2Panel2.TabIndex = 2
        '
        'Timer1
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(37, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 17)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "FVI"
        '
        'txt_fvi
        '
        Me.txt_fvi.BorderRadius = 3
        Me.txt_fvi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_fvi.DefaultText = ""
        Me.txt_fvi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_fvi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_fvi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_fvi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_fvi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_fvi.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fvi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_fvi.Location = New System.Drawing.Point(40, 267)
        Me.txt_fvi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_fvi.Name = "txt_fvi"
        Me.txt_fvi.PlaceholderText = "Scan FVI..."
        Me.txt_fvi.SelectedText = ""
        Me.txt_fvi.Size = New System.Drawing.Size(209, 31)
        Me.txt_fvi.TabIndex = 31
        '
        'barcode_scan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 685)
        Me.Controls.Add(Me.datagrid1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "barcode_scan"
        Me.Text = "barcode_scan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.panel_chk.ResumeLayout(False)
        Me.panel_chk.PerformLayout()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents datagrid1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmb_model As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_sc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cism As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_crcis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_shift As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lbl_line As Label
    Friend WithEvents panel_chk As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_fvi As Guna.UI2.WinForms.Guna2TextBox
End Class
