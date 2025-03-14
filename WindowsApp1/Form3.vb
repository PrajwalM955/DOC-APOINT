Imports System.Data.SqlClient

Public Class Form3
    Dim connectionString As String = "Data Source=LAPTOP-JRNIQUNP\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    Private Sub Load_RegTab_Data()
        ' This method is empty; consider removing it if not needed
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        Form2.Show()
    End Sub

    ' Code for back Buttons in tabcontrol
    Private Sub Btnptnback_Click(sender As Object, e As EventArgs) Handles Btnptnback.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Btntrtback_Click(sender As Object, e As EventArgs) Handles Btntrtback.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Btndocback.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    ' Code for submit button in doctor tab page
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnregdoc.Click
        If String.IsNullOrWhiteSpace(Txtboxdocname.Text) OrElse
           String.IsNullOrWhiteSpace(Txtboxdocspeci.Text) OrElse
           String.IsNullOrWhiteSpace(Txtbox_phoneno.Text) OrElse
           Clstbox.CheckedItems.Count = 0 OrElse
           Cboboxhour.SelectedIndex = -1 Then

            MessageBox.Show("Please fill all the fields and select Week and Hour Availability")
            Return
        Else
            Using con As New SqlConnection(connectionString)
                Try
                    con.Open()
                    Dim cmd As New SqlCommand()
                    cmd.Connection = con

                    Dim weekAvailability As String = String.Join(",", Clstbox.CheckedItems.Cast(Of String)())

                    cmd.CommandText = "INSERT INTO doctor(name, specialization, contact, week_availability, hour_availability) VALUES (@name, @specialization, @contact, @week_availability, @hour_availability)"
                    cmd.Parameters.AddWithValue("@name", Txtboxdocname.Text)
                    cmd.Parameters.AddWithValue("@specialization", Txtboxdocspeci.Text)
                    cmd.Parameters.AddWithValue("@contact", Txtbox_phoneno.Text)
                    cmd.Parameters.AddWithValue("@week_availability", weekAvailability)
                    cmd.Parameters.AddWithValue("@hour_availability", Cboboxhour.SelectedItem.ToString())

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Doctor registered successfully!")
                        DgvdocLoad() ' Reload DataGridView after insertion
                    Else
                        MessageBox.Show("Failed to register doctor.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    ' Code for loading the datagridview in doctor tab page
    Private Sub DgvdocLoad()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = con

                cmd.CommandText = "SELECT * FROM doctor"
                Dim dr1 As SqlDataReader = cmd.ExecuteReader
                Dim datatable As New DataTable()
                datatable.Load(dr1)
                Dgvdoc.DataSource = datatable
                dr1.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvdocLoad()
        DgvtreatmentLoad()
    End Sub

    ' Code for clear function in doctor tab page
    Private Sub Btnclrdoc_Click(sender As Object, e As EventArgs) Handles Btnclrdoc.Click
        Txtboxdocname.Clear()
        Txtboxdocspeci.Clear()
        Txtbox_phoneno.Clear()

        ' Uncheck all items in Clstbox
        For i As Integer = Clstbox.Items.Count - 1 To 0 Step -1
            Clstbox.SetItemChecked(i, False)
        Next

        Cboboxhour.SelectedIndex = -1
    End Sub


    ' Code for clear function in patient tab page
    Private Sub Btnptnclr_Click(sender As Object, e As EventArgs) Handles Btnptnclr.Click
        Txtbxptnname.Clear()
        Cmbbxptngnder.SelectedIndex = -1
        Txtbxptnadrs.Clear()
        TxtBxptncontact.Clear()
        Txtbxptnmedhstry.Clear()
        Datepatientdob.Value = Date.Now ' Resetting the DateTimePicker
    End Sub

    ' Code for Patient tab page Submit Button
    Private Sub Btnptnregister_Click(sender As Object, e As EventArgs) Handles Btnptnregister.Click
        If String.IsNullOrWhiteSpace(Txtbxptnname.Text) OrElse
           String.IsNullOrWhiteSpace(Cmbbxptngnder.Text) OrElse
           Cmbbxptngnder.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(Txtbxptnadrs.Text) Then

            MessageBox.Show("Please enter all the values!")
            Return
        End If

        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = con

                cmd.CommandText = "INSERT INTO patient(name, dob, gender, contact, address, medical_history) VALUES (@name, @dob, @gender, @contact, @address, @medical_history)"
                cmd.Parameters.AddWithValue("@name", Txtbxptnname.Text)
                cmd.Parameters.AddWithValue("@dob", Datepatientdob.Value)
                cmd.Parameters.AddWithValue("@gender", Cmbbxptngnder.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@contact", TxtBxptncontact.Text)
                cmd.Parameters.AddWithValue("@address", Txtbxptnadrs.Text)
                cmd.Parameters.AddWithValue("@medical_history", Txtbxptnmedhstry.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Details Recorded!")
                DgvptntabLoad() ' Reload DataGridView after insertion
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub



    ' Function to load data into DataGridView for the patient table
    Private Sub DgvptntabLoad()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = con

                cmd.CommandText = "SELECT * FROM patient"
                Dim dr1 As SqlDataReader = cmd.ExecuteReader

                Dim datatable As New DataTable()
                datatable.Load(dr1)
                Dgvptntab.DataSource = datatable
                dr1.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Code for clear function in treatment tab page
    Private Sub Btntrtclr_Click(sender As Object, e As EventArgs) Handles Btntrtclr.Click
        Txtbxtrtname.Clear()
        Txtbxtrtcost.Clear()
    End Sub

    ' Code for register treatment button
    Private Sub Btntrtreg_Click(sender As Object, e As EventArgs) Handles Btntrtreg.Click
        Dim cost As Decimal

        ' Validate fields
        If String.IsNullOrWhiteSpace(Txtbxtrtname.Text) OrElse
           String.IsNullOrWhiteSpace(Txtbxtrtcost.Text) OrElse
           Not Decimal.TryParse(Txtbxtrtcost.Text, cost) OrElse cost <= 0 Then

            MessageBox.Show("Please enter a valid Treatment Name and a numeric Treatment Cost greater than 0.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If String.IsNullOrWhiteSpace(Txtbxtrtname.Text) Then Txtbxtrtname.Focus() Else Txtbxtrtcost.Focus()
            Exit Sub
        End If

        ' Insert treatment into database
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = con

                cmd.CommandText = "INSERT INTO treatment(name, cost) VALUES (@name, @cost)"
                cmd.Parameters.AddWithValue("@name", Txtbxtrtname.Text)
                cmd.Parameters.AddWithValue("@cost", cost)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Treatment added successfully!")
                DgvtreatmentLoad() ' Reload DataGridView after insertion
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Function to load data into DataGridView for the treatment table
    Private Sub DgvtreatmentLoad()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Using cmd As New SqlCommand("SELECT name, cost FROM treatment", con)
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(dr)
                        Dgvtreatment.DataSource = dt ' Assigning data to DataGridView
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

