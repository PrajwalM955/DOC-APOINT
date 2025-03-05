<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnclr = New System.Windows.Forms.Button()
        Me.Btnlog = New System.Windows.Forms.Button()
        Me.Txtpword = New System.Windows.Forms.TextBox()
        Me.Txtuname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btnclr)
        Me.Panel1.Controls.Add(Me.Btnlog)
        Me.Panel1.Controls.Add(Me.Txtpword)
        Me.Panel1.Controls.Add(Me.Txtuname)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(75, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 294)
        Me.Panel1.TabIndex = 0
        '
        'Btnclr
        '
        Me.Btnclr.Location = New System.Drawing.Point(142, 228)
        Me.Btnclr.Name = "Btnclr"
        Me.Btnclr.Size = New System.Drawing.Size(75, 23)
        Me.Btnclr.TabIndex = 7
        Me.Btnclr.Text = "Clear"
        Me.Btnclr.UseVisualStyleBackColor = True
        '
        'Btnlog
        '
        Me.Btnlog.Location = New System.Drawing.Point(27, 228)
        Me.Btnlog.Name = "Btnlog"
        Me.Btnlog.Size = New System.Drawing.Size(75, 23)
        Me.Btnlog.TabIndex = 6
        Me.Btnlog.Text = "Login"
        Me.Btnlog.UseVisualStyleBackColor = True
        '
        'Txtpword
        '
        Me.Txtpword.Location = New System.Drawing.Point(27, 147)
        Me.Txtpword.Name = "Txtpword"
        Me.Txtpword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpword.Size = New System.Drawing.Size(180, 22)
        Me.Txtpword.TabIndex = 5
        '
        'Txtuname
        '
        Me.Txtuname.Location = New System.Drawing.Point(27, 72)
        Me.Txtuname.Name = "Txtuname"
        Me.Txtuname.Size = New System.Drawing.Size(180, 22)
        Me.Txtuname.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(30, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(27, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Admin Login Page"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 434)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "login_Page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnclr As Button
    Friend WithEvents Btnlog As Button
    Friend WithEvents Txtpword As TextBox
    Friend WithEvents Txtuname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
