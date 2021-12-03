Imports MySql.Data.MySqlClient
Public Class report_flexo
    Sub loadData()
        Call koneksi()
        da = New MySqlDataAdapter("select * from flexo", conn)
        ds = New DataSet
        da.Fill(ds, "flexo")
        dgv.DataSource = ds.Tables("flexo")
        With dgv
        End With
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        da = New MySqlDataAdapter("select * from flexo where tanggal ='" & tanggal.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "flexo")
        dgv.DataSource = ds.Tables("flexo")
        With dgv
        End With
    End Sub

    Private Sub report_flexo_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()
        tanggal.Text = Format(CDate(Now.Date.ToLongDateString), "yyyy-MM-dd")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles print.Click
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
    Sub lurubarang()

        Call koneksi()
        da = New MySqlDataAdapter("select * from flexo where no_flexo like'%" & TextBox1.Text & "%' or kode_op like'%" & TextBox1.Text & "%' or kode_item like'%" & TextBox1.Text & "%' or nama_order like'%" & TextBox1.Text & "%' or no_spk like'%" & TextBox1.Text & "%' or flute like'%" & TextBox1.Text & "%' or nama_qc_lab like'%" & TextBox1.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "flexo")
        dgv.DataSource = ds.Tables("flexo")
        With dgv
           
        End With
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lurubarang()
    End Sub
End Class