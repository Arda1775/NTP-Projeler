using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamasi
{
    class Manager : IWorker,ISalary,IEat
    {
        public void Eat()
        {
            Console.WriteLine("Manager Yemek Yer");
        }

        public void GetSlary()
        {
            Console.WriteLine("Yönetici Maaş Alır");
        }

        public void Work()
        {
            Console.WriteLine("Manager Çalışıyor");
        }
    }
}
