Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class InputCorr
    Public kon As SqlConnection
    Public kmd As SqlCommand
    Public rd_sql As SqlDataReader
    Public da_sql As SqlDataAdapter
    Public ds_sql As DataSet
    Public str_sql As String
    Dim dr_sql As DataRow
    Dim data_sql As DataTable
    Dim cb_sql As SqlCommandBuilder
    Sub loadData()
        Call koneksi()
        da = New MySqlDataAdapter("select * from corr_detail where no_corr ='" & no_corr.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "corr_detail")
        dgv.DataSource = ds.Tables("corr_detail")
        With dgv

        End With
    End Sub
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

    Sub kosong()
        L1.Text = "0"
        L2.Text = "0"
        L3.Text = "0"
        L4.Text = "0"
        L5.Text = "0"
        L1_s.Text = ""
        L2_s.Text = ""
        L3_s.Text = ""
        L4_s.Text = ""
        L5_s.Text = ""
        akt_berat.Text = "0"
        akt_ect_1.Text = "0"
        akt_ect_2.Text = "0"
        akt_ect_3.Text = "0"
        akt_bst_1.Text = "0"
        akt_bst_2.Text = "0"
        akt_bst_3.Text = "0"
        akt_fct_1.Text = "0"
        akt_fct_2.Text = "0"
        akt_fct_3.Text = "0"
        akt_pat_1.Text = "0"
        akt_pat_2.Text = "0"
        akt_pat_3.Text = "0"
        akt_tebal_1.Text = "0"
        akt_tebal_2.Text = "0"
        akt_tebal_3.Text = "0"
        p_sheet.Text = "0"
        no_spk.Text = ""
        l_sheet1.Text = "0"
        l_sheet2.Text = "0"
        l_sheet3.Text = "0"
        l_sheet4.Text = "0"
        l_sheet5.Text = "0"
        flap_a1.Text = "0"
        flap_a2.Text = "0"
        flap_a3.Text = "0"
        flap_a4.Text = "0"
        flap_a5.Text = "0"
        flap_b1.Text = "0"
        flap_b2.Text = "0"
        flap_b3.Text = "0"
        flap_b4.Text = "0"
        flap_b5.Text = "0"
        tkl_bcf.Text = "0"
        tkl_cf.Text = "0"
        tkl_bf.Text = "0"
        tkf_bf.Text = "0"
        tkf_cf.Text = "0"
        ts_bf_bcf.Text = "0"
        ts_cf_bcf.Text = "0"
        t_glue_1.Text = ""
        t_glue_2.Text = ""
        keterangan.Text = ""
        ect.Text = "0"
        bst.Text = "0"
        fct.Text = "0"
        pat.Text = "0"



    End Sub
    Sub aktif()
        nama.Enabled = False
        Panel1.Enabled = True
        no_corr.Enabled = False
        btn_simpan.Enabled = False
        btn_edit.Enabled = False
        btn_update.Enabled = False
        nama_op.Enabled = False
        tanggal.Enabled = False
        kode_item.Enabled = False
        nama_produk.Enabled = False
        flute.Enabled = False
        creasing.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        GroupBox5.Enabled = False
        GroupBox6.Enabled = False
        GroupBox7.Enabled = False
        GroupBox8.Enabled = False
        GroupBox9.Enabled = False
        GroupBox10.Enabled = False
        GroupBox11.Enabled = False
        GroupBox12.Enabled = False
        GroupBox13.Enabled = False
        GroupBox14.Enabled = False
        p_sheet.Enabled = False
        no_spk.Enabled = False
        Button3.Enabled = False
    End Sub
    Sub produkcanggih()
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
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        GroupBox4.Enabled = True
        GroupBox5.Enabled = True
        GroupBox6.Enabled = True
        GroupBox7.Enabled = True
        GroupBox8.Enabled = True
        GroupBox9.Enabled = True
        GroupBox10.Enabled = True
        GroupBox11.Enabled = True
        GroupBox12.Enabled = True
        GroupBox13.Enabled = True
        GroupBox14.Enabled = True
        p_sheet.Enabled = True
        no_spk.Enabled = True
        Button3.Enabled = True
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
    Sub nomorTransaksi()
        'memanggil module koneksi
        Call koneksi()

        'membuat variabel untuk menampung data pengurutan nomor transaksi di posisi belakang
        Dim x As String
        'membuat variabel untuk menampung data pengurutan nomor transaksi di posisi depan
        'format = Tahun-Bln --> 1901   : 19 tahun, 01 bulan 
        Dim depan, y As String
        y = "CR"
        depan = Microsoft.VisualBasic.Mid(tanggal.Text, 3, 2) + Microsoft.VisualBasic.Mid(tanggal.Text, 6, 2) + "-"

        Dim strSementara As String = ""
        Dim strIsi As String = ""
        'mencari nilai terbesar (MAX) dari nomor transaksi
        Dim cmd As New MySqlCommand("select no_corr from corr where no_corr in(select max(no_corr) from corr) order by no_corr desc", conn)
        Dim rd As MySqlDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            strSementara = Mid(rd.Item("no_corr"), 9, 6)
            strIsi = Val(strSementara) + 1
            x = "0" + Mid("000000", 1, 6 - strIsi.Length) & strIsi
            no_corr.Text = y + depan + x
        Else
            no_corr.Text = "CR2001-0000001"
            'cmd.ExecuteReader.Close()
            no_corr.Focus()
        End If
        conn.Close()
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

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        nama_op.Enabled = True
        nama_op.Focus()
        btn_simpan.Enabled = True
        btn_tambah.Enabled = False
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If nama_op.Text = "" Then
            MsgBox("Nama Operator harus diisi dahulu", MsgBoxStyle.Information, Title:="INFO")
        Else
            Call koneksi()
            Try
                Dim str As String
                str = "insert into corr values ('" & no_corr.Text & "','" & tanggal.Text & "','" & nama_op.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                nama_op.Enabled = False
                btn_simpan.Enabled = False
                btn_edit.Enabled = True
                produkcanggih()
                kosong()
                MsgBox("Data sudah disimpan..", MsgBoxStyle.Information, Title:="SIMPAN DATA")
            Catch ex As Exception
                MessageBox.Show("Data gagal disimpan...")
            End Try
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        aktif()
        nama_op.Focus()
        btn_simpan.Enabled = False
        btn_update.Enabled = True
        tanggal.Enabled = True
        nama_op.Enabled = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If nama_op.Text = "" Then
            MsgBox("Nama Operator Harus diisi...", MsgBoxStyle.Information, Title:="INFORMASI")
        Else
            Call koneksi()
            'menggunakan teknik TRY and Catch
            Try
                Dim str As String
                str = "Update corr set tanggal = '" & tanggal.Text & "', nama_op = '" & nama_op.Text & "' where no_corr = '" & no_corr.Text & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data sudah di update..", MsgBoxStyle.Information, Title:="UPDATE DATA")
            Catch ex As Exception
                MessageBox.Show("Data gagal di update...")
            End Try
        End If
        nama_op.Enabled = False
        tanggal.Enabled = False
        btn_simpan.Enabled = False
        btn_edit.Enabled = True
        produkcanggih()
        btn_update.Enabled = False
    End Sub

    Private Sub InputCorr_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampilp()
        nomorTransaksi()
        aktif()
        tampilsp()
        tampilsp2()
        tampilsp3()
        tampilsp4()
        tampilsp5()
    End Sub

    Private Sub kode_item_TextChanged(sender As Object, e As EventArgs) Handles kode_item.TextChanged
        loadp()
    End Sub

    Private Sub flute_TextChanged(sender As Object, e As EventArgs) Handles flute.TextChanged
        cerdas()
    End Sub

    Private Sub nama_TextChanged(sender As Object, e As EventArgs) Handles nama.TextChanged
        tampilp()
    End Sub

    Private Sub L3_TextChanged(sender As Object, e As EventArgs) Handles L3.TextChanged
        cermat()
    End Sub

    Private Sub L5_TextChanged(sender As Object, e As EventArgs) Handles L5.TextChanged
        cermat()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call koneksi()
        If no_spk.Text = "" Then
            MsgBox("No SPK harus diisi lengkap...", MsgBoxStyle.Information, Title:="INFORMASI")
            'loadData()
        Else
            Try
                Dim str As String
                str = "insert into corr_detail values ('" & no_corr.Text & "','" & no_spk.Text & "','" & time.Text & "', '" & kode_item.Text & "', '" & nama_produk.Text & "', '" & flute.Text & "', '" & creasing.Text & "', '" & L1.Text & "', '" & L1_s.Text & "', '" & L2.Text & "', '" & L2_s.Text & "', '" & L3.Text & "', '" & L3_s.Text & "', '" & L4.Text & "', '" & L4_s.Text & "', '" & L5.Text & "', '" & L5_s.Text & "', '" & berat.Text & "', '" & ect.Text & "', '" & bst.Text & "', '" & fct.Text & "', '" & pat.Text & "', '" & tebal.Text & "', '" & akt_berat.Text & "', '" & akt_ect_1.Text & "', '" & akt_ect_2.Text & "', '" & akt_ect_3.Text & "', '" & akt_bst_1.Text & "', '" & akt_bst_2.Text & "', '" & akt_bst_3.Text & "', '" & akt_fct_1.Text & "', '" & akt_fct_2.Text & "', '" & akt_fct_3.Text & "', '" & akt_pat_1.Text & "', '" & akt_pat_2.Text & "', '" & akt_pat_3.Text & "', '" & akt_tebal_1.Text & "', '" & akt_tebal_2.Text & "', '" & akt_tebal_3.Text & "', '" & p_sheet.Text & "', '" & l_sheet1.Text & "', '" & flap_a1.Text & "', '" & flap_b1.Text & "', '" & l_sheet2.Text & "', '" & flap_a2.Text & "', '" & flap_b2.Text & "', '" & l_sheet3.Text & "', '" & flap_a3.Text & "', '" & flap_b3.Text & "', '" & l_sheet4.Text & "', '" & flap_a4.Text & "', '" & flap_b4.Text & "', '" & l_sheet5.Text & "', '" & flap_a5.Text & "', '" & flap_b5.Text & "', '" & tkl_bf.Text & "', '" & tkf_bf.Text & "', '" & tkl_cf.Text & "', '" & tkf_cf.Text & "', '" & ts_cf_bcf.Text & "', '" & ts_bf_bcf.Text & "', '" & tkl_bcf.Text & "', '" & t_glue_1.Text & "', '" & t_glue_2.Text & "', '" & keterangan.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data sudah disimpan..", MsgBoxStyle.Information, Title:="SIMPAN DATA")
                kosong()
                loadData()
            Catch ex As Exception
                MessageBox.Show("Data gagal disimpan...")
            End Try
        End If
        loadData()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = Format(Now, "H:mm:ss")
    End Sub

    Private Sub time_Click(sender As Object, e As EventArgs) Handles time.Click

    End Sub

    Private Sub L2_s_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
        Try
            If dgv.RowCount > 0 Then
                Dim baris As Integer
                With dgv
                    Hapus_corr.Show()
                    baris = .CurrentRow.Index
                    Hapus_corr.no_corr.Text = .Item(0, baris).Value
                    Hapus_corr.no_spk.Text = .Item(1, baris).Value
                    Hapus_corr.kode_item.Text = .Item(3, baris).Value
                    Hapus_corr.nama_produk.Text = .Item(4, baris).Value
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("DATA YANG ANDA PILIH KOSONG...")
            Hapus_corr.Close()
        End Try
        'Try
        '    If dgv.RowCount > 0 Then
        '        Dim baris As Integer
        '        With dgv
        '            Edit_corr.Show()
        '            baris = .CurrentRow.Index
        '            Edit_corr.no_corr.Text = .Item(0, baris).Value
        '            Edit_corr.no_spk.Text = .Item(1, baris).Value
        '            Edit_corr.kode_item.Text = .Item(3, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.flute.Text = .Item(5, baris).Value
        '            Edit_corr.creasing.Text = .Item(6, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '            Edit_corr.nama_produk.Text = .Item(4, baris).Value
        '        End With
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("DATA YANG ANDA PILIH KOSONG...")
        '    Hapus_corr.Close()
        'End Try
    End Sub
End Class