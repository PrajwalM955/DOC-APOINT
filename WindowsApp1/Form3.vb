Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Dim connectionString As String = "Data Source=LAPTOP-JRNIQUNP\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

    Private Sub Load_RegTab_Data()

    End Sub
    Private Sub Form3_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        Form2.Show()
    End Sub
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnregdoc.Click
        If Txtboxdocid.Text = "" Or Txtboxdocname.Text = "" Or Txtboxdocspeci.Text = "" Or Txtbox_phoneno.Text = "" Or Clstbox.SelectedValueChanged = True Or  Then
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Btndocback.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles Txtbxptnadrs.TextChanged

    End Sub

    Private Sub Btnptnclr_Click(sender As Object, e As EventArgs) Handles Btnptnclr.Click

    End Sub
End Class