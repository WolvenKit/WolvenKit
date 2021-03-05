using System.IO;

namespace WolvenKit.Radish
{
    public abstract class WitcherTool
    {
        #region Methods

        public abstract void Decode(FileStream file);

        public abstract void Encode(FileStream file);

        #endregion Methods
    }
}
