Public Class LocationList

    Private Sub List2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Parent = PictureBox4
        PictureBox6.Parent = PictureBox4
        PictureBox7.Parent = PictureBox4
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        CachesMap.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Profile.Show()
        Me.Hide()
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        PlayerProfile.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        PlayerProfile.Show()
        Me.Hide()
    End Sub
End Class