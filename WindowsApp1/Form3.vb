Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Dim connectionString As String = "Data Source=beast\sqlexpress;Initial Catalog=Clinic;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    Private Sub Form3_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPgDoctor.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPgpatient.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Check if Registration Number is Empty or Zero and all other details are entered
        If Txtboxregid.Text = "" Or Txtboxregid.Text = "0" Or Txtboxdocname.Text = "" Or Txtboxdocspeci.Text = "" Or Txtbox_phoneno.Text.Length < 10 Or Clstbox.SelectedItem = "" Or Cboboxhour.Text = "" Then
            MessageBox.Show("Please enter valid Doctor Details!")
            Return
        Else Using conn As New SqlConnection(connectionString)
                Try
                    conn.Open()
                    Dim cmd As New SqlCommand()
                    cmd.Connection = conn

                    'Inserting details into Registration Table
                    cmd.CommandText = "insert into Doctor_table([regid],[docname],[phoneno],[address],[email],[make],[model],[yearofmfd]) values (@regno, @custname, @phoneno, @address, @email, @make, @model, @yearofmfd)"
                    cmd.Parameters.AddWithValue("@regno", txtbox_regno.Text)
                    cmd.Parameters.AddWithValue("@custname", txtbox_custname.Text)
                    cmd.Parameters.AddWithValue("@phoneno", txtbox_phoneno.Text)
                    cmd.Parameters.AddWithValue("@address", txtbox_address.Text)
                    cmd.Parameters.AddWithValue("@email", txtbox_email.Text)
                    cmd.Parameters.AddWithValue("@make", txtbox_make.Text)
                    cmd.Parameters.AddWithValue("@model", txtbox_model.Text)
                    cmd.Parameters.AddWithValue("@yearofmfd", txtbox_yearofmfd.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Rows inserted: " & rowsAffected)

                    Load_RegTab_Data()
                    LoadServAssignRegNoComboBox()
                    LoadBillingRegNoComboBox()

                Catch ex As Exception
                    MessageBox.Show("Error:" & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class