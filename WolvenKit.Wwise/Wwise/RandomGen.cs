using System;

namespace WolvenKit.Wwise.Wwise
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
