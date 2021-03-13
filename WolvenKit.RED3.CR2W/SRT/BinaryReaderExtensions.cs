using System.IO;

namespace WolvenKit.RED3.CR2W.SRT
{
    public static class BinaryReaderExtensions
    {
        #region Methods

        public static void ParseUntilAligned(this BinaryReader br)
        {
            // read padding
            int uiPadSize = 4 - (int)br.BaseStream.Position % 4;
            if (uiPadSize < 4)
                br.ReadBytes(uiPadSize);
        }

        #endregion Methods
    }

    public static class BinaryWriterExtensions
    {
        #region Methods

        public static void WriteUntilAligned(this BinaryWriter bw)
        {
            // read padding
            int uiPadSize = 4 - (int)bw.BaseStream.Position % 4;
            if (uiPadSize < 4)
                bw.Write(new byte[uiPadSize]);
        }

        #endregion Methods
    }
}
