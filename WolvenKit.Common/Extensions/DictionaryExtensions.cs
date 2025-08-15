using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

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
        
        /// <summary>
        /// Merges two dictionaries with Lists
        /// In case of conflicts, the values of the second dictionary will be used.
        /// </summary>
        /// <param name="me"></param>
        /// <param name="others"></param>
        /// <returns>The merged dictionary</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T MergeWith<T, TK, E>(this T me, params IDictionary<TK, List<E>>[] others)
            where T : IDictionary<TK, List<E>>
        {
            // go through multiple param dictionaries
            foreach (var otherDict in others)
            {
                foreach (var (secondKey, secondValue) in otherDict)
                {
                    // check if key is in the first dictionary
                    if (me.TryGetValue(secondKey, out var firstValue))
                    {
                        // and set it to the concatenated lists
                        me[secondKey] = [.. firstValue, .. secondValue];
                    }
                    // if not, add it
                    else
                    {
                        me[secondKey] = secondValue;
                    }
                }
            }

            return me;
        }

        /// <summary>
        /// Merges two dictionaries with IEnumerables
        /// In case of conflicts, the values of the second dictionary will be used.
        /// </summary>
        /// <param name="me"></param>
        /// <param name="others"></param>
        /// <returns>The merged dictionary</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T MergeWith<T, TK, E>(this T me, params IDictionary<TK, IEnumerable<E>>[] others)
            where T : IDictionary<TK, IEnumerable<E>>
        {
            // go through multiple param dictionaries
            foreach (var otherDict in others)
            {
                foreach (var (secondKey, secondValue) in otherDict)
                {
                    // check if key is in the first dictionary
                    if (me.TryGetValue(secondKey, out var firstValue))
                    {
                        // and set it to the concatenated lists
                        me[secondKey] = firstValue.Concat(secondValue);
                    }
                    // if not, add it
                    else
                    {
                        me[secondKey] = secondValue;
                    }
                }
            }

            return me;
        }
    }
}
