﻿Public Class Login
    Private Sub PressedEnter()
        If Not Trim(TextBox2.Text) = "" And Not Trim(TextBox1.Text) = "" Then
            Profile.Label2.Text = TextBox1.Text
            PlayerProfile.Label6.Text = TextBox1.Text
            CachesMap.Show()
            Me.Hide()
        ElseIf Trim(TextBox2.Text) = "" And Trim(TextBox1.Text) = "" Then
            Label4.Text = "Input fields needs to filled."
        ElseIf Trim(TextBox2.Text) = "" Then
            Label4.Text = "Password field needs to filled."
        ElseIf Trim(TextBox1.Text) = "" Then
            Label4.Text = "Username field needs to filled."
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call PressedEnter()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Parent = PictureBox2
        Label1.Parent = PictureBox2
        Label2.Parent = PictureBox2
        Label3.Parent = PictureBox2
        CheckBox1.Parent = PictureBox2
        Label4.Parent = PictureBox2
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TextBox2.PasswordChar = "*"
        ElseIf CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Button1.Enabled = True Then
                Call PressedEnter()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Button1.Enabled = True Then
                TextBox2.Focus()
            End If
        End If
    End Sub
End Class
