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

            Console.WriteLine(cultureTR.Name + " : "+Read.FromResource("HelloWorld", cultureTR));
            Console.WriteLine(cultureUS.Name + " : "+ Read.FromResource("HelloWorld", cultureUS));
            Console.ReadKey();
        }
    }
}
