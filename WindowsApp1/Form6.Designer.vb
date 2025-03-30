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
        Me.BtnBillbck = New System.Windows.Forms.Button()
        Me.TxtBxbillid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGenerateInvoice = New System.Windows.Forms.Button()
        Me.Btn_bills_clear = New System.Windows.Forms.Button()
        Me.BtnAddBill = New System.Windows.Forms.Button()
        Me.Cmb_bills_status = New System.Windows.Forms.ComboBox()
        Me.CmbPaymentMode = New System.Windows.Forms.ComboBox()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.TxtTotalAmount = New System.Windows.Forms.TextBox()
        Me.DtpBillDate = New System.Windows.Forms.DateTimePicker()
        Me.Combox_bill_ptnid = New System.Windows.Forms.ComboBox()
        Me.lbl_bills_status = New System.Windows.Forms.Label()
        Me.lbl_paymode = New System.Windows.Forms.Label()
        Me.lbl_totalamt = New System.Windows.Forms.Label()
        Me.lbl_billdate = New System.Windows.Forms.Label()
        Me.lbl_bills_regno = New System.Windows.Forms.Label()
        Me.DgvBillingData = New System.Windows.Forms.DataGridView()
        Me.BtnBillview = New System.Windows.Forms.Button()
        Me.BtnEditRow = New System.Windows.Forms.Button()
        Me.BtnDeleteRow = New System.Windows.Forms.Button()
        Me.panel_billstab.SuspendLayout()
        CType(Me.DgvBillingData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_billstab
        '
        Me.panel_billstab.BackColor = System.Drawing.Color.Transparent
        Me.panel_billstab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_billstab.Controls.Add(Me.BtnBillbck)
        Me.panel_billstab.Controls.Add(Me.TxtBxbillid)
        Me.panel_billstab.Controls.Add(Me.Label1)
        Me.panel_billstab.Controls.Add(Me.BtnGenerateInvoice)
        Me.panel_billstab.Controls.Add(Me.Btn_bills_clear)
        Me.panel_billstab.Controls.Add(Me.BtnAddBill)
        Me.panel_billstab.Controls.Add(Me.Cmb_bills_status)
        Me.panel_billstab.Controls.Add(Me.CmbPaymentMode)
        Me.panel_billstab.Controls.Add(Me.BtnCalculate)
        Me.panel_billstab.Controls.Add(Me.TxtTotalAmount)
        Me.panel_billstab.Controls.Add(Me.DtpBillDate)
        Me.panel_billstab.Controls.Add(Me.Combox_bill_ptnid)
        Me.panel_billstab.Controls.Add(Me.lbl_bills_status)
        Me.panel_billstab.Controls.Add(Me.lbl_paymode)
        Me.panel_billstab.Controls.Add(Me.lbl_totalamt)
        Me.panel_billstab.Controls.Add(Me.lbl_billdate)
        Me.panel_billstab.Controls.Add(Me.lbl_bills_regno)
        Me.panel_billstab.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_billstab.Location = New System.Drawing.Point(9, 9)
        Me.panel_billstab.Margin = New System.Windows.Forms.Padding(2)
        Me.panel_billstab.Name = "panel_billstab"
        Me.panel_billstab.Size = New System.Drawing.Size(862, 297)
        Me.panel_billstab.TabIndex = 1
        '
        'BtnBillbck
        '
        Me.BtnBillbck.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBillbck.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBillbck.Location = New System.Drawing.Point(457, 250)
        Me.BtnBillbck.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBillbck.Name = "BtnBillbck"
        Me.BtnBillbck.Size = New System.Drawing.Size(76, 32)
        Me.BtnBillbck.TabIndex = 27
        Me.BtnBillbck.Text = "Back"
        Me.BtnBillbck.UseVisualStyleBackColor = False
        '
        'TxtBxbillid
        '
        Me.TxtBxbillid.Location = New System.Drawing.Point(123, 25)
        Me.TxtBxbillid.Name = "TxtBxbillid"
        Me.TxtBxbillid.ReadOnly = True
        Me.TxtBxbillid.Size = New System.Drawing.Size(137, 22)
        Me.TxtBxbillid.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Bill ID :"
        '
        'BtnGenerateInvoice
        '
        Me.BtnGenerateInvoice.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGenerateInvoice.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerateInvoice.Location = New System.Drawing.Point(243, 250)
        Me.BtnGenerateInvoice.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGenerateInvoice.Name = "BtnGenerateInvoice"
        Me.BtnGenerateInvoice.Size = New System.Drawing.Size(107, 32)
        Me.BtnGenerateInvoice.TabIndex = 24
        Me.BtnGenerateInvoice.Text = "Generate Invoice"
        Me.BtnGenerateInvoice.UseVisualStyleBackColor = False
        '
        'Btn_bills_clear
        '
        Me.Btn_bills_clear.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_bills_clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_bills_clear.Location = New System.Drawing.Point(542, 250)
        Me.Btn_bills_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_bills_clear.Name = "Btn_bills_clear"
        Me.Btn_bills_clear.Size = New System.Drawing.Size(76, 32)
        Me.Btn_bills_clear.TabIndex = 23
        Me.Btn_bills_clear.Text = "Clear"
        Me.Btn_bills_clear.UseVisualStyleBackColor = False
        '
        'BtnAddBill
        '
        Me.BtnAddBill.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnAddBill.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddBill.Location = New System.Drawing.Point(365, 250)
        Me.BtnAddBill.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddBill.Name = "BtnAddBill"
        Me.BtnAddBill.Size = New System.Drawing.Size(76, 32)
        Me.BtnAddBill.TabIndex = 22
        Me.BtnAddBill.Text = "Add Bill"
        Me.BtnAddBill.UseVisualStyleBackColor = False
        '
        'Cmb_bills_status
        '
        Me.Cmb_bills_status.FormattingEnabled = True
        Me.Cmb_bills_status.Items.AddRange(New Object() {"PAID", "PENDING", "EXEMPTED"})
        Me.Cmb_bills_status.Location = New System.Drawing.Point(591, 94)
        Me.Cmb_bills_status.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmb_bills_status.Name = "Cmb_bills_status"
        Me.Cmb_bills_status.Size = New System.Drawing.Size(169, 23)
        Me.Cmb_bills_status.TabIndex = 21
        '
        'CmbPaymentMode
        '
        Me.CmbPaymentMode.FormattingEnabled = True
        Me.CmbPaymentMode.Items.AddRange(New Object() {"CASH", "CREDIT / DEBIT CARD", "ONLINE PAYMENTS", "INSURANCE"})
        Me.CmbPaymentMode.Location = New System.Drawing.Point(591, 38)
        Me.CmbPaymentMode.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbPaymentMode.Name = "CmbPaymentMode"
        Me.CmbPaymentMode.Size = New System.Drawing.Size(169, 23)
        Me.CmbPaymentMode.TabIndex = 20
        '
        'BtnCalculate
        '
        Me.BtnCalculate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCalculate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.Location = New System.Drawing.Point(447, 176)
        Me.BtnCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(97, 32)
        Me.BtnCalculate.TabIndex = 19
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = False
        '
        'TxtTotalAmount
        '
        Me.TxtTotalAmount.Location = New System.Drawing.Point(261, 183)
        Me.TxtTotalAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalAmount.Name = "TxtTotalAmount"
        Me.TxtTotalAmount.ReadOnly = True
        Me.TxtTotalAmount.Size = New System.Drawing.Size(168, 22)
        Me.TxtTotalAmount.TabIndex = 18
        '
        'DtpBillDate
        '
        Me.DtpBillDate.Location = New System.Drawing.Point(123, 116)
        Me.DtpBillDate.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpBillDate.MaxDate = New Date(2376, 12, 31, 0, 0, 0, 0)
        Me.DtpBillDate.MinDate = New Date(2025, 3, 25, 0, 0, 0, 0)
        Me.DtpBillDate.Name = "DtpBillDate"
        Me.DtpBillDate.Size = New System.Drawing.Size(227, 22)
        Me.DtpBillDate.TabIndex = 8
        Me.DtpBillDate.Value = New Date(2025, 3, 25, 0, 0, 0, 0)
        '
        'Combox_bill_ptnid
        '
        Me.Combox_bill_ptnid.FormattingEnabled = True
        Me.Combox_bill_ptnid.Location = New System.Drawing.Point(123, 64)
        Me.Combox_bill_ptnid.Margin = New System.Windows.Forms.Padding(2)
        Me.Combox_bill_ptnid.Name = "Combox_bill_ptnid"
        Me.Combox_bill_ptnid.Size = New System.Drawing.Size(169, 23)
        Me.Combox_bill_ptnid.TabIndex = 7
        '
        'lbl_bills_status
        '
        Me.lbl_bills_status.AutoSize = True
        Me.lbl_bills_status.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bills_status.Location = New System.Drawing.Point(444, 93)
        Me.lbl_bills_status.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_bills_status.Name = "lbl_bills_status"
        Me.lbl_bills_status.Size = New System.Drawing.Size(56, 19)
        Me.lbl_bills_status.TabIndex = 5
        Me.lbl_bills_status.Text = "Status:"
        '
        'lbl_paymode
        '
        Me.lbl_paymode.AutoSize = True
        Me.lbl_paymode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paymode.Location = New System.Drawing.Point(444, 38)
        Me.lbl_paymode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_paymode.Name = "lbl_paymode"
        Me.lbl_paymode.Size = New System.Drawing.Size(116, 19)
        Me.lbl_paymode.TabIndex = 4
        Me.lbl_paymode.Text = "Payment Mode:"
        '
        'lbl_totalamt
        '
        Me.lbl_totalamt.AutoSize = True
        Me.lbl_totalamt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_totalamt.Location = New System.Drawing.Point(258, 168)
        Me.lbl_totalamt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_totalamt.Name = "lbl_totalamt"
        Me.lbl_totalamt.Size = New System.Drawing.Size(83, 15)
        Me.lbl_totalamt.TabIndex = 3
        Me.lbl_totalamt.Text = "Total Amount:"
        '
        'lbl_billdate
        '
        Me.lbl_billdate.AutoSize = True
        Me.lbl_billdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_billdate.Location = New System.Drawing.Point(17, 116)
        Me.lbl_billdate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_billdate.Name = "lbl_billdate"
        Me.lbl_billdate.Size = New System.Drawing.Size(74, 19)
        Me.lbl_billdate.TabIndex = 2
        Me.lbl_billdate.Text = "Bill Date:"
        '
        'lbl_bills_regno
        '
        Me.lbl_bills_regno.AutoSize = True
        Me.lbl_bills_regno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bills_regno.Location = New System.Drawing.Point(17, 64)
        Me.lbl_bills_regno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_bills_regno.Name = "lbl_bills_regno"
        Me.lbl_bills_regno.Size = New System.Drawing.Size(83, 19)
        Me.lbl_bills_regno.TabIndex = 1
        Me.lbl_bills_regno.Text = "Patient ID:"
        '
        'DgvBillingData
        '
        Me.DgvBillingData.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DgvBillingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBillingData.Location = New System.Drawing.Point(11, 343)
        Me.DgvBillingData.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvBillingData.Name = "DgvBillingData"
        Me.DgvBillingData.RowHeadersWidth = 51
        Me.DgvBillingData.RowTemplate.Height = 24
        Me.DgvBillingData.Size = New System.Drawing.Size(861, 160)
        Me.DgvBillingData.TabIndex = 2
        '
        'BtnBillview
        '
        Me.BtnBillview.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBillview.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBillview.Location = New System.Drawing.Point(629, 310)
        Me.BtnBillview.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBillview.Name = "BtnBillview"
        Me.BtnBillview.Size = New System.Drawing.Size(77, 29)
        Me.BtnBillview.TabIndex = 3
        Me.BtnBillview.Text = "View"
        Me.BtnBillview.UseVisualStyleBackColor = False
        '
        'BtnEditRow
        '
        Me.BtnEditRow.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnEditRow.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditRow.Location = New System.Drawing.Point(711, 310)
        Me.BtnEditRow.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditRow.Name = "BtnEditRow"
        Me.BtnEditRow.Size = New System.Drawing.Size(68, 29)
        Me.BtnEditRow.TabIndex = 4
        Me.BtnEditRow.Text = "Edit_row"
        Me.BtnEditRow.UseVisualStyleBackColor = False
        '
        'BtnDeleteRow
        '
        Me.BtnDeleteRow.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnDeleteRow.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteRow.Location = New System.Drawing.Point(783, 310)
        Me.BtnDeleteRow.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDeleteRow.Name = "BtnDeleteRow"
        Me.BtnDeleteRow.Size = New System.Drawing.Size(85, 29)
        Me.BtnDeleteRow.TabIndex = 5
        Me.BtnDeleteRow.Text = "Delete_row"
        Me.BtnDeleteRow.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.images__7_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(882, 514)
        Me.Controls.Add(Me.BtnDeleteRow)
        Me.Controls.Add(Me.BtnEditRow)
        Me.Controls.Add(Me.BtnBillview)
        Me.Controls.Add(Me.DgvBillingData)
        Me.Controls.Add(Me.panel_billstab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form6"
        Me.Text = "Billing_Form"
        Me.panel_billstab.ResumeLayout(False)
        Me.panel_billstab.PerformLayout()
        CType(Me.DgvBillingData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_billstab As Panel
    Friend WithEvents BtnGenerateInvoice As Button
    Friend WithEvents Btn_bills_clear As Button
    Friend WithEvents BtnAddBill As Button
    Friend WithEvents Cmb_bills_status As ComboBox
    Friend WithEvents CmbPaymentMode As ComboBox
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents TxtTotalAmount As TextBox
    Friend WithEvents DtpBillDate As DateTimePicker
    Friend WithEvents Combox_bill_ptnid As ComboBox
    Friend WithEvents lbl_bills_status As Label
    Friend WithEvents lbl_paymode As Label
    Friend WithEvents lbl_totalamt As Label
    Friend WithEvents lbl_billdate As Label
    Friend WithEvents lbl_bills_regno As Label
    Friend WithEvents DgvBillingData As DataGridView
    Friend WithEvents BtnBillview As Button
    Friend WithEvents BtnEditRow As Button
    Friend WithEvents BtnDeleteRow As Button
    Friend WithEvents TxtBxbillid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBillbck As Button
End Class
