Imports System.Data.SQLite
Imports Number.Server
Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices



Public Class mainGUI

    ''=====================
    ''=====================
    ''=====================
    Private Const ConnectionString As String = ("Data Source=c:\Number Data Folder\numberform.db")
    ''======================
    ''======================
    ''======================
    Private Sub mainGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''==================
    
        ''start time
        watch.Start()
        DoubleBuffered = True
        ''================================
        MainCompanyName.Refresh()
        ''================================

        Using Con As SQLiteConnection = New SQLiteConnection(ConnectionString)
            Using cmd As SQLiteCommand = New SQLiteCommand("SELECT Code, ProductName, CompanyName, Address, Telephone, Quantity, UnitPrice FROM Inventory", Con)
                cmd.CommandType = CommandType.Text
                Using sda As SQLiteDataAdapter = New SQLiteDataAdapter(cmd)
                    Using dt As New DataTable
                        Try
                            sda.Fill(dt)
                            ItemView.DataSource = dt
                            ''==================================================================
                            ''get Total price value
                            ''==================================================================
                            dt.Columns.Add("TotalValue", GetType(String))
                            For i As Integer = 0 To dt.Rows.Count - 1
                                Dim value1 As String = Convert.ToString(dt.Rows(i)("Quantity"))
                                Dim value2 As String = Convert.ToString(dt.Rows(i)("UnitPrice"))
                                dt.Rows(i)("TotalValue") = value1 * value2
                            Next
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



        ''===================
    End Sub

    ''======================================
    ''BindGrid====SUB========================
    ''======================================








    ''====================================================
    ''button close
    ''====================================================
    Private Sub CloseMain_Click(sender As Object, e As EventArgs) Handles CloseMain.Click

        Me.Close()

    End Sub
    ''====================================================
    ''buttonMaximized
    ''====================================================
    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximizeMain.Click
        If WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

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
        Dim click As MouseButtons = Windows.Forms.MouseButtons.Left


        If click = True Then
            If WindowState = FormWindowState.Maximized Then
                Me.WindowState = FormWindowState.Normal
            Else
                Me.WindowState = FormWindowState.Maximized
            End If



        End If


    End Sub



    ''====================================================
    ''show database form
    ''====================================================
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles CreateDB.Click
        databaseform.Show()

    End Sub

    ''====================================================
    ''show add item form
    ''====================================================
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles AddItem.Click
        add_item.Show()

    End Sub

    ''====================================================
    ''reload main gui when some form call this bloke probably
    ''====================================================
    Public Sub reload_Main()

        Me.Refresh()


    End Sub

    ''====================================================
    ''watch ? why not
    ''====================================================
    Private Sub watch_Tick(sender As Object, e As EventArgs) Handles watch.Tick
        Dim Today As Object
        Today = Now











        DMYval.Text = Format(Today, "dd / MMMM / yyyy")
        TIval.Text = Format(Today, " h:mm:ss tt")

        secondBar1.Value = Format(Today, "ss")
        MainCompanyName.Text = My.Settings.Name
    End Sub
    Private Sub progress()

        Dim incrementforward As Integer

        incrementforward = incrementforward + 2

        ''ProgressBar1.Value = incrementforward


    End Sub


    ''====================================================
    ''show delete item form
    ''====================================================
    Private Sub DeleteButt_form_Click(sender As Object, e As EventArgs) Handles DeleteButt_form.Click
        DeleteItem_form.Show()

    End Sub


    ''====================================================
    '' Hmmm. Maybe later. I fucking dont know how to do it yet fucker
    ''====================================================
    Private Sub inventory_Audid_bttn_Click(sender As Object, e As EventArgs) Handles inventory_Audid_bttn.Click
        InventoryAudit_form.Show()

    End Sub

    Private Sub CompanySetting_Click(sender As Object, e As EventArgs) Handles CompanySetting.Click
        CompanyConfiguration.Show()

    End Sub

    '' ============================================
    '' menu tooltip
    ''=============================================



    Dim menutips As New ToolTip()
    Private Sub AddItem_MouseHover(sender As Object, e As EventArgs) Handles AddItem.MouseHover

        menutips.ToolTipTitle = "Add Item"
        menutips.UseFading = True
        menutips.UseAnimation = True

        menutips.IsBalloon = True

        menutips.ShowAlways = True

        menutips.AutoPopDelay = False
        menutips.ShowAlways = True
        menutips.SetToolTip(AddItem, "Add New Item information/records that does not exist in your database before, or new product from your supplier")
    End Sub

    Private Sub DeleteButt_form_MouseHover(sender As Object, e As EventArgs) Handles DeleteButt_form.MouseHover
        menutips.ToolTipTitle = "Delete Item"
        menutips.UseFading = True
        menutips.UseAnimation = True

        menutips.IsBalloon = True

        menutips.ShowAlways = True

        menutips.AutoPopDelay = False
        menutips.ShowAlways = True
        menutips.SetToolTip(DeleteButt_form, "Delete Item information/records that is discontinued, or no more exist in your storage")

    End Sub

    Private Sub inventory_Audid_bttn_MouseHover(sender As Object, e As EventArgs) Handles inventory_Audid_bttn.MouseHover
        menutips.ToolTipTitle = "Inventory Audit"
        menutips.UseFading = True
        menutips.UseAnimation = True

        menutips.IsBalloon = True

        menutips.ShowAlways = True

        menutips.AutoPopDelay = False
        menutips.ShowAlways = True
        menutips.SetToolTip(inventory_Audid_bttn, " Use to aid and ease stock inventory housekeeping ")

    End Sub

    Private Sub ItemUpdateBttn_MouseHover(sender As Object, e As EventArgs) Handles ItemUpdateBttn.MouseHover
        menutips.ToolTipTitle = "Update Item Information"
        menutips.UseFading = True
        menutips.UseAnimation = True

        menutips.IsBalloon = True

        menutips.ShowAlways = True

        menutips.AutoPopDelay = False
        menutips.ShowAlways = True
        menutips.SetToolTip(ItemUpdateBttn, "Apply changes to item information if it is obsolete")

    End Sub

    Private Sub CreateDB_MouseHover(sender As Object, e As EventArgs) Handles CreateDB.MouseHover
        menutips.ToolTipTitle = "Create Database"
        menutips.UseFading = True
        menutips.UseAnimation = True

        menutips.IsBalloon = True

        menutips.ShowAlways = True

        menutips.AutoPopDelay = False
        menutips.ShowAlways = True
        menutips.SetToolTip(CreateDB, " Create your database to work with")

    End Sub

    Private Sub CompanySetting_MouseHover(sender As Object, e As EventArgs) Handles CompanySetting.MouseHover
        menutips.ToolTipTitle = "Company Info"
        menutips.UseFading = True
        menutips.UseAnimation = True

        menutips.IsBalloon = True

        menutips.ShowAlways = True

        menutips.AutoPopDelay = False
        menutips.ShowAlways = True
        menutips.SetToolTip(CompanySetting, "Enter your Company information")

    End Sub


  


    Private Sub ItemUpdateBttn_Click(sender As Object, e As EventArgs) Handles ItemUpdateBttn.Click
        UpdateRecord.Show()

    End Sub
End Class