Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form7
    ' Your connection string is implemented here.
    Private connectionString As String = "Data Source=DESKTOP-B9GRHRB\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True;TrustServerCertificate=True"

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize charts when the form loads.
        ChartRevenue.Series.Clear()
        ChartAge.Series.Clear()
    End Sub

    ' Loads revenue data grouped by payment mode within a selected date range.
    Private Sub LoadRevenueData()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT payment_mode, SUM(total_amount) AS TotalRevenue " &
                                      "FROM billing " &
                                      "WHERE bill_date BETWEEN @FromDate AND @ToDate " &
                                      "GROUP BY payment_mode"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FromDate", DtpRevFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@ToDate", DtpRevTo.Value.Date)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        ChartRevenue.Series.Clear()
                        Dim series As New Series("Revenue")
                        series.ChartType = SeriesChartType.Pie

                        Dim totalRevenue As Decimal = 0D
                        While reader.Read()
                            Dim paymentMode As String = reader("payment_mode").ToString()
                            Dim amount As Decimal = Convert.ToDecimal(reader("TotalRevenue"))
                            series.Points.AddXY(paymentMode, amount)
                            totalRevenue += amount
                        End While
                        ChartRevenue.Series.Add(series)
                        TxtTotalRevenue.Text = totalRevenue.ToString("C2")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading revenue data: " & ex.Message)
        End Try
    End Sub

    ' Loads age distribution data, grouping patients into 20-year intervals.
    Private Sub LoadAgeData()
        Try
            Using conn As New SqlConnection(connectionString)
                ' Group ages into 20-year intervals (1-20, 21-40, etc.)
                Dim query As String = "SELECT CASE " &
                                      "WHEN DATEDIFF(YEAR, dob, GETDATE()) BETWEEN 1 AND 20 THEN '1-20' " &
                                      "WHEN DATEDIFF(YEAR, dob, GETDATE()) BETWEEN 21 AND 40 THEN '21-40' " &
                                      "WHEN DATEDIFF(YEAR, dob, GETDATE()) BETWEEN 41 AND 60 THEN '41-60' " &
                                      "WHEN DATEDIFF(YEAR, dob, GETDATE()) BETWEEN 61 AND 80 THEN '61-80' " &
                                      "ELSE '>80' END AS AgeGroup, " &
                                      "COUNT(*) AS PatientCount " &
                                      "FROM patient " &
                                      "WHERE dob IS NOT NULL " &
                                      "GROUP BY CASE " &
                                      "WHEN DATEDIFF(YEAR, dob, GETDATE()) BETWEEN 1 AND 20 THEN '1-20' " &
                                      "WHEN DATEDIFF(YEAR, dob, GETDATE()) BETWEEN 21 AND 40 THEN '21-40' " &
                                      "WHEN DATEDIFF(YEAR, dob, GETDATE()) BETWEEN 41 AND 60 THEN '41-60' " &
                                      "WHEN DATEDIFF(YEAR, dob, GETDATE()) BETWEEN 61 AND 80 THEN '61-80' " &
                                      "ELSE '>80' END " &
                                      "ORDER BY AgeGroup"
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        ChartAge.Series.Clear()
                        Dim series As New Series("Age Distribution")
                        series.ChartType = SeriesChartType.Pie

                        Dim totalPatients As Integer = 0
                        While reader.Read()
                            Dim ageGroup As String = reader("AgeGroup").ToString()
                            Dim count As Integer = Convert.ToInt32(reader("PatientCount"))
                            series.Points.AddXY(ageGroup, count)
                            totalPatients += count
                        End While
                        ChartAge.Series.Add(series)
                        TxtTotalPatients.Text = totalPatients.ToString()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading age distribution data: " & ex.Message)
        End Try
    End Sub

    ' Button click events

    ' Revenue Section: Load, Clear, Close
    Private Sub BtnRevLoad_Click(sender As Object, e As EventArgs) Handles BtnRevLoad.Click
        LoadRevenueData()
    End Sub

    Private Sub BtnRevClear_Click(sender As Object, e As EventArgs) Handles BtnRevClear.Click
        ChartRevenue.Series.Clear()
        TxtTotalRevenue.Clear()
    End Sub

    Private Sub BtnRevClose_Click(sender As Object, e As EventArgs) Handles BtnRevClose.Click
        Me.Close()
    End Sub

    ' Age Section: Load, Clear, Close
    Private Sub BtnAgeLoad_Click(sender As Object, e As EventArgs) Handles BtnAgeLoad.Click
        LoadAgeData()
    End Sub

    Private Sub BtnAgeClear_Click(sender As Object, e As EventArgs) Handles BtnAgeClear.Click
        ChartAge.Series.Clear()
        TxtTotalPatients.Clear()
    End Sub

    Private Sub BtnAgeClose_Click(sender As Object, e As EventArgs) Handles BtnAgeClose.Click
        Me.Close()
    End Sub


    Private Sub GrpRevenue_Enter(sender As Object, e As EventArgs) Handles GrpRevenue.Enter

    End Sub
End Class
