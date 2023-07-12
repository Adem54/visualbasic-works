Public Class MyFrm1

    ' Formumuzun FormBorderStyle dan formun buyuttulup kuculutulebilme ozelligi vs bunlari ayarliyorduk
    ' FormBorderStyle - None, FixedSingle, Fixed3D, FixedDialog, Sizable
    ' default olarak bu ozellik Sizable olarak gelir ondan dolayi da form u biz surukleyebiliyoruz
    ' StartPosition i nasil ayarlarsak ona gore proje acildiginda ortalanarak veya iste hangi pozisyonda baslasin istersek o sekilde baslayacaktir
    ' Biz form un sag ustune bir button olusturup uzerine x yazip sonra kullanici ona tiklayinca form  kapatilsin seklinde ayarlamalar yapabiliriz
    ' ControlBox u False yaparsak sag ustteki x-kare ve - isaretleri formdan kaldirilir, True yaparsak gelir
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' AYARLAR KAYDEDILME DURUMUNDAKI SPINNER DOLMASI MANTIGINDA ASAGIDAKI BESTPRACTISE GIBI...PROGRESSBAR TOOL U VE TIMER BIRLIKTE BU SEKILDE KULLANILABILIYOR
    ' TIMER AYNI WHILE-DO DONGUSU MANTIGINDA KULLANILABILIYOR...HARIKA BESTPRACTISE...
    ' Timer in Interval proeprty si 1000 yapilirsa 1 saniye de bir calisacaktir...Timer.Start() basladiktan sonra Timer.Stop() a basilinca ya kadar calisacaktir, ama 
    ' ornegin biz Interval i 1 yaparsak o zaman da saniye  nin 1000 de 1 i hizinda calisir ve progressbar cok hizli bir sekilde dolacaktir
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        ' Me bu Sub procedure nin icinde bulundugu class olan MyFrm1 class ini temsil ediyor
        ' Bu sekilde form icindeki sag ustte olustrdugmuz x butonuna tiklayinca formumuzun kapatilmasini saglamis oluruz...
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 1
        Else
            Timer1.Stop()
            MsgBox("Your settings are saved succesfully")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProgressBar1.Maximum = 100
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.Value = 0
        Timer1.Start()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
' Simdi sunu bilelim her bir tool, yani Button,Form, ListBox, ComboBox, Label bunlar birer class tir ve bunmlarin kendilerine ait properties ve methodlar i vardir..
' Form methodlari- Show, Hide, Close
' ListBox methodlar
' Burdaki tool larin her birisi  icin Common Controls ismi veriliyor...
' In VB.Net, the Button, Label, ListBox, and ComboBox are all common controls that you can use in Windows Forms applications to create graphical user interfaces.
' Each control has its own set of methods, properties, and events that you can use to customize their behavior and appearance.
' Here's a brief overview of the methods commonly used with these controls:

'Button:

'Click: An Event that() occurs When the button Is clicked by the user.
'PerformClick: Method that programmatically simulates a button click.
'Focus: Method that gives the button focus.
'Label:

'Text: Property that gets Or sets the text displayed by the label.
'AutoSize: Property that determines whether the label automatically adjusts its size To fit the text.
'ForeColor: Property that sets the foreground color Of the label.
'BackColor: Property that sets the background color Of the label.
'ListBox:

'Items: Property that provides access To the collection Of items In the list box.
'SelectedIndex: Property that gets Or sets the index Of the currently selected item.
'SelectedItems: Property that provides access To the collection Of currently selected items.
'Add: Method that adds an item To the list box.
'Remove: Method that removes an item from the list box.
'ComboBox:

'Items: Property that provides access To the collection Of items In the combo box.
'SelectedIndex: Property that gets Or sets the index Of the currently selected item.
'SelectedValue: Property that gets Or sets the value Of the currently selected item.
'DropDownStyle: Property that determines the appearance And behavior Of the combo box.
'DropDown: Method that programmatically displays the drop-down portion Of the combo box.

'These are just a few examples Of the methods available For these controls. Each control offers many more methods that you can use 
'    To manipulate And interact With them In your VB.Net applications.

' Her bir common control  yani her bir button, label, textbox, form vs bunlarin Name i birer class lardan olusturulmus birer instancedir ya da
' bunlar Static class mantigindaki Module lerdir...
' Ve her birisinin Name i uzerinden, her turlu property si manipule edilebilirken, yani hem set hem de get edilebilirken, ayni zamanda kendilerine ait methodlari da vardir

' EXAMPLES OF COMMONT CONTROLS METHOD USAGE
'Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
'    MessageBox.Show("Button clicked!")
'End Sub

'Private Sub btnTrigger_Click(sender As Object, e As EventArgs) Handles btnTrigger.Click
'    btnClick.PerformClick()
'End Sub

' Example 1: Setting the text and appearance of a label dynamically:

'Private Sub UpdateLabel()
'    lblDynamic.Text = "New Text"
'    lblDynamic.ForeColor = Color.Red
'    lblDynamic.BackColor = Color.Yellow
'End Sub
' This example demonstrates a method named UpdateLabel that sets the text of the label named "lblDynamic" to
' "New Text" and changes its foreground color to red and background color to yellow.

' LISTBOX
' Example 1: Adding and removing items from a list box:
' Ozellikle veriatabanina baglanip ordan veri cekerek o veriyi listelerken ListBox kullanilacaktir foreach ile veya diger dongu yontemleri ile data miz ListBox icerisinde Add ile
' eklenerek listelenecektir
'Private Sub AddItemToListBox()
'    lstItems.Items.Add("Item 1")
'    lstItems.Items.Add("Item 2")
'    lstItems.Items.Add("Item 3")
'End Sub

'Private Sub RemoveItemFromListBox()
'    lstItems.Items.Remove("Item 2")
'End Sub

' Private Sub AddItemToListBox()
' In this example, the AddItemToListBox method adds three items ("Item 1", "Item 2", "Item 3") to a list box named "lstItems".
' The RemoveItemFromListBox method removes "Item 2" from the list box.

' ComboBox:

'Private Sub cmbOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOptions.SelectedIndexChanged
'    Dim selectedOption As String = cmbOptions.SelectedItem.ToString()
'    MessageBox.Show("Selected option: " & selectedOption)
'End Sub

' This example demonstrates an event handler for the selected index change event of a combo box named "cmbOptions".
' It retrieves the selected item's text using the SelectedItem property and displays it in a message box.

' Example 2: Adding and selecting items in a combo box:
'Private Sub InitializeComboBox()
'    cmbOptions.Items.Add("Option 1")
'    cmbOptions.Items.Add("Option 2")
'    cmbOptions.Items.Add("Option 3")
'    cmbOptions.SelectedIndex = 1
'End Sub
' In this example, the InitializeComboBox method adds three items ("Option 1", "Option 2", "Option 3") to a combo box named "cmbOptions".
' It also sets the selected index to 1, making "Option 2" the initially selected item.

' These examples provide a clearer understanding of how to use the methods of Button, Label,
' ListBox, and ComboBox controls in VB.Net. You can adapt and modify them based on your specific requirements.

' Kisacasi bizim bir form uygulamasinda Common Controls yani ToolBox dan sectgimz tool lar uzerinde design ile mouse u kullanarak manuel yaptgimiz herseyi
' aslinda kod ile de yapabiliriz

' Ornegin biz mesela RadioButton kullanirken, if RadioBtn.Checked = True Than RadioBtn.ForeColor = Color.Orange yaparak
' eger radiobtn tiklanmis ise rengini orange yap yok sa rengini baska renk  yap diyebiliriz

' Yani bir daha soyleyelim...Common Controls yani Toolbox dan ekledigmiz Tool lar a verdigmiz Name ler uzerinde tum proerpties leri set edebilirz, get ile de read.-okuyabiliriz
' Ve kendilerine ait methodlari da kulllanabiliriz tabi ki ayrica da her bir control un yani tool un kendine ait events leri de vardir..bunlari da yine her birisne tiklainca
' Properties pencresinini menusunde events lerde gorebiliriz

'BESTPRACTISE TIMER TOOL VEYA COMMON CONTROL U VE TIMER.TICK EVENTI- TIMER.START- TIMER.STOP
' Timer tool veya control u bir islem yaparken belli bir sarta gore surekli calismasi gereken durumlarda kullanilir...Timer.Start() diye ornegin bir butona basilmasi ile baslar 
' Ve de icerisinde belli sartlar sorgulanir ve belli sartlar yerine getirilene kadar timer in Tick event i tetiklenir surekli olarak dongu
' biciminde ta ki biz belli sartlar saglandiginda Timer.Stop() u calistirana kadar
' timer ozellikle ProgrerssBar.Value u yu max 100 ayarlariz ve timer calistiginda da ProgresBar.Value 1 den baslar ve her seferinde 100 den kucuk ise 1 arttir deriz ve 100 olunca
' Timer.Stop diyerek Timer i durdurmus oluruz...yani Butona tiklayinca kaydetme islemi gerceklesirken, web de yaptigmz spinner mantigini progressbar da bu sekilde yapabiliriz
' Timer calisma mantigi olarak herhangi bir butona basma veya bizim belirledigmz bir event ile calistirilmaya baslar, Timer1.Start() ile ve bizim kontrol ettgimiz herhangi bir sart saglanincaya kadar
' Timer Timer.Tick eventi icerisinde yaptigimiz condition in durumuna gore calismaya devam eder, taki sart saglanip bizim Timer i durduracagimz ana kadar..Timer1.Stop()



' COMBOBOX KULLANIMI BESTPRACTISE...
' ComboBox demek SelectOptins demektir web deki karsiligi olarak
' SEcilen option yani ComboBox da secilen secenege gore condition yapabiliriz
' if ComboBox1.Text = "Yellow" Then Me.BackColor = Color.Yellow yap diyebiliriz....
' Ayni islemi farkli bir mantik la index uzerinden giderek de yapabiliriz
'  if ComboBox1.SelectedIndex = 0 Then Me.BackColor = Color.Yellow'
'  if ComboBox1.SelectedIndex = 1 Then Me.BackColor = Color.Red

'BU ISLEMI BIZ SELECT CASE DONGUSU ILE DE  YAPABILIRZ...

' SELECT CASE DONGUSU...(SWITCH-CASE E KARSILIK GELIYOR) 
'Certainly! The Select Case statement In VB.Net Is used To perform multiple conditional checks On a Single expression And 
'    execute different code blocks based On the matching condition. It Is similar To the switch statement In other programming languages.


' EXAMPLE OF USAGE

'Dim dayOfWeek As Integer = 3
'Dim dayName As String = ""

'Select Case dayOfWeek
'Case 1
'dayName = "Sunday"
'Case 2
'dayName = "Monday"
'Case 3
'dayName = "Tuesday"
'Case 4
'dayName = "Wednesday"
'Case 5
'dayName = "Thursday"
'Case 6
'dayName = "Friday"
'Case 7
'dayName = "Saturday"
'Case Else
'dayName = "Invalid day"
'End Select

'Console.WriteLine("The day is: " & dayName)

' The day is: Tuesday

' LISTBOX KULLANIM!! VE RESIM EKLEME!!!
' ListBox larda array data si icerisindeki item lari listelemek icin kullanilir genellikle ama tabi kullanicinin ListBox uzerinde herhangi bir item i secmesi vs gibi
' durumlarda da event- tetiklenmis oluyor...
' ListBox1.SelectedIndex = 0 Then....diyerek eger 1. item secilmis ise...diyoruz

' ListBox1.SelectedIndex = 0 Then
' Me.BackgroundImage = My.Resources.picture1  --Me.BackgroundImage-yani Form1 in BackgroundImage i olarak My.Resources.picture-(My demek benim dokumanim demek ve sonrasinda
' Resources..yani biz disardan image ekledigimz zaman...Tabi bu Resources klasoru altina farkli resim dosyalarinn gelebilmesi icin Form properties inde BacgroundImage ye gidip add diyerek
' 4 tane farkli resim ekleriz...ki o da proje dosyasinin altinda Resources klasoru altina bu resim dosyalarini getirir ve bizde bunlari My.Resources.picture1 diyerek seceiliriz

'MY.RESOURCES...BIZIM DISARDAN EKLEDIGMZ RESOURCES ALTINA GELEN IMAGES LERIMIZI SECERKEN....MY.RESOURCES. DERSEK ZATEN RESOURCES KLASORU ALTINDA BULUNAN
'IMAGES LERI BIZE GOSTERECEKTIR
'PICTUREBOX TOOL UNU KULLANIRSAK ORNEGIN 
'MyPictureBox1.Image = My.Resources.picture1 diyerek Picturebox imiza da if conditiona bagli olarak...bir resim atamasi yapabiliriz..ListBox tan secilen value ye gore
' PictureBox in Image ine resim atamasi yapabiliriz
' Biz windows form uygulamalarimzda hareketli gif ler de kullanabiliriz....eeger ornegin uzaktan veya veritabanindan data cekip data nin gelmesi zaman alacak ise...data gelene
' kadar gif spinner gostermek istersek gif resimler i Lutfen bekleyiniz diyerek yazarak da kullanabiliriz...ornegin giris yaparken kullanici girene kadar boyel bir resim gostererek
' bekletebiliriz...Tabi ki PictureBox icerisine boyle bir gif resiim atabiliriz...
' ProgressBar1.Value = 0  ProgressBar1.Visible = True veya ProgressBar1.Visible = False  PictureBox1.Visible = True

'STRING BIRLESTIRME
' Visual Basic te String birlestirme islemi & karakterini kullanarak yapilir
' Dim result As String = "Hello" & " Adem"
'Console.WriteLine(result)
