<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryAudit_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryAudit_form))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timebot = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.minimizeInventoryAuditForm = New System.Windows.Forms.Button()
        Me.CloseInventoryAuditForm = New System.Windows.Forms.Button()
        Me.maximizeInventoryAuditForm = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.purchasegridview = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SupplierComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.purchasegridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Timebot)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 622)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1262, 20)
        Me.Panel3.TabIndex = 23
        '
        'Timebot
        '
        Me.Timebot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Timebot.AutoSize = True
        Me.Timebot.BackColor = System.Drawing.Color.Transparent
        Me.Timebot.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timebot.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Timebot.Location = New System.Drawing.Point(1180, 3)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.minimizeInventoryAuditForm)
        Me.Panel1.Controls.Add(Me.CloseInventoryAuditForm)
        Me.Panel1.Controls.Add(Me.maximizeInventoryAuditForm)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1262, 40)
        Me.Panel1.TabIndex = 22
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
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Inventory Audit"
        '
        'minimizeInventoryAuditForm
        '
        Me.minimizeInventoryAuditForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizeInventoryAuditForm.BackColor = System.Drawing.Color.LightGreen
        Me.minimizeInventoryAuditForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.minimizeInventoryAuditForm.Location = New System.Drawing.Point(1142, 0)
        Me.minimizeInventoryAuditForm.Name = "minimizeInventoryAuditForm"
        Me.minimizeInventoryAuditForm.Size = New System.Drawing.Size(43, 23)
        Me.minimizeInventoryAuditForm.TabIndex = 20
        Me.minimizeInventoryAuditForm.Text = "[ _ ]"
        Me.minimizeInventoryAuditForm.UseVisualStyleBackColor = False
        '
        'CloseInventoryAuditForm
        '
        Me.CloseInventoryAuditForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseInventoryAuditForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CloseInventoryAuditForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CloseInventoryAuditForm.Location = New System.Drawing.Point(1222, 0)
        Me.CloseInventoryAuditForm.Name = "CloseInventoryAuditForm"
        Me.CloseInventoryAuditForm.Size = New System.Drawing.Size(43, 23)
        Me.CloseInventoryAuditForm.TabIndex = 18
        Me.CloseInventoryAuditForm.Text = "[  X  ]"
        Me.CloseInventoryAuditForm.UseVisualStyleBackColor = False
        '
        'maximizeInventoryAuditForm
        '
        Me.maximizeInventoryAuditForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizeInventoryAuditForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximizeInventoryAuditForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.maximizeInventoryAuditForm.Location = New System.Drawing.Point(1182, 0)
        Me.maximizeInventoryAuditForm.Name = "maximizeInventoryAuditForm"
        Me.maximizeInventoryAuditForm.Size = New System.Drawing.Size(43, 23)
        Me.maximizeInventoryAuditForm.TabIndex = 19
        Me.maximizeInventoryAuditForm.Text = "[ ||| ]"
        Me.maximizeInventoryAuditForm.UseVisualStyleBackColor = False
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
        'purchasegridview
        '
        Me.purchasegridview.AllowUserToAddRows = False
        Me.purchasegridview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.purchasegridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.purchasegridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.purchasegridview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.ProductCode, Me.ProductName, Me.Stock, Me.ToOrder})
        Me.purchasegridview.Location = New System.Drawing.Point(0, 152)
        Me.purchasegridview.Name = "purchasegridview"
        Me.purchasegridview.Size = New System.Drawing.Size(1264, 472)
        Me.purchasegridview.TabIndex = 24
        '
        'No
        '
        Me.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.No.DataPropertyName = "rowid"
        Me.No.FillWeight = 126.9036!
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 50
        '
        'ProductCode
        '
        Me.ProductCode.DataPropertyName = "Code"
        Me.ProductCode.FillWeight = 93.27411!
        Me.ProductCode.HeaderText = "Product Code"
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.ReadOnly = True
        '
        'ProductName
        '
        Me.ProductName.DataPropertyName = "ProductName"
        Me.ProductName.FillWeight = 93.27411!
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        '
        'Stock
        '
        Me.Stock.DataPropertyName = "Quantity"
        Me.Stock.FillWeight = 93.27411!
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        '
        'ToOrder
        '
        Me.ToOrder.DataPropertyName = "UnitPrice"
        Me.ToOrder.FillWeight = 93.27411!
        Me.ToOrder.HeaderText = "Order Quantity"
        Me.ToOrder.Name = "ToOrder"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.SupplierComboBox1)
        Me.Panel2.Location = New System.Drawing.Point(8, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1248, 96)
        Me.Panel2.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(520, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Telephone No."
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(520, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(464, 20)
        Me.TextBox3.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Product Type :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(8, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(464, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(520, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(520, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(464, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Supplier :"
        '
        'SupplierComboBox1
        '
        Me.SupplierComboBox1.FormattingEnabled = True
        Me.SupplierComboBox1.Location = New System.Drawing.Point(8, 24)
        Me.SupplierComboBox1.Name = "SupplierComboBox1"
        Me.SupplierComboBox1.Size = New System.Drawing.Size(464, 21)
        Me.SupplierComboBox1.TabIndex = 0
        '
        'InventoryAudit_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 642)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.purchasegridview)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InventoryAudit_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryAudit_form"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.purchasegridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Timebot As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents minimizeInventoryAuditForm As System.Windows.Forms.Button
    Friend WithEvents CloseInventoryAuditForm As System.Windows.Forms.Button
    Friend WithEvents maximizeInventoryAuditForm As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents purchasegridview As System.Windows.Forms.DataGridView
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SupplierComboBox1 As System.Windows.Forms.ComboBox
End Class
