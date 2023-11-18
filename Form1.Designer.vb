<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelMenu = New Panel()
        btnSetting = New FontAwesome.Sharp.IconButton()
        btnMarketing = New FontAwesome.Sharp.IconButton()
        btnCostumers = New FontAwesome.Sharp.IconButton()
        btnProducts = New FontAwesome.Sharp.IconButton()
        btnOrders = New FontAwesome.Sharp.IconButton()
        btnDashboard = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        imgHome = New PictureBox()
        PanelTitleBar = New Panel()
        lbl_FormTitle = New Label()
        IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelDesktop = New Panel()
        PictureBox1 = New PictureBox()
        PanelMenu.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(imgHome, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitleBar.SuspendLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        PanelDesktop.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PanelMenu.Controls.Add(btnSetting)
        PanelMenu.Controls.Add(btnMarketing)
        PanelMenu.Controls.Add(btnCostumers)
        PanelMenu.Controls.Add(btnProducts)
        PanelMenu.Controls.Add(btnOrders)
        PanelMenu.Controls.Add(btnDashboard)
        PanelMenu.Controls.Add(PanelLogo)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(220, 603)
        PanelMenu.TabIndex = 0
        ' 
        ' btnSetting
        ' 
        btnSetting.Dock = DockStyle.Top
        btnSetting.FlatAppearance.BorderSize = 0
        btnSetting.FlatStyle = FlatStyle.Flat
        btnSetting.ForeColor = Color.Gainsboro
        btnSetting.IconChar = FontAwesome.Sharp.IconChar.Tools
        btnSetting.IconColor = Color.Gainsboro
        btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSetting.IconSize = 32
        btnSetting.ImageAlign = ContentAlignment.MiddleLeft
        btnSetting.Location = New Point(0, 440)
        btnSetting.Name = "btnSetting"
        btnSetting.Padding = New Padding(10, 0, 20, 0)
        btnSetting.Size = New Size(220, 60)
        btnSetting.TabIndex = 6
        btnSetting.Text = "Setting"
        btnSetting.TextAlign = ContentAlignment.MiddleLeft
        btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSetting.UseVisualStyleBackColor = True
        ' 
        ' btnMarketing
        ' 
        btnMarketing.Dock = DockStyle.Top
        btnMarketing.FlatAppearance.BorderSize = 0
        btnMarketing.FlatStyle = FlatStyle.Flat
        btnMarketing.ForeColor = Color.Gainsboro
        btnMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk
        btnMarketing.IconColor = Color.Gainsboro
        btnMarketing.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMarketing.IconSize = 32
        btnMarketing.ImageAlign = ContentAlignment.MiddleLeft
        btnMarketing.Location = New Point(0, 380)
        btnMarketing.Name = "btnMarketing"
        btnMarketing.Padding = New Padding(10, 0, 20, 0)
        btnMarketing.Size = New Size(220, 60)
        btnMarketing.TabIndex = 5
        btnMarketing.Text = "Marketing"
        btnMarketing.TextAlign = ContentAlignment.MiddleLeft
        btnMarketing.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMarketing.UseVisualStyleBackColor = True
        ' 
        ' btnCostumers
        ' 
        btnCostumers.Dock = DockStyle.Top
        btnCostumers.FlatAppearance.BorderSize = 0
        btnCostumers.FlatStyle = FlatStyle.Flat
        btnCostumers.ForeColor = Color.Gainsboro
        btnCostumers.IconChar = FontAwesome.Sharp.IconChar.User
        btnCostumers.IconColor = Color.Gainsboro
        btnCostumers.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCostumers.IconSize = 32
        btnCostumers.ImageAlign = ContentAlignment.MiddleLeft
        btnCostumers.Location = New Point(0, 320)
        btnCostumers.Name = "btnCostumers"
        btnCostumers.Padding = New Padding(10, 0, 20, 0)
        btnCostumers.Size = New Size(220, 60)
        btnCostumers.TabIndex = 4
        btnCostumers.Text = "Costumers"
        btnCostumers.TextAlign = ContentAlignment.MiddleLeft
        btnCostumers.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCostumers.UseVisualStyleBackColor = True
        ' 
        ' btnProducts
        ' 
        btnProducts.Dock = DockStyle.Top
        btnProducts.FlatAppearance.BorderSize = 0
        btnProducts.FlatStyle = FlatStyle.Flat
        btnProducts.ForeColor = Color.Gainsboro
        btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tag
        btnProducts.IconColor = Color.Gainsboro
        btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnProducts.IconSize = 32
        btnProducts.ImageAlign = ContentAlignment.MiddleLeft
        btnProducts.Location = New Point(0, 260)
        btnProducts.Name = "btnProducts"
        btnProducts.Padding = New Padding(10, 0, 20, 0)
        btnProducts.Size = New Size(220, 60)
        btnProducts.TabIndex = 3
        btnProducts.Text = "Products"
        btnProducts.TextAlign = ContentAlignment.MiddleLeft
        btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' btnOrders
        ' 
        btnOrders.Dock = DockStyle.Top
        btnOrders.FlatAppearance.BorderSize = 0
        btnOrders.FlatStyle = FlatStyle.Flat
        btnOrders.ForeColor = Color.Gainsboro
        btnOrders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        btnOrders.IconColor = Color.Gainsboro
        btnOrders.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnOrders.IconSize = 32
        btnOrders.ImageAlign = ContentAlignment.MiddleLeft
        btnOrders.Location = New Point(0, 200)
        btnOrders.Name = "btnOrders"
        btnOrders.Padding = New Padding(10, 0, 20, 0)
        btnOrders.Size = New Size(220, 60)
        btnOrders.TabIndex = 2
        btnOrders.Text = "Orders"
        btnOrders.TextAlign = ContentAlignment.MiddleLeft
        btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText
        btnOrders.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = Color.Gainsboro
        btnDashboard.IconChar = FontAwesome.Sharp.IconChar.LineChart
        btnDashboard.IconColor = Color.Gainsboro
        btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDashboard.IconSize = 32
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(0, 140)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(10, 0, 20, 0)
        btnDashboard.Size = New Size(220, 60)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(imgHome)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(220, 140)
        PanelLogo.TabIndex = 0
        ' 
        ' imgHome
        ' 
        imgHome.Image = My.Resources.Resources.bitzen_logo
        imgHome.Location = New Point(32, 32)
        imgHome.Name = "imgHome"
        imgHome.Size = New Size(145, 73)
        imgHome.SizeMode = PictureBoxSizeMode.Zoom
        imgHome.TabIndex = 0
        imgHome.TabStop = False
        ' 
        ' PanelTitleBar
        ' 
        PanelTitleBar.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        PanelTitleBar.Controls.Add(lbl_FormTitle)
        PanelTitleBar.Controls.Add(IconCurrentForm)
        PanelTitleBar.Dock = DockStyle.Top
        PanelTitleBar.Location = New Point(220, 0)
        PanelTitleBar.Name = "PanelTitleBar"
        PanelTitleBar.Size = New Size(580, 75)
        PanelTitleBar.TabIndex = 1
        ' 
        ' lbl_FormTitle
        ' 
        lbl_FormTitle.AutoSize = True
        lbl_FormTitle.ForeColor = Color.Gainsboro
        lbl_FormTitle.Location = New Point(56, 32)
        lbl_FormTitle.Name = "lbl_FormTitle"
        lbl_FormTitle.Size = New Size(40, 15)
        lbl_FormTitle.TabIndex = 1
        lbl_FormTitle.Text = "Home"
        ' 
        ' IconCurrentForm
        ' 
        IconCurrentForm.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(62))
        IconCurrentForm.ForeColor = Color.MediumPurple
        IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        IconCurrentForm.IconColor = Color.MediumPurple
        IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconCurrentForm.Location = New Point(18, 24)
        IconCurrentForm.Name = "IconCurrentForm"
        IconCurrentForm.Size = New Size(32, 32)
        IconCurrentForm.TabIndex = 0
        IconCurrentForm.TabStop = False
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        PanelDesktop.Controls.Add(PictureBox1)
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(220, 75)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(580, 528)
        PanelDesktop.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = My.Resources.Resources.bitzen_logo
        PictureBox1.Location = New Point(129, 146)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(317, 99)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 603)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelTitleBar)
        Controls.Add(PanelMenu)
        Name = "Form1"
        Text = "Form1"
        PanelMenu.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(imgHome, ComponentModel.ISupportInitialize).EndInit()
        PanelTitleBar.ResumeLayout(False)
        PanelTitleBar.PerformLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        PanelDesktop.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSetting As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMarketing As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCostumers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProducts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOrders As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lbl_FormTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox

End Class
