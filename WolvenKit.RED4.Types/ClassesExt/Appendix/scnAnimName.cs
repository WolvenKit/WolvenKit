using System.IO;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public partial class scnAnimName : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            if (size % 2 != 0)
            {
                throw new TodoException();
            }

            var result = new CName[size / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = reader.ReadCName();
            }

            Appendix = result;
        }

        public void Write(Red4Writer writer)
        {
            var appendix = (CName[])Appendix;

            var isNulled = appendix[^1] == "";
            for (int i = 0; i < appendix.Length; i++)
            {
                writer.BaseWriter.Write(isNulled ? (ushort)0 : writer.GetStringIndex(appendix[i]));
            }
        }
    }
}
