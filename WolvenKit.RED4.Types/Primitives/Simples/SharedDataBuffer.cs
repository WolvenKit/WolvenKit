using System;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public class SharedDataBuffer : IRedPrimitive, IEquatable<SharedDataBuffer>
    {
        public byte[] Buffer { get; set; }


        public override bool Equals(object value)
        {
            if (value is SharedDataBuffer cObj)
            {
                return Equals(cObj);
            }
            return false;
        }

        public bool Equals(SharedDataBuffer other)
        {
            if (other == null)
            {
                return false;
            }

            return Buffer.SequenceEqual(other.Buffer);
        }
    }
}
