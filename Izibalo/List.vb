Public Class List

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserMap.Show()
        Me.Hide()
    End Sub

    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox7.Parent = PictureBox4
        PictureBox2.Parent = PictureBox4
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Map.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        UserMap.Show()
        Me.Hide()
    End Sub
End Class