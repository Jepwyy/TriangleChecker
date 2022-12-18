Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstAngle, secondAngle, thirdAngle, Sum As Integer
        Try
            firstAngle = Convert.ToInt32(TextBox1.Text)
            secondAngle = Convert.ToInt32(TextBox2.Text)
            thirdAngle = Convert.ToInt32(TextBox3.Text)
            Sum = firstAngle + secondAngle + thirdAngle
            If Sum = 180 Then
                TextBox4.Text = "180 degrees.That's a GOOD Triangle!"
            Else
                TextBox4.Text = Sum.ToString() + " degrees. That's a BAD Triangle!"
            End If
        Catch ex As Exception
            MessageBox.Show("Please input a number.", "Invvalid Input",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
