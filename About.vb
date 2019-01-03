Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblVersion.Text = "v" & My.Application.Info.Version.ToString
    End Sub

    Private Sub LinkContact_Click(sender As Object, e As EventArgs) Handles LinkContact.Click
        Process.Start("https://www.facebook.com/MArfan890")
    End Sub
End Class