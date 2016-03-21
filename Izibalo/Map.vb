Public Class Map
    Private Sub UserMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Parent = PictureBox1
        PictureBox3.Parent = PictureBox1
        PictureBox7.Parent = PictureBox4
        PictureBox5.Parent = PictureBox4
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        UserMap.Show()
        Me.Hide()
    End Sub
End Class