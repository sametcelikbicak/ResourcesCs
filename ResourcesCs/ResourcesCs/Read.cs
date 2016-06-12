using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace ResourcesCs
{
    public static class Read
    {
        public static string FromResource(string key, CultureInfo culture)
        {
            ResourceManager rm = new ResourceManager("ResourcesCs.Resources.Resource", Assembly.GetExecutingAssembly());
            return rm.GetString(key, culture);
        }
    }


}
