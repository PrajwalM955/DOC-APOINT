Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Net

Public Class Invoiceform

    Private WithEvents PrintDoc As New PrintDocument()
    Private PrintPreviewDlg As New PrintPreviewDialog()

    'Database Connection String
    Private Const ConnectionString As String = "Data Source=DESKTOP-B9GRHRB\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True;Trust Server Certificate=TrueData Source=DESKTOP-B9GRHRB\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True;TrustServerCertificate=True"
    Private Sub Invoiceform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Function to Load Patient id in combobox
        Loadpatientidcmbbx()

    End Sub

    Private Sub Btnbckinvo_Click(sender As Object, e As EventArgs) Handles Btnbckinvo.Click
        Form6.Show()
        Me.Hide()
    End Sub
    Private Sub Form_InvoiceFormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form6.Show()
    End Sub

    Private Sub Buttonprintinvo_Click(sender As Object, e As EventArgs) Handles Buttonprintinvo.Click

        If CmbWardno.SelectedItem = "" Or Cmbbillid.SelectedItem = "" Then
            MessageBox.Show("Please Select Patient ID or Bill ID !")
        Else
            PrintPreviewDlg.Document = PrintDocument1
            PrintPreviewDlg.StartPosition = FormStartPosition.CenterScreen
            PrintPreviewDlg.WindowState = FormWindowState.Maximized
            PrintPreviewDlg.ShowDialog()
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bmp As New Bitmap(Panel1.Width, Panel1.Height)
        Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, Panel1.Width, Panel1.Height))
        e.Graphics.DrawImage(bmp, 50, 50)
    End Sub

    'Function to Load Patient id in combobox
    Private Sub Loadpatientidcmbbx()

        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Selecting Registration Numbers from Registration Table
                cmd.CommandText = "select patient_id from patient"

                'Displaying Registration Numbers in ComboBox
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()
                CmbWardno.Items.Clear()
                While datareader1.Read()
                    CmbWardno.Items.Add(datareader1("patient_id").ToString())
                End While
                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    'Function to Load BillIDs in BillID ComboBox
    Private Sub LoadBillIDComboBox()
        ' Ensure that a patient ID is selected before proceeding
        If CmbWardno.SelectedItem = "" Then
            MessageBox.Show("Please select a valid Patient ID.")
            Return
        End If

        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                ' Query to fetch bill IDs based on the selected patient ID
                cmd.CommandText = "select bill_id from billing where patient_id=@patient_id"
                cmd.Parameters.AddWithValue("@patient_id", CmbWardno.Text)

                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()

                ' Clear and populate the Bill ID ComboBox
                Cmbbillid.Items.Clear()
                While datareader1.Read()
                    Cmbbillid.Items.Add(datareader1("bill_id").ToString())
                End While

                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    'Function to Load Patient Details when a patient id is selected
    Private Sub CmbWardno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbWardno.SelectedIndexChanged

        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Select Patient Details from Patient Table
                cmd.CommandText = "select name, dob, gender, contact, address from Patient where patient_id=@patient_id"
                cmd.Parameters.AddWithValue("@patient_id", CmbWardno.Text)

                'Display patient Details in TextBoxes
                Using datareader1 As SqlDataReader = cmd.ExecuteReader()
                        If datareader1.HasRows Then
                            While datareader1.Read()
                                TextBoxptname.Text = datareader1("name")
                                TextBoxptncallno.Text = datareader1("contact")
                                TextBoxptnaddress.Text = datareader1("address")
                                TextBoxptngen.Text = datareader1("gender")
                                TextBoxptdob.Text = datareader1("dob").ToString() ' Ensure this is a valid date
                            End While
                        Else
                            MessageBox.Show("No patient found with the selected ID.")
                        End If
                    End Using

                    'Load BillIDs in BillID ComboBox
                    LoadBillIDComboBox()

                'Load Treatment Data in Treatment DataGridView
                Load_Treatment_Data()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    'Loads Bill Details in Bill Details Panel
    Private Sub Cmbbillid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbbillid.SelectedIndexChanged

        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Select Bill Details from Billing Table
                cmd.CommandText = "select bill_date,total_amount,payment_mode,payment_status from billing where bill_id=@bill_id"
                cmd.Parameters.AddWithValue("@bill_id", Cmbbillid.Text)

                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()
                Do While datareader1.Read()
                    Dtpbillinvo.Value = datareader1("bill_date")
                    TextBoxamtinvo.Text = datareader1("total_amount")
                    TextBoxpaymod.Text = datareader1("payment_mode")
                    TextBoxstatus.Text = datareader1("payment_status")
                Loop
                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    'Function to Load Treatment Data in invoice DataGridView
    Private Sub Load_Treatment_Data()
        Using conn As New SqlConnection(ConnectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                'Select Treatment Data from Treatment Assignments Table and Treatment Table
                cmd.CommandText = "select sa.treatment_id,s.name,sa.treatment_date,sa.status,sa.treatment_cost from treatmentassign sa,treatment s  where sa.treatment_id=s.treatment_id and patient_id=@patient_id"
                cmd.Parameters.AddWithValue("@patient_id", CmbWardno.Text)
                Dim datareader1 As SqlDataReader = cmd.ExecuteReader()

                'Displaying details in DataGridView
                Dim datatable1 As New DataTable()
                datatable1.Load(datareader1)
                Dgvinvo.DataSource = datatable1
                datareader1.Close()

            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Btnclrinvo_Click(sender As Object, e As EventArgs) Handles Btnclrinvo.Click
        ' Clear all textboxes
        TextBoxptname.Clear()
        TextBoxptncallno.Clear()
        TextBoxptnaddress.Clear()
        TextBoxptngen.Clear()
        TextBoxptdob.Clear()
        TextBoxamtinvo.Clear()
        TextBoxpaymod.Clear()
        TextBoxstatus.Clear()

        ' Reset comboboxes
        CmbWardno.Text = ""
        Cmbbillid.Text = ""

        ' Reset date picker to current date
        Dtpbillinvo.Value = DateTime.Now

        ' Clear DataGridView
        Dgvinvo.DataSource = Nothing

    End Sub
End Class