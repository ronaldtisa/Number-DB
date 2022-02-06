Imports System.Runtime.InteropServices

Public Class Fcontrol

    Private Property WindowState As FormWindowState

    Private Property FormWindowState As FormWindowState

    ''=================
    ''minimize
    ''==================
    Public Sub mini_con()
        Me.WindowState = FormWindowState.Minimized
    End Sub
    ''=================
    ''maxnimize
    ''==================
    Public Sub maxi_con()
        Me.WindowState = FormWindowState.Maximized

    End Sub


End Class
