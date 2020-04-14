using System;
using System.Collections.Generic;
using System.Text;

namespace Convert
{
    public class RandomGen
    {
        public uint uint32()
        {
            Random rnd = new Random();
            return (uint)rnd.Next(1 << 32);
        }
    }
}
