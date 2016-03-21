Public Class UserMap

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Map.Show()
        Me.Hide()
    End Sub

    Private Sub UserMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox7.Parent = PictureBox4
        PictureBox2.Parent = PictureBox4
        PictureBox5.Parent = PictureBox1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        List.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        List2.Show()
        Me.Hide()
    End Sub
End Class