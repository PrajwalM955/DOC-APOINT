<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoiceform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoiceform))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btnclrinvo = New System.Windows.Forms.Button()
        Me.Btnbckinvo = New System.Windows.Forms.Button()
        Me.Buttonprintinvo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxptncallno = New System.Windows.Forms.TextBox()
        Me.TextBoxptnaddress = New System.Windows.Forms.TextBox()
        Me.TextBoxptngen = New System.Windows.Forms.TextBox()
        Me.TextBoxptdob = New System.Windows.Forms.TextBox()
        Me.TextBoxptname = New System.Windows.Forms.TextBox()
        Me.CmbWardno = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dtpbillinvo = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxstatus = New System.Windows.Forms.TextBox()
        Me.TextBoxpaymod = New System.Windows.Forms.TextBox()
        Me.TextBoxamtinvo = New System.Windows.Forms.TextBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.lbl_paymode = New System.Windows.Forms.Label()
        Me.lbl_totalamt = New System.Windows.Forms.Label()
        Me.lbl_billdate = New System.Windows.Forms.Label()
        Me.lbl_billid = New System.Windows.Forms.Label()
        Me.Cmbbillid = New System.Windows.Forms.ComboBox()
        Me.grpbox_servdetails = New System.Windows.Forms.GroupBox()
        Me.Dgvinvo = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpbox_servdetails.SuspendLayout()
        CType(Me.Dgvinvo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Btnclrinvo)
        Me.Panel3.Controls.Add(Me.Btnbckinvo)
        Me.Panel3.Controls.Add(Me.Buttonprintinvo)
        Me.Panel3.Location = New System.Drawing.Point(358, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(251, 40)
        Me.Panel3.TabIndex = 2
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
        'Buttonprintinvo
        '
        Me.Buttonprintinvo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonprintinvo.Location = New System.Drawing.Point(29, 12)
        Me.Buttonprintinvo.Name = "Buttonprintinvo"
        Me.Buttonprintinvo.Size = New System.Drawing.Size(67, 23)
        Me.Buttonprintinvo.TabIndex = 1
        Me.Buttonprintinvo.Text = "Print"
        Me.Buttonprintinvo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxptncallno)
        Me.GroupBox1.Controls.Add(Me.TextBoxptnaddress)
        Me.GroupBox1.Controls.Add(Me.TextBoxptngen)
        Me.GroupBox1.Controls.Add(Me.TextBoxptdob)
        Me.GroupBox1.Controls.Add(Me.TextBoxptname)
        Me.GroupBox1.Controls.Add(Me.CmbWardno)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 222)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ward Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Ward number"
        '
        'TextBoxptncallno
        '
        Me.TextBoxptncallno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxptncallno.Location = New System.Drawing.Point(371, 84)
        Me.TextBoxptncallno.Name = "TextBoxptncallno"
        Me.TextBoxptncallno.ReadOnly = True
        Me.TextBoxptncallno.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxptncallno.TabIndex = 27
        '
        'TextBoxptnaddress
        '
        Me.TextBoxptnaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxptnaddress.Location = New System.Drawing.Point(371, 154)
        Me.TextBoxptnaddress.Multiline = True
        Me.TextBoxptnaddress.Name = "TextBoxptnaddress"
        Me.TextBoxptnaddress.ReadOnly = True
        Me.TextBoxptnaddress.Size = New System.Drawing.Size(180, 50)
        Me.TextBoxptnaddress.TabIndex = 26
        '
        'TextBoxptngen
        '
        Me.TextBoxptngen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxptngen.Location = New System.Drawing.Point(149, 186)
        Me.TextBoxptngen.Name = "TextBoxptngen"
        Me.TextBoxptngen.ReadOnly = True
        Me.TextBoxptngen.Size = New System.Drawing.Size(135, 20)
        Me.TextBoxptngen.TabIndex = 25
        '
        'TextBoxptdob
        '
        Me.TextBoxptdob.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxptdob.Location = New System.Drawing.Point(150, 139)
        Me.TextBoxptdob.Name = "TextBoxptdob"
        Me.TextBoxptdob.ReadOnly = True
        Me.TextBoxptdob.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxptdob.TabIndex = 24
        '
        'TextBoxptname
        '
        Me.TextBoxptname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxptname.Location = New System.Drawing.Point(150, 94)
        Me.TextBoxptname.Name = "TextBoxptname"
        Me.TextBoxptname.ReadOnly = True
        Me.TextBoxptname.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxptname.TabIndex = 23
        '
        'CmbWardno
        '
        Me.CmbWardno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbWardno.FormattingEnabled = True
        Me.CmbWardno.Location = New System.Drawing.Point(149, 51)
        Me.CmbWardno.Name = "CmbWardno"
        Me.CmbWardno.Size = New System.Drawing.Size(92, 21)
        Me.CmbWardno.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(341, 118)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(341, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Contact No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 186)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 138)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Birth_Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Patient Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dtpbillinvo)
        Me.GroupBox2.Controls.Add(Me.TextBoxstatus)
        Me.GroupBox2.Controls.Add(Me.TextBoxpaymod)
        Me.GroupBox2.Controls.Add(Me.TextBoxamtinvo)
        Me.GroupBox2.Controls.Add(Me.lbl_status)
        Me.GroupBox2.Controls.Add(Me.lbl_paymode)
        Me.GroupBox2.Controls.Add(Me.lbl_totalamt)
        Me.GroupBox2.Controls.Add(Me.lbl_billdate)
        Me.GroupBox2.Controls.Add(Me.lbl_billid)
        Me.GroupBox2.Controls.Add(Me.Cmbbillid)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 222)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bill Details"
        '
        'Dtpbillinvo
        '
        Me.Dtpbillinvo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtpbillinvo.Location = New System.Drawing.Point(148, 107)
        Me.Dtpbillinvo.MaxDate = New Date(2085, 12, 31, 0, 0, 0, 0)
        Me.Dtpbillinvo.MinDate = New Date(2025, 3, 25, 0, 0, 0, 0)
        Me.Dtpbillinvo.Name = "Dtpbillinvo"
        Me.Dtpbillinvo.Size = New System.Drawing.Size(148, 20)
        Me.Dtpbillinvo.TabIndex = 32
        Me.Dtpbillinvo.Value = New Date(2025, 3, 25, 0, 0, 0, 0)
        '
        'TextBoxstatus
        '
        Me.TextBoxstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxstatus.Location = New System.Drawing.Point(372, 159)
        Me.TextBoxstatus.Name = "TextBoxstatus"
        Me.TextBoxstatus.ReadOnly = True
        Me.TextBoxstatus.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxstatus.TabIndex = 31
        '
        'TextBoxpaymod
        '
        Me.TextBoxpaymod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxpaymod.Location = New System.Drawing.Point(372, 87)
        Me.TextBoxpaymod.Name = "TextBoxpaymod"
        Me.TextBoxpaymod.ReadOnly = True
        Me.TextBoxpaymod.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxpaymod.TabIndex = 30
        '
        'TextBoxamtinvo
        '
        Me.TextBoxamtinvo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxamtinvo.Location = New System.Drawing.Point(147, 159)
        Me.TextBoxamtinvo.Name = "TextBoxamtinvo"
        Me.TextBoxamtinvo.ReadOnly = True
        Me.TextBoxamtinvo.Size = New System.Drawing.Size(135, 20)
        Me.TextBoxamtinvo.TabIndex = 29
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(342, 121)
        Me.lbl_status.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(47, 16)
        Me.lbl_status.TabIndex = 28
        Me.lbl_status.Text = "Status:"
        '
        'lbl_paymode
        '
        Me.lbl_paymode.AutoSize = True
        Me.lbl_paymode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paymode.Location = New System.Drawing.Point(342, 57)
        Me.lbl_paymode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_paymode.Name = "lbl_paymode"
        Me.lbl_paymode.Size = New System.Drawing.Size(101, 16)
        Me.lbl_paymode.TabIndex = 27
        Me.lbl_paymode.Text = "Payment Mode:"
        '
        'lbl_totalamt
        '
        Me.lbl_totalamt.AutoSize = True
        Me.lbl_totalamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalamt.Location = New System.Drawing.Point(18, 161)
        Me.lbl_totalamt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_totalamt.Name = "lbl_totalamt"
        Me.lbl_totalamt.Size = New System.Drawing.Size(89, 16)
        Me.lbl_totalamt.TabIndex = 26
        Me.lbl_totalamt.Text = "Total Amount:"
        '
        'lbl_billdate
        '
        Me.lbl_billdate.AutoSize = True
        Me.lbl_billdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_billdate.Location = New System.Drawing.Point(18, 109)
        Me.lbl_billdate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_billdate.Name = "lbl_billdate"
        Me.lbl_billdate.Size = New System.Drawing.Size(60, 16)
        Me.lbl_billdate.TabIndex = 25
        Me.lbl_billdate.Text = "Bill Date:"
        '
        'lbl_billid
        '
        Me.lbl_billid.AutoSize = True
        Me.lbl_billid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_billid.Location = New System.Drawing.Point(18, 57)
        Me.lbl_billid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_billid.Name = "lbl_billid"
        Me.lbl_billid.Size = New System.Drawing.Size(44, 16)
        Me.lbl_billid.TabIndex = 24
        Me.lbl_billid.Text = "Bill ID:"
        '
        'Cmbbillid
        '
        Me.Cmbbillid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbbillid.FormattingEnabled = True
        Me.Cmbbillid.Location = New System.Drawing.Point(150, 57)
        Me.Cmbbillid.Name = "Cmbbillid"
        Me.Cmbbillid.Size = New System.Drawing.Size(81, 21)
        Me.Cmbbillid.TabIndex = 23
        '
        'grpbox_servdetails
        '
        Me.grpbox_servdetails.Controls.Add(Me.Dgvinvo)
        Me.grpbox_servdetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbox_servdetails.Location = New System.Drawing.Point(10, 496)
        Me.grpbox_servdetails.Margin = New System.Windows.Forms.Padding(2)
        Me.grpbox_servdetails.Name = "grpbox_servdetails"
        Me.grpbox_servdetails.Padding = New System.Windows.Forms.Padding(2)
        Me.grpbox_servdetails.Size = New System.Drawing.Size(577, 182)
        Me.grpbox_servdetails.TabIndex = 26
        Me.grpbox_servdetails.TabStop = False
        Me.grpbox_servdetails.Text = "Treatment Details:"
        '
        'Dgvinvo
        '
        Me.Dgvinvo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Dgvinvo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dgvinvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvinvo.Location = New System.Drawing.Point(21, 40)
        Me.Dgvinvo.Name = "Dgvinvo"
        Me.Dgvinvo.ReadOnly = True
        Me.Dgvinvo.Size = New System.Drawing.Size(534, 126)
        Me.Dgvinvo.TabIndex = 0
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.grpbox_servdetails)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(3, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 689)
        Me.Panel1.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(203, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Medical Billing Invoice"
        '
        'Invoiceform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(621, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Invoiceform"
        Me.Text = "Medical Bill "
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpbox_servdetails.ResumeLayout(False)
        CType(Me.Dgvinvo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CmbWardno As ComboBox
    Friend WithEvents Cmbbillid As ComboBox
    Friend WithEvents TextBoxptnaddress As TextBox
    Friend WithEvents TextBoxptngen As TextBox
    Friend WithEvents TextBoxptdob As TextBox
    Friend WithEvents TextBoxptname As TextBox
    Friend WithEvents TextBoxptncallno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_billid As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents lbl_paymode As Label
    Friend WithEvents lbl_totalamt As Label
    Friend WithEvents lbl_billdate As Label
    Friend WithEvents grpbox_servdetails As GroupBox
    Friend WithEvents Dtpbillinvo As DateTimePicker
    Friend WithEvents TextBoxstatus As TextBox
    Friend WithEvents TextBoxpaymod As TextBox
    Friend WithEvents TextBoxamtinvo As TextBox
    Friend WithEvents Btnbckinvo As Button
    Friend WithEvents Buttonprintinvo As Button
    Friend WithEvents Dgvinvo As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Btnclrinvo As Button
End Class
