using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.RED4.Types
{
    public class gamedataLocKeyWrapper : IRedPrimitive
    {
        public ulong Key;

        public gamedataLocKeyWrapper(ulong key)
        {
            Key = key;
        }

        public static implicit operator gamedataLocKeyWrapper(ulong key) => new(key);
        public static implicit operator ulong(gamedataLocKeyWrapper locKey) => locKey.Key;

    }
}
