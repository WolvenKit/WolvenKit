using System.Collections.Generic;

namespace WolvenKit.Common.Extensions
{
    public static class DictionaryExtensions
    {

        public static void AddUnique(this Dictionary<string, uint> dic, string str, uint val)
        {
            str ??= "";

            if (!dic.ContainsKey(str))
            {
                dic.Add(str, val);
            }
        }

        public static uint Get(this Dictionary<string, uint> dic, string str)
        {
            str ??= "";

            return dic[str];
        }

    }
}
