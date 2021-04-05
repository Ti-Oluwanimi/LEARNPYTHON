Public Class BEGINNERS
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_intro.asp")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_syntax.asp")
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_variables.asp")
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_numbers.asp")
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_casting.asp")
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_strings.asp")
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_operators.asp")
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_lists.asp")
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_sets.asp")
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_dictionaries.asp")
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_conditions.asp")
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_while_loops.asp")
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_for_loops.asp")
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_functions.asp")
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_arrays.asp")
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        WebBrowser1.Navigate("https://w3schools.com/python/python_try_except.asp")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LEARN.Show()
        Me.Close()
    End Sub

    Private Sub BEGINNERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class