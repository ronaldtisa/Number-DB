<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyConfiguration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompanyConfiguration))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.minimizeCompanyConfigurationForm = New System.Windows.Forms.Button()
        Me.CloseCompanyConfigurationForm = New System.Windows.Forms.Button()
        Me.maximizeCompanyConfigurationForm = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CompanyRegistration = New System.Windows.Forms.TextBox()
        Me.CompanyNameSet = New System.Windows.Forms.TextBox()
        Me.ContactInfoTelephone = New System.Windows.Forms.TextBox()
        Me.AddressPosSet = New System.Windows.Forms.TextBox()
        Me.TaxValSet = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.saveSetting = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.inf = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 457)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1127, 20)
        Me.Panel3.TabIndex = 25
        '
        'minimizeCompanyConfigurationForm
        '
        Me.minimizeCompanyConfigurationForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizeCompanyConfigurationForm.BackColor = System.Drawing.Color.LightGreen
        Me.minimizeCompanyConfigurationForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.minimizeCompanyConfigurationForm.Location = New System.Drawing.Point(1007, 0)
        Me.minimizeCompanyConfigurationForm.Name = "minimizeCompanyConfigurationForm"
        Me.minimizeCompanyConfigurationForm.Size = New System.Drawing.Size(43, 23)
        Me.minimizeCompanyConfigurationForm.TabIndex = 23
        Me.minimizeCompanyConfigurationForm.Text = "[ _ ]"
        Me.minimizeCompanyConfigurationForm.UseVisualStyleBackColor = False
        '
        'CloseCompanyConfigurationForm
        '
        Me.CloseCompanyConfigurationForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseCompanyConfigurationForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CloseCompanyConfigurationForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CloseCompanyConfigurationForm.Location = New System.Drawing.Point(1087, 0)
        Me.CloseCompanyConfigurationForm.Name = "CloseCompanyConfigurationForm"
        Me.CloseCompanyConfigurationForm.Size = New System.Drawing.Size(43, 23)
        Me.CloseCompanyConfigurationForm.TabIndex = 21
        Me.CloseCompanyConfigurationForm.Text = "[  X  ]"
        Me.CloseCompanyConfigurationForm.UseVisualStyleBackColor = False
        '
        'maximizeCompanyConfigurationForm
        '
        Me.maximizeCompanyConfigurationForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizeCompanyConfigurationForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximizeCompanyConfigurationForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.maximizeCompanyConfigurationForm.Location = New System.Drawing.Point(1047, 0)
        Me.maximizeCompanyConfigurationForm.Name = "maximizeCompanyConfigurationForm"
        Me.maximizeCompanyConfigurationForm.Size = New System.Drawing.Size(43, 23)
        Me.maximizeCompanyConfigurationForm.TabIndex = 22
        Me.maximizeCompanyConfigurationForm.Text = "[ ||| ]"
        Me.maximizeCompanyConfigurationForm.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.maximizeCompanyConfigurationForm)
        Me.Panel1.Controls.Add(Me.CloseCompanyConfigurationForm)
        Me.Panel1.Controls.Add(Me.minimizeCompanyConfigurationForm)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1127, 40)
        Me.Panel1.TabIndex = 24
        '
        'CompanyRegistration
        '
        Me.CompanyRegistration.Location = New System.Drawing.Point(32, 64)
        Me.CompanyRegistration.Multiline = True
        Me.CompanyRegistration.Name = "CompanyRegistration"
        Me.CompanyRegistration.Size = New System.Drawing.Size(352, 32)
        Me.CompanyRegistration.TabIndex = 26
        '
        'CompanyNameSet
        '
        Me.CompanyNameSet.Location = New System.Drawing.Point(32, 128)
        Me.CompanyNameSet.Multiline = True
        Me.CompanyNameSet.Name = "CompanyNameSet"
        Me.CompanyNameSet.Size = New System.Drawing.Size(672, 32)
        Me.CompanyNameSet.TabIndex = 27
        '
        'ContactInfoTelephone
        '
        Me.ContactInfoTelephone.Location = New System.Drawing.Point(456, 344)
        Me.ContactInfoTelephone.Multiline = True
        Me.ContactInfoTelephone.Name = "ContactInfoTelephone"
        Me.ContactInfoTelephone.Size = New System.Drawing.Size(248, 32)
        Me.ContactInfoTelephone.TabIndex = 28
        '
        'AddressPosSet
        '
        Me.AddressPosSet.Location = New System.Drawing.Point(32, 192)
        Me.AddressPosSet.Multiline = True
        Me.AddressPosSet.Name = "AddressPosSet"
        Me.AddressPosSet.Size = New System.Drawing.Size(672, 112)
        Me.AddressPosSet.TabIndex = 29
        '
        'TaxValSet
        '
        Me.TaxValSet.Location = New System.Drawing.Point(32, 344)
        Me.TaxValSet.Multiline = True
        Me.TaxValSet.Name = "TaxValSet"
        Me.TaxValSet.Size = New System.Drawing.Size(352, 32)
        Me.TaxValSet.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(736, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(384, 240)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(872, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 32)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Browse Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'saveSetting
        '
        Me.saveSetting.BackColor = System.Drawing.Color.SandyBrown
        Me.saveSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.saveSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.saveSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveSetting.Location = New System.Drawing.Point(512, 400)
        Me.saveSetting.Name = "saveSetting"
        Me.saveSetting.Size = New System.Drawing.Size(104, 32)
        Me.saveSetting.TabIndex = 33
        Me.saveSetting.Text = "Save Setting"
        Me.saveSetting.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(624, 416)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(368, 15)
        Me.ProgressBar1.TabIndex = 34
        '
        'inf
        '
        Me.inf.AutoSize = True
        Me.inf.Location = New System.Drawing.Point(624, 400)
        Me.inf.Name = "inf"
        Me.inf.Size = New System.Drawing.Size(0, 13)
        Me.inf.TabIndex = 35
        '
        'CompanyConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 477)
        Me.Controls.Add(Me.inf)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.saveSetting)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TaxValSet)
        Me.Controls.Add(Me.AddressPosSet)
        Me.Controls.Add(Me.ContactInfoTelephone)
        Me.Controls.Add(Me.CompanyNameSet)
        Me.Controls.Add(Me.CompanyRegistration)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CompanyConfiguration"
        Me.Text = "CompanyConfiguration"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents minimizeCompanyConfigurationForm As System.Windows.Forms.Button
    Friend WithEvents CloseCompanyConfigurationForm As System.Windows.Forms.Button
    Friend WithEvents maximizeCompanyConfigurationForm As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CompanyRegistration As System.Windows.Forms.TextBox
    Friend WithEvents CompanyNameSet As System.Windows.Forms.TextBox
    Friend WithEvents ContactInfoTelephone As System.Windows.Forms.TextBox
    Friend WithEvents AddressPosSet As System.Windows.Forms.TextBox
    Friend WithEvents TaxValSet As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents saveSetting As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents inf As System.Windows.Forms.Label
End Class
