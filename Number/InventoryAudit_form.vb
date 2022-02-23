﻿Imports System.Runtime.InteropServices
Imports System.Data.SQLite

Public Class InventoryAudit_form
    Private Const ConnectionString As String = ("Data Source=c:\Number Data Folder\numberform.db")
    '' opt sql command line ========================

    Private Const sqlsupplier As String = "SELECT Registration, CompanyName, CompanyAddress, CompanyTelephone FROM Supplier"


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


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupplierComboBox1.SelectedIndexChanged

    End Sub

    Dim Auditcon As SQLiteConnection = New SQLiteConnection(ConnectionString)
    Dim Auditcom As New SQLiteCommand
    Dim Auditda As New SQLiteDataAdapter
    Dim dts As DataSet


    Private Sub InventoryAudit_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Auditcon.Open()
            Auditcom = New SQLiteCommand()
            Auditda = New SQLiteDataAdapter
            dts = New DataSet

            With Auditcom
                .Connection = Auditcon
                .CommandText = sqlsupplier
            End With
            With Auditda
                .SelectCommand = Auditcom
                .Fill(dts)
            End With

            Auditda.Dispose()
            Auditcom.Dispose()
            Auditcon.Close()
            SupplierComboBox1.DataSource = dts.Tables(0)
            SupplierComboBox1.ValueMember = "CompanyName"
            SupplierComboBox1.DisplayMember = "CompanyName"
        Catch ex As Exception

        End Try
    End Sub
End Class