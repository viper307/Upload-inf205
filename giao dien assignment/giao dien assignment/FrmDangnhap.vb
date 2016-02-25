Imports System.IO
Public Class frmLogin
    Dim Quyenhan As Integer
    Function Kiemtrataikhoan(ByVal taikhoan As String, ByVal matkhau As String) As Boolean
        Dim input As StreamReader = New StreamReader("nguoidung.txt")
        Dim line As String
        Dim result As String()
        Do Until input.EndOfStream
            line = input.ReadLine
            result = line.Split(ControlChars.Tab)
            If result(0) = taikhoan AndAlso result(3) = matkhau Then
                If result(6) = "Quản trị" Then
                    Quyenhan = 1
                End If
                Return True
            End If
        Loop
        Return False
    End Function

    Private Sub btnDANGNHAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDANGNHAP.Click
        If txtUsername.Text = "" OrElse txtPassword.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If txtUsername.Text = "admin" AndAlso txtPassword.Text = "12345" Then
                MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmGiaodienchinh.Show()
                Me.Hide()
            Else
                Dim kiemtra As Boolean
                kiemtra = Kiemtrataikhoan(txtUsername.Text, txtPassword.Text)
                If kiemtra = True Then
                    If Quyenhan = 1 Then
                        MessageBox.Show("Chào mừng quản trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmGiaodienchinh.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Chào mừng người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmGiaodienchinh.Show()
                        frmDapan.btnThem.Enabled = False
                        frmDapan.btnSua.Enabled = False
                        frmDapan.btnXoa.Enabled = False
                        Me.Hide()
                    End If
                Else
                    MessageBox.Show("Đăng nhập sai")
                End If
            End If
        End If
    End Sub

    Private Sub btnDONG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDONG.Click
        Dim dialog As DialogResult = MessageBox.Show("Bạn thật sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Hiển thị thông báo
        If (dialog = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class
