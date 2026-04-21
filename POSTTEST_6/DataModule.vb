Imports MySql.Data.MySqlClient

Module DataModule

    Public Function GetBooking() As DataTable
        Dim dt As New DataTable
        Try
            Dim query As String = "
                SELECT booking.id, booking.nama, booking.tanggal, booking.jam,
                       layanan.nama_layanan
                FROM booking
                INNER JOIN layanan ON booking.id_layanan = layanan.id_layanan
            "

            Using conn = GetConn()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dt
    End Function

    Public Function GetLayanan() As DataTable
        Dim dt As New DataTable
        Using conn = GetConn()
            Using da As New MySqlDataAdapter("SELECT * FROM layanan", conn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

End Module