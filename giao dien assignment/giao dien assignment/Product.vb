Imports System.Data.SqlClient
Imports System.Data.DataSet

Public Class xemthongtinsanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=assignemnt2.mssql.somee.com;packet size=4096;user id=viper307;pwd=tamhuynh995;data source=assignemnt2.mssql.somee.com;persist security info=False;initial catalog=assignemnt2"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select PRODUCT.ID as 'Mã sản phẩm',PRODUCT.NAME as 'Tên sản phẩm', PRODUCT_CATEGORY.ID as 'Mã Loại', PRODUCT_CATEGORY.NAME as 'Tên Loại',PRODUCT.PRICE as 'giá',PRODUCT.DECRIPSION 'MÔ TẢ' from PRODUCT inner join PRODUCT_CATEGORY on PRODUCT.ID = PRODUCT_CATEGORY.PRODUCT_ID where PRODUCT.ID ='" & txtMASP.Text & "' ", connect)
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMASP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMASP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim hienthi As New Class1
        dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
    End Sub
End Class