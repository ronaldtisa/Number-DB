Imports System.Data.SQLite
Imports System.IO
Imports System.Windows.Forms.DataGridView
Imports Number.mainGUI
Imports System.Windows




Public Class Server

    '' opt sql command line ========================

    Private Const tblsupplier As String = "Create table 'Supplier'( 'Id_num' INT,'Registration' NCHAR, 'CompanyName' NCHAR, 'CompanyAddress' NCHAR, 'CompanyTelephone' NCHAR, PRIMARY KEY( Id_num, CompanyName ));"
    Private Const tblsales As String = "Create table 'Sales'( 'Id_PurchaseReceiptNum', INT,' Date' NUM,'ProductName' NCHAR);"

    Private Const tblManagement As String = "Create table 'Management' ( 'Id_UserName' NCHAR, 'ContactNumber' NCHAR, 'Address' NCHAR, 'Duty' NCHAR, PRIMARY KEY ( Id_UserName ));"



    ''where to store file
    ''named database
    ''combine database file together
    ''create connection string - using sql
    Dim location As String = "c:\Number Data Folder"
    Dim fileName As String = "numberform.db"
    Dim fullPath As String = System.IO.Path.Combine(location, fileName)
    Public connectionString As String = String.Format("Data Source={0}", fullPath)

    Public Sub createFolder()

        ' Specify the directory you want to manipulate.
        Dim path As String = "c:\Number Data Folder"


        ' Determine whether the directory exists.
        If Directory.Exists(path) Then
            MsgBox("That path exists already. Use folder? This process is irreversible!", MsgBoxStyle.OkCancel, MsgBoxStyle.Information)

            Dim MsgBoxResult As Boolean
            If MsgBoxResult = False Then
                Return
            End If


        Else
            ' Try to create the directory.
            Dim di As DirectoryInfo = Directory.CreateDirectory(path)
            MsgBox("Folder path created.", MsgBoxStyle.Information, Title:="Success")
            createDatabase()
        End If


        ''==================================================================================
        ''=====maybe later add delete function===========modify this code =====================================
        ' Delete the directory.
        '' di.Delete()
        ''MsgBox("The directory was deleted successfully.")
        ''====================================================================================
        ''=============================================================================

    End Sub

    ''create boolean value
    ''return value if file exist or not
    Private Function duplicateDataBase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function

    Dim servercon As SQLiteConnection
    Dim servercom As New SQLiteCommand
    Dim serverda As New SQLiteDataAdapter
    Dim dts As DataSet

    Public Sub createDatabase()
        If Not duplicateDataBase(fullPath) Then


            Dim createTable As String = "CREATE TABLE 'Inventory'( 'Code' NCHAR, 'ProductName' NCHAR,'CompanyName' NCHAR, 'Address' NCHAR, 'Telephone' NCHAR, 'Quantity' NCHAR NULL, 'UnitPrice'NUM NULL, 'UnitTax' NUM NULL );"

            Using SqlConn As New SQLiteConnection(connectionString)
                Dim cmd As New SQLiteCommand(createTable, SqlConn)
                SqlConn.Open()
                cmd.ExecuteNonQuery()
                Try
                    MsgBox("Success", MsgBoxStyle.Information, Title:="Success")
                Catch ex As Exception
                    MsgBox("File Already exist")
                End Try


                ''======================================================
                ''need to edit filder and file bug
                ''=====================================================


            End Using
            ''============= 2 ============================================
            Using servercon As New SQLiteConnection(connectionString)
                servercom = New SQLiteCommand(tblsupplier, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                    MsgBox("Success step 2", MsgBoxStyle.Information, Title:="Success")
                Catch ex As Exception
                    MsgBox("error on step 2")
                End Try

            End Using

            ''============= 3 ============================================
            Using servercon As New SQLiteConnection(connectionString)
                servercom = New SQLiteCommand(tblsales, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                    MsgBox("Success step 3", MsgBoxStyle.Information, Title:="Success")
                Catch ex As Exception
                    MsgBox("error on step 3")
                End Try

            End Using

            ''============= 4 ============================================
            Using servercon As New SQLiteConnection(connectionString)
                servercom = New SQLiteCommand(tblManagement, servercon)
                servercon.Open()
                Try
                    servercom.ExecuteNonQuery()
                    MsgBox("Success step 4", MsgBoxStyle.Information, Title:="Success")
                Catch ex As Exception
                    MsgBox("error on step 4")
                End Try

            End Using





        End If

    End Sub



   
End Class
