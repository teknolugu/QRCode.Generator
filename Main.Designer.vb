<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ClrDialog = New System.Windows.Forms.ColorDialog()
        Me.SettingsContextMenu = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndonesianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpContextMenu = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ContactSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelHeader = New MaterialFramework.MaterialPanel()
        Me.LinkSettings = New MetroFramework.Controls.MetroLink()
        Me.LblAppName = New System.Windows.Forms.Label()
        Me.LinkHelp = New MetroFramework.Controls.MetroLink()
        Me.MainPanel = New MaterialFramework.MaterialPanel()
        Me.CheckUseImage = New MetroFramework.Controls.MetroCheckBox()
        Me.BtnGenerate = New MaterialFramework.LollipopButton()
        Me.LinkSave = New MetroFramework.Controls.MetroLink()
        Me.BtnQrCodeBackColor = New MaterialFramework.LollipopButton()
        Me.BtnQrCodeColor = New MaterialFramework.LollipopButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.TxtImagePath = New MaterialFramework.LollipopTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtData = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHeight = New MaterialFramework.LollipopTextBox()
        Me.txtWidth = New MaterialFramework.LollipopTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtQrBackColor = New MaterialFramework.LollipopTextBox()
        Me.PictQRCode = New System.Windows.Forms.PictureBox()
        Me.TxtQrCodeColor = New MaterialFramework.LollipopTextBox()
        Me.LabelQR = New System.Windows.Forms.Label()
        Me.PictQrCodeColor = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictQrCodeBackColor = New System.Windows.Forms.PictureBox()
        Me.SettingsContextMenu.SuspendLayout()
        Me.HelpContextMenu.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        CType(Me.PictQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictQrCodeColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictQrCodeBackColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SettingsContextMenu
        '
        Me.SettingsContextMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SettingsContextMenu.Depth = 0
        Me.SettingsContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LanguageToolStripMenuItem, Me.ThemeToolStripMenuItem})
        Me.SettingsContextMenu.MouseState = MaterialSkin.MouseState.HOVER
        Me.SettingsContextMenu.Name = "SettingsContextMenu"
        resources.ApplyResources(Me.SettingsContextMenu, "SettingsContextMenu")
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndonesianToolStripMenuItem, Me.EnglishToolStripMenuItem})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        resources.ApplyResources(Me.LanguageToolStripMenuItem, "LanguageToolStripMenuItem")
        '
        'IndonesianToolStripMenuItem
        '
        Me.IndonesianToolStripMenuItem.Name = "IndonesianToolStripMenuItem"
        resources.ApplyResources(Me.IndonesianToolStripMenuItem, "IndonesianToolStripMenuItem")
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        resources.ApplyResources(Me.EnglishToolStripMenuItem, "EnglishToolStripMenuItem")
        '
        'ThemeToolStripMenuItem
        '
        Me.ThemeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LightToolStripMenuItem, Me.DarkToolStripMenuItem})
        Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        resources.ApplyResources(Me.ThemeToolStripMenuItem, "ThemeToolStripMenuItem")
        '
        'LightToolStripMenuItem
        '
        Me.LightToolStripMenuItem.Name = "LightToolStripMenuItem"
        resources.ApplyResources(Me.LightToolStripMenuItem, "LightToolStripMenuItem")
        '
        'DarkToolStripMenuItem
        '
        Me.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem"
        resources.ApplyResources(Me.DarkToolStripMenuItem, "DarkToolStripMenuItem")
        '
        'HelpContextMenu
        '
        Me.HelpContextMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HelpContextMenu.Depth = 0
        Me.HelpContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactSupportToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpContextMenu.MouseState = MaterialSkin.MouseState.HOVER
        Me.HelpContextMenu.Name = "HelpContextMenu"
        resources.ApplyResources(Me.HelpContextMenu, "HelpContextMenu")
        '
        'ContactSupportToolStripMenuItem
        '
        Me.ContactSupportToolStripMenuItem.Name = "ContactSupportToolStripMenuItem"
        resources.ApplyResources(Me.ContactSupportToolStripMenuItem, "ContactSupportToolStripMenuItem")
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        '
        'PanelHeader
        '
        resources.ApplyResources(Me.PanelHeader, "PanelHeader")
        Me.PanelHeader.Controls.Add(Me.LinkSettings)
        Me.PanelHeader.Controls.Add(Me.LblAppName)
        Me.PanelHeader.Controls.Add(Me.LinkHelp)
        Me.PanelHeader.DarkTheme = False
        Me.PanelHeader.Name = "PanelHeader"
        '
        'LinkSettings
        '
        resources.ApplyResources(Me.LinkSettings, "LinkSettings")
        Me.LinkSettings.BackColor = System.Drawing.Color.Transparent
        Me.LinkSettings.Image = Global.QRCode_Generator.My.Resources.Resources.baseline_settings_black_18dp
        Me.LinkSettings.Name = "LinkSettings"
        Me.LinkSettings.UseCustomBackColor = True
        Me.LinkSettings.UseSelectable = True
        '
        'LblAppName
        '
        resources.ApplyResources(Me.LblAppName, "LblAppName")
        Me.LblAppName.BackColor = System.Drawing.Color.Transparent
        Me.LblAppName.Name = "LblAppName"
        '
        'LinkHelp
        '
        resources.ApplyResources(Me.LinkHelp, "LinkHelp")
        Me.LinkHelp.BackColor = System.Drawing.Color.Transparent
        Me.LinkHelp.Image = Global.QRCode_Generator.My.Resources.Resources.baseline_help_black_18dp
        Me.LinkHelp.Name = "LinkHelp"
        Me.LinkHelp.UseCustomBackColor = True
        Me.LinkHelp.UseSelectable = True
        '
        'MainPanel
        '
        resources.ApplyResources(Me.MainPanel, "MainPanel")
        Me.MainPanel.Controls.Add(Me.CheckUseImage)
        Me.MainPanel.Controls.Add(Me.BtnGenerate)
        Me.MainPanel.Controls.Add(Me.LinkSave)
        Me.MainPanel.Controls.Add(Me.BtnQrCodeBackColor)
        Me.MainPanel.Controls.Add(Me.BtnQrCodeColor)
        Me.MainPanel.Controls.Add(Me.Label7)
        Me.MainPanel.Controls.Add(Me.BtnBrowse)
        Me.MainPanel.Controls.Add(Me.TxtImagePath)
        Me.MainPanel.Controls.Add(Me.Label8)
        Me.MainPanel.Controls.Add(Me.Label6)
        Me.MainPanel.Controls.Add(Me.TxtData)
        Me.MainPanel.Controls.Add(Me.Label1)
        Me.MainPanel.Controls.Add(Me.txtHeight)
        Me.MainPanel.Controls.Add(Me.txtWidth)
        Me.MainPanel.Controls.Add(Me.Label5)
        Me.MainPanel.Controls.Add(Me.TxtQrBackColor)
        Me.MainPanel.Controls.Add(Me.PictQRCode)
        Me.MainPanel.Controls.Add(Me.TxtQrCodeColor)
        Me.MainPanel.Controls.Add(Me.LabelQR)
        Me.MainPanel.Controls.Add(Me.PictQrCodeColor)
        Me.MainPanel.Controls.Add(Me.Label2)
        Me.MainPanel.Controls.Add(Me.Label3)
        Me.MainPanel.Controls.Add(Me.PictQrCodeBackColor)
        Me.MainPanel.DarkTheme = False
        Me.MainPanel.Name = "MainPanel"
        '
        'CheckUseImage
        '
        resources.ApplyResources(Me.CheckUseImage, "CheckUseImage")
        Me.CheckUseImage.BackColor = System.Drawing.Color.Transparent
        Me.CheckUseImage.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.CheckUseImage.Name = "CheckUseImage"
        Me.CheckUseImage.UseCustomBackColor = True
        Me.CheckUseImage.UseSelectable = True
        '
        'BtnGenerate
        '
        resources.ApplyResources(Me.BtnGenerate, "BtnGenerate")
        Me.BtnGenerate.BGColor = "#508ef5"
        Me.BtnGenerate.FontColor = "#ffffff"
        Me.BtnGenerate.Name = "BtnGenerate"
        '
        'LinkSave
        '
        resources.ApplyResources(Me.LinkSave, "LinkSave")
        Me.LinkSave.BackColor = System.Drawing.Color.Transparent
        Me.LinkSave.Image = Global.QRCode_Generator.My.Resources.Resources.baseline_save_black_18dp
        Me.LinkSave.Name = "LinkSave"
        Me.LinkSave.UseCustomBackColor = True
        Me.LinkSave.UseSelectable = True
        '
        'BtnQrCodeBackColor
        '
        Me.BtnQrCodeBackColor.BGColor = "#508ef5"
        Me.BtnQrCodeBackColor.FontColor = "#ffffff"
        resources.ApplyResources(Me.BtnQrCodeBackColor, "BtnQrCodeBackColor")
        Me.BtnQrCodeBackColor.Name = "BtnQrCodeBackColor"
        '
        'BtnQrCodeColor
        '
        Me.BtnQrCodeColor.BGColor = "#508ef5"
        Me.BtnQrCodeColor.FontColor = "#ffffff"
        resources.ApplyResources(Me.BtnQrCodeColor, "BtnQrCodeColor")
        Me.BtnQrCodeColor.Name = "BtnQrCodeColor"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Name = "Label7"
        '
        'BtnBrowse
        '
        resources.ApplyResources(Me.BtnBrowse, "BtnBrowse")
        Me.BtnBrowse.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnBrowse.FlatAppearance.BorderSize = 0
        Me.BtnBrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'TxtImagePath
        '
        resources.ApplyResources(Me.TxtImagePath, "TxtImagePath")
        Me.TxtImagePath.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtImagePath.DarkTheme = False
        Me.TxtImagePath.FocusedColor = "#508ef5"
        Me.TxtImagePath.FontColor = "#999999"
        Me.TxtImagePath.IsEnabled = True
        Me.TxtImagePath.MaxLength = 32767
        Me.TxtImagePath.Multiline = False
        Me.TxtImagePath.Name = "TxtImagePath"
        Me.TxtImagePath.ReadOnly = True
        Me.TxtImagePath.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtImagePath.UseSystemPasswordChar = False
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label8.Name = "Label8"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Name = "Label6"
        '
        'TxtData
        '
        resources.ApplyResources(Me.TxtData, "TxtData")
        Me.TxtData.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtData.Name = "TxtData"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'txtHeight
        '
        Me.txtHeight.DarkTheme = False
        Me.txtHeight.FocusedColor = "#508ef5"
        Me.txtHeight.FontColor = "#999999"
        Me.txtHeight.IsEnabled = True
        resources.ApplyResources(Me.txtHeight, "txtHeight")
        Me.txtHeight.MaxLength = 32767
        Me.txtHeight.Multiline = False
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = False
        Me.txtHeight.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtHeight.UseSystemPasswordChar = False
        '
        'txtWidth
        '
        Me.txtWidth.DarkTheme = False
        Me.txtWidth.FocusedColor = "#508ef5"
        Me.txtWidth.FontColor = "#999999"
        Me.txtWidth.IsEnabled = True
        resources.ApplyResources(Me.txtWidth, "txtWidth")
        Me.txtWidth.MaxLength = 32767
        Me.txtWidth.Multiline = False
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.ReadOnly = False
        Me.txtWidth.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtWidth.UseSystemPasswordChar = False
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Name = "Label5"
        '
        'TxtQrBackColor
        '
        Me.TxtQrBackColor.DarkTheme = False
        Me.TxtQrBackColor.FocusedColor = "#508ef5"
        Me.TxtQrBackColor.FontColor = "#999999"
        Me.TxtQrBackColor.IsEnabled = True
        resources.ApplyResources(Me.TxtQrBackColor, "TxtQrBackColor")
        Me.TxtQrBackColor.MaxLength = 32767
        Me.TxtQrBackColor.Multiline = False
        Me.TxtQrBackColor.Name = "TxtQrBackColor"
        Me.TxtQrBackColor.ReadOnly = False
        Me.TxtQrBackColor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtQrBackColor.UseSystemPasswordChar = False
        '
        'PictQRCode
        '
        resources.ApplyResources(Me.PictQRCode, "PictQRCode")
        Me.PictQRCode.Name = "PictQRCode"
        Me.PictQRCode.TabStop = False
        '
        'TxtQrCodeColor
        '
        Me.TxtQrCodeColor.DarkTheme = False
        Me.TxtQrCodeColor.FocusedColor = "#508ef5"
        Me.TxtQrCodeColor.FontColor = "#999999"
        Me.TxtQrCodeColor.IsEnabled = True
        resources.ApplyResources(Me.TxtQrCodeColor, "TxtQrCodeColor")
        Me.TxtQrCodeColor.MaxLength = 32767
        Me.TxtQrCodeColor.Multiline = False
        Me.TxtQrCodeColor.Name = "TxtQrCodeColor"
        Me.TxtQrCodeColor.ReadOnly = False
        Me.TxtQrCodeColor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtQrCodeColor.UseSystemPasswordChar = False
        '
        'LabelQR
        '
        resources.ApplyResources(Me.LabelQR, "LabelQR")
        Me.LabelQR.BackColor = System.Drawing.Color.Transparent
        Me.LabelQR.Name = "LabelQR"
        '
        'PictQrCodeColor
        '
        Me.PictQrCodeColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictQrCodeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.PictQrCodeColor, "PictQrCodeColor")
        Me.PictQrCodeColor.Name = "PictQrCodeColor"
        Me.PictQrCodeColor.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'PictQrCodeBackColor
        '
        Me.PictQrCodeBackColor.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictQrCodeBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.PictQrCodeBackColor, "PictQrCodeBackColor")
        Me.PictQrCodeBackColor.Name = "PictQrCodeBackColor"
        Me.PictQrCodeBackColor.TabStop = False
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "Main"
        Me.SettingsContextMenu.ResumeLayout(False)
        Me.HelpContextMenu.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.PictQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictQrCodeColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictQrCodeBackColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictQRCode As PictureBox
    Friend WithEvents LinkSave As MetroFramework.Controls.MetroLink
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtData As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictQrCodeColor As PictureBox
    Friend WithEvents PictQrCodeBackColor As PictureBox
    Friend WithEvents MainPanel As MaterialFramework.MaterialPanel
    Friend WithEvents PanelHeader As MaterialFramework.MaterialPanel
    Friend WithEvents LabelQR As Label
    Friend WithEvents TxtQrBackColor As MaterialFramework.LollipopTextBox
    Friend WithEvents TxtQrCodeColor As MaterialFramework.LollipopTextBox
    Friend WithEvents txtWidth As MaterialFramework.LollipopTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHeight As MaterialFramework.LollipopTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents TxtImagePath As MaterialFramework.LollipopTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnQrCodeColor As MaterialFramework.LollipopButton
    Friend WithEvents BtnGenerate As MaterialFramework.LollipopButton
    Friend WithEvents BtnQrCodeBackColor As MaterialFramework.LollipopButton
    Friend WithEvents ClrDialog As ColorDialog
    Friend WithEvents LinkHelp As MetroFramework.Controls.MetroLink
    Friend WithEvents LblAppName As Label
    Friend WithEvents LinkSettings As MetroFramework.Controls.MetroLink
    Friend WithEvents SettingsContextMenu As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents LanguageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndonesianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpContextMenu As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ContactSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckUseImage As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkToolStripMenuItem As ToolStripMenuItem
End Class
