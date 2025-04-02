using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
        
        private static IList MergeLists(IList coll1, IList coll2)
        {
            foreach (var o in coll2)
            {
                coll1.Add(o);
            }

            return coll1;
        }


        private static IEnumerable MergeLists(IEnumerable coll1, IEnumerable coll2)
        {
            var elementType = coll1.GetType().GetGenericArguments().FirstOrDefault() ?? typeof(object);
            var listType = typeof(List<>).MakeGenericType(elementType);
            var list = (IList)Activator.CreateInstance(listType)!;

            foreach (var item in coll1)
            {
                list.Add(item);
            }

            foreach (var item in coll2)
            {
                list.Add(item);
            }

            return list;
        }
        
        // Merges two dictionaries with lists
        public static T MergeRange<T, TK, TV>(this T me, params IDictionary<TK, TV>[] others)
            where T : IDictionary<TK, TV>, new()
        {
            var newMap = new T();
            foreach (var src in others)
            {
                foreach (var p in src)
                {
                    if (me.TryGetValue(p.Key, out var val))
                    {
                        switch (val)
                        {
                            case IList coll when p.Value is IList coll2:
                                me[p.Key] = (TV)MergeLists(coll, coll2);
                                break;
                            case IEnumerable enum1 when p.Value is IEnumerable enum2:
                                me[p.Key] = (TV)MergeLists(enum1, enum2);
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(me),
                                    $"This method only supports lists, but instead we're trying to merge {p.Value?.GetType().Name} into {val?.GetType().Name}");
                        }
                    }
                    else
                    {
                        me[p.Key] = p.Value;
                    }
                }
            }

            return me;
        }

    }
}
