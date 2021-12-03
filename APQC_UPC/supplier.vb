Imports MySql.Data.MySqlClient

Public Class supplier
    Sub loadData()
        Call koneksi()
        Dim sqlQuery As String = "SELECT * FROM supplier order by kode_sp Desc"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        Dim TABLE As New DataTable
        Dim i As Integer

        With sqlCommand
            .CommandText = sqlQuery
            .Connection = conn
        End With

        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(TABLE)
        End With

        ListView1.Items.Clear()
        For i = 0 To TABLE.Rows.Count - 1
            With ListView1
                .Items.Add(TABLE.Rows(i)("kode_sp"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("nama_sp"))
                End With
            End With
        Next
    End Sub
    Sub aktif()
        kode_sp.Enabled = False
        nama_sp.Enabled = False
        btn_tambah.Enabled = True
        btn_edit.Enabled = True
        btn_simpan.Enabled = False
        btn_update.Enabled = False
        dl.Enabled = True
    End Sub
    Sub nonaktif()
        nama_sp.Enabled = True
        btn_tambah.Enabled = False
        btn_edit.Enabled = False
        btn_simpan.Enabled = True
        btn_update.Enabled = True
    End Sub
    Sub kosong()
        kode_sp.Text = ""
        nama_sp.Text = ""
    End Sub
    Sub kodeOtomatis()
        'memanggil module koneksi
        Call koneksi()

        'membuat variabel untuk penambahan data
        Dim strSementara As String = ""
        Dim strisi As String = ""
        'membuat variabel sql untuk mengecek data pada tabel barang
        'berdasarkan kd_barang karena penomoran kode barang akan kita buat berurutan
        Dim cmd As New MySqlCommand("Select * From supplier order by kode_sp desc", conn)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        'melakukan pengecekan terhadap kd_barang
        If dr.Read Then
            'mengisi textbox kd_barang dengan format yang kita tentukan
            'memotong dimulai dari karakter ke-3 dari depan, dipotong sebanyak 4 karakter
            strSementara = Mid(dr.Item("kode_sp"), 3, 4)
            strisi = Val(strSementara) + 1
            'memotong dimulai dari karakter ke-1 dari depan, dipotong sebanyak 4 karakter
            kode_sp.Text = "S" + Mid("00", 1, 3 - strisi.Length) & strisi
        Else
            kode_sp.Text = "S001"
            'cmd.ExecuteReader.Close()
            kode_sp.Focus()
        End If
        conn.Close()
    End Sub
    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        nonaktif()
        btn_update.Enabled = False
        kosong()
        dl.Enabled = False
        nama_sp.Focus()
        kodeOtomatis()
    End Sub

    Private Sub supplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        aktif()
        loadData()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If kode_sp.Text = "" Or nama_sp.Text = "" Then
            MsgBox("Pilih Data Terlebih Dahulu...", MsgBoxStyle.Information, Title:="INFORMASI")
            loadData()
        Else
            nonaktif()
            btn_simpan.Enabled = False
            dl.Enabled = False
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Call koneksi()
        If kode_sp.Text = "" Or nama_sp.Text = "" Then
            MsgBox("Data harus diisi lengkap...", MsgBoxStyle.Information, Title:="INFORMASI")
            loadData()
        Else
            Try
                Dim str As String
                str = "insert into supplier values ('" & kode_sp.Text & "','" & nama_sp.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data sudah disimpan..", MsgBoxStyle.Information, Title:="SIMPAN DATA")
                aktif()
            Catch ex As Exception
                MessageBox.Show("Data gagal disimpan...")
            End Try
        End If
        loadData()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If kode_sp.Text = "" Or nama_sp.Text = "" Then
            MsgBox("Data harus diisi lengkap...", MsgBoxStyle.Information, Title:="INFORMASI")
            loadData()
        Else
            Call koneksi()
            'menggunakan teknik TRY and Catch
            Try
                Dim str As String
                str = "Update supplier set nama_sp = '" & nama_sp.Text & "' where kode_sp = '" & kode_sp.Text & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                aktif()
                MsgBox("Data sudah di update..", MsgBoxStyle.Information, Title:="UPDATE DATA")
            Catch ex As Exception
                MessageBox.Show("Data gagal di update...")
            End Try
        End If
        loadData()
    End Sub

    Private Sub dl_Click(sender As Object, e As EventArgs) Handles dl.Click
        If kode_sp.Text = "" Or nama_sp.Text = "" Then
            MsgBox("Pilih Data Terlebih Dahulu...", MsgBoxStyle.Information, Title:="INFORMASI")
            loadData()
        Else
            Call koneksi()
            Try
                Dim str As String
                str = "delete from supplier where kode_sp = '" & kode_sp.Text & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()

                MsgBox("Data sudah di hapus..", MsgBoxStyle.Information, Title:="HAPUS DATA")
            Catch ex As Exception
                MessageBox.Show("Data gagal di update...")
            End Try
            loadData()
        End If
    End Sub

    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        With ListView1.SelectedItems(0)
            kode_sp.Text = .SubItems(0).Text
            nama_sp.Text = .SubItems(1).Text
        End With
    End Sub
End Class