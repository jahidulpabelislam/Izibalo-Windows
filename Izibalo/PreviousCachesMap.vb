Public Class PreviousCachesMap

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        CachesMap.Show()
        Me.Hide()
    End Sub

    Private Sub UserMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox7.Parent = PictureBox4
        PictureBox6.Parent = PictureBox4
        PictureBox2.Parent = PictureBox4
        PictureBox5.Parent = PictureBox1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PreviousCachesList.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        LocationList.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Profile.Show()
        Me.Hide()
    End Sub
End Class