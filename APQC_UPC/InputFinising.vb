Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class InputFinising
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
        da = New MySqlDataAdapter("select * from finising where tanggal ='" & tanggal.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "finising")
        dgv.DataSource = ds.Tables("finising")
        With dgv  
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
        Dim cmd As New MySqlCommand("select no_finising from finising where no_finising in(select max(no_finising) from finising) order by no_finising desc", conn)
        Dim rd As MySqlDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            strSementara = Mid(rd.Item("no_finising"), 9, 2)
            strIsi = Val(strSementara) + 1
            x = "0" + Mid("00", 1, 2 - strIsi.Length) & strIsi
            no_finising.Text = y + depan + x
        Else
            no_finising.Text = "FX2001-001"
            'cmd.ExecuteReader.Close()
            no_finising.Focus()
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
                nama_item.Text = rd_sql.Item(16)
                jml_ikatan.Text = rd_sql.Item(96)
                jml_paku.Text = rd_sql.Item(97)
            End If
            kon.Close()
        Catch ex As Exception
            MessageBox.Show("Data tidak memiliki nilai...")
        End Try
    End Sub
    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        Call koneksi()
        If kode_item.Text = "" Then
            MsgBox("Kode item harus diisi lengkap...", MsgBoxStyle.Information, Title:="INFORMASI")
            'loadData()
        Else
            Try
                Dim str As String
                str = "insert into finising values ('" & no_finising.Text & "','" & tanggal.Text & "','" & kode_item.Text & "','" & nama_item.Text & "', '" & jenis_join.Text & "', '" & proses_mesin.Text & "', '" & jml_paku.Text & "', '" & jml_ikatan.Text & "', '" & ws.Text & "', '" & s_b_s.Text & "', '" & j_mc.Text & "', '" & j_t_m.Text & "', '" & s_r_l.Text & "', '" & l_f_t_b.Text & "', '" & keterangan.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data sudah disimpan..", MsgBoxStyle.Information, Title:="SIMPAN DATA")
                loadData()

            Catch ex As Exception
                MessageBox.Show("Data gagal disimpan...")
            End Try
        End If
        loadData()
    End Sub

    Private Sub InputFinising_Load(sender As Object, e As EventArgs) Handles Me.Load
        no_finising.Enabled = False
        tampilp()
        nomorTransaksi()
        nama_item.Enabled = False

    End Sub

    Private Sub kode_item_TextChanged(sender As Object, e As EventArgs) Handles kode_item.TextChanged
        loadp()
    End Sub

    Private Sub nama_TextChanged(sender As Object, e As EventArgs) Handles nama.TextChanged
        tampilp()
    End Sub

    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
        Try
            If dgv.RowCount > 0 Then
                Dim baris As Integer
                With dgv
                    hapus_finising.Show()
                    baris = .CurrentRow.Index
                    hapus_finising.no_finising.Text = .Item(0, baris).Value
                    hapus_finising.tanggal.Text = .Item(1, baris).Value
                    hapus_finising.kode_item.Text = .Item(2, baris).Value
                    hapus_finising.nama_order.Text = .Item(3, baris).Value
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("DATA YANG ANDA PILIH KOSONG...")
            hapus_flexo.Close()
        End Try
    End Sub
End Class