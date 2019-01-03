Imports QRCoder
Imports Microsoft.VisualBasic.Conversion
Public Class DataGenerator
    Public Function GenerateQR(QrModel As mQRCode) As Bitmap

        Dim qrCodegenerator As New QRCodeGenerator
        Dim qrcodedata As QRCodeData = qrCodegenerator.CreateQrCode(QrModel.Data, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As QRCode = New QRCode(qrcodedata)
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(20, ColorTranslator.ToHtml(QrModel.PrimaryColor), ColorTranslator.ToHtml(QrModel.BackColor), True)
        Dim qrResult As New Bitmap(QrModel.qWidth, QrModel.qHeight)
        Dim g As Graphics = Graphics.FromImage(qrResult)
        g.DrawImage(qrCodeImage, 0, 0, qrResult.Width, qrResult.Height)

        Return qrResult

    End Function
    Public Function GenerateQR(QrModel As mQRCode, img As String)
        Dim qrCodegenerator As New QRCodeGenerator
        Dim qrcodedata As QRCodeData = qrCodegenerator.CreateQrCode(QrModel.Data, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As QRCode = New QRCode(qrcodedata)
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(20, QrModel.PrimaryColor, QrModel.BackColor, Bitmap.FromFile(img))
        Dim qrResult As New Bitmap(QrModel.qWidth, QrModel.qHeight)
        Dim g As Graphics = Graphics.FromImage(qrResult)
        g.DrawImage(qrCodeImage, 0, 0, qrResult.Width, qrResult.Height)

        Return qrResult
    End Function
End Class
