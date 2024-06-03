using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHayvanUygulaması
{
    class Kopek : IHayvan,IBesleyen
    {
        public void Beslen()
        {
            Console.WriteLine("Köpek et yedi");
        }

        public void SesCikar()
        {
            Console.WriteLine("Köpek : hav hav");
        }
    }
}
