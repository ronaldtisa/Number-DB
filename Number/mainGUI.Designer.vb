
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainGUI))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.minimizemain = New System.Windows.Forms.Button()
        Me.CloseMain = New System.Windows.Forms.Button()
        Me.maximizeMain = New System.Windows.Forms.Button()
        Me.ItemUpdateBttn = New System.Windows.Forms.Button()
        Me.DeleteButt_form = New System.Windows.Forms.Button()
        Me.inventory_Audid_bttn = New System.Windows.Forms.Button()
        Me.AddItem = New System.Windows.Forms.Button()
        Me.CompanySetting = New System.Windows.Forms.Button()
        Me.CreateDB = New System.Windows.Forms.Button()
        Me.DMYval = New System.Windows.Forms.Label()
        Me.TIval = New System.Windows.Forms.Label()
        Me.watch = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ItemView = New System.Windows.Forms.DataGridView()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SpinningProgress1 = New Microsoft.TeamFoundation.Controls.WinForms.SpinningProgress()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.secondBar1 = New System.Windows.Forms.ProgressBar()
        Me.MainCompanyName = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImage = CType(resources.GetObject("StatusStrip1.BackgroundImage"), System.Drawing.Image)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 659)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1264, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'minimizemain
        '
        Me.minimizemain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizemain.BackColor = System.Drawing.Color.LightGreen
        Me.minimizemain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.minimizemain.Location = New System.Drawing.Point(1136, 0)
        Me.minimizemain.Name = "minimizemain"
        Me.minimizemain.Size = New System.Drawing.Size(43, 23)
        Me.minimizemain.TabIndex = 7
        Me.minimizemain.Text = "[ _ ]"
        Me.minimizemain.UseVisualStyleBackColor = False
        '
        'CloseMain
        '
        Me.CloseMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseMain.Location = New System.Drawing.Point(1221, 0)
        Me.CloseMain.Name = "CloseMain"
        Me.CloseMain.Size = New System.Drawing.Size(43, 23)
        Me.CloseMain.TabIndex = 5
        Me.CloseMain.Text = "[  X  ]"
        Me.CloseMain.UseVisualStyleBackColor = False
        '
        'maximizeMain
        '
        Me.maximizeMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizeMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximizeMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.maximizeMain.Location = New System.Drawing.Point(1178, 0)
        Me.maximizeMain.Name = "maximizeMain"
        Me.maximizeMain.Size = New System.Drawing.Size(43, 23)
        Me.maximizeMain.TabIndex = 6
        Me.maximizeMain.Text = "[ ||| ]"
        Me.maximizeMain.UseVisualStyleBackColor = False
        '
        'ItemUpdateBttn
        '
        Me.ItemUpdateBttn.BackColor = System.Drawing.SystemColors.Info
        Me.ItemUpdateBttn.BackgroundImage = CType(resources.GetObject("ItemUpdateBttn.BackgroundImage"), System.Drawing.Image)
        Me.ItemUpdateBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ItemUpdateBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ItemUpdateBttn.FlatAppearance.BorderSize = 2
        Me.ItemUpdateBttn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemUpdateBttn.ForeColor = System.Drawing.Color.Black
        Me.ItemUpdateBttn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ItemUpdateBttn.Location = New System.Drawing.Point(242, 8)
        Me.ItemUpdateBttn.Name = "ItemUpdateBttn"
        Me.ItemUpdateBttn.Size = New System.Drawing.Size(72, 72)
        Me.ItemUpdateBttn.TabIndex = 10
        Me.ItemUpdateBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ItemUpdateBttn.UseVisualStyleBackColor = False
        '
        'DeleteButt_form
        '
        Me.DeleteButt_form.BackColor = System.Drawing.SystemColors.Info
        Me.DeleteButt_form.BackgroundImage = CType(resources.GetObject("DeleteButt_form.BackgroundImage"), System.Drawing.Image)
        Me.DeleteButt_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteButt_form.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteButt_form.FlatAppearance.BorderSize = 2
        Me.DeleteButt_form.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButt_form.ForeColor = System.Drawing.Color.Black
        Me.DeleteButt_form.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteButt_form.Location = New System.Drawing.Point(86, 8)
        Me.DeleteButt_form.Name = "DeleteButt_form"
        Me.DeleteButt_form.Size = New System.Drawing.Size(72, 72)
        Me.DeleteButt_form.TabIndex = 9
        Me.DeleteButt_form.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.DeleteButt_form.UseVisualStyleBackColor = False
        '
        'inventory_Audid_bttn
        '
        Me.inventory_Audid_bttn.BackColor = System.Drawing.SystemColors.Info
        Me.inventory_Audid_bttn.BackgroundImage = CType(resources.GetObject("inventory_Audid_bttn.BackgroundImage"), System.Drawing.Image)
        Me.inventory_Audid_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inventory_Audid_bttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.inventory_Audid_bttn.FlatAppearance.BorderSize = 2
        Me.inventory_Audid_bttn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventory_Audid_bttn.ForeColor = System.Drawing.Color.Black
        Me.inventory_Audid_bttn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.inventory_Audid_bttn.Location = New System.Drawing.Point(164, 8)
        Me.inventory_Audid_bttn.Name = "inventory_Audid_bttn"
        Me.inventory_Audid_bttn.Size = New System.Drawing.Size(72, 72)
        Me.inventory_Audid_bttn.TabIndex = 8
        Me.inventory_Audid_bttn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.inventory_Audid_bttn.UseVisualStyleBackColor = False
        '
        'AddItem
        '
        Me.AddItem.BackColor = System.Drawing.Color.White
        Me.AddItem.BackgroundImage = CType(resources.GetObject("AddItem.BackgroundImage"), System.Drawing.Image)
        Me.AddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddItem.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia
        Me.AddItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItem.ForeColor = System.Drawing.Color.Black
        Me.AddItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddItem.Location = New System.Drawing.Point(8, 8)
        Me.AddItem.Name = "AddItem"
        Me.AddItem.Size = New System.Drawing.Size(72, 72)
        Me.AddItem.TabIndex = 6
        Me.AddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.AddItem.UseVisualStyleBackColor = False
        '
        'CompanySetting
        '
        Me.CompanySetting.BackColor = System.Drawing.SystemColors.Info
        Me.CompanySetting.BackgroundImage = CType(resources.GetObject("CompanySetting.BackgroundImage"), System.Drawing.Image)
        Me.CompanySetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CompanySetting.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.CompanySetting.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.CompanySetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CompanySetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CompanySetting.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanySetting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CompanySetting.Location = New System.Drawing.Point(398, 8)
        Me.CompanySetting.Name = "CompanySetting"
        Me.CompanySetting.Size = New System.Drawing.Size(72, 72)
        Me.CompanySetting.TabIndex = 5
        Me.CompanySetting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CompanySetting.UseVisualStyleBackColor = False
        '
        'CreateDB
        '
        Me.CreateDB.BackColor = System.Drawing.SystemColors.Info
        Me.CreateDB.BackgroundImage = CType(resources.GetObject("CreateDB.BackgroundImage"), System.Drawing.Image)
        Me.CreateDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CreateDB.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.CreateDB.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.CreateDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CreateDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CreateDB.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CreateDB.Location = New System.Drawing.Point(320, 8)
        Me.CreateDB.Name = "CreateDB"
        Me.CreateDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CreateDB.Size = New System.Drawing.Size(72, 72)
        Me.CreateDB.TabIndex = 2
        Me.CreateDB.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CreateDB.UseVisualStyleBackColor = False
        '
        'DMYval
        '
        Me.DMYval.AutoSize = True
        Me.DMYval.BackColor = System.Drawing.Color.Transparent
        Me.DMYval.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DMYval.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DMYval.Location = New System.Drawing.Point(963, 0)
        Me.DMYval.Name = "DMYval"
        Me.DMYval.Size = New System.Drawing.Size(57, 18)
        Me.DMYval.TabIndex = 11
        Me.DMYval.Text = "Label1"
        Me.DMYval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TIval
        '
        Me.TIval.AutoSize = True
        Me.TIval.BackColor = System.Drawing.Color.Transparent
        Me.TIval.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIval.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TIval.Location = New System.Drawing.Point(963, 22)
        Me.TIval.Name = "TIval"
        Me.TIval.Size = New System.Drawing.Size(57, 18)
        Me.TIval.TabIndex = 12
        Me.TIval.Text = "Label1"
        Me.TIval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'watch
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 40)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'ItemView
        '
        Me.ItemView.AllowUserToDeleteRows = False
        Me.ItemView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ItemView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.ItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Number, Me.ProductCode, Me.ProductName, Me.CompanyName, Me.TelephoneNumber, Me.CompanyAddress, Me.UnitPrice, Me.Quantity, Me.TotalValue})
        Me.ItemView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ItemView.Location = New System.Drawing.Point(0, 142)
        Me.ItemView.Name = "ItemView"
        Me.ItemView.ReadOnly = True
        Me.ItemView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemView.Size = New System.Drawing.Size(1265, 517)
        Me.ItemView.TabIndex = 10
        '
        'Number
        '
        Me.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Number.HeaderText = "No :"
        Me.Number.Name = "Number"
        Me.Number.ReadOnly = True
        Me.Number.Width = 46
        '
        'ProductCode
        '
        Me.ProductCode.DataPropertyName = "Code"
        Me.ProductCode.HeaderText = "Product Code :"
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.ReadOnly = True
        '
        'ProductName
        '
        Me.ProductName.DataPropertyName = "ProductName"
        Me.ProductName.HeaderText = "Product Name:"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        '
        'CompanyName
        '
        Me.CompanyName.DataPropertyName = "CompanyName"
        Me.CompanyName.HeaderText = "Company Name :"
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.ReadOnly = True
        '
        'TelephoneNumber
        '
        Me.TelephoneNumber.DataPropertyName = "Telephone"
        Me.TelephoneNumber.HeaderText = "Telephone :"
        Me.TelephoneNumber.Name = "TelephoneNumber"
        Me.TelephoneNumber.ReadOnly = True
        '
        'CompanyAddress
        '
        Me.CompanyAddress.DataPropertyName = "Address"
        Me.CompanyAddress.HeaderText = "Company Address :"
        Me.CompanyAddress.Name = "CompanyAddress"
        Me.CompanyAddress.ReadOnly = True
        '
        'UnitPrice
        '
        Me.UnitPrice.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle1.Format = "C1"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.UnitPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.UnitPrice.HeaderText = "Unit Price :"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.HeaderText = "Stock"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 60
        '
        'TotalValue
        '
        Me.TotalValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TotalValue.DataPropertyName = "TotalValue"
        DataGridViewCellStyle2.Format = "C1"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TotalValue.DefaultCellStyle = DataGridViewCellStyle2
        Me.TotalValue.HeaderText = "Total Price Value :"
        Me.TotalValue.Name = "TotalValue"
        Me.TotalValue.ReadOnly = True
        Me.TotalValue.Width = 109
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.SpinningProgress1)
        Me.Panel1.Controls.Add(Me.DMYval)
        Me.Panel1.Controls.Add(Me.TIval)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1266, 40)
        Me.Panel1.TabIndex = 14
        '
        'SpinningProgress1
        '
        Me.SpinningProgress1.BackColor = System.Drawing.Color.Transparent
        Me.SpinningProgress1.InnerRadius = 20
        Me.SpinningProgress1.IsSpinning = False
        Me.SpinningProgress1.Location = New System.Drawing.Point(904, -3)
        Me.SpinningProgress1.Name = "SpinningProgress1"
        Me.SpinningProgress1.OuterRadius = 5
        Me.SpinningProgress1.Size = New System.Drawing.Size(47, 47)
        Me.SpinningProgress1.TabIndex = 17
        Me.SpinningProgress1.TabStop = False
        Me.SpinningProgress1.Text = "SpinningProgress1"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.AddItem)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButt_form)
        Me.FlowLayoutPanel1.Controls.Add(Me.inventory_Audid_bttn)
        Me.FlowLayoutPanel1.Controls.Add(Me.ItemUpdateBttn)
        Me.FlowLayoutPanel1.Controls.Add(Me.CreateDB)
        Me.FlowLayoutPanel1.Controls.Add(Me.CompanySetting)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 47)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(642, 92)
        Me.FlowLayoutPanel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.secondBar1)
        Me.Panel2.Controls.Add(Me.MainCompanyName)
        Me.Panel2.Location = New System.Drawing.Point(959, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(302, 96)
        Me.Panel2.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(8, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Hardwork = Curiousity"
        '
        'secondBar1
        '
        Me.secondBar1.Location = New System.Drawing.Point(7, 3)
        Me.secondBar1.MarqueeAnimationSpeed = 900
        Me.secondBar1.Maximum = 60
        Me.secondBar1.Name = "secondBar1"
        Me.secondBar1.Size = New System.Drawing.Size(287, 10)
        Me.secondBar1.Step = 60
        Me.secondBar1.TabIndex = 17
        '
        'MainCompanyName
        '
        Me.MainCompanyName.Location = New System.Drawing.Point(7, 13)
        Me.MainCompanyName.Multiline = True
        Me.MainCompanyName.Name = "MainCompanyName"
        Me.MainCompanyName.Size = New System.Drawing.Size(288, 34)
        Me.MainCompanyName.TabIndex = 0
        '
        'mainGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ItemView)
        Me.Controls.Add(Me.minimizemain)
        Me.Controls.Add(Me.CloseMain)
        Me.Controls.Add(Me.maximizeMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainGUI"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents minimizemain As System.Windows.Forms.Button
    Friend WithEvents CloseMain As System.Windows.Forms.Button
    Friend WithEvents maximizeMain As System.Windows.Forms.Button
    Friend WithEvents CreateDB As System.Windows.Forms.Button
    Friend WithEvents CompanySetting As System.Windows.Forms.Button
    Friend WithEvents AddItem As System.Windows.Forms.Button
    Friend WithEvents DMYval As System.Windows.Forms.Label
    Friend WithEvents TIval As System.Windows.Forms.Label
    Friend WithEvents watch As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents inventory_Audid_bttn As System.Windows.Forms.Button
    Friend WithEvents DeleteButt_form As System.Windows.Forms.Button
    Friend WithEvents ItemUpdateBttn As System.Windows.Forms.Button
    Friend WithEvents ItemView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelephoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MainCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents secondBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents SpinningProgress1 As Microsoft.TeamFoundation.Controls.WinForms.SpinningProgress
End Class



Public Class Progress_bar : Inherits Control

    '#Region "Variables"    ' UnComment the '#Region lines to make the code collapsible

    Private min As Integer = 0
    Private max As Integer = 100
    Private val As Integer = 0
    Public usegrad As Boolean = False
    Public bkColor As Color = Color.Transparent
    Public enBackColor As Boolean = False
    Public BarColor As Color = Color.Blue
    Public gradcolor1 As Color = Color.DeepSkyBlue
    Public gradcolor2 As Color = Color.Blue
    Dim HColor As Color = Color.WhiteSmoke
    Dim hStyle As HatchStyle
    Dim drawhBrush As Boolean = False
    Dim hatchBackColor As Color = Color.Transparent '?
    Public drwLabel As Boolean = False
    Public draw3D As Boolean = False

    '#End Region

    '#Region "New/Create Control"

    Public Sub New()
        MyBase.New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
    End Sub

    '#End Region

    '#Region"Properties"

    Public Property Minimum() As Integer
        Get
            Return min
        End Get
        Set(ByVal Value As Integer)
            '
            If (Value < 0) Then
                min = 0
            End If
            '
            If (Value > max) Then
                min = Value
                min = Value
            End If
            '
            If (Value < min) Then
                val = min
            End If
            '
            Me.Invalidate()
            '
        End Set
    End Property

    Public Property Maximum() As Integer
        Get
            Return max
        End Get
        Set(ByVal Value As Integer)

            If (Value < min) Then
                min = Value
            End If

            max = Value

            If (val > max) Then
                val = max
            End If

            Me.Invalidate()

        End Set
    End Property

    Public Property Value As Integer
        '
        Get
            Return val
        End Get
        '
        Set(ByVal Value As Integer)
            Dim oldvalue As Integer = val
            '
            If (Value < min) Then
                val = min
            ElseIf (Value > max) Then
                val = max
            Else
                val = Value
            End If
            '
            Dim newValueRect As Rectangle = Me.ClientRectangle
            Dim oldValueRect As Rectangle = Me.ClientRectangle
            Dim percent As Decimal
            '
            percent = (val - min) / (max - min)
            newValueRect.Width = newValueRect.Width * percent
            '
            percent = (oldvalue - min) / (max - min)
            oldValueRect.Width = oldValueRect.Width * percent
            '
            Dim updateRect As Rectangle = New Rectangle()
            '
            If (newValueRect.Width > oldValueRect.Width) Then
                updateRect.X = oldValueRect.Size.Width
                updateRect.Width = newValueRect.Width - oldValueRect.Width
            Else
                updateRect.X = newValueRect.Size.Width
                updateRect.Width = oldValueRect.Width - newValueRect.Width
            End If
            '
            updateRect.Height = Me.Height
            '
            Me.Invalidate(updateRect.X)
        End Set
        '
    End Property

    Public Property ProgressBarColor() As Color
        Get
            Return BarColor
        End Get
        Set(ByVal Value As Color)
            BarColor = Value
            Me.Invalidate()
        End Set
    End Property

    Public Property GradientColor1() As Color
        Get
            Return gradcolor1
        End Get
        Set(ByVal value As Color)
            gradcolor1 = value
            Me.Invalidate()
        End Set
    End Property

    Public Property GradientColor2() As Color
        Get
            Return gradcolor2
        End Get
        Set(ByVal value As Color)
            gradcolor2 = value
            Me.Invalidate()
        End Set
    End Property

    Public Property UseHatchBrush() As Boolean
        Get
            Return drawhBrush
        End Get
        Set(ByVal value As Boolean)
            drawhBrush = value
            Me.Invalidate()
        End Set
    End Property

    Public Property HatchColor() As Color
        Get
            Return HColor
        End Get
        Set(ByVal value As Color)

            HColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property HatchStyle() As HatchStyle
        Get
            Return hStyle
        End Get
        Set(ByVal value As HatchStyle)
            hStyle = value
            Me.Invalidate()
        End Set
    End Property

    Public Property UseGradient() As Boolean
        Get
            Return usegrad
        End Get
        Set(ByVal value As Boolean)
            usegrad = value
            Me.Invalidate()
        End Set
    End Property

    Public Property DrawLabel() As Boolean
        Get
            Return drwLabel
        End Get
        Set(ByVal value As Boolean)
            drwLabel = value
            Me.Invalidate()
        End Set
    End Property

    Public Property Draw3DBorder() As Boolean
        Get
            Return draw3D
        End Get
        Set(ByVal value As Boolean)
            draw3D = value
            Me.Invalidate()
        End Set
    End Property

    Public Shadows Property BackColor() As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            MyBase.BackColor = value
            Me.Invalidate()
        End Set
    End Property

    '#End Region

    Private Sub Draw_3D_Border(ByVal g As Graphics)
        '
        Dim penWidth As Integer = Pens.White.Width
        g.DrawLine(Pens.DarkGray, New Point(Me.ClientRectangle.Left, _
        Me.ClientRectangle.Top), New Point(Me.ClientRectangle.Width - _
        penWidth, Me.ClientRectangle.Top))
        g.DrawLine(Pens.DarkGray, New Point(Me.ClientRectangle.Left, _
        Me.ClientRectangle.Top), New Point(Me.ClientRectangle.Left, _
        Me.ClientRectangle.Height - penWidth))
        g.DrawLine(Pens.White, New Point(Me.ClientRectangle.Left, _
        Me.ClientRectangle.Height - penWidth), New Point(Me.ClientRectangle.Width - _
        penWidth, Me.ClientRectangle.Height - penWidth))
        g.DrawLine(Pens.White, New Point(Me.ClientRectangle.Width - _
    penWidth, Me.ClientRectangle.Top), New Point(Me.ClientRectangle.Width - _
    penWidth, Me.ClientRectangle.Height - penWidth))
        '
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        Me.Invalidate()     'Invalidate to resize control
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        '
        Dim g As Graphics = e.Graphics
        Dim brush As SolidBrush = New SolidBrush(BarColor) ' new solid brush from BarColor
        Dim bkbrush As New SolidBrush(MyBase.BackColor)    ' new solidbrush from backcolor
        Dim hbrush As New HatchBrush(hStyle, _
        HColor, Color.Transparent) ' new hatch brush (forecolor, backcolor)
        'new lineargradient brush
        Dim gbrush As LinearGradientBrush = New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(255, gradcolor1), _
    Color.FromArgb(255, gradcolor2), LinearGradientMode.Vertical)
        Dim percent As Decimal = (val - min) / (max - min) ' calculate the percent
        Dim cliRect As Rectangle = New Rectangle(0, 0, _
        Me.ClientRectangle.Width, Me.ClientRectangle.Height) ' Control rectangle
        Dim rect As Rectangle = New Rectangle(1, 1, _
        Me.ClientRectangle.Width - 2, Me.ClientRectangle.Height - 2) ' Progress rectangle
        '
        rect.Width = rect.Width * percent
        '
        ' Smoothing and quality mode
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.CompositingQuality = CompositingQuality.AssumeLinear
        '
        If UseGradient = True Then
            g.FillRectangle(bkbrush, cliRect) ' enable back color
            g.FillRectangle(gbrush, rect)     ' Use Gradient
            If drawhBrush = True Then
                g.FillRectangle(hbrush, rect) ' draw hatch brush
            End If

        End If
        '
        If UseGradient = False Then
            g.FillRectangle(bkbrush, cliRect)
            g.FillRectangle(brush, rect)
            If drawhBrush = True Then
                g.FillRectangle(hbrush, rect)
            End If
            ' g.DrawRectangle(Pens.Black, cliRect)  ' Draw a single Border
        End If
        '
        If draw3D = True Then
            Draw_3D_Border(g) ' draw the 3d border using g as graphics
        End If
        '
        If DrawLabel = True Then
            Dim str As String = CType(val & "%", String) ' convert val into a string
            Dim mybrush As New SolidBrush(Me.ForeColor)  ' make ForeColor as brush
            g.DrawString(str, Me.Font, mybrush, _
            New Point((Me.ClientRectangle.Width / 2) - str.Length * 4, _
            (Me.ClientRectangle.Height / 2) - (FontHeight / 2))) ' Draw string 
        End If
        '
        brush.Dispose()
        bkbrush.Dispose()
        hbrush.Dispose()
        gbrush.Dispose()
        g.Dispose()
        '
    End Sub

End Class
