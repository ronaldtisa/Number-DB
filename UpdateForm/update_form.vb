Public Class update_form

    Private Sub CloseMain_Click(sender As Object, e As EventArgs) Handles CloseMain.Click

        Me.Close()

    End Sub
    ''====================================================
    ''buttonMaximized
    ''====================================================
    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximizeMain.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    ''====================================================
    ''button Minimized
    ''====================================================
    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimizemain.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
