using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcgenAlanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            ucgen üçgen = new ucgen();
            üçgen.a = 5;
            üçgen.b = 4;
            üçgen.c = 3;
            Console.WriteLine("üÇGENİN A KENARI : " + üçgen.a);
            Console.WriteLine("üÇGENİN B KENARI : " + üçgen.b);
            Console.WriteLine("üÇGENİN C KENARI : " + üçgen.c);
            Console.ReadLine();
        }
    }
}
