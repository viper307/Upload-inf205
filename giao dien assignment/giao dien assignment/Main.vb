Imports System.IO
Imports System.Threading
Public Class frmGiaodienchinh
    Private Sub butQuanLi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniTRACNGHIEM.Click, btntracnghiem.Click
        frmTracNghiem.ShowDialog(Me)
    End Sub

    Private Sub butTracNghiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniDAPAN.Click, btndapan.Click
        frmDapan.ShowDialog(Me)
    End Sub
    Private Sub mniKETTHUC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniKETTHUC.Click
        Me.Close()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btndangnhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndangnhap.Click
        frmLogin.ShowDialog(Me)
    End Sub

    Private Sub mniDANGNHAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniDANGNHAP.Click
        frmLogin.ShowDialog(Me)
    End Sub

    Private Sub mniBIENTAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniBIENTAP.Click
        frmbientap.ShowDialog(Me)
    End Sub

    Private Sub mniQUANLIUSER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniQUANLIUSER.Click
        frmQuanlinguoidung.ShowDialog(Me)
    End Sub

    Private Sub mniDanhsachKH_Click(sender As Object, e As EventArgs) Handles mniDanhsachKH.Click
        xemthongtinKH.ShowDialog(Me)
    End Sub

    Private Sub mniChinhsuaKH_Click(sender As Object, e As EventArgs) Handles mniChinhsuaKH.Click
        frmDieuchinhKH.ShowDialog(Me)
    End Sub

    Private Sub mniDanhsachSP_Click(sender As Object, e As EventArgs) Handles mniDanhsachSP.Click
        xemthongtinsanpham.ShowDialog(Me)
    End Sub

    Private Sub mniChinhsuaSP_Click(sender As Object, e As EventArgs) Handles mniChinhsuaSP.Click
        frmCapnhatsanpham.ShowDialog(Me)
    End Sub
End Class
