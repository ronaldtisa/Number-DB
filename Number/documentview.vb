Public Class documentview

    Private Sub documentview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'numberformDataSet.Inventory' table. You can move, or remove it, as needed.
   
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class