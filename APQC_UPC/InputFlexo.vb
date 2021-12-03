Imports MySql.Data.MySqlClient
Public Class InputFlexo
    Public kon As MySqlConnection
    Public kmd As MySqlCommand
    Public rd_sql As MySqlDataReader
    Public da_sql As MySqlDataAdapter
    Public ds_sql As DataSet
    Public str_sql As String
    Dim dr_sql As DataRow
    Dim data_sql As DataTable
    Dim cb_sql As MySqlCommandBuilder
    Sub loadData()
        Call koneksi()
        da = New MySqlDataAdapter("select * from flexo where no_flexo ='" & no_flexo.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "flexo")
        dgv.DataSource = ds.Tables("flexo")
        With dgv
            dgv.Columns(0).HeaderText = "No flexo"
            dgv.Columns(1).HeaderText = "No. SPK"
            dgv.Columns(2).HeaderText = "Tanggal"
            dgv.Columns(3).HeaderText = "Jam"
            dgv.Columns(4).HeaderText = "Kode Operator"
            dgv.Columns(5).HeaderText = "Kode Item"
            dgv.Columns(6).HeaderText = "Nama Order"
            dgv.Columns(7).HeaderText = "Panjang"
            dgv.Columns(8).HeaderText = "Lebar"
            dgv.Columns(9).HeaderText = "Tinggi"
            dgv.Columns(10).HeaderText = "Flute"
            dgv.Columns(11).HeaderText = "L1"
            dgv.Columns(12).HeaderText = "L2"
            dgv.Columns(13).HeaderText = "L3"
            dgv.Columns(14).HeaderText = "L4"
            dgv.Columns(15).HeaderText = "L5"
            dgv.Columns(16).HeaderText = "Berat Standar"
            dgv.Columns(17).HeaderText = "Berat Aktual"
            dgv.Columns(18).HeaderText = "ECT"
            dgv.Columns(19).HeaderText = "BCT Standar"
            dgv.Columns(20).HeaderText = "BCT Target"
            dgv.Columns(21).HeaderText = "BCT 1"
            dgv.Columns(22).HeaderText = "BCT 2"
            dgv.Columns(23).HeaderText = "BCT 3"
            dgv.Columns(24).HeaderText = "BCT rata-rata"
            dgv.Columns(25).HeaderText = "Kualitas Cetakan"
            dgv.Columns(26).HeaderText = "Kualitas Join"
            dgv.Columns(27).HeaderText = "Kualitas Potongan"
            dgv.Columns(28).HeaderText = "Jumlah Ikatan"
            dgv.Columns(29).HeaderText = "Nama QC LAB"
            dgv.Columns(30).HeaderText = "Keterangan"

        End With
    End Sub
    Sub nomorTransaksi()
        'memanggil module koneksi
        Call koneksi()

        'membuat variabel untuk menampung data pengurutan nomor transaksi di posisi belakang
        Dim x As String
        'membuat variabel untuk menampung data pengurutan nomor transaksi di posisi depan
        'format = Tahun-Bln --> 1901   : 19 tahun, 01 bulan 
        Dim depan, y As String
        y = "FX"
        depan = Microsoft.VisualBasic.Mid(tanggal.Text, 3, 2) + Microsoft.VisualBasic.Mid(tanggal.Text, 6, 2) + "-"

        Dim strSementara As String = ""
        Dim strIsi As String = ""
        'mencari nilai terbesar (MAX) dari nomor transaksi
        Dim cmd As New MySqlCommand("select no_flexo from flexo where no_flexo in(select max(no_flexo) from flexo) order by no_flexo desc", conn)
        Dim rd As MySqlDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            strSementara = Mid(rd.Item("no_flexo"), 9, 2)
            strIsi = Val(strSementara) + 1
            x = "0" + Mid("00", 1, 2 - strIsi.Length) & strIsi
            no_flexo.Text = y + depan + x
        Else
            no_flexo.Text = "FX2001-001"
            'cmd.ExecuteReader.Close()
            no_flexo.Focus()
        End If
        conn.Close()
    End Sub
    Sub tampilbct()
        Try
            Dim str_sql As String = "Server=192.168.24.118;user id=budianto;password=12345678;database=gdg_bj"
            kon = New MySqlConnection(str_sql)
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
            da_sql = New MySqlDataAdapter("select AVG(BCT) from BCT where SPK ='" & no_spk.Text & "'", kon)
            'membuat variable untuk mengeksekusi perintah diatas
            Dim cb_sql = New MySqlCommandBuilder(da_sql)
            da_sql.Fill(Data_sql)
            'menempatkan isi dari field yang ditunjuk kedalam combo box
            ' bct_rt.Text = "AVG(BCT)"
            bct_rt.DataSource = Data_sql
            bct_rt.ValueMember = "AVG(BCT)"
            bct_rt.DisplayMember = "AVG(BCT)"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        kon.Close()
    End Sub
    Sub tampilop()
        'memanggil koneksi
        Call koneksi()
        'menggunakan teknik try and catch
        Try
            'membuat variable untuk menampung data dari table yang ditunjuk
            Dim Data = New DataTable
            'membuat variable untuk mengarahkan ke table yang dituju 
            da = New MySqlDataAdapter("select op_n from op where kode_op ='" & simbol.Text & "'", conn)
            'membuat variable untuk mengeksekusi perintah diatas
            Dim cb = New MySqlCommandBuilder(da)
            da.Fill(Data)
            'menempatkan isi dari field yang ditunjuk kedalam combo box
            kode_op_1.DataSource = Data
            kode_op_1.ValueMember = "op_n"
            kode_op_1.DisplayMember = "op_n"
        Catch ex As Exception
        End Try
    End Sub
    Sub aktif()
        no_flexo.Enabled = False
        L1.Enabled = False
        L2.Enabled = False
        L3.Enabled = False
        L4.Enabled = False
        L5.Enabled = False
        berat_std.Enabled = True
        ECT.Enabled = True
        bct_std.Enabled = True
        bct_target.Enabled = True
        bct_rt.Enabled = True
    End Sub
    Sub kosong()
        kode_item.Text = ""
        nama_order.Text = ""
        L1.Text = "0"
        L2.Text = "0"
        L3.Text = "0"
        L4.Text = "0"
        L5.Text = "0"
        panjang.Text = "0"
        lebar.Text = "0"
        tinggi.Text = "0"
        berat_std.Text = "0"
        berat_akt.Text = "0"
        ECT.Text = "0"
        bct_std.Text = "0"
        bct_target.Text = "0"
        no_spk.Text = ""
        bct1.Text = "0"
        bct2.Text = "0"
        bct3.Text = "0"
        bct_rt.Text = "0"
        Kualitas_cetak.Text = ""
        kualitas_join.Text = ""
        Kualitas_potongan.Text = ""
        jumlah_ikatan.Text = "0"
        nama_qc_lab.Text = ""
        keterangan.Text = ""

    End Sub
    Sub beratcanggih()
        Dim a, b, c, d, j, f, g, h, i, k As Single

        a = Val(L1.Text)
        b = Val(L2.Text)
        c = Val(L3.Text)
        d = Val(L4.Text)
        j = Val(L5.Text)
        g = Val(panjang.Text)
        h = Val(lebar.Text)
        i = Val(tinggi.Text)

        If flute.Text = "BF" Then
            f = ((i + h + 10) / 1000 * (2 * g + 2 * h + 33) / 1000) * (a + b * 1.28 + c) - ((h / 2 + 2) / 1000 * 6 / 1000 * 8) * (a + b * 1.28 + c) - (24 / 1000 * (h / 2 + 2) / 1000 * 2) * (a + b * 1.28 + c)
            berat_std.Text = f
        ElseIf flute.Text = "CF" Then
            f = ((i + h + 13) / 1000 * (2 * g + 2 * h + 37) / 1000) * (a + d * 1.38 + j) - ((h / 2 + 3) / 1000 * 6 / 1000 * 8) * (a + d * 1.38 + j) - (24 / 1000 * (h / 2 + 3) / 1000 * 2) * (a + d * 1.38 + j)
            berat_std.Text = f
        ElseIf flute.Text = "BCF" Then
            f = ((i + h + 23) / 1000 * (2 * g + 2 * h + 57) / 1000) * (a + b * 1.28 + c + d * 1.38 + j) - ((h / 2 + 5) / 1000 * 6 / 1000 * 8) * (a + b * 1.28 + c + d * 1.38 + j) - (32 / 1000 * (h / 2 + 5) / 1000 * 2) * (a + b * 1.28 + c + d * 1.38 + j)
            berat_std.Text = f
        Else
        End If
        k = ((0.8 * ((a * 0.1 * 2.20462 / 6) + (c * 0.1 * 2.20462 / 6) + (j * 0.1 * 2.20462 / 6) + (b * 1.28 * 0.1 * 2.20462 / 6) + (d * 1.38 * 0.1 * 2.20462 / 6)) + 12)) * 0.45 / (2.54)
        ECT.Text = k

    End Sub
    Sub bct_canggih()
        Dim g, h, i, k As Single
        Dim l As Integer

        g = Val(panjang.Text)
        h = Val(lebar.Text)
        i = Val(tinggi.Text)
        k = Val(ECT.Text)
        If flute.Text = "BF" Then
            l = 5.87 * k * (2.6 * 0.1) ^ 0.5 * ((2 * g * 0.1 + 2 * h * 0.1) ^ 0.5)
            bct_std.Text = l
        ElseIf flute.Text = "CF" Then
            l = 5.87 * k * (3.8 * 0.1) ^ 0.5 * ((2 * g * 0.1 + 2 * h * 0.1) ^ 0.5)
            bct_std.Text = l
        ElseIf flute.Text = "BCF" Then
            l = 5.87 * k * (6.2 * 0.1) ^ 0.5 * ((2 * g * 0.1 + 2 * h * 0.1) ^ 0.5)
            bct_std.Text = l
        End If
    End Sub
    Sub target_canggih()
        Dim t, u As Integer
        t = Val(bct_std.Text)
        u = t + (t * 0.3)
        bct_target.Text = u
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InputFlexo_Load(sender As Object, e As EventArgs) Handles Me.Load
        aktif()
        kosong()
        loadData()
        nomorTransaksi()
    End Sub

    Private Sub flute_TextChanged(sender As Object, e As EventArgs) Handles flute.TextChanged
        If flute.Text = "BF" Then
            L1.Enabled = True
            L2.Enabled = True
            L3.Enabled = True
            L4.Enabled = False
            L5.Enabled = False
        ElseIf flute.Text = "CF" Then
            L1.Enabled = True
            L2.Enabled = False
            L3.Enabled = False
            L4.Enabled = True
            L5.Enabled = True
        ElseIf flute.Text = "BCF" Then
            L1.Enabled = True
            L2.Enabled = True
            L3.Enabled = True
            L4.Enabled = True
            L5.Enabled = True
        Else
            L1.Enabled = False
            L2.Enabled = False
            L3.Enabled = False
            L4.Enabled = False
            L5.Enabled = False
        End If
        L1.Text = "0"
        L2.Text = "0"
        L3.Text = "0"
        L4.Text = "0"
        L5.Text = "0"
        berat_std.Text = "0"
    End Sub

    Private Sub flute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles flute.SelectedIndexChanged

    End Sub


    Private Sub L3_TextChanged(sender As Object, e As EventArgs) Handles L3.TextChanged
        beratcanggih()
    End Sub

    Private Sub L5_TextChanged(sender As Object, e As EventArgs) Handles L5.TextChanged
        beratcanggih()
    End Sub

    Private Sub ECT_TextChanged(sender As Object, e As EventArgs) Handles ECT.TextChanged
        bct_canggih()
    End Sub

    Private Sub bct_std_TextChanged(sender As Object, e As EventArgs) Handles bct_std.TextChanged
        target_canggih()
    End Sub

    Private Sub no_spk_TextChanged(sender As Object, e As EventArgs) Handles no_spk.TextChanged
        tampilbct()
    End Sub

    Private Sub panjang_TextChanged(sender As Object, e As EventArgs) Handles panjang.TextChanged
        beratcanggih()
    End Sub

    Private Sub lebar_TextChanged(sender As Object, e As EventArgs) Handles lebar.TextChanged
        beratcanggih()
    End Sub

    Private Sub tinggi_TextChanged(sender As Object, e As EventArgs) Handles tinggi.TextChanged
        beratcanggih()
    End Sub

    Private Sub L1_TextChanged(sender As Object, e As EventArgs) Handles L1.TextChanged
        beratcanggih()
    End Sub

    Private Sub L2_TextChanged(sender As Object, e As EventArgs) Handles L2.TextChanged
        beratcanggih()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub simbol_TextChanged(sender As Object, e As EventArgs) Handles simbol.TextChanged
        tampilop()
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        Call koneksi()
        If kode_item.Text = "" Then
            MsgBox("Kode item harus diisi lengkap...", MsgBoxStyle.Information, Title:="INFORMASI")
            'loadData()
        Else
            Try
                Dim str As String
                str = "insert into flexo values ('" & no_flexo.Text & "','" & no_spk.Text & "','" & tanggal.Text & "','" & time.Text & "' , '" & simbol.Text + kode_op_0.Text + kode_op_1.Text + kode_op_2.Text + kode_op_3.Text + kode_op_4.Text + kode_op_5.Text + kode_op_6.Text + kode_op_7.Text & "', '" & kode_item.Text & "', '" & nama_order.Text & "', '" & panjang.Text & "', '" & lebar.Text & "', '" & tinggi.Text & "', '" & flute.Text & "', '" & L1.Text & "', '" & L2.Text & "', '" & L3.Text & "', '" & L4.Text & "', '" & L5.Text & "', '" & berat_std.Text & "', '" & berat_akt.Text & "', '" & ECT.Text & "', '" & bct_std.Text & "', '" & bct_target.Text & "', '" & bct1.Text & "', '" & bct2.Text & "', '" & bct3.Text & "', '" & bct_rt.Text & "', '" & Kualitas_cetak.Text & "', '" & kualitas_join.Text & "', '" & Kualitas_potongan.Text & "', '" & jumlah_ikatan.Text & "', '" & nama_qc_lab.Text & "', '" & keterangan.Text & "')"
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

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles bct1.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = Format(Now, "H:mm:ss")
    End Sub

    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
        Try
            If dgv.RowCount > 0 Then
                Dim baris As Integer
                With dgv
                    hapus_flexo.Show()
                    baris = .CurrentRow.Index
                    hapus_flexo.no_flexo.Text = .Item(0, baris).Value
                    hapus_flexo.no_spk.Text = .Item(1, baris).Value
                    hapus_flexo.kode_item.Text = .Item(5, baris).Value
                    hapus_flexo.nama_order.Text = .Item(6, baris).Value
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("DATA YANG ANDA PILIH KOSONG...")
            hapus_flexo.Close()
        End Try
    End Sub
End Class