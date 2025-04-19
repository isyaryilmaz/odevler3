using System;
using System.Reflection;

class Ogrenci
{
    public string Ad { get; set; }
    public int Yas { get; set; }
    public string Bolum { get; set; }
}

class Program
{
    static void Main()
    {
        Type tip = typeof(Ogrenci);

        Console.WriteLine("Ogrenci sınıfındaki özellikler:");
        foreach (PropertyInfo ozellik in tip.GetProperties())
        {
            Console.WriteLine(ozellik.Name);
        }
    }
}


Reflection, programın çalışma anında kendi yapısını incelemesini ve bu yapılar üzerinde işlem yapmasını sağlar. Bu sayede:

Bir nesnenin türü çalışma zamanında öğrenilebilir.

Sınıfın metodları, özellikleri ve alanları listelenebilir.

Dinamik olarak nesne oluşturulabilir veya metodlar çalıştırılabilir.

Derleme zamanında bilinmeyen türlerle çalışma imkânı sağlar.

Özellikle eklenti sistemleri, JSON serileştirme, veri doğrulama ve birim testleri gibi dinamik işlemlerde sıkça kullanılır.





Reflection, bir programın çalışması sırasında kendi yapısını (sınıflar, metodlar, özellikler vb.) incelemesine ve gerekirse bu yapılar üzerinde işlem yapmasına olanak tanıyan bir programlama tekniğidir. Özellikle C# gibi dillerde, çalışma zamanında nesne bilgilerine erişmek için kullanılır.
