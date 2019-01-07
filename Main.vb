Imports QRCoder
Public Class Main
    Public myColorPicker As New ColorDialog
    Dim QRGenerator As New DataGenerator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        If TxtData.Text = "" Then
            MsgBox("You have not entered text", MsgBoxStyle.Critical, "An error occured")
        Else
            CreateQR()
        End If

    End Sub

    Private Sub TentangToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        MessageBox.Show(My.Application.Info.ProductName & " " & My.Application.Info.Version.ToString & Environment.NewLine & "Author : " & My.Application.Info.CompanyName & Environment.NewLine & "Software ini dibuat oleh Muhammad Arfan Maulana" & Environment.NewLine & "Facebook : https://www.facebook.com/MArfan890", "About")
    End Sub

    Private Sub LinkSave_Click(sender As Object, e As EventArgs) Handles LinkSave.Click
        If PictQRCode.Image Is Nothing Then
            MsgBox("Cannot save image", MsgBoxStyle.Critical, "An error occured")
        Else
            Dim SaveDialog As New SaveFileDialog
            SaveDialog.DefaultExt = "jpg"
            SaveDialog.Filter = "JPG images (*.jpg)|*.jpg|PNG images (*.png)|*.png|BMP images (*.bmp)|*.bmp|Tiff images (*.tiff)|*.tiff"
            If SaveDialog.ShowDialog = DialogResult.OK Then
                Select Case SaveDialog.FilterIndex
                    Case 1
                        PictQRCode.Image.Save(SaveDialog.FileName, Imaging.ImageFormat.Jpeg)
                    Case 2
                        PictQRCode.Image.Save(SaveDialog.FileName, Imaging.ImageFormat.Png)
                    Case 3
                        PictQRCode.Image.Save(SaveDialog.FileName, Imaging.ImageFormat.Bmp)
                    Case 4
                        PictQRCode.Image.Save(SaveDialog.FileName, Imaging.ImageFormat.Tiff)
                End Select
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler TxtData.TextChanged, AddressOf TxtData_TextChanged
        AddHandler TxtQrCodeColor.TextChanged, AddressOf TxtQrCodeColorChanged
        AddHandler TxtQrBackColor.TextChanged, AddressOf TxtQrCodeBackColorChanged
        CreateQR()
        Select Case My.Settings.FirstLaunch
            Case True
                TxtData.Text = "Welcome to QRCode Generator enter your text here to convert the text to QRCode.."

        End Select
        My.Settings.FirstLaunch = False
        My.Settings.Save()
        If My.Settings.Dark Then
            ThemeManager.SetTheme(Theme.Dark)
        Else
            ThemeManager.SetTheme(Theme.Light)
        End If
    End Sub
    Private Sub TxtData_TextChanged()
        CreateQR()
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        CreateQR()
    End Sub
    Sub CreateQR()

        If TxtData.Text = Nothing Then
            PictQRCode.Image = Nothing
        Else
            Dim ModelQRCode As New mQRCode
            ModelQRCode.Data = TxtData.Text
            ModelQRCode.PrimaryColor = PictQrCodeColor.BackColor
            ModelQRCode.BackColor = PictQrCodeBackColor.BackColor
            ModelQRCode.qHeight = txtHeight.Text
            ModelQRCode.qWidth = txtWidth.Text
            If Not TxtImagePath.Text = Nothing And CheckUseImage.Checked = True Then
                PictQRCode.Image = QRGenerator.GenerateQR(ModelQRCode, TxtImagePath.Text)
            Else
                PictQRCode.Image = QRGenerator.GenerateQR(ModelQRCode)
            End If

        End If

    End Sub


    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim op As New OpenFileDialog
        op.Filter = "Images Files (*.jpg, *.png, *.jpeg, *.bmp)|*.png;*.jpg;*.jpeg;*.bmp"
        If op.ShowDialog() = DialogResult.OK Then


            TxtImagePath.Text = op.FileName
        End If
    End Sub

    Private Sub BtnQrCodeColor_Click(sender As Object, e As EventArgs) Handles BtnQrCodeColor.Click
        If ClrDialog.ShowDialog() = DialogResult.OK Then
            PictQrCodeColor.BackColor = ClrDialog.Color
            TxtQrCodeColor.Text = ColorTranslator.ToHtml(ClrDialog.Color)
        End If
    End Sub

    Private Sub BtnQrCodeBackColor_Click(sender As Object, e As EventArgs) Handles BtnQrCodeBackColor.Click
        If ClrDialog.ShowDialog() = DialogResult.OK Then
            PictQrCodeBackColor.BackColor = ClrDialog.Color
            TxtQrBackColor.Text = ColorTranslator.ToHtml(ClrDialog.Color)
        End If
    End Sub

    Sub TxtQrCodeColorChanged()
        Try
            PictQrCodeColor.BackColor = ColorTranslator.FromHtml(TxtQrCodeColor.Text)
        Catch
        End Try
        CreateQR()
    End Sub
    Sub TxtQrCodeBackColorChanged()
        Try
            PictQrCodeBackColor.BackColor = ColorTranslator.FromHtml(TxtQrBackColor.Text)
        Catch
        End Try
        CreateQR()
    End Sub

    Private Sub LinkSettings_Click(sender As Object, e As EventArgs) Handles LinkSettings.Click
        SettingsContextMenu.Show(LinkSettings, 0, LinkSettings.Height)
    End Sub

    Private Sub LinkHelp_Click(sender As Object, e As EventArgs) Handles LinkHelp.Click
        HelpContextMenu.Show(LinkHelp, 0, LinkHelp.Height)
    End Sub

    Private Sub ContactSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactSupportToolStripMenuItem.Click
        Process.Start("https://www.facebook.com/MArfan890")
    End Sub

    Private Sub IndonesianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndonesianToolStripMenuItem.Click
        My.Settings.Language = "Indonesian"
        My.Settings.Save()
        MsgBox("You need to restart app to change the language", MsgBoxStyle.Information, "Settings will be applied after restarting app")
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        My.Settings.Language = "English"
        My.Settings.Save()
        MsgBox("You need to restart app to change the language", MsgBoxStyle.Information, "Settings will be applied after restarting app")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not PictQRCode.Image Is Nothing Then
            Select Case MsgBox("Are you sure want to exit? Your QRCode will not be saved", MsgBoxStyle.YesNo)
                Case MsgBoxResult.No
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub txtWidth_Leave(sender As Object, e As EventArgs) Handles txtWidth.Leave
        CreateQR()
    End Sub

    Private Sub txtHeight_Leave(sender As Object, e As EventArgs) Handles txtHeight.Leave
        CreateQR()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub TxtImagePath_TextChanged(sender As Object, e As EventArgs) Handles TxtImagePath.TextChanged
        Try
            CreateQR()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckUseImage_CheckedChanged(sender As Object, e As EventArgs) Handles CheckUseImage.CheckedChanged
        If CheckUseImage.Checked = True Then
            BtnBrowse.Enabled = True
        Else
            BtnBrowse.Enabled = False
            TxtImagePath.Text = ""
        End If
    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        ThemeManager.SetTheme(Theme.Dark)
        My.Settings.Dark = True
        My.Settings.Save()
    End Sub

    Private Sub LightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightToolStripMenuItem.Click
        ThemeManager.SetTheme(Theme.Light)
        My.Settings.Dark = False
        My.Settings.Save()
    End Sub
End Class
