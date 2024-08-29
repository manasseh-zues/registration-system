Imports DBLC_OBSI
Imports MySql.Data.MySqlClient
Public Class mysql_connect

    Private Sub ResetPrimaryKey()
        Dim connectionString As String = "datasource=localhost;port=3306;username=root;password=;database=dblc_obsi"
        Dim tableName As String = "registration"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Get the maximum value of the primary key column
            Dim maxValue As Integer
            Dim getMaxValueQuery As String = String.Format("SELECT MAX(id) FROM {0}", tableName)
            Using getMaxValueCommand As New MySqlCommand(getMaxValueQuery, connection)
                maxValue = CInt(getMaxValueCommand.ExecuteScalar())
            End Using

            ' Reset the auto increment value of the primary key column
            Dim resetAutoIncrementQuery As String = String.Format("ALTER TABLE {0} AUTO_INCREMENT = {1}", tableName, maxValue + 1)
            Using resetAutoIncrementCommand As New MySqlCommand(resetAutoIncrementQuery, connection)
                resetAutoIncrementCommand.ExecuteNonQuery()
            End Using
        End Using
    End Sub




    ' first we need to download the mysql connector & add it to our project
    ' https://dev.mysql.com/downloads/connector/net/8.0.html
    ' open xampp
    ' create the mysql database using phpmyadmin
    ' create the database and name it "vbnet_users_db"
    ' create a table and name it "users"
    ' create the connection

    Private connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=dblc_obsi")

    ' return the connection
    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property

    Public Property ConnectionString As String

    ' open the connection
    Sub openConnection()

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

    End Sub

    ' close the connection
    Sub closeConnection()

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Sub
End Class
