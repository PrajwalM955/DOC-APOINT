<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPgDoctor = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Txtboxdocname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btndocback = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtbox_phoneno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnclrdoc = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btnregdoc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtboxdocspeci = New System.Windows.Forms.TextBox()
        Me.Clstbox = New System.Windows.Forms.CheckedListBox()
        Me.Cboboxhour = New System.Windows.Forms.ComboBox()
        Me.Btn_docdel = New System.Windows.Forms.Button()
        Me.Btndocview = New System.Windows.Forms.Button()
        Me.Dgvdoc = New System.Windows.Forms.DataGridView()
        Me.TabPgpatient = New System.Windows.Forms.TabPage()
        Me.BtnPtnview = New System.Windows.Forms.Button()
        Me.BtnDeletePatient = New System.Windows.Forms.Button()
        Me.TxtBxptncontact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnptnback = New System.Windows.Forms.Button()
        Me.Btnptnclr = New System.Windows.Forms.Button()
        Me.Btnptnregister = New System.Windows.Forms.Button()
        Me.Txtbxptnmedhstry = New System.Windows.Forms.TextBox()
        Me.Txtbxptnadrs = New System.Windows.Forms.TextBox()
        Me.Cmbbxptngnder = New System.Windows.Forms.ComboBox()
        Me.Datepatientdob = New System.Windows.Forms.DateTimePicker()
        Me.Txtbxptnname = New System.Windows.Forms.TextBox()
        Me.Dgvptntab = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPgTreatment = New System.Windows.Forms.TabPage()
        Me.BtnTrtview = New System.Windows.Forms.Button()
        Me.BtnDeleteTreatment = New System.Windows.Forms.Button()
        Me.Btntrtback = New System.Windows.Forms.Button()
        Me.Dgvtreatment = New System.Windows.Forms.DataGridView()
        Me.Btntrtclr = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txtbxtrtname = New System.Windows.Forms.TextBox()
        Me.Txtbxtrtcost = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Btntrtreg = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPgDoctor.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dgvdoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPgpatient.SuspendLayout()
        CType(Me.Dgvptntab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPgTreatment.SuspendLayout()
        CType(Me.Dgvtreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPgDoctor)
        Me.TabControl1.Controls.Add(Me.TabPgpatient)
        Me.TabControl1.Controls.Add(Me.TabPgTreatment)
        Me.TabControl1.ItemSize = New System.Drawing.Size(90, 60)
        Me.TabControl1.Location = New System.Drawing.Point(22, 11)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(726, 488)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPgDoctor
        '
        Me.TabPgDoctor.Controls.Add(Me.Panel2)
        Me.TabPgDoctor.Controls.Add(Me.Btn_docdel)
        Me.TabPgDoctor.Controls.Add(Me.Btndocview)
        Me.TabPgDoctor.Controls.Add(Me.Dgvdoc)
        Me.TabPgDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPgDoctor.Location = New System.Drawing.Point(4, 64)
        Me.TabPgDoctor.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPgDoctor.Name = "TabPgDoctor"
        Me.TabPgDoctor.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPgDoctor.Size = New System.Drawing.Size(718, 420)
        Me.TabPgDoctor.TabIndex = 0
        Me.TabPgDoctor.Text = "Doctor"
        Me.TabPgDoctor.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Txtboxdocname)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Btndocback)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Txtbox_phoneno)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Btnclrdoc)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Btnregdoc)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Txtboxdocspeci)
        Me.Panel2.Controls.Add(Me.Clstbox)
        Me.Panel2.Controls.Add(Me.Cboboxhour)
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(708, 243)
        Me.Panel2.TabIndex = 18
        '
        'Txtboxdocname
        '
        Me.Txtboxdocname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtboxdocname.Location = New System.Drawing.Point(165, 33)
        Me.Txtboxdocname.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtboxdocname.Name = "Txtboxdocname"
        Me.Txtboxdocname.Size = New System.Drawing.Size(146, 22)
        Me.Txtboxdocname.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Btndocback
        '
        Me.Btndocback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndocback.Location = New System.Drawing.Point(621, 204)
        Me.Btndocback.Name = "Btndocback"
        Me.Btndocback.Size = New System.Drawing.Size(75, 27)
        Me.Btndocback.TabIndex = 3
        Me.Btndocback.Text = "Back"
        Me.Btndocback.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Specialization"
        '
        'Txtbox_phoneno
        '
        Me.Txtbox_phoneno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_phoneno.Location = New System.Drawing.Point(165, 156)
        Me.Txtbox_phoneno.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbox_phoneno.Name = "Txtbox_phoneno"
        Me.Txtbox_phoneno.Size = New System.Drawing.Size(146, 22)
        Me.Txtbox_phoneno.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 155)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact"
        '
        'Btnclrdoc
        '
        Me.Btnclrdoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclrdoc.Location = New System.Drawing.Point(543, 204)
        Me.Btnclrdoc.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnclrdoc.Name = "Btnclrdoc"
        Me.Btnclrdoc.Size = New System.Drawing.Size(73, 27)
        Me.Btnclrdoc.TabIndex = 14
        Me.Btnclrdoc.Text = "Clear"
        Me.Btnclrdoc.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Week_Availability"
        '
        'Btnregdoc
        '
        Me.Btnregdoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregdoc.Location = New System.Drawing.Point(455, 204)
        Me.Btnregdoc.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnregdoc.Name = "Btnregdoc"
        Me.Btnregdoc.Size = New System.Drawing.Size(76, 27)
        Me.Btnregdoc.TabIndex = 13
        Me.Btnregdoc.Text = "Register"
        Me.Btnregdoc.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(407, 144)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Hour_Availability"
        '
        'Txtboxdocspeci
        '
        Me.Txtboxdocspeci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtboxdocspeci.Location = New System.Drawing.Point(165, 82)
        Me.Txtboxdocspeci.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtboxdocspeci.Multiline = True
        Me.Txtboxdocspeci.Name = "Txtboxdocspeci"
        Me.Txtboxdocspeci.Size = New System.Drawing.Size(146, 26)
        Me.Txtboxdocspeci.TabIndex = 11
        '
        'Clstbox
        '
        Me.Clstbox.BackColor = System.Drawing.SystemColors.Window
        Me.Clstbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clstbox.FormattingEnabled = True
        Me.Clstbox.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.Clstbox.Location = New System.Drawing.Point(537, 7)
        Me.Clstbox.Margin = New System.Windows.Forms.Padding(2)
        Me.Clstbox.Name = "Clstbox"
        Me.Clstbox.Size = New System.Drawing.Size(94, 116)
        Me.Clstbox.TabIndex = 7
        '
        'Cboboxhour
        '
        Me.Cboboxhour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cboboxhour.FormattingEnabled = True
        Me.Cboboxhour.Items.AddRange(New Object() {"Fore noon", "After noon", "Evening"})
        Me.Cboboxhour.Location = New System.Drawing.Point(543, 144)
        Me.Cboboxhour.Margin = New System.Windows.Forms.Padding(2)
        Me.Cboboxhour.Name = "Cboboxhour"
        Me.Cboboxhour.Size = New System.Drawing.Size(134, 24)
        Me.Cboboxhour.TabIndex = 8
        '
        'Btn_docdel
        '
        Me.Btn_docdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_docdel.Location = New System.Drawing.Point(626, 254)
        Me.Btn_docdel.Name = "Btn_docdel"
        Me.Btn_docdel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_docdel.TabIndex = 16
        Me.Btn_docdel.Text = "Delete"
        Me.Btn_docdel.UseVisualStyleBackColor = True
        '
        'Btndocview
        '
        Me.Btndocview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndocview.Location = New System.Drawing.Point(537, 254)
        Me.Btndocview.Name = "Btndocview"
        Me.Btndocview.Size = New System.Drawing.Size(84, 23)
        Me.Btndocview.TabIndex = 17
        Me.Btndocview.Text = "View Details"
        Me.Btndocview.UseVisualStyleBackColor = True
        '
        'Dgvdoc
        '
        Me.Dgvdoc.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Dgvdoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvdoc.Location = New System.Drawing.Point(20, 282)
        Me.Dgvdoc.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgvdoc.Name = "Dgvdoc"
        Me.Dgvdoc.RowHeadersWidth = 51
        Me.Dgvdoc.RowTemplate.Height = 24
        Me.Dgvdoc.Size = New System.Drawing.Size(694, 134)
        Me.Dgvdoc.TabIndex = 0
        '
        'TabPgpatient
        '
        Me.TabPgpatient.Controls.Add(Me.BtnPtnview)
        Me.TabPgpatient.Controls.Add(Me.BtnDeletePatient)
        Me.TabPgpatient.Controls.Add(Me.TxtBxptncontact)
        Me.TabPgpatient.Controls.Add(Me.Label1)
        Me.TabPgpatient.Controls.Add(Me.Btnptnback)
        Me.TabPgpatient.Controls.Add(Me.Btnptnclr)
        Me.TabPgpatient.Controls.Add(Me.Btnptnregister)
        Me.TabPgpatient.Controls.Add(Me.Txtbxptnmedhstry)
        Me.TabPgpatient.Controls.Add(Me.Txtbxptnadrs)
        Me.TabPgpatient.Controls.Add(Me.Cmbbxptngnder)
        Me.TabPgpatient.Controls.Add(Me.Datepatientdob)
        Me.TabPgpatient.Controls.Add(Me.Txtbxptnname)
        Me.TabPgpatient.Controls.Add(Me.Dgvptntab)
        Me.TabPgpatient.Controls.Add(Me.Label12)
        Me.TabPgpatient.Controls.Add(Me.Label11)
        Me.TabPgpatient.Controls.Add(Me.Label9)
        Me.TabPgpatient.Controls.Add(Me.Label8)
        Me.TabPgpatient.Controls.Add(Me.Label7)
        Me.TabPgpatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPgpatient.Location = New System.Drawing.Point(4, 64)
        Me.TabPgpatient.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPgpatient.Name = "TabPgpatient"
        Me.TabPgpatient.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPgpatient.Size = New System.Drawing.Size(718, 420)
        Me.TabPgpatient.TabIndex = 1
        Me.TabPgpatient.Text = "Patients"
        Me.TabPgpatient.UseVisualStyleBackColor = True
        '
        'BtnPtnview
        '
        Me.BtnPtnview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPtnview.Location = New System.Drawing.Point(525, 254)
        Me.BtnPtnview.Name = "BtnPtnview"
        Me.BtnPtnview.Size = New System.Drawing.Size(84, 23)
        Me.BtnPtnview.TabIndex = 22
        Me.BtnPtnview.Text = "View Details"
        Me.BtnPtnview.UseVisualStyleBackColor = True
        '
        'BtnDeletePatient
        '
        Me.BtnDeletePatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeletePatient.Location = New System.Drawing.Point(615, 254)
        Me.BtnDeletePatient.Name = "BtnDeletePatient"
        Me.BtnDeletePatient.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeletePatient.TabIndex = 21
        Me.BtnDeletePatient.Text = "Delete"
        Me.BtnDeletePatient.UseVisualStyleBackColor = True
        '
        'TxtBxptncontact
        '
        Me.TxtBxptncontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxptncontact.Location = New System.Drawing.Point(142, 148)
        Me.TxtBxptncontact.Name = "TxtBxptncontact"
        Me.TxtBxptncontact.Size = New System.Drawing.Size(100, 26)
        Me.TxtBxptncontact.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Contact No"
        '
        'Btnptnback
        '
        Me.Btnptnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnptnback.Location = New System.Drawing.Point(614, 206)
        Me.Btnptnback.Name = "Btnptnback"
        Me.Btnptnback.Size = New System.Drawing.Size(87, 28)
        Me.Btnptnback.TabIndex = 18
        Me.Btnptnback.Text = "Back"
        Me.Btnptnback.UseVisualStyleBackColor = True
        '
        'Btnptnclr
        '
        Me.Btnptnclr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnptnclr.Location = New System.Drawing.Point(531, 206)
        Me.Btnptnclr.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnptnclr.Name = "Btnptnclr"
        Me.Btnptnclr.Size = New System.Drawing.Size(82, 28)
        Me.Btnptnclr.TabIndex = 14
        Me.Btnptnclr.Text = "Clear"
        Me.Btnptnclr.UseVisualStyleBackColor = True
        '
        'Btnptnregister
        '
        Me.Btnptnregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnptnregister.Location = New System.Drawing.Point(440, 206)
        Me.Btnptnregister.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnptnregister.Name = "Btnptnregister"
        Me.Btnptnregister.Size = New System.Drawing.Size(87, 28)
        Me.Btnptnregister.TabIndex = 13
        Me.Btnptnregister.Text = "Register"
        Me.Btnptnregister.UseVisualStyleBackColor = True
        '
        'Txtbxptnmedhstry
        '
        Me.Txtbxptnmedhstry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbxptnmedhstry.Location = New System.Drawing.Point(501, 124)
        Me.Txtbxptnmedhstry.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxptnmedhstry.Multiline = True
        Me.Txtbxptnmedhstry.Name = "Txtbxptnmedhstry"
        Me.Txtbxptnmedhstry.Size = New System.Drawing.Size(170, 54)
        Me.Txtbxptnmedhstry.TabIndex = 12
        '
        'Txtbxptnadrs
        '
        Me.Txtbxptnadrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbxptnadrs.Location = New System.Drawing.Point(501, 24)
        Me.Txtbxptnadrs.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxptnadrs.Multiline = True
        Me.Txtbxptnadrs.Name = "Txtbxptnadrs"
        Me.Txtbxptnadrs.Size = New System.Drawing.Size(170, 57)
        Me.Txtbxptnadrs.TabIndex = 11
        '
        'Cmbbxptngnder
        '
        Me.Cmbbxptngnder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbbxptngnder.FormattingEnabled = True
        Me.Cmbbxptngnder.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.Cmbbxptngnder.Location = New System.Drawing.Point(142, 113)
        Me.Cmbbxptngnder.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbbxptngnder.Name = "Cmbbxptngnder"
        Me.Cmbbxptngnder.Size = New System.Drawing.Size(92, 28)
        Me.Cmbbxptngnder.TabIndex = 10
        '
        'Datepatientdob
        '
        Me.Datepatientdob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datepatientdob.Location = New System.Drawing.Point(142, 68)
        Me.Datepatientdob.Margin = New System.Windows.Forms.Padding(2)
        Me.Datepatientdob.Name = "Datepatientdob"
        Me.Datepatientdob.Size = New System.Drawing.Size(151, 26)
        Me.Datepatientdob.TabIndex = 9
        '
        'Txtbxptnname
        '
        Me.Txtbxptnname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbxptnname.Location = New System.Drawing.Point(142, 30)
        Me.Txtbxptnname.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxptnname.Name = "Txtbxptnname"
        Me.Txtbxptnname.Size = New System.Drawing.Size(76, 26)
        Me.Txtbxptnname.TabIndex = 8
        '
        'Dgvptntab
        '
        Me.Dgvptntab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvptntab.Location = New System.Drawing.Point(19, 288)
        Me.Dgvptntab.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgvptntab.Name = "Dgvptntab"
        Me.Dgvptntab.RowHeadersWidth = 51
        Me.Dgvptntab.RowTemplate.Height = 24
        Me.Dgvptntab.Size = New System.Drawing.Size(682, 128)
        Me.Dgvptntab.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(358, 124)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 20)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Medical_History"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(397, 30)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 110)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 65)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Birth_Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 27)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Patient Name"
        '
        'TabPgTreatment
        '
        Me.TabPgTreatment.Controls.Add(Me.BtnTrtview)
        Me.TabPgTreatment.Controls.Add(Me.BtnDeleteTreatment)
        Me.TabPgTreatment.Controls.Add(Me.Dgvtreatment)
        Me.TabPgTreatment.Controls.Add(Me.Panel1)
        Me.TabPgTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPgTreatment.Location = New System.Drawing.Point(4, 64)
        Me.TabPgTreatment.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPgTreatment.Name = "TabPgTreatment"
        Me.TabPgTreatment.Size = New System.Drawing.Size(718, 420)
        Me.TabPgTreatment.TabIndex = 2
        Me.TabPgTreatment.Text = "Treatments"
        Me.TabPgTreatment.UseVisualStyleBackColor = True
        '
        'BtnTrtview
        '
        Me.BtnTrtview.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTrtview.Location = New System.Drawing.Point(525, 214)
        Me.BtnTrtview.Name = "BtnTrtview"
        Me.BtnTrtview.Size = New System.Drawing.Size(84, 23)
        Me.BtnTrtview.TabIndex = 23
        Me.BtnTrtview.Text = "View Details"
        Me.BtnTrtview.UseVisualStyleBackColor = True
        '
        'BtnDeleteTreatment
        '
        Me.BtnDeleteTreatment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteTreatment.Location = New System.Drawing.Point(624, 214)
        Me.BtnDeleteTreatment.Name = "BtnDeleteTreatment"
        Me.BtnDeleteTreatment.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteTreatment.TabIndex = 22
        Me.BtnDeleteTreatment.Text = "Delete"
        Me.BtnDeleteTreatment.UseVisualStyleBackColor = True
        '
        'Btntrtback
        '
        Me.Btntrtback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtback.Location = New System.Drawing.Point(608, 146)
        Me.Btntrtback.Name = "Btntrtback"
        Me.Btntrtback.Size = New System.Drawing.Size(75, 27)
        Me.Btntrtback.TabIndex = 17
        Me.Btntrtback.Text = "Back"
        Me.Btntrtback.UseVisualStyleBackColor = True
        '
        'Dgvtreatment
        '
        Me.Dgvtreatment.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Dgvtreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvtreatment.Location = New System.Drawing.Point(15, 252)
        Me.Dgvtreatment.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgvtreatment.Name = "Dgvtreatment"
        Me.Dgvtreatment.RowHeadersWidth = 51
        Me.Dgvtreatment.RowTemplate.Height = 24
        Me.Dgvtreatment.Size = New System.Drawing.Size(684, 143)
        Me.Dgvtreatment.TabIndex = 7
        '
        'Btntrtclr
        '
        Me.Btntrtclr.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtclr.Location = New System.Drawing.Point(520, 145)
        Me.Btntrtclr.Margin = New System.Windows.Forms.Padding(2)
        Me.Btntrtclr.Name = "Btntrtclr"
        Me.Btntrtclr.Size = New System.Drawing.Size(73, 27)
        Me.Btntrtclr.TabIndex = 16
        Me.Btntrtclr.Text = "Clear"
        Me.Btntrtclr.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Txtbxtrtname)
        Me.Panel1.Controls.Add(Me.Txtbxtrtcost)
        Me.Panel1.Controls.Add(Me.Btntrtback)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Btntrtclr)
        Me.Panel1.Controls.Add(Me.Btntrtreg)
        Me.Panel1.Location = New System.Drawing.Point(2, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 185)
        Me.Panel1.TabIndex = 6
        '
        'Txtbxtrtname
        '
        Me.Txtbxtrtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbxtrtname.Location = New System.Drawing.Point(139, 33)
        Me.Txtbxtrtname.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxtrtname.Name = "Txtbxtrtname"
        Me.Txtbxtrtname.Size = New System.Drawing.Size(141, 26)
        Me.Txtbxtrtname.TabIndex = 4
        '
        'Txtbxtrtcost
        '
        Me.Txtbxtrtcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbxtrtcost.Location = New System.Drawing.Point(139, 89)
        Me.Txtbxtrtcost.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxtrtcost.Name = "Txtbxtrtcost"
        Me.Txtbxtrtcost.Size = New System.Drawing.Size(141, 26)
        Me.Txtbxtrtcost.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 41)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Traetment Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 97)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Treatment Cost"
        '
        'Btntrtreg
        '
        Me.Btntrtreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtreg.Location = New System.Drawing.Point(428, 146)
        Me.Btntrtreg.Margin = New System.Windows.Forms.Padding(2)
        Me.Btntrtreg.Name = "Btntrtreg"
        Me.Btntrtreg.Size = New System.Drawing.Size(76, 27)
        Me.Btntrtreg.TabIndex = 15
        Me.Btntrtreg.Text = "Register"
        Me.Btntrtreg.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 506)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "Registration_Page"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPgDoctor.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Dgvdoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPgpatient.ResumeLayout(False)
        Me.TabPgpatient.PerformLayout()
        CType(Me.Dgvptntab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPgTreatment.ResumeLayout(False)
        CType(Me.Dgvtreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPgDoctor As TabPage
    Friend WithEvents TabPgpatient As TabPage
    Friend WithEvents TabPgTreatment As TabPage
    Friend WithEvents Dgvdoc As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Clstbox As CheckedListBox
    Friend WithEvents Txtboxdocspeci As TextBox
    Friend WithEvents Txtboxdocname As TextBox
    Friend WithEvents Cboboxhour As ComboBox
    Friend WithEvents Btnclrdoc As Button
    Friend WithEvents Btnregdoc As Button
    Friend WithEvents Txtbox_phoneno As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Dgvptntab As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Txtbxptnname As TextBox
    Friend WithEvents Btnptnclr As Button
    Friend WithEvents Btnptnregister As Button
    Friend WithEvents Txtbxptnmedhstry As TextBox
    Friend WithEvents Txtbxptnadrs As TextBox
    Friend WithEvents Cmbbxptngnder As ComboBox
    Friend WithEvents Datepatientdob As DateTimePicker
    Friend WithEvents Txtbxtrtcost As TextBox
    Friend WithEvents Txtbxtrtname As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Dgvtreatment As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btntrtclr As Button
    Friend WithEvents Btntrtreg As Button
    Friend WithEvents Btndocback As Button
    Friend WithEvents Btnptnback As Button
    Friend WithEvents Btntrtback As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBxptncontact As TextBox
    Friend WithEvents Btn_docdel As Button
    Friend WithEvents BtnDeletePatient As Button
    Friend WithEvents BtnDeleteTreatment As Button
    Friend WithEvents Btndocview As Button
    Friend WithEvents BtnPtnview As Button
    Friend WithEvents BtnTrtview As Button
    Friend WithEvents Panel2 As Panel
End Class
