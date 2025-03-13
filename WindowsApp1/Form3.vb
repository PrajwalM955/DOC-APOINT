Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Messaging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    ' Dim connectionString As String = " Data Source = LAPTOP - JRNIQUNP \ SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
    Dim connectionString As String = "Data Source=LAPTOP-JRNIQUNP\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    Private Sub Load_RegTab_Data()

    End Sub
    Private Sub Form3_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        Form2.Show()
    End Sub
    'Code for back Buttons in tabcontrol
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

    'Code for submit button in doctor tab page

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnregdoc.Click
        If String.IsNullOrWhiteSpace(Txtboxdocname.Text) OrElse
                  String.IsNullOrWhiteSpace(Txtboxdocspeci.Text) OrElse
                  String.IsNullOrWhiteSpace(Txtbox_phoneno.Text) OrElse
                 Clstbox.CheckedItems.Count = 0 OrElse
                 Cboboxhour.SelectedIndex = -1 Then

            MessageBox.Show("Please fill all the fields and select Week and Hour Availability")

            'Txtboxdocname.Text = " " Or Txtboxdocspeci.Text = " " Or Txtbox_phoneno.Text.Length < 10 Or Clstbox.CheckedItems.Count = 0 Or Cboboxhour.SelectedValue = -1 Then
            '         MessageBox.Show("enter all the values!")
            Return
        Else Using con As New SqlConnection
                Try
                    con.Open()
                    Dim cmd As New SqlCommand()
                    cmd.Connection = con
                    Dim weekAvailability As String = String.Join(",", Clstbox.CheckedItems.Cast(Of String)())

                    cmd.CommandText = "insert into doctor(name,specialization,contact,week_availability,hour_availability) values (@name,@specialization,@contact,@week_availability,@hour_availability)"
                    cmd.Parameters.AddWithValue("@name", Txtboxdocname.Text)
                    cmd.Parameters.AddWithValue("@specialization", Txtboxdocspeci.Text)
                    cmd.Parameters.AddWithValue("@contact", Txtbox_phoneno.Text)
                    cmd.Parameters.AddWithValue("@Week_Availability", weekAvailability)
                    cmd.Parameters.AddWithValue("@Hour_Availability", Cboboxhour.SelectedItem.ToString())

                    '  cmd.Parameters.AddWithValue("@week_availability", Clstbox.SelectedItem)
                    ' cmd.Parameters.AddWithValue("@hour_availability", Cboboxhour.SelectedItem)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Doctor registered successfully!")

                Catch ex As Exception
                    MessageBox.Show("Error:" & ex.Message)
                End Try
                con.Close()
            End Using
        End If
    End Sub
    'Code for loading the datagridview in doctor tab page
    Private Sub DgvdocLoad()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = con

                cmd.CommandText = "select * from doctor"
                Dim dr1 As SqlDataReader = cmd.ExecuteReader
                Dim datatable As New DataTable()
                datatable.Load(dr1)
                Dgvdoc.DataSource = datatable
                dr1.Close()
            Catch ex As Exception
                MessageBox.Show("Error:", ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvdocLoad()
        Dgvtreatmentload()

    End Sub

    'code for clear function in doctor tab page
    Private Sub Btnclrdoc_Click(sender As Object, e As EventArgs) Handles Btnclrdoc.Click

    End Sub
    'code for clear function in patient tab page
    Private Sub Btnptnclr_Click(sender As Object, e As EventArgs) Handles Btnptnclr.Click
        Txtbxptnname.Clear()
        Cmbbxptngnder.SelectedIndex = -1
        Txtbxptnadrs.Clear()
        TxtBxptncontact.Clear()
        Txtbxptnmedhstry.Clear()
        Datepatientdob.Value = Date.Now ' Resetting the DateTimePicker
    End Sub

    'Code for Patient tab page Submit Button

    '  Private Sub Btnptnregister_Click(sender As Object, e As EventArgs) Handles Btnptnregister.Click
    ' If Txtbxptnname.Text = "" Or Cmbbxptngnder.Text = " " Or Cmbbxptngnder.SelectedItem = 0 Or Txtbxptnadrs.Text = " " Then
    ' MessageBox.Show("Please enter all the values!")
    ' Return
    '  Else Using con As New SqlConnection
    'Try
    ' con.Open()
    '       Dim cmd As New SqlCommand()
    ' cmd.Connection = con
    '
    '  cmd.CommandText = "insert into patient(name,dob,gender,contact,address,medical_history) values (@name,@dob,@gender,@contact,@address,@medical_history)"
    '            cmd.Parameters.AddWithValue("@name", Txtbxptnname.Text)
    ' cmd.Parameters.AddWithValue("@specialization", Cmbbxptngnder.Text)
    '  cmd.Parameters.AddWithValue("@contact", Cmbbxptngnder.Text)
    '  cmd.Parameters.AddWithValue("@week_availability", Txtbxptnadrs.Text)
    '  cmd.Parameters.AddWithValue("@hour_availability", Cboboxhour.SelectedItem)
    '  cmd.ExecuteNonQuery()
    '              MessageBox.Show("Details Recorded!")
    '  DgvdocLoad()

    '  Catch ex As Exception

    ' End Try
    '    End Using
    '   End If
    ' End Sub
    Private Sub Btnptnregister_Click(sender As Object, e As EventArgs) Handles Btnptnregister.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(Txtbxptnname.Text) OrElse
       String.IsNullOrWhiteSpace(Cmbbxptngnder.Text) OrElse
       Cmbbxptngnder.SelectedItem = 0 OrElse
       String.IsNullOrWhiteSpace(Txtbxptnadrs.Text) Then
            MessageBox.Show("Please enter all the values!")
            Return
        End If

        ' Insert patient into database
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = con

                cmd.CommandText = "INSERT INTO patient(name, dob, gender, contact, address, medical_history) 
                               VALUES (@name, @dob, @gender, @contact, @address, @medical_history)"
                cmd.Parameters.AddWithValue("@name", Txtbxptnname.Text)
                cmd.Parameters.AddWithValue("@dob", Datepatientdob.Value) ' Correctly referencing DateTimePicker
                cmd.Parameters.AddWithValue("@gender", Cmbbxptngnder.SelectedItem.ToString()) ' Ensure this is a string
                cmd.Parameters.AddWithValue("@contact", TxtBxptncontact.Text) ' Ensure contact is a string
                cmd.Parameters.AddWithValue("@address", Txtbxptnadrs.Text)
                cmd.Parameters.AddWithValue("@medical_history", Txtbxptnmedhstry.Text)


                ' Execute the query
                cmd.ExecuteNonQuery()
                MessageBox.Show("Details Recorded!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Call the function to load doctor data into the DataGridView
    Private Sub Btndgvview_Click(sender As Object, e As EventArgs) Handles Btndgvview.Click
        DgvdocLoad()
    End Sub
    ' Call the function to load patient data into the DataGridView
    Private Sub Btnptnview_Click(sender As Object, e As EventArgs) Handles Btnptnview.Click
        DgvptntabLoad()
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
                ' Show error message if there is an exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Btntrtclr_Click(sender As Object, e As EventArgs) Handles Btntrtclr.Click

    End Sub

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
    End Sub
    ' Insert treatment into database
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

    Private Sub Btntrtview_Click(sender As Object, e As EventArgs) Handles Btntrtview.Click

    End Sub
End Class
