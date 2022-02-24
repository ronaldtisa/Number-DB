<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_item))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.minimizeAdd = New System.Windows.Forms.Button()
        Me.exitAdd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ItemCode = New System.Windows.Forms.TextBox()
        Me.CompanydName = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Telephone = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.ItemName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UnitTax = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UnitPrice = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.SaveSupplier = New System.Windows.Forms.Button()
        Me.NewSupplierTelephone = New System.Windows.Forms.TextBox()
        Me.NewSupplierAddress = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NewSupplierName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NewSupplierRegistration = New System.Windows.Forms.TextBox()
        Me.ControlList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImage = CType(resources.GetObject("StatusStrip1.BackgroundImage"), System.Drawing.Image)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 598)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1071, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'minimizeAdd
        '
        Me.minimizeAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizeAdd.BackColor = System.Drawing.Color.LightGreen
        Me.minimizeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.minimizeAdd.Location = New System.Drawing.Point(990, 0)
        Me.minimizeAdd.Name = "minimizeAdd"
        Me.minimizeAdd.Size = New System.Drawing.Size(43, 23)
        Me.minimizeAdd.TabIndex = 7
        Me.minimizeAdd.Text = "[ _ ]"
        Me.minimizeAdd.UseVisualStyleBackColor = False
        '
        'exitAdd
        '
        Me.exitAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.exitAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitAdd.Location = New System.Drawing.Point(1030, 0)
        Me.exitAdd.Name = "exitAdd"
        Me.exitAdd.Size = New System.Drawing.Size(43, 23)
        Me.exitAdd.TabIndex = 5
        Me.exitAdd.Text = "[  X  ]"
        Me.exitAdd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1071, 50)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(200, 100)
        Me.TabPage1.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(8, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(139, 119)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Create Database"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1257, 128)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Setting"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(167, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 119)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Company"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(322, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 119)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Create Database"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(481, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 119)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Create Database"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(10, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 119)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Create Database"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ItemCode
        '
        Me.ItemCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemCode.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemCode.Location = New System.Drawing.Point(0, 37)
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.Size = New System.Drawing.Size(634, 29)
        Me.ItemCode.TabIndex = 9
        '
        'CompanydName
        '
        Me.CompanydName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompanydName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanydName.Location = New System.Drawing.Point(0, 158)
        Me.CompanydName.Name = "CompanydName"
        Me.CompanydName.Size = New System.Drawing.Size(804, 29)
        Me.CompanydName.TabIndex = 10
        '
        'Address
        '
        Me.Address.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Address.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(0, 218)
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(804, 110)
        Me.Address.TabIndex = 11
        '
        'Telephone
        '
        Me.Telephone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Telephone.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telephone.Location = New System.Drawing.Point(0, 358)
        Me.Telephone.Name = "Telephone"
        Me.Telephone.Size = New System.Drawing.Size(804, 29)
        Me.Telephone.TabIndex = 12
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(610, 440)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 30)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Add Item"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Quantity
        '
        Me.Quantity.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity.Location = New System.Drawing.Point(0, 410)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(260, 29)
        Me.Quantity.TabIndex = 14
        '
        'ItemName
        '
        Me.ItemName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemName.Location = New System.Drawing.Point(0, 98)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(804, 29)
        Me.ItemName.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Item Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Product Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Company Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Address :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Telephone :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Quantity :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(450, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 31)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Add New Item"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(320, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 18)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Tax :"
        '
        'UnitTax
        '
        Me.UnitTax.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitTax.Location = New System.Drawing.Point(320, 410)
        Me.UnitTax.Name = "UnitTax"
        Me.UnitTax.Size = New System.Drawing.Size(190, 29)
        Me.UnitTax.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(530, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 18)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Unit Price :"
        '
        'UnitPrice
        '
        Me.UnitPrice.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitPrice.Location = New System.Drawing.Point(530, 410)
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Size = New System.Drawing.Size(190, 29)
        Me.UnitPrice.TabIndex = 26
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.ImageList = Me.ControlList1
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TabControl1.ItemSize = New System.Drawing.Size(18, 72)
        Me.TabControl1.Location = New System.Drawing.Point(0, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1090, 550)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.Button7)
        Me.TabPage3.Controls.Add(Me.UnitPrice)
        Me.TabPage3.Controls.Add(Me.ItemName)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.UnitTax)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Quantity)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Telephone)
        Me.TabPage3.Controls.Add(Me.ItemCode)
        Me.TabPage3.Controls.Add(Me.Address)
        Me.TabPage3.Controls.Add(Me.CompanydName)
        Me.TabPage3.ImageIndex = 0
        Me.TabPage3.Location = New System.Drawing.Point(4, 76)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1082, 470)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Add New Item"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TabPage4.Controls.Add(Me.SaveSupplier)
        Me.TabPage4.Controls.Add(Me.NewSupplierTelephone)
        Me.TabPage4.Controls.Add(Me.NewSupplierAddress)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.NewSupplierName)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.NewSupplierRegistration)
        Me.TabPage4.ImageIndex = 1
        Me.TabPage4.Location = New System.Drawing.Point(4, 76)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1082, 470)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "New Supplier"
        '
        'SaveSupplier
        '
        Me.SaveSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SaveSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveSupplier.Location = New System.Drawing.Point(500, 430)
        Me.SaveSupplier.Name = "SaveSupplier"
        Me.SaveSupplier.Size = New System.Drawing.Size(110, 30)
        Me.SaveSupplier.TabIndex = 24
        Me.SaveSupplier.Text = "Add Company"
        Me.SaveSupplier.UseVisualStyleBackColor = False
        '
        'NewSupplierTelephone
        '
        Me.NewSupplierTelephone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewSupplierTelephone.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewSupplierTelephone.Location = New System.Drawing.Point(10, 325)
        Me.NewSupplierTelephone.Name = "NewSupplierTelephone"
        Me.NewSupplierTelephone.Size = New System.Drawing.Size(634, 29)
        Me.NewSupplierTelephone.TabIndex = 23
        '
        'NewSupplierAddress
        '
        Me.NewSupplierAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewSupplierAddress.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewSupplierAddress.Location = New System.Drawing.Point(10, 185)
        Me.NewSupplierAddress.Multiline = True
        Me.NewSupplierAddress.Name = "NewSupplierAddress"
        Me.NewSupplierAddress.Size = New System.Drawing.Size(804, 110)
        Me.NewSupplierAddress.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 18)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Telephone No :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 18)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Company Address :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Company Name :"
        '
        'NewSupplierName
        '
        Me.NewSupplierName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewSupplierName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewSupplierName.Location = New System.Drawing.Point(10, 115)
        Me.NewSupplierName.Name = "NewSupplierName"
        Me.NewSupplierName.Size = New System.Drawing.Size(634, 29)
        Me.NewSupplierName.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Registration No.:"
        '
        'NewSupplierRegistration
        '
        Me.NewSupplierRegistration.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewSupplierRegistration.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewSupplierRegistration.Location = New System.Drawing.Point(10, 45)
        Me.NewSupplierRegistration.Name = "NewSupplierRegistration"
        Me.NewSupplierRegistration.Size = New System.Drawing.Size(634, 29)
        Me.NewSupplierRegistration.TabIndex = 10
        '
        'ControlList1
        '
        Me.ControlList1.ImageStream = CType(resources.GetObject("ControlList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ControlList1.TransparentColor = System.Drawing.Color.Gray
        Me.ControlList1.Images.SetKeyName(0, "Updaterecorditem.ico")
        Me.ControlList1.Images.SetKeyName(1, "supplierIcon.ico")
        '
        'add_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1071, 620)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.exitAdd)
        Me.Controls.Add(Me.minimizeAdd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "add_item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainGUI"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents minimizeAdd As System.Windows.Forms.Button
    Friend WithEvents exitAdd As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ItemCode As System.Windows.Forms.TextBox
    Friend WithEvents CompanydName As System.Windows.Forms.TextBox
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents Telephone As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Quantity As System.Windows.Forms.TextBox
    Friend WithEvents ItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents UnitTax As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NewSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NewSupplierRegistration As System.Windows.Forms.TextBox
    Friend WithEvents SaveSupplier As System.Windows.Forms.Button
    Friend WithEvents NewSupplierTelephone As System.Windows.Forms.TextBox
    Friend WithEvents NewSupplierAddress As System.Windows.Forms.TextBox
    Friend WithEvents ControlList1 As System.Windows.Forms.ImageList
End Class
