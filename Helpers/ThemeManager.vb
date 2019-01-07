Public Class ThemeManager
    Public Shared Sub SetTheme(AppTheme As Theme)
        If AppTheme = Theme.Dark Then
            Main.PanelHeader.DarkTheme = True
            Main.MainPanel.DarkTheme = True
            Main.BackColor = ColorTranslator.FromHtml("#1E1E1E")
            Main.ForeColor = Color.White
            Main.TxtData.BackColor = Main.BackColor
            Main.LinkSettings.Image = My.Resources.baseline_settings_white_18dp
            Main.LinkHelp.Image = My.Resources.baseline_help_white_24dp
            Main.LinkSave.Image = My.Resources.baseline_save_white_18dp
            Main.TxtImagePath.BackColor = ColorTranslator.FromHtml("#2D2D2D")
            Main.TxtImagePath.DarkTheme = True
            Main.TxtQrBackColor.BackColor = ColorTranslator.FromHtml("#2D2D2D")
            Main.TxtQrBackColor.DarkTheme = True
            Main.TxtQrCodeColor.BackColor = ColorTranslator.FromHtml("#2D2D2D")
            Main.TxtQrCodeColor.DarkTheme = True
            Main.txtWidth.BackColor = ColorTranslator.FromHtml("#2D2D2D")
            Main.txtWidth.DarkTheme = True
            Main.txtHeight.BackColor = ColorTranslator.FromHtml("#2D2D2D")
            Main.txtHeight.DarkTheme = True
            Main.TxtData.ForeColor = Color.White

        Else
            Main.PanelHeader.DarkTheme = False
            Main.MainPanel.DarkTheme = False
            Main.BackColor = ColorTranslator.FromHtml("#FFFFFF")
            Main.ForeColor = Color.Black
            Main.TxtData.BackColor = Main.BackColor
            Main.LinkSettings.Image = My.Resources.baseline_settings_black_18dp
            Main.LinkHelp.Image = My.Resources.baseline_help_black_18dp
            Main.LinkSave.Image = My.Resources.baseline_save_black_18dp
            Main.TxtImagePath.BackColor = Color.FromArgb(255, 255, 255)
            Main.TxtImagePath.DarkTheme = False
            Main.TxtQrBackColor.BackColor = Color.FromArgb(255, 255, 255)
            Main.TxtQrBackColor.DarkTheme = False
            Main.TxtQrCodeColor.BackColor = Color.FromArgb(255, 255, 255)
            Main.TxtQrCodeColor.DarkTheme = False
            Main.txtWidth.BackColor = Color.FromArgb(255, 255, 255)
            Main.txtWidth.DarkTheme = False
            Main.txtHeight.BackColor = Color.FromArgb(255, 255, 255)
            Main.txtHeight.DarkTheme = False
            Main.TxtData.ForeColor = Color.Black
        End If
    End Sub
End Class
