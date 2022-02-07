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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.minimizemain = New System.Windows.Forms.Button()
        Me.CloseMain = New System.Windows.Forms.Button()
        Me.maximizeMain = New System.Windows.Forms.Button()
        Me.ItemControl = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.ItemUpdateBttn = New System.Windows.Forms.Button()
        Me.DeleteButt_form = New System.Windows.Forms.Button()
        Me.inventory_Audid_bttn = New System.Windows.Forms.Button()
        Me.purchase_order_button = New System.Windows.Forms.Button()
        Me.AddItem = New System.Windows.Forms.Button()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Tab3 = New System.Windows.Forms.TabPage()
        Me.CompanySetting = New System.Windows.Forms.Button()
        Me.ProgramSetting = New System.Windows.Forms.Button()
        Me.CreateDB = New System.Windows.Forms.Button()
        Me.DMYval = New System.Windows.Forms.Label()
        Me.TIval = New System.Windows.Forms.Label()
        Me.watch = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ItemView = New System.Windows.Forms.DataGridView()
        Me.ItemControl.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.Tab2.SuspendLayout()
        Me.Tab3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
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
        'ItemControl
        '
        Me.ItemControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemControl.Controls.Add(Me.Tab1)
        Me.ItemControl.Controls.Add(Me.Tab2)
        Me.ItemControl.Controls.Add(Me.Tab3)
        Me.ItemControl.Location = New System.Drawing.Point(1, 75)
        Me.ItemControl.Name = "ItemControl"
        Me.ItemControl.SelectedIndex = 0
        Me.ItemControl.ShowToolTips = True
        Me.ItemControl.Size = New System.Drawing.Size(782, 111)
        Me.ItemControl.TabIndex = 9
        '
        'Tab1
        '
        Me.Tab1.BackColor = System.Drawing.Color.LightBlue
        Me.Tab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Tab1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab1.Controls.Add(Me.ItemUpdateBttn)
        Me.Tab1.Controls.Add(Me.DeleteButt_form)
        Me.Tab1.Controls.Add(Me.inventory_Audid_bttn)
        Me.Tab1.Controls.Add(Me.purchase_order_button)
        Me.Tab1.Controls.Add(Me.AddItem)
        Me.Tab1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, CType(0, Byte))
        Me.Tab1.ForeColor = System.Drawing.Color.Wheat
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(774, 85)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "Item Management"
        '
        'ItemUpdateBttn
        '
        Me.ItemUpdateBttn.BackColor = System.Drawing.SystemColors.Info
        Me.ItemUpdateBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ItemUpdateBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ItemUpdateBttn.FlatAppearance.BorderSize = 2
        Me.ItemUpdateBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ItemUpdateBttn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemUpdateBttn.ForeColor = System.Drawing.Color.Black
        Me.ItemUpdateBttn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ItemUpdateBttn.Location = New System.Drawing.Point(623, 8)
        Me.ItemUpdateBttn.Name = "ItemUpdateBttn"
        Me.ItemUpdateBttn.Size = New System.Drawing.Size(120, 64)
        Me.ItemUpdateBttn.TabIndex = 10
        Me.ItemUpdateBttn.Text = "Item Update"
        Me.ItemUpdateBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ItemUpdateBttn.UseVisualStyleBackColor = False
        '
        'DeleteButt_form
        '
        Me.DeleteButt_form.BackColor = System.Drawing.SystemColors.Info
        Me.DeleteButt_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteButt_form.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteButt_form.FlatAppearance.BorderSize = 2
        Me.DeleteButt_form.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButt_form.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButt_form.ForeColor = System.Drawing.Color.Black
        Me.DeleteButt_form.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteButt_form.Location = New System.Drawing.Point(168, 8)
        Me.DeleteButt_form.Name = "DeleteButt_form"
        Me.DeleteButt_form.Size = New System.Drawing.Size(120, 64)
        Me.DeleteButt_form.TabIndex = 9
        Me.DeleteButt_form.Text = "Delete Item"
        Me.DeleteButt_form.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.DeleteButt_form.UseVisualStyleBackColor = False
        '
        'inventory_Audid_bttn
        '
        Me.inventory_Audid_bttn.BackColor = System.Drawing.SystemColors.Info
        Me.inventory_Audid_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inventory_Audid_bttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.inventory_Audid_bttn.FlatAppearance.BorderSize = 2
        Me.inventory_Audid_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.inventory_Audid_bttn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventory_Audid_bttn.ForeColor = System.Drawing.Color.Black
        Me.inventory_Audid_bttn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.inventory_Audid_bttn.Location = New System.Drawing.Point(472, 8)
        Me.inventory_Audid_bttn.Name = "inventory_Audid_bttn"
        Me.inventory_Audid_bttn.Size = New System.Drawing.Size(120, 64)
        Me.inventory_Audid_bttn.TabIndex = 8
        Me.inventory_Audid_bttn.Text = "Inventory Audit Form"
        Me.inventory_Audid_bttn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.inventory_Audid_bttn.UseVisualStyleBackColor = False
        '
        'purchase_order_button
        '
        Me.purchase_order_button.BackColor = System.Drawing.SystemColors.Info
        Me.purchase_order_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.purchase_order_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.purchase_order_button.FlatAppearance.BorderSize = 2
        Me.purchase_order_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.purchase_order_button.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchase_order_button.ForeColor = System.Drawing.Color.Black
        Me.purchase_order_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.purchase_order_button.Location = New System.Drawing.Point(320, 8)
        Me.purchase_order_button.Name = "purchase_order_button"
        Me.purchase_order_button.Size = New System.Drawing.Size(120, 64)
        Me.purchase_order_button.TabIndex = 7
        Me.purchase_order_button.Text = "Purchase Order"
        Me.purchase_order_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.purchase_order_button.UseVisualStyleBackColor = False
        '
        'AddItem
        '
        Me.AddItem.BackColor = System.Drawing.SystemColors.Info
        Me.AddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddItem.FlatAppearance.BorderSize = 2
        Me.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItem.ForeColor = System.Drawing.Color.Black
        Me.AddItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AddItem.Location = New System.Drawing.Point(16, 8)
        Me.AddItem.Name = "AddItem"
        Me.AddItem.Size = New System.Drawing.Size(120, 64)
        Me.AddItem.TabIndex = 6
        Me.AddItem.Text = "Create Item"
        Me.AddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.AddItem.UseVisualStyleBackColor = False
        '
        'Tab2
        '
        Me.Tab2.BackColor = System.Drawing.Color.LightBlue
        Me.Tab2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab2.Controls.Add(Me.Button3)
        Me.Tab2.Controls.Add(Me.Button2)
        Me.Tab2.Location = New System.Drawing.Point(4, 22)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2.Size = New System.Drawing.Size(774, 85)
        Me.Tab2.TabIndex = 2
        Me.Tab2.Text = "Report tools"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(168, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 64)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Item Performance"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(16, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 64)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Inventory Performance"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Tab3
        '
        Me.Tab3.BackColor = System.Drawing.Color.LightBlue
        Me.Tab3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab3.Controls.Add(Me.CompanySetting)
        Me.Tab3.Controls.Add(Me.ProgramSetting)
        Me.Tab3.Controls.Add(Me.CreateDB)
        Me.Tab3.Location = New System.Drawing.Point(4, 22)
        Me.Tab3.Name = "Tab3"
        Me.Tab3.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab3.Size = New System.Drawing.Size(774, 85)
        Me.Tab3.TabIndex = 1
        Me.Tab3.Text = "Setting / Account"
        '
        'CompanySetting
        '
        Me.CompanySetting.BackColor = System.Drawing.SystemColors.Info
        Me.CompanySetting.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.CompanySetting.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.CompanySetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CompanySetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CompanySetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CompanySetting.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanySetting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CompanySetting.Location = New System.Drawing.Point(168, 8)
        Me.CompanySetting.Name = "CompanySetting"
        Me.CompanySetting.Size = New System.Drawing.Size(120, 64)
        Me.CompanySetting.TabIndex = 5
        Me.CompanySetting.Text = "Company"
        Me.CompanySetting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CompanySetting.UseVisualStyleBackColor = False
        '
        'ProgramSetting
        '
        Me.ProgramSetting.BackColor = System.Drawing.SystemColors.Info
        Me.ProgramSetting.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ProgramSetting.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.ProgramSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ProgramSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgramSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ProgramSetting.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgramSetting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgramSetting.Location = New System.Drawing.Point(320, 8)
        Me.ProgramSetting.Name = "ProgramSetting"
        Me.ProgramSetting.Size = New System.Drawing.Size(120, 64)
        Me.ProgramSetting.TabIndex = 4
        Me.ProgramSetting.Text = "Create Database"
        Me.ProgramSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ProgramSetting.UseVisualStyleBackColor = False
        '
        'CreateDB
        '
        Me.CreateDB.BackColor = System.Drawing.SystemColors.Info
        Me.CreateDB.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.CreateDB.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.CreateDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CreateDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CreateDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateDB.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CreateDB.Location = New System.Drawing.Point(16, 8)
        Me.CreateDB.Name = "CreateDB"
        Me.CreateDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CreateDB.Size = New System.Drawing.Size(120, 64)
        Me.CreateDB.TabIndex = 2
        Me.CreateDB.Text = "Create Database"
        Me.CreateDB.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CreateDB.UseVisualStyleBackColor = False
        '
        'DMYval
        '
        Me.DMYval.AutoSize = True
        Me.DMYval.BackColor = System.Drawing.Color.Transparent
        Me.DMYval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DMYval.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DMYval.Location = New System.Drawing.Point(962, 1)
        Me.DMYval.Name = "DMYval"
        Me.DMYval.Size = New System.Drawing.Size(63, 20)
        Me.DMYval.TabIndex = 11
        Me.DMYval.Text = "Label1"
        Me.DMYval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TIval
        '
        Me.TIval.AutoSize = True
        Me.TIval.BackColor = System.Drawing.Color.Transparent
        Me.TIval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIval.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TIval.Location = New System.Drawing.Point(962, 26)
        Me.TIval.Name = "TIval"
        Me.TIval.Size = New System.Drawing.Size(63, 20)
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
        Me.ItemView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ItemView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.ItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ItemView.Location = New System.Drawing.Point(1, 192)
        Me.ItemView.Name = "ItemView"
        Me.ItemView.ReadOnly = True
        Me.ItemView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemView.Size = New System.Drawing.Size(1262, 466)
        Me.ItemView.TabIndex = 10
        '
        'mainGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.DMYval)
        Me.Controls.Add(Me.TIval)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ItemView)
        Me.Controls.Add(Me.minimizemain)
        Me.Controls.Add(Me.CloseMain)
        Me.Controls.Add(Me.maximizeMain)
        Me.Controls.Add(Me.ItemControl)
        Me.Controls.Add(Me.StatusStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainGUI"
        Me.ItemControl.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Tab2.ResumeLayout(False)
        Me.Tab3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents minimizemain As System.Windows.Forms.Button
    Friend WithEvents CloseMain As System.Windows.Forms.Button
    Friend WithEvents maximizeMain As System.Windows.Forms.Button
    Friend WithEvents ItemControl As System.Windows.Forms.TabControl
    Friend WithEvents Tab1 As System.Windows.Forms.TabPage
    Friend WithEvents Tab3 As System.Windows.Forms.TabPage
    Friend WithEvents CreateDB As System.Windows.Forms.Button
    Friend WithEvents CompanySetting As System.Windows.Forms.Button
    Friend WithEvents ProgramSetting As System.Windows.Forms.Button
    Friend WithEvents AddItem As System.Windows.Forms.Button
    Friend WithEvents DMYval As System.Windows.Forms.Label
    Friend WithEvents TIval As System.Windows.Forms.Label
    Friend WithEvents watch As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents inventory_Audid_bttn As System.Windows.Forms.Button
    Friend WithEvents purchase_order_button As System.Windows.Forms.Button
    Friend WithEvents Tab2 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DeleteButt_form As System.Windows.Forms.Button
    Friend WithEvents ItemUpdateBttn As System.Windows.Forms.Button
    Friend WithEvents ItemView As System.Windows.Forms.DataGridView
End Class
