<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CmbxapintId = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Cmbxapoitdocname = New System.Windows.Forms.ComboBox()
        Me.Cmbxapointptnname = New System.Windows.Forms.ComboBox()
        Me.Cmbxapoitdocid = New System.Windows.Forms.ComboBox()
        Me.Cmbxapointptnid = New System.Windows.Forms.ComboBox()
        Me.Cmbxapointreason = New System.Windows.Forms.ComboBox()
        Me.Btnapointclr = New System.Windows.Forms.Button()
        Me.Btnappoint = New System.Windows.Forms.Button()
        Me.Cmbxapoitstatus = New System.Windows.Forms.ComboBox()
        Me.Cmbxapointtime = New System.Windows.Forms.ComboBox()
        Me.Dateapointdate = New System.Windows.Forms.DateTimePicker()
        Me.Dgvappoint = New System.Windows.Forms.DataGridView()
        Me.Btnapointview = New System.Windows.Forms.Button()
        Me.Btnapointedit = New System.Windows.Forms.Button()
        Me.Btnapointdelete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgvappoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient_Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Doctor_ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 217)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Doctor_Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(307, 30)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Appointment_date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(307, 77)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(307, 140)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(307, 179)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Reason"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbxapintId)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Cmbxapoitdocname)
        Me.Panel1.Controls.Add(Me.Cmbxapointptnname)
        Me.Panel1.Controls.Add(Me.Cmbxapoitdocid)
        Me.Panel1.Controls.Add(Me.Cmbxapointptnid)
        Me.Panel1.Controls.Add(Me.Cmbxapointreason)
        Me.Panel1.Controls.Add(Me.Btnapointclr)
        Me.Panel1.Controls.Add(Me.Btnappoint)
        Me.Panel1.Controls.Add(Me.Cmbxapoitstatus)
        Me.Panel1.Controls.Add(Me.Cmbxapointtime)
        Me.Panel1.Controls.Add(Me.Dateapointdate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 274)
        Me.Panel1.TabIndex = 8
        '
        'CmbxapintId
        '
        Me.CmbxapintId.FormattingEnabled = True
        Me.CmbxapintId.Location = New System.Drawing.Point(123, 31)
        Me.CmbxapintId.Name = "CmbxapintId"
        Me.CmbxapintId.Size = New System.Drawing.Size(121, 21)
        Me.CmbxapintId.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Appointment ID"
        '
        'Cmbxapoitdocname
        '
        Me.Cmbxapoitdocname.FormattingEnabled = True
        Me.Cmbxapoitdocname.Location = New System.Drawing.Point(123, 217)
        Me.Cmbxapoitdocname.Name = "Cmbxapoitdocname"
        Me.Cmbxapoitdocname.Size = New System.Drawing.Size(121, 21)
        Me.Cmbxapoitdocname.TabIndex = 22
        '
        'Cmbxapointptnname
        '
        Me.Cmbxapointptnname.FormattingEnabled = True
        Me.Cmbxapointptnname.Location = New System.Drawing.Point(123, 128)
        Me.Cmbxapointptnname.Name = "Cmbxapointptnname"
        Me.Cmbxapointptnname.Size = New System.Drawing.Size(121, 21)
        Me.Cmbxapointptnname.TabIndex = 21
        '
        'Cmbxapoitdocid
        '
        Me.Cmbxapoitdocid.FormattingEnabled = True
        Me.Cmbxapoitdocid.Location = New System.Drawing.Point(123, 171)
        Me.Cmbxapoitdocid.Name = "Cmbxapoitdocid"
        Me.Cmbxapoitdocid.Size = New System.Drawing.Size(121, 21)
        Me.Cmbxapoitdocid.TabIndex = 20
        '
        'Cmbxapointptnid
        '
        Me.Cmbxapointptnid.FormattingEnabled = True
        Me.Cmbxapointptnid.Location = New System.Drawing.Point(123, 77)
        Me.Cmbxapointptnid.Name = "Cmbxapointptnid"
        Me.Cmbxapointptnid.Size = New System.Drawing.Size(121, 21)
        Me.Cmbxapointptnid.TabIndex = 19
        '
        'Cmbxapointreason
        '
        Me.Cmbxapointreason.FormattingEnabled = True
        Me.Cmbxapointreason.Items.AddRange(New Object() {"General Consultancy", "Follow-up Consultancy", "Specialized Consultancy", "Diagnostic Tests"})
        Me.Cmbxapointreason.Location = New System.Drawing.Point(444, 179)
        Me.Cmbxapointreason.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbxapointreason.Name = "Cmbxapointreason"
        Me.Cmbxapointreason.Size = New System.Drawing.Size(126, 21)
        Me.Cmbxapointreason.TabIndex = 18
        '
        'Btnapointclr
        '
        Me.Btnapointclr.Location = New System.Drawing.Point(604, 231)
        Me.Btnapointclr.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnapointclr.Name = "Btnapointclr"
        Me.Btnapointclr.Size = New System.Drawing.Size(84, 24)
        Me.Btnapointclr.TabIndex = 17
        Me.Btnapointclr.Text = "Clear"
        Me.Btnapointclr.UseVisualStyleBackColor = True
        '
        'Btnappoint
        '
        Me.Btnappoint.Location = New System.Drawing.Point(520, 231)
        Me.Btnappoint.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnappoint.Name = "Btnappoint"
        Me.Btnappoint.Size = New System.Drawing.Size(80, 26)
        Me.Btnappoint.TabIndex = 16
        Me.Btnappoint.Text = "Appoint"
        Me.Btnappoint.UseVisualStyleBackColor = True
        '
        'Cmbxapoitstatus
        '
        Me.Cmbxapoitstatus.FormattingEnabled = True
        Me.Cmbxapoitstatus.Items.AddRange(New Object() {"Booked", "Canceled", "Finished"})
        Me.Cmbxapoitstatus.Location = New System.Drawing.Point(444, 132)
        Me.Cmbxapoitstatus.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbxapoitstatus.Name = "Cmbxapoitstatus"
        Me.Cmbxapoitstatus.Size = New System.Drawing.Size(126, 21)
        Me.Cmbxapoitstatus.TabIndex = 15
        '
        'Cmbxapointtime
        '
        Me.Cmbxapointtime.FormattingEnabled = True
        Me.Cmbxapointtime.Items.AddRange(New Object() {"8:00-8:30 am", "8:30-9:00 am", "9:00-9:30 am", "9:30-10:00 am", "10:00-10:30 am", "10:30- 11:00 am", "11:00-11:30 am", "11:30-12:00 am", "12:00-12:30 pm", "12:30-1:00 pm", "1:00-1:30 pm", "1:30 -2:00 pm", "2:00-2:30 pm", "2:30-3:00 pm", "3:00-3:30 pm", "3:30-4:00 pm", "4:00-4:30 pm", "4:30-5:00 pm", "5:00-5:30 pm", "5:30-6:00 pm", "6:00-6:30 pm", "6:30-7:00 pm", "7:00-7:30 pm", "7:30-8:00 pm", "8:00-8:30 pm", "8:30-9:00 pm", "9:00-9:30 pm", "9:30-10:00 pm", "10:00-10:30 pm", "10:30-11:00 pm", "11:00-11:30 pm", "", ""})
        Me.Cmbxapointtime.Location = New System.Drawing.Point(444, 77)
        Me.Cmbxapointtime.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbxapointtime.Name = "Cmbxapointtime"
        Me.Cmbxapointtime.Size = New System.Drawing.Size(126, 21)
        Me.Cmbxapointtime.TabIndex = 14
        '
        'Dateapointdate
        '
        Me.Dateapointdate.Location = New System.Drawing.Point(444, 24)
        Me.Dateapointdate.Margin = New System.Windows.Forms.Padding(2)
        Me.Dateapointdate.MinDate = New Date(2025, 2, 23, 0, 0, 0, 0)
        Me.Dateapointdate.Name = "Dateapointdate"
        Me.Dateapointdate.Size = New System.Drawing.Size(151, 20)
        Me.Dateapointdate.TabIndex = 13
        '
        'Dgvappoint
        '
        Me.Dgvappoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvappoint.Location = New System.Drawing.Point(9, 322)
        Me.Dgvappoint.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgvappoint.Name = "Dgvappoint"
        Me.Dgvappoint.RowHeadersWidth = 51
        Me.Dgvappoint.RowTemplate.Height = 24
        Me.Dgvappoint.Size = New System.Drawing.Size(710, 133)
        Me.Dgvappoint.TabIndex = 9
        '
        'Btnapointview
        '
        Me.Btnapointview.Location = New System.Drawing.Point(487, 298)
        Me.Btnapointview.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnapointview.Name = "Btnapointview"
        Me.Btnapointview.Size = New System.Drawing.Size(67, 19)
        Me.Btnapointview.TabIndex = 10
        Me.Btnapointview.Text = "View"
        Me.Btnapointview.UseVisualStyleBackColor = True
        '
        'Btnapointedit
        '
        Me.Btnapointedit.Location = New System.Drawing.Point(558, 298)
        Me.Btnapointedit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnapointedit.Name = "Btnapointedit"
        Me.Btnapointedit.Size = New System.Drawing.Size(65, 19)
        Me.Btnapointedit.TabIndex = 11
        Me.Btnapointedit.Text = "Edit_row"
        Me.Btnapointedit.UseVisualStyleBackColor = True
        '
        'Btnapointdelete
        '
        Me.Btnapointdelete.Location = New System.Drawing.Point(628, 298)
        Me.Btnapointdelete.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnapointdelete.Name = "Btnapointdelete"
        Me.Btnapointdelete.Size = New System.Drawing.Size(71, 19)
        Me.Btnapointdelete.TabIndex = 12
        Me.Btnapointdelete.Text = "Delete_row"
        Me.Btnapointdelete.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 466)
        Me.Controls.Add(Me.Btnapointdelete)
        Me.Controls.Add(Me.Btnapointedit)
        Me.Controls.Add(Me.Btnapointview)
        Me.Controls.Add(Me.Dgvappoint)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form4"
        Me.Text = "Appointment_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgvappoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cmbxapoitstatus As ComboBox
    Friend WithEvents Cmbxapointtime As ComboBox
    Friend WithEvents Dateapointdate As DateTimePicker
    Friend WithEvents Btnapointclr As Button
    Friend WithEvents Btnappoint As Button
    Friend WithEvents Dgvappoint As DataGridView
    Friend WithEvents Btnapointview As Button
    Friend WithEvents Btnapointedit As Button
    Friend WithEvents Btnapointdelete As Button
    Friend WithEvents Cmbxapointreason As ComboBox
    Friend WithEvents Cmbxapoitdocname As ComboBox
    Friend WithEvents Cmbxapointptnname As ComboBox
    Friend WithEvents Cmbxapoitdocid As ComboBox
    Friend WithEvents Cmbxapointptnid As ComboBox
    Friend WithEvents CmbxapintId As ComboBox
    Friend WithEvents Label9 As Label
End Class
