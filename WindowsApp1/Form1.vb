Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnlog.Click

        If Txtuname.Text = "Prajwal" And Txtpword.Text = "123" Then
            MessageBox.Show("Login Successfull ! ")
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Username or Password !!")
        End If

    End Sub

    Private Sub Btncls_Click(sender As Object, e As EventArgs) Handles Btnclr.Click
        Txtpword.Text = "    "
        Txtuname.Text = "      "
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class
