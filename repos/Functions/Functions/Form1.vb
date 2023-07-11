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
        ' MessageBox a biz hem icon ekleyebiliyoruz..hem de ornegin farkli turlerde MessageBox yapabiliriz..yani question messagebox u yapariz ve yes-no sorusu ile ..gibi
        MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        title = "Exit"
        message = "You exited"
        Test1()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  WebBrowser1.DocumentText = My.Resources.OpenStreetMap
        ' Documan okiyacagizim icin DocumentText property sini kullaniyourz
        ' Gordugmuz gibi disardasn bir html sayfasini aldik My Projecte cift tiklayip orda Resources e ekledik ve onu WebBrowser tool umuza eklyerek calistirmis olduk
        ' Ayrica biz WebBrowsser tool unun properties lerinden url kismina herhangi bir web sayfasina ait url i kullanarak, istedigmz web sayfasini da form  umumuz uzerinde gosterebiliriz
        ' Ve direk formumuz uzerinde istedgimz web sayfasini canli olarak kullanabiliiriz..bu ozellik cok fazla ku llanacagimz bir ozellikdir...

    End Sub
End Class

' REFERANS EKLEME
' Biz baska projelerin referanslarini alarak onun ozelliklerini de kendi projemizde kullanabiliyoruz
' Sag da solution Explorer da My Project e cift tiklayinca acilan pencereden Resources uzerine biz ornegin elimzde var olan bir google haritalar .html sayfasini kendi formumuzda
' kullanabilmek icin googleharitalar.html dosyasini resources e surukleriz..sonra o Resources klsoru altinda olusacak sekilde proje dosyalarimiza gelecektir
' Tabi biz webbrowser tool unu ekleriz formumuza 
' Biz dokumanlar arasindan bir dosya secerken de tum dokumanlarimizi temsil eden My keywordu uzerinden orngin istedgimz bir dosyamizi ekleyebiliyoruz...veya atma yapabiliyuoruz
' WebBrowser1.DocumentText = My.Resources.GoogleMap bu sekilde ekleyebiliriz....

' DLL DOSYALARININ REFERANS OLARAK EKLENMESI...CCOOK ONEMLI BIR NOKTA!!!!!!!
' DLL DOSYALARI - DYNAMIC LINK LIBRARY
' In a Visual Basic .NET project, DLL (Dynamic Link Library) files are used to provide reusable code and functionality
' DLL files contain compiled code and resources that can be shared among multiple applications or projects. 
' Here are some purposes of inserting DLL files in a Visual Basic .NET project:
'Code Reusability: DLL files allow you to separate common code or functionality into separate modules that can be shared among different projects.
'This promotes code reusability and reduces duplication, as you can include the DLL file in multiple projects without rewriting the same code.
' Encapsulation: DLL files encapsulate code and resources, making it easier to manage and maintain your project. By organizing related code in a DLL,
' you can keep your main project files clean and modular.
' Separation of Concerns: DLL files allow you to separate different concerns or components of your application. For example,
' you can have a DLL file for database access, another for networking, and so on. This promotes modular design and makes
' it easier to update or replace specific components without affecting the entire project.
' Third-Party Libraries: DLL files are commonly used to include third-party libraries or frameworks in your project.
' These libraries provide additional functionality or features that are not available in the standard .NET framework.
' By referencing the DLL file, you can leverage the capabilities of these libraries in your application.
' To use a DLL file in a Visual Basic .NET project, you typically need to add a reference to the DLL file in your project.
' This allows your project to access the code and resources contained in the DLL. Once the reference is added,
' you can use the classes, functions, and other elements provided by the DLL in your code.
' Nuget paket  yoneticisi tarafindan direk olarak ekledigmz library ler aslindas birer dll dosyasi olarak projemize eklenmis oluyor biz bu islemi manuel olarak da gidip
' nuget package nin web sitesinden aradigmz source yi bulup download ettigimzde uzantisi nuget diye geliyor sonra biz bu uzantiyi .zip yapip sonra o zipi disari cikardigmz zaman
' lib klasoru altinda .dll dosyasini bulabliiriz ve add reference diyerek proemize bu .dll dosyasini da manuel olarak ekleyebiliyoruz

' TOOLBOX ICERISINE DISARDAN .DLL DOSYASI REFERANSI EKLEYEREK YENI BIR TOOL EKLEMEK
' Toolbox ta en altta general da yeni bir sekme olustur deriz ve sonra da o sekmeye choose diyerek disardan eklemek istedigmz dll i ekleyerek yeni tool lar ekleyebiliyoruz...
' Dikkat edersek biz bu islemi de  yine referans ekleyerek yapiiyoruz...
' .dll dosyalarinin bu sekilde...referans ekleme islemini yapabiliyoruz..

' AMA GENEL OLARAK REFRRANS EKLEMEK DIREK PROJE UZERINDE SAGA TIKLANARAK REFERANS EKLEME ISLEMI ILE YAPABILIRIZ....

' FORM DA BACKGROUND COLOR I AYARLARKEN BACKGROUND COLOR - CUSTOM -EN ALTTAKI BEYAZ KUTULARDAN BIRINE SAGA TIKLARSAK COLOR-PICKER GELECEK
' FORM UZERINE..ORDAN DA BU SEKILDE BACKGORUND -COLOR AYARALAYABLIYOURZ


