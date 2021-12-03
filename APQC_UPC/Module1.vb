Imports MySql.Data.MySqlClient

Module Module1
    'membuat variabel-variabel koneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String
    Dim dr As DataRow
    Dim data As DataTable
    Dim cb As MySqlCommandBuilder

    'membuat prosedur koneksi ke database
    Sub koneksi()
        Try
            Dim str As String = "Server=192.168.24.118;user id=budianto;password=12345678;database=qc_ultra"
            ' Dim str As String = "Server=localhost;user id=root;password=;database=qc_ultra"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            Messagebox.show(ex.Message)
        End Try
    End Sub
End Module
