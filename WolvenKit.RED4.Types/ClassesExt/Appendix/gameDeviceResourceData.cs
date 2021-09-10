using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class gameDeviceResourceData : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            var innerSize = reader.BaseReader.ReadInt32();

            Appendix = new gameDeviceResourceData_Appendix { Buffer = reader.BaseReader.ReadBytes(innerSize - 4) };
        }

        public void Write(Red4Writer writer)
        {
            var value = (gameDeviceResourceData_Appendix)Appendix;

            writer.BaseWriter.Write(value.Buffer.Length + 4);
            writer.BaseWriter.Write(value.Buffer);
        }
    }

    public class gameDeviceResourceData_Appendix
    {
        public byte[] Buffer { get; set; }
    }
}
