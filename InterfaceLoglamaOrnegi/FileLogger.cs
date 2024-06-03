using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoglamaOrnegi
{
    class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Dosyaya kayıt ekledni");
        }
    }
}
