Public Class Form1

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        PictureBox1.Visible = True
        PictureBox2.Visible = False
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        PictureBox2.Visible = True
        PictureBox1.Visible = False
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        btn1.Enabled = False
        btn2.Enabled = False
        btnExit.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
