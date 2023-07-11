Public Class MyFrm1

    ' Formumuzun FormBorderStyle dan formun buyuttulup kuculutulebilme ozelligi vs bunlari ayarliyorduk
    ' FormBorderStyle - None, FixedSingle, Fixed3D, FixedDialog, Sizable
    ' default olarak bu ozellik Sizable olarak gelir ondan dolayi da form u biz surukleyebiliyoruz
    ' StartPosition i nasil ayarlarsak ona gore proje acildiginda ortalanarak veya iste hangi pozisyonda baslasin istersek o sekilde baslayacaktir
    ' Biz form un sag ustune bir button olusturup uzerine x yazip sonra kullanici ona tiklayinca form  kapatilsin seklinde ayarlamalar yapabiliriz
    ' ControlBox u False yaparsak sag ustteki x-kare ve - isaretleri formdan kaldirilir, True yaparsak gelir
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
