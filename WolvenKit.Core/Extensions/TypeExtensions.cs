using System;
using System.Linq;

namespace WolvenKit.RED4.CR2W
{
    public static class TypeExtensions
    {
        #region Methods

        public static string GetPrettyGenericTypes(this Type t)
        {
            if (t.IsGenericType)
            {
                var typenamewithoutarity = t.Name[..t.Name.LastIndexOf("`", StringComparison.InvariantCulture)];
                var flags = "";
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

        #endregion Methods
    }
}
