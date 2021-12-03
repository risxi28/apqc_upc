Imports MySql.Data.MySqlClient
Public Class DaftarUser
    Sub loadData()
        Call koneksi()
        Dim sqlQuery As String = "SELECT * FROM user_akses order by id_user Desc"
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
                .Items.Add(TABLE.Rows(i)("id_user"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("nama_user"))
                    .Add(TABLE.Rows(i)("username"))
                    .Add(TABLE.Rows(i)("password"))
                    .Add(TABLE.Rows(i)("hak"))

                End With
            End With
        Next
    End Sub
    Sub kosong()
        ' id_user.Text = ""
        nama_user.Text = ""
        user_name.Text = ""
        password.Text = ""
        hak.Text = ""
        nama_user.Focus()
    End Sub
    Sub kodeOtomatis()
        'memanggil module koneksi
        Call koneksi()

        'membuat variabel untuk penambahan data
        Dim strSementara As String = ""
        Dim strisi As String = ""
        'membuat variabel sql untuk mengecek data pada tabel barang
        'berdasarkan kd_barang karena penomoran kode barang akan kita buat berurutan
        Dim cmd As New MySqlCommand("Select * From user_akses order by id_user desc", conn)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        'melakukan pengecekan terhadap kd_barang
        If dr.Read Then
            'mengisi textbox kd_barang dengan format yang kita tentukan
            'memotong dimulai dari karakter ke-3 dari depan, dipotong sebanyak 4 karakter
            strSementara = Mid(dr.Item("id_user"), 3, 4)
            strisi = Val(strSementara) + 1
            'memotong dimulai dari karakter ke-1 dari depan, dipotong sebanyak 4 karakter
            id_user.Text = "US" + Mid("00", 1, 3 - strisi.Length) & strisi
        Else
            id_user.Text = "US001"
            'cmd.ExecuteReader.Close()
            id_user.Focus()
        End If
        conn.Close()
    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Call koneksi()
        If id_user.Text = "" Or nama_user.Text = "" Or user_name.Text = "" Or password.Text = "" Or hak.Text = "" Then
            MsgBox("Data harus diisi lengkap...", MsgBoxStyle.Information, Title:="INFORMASI")
            loadData()
        Else
            Try
                Dim str As String
                str = "insert into user_akses values ('" & id_user.Text & "','" & nama_user.Text & "', '" & user_name.Text & "', MD5('" & password.Text & "'), '" & hak.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data sudah disimpan..", MsgBoxStyle.Information, Title:="SIMPAN DATA")
                'aktif()
                kosong()
                kodeOtomatis()
            Catch ex As Exception
                MessageBox.Show("Data gagal disimpan...")
            End Try
        End If
        loadData()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kosong()
        kodeOtomatis()
    End Sub

    Private Sub DaftarUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()
        kodeOtomatis()
        id_user.Enabled = False
        nama_user.Focus()
    End Sub
End Class