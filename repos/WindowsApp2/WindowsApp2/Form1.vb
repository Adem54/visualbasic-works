Public Class Form1

    ' Sayisal degiskenler: Byte, short , integer , Long, Single, Double, Decimal
    ' String Tipler:  String, Char
    ' Mantiksal tipler: Boolean
    ' Tarih Tipi : Date
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles MyTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '  Dim counter As Integer = 0 counter degeri Dim ile olusturulur ise her seferinde bu method calisinca bu deger 0 dan baslayacagi icin, sadece 1 olur her tiklamada 1 de kalir artmaz
        ' STATIC OLARAK TANIMLANAN DEGISKEN ILE, DIM ILE TANIMLANAN DEGISKENIN FARKINI BILELIM!!!!CCOOOK ONEMLI BESTPRACTISE...
        ' Ama eger biz bu degisken i Dim ile degil de Static ile yaparsak bu sefer, artik dikkat edelim...Static sayesinde Button1_Click methoud icerisinde counter degeri,
        ' en son hangi dgeer olarak calisti ise o degeri bize verecektir yani, her buttona tiklandigiinda artik artisa gececektir...COOK ONEMLI!!!
        Static counter As Integer = 0
        ' Javascriptteki Closure ve php deki yine static ile ayni mantik ta her bir method invoke edildiginde en son hangi deger de kalmis ise onunla devam edecektir..

        ' Sabit degerler Const ile tanimlanir
        Const pi = 3.1415 ' bu deger hicbir zaaman degismeyecektir

        ' Mod alma Mod yazarak yapilir
        ' And , Or   ifadeleri de if condition larda kullanilir
        ' XOr verilen kosullarin farklarini kiyaslar..yANI EGER IKI KOSULDAN SADECE BIRISI TRUE ISE TRUE DONER, YANI HER IKISIDDE TRUE OLURSA FALSE DONER HER IKISI DE FALSE ISE FALSE DONER
        ' AMA TRUE-FALSE VEYA FALSE-TRUE LARIN HER IKISINDE DE TRUE DONECEKTIR

        counter += 1
        Label1.Text = counter
        ' Sub demek retun etmeyen bir procedurdur...Procedurler 2 ye ayrililr function, Sub diye function return edileblir, Sub return edilemez
        Dim userName As String
        ' Dim userName yazsa idik o zaman program bunu kendisi turu bizim atadigimz degere gore otomatik olarak belirleyecktir ama boyle durumlarda ise memory de daha fazla yer kaplayacagi icin, bu perfoormans acisindan tavsiye edilmez
        ' Uygulammaiz i compile edince, .exe uzantili uygulamayi calistiran dosyayi bin klasoru icindeki Debug icinde olusturacaktir..Ve de bu .exe  dosyasinin boyutunu ekstra dan artiracaktir..
        ' Biz Button a tiklaninca Textbox icerigine yazilan datayi almak istiyorsak once TextBox in referansini tutan bir degisken vs elimizde olmalidir iste bunun icin biz TextBox a ait uniq Name ozelliginde ne verilmis ise onu kullanabiliriz
        ' MyTextBox1 referans i tutan Name property sine memberAccess operatorune MyTextBox1. altinda kullanabilecegimz property ve methodri vardir onlari kullanabiliriz...
        ' Buyuk ihtimalle MyTextBox1 kendisi de ayri bir class tir
        ' MyTextBox1.Text buna biz yeni bir deger set edebiliyoruz ayrica da eger biz direk burda yeni bir deger set etmezsek de kullanici TextBox a ne girmis ise onu de get edebiliyoruz yani okuyabiliyoruz..
        userName = "Adem"

        ' Visual BAsic de = ifadesi hem atama ,  hem de karsilastirma operatoru olarak kullaniliyor
        ' String.Compare methodu ise integer ifadde dondurur ve eger equal ise 0, equal degil ise de 1 dondurecektir..
        ' Visual Basic de C#,Javascriptteki ! operatorunun karsiligi Not operatorudur

        '  MyTextBox1.Text = userName.ToLower()
        Dim result As String
        If (String.Compare(userName, MyTextBox1.Text)) = 0 Then

            result = "Two strings are equal!"
        Else
            result = "Two strings are not equal"
        End If



        'MsgBox(result)

        '  userName.Insert(4, " Erbas") bu ifade mevcut userName i degistirmiyor, ondan dolayi bizim sonucu yeni bir deger atamamamiz gerekiyor
        Dim newName As String = userName.Insert(4, " Erbas") ' index mantiinda 0 dan baslamiyor normal ilk harfi 1 olarak degerlendiriyor, ve mevcut insert un Lengt inden daha buyuk bir integer
        ' deger vermeeyiz ilk parametrye cunku mevcut stringimze bir deger ekleyecek...eger bosluk birakmak istersek zaten yeni ekleyecegimz string i bir bosluk birakara yazabilriz

        Dim myNewName As String = newName.Replace("Adem", "Zehra") ' Direk kullanilan String icerisindkei herhangi bir ifadeyi bulur ve verdigimz 2. parametredeki String ile onu degistirir
        MsgBox(myNewName)

        ' String Formatlama 
        ' PadRight(adet, karakter)-> Saga karakter ekleme
        ' PadLeft(adet,karaketer)->Sola karakter ekleme

        Dim str As String = "Ali Okula Gel"
        MsgBox(str.PadRight(14, "."))
        ' Oncelikle mevcut string in Lengt ine bakar ornegin uzunlugu 13 diyelim eger PadRigth parametreler 14,"." verilirse o zaman 1 tane . koyar stringin sonuna,
        ' eger 14  yerine 15 verilse idi o zaman da 2 tane . koyacakti string sonuna , ya da 14 yerine 12 verse idi 12. sira da zaten string degerin  kendi karakteri oldugu icin hicbirse eklemeyecekti..

        '  Dim name, surname As String, myDate As Date ' bu sekilde bir den fazla degisken i tanimlayabiliyoruz
        Dim myDate As Date

        myDate = Today ' Today hazir fonksiyon olarak geliyor Visual BAsic icerisine

        MsgBox(myDate)


        ' Formatted String

        '{0} represents the placeholder for the name variable, and {1} represents the placeholder for the age variable.
        'The values of name and age are passed as arguments to the String.Format method in the same order as the placeholders.
        'The String.Format method replaces the placeholders with the corresponding values and returns the formatted string.

        Dim name As String = "John"
        Dim age As Integer = 30

        Dim formattedString As String = String.Format("My name is {0} and I'm {1} years old.", name, age)

        Console.WriteLine(formattedString) ' My name is John and I'm 30 years old.

        ' Global-Local Variables
        ' Class larin altinda ama precedurlerin ustunde  yani sub veya functions larin ustunde tanimlanan degiskenler global olur ve tum procedurlerde kullanilabilir
        ' Global variables are useful when you need to share data across multiple procedures or functions.
        ' Local variables are useful when you need temporary storage for data within a specific procedure or function.
        'Local variables are declared within a specific procedure or function.
        ' Local variables are accessible only within the scope of the procedure Or function where they are declared.

        'Public Shared 
        ' In Visual Basic .NET, the Public Shared declaration is used to define a member or variable that is accessible from anywhere
        ' in the program without needing an instance of the class or object.
        ' Public: It specifies the accessibility level of the member as public. This means the member can be accessed from any code within the same assembly or project.
        ' Shared: It indicates that the member or variable belongs to the class itself rather than instances of the class.
        ' The member is shared among all instances of the class, and it can be accessed directly using the class name without creating an instance of the class.
        ' When a member or variable is declared as Public Shared, it is commonly referred to as a "shared member" or "static member" in other programming languages.
        ' Shared members are associated with the class itself rather than individual instances, and they can be accessed using the class name followed by the member name.
        ' Ornegin MyClass isimli public bir class iceriisnde eger Public Shared Sub SharedMethod()   End Sub ve Public Shared mySharedVariable As Integer = 10 kullaniliyor ise
        ' o zaman biz uygulamanin her yerinde MyClass.SharedMethod() ve MyClass.mySharedVariable bu sekilde erisebiliriz..
        ' 
        ' HANGI DURUMLARDA KULLANILIR 
        ' Shared members are useful when you want to define functionality or data that is shared among all instances of a class,
        ' or when you need to access the member without creating an instance of the class. They can be accessed globally within the program,
        ' making them suitable for implementing utility methods, constants, or shared data.

        ' Diger Form2 class ini projesini biz direk olarak burda kullanabiliyoruz bu sekilde..cunku Public olarak verilmis
        Dim Form2 As Form2 = New Form2()
        Form2.Label1.Text = MyTextBox1.Text

        ' <> demek esit degil ise demektir visual basic de ...  yani javascript ve C# daki ! a karsilik gelir
        ' = hem assign hem de compare(karsilastirma) operatorudur

        If MyTextBox1.Text <> "Adem" Then
            MsgBox("username is not equal Adem")
        ElseIf MyTextBox1.Text = "Adem" Then
            MsgBox("username is equal Adem")

        End If

        ' Array tanimlama

        Dim array() As Integer = New Integer() {1, 2, 3, 4}
        Dim array2() As String = {"Skien", "Ski", "Larvik", "Porsgrunn"}
        Dim array3(3) As Char
        array3(0) = "A"
        array3(1) = "Z"
        array3(2) = "X"
        array3(3) = "Y"

        ' For Each dongusu
        For Each ch As Char In array3
            Console.WriteLine("ch: {0} ", ch)
        Next

        Console.WriteLine("****************************")

        ' For dongusu kullanim
        For i As Integer = 0 To (array2.Length - 1)
            Console.WriteLine(array2(i))
        Next

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class

' Module nedir ne icin kullanilir..
' Module kisaca C# daki Static class larin Visual basic deki karsiligidir
' In Visual Basic .NET, a Module is a container that allows you to organize and group related code together.
' It is similar to a class, but unlike a class, you cannot create instances of a module. The Module keyword is used to define a module in Visual Basic.

'In the given example, GlobalModule is a module that contains two subroutines (Procedure1 and Procedure2) and a global variable (globalVariable).
'The globalVariable is a public variable declared at the module level, which means it can be accessed by any code within the module. It has a value of 10 initially.
' The Procedure1 subroutine demonstrates accessing the global variable by simply using its name (globalVariable). In this case, it will output the value of the global variable (10) to the console.
' The Procedure2 subroutine shows an example of modifying the global variable. It sets the value of globalVariable to 20.

' Since the variable is declared at the module level, it can be accessed and modified by any procedure within the same module.
' This allows for sharing data across different procedures or functions within the module.

' Modules are commonly used to define shared procedures, functions, and variables that can be accessed globally within an application without the need for object instances.
' They provide a way to organize code and encapsulate related functionality.

Module GlobalModule
    Public globalVariable As Integer = 10

    Sub Procedure1()
        ' Accessing the global variable
        Console.WriteLine(globalVariable)
    End Sub

    Sub Procedure2()
        ' Modifying the global variable
        globalVariable = 20
    End Sub
End Module

Module GlobalModule2
    Public globalVariable2 As Integer = 10
End Module

Module Program
    Sub Main()
        ' Accessing the global variable from another module or class
        Console.WriteLine(GlobalModule2.globalVariable2)
    End Sub
End Module

Module GlobalModule3
    Sub Procedure1()
        Console.WriteLine("Hello from Procedure1!")
    End Sub
End Module

Module Program2
    Sub Main()
        ' Calling the procedure from another module or class
        GlobalModule3.Procedure1()
    End Sub
End Module
' Importing Modules:
' In this example, the GlobalModule is imported using the Imports statement.
' This allows you to directly access the global variable and call the procedure without explicitly specifying the module name.
' GlobalModule3 u import ettoginde o Module icerisindeki procedurleri direk olarak kullanabilir
' Imports GlobalModule3
Module Program3
    Sub Main()
        ' Accessing the global variable without explicitly using the module name
        Console.WriteLine(globalVariable)

        ' Calling the procedure without explicitly using the module name
        '  Procedure1()
    End Sub
End Module


' Public olarak belirledigmiz class larimzi diger tum alanlarda ve diger tum projelerde kullanabiliyoruz..
' Private olarak kullanirsak da sadece kendi projesi icerisinde ku llaniliyor..baska projelerde kullanilamaz..Biz genellikle bir solution altinda
' birden fazla proje lerin birlesiminden olusan bir solution ile tum projeyi calistiririz
'  iste burda private yapinca diger proje lerden erisilemeyecektir sadece kendi projesi icerisinde erisilebilecektir