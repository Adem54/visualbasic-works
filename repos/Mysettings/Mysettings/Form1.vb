Public Class Form1

    ' Programlarimzi yazarken veri tabanina ihtiyac duyaagiz, kullaniciin  y aptigi islemleri vs tutacagimz 
    ' Ayrica exe programinin icerisine gomulu olarak da verileri tutabiliyoruz, iste bunun adi My.settings dir
    ' My Project e cift tiklayip sonra Form a gidip tekrar gelen pencereye gittimgzde..karsiimiza sol sidebar gelecektir orda Settings kismi var iste burasi bizim verileri
    ' .exe nin icinde gomulu olarak tutmamizi saglayan alandir, yani My.settigns kismidir. Buraya istedigmiz verileri kaydedip, tutup , kodla da burdaki verileri okuyup, update edebiliriz
    ' Olusturudgumuz form a girilen data lari kayit altina alacagiz...Bunu hem kod ile manuel olarak hem de otomatik olarak yapabiliyoruz, her iki yontemi de inceleyelim
    ' KOD ILE VERILERIMIZI KAYDETME ISLEMI
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' HARIKA BESTPRACTISE....BU ISLEM ILE FORM UNMUZ LOAD OLDUGUNDA VERILER LE BIRLIKTE GLEMESINI SAGLAYACAGIZ..BU MANTIGI COK FAZLA KULLANCAGIZ..
        ' Su an ayarlarda kaydettik artik verilerimizi gostermek istiyorsak o zaman verilerimizi My.Settings den cekebiliriz. Bu verileri formumuz acildiginda ceksin diyebiliirz
        ' Verilerimzi biz Formumuz acildiginda direk My.Settings den verileriimizi cekerek getirisin istiyoruz o zaman Formun Load Eventi icerisinde bu islemleri yapariz
        InputName.Text = My.Settings.Name
        InputSurname.Text = My.Settings.Surname
        InputBorn.Text = My.Settings.Born
        InputCity.Text = My.Settings.City

        ' EXCEPTION HANDLING.
        ' Ugyulama ilk acilidiginda daha onceden herhangi bir resim secilmedigi ve My.SEttings.Avatar data sindan birsey olmadigi icin boyle bos bir adres in AvatarPictureBox.ImageLocation atanmasi
        ' hataya sebep olacaktir bu hata ile bas edebilmekk icin de try-catch kullancagiz yoksa...uygulamamiz kirilarak yarida kesilecektir bu da bizim icin cok kotu bir userexperience olacaktir

        Try
            AvatarPictureBox.ImageLocation = My.Settings.Avatar ' Ilk form load edildiginde resmin de kaynagindan, lokal kaynagindan cekilerek getirilmesini saglayan kodda budur
        Catch ex As Exception
            ' Buraya hicbirsey yazmadigmiz zaman, eger bir hata olusursa hicbirsey yapma demis oluyoruz ama burda hicbirsey yapmazsak bile biz, programin kirilmasini, patlamasini engellems oluyoruz
            ' try-catch kullanarak, bu coook onemli ve olmazsa olmaz bir kullanimdir...bu kullanimlar cok iyi bilmeliyyz
        End Try

        ' Birde My.Settings de Tema isminde bir alanimiz vardi Tema rengini belirlemek icin ve Tema kolon title inin veri turunu biz System.Draw.Color seciyoruz cunku burda
        ' color kaydedecektik...ve bu alan in karsina gelip tiklarsak kendisi default olarak control rengini sececektir..Bunu neden yapiyoruz...uygulama ilk acildiginda 
        ' default olarak My.Settings de Tema kolonunda hangi renk verirsek o rengi acilista ordan alsin form umumz bir default rengi olsun acilista verebildigimz
        ' FORMUN UZERINDE ISLEM YAPACAIGMZ ZAMAN CLASS FORM CLASS I OLDUGU ICN ME KEYWORDU ILE YAPACAGIZ FORM UZERINDEKI MANIPULASYONLARI YAPARKEN
        Me.BackColor = My.Settings.Tema
        ' Burasi onemli..color imizi direk color olarak saklayabiioruz...cunku veri tip olarak System.Draw.Color type ini secebildik...

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles MySurname.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles MyBorn.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles MyName.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles MyCity.Click

    End Sub



    Private Sub MySaveBtn_Click(sender As Object, e As EventArgs) Handles MySaveBtn.Click
        ' Buraya tiklaninca, verilerimiz kaydedilecek
        ' Validation da yapmak istiyoruz eger ki , textbox lar bos birakilmis ise kaydedemesin diyecegiz
        ' Name ve Surname bos ise kayit islemine izin vermeyelim ama digerleri bos birakilabilir diyelim
        ' InputName,InputSurname, InputBorn, InputCity bunlar Textbox larimizin Nama leridir
        If InputName.Text = "" Then
            MyName.ForeColor = Color.Red ' Bos birakildiginda Label inin rengi ni kirmizi  yapalim
            MsgBox("Please, fill the Name TextBox")

        ElseIf InputSurname.Text = "" Then
            MySurname.ForeColor = Color.Red
            MsgBox("Please, fill the Surname TextBox")
        Else
            ' Burda artik kaydedecegiz.. eger Name-Surname Text lari  dolu ise
            ' My.Settings bizim My Project e tiklayinca sol sidebar dan Settigns i secince karsimza gelen tablo  yu temsil ediyor...My.Settings yazinca . dersek memeber access ile
            'bizim o tabloya colon olarak girdigmz Name,Surname,Born,City gibi degerlerin geldigini ve bunlara atama yapabildigmzi gorebiliriz..
            My.Settings.Name = InputName.Text
            My.Settings.Surname = InputSurname.Text
            My.Settings.Born = InputBorn.Text
            My.Settings.City = InputCity.Text
            ' PICTUREBOX A EKLENEN RESMIN TABLOYA EKLENMESI..MY.SETTINGS. TABLOSUNA EKLENMESI
            ' Resimlerin isimlerini, veya url lerini kaydedecegiz normal veritabanlarinda veya web de de  yaptgiimgz uzere..Ve resmimizin ismine atama yapmak icin de ayrica bir tane
            ' Label olusturuyoruz..Avatar resmine ekleyeceigmz resmin url ini verecegimz bir label olusturacagiz..Ve form daki datalar kaydedilirken bu label dan URL ALINARAK KAYDEDILECEK
            ' Bu cok onemlidir cunku biz eger direk, kullanici picturebox a resim eklerken kaydederken ki url i alip da My.Settings e kaydedersek adam eger Save e basmadan gidip
            ' tekrar resmi degistirebilir...ayrica adam 3-4 tane farkli resim ekler, resources e ve ordan secebilir, biz adam hangisini secerse onun url ini surekli olarak label 
            ' in text inde guncel tutariz...Kullanici kaydet tusuna basarsa Label da artik hangi picture kaydetti ise ona ait URL yi gorecegiz yok kullanici save demez ise kaydetmez ise
            ' o zaman Label default text value ne verdi isek onu gorecegiz
            ' Tabi burda suna dikkat edelim...Biz Label i da gizleyerek tutacagiz..nasil form u buyuturuz once size olarak, bir kosesinden cekerek sonra sol alt kosesine
            ' label i surukleriz ardindan da tekrar formu kucultursek o zaman o label gizlenmis olacak...yani biz data yi tutuyoruz ama onunda kullanici tarafindan gozukmemesini 
            ' istiyorusak bu sekilde yapacagiz...ki genelllikle resim islemlerinde biz bu sekilde yapariz..Ama eger formu n FormBorderStyle i Sizeable ise ozaman kullanici formu
            ' buyutup kuculttugunde onu gorur ondan dolayi da , herhangi bir tool-aracinin arkasina saklamayi deneyebiliriz...Ornegin goturup PictureBox in uzerine
            ' surukleriz URLLABEL IMIZI sonrasinda da o Label uzerine gelip saga tiklayarak arka ya gonder dersek o URL  i gizlemis oluruz, biz su anda bu sekilde yaptik Avatar
            ' picturebox imizin arkasina gondermis olduk URLLABEL IMIZI..AMA SUNU DA UNUTMAYALIM..O LABEL IN TEXT INE GIRILECEK DEGER EGER ARKASINA GIZLEDIMGZ PICTUREBOX IN 
            ' GENISLIGINI ASARSA , URLLABEL ININ PICTUREBOX TAN TASAN KISIMLARI DA GOZUKECEKTIR ONUN ICIN DE AYRICA BIR COZUM DUSUNULMELDIR...KULLANICIYA ONU GOSTERMEMEK ICIN
            My.Settings.Avatar = AvatarURL.Text

            'YUKARDAKI GIBI My.Settings deki column title lara atama yaptik son olarak bunlarin oraya kaydolmasi icin My.Settings.Save() dememiz gerekiyor
            My.Settings.Save()
            ' Herzaman kullaniclarimza yapilan islem sonunda onlari dogru  yonlendirici geri donusumler vererek yaptigi islemin basarili veya basarizi olma durumunu onlara
            ' bildirerek onlari dogru yonlendirmeliyiz...
            MsgBox("Your settings are saved successfully")
            ' Bu arada biz datalarimizi My.Settings e Save butonan basarak kaydetsek bile, verilerimiz My.Settings de gozukmeyecektir...bunlar ancak biz My.Settings e kendimiz
            ' elle deger girdigmz de veya program calistiginda gozukecektir..Yani bu bir problem degildir sadece bu konunun bu sekilde oldugunu bilelim..
            ' Su an ayarlarda kaydettik artik verilerimizi gostermek istiyorsak o zaman verilerimizi My.Settings den cekebiliriz. Bu verileri formumuz acildiginda ceksin diyebiliirz
            ' Verilerimzi biz Formumuz acildiginda direk My.Settings den verileriimizi cekerek getirisin istiyoruz o zaman Formun Load Eventi icerisinde bu islemleri yapariz

        End If
        ' Form- da ControlBox, StartPosition, FormBorderStyle, MaximizeBox u False yaparsak da kullanicinin formu buyutebilmesini daha dogrusu, sag ustteki kareye basarak 
        ' buyutebilmesini engellemis oluruz..


    End Sub

    Private Sub InputName_TextChanged(sender As Object, e As EventArgs) Handles InputName.TextChanged
        ' eger kullanici buraya data girmis ise o zaman da biz ne yapalim...Label text i tekrardan siyah renkli yapalim
        If InputName.Text <> "" Then ' Eger ki InputName icerisine veri girilmemis ise....
            MyName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub InputSurname_TextChanged(sender As Object, e As EventArgs) Handles InputSurname.TextChanged
        ' eger kullanici buraya data girmis ise o zaman da biz ne yapalim...Label text i tekrardan siyah renkli yapalim
        If InputSurname.Text <> "" Then ' Eger ki InputName icerisine veri girilmemis ise....
            MySurname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub MyAddAvatarBtn_Click(sender As Object, e As EventArgs) Handles MyAddAvatarBtn.Click
        ' KULANICIYA RESIM SECTIRME...COOOK ONEMLI
        ' Bu buton avatar ekleme butonudur, kullanici bu butona tikladigi zaman OpenFileDialog tool u acilacak ve kullanici resim secebilmesin saglamis olacagiz..
        ' Name olarak da ChooseFile yaptik bunu....
        ' Kullanici AddAvatar butoununa tiklayinca burasi calisacak ve kullanicinin dosya secme islemini onaylamasi neticesince, y ani OpenFileDialog da kullanici dosya yi sectikten
        ' sonra tetiklenen dosyayi sectigi onaylama durumnunu check edip ona gore burda islem yapacagiz...
        If ChooseFile.ShowDialog = DialogResult.OK Then  ' Kullanici resmi ortaya cikan file a secti ise..
            ' ChooseFile.ShowDialog() boyle yapsa idik kullanici bu dialog icine resim sectiginda sonradan iptal bile etse o resmi aliyor ondan dolayi bu kontrolu  yapmamiz cok onemlidir
            AvatarURL.Text = ChooseFile.FileName   ' secilen dosya nin ismini url icin tuttugmuz label in text ine atama  yapacagiz
            AvatarPictureBox.ImageLocation = ChooseFile.FileName ' PictureBox in ImageLocation a da secilen resmin ismini atariz..
        End If
    End Sub
    ' BESTPRACTISE...FORM  UN TEMA RENGINI KULLANICIYA SUNDUGMUZ PICTUREBOX LAR ILE FARKLI RENKLERI TIKLAMASINI SAGLAYARAK KULLANICININ FORM UN TEMA RENGINI DE BELIRLEMESIN SAGLAMIS
    ' OLUYORUZ VE O TEMA RENGINI DE MY.Settigns tablosuna kaydederek form load edildiginde yani bastan acildiginda kullanici hangi rengi secerek kaydetmis ise
    ' o tema rengi ile formun acilmasini saglamais oluyroz
    ' Asagida My.Settings de kaydetme islemlerinden sonra Save etmeyi unutmayalim....
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles MyPictureBox1.Click

        Me.BackColor = MyPictureBox1.BackColor
        My.Settings.Tema = MyPictureBox1.BackColor
        My.Settings.Save()

    End Sub
    Private Sub MyPictureBox2_Click(sender As Object, e As EventArgs) Handles MyPictureBox2.Click
        Me.BackColor = MyPictureBox2.BackColor
        My.Settings.Tema = MyPictureBox2.BackColor
        My.Settings.Save()

    End Sub

    Private Sub MyPictureBox3_Click(sender As Object, e As EventArgs) Handles MyPictureBox3.Click
        Me.BackColor = MyPictureBox3.BackColor
        My.Settings.Tema = MyPictureBox3.BackColor
        My.Settings.Save()
    End Sub

    ' BURASI DA HARIKA...FORM1 ICERISINDE OPENFORM2 BUTONUNA TIKLIYORUZ VE SONRADAN PROJEMIZE MENU DEN PROJE DEN YENI FORM EKLE YI SECEREK EKLEDIMGZ FORM2 YI BU BUTON ARACILIGI
    ' ILE ASAGIDAKI GIBI GOSTEREBILIYORUZ VEYA ACABILIYORUZ....
    'Eger ShowDialog() olarak acarsak o zaman da pencere olarak direk Form1 in uzerinde acacaktir cunku Form1 in dialog penceresi oldugu icin dialog pencersindeki mantik budur,
    'ama biz direk olarak show dersek o zaman Form1 den bagimsiz olarak Form2 acilir...
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ShowDialog()
        ' Form2.Show()
    End Sub
    ' Sag sidebar da proje dosyamiz da My Project e cift tiklayinca Settings kismindaki tablo ya oncelikle neleri kaydedecek sek onlarin Colon title larini girelim
    ' Yani Name, Surname, Born, City colon title larini girelim ki kullanici verilerini girdginde bu title lar altina kaydededlim...

End Class

' PictureBox da secilen resmin alana tam sigmasi ve kuculttulerek alana yerlestirilmesi icin PictureBox in BackgroundImageLayoutta Strict ozelligi secilmelidir

' BESTPRACTISE..KESINLIKE BU MANTIK ANLASILMALI VE BILINMELIDIR

' Simdi su konuyu tam anlamak gerekiyor...ListBox,Form, Combobox, TextBox gibi tum tool lar birer class tir..yani ayni zamanda da type dirlar ayni String gibi Integer gibi
' a yni zamanda da birer type dirlar ve ornegin paraemtrelere verirken listBox As ListBox diyerek belirtebildigimz birer type dirlar, burda parametre de belirtirken bu type a gore
' belirtmek bazen o kadar onemlidir ki bir sonraki adima gecerken tikanmadan gecebilmek icin bunu anlamak gerkeiyor...Cunku her her bir Type in barindirdigi bazi properties, eveents
' ve methods lari vardir..iste parametre de hangi type olarak belirtirsek referans tutucuyu, o referans tutucu uzerinden islem yapacagmz zaman o methodlara, o eventlere ve o properties
' e erisebilmis olcagiz..bu da dogurdan yapacagimz islemi etkiliyor olacak

' MY.Settings e textbox a girilen verileri otomatik olarak kaydetme, kod yazmadan kaydetme islemijne baklaim simdide
' InputName olarak Name verdigmz textBox imizi seceriz ve o textbox imizin properties pencreesi ne gidersek yani sag alt kosede bulunan pencere  de en ustte
'ApplicationSettins bulunuyor onun hemen altinda da DataBindings bulunuyor..DataBindings veritabani baglantilarinda kullanilrken biz burda My.Settings e otomatik eklemek icin
' ApplicationSettings i kullanaagiz, ApplicationSettings in altinda porpertybinding satirindan en sagda bulunan ... iconuna tiklayarak acarsak o zaman karsimza bir pencere
' acilacaktir, uzerinde secerek properties e geldigmz textBox ile ilgili ne kaydetmek istersek onu bu pencereden secebiliyoruz...Ve orda istersek new a tiklayarak yeni bir isim
' veiriri o kaydetmek istdigmz kolon title icin istersek de zaten seceneklerde bizim manuel olarak kendigmzin kaydettigi title lar da var Name gibi o Name i de secebiliriz yani 
' ayni title i kullaniriz...istersek de new diyerek yeni olustururuz, Default value de girebiliyoruz...yine ayni yerde..Simdi biz bu ekledigmz yeni colon u eklenip eklenmedigin
' gormek istersek de proje dosyalarimzin visual studio da sag sidebar da bulundugu yerde My Project e cift tiklarsak ordan geleecek olan sol sidebar dan da Settings i secersek ordas
' tablo ya ekledigmiz column title inin gelip gelmedigni gormus oluruz

' BESTPRACITSE--INFORMATION
'  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click bu tarz click olaylarinda Handles Button1.Click in olmasi gerekir yoksa, click olayi calismayacaktir