Imports MySql.Data.MySqlClient

Public Class Edit_incoming
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

    Private Sub Edit_incoming_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilGM()
        std_bs.Enabled = False
        std_rc.Enabled = False
        std_tk.Enabled = False
        rg_a.Enabled = False
        rg_b.Enabled = False
        no_incoming.Enabled = False
    End Sub

    Private Sub gmt_TextChanged(sender As Object, e As EventArgs) Handles gmt.TextChanged
        loadgm()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If akt_bs.Text = "" Or akt_rc.Text = "" Or akt_tk.Text = "" Or gmt_a.Text = "" Or gmt_t.Text = "" Or gmt_b.Text = "" Or cobb_s.Text = "" Or mp_a.Text = "" Or mp_t.Text = "" Or mp_b.Text = "" Or lot.Text = "" Or lebar_sp.Text = "" Or lebar_a.Text = "" Or b_supplier.Text = "" Or b_aktual.Text = "" Or v_cek.Text = "" Then
            MsgBox("Data harus diisi lengkap...", MsgBoxStyle.Information, Title:="INFORMASI")
        Else
            If std_bs.Text - 0.0001 >= akt_bs.Text Or std_rc.Text - 0.0001 >= akt_rc.Text Or std_tk.Text - 0.0001 >= akt_tk.Text Or rg_a.Text - 0.0001 > gmt_a.Text Or gmt_a.Text > rg_b.Text + 0.0001 Or rg_a.Text - 0.0001 > gmt_t.Text Or gmt_t.Text > rg_b.Text + 0.0001 Or rg_a.Text - 0.0001 > gmt_b.Text Or gmt_b.Text > rg_b.Text + 0.0001 Or cobb_s.Text > 90.00001 Or 4.9999 > mp_a.Text Or mp_a.Text > 9.0001 Or 4.9999 > mp_t.Text Or mp_t.Text > 9.0001 Or 4.9999 > mp_b.Text Or mp_b.Text > 9.0001 Then
                Dim Prompt, Title, Reply As String
                Prompt = "Nilai Inputan Tidak Standar, Yakin Ingin Menyimpannya ?? "
                Title = "INFO"
                Reply = MsgBox(Prompt, vbYesNo + MsgBoxStyle.OkOnly, Title)
                If Reply = vbYes Then
                    Call koneksi()
                    'menggunakan teknik TRY and Catch
                    Try
                        Dim str As String
                        str = "Update incoming_detail set lot = '" & lot.Text & "', lebar_sp = '" & lebar_sp.Text & "', lebar_a = '" & lebar_a.Text & "', berat_sp = '" & b_supplier.Text & "', berat_a = '" & b_aktual.Text & "', visual_c = '" & v_cek.Text & "', gsm_atas = '" & gmt_a.Text & "', gsm_tengah = '" & gmt_t.Text & "', gsm_bawah = '" & gmt_b.Text & "', mp_atas = '" & mp_a.Text & "', mp_tengah = '" & mp_t.Text & "', mp_bawah = '" & mp_b.Text & "', c_size = '" & cobb_s.Text & "', cb2 = '" & cb2.Text & "', ha_bs = '" & akt_bs.Text & "', ha_rc = '" & akt_rc.Text & "', ha_tk = '" & akt_tk.Text & "', status = '" & status.Text & "' where no_incoming = '" & no_incoming.Text & "' and  lot = '" & lot.Text & "'"
                        cmd = New MySqlCommand(str, conn)
                        cmd.ExecuteNonQuery()
                        Me.Close()
                        InputIncoming.loadData()
                        MsgBox("Data sudah di update..", MsgBoxStyle.Information, Title:="UPDATE DATA")
                    Catch ex As Exception
                        MessageBox.Show("Data gagal di update...")
                    End Try
                Else

                End If
            Else
                Call koneksi()
                'menggunakan teknik TRY and Catch
                Try
                    Dim str As String
                    str = "Update incoming_detail set lot = '" & lot.Text & "', lebar_sp = '" & lebar_sp.Text & "', lebar_a = '" & lebar_a.Text & "', berat_sp = '" & b_supplier.Text & "', berat_a = '" & b_aktual.Text & "', visual_c = '" & v_cek.Text & "', gsm_atas = '" & gmt_a.Text & "', gsm_tengah = '" & gmt_t.Text & "', gsm_bawah = '" & gmt_b.Text & "', mp_atas = '" & mp_a.Text & "', mp_tengah = '" & mp_t.Text & "', mp_bawah = '" & mp_b.Text & "', c_size = '" & cobb_s.Text & "', cb2 = '" & cb2.Text & "', ha_bs = '" & akt_bs.Text & "', ha_rc = '" & akt_rc.Text & "', ha_tk = '" & akt_tk.Text & "', status = '" & status.Text & "' where no_incoming = '" & no_incoming.Text & "' and  lot = '" & lot.Text & "'"
                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data sudah di update..", MsgBoxStyle.Information, Title:="UPDATE DATA")
                    Me.Close()
                    InputIncoming.loadData()
                Catch ex As Exception
                    MessageBox.Show("Data gagal di update...")
                End Try
                InputIncoming.loadData()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Try
            Dim str As String
            str = "delete from incoming_detail where lot = '" & lot.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data sudah di hapus..", MsgBoxStyle.Information, Title:="HAPUS DATA")
        Catch ex As Exception
            MessageBox.Show("Data gagal di update...")
        End Try
        InputIncoming.loadData()
        Me.Close()
    End Sub
End Class