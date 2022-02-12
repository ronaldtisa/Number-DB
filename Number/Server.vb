Imports System.Data.SQLite
Imports System.IO
Imports System.Windows.Forms.DataGridView
Imports Number.mainGUI
Imports System.Windows




Public Class Server
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


    Public Sub createDatabase()
        If Not duplicateDataBase(fullPath) Then

            Dim createTable As String = "CREATE TABLE 'Inventory'( 'Code' NCHAR, 'ProductName' NCHAR,'CompanyName' NCHAR, 'Address' NCHAR, 'Telephone' NCHAR, 'Quantity' NCHAR);"

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

        End If

    End Sub



    ''create boolean value
    ''return value if file exist or not
    Private Function duplicateDataBase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function


    ''=========================================
    ''dataview
    ''=========================================


    Public Sub dataviewSQLite()
       

    End Sub




End Class
