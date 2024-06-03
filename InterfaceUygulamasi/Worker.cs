using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamasi
{
    class Worker : IWorker,ISalary,IEat
    {
        public void Eat()
        {
            Console.WriteLine("Worker Yemek Yer");
        }

        public void GetSlary()
        {
            Console.WriteLine("Workerk Maaş Alır");
        }

        public void Work()
        {
            Console.WriteLine("Worker Çalışıyor");
        }
    }
}
