<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrder_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseOrder_form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.minimizePurchaseOrderForm = New System.Windows.Forms.Button()
        Me.ClosePurchaseOrderForm = New System.Windows.Forms.Button()
        Me.maximizePurchaseOrderForm = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timebot = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPagePurchaseOrder = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.companylistgrid = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPagePurchaseOrder.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.companylistgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.minimizePurchaseOrderForm)
        Me.Panel1.Controls.Add(Me.ClosePurchaseOrderForm)
        Me.Panel1.Controls.Add(Me.maximizePurchaseOrderForm)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 40)
        Me.Panel1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(544, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Purchase Order"
        '
        'minimizePurchaseOrderForm
        '
        Me.minimizePurchaseOrderForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizePurchaseOrderForm.BackColor = System.Drawing.Color.LightGreen
        Me.minimizePurchaseOrderForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.minimizePurchaseOrderForm.Location = New System.Drawing.Point(1144, 0)
        Me.minimizePurchaseOrderForm.Name = "minimizePurchaseOrderForm"
        Me.minimizePurchaseOrderForm.Size = New System.Drawing.Size(43, 23)
        Me.minimizePurchaseOrderForm.TabIndex = 20
        Me.minimizePurchaseOrderForm.Text = "[ _ ]"
        Me.minimizePurchaseOrderForm.UseVisualStyleBackColor = False
        '
        'ClosePurchaseOrderForm
        '
        Me.ClosePurchaseOrderForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClosePurchaseOrderForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClosePurchaseOrderForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClosePurchaseOrderForm.Location = New System.Drawing.Point(1224, 0)
        Me.ClosePurchaseOrderForm.Name = "ClosePurchaseOrderForm"
        Me.ClosePurchaseOrderForm.Size = New System.Drawing.Size(43, 23)
        Me.ClosePurchaseOrderForm.TabIndex = 18
        Me.ClosePurchaseOrderForm.Text = "[  X  ]"
        Me.ClosePurchaseOrderForm.UseVisualStyleBackColor = False
        '
        'maximizePurchaseOrderForm
        '
        Me.maximizePurchaseOrderForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizePurchaseOrderForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximizePurchaseOrderForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.maximizePurchaseOrderForm.Location = New System.Drawing.Point(1184, 0)
        Me.maximizePurchaseOrderForm.Name = "maximizePurchaseOrderForm"
        Me.maximizePurchaseOrderForm.Size = New System.Drawing.Size(43, 23)
        Me.maximizePurchaseOrderForm.TabIndex = 19
        Me.maximizePurchaseOrderForm.Text = "[ ||| ]"
        Me.maximizePurchaseOrderForm.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 40)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Timebot)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 661)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1264, 20)
        Me.Panel3.TabIndex = 21
        '
        'Timebot
        '
        Me.Timebot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Timebot.AutoSize = True
        Me.Timebot.BackColor = System.Drawing.Color.Transparent
        Me.Timebot.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timebot.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Timebot.Location = New System.Drawing.Point(1182, 3)
        Me.Timebot.Name = "Timebot"
        Me.Timebot.Size = New System.Drawing.Size(34, 15)
        Me.Timebot.TabIndex = 13
        Me.Timebot.Text = "Label1"
        Me.Timebot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(503, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "loading.....?"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 7)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(490, 8)
        Me.ProgressBar1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPagePurchaseOrder)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(100, 30)
        Me.TabControl1.Location = New System.Drawing.Point(0, 40)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(60, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(1272, 624)
        Me.TabControl1.TabIndex = 22
        '
        'TabPagePurchaseOrder
        '
        Me.TabPagePurchaseOrder.BackColor = System.Drawing.Color.Transparent
        Me.TabPagePurchaseOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPagePurchaseOrder.Controls.Add(Me.Panel5)
        Me.TabPagePurchaseOrder.Controls.Add(Me.Panel4)
        Me.TabPagePurchaseOrder.Controls.Add(Me.Panel2)
        Me.TabPagePurchaseOrder.Location = New System.Drawing.Point(4, 34)
        Me.TabPagePurchaseOrder.Name = "TabPagePurchaseOrder"
        Me.TabPagePurchaseOrder.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePurchaseOrder.Size = New System.Drawing.Size(1264, 586)
        Me.TabPagePurchaseOrder.TabIndex = 0
        Me.TabPagePurchaseOrder.Text = "Purchase Order"
        Me.TabPagePurchaseOrder.ToolTipText = "Create Purchase Order bill for item ordering"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TextBox2)
        Me.Panel5.Location = New System.Drawing.Point(377, 25)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(879, 535)
        Me.Panel5.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(304, 8)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 29)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "Purchase Order"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(376, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(880, 584)
        Me.Panel4.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.companylistgrid)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 584)
        Me.Panel2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 22)
        Me.TextBox1.TabIndex = 2
        '
        'companylistgrid
        '
        Me.companylistgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.companylistgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.companylistgrid.Location = New System.Drawing.Point(0, 64)
        Me.companylistgrid.Name = "companylistgrid"
        Me.companylistgrid.ReadOnly = True
        Me.companylistgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.companylistgrid.Size = New System.Drawing.Size(352, 528)
        Me.companylistgrid.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Select Company"
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1264, 586)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Delivery Order"
        Me.TabPage2.ToolTipText = "Update stock using Delivery Order form"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Timer
        '
        '
        'PurchaseOrder_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PurchaseOrder_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PurchaseOrder_form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPagePurchaseOrder.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.companylistgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents minimizePurchaseOrderForm As System.Windows.Forms.Button
    Friend WithEvents ClosePurchaseOrderForm As System.Windows.Forms.Button
    Friend WithEvents maximizePurchaseOrderForm As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPagePurchaseOrder As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timebot As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents companylistgrid As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
