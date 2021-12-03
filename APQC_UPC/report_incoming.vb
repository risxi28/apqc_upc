Imports MySql.Data.MySqlClient
Public Class report_incoming
    Sub loadData()
        Call koneksi()
        da = New MySqlDataAdapter("select * from view_incoming", conn)
        ds = New DataSet
        da.Fill(ds, "View_incoming")
        dgv.DataSource = ds.Tables("view_incoming")
        With dgv
            dgv.Columns(0).Width = 110
            dgv.Columns(1).Width = 110
            dgv.Columns(2).Width = 110
            dgv.Columns(5).Width = 150
            dgv.Columns(7).Width = 200
            dgv.Columns(1).DefaultCellStyle.Format = "yyyy-MM-dd"
            dgv.Columns(2).DefaultCellStyle.Format = "yyyy-MM-dd"
            dgv.Columns(0).HeaderText = "No Pengecekan"
            dgv.Columns(1).HeaderText = "Tanggal Analisa"
            dgv.Columns(2).HeaderText = "Tanggal Datang"
            dgv.Columns(3).HeaderText = "Gramature"
            dgv.Columns(4).HeaderText = "Lebar Kertas"
            dgv.Columns(5).HeaderText = "Supplier"
            dgv.Columns(6).HeaderText = "Quantity"
            dgv.Columns(7).HeaderText = "No.BATCH/LOT"
            dgv.Columns(8).HeaderText = "Lebar Supplier"
            dgv.Columns(9).HeaderText = "Lebar Aktual"
            dgv.Columns(10).HeaderText = "Berat Supplier"
            dgv.Columns(11).HeaderText = "Berat Actual"
            dgv.Columns(12).HeaderText = "VisualL Cek"
            dgv.Columns(13).HeaderText = "GMT Atas"
            dgv.Columns(14).HeaderText = "GMT Tengah"
            dgv.Columns(15).HeaderText = "GMT Bawah"
            dgv.Columns(16).HeaderText = "MP Atas"
            dgv.Columns(17).HeaderText = "MP Tengah"
            dgv.Columns(18).HeaderText = "MP Bawah"
            dgv.Columns(19).HeaderText = "Cobb Size"
            dgv.Columns(20).HeaderText = "Cobb Size 2"
            dgv.Columns(21).HeaderText = "Bursting Strength"
            dgv.Columns(22).HeaderText = "Ring Crush"
            dgv.Columns(23).HeaderText = "Tebal Kertas"
            dgv.Columns(24).HeaderText = "Status"
        End With
    End Sub
    Sub lurubarang()

        Call koneksi()
        da = New MySqlDataAdapter("select * from view_incoming where no_incoming like'%" & TextBox1.Text & "%' or supplier like'%" & TextBox1.Text & "%' or lot like'%" & TextBox1.Text & "%' or tgl_analisa like'%" & TextBox1.Text & "%' or gramatur like'%" & TextBox1.Text & "%' or visual_c like'%" & TextBox1.Text & "%' or status like'%" & TextBox1.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "view_incoming")
        dgv.DataSource = ds.Tables("view_incoming")
        With dgv
            dgv.Columns(0).HeaderText = "No Pengecekan"
            dgv.Columns(7).HeaderText = "No. BATCH/ LOT"
            dgv.Columns(8).HeaderText = "LEBAR SUPPLIER"
            dgv.Columns(9).HeaderText = "LEBAR AKTUAL"
            dgv.Columns(10).HeaderText = "BERAT SUPPLIER"
            dgv.Columns(11).HeaderText = "BERAT AKTUAL"
            dgv.Columns(12).HeaderText = "VISUAL CEK"
            dgv.Columns(13).HeaderText = "GMT ATAS"
            dgv.Columns(14).HeaderText = "GMT TENGAH"
            dgv.Columns(15).HeaderText = "GMT BAWAH"
            dgv.Columns(16).HeaderText = "MP ATAS"
            dgv.Columns(17).HeaderText = "MP TENGAH"
            dgv.Columns(18).HeaderText = "MP BAWAH"
            dgv.Columns(19).HeaderText = "Cobb Size"
            dgv.Columns(20).HeaderText = "Cobb Size 2"
            dgv.Columns(21).HeaderText = "Bursting Strength"
            dgv.Columns(22).HeaderText = "Ring Crush"
            dgv.Columns(23).HeaderText = "Tebal Kertas"
            dgv.Columns(24).HeaderText = "Status"
        End With
    End Sub



    Private Sub report_incoming_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        da = New MySqlDataAdapter("select * from view_incoming where tgl_analisa ='" & tgl_analisa.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "view_incoming")
        dgv.DataSource = ds.Tables("view_incoming")
        With dgv
            dgv.Columns(0).HeaderText = "No Pengecekan"
            dgv.Columns(7).HeaderText = "No. BATCH/ LOT"
            dgv.Columns(8).HeaderText = "LEBAR SUPPLIER"
            dgv.Columns(9).HeaderText = "LEBAR AKTUAL"
            dgv.Columns(10).HeaderText = "BERAT SUPPLIER"
            dgv.Columns(11).HeaderText = "BERAT AKTUAL"
            dgv.Columns(12).HeaderText = "VISUAL CEK"
            dgv.Columns(13).HeaderText = "GMT ATAS"
            dgv.Columns(14).HeaderText = "GMT TENGAH"
            dgv.Columns(15).HeaderText = "GMT BAWAH"
            dgv.Columns(16).HeaderText = "MP ATAS"
            dgv.Columns(17).HeaderText = "MP TENGAH"
            dgv.Columns(18).HeaderText = "MP BAWAH"
            dgv.Columns(19).HeaderText = "Cobb Size"
            dgv.Columns(20).HeaderText = "Cobb Size 2"
            dgv.Columns(21).HeaderText = "Bursting Strength"
            dgv.Columns(22).HeaderText = "Ring Crush"
            dgv.Columns(23).HeaderText = "Tebal Kertas"
            dgv.Columns(24).HeaderText = "Status"
        End With
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lurubarang()
    End Sub
End Class