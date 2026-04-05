Imports System.IO

Public Class FormUtama
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtbNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbNoHP.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Function ValidasiInput() As Boolean
        Dim valid As Boolean = True
        ErrorProvider1.Clear()
        Dim errMsg As String = "Inputan tidak boleh kosong"

        If txtNama.Text.Trim() = "" Then ErrorProvider1.SetError(txtNama, errMsg) : valid = False
        If txtID.Text.Trim() = "" Then ErrorProvider1.SetError(txtID, errMsg) : valid = False
        If cmbDivisi.Text.Trim() = "" Then ErrorProvider1.SetError(cmbDivisi, errMsg) : valid = False
        If txtEmail.Text.Trim() = "" Then ErrorProvider1.SetError(txtEmail, errMsg) : valid = False
        If txtAlamat.Text.Trim() = "" Then ErrorProvider1.SetError(txtAlamat, errMsg) : valid = False

        If Not mtbNoHP.MaskCompleted Then
            ErrorProvider1.SetError(mtbNoHP, errMsg)
            valid = False
        End If

        If picFoto.Image Is Nothing Then
            ErrorProvider1.SetError(btnBrowse, errMsg)
            valid = False
        End If

        Dim cekHobi As Boolean = chk1.Checked Or chk2.Checked Or chk3.Checked Or chk4.Checked Or chk5.Checked Or chk6.Checked Or chk7.Checked Or chk8.Checked
        If Not cekHobi Then
            ErrorProvider1.SetError(gbHobi, errMsg)
            valid = False
        End If

        Return valid
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        OpenFileDialog1.Title = "Pilih Foto Profil"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If Not ValidasiInput() Then
            MessageBox.Show("Ada data yang kosong, harap periksa tanda merah dari ErrorProvider!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hasil As DialogResult = MessageBox.Show("Cetak kartu komunitas sekarang?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            FormKartu.lblHasilNama.Text = txtNama.Text
            FormKartu.lblHasilID.Text = "ID: " & txtID.Text
            FormKartu.lblHasilKomunitas.Text = "Divisi: " & cmbDivisi.Text
            FormKartu.lblHasilKontak.Text = mtbNoHP.Text & " | " & txtEmail.Text
            FormKartu.picHasilFoto.Image = picFoto.Image

            Dim hobiAktif As String = ""
            If chk1.Checked Then hobiAktif &= chk1.Text & ", "
            If chk2.Checked Then hobiAktif &= chk2.Text & ", "
            If chk3.Checked Then hobiAktif &= chk3.Text & ", "
            If chk4.Checked Then hobiAktif &= chk4.Text & ", "
            If chk5.Checked Then hobiAktif &= chk5.Text & ", "
            If chk6.Checked Then hobiAktif &= chk6.Text & ", "
            If chk7.Checked Then hobiAktif &= chk7.Text & ", "
            If chk8.Checked Then hobiAktif &= chk8.Text & ", "
            FormKartu.lblHasilHobi.Text = "Aktivitas: " & hobiAktif.TrimEnd(","c, " "c)

            FormKartu.Show()
        End If
    End Sub
    Private Sub menuInputData_Click(sender As Object, e As EventArgs) Handles menuInput.Click
        TabControl1.SelectedTab = TabControl1.TabPages(0)
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuLihat.Click
        FormKartu.Show()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuSimpan.Click
        If ValidasiInput() Then
            SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
            SaveFileDialog1.Title = "Simpan Data Komunitas"
            Dim konfirmasi As DialogResult = MessageBox.Show("Simpan data ke dalam file?", "Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If konfirmasi = DialogResult.Yes AndAlso SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim dataExport As String = "NAMA: " & txtNama.Text & vbCrLf & "ID: " & txtID.Text & vbCrLf & "DIVISI: " & cmbDivisi.Text
                IO.File.WriteAllText(SaveFileDialog1.FileName, dataExport)
                MessageBox.Show("File berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Mohon isi semua data sebelum menyimpan file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub menuBukaData_Click(sender As Object, e As EventArgs) Handles menuBuka.Click
        OpenFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim textData As String = IO.File.ReadAllText(OpenFileDialog1.FileName)
            MessageBox.Show("Isi File Terbaca:" & vbCrLf & textData, "Buka Data")
        End If
    End Sub

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        Dim hasil As DialogResult = MessageBox.Show("Yakin ingin keluar aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class