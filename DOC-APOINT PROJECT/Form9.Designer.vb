<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btnclrinvo = New System.Windows.Forms.Button()
        Me.Btnbckinvo = New System.Windows.Forms.Button()
        Me.Btnprintinvoapoint = New System.Windows.Forms.Button()
        Me.Panelapinvo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cmbxapointinvodocid = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cmbxapointinvoptnid = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cmbxapointinvoreason = New System.Windows.Forms.ComboBox()
        Me.Dateapointinvodate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Cmbxapointinvostatus = New System.Windows.Forms.ComboBox()
        Me.Cmbxapointinvotime = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel3.SuspendLayout()
        Me.Panelapinvo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Btnclrinvo)
        Me.Panel3.Controls.Add(Me.Btnbckinvo)
        Me.Panel3.Controls.Add(Me.Btnprintinvoapoint)
        Me.Panel3.Location = New System.Drawing.Point(432, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(251, 40)
        Me.Panel3.TabIndex = 3
        '
        'Btnclrinvo
        '
        Me.Btnclrinvo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclrinvo.Location = New System.Drawing.Point(170, 12)
        Me.Btnclrinvo.Name = "Btnclrinvo"
        Me.Btnclrinvo.Size = New System.Drawing.Size(62, 23)
        Me.Btnclrinvo.TabIndex = 3
        Me.Btnclrinvo.Text = "Clear"
        Me.Btnclrinvo.UseVisualStyleBackColor = True
        '
        'Btnbckinvo
        '
        Me.Btnbckinvo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbckinvo.Location = New System.Drawing.Point(102, 12)
        Me.Btnbckinvo.Name = "Btnbckinvo"
        Me.Btnbckinvo.Size = New System.Drawing.Size(62, 23)
        Me.Btnbckinvo.TabIndex = 2
        Me.Btnbckinvo.Text = "Back"
        Me.Btnbckinvo.UseVisualStyleBackColor = True
        '
        'Btnprintinvoapoint
        '
        Me.Btnprintinvoapoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprintinvoapoint.Location = New System.Drawing.Point(29, 12)
        Me.Btnprintinvoapoint.Name = "Btnprintinvoapoint"
        Me.Btnprintinvoapoint.Size = New System.Drawing.Size(67, 23)
        Me.Btnprintinvoapoint.TabIndex = 1
        Me.Btnprintinvoapoint.Text = "Print"
        Me.Btnprintinvoapoint.UseVisualStyleBackColor = True
        '
        'Panelapinvo
        '
        Me.Panelapinvo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panelapinvo.Controls.Add(Me.Label3)
        Me.Panelapinvo.Controls.Add(Me.GroupBox1)
        Me.Panelapinvo.Location = New System.Drawing.Point(12, 58)
        Me.Panelapinvo.Name = "Panelapinvo"
        Me.Panelapinvo.Size = New System.Drawing.Size(671, 336)
        Me.Panelapinvo.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(225, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Medical Apointment Invoice"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmbxapointinvodocid)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Cmbxapointinvoptnid)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Cmbxapointinvoreason)
        Me.GroupBox1.Controls.Add(Me.Dateapointinvodate)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Cmbxapointinvostatus)
        Me.GroupBox1.Controls.Add(Me.Cmbxapointinvotime)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 222)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appointment Details"
        '
        'Cmbxapointinvodocid
        '
        Me.Cmbxapointinvodocid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbxapointinvodocid.FormattingEnabled = True
        Me.Cmbxapointinvodocid.Location = New System.Drawing.Point(140, 101)
        Me.Cmbxapointinvodocid.Name = "Cmbxapointinvodocid"
        Me.Cmbxapointinvodocid.Size = New System.Drawing.Size(151, 24)
        Me.Cmbxapointinvodocid.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 49)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Patient_Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(377, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Status"
        '
        'Cmbxapointinvoptnid
        '
        Me.Cmbxapointinvoptnid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbxapointinvoptnid.FormattingEnabled = True
        Me.Cmbxapointinvoptnid.Location = New System.Drawing.Point(140, 49)
        Me.Cmbxapointinvoptnid.Name = "Cmbxapointinvoptnid"
        Me.Cmbxapointinvoptnid.Size = New System.Drawing.Size(151, 24)
        Me.Cmbxapointinvoptnid.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(377, 48)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(377, 165)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Reason"
        '
        'Cmbxapointinvoreason
        '
        Me.Cmbxapointinvoreason.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbxapointinvoreason.FormattingEnabled = True
        Me.Cmbxapointinvoreason.Items.AddRange(New Object() {"General Consultancy", "Follow-up Consultancy", "Specialized Consultancy", "Diagnostic Tests"})
        Me.Cmbxapointinvoreason.Location = New System.Drawing.Point(443, 160)
        Me.Cmbxapointinvoreason.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbxapointinvoreason.Name = "Cmbxapointinvoreason"
        Me.Cmbxapointinvoreason.Size = New System.Drawing.Size(168, 24)
        Me.Cmbxapointinvoreason.TabIndex = 38
        '
        'Dateapointinvodate
        '
        Me.Dateapointinvodate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dateapointinvodate.Location = New System.Drawing.Point(140, 160)
        Me.Dateapointinvodate.Margin = New System.Windows.Forms.Padding(2)
        Me.Dateapointinvodate.MinDate = New Date(2025, 2, 23, 0, 0, 0, 0)
        Me.Dateapointinvodate.Name = "Dateapointinvodate"
        Me.Dateapointinvodate.Size = New System.Drawing.Size(196, 20)
        Me.Dateapointinvodate.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 104)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 16)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Doctor_Name"
        '
        'Cmbxapointinvostatus
        '
        Me.Cmbxapointinvostatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbxapointinvostatus.FormattingEnabled = True
        Me.Cmbxapointinvostatus.Items.AddRange(New Object() {"Booked", "Canceled", "Finished"})
        Me.Cmbxapointinvostatus.Location = New System.Drawing.Point(443, 101)
        Me.Cmbxapointinvostatus.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbxapointinvostatus.Name = "Cmbxapointinvostatus"
        Me.Cmbxapointinvostatus.Size = New System.Drawing.Size(168, 24)
        Me.Cmbxapointinvostatus.TabIndex = 37
        '
        'Cmbxapointinvotime
        '
        Me.Cmbxapointinvotime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbxapointinvotime.FormattingEnabled = True
        Me.Cmbxapointinvotime.Items.AddRange(New Object() {"8:00-8:30 am", "8:30-9:00 am", "9:00-9:30 am", "9:30-10:00 am", "10:00-10:30 am", "10:30- 11:00 am", "11:00-11:30 am", "11:30-12:00 am", "12:00-12:30 pm", "12:30-1:00 pm", "1:00-1:30 pm", "1:30 -2:00 pm", "2:00-2:30 pm", "2:30-3:00 pm", "3:00-3:30 pm", "3:30-4:00 pm", "4:00-4:30 pm", "4:30-5:00 pm", "5:00-5:30 pm", "5:30-6:00 pm", "6:00-6:30 pm", "6:30-7:00 pm", "7:00-7:30 pm", "7:30-8:00 pm", "8:00-8:30 pm", "8:30-9:00 pm", "9:00-9:30 pm", "9:30-10:00 pm", "10:00-10:30 pm", "10:30-11:00 pm", "11:00-11:30 pm", "", ""})
        Me.Cmbxapointinvotime.Location = New System.Drawing.Point(443, 48)
        Me.Cmbxapointinvotime.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbxapointinvotime.Name = "Cmbxapointinvotime"
        Me.Cmbxapointinvotime.Size = New System.Drawing.Size(126, 24)
        Me.Cmbxapointinvotime.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 166)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 16)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Appointment_date"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(695, 406)
        Me.Controls.Add(Me.Panelapinvo)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Form9"
        Me.Text = "Appointment Invoice Form"
        Me.Panel3.ResumeLayout(False)
        Me.Panelapinvo.ResumeLayout(False)
        Me.Panelapinvo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btnclrinvo As Button
    Friend WithEvents Btnbckinvo As Button
    Friend WithEvents Btnprintinvoapoint As Button
    Friend WithEvents Panelapinvo As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cmbxapointinvodocid As ComboBox
    Friend WithEvents Cmbxapointinvoptnid As ComboBox
    Friend WithEvents Cmbxapointinvoreason As ComboBox
    Friend WithEvents Cmbxapointinvostatus As ComboBox
    Friend WithEvents Cmbxapointinvotime As ComboBox
    Friend WithEvents Dateapointinvodate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
