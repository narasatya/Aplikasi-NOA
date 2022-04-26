<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Murid
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
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtJenisKelamin = New System.Windows.Forms.TextBox()
        Me.TxtNilaiTertinggi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbBerdasarkan = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        PictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        PictureBox1.Location = New System.Drawing.Point(463, 230)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(630, 350)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnTambah)
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Controls.Add(Me.BtnHapus)
        Me.GroupBox1.Controls.Add(Me.BtnBatal)
        Me.GroupBox1.Controls.Add(Me.BtnSimpan)
        Me.GroupBox1.Controls.Add(Me.TanggalLahir)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.TxtJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.TxtNilaiTertinggi)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNis)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 438)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Murid"
        '
        'TanggalLahir
        '
        Me.TanggalLahir.Location = New System.Drawing.Point(157, 168)
        Me.TanggalLahir.Name = "TanggalLahir"
        Me.TanggalLahir.Size = New System.Drawing.Size(237, 22)
        Me.TanggalLahir.TabIndex = 10
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(157, 75)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(237, 22)
        Me.TxtNama.TabIndex = 9
        '
        'TxtJenisKelamin
        '
        Me.TxtJenisKelamin.Location = New System.Drawing.Point(157, 120)
        Me.TxtJenisKelamin.Name = "TxtJenisKelamin"
        Me.TxtJenisKelamin.Size = New System.Drawing.Size(33, 22)
        Me.TxtJenisKelamin.TabIndex = 8
        '
        'TxtNilaiTertinggi
        '
        Me.TxtNilaiTertinggi.Location = New System.Drawing.Point(157, 215)
        Me.TxtNilaiTertinggi.Name = "TxtNilaiTertinggi"
        Me.TxtNilaiTertinggi.Size = New System.Drawing.Size(237, 22)
        Me.TxtNilaiTertinggi.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(17, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(17, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nilai Tertinggi"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(17, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'TxtNis
        '
        Me.TxtNis.Location = New System.Drawing.Point(157, 31)
        Me.TxtNis.Name = "TxtNis"
        Me.TxtNis.Size = New System.Drawing.Size(237, 22)
        Me.TxtNis.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NIS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbBerdasarkan)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(461, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(633, 82)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'CmbBerdasarkan
        '
        Me.CmbBerdasarkan.FormattingEnabled = True
        Me.CmbBerdasarkan.Items.AddRange(New Object() {"NIS", "Nama"})
        Me.CmbBerdasarkan.Location = New System.Drawing.Point(114, 36)
        Me.CmbBerdasarkan.Name = "CmbBerdasarkan"
        Me.CmbBerdasarkan.Size = New System.Drawing.Size(183, 24)
        Me.CmbBerdasarkan.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(380, 36)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(247, 22)
        Me.TextBox2.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(330, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 22)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Cari"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Berdasarkan"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SlateGray
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1101, 139)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Data Murid"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(157, 297)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(86, 36)
        Me.BtnSimpan.TabIndex = 11
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(218, 355)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(86, 36)
        Me.BtnBatal.TabIndex = 12
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(104, 355)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(86, 36)
        Me.BtnHapus.TabIndex = 13
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(263, 297)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(86, 36)
        Me.BtnEdit.TabIndex = 14
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(52, 297)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(86, 36)
        Me.BtnTambah.TabIndex = 15
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'Murid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 593)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Murid"
        Me.Text = "Murid"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TanggalLahir As DateTimePicker
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtJenisKelamin As TextBox
    Friend WithEvents TxtNilaiTertinggi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNis As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbBerdasarkan As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnSimpan As Button
End Class
