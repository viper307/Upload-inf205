Imports System.IO
Public Class frmDapan
    Public Structure CauHoi
        Dim Q As String
        Dim A1, A2, A3, A4 As String
        Dim A As Integer
    End Structure

    Public QuanLi() As CauHoi
    Public Sub HienCauHoi()
        'Đọc nội dung
        'Đọc nội dung file và chia nội dung thành nhiều câu hỏi
        'Đọc nội dung : File.ReadAllText("Data.ini")
        'Chia thành nhiều câu phân cách bằng vbNewLine (là vbCrLf) :
        'Khai báo Dim Content As String() tương đương Dim Content() As String
        Dim Content As String() = Split(File.ReadAllText("Data.ini"), vbNewLine)
        ReDim QuanLi(Content.Length - 1)
        'Quét từng dòng
        'Phân tiếp thành 6 phần : Câu hỏi, 4 câu trả lời và đáp án bởi dấu /
        For i As Integer = 0 To Content.Length - 1
            Dim Temp() As String = Split(Content(i), "/")
            QuanLi(i).Q = Temp(0)
            QuanLi(i).A1 = Temp(1) : QuanLi(i).A2 = Temp(2) : QuanLi(i).A3 = Temp(3) : QuanLi(i).A4 = Temp(4)
            QuanLi(i).A = Val(Temp(5))
        Next
        'Hiển thị
        lstdanhsach.Items.Clear()
        For i As Integer = 0 To QuanLi.Length - 1
            lstdanhsach.Items.Add("Câu " & i + 1)
        Next
    End Sub
    Private Sub frmQuanLi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HienCauHoi()
    End Sub
    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstdanhsach.SelectedIndexChanged
        If lstdanhsach.SelectedIndex <> -1 Then 'Nếu SelectIndex = -1 nghĩa là không chọn gì cả!
            With QuanLi(lstdanhsach.SelectedIndex)
                txtCauhoi.Text = .Q & vbNewLine & _
                    "Đáp án 1 : " & .A1 & vbNewLine & _
                    "Đáp án 2 : " & .A2 & vbNewLine & _
                    "Đáp án 3 : " & .A3 & vbNewLine & _
                    "Đáp án 4 : " & .A4
                txtDapan.Text = "Đáp án đúng : " & .A + 1
            End With
        End If
    End Sub
    Private Sub butThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        frmbientap.Tag = "Add"
        frmbientap.ShowDialog(Me)
        HienCauHoi() 'Để lúc thay đổi thì chương trình sẽ hiện lại
    End Sub

    Private Sub butSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        If lstdanhsach.SelectedIndex = -1 Then
            MsgBox("Vui lòng chọn câu hỏi cần sửa!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        frmbientap.Tag = lstdanhsach.SelectedIndex
        frmbientap.ShowDialog(Me)
        HienCauHoi()
    End Sub
    Private Sub butXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        'Xác định dòng định xoá
        'Kiểm tra người dùng đã chọn gì chưa
        If lstdanhsach.SelectedIndex = -1 Then
            MsgBox("Vui lòng chọn câu hỏi cần xoá!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'Xác nhận
        If MsgBox("Bạn có chắc muốn xoá?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        'Dòng cần xoá chính là dòng đang chọn trong Listbox (tính từ 0)
        Dim DongXoa As Integer = lstdanhsach.SelectedIndex
        'Xoá
        'Xoá bằng cách đưa từng câu vào mảng, sau đó đặt nội dung của câu cần xoá thành ""
        Dim Content As String() = Split(File.ReadAllText("Data.ini"), vbNewLine)
        Content(DongXoa) = ""

        Dim St As String = Join(Content, vbNewLine)
        St = Replace$(St, vbNewLine & vbNewLine, vbNewLine).Trim
        'Lưu
        File.WriteAllText("Data.ini", St)
        'Hiện nội dung lại
        HienCauHoi()
    End Sub

End Class
