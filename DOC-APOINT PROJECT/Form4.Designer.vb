﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel_apoint = New System.Windows.Forms.Panel()
        Me.TxtBxapointid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnappntbck = New System.Windows.Forms.Button()
        Me.Cmbxapoitdocid = New System.Windows.Forms.ComboBox()
        Me.Cmbxapointptnid = New System.Windows.Forms.ComboBox()
        Me.Cmbxapointreason = New System.Windows.Forms.ComboBox()
        Me.BtnIssueTicket = New System.Windows.Forms.Button()
        Me.Cmbxapoitstatus = New System.Windows.Forms.ComboBox()
        Me.Btnapointclr = New System.Windows.Forms.Button()
        Me.Cmbxapointtime = New System.Windows.Forms.ComboBox()
        Me.Dateapointdate = New System.Windows.Forms.DateTimePicker()
        Me.Btnappoint = New System.Windows.Forms.Button()
        Me.Dgvappoint = New System.Windows.Forms.DataGridView()
        Me.Btnapointview = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Btnapntedit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_apoint.SuspendLayout()
        CType(Me.Dgvappoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patient Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Doctor Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 167)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Appointment Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(483, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(483, 70)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(483, 132)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Reason"
        '
        'Panel_apoint
        '
        Me.Panel_apoint.BackColor = System.Drawing.Color.Transparent
        Me.Panel_apoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_apoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_apoint.Controls.Add(Me.TxtBxapointid)
        Me.Panel_apoint.Controls.Add(Me.Label1)
        Me.Panel_apoint.Controls.Add(Me.Btnappntbck)
        Me.Panel_apoint.Controls.Add(Me.Cmbxapoitdocid)
        Me.Panel_apoint.Controls.Add(Me.Cmbxapointptnid)
        Me.Panel_apoint.Controls.Add(Me.Cmbxapointreason)
        Me.Panel_apoint.Controls.Add(Me.BtnIssueTicket)
        Me.Panel_apoint.Controls.Add(Me.Cmbxapoitstatus)
        Me.Panel_apoint.Controls.Add(Me.Btnapointclr)
        Me.Panel_apoint.Controls.Add(Me.Cmbxapointtime)
        Me.Panel_apoint.Controls.Add(Me.Dateapointdate)
        Me.Panel_apoint.Controls.Add(Me.Btnappoint)
        Me.Panel_apoint.Controls.Add(Me.Label6)
        Me.Panel_apoint.Controls.Add(Me.Label7)
        Me.Panel_apoint.Controls.Add(Me.Label8)
        Me.Panel_apoint.Controls.Add(Me.Label2)
        Me.Panel_apoint.Controls.Add(Me.Label4)
        Me.Panel_apoint.Controls.Add(Me.Label5)
        Me.Panel_apoint.Location = New System.Drawing.Point(24, 135)
        Me.Panel_apoint.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_apoint.Name = "Panel_apoint"
        Me.Panel_apoint.Size = New System.Drawing.Size(873, 297)
        Me.Panel_apoint.TabIndex = 8
        '
        'TxtBxapointid
        '
        Me.TxtBxapointid.Location = New System.Drawing.Point(209, 13)
        Me.TxtBxapointid.Name = "TxtBxapointid"
        Me.TxtBxapointid.ReadOnly = True
        Me.TxtBxapointid.Size = New System.Drawing.Size(137, 20)
        Me.TxtBxapointid.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Appointment ID"
        '
        'Btnappntbck
        '
        Me.Btnappntbck.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Btnappntbck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnappntbck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnappntbck.Location = New System.Drawing.Point(557, 256)
        Me.Btnappntbck.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnappntbck.Name = "Btnappntbck"
        Me.Btnappntbck.Size = New System.Drawing.Size(74, 26)
        Me.Btnappntbck.TabIndex = 25
        Me.Btnappntbck.Text = "Back"
        Me.Btnappntbck.UseVisualStyleBackColor = False
        '
        'Cmbxapoitdocid
        '
        Me.Cmbxapoitdocid.FormattingEnabled = True
        Me.Cmbxapoitdocid.Location = New System.Drawing.Point(209, 105)
        Me.Cmbxapoitdocid.Name = "Cmbxapoitdocid"
        Me.Cmbxapoitdocid.Size = New System.Drawing.Size(139, 21)
        Me.Cmbxapoitdocid.TabIndex = 20
        '
        'Cmbxapointptnid
        '
        Me.Cmbxapointptnid.FormattingEnabled = True
        Me.Cmbxapointptnid.Location = New System.Drawing.Point(209, 62)
        Me.Cmbxapointptnid.Name = "Cmbxapointptnid"
        Me.Cmbxapointptnid.Size = New System.Drawing.Size(139, 21)
        Me.Cmbxapointptnid.TabIndex = 19
        '
        'Cmbxapointreason
        '
        Me.Cmbxapointreason.FormattingEnabled = True
        Me.Cmbxapointreason.Items.AddRange(New Object() {"General Consultancy", "Follow-up Consultancy", "Specialized Consultancy", "Diagnostic Tests"})
        Me.Cmbxapointreason.Location = New System.Drawing.Point(608, 127)
        Me.Cmbxapointreason.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbxapointreason.Name = "Cmbxapointreason"
        Me.Cmbxapointreason.Size = New System.Drawing.Size(167, 21)
        Me.Cmbxapointreason.TabIndex = 18
        '
        'BtnIssueTicket
        '
        Me.BtnIssueTicket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnIssueTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIssueTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIssueTicket.Location = New System.Drawing.Point(271, 256)
        Me.BtnIssueTicket.Name = "BtnIssueTicket"
        Me.BtnIssueTicket.Size = New System.Drawing.Size(75, 26)
        Me.BtnIssueTicket.TabIndex = 23
        Me.BtnIssueTicket.Text = "Print Appointment"
        Me.BtnIssueTicket.UseVisualStyleBackColor = False
        '
        'Cmbxapoitstatus
        '
        Me.Cmbxapoitstatus.FormattingEnabled = True
        Me.Cmbxapoitstatus.Items.AddRange(New Object() {"Booked", "Canceled", "Finished"})
        Me.Cmbxapoitstatus.Location = New System.Drawing.Point(608, 68)
        Me.Cmbxapoitstatus.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbxapoitstatus.Name = "Cmbxapoitstatus"
        Me.Cmbxapoitstatus.Size = New System.Drawing.Size(167, 21)
        Me.Cmbxapoitstatus.TabIndex = 15
        '
        'Btnapointclr
        '
        Me.Btnapointclr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Btnapointclr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnapointclr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnapointclr.Location = New System.Drawing.Point(459, 256)
        Me.Btnapointclr.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnapointclr.Name = "Btnapointclr"
        Me.Btnapointclr.Size = New System.Drawing.Size(84, 26)
        Me.Btnapointclr.TabIndex = 17
        Me.Btnapointclr.Text = "Clear"
        Me.Btnapointclr.UseVisualStyleBackColor = False
        '
        'Cmbxapointtime
        '
        Me.Cmbxapointtime.FormattingEnabled = True
        Me.Cmbxapointtime.Items.AddRange(New Object() {"8:00-8:30 am", "8:30-9:00 am", "9:00-9:30 am", "9:30-10:00 am", "10:00-10:30 am", "10:30- 11:00 am", "11:00-11:30 am", "11:30-12:00 am", "12:00-12:30 pm", "12:30-1:00 pm", "1:00-1:30 pm", "1:30 -2:00 pm", "2:00-2:30 pm", "2:30-3:00 pm", "3:00-3:30 pm", "3:30-4:00 pm", "4:00-4:30 pm", "4:30-5:00 pm", "5:00-5:30 pm", "5:30-6:00 pm", "6:00-6:30 pm", "6:30-7:00 pm", "7:00-7:30 pm", "7:30-8:00 pm", "8:00-8:30 pm", "8:30-9:00 pm", "9:00-9:30 pm", "9:30-10:00 pm", "10:00-10:30 pm", "10:30-11:00 pm", "11:00-11:30 pm", "", ""})
        Me.Cmbxapointtime.Location = New System.Drawing.Point(608, 15)
        Me.Cmbxapointtime.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbxapointtime.Name = "Cmbxapointtime"
        Me.Cmbxapointtime.Size = New System.Drawing.Size(167, 21)
        Me.Cmbxapointtime.TabIndex = 14
        '
        'Dateapointdate
        '
        Me.Dateapointdate.Location = New System.Drawing.Point(209, 164)
        Me.Dateapointdate.Margin = New System.Windows.Forms.Padding(2)
        Me.Dateapointdate.MinDate = New Date(2025, 2, 23, 0, 0, 0, 0)
        Me.Dateapointdate.Name = "Dateapointdate"
        Me.Dateapointdate.Size = New System.Drawing.Size(198, 20)
        Me.Dateapointdate.TabIndex = 13
        '
        'Btnappoint
        '
        Me.Btnappoint.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Btnappoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnappoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnappoint.Location = New System.Drawing.Point(366, 256)
        Me.Btnappoint.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnappoint.Name = "Btnappoint"
        Me.Btnappoint.Size = New System.Drawing.Size(80, 26)
        Me.Btnappoint.TabIndex = 16
        Me.Btnappoint.Text = "Appoint"
        Me.Btnappoint.UseVisualStyleBackColor = False
        '
        'Dgvappoint
        '
        Me.Dgvappoint.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Dgvappoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvappoint.Location = New System.Drawing.Point(22, 475)
        Me.Dgvappoint.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgvappoint.Name = "Dgvappoint"
        Me.Dgvappoint.RowHeadersWidth = 51
        Me.Dgvappoint.RowTemplate.Height = 24
        Me.Dgvappoint.Size = New System.Drawing.Size(882, 156)
        Me.Dgvappoint.TabIndex = 9
        '
        'Btnapointview
        '
        Me.Btnapointview.BackColor = System.Drawing.Color.White
        Me.Btnapointview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnapointview.Location = New System.Drawing.Point(628, 437)
        Me.Btnapointview.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnapointview.Name = "Btnapointview"
        Me.Btnapointview.Size = New System.Drawing.Size(84, 34)
        Me.Btnapointview.TabIndex = 10
        Me.Btnapointview.Text = "View"
        Me.Btnapointview.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.White
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(804, 436)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(73, 34)
        Me.BtnDelete.TabIndex = 24
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Btnapntedit
        '
        Me.Btnapntedit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnapntedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnapntedit.Location = New System.Drawing.Point(717, 437)
        Me.Btnapntedit.Name = "Btnapntedit"
        Me.Btnapntedit.Size = New System.Drawing.Size(84, 33)
        Me.Btnapntedit.TabIndex = 25
        Me.Btnapntedit.Text = "Edit"
        Me.Btnapntedit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.nnnn
        Me.PictureBox1.Location = New System.Drawing.Point(702, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.gg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(928, 650)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btnapntedit)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Btnapointview)
        Me.Controls.Add(Me.Dgvappoint)
        Me.Controls.Add(Me.Panel_apoint)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form4"
        Me.Text = "Appointment_Form"
        Me.Panel_apoint.ResumeLayout(False)
        Me.Panel_apoint.PerformLayout()
        CType(Me.Dgvappoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel_apoint As Panel
    Friend WithEvents Cmbxapoitstatus As ComboBox
    Friend WithEvents Cmbxapointtime As ComboBox
    Friend WithEvents Dateapointdate As DateTimePicker
    Friend WithEvents Btnapointclr As Button
    Friend WithEvents Btnappoint As Button
    Friend WithEvents Dgvappoint As DataGridView
    Friend WithEvents Btnapointview As Button
    Friend WithEvents Cmbxapointreason As ComboBox
    Friend WithEvents Cmbxapoitdocid As ComboBox
    Friend WithEvents Cmbxapointptnid As ComboBox
    Friend WithEvents BtnIssueTicket As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Btnappntbck As Button
    Friend WithEvents Btnapntedit As Button
    Friend WithEvents TxtBxapointid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
