Public Class MyFrm1
    Private Sub MyBtn1_Click(sender As Object, e As EventArgs) Handles MyBtn1.Click

        ' 1.si MyBtn1 butonumuzun Name idir yani referans tutucusudr ve form uzerinde buttona tikladigmz zaman sag alttaki properties ler, yani butona ait propertiesler,
        ' MyBtn1 name inin,(MyBtn1 bir class dir)  yani class inin propertiesleri yani field lari ya da hem get hem de set edilebilen variable laridir diyebilriiz...ISTE BU BILGI 
        ' BIZIM ISMIZE COK CIDDI YARAYACAK BIR BILGIDIR...
        ' Color ise System.Drawing den gelen bir Color Class idir
        '   If MyBtn1.BackColor = Color.Red Then  EndIf
        ' Form un Close methodunu calistirirken form dan olusturulmus bir instance uzerinden olusturulmasini saglayan, Me-yani C# da this e karsilk gelen ve Formu temsil eden keyworddur
        Me.Close()
        Me.Hide()
        Me.Show()
        ' Formu orneign gizledik, sonrasinda gostermek icin bir tane icon kullaniriz, iconu taskabar a koyariz sonra icon a taskbar da saga tikayip show diyerek tekrardan formu 
        ' gozukur hale getirecegiz
    End Sub
    ' Bu arada sunu da anlayalim...ilk olarak biz Button ve Label olusturdugumuz zaman, bu tools larin, events leri direk olusturulmyor ancak ne zamn ki uzerinlerine cift tiklarsak
    ' o zaman arka plan da ki Public Class Form1 icerisinde eventler birer Sub procedurler olarak olusturuluyor....
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles MyLbl1.Click
        ' Label imiizin Name i yani referans tutucusu bir Label class inin instancesidir ve bu Label Class i icerisinde de properties
        ' ler hazir olarak tanimlanmis ve default degerler atanmistir!!!

    End Sub

    ' Dikkat edelim..Form1 uzerine cift tikladigmiz da da Form1 in Load eventi devreye giriyor, ve de form1 yuklenir yuklenmez calisacaktir...
    ' Daha farkli form olaylari da var onlara da bakacagiz
    ' FORM EVENTS - BU EVENTLERI FORM UN UZERINE TIKLANDIGI ZAMAN PROPERTIES LER DE MENU DE EVENTS ICONUNA TIKLAYARAK GOREBILIRIZ...VE DIKKAT EDELIM.PROPERTIES LISTESINDEKI
    ' EVENTSLERIN UZERINE CIFT TIKLARSAK DA YINE BU FORM1 CLASS ININ ICERISINE PRIVATE BIR SUB PROCEDUR OLARAK TIKLANAN OLAY A AIT EVENT SUB PROCEDUR U OLUSTURULMUS OLACAKTIR..
    ' BU EVENTSLERI ISTER BU SEKILDE OLUSTURURUZ ISTERSEKDE KENDIMZI MANUEL OLARAK DA OLUSTURABILIRIZ!!!!
    ' LOAD:Form yuklendikten hemen sonra tetiklenecek olan eventtir
    ' FormClosing: Form kapanmadan hemen once calisacak eventtir
    ' FormClosed: Form kapandiktan sonra calisacak olan eventtir
    ' Application.Exit:
    ' Cagrildigi anda tetiklenmmeyen bir metottur. Bu yuzden bu metottan once bir close cagrilmalidir
    ' Visual Basic .NET'te, Application.Exit olayı forma özgü bir olay değildir. Bunun yerine, uygulamadan çıkmak üzereyken ve
    ' tüm formlar kapatıldığında ortaya çıkan küresel bir olaydır.
    ' Bu olay, uygulama sonlandırılmadan önce gerekli temizleme veya sonlandırma görevlerini gerçekleştirmenize olanak tanır.
    ' Application.Exit olayı aşağıdaki durumlarda tetiklenir:
    ' Kullanıcı, son açık formu kapatarak uygulamanın kapanmasını başlattığında.
    ' Uygulamayı programlı olarak sonlandırmak için Application.Exit() yöntemi kodda açıkça çağrıldığında.
    ' ApplicationExitHandler yönteminde, kaynakları temizlemek, verileri kaydetmek veya uygulama sonlandırılmadan
    ' önce yapılması gereken diğer eylemleri gerçekleştirmek için gerekli tüm kodları dahil edebilirsiniz.
    ' Uygulamanın kapanmasını engelleyen (ör. FormClosing olayı aracılığıyla) olay işleyicileri olan açık formlarınız varsa,
    ' tüm formlar kapatılana veya uygulama zorla sonlandırılana kadar Application.Exit olayının başlatılmayacağını unutmamak önemlidir. .
    ' Application.Exit olayını işleyerek, uygulamanızı incelikle kapatma ve sonlandırılmadan önce gerekli temizleme işlemlerini gerçekleştirme fırsatınız olur.
    ' You can handle the Application.Exit event by adding a handler for it in your application's entry point or startup code. Typically, this is done in the Sub Main() method,
    ' which serves as the entry point for a Visual Basic .NET console application or a Windows Forms application without a specific startup form.
    ' Uygulama ilk acilirken, baslatildiginda icerisine eklenerek, uygulama kapanmadan once uygulanmak istenen operasyonlari uygulayacagimz methodu saglama almis ve onu kontrol
    ' altina almis oluruz aslinda bir nevi...
    ' Module Program  Sub Main() procedur icerisinde yani, uygulama calisirken ilk calisacak olan methoddur Main  AddHandler Application.Exit, AddressOf ApplicationExitHandler
    ' ' Your application startup code here
    ' Run the application message loop   Application.Run()

    ' Activated Event: 
    'Form u sectigimzde, formu her aktif etttgimzde calisacak bir eventtir
    ' Form kullanici tarafindan Activate() edildiginde calisacak olaylar tetiklenir
    ' Deactivate Event:
    ' Formun etkinligi kaldirilinca tetiklenen olaylar burdadir
    ' HelpButtonClicked: Formun ust kisminda yardim dugmesi tiklandiginda, calisacak olaylari buraya belirtebiliriz
    ' HelpRequested: Form uzerinde iken F1 tusuna bastigimzda tetiklenecek olaylari burda belirtebiliriz

    ' FORM MOUSE EVENTS
    ' Click: Form uzerine tiklandiginda tetiklenir
    ' Formun bos biryerine tiklaninca tetiklenir, ama form u zerinde var olan ornegin button tool una tiklarsak tetiklenmeyecektir,  yani formun kendisine tiklaninca tetiklenir
    ' MouseDoubleClick: Form uzerine mouse ile cift tiklandiginda tetiklenir
    ' MouseClick: Form uzerine mouse ile tiklandiginda tetiklenir
    ' MouseMove: Form uzerinde mouse hareket ettirilmesi ile calisir
    ' MouseEnter: Form alanina girmekle tetiklenen olaylari burda yazabiliriz
    ' MouseLeave: Form alanindan ayrildiginda tetiklenen olaylari buraya yazabiliriz
    ' MouseDown: Mouse tusuna basildiginda calisacak olaylari burda yer alabilir. MouseDown olayi click olayindan once calisan bir eventtir
    ' MouseUp: Mouse tusuna bastiktan sonra cekildiginde calisacak olan bir olaydir

    ' FORM KLAVYE OLAYLARI
    'KeyPreview: KeyPress,KeyUp, KeyDown gibi ozellikleri vardir
    'KeyDown: Form uzerindeki herhangi bir tusa basildigi anda tetiklenir


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MyLbl1.Text = "Welcome"
    End Sub

    Private Sub MyFrm1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub MyFrm1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        MyLbl1.Text = "Welcome"
        'Form u sectigimzde, formu her aktif etttgimzde calisacak bir eventtir
        ' Yani form ilk acilirken olsun ondan sonra da ornegin formu taskabar a indirdik ve tekrar formu ekranda gorunur yaptik iste ekranda formun her gorunur olma durumunda tetiklenir
        ' Ama formun uzerine gelip formun uzerindeki herhangi bir tool veya formun direk kendisi uzerinde islem yapildiginda form aktiv olmus oluyor...
    End Sub

    Private Sub MyFrm1_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        ' Form Deactivate oldugunda calisacak olan bir eventtir, yani uygulamamizi calistirinca form u ana sayfadan taskbar a indirdigimzde form u yani kapatma degil de
        ' Daha dogru su su sekilde oluyor mus tamam simdi tam olarak anladim..Form un kodlarina geldigmizde yani formun gorsel olan kismi yerine kod kisminda iken Deactive eventi tetikleniyor 
        ' Ama formun uzerine gelip formun uzerindeki herhangi bir tool veya formun direk kendisi uzerinde islem yapildiginda form aktiv olmus oluyor...
        MyLbl1.Text = "Bye Bye"
    End Sub

    Private Sub MyFrm1_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        MyLbl1.Text = "F1 Clicked"
    End Sub

    Private Sub MyFrm1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        MyLbl1.Text = "Form CLICK TRIGGERED"
        ' Formun bos biryerine tiklaninca tetiklenir, ama form u zerinde var olan ornegin button tool una tiklarsak tetiklenmeyecektir,  yani formun kendisine tiklaninca tetiklenir
        ' Hem Click hem MouseClick tetiklenirse MouseClick olayi Click olayini ezecektir, override ederek MouseClick olayi gecerli olacaktir ama sadece Click olayi tetiklenirse
        ' o zaman normal form uzerinde bos biryere tiklaninca tetiklenecektir
    End Sub

    Private Sub MyFrm1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        MyLbl1.Text = "Form MOUSECLICK TRIGGERED"
        ' Hem Click hem MouseClick tetiklenirse MouseClick olayi Click olayini ezecektir, override ederek MouseClick olayi gecerli olacaktir
        ' Formun bos biryerine tiklaninca tetiklenir, ama form u zerinde var olan ornegin button tool una tiklarsak tetiklenmeyecektir,  yani formun kendisine tiklaninca tetiklenir
    End Sub

    Private Sub MyFrm1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        MyLbl1.Text = "Mouse Move event triggered"
        ' MOUSE ILE FORM UZERINE GELINCE TETIKLENIR
    End Sub

    Private Sub MyFrm1_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        MyLbl1.Text = "Mouse LEAVE event triggered"
        ' MOUSE FORM U ZERINDEN AYRILINCA TETIKLENECEKTIR
    End Sub

    Private Sub MyFrm1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ' Burasi tam mouse a tiklarken gerceklesir ve Click olayindan hemen once tetiklenecektir ve spesifik durumlarda bazen, click olayinin hemen oncesinde
        ' birseyler yapmak isteyebiliriz, iste boyle durumlarda harika efektif islev gorecektir
    End Sub

    Private Sub MyFrm1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        ' MouseUp da click olayindan hemen sonra calisacak bir eventtir
        ' Yani MouseDown ile MouseUp bir click olayinin oncesi ve sonrasin i kontrol edilebilmesi icin kullanilabilir...
    End Sub

    Private Sub MyLbl1_TextChanged(sender As Object, e As EventArgs) Handles MyLbl1.TextChanged
        ' Label  uzerinde text degistiginde tetiklenecektir
    End Sub

    ' EVENTS...HER BIR TOOL A AIT EVENTLERI NERDEN GOREBILIRIZ?

    ' BIZIM FORM ELEMENTIMZ VE FORM ELEMENTIMZIN ICERISINE OLUSTURDUGUMUZ TOOLS LAR, BUTTON, LABEL, TEXTBOX GIBI TOOLS LAR IN HANGI EVENTSLERININ VAR OLDUGUNU GORMEK ICIN
    ' PROPERTIES PENCERESINDE EN USTTE MENU KISMINDA EN SAGDA EVENTS ICONU VARDIR ONA TIKLARSAK BIZ O AN ICIN TIKLANAN TOOL HANGISI ISE FORM, BUTTON,LABEL, HANGISI ISE ONUN
    ' HANGI EVENTLERININ VAR OLDUGUNU GOREBILIRIZ...BU COK ONEMLIDIR..BIZ HANGI DURUMDA HANGI EVENT I DEVREYE SOKACAGIZ BUNU IYI BILMEMIZ GEREKIR!!!!

    ' KEYPREVIEW-TRUE
    ' Form un properties den KeyPreview True yaparsak Form  uzerinde klavye tuslarina basildiginda algilamaya baslayacaktir

    ' FORM METHODLARI!!!
    ' Form metotlari olarak 3 tane temel metod bulunmaktadir
    ' Close-Formu kapatmak icin kullanilir
    ' Hide - formu gizlemek icin kullanilir

End Class
