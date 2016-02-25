Imports System.Data.SqlClient
Imports System.Data

Public Class xemthongtinKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=assignemnt2.mssql.somee.com;packet size=4096;user id=viper307;pwd=tamhuynh995;data source=assignemnt2.mssql.somee.com;persist security info=False;initial catalog=assignemnt2"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub xemthongtinKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnxem_Click(sender As Object, e As EventArgs) Handles btnxem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select ID as 'Mã KH' ,FULL_NAME, EMAIL from CLIENT where ID='" & txtMAKH.Text & "'", connect)
        Try
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập MAKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvxemkh.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvxemkh.DataSource = db.DefaultView
                    txtMAKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMAKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnxemall_Click(sender As Object, e As EventArgs) Handles btnxemall.Click
        Dim hienthi As New Class1
        dgvxemkh.DataSource = hienthi.Loadkhachang.Tables(0)
    End Sub

    Private Sub btnquaylai_Click(sender As Object, e As EventArgs) Handles btnquaylai.Click
        frmGiaodienchinh.Show()
        Me.Hide()
    End Sub
End Class