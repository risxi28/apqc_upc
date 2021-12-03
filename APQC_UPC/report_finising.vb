Imports MySql.Data.MySqlClient
Public Class report_finising
    Sub loadData()
        Call koneksi()
        da = New MySqlDataAdapter("select * from finising", conn)
        ds = New DataSet
        da.Fill(ds, "finising")
        dgv.DataSource = ds.Tables("finising")
        With dgv
        End With
    End Sub
    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
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

    Private Sub report_finising_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()
        tanggal.Text = Format(CDate(Now.Date.ToLongDateString), "yyyy-MM-dd")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        da = New MySqlDataAdapter("select * from finising where tanggal ='" & tanggal.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "finising")
        dgv.DataSource = ds.Tables("finising")
        With dgv
        End With
    End Sub
    Sub lurubarang()

        Call koneksi()
        da = New MySqlDataAdapter("select * from finising where no_finising like'%" & TextBox1.Text & "%' or jenis_joint like'%" & TextBox1.Text & "%' or kode_item like'%" & TextBox1.Text & "%' or nama_item like'%" & TextBox1.Text & "%' or proses_mesin like'%" & TextBox1.Text & "%' or jml_paku like'%" & TextBox1.Text & "%' or jml_ikatan like'%" & TextBox1.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "finising")
        dgv.DataSource = ds.Tables("finising")
        With dgv

        End With
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lurubarang()
    End Sub
End Class