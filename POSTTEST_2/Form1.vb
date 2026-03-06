Public Class Form1

    Function CariBuku(ByVal judul As String) As Integer

        For i As Integer = 0 To JumlahData - 1

            If DaftarBuku(i).Judul.ToLower() = judul.ToLower() Then
                Return i
            End If

        Next

        Return -1

    End Function


    Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        If JumlahData < DaftarBuku.Length Then

            DaftarBuku(JumlahData).Judul = judul
            DaftarBuku(JumlahData).Genre = genre

            JumlahData = JumlahData + 1

        End If

    End Sub


    Sub TampilkanData()

        ListBox1.Items.Clear()

        For i As Integer = 0 To JumlahData - 1

            ListBox1.Items.Add(DaftarBuku(i).Judul & " - " & DaftarBuku(i).Genre)

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox2.Text = "" Or TextBox1.Text = "" Then
            MsgBox("Judul dan Genre harus diisi")
            Exit Sub
        End If

        TambahBuku(TextBox2.Text, TextBox1.Text)

        TampilkanData()

        TextBox2.Clear()
        TextBox1.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim posisi As Integer

        posisi = CariBuku(TextBox3.Text)

        If posisi = -1 Then

            MsgBox("Buku tidak ditemukan")

        Else

            For i As Integer = posisi To JumlahData - 2
                DaftarBuku(i) = DaftarBuku(i + 1)
            Next

            JumlahData = JumlahData - 1

            MsgBox("Buku berhasil dihapus")

        End If

        TampilkanData()

        TextBox3.Clear()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class