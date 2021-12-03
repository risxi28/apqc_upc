Imports MySql.Data.MySqlClient
Public Class hapus_flexo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Try
            Dim str As String
            str = "delete from flexo where no_flexo = '" & no_flexo.Text & "' and kode_item = '" & kode_item.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data sudah di hapus..", MsgBoxStyle.Information, Title:="HAPUS DATA")
        Catch ex As Exception
            MessageBox.Show("Data gagal di update...")
        End Try
        InputFlexo.loadData()
        Me.Close()
    End Sub

    Private Sub hapus_flexo_Load(sender As Object, e As EventArgs) Handles Me.Load

        no_flexo.Enabled = False
        no_spk.Enabled = False
        nama_order.Enabled = False
        kode_item.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class