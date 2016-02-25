Imports System.Data.SqlClient
Imports System.Data

Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=assignemnt2.mssql.somee.com;packet size=4096;user id=viper307;pwd=tamhuynh995;data source=assignemnt2.mssql.somee.com;persist security info=False;initial catalog=assignemnt2"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select ID as 'Mã KH' ,FULL_NAME as 'Tên Khách Hàng', EMAIL as 'EMAIL' from CLIENT", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=assignemnt2.mssql.somee.com;packet size=4096;user id=viper307;pwd=tamhuynh995;data source=assignemnt2.mssql.somee.com;persist security info=False;initial catalog=assignemnt2"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select PRODUCT.ID as 'Mã sản phẩm',PRODUCT.NAME as 'Tên sản phẩm', PRODUCT_CATEGORY.ID as 'Mã Loại', PRODUCT_CATEGORY.NAME as 'Tên Loại',PRODUCT.PRICE as 'GIÁ',PRODUCT.DECRIPSION as 'MÔ TẢ SẢN PHẨM' from PRODUCT inner join PRODUCT_CATEGORY on PRODUCT.ID = PRODUCT_CATEGORY.PRODUCT_ID", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class

