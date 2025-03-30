Imports System.Data.SqlClient

Public Class Form4
    Dim connectionString As String = "Data Source=DESKTOP-B9GRHRB\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True;TrustServerCertificate=True"

    ' Method to handle form load
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDoctorNames()
        LoadPatientNames()
        LoadAppointmentData() ' Load appointment data into DataGridView
    End Sub

    ' Method to load Doctor Names into the Doctor combobox
    Private Sub LoadDoctorNames()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand("SELECT doctor_id, name FROM doctor", con)
                Dim dr As SqlDataReader = cmd.ExecuteReader()

                Dim dt As New DataTable()
                dt.Load(dr)

                Cmbxapoitdocid.DataSource = dt
                Cmbxapoitdocid.DisplayMember = "name"  ' Display Doctor Name in combobox
                Cmbxapoitdocid.ValueMember = "doctor_id"  ' Store Doctor IDs as values
                Cmbxapoitdocid.SelectedIndex = -1          ' Reset selection
            Catch ex As Exception
                MessageBox.Show("Error loading doctor names: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to load Patient Names into the Patient combobox
    Private Sub LoadPatientNames()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand("SELECT patient_id, name FROM patient", con)
                Dim dr As SqlDataReader = cmd.ExecuteReader()

                Dim dt As New DataTable()
                dt.Load(dr)

                Cmbxapointptnid.DataSource = dt
                Cmbxapointptnid.DisplayMember = "name"  ' Display Patient Name in combobox
                Cmbxapointptnid.ValueMember = "patient_id"         ' Store Patient IDs as values
                Cmbxapointptnid.SelectedIndex = -1           ' Reset selection
            Catch ex As Exception
                MessageBox.Show("Error loading patient names: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to clear all fields in the Appointment Form
    Private Sub Btnapointclr_Click(sender As Object, e As EventArgs) Handles Btnapointclr.Click
        Cmbxapointptnid.SelectedIndex = -1
        Cmbxapoitdocid.SelectedIndex = -1
        Dateapointdate.Value = Date.Now
        Cmbxapointtime.SelectedIndex = -1
        Cmbxapoitstatus.SelectedIndex = -1
        Cmbxapointreason.SelectedIndex = -1
    End Sub

    ' Method to insert appointment data into the database when Appoint button is clicked
    Private Sub Btnappoint_Click(sender As Object, e As EventArgs) Handles Btnappoint.Click
        ' Validate input fields before inserting data into database table.
        If Cmbxapointptnid.SelectedIndex = -1 OrElse
           Cmbxapoitdocid.SelectedIndex = -1 OrElse
           Cmbxapointtime.SelectedIndex = -1 OrElse
           Cmbxapoitstatus.SelectedIndex = -1 OrElse
           Cmbxapointreason.SelectedIndex = -1 Then

            MessageBox.Show("Please fill all fields before proceeding!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using con As New SqlConnection(connectionString)
            Try
                con.Open()

                Dim cmd As New SqlCommand("INSERT INTO appointment(patient_id, doctor_id, appointment_date, status, reason, [time]) " &
                                         "VALUES (@patient_id, @doctor_id, @appointment_date, @status, @reason, @time)", con)

                cmd.Parameters.AddWithValue("@patient_id", Convert.ToInt32(Cmbxapointptnid.SelectedValue))
                cmd.Parameters.AddWithValue("@doctor_id", Convert.ToInt32(Cmbxapoitdocid.SelectedValue))
                cmd.Parameters.AddWithValue("@appointment_date", Dateapointdate.Value)
                cmd.Parameters.AddWithValue("@status", Cmbxapoitstatus.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@reason", Cmbxapointreason.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@time", Cmbxapointtime.SelectedItem.ToString())

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadAppointmentData() ' Reload DataGridView after insertion
                Else
                    MessageBox.Show("Failed to add appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Method to load appointment data into DataGridView from the database table
    Private Sub LoadAppointmentData()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand("SELECT *, [time] FROM appointment", con)
                Dim dr As SqlDataReader = cmd.ExecuteReader()

                Dim dt As New DataTable()
                dt.Load(dr)

                Dgvappoint.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Method for View Button to refresh and reload appointment data into DataGridView manually.
    Private Sub Btnapointview_Click(sender As Object, e As EventArgs) Handles Btnapointview.Click
        LoadAppointmentData()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ' Check if a row is selected
        If Dgvappoint.SelectedRows.Count > 0 Then
            Dim selectedIndex As Integer = Dgvappoint.SelectedRows(0).Index
            Dim appointmentID As Integer = Convert.ToInt32(Dgvappoint.Rows(selectedIndex).Cells(0).Value)

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Using con As New SqlConnection(connectionString)
                    Try
                        con.Open()
                        Dim cmd As New SqlCommand("DELETE FROM appointment WHERE appointment_id = @appointment_id", con)
                        cmd.Parameters.AddWithValue("@appointment_id", appointmentID)
                        cmd.ExecuteNonQuery()
                        LoadAppointmentData() ' Reload DataGridView after deletion
                        MessageBox.Show("Appointment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error deleting appointment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Please select a row to delete!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnDelete_Click_1(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ' Check if a row is selected
        If Dgvappoint.SelectedRows.Count > 0 Then
            Dim selectedIndex As Integer = Dgvappoint.SelectedRows(0).Index
            Dim appointmentID As Integer = Convert.ToInt32(Dgvappoint.Rows(selectedIndex).Cells(0).Value)

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Using con As New SqlConnection(connectionString)
                    Try
                        con.Open()
                        Dim cmd As New SqlCommand("DELETE FROM appointment WHERE appointment_id = @appointment_id", con)
                        cmd.Parameters.AddWithValue("@appointment_id", appointmentID)
                        cmd.ExecuteNonQuery()
                        LoadAppointmentData() ' Reload DataGridView after deletion
                        MessageBox.Show("Appointment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error deleting appointment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Please select a row to delete!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Btnappntbck_Click(sender As Object, e As EventArgs) Handles Btnappntbck.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub BtnIssueTicket_Click(sender As Object, e As EventArgs) Handles BtnIssueTicket.Click
        Dim apointinvoiceForm As New Form9()
        apointinvoiceForm.Show() ' Show Invoice Form.
    End Sub
End Class