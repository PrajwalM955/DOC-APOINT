Public Class Form7
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click
        Me.Chart1.Series("Revenue").Points.AddXY("2025", 150000)
        Me.Chart1.Series("Revenue").Points.AddXY("2026", 170000)
        Me.Chart1.Series("Revenue").Points.AddXY("2027", 190000)
    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs) Handles Chart2.Click
        Me.Chart2.Series("Age").Points.AddXY("0-10", 20)
        Me.Chart2.Series("Age").Points.AddXY("10-20", 17)
        Me.Chart2.Series("Age").Points.AddXY("20-30", 19)
        Me.Chart2.Series("Age").Points.AddXY("30-40", 20)
        Me.Chart2.Series("Age").Points.AddXY("40-50", 17)
        Me.Chart2.Series("Age").Points.AddXY("50-60", 19)
        Me.Chart2.Series("Age").Points.AddXY("60-100", 20)
    End Sub
End Class