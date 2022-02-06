<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class databaseform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(databaseform))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.minimizemain = New System.Windows.Forms.Button()
        Me.CloseMain = New System.Windows.Forms.Button()
        Me.maximizeMain = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SQL Database (UnderDev)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "SQLite Database"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 40)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'minimizemain
        '
        Me.minimizemain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizemain.BackColor = System.Drawing.Color.LightGreen
        Me.minimizemain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.minimizemain.Location = New System.Drawing.Point(416, 0)
        Me.minimizemain.Name = "minimizemain"
        Me.minimizemain.Size = New System.Drawing.Size(43, 23)
        Me.minimizemain.TabIndex = 21
        Me.minimizemain.Text = "[ _ ]"
        Me.minimizemain.UseVisualStyleBackColor = False
        '
        'CloseMain
        '
        Me.CloseMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CloseMain.Location = New System.Drawing.Point(496, 0)
        Me.CloseMain.Name = "CloseMain"
        Me.CloseMain.Size = New System.Drawing.Size(43, 23)
        Me.CloseMain.TabIndex = 19
        Me.CloseMain.Text = "[  X  ]"
        Me.CloseMain.UseVisualStyleBackColor = False
        '
        'maximizeMain
        '
        Me.maximizeMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizeMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximizeMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.maximizeMain.Location = New System.Drawing.Point(456, 0)
        Me.maximizeMain.Name = "maximizeMain"
        Me.maximizeMain.Size = New System.Drawing.Size(43, 23)
        Me.maximizeMain.TabIndex = 20
        Me.maximizeMain.Text = "[ ||| ]"
        Me.maximizeMain.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(537, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 314)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.minimizemain)
        Me.Controls.Add(Me.CloseMain)
        Me.Controls.Add(Me.maximizeMain)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents minimizemain As System.Windows.Forms.Button
    Friend WithEvents CloseMain As System.Windows.Forms.Button
    Friend WithEvents maximizeMain As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
