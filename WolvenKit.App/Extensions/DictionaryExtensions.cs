using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace WolvenKit.App.Extensions;

public static class DictionaryExtensions
{
    private static IList MergeLists(IList coll1, IList coll2)
    {
        foreach (var o in coll2)
        {
            coll1.Add(o);
        }

        return coll1;
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
                    if (val is IList coll && p.Value is IList coll2)
                    {
                        me[p.Key] = (TV)MergeLists(coll, coll2);
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(nameof(me), "This method only support lists");
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