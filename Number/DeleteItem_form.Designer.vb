<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteItem_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteItem_form))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.minimizeDeleteItemForm = New System.Windows.Forms.Button()
        Me.CloseDeleteItemForm = New System.Windows.Forms.Button()
        Me.maximizeDeleteItemForm = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 40)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'minimizeDeleteItemForm
        '
        Me.minimizeDeleteItemForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizeDeleteItemForm.BackColor = System.Drawing.Color.LightGreen
        Me.minimizeDeleteItemForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.minimizeDeleteItemForm.Location = New System.Drawing.Point(1143, 0)
        Me.minimizeDeleteItemForm.Name = "minimizeDeleteItemForm"
        Me.minimizeDeleteItemForm.Size = New System.Drawing.Size(43, 23)
        Me.minimizeDeleteItemForm.TabIndex = 17
        Me.minimizeDeleteItemForm.Text = "[ _ ]"
        Me.minimizeDeleteItemForm.UseVisualStyleBackColor = False
        '
        'CloseDeleteItemForm
        '
        Me.CloseDeleteItemForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseDeleteItemForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CloseDeleteItemForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CloseDeleteItemForm.Location = New System.Drawing.Point(1223, 0)
        Me.CloseDeleteItemForm.Name = "CloseDeleteItemForm"
        Me.CloseDeleteItemForm.Size = New System.Drawing.Size(43, 23)
        Me.CloseDeleteItemForm.TabIndex = 15
        Me.CloseDeleteItemForm.Text = "[  X  ]"
        Me.CloseDeleteItemForm.UseVisualStyleBackColor = False
        '
        'maximizeDeleteItemForm
        '
        Me.maximizeDeleteItemForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizeDeleteItemForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maximizeDeleteItemForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.maximizeDeleteItemForm.Location = New System.Drawing.Point(1183, 0)
        Me.maximizeDeleteItemForm.Name = "maximizeDeleteItemForm"
        Me.maximizeDeleteItemForm.Size = New System.Drawing.Size(43, 23)
        Me.maximizeDeleteItemForm.TabIndex = 16
        Me.maximizeDeleteItemForm.Text = "[ ||| ]"
        Me.maximizeDeleteItemForm.UseVisualStyleBackColor = False
        '
        'DeleteItem_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.minimizeDeleteItemForm)
        Me.Controls.Add(Me.CloseDeleteItemForm)
        Me.Controls.Add(Me.maximizeDeleteItemForm)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DeleteItem_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeleteItem_form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents minimizeDeleteItemForm As System.Windows.Forms.Button
    Friend WithEvents CloseDeleteItemForm As System.Windows.Forms.Button
    Friend WithEvents maximizeDeleteItemForm As System.Windows.Forms.Button
End Class
