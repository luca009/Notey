Public Class Form2
    Private Sub bGo_Click(sender As Object, e As EventArgs) Handles bGo.Click
        wbMain.Navigate(tbAddress.Text)
    End Sub
End Class