Imports MySql.Data.MySqlClient
Public Class hapus_finising

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Try
            Dim str As String
            str = "delete from finising where no_finising = '" & no_finising.Text & "' and kode_item = '" & kode_item.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data sudah di hapus..", MsgBoxStyle.Information, Title:="HAPUS DATA")
        Catch ex As Exception
            MessageBox.Show("Data gagal di update...")
        End Try
        InputFinising.loadData()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub hapus_finising_Load(sender As Object, e As EventArgs) Handles Me.Load
        no_finising.Enabled = False
        tanggal.Enabled = False
        kode_item.Enabled = False
        nama_order.Enabled = False
    End Sub
End Class