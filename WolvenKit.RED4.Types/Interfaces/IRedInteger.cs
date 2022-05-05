using System.Globalization;

namespace WolvenKit.RED4.Types
{
    public interface IRedInteger
    {
        public string ToString();
        public string ToString(CultureInfo cultureInfo);
    }
}
