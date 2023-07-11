Public Class Form1

    Dim message As String
    Dim title As String

    Private Sub MyBtn1_Click(sender As Object, e As EventArgs) Handles MyBtn1.Click
        title = "Save"
        message = "You saved"
        Test1()
    End Sub

    Private Function Test1()
        ' Bu sekilde 2 farkli mesaj vereceksek MessageBox.Show parametresine yazarak bunu yapabiliriz..
        ' Ornegin biz eger, tool eventlerinde yapacagimz ortak isler var ise onlari tek tek manuel yapmak yerine ortak bir fonksiyon olusturarak yapabiliriz
        '   MessageBox.Show(message, title)
        ' MessageBox a biz hem icon ekleyebiliyoruz..hem de ornegin farkli turlerde MessageBox yapabiliriz..
        MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        title = "Exit"
        message = "You exited"
        Test1()
    End Sub
End Class
