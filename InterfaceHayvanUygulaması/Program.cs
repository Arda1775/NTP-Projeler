using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHayvanUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.SesCikar();
            kedi.Beslen();
            Console.WriteLine(" ");
            Kopek köpek = new Kopek();
            köpek.SesCikar();
            köpek.Beslen();

            Console.ReadLine();
        }
    }
}
