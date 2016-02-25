<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanlinguoidung
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
        Me.btnquaylai = New System.Windows.Forms.Button()
        Me.cbbquyentruycap = New System.Windows.Forms.ComboBox()
        Me.txtsodienthoai = New System.Windows.Forms.TextBox()
        Me.lblquyentruycap = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.cbbgioitinh = New System.Windows.Forms.ComboBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnluu = New System.Windows.Forms.Button()
        Me.txtsinhngay = New System.Windows.Forms.TextBox()
        Me.grbdanhsachthanhvien = New System.Windows.Forms.GroupBox()
        Me.Lstdanhsach = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grbthongtin = New System.Windows.Forms.GroupBox()
        Me.ptbhinhdaidien = New System.Windows.Forms.PictureBox()
        Me.btnchon = New System.Windows.Forms.Button()
        Me.lblduongdan = New System.Windows.Forms.Label()
        Me.lblhinhanhdaidien = New System.Windows.Forms.Label()
        Me.lbldienthoai = New System.Windows.Forms.Label()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtmatkhau = New System.Windows.Forms.TextBox()
        Me.txtdangnhap = New System.Windows.Forms.TextBox()
        Me.lblhoten = New System.Windows.Forms.Label()
        Me.lblngaysinh = New System.Windows.Forms.Label()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.lblgioitinh = New System.Windows.Forms.Label()
        Me.lblchucvu = New System.Windows.Forms.Label()
        Me.chonhinhanhdaidien = New System.Windows.Forms.OpenFileDialog()
        Me.grbdanhsachthanhvien.SuspendLayout()
        Me.grbthongtin.SuspendLayout()
        CType(Me.ptbhinhdaidien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnquaylai
        '
        Me.btnquaylai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnquaylai.Location = New System.Drawing.Point(530, 12)
        Me.btnquaylai.Name = "btnquaylai"
        Me.btnquaylai.Size = New System.Drawing.Size(78, 23)
        Me.btnquaylai.TabIndex = 14
        Me.btnquaylai.Text = "Quay lại"
        Me.btnquaylai.UseVisualStyleBackColor = True
        '
        'cbbquyentruycap
        '
        Me.cbbquyentruycap.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cbbquyentruycap.FormattingEnabled = True
        Me.cbbquyentruycap.Items.AddRange(New Object() {"Quản trị", "Người dùng"})
        Me.cbbquyentruycap.Location = New System.Drawing.Point(132, 224)
        Me.cbbquyentruycap.Name = "cbbquyentruycap"
        Me.cbbquyentruycap.Size = New System.Drawing.Size(120, 24)
        Me.cbbquyentruycap.TabIndex = 29
        '
        'txtsodienthoai
        '
        Me.txtsodienthoai.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtsodienthoai.Location = New System.Drawing.Point(132, 190)
        Me.txtsodienthoai.Name = "txtsodienthoai"
        Me.txtsodienthoai.Size = New System.Drawing.Size(245, 22)
        Me.txtsodienthoai.TabIndex = 28
        '
        'lblquyentruycap
        '
        Me.lblquyentruycap.AutoSize = True
        Me.lblquyentruycap.Location = New System.Drawing.Point(21, 227)
        Me.lblquyentruycap.Name = "lblquyentruycap"
        Me.lblquyentruycap.Size = New System.Drawing.Size(100, 16)
        Me.lblquyentruycap.TabIndex = 27
        Me.lblquyentruycap.Text = "Quyền truy cập:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(538, 323)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 11
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(434, 318)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 20
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(341, 318)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 19
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'cbbgioitinh
        '
        Me.cbbgioitinh.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cbbgioitinh.FormattingEnabled = True
        Me.cbbgioitinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cbbgioitinh.Location = New System.Drawing.Point(131, 64)
        Me.cbbgioitinh.Name = "cbbgioitinh"
        Me.cbbgioitinh.Size = New System.Drawing.Size(121, 24)
        Me.cbbgioitinh.TabIndex = 31
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(614, 12)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 15
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnluu
        '
        Me.btnluu.Location = New System.Drawing.Point(526, 318)
        Me.btnluu.Name = "btnluu"
        Me.btnluu.Size = New System.Drawing.Size(75, 23)
        Me.btnluu.TabIndex = 32
        Me.btnluu.Text = "Save"
        Me.btnluu.UseVisualStyleBackColor = True
        '
        'txtsinhngay
        '
        Me.txtsinhngay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtsinhngay.Location = New System.Drawing.Point(132, 94)
        Me.txtsinhngay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsinhngay.Name = "txtsinhngay"
        Me.txtsinhngay.Size = New System.Drawing.Size(245, 22)
        Me.txtsinhngay.TabIndex = 30
        '
        'grbdanhsachthanhvien
        '
        Me.grbdanhsachthanhvien.Controls.Add(Me.Lstdanhsach)
        Me.grbdanhsachthanhvien.Location = New System.Drawing.Point(7, 419)
        Me.grbdanhsachthanhvien.Name = "grbdanhsachthanhvien"
        Me.grbdanhsachthanhvien.Size = New System.Drawing.Size(682, 217)
        Me.grbdanhsachthanhvien.TabIndex = 13
        Me.grbdanhsachthanhvien.TabStop = False
        Me.grbdanhsachthanhvien.Text = "Danh sách thành viên"
        '
        'Lstdanhsach
        '
        Me.Lstdanhsach.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.Lstdanhsach.Location = New System.Drawing.Point(6, 19)
        Me.Lstdanhsach.Name = "Lstdanhsach"
        Me.Lstdanhsach.Size = New System.Drawing.Size(670, 192)
        Me.Lstdanhsach.TabIndex = 0
        Me.Lstdanhsach.UseCompatibleStateImageBehavior = False
        Me.Lstdanhsach.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tên đăng nhập"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Giới Tính"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Năm sinh"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Mật khẩu"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Đia chỉ"
        Me.ColumnHeader5.Width = 56
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Số điện thoại"
        Me.ColumnHeader6.Width = 91
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Quyền hạn"
        Me.ColumnHeader7.Width = 76
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Hình ảnh"
        Me.ColumnHeader8.Width = 77
        '
        'grbthongtin
        '
        Me.grbthongtin.Controls.Add(Me.btnluu)
        Me.grbthongtin.Controls.Add(Me.cbbgioitinh)
        Me.grbthongtin.Controls.Add(Me.txtsinhngay)
        Me.grbthongtin.Controls.Add(Me.cbbquyentruycap)
        Me.grbthongtin.Controls.Add(Me.txtsodienthoai)
        Me.grbthongtin.Controls.Add(Me.lblquyentruycap)
        Me.grbthongtin.Controls.Add(Me.btnxoa)
        Me.grbthongtin.Controls.Add(Me.btnthem)
        Me.grbthongtin.Controls.Add(Me.ptbhinhdaidien)
        Me.grbthongtin.Controls.Add(Me.btnchon)
        Me.grbthongtin.Controls.Add(Me.lblduongdan)
        Me.grbthongtin.Controls.Add(Me.lblhinhanhdaidien)
        Me.grbthongtin.Controls.Add(Me.lbldienthoai)
        Me.grbthongtin.Controls.Add(Me.txtdiachi)
        Me.grbthongtin.Controls.Add(Me.txtmatkhau)
        Me.grbthongtin.Controls.Add(Me.txtdangnhap)
        Me.grbthongtin.Controls.Add(Me.lblhoten)
        Me.grbthongtin.Controls.Add(Me.lblngaysinh)
        Me.grbthongtin.Controls.Add(Me.lbldiachi)
        Me.grbthongtin.Controls.Add(Me.lblgioitinh)
        Me.grbthongtin.Controls.Add(Me.lblchucvu)
        Me.grbthongtin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbthongtin.Location = New System.Drawing.Point(7, 51)
        Me.grbthongtin.Margin = New System.Windows.Forms.Padding(4)
        Me.grbthongtin.Name = "grbthongtin"
        Me.grbthongtin.Padding = New System.Windows.Forms.Padding(4)
        Me.grbthongtin.Size = New System.Drawing.Size(682, 361)
        Me.grbthongtin.TabIndex = 12
        Me.grbthongtin.TabStop = False
        Me.grbthongtin.Text = "Thông tin"
        '
        'ptbhinhdaidien
        '
        Me.ptbhinhdaidien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbhinhdaidien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbhinhdaidien.Location = New System.Drawing.Point(398, 34)
        Me.ptbhinhdaidien.Name = "ptbhinhdaidien"
        Me.ptbhinhdaidien.Size = New System.Drawing.Size(264, 227)
        Me.ptbhinhdaidien.TabIndex = 17
        Me.ptbhinhdaidien.TabStop = False
        '
        'btnchon
        '
        Me.btnchon.Location = New System.Drawing.Point(574, 265)
        Me.btnchon.Name = "btnchon"
        Me.btnchon.Size = New System.Drawing.Size(75, 23)
        Me.btnchon.TabIndex = 16
        Me.btnchon.Text = "Chọn"
        Me.btnchon.UseVisualStyleBackColor = True
        '
        'lblduongdan
        '
        Me.lblduongdan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblduongdan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblduongdan.Location = New System.Drawing.Point(131, 266)
        Me.lblduongdan.Name = "lblduongdan"
        Me.lblduongdan.Size = New System.Drawing.Size(437, 22)
        Me.lblduongdan.TabIndex = 15
        Me.lblduongdan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblhinhanhdaidien
        '
        Me.lblhinhanhdaidien.AutoSize = True
        Me.lblhinhanhdaidien.Location = New System.Drawing.Point(17, 269)
        Me.lblhinhanhdaidien.Name = "lblhinhanhdaidien"
        Me.lblhinhanhdaidien.Size = New System.Drawing.Size(104, 16)
        Me.lblhinhanhdaidien.TabIndex = 14
        Me.lblhinhanhdaidien.Text = "Tải ảnh (nếu có)"
        Me.lblhinhanhdaidien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldienthoai
        '
        Me.lbldienthoai.AutoSize = True
        Me.lbldienthoai.Location = New System.Drawing.Point(21, 190)
        Me.lbldienthoai.Name = "lbldienthoai"
        Me.lbldienthoai.Size = New System.Drawing.Size(89, 16)
        Me.lbldienthoai.TabIndex = 12
        Me.lbldienthoai.Text = "Số điện thoại:"
        Me.lbldienthoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdiachi
        '
        Me.txtdiachi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtdiachi.Location = New System.Drawing.Point(131, 124)
        Me.txtdiachi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(245, 22)
        Me.txtdiachi.TabIndex = 11
        '
        'txtmatkhau
        '
        Me.txtmatkhau.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtmatkhau.Location = New System.Drawing.Point(131, 154)
        Me.txtmatkhau.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.Size = New System.Drawing.Size(245, 22)
        Me.txtmatkhau.TabIndex = 8
        '
        'txtdangnhap
        '
        Me.txtdangnhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtdangnhap.Location = New System.Drawing.Point(131, 34)
        Me.txtdangnhap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdangnhap.Name = "txtdangnhap"
        Me.txtdangnhap.Size = New System.Drawing.Size(245, 22)
        Me.txtdangnhap.TabIndex = 6
        '
        'lblhoten
        '
        Me.lblhoten.AutoSize = True
        Me.lblhoten.Location = New System.Drawing.Point(21, 34)
        Me.lblhoten.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhoten.Name = "lblhoten"
        Me.lblhoten.Size = New System.Drawing.Size(99, 16)
        Me.lblhoten.TabIndex = 0
        Me.lblhoten.Text = "Tên đăng nhập"
        Me.lblhoten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblngaysinh
        '
        Me.lblngaysinh.AutoSize = True
        Me.lblngaysinh.Location = New System.Drawing.Point(21, 94)
        Me.lblngaysinh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblngaysinh.Name = "lblngaysinh"
        Me.lblngaysinh.Size = New System.Drawing.Size(70, 16)
        Me.lblngaysinh.TabIndex = 4
        Me.lblngaysinh.Text = "Sinh ngày:"
        Me.lblngaysinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Location = New System.Drawing.Point(21, 124)
        Me.lbldiachi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(51, 16)
        Me.lbldiachi.TabIndex = 5
        Me.lbldiachi.Text = "Địa chỉ:"
        Me.lbldiachi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblgioitinh
        '
        Me.lblgioitinh.AutoSize = True
        Me.lblgioitinh.Location = New System.Drawing.Point(21, 64)
        Me.lblgioitinh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblgioitinh.Name = "lblgioitinh"
        Me.lblgioitinh.Size = New System.Drawing.Size(55, 16)
        Me.lblgioitinh.TabIndex = 2
        Me.lblgioitinh.Text = "Giới tính"
        Me.lblgioitinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblchucvu
        '
        Me.lblchucvu.AutoSize = True
        Me.lblchucvu.Location = New System.Drawing.Point(21, 154)
        Me.lblchucvu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblchucvu.Name = "lblchucvu"
        Me.lblchucvu.Size = New System.Drawing.Size(68, 16)
        Me.lblchucvu.TabIndex = 1
        Me.lblchucvu.Text = "Mật khẩu :"
        Me.lblchucvu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmQuanlinguoidung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 659)
        Me.Controls.Add(Me.btnquaylai)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.grbdanhsachthanhvien)
        Me.Controls.Add(Me.grbthongtin)
        Me.Name = "frmQuanlinguoidung"
        Me.Text = "Quản lí người dùng"
        Me.grbdanhsachthanhvien.ResumeLayout(False)
        Me.grbthongtin.ResumeLayout(False)
        Me.grbthongtin.PerformLayout()
        CType(Me.ptbhinhdaidien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnquaylai As System.Windows.Forms.Button
    Friend WithEvents cbbquyentruycap As System.Windows.Forms.ComboBox
    Friend WithEvents txtsodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents lblquyentruycap As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents cbbgioitinh As System.Windows.Forms.ComboBox
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents btnluu As System.Windows.Forms.Button
    Friend WithEvents txtsinhngay As System.Windows.Forms.TextBox
    Friend WithEvents grbdanhsachthanhvien As System.Windows.Forms.GroupBox
    Friend WithEvents Lstdanhsach As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents grbthongtin As System.Windows.Forms.GroupBox
    Friend WithEvents ptbhinhdaidien As System.Windows.Forms.PictureBox
    Friend WithEvents btnchon As System.Windows.Forms.Button
    Friend WithEvents lblduongdan As System.Windows.Forms.Label
    Friend WithEvents lblhinhanhdaidien As System.Windows.Forms.Label
    Friend WithEvents lbldienthoai As System.Windows.Forms.Label
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents txtdangnhap As System.Windows.Forms.TextBox
    Friend WithEvents lblhoten As System.Windows.Forms.Label
    Friend WithEvents lblngaysinh As System.Windows.Forms.Label
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents lblgioitinh As System.Windows.Forms.Label
    Friend WithEvents lblchucvu As System.Windows.Forms.Label
    Friend WithEvents chonhinhanhdaidien As System.Windows.Forms.OpenFileDialog

End Class
