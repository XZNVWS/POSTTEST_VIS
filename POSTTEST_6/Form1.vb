Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Enabled = False
        LoadLayanan()
        TampilData()
        ClearForm()
    End Sub
    Sub LoadLayanan()
        Try
            Using conn = GetConn()
                Dim query As String = "SELECT * FROM layanan"

                Using da As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    cmbLayanan.DataSource = dt
                    cmbLayanan.DisplayMember = "nama_layanan"
                    cmbLayanan.ValueMember = "id_layanan"
                    cmbLayanan.SelectedIndex = -1
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal load layanan: " & ex.Message)
        End Try
    End Sub
    Sub TampilData()
        Try
            Using conn = GetConn()

                Dim query As String = "
                    SELECT booking.id, booking.nama, booking.tanggal, booking.jam,
                           layanan.nama_layanan
                    FROM booking
                    LEFT JOIN layanan ON booking.id_layanan = layanan.id_layanan
                "

                Using da As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgvBooking.DataSource = dt
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal tampil data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtNama.Text = "" Or txtJam.Text = "" Or cmbLayanan.SelectedIndex = -1 Then
            MessageBox.Show("Semua field harus diisi!")
            Exit Sub
        End If

        Try
            Using conn = GetConn()
                conn.Open()

                Dim query As String = "
                    INSERT INTO booking (nama, tanggal, jam, id_layanan)
                    VALUES (@nama,@tanggal,@jam,@layanan)
                "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                    cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value)
                    cmd.Parameters.AddWithValue("@jam", txtJam.Text)
                    cmd.Parameters.AddWithValue("@layanan", cmbLayanan.SelectedValue)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data berhasil ditambahkan")
            TampilData()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtID.Text = "" Then
            MessageBox.Show("Pilih data terlebih dahulu")
            Exit Sub
        End If

        Try
            Using conn = GetConn()
                conn.Open()

                Dim query As String = "
                    UPDATE booking 
                    SET nama=@nama, tanggal=@tanggal, jam=@jam, id_layanan=@layanan
                    WHERE id=@id
                "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", txtID.Text)
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                    cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value)
                    cmd.Parameters.AddWithValue("@jam", txtJam.Text)
                    cmd.Parameters.AddWithValue("@layanan", cmbLayanan.SelectedValue)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data berhasil diupdate")
            TampilData()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtID.Text = "" Then
            MessageBox.Show("Pilih data terlebih dahulu")
            Exit Sub
        End If

        Dim confirm = MessageBox.Show("Yakin ingin hapus?", "Konfirmasi", MessageBoxButtons.YesNo)

        If confirm = DialogResult.Yes Then
            Try
                Using conn = GetConn()
                    conn.Open()

                    Dim cmd As New MySqlCommand("DELETE FROM booking WHERE id=@id", conn)
                    cmd.Parameters.AddWithValue("@id", txtID.Text)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Data berhasil dihapus")
                TampilData()
                ClearForm()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub dgvBooking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooking.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvBooking.Rows(e.RowIndex)

        txtID.Text = If(IsDBNull(row.Cells("id").Value), "", row.Cells("id").Value.ToString())

        txtNama.Text = If(IsDBNull(row.Cells("nama").Value), "", row.Cells("nama").Value.ToString())

        Dim valTanggal = row.Cells("tanggal").Value
        If valTanggal IsNot Nothing AndAlso Not IsDBNull(valTanggal) Then
            dtpTanggal.Value = Convert.ToDateTime(valTanggal)
        Else
            dtpTanggal.Value = DateTime.Now
        End If

        txtJam.Text = If(IsDBNull(row.Cells("jam").Value), "", row.Cells("jam").Value.ToString())

        cmbLayanan.Text = If(IsDBNull(row.Cells("nama_layanan").Value), "", row.Cells("nama_layanan").Value.ToString())
    End Sub

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