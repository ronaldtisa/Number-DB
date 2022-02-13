Imports System.Data.SQLite
Imports System.Runtime.InteropServices

Public Class DeleteItem_form

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

    Private Sub Panel1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDoubleClick
        If WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub
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
    Private Const ConnectionString As String = ("Data Source=c:\Number Data Folder\numberform.db")

    Public Sub DeleteItem_detailGrid_fill()
        Dim conn As New My.MySettings
        Using Con As SQLiteConnection = New SQLiteConnection(ConnectionString)
            Using cmd As SQLiteCommand = New SQLiteCommand("SELECT * FROM Code", Con)
                cmd.CommandType = CommandType.Text
                Using sda As SQLiteDataAdapter = New SQLiteDataAdapter(cmd)
                    Using dt As New DataTable
                        Try
                            sda.Fill(dt)
                        Catch ex As Exception
                            ''======================
                            ''warn no database
                            ''======================
                            '' MsgBox("You still have not set up database, please set up in setting page", Title:="Important")

                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Sub


    Private Sub DeleteItem_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        sql = "SELECT * FROM Inventory"
        searchData(sql, searchresult)
    End Sub
    Public Sub RefreshForm()

        sql = "SELECT * FROM Inventory"
        searchData(sql, searchresult)
    End Sub



    ''==========================================================================================================
    ''========= Important search code ==========================================================================
    ''==========================================================================================================
    Dim con As SQLiteConnection = New SQLiteConnection("Data Source=c:\Number Data Folder\numberform.db")
    Dim cmd As SQLiteCommand
    Dim da As SQLiteDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Private Sub search_delete_btn_TextChanged(sender As Object, e As EventArgs) Handles search_delete_btn.TextChanged, search_delete_btn.ModifiedChanged
        sql = "SELECT * FROM Inventory WHERE Code LIKE '%" & search_delete_btn.Text & "%' OR ProductName LIKE '%" & search_delete_btn.Text & "%'"
        searchData(sql, searchresult)
    End Sub


    Private Sub searchData(sql As String, dtg As DataGridView)


        Try
            con.Open()
            cmd = New SQLiteCommand()
            da = New SQLiteDataAdapter
            dt = New DataTable

            With cmd
                .Connection = con
                .CommandText = sql
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
            End With
            dtg.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub


    Dim conrow As SQLiteConnection = New SQLiteConnection("Data Source=c:\Number Data Folder\numberform.db")
    Dim cmdrow As SQLiteCommand
    Dim darow As SQLiteDataAdapter
    Dim dtrow As DataTable
    Dim sqlrow As String
    Private Sub searchresult_CellClick(sender As Object, e As DataGridViewCellEventArgs)

        sql = "SELECT * FROM Inventory WHERE Code LIKE '%" & search_delete_btn.Text & "%' OR ProductName LIKE '%" & search_delete_btn.Text & "%'"
    End Sub
    Private Sub searchgrid_select(sql As String, dtg As DataGridView)
        Try
            conrow.Open()
            cmdrow = New SQLiteCommand()
            darow = New SQLiteDataAdapter
            dtrow = New DataTable
            With cmdrow
                .Connection = conrow
                .CommandText = sqlrow
            End With
            With darow
                .SelectCommand = cmdrow
                .Fill(dtrow)
            End With
            dtg.DataSource = dtrow

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conrow.Close()
            darow.Dispose()
        End Try
    End Sub

    ''================== End====================================================================
    ''==========================================================================================
    Private Sub searchresult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles searchresult.CellContentClick, searchresult.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim row As DataGridViewRow
        row = searchresult.Rows(index)
        If row.Selected Then
            LabelCode.Text = row.Cells(0).Value.ToString()
            LabelProductName.Text = row.Cells(1).Value.ToString()
            LabelCompanyName.Text = row.Cells(2).Value.ToString()
            LabelAddress.Text = row.Cells(3).Value.ToString()
            LabelUnitPrice.Text = row.Cells(4).Value.ToString()
            LabelUnitTax.Text = row.Cells(5).Value.ToString()
        End If
        ''==='======================================
        ''gets a collection that contains all the rows
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rindex As Integer

        Dim row As DataGridViewRow
        row = searchresult.Rows(rindex)
        If MessageBox.Show(String.Format("Do you want to delete This Item?: {0}", row.Cells("Code").Value), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using con As New SQLiteConnection(ConnectionString)
                Using cmd As New SQLiteCommand("DELETE FROM Inventory WHERE Code = @Code", con)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("@Code", row.Cells("Code").Value)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
            Me.RefreshForm()

        End If
    End Sub

  
End Class