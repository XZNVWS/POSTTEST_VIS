<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtID = New TextBox()
        txtNamaLayanan = New TextBox()
        txtHarga = New TextBox()
        dgvLayanan = New DataGridView()
        btnTambah = New Button()
        btnUpdate = New Button()
        btnHapus = New Button()
        CType(dgvLayanan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(43, 50)
        txtID.Name = "txtID"
        txtID.Size = New Size(125, 27)
        txtID.TabIndex = 0
        ' 
        ' txtNamaLayanan
        ' 
        txtNamaLayanan.Location = New Point(43, 91)
        txtNamaLayanan.Name = "txtNamaLayanan"
        txtNamaLayanan.Size = New Size(125, 27)
        txtNamaLayanan.TabIndex = 1
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(43, 134)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(125, 27)
        txtHarga.TabIndex = 2
        ' 
        ' dgvLayanan
        ' 
        dgvLayanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLayanan.Location = New Point(198, 50)
        dgvLayanan.Name = "dgvLayanan"
        dgvLayanan.RowHeadersWidth = 51
        dgvLayanan.Size = New Size(300, 188)
        dgvLayanan.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(198, 265)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(298, 265)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 5
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(398, 265)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(533, 321)
        Controls.Add(btnHapus)
        Controls.Add(btnUpdate)
        Controls.Add(btnTambah)
        Controls.Add(dgvLayanan)
        Controls.Add(txtHarga)
        Controls.Add(txtNamaLayanan)
        Controls.Add(txtID)
        Name = "Form2"
        Text = "Form2"
        CType(dgvLayanan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNamaLayanan As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents dgvLayanan As DataGridView
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
End Class
