<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GramatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataIncomingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataCORRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataFlexoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataOutGoingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataOutGoingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanIncomingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanCorrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanFlexoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanFinisingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanOutGoingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAksesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.time = New System.Windows.Forms.Label()
        Me.hak = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.incoming = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.UserAksesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(510, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GramatureToolStripMenuItem, Me.SupplierToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'GramatureToolStripMenuItem
        '
        Me.GramatureToolStripMenuItem.Name = "GramatureToolStripMenuItem"
        Me.GramatureToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.GramatureToolStripMenuItem.Text = "Gramature"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataIncomingToolStripMenuItem, Me.InputDataCORRToolStripMenuItem, Me.InputDataFlexoToolStripMenuItem, Me.InputDataOutGoingToolStripMenuItem, Me.InputDataOutGoingToolStripMenuItem1})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'InputDataIncomingToolStripMenuItem
        '
        Me.InputDataIncomingToolStripMenuItem.Name = "InputDataIncomingToolStripMenuItem"
        Me.InputDataIncomingToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.InputDataIncomingToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.InputDataIncomingToolStripMenuItem.Text = "Input Data Incoming"
        '
        'InputDataCORRToolStripMenuItem
        '
        Me.InputDataCORRToolStripMenuItem.Name = "InputDataCORRToolStripMenuItem"
        Me.InputDataCORRToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.InputDataCORRToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.InputDataCORRToolStripMenuItem.Text = "Input Data CORR"
        '
        'InputDataFlexoToolStripMenuItem
        '
        Me.InputDataFlexoToolStripMenuItem.Name = "InputDataFlexoToolStripMenuItem"
        Me.InputDataFlexoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.InputDataFlexoToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.InputDataFlexoToolStripMenuItem.Text = "Input Data Flexo"
        '
        'InputDataOutGoingToolStripMenuItem
        '
        Me.InputDataOutGoingToolStripMenuItem.Name = "InputDataOutGoingToolStripMenuItem"
        Me.InputDataOutGoingToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.InputDataOutGoingToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.InputDataOutGoingToolStripMenuItem.Text = "Input Data Finising"
        '
        'InputDataOutGoingToolStripMenuItem1
        '
        Me.InputDataOutGoingToolStripMenuItem1.Name = "InputDataOutGoingToolStripMenuItem1"
        Me.InputDataOutGoingToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.InputDataOutGoingToolStripMenuItem1.Size = New System.Drawing.Size(205, 22)
        Me.InputDataOutGoingToolStripMenuItem1.Text = "Input Data Out going"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanIncomingToolStripMenuItem, Me.LaporanCorrToolStripMenuItem, Me.LaporanFlexoToolStripMenuItem, Me.LaporanFinisingToolStripMenuItem, Me.LaporanOutGoingToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanIncomingToolStripMenuItem
        '
        Me.LaporanIncomingToolStripMenuItem.Name = "LaporanIncomingToolStripMenuItem"
        Me.LaporanIncomingToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LaporanIncomingToolStripMenuItem.Text = "Laporan Incoming"
        '
        'LaporanCorrToolStripMenuItem
        '
        Me.LaporanCorrToolStripMenuItem.Name = "LaporanCorrToolStripMenuItem"
        Me.LaporanCorrToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LaporanCorrToolStripMenuItem.Text = "Laporan Corr"
        '
        'LaporanFlexoToolStripMenuItem
        '
        Me.LaporanFlexoToolStripMenuItem.Name = "LaporanFlexoToolStripMenuItem"
        Me.LaporanFlexoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LaporanFlexoToolStripMenuItem.Text = "Laporan Flexo"
        '
        'LaporanFinisingToolStripMenuItem
        '
        Me.LaporanFinisingToolStripMenuItem.Name = "LaporanFinisingToolStripMenuItem"
        Me.LaporanFinisingToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LaporanFinisingToolStripMenuItem.Text = "Laporan Finising"
        '
        'LaporanOutGoingToolStripMenuItem
        '
        Me.LaporanOutGoingToolStripMenuItem.Name = "LaporanOutGoingToolStripMenuItem"
        Me.LaporanOutGoingToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LaporanOutGoingToolStripMenuItem.Text = "Laporan Out Going"
        '
        'UserAksesToolStripMenuItem
        '
        Me.UserAksesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarUserToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.UserAksesToolStripMenuItem.Name = "UserAksesToolStripMenuItem"
        Me.UserAksesToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.UserAksesToolStripMenuItem.Text = "User Akses"
        '
        'DaftarUserToolStripMenuItem
        '
        Me.DaftarUserToolStripMenuItem.Name = "DaftarUserToolStripMenuItem"
        Me.DaftarUserToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.DaftarUserToolStripMenuItem.Text = "Daftar User"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.time)
        Me.Panel1.Controls.Add(Me.hak)
        Me.Panel1.Controls.Add(Me.nama)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 262)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 30)
        Me.Panel1.TabIndex = 5
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Font = New System.Drawing.Font("Segoe Marker", 12.0!)
        Me.time.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.time.Location = New System.Drawing.Point(443, 5)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(37, 19)
        Me.time.TabIndex = 38
        Me.time.Text = "Time"
        '
        'hak
        '
        Me.hak.AutoSize = True
        Me.hak.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.hak.Location = New System.Drawing.Point(320, 9)
        Me.hak.Name = "hak"
        Me.hak.Size = New System.Drawing.Size(36, 13)
        Me.hak.TabIndex = 3
        Me.hak.Text = "Admin"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nama.Location = New System.Drawing.Point(85, 9)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(100, 13)
        Me.nama.TabIndex = 2
        Me.nama.Text = "Risxi Bagus Eriyana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(238, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hak Akses :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama User :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(295, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "PT. ULTRA PRIMA CORRUGATOR "
        '
        'incoming
        '
        Me.incoming.BackColor = System.Drawing.Color.Lime
        Me.incoming.Font = New System.Drawing.Font("Segoe Marker", 12.0!, System.Drawing.FontStyle.Bold)
        Me.incoming.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.incoming.Location = New System.Drawing.Point(330, 27)
        Me.incoming.Name = "incoming"
        Me.incoming.Size = New System.Drawing.Size(167, 36)
        Me.incoming.TabIndex = 26
        Me.incoming.Text = "INCOMING"
        Me.incoming.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Segoe Marker", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(330, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 36)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "CORR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_tambah
        '
        Me.btn_tambah.BackColor = System.Drawing.Color.Lime
        Me.btn_tambah.Font = New System.Drawing.Font("Segoe Marker", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_tambah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_tambah.Location = New System.Drawing.Point(330, 116)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(167, 36)
        Me.btn_tambah.TabIndex = 28
        Me.btn_tambah.Text = "FLEXO"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Font = New System.Drawing.Font("Segoe Marker", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(330, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 36)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "FINISING"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Lime
        Me.Button3.Font = New System.Drawing.Font("Segoe Marker", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(330, 200)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 36)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "OUT GOING"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.APQC_UPC.My.Resources.Resources.Untitled_2
        Me.PictureBox1.Location = New System.Drawing.Point(54, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(510, 292)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.incoming)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APQC UPC"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GramatureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataIncomingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataCORRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataFlexoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataOutGoingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataOutGoingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanIncomingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanCorrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanFlexoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanFinisingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanOutGoingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents hak As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents incoming As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents time As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents UserAksesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
