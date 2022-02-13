Imports System.Runtime.InteropServices
Imports System.Data.SQLite



Public Class PurchaseOrder_form
    Private Sub ClosePurchaseOrderForm_Click(sender As Object, e As EventArgs) Handles ClosePurchaseOrderForm.Click
        Me.Close()
    End Sub

    Private Sub maximizePurchaseOrderForm_Click(sender As Object, e As EventArgs) Handles maximizePurchaseOrderForm.Click
        If WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub
    Private Sub minimizePurchaseOrderForm_Click(sender As Object, e As EventArgs) Handles minimizePurchaseOrderForm.Click
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

   

    Private Sub PurchaseOrder_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        Timer.Start()
        retrievedata()

    End Sub
    Private Sub watch_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim Today As Object
        Today = Now
        Timebot.Text = Format(Today, " h:mm:ss tt")
    End Sub

    ''=============================================================================
    ''========== User Form ========================================================
    ''=============================================================================
    Private Const ConnectionString As String = ("Data Source=c:\Number Data Folder\numberform.db")
    Public Sub retrievedata()
        Dim purchaseDataCon As New SQLiteConnection(ConnectionString)
        Dim purchaseDataCom As New SQLiteCommand("Select name As Supplier From sqlite_master where type='table' order by name;", purchaseDataCon)
        purchaseDataCom.CommandType = CommandType.Text
        Dim purchaseDataAdap As New SQLiteDataAdapter(purchaseDataCom)
        Dim datagrid_dt As DataTable = New DataTable
        Try
            purchaseDataAdap.Fill(datagrid_dt)
            companylistgrid.DataSource = datagrid_dt
        Catch ex As Exception
        End Try

    End Sub
End Class
