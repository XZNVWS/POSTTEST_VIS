<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        menuInput = New ToolStripMenuItem()
        menuLihat = New ToolStripMenuItem()
        menuSimpan = New ToolStripMenuItem()
        menuBuka = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        GroupBox1 = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        cmbDivisi = New ComboBox()
        dtpLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        TabPage2 = New TabPage()
        mtbNoHP = New MaskedTextBox()
        txtAlamat = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        txtEmail = New TextBox()
        TabPage3 = New TabPage()
        btnCetak = New Button()
        gbHobi = New GroupBox()
        chk8 = New CheckBox()
        chk7 = New CheckBox()
        chk6 = New CheckBox()
        chk5 = New CheckBox()
        chk4 = New CheckBox()
        chk3 = New CheckBox()
        chk2 = New CheckBox()
        chk1 = New CheckBox()
        gbPeran = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        picFoto = New PictureBox()
        PictureBox1 = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        gbHobi.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {menuInput, menuLihat, menuSimpan, menuBuka, menuKeluar})
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(60, 24)
        InputDataToolStripMenuItem.Text = "Menu"
        ' 
        ' menuInput
        ' 
        menuInput.Name = "menuInput"
        menuInput.Size = New Size(178, 26)
        menuInput.Text = "Input Data"
        ' 
        ' menuLihat
        ' 
        menuLihat.Name = "menuLihat"
        menuLihat.Size = New Size(178, 26)
        menuLihat.Text = "Lihat Kartu"
        ' 
        ' menuSimpan
        ' 
        menuSimpan.Name = "menuSimpan"
        menuSimpan.Size = New Size(178, 26)
        menuSimpan.Text = "Simpan Data"
        ' 
        ' menuBuka
        ' 
        menuBuka.Name = "menuBuka"
        menuBuka.Size = New Size(178, 26)
        menuBuka.Text = "Buka Data"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(178, 26)
        menuKeluar.Text = "Keluar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(69, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(393, 50)
        Label1.TabIndex = 1
        Label1.Text = "KOMUNITAS DIGITAL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(69, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(299, 25)
        Label2.TabIndex = 2
        Label2.Text = "Sistem Manajemen Kartu Anggota"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(38, 140)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(527, 298)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Gainsboro
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(cmbDivisi)
        TabPage1.Controls.Add(dtpLahir)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(519, 265)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbPerempuan)
        GroupBox1.Controls.Add(rbLaki)
        GroupBox1.Location = New Point(171, 161)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 125)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(13, 56)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(13, 26)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(85, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki" & vbCrLf
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(24, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 25)
        Label7.TabIndex = 10
        Label7.Text = "Divisi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(24, 161)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 25)
        Label6.TabIndex = 9
        Label6.Text = "Jenis Kelamin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(23, 86)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 25)
        Label5.TabIndex = 8
        Label5.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(23, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 25)
        Label4.TabIndex = 7
        Label4.Text = "Masukkan ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 25)
        Label3.TabIndex = 6
        Label3.Text = "Masukkan nama "
        ' 
        ' cmbDivisi
        ' 
        cmbDivisi.FormattingEnabled = True
        cmbDivisi.Items.AddRange(New Object() {"KPDSM", "MKBM", "ADVOKASI", "HUMAS"})
        cmbDivisi.Location = New Point(171, 126)
        cmbDivisi.Name = "cmbDivisi"
        cmbDivisi.Size = New Size(151, 28)
        cmbDivisi.TabIndex = 4
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(171, 86)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(250, 27)
        dtpLahir.TabIndex = 2
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(171, 52)
        txtID.Name = "txtID"
        txtID.Size = New Size(198, 27)
        txtID.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(171, 19)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(198, 27)
        txtNama.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.LightGray
        TabPage2.Controls.Add(mtbNoHP)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(Label10)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(519, 265)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        ' 
        ' mtbNoHP
        ' 
        mtbNoHP.Location = New Point(168, 26)
        mtbNoHP.Mask = "0000-0000-0000"
        mtbNoHP.Name = "mtbNoHP"
        mtbNoHP.Size = New Size(227, 27)
        mtbNoHP.TabIndex = 11
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(168, 94)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(227, 101)
        txtAlamat.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(12, 95)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 25)
        Label10.TabIndex = 9
        Label10.Text = "Alamat"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(12, 61)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 25)
        Label9.TabIndex = 8
        Label9.Text = "Email"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 28)
        Label8.Name = "Label8"
        Label8.Size = New Size(142, 25)
        Label8.TabIndex = 7
        Label8.Text = "Nomor Telepon"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(168, 61)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(227, 27)
        txtEmail.TabIndex = 1
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.LightGray
        TabPage3.Controls.Add(btnCetak)
        TabPage3.Controls.Add(gbHobi)
        TabPage3.Controls.Add(gbPeran)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(picFoto)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(519, 265)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnCetak.Location = New Point(357, 192)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(142, 54)
        btnCetak.TabIndex = 4
        btnCetak.Text = "Simpan Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(chk8)
        gbHobi.Controls.Add(chk7)
        gbHobi.Controls.Add(chk6)
        gbHobi.Controls.Add(chk5)
        gbHobi.Controls.Add(chk4)
        gbHobi.Controls.Add(chk3)
        gbHobi.Controls.Add(chk2)
        gbHobi.Controls.Add(chk1)
        gbHobi.Location = New Point(21, 116)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(305, 143)
        gbHobi.TabIndex = 3
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' chk8
        ' 
        chk8.AutoSize = True
        chk8.Location = New Point(133, 106)
        chk8.Name = "chk8"
        chk8.Size = New Size(90, 24)
        chk8.TabIndex = 7
        chk8.Text = "Ngoding"
        chk8.UseVisualStyleBackColor = True
        ' 
        ' chk7
        ' 
        chk7.AutoSize = True
        chk7.Location = New Point(133, 76)
        chk7.Name = "chk7"
        chk7.Size = New Size(94, 24)
        chk7.TabIndex = 6
        chk7.Text = "Menyanyi"
        chk7.UseVisualStyleBackColor = True
        ' 
        ' chk6
        ' 
        chk6.AutoSize = True
        chk6.Location = New Point(133, 46)
        chk6.Name = "chk6"
        chk6.Size = New Size(94, 24)
        chk6.TabIndex = 5
        chk6.Text = "Memasak"
        chk6.UseVisualStyleBackColor = True
        ' 
        ' chk5
        ' 
        chk5.AutoSize = True
        chk5.Location = New Point(133, 22)
        chk5.Name = "chk5"
        chk5.Size = New Size(85, 24)
        chk5.TabIndex = 4
        chk5.Text = "Balapan"
        chk5.UseVisualStyleBackColor = True
        ' 
        ' chk4
        ' 
        chk4.AutoSize = True
        chk4.Location = New Point(6, 106)
        chk4.Name = "chk4"
        chk4.Size = New Size(97, 24)
        chk4.TabIndex = 3
        chk4.Text = "Membaca"
        chk4.UseVisualStyleBackColor = True
        ' 
        ' chk3
        ' 
        chk3.AutoSize = True
        chk3.Location = New Point(6, 76)
        chk3.Name = "chk3"
        chk3.Size = New Size(70, 24)
        chk3.TabIndex = 2
        chk3.Text = "Game"
        chk3.UseVisualStyleBackColor = True
        ' 
        ' chk2
        ' 
        chk2.AutoSize = True
        chk2.Location = New Point(6, 47)
        chk2.Name = "chk2"
        chk2.Size = New Size(74, 24)
        chk2.TabIndex = 1
        chk2.Text = "Basket"
        chk2.UseVisualStyleBackColor = True
        ' 
        ' chk1
        ' 
        chk1.AutoSize = True
        chk1.Location = New Point(6, 22)
        chk1.Name = "chk1"
        chk1.Size = New Size(69, 24)
        chk1.TabIndex = 0
        chk1.Text = "Futsal"
        chk1.UseVisualStyleBackColor = True
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbAdmin)
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Controls.Add(rbKetua)
        gbPeran.Location = New Point(306, 6)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(155, 110)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        gbPeran.Text = "Jabatan"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(6, 80)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(72, 24)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(6, 50)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(88, 24)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(6, 26)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(68, 24)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(161, 67)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(104, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picFoto
        ' 
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(21, 6)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(125, 90)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(571, 75)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(162, 124)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.FileName = "`"
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(TabControl1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormUtama"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents menuInput As ToolStripMenuItem
    Friend WithEvents menuLihat As ToolStripMenuItem
    Friend WithEvents menuSimpan As ToolStripMenuItem
    Friend WithEvents menuBuka As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cmbDivisi As ComboBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents mtbNoHP As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents chk8 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk6 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
