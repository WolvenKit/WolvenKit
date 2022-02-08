using System.IO;
using System.Text;

namespace WolvenKit.RED4.CR2W
{
    public static class CR2WReaderExtensions
    {









        #region Methods


        /// <summary>
        ///     Read null terminated string
        /// </summary>
        /// <param name="file">Reader</param>
        /// <param name="len">Fixed length string</param>
        /// <returns>string</returns>
        public static string ReadCR2WString(this BinaryReader file, int len = 0)
        {
            string str = null;
            if (len > 0)
            {
                str = Encoding.GetEncoding("ISO-8859-1").GetString(file.ReadBytes(len));
            }
            else
            {
                var sb = new StringBuilder();
                while (true)
                {
                    var c = (char)file.ReadByte();
                    if (c == 0)
                    {
                        break;
                    }

                    sb.Append(c);
                }
                str = sb.ToString();
            }
            return str;
        }

        public static byte[] ReadRemainingData(this BinaryReader br) => br.ReadBytes((int)(br.BaseStream.Length - br.BaseStream.Position));

        public static void WriteCR2WString(this BinaryWriter file, string str)
        {
            if (str != null)
            {
                file.Write(Encoding.GetEncoding("ISO-8859-1").GetBytes(str));
            }
            file.Write((byte)0);
        }

        #endregion Methods
    }
}
