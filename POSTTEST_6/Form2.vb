Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Enabled = False
        TampilData()
        Kosong()
    End Sub
    Sub Kosong()
        txtID.Clear()
        txtNamaLayanan.Clear()
        txtHarga.Clear()
    End Sub
    Sub TampilData()
        Try
            Using conn = GetConn()
                Dim query As String = "SELECT * FROM layanan"

                Using da As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgvLayanan.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal tampil data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            Using conn = GetConn()
                conn.Open()

                Dim query As String = "INSERT INTO layanan (nama_layanan, harga) 
                                      VALUES (@nama,@harga)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", txtNamaLayanan.Text)
                    cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data berhasil ditambahkan")
            TampilData()
            Kosong()

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

                Dim query As String = "UPDATE layanan 
                                      SET nama_layanan=@nama, harga=@harga 
                                      WHERE id_layanan=@id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", txtID.Text)
                    cmd.Parameters.AddWithValue("@nama", txtNamaLayanan.Text)
                    cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data berhasil diupdate")
            TampilData()
            Kosong()

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

                    Dim cmd As New MySqlCommand("DELETE FROM layanan WHERE id_layanan=@id", conn)
                    cmd.Parameters.AddWithValue("@id", txtID.Text)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Data berhasil dihapus")
                TampilData()
                Kosong()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub dgvLayanan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLayanan.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvLayanan.Rows(e.RowIndex)

            txtID.Text = row.Cells("id_layanan").Value.ToString()
            txtNamaLayanan.Text = row.Cells("nama_layanan").Value.ToString()
            txtHarga.Text = row.Cells("harga").Value.ToString()
        End If
    End Sub
    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class