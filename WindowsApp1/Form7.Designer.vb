<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ChartRevenue = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BtnRevLoad = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRevClose = New System.Windows.Forms.Button()
        Me.DtpRevFrom = New System.Windows.Forms.DateTimePicker()
        Me.GrpRevenue = New System.Windows.Forms.GroupBox()
        Me.BtnRevClear = New System.Windows.Forms.Button()
        Me.TxtTotalRevenue = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtpRevTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrpAge = New System.Windows.Forms.GroupBox()
        Me.BtnAgeClear = New System.Windows.Forms.Button()
        Me.TxtTotalPatients = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpAgeTo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnAgeClose = New System.Windows.Forms.Button()
        Me.BtnAgeLoad = New System.Windows.Forms.Button()
        Me.DtpAgeFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChartAge = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.ChartRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpRevenue.SuspendLayout()
        Me.GrpAge.SuspendLayout()
        CType(Me.ChartAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartRevenue
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartRevenue.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartRevenue.Legends.Add(Legend1)
        Me.ChartRevenue.Location = New System.Drawing.Point(4, 17)
        Me.ChartRevenue.Margin = New System.Windows.Forms.Padding(2)
        Me.ChartRevenue.Name = "ChartRevenue"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Revenue"
        Me.ChartRevenue.Series.Add(Series1)
        Me.ChartRevenue.Size = New System.Drawing.Size(548, 249)
        Me.ChartRevenue.TabIndex = 0
        Me.ChartRevenue.Text = "Chart1"
        '
        'BtnRevLoad
        '
        Me.BtnRevLoad.Location = New System.Drawing.Point(693, 223)
        Me.BtnRevLoad.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRevLoad.Name = "BtnRevLoad"
        Me.BtnRevLoad.Size = New System.Drawing.Size(67, 19)
        Me.BtnRevLoad.TabIndex = 1
        Me.BtnRevLoad.Text = "Load "
        Me.BtnRevLoad.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(584, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select From Duration"
        '
        'BtnRevClose
        '
        Me.BtnRevClose.Location = New System.Drawing.Point(852, 223)
        Me.BtnRevClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRevClose.Name = "BtnRevClose"
        Me.BtnRevClose.Size = New System.Drawing.Size(67, 19)
        Me.BtnRevClose.TabIndex = 4
        Me.BtnRevClose.Text = "close"
        Me.BtnRevClose.UseVisualStyleBackColor = True
        '
        'DtpRevFrom
        '
        Me.DtpRevFrom.Location = New System.Drawing.Point(700, 17)
        Me.DtpRevFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpRevFrom.Name = "DtpRevFrom"
        Me.DtpRevFrom.Size = New System.Drawing.Size(157, 20)
        Me.DtpRevFrom.TabIndex = 5
        '
        'GrpRevenue
        '
        Me.GrpRevenue.Controls.Add(Me.BtnRevClear)
        Me.GrpRevenue.Controls.Add(Me.TxtTotalRevenue)
        Me.GrpRevenue.Controls.Add(Me.Label5)
        Me.GrpRevenue.Controls.Add(Me.DtpRevTo)
        Me.GrpRevenue.Controls.Add(Me.Label3)
        Me.GrpRevenue.Controls.Add(Me.ChartRevenue)
        Me.GrpRevenue.Controls.Add(Me.BtnRevClose)
        Me.GrpRevenue.Controls.Add(Me.DtpRevFrom)
        Me.GrpRevenue.Controls.Add(Me.BtnRevLoad)
        Me.GrpRevenue.Controls.Add(Me.Label1)
        Me.GrpRevenue.Location = New System.Drawing.Point(9, 3)
        Me.GrpRevenue.Margin = New System.Windows.Forms.Padding(2)
        Me.GrpRevenue.Name = "GrpRevenue"
        Me.GrpRevenue.Padding = New System.Windows.Forms.Padding(2)
        Me.GrpRevenue.Size = New System.Drawing.Size(932, 279)
        Me.GrpRevenue.TabIndex = 6
        Me.GrpRevenue.TabStop = False
        Me.GrpRevenue.Text = "Revenue Distribution"
        '
        'BtnRevClear
        '
        Me.BtnRevClear.Location = New System.Drawing.Point(770, 223)
        Me.BtnRevClear.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRevClear.Name = "BtnRevClear"
        Me.BtnRevClear.Size = New System.Drawing.Size(67, 19)
        Me.BtnRevClear.TabIndex = 10
        Me.BtnRevClear.Text = "Clear"
        Me.BtnRevClear.UseVisualStyleBackColor = True
        '
        'TxtTotalRevenue
        '
        Me.TxtTotalRevenue.Location = New System.Drawing.Point(687, 114)
        Me.TxtTotalRevenue.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalRevenue.Name = "TxtTotalRevenue"
        Me.TxtTotalRevenue.Size = New System.Drawing.Size(101, 20)
        Me.TxtTotalRevenue.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(586, 119)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Revenue"
        '
        'DtpRevTo
        '
        Me.DtpRevTo.Location = New System.Drawing.Point(700, 67)
        Me.DtpRevTo.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpRevTo.Name = "DtpRevTo"
        Me.DtpRevTo.Size = New System.Drawing.Size(157, 20)
        Me.DtpRevTo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(584, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Select To Duration"
        '
        'GrpAge
        '
        Me.GrpAge.Controls.Add(Me.BtnAgeClear)
        Me.GrpAge.Controls.Add(Me.TxtTotalPatients)
        Me.GrpAge.Controls.Add(Me.Label6)
        Me.GrpAge.Controls.Add(Me.DtpAgeTo)
        Me.GrpAge.Controls.Add(Me.Label4)
        Me.GrpAge.Controls.Add(Me.BtnAgeClose)
        Me.GrpAge.Controls.Add(Me.BtnAgeLoad)
        Me.GrpAge.Controls.Add(Me.DtpAgeFrom)
        Me.GrpAge.Controls.Add(Me.Label2)
        Me.GrpAge.Controls.Add(Me.ChartAge)
        Me.GrpAge.Location = New System.Drawing.Point(11, 286)
        Me.GrpAge.Margin = New System.Windows.Forms.Padding(2)
        Me.GrpAge.Name = "GrpAge"
        Me.GrpAge.Padding = New System.Windows.Forms.Padding(2)
        Me.GrpAge.Size = New System.Drawing.Size(930, 306)
        Me.GrpAge.TabIndex = 7
        Me.GrpAge.TabStop = False
        Me.GrpAge.Text = "Age Distribution"
        '
        'BtnAgeClear
        '
        Me.BtnAgeClear.Location = New System.Drawing.Point(768, 266)
        Me.BtnAgeClear.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgeClear.Name = "BtnAgeClear"
        Me.BtnAgeClear.Size = New System.Drawing.Size(67, 19)
        Me.BtnAgeClear.TabIndex = 13
        Me.BtnAgeClear.Text = "Clear"
        Me.BtnAgeClear.UseVisualStyleBackColor = True
        '
        'TxtTotalPatients
        '
        Me.TxtTotalPatients.Location = New System.Drawing.Point(685, 108)
        Me.TxtTotalPatients.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalPatients.Name = "TxtTotalPatients"
        Me.TxtTotalPatients.Size = New System.Drawing.Size(101, 20)
        Me.TxtTotalPatients.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(592, 111)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total_Patients"
        '
        'DtpAgeTo
        '
        Me.DtpAgeTo.Location = New System.Drawing.Point(698, 56)
        Me.DtpAgeTo.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpAgeTo.Name = "DtpAgeTo"
        Me.DtpAgeTo.Size = New System.Drawing.Size(157, 20)
        Me.DtpAgeTo.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(582, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Select To Duration"
        '
        'BtnAgeClose
        '
        Me.BtnAgeClose.Location = New System.Drawing.Point(850, 266)
        Me.BtnAgeClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgeClose.Name = "BtnAgeClose"
        Me.BtnAgeClose.Size = New System.Drawing.Size(67, 19)
        Me.BtnAgeClose.TabIndex = 8
        Me.BtnAgeClose.Text = "close"
        Me.BtnAgeClose.UseVisualStyleBackColor = True
        '
        'BtnAgeLoad
        '
        Me.BtnAgeLoad.Location = New System.Drawing.Point(691, 266)
        Me.BtnAgeLoad.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgeLoad.Name = "BtnAgeLoad"
        Me.BtnAgeLoad.Size = New System.Drawing.Size(67, 19)
        Me.BtnAgeLoad.TabIndex = 7
        Me.BtnAgeLoad.Text = "Load "
        Me.BtnAgeLoad.UseVisualStyleBackColor = True
        '
        'DtpAgeFrom
        '
        Me.DtpAgeFrom.Location = New System.Drawing.Point(698, 17)
        Me.DtpAgeFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpAgeFrom.Name = "DtpAgeFrom"
        Me.DtpAgeFrom.Size = New System.Drawing.Size(157, 20)
        Me.DtpAgeFrom.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(582, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select From Duration"
        '
        'ChartAge
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartAge.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChartAge.Legends.Add(Legend2)
        Me.ChartAge.Location = New System.Drawing.Point(4, 28)
        Me.ChartAge.Margin = New System.Windows.Forms.Padding(2)
        Me.ChartAge.Name = "ChartAge"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Revenue"
        Me.ChartAge.Series.Add(Series2)
        Me.ChartAge.Size = New System.Drawing.Size(546, 257)
        Me.ChartAge.TabIndex = 1
        Me.ChartAge.Text = "Chart2"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 603)
        Me.Controls.Add(Me.GrpAge)
        Me.Controls.Add(Me.GrpRevenue)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form7"
        Me.Text = "Reports"
        CType(Me.ChartRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpRevenue.ResumeLayout(False)
        Me.GrpRevenue.PerformLayout()
        Me.GrpAge.ResumeLayout(False)
        Me.GrpAge.PerformLayout()
        CType(Me.ChartAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChartRevenue As DataVisualization.Charting.Chart
    Friend WithEvents BtnRevLoad As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRevClose As Button
    Friend WithEvents DtpRevFrom As DateTimePicker
    Friend WithEvents GrpRevenue As GroupBox
    Friend WithEvents GrpAge As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChartAge As DataVisualization.Charting.Chart
    Friend WithEvents DtpRevTo As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpAgeTo As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnAgeClose As Button
    Friend WithEvents BtnAgeLoad As Button
    Friend WithEvents DtpAgeFrom As DateTimePicker
    Friend WithEvents TxtTotalRevenue As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTotalPatients As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnRevClear As Button
    Friend WithEvents BtnAgeClear As Button


End Class
