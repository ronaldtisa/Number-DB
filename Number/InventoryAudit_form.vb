Imports System.Runtime.InteropServices

Public Class InventoryAudit_form



    Private Sub ClosePurchaseOrderForm_Click(sender As Object, e As EventArgs) Handles CloseInventoryAuditForm.Click
        Me.Close()
    End Sub

    Private Sub maximizePurchaseOrderForm_Click(sender As Object, e As EventArgs) Handles maximizeInventoryAuditForm.Click
        If WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub
    Private Sub minimizePurchaseOrderForm_Click(sender As Object, e As EventArgs) Handles minimizeInventoryAuditForm.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    ''=========================================================================
    ''========taskbar drag=====================================================
    ''=========================================================================
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    ''=========================================================================
    ''========taskbar drag end=====================================================
    ''=========================================================================


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class