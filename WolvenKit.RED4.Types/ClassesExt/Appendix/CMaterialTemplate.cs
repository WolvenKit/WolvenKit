using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    [REDClass(ChildLevel = 1)]
    public partial class CMaterialTemplate : IRedAppendix
    {
        // appear to just be the parameterNames
        [RED("buffer")]
        [REDProperty(IsIgnored = true)]
        public CByteArray Buffer
        {
            get => GetPropertyValue<CByteArray>();
            set => SetPropertyValue<CByteArray>(value);
        }

        public void Read(Red4Reader reader, uint size)
        {
            Buffer = reader.BaseReader.ReadBytes((int)size);
        }

        public void Write(Red4Writer writer) => writer.BaseWriter.Write(Buffer);
    }
}
