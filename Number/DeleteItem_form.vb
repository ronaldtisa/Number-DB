Public Class DeleteItem_form

    Private Sub CloseDeleteItemForm_Click(sender As Object, e As EventArgs) Handles CloseDeleteItemForm.Click
        Me.Close()
    End Sub

    Private Sub maximizeDeleteItemForm_Click(sender As Object, e As EventArgs) Handles maximizeDeleteItemForm.Click
        If WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub
    Private Sub minimizeDeleteItemForm_Click(sender As Object, e As EventArgs) Handles minimizeDeleteItemForm.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ''=====================================================================================================
    ''code ==============================   
    ''=====================================================================================================


End Class