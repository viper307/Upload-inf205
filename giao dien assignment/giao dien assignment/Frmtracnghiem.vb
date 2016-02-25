Imports WindowsApplication1.frmDapan

Public Class frmtracnghiem

    Dim CauHienTai As CauHoi

    Private Sub frmTracNghiem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmDapan.HienCauHoi() 'Gọi cái này để load câu hỏi
        TaoCauHoi()
    End Sub

    Private Sub TaoCauHoi()
        Randomize() 'Trộn
        Dim Max As Integer = frmDapan.QuanLi.Length - 1
        'Công thức tạo số ngẫu nhiên :
        'Int((Số lớn nhất - Số nhỏ nhất + 1) * Rnd() + Số nhỏ nhất)
        'Vì số nhỏ nhất = 0 nên thôi :D
        Dim CauHoi As Integer = Int((Max + 1) * Rnd())
        CauHienTai = frmDapan.QuanLi(CauHoi)
        With CauHienTai
            txtCAUHOI.Text = .Q
            rdb1.Text = .A1 : rdb2.Text = .A2 : rdb3.Text = .A3 : rdb4.Text = .A4
        End With
    End Sub

    Private Sub butTraLoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraloi.Click
        'Kiểm tra lần lượt
        Dim Dung As Boolean = False
        If rdb1.Checked And CauHienTai.A = 0 Then Dung = True
        If rdb2.Checked And CauHienTai.A = 1 Then Dung = True
        If rdb3.Checked And CauHienTai.A = 2 Then Dung = True
        If rdb4.Checked And CauHienTai.A = 3 Then Dung = True
        'Nếu đúng/sai
        If Dung Then
            MsgBox("Bạn đã trả lời đúng!", MsgBoxStyle.Information)
        Else
            MsgBox("Bạn đã trả lời sai, đáp án đúng : " & CauHienTai.A + 1, MsgBoxStyle.Information)
        End If
        'Dù đúng sai cũng tạo câu mới
        TaoCauHoi()
    End Sub

Private Sub btnDong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDong.Click
    Me.Close()
End Sub
End Class

