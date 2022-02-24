Imports System.Data.SQLite
Imports Number.Server
Imports System.Data.SqlClient
Imports System.Data

Public Class add_item

    Private Const ConnectionString As String = ("Data Source=c:\Number Data Folder\numberform.db")


    Dim sqliteCon As SQLiteConnection
    Dim sqliteCom As SQLiteCommand

    ''====================================================
    ''button close
    ''====================================================
    Private Sub exitAdd_Click(sender As Object, e As EventArgs) Handles exitAdd.Click
        Me.Close()
        mainGUI.ItemView.Refresh()



    End Sub
    ''====================================================
    ''buttonMaximized
    ''====================================================
    Private Sub maximizeAdd_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    ''====================================================
    ''button Minimized
    ''====================================================
    Private Sub minimizeAdd_Click(sender As Object, e As EventArgs) Handles minimizeAdd.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    ''=======================================================================================
    '' saving button code
    ''========================================================================================
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If ItemCode.Text.Trim = "" Then
            MsgBox("Item Code Cannot be blank", MsgBoxStyle.Information, Title:="Error")
            ItemCode.Focus()
            Exit Sub
        End If
        If ItemName.Text.Trim = "" Then
            MsgBox("Item Name Cannot be blank", MsgBoxStyle.Information, Title:="Error")
            ItemName.Focus()
            Exit Sub

        End If
        If CompanydName.Text.Trim = "" Then
            MsgBox("Company Name Cannot be blank", MsgBoxStyle.Information, Title:="Error")
            CompanydName.Focus()
            Exit Sub
        End If
        If Address.Text.Trim = "" Then
            MsgBox("Address Cannot be blank", MsgBoxStyle.Information, Title:="Error")
            Address.Focus()
            Exit Sub
        End If
        If Telephone.Text.Trim = "" Then
            MsgBox("Telephone/Phone Number Cannot be blank", MsgBoxStyle.Information, Title:="Error")
            Telephone.Focus()
            Exit Sub
        End If
        '' Dim createTable As String = "INSERT INTO 'Inventory'( 'Code' NCHAR, 'ProductName' NCHAR, 'Address' NCHAR, 'Telephone' NCHAR);"

        Dim sqlite_Con As New SQLiteConnection(ConnectionString)
        Dim sqlite_com As New SQLiteCommand("INSERT INTO Inventory (Code, ProductName, CompanyName, Address, Telephone, Quantity, UnitPrice, UnitTax) VALUES('" + ItemCode.Text + "','" + ItemName.Text + "','" + CompanydName.Text + "','" + Address.Text + "','" + Telephone.Text + "','" + Quantity.Text + "','" + UnitPrice.Text + "', '" + UnitTax.Text + "')", sqlite_Con)
        'integer holds the number of records inserted
        'you need to provide password for sql server
        sqlite_Con.Open()
        sqlite_com.ExecuteNonQuery()
        mainGUI.reload_Main()
        sqlite_Con.Close()
        MsgBox("New Item Inserted", MsgBoxStyle.OkOnly)
        ItemCode.Clear()
        ItemName.Clear()
        CompanydName.Clear()
        Address.Clear()
        Telephone.Clear()
        Quantity.Clear()
        UnitPrice.Clear()
        UnitTax.Clear()
        ''==========================================================
        '' update main menu datagrid=after insert data==============
        ''==========================================================
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles SaveSupplier.Click
        If NewSupplierRegistration.Text.Trim = "" Then
            MsgBox("Registration Number Cannot be blank", MsgBoxStyle.Information, Title:="Error")
            NewSupplierRegistration.Focus()
            Exit Sub
        End If
        If NewSupplierName.Text.Trim = "" Then
            MsgBox("CompanyName Cannot be blank", MsgBoxStyle.Information, Title:="Error")
            NewSupplierName.Focus()
            Exit Sub
        End If
        If NewSupplierAddress.Text.Trim = "" Then
            MsgBox("Address Cannot be blank", MsgBoxStyle.Information, Title:="Error")
            ItemCode.Focus()
            Exit Sub
        End If
        If NewSupplierTelephone.Text.Trim = "" Then
            MsgBox("Telephone Number Cannot be blank", MsgBoxStyle.Information, Title:="Error")
            ItemCode.Focus()
            Exit Sub
        End If
        Dim sqliteCon As New SQLiteConnection(ConnectionString)
        Dim sqliteCom = New SQLiteCommand("INSERT INTO Supplier (Registration, CompanyName, CompanyAddress, CompanyTelephone ) VALUES( '" + NewSupplierRegistration.Text + "', '" + NewSupplierName.Text + "', '" + NewSupplierAddress.Text + "', '" + NewSupplierTelephone.Text + "')", sqliteCon)
        Try
            sqliteCon.Open()
            sqliteCom.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error entering Supplier Data", MsgBoxStyle.OkOnly)
        End Try
        MsgBox("New Item Inserted", MsgBoxStyle.OkOnly)
    End Sub
End Class