Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmCapnhatsanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=assignemnt2.mssql.somee.com;packet size=4096;user id=viper307;pwd=tamhuynh995;data source=assignemnt2.mssql.somee.com;persist security info=False;initial catalog=assignemnt2"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select PRODUCT.ID as 'Mã sản phẩm',PRODUCT.NAME as 'Tên sản phẩm', PRODUCT_CATEGORY.ID as 'Mã Loại', PRODUCT_CATEGORY.NAME as 'Tên Loại',PRODUCT.PRICE as 'GIÁ',PRODUCT.DECRIPSION as 'Mô tả' from PRODUCT inner join PRODUCT_CATEGORY on PRODUCT.ID = PRODUCT_CATEGORY.PRODUCT_ID where PRODUCT.ID='" & txtMASP.Text & "'", connect)
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvSanpham.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvSanpham.DataSource = db.DefaultView
                    txtMASP.Text = Nothing

                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMASP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmCapnhatsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvSanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanpham.CellContentClick
        Dim click As Integer = dgvSanpham.CurrentCell.RowIndex
        txtMASP.Text = dgvSanpham.Item(0, click).Value
        txtTENSP.Text = dgvSanpham.Item(1, click).Value
        txtMALOAI.Text = dgvSanpham.Item(2, click).Value
        txtTENLOAI.Text = dgvSanpham.Item(3, click).Value
        txtGia.Text = dgvSanpham.Item(4, click).Value
        txtmotasp.Text = dgvSanpham.Item(5, click).Value

    End Sub
    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select PRODUCT.ID as 'Mã sản phẩm',PRODUCT.NAME as 'Tên sản phẩm', PRODUCT_CATEGORY.ID as 'Mã Loại', PRODUCT_CATEGORY.NAME as 'Tên Loại',PRODUCT.PRICE as 'GIÁ',PRODUCT.DECRIPSION as 'Mô tả' from PRODUCT inner join PRODUCT_CATEGORY on PRODUCT.ID = PRODUCT_CATEGORY.PRODUCT_ID", conn)

        conn.Open()
        load.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub
    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update PRODUCT set ID=@PRODUCT_ID, NAME=@PRODUCT_NAME, PRICE=@PRICE,DECRIPSION=@DECRIPSION where ID=@PRODUCT_ID update PRODUCT_CATEGORY set ID=@PRODUCT_CATEGORY_ID, NAME=@PRODUCT_CATEGORY_NAME,PARENT_CATEGORY_ID=@PRODUCT_CATEGORY_ID,PRODUCT_ID =@PRODUCT_ID where PRODUCT_ID=@PRODUCT_ID"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMASP.Focus()
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMASP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTENSP.Focus()
                    If txtMALOAI.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMALOAI.Focus()
                        If txtGia.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtGia.Focus()
                            If txtmotasp.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                addupdate.Parameters.AddWithValue("@PRODUCT_ID", txtMASP.Text)
                                addupdate.Parameters.AddWithValue("@PRODUCT_NAME", txtTENSP.Text)
                                addupdate.Parameters.AddWithValue("@PRODUCT_CATEGORY_ID", txtMALOAI.Text)
                                addupdate.Parameters.AddWithValue("@PRODUCT_CATEGORY_NAME", txtTENLOAI.Text)
                                addupdate.Parameters.AddWithValue("@PRICE", txtGia.Text)
                                addupdate.Parameters.AddWithValue("@DECRIPSION", txtmotasp.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtMASP.Text = Nothing
                                txtTENSP.Text = Nothing
                                txtMALOAI.Text = Nothing
                                txtTENLOAI.Text = Nothing
                                txtGia.Text = Nothing
                                txtmotasp.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from PRODUCT where ID=@PRODUCT_ID delete from PRODUCT_CATEGORY where PRODUCT_ID=@PRODUCT_ID delete from PURCHASE_ITEM WHERE PRODUCT_ID = @PRODUCT_ID"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMASP.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@PRODUCT_ID", txtMASP.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMASP.Text = Nothing
                    txtTENSP.Text = Nothing
                    txtMALOAI.Text = Nothing
                    txtTENLOAI.Text = Nothing
                    txtGia.Text = Nothing
                    txtmotasp.Text = Nothing
                    txtMASP.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into PRODUCT values(@PRODUCT_ID,@PRODUCT_NAME,@PRICE,@DECRIPSION) insert into PRODUCT_CATEGORY values(@PRODUCT_CATEGORY_ID,@PRODUCT_CATEGORY_NAME,@PRODUCT_CATEGORY_ID,@PRODUCT_ID)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMASP.Focus()
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMASP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTENSP.Focus()
                    If txtMALOAI.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMALOAI.Focus()
                        If txtGia.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtGia.Focus()
                            If txtmotasp.Text = "" Then
                                MessageBox.Show("Bạn Chưa nhập mô tả sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@PRODUCT_ID", txtMASP.Text)
                                save.Parameters.AddWithValue("@PRODUCT_NAME", txtTENSP.Text)
                                save.Parameters.AddWithValue("@PRODUCT_CATEGORY_ID", txtMALOAI.Text)
                                save.Parameters.AddWithValue("@PRODUCT_CATEGORY_NAME", txtTENLOAI.Text)
                                save.Parameters.AddWithValue("@PRICE", txtGia.Text)
                                save.Parameters.AddWithValue("@DECRIPSION", txtmotasp.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMASP.Text = Nothing
                                txtMALOAI.Text = Nothing
                                txtGia.Text = Nothing
                                txtTENSP.Text = Nothing
                                txtTENLOAI.Text = Nothing
                                txtGia.Text = Nothing
                                txtmotasp.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select PRODUCT.ID as 'Mã sản phẩm',PRODUCT.NAME as 'Tên sản phẩm', PRODUCT_CATEGORY.ID as 'Mã Loại', PRODUCT_CATEGORY.NAME as 'Tên Loại',PRODUCT.PRICE as 'GIÁ' from PRODUCT inner join PRODUCT_CATEGORY on PRODUCT.ID = PRODUCT_CATEGORY.PRODUCT_ID", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub
End Class