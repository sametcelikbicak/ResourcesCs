using System.Globalization;
using System.Reflection;
using System.Resources;

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
