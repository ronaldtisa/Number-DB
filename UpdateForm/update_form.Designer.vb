<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(update_form))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.minimizemain = New System.Windows.Forms.Button()
        Me.CloseMain = New System.Windows.Forms.Button()
        Me.maximizeMain = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.update_check = New System.Windows.Forms.Button()
        Me.update_install = New System.Windows.Forms.Button()
        Me.check_bar = New System.Windows.Forms.ProgressBar()
        Me.install_bar = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 40)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'minimizemain
        '
        Me.minimizemain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizemain.BackColor = System.Drawing.Color.LightGreen
        Me.minimizemain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.minimizemain.Location = New System.Drawing.Point(607, 0)
        Me.minimizemain.Name = "minimizemain"
        Me.minimizemain.Size = New System.Drawing.Size(43, 23)
        Me.minimizemain.TabIndex = 16
        Me.minimizemain.Text = "[ _ ]"
        Me.minimizemain.UseVisualStyleBackColor = False
        '
        'CloseMain
        '
        Me.CloseMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CloseMain.Location = New System.Drawing.Point(687, 0)
        Me.CloseMain.Name = "CloseMain"
        Me.CloseMain.Size = New System.Drawing.Size(43, 23)
        Me.CloseMain.TabIndex = 14
        Me.CloseMain.Text = "[  X  ]"
        Me.CloseMain.UseVisualStyleBackColor = False
        '
        'maximizeMain
        '
        Me.maximizeMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizeMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximizeMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.maximizeMain.Location = New System.Drawing.Point(647, 0)
        Me.maximizeMain.Name = "maximizeMain"
        Me.maximizeMain.Size = New System.Drawing.Size(43, 23)
        Me.maximizeMain.TabIndex = 15
        Me.maximizeMain.Text = "[ ||| ]"
        Me.maximizeMain.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(730, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'update_check
        '
        Me.update_check.Location = New System.Drawing.Point(10, 80)
        Me.update_check.Name = "update_check"
        Me.update_check.Size = New System.Drawing.Size(100, 30)
        Me.update_check.TabIndex = 19
        Me.update_check.Text = "Check Update"
        Me.update_check.UseVisualStyleBackColor = True
        '
        'update_install
        '
        Me.update_install.Location = New System.Drawing.Point(10, 220)
        Me.update_install.Name = "update_install"
        Me.update_install.Size = New System.Drawing.Size(100, 30)
        Me.update_install.TabIndex = 20
        Me.update_install.Text = "Install Update"
        Me.update_install.UseVisualStyleBackColor = True
        '
        'check_bar
        '
        Me.check_bar.Location = New System.Drawing.Point(10, 110)
        Me.check_bar.Name = "check_bar"
        Me.check_bar.Size = New System.Drawing.Size(690, 23)
        Me.check_bar.TabIndex = 21
        '
        'install_bar
        '
        Me.install_bar.Location = New System.Drawing.Point(10, 250)
        Me.install_bar.Name = "install_bar"
        Me.install_bar.Size = New System.Drawing.Size(690, 23)
        Me.install_bar.TabIndex = 22
        '
        'update_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 370)
        Me.Controls.Add(Me.install_bar)
        Me.Controls.Add(Me.check_bar)
        Me.Controls.Add(Me.update_install)
        Me.Controls.Add(Me.update_check)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.minimizemain)
        Me.Controls.Add(Me.CloseMain)
        Me.Controls.Add(Me.maximizeMain)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "update_form"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents minimizemain As System.Windows.Forms.Button
    Friend WithEvents CloseMain As System.Windows.Forms.Button
    Friend WithEvents maximizeMain As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents update_check As System.Windows.Forms.Button
    Friend WithEvents update_install As System.Windows.Forms.Button
    Friend WithEvents check_bar As System.Windows.Forms.ProgressBar
    Friend WithEvents install_bar As System.Windows.Forms.ProgressBar

End Class
