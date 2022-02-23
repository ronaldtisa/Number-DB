Imports System.Runtime.InteropServices
Imports System.Data.SQLite

Public Class UpdateRecord

    Private Const ConnectionString As String = ("Data Source=c:\Number Data Folder\numberform.db")
    '' opt sql command line ========================
    Private Const sqlsupplier As String = "SELECT Registration, CompanyName, CompanyAddress, CompanyTelephone FROM Supplier"
    Private Const sqlinventory As String = "SELECT Code, ProductName, CompanyName, UnitPrice, UnitTax FROM Inventory"
    ''==============================
    Private Sub ClosePurchaseOrderForm_Click(sender As Object, e As EventArgs) Handles CloseRecordUpdateForm.Click
        Me.Close()
    End Sub

    Private Sub maximizePurchaseOrderForm_Click(sender As Object, e As EventArgs) Handles maximizeRecordUpdateForm.Click
        If WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub
    Private Sub minimizePurchaseOrderForm_Click(sender As Object, e As EventArgs) Handles minimizeRecordUpdateForm.Click
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


    '' ============================================
    '' menu tooltip
    ''=============================================
    Dim updatetips As New ToolTip()
    Private Sub Supplier_MouseHover(sender As Object, e As EventArgs) Handles Supplier.MouseHover
        updatetips.ToolTipTitle = "Edit Supplier Info"
        updatetips.UseFading = True
        updatetips.UseAnimation = True

        updatetips.IsBalloon = True

        updatetips.ShowAlways = True

        updatetips.AutoPopDelay = False
        updatetips.ShowAlways = True
        updatetips.SetToolTip(Supplier, "Apply changes to supplier information. Double Click on grid below to edit")

    End Sub
    Private Sub Inventory_MouseHover(sender As Object, e As EventArgs) Handles Inventory.MouseHover, Supplier.MouseHover, Inventory.MouseHover
        updatetips.ToolTipTitle = "Edit Inventory Info"
        updatetips.UseFading = True
        updatetips.UseAnimation = True

        updatetips.IsBalloon = True

        updatetips.ShowAlways = True

        updatetips.AutoPopDelay = False
        updatetips.ShowAlways = True
        updatetips.SetToolTip(Inventory, "Apply changes to item information. Double Click on grid below to edit")

    End Sub

    ''====================================================================
    '' selection button
    ''====================================================================
    Dim updatecon As SQLiteConnection = New SQLiteConnection(ConnectionString)
    Dim updatecom As New SQLiteCommand
    Dim updateda As New SQLiteDataAdapter
    Dim dt As DataTable
    Dim dtgv As New DataGridView
      Private Sub Supplier_Click(sender As Object, e As EventArgs) Handles Supplier.Click
        Try
            updatecon.Open()
            updatecom = New SQLiteCommand()
            updateda = New SQLiteDataAdapter
            dt = New DataTable

            With updatecom
                .Connection = updatecon
                .CommandText = sqlsupplier
            End With
            With updateda
                .SelectCommand = updatecom
                .Fill(dt)
            End With
            dtgv.DataSource = updateda
        Catch ex As Exception

        End Try
       

    End Sub

    Private Sub Inventory_Click(sender As Object, e As EventArgs) Handles Inventory.Click
        Try
            updatecon.Open()
            updatecom = New SQLiteCommand()
            updateda = New SQLiteDataAdapter
            dt = New DataTable

            With updatecom
                .Connection = updatecon
                .CommandText = sqlinventory
            End With
            With updateda
                .SelectCommand = updatecom
                .Fill(dt)
            End With
            dtgv.DataSource = updateda
        Catch ex As Exception

        End Try
      

    End Sub
End Class