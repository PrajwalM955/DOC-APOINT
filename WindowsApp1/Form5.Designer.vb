<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.panel_assigtab = New System.Windows.Forms.Panel()
        Me.combox_assign_status = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker_assigtab = New System.Windows.Forms.DateTimePicker()
        Me.btn_assign_clear = New System.Windows.Forms.Button()
        Me.btn_assignserv = New System.Windows.Forms.Button()
        Me.combox_assign_mechid = New System.Windows.Forms.ComboBox()
        Me.combox_assign_servid = New System.Windows.Forms.ComboBox()
        Me.combox_assign_regno = New System.Windows.Forms.ComboBox()
        Me.txtbox_servassignid = New System.Windows.Forms.TextBox()
        Me.lbl_servstatus = New System.Windows.Forms.Label()
        Me.lbl_servdate = New System.Windows.Forms.Label()
        Me.lbl_assign_mechanicid = New System.Windows.Forms.Label()
        Me.lbl_assign_serviceid = New System.Windows.Forms.Label()
        Me.lbl_assign_regno = New System.Windows.Forms.Label()
        Me.lbl_servassignid = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.panel_assigtab.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_assigtab
        '
        Me.panel_assigtab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_assigtab.Controls.Add(Me.combox_assign_status)
        Me.panel_assigtab.Controls.Add(Me.DateTimePicker_assigtab)
        Me.panel_assigtab.Controls.Add(Me.btn_assign_clear)
        Me.panel_assigtab.Controls.Add(Me.btn_assignserv)
        Me.panel_assigtab.Controls.Add(Me.combox_assign_mechid)
        Me.panel_assigtab.Controls.Add(Me.combox_assign_servid)
        Me.panel_assigtab.Controls.Add(Me.combox_assign_regno)
        Me.panel_assigtab.Controls.Add(Me.txtbox_servassignid)
        Me.panel_assigtab.Controls.Add(Me.lbl_servstatus)
        Me.panel_assigtab.Controls.Add(Me.lbl_servdate)
        Me.panel_assigtab.Controls.Add(Me.lbl_assign_mechanicid)
        Me.panel_assigtab.Controls.Add(Me.lbl_assign_serviceid)
        Me.panel_assigtab.Controls.Add(Me.lbl_assign_regno)
        Me.panel_assigtab.Controls.Add(Me.lbl_servassignid)
        Me.panel_assigtab.Location = New System.Drawing.Point(26, 26)
        Me.panel_assigtab.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panel_assigtab.Name = "panel_assigtab"
        Me.panel_assigtab.Size = New System.Drawing.Size(887, 278)
        Me.panel_assigtab.TabIndex = 1
        '
        'combox_assign_status
        '
        Me.combox_assign_status.FormattingEnabled = True
        Me.combox_assign_status.Items.AddRange(New Object() {"ASSIGNED", "ONGOING", "PENDING", "COMPLETED"})
        Me.combox_assign_status.Location = New System.Drawing.Point(587, 163)
        Me.combox_assign_status.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.combox_assign_status.Name = "combox_assign_status"
        Me.combox_assign_status.Size = New System.Drawing.Size(168, 21)
        Me.combox_assign_status.TabIndex = 16
        '
        'DateTimePicker_assigtab
        '
        Me.DateTimePicker_assigtab.Checked = False
        Me.DateTimePicker_assigtab.Location = New System.Drawing.Point(587, 72)
        Me.DateTimePicker_assigtab.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker_assigtab.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_assigtab.Name = "DateTimePicker_assigtab"
        Me.DateTimePicker_assigtab.Size = New System.Drawing.Size(168, 20)
        Me.DateTimePicker_assigtab.TabIndex = 1
        Me.DateTimePicker_assigtab.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'btn_assign_clear
        '
        Me.btn_assign_clear.Location = New System.Drawing.Point(759, 226)
        Me.btn_assign_clear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_assign_clear.Name = "btn_assign_clear"
        Me.btn_assign_clear.Size = New System.Drawing.Size(111, 32)
        Me.btn_assign_clear.TabIndex = 15
        Me.btn_assign_clear.Text = "Clear"
        Me.btn_assign_clear.UseVisualStyleBackColor = True
        '
        'btn_assignserv
        '
        Me.btn_assignserv.Location = New System.Drawing.Point(634, 226)
        Me.btn_assignserv.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_assignserv.Name = "btn_assignserv"
        Me.btn_assignserv.Size = New System.Drawing.Size(111, 32)
        Me.btn_assignserv.TabIndex = 14
        Me.btn_assignserv.Text = "Assign Treatment"
        Me.btn_assignserv.UseVisualStyleBackColor = True
        '
        'combox_assign_mechid
        '
        Me.combox_assign_mechid.FormattingEnabled = True
        Me.combox_assign_mechid.Location = New System.Drawing.Point(148, 175)
        Me.combox_assign_mechid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.combox_assign_mechid.Name = "combox_assign_mechid"
        Me.combox_assign_mechid.Size = New System.Drawing.Size(168, 21)
        Me.combox_assign_mechid.TabIndex = 10
        '
        'combox_assign_servid
        '
        Me.combox_assign_servid.FormattingEnabled = True
        Me.combox_assign_servid.Location = New System.Drawing.Point(148, 126)
        Me.combox_assign_servid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.combox_assign_servid.Name = "combox_assign_servid"
        Me.combox_assign_servid.Size = New System.Drawing.Size(168, 21)
        Me.combox_assign_servid.TabIndex = 9
        '
        'combox_assign_regno
        '
        Me.combox_assign_regno.FormattingEnabled = True
        Me.combox_assign_regno.Location = New System.Drawing.Point(148, 74)
        Me.combox_assign_regno.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.combox_assign_regno.Name = "combox_assign_regno"
        Me.combox_assign_regno.Size = New System.Drawing.Size(168, 21)
        Me.combox_assign_regno.TabIndex = 8
        '
        'txtbox_servassignid
        '
        Me.txtbox_servassignid.Location = New System.Drawing.Point(148, 26)
        Me.txtbox_servassignid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbox_servassignid.Name = "txtbox_servassignid"
        Me.txtbox_servassignid.ReadOnly = True
        Me.txtbox_servassignid.Size = New System.Drawing.Size(168, 20)
        Me.txtbox_servassignid.TabIndex = 7
        '
        'lbl_servstatus
        '
        Me.lbl_servstatus.AutoSize = True
        Me.lbl_servstatus.Location = New System.Drawing.Point(482, 163)
        Me.lbl_servstatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_servstatus.Name = "lbl_servstatus"
        Me.lbl_servstatus.Size = New System.Drawing.Size(40, 13)
        Me.lbl_servstatus.TabIndex = 5
        Me.lbl_servstatus.Text = "Status:"
        '
        'lbl_servdate
        '
        Me.lbl_servdate.AutoSize = True
        Me.lbl_servdate.Location = New System.Drawing.Point(482, 76)
        Me.lbl_servdate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_servdate.Name = "lbl_servdate"
        Me.lbl_servdate.Size = New System.Drawing.Size(84, 13)
        Me.lbl_servdate.TabIndex = 4
        Me.lbl_servdate.Text = "Treatment Date:"
        '
        'lbl_assign_mechanicid
        '
        Me.lbl_assign_mechanicid.AutoSize = True
        Me.lbl_assign_mechanicid.Location = New System.Drawing.Point(17, 175)
        Me.lbl_assign_mechanicid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_assign_mechanicid.Name = "lbl_assign_mechanicid"
        Me.lbl_assign_mechanicid.Size = New System.Drawing.Size(56, 13)
        Me.lbl_assign_mechanicid.TabIndex = 3
        Me.lbl_assign_mechanicid.Text = "Doctor ID:"
        '
        'lbl_assign_serviceid
        '
        Me.lbl_assign_serviceid.AutoSize = True
        Me.lbl_assign_serviceid.Location = New System.Drawing.Point(17, 126)
        Me.lbl_assign_serviceid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_assign_serviceid.Name = "lbl_assign_serviceid"
        Me.lbl_assign_serviceid.Size = New System.Drawing.Size(72, 13)
        Me.lbl_assign_serviceid.TabIndex = 2
        Me.lbl_assign_serviceid.Text = "Treatment ID:"
        '
        'lbl_assign_regno
        '
        Me.lbl_assign_regno.AutoSize = True
        Me.lbl_assign_regno.Location = New System.Drawing.Point(17, 76)
        Me.lbl_assign_regno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_assign_regno.Name = "lbl_assign_regno"
        Me.lbl_assign_regno.Size = New System.Drawing.Size(57, 13)
        Me.lbl_assign_regno.TabIndex = 1
        Me.lbl_assign_regno.Text = "Patient ID:"
        '
        'lbl_servassignid
        '
        Me.lbl_servassignid.AutoSize = True
        Me.lbl_servassignid.Location = New System.Drawing.Point(5, 28)
        Me.lbl_servassignid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_servassignid.Name = "lbl_servassignid"
        Me.lbl_servassignid.Size = New System.Drawing.Size(132, 13)
        Me.lbl_servassignid.TabIndex = 0
        Me.lbl_servassignid.Text = "Treatment_Assignment ID:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 344)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(886, 184)
        Me.DataGridView1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(672, 316)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 19)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(752, 316)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 19)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Edit_row"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(826, 316)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 19)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Delete_row"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(919, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(21, 569)
        Me.VScrollBar1.TabIndex = 6
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 569)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.panel_assigtab)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form5"
        Me.Text = "Treatment_assign_Form"
        Me.panel_assigtab.ResumeLayout(False)
        Me.panel_assigtab.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_assigtab As Panel
    Friend WithEvents combox_assign_status As ComboBox
    Friend WithEvents DateTimePicker_assigtab As DateTimePicker
    Friend WithEvents btn_assign_clear As Button
    Friend WithEvents btn_assignserv As Button
    Friend WithEvents combox_assign_mechid As ComboBox
    Friend WithEvents combox_assign_servid As ComboBox
    Friend WithEvents combox_assign_regno As ComboBox
    Friend WithEvents txtbox_servassignid As TextBox
    Friend WithEvents lbl_servstatus As Label
    Friend WithEvents lbl_servdate As Label
    Friend WithEvents lbl_assign_mechanicid As Label
    Friend WithEvents lbl_assign_serviceid As Label
    Friend WithEvents lbl_assign_regno As Label
    Friend WithEvents lbl_servassignid As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
