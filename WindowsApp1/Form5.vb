Imports System.Data.SqlClient

Public Class Treatment_Assign_Form
    Private ReadOnly ConnectionString As String = "Data Source=LAPTOP-JRNIQUNP\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    ' Form Load: Load ComboBoxes
    Private Sub Treatment_Assign_Form_Load(Sender As Object, E As EventArgs) Handles Me.Load
        LoadDoctorID()
        LoadPatientID()
        LoadTreatmentID()
    End Sub

    ' Helper Function: Load data into ComboBoxes

    'Function to Load Patient_ID in ComboBox in Treatment Assignment 
    Private Sub LoadPatientID()
        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Selecting Registration Numbers from Registration Table
                cmd.CommandText = "select patient_id from patient"

                'Displaying Registration Numbers in ComboBox
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()
                CmbPatientID.Items.Clear()
                While datareader1.Read()
                    CmbPatientID.Items.Add(datareader1("patient_id").ToString())
                End While
                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    'Function to Load Doctor ID in  ComboBox in Treatment Assignment
    Private Sub LoadDoctorID()

        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Selecting Doctor ID from Doctor Table
                cmd.CommandText = "select doctor_id from doctor"


                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()
                CmbDoctorID.Items.Clear()
                While datareader1.Read()
                    CmbDoctorID.Items.Add(datareader1("doctor_id").ToString())
                End While
                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using

    End Sub

    'Function to Load Treatment ID in ComboBox 
    Private Sub LoadTreatmentID()

        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Selecting Service IDs from Services Table
                cmd.CommandText = "select treatment_id from treatment"

                'Displaying Service IDs in ComboBox
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()
                CmbTreatmentID.Items.Clear()
                While datareader1.Read()
                    CmbTreatmentID.Items.Add(datareader1("treatment_id").ToString())
                End While
                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using

    End Sub

    'loading datagridview
    Private Sub Loadtreatmentassigntab()
        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Selecting all details from Service Assignments Table
                cmd.CommandText = "select * from Treatmentassign"
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()

                'Displaying details in DataGridView
                Dim datatable1 As New DataTable()
                datatable1.Load(datareader1)
                DgvAssignments.DataSource = datatable1
                datareader1.Close()
                Loadtreatmentassigntab()
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    ' Button Click: Calculate Treatment Cost
    Private Sub BtnCalculatetrtcost_Click(sender As Object, e As EventArgs) Handles BtnCalculatetrtcost.Click
        If CmbTreatmentID.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Treatment ID for cost calculation.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Using conn As New SqlConnection(ConnectionString)
                Try

                    conn.Open()
                    Dim cmd As New SqlCommand()
                    cmd.Connection = conn

                    'Selecting Treatment Cost from Treatment Table
                    cmd.CommandText = "select cost from treatment where treatment_id=" + CmbTreatmentID.Text

                    'Displaying Treatment Cost in TextBox
                    Dim datareader1 As SqlDataReader = cmd.ExecuteReader()
                    TxtTreatmentCost.Clear()
                    While datareader1.Read()
                        TxtTreatmentCost.Text = datareader1("cost").ToString()
                    End While
                    datareader1.Close()

                Catch ex As Exception
                    MessageBox.Show("Error:" & ex.Message)
                End Try
            End Using
        End If
    End Sub
    ' Button Click: Submit Treatment Assignment
    Private Sub BtnSubmit_Click(Sender As Object, E As EventArgs) Handles BtnSubmit.Click
        ' Validate input
        If CmbPatientID.SelectedIndex = -1 OrElse CmbDoctorID.SelectedIndex = -1 OrElse CmbTreatmentID.SelectedIndex = -1 OrElse String.IsNullOrEmpty(TxtTreatmentCost.Text) OrElse String.IsNullOrEmpty(Cmbstatus.Text) Then
            MessageBox.Show("Please fill all the Mandatory Details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            ' Insert data into treatmentassign table
            Using conn As New SqlConnection(ConnectionString)
                Try
                    conn.Open()
                    Dim cmd As New SqlCommand()
                    cmd.Connection = conn

                    cmd.CommandText = "INSERT INTO treatmentassign (patient_id, doctor_id, treatment_date, treatment_id, status, treatment_cost)
                                  VALUES (@patient_id, @doctor_id, @treatment_date, @treatment_id, @status, @treatment_cost)"

                    ' Use .Text instead of .SelectedValue to get selected values from ComboBoxes
                    cmd.Parameters.AddWithValue("@patient_id", CmbPatientID.Text.Trim())
                    cmd.Parameters.AddWithValue("@doctor_id", CmbDoctorID.Text.Trim())
                    cmd.Parameters.AddWithValue("@treatment_date", DtpTreatmentDate.Value.Date)
                    cmd.Parameters.AddWithValue("@treatment_id", CmbTreatmentID.Text.Trim())
                    cmd.Parameters.AddWithValue("@status", Cmbstatus.Text.Trim())
                    cmd.Parameters.AddWithValue("@treatment_cost", Convert.ToDecimal(TxtTreatmentCost.Text))

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Rows inserted: " & rowsAffected)

                Catch ex As Exception
                    MessageBox.Show("Error:" & ex.Message)
                End Try
            End Using
        End If

        ClearForm() ' Clear form after submission
    End Sub



    ' Helper Function: Load assigned treatments into DataGridView
    Private Sub LoadTreatmentAssign()
        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Selecting all details from treatment Assign Table
                cmd.CommandText = "select * from treatmentassign"
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()

                'Displaying details in DataGridView
                Dim datatable1 As New DataTable()
                datatable1.Load(datareader1)
                DgvAssignments.DataSource = datatable1
                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub DgvAssignments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAssignments.CellClick
        CmbPatientID.Text = DgvAssignments.SelectedRows(0).Cells(1).Value
        CmbDoctorID.Text = DgvAssignments.SelectedRows(0).Cells(2).Value
        DtpTreatmentDate.Value = DgvAssignments.SelectedRows(0).Cells(3).Value
        Cmbstatus.Text = DgvAssignments.SelectedRows(0).Cells(4).Value
        CmbTreatmentID.Text = DgvAssignments.SelectedRows(0).Cells(5).Value
    End Sub

    ' Button Click: View Treatment Assignments
    Private Sub BtnView_Click(Sender As Object, E As EventArgs) Handles BtnView.Click
        LoadTreatmentAssign() ' Load data into DataGridView
    End Sub
    ' Button Click: Edit Treatment Assignment
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        ' Validate selection
        If DgvAssignments.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to edit!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate input
        If CmbPatientID.Text = "" OrElse CmbDoctorID.Text = "" OrElse CmbTreatmentID.Text = "" OrElse String.IsNullOrEmpty(TxtTreatmentCost.Text) OrElse String.IsNullOrEmpty(Cmbstatus.Text) Then
            MessageBox.Show("Please enter valid Assignment Details!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm edit
        If MessageBox.Show("Are you sure you want to edit selected row?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        ' Update data in treatmentassign table
        Using connection As New SqlConnection(ConnectionString), command As New SqlCommand("UPDATE treatmentassign SET patient_id = @patient_id, doctor_id = @doctor_id, treatment_date = @treatment_date, treatment_id = @treatment_id, status = @status, treatment_cost = @treatment_cost " &
                                      "WHERE treatmentassign_id = @treatmentassign_id", connection)
            With command.Parameters
                .AddWithValue("@treatmentassign_id", DgvAssignments.SelectedRows(0).Cells("treatmentassign_id").Value)
                .AddWithValue("@patient_id", CmbPatientID.SelectedValue)
                .AddWithValue("@doctor_id", CmbDoctorID.SelectedValue)
                .AddWithValue("@treatment_date", DtpTreatmentDate.Value)
                .AddWithValue("@treatment_id", CmbTreatmentID.SelectedValue)
                .AddWithValue("@status", Cmbstatus.Text)
                .AddWithValue("@treatment_cost", TxtTreatmentCost.Text)
            End With
            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                MessageBox.Show($"Rows updated: {rowsAffected}", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadTreatmentAssign() ' Refresh DataGridView
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Show error message
            End Try
        End Using
    End Sub

    ' Button Click: Delete Treatment Assignment
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ' Validate selection
        If dgvAssignments.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm deletion
        If MessageBox.Show("Are you sure you want to delete selected row?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        ' Delete data from treatmentassign table
        Using connection As New SqlConnection(ConnectionString), command As New SqlCommand("DELETE FROM treatmentassign WHERE treatmentassign_id = @treatmentassign_id", connection)
            command.Parameters.AddWithValue("@treatmentassign_id", dgvAssignments.SelectedRows(0).Cells("treatmentassign_id").Value)
            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                MessageBox.Show($"Rows deleted: {rowsAffected}", "Deletion Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadTreatmentAssign() ' Refresh DataGridView
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Show error message
            End Try
        End Using
    End Sub

    ' Button Click: Clear Form
    Private Sub BtnClear_Click(Sender As Object, E As EventArgs) Handles BtnClear.Click
        ClearForm() ' Clear all input controls
    End Sub

    ' Helper Function: Clear the form
    Private Sub ClearForm()
        With Me
            .CmbPatientID.SelectedIndex = -1
            .CmbDoctorID.SelectedIndex = -1
            .CmbTreatmentID.SelectedIndex = -1
            .TxtTreatmentCost.Clear()
            .DtpTreatmentDate.Value = Date.Now
            .Cmbstatus.SelectedIndex = -1
            .dgvAssignments.DataSource = Nothing ' Clear DataGridView
        End With
    End Sub

    Private Sub BtntrtassignBck_Click(sender As Object, e As EventArgs) Handles BtntrtassignBck.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class