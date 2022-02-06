
Imports System.Data.SqlClient




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
End Class
