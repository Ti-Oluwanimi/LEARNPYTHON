Public Class PROFESSIONAL
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LEARN.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DATA_SCIENCE.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MACHINE_LEARNING.Show()
        Me.Hide()
    End Sub

    Private Sub PROFESSIONAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class