<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbientap
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
        Me.txtCauhoi = New System.Windows.Forms.TextBox()
        Me.lbldapan1 = New System.Windows.Forms.Label()
        Me.lbldapan2 = New System.Windows.Forms.Label()
        Me.lbldapan3 = New System.Windows.Forms.Label()
        Me.lbldapan4 = New System.Windows.Forms.Label()
        Me.txtdapan1 = New System.Windows.Forms.TextBox()
        Me.txtdapan2 = New System.Windows.Forms.TextBox()
        Me.txtdapan3 = New System.Windows.Forms.TextBox()
        Me.txtdapan4 = New System.Windows.Forms.TextBox()
        Me.lbltraloidung = New System.Windows.Forms.Label()
        Me.cbotraloidung = New System.Windows.Forms.ComboBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btntuchoi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCauhoi
        '
        Me.txtCauhoi.Location = New System.Drawing.Point(12, 12)
        Me.txtCauhoi.Multiline = True
        Me.txtCauhoi.Name = "txtCauhoi"
        Me.txtCauhoi.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCauhoi.Size = New System.Drawing.Size(430, 77)
        Me.txtCauhoi.TabIndex = 0
        '
        'lbldapan1
        '
        Me.lbldapan1.AutoSize = True
        Me.lbldapan1.Location = New System.Drawing.Point(19, 111)
        Me.lbldapan1.Name = "lbldapan1"
        Me.lbldapan1.Size = New System.Drawing.Size(59, 15)
        Me.lbldapan1.TabIndex = 1
        Me.lbldapan1.Text = "Đáp án 1 :"
        '
        'lbldapan2
        '
        Me.lbldapan2.AutoSize = True
        Me.lbldapan2.Location = New System.Drawing.Point(19, 153)
        Me.lbldapan2.Name = "lbldapan2"
        Me.lbldapan2.Size = New System.Drawing.Size(59, 15)
        Me.lbldapan2.TabIndex = 2
        Me.lbldapan2.Text = "Đáp án 2 :"
        '
        'lbldapan3
        '
        Me.lbldapan3.AutoSize = True
        Me.lbldapan3.Location = New System.Drawing.Point(19, 199)
        Me.lbldapan3.Name = "lbldapan3"
        Me.lbldapan3.Size = New System.Drawing.Size(59, 15)
        Me.lbldapan3.TabIndex = 3
        Me.lbldapan3.Text = "Đáp án 3 :"
        '
        'lbldapan4
        '
        Me.lbldapan4.AutoSize = True
        Me.lbldapan4.Location = New System.Drawing.Point(19, 240)
        Me.lbldapan4.Name = "lbldapan4"
        Me.lbldapan4.Size = New System.Drawing.Size(59, 15)
        Me.lbldapan4.TabIndex = 4
        Me.lbldapan4.Text = "Đáp án 4 :"
        '
        'txtdapan1
        '
        Me.txtdapan1.Location = New System.Drawing.Point(103, 108)
        Me.txtdapan1.Name = "txtdapan1"
        Me.txtdapan1.Size = New System.Drawing.Size(285, 23)
        Me.txtdapan1.TabIndex = 5
        '
        'txtdapan2
        '
        Me.txtdapan2.Location = New System.Drawing.Point(103, 150)
        Me.txtdapan2.Name = "txtdapan2"
        Me.txtdapan2.Size = New System.Drawing.Size(285, 23)
        Me.txtdapan2.TabIndex = 6
        '
        'txtdapan3
        '
        Me.txtdapan3.Location = New System.Drawing.Point(103, 196)
        Me.txtdapan3.Name = "txtdapan3"
        Me.txtdapan3.Size = New System.Drawing.Size(285, 23)
        Me.txtdapan3.TabIndex = 7
        '
        'txtdapan4
        '
        Me.txtdapan4.Location = New System.Drawing.Point(103, 237)
        Me.txtdapan4.Name = "txtdapan4"
        Me.txtdapan4.Size = New System.Drawing.Size(285, 23)
        Me.txtdapan4.TabIndex = 8
        '
        'lbltraloidung
        '
        Me.lbltraloidung.AutoSize = True
        Me.lbltraloidung.Location = New System.Drawing.Point(19, 296)
        Me.lbltraloidung.Name = "lbltraloidung"
        Me.lbltraloidung.Size = New System.Drawing.Size(98, 15)
        Me.lbltraloidung.TabIndex = 9
        Me.lbltraloidung.Text = "Câu trả lời đúng :"
        '
        'cbotraloidung
        '
        Me.cbotraloidung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotraloidung.FormattingEnabled = True
        Me.cbotraloidung.Items.AddRange(New Object() {"Đáp án 1", "Đáp án 2", "Đáp án 3", "Đáp án 4"})
        Me.cbotraloidung.Location = New System.Drawing.Point(133, 293)
        Me.cbotraloidung.Name = "cbotraloidung"
        Me.cbotraloidung.Size = New System.Drawing.Size(285, 23)
        Me.cbotraloidung.TabIndex = 10
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(114, 360)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(78, 42)
        Me.btnthem.TabIndex = 11
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btntuchoi
        '
        Me.btntuchoi.Location = New System.Drawing.Point(254, 360)
        Me.btntuchoi.Name = "btntuchoi"
        Me.btntuchoi.Size = New System.Drawing.Size(78, 42)
        Me.btntuchoi.TabIndex = 12
        Me.btntuchoi.Text = "Từ chối"
        Me.btntuchoi.UseVisualStyleBackColor = True
        '
        'frmbientap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 440)
        Me.Controls.Add(Me.btntuchoi)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.cbotraloidung)
        Me.Controls.Add(Me.lbltraloidung)
        Me.Controls.Add(Me.txtdapan4)
        Me.Controls.Add(Me.txtdapan3)
        Me.Controls.Add(Me.txtdapan2)
        Me.Controls.Add(Me.txtdapan1)
        Me.Controls.Add(Me.lbldapan4)
        Me.Controls.Add(Me.lbldapan3)
        Me.Controls.Add(Me.lbldapan2)
        Me.Controls.Add(Me.lbldapan1)
        Me.Controls.Add(Me.txtCauhoi)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmbientap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biên tập câu hỏi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCauhoi As System.Windows.Forms.TextBox
    Friend WithEvents lbldapan1 As System.Windows.Forms.Label
    Friend WithEvents lbldapan2 As System.Windows.Forms.Label
    Friend WithEvents lbldapan3 As System.Windows.Forms.Label
    Friend WithEvents lbldapan4 As System.Windows.Forms.Label
    Friend WithEvents txtdapan1 As System.Windows.Forms.TextBox
    Friend WithEvents txtdapan2 As System.Windows.Forms.TextBox
    Friend WithEvents txtdapan3 As System.Windows.Forms.TextBox
    Friend WithEvents txtdapan4 As System.Windows.Forms.TextBox
    Friend WithEvents lbltraloidung As System.Windows.Forms.Label
    Friend WithEvents cbotraloidung As System.Windows.Forms.ComboBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btntuchoi As System.Windows.Forms.Button

End Class
