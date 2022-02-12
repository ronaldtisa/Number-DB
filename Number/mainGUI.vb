Imports System.Data.SQLite
Imports Number.Server
Imports System.Data.SqlClient
Imports System.Data

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
        ''==================
        Me.BindGrid()
        ''start time
        watch.Start()
        DoubleBuffered = True





        ''===================
    End Sub

    ''======================================
    ''BindGrid====SUB========================
    ''======================================
    Public Sub BindGrid()
        ''hide last blank line
        ItemView.AllowUserToAddRows = False
        ''Clear collum
        ItemView.Columns.Clear()
        ''add collum
        Dim Code As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Code.Name = "Code"
        Code.HeaderText = "Code"
        Code.DataPropertyName = "Code"
        Code.Width = "69"
        ItemView.Columns.Insert(0, Code)

        Dim ProductName As DataGridViewColumn = New DataGridViewTextBoxColumn()
        ProductName.Name = "ProductName"
        ProductName.HeaderText = "Product Name"
        ProductName.DataPropertyName = "ProductName"
        ProductName.Width = "100"
        ItemView.Columns.Insert(1, ProductName)

        Dim CompanyName As DataGridViewColumn = New DataGridViewTextBoxColumn()
        CompanyName.Name = "CompanyName"
        CompanyName.HeaderText = "Company Name"
        CompanyName.DataPropertyName = "CompanyName"
        CompanyName.Width = "300"
        ItemView.Columns.Insert(2, CompanyName)



        Dim Address As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Address.Name = "Address"
        Address.HeaderText = "Address"
        Address.DataPropertyName = "Address"
        Address.Width = "550"
        ItemView.Columns.Insert(3, Address)

        Dim Telephone As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Telephone.Name = "Telephone"
        Telephone.HeaderText = "Telephone"
        Telephone.DataPropertyName = "Telephone"
        Telephone.Width = "100"
        ItemView.Columns.Insert(4, Telephone)

        Dim Quantity As DataGridViewColumn = New DataGridViewTextBoxColumn()
        Quantity.Name = "Quantity"
        Quantity.HeaderText = "Quantity"
        Quantity.DataPropertyName = "Quantity"
        Quantity.Width = "100"
        ItemView.Columns.Insert(5, Quantity)

        Dim UnitPrice As DataGridViewColumn = New DataGridViewTextBoxColumn()
        UnitPrice.Name = "UnitPrice"
        UnitPrice.HeaderText = "Unit Price"
        UnitPrice.DataPropertyName = "UnitPrice"
        UnitPrice.Width = "100"
        ItemView.Columns.Insert(6, UnitPrice)
        ItemView.DataSource = Nothing

        Dim TotalPriceValue As DataGridViewColumn = New DataGridViewTextBoxColumn()
        TotalPriceValue.Name = "TotalPriceValue"
        TotalPriceValue.HeaderText = "Total Value"
        TotalPriceValue.DataPropertyName = "TotalPriceValue"
        TotalPriceValue.Width = "100"
        ItemView.Columns.Insert(7, TotalPriceValue)

        Dim UnitTax As DataGridViewColumn = New DataGridViewTextBoxColumn()
        UnitTax.Name = "UnitTax"
        UnitTax.HeaderText = "Unit Tax"
        UnitTax.DataPropertyName = "UnitTax"
        UnitTax.Width = "100"
        ItemView.Columns.Insert(8, UnitTax)

        Dim TotalTax As DataGridViewColumn = New DataGridViewTextBoxColumn()
        TotalTax.Name = "TotalTax"
        TotalTax.HeaderText = "Total Tax"
        TotalTax.DataPropertyName = "TotalTax"
        TotalTax.Width = "100"
        ItemView.Columns.Insert(9, TotalTax)





        ItemView.DataSource = Nothing


        ''===============================
        ''bind datagridview(ItemView)
        ''================================

        Me.itemview_fill()

    End Sub


    Public Sub itemview_fill()


        Using Con As SQLiteConnection = New SQLiteConnection(ConnectionString)
            Using cmd As SQLiteCommand = New SQLiteCommand("SELECT Code, ProductName, CompanyName, Address, Telephone, Quantity FROM Inventory", Con)
                cmd.CommandType = CommandType.Text
                Using sda As SQLiteDataAdapter = New SQLiteDataAdapter(cmd)
                    Using dt As New DataTable
                        Try
                            sda.Fill(dt)
                            ItemView.DataSource = dt

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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles CreateDB.Click
        databaseform.Show()

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles AddItem.Click
        add_item.Show()

    End Sub

    Public Sub reload_Main()

        Me.Refresh()
        BindGrid()

    End Sub

    ''==========================
    ''watch
    ''============================
    Private Sub watch_Tick(sender As Object, e As EventArgs) Handles watch.Tick
        Dim Today As Object
        Today = Now


        DMYval.Text = Format(Today, "dd / MMMM / yyyy")
        TIval.Text = Format(Today, " h:mm:ss tt")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub DeleteButt_form_Click(sender As Object, e As EventArgs) Handles DeleteButt_form.Click
        DeleteItem_form.Show()

    End Sub

    Private Sub purchase_order_button_Click(sender As Object, e As EventArgs) Handles purchase_order_button.Click
        PurchaseOrder_form.Show()

    End Sub

    Private Sub inventory_Audid_bttn_Click(sender As Object, e As EventArgs) Handles inventory_Audid_bttn.Click
        InventoryAudit_form.Show()

    End Sub
End Class