using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class animRig : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            Appendix = new BaseAppendix { Buffer = reader.BaseReader.ReadBytes((int)size) };
        }

        public void Write(Red4Writer writer) => writer.BaseWriter.Write(((BaseAppendix)Appendix).Buffer);


        //[Ordinal(1000)]
        //[REDBuffer(true)]
        //public CArrayCompressed<CInt16> Unk1
        //{
        //    get => GetPropertyValue<CArrayCompressed<CInt16>>();
        //    set => SetPropertyValue<CArrayCompressed<CInt16>>(value);
        //}

        //// could be anything, the vector4 is just a wild guess
        //[Ordinal(1001)]
        //[REDBuffer(true)]
        //public CArrayCompressed<CArrayCompressed<Vector4>> Unk2
        //{
        //    get => GetPropertyValue<CArrayCompressed<CArrayCompressed<Vector4>>>();
        //    set => SetPropertyValue<CArrayCompressed<CArrayCompressed<Vector4>>>(value);
        //}
    }
}
