<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xemthongtinKH
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
        Me.btnquaylai = New System.Windows.Forms.Button()
        Me.btnxemall = New System.Windows.Forms.Button()
        Me.btnxem = New System.Windows.Forms.Button()
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvxemkh = New System.Windows.Forms.DataGridView()
        CType(Me.dgvxemkh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnquaylai
        '
        Me.btnquaylai.Location = New System.Drawing.Point(295, 66)
        Me.btnquaylai.Name = "btnquaylai"
        Me.btnquaylai.Size = New System.Drawing.Size(75, 23)
        Me.btnquaylai.TabIndex = 7
        Me.btnquaylai.Text = "Quay Lại"
        Me.btnquaylai.UseVisualStyleBackColor = True
        '
        'btnxemall
        '
        Me.btnxemall.Location = New System.Drawing.Point(177, 66)
        Me.btnxemall.Name = "btnxemall"
        Me.btnxemall.Size = New System.Drawing.Size(75, 23)
        Me.btnxemall.TabIndex = 8
        Me.btnxemall.Text = "Xem All"
        Me.btnxemall.UseVisualStyleBackColor = True
        '
        'btnxem
        '
        Me.btnxem.Location = New System.Drawing.Point(59, 66)
        Me.btnxem.Name = "btnxem"
        Me.btnxem.Size = New System.Drawing.Size(75, 23)
        Me.btnxem.TabIndex = 9
        Me.btnxem.Text = "Xem"
        Me.btnxem.UseVisualStyleBackColor = True
        '
        'txtMAKH
        '
        Me.txtMAKH.Location = New System.Drawing.Point(113, 20)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(187, 20)
        Me.txtMAKH.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã Khách Hàng"
        '
        'dgvxemkh
        '
        Me.dgvxemkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvxemkh.Location = New System.Drawing.Point(12, 95)
        Me.dgvxemkh.Name = "dgvxemkh"
        Me.dgvxemkh.Size = New System.Drawing.Size(668, 199)
        Me.dgvxemkh.TabIndex = 4
        '
        'xemthongtinKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 306)
        Me.Controls.Add(Me.btnquaylai)
        Me.Controls.Add(Me.btnxemall)
        Me.Controls.Add(Me.btnxem)
        Me.Controls.Add(Me.txtMAKH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvxemkh)
        Me.Name = "xemthongtinKH"
        Me.Text = "Customer"
        CType(Me.dgvxemkh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnquaylai As System.Windows.Forms.Button
    Friend WithEvents btnxemall As System.Windows.Forms.Button
    Friend WithEvents btnxem As System.Windows.Forms.Button
    Friend WithEvents txtMAKH As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvxemkh As System.Windows.Forms.DataGridView
End Class
