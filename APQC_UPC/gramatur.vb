Imports MySql.Data.MySqlClient
Public Class gramatur
    Sub loadData()
        Call koneksi()
        Dim sqlQuery As String = "SELECT * FROM gramatur order by id_gm Desc"
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
                .Items.Add(TABLE.Rows(i)("id_gm"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("bursting_s"))
                    .Add(TABLE.Rows(i)("r_crush"))
                    .Add(TABLE.Rows(i)("t_kertas"))
                    .Add(TABLE.Rows(i)("rg_a"))
                    .Add(TABLE.Rows(i)("rg_b"))
                End With
            End With
        Next
    End Sub
    Sub aktif()
        gm.Enabled = False
        bs.Enabled = False
        rc.Enabled = False
        tk.Enabled = False
        rg_a.Enabled = False
        rg_b.Enabled = False
        btn_tambah.Enabled = True
        btn_edit.Enabled = True
        btn_simpan.Enabled = False
        btn_update.Enabled = False
        dl.Enabled = True
    End Sub
    Sub nonaktif()
        gm.Enabled = True
        bs.Enabled = True
        rc.Enabled = True
        tk.Enabled = True
        rg_a.Enabled = True
        rg_b.Enabled = True
        btn_tambah.Enabled = False
        btn_edit.Enabled = False
        btn_simpan.Enabled = True
        btn_update.Enabled = True
    End Sub
    Sub kosong()
        gm.Text = ""
        bs.Text = ""
        rc.Text = ""
        tk.Text = ""
        rg_a.Text = ""
        rg_b.Text = ""
    End Sub



    Private Sub gramatur_Load(sender As Object, e As EventArgs) Handles Me.Load
        aktif()
        loadData()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        nonaktif()
        btn_update.Enabled = False
        kosong()
        dl.Enabled = False
        gm.Focus()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If gm.Text = "" Or bs.Text = "" Or rc.Text = "" Or tk.Text = "" Or rg_a.Text = "" Or rg_b.Text = "" Then
            MsgBox("Pilih Data Terlebih Dahulu...", MsgBoxStyle.Information, Title:="INFORMASI")
            loadData()
        Else
            nonaktif()
            btn_simpan.Enabled = False
            dl.Enabled = False
            gm.Enabled = False
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Call koneksi()
        If gm.Text = "" Or bs.Text = "" Or rc.Text = "" Or tk.Text = "" Or rg_a.Text = "" Or rg_b.Text = "" Then
            MsgBox("Data harus diisi lengkap...", MsgBoxStyle.Information, Title:="INFORMASI")
            loadData()
        Else
            Try
                Dim str As String
                str = "insert into gramatur values ('" & gm.Text & "','" & bs.Text & "', '" & rc.Text & "', '" & tk.Text & "', '" & rg_a.Text & "', '" & rg_b.Text & "')"
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
        If gm.Text = "" Or bs.Text = "" Or rc.Text = "" Or tk.Text = "" Or rg_a.Text = "" Or rg_b.Text = "" Then
            MsgBox("Data harus diisi lengkap...", MsgBoxStyle.Information, Title:="INFORMASI")
            loadData()
        Else
            Call koneksi()
            'menggunakan teknik TRY and Catch
            Try
                Dim str As String
                str = "Update gramatur set bursting_s = '" & bs.Text & "', r_crush = '" & rc.Text & "', t_kertas = '" & tk.Text & "', rg_a='" & rg_a.Text & "', rg_b='" & rg_b.Text & "'   where id_gm = '" & gm.Text & "'"
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

    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        With ListView1.SelectedItems(0)
            gm.Text = .SubItems(0).Text
            bs.Text = .SubItems(1).Text
            rc.Text = .SubItems(2).Text
            tk.Text = .SubItems(3).Text
            rg_a.Text = .SubItems(4).Text
            rg_b.Text = .SubItems(5).Text
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles dl.Click
        If gm.Text = "" Or bs.Text = "" Or rc.Text = "" Or tk.Text = "" Or rg_a.Text = "" Then
            MsgBox("Pilih Data Terlebih Dahulu...", MsgBoxStyle.Information, Title:="INFORMASI")
            loadData()
        Else
            Call koneksi()
            Try
                Dim str As String
                str = "delete from gramatur where id_gm = '" & gm.Text & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()

                MsgBox("Data sudah di hapus..", MsgBoxStyle.Information, Title:="HAPUS DATA")
            Catch ex As Exception
                MessageBox.Show("Data gagal di update...")
            End Try
            loadData()
        End If
    End Sub

End Class
