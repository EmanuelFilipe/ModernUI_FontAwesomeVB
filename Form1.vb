Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class Form1
    'Fields

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Private closeIcon As IconChar = IconChar.WindowClose

    Public Sub New()
        InitializeComponent()

        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

        'form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AssignIconToButton(btnFechar, closeIcon)
        'AssignIconToButton(btnMinimizar, minimizeIcon)
        'AssignIconToButton(btnMaximizar, maximizeIcon)
    End Sub

    'methods
    Private Sub AssignIconToButton(button As IconButton, icon As IconChar)
        button.IconChar = icon
        button.IconColor = Color.White ' Cor do ícone
        button.Font = New Font("FontAwesome", 12, FontStyle.Regular) ' Fonte FontAwesome e tamanho
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            'left border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            'Curret Form Icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText

        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        'PanelDesktop.Controls.Add(childForm)
        'PanelDesktop.Tag = childForm

        Me.Controls.Add(childForm)

        childForm.BringToFront()
        childForm.Show()
        lbl_FormTitle.Text = childForm.Text
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormDashboard)
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        ActivateButton(sender, RGBColors.color2)
        OpenChildForm(New FormOrders)
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        ActivateButton(sender, RGBColors.color3)
        OpenChildForm(New FormProducts)
    End Sub

    Private Sub btnCostumers_Click(sender As Object, e As EventArgs) Handles btnCostumers.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New FormCostumers)
    End Sub

    Private Sub btnMarketing_Click(sender As Object, e As EventArgs) Handles btnMarketing.Click
        ActivateButton(sender, RGBColors.color5)
        OpenChildForm(New FormMarketing)
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        ActivateButton(sender, RGBColors.color6)
        OpenChildForm(New FormSetting)
    End Sub

    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        lbl_FormTitle.Text = "Home"

    End Sub

    'drag form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal IParam As Integer)

    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub
End Class
