Imports MySql.Data.MySqlClient
Public Class report_outgoing
    Sub loadData()
        Call koneksi()
        da = New MySqlDataAdapter("select * from outgoing", conn)
        ds = New DataSet
        da.Fill(ds, "outgoing")
        dgv.DataSource = ds.Tables("outgoing")
        With dgv
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        da = New MySqlDataAdapter("select * from outgoing where tgl_kirim ='" & tanggal.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "outgoing")
        dgv.DataSource = ds.Tables("outgoing")
        With dgv
        End With
    End Sub

    Private Sub report_outgoing_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()
        tanggal.Text = Format(CDate(Now.Date.ToLongDateString), "yyyy-MM-dd")
    End Sub
    Sub lurubarang()

        Call koneksi()
        da = New MySqlDataAdapter("select * from outgoing where no like'%" & TextBox1.Text & "%' or customer_name like'%" & TextBox1.Text & "%' or part_name like'%" & TextBox1.Text & "%' or order_no like'%" & TextBox1.Text & "%' or dimension like'%" & TextBox1.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "outgoing")
        dgv.DataSource = ds.Tables("outgoing")
        With dgv

        End With
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lurubarang()
    End Sub
End Class