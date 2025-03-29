Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Net
Imports System.Windows.Forms.VisualStyles

Public Class Form9

    Private WithEvents PrintDoc As New PrintDocument()
    Private PrintPreviewDlg As New PrintPreviewDialog()

    'Database Connection String
    Private Const ConnectionString As String = "Data Source=desktop-b9grhrb\sqlexpress;Initial Catalog=clinic;Integrated Security=True;Trust Server Certificate=True"

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Function to Load Patient name in combobox
        Loadptnnamecmb()
        LoadDoctorNamescmb()
    End Sub

    Private Sub Btnbckinvo_Click(sender As Object, e As EventArgs) Handles Btnbckinvo.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub Form9FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form4.Show()
    End Sub
    Private Sub Buttonprintinvo_Click(sender As Object, e As EventArgs) Handles Btnprintinvoapoint.Click

        If Cmbxapointinvoptnid.SelectedIndex = -1 Or Cmbxapointinvodocid.SelectedIndex = -1 Then
            MessageBox.Show("Please Select Patient Name and Doctor Name!")
        Else
            PrintPreviewDlg.Document = PrintDocument1
            PrintPreviewDlg.StartPosition = FormStartPosition.CenterScreen
            PrintPreviewDlg.WindowState = FormWindowState.Maximized
            PrintPreviewDlg.ShowDialog()
        End If

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bmp As New Bitmap(Panelapinvo.Width, Panelapinvo.Height)
        Panelapinvo.DrawToBitmap(bmp, New Rectangle(0, 0, Panelapinvo.Width, Panelapinvo.Height))
        e.Graphics.DrawImage(bmp, 50, 50)
    End Sub

    'Function to Load Patient name in combobox
    Private Sub Loadptnnamecmb()

        Using con As New SqlConnection(ConnectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand("SELECT patient_id, name FROM patient", con)
                Dim dr As SqlDataReader = cmd.ExecuteReader()

                Dim dt As New DataTable()
                dt.Load(dr)

                Cmbxapointinvoptnid.DataSource = dt
                Cmbxapointinvoptnid.DisplayMember = "name"  ' Display Patient Name in combobox
                Cmbxapointinvoptnid.ValueMember = "patient_id"         ' Store Patient IDs as values
                Cmbxapointinvoptnid.SelectedIndex = -1           ' Reset selection
            Catch ex As Exception
                MessageBox.Show("Error loading patient names: " & ex.Message)
            End Try
        End Using
    End Sub
    ' Method to load Doctor Names into the Doctor combobox
    Private Sub LoadDoctorNamescmb()
        Using con As New SqlConnection(ConnectionString)
            Try
                con.Open()
                Dim cmd As New SqlCommand("SELECT doctor_id, name FROM doctor", con)
                Dim dr As SqlDataReader = cmd.ExecuteReader()

                Dim dt As New DataTable()
                dt.Load(dr)

                Cmbxapointinvodocid.DataSource = dt
                Cmbxapointinvodocid.DisplayMember = "name"  ' Display Doctor Name in combobox
                Cmbxapointinvodocid.ValueMember = "doctor_id"  ' Store Doctor IDs as values
                Cmbxapointinvodocid.SelectedIndex = -1          ' Reset selection
            Catch ex As Exception
                MessageBox.Show("Error loading doctor names: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub Btnclrinvo_Click(sender As Object, e As EventArgs) Handles Btnclrinvo.Click

        ' Reset comboboxes
        Cmbxapointinvoptnid.SelectedIndex = -1
        Cmbxapointinvodocid.SelectedIndex = -1
        Cmbxapointinvotime.SelectedIndex = -1
        Cmbxapointinvostatus.SelectedIndex = -1
        Cmbxapointinvoreason.SelectedIndex = -1

        ' Reset date picker to current date
        Dateapointinvodate.Value = DateTime.Now

    End Sub

End Class