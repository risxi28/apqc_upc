Imports MySql.Data.MySqlClient

Public Class InputIncoming
    Sub loadData()
        Call koneksi()
        da = New MySqlDataAdapter("select * from incoming_detail where no_incoming ='" & no_incoming.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "incoming_detail")
        dgv.DataSource = ds.Tables("incoming_detail")
        With dgv
            dgv.Columns(0).HeaderText = "No Pengecekan"
            dgv.Columns(1).HeaderText = "No. BATCH/ LOT"
            dgv.Columns(2).HeaderText = "LEBAR SUPPLIER"
            dgv.Columns(3).HeaderText = "LEBAR AKTUAL"
            dgv.Columns(4).HeaderText = "BERAT SUPPLIER"
            dgv.Columns(5).HeaderText = "BERAT AKTUAL"
            dgv.Columns(6).HeaderText = "VISUAL CEK"
            dgv.Columns(7).HeaderText = "GMT ATAS"
            dgv.Columns(8).HeaderText = "GMT TENGAH"
            dgv.Columns(9).HeaderText = "GMT BAWAH"
            dgv.Columns(10).HeaderText = "MP ATAS"
            dgv.Columns(11).HeaderText = "MP TENGAH"
            dgv.Columns(12).HeaderText = "MP BAWAH"
            dgv.Columns(13).HeaderText = "COBB SIZE"
            dgv.Columns(14).HeaderText = "COBB SIZE 2"
            dgv.Columns(15).HeaderText = "BURSTING STRENGTH"
            dgv.Columns(16).HeaderText = "RING CRUSH"
            dgv.Columns(17).HeaderText = "TEBAL KERTAS"
            dgv.Columns(18).HeaderText = "STATUS"
        End With
    End Sub

    Sub aktif()
        no_incoming.Enabled = False
        tgl_analisa.Enabled = False
        tgl_datang.Enabled = False
        gramatur.Enabled = False
        l_kertas.Enabled = False
        supplier.Enabled = False
        qty.Enabled = False
        btn_simpan.Enabled = False
        btn_edit.Enabled = False
        btn_update.Enabled = False
        std_bs.Enabled = False
        std_rc.Enabled = False
        std_tk.Enabled = False
        rg_a.Enabled = False
        rg_b.Enabled = False
    End Sub
    Sub nonaktif()
        tgl_analisa.Enabled = True
        tgl_datang.Enabled = True
        gramatur.Enabled = True
        l_kertas.Enabled = True
        supplier.Enabled = True
        qty.Enabled = True
        btn_simpan.Enabled = True
        btn_edit.Enabled = False
        btn_update.Enabled = False
        btn_tambah.Enabled = False
    End Sub
    Sub kosong()
        tgl_analisa.Text = ""
        tgl_datang.Text = ""
        gramatur.Text = ""
        l_kertas.Text = ""
        qty.Text = "0"
    End Sub
    Sub lagi()
        lot.Text = ""
        lebar_sp.Text = ""
        lebar_a.Text = ""
        b_supplier.Text = ""
        b_aktual.Text = ""
        v_cek.Text = ""
        gmt_a.Text = ""
        gmt_t.Text = ""
        gmt_b.Text = ""
        mp_a.Text = ""
        mp_b.Text = ""
        mp_t.Text = ""
        ' akt_bs.Text = ""
        ' akt_rc.Text = ""
        'akt_tk.Text = ""
        'cobb_s.Text = ""
        ' status.Text = ""
    End Sub

    Sub nomorTransaksi()
        'memanggil module koneksi
        Call koneksi()

        'membuat variabel untuk menampung data pengurutan nomor transaksi di posisi belakang
        Dim x As String
        'membuat variabel untuk menampung data pengurutan nomor transaksi di posisi depan
        'format = Tahun-Bln --> 1901   : 19 tahun, 01 bulan 
        Dim depan, y As String
        y = "PI"
        depan = Microsoft.VisualBasic.Mid(tgl_analisa.Text, 3, 2) + Microsoft.VisualBasic.Mid(tgl_analisa.Text, 6, 2) + "-"

        Dim strSementara As String = ""
        Dim strIsi As String = ""
        'mencari nilai terbesar (MAX) dari nomor transaksi
        Dim cmd As New MySqlCommand("select no_incoming from incoming where no_incoming in(select max(no_incoming) from incoming) order by no_incoming desc", conn)
        Dim rd As MySqlDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            strSementara = Mid(rd.Item("no_incoming"), 9, 6)
            strIsi = Val(strSementara) + 1
            x = "0" + Mid("000000", 1, 6 - strIsi.Length) & strIsi
            no_incoming.Text = y + depan + x
        Else
            no_incoming.Text = "TP2002-0000001"
            'cmd.ExecuteReader.Close()
            no_incoming.Focus()
        End If
        conn.Close()
    End Sub
    Sub tampilGM()
        'memanggil koneksi
        Call koneksi()
        'menggunakan teknik try and catch
        Try
            'membuat variable untuk menampung data dari table yang ditunjuk
            Dim Data = New DataTable
            'membuat variable untuk mengarahkan ke table yang dituju 
            da = New MySqlDataAdapter("select id_gm from gramatur", conn)
            'membuat variable untuk mengeksekusi perintah diatas
            Dim cb = New MySqlCommandBuilder(da)
            da.Fill(Data)
            'menempatkan isi dari field yang ditunjuk kedalam combo box
            gmt.DataSource = Data
            gmt.ValueMember = "id_gm"
            gmt.DisplayMember = "id_gm"
        Catch ex As Exception
        End Try
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
            supplier.DataSource = Data
            supplier.ValueMember = "nama_sp"
            supplier.DisplayMember = "nama_sp"
        Catch ex As Exception
        End Try
    End Sub
    Sub loadgm()
        Call koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM gramatur where id_gm ='" & gmt.Text & "'", conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        If rd.HasRows Then
            std_bs.Text = rd.Item(1)
            std_rc.Text = rd.Item(2)
            std_tk.Text = rd.Item(3)
            rg_a.Text = rd.Item(4)
            rg_b.Text = rd.Item(5)
        End If
        conn.Close()
    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Call koneksi()
        If gramatur.Text = "" Or l_kertas.Text = "" Or supplier.Text = "" Or qty.Text = "0" Then
            MsgBox("Data harus diisi lengkap...", MsgBoxStyle.Information, Title:="INFORMASI")
            loadData()
        Else
            Try
                Dim str As String
                str = "insert into incoming values ('" & no_incoming.Text & "','" & tgl_analisa.Text & "','" & tgl_datang.Text & "','" & gramatur.Text & "','" & l_kertas.Text & "','" & supplier.Text & "','" & qty.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                Panel1.Enabled = True
                aktif()
                lot.Focus()
                'btn_tambah.Enabled = True
                btn_edit.Enabled = True
                MsgBox("Data sudah disimpan..", MsgBoxStyle.Information, Title:="SIMPAN DATA")
            Catch ex As Exception
                MessageBox.Show("Data gagal disimpan...")
            End Try
        End If
        loadData()

    End Sub

    Private Sub incoming_Load(sender As Object, e As EventArgs) Handles Me.Load
        aktif()
        tampilGM()
        tampilsp()
        Panel1.Enabled = False
        nomorTransaksi()

    End Sub


    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        nonaktif()
        kosong()
        nomorTransaksi()
        gramatur.Focus()
    End Sub

    Private Sub gmt_TextChanged(sender As Object, e As EventArgs) Handles gmt.TextChanged
        loadgm()

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        nonaktif()
        btn_update.Enabled = True
        btn_simpan.Enabled = False
        Panel1.Enabled = False
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If gramatur.Text = "" Or l_kertas.Text = "" Or supplier.Text = "" Or qty.Text = "0" Then
            MsgBox("Data harus diisi lengkap...", MsgBoxStyle.Information, Title:="INFORMASI")
            loadData()
        Else
            Call koneksi()
            'menggunakan teknik TRY and Catch
            Try
                Dim str As String
                str = "Update incoming set tgl_analisa = '" & tgl_analisa.Text & "', tgl_datang = '" & tgl_datang.Text & "', gramatur = '" & gramatur.Text & "', l_kertas = '" & l_kertas.Text & "', supplier = '" & supplier.Text & "' where no_incoming = '" & no_incoming.Text & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data sudah di update..", MsgBoxStyle.Information, Title:="UPDATE DATA")
            Catch ex As Exception
                MessageBox.Show("Data gagal di update...")
            End Try
        End If
        Panel1.Enabled = True
        aktif()
        btn_edit.Enabled = True
        loadData()
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If akt_bs.Text = "" Or akt_rc.Text = "" Or akt_tk.Text = "" Or gmt_a.Text = "" Or gmt_t.Text = "" Or gmt_b.Text = "" Or cobb_s.Text = "" Or mp_a.Text = "" Or mp_t.Text = "" Or mp_b.Text = "" Or lot.Text = "" Or lebar_sp.Text = "" Or lebar_a.Text = "" Or b_supplier.Text = "" Or b_aktual.Text = "" Or v_cek.Text = "" Then
            MsgBox("Data harus diisi lengkap...", MsgBoxStyle.Information, Title:="INFORMASI")
            loadData()
        Else
            If std_bs.Text - 0.0001 >= akt_bs.Text Or std_rc.Text - 0.0001 >= akt_rc.Text Or std_tk.Text - 0.0001 >= akt_tk.Text Or rg_a.Text - 0.0001 > gmt_a.Text Or gmt_a.Text > rg_b.Text + 0.0001 Or rg_a.Text - 0.0001 > gmt_t.Text Or gmt_t.Text > rg_b.Text + 0.0001 Or rg_a.Text - 0.0001 > gmt_b.Text Or gmt_b.Text > rg_b.Text + 0.0001 Or cobb_s.Text > 90.00001 Or 4.9999 > mp_a.Text Or mp_a.Text > 9.0001 Or 4.9999 > mp_t.Text Or mp_t.Text > 9.0001 Or 4.9999 > mp_b.Text Or mp_b.Text > 9.0001 Then
                Dim Prompt, Title, Reply As String
                Prompt = "Nilai Inputan Tidak Standar, Yakin Ingin Menyimpannya ?? "
                Title = "INFO"
                Reply = MsgBox(Prompt, vbYesNo + MsgBoxStyle.OkOnly, Title)
                If Reply = vbYes Then
                    Try
                        Dim str As String
                        str = "insert into incoming_detail values ('" & no_incoming.Text & "','" & lot.Text & "','" & lebar_sp.Text & "','" & lebar_a.Text & "','" & b_supplier.Text & "','" & b_aktual.Text & "','" & v_cek.Text & "','" & gmt_a.Text & "','" & gmt_t.Text & "','" & gmt_b.Text & "','" & mp_a.Text & "','" & mp_t.Text & "','" & mp_b.Text & "','" & cobb_s.Text & "','" & cb2.Text & "','" & akt_bs.Text & "','" & akt_rc.Text & "','" & akt_tk.Text & "','" & status.Text & "')"
                        cmd = New MySqlCommand(str, conn)
                        cmd.ExecuteNonQuery()
                        lagi()
                        MsgBox("Data sudah disimpan..", MsgBoxStyle.Information, Title:="SIMPAN DATA")
                    Catch ex As Exception
                        MessageBox.Show("Data gagal disimpan...")
                    End Try
                Else

                End If
            Else
                Try
                    Dim str As String
                    str = "insert into incoming_detail values ('" & no_incoming.Text & "','" & lot.Text & "','" & lebar_sp.Text & "','" & lebar_a.Text & "','" & b_supplier.Text & "','" & b_aktual.Text & "','" & v_cek.Text & "','" & gmt_a.Text & "','" & gmt_t.Text & "','" & gmt_b.Text & "','" & mp_a.Text & "','" & mp_t.Text & "','" & mp_b.Text & "','" & cobb_s.Text & "','" & cb2.Text & "','" & akt_bs.Text & "','" & akt_rc.Text & "','" & akt_tk.Text & "','" & status.Text & "')"
                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    lagi()
                    MsgBox("Data sudah disimpan..", MsgBoxStyle.Information, Title:="SIMPAN DATA")
                Catch ex As Exception
                    MessageBox.Show("Data gagal disimpan...")
                End Try
            End If
        End If
        loadData()
    End Sub


    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
        Try
            Edit_incoming.Show()
            If dgv.RowCount > 0 Then
                Dim baris As Integer
                With dgv
                    baris = .CurrentRow.Index
                    Edit_incoming.no_incoming.Text = .Item(0, baris).Value
                    Edit_incoming.lot.Text = .Item(1, baris).Value
                    Edit_incoming.lebar_sp.Text = .Item(2, baris).Value
                    Edit_incoming.lebar_a.Text = .Item(3, baris).Value
                    Edit_incoming.b_supplier.Text = .Item(4, baris).Value
                    Edit_incoming.b_aktual.Text = .Item(5, baris).Value
                    Edit_incoming.v_cek.Text = .Item(6, baris).Value
                    Edit_incoming.gmt_a.Text = .Item(7, baris).Value
                    Edit_incoming.gmt_t.Text = .Item(8, baris).Value
                    Edit_incoming.gmt_b.Text = .Item(9, baris).Value
                    Edit_incoming.mp_a.Text = .Item(10, baris).Value
                    Edit_incoming.mp_t.Text = .Item(11, baris).Value
                    Edit_incoming.mp_b.Text = .Item(12, baris).Value
                    Edit_incoming.cobb_s.Text = .Item(13, baris).Value
                    Edit_incoming.cb2.Text = .Item(14, baris).Value
                    Edit_incoming.akt_bs.Text = .Item(15, baris).Value
                    Edit_incoming.akt_rc.Text = .Item(16, baris).Value
                    Edit_incoming.akt_tk.Text = .Item(17, baris).Value
                    Edit_incoming.status.Text = .Item(18, baris).Value
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("DATA YANG ANDA PILIH KOSONG...")
            Edit_incoming.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ExcelApp As Object, ExcelBook As Object
        Dim ExcelSheet As Object
        Dim i As Integer
        Dim j As Integer
        ExcelApp = CreateObject("Excel.Application")
        ExcelBook = ExcelApp.WorkBooks.Add
        ExcelSheet = ExcelBook.WorkSheets(1)

        With ExcelSheet
            For i = 1 To Me.dgv.RowCount
                .Cells(i, 1) = Me.dgv.Rows(i - 1).Cells(0).Value
                For j = 1 To dgv.Columns.Count - 1
                    .cells(i, j + 1) = dgv.Rows(i - 1).Cells(j).Value
                Next
            Next
        End With
        ExcelApp.Visible = True
        ExcelSheet = Nothing
        ExcelBook = Nothing
        ExcelApp = Nothing
    End Sub

    Private Sub gramatur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gramatur.KeyPress
        If (e.KeyChar = Chr(13)) Then
            l_kertas.Focus()
        End If
    End Sub

    Private Sub l_kertas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles l_kertas.KeyPress
        If (e.KeyChar = Chr(13)) Then
            supplier.Focus()
        End If
    End Sub

    Private Sub supplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles supplier.KeyPress
        If (e.KeyChar = Chr(13)) Then
            qty.Focus()
        End If
    End Sub

    Private Sub lot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lot.KeyPress
        If (e.KeyChar = Chr(13)) Then
            lebar_sp.Focus()
        End If
    End Sub

    Private Sub lebar_sp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lebar_sp.KeyPress
        If (e.KeyChar = Chr(13)) Then
            lebar_a.Focus()
        End If
    End Sub

    Private Sub lebar_a_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lebar_a.KeyPress
        If (e.KeyChar = Chr(13)) Then
            b_supplier.Focus()
        End If
    End Sub

    Private Sub b_supplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles b_supplier.KeyPress
        If (e.KeyChar = Chr(13)) Then
            b_aktual.Focus()
        End If
    End Sub

    Private Sub b_aktual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles b_aktual.KeyPress
        If (e.KeyChar = Chr(13)) Then
            v_cek.Focus()
        End If
    End Sub

    Private Sub v_cek_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v_cek.KeyPress
        If (e.KeyChar = Chr(13)) Then
            gmt_a.Focus()
        End If
    End Sub

    Private Sub gmt_a_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gmt_a.KeyPress
        If (e.KeyChar = Chr(13)) Then
            gmt_t.Focus()
        End If
    End Sub

    Private Sub gmt_t_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gmt_t.KeyPress
        If (e.KeyChar = Chr(13)) Then
            gmt_b.Focus()
        End If
    End Sub

    Private Sub gmt_b_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gmt_b.KeyPress
        If (e.KeyChar = Chr(13)) Then
            mp_a.Focus()
        End If
    End Sub

    Private Sub mp_a_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mp_a.KeyPress
        If (e.KeyChar = Chr(13)) Then
            mp_t.Focus()
        End If
    End Sub

    Private Sub mp_t_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mp_t.KeyPress
        If (e.KeyChar = Chr(13)) Then
            mp_b.Focus()
        End If
    End Sub

    Private Sub mp_b_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mp_b.KeyPress
        If (e.KeyChar = Chr(13)) Then
            akt_bs.Focus()
        End If
    End Sub

    Private Sub akt_bs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles akt_bs.KeyPress
        If (e.KeyChar = Chr(13)) Then
            akt_rc.Focus()
        End If
    End Sub



    Private Sub akt_rc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles akt_rc.KeyPress
        If (e.KeyChar = Chr(13)) Then
            akt_tk.Focus()
        End If
    End Sub

    Private Sub akt_tk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles akt_tk.KeyPress
        If (e.KeyChar = Chr(13)) Then
            cobb_s.Focus()
        End If
    End Sub

    Private Sub cobb_s_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cobb_s.KeyPress
        If (e.KeyChar = Chr(13)) Then
            status.Focus()
        End If
    End Sub

    Private Sub lot_TextChanged(sender As Object, e As EventArgs) Handles lot.TextChanged

    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs)

    End Sub
End Class