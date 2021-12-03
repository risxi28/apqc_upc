Imports MySql.Data.MySqlClient
Public Class Hapus_corr

    Private Sub Hapus_corr_Load(sender As Object, e As EventArgs) Handles Me.Load
        no_corr.Enabled = False
        no_spk.Enabled = False
        nama_produk.Enabled = False
        kode_item.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Try
            Dim str As String
            str = "delete from corr_detail where no_corr = '" & no_corr.Text & "'and kode_item = '" & kode_item.Text & "'and no_spk = '" & no_spk.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data barang sudah di hapus..", MsgBoxStyle.Information, Title:="HAPUS DATA")
        Catch ex As Exception
            MessageBox.Show("Data gagal di update...")
        End Try
        InputCorr.loadData()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class