using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesCs
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultureTR = new CultureInfo(Culture.trTR());
            CultureInfo cultureUS = new CultureInfo(Culture.enUS());
            CultureInfo cultureFR = new CultureInfo(Culture.frFR());

            Console.WriteLine("Read resources from Resource.resx with Culture");
            Console.WriteLine("HelloWorld with " + cultureTR.Name + " : " + Read.FromResource("HelloWorld", cultureTR));
            Console.WriteLine("HelloWorld with " + cultureUS.Name + " : " + Read.FromResource("HelloWorld", cultureUS));
            Console.WriteLine("HelloWorld with " + cultureFR.Name + " : " + Read.FromResource("HelloWorld", cultureFR));

            Console.ReadKey();
        }
    }
}
