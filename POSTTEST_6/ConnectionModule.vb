Imports MySql.Data.MySqlClient

Module ConnectionModule
    Public ConnString As String = "server=localhost;user id=root;password=;database=db_barbershop"

    Public Function GetConn() As MySqlConnection
        Return New MySqlConnection(ConnString)
    End Function
End Module