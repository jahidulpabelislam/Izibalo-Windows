Public Class Login
    Private Sub CheckInputs()
        If Not Trim(TextBox2.Text) = "" And Not Trim(TextBox1.Text) = "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub PressedEnter()
        Profile.Label2.Text = TextBox1.Text
        PlayerProfile.Label6.Text = TextBox1.Text
        CachesMap.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call PressedEnter()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Button1.Enabled = True Then
                Call PressedEnter()
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Button1.Enabled = True Then
                Call PressedEnter()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call CheckInputs()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Call CheckInputs()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Parent = PictureBox2
    End Sub
End Class
