Public Class LEARN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BEGINNERS.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub LEARN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PROFESSIONAL.Show()
        Me.Hide()
    End Sub
End Class