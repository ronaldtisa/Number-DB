
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices




Public Class databaseform
    Const CONNECTION_STR As String = "Data Source=customers.db;Version=3;"







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String

        Dim myConn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\MVS Project\Number\Number\database.mdf ;Integrated Security=True")

        str = "CREATE DATABASE MyDatabase ON PRIMARY " & _
        "(NAME = MyDatabase_Data, " & _
        " FILENAME = 'C:\SQLNumber\MyDatabaseData.mdf', " & _
        " SIZE = 2MB, " & _
        " MAXSIZE = 10MB, " & _
        " FILEGROWTH = 10%)" & _
        " LOG ON " & _
        "(NAME = MyDatabase_Log, " & _
        " FILENAME = 'C:\SQLNumber\MyDatabaseLog.ldf', " & _
        " SIZE = 1MB, " & _
        " MAXSIZE = 5MB, " & _
        " FILEGROWTH = 10%)"

        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)

        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Database is created successfully", _
            "MyProgram", MessageBoxButtons.OK, _
            MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try




    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Server As New Server
        Try
            Server.createFolder()

        Catch ex As Exception

        End Try


    End Sub



    Private Sub minimizemain_Click(sender As Object, e As EventArgs) Handles minimizemain.Click

    End Sub
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

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If

    End Sub
    ''=========================================================================
    ''========taskbar drag end=====================================================
    ''=========================================================================

End Class
