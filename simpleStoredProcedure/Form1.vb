Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnFetchDetails_Click(sender As Object, e As EventArgs) Handles btnFetchDetails.Click

        Dim userId As Integer = Convert.ToInt32(txtUserID.Text)

        ' Connection string to connect to MySQL database
        Dim connectionString As String = "Server=localhost;Database=dbuser;User ID=root;Password=12Yellow34!"

        Using conn As New MySqlConnection(connectionString)

            conn.Open()

            ' Create a command object
            Dim cmd As New MySqlCommand("sp_GetUserDetails", conn)
            cmd.CommandType = CommandType.StoredProcedure

            ' Add parameters to the command object
            cmd.Parameters.AddWithValue("@uid", userId)

            ' Execute the command
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Read the data and display it in the textboxes
            If reader.Read() Then
                txtOutputUserID.Text = reader("userid").ToString()
                txtOutputTitle.Text = reader("title").ToString()
                txtOutputForename.Text = reader("forename").ToString()
                txtOutputSurname.Text = reader("surname").ToString()
            Else
                MessageBox.Show("User not found")
            End If
        End Using
    End Sub
End Class
