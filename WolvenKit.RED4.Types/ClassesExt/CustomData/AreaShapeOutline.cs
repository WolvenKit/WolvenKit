using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class AreaShapeOutline : IRedCustomData
    {
        private byte[] _buffer;

        public void CustomRead(Red4Reader reader, uint size)
        {
            // TODO: cnt + (Vector4? * cnt) + Height
            _buffer = reader.BaseReader.ReadBytes((int)size);
        }

        public void CustomWrite(Red4Writer writer)
        {
            writer.BaseWriter.Write(_buffer);
        }
    }
}
