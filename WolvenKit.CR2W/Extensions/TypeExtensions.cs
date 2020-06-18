using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.CR2W
{
    public static class TypeExtensions
    {

        public static string GetPrettyGenericTypes(this Type t)
        {
            if (t.IsGenericType)
            {
                string typenamewithoutarity = t.Name.Substring(0, t.Name.LastIndexOf("`", StringComparison.InvariantCulture));
                string flags = "";
                if (typenamewithoutarity == "CArray")
                {
                    typenamewithoutarity = "array";
                    //flags = "2,0,";
                }

                var redname = string.Format(
                    "{0}:{1}{2}",
                    typenamewithoutarity,
                    flags,
                    string.Join(", ", t.GetGenericArguments().Select(GetPrettyGenericTypes)));
                return redname;
            }
            return t.Name;
        }
    }
}
