using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableKoleksiyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable nesnesi oluşturma
            Hashtable ogrenciler = new Hashtable();
            ogrenciler.Add(550, "Evin");//veri ekleme 1 .yol
            ogrenciler.Add("Enes", 1944);// veri ekleme 2. yol
            ogrenciler.Add(1442, "Miray");
            ogrenciler.Add(1825, "Hazal");
            ogrenciler.Add(1376, "Arda");
            ogrenciler.Add(2489, "Ömer");
            ogrenciler.Add(997, "Emirhan");

            //silme
            ogrenciler.Remove(550);
            ogrenciler.Remove("Enes");

            //güncelleme
            ogrenciler[1442] = "Kerim";

            foreach (var anahtar in ogrenciler.Keys)
            {
                Console.WriteLine(anahtar);
            }
            foreach (var deger in ogrenciler.Values)
            {
                Console.WriteLine(deger);
            }
            foreach (DictionaryEntry eleman in ogrenciler)
            {
                Console.WriteLine(eleman.Key + " - " + eleman.Value);
            }
            Console.ReadLine();
        }
    }
}
