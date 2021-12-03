Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class reportCorr
    Sub loadData()
        Call koneksi()
        da = New MySqlDataAdapter("select * from view_corr", conn)
        ds = New DataSet
        da.Fill(ds, "View_corr")
        dgv.DataSource = ds.Tables("View_corr")
        With dgv

        End With
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim brs As String
        brs = dgv.CurrentRow.Index
        Dim reportku As New ReportDocument

        reportku.Load("..\..\cetakcorr.rpt")
        reportku.SetParameterValue("tanggal", tanggal.Text)
        cetakUmum.CrystalReportViewer1.ReportSource = reportku
        cetakUmum.CrystalReportViewer1.Refresh()
        cetakUmum.ShowDialog()
    End Sub

    Private Sub reportCorr_Load(sender As Object, e As EventArgs) Handles Me.Load
        tanggal.Text = Format(CDate(Now.Date.ToLongDateString), "yyyy-MM-dd")
        loadData()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lurubarang()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        da = New MySqlDataAdapter("select * from view_corr where tanggal ='" & tanggal.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "view_corr")
        dgv.DataSource = ds.Tables("view_corr")
        With dgv
        End With
    End Sub
    Sub lurubarang()

        Call koneksi()
        da = New MySqlDataAdapter("select * from view_corr where no_corr like'%" & TextBox1.Text & "%' or nama_op like'%" & TextBox1.Text & "%' or no_spk like'%" & TextBox1.Text & "%' or kode_item like'%" & TextBox1.Text & "%'or nama_p like'%" & TextBox1.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "view_corr")
        dgv.DataSource = ds.Tables("view_corr")
        With dgv
          
        End With
    End Sub

End Class