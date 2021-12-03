Imports MySql.Data.MySqlClient

Public Class MasterLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Call koneksi()
        'membuat variabel mysql data redaer
        Dim dr As MySqlDataReader

        'membuat variabel mysqlcomand
        cmd = New MySqlCommand("select * from user_akses where username= '" & UsernameTextBox.Text & "'and password = MD5('" & PasswordTextBox.Text & "')", conn)
        'mengeksekusi data reader
        dr = cmd.ExecuteReader
        dr.Read()
        'membuar informasu apabila data dalam DB user kosong/txtbox kosong
        If Not dr.HasRows Then
            MsgBox("LOGIN GAGAL. .", MsgBoxStyle.Information, Title:="INFORMASI")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UsernameTextBox.Focus()
        Else
            ' Me.Visible = False
            Timer1.Start()
            MenuUtama.nama.Text = dr.Item("nama_user")
            MenuUtama.hak.Text = dr.Item("hak")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 50
        ElseIf ProgressBar1.Value = 100 Then
            MenuUtama.Show()
            'Me.Close()
            Me.Visible = False
            Timer1.Stop()
        End If
    End Sub

    Private Sub MasterLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Stop()
    End Sub


    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
