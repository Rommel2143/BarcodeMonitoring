<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create_line
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_model = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_line = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Set Line - Station"
        '
        'txt_model
        '
        Me.txt_model.BorderRadius = 3
        Me.txt_model.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_model.DefaultText = ""
        Me.txt_model.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_model.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_model.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_model.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_model.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_model.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_model.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_model.Location = New System.Drawing.Point(35, 61)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.PlaceholderText = "Input Model Name..."
        Me.txt_model.SelectedText = ""
        Me.txt_model.Size = New System.Drawing.Size(298, 36)
        Me.txt_model.TabIndex = 6
        '
        'btn_save
        '
        Me.btn_save.BorderRadius = 3
        Me.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_save.FillColor = System.Drawing.Color.MidnightBlue
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(336, 61)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 36)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "Register Line"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(35, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Current Line - Station :"
        '
        'lbl_line
        '
        Me.lbl_line.AutoSize = True
        Me.lbl_line.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_line.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_line.Location = New System.Drawing.Point(59, 193)
        Me.lbl_line.Name = "lbl_line"
        Me.lbl_line.Size = New System.Drawing.Size(40, 21)
        Me.lbl_line.TabIndex = 11
        Me.lbl_line.Text = "Line"
        '
        'create_line
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 450)
        Me.Controls.Add(Me.lbl_line)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_model)
        Me.Controls.Add(Me.btn_save)
        Me.Name = "create_line"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_model As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_line As Label
End Class
