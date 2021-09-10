using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class gameSmartObjectAnimationDatabase : IRedCustomData
    {
        private int _value;
        private byte[] _buffer;

        public void CustomRead(Red4Reader reader, uint size, int zero)
        {
            _value = zero;
            _buffer = reader.BaseReader.ReadBytes((int)size);
        }

        public void CustomWrite(Red4Writer writer) => throw new System.NotImplementedException();
    }
}
