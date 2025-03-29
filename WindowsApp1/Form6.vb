Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Form6
    ' Connection string to your SQL Server database
    Private Const ConnectionString As String = "Data Source=desktop-b9grhrb\sqlexpress;Initial Catalog=clinic;Integrated Security=True;Trust Server Certificate=TrueData Source=desktop-b9grhrb\sqlexpress;Initial Catalog=clinic;Integrated Security=True;Trust Server Certificate=True"

    ' Clear all fields in the form
    Private Sub Btn_bills_clear_Click(sender As Object, e As EventArgs) Handles Btn_bills_clear.Click
        TxtBxbillid.Clear()
        Combox_bill_ptnid.SelectedIndex = -1
        CmbPaymentMode.SelectedIndex = -1
        Cmb_bills_status.SelectedIndex = -1
        TxtTotalAmount.Clear()
        DtpBillDate.Value = DateTime.Now
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadpatientidbill()
    End Sub

    Private Sub Loadpatientidbill()
        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Selecting Registration Numbers from Registration Table
                cmd.CommandText = "select patient_id from patient"

                'Displaying Registration Numbers in ComboBox
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()
                Combox_bill_ptnid.Items.Clear()
                While datareader1.Read()
                    Combox_bill_ptnid.Items.Add(datareader1("patient_id").ToString())
                End While
                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    'loading the data from database to datagridview
    Private Sub Loadbilldata()
        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim adapter As New SqlDataAdapter("SELECT * FROM billing", conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DgvBillingData.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub DgvBillingData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBillingData.CellClick
        TxtBxbillid.Text = DgvBillingData.SelectedRows(0).Cells(0).Value
        Combox_bill_ptnid.Text = DgvBillingData.SelectedRows(0).Cells(1).Value
        DtpBillDate.Value = DgvBillingData.SelectedRows(0).Cells(5).Value
        TxtTotalAmount.Text = DgvBillingData.SelectedRows(0).Cells(2).Value
        CmbPaymentMode.Text = DgvBillingData.SelectedRows(0).Cells(3).Value
        Cmb_bills_status.Text = DgvBillingData.SelectedRows(0).Cells(4).Value
    End Sub

    ' Close the application
    Private Sub Form6_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    ' Calculate total cost for selected Patient ID from treatmentassign table
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        Using conn As New SqlConnection(ConnectionString)
            Try

                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Selects sum of treatment costs of all treatments done to a patient
                cmd.CommandText = "select sum(treatment_cost) as totalamount from treatmentassign where patient_id=" + Combox_bill_ptnid.Text

                'Displaying Total Amount in TextBox
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()
                TxtTotalAmount.Clear()
                While datareader1.Read()
                    TxtTotalAmount.Text = datareader1("totalamount").ToString()
                End While
                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    ' Add a new bill record to the billing table
    Private Sub BtnAddBill_Click(sender As Object, e As EventArgs) Handles BtnAddBill.Click
        ' Validate input fields
        If String.IsNullOrEmpty(Combox_bill_ptnid.Text) OrElse String.IsNullOrEmpty(CmbPaymentMode.Text) OrElse String.IsNullOrEmpty(Cmb_bills_status.Text) OrElse String.IsNullOrEmpty(TxtTotalAmount.Text) Then
            MessageBox.Show("Please fill all mandatory fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else Using conn As New SqlConnection(ConnectionString)
                Try
                    conn.Open()
                    Dim cmd As New SqlCommand()
                    cmd.Connection = conn

                    'Inserting details into Billing Table
                    cmd.CommandText = "INSERT INTO billing (patient_id, total_amount, payment_mode, payment_status, bill_date) VALUES (@patient_id, @total_amount, @payment_mode, @payment_status, @bill_date)"
                    cmd.Parameters.AddWithValue("@patient_id", Combox_bill_ptnid.Text)
                    cmd.Parameters.AddWithValue("@total_amount", TxtTotalAmount.Text)
                    cmd.Parameters.AddWithValue("@payment_mode", CmbPaymentMode.Text)
                    cmd.Parameters.AddWithValue("@payment_status", Cmb_bills_status.Text)
                    cmd.Parameters.AddWithValue("@bill_date", DtpBillDate.Value)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Billing record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Rows inserted: " & rowsAffected)

                    Loadbilldata()

                Catch ex As Exception
                    MessageBox.Show("Error:" & ex.Message)
                End Try
            End Using
        End If
    End Sub

    ' View all billing records in DataGridView (DgvBillingData)
    Private Sub BtnBillview_Click(sender As Object, e As EventArgs) Handles BtnBillview.Click
        Loadbilldata()
    End Sub

    ' Edit selected row in DataGridView and update database record accordingly.
    Private Sub BtnEditRow_Click(sender As Object, e As EventArgs) Handles BtnEditRow.Click
        'Check if any row is selected
        If DgvBillingData.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to edit!")
            Return
        End If

        'Check if all Bill details are entered
        If Combox_bill_ptnid.Text = "" Or TxtTotalAmount.Text = "" Or CmbPaymentMode.Text = "" Or Cmb_bills_status.Text = "" Then
            MessageBox.Show("Please enter valid Bill Details!")
            Return
        End If

        If MessageBox.Show("Are you sure you want to edit selected row?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        If DgvBillingData.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn
                'Updating selected row in Billing Table
                cmd.CommandText = "UPDATE billing SET patient_id = @patient_id, total_amount = @total_amount, payment_mode = @payment_mode, payment_status = @payment_status, bill_date = @bill_date WHERE bill_id = @bill_id"
                cmd.Parameters.AddWithValue("@bill_id", TxtBxbillid.Text)
                cmd.Parameters.AddWithValue("@patient_id", Combox_bill_ptnid.Text)
                cmd.Parameters.AddWithValue("@total_amount", TxtTotalAmount.Text)
                cmd.Parameters.AddWithValue("@payment_mode", CmbPaymentMode.Text)
                cmd.Parameters.AddWithValue("@payment_status", Cmb_bills_status.Text)
                cmd.Parameters.AddWithValue("@bill_date", DtpBillDate.Value)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show("Rows updated: " & rowsAffected)

                BtnBillview.PerformClick() ' Refresh DataGridView after update.()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using

    End Sub

    ' Delete selected row from DataGridView and database table.
    Private Sub BtnDeleteRow_Click(sender As Object, e As EventArgs) Handles BtnDeleteRow.Click
        'Check if any row is selected
        If DgvBillingData.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete!")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete selected row?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Deleting selected row from Billing Table
                cmd.CommandText = "DELETE FROM billing WHERE bill_id = @bill_id"
                cmd.Parameters.AddWithValue("@bill_id", DgvBillingData.SelectedRows(0).Cells(0).Value)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show("Rows deleted: " & rowsAffected)

                BtnBillview.PerformClick() ' Refresh DataGridView after deletion.

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using

    End Sub

    ' Generate Invoice by opening InvoiceForm (with PrintDocument and PrintPreviewDialog tools)
    Private Sub BtnGenerateInvoice_Click(sender As Object, e As EventArgs) Handles BtnGenerateInvoice.Click
        Dim invoiceForm As New Invoiceform()
        invoiceForm.Show() ' Show Invoice Form.
    End Sub

    Private Sub BtnBillbck_Click(sender As Object, e As EventArgs) Handles BtnBillbck.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class