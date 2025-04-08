<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Treatment_Assign_Form
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
        Me.DgvAssignments = New System.Windows.Forms.DataGridView()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.lbl_assign_serviceid = New System.Windows.Forms.Label()
        Me.lbl_servdate = New System.Windows.Forms.Label()
        Me.CmbPatientID = New System.Windows.Forms.ComboBox()
        Me.CmbDoctorID = New System.Windows.Forms.ComboBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.DtpTreatmentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cmbstatus = New System.Windows.Forms.ComboBox()
        Me.CmbTreatmentID = New System.Windows.Forms.ComboBox()
        Me.TxtTreatmentCost = New System.Windows.Forms.TextBox()
        Me.BtnCalculatetrtcost = New System.Windows.Forms.Button()
        Me.panel_assigtab = New System.Windows.Forms.Panel()
        Me.TxtBxtrtagnid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtntrtassignBck = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DgvAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_assigtab.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvAssignments
        '
        Me.DgvAssignments.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAssignments.Location = New System.Drawing.Point(40, 479)
        Me.DgvAssignments.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvAssignments.Name = "DgvAssignments"
        Me.DgvAssignments.RowHeadersWidth = 51
        Me.DgvAssignments.RowTemplate.Height = 24
        Me.DgvAssignments.Size = New System.Drawing.Size(895, 164)
        Me.DgvAssignments.TabIndex = 2
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(658, 442)
        Me.BtnView.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 24)
        Me.BtnView.TabIndex = 3
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(752, 442)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(70, 24)
        Me.BtnEdit.TabIndex = 4
        Me.BtnEdit.Text = "Edit Row"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(849, 442)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 24)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Delete Row"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'lbl_assign_serviceid
        '
        Me.lbl_assign_serviceid.AutoSize = True
        Me.lbl_assign_serviceid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_assign_serviceid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_assign_serviceid.Location = New System.Drawing.Point(480, 77)
        Me.lbl_assign_serviceid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_assign_serviceid.Name = "lbl_assign_serviceid"
        Me.lbl_assign_serviceid.Size = New System.Drawing.Size(109, 19)
        Me.lbl_assign_serviceid.TabIndex = 2
        Me.lbl_assign_serviceid.Text = "Treatment ID :"
        '
        'lbl_servdate
        '
        Me.lbl_servdate.AutoSize = True
        Me.lbl_servdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_servdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_servdate.Location = New System.Drawing.Point(36, 139)
        Me.lbl_servdate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_servdate.Name = "lbl_servdate"
        Me.lbl_servdate.Size = New System.Drawing.Size(120, 19)
        Me.lbl_servdate.TabIndex = 4
        Me.lbl_servdate.Text = "Treatment Date:"
        '
        'CmbPatientID
        '
        Me.CmbPatientID.FormattingEnabled = True
        Me.CmbPatientID.Location = New System.Drawing.Point(223, 60)
        Me.CmbPatientID.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbPatientID.Name = "CmbPatientID"
        Me.CmbPatientID.Size = New System.Drawing.Size(168, 21)
        Me.CmbPatientID.TabIndex = 8
        '
        'CmbDoctorID
        '
        Me.CmbDoctorID.FormattingEnabled = True
        Me.CmbDoctorID.Location = New System.Drawing.Point(224, 98)
        Me.CmbDoctorID.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbDoctorID.Name = "CmbDoctorID"
        Me.CmbDoctorID.Size = New System.Drawing.Size(168, 21)
        Me.CmbDoctorID.TabIndex = 10
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSubmit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(306, 222)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(85, 32)
        Me.BtnSubmit.TabIndex = 14
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(423, 222)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(89, 32)
        Me.BtnClear.TabIndex = 15
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'DtpTreatmentDate
        '
        Me.DtpTreatmentDate.Checked = False
        Me.DtpTreatmentDate.Location = New System.Drawing.Point(224, 139)
        Me.DtpTreatmentDate.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpTreatmentDate.MinDate = New Date(2025, 3, 20, 0, 0, 0, 0)
        Me.DtpTreatmentDate.Name = "DtpTreatmentDate"
        Me.DtpTreatmentDate.Size = New System.Drawing.Size(168, 20)
        Me.DtpTreatmentDate.TabIndex = 1
        Me.DtpTreatmentDate.Value = New Date(2025, 3, 20, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Patiet ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Doctor ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(480, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Status :"
        '
        'Cmbstatus
        '
        Me.Cmbstatus.FormattingEnabled = True
        Me.Cmbstatus.Items.AddRange(New Object() {"Ongoing ", "completed", "Assigned"})
        Me.Cmbstatus.Location = New System.Drawing.Point(617, 30)
        Me.Cmbstatus.Name = "Cmbstatus"
        Me.Cmbstatus.Size = New System.Drawing.Size(137, 21)
        Me.Cmbstatus.TabIndex = 24
        '
        'CmbTreatmentID
        '
        Me.CmbTreatmentID.FormattingEnabled = True
        Me.CmbTreatmentID.Location = New System.Drawing.Point(617, 69)
        Me.CmbTreatmentID.Name = "CmbTreatmentID"
        Me.CmbTreatmentID.Size = New System.Drawing.Size(168, 21)
        Me.CmbTreatmentID.TabIndex = 25
        '
        'TxtTreatmentCost
        '
        Me.TxtTreatmentCost.Location = New System.Drawing.Point(685, 133)
        Me.TxtTreatmentCost.Name = "TxtTreatmentCost"
        Me.TxtTreatmentCost.Size = New System.Drawing.Size(175, 20)
        Me.TxtTreatmentCost.TabIndex = 27
        '
        'BtnCalculatetrtcost
        '
        Me.BtnCalculatetrtcost.BackColor = System.Drawing.Color.Transparent
        Me.BtnCalculatetrtcost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCalculatetrtcost.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculatetrtcost.Location = New System.Drawing.Point(455, 133)
        Me.BtnCalculatetrtcost.Name = "BtnCalculatetrtcost"
        Me.BtnCalculatetrtcost.Size = New System.Drawing.Size(209, 23)
        Me.BtnCalculatetrtcost.TabIndex = 28
        Me.BtnCalculatetrtcost.Text = """ Click here for Treatment cost """
        Me.BtnCalculatetrtcost.UseVisualStyleBackColor = False
        '
        'panel_assigtab
        '
        Me.panel_assigtab.BackColor = System.Drawing.Color.Transparent
        Me.panel_assigtab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_assigtab.Controls.Add(Me.TxtBxtrtagnid)
        Me.panel_assigtab.Controls.Add(Me.Label4)
        Me.panel_assigtab.Controls.Add(Me.BtntrtassignBck)
        Me.panel_assigtab.Controls.Add(Me.BtnCalculatetrtcost)
        Me.panel_assigtab.Controls.Add(Me.TxtTreatmentCost)
        Me.panel_assigtab.Controls.Add(Me.CmbTreatmentID)
        Me.panel_assigtab.Controls.Add(Me.Cmbstatus)
        Me.panel_assigtab.Controls.Add(Me.Label3)
        Me.panel_assigtab.Controls.Add(Me.Label2)
        Me.panel_assigtab.Controls.Add(Me.Label1)
        Me.panel_assigtab.Controls.Add(Me.DtpTreatmentDate)
        Me.panel_assigtab.Controls.Add(Me.BtnClear)
        Me.panel_assigtab.Controls.Add(Me.BtnSubmit)
        Me.panel_assigtab.Controls.Add(Me.CmbDoctorID)
        Me.panel_assigtab.Controls.Add(Me.CmbPatientID)
        Me.panel_assigtab.Controls.Add(Me.lbl_servdate)
        Me.panel_assigtab.Controls.Add(Me.lbl_assign_serviceid)
        Me.panel_assigtab.Location = New System.Drawing.Point(40, 147)
        Me.panel_assigtab.Margin = New System.Windows.Forms.Padding(2)
        Me.panel_assigtab.Name = "panel_assigtab"
        Me.panel_assigtab.Size = New System.Drawing.Size(895, 267)
        Me.panel_assigtab.TabIndex = 1
        '
        'TxtBxtrtagnid
        '
        Me.TxtBxtrtagnid.Location = New System.Drawing.Point(224, 23)
        Me.TxtBxtrtagnid.Name = "TxtBxtrtagnid"
        Me.TxtBxtrtagnid.ReadOnly = True
        Me.TxtBxtrtagnid.Size = New System.Drawing.Size(127, 20)
        Me.TxtBxtrtagnid.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 19)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Treatment_assign ID :"
        '
        'BtntrtassignBck
        '
        Me.BtntrtassignBck.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtntrtassignBck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtntrtassignBck.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtntrtassignBck.Location = New System.Drawing.Point(539, 222)
        Me.BtntrtassignBck.Margin = New System.Windows.Forms.Padding(2)
        Me.BtntrtassignBck.Name = "BtntrtassignBck"
        Me.BtntrtassignBck.Size = New System.Drawing.Size(89, 32)
        Me.BtntrtassignBck.TabIndex = 29
        Me.BtntrtassignBck.Text = "Back"
        Me.BtntrtassignBck.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.nnnn
        Me.PictureBox2.Location = New System.Drawing.Point(726, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(209, 86)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'Treatment_Assign_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.gg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(968, 664)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.DgvAssignments)
        Me.Controls.Add(Me.panel_assigtab)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Treatment_Assign_Form"
        Me.Text = "Treatment_assign_Form"
        CType(Me.DgvAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_assigtab.ResumeLayout(False)
        Me.panel_assigtab.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvAssignments As DataGridView
    Friend WithEvents BtnView As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents lbl_assign_serviceid As Label
    Friend WithEvents lbl_servdate As Label
    Friend WithEvents CmbPatientID As ComboBox
    Friend WithEvents CmbDoctorID As ComboBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents DtpTreatmentDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Cmbstatus As ComboBox
    Friend WithEvents CmbTreatmentID As ComboBox
    Friend WithEvents TxtTreatmentCost As TextBox
    Friend WithEvents BtnCalculatetrtcost As Button
    Friend WithEvents panel_assigtab As Panel
    Friend WithEvents BtntrtassignBck As Button
    Friend WithEvents TxtBxtrtagnid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
