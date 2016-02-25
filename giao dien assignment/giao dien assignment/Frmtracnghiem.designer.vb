<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtracnghiem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtracnghiem))
        Me.rdb1 = New System.Windows.Forms.RadioButton()
        Me.rdb2 = New System.Windows.Forms.RadioButton()
        Me.rdb3 = New System.Windows.Forms.RadioButton()
        Me.rdb4 = New System.Windows.Forms.RadioButton()
        Me.txtCAUHOI = New System.Windows.Forms.TextBox()
        Me.btnTraloi = New System.Windows.Forms.Button()
        Me.pcb1 = New System.Windows.Forms.PictureBox()
        Me.btnDong = New System.Windows.Forms.Button()
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdb1
        '
        Me.rdb1.AutoSize = True
        Me.rdb1.Location = New System.Drawing.Point(12, 105)
        Me.rdb1.Name = "rdb1"
        Me.rdb1.Size = New System.Drawing.Size(73, 19)
        Me.rdb1.TabIndex = 0
        Me.rdb1.TabStop = True
        Me.rdb1.Text = "Đáp án 1"
        Me.rdb1.UseVisualStyleBackColor = True
        '
        'rdb2
        '
        Me.rdb2.AutoSize = True
        Me.rdb2.Location = New System.Drawing.Point(12, 131)
        Me.rdb2.Name = "rdb2"
        Me.rdb2.Size = New System.Drawing.Size(73, 19)
        Me.rdb2.TabIndex = 1
        Me.rdb2.TabStop = True
        Me.rdb2.Text = "Đáp án 2"
        Me.rdb2.UseVisualStyleBackColor = True
        '
        'rdb3
        '
        Me.rdb3.AutoSize = True
        Me.rdb3.Location = New System.Drawing.Point(12, 157)
        Me.rdb3.Name = "rdb3"
        Me.rdb3.Size = New System.Drawing.Size(73, 19)
        Me.rdb3.TabIndex = 2
        Me.rdb3.TabStop = True
        Me.rdb3.Text = "Đáp án 3"
        Me.rdb3.UseVisualStyleBackColor = True
        '
        'rdb4
        '
        Me.rdb4.AutoSize = True
        Me.rdb4.Location = New System.Drawing.Point(12, 183)
        Me.rdb4.Name = "rdb4"
        Me.rdb4.Size = New System.Drawing.Size(73, 19)
        Me.rdb4.TabIndex = 3
        Me.rdb4.TabStop = True
        Me.rdb4.Text = "Đáp án 4"
        Me.rdb4.UseVisualStyleBackColor = True
        '
        'txtCAUHOI
        '
        Me.txtCAUHOI.Location = New System.Drawing.Point(7, 14)
        Me.txtCAUHOI.Multiline = True
        Me.txtCAUHOI.Name = "txtCAUHOI"
        Me.txtCAUHOI.ReadOnly = True
        Me.txtCAUHOI.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCAUHOI.Size = New System.Drawing.Size(370, 79)
        Me.txtCAUHOI.TabIndex = 4
        '
        'btnTraloi
        '
        Me.btnTraloi.Location = New System.Drawing.Point(12, 231)
        Me.btnTraloi.Name = "btnTraloi"
        Me.btnTraloi.Size = New System.Drawing.Size(69, 55)
        Me.btnTraloi.TabIndex = 5
        Me.btnTraloi.Text = "Trả lời"
        Me.btnTraloi.UseVisualStyleBackColor = True
        '
        'pcb1
        '
        Me.pcb1.Image = CType(resources.GetObject("pcb1.Image"), System.Drawing.Image)
        Me.pcb1.Location = New System.Drawing.Point(252, 142)
        Me.pcb1.Name = "pcb1"
        Me.pcb1.Size = New System.Drawing.Size(159, 131)
        Me.pcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb1.TabIndex = 6
        Me.pcb1.TabStop = False
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(108, 231)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 55)
        Me.btnDong.TabIndex = 7
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'frmtracnghiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 372)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.pcb1)
        Me.Controls.Add(Me.btnTraloi)
        Me.Controls.Add(Me.txtCAUHOI)
        Me.Controls.Add(Me.rdb4)
        Me.Controls.Add(Me.rdb3)
        Me.Controls.Add(Me.rdb2)
        Me.Controls.Add(Me.rdb1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmtracnghiem"
        Me.Text = "Funny Quiz"
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdb1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb4 As System.Windows.Forms.RadioButton
    Friend WithEvents txtCAUHOI As System.Windows.Forms.TextBox
    Friend WithEvents btnTraloi As System.Windows.Forms.Button
    Friend WithEvents pcb1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDong As System.Windows.Forms.Button

End Class
