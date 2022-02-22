Imports System.Runtime.InteropServices

Public Class CompanyConfiguration



    Private Sub saveSetting_Click(sender As Object, e As EventArgs) Handles saveSetting.Click



        If CompanyRegistration.Text.Trim = "" Then
            MsgBox("Registration Number cannot be blank", MsgBoxStyle.Information, Title:="Error")
            CompanyRegistration.Focus()
            Exit Sub

        End If
        If CompanyNameSet.Text.Trim = "" Then
            MsgBox("Company Name annot be blank", MsgBoxStyle.Information, Title:="Error")
            CompanyNameSet.Focus()
            Exit Sub
        End If
        If AddressPosSet.Text.Trim = "" Then
            MsgBox("Address cannot be blank", MsgBoxStyle.Information, Title:="Error")
            AddressPosSet.Focus()
            Exit Sub
        End If
        If ContactInfoTelephone.Text.Trim = "" Then
            MsgBox("Telephone/Phone Number Cannot be blank", MsgBoxStyle.Information, Title:="Error")
            ContactInfoTelephone.Focus()
            Exit Sub
        End If
        If TaxValSet.Text.Trim = "" Then
            MsgBox("Tax info cannot be blank, and only accept number", MsgBoxStyle.Information, Title:="Error")
            TaxValSet.Focus()
            Exit Sub
        End If

      
        Try
          
            go()
            Me.Refresh()
            MsgBox("Data saved. Successfully reload setting", MsgBoxStyle.OkOnly, Title:="Success")

        Catch ex As Exception

        End Try

      
    End Sub

    ''===================================
    ''progress
    ''===================================
    Public Sub go()
       
        My.Settings.Registration = CompanyRegistration.Text
        My.Settings.Name = CompanyNameSet.Text
        My.Settings.Address = AddressPosSet.Text
        My.Settings.Telephone = ContactInfoTelephone.Text
        My.Settings.Tax = TaxValSet.Text
        My.Settings.Save()
      



    End Sub


    Private Sub progress()

        Dim incrementforward As Integer

        incrementforward = incrementforward + 2

        ProgressBar1.Value = incrementforward


    End Sub

    ''===================================
    ''progress 
    ''===================================


    ''====================================================
    ''button close
    ''====================================================
    Private Sub CloseMain_Click(sender As Object, e As EventArgs) Handles CloseCompanyConfigurationForm.Click

        Me.Close()

    End Sub
    ''====================================================
    ''buttonMaximized
    ''====================================================
    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximizeCompanyConfigurationForm.Click
        If WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    ''====================================================
    ''button Minimized
    ''====================================================
    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimizeCompanyConfigurationForm.Click
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
End Class