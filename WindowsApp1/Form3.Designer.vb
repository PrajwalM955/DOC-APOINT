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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPgDoctor = New System.Windows.Forms.TabPage()
        Me.Btndocedit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtBxdocid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.Btnptnedit = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtBxptnid = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txtbxptnname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBxptncontact = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Btnptnback = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Btnptnclr = New System.Windows.Forms.Button()
        Me.Datepatientdob = New System.Windows.Forms.DateTimePicker()
        Me.Btnptnregister = New System.Windows.Forms.Button()
        Me.Cmbbxptngnder = New System.Windows.Forms.ComboBox()
        Me.Txtbxptnmedhstry = New System.Windows.Forms.TextBox()
        Me.Txtbxptnadrs = New System.Windows.Forms.TextBox()
        Me.Dgvptntab = New System.Windows.Forms.DataGridView()
        Me.BtnPtnview = New System.Windows.Forms.Button()
        Me.BtnDeletePatient = New System.Windows.Forms.Button()
        Me.TabPgTreatment = New System.Windows.Forms.TabPage()
        Me.Btntrtedit = New System.Windows.Forms.Button()
        Me.BtnTrtview = New System.Windows.Forms.Button()
        Me.BtnDeleteTreatment = New System.Windows.Forms.Button()
        Me.Dgvtreatment = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtBxtrtid = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txtbxtrtname = New System.Windows.Forms.TextBox()
        Me.Txtbxtrtcost = New System.Windows.Forms.TextBox()
        Me.Btntrtback = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Btntrtclr = New System.Windows.Forms.Button()
        Me.Btntrtreg = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPgDoctor.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dgvdoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPgpatient.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Dgvptntab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPgTreatment.SuspendLayout()
        CType(Me.Dgvtreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPgDoctor)
        Me.TabControl1.Controls.Add(Me.TabPgpatient)
        Me.TabControl1.Controls.Add(Me.TabPgTreatment)
        Me.TabControl1.ItemSize = New System.Drawing.Size(90, 60)
        Me.TabControl1.Location = New System.Drawing.Point(27, 113)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(726, 498)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPgDoctor
        '
        Me.TabPgDoctor.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.gg1
        Me.TabPgDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPgDoctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPgDoctor.Controls.Add(Me.Btndocedit)
        Me.TabPgDoctor.Controls.Add(Me.Panel2)
        Me.TabPgDoctor.Controls.Add(Me.Btn_docdel)
        Me.TabPgDoctor.Controls.Add(Me.Btndocview)
        Me.TabPgDoctor.Controls.Add(Me.Dgvdoc)
        Me.TabPgDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPgDoctor.Location = New System.Drawing.Point(4, 64)
        Me.TabPgDoctor.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPgDoctor.Name = "TabPgDoctor"
        Me.TabPgDoctor.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPgDoctor.Size = New System.Drawing.Size(718, 430)
        Me.TabPgDoctor.TabIndex = 0
        Me.TabPgDoctor.Text = "Doctor"
        Me.TabPgDoctor.UseVisualStyleBackColor = True
        '
        'Btndocedit
        '
        Me.Btndocedit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btndocedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndocedit.Location = New System.Drawing.Point(537, 254)
        Me.Btndocedit.Name = "Btndocedit"
        Me.Btndocedit.Size = New System.Drawing.Size(84, 23)
        Me.Btndocedit.TabIndex = 19
        Me.Btndocedit.Text = "Edit"
        Me.Btndocedit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.TxtBxdocid)
        Me.Panel2.Controls.Add(Me.Label10)
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
        Me.Panel2.Size = New System.Drawing.Size(696, 243)
        Me.Panel2.TabIndex = 18
        '
        'TxtBxdocid
        '
        Me.TxtBxdocid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxdocid.Location = New System.Drawing.Point(165, 20)
        Me.TxtBxdocid.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBxdocid.Name = "TxtBxdocid"
        Me.TxtBxdocid.ReadOnly = True
        Me.TxtBxdocid.Size = New System.Drawing.Size(146, 20)
        Me.TxtBxdocid.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Doctor ID"
        '
        'Txtboxdocname
        '
        Me.Txtboxdocname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtboxdocname.Location = New System.Drawing.Point(165, 53)
        Me.Txtboxdocname.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtboxdocname.Name = "Txtboxdocname"
        Me.Txtboxdocname.Size = New System.Drawing.Size(146, 20)
        Me.Txtboxdocname.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Btndocback
        '
        Me.Btndocback.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btndocback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btndocback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btndocback.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndocback.Location = New System.Drawing.Point(416, 204)
        Me.Btndocback.Name = "Btndocback"
        Me.Btndocback.Size = New System.Drawing.Size(75, 27)
        Me.Btndocback.TabIndex = 3
        Me.Btndocback.Text = "Back"
        Me.Btndocback.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Specialization"
        '
        'Txtbox_phoneno
        '
        Me.Txtbox_phoneno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbox_phoneno.Location = New System.Drawing.Point(165, 131)
        Me.Txtbox_phoneno.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbox_phoneno.Name = "Txtbox_phoneno"
        Me.Txtbox_phoneno.Size = New System.Drawing.Size(146, 20)
        Me.Txtbox_phoneno.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact"
        '
        'Btnclrdoc
        '
        Me.Btnclrdoc.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnclrdoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnclrdoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnclrdoc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclrdoc.Location = New System.Drawing.Point(330, 204)
        Me.Btnclrdoc.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnclrdoc.Name = "Btnclrdoc"
        Me.Btnclrdoc.Size = New System.Drawing.Size(73, 27)
        Me.Btnclrdoc.TabIndex = 14
        Me.Btnclrdoc.Text = "Clear"
        Me.Btnclrdoc.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(395, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Week_Availability"
        '
        'Btnregdoc
        '
        Me.Btnregdoc.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnregdoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnregdoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnregdoc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregdoc.Location = New System.Drawing.Point(235, 204)
        Me.Btnregdoc.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnregdoc.Name = "Btnregdoc"
        Me.Btnregdoc.Size = New System.Drawing.Size(76, 27)
        Me.Btnregdoc.TabIndex = 13
        Me.Btnregdoc.Text = "Register"
        Me.Btnregdoc.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(395, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Hour_Availability"
        '
        'Txtboxdocspeci
        '
        Me.Txtboxdocspeci.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtboxdocspeci.Location = New System.Drawing.Point(165, 90)
        Me.Txtboxdocspeci.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtboxdocspeci.Multiline = True
        Me.Txtboxdocspeci.Name = "Txtboxdocspeci"
        Me.Txtboxdocspeci.Size = New System.Drawing.Size(146, 26)
        Me.Txtboxdocspeci.TabIndex = 11
        '
        'Clstbox
        '
        Me.Clstbox.BackColor = System.Drawing.Color.White
        Me.Clstbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clstbox.FormattingEnabled = True
        Me.Clstbox.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.Clstbox.Location = New System.Drawing.Point(537, 7)
        Me.Clstbox.Margin = New System.Windows.Forms.Padding(2)
        Me.Clstbox.Name = "Clstbox"
        Me.Clstbox.Size = New System.Drawing.Size(94, 100)
        Me.Clstbox.TabIndex = 7
        '
        'Cboboxhour
        '
        Me.Cboboxhour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cboboxhour.FormattingEnabled = True
        Me.Cboboxhour.Items.AddRange(New Object() {"Fore noon", "After noon", "Evening"})
        Me.Cboboxhour.Location = New System.Drawing.Point(532, 132)
        Me.Cboboxhour.Margin = New System.Windows.Forms.Padding(2)
        Me.Cboboxhour.Name = "Cboboxhour"
        Me.Cboboxhour.Size = New System.Drawing.Size(134, 21)
        Me.Cboboxhour.TabIndex = 8
        '
        'Btn_docdel
        '
        Me.Btn_docdel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_docdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_docdel.Location = New System.Drawing.Point(626, 254)
        Me.Btn_docdel.Name = "Btn_docdel"
        Me.Btn_docdel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_docdel.TabIndex = 16
        Me.Btn_docdel.Text = "Delete"
        Me.Btn_docdel.UseVisualStyleBackColor = False
        '
        'Btndocview
        '
        Me.Btndocview.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btndocview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndocview.Location = New System.Drawing.Point(445, 254)
        Me.Btndocview.Name = "Btndocview"
        Me.Btndocview.Size = New System.Drawing.Size(84, 23)
        Me.Btndocview.TabIndex = 17
        Me.Btndocview.Text = "View Details"
        Me.Btndocview.UseVisualStyleBackColor = False
        '
        'Dgvdoc
        '
        Me.Dgvdoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgvdoc.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Dgvdoc.Location = New System.Drawing.Point(7, 282)
        Me.Dgvdoc.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgvdoc.Name = "Dgvdoc"
        Me.Dgvdoc.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgvdoc.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgvdoc.RowTemplate.Height = 24
        Me.Dgvdoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Dgvdoc.Size = New System.Drawing.Size(694, 134)
        Me.Dgvdoc.TabIndex = 0
        '
        'TabPgpatient
        '
        Me.TabPgpatient.Controls.Add(Me.Btnptnedit)
        Me.TabPgpatient.Controls.Add(Me.Panel3)
        Me.TabPgpatient.Controls.Add(Me.Dgvptntab)
        Me.TabPgpatient.Controls.Add(Me.BtnPtnview)
        Me.TabPgpatient.Controls.Add(Me.BtnDeletePatient)
        Me.TabPgpatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPgpatient.Location = New System.Drawing.Point(4, 64)
        Me.TabPgpatient.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPgpatient.Name = "TabPgpatient"
        Me.TabPgpatient.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPgpatient.Size = New System.Drawing.Size(718, 430)
        Me.TabPgpatient.TabIndex = 1
        Me.TabPgpatient.Text = "Patients"
        Me.TabPgpatient.UseVisualStyleBackColor = True
        '
        'Btnptnedit
        '
        Me.Btnptnedit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnptnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnptnedit.Location = New System.Drawing.Point(525, 254)
        Me.Btnptnedit.Name = "Btnptnedit"
        Me.Btnptnedit.Size = New System.Drawing.Size(84, 23)
        Me.Btnptnedit.TabIndex = 24
        Me.Btnptnedit.Text = "Edit"
        Me.Btnptnedit.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtBxptnid)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Txtbxptnname)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TxtBxptncontact)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Btnptnback)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Btnptnclr)
        Me.Panel3.Controls.Add(Me.Datepatientdob)
        Me.Panel3.Controls.Add(Me.Btnptnregister)
        Me.Panel3.Controls.Add(Me.Cmbbxptngnder)
        Me.Panel3.Controls.Add(Me.Txtbxptnmedhstry)
        Me.Panel3.Controls.Add(Me.Txtbxptnadrs)
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(708, 243)
        Me.Panel3.TabIndex = 23
        '
        'TxtBxptnid
        '
        Me.TxtBxptnid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxptnid.Location = New System.Drawing.Point(149, 15)
        Me.TxtBxptnid.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBxptnid.Name = "TxtBxptnid"
        Me.TxtBxptnid.ReadOnly = True
        Me.TxtBxptnid.Size = New System.Drawing.Size(146, 20)
        Me.TxtBxptnid.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(30, 15)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 17)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Patient ID"
        '
        'Txtbxptnname
        '
        Me.Txtbxptnname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbxptnname.Location = New System.Drawing.Point(149, 51)
        Me.Txtbxptnname.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxptnname.Name = "Txtbxptnname"
        Me.Txtbxptnname.Size = New System.Drawing.Size(137, 20)
        Me.Txtbxptnname.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 51)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Patient Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 86)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Birth_Date"
        '
        'TxtBxptncontact
        '
        Me.TxtBxptncontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxptncontact.Location = New System.Drawing.Point(519, 18)
        Me.TxtBxptncontact.Name = "TxtBxptncontact"
        Me.TxtBxptncontact.Size = New System.Drawing.Size(137, 20)
        Me.TxtBxptncontact.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 131)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 19)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Contact No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(415, 58)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 19)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Address"
        '
        'Btnptnback
        '
        Me.Btnptnback.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Btnptnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnptnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnptnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnptnback.Location = New System.Drawing.Point(412, 200)
        Me.Btnptnback.Name = "Btnptnback"
        Me.Btnptnback.Size = New System.Drawing.Size(87, 28)
        Me.Btnptnback.TabIndex = 18
        Me.Btnptnback.Text = "Back"
        Me.Btnptnback.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(376, 118)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 19)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Medical_History"
        '
        'Btnptnclr
        '
        Me.Btnptnclr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Btnptnclr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnptnclr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnptnclr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnptnclr.Location = New System.Drawing.Point(309, 200)
        Me.Btnptnclr.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnptnclr.Name = "Btnptnclr"
        Me.Btnptnclr.Size = New System.Drawing.Size(82, 28)
        Me.Btnptnclr.TabIndex = 14
        Me.Btnptnclr.Text = "Clear"
        Me.Btnptnclr.UseVisualStyleBackColor = False
        '
        'Datepatientdob
        '
        Me.Datepatientdob.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datepatientdob.Location = New System.Drawing.Point(149, 89)
        Me.Datepatientdob.Margin = New System.Windows.Forms.Padding(2)
        Me.Datepatientdob.Name = "Datepatientdob"
        Me.Datepatientdob.Size = New System.Drawing.Size(151, 20)
        Me.Datepatientdob.TabIndex = 9
        '
        'Btnptnregister
        '
        Me.Btnptnregister.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Btnptnregister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnptnregister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnptnregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnptnregister.Location = New System.Drawing.Point(197, 200)
        Me.Btnptnregister.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnptnregister.Name = "Btnptnregister"
        Me.Btnptnregister.Size = New System.Drawing.Size(87, 28)
        Me.Btnptnregister.TabIndex = 13
        Me.Btnptnregister.Text = "Register"
        Me.Btnptnregister.UseVisualStyleBackColor = False
        '
        'Cmbbxptngnder
        '
        Me.Cmbbxptngnder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbbxptngnder.FormattingEnabled = True
        Me.Cmbbxptngnder.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.Cmbbxptngnder.Location = New System.Drawing.Point(149, 134)
        Me.Cmbbxptngnder.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbbxptngnder.Name = "Cmbbxptngnder"
        Me.Cmbbxptngnder.Size = New System.Drawing.Size(108, 21)
        Me.Cmbbxptngnder.TabIndex = 10
        '
        'Txtbxptnmedhstry
        '
        Me.Txtbxptnmedhstry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbxptnmedhstry.Location = New System.Drawing.Point(519, 118)
        Me.Txtbxptnmedhstry.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxptnmedhstry.Multiline = True
        Me.Txtbxptnmedhstry.Name = "Txtbxptnmedhstry"
        Me.Txtbxptnmedhstry.Size = New System.Drawing.Size(170, 54)
        Me.Txtbxptnmedhstry.TabIndex = 12
        '
        'Txtbxptnadrs
        '
        Me.Txtbxptnadrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbxptnadrs.Location = New System.Drawing.Point(519, 52)
        Me.Txtbxptnadrs.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxptnadrs.Multiline = True
        Me.Txtbxptnadrs.Name = "Txtbxptnadrs"
        Me.Txtbxptnadrs.Size = New System.Drawing.Size(170, 57)
        Me.Txtbxptnadrs.TabIndex = 11
        '
        'Dgvptntab
        '
        Me.Dgvptntab.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Dgvptntab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvptntab.Location = New System.Drawing.Point(18, 282)
        Me.Dgvptntab.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgvptntab.Name = "Dgvptntab"
        Me.Dgvptntab.RowHeadersWidth = 51
        Me.Dgvptntab.RowTemplate.Height = 24
        Me.Dgvptntab.Size = New System.Drawing.Size(682, 144)
        Me.Dgvptntab.TabIndex = 6
        '
        'BtnPtnview
        '
        Me.BtnPtnview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPtnview.Location = New System.Drawing.Point(435, 254)
        Me.BtnPtnview.Name = "BtnPtnview"
        Me.BtnPtnview.Size = New System.Drawing.Size(84, 23)
        Me.BtnPtnview.TabIndex = 22
        Me.BtnPtnview.Text = "View Details"
        Me.BtnPtnview.UseVisualStyleBackColor = True
        '
        'BtnDeletePatient
        '
        Me.BtnDeletePatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeletePatient.Location = New System.Drawing.Point(615, 254)
        Me.BtnDeletePatient.Name = "BtnDeletePatient"
        Me.BtnDeletePatient.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeletePatient.TabIndex = 21
        Me.BtnDeletePatient.Text = "Delete"
        Me.BtnDeletePatient.UseVisualStyleBackColor = True
        '
        'TabPgTreatment
        '
        Me.TabPgTreatment.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabPgTreatment.Controls.Add(Me.Btntrtedit)
        Me.TabPgTreatment.Controls.Add(Me.BtnTrtview)
        Me.TabPgTreatment.Controls.Add(Me.BtnDeleteTreatment)
        Me.TabPgTreatment.Controls.Add(Me.Dgvtreatment)
        Me.TabPgTreatment.Controls.Add(Me.Panel1)
        Me.TabPgTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPgTreatment.Location = New System.Drawing.Point(4, 64)
        Me.TabPgTreatment.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPgTreatment.Name = "TabPgTreatment"
        Me.TabPgTreatment.Size = New System.Drawing.Size(718, 430)
        Me.TabPgTreatment.TabIndex = 2
        Me.TabPgTreatment.Text = "Treatments"
        '
        'Btntrtedit
        '
        Me.Btntrtedit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btntrtedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtedit.Location = New System.Drawing.Point(534, 224)
        Me.Btntrtedit.Name = "Btntrtedit"
        Me.Btntrtedit.Size = New System.Drawing.Size(84, 23)
        Me.Btntrtedit.TabIndex = 24
        Me.Btntrtedit.Text = "Edit"
        Me.Btntrtedit.UseVisualStyleBackColor = False
        '
        'BtnTrtview
        '
        Me.BtnTrtview.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnTrtview.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTrtview.Location = New System.Drawing.Point(449, 224)
        Me.BtnTrtview.Name = "BtnTrtview"
        Me.BtnTrtview.Size = New System.Drawing.Size(84, 23)
        Me.BtnTrtview.TabIndex = 23
        Me.BtnTrtview.Text = "View Details"
        Me.BtnTrtview.UseVisualStyleBackColor = False
        '
        'BtnDeleteTreatment
        '
        Me.BtnDeleteTreatment.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnDeleteTreatment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteTreatment.Location = New System.Drawing.Point(624, 224)
        Me.BtnDeleteTreatment.Name = "BtnDeleteTreatment"
        Me.BtnDeleteTreatment.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteTreatment.TabIndex = 22
        Me.BtnDeleteTreatment.Text = "Delete"
        Me.BtnDeleteTreatment.UseVisualStyleBackColor = False
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
        Me.Dgvtreatment.Size = New System.Drawing.Size(684, 176)
        Me.Dgvtreatment.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TxtBxtrtid)
        Me.Panel1.Controls.Add(Me.Label16)
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
        Me.Panel1.Size = New System.Drawing.Size(697, 199)
        Me.Panel1.TabIndex = 6
        '
        'TxtBxtrtid
        '
        Me.TxtBxtrtid.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxtrtid.Location = New System.Drawing.Point(179, 18)
        Me.TxtBxtrtid.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBxtrtid.Name = "TxtBxtrtid"
        Me.TxtBxtrtid.ReadOnly = True
        Me.TxtBxtrtid.Size = New System.Drawing.Size(146, 20)
        Me.TxtBxtrtid.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(41, 18)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 17)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Treatment ID"
        '
        'Txtbxtrtname
        '
        Me.Txtbxtrtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbxtrtname.Location = New System.Drawing.Point(180, 56)
        Me.Txtbxtrtname.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxtrtname.Name = "Txtbxtrtname"
        Me.Txtbxtrtname.Size = New System.Drawing.Size(141, 20)
        Me.Txtbxtrtname.TabIndex = 4
        '
        'Txtbxtrtcost
        '
        Me.Txtbxtrtcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbxtrtcost.Location = New System.Drawing.Point(180, 97)
        Me.Txtbxtrtcost.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtbxtrtcost.Name = "Txtbxtrtcost"
        Me.Txtbxtrtcost.Size = New System.Drawing.Size(141, 20)
        Me.Txtbxtrtcost.TabIndex = 5
        '
        'Btntrtback
        '
        Me.Btntrtback.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btntrtback.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtback.Location = New System.Drawing.Point(399, 155)
        Me.Btntrtback.Name = "Btntrtback"
        Me.Btntrtback.Size = New System.Drawing.Size(75, 30)
        Me.Btntrtback.TabIndex = 17
        Me.Btntrtback.Text = "Back"
        Me.Btntrtback.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(41, 56)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 17)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Traetment Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(41, 97)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 17)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Treatment Cost"
        '
        'Btntrtclr
        '
        Me.Btntrtclr.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btntrtclr.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtclr.Location = New System.Drawing.Point(311, 154)
        Me.Btntrtclr.Margin = New System.Windows.Forms.Padding(2)
        Me.Btntrtclr.Name = "Btntrtclr"
        Me.Btntrtclr.Size = New System.Drawing.Size(73, 30)
        Me.Btntrtclr.TabIndex = 16
        Me.Btntrtclr.Text = "Clear"
        Me.Btntrtclr.UseVisualStyleBackColor = False
        '
        'Btntrtreg
        '
        Me.Btntrtreg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btntrtreg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrtreg.Location = New System.Drawing.Point(200, 154)
        Me.Btntrtreg.Margin = New System.Windows.Forms.Padding(2)
        Me.Btntrtreg.Name = "Btntrtreg"
        Me.Btntrtreg.Size = New System.Drawing.Size(82, 30)
        Me.Btntrtreg.TabIndex = 15
        Me.Btntrtreg.Text = "Register"
        Me.Btntrtreg.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.nnnn
        Me.PictureBox1.Location = New System.Drawing.Point(541, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.gg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(775, 633)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "Registration_Page"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPgDoctor.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Dgvdoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPgpatient.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Dgvptntab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPgTreatment.ResumeLayout(False)
        CType(Me.Dgvtreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btndocedit As Button
    Friend WithEvents Btnptnedit As Button
    Friend WithEvents Btntrtedit As Button
    Friend WithEvents TxtBxdocid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtBxptnid As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtBxtrtid As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
