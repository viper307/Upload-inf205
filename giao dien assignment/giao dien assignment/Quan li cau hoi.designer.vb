<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDapan
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
        Me.lstdanhsach = New System.Windows.Forms.ListBox()
        Me.txtDapan = New System.Windows.Forms.TextBox()
        Me.txtCauhoi = New System.Windows.Forms.TextBox()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstdanhsach
        '
        Me.lstdanhsach.FormattingEnabled = True
        Me.lstdanhsach.ItemHeight = 15
        Me.lstdanhsach.Location = New System.Drawing.Point(8, 2)
        Me.lstdanhsach.Name = "lstdanhsach"
        Me.lstdanhsach.Size = New System.Drawing.Size(324, 439)
        Me.lstdanhsach.TabIndex = 0
        '
        'txtDapan
        '
        Me.txtDapan.Location = New System.Drawing.Point(339, 421)
        Me.txtDapan.Name = "txtDapan"
        Me.txtDapan.ReadOnly = True
        Me.txtDapan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDapan.Size = New System.Drawing.Size(243, 23)
        Me.txtDapan.TabIndex = 1
        '
        'txtCauhoi
        '
        Me.txtCauhoi.Location = New System.Drawing.Point(339, 2)
        Me.txtCauhoi.Multiline = True
        Me.txtCauhoi.Name = "txtCauhoi"
        Me.txtCauhoi.ReadOnly = True
        Me.txtCauhoi.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCauhoi.Size = New System.Drawing.Size(243, 411)
        Me.txtCauhoi.TabIndex = 2
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(121, 458)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(96, 50)
        Me.btnSua.TabIndex = 4
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(223, 458)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(101, 50)
        Me.btnXoa.TabIndex = 5
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(15, 458)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(100, 50)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'frmDapan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 545)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtCauhoi)
        Me.Controls.Add(Me.txtDapan)
        Me.Controls.Add(Me.lstdanhsach)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDapan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lí câu hỏi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstdanhsach As System.Windows.Forms.ListBox
    Friend WithEvents txtDapan As System.Windows.Forms.TextBox
    Friend WithEvents txtCauhoi As System.Windows.Forms.TextBox
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button

End Class
