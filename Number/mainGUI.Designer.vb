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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ItemControl = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.AddItem = New System.Windows.Forms.Button()
        Me.Tab3 = New System.Windows.Forms.TabPage()
        Me.CompanySetting = New System.Windows.Forms.Button()
        Me.ProgramSetting = New System.Windows.Forms.Button()
        Me.CreateDB = New System.Windows.Forms.Button()
        Me.ItemView = New System.Windows.Forms.DataGridView()
        Me.DMYval = New System.Windows.Forms.Label()
        Me.TIval = New System.Windows.Forms.Label()
        Me.watch = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.purchase_order_button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemControl.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.Tab3.SuspendLayout()
        CType(Me.ItemView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab2.SuspendLayout()
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1264, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ItemControl
        '
        Me.ItemControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemControl.Controls.Add(Me.Tab1)
        Me.ItemControl.Controls.Add(Me.Tab2)
        Me.ItemControl.Controls.Add(Me.Tab3)
        Me.ItemControl.Location = New System.Drawing.Point(1, 52)
        Me.ItemControl.Name = "ItemControl"
        Me.ItemControl.SelectedIndex = 0
        Me.ItemControl.ShowToolTips = True
        Me.ItemControl.Size = New System.Drawing.Size(630, 111)
        Me.ItemControl.TabIndex = 9
        '
        'Tab1
        '
        Me.Tab1.BackColor = System.Drawing.Color.LightBlue
        Me.Tab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Tab1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab1.Controls.Add(Me.Button4)
        Me.Tab1.Controls.Add(Me.Button1)
        Me.Tab1.Controls.Add(Me.purchase_order_button)
        Me.Tab1.Controls.Add(Me.AddItem)
        Me.Tab1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, CType(0, Byte))
        Me.Tab1.ForeColor = System.Drawing.Color.Wheat
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(622, 85)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "Item Management"
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
        Me.Tab3.Size = New System.Drawing.Size(622, 85)
        Me.Tab3.TabIndex = 1
        Me.Tab3.Text = "Setting / Account"
        '
        'CompanySetting
        '
        Me.CompanySetting.BackgroundImage = CType(resources.GetObject("CompanySetting.BackgroundImage"), System.Drawing.Image)
        Me.CompanySetting.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.CompanySetting.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.CompanySetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.CompanySetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CompanySetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CompanySetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.CompanySetting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CompanySetting.Location = New System.Drawing.Point(168, 8)
        Me.CompanySetting.Name = "CompanySetting"
        Me.CompanySetting.Size = New System.Drawing.Size(120, 64)
        Me.CompanySetting.TabIndex = 5
        Me.CompanySetting.Text = "Company"
        Me.CompanySetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CompanySetting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CompanySetting.UseVisualStyleBackColor = True
        '
        'ProgramSetting
        '
        Me.ProgramSetting.BackgroundImage = CType(resources.GetObject("ProgramSetting.BackgroundImage"), System.Drawing.Image)
        Me.ProgramSetting.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ProgramSetting.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue
        Me.ProgramSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.ProgramSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgramSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ProgramSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.ProgramSetting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgramSetting.Location = New System.Drawing.Point(320, 8)
        Me.ProgramSetting.Name = "ProgramSetting"
        Me.ProgramSetting.Size = New System.Drawing.Size(120, 64)
        Me.ProgramSetting.TabIndex = 4
        Me.ProgramSetting.Text = "Create Database"
        Me.ProgramSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ProgramSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ProgramSetting.UseVisualStyleBackColor = True
        '
        'CreateDB
        '
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
        Me.CreateDB.UseVisualStyleBackColor = True
        '
        'ItemView
        '
        Me.ItemView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ItemView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.ItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemView.Location = New System.Drawing.Point(1, 192)
        Me.ItemView.Name = "ItemView"
        Me.ItemView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemView.Size = New System.Drawing.Size(1262, 466)
        Me.ItemView.TabIndex = 10
        '
        'DMYval
        '
        Me.DMYval.AutoSize = True
        Me.DMYval.BackColor = System.Drawing.Color.Transparent
        Me.DMYval.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DMYval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DMYval.Location = New System.Drawing.Point(962, 1)
        Me.DMYval.Name = "DMYval"
        Me.DMYval.Size = New System.Drawing.Size(59, 22)
        Me.DMYval.TabIndex = 11
        Me.DMYval.Text = "Label1"
        Me.DMYval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TIval
        '
        Me.TIval.AutoSize = True
        Me.TIval.BackColor = System.Drawing.Color.Transparent
        Me.TIval.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TIval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIval.Location = New System.Drawing.Point(962, 26)
        Me.TIval.Name = "TIval"
        Me.TIval.Size = New System.Drawing.Size(59, 22)
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(472, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 64)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Inventory Audit Form"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Tab2.Size = New System.Drawing.Size(622, 85)
        Me.Tab2.TabIndex = 2
        Me.Tab2.Text = "Report tools"
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
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Info
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(168, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 64)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Delete Item"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button4.UseVisualStyleBackColor = False
        '
        'mainGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
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
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainGUI"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemControl.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Tab3.ResumeLayout(False)
        CType(Me.ItemView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents minimizemain As System.Windows.Forms.Button
    Friend WithEvents CloseMain As System.Windows.Forms.Button
    Friend WithEvents maximizeMain As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ItemControl As System.Windows.Forms.TabControl
    Friend WithEvents Tab1 As System.Windows.Forms.TabPage
    Friend WithEvents Tab3 As System.Windows.Forms.TabPage
    Friend WithEvents CreateDB As System.Windows.Forms.Button
    Friend WithEvents CompanySetting As System.Windows.Forms.Button
    Friend WithEvents ProgramSetting As System.Windows.Forms.Button
    Friend WithEvents AddItem As System.Windows.Forms.Button
    Friend WithEvents ItemView As System.Windows.Forms.DataGridView
    Friend WithEvents DMYval As System.Windows.Forms.Label
    Friend WithEvents TIval As System.Windows.Forms.Label
    Friend WithEvents watch As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents purchase_order_button As System.Windows.Forms.Button
    Friend WithEvents Tab2 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
