Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim celcius, fahrenheit, reamur, kelvin As Double
        celcius = Val(TextBox1.Text)
        fahrenheit = 9 / 5 * (celcius) + 32
        reamur = 4 / 5 * (celcius)
        kelvin = celcius + 273

        TextBox2.Text = CStr(fahrenheit)
        TextBox3.Text = CStr(reamur)
        TextBox4.Text = CStr(kelvin)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub cmdCalculator_Click(sender As Object, e As EventArgs) Handles cmdCalculator.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub
End Class
