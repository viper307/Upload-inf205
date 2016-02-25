<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.ptbUser = New System.Windows.Forms.PictureBox()
        Me.lblTieude = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnDANGNHAP = New System.Windows.Forms.Button()
        Me.btnDONG = New System.Windows.Forms.Button()
        CType(Me.ptbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbUser
        '
        Me.ptbUser.Image = CType(resources.GetObject("ptbUser.Image"), System.Drawing.Image)
        Me.ptbUser.Location = New System.Drawing.Point(14, 47)
        Me.ptbUser.Name = "ptbUser"
        Me.ptbUser.Size = New System.Drawing.Size(146, 145)
        Me.ptbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbUser.TabIndex = 0
        Me.ptbUser.TabStop = False
        '
        'lblTieude
        '
        Me.lblTieude.AutoSize = True
        Me.lblTieude.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieude.ForeColor = System.Drawing.Color.Red
        Me.lblTieude.Location = New System.Drawing.Point(206, 9)
        Me.lblTieude.Name = "lblTieude"
        Me.lblTieude.Size = New System.Drawing.Size(110, 25)
        Me.lblTieude.TabIndex = 1
        Me.lblTieude.Text = "Đăng nhập"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(208, 65)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(88, 20)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(208, 119)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(84, 20)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(309, 65)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(164, 23)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(309, 115)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(164, 23)
        Me.txtPassword.TabIndex = 5
        '
        'btnDANGNHAP
        '
        Me.btnDANGNHAP.Location = New System.Drawing.Point(257, 165)
        Me.btnDANGNHAP.Name = "btnDANGNHAP"
        Me.btnDANGNHAP.Size = New System.Drawing.Size(87, 27)
        Me.btnDANGNHAP.TabIndex = 6
        Me.btnDANGNHAP.Text = "Đăng nhập"
        Me.btnDANGNHAP.UseVisualStyleBackColor = True
        '
        'btnDONG
        '
        Me.btnDONG.Location = New System.Drawing.Point(386, 165)
        Me.btnDONG.Name = "btnDONG"
        Me.btnDONG.Size = New System.Drawing.Size(87, 27)
        Me.btnDONG.TabIndex = 7
        Me.btnDONG.Text = "Đóng"
        Me.btnDONG.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 270)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDONG)
        Me.Controls.Add(Me.btnDANGNHAP)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblTieude)
        Me.Controls.Add(Me.ptbUser)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.ptbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptbUser As System.Windows.Forms.PictureBox
    Friend WithEvents lblTieude As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnDANGNHAP As System.Windows.Forms.Button
    Friend WithEvents btnDONG As System.Windows.Forms.Button

End Class
