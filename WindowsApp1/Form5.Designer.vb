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
        Me.Dgv_trtassing = New System.Windows.Forms.DataGridView()
        Me.Btn_assigntreatmnt_dgv_view = New System.Windows.Forms.Button()
        Me.Btn_assigntreatmnt_edit = New System.Windows.Forms.Button()
        Me.Btn_assigntreatmnt_dgv_delete = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.lbl_assign_regno = New System.Windows.Forms.Label()
        Me.lbl_assign_serviceid = New System.Windows.Forms.Label()
        Me.lbl_assign_mechanicid = New System.Windows.Forms.Label()
        Me.lbl_servdate = New System.Windows.Forms.Label()
        Me.lbl_servstatus = New System.Windows.Forms.Label()
        Me.combox_trtassign_ptnid = New System.Windows.Forms.ComboBox()
        Me.combox_trtassign_trtmnt_id = New System.Windows.Forms.ComboBox()
        Me.combox_trtassign_docid = New System.Windows.Forms.ComboBox()
        Me.btn_assigntreatmnt = New System.Windows.Forms.Button()
        Me.btn_assign_clear = New System.Windows.Forms.Button()
        Me.DateTimePicker_trtassig = New System.Windows.Forms.DateTimePicker()
        Me.combox_trtassign_status = New System.Windows.Forms.ComboBox()
        Me.panel_assigtab = New System.Windows.Forms.Panel()
        CType(Me.Dgv_trtassing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_assigtab.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_trtassing
        '
        Me.Dgv_trtassing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_trtassing.Location = New System.Drawing.Point(26, 344)
        Me.Dgv_trtassing.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgv_trtassing.Name = "Dgv_trtassing"
        Me.Dgv_trtassing.RowHeadersWidth = 51
        Me.Dgv_trtassing.RowTemplate.Height = 24
        Me.Dgv_trtassing.Size = New System.Drawing.Size(886, 184)
        Me.Dgv_trtassing.TabIndex = 2
        '
        'Btn_assigntreatmnt_dgv_view
        '
        Me.Btn_assigntreatmnt_dgv_view.Location = New System.Drawing.Point(672, 316)
        Me.Btn_assigntreatmnt_dgv_view.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_assigntreatmnt_dgv_view.Name = "Btn_assigntreatmnt_dgv_view"
        Me.Btn_assigntreatmnt_dgv_view.Size = New System.Drawing.Size(75, 19)
        Me.Btn_assigntreatmnt_dgv_view.TabIndex = 3
        Me.Btn_assigntreatmnt_dgv_view.Text = "View"
        Me.Btn_assigntreatmnt_dgv_view.UseVisualStyleBackColor = True
        '
        'Btn_assigntreatmnt_edit
        '
        Me.Btn_assigntreatmnt_edit.Location = New System.Drawing.Point(752, 316)
        Me.Btn_assigntreatmnt_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_assigntreatmnt_edit.Name = "Btn_assigntreatmnt_edit"
        Me.Btn_assigntreatmnt_edit.Size = New System.Drawing.Size(70, 19)
        Me.Btn_assigntreatmnt_edit.TabIndex = 4
        Me.Btn_assigntreatmnt_edit.Text = "Edit_row"
        Me.Btn_assigntreatmnt_edit.UseVisualStyleBackColor = True
        '
        'Btn_assigntreatmnt_dgv_delete
        '
        Me.Btn_assigntreatmnt_dgv_delete.Location = New System.Drawing.Point(826, 316)
        Me.Btn_assigntreatmnt_dgv_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_assigntreatmnt_dgv_delete.Name = "Btn_assigntreatmnt_dgv_delete"
        Me.Btn_assigntreatmnt_dgv_delete.Size = New System.Drawing.Size(78, 19)
        Me.Btn_assigntreatmnt_dgv_delete.TabIndex = 5
        Me.Btn_assigntreatmnt_dgv_delete.Text = "Delete_row"
        Me.Btn_assigntreatmnt_dgv_delete.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(919, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(21, 569)
        Me.VScrollBar1.TabIndex = 6
        '
        'lbl_assign_regno
        '
        Me.lbl_assign_regno.AutoSize = True
        Me.lbl_assign_regno.Location = New System.Drawing.Point(16, 32)
        Me.lbl_assign_regno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_assign_regno.Name = "lbl_assign_regno"
        Me.lbl_assign_regno.Size = New System.Drawing.Size(57, 13)
        Me.lbl_assign_regno.TabIndex = 1
        Me.lbl_assign_regno.Text = "Patient ID:"
        '
        'lbl_assign_serviceid
        '
        Me.lbl_assign_serviceid.AutoSize = True
        Me.lbl_assign_serviceid.Location = New System.Drawing.Point(16, 82)
        Me.lbl_assign_serviceid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_assign_serviceid.Name = "lbl_assign_serviceid"
        Me.lbl_assign_serviceid.Size = New System.Drawing.Size(72, 13)
        Me.lbl_assign_serviceid.TabIndex = 2
        Me.lbl_assign_serviceid.Text = "Treatment ID:"
        '
        'lbl_assign_mechanicid
        '
        Me.lbl_assign_mechanicid.AutoSize = True
        Me.lbl_assign_mechanicid.Location = New System.Drawing.Point(16, 131)
        Me.lbl_assign_mechanicid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_assign_mechanicid.Name = "lbl_assign_mechanicid"
        Me.lbl_assign_mechanicid.Size = New System.Drawing.Size(56, 13)
        Me.lbl_assign_mechanicid.TabIndex = 3
        Me.lbl_assign_mechanicid.Text = "Doctor ID:"
        '
        'lbl_servdate
        '
        Me.lbl_servdate.AutoSize = True
        Me.lbl_servdate.Location = New System.Drawing.Point(388, 33)
        Me.lbl_servdate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_servdate.Name = "lbl_servdate"
        Me.lbl_servdate.Size = New System.Drawing.Size(84, 13)
        Me.lbl_servdate.TabIndex = 4
        Me.lbl_servdate.Text = "Treatment Date:"
        '
        'lbl_servstatus
        '
        Me.lbl_servstatus.AutoSize = True
        Me.lbl_servstatus.Location = New System.Drawing.Point(388, 82)
        Me.lbl_servstatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_servstatus.Name = "lbl_servstatus"
        Me.lbl_servstatus.Size = New System.Drawing.Size(40, 13)
        Me.lbl_servstatus.TabIndex = 5
        Me.lbl_servstatus.Text = "Status:"
        '
        'combox_trtassign_ptnid
        '
        Me.combox_trtassign_ptnid.FormattingEnabled = True
        Me.combox_trtassign_ptnid.Location = New System.Drawing.Point(147, 30)
        Me.combox_trtassign_ptnid.Margin = New System.Windows.Forms.Padding(2)
        Me.combox_trtassign_ptnid.Name = "combox_trtassign_ptnid"
        Me.combox_trtassign_ptnid.Size = New System.Drawing.Size(168, 21)
        Me.combox_trtassign_ptnid.TabIndex = 8
        '
        'combox_trtassign_trtmnt_id
        '
        Me.combox_trtassign_trtmnt_id.FormattingEnabled = True
        Me.combox_trtassign_trtmnt_id.Location = New System.Drawing.Point(147, 82)
        Me.combox_trtassign_trtmnt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.combox_trtassign_trtmnt_id.Name = "combox_trtassign_trtmnt_id"
        Me.combox_trtassign_trtmnt_id.Size = New System.Drawing.Size(168, 21)
        Me.combox_trtassign_trtmnt_id.TabIndex = 9
        '
        'combox_trtassign_docid
        '
        Me.combox_trtassign_docid.FormattingEnabled = True
        Me.combox_trtassign_docid.Location = New System.Drawing.Point(147, 131)
        Me.combox_trtassign_docid.Margin = New System.Windows.Forms.Padding(2)
        Me.combox_trtassign_docid.Name = "combox_trtassign_docid"
        Me.combox_trtassign_docid.Size = New System.Drawing.Size(168, 21)
        Me.combox_trtassign_docid.TabIndex = 10
        '
        'btn_assigntreatmnt
        '
        Me.btn_assigntreatmnt.Location = New System.Drawing.Point(634, 226)
        Me.btn_assigntreatmnt.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_assigntreatmnt.Name = "btn_assigntreatmnt"
        Me.btn_assigntreatmnt.Size = New System.Drawing.Size(111, 32)
        Me.btn_assigntreatmnt.TabIndex = 14
        Me.btn_assigntreatmnt.Text = "Assign Treatment"
        Me.btn_assigntreatmnt.UseVisualStyleBackColor = True
        '
        'btn_assign_clear
        '
        Me.btn_assign_clear.Location = New System.Drawing.Point(759, 226)
        Me.btn_assign_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_assign_clear.Name = "btn_assign_clear"
        Me.btn_assign_clear.Size = New System.Drawing.Size(111, 32)
        Me.btn_assign_clear.TabIndex = 15
        Me.btn_assign_clear.Text = "Clear"
        Me.btn_assign_clear.UseVisualStyleBackColor = True
        '
        'DateTimePicker_trtassig
        '
        Me.DateTimePicker_trtassig.Checked = False
        Me.DateTimePicker_trtassig.Location = New System.Drawing.Point(493, 29)
        Me.DateTimePicker_trtassig.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker_trtassig.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_trtassig.Name = "DateTimePicker_trtassig"
        Me.DateTimePicker_trtassig.Size = New System.Drawing.Size(168, 20)
        Me.DateTimePicker_trtassig.TabIndex = 1
        Me.DateTimePicker_trtassig.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'combox_trtassign_status
        '
        Me.combox_trtassign_status.FormattingEnabled = True
        Me.combox_trtassign_status.Items.AddRange(New Object() {"ASSIGNED", "ONGOING", "PENDING", "COMPLETED"})
        Me.combox_trtassign_status.Location = New System.Drawing.Point(493, 82)
        Me.combox_trtassign_status.Margin = New System.Windows.Forms.Padding(2)
        Me.combox_trtassign_status.Name = "combox_trtassign_status"
        Me.combox_trtassign_status.Size = New System.Drawing.Size(168, 21)
        Me.combox_trtassign_status.TabIndex = 16
        '
        'panel_assigtab
        '
        Me.panel_assigtab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_assigtab.Controls.Add(Me.combox_trtassign_status)
        Me.panel_assigtab.Controls.Add(Me.DateTimePicker_trtassig)
        Me.panel_assigtab.Controls.Add(Me.btn_assign_clear)
        Me.panel_assigtab.Controls.Add(Me.btn_assigntreatmnt)
        Me.panel_assigtab.Controls.Add(Me.combox_trtassign_docid)
        Me.panel_assigtab.Controls.Add(Me.combox_trtassign_trtmnt_id)
        Me.panel_assigtab.Controls.Add(Me.combox_trtassign_ptnid)
        Me.panel_assigtab.Controls.Add(Me.lbl_servstatus)
        Me.panel_assigtab.Controls.Add(Me.lbl_servdate)
        Me.panel_assigtab.Controls.Add(Me.lbl_assign_mechanicid)
        Me.panel_assigtab.Controls.Add(Me.lbl_assign_serviceid)
        Me.panel_assigtab.Controls.Add(Me.lbl_assign_regno)
        Me.panel_assigtab.Location = New System.Drawing.Point(26, 26)
        Me.panel_assigtab.Margin = New System.Windows.Forms.Padding(2)
        Me.panel_assigtab.Name = "panel_assigtab"
        Me.panel_assigtab.Size = New System.Drawing.Size(887, 278)
        Me.panel_assigtab.TabIndex = 1
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 569)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Btn_assigntreatmnt_dgv_delete)
        Me.Controls.Add(Me.Btn_assigntreatmnt_edit)
        Me.Controls.Add(Me.Btn_assigntreatmnt_dgv_view)
        Me.Controls.Add(Me.Dgv_trtassing)
        Me.Controls.Add(Me.panel_assigtab)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form5"
        Me.Text = "Treatment_assign_Form"
        CType(Me.Dgv_trtassing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_assigtab.ResumeLayout(False)
        Me.panel_assigtab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgv_trtassing As DataGridView
    Friend WithEvents Btn_assigntreatmnt_dgv_view As Button
    Friend WithEvents Btn_assigntreatmnt_edit As Button
    Friend WithEvents Btn_assigntreatmnt_dgv_delete As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents lbl_assign_regno As Label
    Friend WithEvents lbl_assign_serviceid As Label
    Friend WithEvents lbl_assign_mechanicid As Label
    Friend WithEvents lbl_servdate As Label
    Friend WithEvents lbl_servstatus As Label
    Friend WithEvents combox_trtassign_ptnid As ComboBox
    Friend WithEvents combox_trtassign_trtmnt_id As ComboBox
    Friend WithEvents combox_trtassign_docid As ComboBox
    Friend WithEvents btn_assigntreatmnt As Button
    Friend WithEvents btn_assign_clear As Button
    Friend WithEvents DateTimePicker_trtassig As DateTimePicker
    Friend WithEvents combox_trtassign_status As ComboBox
    Friend WithEvents panel_assigtab As Panel
End Class
