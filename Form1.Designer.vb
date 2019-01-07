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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtData = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaterialPanel2 = New MaterialFramework.MaterialPanel()
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
        Me.txtHeight = New MaterialFramework.LollipopTextBox()
        Me.txtWidth = New MaterialFramework.LollipopTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtQrBackColor = New MaterialFramework.LollipopTextBox()
        Me.PictQRCode = New System.Windows.Forms.PictureBox()
        Me.TxtQrCodeColor = New MaterialFramework.LollipopTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictQrCodeColor = New System.Windows.Forms.PictureBox()
        Me.PictQrCodeBackColor = New System.Windows.Forms.PictureBox()
        Me.MaterialPanel3 = New MaterialFramework.MaterialPanel()
        Me.LinkSettings = New MetroFramework.Controls.MetroLink()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkHelp = New MetroFramework.Controls.MetroLink()
        Me.ClrDialog = New System.Windows.Forms.ColorDialog()
        Me.SettingsContextMenu = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndonesianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpContextMenu = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ContactSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialPanel2.SuspendLayout()
        CType(Me.PictQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictQrCodeColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictQrCodeBackColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialPanel3.SuspendLayout()
        Me.SettingsContextMenu.SuspendLayout()
        Me.HelpContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TxtData
        '
        resources.ApplyResources(Me.TxtData, "TxtData")
        Me.TxtData.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtData.Name = "TxtData"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'MaterialPanel2
        '
        resources.ApplyResources(Me.MaterialPanel2, "MaterialPanel2")
        Me.MaterialPanel2.Controls.Add(Me.CheckUseImage)
        Me.MaterialPanel2.Controls.Add(Me.BtnGenerate)
        Me.MaterialPanel2.Controls.Add(Me.LinkSave)
        Me.MaterialPanel2.Controls.Add(Me.BtnQrCodeBackColor)
        Me.MaterialPanel2.Controls.Add(Me.BtnQrCodeColor)
        Me.MaterialPanel2.Controls.Add(Me.Label7)
        Me.MaterialPanel2.Controls.Add(Me.BtnBrowse)
        Me.MaterialPanel2.Controls.Add(Me.TxtImagePath)
        Me.MaterialPanel2.Controls.Add(Me.Label8)
        Me.MaterialPanel2.Controls.Add(Me.Label6)
        Me.MaterialPanel2.Controls.Add(Me.TxtData)
        Me.MaterialPanel2.Controls.Add(Me.Label1)
        Me.MaterialPanel2.Controls.Add(Me.txtHeight)
        Me.MaterialPanel2.Controls.Add(Me.txtWidth)
        Me.MaterialPanel2.Controls.Add(Me.Label5)
        Me.MaterialPanel2.Controls.Add(Me.TxtQrBackColor)
        Me.MaterialPanel2.Controls.Add(Me.PictQRCode)
        Me.MaterialPanel2.Controls.Add(Me.TxtQrCodeColor)
        Me.MaterialPanel2.Controls.Add(Me.Label4)
        Me.MaterialPanel2.Controls.Add(Me.PictQrCodeColor)
        Me.MaterialPanel2.Controls.Add(Me.Label2)
        Me.MaterialPanel2.Controls.Add(Me.Label3)
        Me.MaterialPanel2.Controls.Add(Me.PictQrCodeBackColor)
        Me.MaterialPanel2.Name = "MaterialPanel2"
        '
        'CheckUseImage
        '
        resources.ApplyResources(Me.CheckUseImage, "CheckUseImage")
        Me.CheckUseImage.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.CheckUseImage.Name = "CheckUseImage"
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
        Me.LinkSave.Image = Global.QRCode_Generator.My.Resources.Resources.baseline_save_black_18dp
        Me.LinkSave.Name = "LinkSave"
        Me.LinkSave.UseSelectable = True
        '
        'BtnQrCodeBackColor
        '
        resources.ApplyResources(Me.BtnQrCodeBackColor, "BtnQrCodeBackColor")
        Me.BtnQrCodeBackColor.BGColor = "#508ef5"
        Me.BtnQrCodeBackColor.FontColor = "#ffffff"
        Me.BtnQrCodeBackColor.Name = "BtnQrCodeBackColor"
        '
        'BtnQrCodeColor
        '
        resources.ApplyResources(Me.BtnQrCodeColor, "BtnQrCodeColor")
        Me.BtnQrCodeColor.BGColor = "#508ef5"
        Me.BtnQrCodeColor.FontColor = "#ffffff"
        Me.BtnQrCodeColor.Name = "BtnQrCodeColor"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
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
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label8.Name = "Label8"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtHeight
        '
        resources.ApplyResources(Me.txtHeight, "txtHeight")
        Me.txtHeight.FocusedColor = "#508ef5"
        Me.txtHeight.FontColor = "#999999"
        Me.txtHeight.IsEnabled = True
        Me.txtHeight.MaxLength = 32767
        Me.txtHeight.Multiline = False
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = False
        Me.txtHeight.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtHeight.UseSystemPasswordChar = False
        '
        'txtWidth
        '
        resources.ApplyResources(Me.txtWidth, "txtWidth")
        Me.txtWidth.FocusedColor = "#508ef5"
        Me.txtWidth.FontColor = "#999999"
        Me.txtWidth.IsEnabled = True
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
        Me.Label5.Name = "Label5"
        '
        'TxtQrBackColor
        '
        resources.ApplyResources(Me.TxtQrBackColor, "TxtQrBackColor")
        Me.TxtQrBackColor.FocusedColor = "#508ef5"
        Me.TxtQrBackColor.FontColor = "#999999"
        Me.TxtQrBackColor.IsEnabled = True
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
        resources.ApplyResources(Me.TxtQrCodeColor, "TxtQrCodeColor")
        Me.TxtQrCodeColor.FocusedColor = "#508ef5"
        Me.TxtQrCodeColor.FontColor = "#999999"
        Me.TxtQrCodeColor.IsEnabled = True
        Me.TxtQrCodeColor.MaxLength = 32767
        Me.TxtQrCodeColor.Multiline = False
        Me.TxtQrCodeColor.Name = "TxtQrCodeColor"
        Me.TxtQrCodeColor.ReadOnly = False
        Me.TxtQrCodeColor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtQrCodeColor.UseSystemPasswordChar = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'PictQrCodeColor
        '
        resources.ApplyResources(Me.PictQrCodeColor, "PictQrCodeColor")
        Me.PictQrCodeColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictQrCodeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictQrCodeColor.Name = "PictQrCodeColor"
        Me.PictQrCodeColor.TabStop = False
        '
        'PictQrCodeBackColor
        '
        resources.ApplyResources(Me.PictQrCodeBackColor, "PictQrCodeBackColor")
        Me.PictQrCodeBackColor.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictQrCodeBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictQrCodeBackColor.Name = "PictQrCodeBackColor"
        Me.PictQrCodeBackColor.TabStop = False
        '
        'MaterialPanel3
        '
        resources.ApplyResources(Me.MaterialPanel3, "MaterialPanel3")
        Me.MaterialPanel3.Controls.Add(Me.LinkSettings)
        Me.MaterialPanel3.Controls.Add(Me.Label9)
        Me.MaterialPanel3.Controls.Add(Me.LinkHelp)
        Me.MaterialPanel3.Name = "MaterialPanel3"
        '
        'LinkSettings
        '
        resources.ApplyResources(Me.LinkSettings, "LinkSettings")
        Me.LinkSettings.Image = Global.QRCode_Generator.My.Resources.Resources.baseline_settings_black_18dp
        Me.LinkSettings.Name = "LinkSettings"
        Me.LinkSettings.UseSelectable = True
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'LinkHelp
        '
        resources.ApplyResources(Me.LinkHelp, "LinkHelp")
        Me.LinkHelp.Image = Global.QRCode_Generator.My.Resources.Resources.baseline_help_black_18dp
        Me.LinkHelp.Name = "LinkHelp"
        Me.LinkHelp.UseSelectable = True
        '
        'SettingsContextMenu
        '
        resources.ApplyResources(Me.SettingsContextMenu, "SettingsContextMenu")
        Me.SettingsContextMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SettingsContextMenu.Depth = 0
        Me.SettingsContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LanguageToolStripMenuItem})
        Me.SettingsContextMenu.MouseState = MaterialSkin.MouseState.HOVER
        Me.SettingsContextMenu.Name = "SettingsContextMenu"
        '
        'LanguageToolStripMenuItem
        '
        resources.ApplyResources(Me.LanguageToolStripMenuItem, "LanguageToolStripMenuItem")
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndonesianToolStripMenuItem, Me.EnglishToolStripMenuItem})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        '
        'IndonesianToolStripMenuItem
        '
        resources.ApplyResources(Me.IndonesianToolStripMenuItem, "IndonesianToolStripMenuItem")
        Me.IndonesianToolStripMenuItem.Name = "IndonesianToolStripMenuItem"
        '
        'EnglishToolStripMenuItem
        '
        resources.ApplyResources(Me.EnglishToolStripMenuItem, "EnglishToolStripMenuItem")
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        '
        'HelpContextMenu
        '
        resources.ApplyResources(Me.HelpContextMenu, "HelpContextMenu")
        Me.HelpContextMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HelpContextMenu.Depth = 0
        Me.HelpContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactSupportToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpContextMenu.MouseState = MaterialSkin.MouseState.HOVER
        Me.HelpContextMenu.Name = "HelpContextMenu"
        '
        'ContactSupportToolStripMenuItem
        '
        resources.ApplyResources(Me.ContactSupportToolStripMenuItem, "ContactSupportToolStripMenuItem")
        Me.ContactSupportToolStripMenuItem.Name = "ContactSupportToolStripMenuItem"
        '
        'AboutToolStripMenuItem
        '
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.MaterialPanel3)
        Me.Controls.Add(Me.MaterialPanel2)
        Me.Name = "Form1"
        Me.MaterialPanel2.ResumeLayout(False)
        Me.MaterialPanel2.PerformLayout()
        CType(Me.PictQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictQrCodeColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictQrCodeBackColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialPanel3.ResumeLayout(False)
        Me.MaterialPanel3.PerformLayout()
        Me.SettingsContextMenu.ResumeLayout(False)
        Me.HelpContextMenu.ResumeLayout(False)
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
    Friend WithEvents MaterialPanel2 As MaterialFramework.MaterialPanel
    Friend WithEvents MaterialPanel3 As MaterialFramework.MaterialPanel
    Friend WithEvents Label4 As Label
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
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkSettings As MetroFramework.Controls.MetroLink
    Friend WithEvents SettingsContextMenu As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents LanguageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndonesianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpContextMenu As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents ContactSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckUseImage As MetroFramework.Controls.MetroCheckBox
End Class
