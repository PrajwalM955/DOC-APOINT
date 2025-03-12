<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPgDoctor = New System.Windows.Forms.TabPage()
        Me.Btndocback = New System.Windows.Forms.Button()
        Me.Btndgvdelete = New System.Windows.Forms.Button()
        Me.Txtbox_phoneno = New System.Windows.Forms.TextBox()
        Me.Btndgvedit = New System.Windows.Forms.Button()
        Me.Btnclrdoc = New System.Windows.Forms.Button()
        Me.Btnregdoc = New System.Windows.Forms.Button()
        Me.Btndgvview = New System.Windows.Forms.Button()
        Me.Txtboxdocspeci = New System.Windows.Forms.TextBox()
        Me.Txtboxdocname = New System.Windows.Forms.TextBox()
        Me.Txtboxdocid = New System.Windows.Forms.TextBox()
        Me.Cboboxhour = New System.Windows.Forms.ComboBox()
        Me.Clstbox = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgvdoc = New System.Windows.Forms.DataGridView()
        Me.TabPgpatient = New System.Windows.Forms.TabPage()
        Me.Btnptndelete = New System.Windows.Forms.Button()
        Me.Btnptnedit = New System.Windows.Forms.Button()
        Me.Btnptnview = New System.Windows.Forms.Button()
        Me.Btnptnclr = New System.Windows.Forms.Button()
        Me.Btnptnregister = New System.Windows.Forms.Button()
        Me.Txtbxptnmedhstry = New System.Windows.Forms.TextBox()
        Me.Txtbxptnadrs = New System.Windows.Forms.TextBox()
        Me.Cmbbxptngnder = New System.Windows.Forms.ComboBox()
        Me.Datepatientdob = New System.Windows.Forms.DateTimePicker()
        Me.Txtbxptnname = New System.Windows.Forms.TextBox()
        Me.Txtbxptnid = New System.Windows.Forms.TextBox()
        Me.Dgvptntab = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPgTreatment = New System.Windows.Forms.TabPage()
        Me.Btntrtdelete = New System.Windows.Forms.Button()
        Me.Dgvtreatment = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btntrtclr = New System.Windows.Forms.Button()
        Me.Btntrtreg = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txtbxtrtid = New System.Windows.Forms.TextBox()
        Me.Txtbxtrtname = New System.Windows.Forms.TextBox()
        Me.Txtbxtrtcost = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Btntrtedit = New System.Windows.Forms.Button()
        Me.Btntrtview = New System.Windows.Forms.Button()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.Btnptnback = New System.Windows.Forms.Button()
        Me.Btntrtback = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPgDoctor.SuspendLayout()
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
        Me.TabControl1.Location = New System.Drawing.Point(22, 11)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(665, 488)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPgDoctor
        '
        Me.TabPgDoctor.Controls.Add(Me.Btndocback)
        Me.TabPgDoctor.Controls.Add(Me.Btndgvdelete)
        Me.TabPgDoctor.Controls.Add(Me.Txtbox_phoneno)
        Me.TabPgDoctor.Controls.Add(Me.Btndgvedit)
        Me.TabPgDoctor.Controls.Add(Me.Btnclrdoc)
        Me.TabPgDoctor.Controls.Add(Me.Btnregdoc)
        Me.TabPgDoctor.Controls.Add(Me.Btndgvview)
        Me.TabPgDoctor.Controls.Add(Me.Txtboxdocspeci)
        Me.TabPgDoctor.Controls.Add(Me.Txtboxdocname)
        Me.TabPgDoctor.Controls.Add(Me.Txtboxdocid)
        Me.TabPgDoctor.Controls.Add(Me.Cboboxhour)
        Me.TabPgDoctor.Controls.Add(Me.Clstbox)
        Me.TabPgDoctor.Controls.Add(Me.Label6)
        Me.TabPgDoctor.Controls.Add(Me.Label5)
        Me.TabPgDoctor.Controls.Add(Me.Label4)
        Me.TabPgDoctor.Controls.Add(Me.Label3)
        Me.TabPgDoctor.Controls.Add(Me.Label2)
        Me.TabPgDoctor.Controls.Add(Me.Label1)
        Me.TabPgDoctor.Controls.Add(Me.Dgvdoc)
        Me.TabPgDoctor.Location = New System.Drawing.Point(4, 22)
        Me.TabPgDoctor.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPgDoctor.Name = "TabPgDoctor"
        Me.TabPgDoctor.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPgDoctor.Size = New System.Drawing.Size(657, 462)
        Me.TabPgDoctor.TabIndex = 0
        Me.TabPgDoctor.Text = "Doctor"
        Me.TabPgDoctor.UseVisualStyleBackColor = True
        '
        'Btndocback
        '
        Me.Btndocback.Location = New System.Drawing.Point(570, 214)
        Me.Btndocback.Name = "Btndocback"
        Me.Btndocback.Size = New System.Drawing.Size(75, 27)
        Me.Btndocback.TabIndex = 3
        Me.Btndocback.Text = "Back"
        Me.Btndocback.UseVisualStyleBackColor = True
        '
        'Btndgvdelete
        '
        Me.Btndgvdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndgvdelete.Location = New System.Drawing.Point(562, 262)
        Me.Btndgvdelete.Margin = New System.Windows.Forms.Padding(2)
        Me.Btndgvdelete.Name = "Btndgvdelete"
        Me.Btndgvdelete.Size = New System.Drawing.Size(75, 19)
        Me.Btndgvdelete.TabIndex = 10
        Me.Btndgvdelete.Text = "Delete_Row"
        Me.Btndgvdelete.UseVisualStyleBackColor = True
        '
        'Txtbox_phoneno
        '
        Me.Txtbox_phoneno.Location = New System.Drawing.Point(158, 192)
        Me.Txtbox_phoneno.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbox_phoneno.Name = "Txtbox_phoneno"
        Me.Txtbox_phoneno.Size = New System.Drawing.Size(128, 20)
        Me.Txtbox_phoneno.TabIndex = 15
        '
        'Btndgvedit
        '
        Me.Btndgvedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndgvedit.Location = New System.Drawing.Point(492, 262)
        Me.Btndgvedit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btndgvedit.Name = "Btndgvedit"
        Me.Btndgvedit.Size = New System.Drawing.Size(67, 19)
        Me.Btndgvedit.TabIndex = 9
        Me.Btndgvedit.Text = "Edit_Row"
        Me.Btndgvedit.UseVisualStyleBackColor = True
        '
        'Btnclrdoc
        '
        Me.Btnclrdoc.Location = New System.Drawing.Point(492, 214)
        Me.Btnclrdoc.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnclrdoc.Name = "Btnclrdoc"
        Me.Btnclrdoc.Size = New System.Drawing.Size(73, 27)
        Me.Btnclrdoc.TabIndex = 14
        Me.Btnclrdoc.Text = "Clear"
        Me.Btnclrdoc.UseVisualStyleBackColor = True
        '
        'Btnregdoc
        '
        Me.Btnregdoc.Location = New System.Drawing.Point(404, 214)
        Me.Btnregdoc.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnregdoc.Name = "Btnregdoc"
        Me.Btnregdoc.Size = New System.Drawing.Size(76, 27)
        Me.Btnregdoc.TabIndex = 13
        Me.Btnregdoc.Text = "Register"
        Me.Btnregdoc.UseVisualStyleBackColor = True
        '
        'Btndgvview
        '
        Me.Btndgvview.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndgvview.Location = New System.Drawing.Point(424, 262)
        Me.Btndgvview.Margin = New System.Windows.Forms.Padding(2)
        Me.Btndgvview.Name = "Btndgvview"
        Me.Btndgvview.Size = New System.Drawing.Size(56, 19)
        Me.Btndgvview.TabIndex = 8
        Me.Btndgvview.Text = "View "
        Me.Btndgvview.UseVisualStyleBackColor = True
        '
        'Txtboxdocspeci
        '
        Me.Txtboxdocspeci.Location = New System.Drawing.Point(158, 132)
        Me.Txtboxdocspeci.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtboxdocspeci.Multiline = True
        Me.Txtboxdocspeci.Name = "Txtboxdocspeci"
        Me.Txtboxdocspeci.Size = New System.Drawing.Size(128, 41)
        Me.Txtboxdocspeci.TabIndex = 11
        '
        'Txtboxdocname
        '
        Me.Txtboxdocname.Location = New System.Drawing.Point(158, 92)
        Me.Txtboxdocname.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtboxdocname.Name = "Txtboxdocname"
        Me.Txtboxdocname.Size = New System.Drawing.Size(128, 20)
        Me.Txtboxdocname.TabIndex = 10
        '
        'Txtboxdocid
        '
        Me.Txtboxdocid.Location = New System.Drawing.Point(158, 34)
        Me.Txtboxdocid.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtboxdocid.Name = "Txtboxdocid"
        Me.Txtboxdocid.Size = New System.Drawing.Size(128, 20)
        Me.Txtboxdocid.TabIndex = 9
        '
        'Cboboxhour
        '
        Me.Cboboxhour.FormattingEnabled = True
        Me.Cboboxhour.Items.AddRange(New Object() {"Fore noon", "After noon", "Evening"})
        Me.Cboboxhour.Location = New System.Drawing.Point(477, 159)
        Me.Cboboxhour.Margin = New System.Windows.Forms.Padding(2)
        Me.Cboboxhour.Name = "Cboboxhour"
        Me.Cboboxhour.Size = New System.Drawing.Size(134, 21)
        Me.Cboboxhour.TabIndex = 8
        '
        'Clstbox
        '
        Me.Clstbox.BackColor = System.Drawing.SystemColors.Window
        Me.Clstbox.FormattingEnabled = True
        Me.Clstbox.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.Clstbox.Location = New System.Drawing.Point(477, 37)
        Me.Clstbox.Margin = New System.Windows.Forms.Padding(2)
        Me.Clstbox.Name = "Clstbox"
        Me.Clstbox.Size = New System.Drawing.Size(94, 94)
        Me.Clstbox.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 159)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Hour_Availability"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(345, 37)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Week_Availability"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Specialization"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Doctor_id"
        '
        'Dgvdoc
        '
        Me.Dgvdoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvdoc.Location = New System.Drawing.Point(21, 285)
        Me.Dgvdoc.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgvdoc.Name = "Dgvdoc"
        Me.Dgvdoc.RowHeadersWidth = 51
        Me.Dgvdoc.RowTemplate.Height = 24
        Me.Dgvdoc.Size = New System.Drawing.Size(616, 134)
        Me.Dgvdoc.TabIndex = 0
        '
        'TabPgpatient
        '
        Me.TabPgpatient.Controls.Add(Me.Btnptnback)
        Me.TabPgpatient.Controls.Add(Me.Btnptndelete)
        Me.TabPgpatient.Controls.Add(Me.Btnptnedit)
        Me.TabPgpatient.Controls.Add(Me.Btnptnview)
        Me.TabPgpatient.Controls.Add(Me.Btnptnclr)
        Me.TabPgpatient.Controls.Add(Me.Btnptnregister)
        Me.TabPgpatient.Controls.Add(Me.Txtbxptnmedhstry)
        Me.TabPgpatient.Controls.Add(Me.Txtbxptnadrs)
        Me.TabPgpatient.Controls.Add(Me.Cmbbxptngnder)
        Me.TabPgpatient.Controls.Add(Me.Datepatientdob)
        Me.TabPgpatient.Controls.Add(Me.Txtbxptnname)
        Me.TabPgpatient.Controls.Add(Me.Txtbxptnid)
        Me.TabPgpatient.Controls.Add(Me.Dgvptntab)
        Me.TabPgpatient.Controls.Add(Me.Label12)
        Me.TabPgpatient.Controls.Add(Me.Label11)
        Me.TabPgpatient.Controls.Add(Me.Label10)
        Me.TabPgpatient.Controls.Add(Me.Label9)
        Me.TabPgpatient.Controls.Add(Me.Label8)
        Me.TabPgpatient.Controls.Add(Me.Label7)
        Me.TabPgpatient.Location = New System.Drawing.Point(4, 22)
        Me.TabPgpatient.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPgpatient.Name = "TabPgpatient"
        Me.TabPgpatient.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPgpatient.Size = New System.Drawing.Size(657, 462)
        Me.TabPgpatient.TabIndex = 1
        Me.TabPgpatient.Text = "Patients"
        Me.TabPgpatient.UseVisualStyleBackColor = True
        '
        'Btnptndelete
        '
        Me.Btnptndelete.Location = New System.Drawing.Point(563, 265)
        Me.Btnptndelete.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnptndelete.Name = "Btnptndelete"
        Me.Btnptndelete.Size = New System.Drawing.Size(64, 19)
        Me.Btnptndelete.TabIndex = 17
        Me.Btnptndelete.Text = "Delete_row"
        Me.Btnptndelete.UseVisualStyleBackColor = True
        '
        'Btnptnedit
        '
        Me.Btnptnedit.Location = New System.Drawing.Point(488, 265)
        Me.Btnptnedit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnptnedit.Name = "Btnptnedit"
        Me.Btnptnedit.Size = New System.Drawing.Size(71, 19)
        Me.Btnptnedit.TabIndex = 16
        Me.Btnptnedit.Text = "Edit_row"
        Me.Btnptnedit.UseVisualStyleBackColor = True
        '
        'Btnptnview
        '
        Me.Btnptnview.Location = New System.Drawing.Point(427, 265)
        Me.Btnptnview.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnptnview.Name = "Btnptnview"
        Me.Btnptnview.Size = New System.Drawing.Size(56, 19)
        Me.Btnptnview.TabIndex = 15
        Me.Btnptnview.Text = "View"
        Me.Btnptnview.UseVisualStyleBackColor = True
        '
        'Btnptnclr
        '
        Me.Btnptnclr.Location = New System.Drawing.Point(469, 212)
        Me.Btnptnclr.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnptnclr.Name = "Btnptnclr"
        Me.Btnptnclr.Size = New System.Drawing.Size(82, 28)
        Me.Btnptnclr.TabIndex = 14
        Me.Btnptnclr.Text = "Clear"
        Me.Btnptnclr.UseVisualStyleBackColor = True
        '
        'Btnptnregister
        '
        Me.Btnptnregister.Location = New System.Drawing.Point(378, 212)
        Me.Btnptnregister.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnptnregister.Name = "Btnptnregister"
        Me.Btnptnregister.Size = New System.Drawing.Size(87, 28)
        Me.Btnptnregister.TabIndex = 13
        Me.Btnptnregister.Text = "Register"
        Me.Btnptnregister.UseVisualStyleBackColor = True
        '
        'Txtbxptnmedhstry
        '
        Me.Txtbxptnmedhstry.Location = New System.Drawing.Point(459, 124)
        Me.Txtbxptnmedhstry.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxptnmedhstry.Multiline = True
        Me.Txtbxptnmedhstry.Name = "Txtbxptnmedhstry"
        Me.Txtbxptnmedhstry.Size = New System.Drawing.Size(170, 54)
        Me.Txtbxptnmedhstry.TabIndex = 12
        '
        'Txtbxptnadrs
        '
        Me.Txtbxptnadrs.Location = New System.Drawing.Point(459, 24)
        Me.Txtbxptnadrs.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxptnadrs.Multiline = True
        Me.Txtbxptnadrs.Name = "Txtbxptnadrs"
        Me.Txtbxptnadrs.Size = New System.Drawing.Size(170, 57)
        Me.Txtbxptnadrs.TabIndex = 11
        '
        'Cmbbxptngnder
        '
        Me.Cmbbxptngnder.FormattingEnabled = True
        Me.Cmbbxptngnder.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.Cmbbxptngnder.Location = New System.Drawing.Point(142, 158)
        Me.Cmbbxptngnder.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbbxptngnder.Name = "Cmbbxptngnder"
        Me.Cmbbxptngnder.Size = New System.Drawing.Size(92, 21)
        Me.Cmbbxptngnder.TabIndex = 10
        '
        'Datepatientdob
        '
        Me.Datepatientdob.Location = New System.Drawing.Point(142, 104)
        Me.Datepatientdob.Margin = New System.Windows.Forms.Padding(2)
        Me.Datepatientdob.Name = "Datepatientdob"
        Me.Datepatientdob.Size = New System.Drawing.Size(151, 20)
        Me.Datepatientdob.TabIndex = 9
        '
        'Txtbxptnname
        '
        Me.Txtbxptnname.Location = New System.Drawing.Point(142, 67)
        Me.Txtbxptnname.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxptnname.Name = "Txtbxptnname"
        Me.Txtbxptnname.Size = New System.Drawing.Size(76, 20)
        Me.Txtbxptnname.TabIndex = 8
        '
        'Txtbxptnid
        '
        Me.Txtbxptnid.Location = New System.Drawing.Point(142, 30)
        Me.Txtbxptnid.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxptnid.Name = "Txtbxptnid"
        Me.Txtbxptnid.Size = New System.Drawing.Size(76, 20)
        Me.Txtbxptnid.TabIndex = 7
        '
        'Dgvptntab
        '
        Me.Dgvptntab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvptntab.Location = New System.Drawing.Point(32, 288)
        Me.Dgvptntab.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgvptntab.Name = "Dgvptntab"
        Me.Dgvptntab.RowHeadersWidth = 51
        Me.Dgvptntab.RowTemplate.Height = 24
        Me.Dgvptntab.Size = New System.Drawing.Size(596, 102)
        Me.Dgvptntab.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(360, 124)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Medical_History"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(360, 30)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 35)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Patient_ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 158)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 104)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Birth_Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 67)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Patient Name"
        '
        'TabPgTreatment
        '
        Me.TabPgTreatment.Controls.Add(Me.Btntrtdelete)
        Me.TabPgTreatment.Controls.Add(Me.Dgvtreatment)
        Me.TabPgTreatment.Controls.Add(Me.Panel1)
        Me.TabPgTreatment.Controls.Add(Me.Btntrtedit)
        Me.TabPgTreatment.Controls.Add(Me.Btntrtview)
        Me.TabPgTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPgTreatment.Location = New System.Drawing.Point(4, 22)
        Me.TabPgTreatment.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPgTreatment.Name = "TabPgTreatment"
        Me.TabPgTreatment.Size = New System.Drawing.Size(657, 462)
        Me.TabPgTreatment.TabIndex = 2
        Me.TabPgTreatment.Text = "Treatments"
        Me.TabPgTreatment.UseVisualStyleBackColor = True
        '
        'Btntrtdelete
        '
        Me.Btntrtdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtdelete.Location = New System.Drawing.Point(568, 267)
        Me.Btntrtdelete.Margin = New System.Windows.Forms.Padding(2)
        Me.Btntrtdelete.Name = "Btntrtdelete"
        Me.Btntrtdelete.Size = New System.Drawing.Size(75, 19)
        Me.Btntrtdelete.TabIndex = 10
        Me.Btntrtdelete.Text = "Delete_Row"
        Me.Btntrtdelete.UseVisualStyleBackColor = True
        '
        'Dgvtreatment
        '
        Me.Dgvtreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvtreatment.Location = New System.Drawing.Point(14, 291)
        Me.Dgvtreatment.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgvtreatment.Name = "Dgvtreatment"
        Me.Dgvtreatment.RowHeadersWidth = 51
        Me.Dgvtreatment.RowTemplate.Height = 24
        Me.Dgvtreatment.Size = New System.Drawing.Size(629, 124)
        Me.Dgvtreatment.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btntrtback)
        Me.Panel1.Controls.Add(Me.Btntrtclr)
        Me.Panel1.Controls.Add(Me.Btntrtreg)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Txtbxtrtid)
        Me.Panel1.Controls.Add(Me.Txtbxtrtname)
        Me.Panel1.Controls.Add(Me.Txtbxtrtcost)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(2, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(628, 219)
        Me.Panel1.TabIndex = 6
        '
        'Btntrtclr
        '
        Me.Btntrtclr.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtclr.Location = New System.Drawing.Point(450, 180)
        Me.Btntrtclr.Margin = New System.Windows.Forms.Padding(2)
        Me.Btntrtclr.Name = "Btntrtclr"
        Me.Btntrtclr.Size = New System.Drawing.Size(73, 27)
        Me.Btntrtclr.TabIndex = 16
        Me.Btntrtclr.Text = "Clear"
        Me.Btntrtclr.UseVisualStyleBackColor = True
        '
        'Btntrtreg
        '
        Me.Btntrtreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtreg.Location = New System.Drawing.Point(370, 180)
        Me.Btntrtreg.Margin = New System.Windows.Forms.Padding(2)
        Me.Btntrtreg.Name = "Btntrtreg"
        Me.Btntrtreg.Size = New System.Drawing.Size(76, 27)
        Me.Btntrtreg.TabIndex = 15
        Me.Btntrtreg.Text = "Register"
        Me.Btntrtreg.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 26)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Treatment_ID"
        '
        'Txtbxtrtid
        '
        Me.Txtbxtrtid.Location = New System.Drawing.Point(111, 26)
        Me.Txtbxtrtid.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxtrtid.Name = "Txtbxtrtid"
        Me.Txtbxtrtid.Size = New System.Drawing.Size(141, 26)
        Me.Txtbxtrtid.TabIndex = 3
        '
        'Txtbxtrtname
        '
        Me.Txtbxtrtname.Location = New System.Drawing.Point(111, 80)
        Me.Txtbxtrtname.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxtrtname.Name = "Txtbxtrtname"
        Me.Txtbxtrtname.Size = New System.Drawing.Size(141, 26)
        Me.Txtbxtrtname.TabIndex = 4
        '
        'Txtbxtrtcost
        '
        Me.Txtbxtrtcost.Location = New System.Drawing.Point(111, 134)
        Me.Txtbxtrtcost.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxtrtcost.Name = "Txtbxtrtcost"
        Me.Txtbxtrtcost.Size = New System.Drawing.Size(141, 26)
        Me.Txtbxtrtcost.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 80)
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
        Me.Label15.Location = New System.Drawing.Point(18, 134)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Treatment Cost"
        '
        'Btntrtedit
        '
        Me.Btntrtedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtedit.Location = New System.Drawing.Point(496, 267)
        Me.Btntrtedit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btntrtedit.Name = "Btntrtedit"
        Me.Btntrtedit.Size = New System.Drawing.Size(67, 19)
        Me.Btntrtedit.TabIndex = 9
        Me.Btntrtedit.Text = "Edit_Row"
        Me.Btntrtedit.UseVisualStyleBackColor = True
        '
        'Btntrtview
        '
        Me.Btntrtview.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtview.Location = New System.Drawing.Point(436, 267)
        Me.Btntrtview.Margin = New System.Windows.Forms.Padding(2)
        Me.Btntrtview.Name = "Btntrtview"
        Me.Btntrtview.Size = New System.Drawing.Size(56, 19)
        Me.Btntrtview.TabIndex = 8
        Me.Btntrtview.Text = "View "
        Me.Btntrtview.UseVisualStyleBackColor = True
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar2.Location = New System.Drawing.Point(716, 0)
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(21, 506)
        Me.VScrollBar2.TabIndex = 2
        '
        'Btnptnback
        '
        Me.Btnptnback.Location = New System.Drawing.Point(552, 212)
        Me.Btnptnback.Name = "Btnptnback"
        Me.Btnptnback.Size = New System.Drawing.Size(87, 28)
        Me.Btnptnback.TabIndex = 18
        Me.Btnptnback.Text = "Back"
        Me.Btnptnback.UseVisualStyleBackColor = True
        '
        'Btntrtback
        '
        Me.Btntrtback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtback.Location = New System.Drawing.Point(528, 180)
        Me.Btntrtback.Name = "Btntrtback"
        Me.Btntrtback.Size = New System.Drawing.Size(75, 27)
        Me.Btntrtback.TabIndex = 17
        Me.Btntrtback.Text = "Back"
        Me.Btntrtback.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 506)
        Me.Controls.Add(Me.VScrollBar2)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "Registration_Page"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPgDoctor.ResumeLayout(False)
        Me.TabPgDoctor.PerformLayout()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Clstbox As CheckedListBox
    Friend WithEvents Txtboxdocspeci As TextBox
    Friend WithEvents Txtboxdocname As TextBox
    Friend WithEvents Txtboxdocid As TextBox
    Friend WithEvents Cboboxhour As ComboBox
    Friend WithEvents Btnclrdoc As Button
    Friend WithEvents Btnregdoc As Button
    Friend WithEvents Txtbox_phoneno As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Dgvptntab As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Txtbxptnname As TextBox
    Friend WithEvents Txtbxptnid As TextBox
    Friend WithEvents Btnptnclr As Button
    Friend WithEvents Btnptnregister As Button
    Friend WithEvents Txtbxptnmedhstry As TextBox
    Friend WithEvents Txtbxptnadrs As TextBox
    Friend WithEvents Cmbbxptngnder As ComboBox
    Friend WithEvents Datepatientdob As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Txtbxtrtcost As TextBox
    Friend WithEvents Txtbxtrtname As TextBox
    Friend WithEvents Txtbxtrtid As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Dgvtreatment As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btntrtclr As Button
    Friend WithEvents Btntrtreg As Button
    Friend WithEvents Btnptndelete As Button
    Friend WithEvents Btnptnedit As Button
    Friend WithEvents Btnptnview As Button
    Friend WithEvents Btntrtdelete As Button
    Friend WithEvents Btntrtedit As Button
    Friend WithEvents Btntrtview As Button
    Friend WithEvents Btndgvdelete As Button
    Friend WithEvents Btndgvedit As Button
    Friend WithEvents Btndgvview As Button
    Friend WithEvents VScrollBar2 As VScrollBar
    Friend WithEvents Btndocback As Button
    Friend WithEvents Btnptnback As Button
    Friend WithEvents Btntrtback As Button
End Class
