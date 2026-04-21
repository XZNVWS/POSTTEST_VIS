<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtNama = New TextBox()
        txtJam = New TextBox()
        dtpTanggal = New DateTimePicker()
        cmbLayanan = New ComboBox()
        btnTambah = New Button()
        btnUpdate = New Button()
        btnHapus = New Button()
        btnClear = New Button()
        dgvBooking = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        txtID = New TextBox()
        CType(dgvBooking, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(123, 40)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(261, 27)
        txtNama.TabIndex = 1
        txtNama.Text = "Nama"
        ' 
        ' txtJam
        ' 
        txtJam.Location = New Point(123, 72)
        txtJam.Name = "txtJam"
        txtJam.Size = New Size(261, 27)
        txtJam.TabIndex = 2
        txtJam.Text = "Jam"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(123, 139)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(261, 27)
        dtpTanggal.TabIndex = 3
        ' 
        ' cmbLayanan
        ' 
        cmbLayanan.FormattingEnabled = True
        cmbLayanan.Location = New Point(123, 105)
        cmbLayanan.Name = "cmbLayanan"
        cmbLayanan.Size = New Size(261, 28)
        cmbLayanan.TabIndex = 4
        cmbLayanan.Text = "Layanan"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(35, 195)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(135, 195)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(235, 195)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(335, 195)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvBooking
        ' 
        dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooking.Location = New Point(448, 40)
        dgvBooking.Name = "dgvBooking"
        dgvBooking.RowHeadersWidth = 51
        dgvBooking.Size = New Size(257, 184)
        dgvBooking.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 11
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 20)
        Label3.TabIndex = 12
        Label3.Text = "Jam"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 13
        Label1.Text = "Layanan"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(4, 7)
        txtID.Name = "txtID"
        txtID.Size = New Size(35, 27)
        txtID.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(724, 251)
        Controls.Add(txtID)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dgvBooking)
        Controls.Add(btnClear)
        Controls.Add(btnHapus)
        Controls.Add(btnUpdate)
        Controls.Add(btnTambah)
        Controls.Add(cmbLayanan)
        Controls.Add(dtpTanggal)
        Controls.Add(txtJam)
        Controls.Add(txtNama)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBooking, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtJam As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents cmbLayanan As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvBooking As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox



End Class
