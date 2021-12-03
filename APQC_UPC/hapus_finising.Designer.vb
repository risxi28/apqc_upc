<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hapus_finising
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nama_order = New System.Windows.Forms.TextBox()
        Me.kode_item = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.no_finising = New System.Windows.Forms.TextBox()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.tanggal)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.nama_order)
        Me.GroupBox4.Controls.Add(Me.kode_item)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label52)
        Me.GroupBox4.Controls.Add(Me.no_finising)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(464, 237)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hapus Data Finising"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(324, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 40)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "CANCLE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(182, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 40)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "DELETE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'nama_order
        '
        Me.nama_order.Location = New System.Drawing.Point(176, 143)
        Me.nama_order.Name = "nama_order"
        Me.nama_order.Size = New System.Drawing.Size(274, 26)
        Me.nama_order.TabIndex = 58
        '
        'kode_item
        '
        Me.kode_item.Location = New System.Drawing.Point(176, 104)
        Me.kode_item.Name = "kode_item"
        Me.kode_item.Size = New System.Drawing.Size(217, 26)
        Me.kode_item.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Marker", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(13, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Nama Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Marker", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(13, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Kode Item"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Marker", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "No Finising"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Segoe Marker", 12.0!)
        Me.Label52.Location = New System.Drawing.Point(13, 68)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(55, 19)
        Me.Label52.TabIndex = 52
        Me.Label52.Text = "Tanggal"
        '
        'no_finising
        '
        Me.no_finising.Location = New System.Drawing.Point(176, 28)
        Me.no_finising.Name = "no_finising"
        Me.no_finising.Size = New System.Drawing.Size(217, 26)
        Me.no_finising.TabIndex = 14
        '
        'tanggal
        '
        Me.tanggal.CustomFormat = "yyyy-MM-dd"
        Me.tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tanggal.Location = New System.Drawing.Point(176, 65)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(120, 26)
        Me.tanggal.TabIndex = 61
        Me.tanggal.Value = New Date(2020, 2, 6, 0, 0, 0, 0)
        '
        'hapus_finising
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 261)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "hapus_finising"
        Me.Text = "hapus_finising"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nama_order As System.Windows.Forms.TextBox
    Friend WithEvents kode_item As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents no_finising As System.Windows.Forms.TextBox
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
End Class
