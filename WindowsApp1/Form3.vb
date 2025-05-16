Imports System.Data.SqlClient

Public Class Form3
    Dim connectionString As String = "Data Source=DESKTOP-B9GRHRB\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True;TrustServerCertificate=True"

    'close application code
    Private Sub Form3_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        Application.Exit()
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

            MessageBox.Show("Please fill all the fields")
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
        TxtBxdocid.Clear()
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
        TxtBxptnid.Clear()
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
        TxtBxtrtid.Clear()
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
                Using cmd As New SqlCommand("SELECT * FROM treatment", con)
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


    Private Sub Btn_docdel_Click(sender As Object, e As EventArgs) Handles Btn_docdel.Click
        'Check if any row is selected
        If Dgvdoc.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete!")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete selected row?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Deleting selected row from Doctor Table
                cmd.CommandText = "DELETE FROM doctor WHERE doctor_id = @doctor_id"
                cmd.Parameters.AddWithValue("@doctor_id", Dgvdoc.SelectedRows(0).Cells(0).Value)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show("Rows deleted: " & rowsAffected)

                '  Dgvdoc.PerformClick() ' Refresh DataGridView after deletion.

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadDoctorsData()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand("SELECT * FROM doctor", con)
                Dim dr As SqlDataReader = cmd.ExecuteReader()

                Dim dt As New DataTable()
                dt.Load(dr)

                Dgvdoc.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub BtnDeletePatient_Click(sender As Object, e As EventArgs) Handles BtnDeletePatient.Click
        'Check if any row is selected
        If Dgvptntab.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete!")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete selected row?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Deleting selected row from Billing Table
                cmd.CommandText = "DELETE FROM patient WHERE patient_id = @patient_id"
                cmd.Parameters.AddWithValue("@patient_id", Dgvptntab.SelectedRows(0).Cells(0).Value)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show("Rows deleted: " & rowsAffected)

                '  Dgvptntab.PerformClick() ' Refresh DataGridView after deletion.

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub LoadPatientsData()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand("SELECT * FROM patient", con)
                Dim dr As SqlDataReader = cmd.ExecuteReader()

                Dim dt As New DataTable()
                dt.Load(dr)

                Dgvptntab.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub BtnDeleteTreatment_Click(sender As Object, e As EventArgs) Handles BtnDeleteTreatment.Click
        'Check if any row is selected
        If Dgvtreatment.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete!")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete selected row?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Deleting selected row from Billing Table
                cmd.CommandText = "DELETE FROM treatment WHERE treatment_id=@treatment_id"
                cmd.Parameters.AddWithValue("@treatment_id", Dgvtreatment.SelectedRows(0).Cells(0).Value)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show("Rows deleted: " & rowsAffected)

                '  Dgvtreatment.PerformClick() ' Refresh DataGridView after deletion.

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub LoadTreatmentsData()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand("SELECT * FROM treatment", con)
                Dim dr As SqlDataReader = cmd.ExecuteReader()

                Dim dt As New DataTable()
                dt.Load(dr)

                Dgvtreatment.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Btndocview.Click
        LoadDoctorsData()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BtnPtnview.Click
        LoadPatientsData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnTrtview.Click
        LoadTreatmentsData()
    End Sub
    Private Sub Dgvtreatment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvtreatment.CellClick
        TxtBxtrtid.Text = Dgvtreatment.SelectedRows(0).Cells(0).Value
        Txtbxtrtname.Text = Dgvtreatment.SelectedRows(0).Cells(1).Value
        Txtbxtrtcost.Text = Dgvtreatment.SelectedRows(0).Cells(2).Value
    End Sub
    Private Sub Btntrtedit_Click(sender As Object, e As EventArgs) Handles Btntrtedit.Click

        'Check if any row is selected
        If Dgvtreatment.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to edit!")
            Return
        End If

        'Check if all Assignment details are entered
        If Txtbxtrtname.Text = "" Or Txtbxtrtcost.Text = "" Or TxtBxtrtid.Text = "" Then
            MessageBox.Show("Please enter valid Assignment Details!")
            Return
        End If


        If MessageBox.Show("Are you sure you want to edit selected row?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn
                'Updating selected row in Billing Table
                cmd.CommandText = "UPDATE treatment SET name = @name, cost = @cost WHERE treatment_id = @treatment_id"
                cmd.Parameters.AddWithValue("@treatment_id", TxtBxtrtid.Text)
                cmd.Parameters.AddWithValue("@name", Txtbxtrtname.Text)
                cmd.Parameters.AddWithValue("@cost", Txtbxtrtcost.Text)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show("Rows updated: " & rowsAffected)
                LoadTreatmentsData() ' Refresh DataGridView

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub Dgvptntab_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvptntab.CellClick
        TxtBxptnid.Text = Dgvptntab.SelectedRows(0).Cells(0).Value
        Txtbxptnname.Text = Dgvptntab.SelectedRows(0).Cells(1).Value
        Datepatientdob.Value = Dgvptntab.SelectedRows(0).Cells(2).Value
        Cmbbxptngnder.Text = Dgvptntab.SelectedRows(0).Cells(3).Value
        TxtBxptncontact.Text = Dgvptntab.SelectedRows(0).Cells(4).Value
        Txtbxptnadrs.Text = Dgvptntab.SelectedRows(0).Cells(5).Value
        Txtbxptnmedhstry.Text = Dgvptntab.SelectedRows(0).Cells(6).Value
    End Sub
    Private Sub Btnptnedit_Click(sender As Object, e As EventArgs) Handles Btnptnedit.Click
        'Check if any row is selected
        If Dgvptntab.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to edit!")
            Return
        End If

        'Check if all Assignment details are entered
        If Txtbxptnname.Text = "" Or TxtBxptnid.Text = "" Or TxtBxptncontact.Text = "" Or Txtbxptnadrs.Text = "" Or Txtbxptnmedhstry.Text = "" Then
            MessageBox.Show("Please enter valid Assignment Details!")
            Return
        End If


        If MessageBox.Show("Are you sure you want to edit selected row?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn
                'Updating selected row in Billing Table
                cmd.CommandText = "UPDATE patient SET name = @name, gender = @gender, dob = @dob, contact = @contact, address = @address, medical_history = @medical_history WHERE patient_id = @patient_id"
                cmd.Parameters.AddWithValue("@patient_id", TxtBxptnid.Text)
                cmd.Parameters.AddWithValue("@name", Txtbxptnname.Text)
                cmd.Parameters.AddWithValue("@gender", Cmbbxptngnder.Text)
                cmd.Parameters.AddWithValue("@dob", Datepatientdob.Value)
                cmd.Parameters.AddWithValue("@contact", TxtBxptncontact.Text)
                cmd.Parameters.AddWithValue("@address", Txtbxptnadrs.Text)
                cmd.Parameters.AddWithValue("@medical_history", Txtbxptnmedhstry.Text)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show("Rows updated: " & rowsAffected)
                LoadPatientsData() ' Refresh DataGridView

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub Dgvdoc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvdoc.CellClick
        TxtBxdocid.Text = Dgvdoc.SelectedRows(0).Cells(0).Value
        Txtboxdocname.Text = Dgvdoc.SelectedRows(0).Cells(1).Value
        Txtboxdocspeci.Text = Dgvdoc.SelectedRows(0).Cells(2).Value
        Txtbox_phoneno.Text = Dgvdoc.SelectedRows(0).Cells(3).Value
        Clstbox.SelectedValue = Dgvdoc.SelectedRows(0).Cells(4).Value
        Cboboxhour.Text = Dgvdoc.SelectedRows(0).Cells(5).Value
    End Sub
    Private Sub Btndocedit_Click(sender As Object, e As EventArgs) Handles Btndocedit.Click

        ' Check if any row is selected
        If Dgvdoc.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to edit!")
            Return
        End If

        ' Check if all Assignment details are entered
        If Txtboxdocname.Text = "" Or TxtBxdocid.Text = "" Or Txtboxdocspeci.Text = "" Or Txtbox_phoneno.Text = "" Or Clstbox.CheckedItems.Count < 0 Or Cboboxhour.Text = "" Then
            MessageBox.Show("Please enter valid Assignment Details!")
            Return
        End If

        If MessageBox.Show("Are you sure you want to edit selected row?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn
                'Updating selected row in Billing Table
                cmd.CommandText = "UPDATE doctor SET name = @name, specialization = @specialization, contact = @contact, week_availability = @week_availability, hour_availability = @hour_availability WHERE doctor_id = @doctor_id"
                cmd.Parameters.AddWithValue("@doctor_id", TxtBxdocid.Text)
                cmd.Parameters.AddWithValue("@name", Txtboxdocname.Text)
                cmd.Parameters.AddWithValue("@specialization", Txtboxdocspeci.Text)
                cmd.Parameters.AddWithValue("@contact", Txtbox_phoneno.Text)

                ' Convert CheckedListBox CheckedItems to a comma-separated string for database storage
                Dim weekAvailability As String = String.Join(",", Clstbox.CheckedItems.Cast(Of String)())
                cmd.Parameters.AddWithValue("@week_availability", weekAvailability)

                cmd.Parameters.AddWithValue("@hour_availability", Cboboxhour.Text)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show("Rows updated: " & rowsAffected)
                LoadDoctorsData() ' Refresh DataGridView

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub
End Class

