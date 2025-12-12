Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=root; database=museum_db;"
        Try
            conn.Open()
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        Dim query As String = "INSERT INTO `museum_db`.`artifacts_tbl` (`artifact_name`, `country`, `year_found`, `condition`) VALUES (@artifact_name, @country, @year_found, @condition);"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@artifact_name", tbArtifactName.Text)
                    cmd.Parameters.AddWithValue("@country", tbCountry.Text)
                    cmd.Parameters.AddWithValue("@year_found", CInt(tbYearFound.Text))
                    cmd.Parameters.AddWithValue("@condition", cbCondition.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record insert successful!")
                    tbArtifactName.Clear()
                    tbCountry.Clear()
                    tbYearFound.Clear()
                    cbCondition.ResetText()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim query As String = "SELECT * FROM museum_db.artifacts_tbl WHERE is_deleted = 0;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                DataGridView1.Columns("id").Visible = False
                DataGridView1.Columns("is_deleted").Visible = False
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a row to update.")
        End If
        Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim Id As Integer = row.Cells("id").Value

        Dim query As String = "UPDATE artifacts_tbl SET artifact_name = @artifact_name, country = @country, year_found = @year_found, condition=@condition WHERE id = @id"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@artifact_name", tbArtifactName.Text)
                    cmd.Parameters.AddWithValue("@country", tbCountry.Text)
                    cmd.Parameters.AddWithValue("@year_found", CInt(tbYearFound.Text))
                    cmd.Parameters.AddWithValue("@condition", cbCondition.Text)
                    cmd.Parameters.AddWithValue("@id", Id)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim query As String = "UPDATE `museum_db`.`artifacts_tbl` SET `is_deleted` = 1 WHERE (`id` = @id);"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", CInt(tbHiddenID.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record deleted successfully!")
                    tbArtifactName.Clear()
                    tbCountry.Clear()
                    tbYearFound.Clear()
                    cbCondition.ResetText()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Environment.Exit(0)
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            tbArtifactName.Text = selectedRow.Cells("artifact_name").Value.ToString()
            tbCountry.Text = selectedRow.Cells("country").Value.ToString()
            tbYearFound.Text = selectedRow.Cells("year_found").Value.ToString()
            cbCondition.Text = selectedRow.Cells("condition").Value.ToString()
            tbHiddenID.Text = selectedRow.Cells("id").Value.ToString()
        End If
    End Sub

    Private Sub ButtonViewDeleted_Click(sender As Object, e As EventArgs) Handles ButtonViewDeleted.Click
        Dim query As String = "SELECT * FROM museum_db.artifacts_tbl WHERE is_deleted = 1;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                DataGridView1.Columns("id").Visible = False
                DataGridView1.Columns("is_deleted").Visible = False
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class