Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Edit_corr
    Public kon As SqlConnection
    Public kmd As SqlCommand
    Public rd_sql As SqlDataReader
    Public da_sql As SqlDataAdapter
    Public ds_sql As DataSet
    Public str_sql As String
    Dim dr_sql As DataRow
    Dim data_sql As DataTable
    Dim cb_sql As SqlCommandBuilder
    Sub tampilsp()
        'memanggil koneksi
        Call koneksi()
        'menggunakan teknik try and catch
        Try
            'membuat variable untuk menampung data dari table yang ditunjuk
            Dim Data = New DataTable
            'membuat variable untuk mengarahkan ke table yang dituju 
            da = New MySqlDataAdapter("select nama_sp from supplier", conn)
            'membuat variable untuk mengeksekusi perintah diatas
            Dim cb = New MySqlCommandBuilder(da)
            da.Fill(Data)
            'menempatkan isi dari field yang ditunjuk kedalam combo box
            L1_s.DataSource = Data
            L1_s.ValueMember = "nama_sp"
            L1_s.DisplayMember = "nama_sp"
        Catch ex As Exception
        End Try
    End Sub
    Sub tampilsp2()
        'memanggil koneksi
        Call koneksi()
        'menggunakan teknik try and catch
        Try
            'membuat variable untuk menampung data dari table yang ditunjuk
            Dim Data = New DataTable
            'membuat variable untuk mengarahkan ke table yang dituju 
            da = New MySqlDataAdapter("select nama_sp from supplier", conn)
            'membuat variable untuk mengeksekusi perintah diatas
            Dim cb = New MySqlCommandBuilder(da)
            da.Fill(Data)
            'menempatkan isi dari field yang ditunjuk kedalam combo box
            L2_s.DataSource = Data
            L2_s.ValueMember = "nama_sp"
            L2_s.DisplayMember = "nama_sp"
        Catch ex As Exception
        End Try
    End Sub
    Sub tampilsp3()
        'memanggil koneksi
        Call koneksi()
        'menggunakan teknik try and catch
        Try
            'membuat variable untuk menampung data dari table yang ditunjuk
            Dim Data = New DataTable
            'membuat variable untuk mengarahkan ke table yang dituju 
            da = New MySqlDataAdapter("select nama_sp from supplier", conn)
            'membuat variable untuk mengeksekusi perintah diatas
            Dim cb = New MySqlCommandBuilder(da)
            da.Fill(Data)
            'menempatkan isi dari field yang ditunjuk kedalam combo box
            L3_s.DataSource = Data
            L3_s.ValueMember = "nama_sp"
            L3_s.DisplayMember = "nama_sp"
        Catch ex As Exception
        End Try
    End Sub
    Sub tampilsp4()
        'memanggil koneksi
        Call koneksi()
        'menggunakan teknik try and catch
        Try
            'membuat variable untuk menampung data dari table yang ditunjuk
            Dim Data = New DataTable
            'membuat variable untuk mengarahkan ke table yang dituju 
            da = New MySqlDataAdapter("select nama_sp from supplier", conn)
            'membuat variable untuk mengeksekusi perintah diatas
            Dim cb = New MySqlCommandBuilder(da)
            da.Fill(Data)
            'menempatkan isi dari field yang ditunjuk kedalam combo box
            L4_s.DataSource = Data
            L4_s.ValueMember = "nama_sp"
            L4_s.DisplayMember = "nama_sp"
        Catch ex As Exception
        End Try
    End Sub
    Sub tampilsp5()
        'memanggil koneksi
        Call koneksi()
        'menggunakan teknik try and catch
        Try
            'membuat variable untuk menampung data dari table yang ditunjuk
            Dim Data = New DataTable
            'membuat variable untuk mengarahkan ke table yang dituju 
            da = New MySqlDataAdapter("select nama_sp from supplier", conn)
            'membuat variable untuk mengeksekusi perintah diatas
            Dim cb = New MySqlCommandBuilder(da)
            da.Fill(Data)
            'menempatkan isi dari field yang ditunjuk kedalam combo box
            L5_s.DataSource = Data
            L5_s.ValueMember = "nama_sp"
            L5_s.DisplayMember = "nama_sp"
        Catch ex As Exception
        End Try
    End Sub
    Sub produkcanggih()
        Panel1.Enabled = False
        nama.Enabled = True
        kode_item.Enabled = True
        nama_produk.Enabled = False
        flute.Enabled = False
        L1.Enabled = True
        L1_s.Enabled = True
        L2.Enabled = True
        L2_s.Enabled = True
        L3.Enabled = True
        L3_s.Enabled = True
        L4.Enabled = True
        L4_s.Enabled = True
        L5.Enabled = True
        L5_s.Enabled = True
        creasing.Enabled = False
        berat.Enabled = True
        ect.Enabled = False
        bst.Enabled = False
        fct.Enabled = False
        pat.Enabled = False
        tebal.Enabled = False
    End Sub
    Sub cerdas()
        If flute.Text = "BF" Then
            tebal.Text = "2.6"
        ElseIf flute.Text = "CF" Then
            tebal.Text = "3.8"
        ElseIf flute.Text = "BCF" Then
            tebal.Text = "6.2"
        ElseIf flute.Text = "" Then
            tebal.Text = ""
        End If
    End Sub
    Sub cermat()
        Dim a, b, c, d As Integer
        If L5.Text = "0" Then
            a = Val(L1.Text)
            b = Val(L3.Text)
            c = a + b
            If c = 220 Then
                ect.Text = "3"
                bst.Text = "3.4"
                fct.Text = "0.7"
                pat.Text = "0.4"
            End If
            If c = 235 Then
                ect.Text = "3.1"
                bst.Text = "3.6"
                fct.Text = "0.7"
                pat.Text = "0.4"
            End If
            If c = 245 Then
                ect.Text = "3.1"
                bst.Text = "3.6"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 250 Then
                ect.Text = "3.1"
                bst.Text = "3.6"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 260 Then
                ect.Text = "3.1"
                bst.Text = "3.6"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 275 Then
                ect.Text = "3.3"
                bst.Text = "3.8"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 285 Then
                ect.Text = "3.5"
                bst.Text = "4.0"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 300 Then
                ect.Text = "3.5"
                bst.Text = "4.0"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 310 Then
                ect.Text = "3.5"
                bst.Text = "4.0"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 325 Then
                ect.Text = "3.7"
                bst.Text = "4.8"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 335 Then
                ect.Text = "4.0"
                bst.Text = "5.0"
                fct.Text = "1.2"
                pat.Text = "0.6"
            End If
            If c = 350 Then
                ect.Text = "4.0"
                bst.Text = "5.0"
                fct.Text = "1.2"
                pat.Text = "0.6"
            End If
            If c = 400 Then
                ect.Text = "4.4"
                bst.Text = "6.0"
                fct.Text = "1.2"
                pat.Text = "0.6"
            End If

        ElseIf L3.Text = "0" Then
            a = Val(L1.Text)
            b = Val(L5.Text)
            c = a + b
            If c = 220 Then
                ect.Text = "3"
                bst.Text = "3.4"
                fct.Text = "0.7"
                pat.Text = "0.4"
            End If
            If c = 235 Then
                ect.Text = "3.1"
                bst.Text = "3.6"
                fct.Text = "0.7"
                pat.Text = "0.4"
            End If
            If c = 245 Then
                ect.Text = "3.1"
                bst.Text = "3.6"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 250 Then
                ect.Text = "3.1"
                bst.Text = "3.6"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 260 Then
                ect.Text = "3.1"
                bst.Text = "3.6"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 275 Then
                ect.Text = "3.3"
                bst.Text = "3.8"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 285 Then
                ect.Text = "3.5"
                bst.Text = "4.0"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 300 Then
                ect.Text = "3.5"
                bst.Text = "4.0"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 310 Then
                ect.Text = "3.5"
                bst.Text = "4.0"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 325 Then
                ect.Text = "3.7"
                bst.Text = "4.8"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 335 Then
                ect.Text = "4.0"
                bst.Text = "5.0"
                fct.Text = "1.2"
                pat.Text = "0.6"
            End If
            If c = 350 Then
                ect.Text = "4.0"
                bst.Text = "5.0"
                fct.Text = "1.2"
                pat.Text = "0.6"
            End If
            If c = 400 Then
                ect.Text = "4.4"
                bst.Text = "6.0"
                fct.Text = "1.2"
                pat.Text = "0.6"
            End If
        Else
            a = Val(L1.Text)
            b = Val(L3.Text)
            d = Val(L5.Text)
            c = a + b + d
            If c = 330 Then
                ect.Text = "4.5"
                bst.Text = "5.2"
                fct.Text = "0.6"
                pat.Text = "0.4"
            End If
            If c = 345 Then
                ect.Text = "4.5"
                bst.Text = "5.2"
                fct.Text = "0.6"
                pat.Text = "0.4"
            End If
            If c = 355 Then
                ect.Text = "4.5"
                bst.Text = "5.2"
                fct.Text = "0.6"
                pat.Text = "0.4"
            End If
            If c = 360 Then
                ect.Text = "5.0"
                bst.Text = "5.4"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 370 Then
                ect.Text = "5.0"
                bst.Text = "5.4"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 375 Then
                ect.Text = "5.0"
                bst.Text = "5.4"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 380 Then
                ect.Text = "5.0"
                bst.Text = "5.4"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 385 Then
                ect.Text = "5.2"
                bst.Text = "5.6"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 395 Then
                ect.Text = "5.2"
                bst.Text = "5.6"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 395 Then
                ect.Text = "5.2"
                bst.Text = "5.6"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 400 Then
                ect.Text = "5.2"
                bst.Text = "5.6"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 405 Then
                ect.Text = "5.2"
                bst.Text = "5.6"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 410 Then
                ect.Text = "5.2"
                bst.Text = "5.6"
                fct.Text = "0.8"
                pat.Text = "0.4"
            End If
            If c = 420 Then
                ect.Text = "5.4"
                bst.Text = "5.8"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 425 Then
                ect.Text = "5.4"
                bst.Text = "5.8"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 435 Then
                ect.Text = "5.8"
                bst.Text = "6.0"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 445 Then
                ect.Text = "5.8"
                bst.Text = "6.0"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 450 Then
                ect.Text = "5.8"
                bst.Text = "6.0"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 460 Then
                ect.Text = "5.8"
                bst.Text = "6.0"
                fct.Text = "1.0"
                pat.Text = "0.6"
            End If
            If c = 475 Then
                ect.Text = "6.2"
                bst.Text = "6.8"
                fct.Text = "1.2"
                pat.Text = "0.6"
            End If
            If c = 485 Then
                ect.Text = "6.2"
                bst.Text = "6.8"
                fct.Text = "1.2"
                pat.Text = "0.6"
            End If
            If c = 525 Then
                ect.Text = "7.0"
                bst.Text = "7.8"
                fct.Text = "1.2"
                pat.Text = "0.6"
            End If
            If c = 535 Then
                ect.Text = "7.0"
                bst.Text = "7.8"
                fct.Text = "1.2"
                pat.Text = "0.6"
            End If
            If c = 625 Then
                ect.Text = "7.4"
                bst.Text = "11"
                fct.Text = "1.4"
                pat.Text = "0.6"
            End If
            If c = 725 Then
                ect.Text = "8"
                bst.Text = "14"
                fct.Text = "1.4"
                pat.Text = "0.6"
            End If
        End If
    End Sub
    Sub tampilp()

        Try
            Dim str_sql As String = "Server=192.168.24.25;user id=sa;password=daqupc2015;database=CMSOnline"
            kon = New SqlConnection(str_sql)
            If kon.State = ConnectionState.Closed Then
                kon.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            'membuat variable untuk menampung data dari table yang ditunjuk
            Dim Data_sql = New DataTable
            'membuat variable untuk mengarahkan ke table yang dituju 
            da_sql = New SqlDataAdapter("select kode from dbo.Mbarang where nama like'%" & nama.Text & "%'", kon)
            'membuat variable untuk mengeksekusi perintah diatas
            Dim cb_sql = New SqlCommandBuilder(da_sql)
            da_sql.Fill(Data_sql)
            'menempatkan isi dari field yang ditunjuk kedalam combo box
            kode_item.DataSource = Data_sql
            kode_item.ValueMember = "kode"
            kode_item.DisplayMember = "kode"
        Catch ex As Exception
        End Try
        kon.Close()
    End Sub
    Sub loadp()
        Try
            Dim str_sql As String = "Server=192.168.24.25;user id=sa;password=daqupc2015;database=CMSOnline"
            kon = New SqlConnection(str_sql)
            If kon.State = ConnectionState.Closed Then
                kon.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            kmd = New System.Data.SqlClient.SqlCommand("SELECT * FROM dbo.Mbarang where kode ='" & kode_item.Text & "'", kon)
            rd_sql = kmd.ExecuteReader()
            rd_sql.Read()
            If rd_sql.HasRows Then
                nama_produk.Text = rd_sql.Item(16)
                flute.Text = rd_sql.Item(82)
                creasing.Text = rd_sql.Item(45)
                berat.Text = rd_sql.Item(78)
            End If
            kon.Close()
        Catch ex As Exception
            MessageBox.Show("Data tidak memiliki nilai flute...")
            flute.Text = ""
        End Try
    End Sub
    Private Sub Edit_corr_Load(sender As Object, e As EventArgs) Handles Me.Load
        produkcanggih()
        tampilp()
        tampilsp()
        tampilsp2()
        tampilsp3()
        tampilsp4()
        tampilsp5()
    End Sub

    Private Sub nama_TextChanged(sender As Object, e As EventArgs) Handles nama.TextChanged
        tampilp()
    End Sub

    Private Sub kode_item_TextChanged(sender As Object, e As EventArgs) Handles kode_item.TextChanged
        loadp()
    End Sub

    Private Sub flute_TextChanged(sender As Object, e As EventArgs) Handles flute.TextChanged
        cerdas()
    End Sub

    Private Sub L3_TextChanged(sender As Object, e As EventArgs) Handles L3.TextChanged
        cermat()
    End Sub

    Private Sub L5_TextChanged(sender As Object, e As EventArgs) Handles L5.TextChanged
        cermat()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Try
            Dim str As String
            str = "delete from corr_detail where no_corr = '" & no_corr.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data barang sudah di hapus..", MsgBoxStyle.Information, Title:="HAPUS DATA")
        Catch ex As Exception
            MessageBox.Show("Data gagal di update...")
        End Try
        InputCorr.loadData()
        Me.Close()
    End Sub
End Class