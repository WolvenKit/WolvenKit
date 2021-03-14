using System;

namespace WolvenKit.Wwise.Wwise
{
    public class RandomGen
    {
        #region Methods

        public uint uint32()
        {
            Random rnd = new Random();
            return (uint)rnd.Next(1 << 32);
        }

        #endregion Methods
    }
}
