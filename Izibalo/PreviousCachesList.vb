Public Class PreviousCachesList

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PreviousCachesMap.Show()
        Me.Hide()
    End Sub

    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox7.Parent = PictureBox4
        PictureBox6.Parent = PictureBox4
        PictureBox2.Parent = PictureBox4
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        CachesMap.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Profile.Show()
        Me.Hide()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        PlayerProfile.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        LocationList.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        LocationList.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        PlayerProfile.Show()
        Me.Hide()
    End Sub
End Class