Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Public Class input_outgoing
    Public kon As SqlConnection
    Public kmd As SqlCommand
    Public rd_sql As SqlDataReader
    Public da_sql As SqlDataAdapter
    Public ds_sql As DataSet
    Public str_sql As String
    Dim dr_sql As DataRow
    Dim data_sql As DataTable
    Dim cb_sql As SqlCommandBuilder
    Sub loadkodeitem()
        'memanggil koneksi
        Call koneksi()
        'menggunakan teknik try and catch
        Try
            'membuat variable untuk menampung data dari table yang ditunjuk
            Dim Data = New DataTable
            'membuat variable untuk mengarahkan ke table yang dituju 
            da = New MySqlDataAdapter("select kode_item from flexo where tanggal ='" & produksi.Text & "'", conn)
            'membuat variable untuk mengeksekusi perintah diatas
            Dim cb = New MySqlCommandBuilder(da)
            da.Fill(Data)
            'menempatkan isi dari field yang ditunjuk kedalam combo box
            kode_item.DataSource = Data
            kode_item.ValueMember = "kode_item"
            kode_item.DisplayMember = "kode_item"
        Catch ex As Exception
        End Try
    End Sub
    Sub caribarang()

        Try
            Dim str_sql As String = "Server=192.168.24.25;user id=sa;password=daqupc2015;database=CMSOnline"
            kon = New SqlConnection(str_sql)
            If kon.State = ConnectionState.Closed Then
                kon.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            'membuat variable untuk menampung data dari table yang ditunjuk
            Dim Data_sql = New DataTable
            'membuat variable untuk mengarahkan ke table yang dituju 
            da_sql = New SqlDataAdapter("select kode from dbo.Mbarang where nama like'%" & nama.Text & "%'", kon)
            'membuat variable untuk mengeksekusi perintah diatas
            Dim cb_sql = New SqlCommandBuilder(da_sql)
            da_sql.Fill(Data_sql)
            'menempatkan isi dari field yang ditunjuk kedalam combo box
            kode_item.DataSource = Data_sql
            kode_item.ValueMember = "kode"
            kode_item.DisplayMember = "kode"
        Catch ex As Exception
        End Try
        kon.Close()
    End Sub
    Sub tampilitem()
        Call koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM flexo where kode_item ='" & kode_item.Text & "'", conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        If rd.HasRows Then
            wight_box_std.Text = rd.Item(16)
            wight_box_r.Text = rd.Item(17)
        End If
        conn.Close()
    End Sub
    Sub tampilp()
        Try
            Dim str_sql As String = "Server=192.168.24.25;user id=sa;password=daqupc2015;database=CMSOnline"
            kon = New SqlConnection(str_sql)
            If kon.State = ConnectionState.Closed Then
                kon.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            'membuat variable untuk menampung data dari table yang ditunjuk
            Dim Data_sql = New DataTable
            'membuat variable untuk mengarahkan ke table yang dituju 
            da_sql = New SqlDataAdapter("select kode from dbo.Mbarang ", kon)
            'membuat variable untuk mengeksekusi perintah diatas
            Dim cb_sql = New SqlCommandBuilder(da_sql)
            da_sql.Fill(Data_sql)
            'menempatkan isi dari field yang ditunjuk kedalam combo box
            kode_item.DataSource = Data_sql
            kode_item.ValueMember = "kode"
            kode_item.DisplayMember = "kode"
        Catch ex As Exception
        End Try
        kon.Close()
    End Sub
    Sub cetak_umum()
        box_print.Text = "     PT ULTRA PRIMA CORRUGATOR" + System.Environment.NewLine
        box_print.Text += "     KOMPLEK INDUSTRI SARANA TERPADU" + System.Environment.NewLine
        box_print.Text += "     (KAWASAN MURINDA) RT001 RW006" + System.Environment.NewLine
        box_print.Text += "     DS PASIR GOMBONG CIKARANG UTARA" + System.Environment.NewLine
        box_print.Text += "     BEKASI - JAWA BARAT" + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        box_print.Text += "                                CERTIFICATE OF ANALYSIS"
        box_print.Text += System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        box_print.Text += "     NO                   : " + no.Text + System.Environment.NewLine
        box_print.Text += "     CUSTOMER NAME        : " + cs_name.Text + System.Environment.NewLine
        box_print.Text += "     PART NAME            : " + p_name.Text + System.Environment.NewLine
        box_print.Text += "     DIMENSION (LxWxH)    : " + dimension.Text + System.Environment.NewLine
        box_print.Text += "     SUBTANCE             : " + substance.Text + System.Environment.NewLine
        box_print.Text += "     COLOUR               : " + colour.Text + System.Environment.NewLine
        box_print.Text += "     ORDE NO              : " + order_no.Text + System.Environment.NewLine
        box_print.Text += "     PRODUCTION           : " + produksi.Text + System.Environment.NewLine
        box_print.Text += "     TGL KIRIM            : " + tgl_kirim.Text + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| NO |        ITEM          |   EQUIPMEN TEST   | UNIT  |      STANDARD     |      RESULT      | " + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 1  | SUBSTANCE            | ELECTONIC BALANCE | GR/M2 |   " + st.Text + "  |  " + st.Text + "  |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 2  | DIMENSION :          |                   |       |                   |                  |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "|    | -LENGTH              |  STAINLESS RULER  |   mm  |        " + length_std.Text + " +-2    |       " + length_r.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "|    | -WIDTH               |  STAINLESS RULER  |   mm  |        " + width_std.Text + " +-2    |       " + width_result.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "|    | -HEIGHT              |  STAINLESS RULER  |   mm  |        " + height_std.Text + " +-2    |       " + height_r.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 3  | FLUTE                |       VISUAL      |   -   |        " + flute.Text + "        |       " + flute.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 4  | WEIGHT BOX           | ELECTONIC BALANCE | PCS/GR|        " + wight_box_std.Text + " +-4%   |       " + wight_box_r.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 5  | BOX COMPRESSION TEST |  BOX COMPRESSION  |  Kgf  |      " + box_c_std.Text + "      |       " + box_r.Text + "        |" + System.Environment.NewLine
        box_print.Text += "|    |                      |     TESTER        |       |                   |                  |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 6  | JOINT TYPE           |         -         |   -   |       GLUE        |       GLUE       |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 7  | APPEARANCE           |       VISUAL      |   -   | NO DAMAGE AND NO  |        OK        | " + System.Environment.NewLine
        box_print.Text += "|    |                      |                   |       |       BENDED      |                  |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 8  | COLOUR PRINTING      |       VISUAL      |   -   | MATCH WITH COLOUR |        OK        |" + System.Environment.NewLine
        box_print.Text += "|    |                      |                   |       | GUIDE STD CUSTOMER|                  |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        box_print.Text += "     APPROVED BY"
        box_print.Text += System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        box_print.Text += System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        box_print.Text += "     MEIRIN CHATERINA" + System.Environment.NewLine
        box_print.Text += "     QUALITY CONTROL" + System.Environment.NewLine
    End Sub
    Sub cetak_khusus()
        box_print.Text = "     PT ULTRA PRIMA CORRUGATOR" + System.Environment.NewLine
        box_print.Text += "     KOMPLEK INDUSTRI SARANA TERPADU" + System.Environment.NewLine
        box_print.Text += "     (KAWASAN MURINDA) RT001 RW006" + System.Environment.NewLine
        box_print.Text += "     DS PASIR GOMBONG CIKARANG UTARA" + System.Environment.NewLine
        box_print.Text += "     BEKASI - JAWA BARAT" + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        box_print.Text += "                                CERTIFICATE OF ANALYSIS"
        box_print.Text += System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        box_print.Text += "     NO                   : " + no.Text + System.Environment.NewLine
        box_print.Text += "     CUSTOMER NAME        : " + cs_name.Text + System.Environment.NewLine
        box_print.Text += "     PART NAME            : " + p_name.Text + System.Environment.NewLine
        box_print.Text += "     DIMENSION (LxWxH)    : " + dimension.Text + System.Environment.NewLine
        box_print.Text += "     SUBTANCE             : " + substance.Text + System.Environment.NewLine
        box_print.Text += "     COLOUR               : " + colour.Text + System.Environment.NewLine
        box_print.Text += "     ORDE NO              : " + order_no.Text + System.Environment.NewLine
        box_print.Text += "     PRODUCTION           : " + produksi.Text + System.Environment.NewLine
        box_print.Text += "     TGL KIRIM            : " + tgl_kirim.Text + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| NO |        ITEM          |   EQUIPMEN TEST   | UNIT  |      STANDARD     |      RESULT      | " + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 1  | SUBSTANCE            | ELECTONIC BALANCE | GR/M2 |   " + st.Text + "  |  " + st.Text + "  |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "|    |                      |                   |       |      " + st1.Text + " +-4%    |       " + st_r1.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "|    |                      |                   |       |      " + st2.Text + " +-4%    |       " + st_r2.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "|    |                      |                   |       |      " + st3.Text + " +-4%    |       " + st_r3.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 2  | DIMENSION :          |                   |       |                   |                  |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "|    | -LENGTH              |  STAINLESS RULER  |   mm  |        " + length_std.Text + " +-2    |       " + length_r.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "|    | -WIDTH               |  STAINLESS RULER  |   mm  |        " + width_std.Text + " +-2    |       " + width_result.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "|    | -HEIGHT              |  STAINLESS RULER  |   mm  |        " + height_std.Text + " +-2    |       " + height_r.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 3  | FLUTE                |       VISUAL      |   -   |        " + flute.Text + "        |       " + flute.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 4  | WEIGHT BOX           | ELECTONIC BALANCE | PCS/GR|        " + wight_box_std.Text + " +-4%   |       " + wight_box_r.Text + "        |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 5  | BOX COMPRESSION TEST |  BOX COMPRESSION  |  Kgf  |      " + box_c_std.Text + "      |       " + box_r.Text + "        |" + System.Environment.NewLine
        box_print.Text += "|    |                      |     TESTER        |       |                   |                  |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 6  | JOINT TYPE           |         -         |   -   |       GLUE        |       GLUE       |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 7  | APPEARANCE           |       VISUAL      |   -   | NO DAMAGE AND NO  |        OK        | " + System.Environment.NewLine
        box_print.Text += "|    |                      |                   |       |       BENDED      |                  |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += "| 8  | COLOUR PRINTING      |       VISUAL      |   -   | MATCH WITH COLOUR |        OK        |" + System.Environment.NewLine
        box_print.Text += "|    |                      |                   |       | GUIDE STD CUSTOMER|                  |" + System.Environment.NewLine
        box_print.Text += "------------------------------------------------------------------------------------------------" + System.Environment.NewLine
        box_print.Text += System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        box_print.Text += "     APPROVED BY"
        box_print.Text += System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        box_print.Text += System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        box_print.Text += "     MEIRIN CHATERINA" + System.Environment.NewLine
        box_print.Text += "     QUALITY CONTROL" + System.Environment.NewLine
    End Sub

    Sub kosong()
        no.Text = ""
        kode_item.Text = ""
        cs_name.Text = ""
        p_name.Text = ""
        dimension.Text = ""
        substance.Text = ""
        colour.Text = ""
        order_no.Text = ""
        st.Text = ""
        st1.Text = ""
        st2.Text = ""
        st3.Text = ""
        st_r1.Text = ""
        st_r2.Text = ""
        st_r3.Text = ""
        length_std.Text = ""
        length_r.Text = ""
        width_std.Text = ""
        width_result.Text = ""
        height_std.Text = ""
        height_r.Text = ""
        flute.Text = ""
        wight_box_std.Text = ""
        wight_box_r.Text = ""


    End Sub
    Sub loadp()
        Try
            Dim str_sql As String = "Server=192.168.24.25;user id=sa;password=daqupc2015;database=CMSOnline"
            kon = New SqlConnection(str_sql)
            If kon.State = ConnectionState.Closed Then
                kon.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If kode_item.Text = "" Then
            ' MessageBox.Show("Kode Item Tidak Ada")
        Else

            Try
                kmd = New System.Data.SqlClient.SqlCommand("SELECT * FROM dbo.Mbarang where kode ='" & kode_item.Text & "'", kon)
                rd_sql = kmd.ExecuteReader()
                rd_sql.Read()
                If rd_sql.HasRows Then
                    p_name.Text = rd_sql.Item(16)
                    flute.Text = rd_sql.Item(82)
                    cs_name.Text = rd_sql.Item(15)
                    dimension.Text = rd_sql.Item(24)
                    substance.Text = rd_sql.Item(54)
                    colour.Text = rd_sql.Item(92)
                    st.Text = rd_sql.Item(54)
                    st1.Text = rd_sql.Item(46)
                    ' st2.Text = rd_sql.Item(47)
                    ' st3.Text = rd_sql.Item(48)
                    st2.Text = rd_sql.Item(49)
                    st3.Text = rd_sql.Item(50)
                    length_std.Text = rd_sql.Item(20)
                    length_r.Text = rd_sql.Item(20)
                    width_std.Text = rd_sql.Item(21)
                    width_result.Text = rd_sql.Item(21)
                    height_std.Text = rd_sql.Item(22)
                    height_r.Text = rd_sql.Item(22)
                    'height_std.Text = height_std.Text + " +-2"
                    'width_std.Text = width_std.Text + " +-2"
                    'length_std.Text = length_std.Text + " +-2"
                Else
                    kosong()
                End If

                kon.Close()
            Catch ex As Exception
                MessageBox.Show("Data tidak ada")
            End Try
        End If
    End Sub
    Private Sub input_outgoing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadkodeitem()
        tampilp()
        kosong()
    End Sub
    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        If no.Text = "" Then
            MsgBox("No harus diisi dahulu", MsgBoxStyle.Information, Title:="INFO")
        Else
            Call koneksi()
            Try
                Dim str As String
                str = "insert into outgoing values ('" & no.Text & "','" & cs_name.Text & "','" & p_name.Text & "','" & dimension.Text & "','" & substance.Text & "','" & colour.Text & "','" & order_no.Text & "','" & produksi.Text & "','" & tgl_kirim.Text & "','" & st.Text & "','" & st1.Text & "','" & st2.Text & "','" & st3.Text & "','" & st_r1.Text & "','" & st_r2.Text & "','" & st_r3.Text & "','" & length_std.Text & "','" & length_r.Text & "','" & width_std.Text & "','" & width_result.Text & "','" & height_std.Text & "','" & height_r.Text & "','" & flute.Text & "','" & wight_box_std.Text & "','" & wight_box_r.Text & "','" & box_c_std.Text & "','" & box_r.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data sudah disimpan..", MsgBoxStyle.Information, Title:="SIMPAN DATA")
            Catch ex As Exception
                MessageBox.Show("Data gagal disimpan...")
            End Try
        End If
    End Sub

    Private Sub kode_item_TextChanged(sender As Object, e As EventArgs) Handles kode_item.TextChanged
        loadp()
        tampilitem()
    End Sub


    Private Sub produksi_TextChanged(sender As Object, e As EventArgs) Handles produksi.TextChanged
        loadkodeitem()
        If kode_item.SelectedValue = "" Then
            kosong()
        Else
        End If
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        kosong()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim reportku As New ReportDocument
        'If jenis_Print.Text = "UMUM" Then
        '    reportku.Load("..\..\cetakoutgoing.rpt")
        'ElseIf jenis_Print.Text = "KHUSUS" Then
        '    reportku.Load("..\..\cetak2.rpt")
        'End If
        'reportku.SetParameterValue("no", no.Text)
        'cetakUmum.CrystalReportViewer1.ReportSource = reportku
        'cetakUmum.CrystalReportViewer1.Refresh()

        'cetakUmum.ShowDialog()
        Dim writer As TextWriter = New StreamWriter("D:\OutGoingPrint.txt")
        writer.Write(box_print.Text)
        writer.Close()
        MessageBox.Show("Export berhasil")

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles box_print.TextChanged

    End Sub

    Private Sub txt_prin_Click(sender As Object, e As EventArgs)
        box_print.Text = "PT ULTRA PRIMA CORRUGATOR" + System.Environment.NewLine + "KOMPLEK INDUSTRI SARANA TERPADU" + System.Environment.NewLine + "(KAWASAN MURINDA) RT001 RW006" + System.Environment.NewLine + "DS PASIR GOMBONG CIKARANG UTARA" + System.Environment.NewLine + "BEKASI - JAWA BARAT" + System.Environment.NewLine
        box_print.Text += "                           CERTIFICATE OF ANALYSIS"
    End Sub

    Private Sub jenis_Print_TextChanged(sender As Object, e As EventArgs) Handles jenis_Print.TextChanged
        If jenis_Print.Text = "UMUM" Then
            cetak_umum()
        ElseIf jenis_Print.Text = "KHUSUS" Then
            cetak_khusus()
        End If
    End Sub

    Private Sub nama_TextChanged(sender As Object, e As EventArgs) Handles nama.TextChanged
        caribarang()
    End Sub
End Class