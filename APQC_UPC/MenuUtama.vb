Public Class MenuUtama

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        supplier.Show()
    End Sub

    Private Sub GramatureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GramatureToolStripMenuItem.Click
        gramatur.Show()
    End Sub

    Private Sub InputDataIncomingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataIncomingToolStripMenuItem.Click
        loading_incoming.Show()
    End Sub

    Private Sub LaporanIncomingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanIncomingToolStripMenuItem.Click
        report_incoming.Show()
    End Sub

    Private Sub InputDataCORRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataCORRToolStripMenuItem.Click
        loading_corr.Show()
    End Sub


    Private Sub incoming_Click(sender As Object, e As EventArgs) Handles incoming.Click
        loading_incoming.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loading_corr.Show()
    End Sub

    Private Sub LaporanCorrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanCorrToolStripMenuItem.Click
        reportCorr.Show()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = Format(Now, "H:mm:ss")
    End Sub

    Private Sub MenuUtama_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.G
                gramatur.Show()
        End Select
    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        If hak.Text = "ADMIN" Then
            MasterToolStripMenuItem.Visible = False
        End If

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        MasterLogin.Show()
        MasterLogin.PasswordTextBox.Text = ""
        MasterLogin.ProgressBar1.Value = 0
    End Sub

    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click

    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        InputFlexo.Show()
    End Sub

    Private Sub UserAksesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserAksesToolStripMenuItem.Click

    End Sub

    Private Sub DaftarUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarUserToolStripMenuItem.Click
        DaftarUser.Show()
    End Sub

    Private Sub InputDataFlexoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataFlexoToolStripMenuItem.Click
        InputFlexo.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        input_outgoing.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InputFinising.Show()
    End Sub

    Private Sub LaporanFlexoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanFlexoToolStripMenuItem.Click
        report_flexo.Show()
    End Sub

    Private Sub LaporanFinisingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanFinisingToolStripMenuItem.Click
        report_finising.Show()
    End Sub

    Private Sub LaporanOutGoingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanOutGoingToolStripMenuItem.Click
        report_outgoing.Show()
    End Sub
End Class
