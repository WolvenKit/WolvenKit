using System;

namespace WolvenKit.RED4.Types
{
    public class DataBuffer : IRedPrimitive, IEquatable<DataBuffer>
    {
        public ushort Buffer { get; set; }


        public override bool Equals(object obj)
        {
            if (obj is DataBuffer cObj)
            {
                return Equals(obj);
            }

            return false;
        }

        public bool Equals(DataBuffer other)
        {
            if (other == null)
            {
                return false;
            }

            return Buffer.Equals(other.Buffer);
        }
    }
}
