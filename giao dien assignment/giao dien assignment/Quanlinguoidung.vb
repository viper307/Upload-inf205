Imports System.IO
Public Class frmQuanlinguoidung
    Sub loadfile()
        Dim output As StreamReader  'Gán giá trị cho từng biến
        Dim line As String
        Dim result As String()
        Dim view As ListViewItem = New ListViewItem

        output = New StreamReader("nguoidung.txt", True)  'Tiến hành hiển thị cái Items trên list view
        Do Until output.EndOfStream
            line = output.ReadLine
            result = line.Split(ControlChars.Tab)
            view = New ListViewItem(result(0))
            view.SubItems.Add(result(1))
            view.SubItems.Add(result(2))
            view.SubItems.Add(result(3))
            view.SubItems.Add(result(4))
            view.SubItems.Add(result(5))
            view.SubItems.Add(result(6))
            view.SubItems.Add(result(7))


            Lstdanhsach.Items.Add(view)
        Loop
        output.Close()
    End Sub
    Private Sub frmquanlynhanvien_Load(ByVal sender As Object, ByVal e As EventArgs) 'Thực hiện load lên các thông tin có sẵn khi mở
        Me.loadfile()
    End Sub

    Private Sub ListBoxshow_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) 'Thực hiện đặt các giá trị vào list view
        Dim s As Integer
        s = Lstdanhsach.FocusedItem.Index
        txtdangnhap.Text = Lstdanhsach.Items(s).SubItems(0).Text
        cbbgioitinh.Text = Lstdanhsach.Items(s).SubItems(1).Text
        txtsinhngay.Text = Lstdanhsach.Items(s).SubItems(2).Text
        txtmatkhau.Text = Lstdanhsach.Items(s).SubItems(3).Text
        txtdiachi.Text = Lstdanhsach.Items(s).SubItems(4).Text
        txtsodienthoai.Text = Lstdanhsach.Items(s).SubItems(5).Text
        cbbquyentruycap.Text = Lstdanhsach.Items(s).SubItems(6).Text
        lblduongdan.Text = Lstdanhsach.Items(s).SubItems(7).Text
        If lblduongdan.Text <> "" Then
            ptbhinhdaidien.BackgroundImage = Image.FromFile(lblduongdan.Text) 'Load hình ảnh
        Else
            ptbhinhdaidien.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub btnthem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnthem.Click 'Xử lí sự kiện nút thêm
        'Nếu không nhập gì hiển thị thông báo
        If (txtdangnhap.Text = "") OrElse (txtmatkhau.Text = "") _
            OrElse (txtdiachi.Text = "") OrElse (txtsodienthoai.Text = "") _
            OrElse (cbbgioitinh.Text = "") OrElse (cbbquyentruycap.Text = "") Then
            MessageBox.Show("Thiếu thông tin. Xin nhập lại đầy đủ thông tin.", "Lỗi", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim item As ListViewItem                'Gán giá trị và đưa vào
            item = New ListViewItem(txtdangnhap.Text)
            item.SubItems.Add(cbbgioitinh.SelectedItem)
            item.SubItems.Add(txtsinhngay.Text)
            item.SubItems.Add(txtdiachi.Text)
            item.SubItems.Add(txtmatkhau.Text)
            item.SubItems.Add(txtsodienthoai.Text)
            item.SubItems.Add(cbbquyentruycap.SelectedItem)
            item.SubItems.Add(lblduongdan.Text)
            Lstdanhsach.Items.Add(item)

            'Sau khi nhập xong xóa hết các dòng ở trên
            txtdangnhap.Clear()
            cbbgioitinh.Text = ""
            txtsinhngay.Clear()
            txtmatkhau.Text = ""
            txtdiachi.Text = ""
            txtsodienthoai.Text = ""
            cbbquyentruycap.Text = ""
            lblduongdan.Text = ""
            ptbhinhdaidien.BackgroundImage = Nothing
        End If
    End Sub



    Private Sub btnthemanh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnchon.Click 'Xử lý sự kiện nút chọn
        chonhinhanhdaidien = New OpenFileDialog()
        chonhinhanhdaidien.Filter = "all file(*.*)|*.*"  'Add hình ảnh
        chonhinhanhdaidien.Title = "chọn Ảnh"
        If (chonhinhanhdaidien.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            ptbhinhdaidien.BackgroundImage = Image.FromFile(chonhinhanhdaidien.FileName)

            lblhinhanhdaidien.Text = "image\" & Path.GetFileName(chonhinhanhdaidien.FileName)
        End If

    End Sub


    Private Sub btnthoat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnthoat.Click 'xử lí sự kiện nút thoát
        Dim dialog As DialogResult = New DialogResult()
        dialog = MessageBox.Show("Bạn thực sự muốn thoát khỏi phần mềm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.None)
        If dialog = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxoa.Click 'Xử lí sự kiện nút xóa
        txtdangnhap.Text = ""
        txtmatkhau.Text = ""
        txtsinhngay.Text = ""
        txtsodienthoai.Text = ""
        txtdangnhap.Text = ""
        cbbgioitinh.Text = ""
        lblhinhanhdaidien.Text = ""
        cbbquyentruycap.Text = ""
        ptbhinhdaidien = Nothing

    End Sub
    Private Sub btnluu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnluu.Click 'Thực hiện lưu ra file txt thông qua sự kiện nút Save
        Dim output As StreamWriter = New StreamWriter("nguoidung.txt")
        Dim line As String
        For s As Integer = 0 To Lstdanhsach.Items.Count - 1
            line = Lstdanhsach.Items(s).SubItems(0).Text & _
                ControlChars.Tab & Lstdanhsach.Items(s).SubItems(1).Text & _
                ControlChars.Tab & Lstdanhsach.Items(s).SubItems(2).Text & _
                ControlChars.Tab & Lstdanhsach.Items(s).SubItems(4).Text & _
                ControlChars.Tab & Lstdanhsach.Items(s).SubItems(3).Text & _
                ControlChars.Tab & Lstdanhsach.Items(s).SubItems(5).Text & _
                ControlChars.Tab & Lstdanhsach.Items(s).SubItems(6).Text & _
                ControlChars.Tab & Lstdanhsach.Items(s).SubItems(7).Text

            output.WriteLine(line)
        Next
        output.Close()
        btnthoat.Enabled = True
    End Sub
    Private Sub btnquaylai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquaylai.Click 'Xử lí sự kiện nút quay lại
        Me.Hide()
        frmGiaodienchinh.Show()
    End Sub

    Private Sub frmQuanlinguoidung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
