Imports MySql.Data.MySqlClient

Public Class Form1

    ' Koneksi ke database
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=db_barbershop")

    ' =========================
    ' LOAD FORM
    ' =========================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbLayanan.Items.Add("Haircut")
        cmbLayanan.Items.Add("Shave")
        cmbLayanan.Items.Add("Haircut + Shave")

        txtID.Enabled = False ' ID dari database (auto increment)

        TampilData()
    End Sub

    ' =========================
    ' READ (TAMPIL DATA)
    ' =========================
    Sub TampilData()
        Try
            conn.Open()
            Dim da As New MySqlDataAdapter("SELECT * FROM booking", conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvBooking.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' CREATE (TAMBAH DATA)
    ' =========================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("INSERT INTO booking (nama, tanggal, jam, layanan) VALUES (@nama,@tanggal,@jam,@layanan)", conn)

            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value)
            cmd.Parameters.AddWithValue("@jam", txtJam.Text)
            cmd.Parameters.AddWithValue("@layanan", cmbLayanan.Text)

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data berhasil ditambahkan")

            TampilData()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' UPDATE
    ' =========================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE booking SET nama=@nama, tanggal=@tanggal, jam=@jam, layanan=@layanan WHERE id=@id", conn)

            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value)
            cmd.Parameters.AddWithValue("@jam", txtJam.Text)
            cmd.Parameters.AddWithValue("@layanan", cmbLayanan.Text)

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data berhasil diupdate")

            TampilData()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' DELETE
    ' =========================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("DELETE FROM booking WHERE id=@id", conn)
            cmd.Parameters.AddWithValue("@id", txtID.Text)

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data berhasil dihapus")

            TampilData()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' KLIK DATAGRIDVIEW
    ' =========================
    Private Sub dgvBooking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooking.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvBooking.Rows(e.RowIndex)

            txtID.Text = row.Cells("id").Value.ToString()
            txtNama.Text = row.Cells("nama").Value.ToString()
            dtpTanggal.Value = Convert.ToDateTime(row.Cells("tanggal").Value)
            txtJam.Text = row.Cells("jam").Value.ToString()
            cmbLayanan.Text = row.Cells("layanan").Value.ToString()
        End If
    End Sub

    ' =========================
    ' CLEAR FORM
    ' =========================
    Sub ClearForm()
        txtID.Clear()
        txtNama.Clear()
        txtJam.Clear()
        cmbLayanan.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

End Class