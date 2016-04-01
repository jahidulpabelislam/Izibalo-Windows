Public Class Profile

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        CachesMap.Show()
        Me.Hide()
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Parent = PictureBox4
        PictureBox6.Parent = PictureBox4
        PictureBox7.Parent = PictureBox4
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        PreviousCachesMap.Show()
        Me.Hide()
    End Sub
End Class