<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.panel_billstab = New System.Windows.Forms.Panel()
        Me.btn_gen_invoice = New System.Windows.Forms.Button()
        Me.btn_bills_clear = New System.Windows.Forms.Button()
        Me.btn_addbill = New System.Windows.Forms.Button()
        Me.combox_bills_status = New System.Windows.Forms.ComboBox()
        Me.combox_paymode = New System.Windows.Forms.ComboBox()
        Me.btn_totalamt = New System.Windows.Forms.Button()
        Me.txtbox_totalamt = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_billstab = New System.Windows.Forms.DateTimePicker()
        Me.combox_bill_ptnid = New System.Windows.Forms.ComboBox()
        Me.txtbox_billid = New System.Windows.Forms.TextBox()
        Me.lbl_bills_status = New System.Windows.Forms.Label()
        Me.lbl_paymode = New System.Windows.Forms.Label()
        Me.lbl_totalamt = New System.Windows.Forms.Label()
        Me.lbl_billdate = New System.Windows.Forms.Label()
        Me.lbl_bills_regno = New System.Windows.Forms.Label()
        Me.lbl_billid = New System.Windows.Forms.Label()
        Me.Dgv_biiling = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_bill_edit = New System.Windows.Forms.Button()
        Me.Btn_dgv_delete = New System.Windows.Forms.Button()
        Me.panel_billstab.SuspendLayout()
        CType(Me.Dgv_biiling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_billstab
        '
        Me.panel_billstab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_billstab.Controls.Add(Me.btn_gen_invoice)
        Me.panel_billstab.Controls.Add(Me.btn_bills_clear)
        Me.panel_billstab.Controls.Add(Me.btn_addbill)
        Me.panel_billstab.Controls.Add(Me.combox_bills_status)
        Me.panel_billstab.Controls.Add(Me.combox_paymode)
        Me.panel_billstab.Controls.Add(Me.btn_totalamt)
        Me.panel_billstab.Controls.Add(Me.txtbox_totalamt)
        Me.panel_billstab.Controls.Add(Me.DateTimePicker_billstab)
        Me.panel_billstab.Controls.Add(Me.combox_bill_ptnid)
        Me.panel_billstab.Controls.Add(Me.txtbox_billid)
        Me.panel_billstab.Controls.Add(Me.lbl_bills_status)
        Me.panel_billstab.Controls.Add(Me.lbl_paymode)
        Me.panel_billstab.Controls.Add(Me.lbl_totalamt)
        Me.panel_billstab.Controls.Add(Me.lbl_billdate)
        Me.panel_billstab.Controls.Add(Me.lbl_bills_regno)
        Me.panel_billstab.Controls.Add(Me.lbl_billid)
        Me.panel_billstab.Location = New System.Drawing.Point(9, 9)
        Me.panel_billstab.Margin = New System.Windows.Forms.Padding(2)
        Me.panel_billstab.Name = "panel_billstab"
        Me.panel_billstab.Size = New System.Drawing.Size(862, 297)
        Me.panel_billstab.TabIndex = 1
        '
        'btn_gen_invoice
        '
        Me.btn_gen_invoice.Location = New System.Drawing.Point(485, 248)
        Me.btn_gen_invoice.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gen_invoice.Name = "btn_gen_invoice"
        Me.btn_gen_invoice.Size = New System.Drawing.Size(141, 32)
        Me.btn_gen_invoice.TabIndex = 24
        Me.btn_gen_invoice.Text = "Generate Invoice"
        Me.btn_gen_invoice.UseVisualStyleBackColor = True
        '
        'btn_bills_clear
        '
        Me.btn_bills_clear.Location = New System.Drawing.Point(746, 248)
        Me.btn_bills_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_bills_clear.Name = "btn_bills_clear"
        Me.btn_bills_clear.Size = New System.Drawing.Size(111, 32)
        Me.btn_bills_clear.TabIndex = 23
        Me.btn_bills_clear.Text = "Clear"
        Me.btn_bills_clear.UseVisualStyleBackColor = True
        '
        'btn_addbill
        '
        Me.btn_addbill.Location = New System.Drawing.Point(631, 248)
        Me.btn_addbill.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_addbill.Name = "btn_addbill"
        Me.btn_addbill.Size = New System.Drawing.Size(111, 32)
        Me.btn_addbill.TabIndex = 22
        Me.btn_addbill.Text = "Add Bill"
        Me.btn_addbill.UseVisualStyleBackColor = True
        '
        'combox_bills_status
        '
        Me.combox_bills_status.FormattingEnabled = True
        Me.combox_bills_status.Items.AddRange(New Object() {"PAID", "PENDING", "EXEMPTED"})
        Me.combox_bills_status.Location = New System.Drawing.Point(612, 132)
        Me.combox_bills_status.Margin = New System.Windows.Forms.Padding(2)
        Me.combox_bills_status.Name = "combox_bills_status"
        Me.combox_bills_status.Size = New System.Drawing.Size(169, 21)
        Me.combox_bills_status.TabIndex = 21
        '
        'combox_paymode
        '
        Me.combox_paymode.FormattingEnabled = True
        Me.combox_paymode.Items.AddRange(New Object() {"CASH", "CREDIT CARD"})
        Me.combox_paymode.Location = New System.Drawing.Point(605, 54)
        Me.combox_paymode.Margin = New System.Windows.Forms.Padding(2)
        Me.combox_paymode.Name = "combox_paymode"
        Me.combox_paymode.Size = New System.Drawing.Size(169, 21)
        Me.combox_paymode.TabIndex = 20
        '
        'btn_totalamt
        '
        Me.btn_totalamt.Location = New System.Drawing.Point(212, 206)
        Me.btn_totalamt.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_totalamt.Name = "btn_totalamt"
        Me.btn_totalamt.Size = New System.Drawing.Size(153, 32)
        Me.btn_totalamt.TabIndex = 19
        Me.btn_totalamt.Text = "Calculate"
        Me.btn_totalamt.UseVisualStyleBackColor = True
        '
        'txtbox_totalamt
        '
        Me.txtbox_totalamt.Location = New System.Drawing.Point(20, 213)
        Me.txtbox_totalamt.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbox_totalamt.Name = "txtbox_totalamt"
        Me.txtbox_totalamt.ReadOnly = True
        Me.txtbox_totalamt.Size = New System.Drawing.Size(168, 20)
        Me.txtbox_totalamt.TabIndex = 18
        '
        'DateTimePicker_billstab
        '
        Me.DateTimePicker_billstab.Location = New System.Drawing.Point(123, 119)
        Me.DateTimePicker_billstab.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker_billstab.Name = "DateTimePicker_billstab"
        Me.DateTimePicker_billstab.Size = New System.Drawing.Size(169, 20)
        Me.DateTimePicker_billstab.TabIndex = 8
        '
        'combox_bill_ptnid
        '
        Me.combox_bill_ptnid.FormattingEnabled = True
        Me.combox_bill_ptnid.Location = New System.Drawing.Point(123, 73)
        Me.combox_bill_ptnid.Margin = New System.Windows.Forms.Padding(2)
        Me.combox_bill_ptnid.Name = "combox_bill_ptnid"
        Me.combox_bill_ptnid.Size = New System.Drawing.Size(169, 21)
        Me.combox_bill_ptnid.TabIndex = 7
        '
        'txtbox_billid
        '
        Me.txtbox_billid.Location = New System.Drawing.Point(123, 28)
        Me.txtbox_billid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbox_billid.Name = "txtbox_billid"
        Me.txtbox_billid.ReadOnly = True
        Me.txtbox_billid.Size = New System.Drawing.Size(169, 20)
        Me.txtbox_billid.TabIndex = 6
        '
        'lbl_bills_status
        '
        Me.lbl_bills_status.AutoSize = True
        Me.lbl_bills_status.Location = New System.Drawing.Point(471, 124)
        Me.lbl_bills_status.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_bills_status.Name = "lbl_bills_status"
        Me.lbl_bills_status.Size = New System.Drawing.Size(40, 13)
        Me.lbl_bills_status.TabIndex = 5
        Me.lbl_bills_status.Text = "Status:"
        '
        'lbl_paymode
        '
        Me.lbl_paymode.AutoSize = True
        Me.lbl_paymode.Location = New System.Drawing.Point(471, 56)
        Me.lbl_paymode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_paymode.Name = "lbl_paymode"
        Me.lbl_paymode.Size = New System.Drawing.Size(81, 13)
        Me.lbl_paymode.TabIndex = 4
        Me.lbl_paymode.Text = "Payment Mode:"
        '
        'lbl_totalamt
        '
        Me.lbl_totalamt.AutoSize = True
        Me.lbl_totalamt.Location = New System.Drawing.Point(17, 167)
        Me.lbl_totalamt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_totalamt.Name = "lbl_totalamt"
        Me.lbl_totalamt.Size = New System.Drawing.Size(73, 13)
        Me.lbl_totalamt.TabIndex = 3
        Me.lbl_totalamt.Text = "Total Amount:"
        '
        'lbl_billdate
        '
        Me.lbl_billdate.AutoSize = True
        Me.lbl_billdate.Location = New System.Drawing.Point(17, 119)
        Me.lbl_billdate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_billdate.Name = "lbl_billdate"
        Me.lbl_billdate.Size = New System.Drawing.Size(49, 13)
        Me.lbl_billdate.TabIndex = 2
        Me.lbl_billdate.Text = "Bill Date:"
        '
        'lbl_bills_regno
        '
        Me.lbl_bills_regno.AutoSize = True
        Me.lbl_bills_regno.Location = New System.Drawing.Point(17, 73)
        Me.lbl_bills_regno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_bills_regno.Name = "lbl_bills_regno"
        Me.lbl_bills_regno.Size = New System.Drawing.Size(57, 13)
        Me.lbl_bills_regno.TabIndex = 1
        Me.lbl_bills_regno.Text = "Patient ID:"
        '
        'lbl_billid
        '
        Me.lbl_billid.AutoSize = True
        Me.lbl_billid.Location = New System.Drawing.Point(17, 28)
        Me.lbl_billid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_billid.Name = "lbl_billid"
        Me.lbl_billid.Size = New System.Drawing.Size(37, 13)
        Me.lbl_billid.TabIndex = 0
        Me.lbl_billid.Text = "Bill ID:"
        '
        'Dgv_biiling
        '
        Me.Dgv_biiling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_biiling.Location = New System.Drawing.Point(9, 333)
        Me.Dgv_biiling.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgv_biiling.Name = "Dgv_biiling"
        Me.Dgv_biiling.RowHeadersWidth = 51
        Me.Dgv_biiling.RowTemplate.Height = 24
        Me.Dgv_biiling.Size = New System.Drawing.Size(861, 160)
        Me.Dgv_biiling.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(634, 310)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 19)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_bill_edit
        '
        Me.Btn_bill_edit.Location = New System.Drawing.Point(716, 310)
        Me.Btn_bill_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_bill_edit.Name = "Btn_bill_edit"
        Me.Btn_bill_edit.Size = New System.Drawing.Size(68, 19)
        Me.Btn_bill_edit.TabIndex = 4
        Me.Btn_bill_edit.Text = "Edit_row"
        Me.Btn_bill_edit.UseVisualStyleBackColor = True
        '
        'Btn_dgv_delete
        '
        Me.Btn_dgv_delete.Location = New System.Drawing.Point(788, 310)
        Me.Btn_dgv_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_dgv_delete.Name = "Btn_dgv_delete"
        Me.Btn_dgv_delete.Size = New System.Drawing.Size(73, 19)
        Me.Btn_dgv_delete.TabIndex = 5
        Me.Btn_dgv_delete.Text = "Delete_row"
        Me.Btn_dgv_delete.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 514)
        Me.Controls.Add(Me.Btn_dgv_delete)
        Me.Controls.Add(Me.Btn_bill_edit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Dgv_biiling)
        Me.Controls.Add(Me.panel_billstab)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form6"
        Me.Text = "Billing_Form"
        Me.panel_billstab.ResumeLayout(False)
        Me.panel_billstab.PerformLayout()
        CType(Me.Dgv_biiling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_billstab As Panel
    Friend WithEvents btn_gen_invoice As Button
    Friend WithEvents btn_bills_clear As Button
    Friend WithEvents btn_addbill As Button
    Friend WithEvents combox_bills_status As ComboBox
    Friend WithEvents combox_paymode As ComboBox
    Friend WithEvents btn_totalamt As Button
    Friend WithEvents txtbox_totalamt As TextBox
    Friend WithEvents DateTimePicker_billstab As DateTimePicker
    Friend WithEvents combox_bill_ptnid As ComboBox
    Friend WithEvents txtbox_billid As TextBox
    Friend WithEvents lbl_bills_status As Label
    Friend WithEvents lbl_paymode As Label
    Friend WithEvents lbl_totalamt As Label
    Friend WithEvents lbl_billdate As Label
    Friend WithEvents lbl_bills_regno As Label
    Friend WithEvents lbl_billid As Label
    Friend WithEvents Dgv_biiling As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Btn_bill_edit As Button
    Friend WithEvents Btn_dgv_delete As Button
End Class
