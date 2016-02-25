Imports System.IO
Public Class frmbientap
    Private Sub butTuChoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntuchoi.Click
        Me.Close()
    End Sub
    Private Sub frmbientap_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNumeric(Me.Tag) Then
            With frmDapan.QuanLi(Me.Tag)
                txtCauhoi.Text = .Q
                txtdapan1.Text = .A1
                txtdapan2.Text = .A2
                txtdapan3.Text = .A3
                txtdapan4.Text = .A4
                cbotraloidung.SelectedIndex = .A
            End With
        Else
            cbotraloidung.SelectedIndex = 0
        End If
    End Sub
    Private Sub butChapNhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        'Kiểm tra
        If txtdapan1.Text = "" Or txtdapan2.Text = "" Or txtdapan3.Text = "" Or txtdapan4.Text = "" Or txtCauhoi.Text = "" Then
            MsgBox("Vui lòng nhập đầy đủ thông tin!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If IsNumeric(Me.Tag) Then
            'Nếu đang sửa
            With frmDapan.QuanLi(Me.Tag)
                .Q = txtCauhoi.Text
                .A1 = txtdapan1.Text : .A2 = txtdapan2.Text : .A3 = txtdapan3.Text : .A4 = txtdapan4.Text
                'Ghi dữ liệu
            End With
            Dim Content(frmDapan.QuanLi.Length - 1) As String
            For i As Integer = 0 To frmDapan.QuanLi.Length - 1
                With frmDapan.QuanLi(i)
                    Content(i) = .Q & "/" & .A1 & "/" & .A2 & "/" & .A3 & "/" & .A4 & "/" & .A
                End With
            Next
            File.WriteAllText("Data.ini", Join(Content, vbNewLine))
        Else
            'Nếu ghi thêm
            Dim Content As String = File.ReadAllText("Data.ini")
            Content += vbNewLine & txtCauhoi.Text & "/" & txtdapan1.Text & "/" & _
                txtdapan2.Text & "/" & txtdapan3.Text & "/" & txtdapan4.Text & "/" & cbotraloidung.SelectedIndex
            File.WriteAllText("Data.ini", Content)
        End If
        'Đóng form
        Me.Close()
    End Sub
End Class
