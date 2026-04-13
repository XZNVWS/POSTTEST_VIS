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
        txtID = New TextBox()
        txtNama = New TextBox()
        txtJam = New TextBox()
        dtpTanggal = New DateTimePicker()
        cmbLayanan = New ComboBox()
        btnTambah = New Button()
        btnUpdate = New Button()
        btnHapus = New Button()
        btnClear = New Button()
        dgvBooking = New DataGridView()
        CType(dgvBooking, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(35, 43)
        txtID.Name = "txtID"
        txtID.Size = New Size(467, 27)
        txtID.TabIndex = 0
        txtID.Text = "ID"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(35, 85)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(467, 27)
        txtNama.TabIndex = 1
        txtNama.Text = "Nama"
        ' 
        ' txtJam
        ' 
        txtJam.Location = New Point(35, 130)
        txtJam.Name = "txtJam"
        txtJam.Size = New Size(467, 27)
        txtJam.TabIndex = 2
        txtJam.Text = "Jam"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(35, 232)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(467, 27)
        dtpTanggal.TabIndex = 3
        ' 
        ' cmbLayanan
        ' 
        cmbLayanan.FormattingEnabled = True
        cmbLayanan.Location = New Point(35, 178)
        cmbLayanan.Name = "cmbLayanan"
        cmbLayanan.Size = New Size(467, 28)
        cmbLayanan.TabIndex = 4
        cmbLayanan.Text = "Layanan"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(35, 283)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(150, 283)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(281, 283)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(408, 283)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvBooking
        ' 
        dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooking.Location = New Point(531, 43)
        dgvBooking.Name = "dgvBooking"
        dgvBooking.RowHeadersWidth = 51
        dgvBooking.Size = New Size(257, 216)
        dgvBooking.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 344)
        Controls.Add(dgvBooking)
        Controls.Add(btnClear)
        Controls.Add(btnHapus)
        Controls.Add(btnUpdate)
        Controls.Add(btnTambah)
        Controls.Add(cmbLayanan)
        Controls.Add(dtpTanggal)
        Controls.Add(txtJam)
        Controls.Add(txtNama)
        Controls.Add(txtID)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBooking, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtJam As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents cmbLayanan As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvBooking As DataGridView

End Class
