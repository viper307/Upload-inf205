<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGiaodienchinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGiaodienchinh))
        Me.stsgiaodien = New System.Windows.Forms.StatusStrip()
        Me.lblwelcome = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnsgiaodien = New System.Windows.Forms.MenuStrip()
        Me.mnihethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDANGNHAP = New System.Windows.Forms.ToolStripMenuItem()
        Me.KếtThúcToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.mniKETTHUC = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnigiaitri = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniTRACNGHIEM = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDAPAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniquanli = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniBIENTAP = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.mniQUANLIUSER = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDanhsachKH = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniChinhsuaKH = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDanhsachSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniChinhsuaSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.tosgiaodien = New System.Windows.Forms.ToolStrip()
        Me.btndangnhap = New System.Windows.Forms.ToolStripButton()
        Me.btntracnghiem = New System.Windows.Forms.ToolStripButton()
        Me.btndapan = New System.Windows.Forms.ToolStripButton()
        Me.btnexit = New System.Windows.Forms.ToolStripButton()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.stsgiaodien.SuspendLayout()
        Me.mnsgiaodien.SuspendLayout()
        Me.tosgiaodien.SuspendLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stsgiaodien
        '
        Me.stsgiaodien.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblwelcome})
        Me.stsgiaodien.Location = New System.Drawing.Point(0, 330)
        Me.stsgiaodien.Name = "stsgiaodien"
        Me.stsgiaodien.Size = New System.Drawing.Size(661, 22)
        Me.stsgiaodien.TabIndex = 1
        Me.stsgiaodien.Text = "StatusStrip1"
        '
        'lblwelcome
        '
        Me.lblwelcome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.ForeColor = System.Drawing.Color.Red
        Me.lblwelcome.Image = CType(resources.GetObject("lblwelcome.Image"), System.Drawing.Image)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(221, 17)
        Me.lblwelcome.Text = "WELCOME TO MANAGER SALES...! :)"
        '
        'mnsgiaodien
        '
        Me.mnsgiaodien.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnihethong, Me.mnigiaitri, Me.mniquanli, Me.KháchHàngToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem})
        Me.mnsgiaodien.Location = New System.Drawing.Point(0, 0)
        Me.mnsgiaodien.Name = "mnsgiaodien"
        Me.mnsgiaodien.Size = New System.Drawing.Size(661, 24)
        Me.mnsgiaodien.TabIndex = 2
        Me.mnsgiaodien.Text = "MenuStrip1"
        '
        'mnihethong
        '
        Me.mnihethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniDANGNHAP, Me.KếtThúcToolStripMenuItem, Me.mniKETTHUC})
        Me.mnihethong.Name = "mnihethong"
        Me.mnihethong.Size = New System.Drawing.Size(69, 20)
        Me.mnihethong.Text = "Hệ thống"
        '
        'mniDANGNHAP
        '
        Me.mniDANGNHAP.AccessibleName = ""
        Me.mniDANGNHAP.Image = CType(resources.GetObject("mniDANGNHAP.Image"), System.Drawing.Image)
        Me.mniDANGNHAP.Name = "mniDANGNHAP"
        Me.mniDANGNHAP.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F10), System.Windows.Forms.Keys)
        Me.mniDANGNHAP.Size = New System.Drawing.Size(184, 22)
        Me.mniDANGNHAP.Text = "Đăng nhập"
        '
        'KếtThúcToolStripMenuItem
        '
        Me.KếtThúcToolStripMenuItem.Name = "KếtThúcToolStripMenuItem"
        Me.KếtThúcToolStripMenuItem.Size = New System.Drawing.Size(181, 6)
        '
        'mniKETTHUC
        '
        Me.mniKETTHUC.Image = CType(resources.GetObject("mniKETTHUC.Image"), System.Drawing.Image)
        Me.mniKETTHUC.Name = "mniKETTHUC"
        Me.mniKETTHUC.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F10), System.Windows.Forms.Keys)
        Me.mniKETTHUC.Size = New System.Drawing.Size(184, 22)
        Me.mniKETTHUC.Text = "Kết thúc"
        '
        'mnigiaitri
        '
        Me.mnigiaitri.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniTRACNGHIEM, Me.mniDAPAN})
        Me.mnigiaitri.Name = "mnigiaitri"
        Me.mnigiaitri.Size = New System.Drawing.Size(53, 20)
        Me.mnigiaitri.Text = "Giải trí"
        '
        'mniTRACNGHIEM
        '
        Me.mniTRACNGHIEM.Image = CType(resources.GetObject("mniTRACNGHIEM.Image"), System.Drawing.Image)
        Me.mniTRACNGHIEM.Name = "mniTRACNGHIEM"
        Me.mniTRACNGHIEM.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mniTRACNGHIEM.Size = New System.Drawing.Size(179, 22)
        Me.mniTRACNGHIEM.Text = "Trắc nghiệm vui"
        '
        'mniDAPAN
        '
        Me.mniDAPAN.Image = CType(resources.GetObject("mniDAPAN.Image"), System.Drawing.Image)
        Me.mniDAPAN.Name = "mniDAPAN"
        Me.mniDAPAN.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.mniDAPAN.Size = New System.Drawing.Size(179, 22)
        Me.mniDAPAN.Text = "Đáp án"
        '
        'mniquanli
        '
        Me.mniquanli.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniBIENTAP, Me.SToolStripMenuItem, Me.mniQUANLIUSER})
        Me.mniquanli.Name = "mniquanli"
        Me.mniquanli.Size = New System.Drawing.Size(57, 20)
        Me.mniquanli.Text = "Quản lí"
        '
        'mniBIENTAP
        '
        Me.mniBIENTAP.Image = CType(resources.GetObject("mniBIENTAP.Image"), System.Drawing.Image)
        Me.mniBIENTAP.Name = "mniBIENTAP"
        Me.mniBIENTAP.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F12), System.Windows.Forms.Keys)
        Me.mniBIENTAP.Size = New System.Drawing.Size(174, 22)
        Me.mniBIENTAP.Text = "Biên tập"
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(171, 6)
        '
        'mniQUANLIUSER
        '
        Me.mniQUANLIUSER.Image = CType(resources.GetObject("mniQUANLIUSER.Image"), System.Drawing.Image)
        Me.mniQUANLIUSER.Name = "mniQUANLIUSER"
        Me.mniQUANLIUSER.Size = New System.Drawing.Size(174, 22)
        Me.mniQUANLIUSER.Text = "Quản lí User"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniDanhsachKH, Me.mniChinhsuaKH})
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'mniDanhsachKH
        '
        Me.mniDanhsachKH.Image = CType(resources.GetObject("mniDanhsachKH.Image"), System.Drawing.Image)
        Me.mniDanhsachKH.Name = "mniDanhsachKH"
        Me.mniDanhsachKH.Size = New System.Drawing.Size(194, 22)
        Me.mniDanhsachKH.Text = "Danh sách khách hàng"
        '
        'mniChinhsuaKH
        '
        Me.mniChinhsuaKH.Image = CType(resources.GetObject("mniChinhsuaKH.Image"), System.Drawing.Image)
        Me.mniChinhsuaKH.Name = "mniChinhsuaKH"
        Me.mniChinhsuaKH.Size = New System.Drawing.Size(194, 22)
        Me.mniChinhsuaKH.Text = "Chỉnh sửa khách hàng"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniDanhsachSP, Me.mniChinhsuaSP})
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản Phẩm"
        '
        'mniDanhsachSP
        '
        Me.mniDanhsachSP.Image = CType(resources.GetObject("mniDanhsachSP.Image"), System.Drawing.Image)
        Me.mniDanhsachSP.Name = "mniDanhsachSP"
        Me.mniDanhsachSP.Size = New System.Drawing.Size(185, 22)
        Me.mniDanhsachSP.Text = "Danh sách Sản Phẩm"
        '
        'mniChinhsuaSP
        '
        Me.mniChinhsuaSP.Image = CType(resources.GetObject("mniChinhsuaSP.Image"), System.Drawing.Image)
        Me.mniChinhsuaSP.Name = "mniChinhsuaSP"
        Me.mniChinhsuaSP.Size = New System.Drawing.Size(185, 22)
        Me.mniChinhsuaSP.Text = "Chỉnh sửa sản phẩm"
        '
        'tosgiaodien
        '
        Me.tosgiaodien.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btndangnhap, Me.btntracnghiem, Me.btndapan, Me.btnexit})
        Me.tosgiaodien.Location = New System.Drawing.Point(0, 24)
        Me.tosgiaodien.Name = "tosgiaodien"
        Me.tosgiaodien.Size = New System.Drawing.Size(661, 25)
        Me.tosgiaodien.TabIndex = 3
        Me.tosgiaodien.Text = "ToolStrip1"
        '
        'btndangnhap
        '
        Me.btndangnhap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btndangnhap.Image = CType(resources.GetObject("btndangnhap.Image"), System.Drawing.Image)
        Me.btndangnhap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(23, 22)
        Me.btndangnhap.Text = "ToolStripButton2"
        '
        'btntracnghiem
        '
        Me.btntracnghiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btntracnghiem.Image = CType(resources.GetObject("btntracnghiem.Image"), System.Drawing.Image)
        Me.btntracnghiem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btntracnghiem.Name = "btntracnghiem"
        Me.btntracnghiem.Size = New System.Drawing.Size(23, 22)
        Me.btntracnghiem.Text = "ToolStripButton1"
        '
        'btndapan
        '
        Me.btndapan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btndapan.Image = CType(resources.GetObject("btndapan.Image"), System.Drawing.Image)
        Me.btndapan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndapan.Name = "btndapan"
        Me.btndapan.Size = New System.Drawing.Size(23, 22)
        Me.btndapan.Text = "ToolStripButton3"
        '
        'btnexit
        '
        Me.btnexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnexit.Image = CType(resources.GetObject("btnexit.Image"), System.Drawing.Image)
        Me.btnexit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(23, 22)
        Me.btnexit.Text = "ToolStripButton5"
        '
        'pic2
        '
        Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(63, 94)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(194, 161)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 4
        Me.pic2.TabStop = False
        '
        'pic1
        '
        Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(373, 96)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(186, 158)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 5
        Me.pic1.TabStop = False
        '
        'frmGiaodienchinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 352)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.tosgiaodien)
        Me.Controls.Add(Me.stsgiaodien)
        Me.Controls.Add(Me.mnsgiaodien)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnsgiaodien
        Me.Name = "frmGiaodienchinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manager Sales"
        Me.TransparencyKey = System.Drawing.Color.LightGray
        Me.stsgiaodien.ResumeLayout(False)
        Me.stsgiaodien.PerformLayout()
        Me.mnsgiaodien.ResumeLayout(False)
        Me.mnsgiaodien.PerformLayout()
        Me.tosgiaodien.ResumeLayout(False)
        Me.tosgiaodien.PerformLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsgiaodien As System.Windows.Forms.StatusStrip
    Friend WithEvents mnsgiaodien As System.Windows.Forms.MenuStrip
    Friend WithEvents mnihethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDANGNHAP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KếtThúcToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mniKETTHUC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnigiaitri As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniTRACNGHIEM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDAPAN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniquanli As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniBIENTAP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tosgiaodien As System.Windows.Forms.ToolStrip
    Friend WithEvents SToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btntracnghiem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btndangnhap As System.Windows.Forms.ToolStripButton
    Friend WithEvents btndapan As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnexit As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblwelcome As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents mniQUANLIUSER As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDanhsachKH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniChinhsuaKH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDanhsachSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniChinhsuaSP As System.Windows.Forms.ToolStripMenuItem

End Class
