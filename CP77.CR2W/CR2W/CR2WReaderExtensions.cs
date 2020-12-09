using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
{
    public static class CR2WReaderExtensions
    {
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
                        break;
                    sb.Append(c);
                }
                str = sb.ToString();
            }
            return str;
        }

        public static void WriteCR2WString(this BinaryWriter file, string str)
        {
            if (str != null)
            {
                file.Write(Encoding.GetEncoding("ISO-8859-1").GetBytes(str));
            }
            file.Write((byte)0);
        }

        public static void AddUnique(this Dictionary<string, uint> dic, string str, uint val)
        {
            if (str == null) str = "";

            if (!dic.ContainsKey(str))
            {
                dic.Add(str, val);
            }
        }

        public static uint Get(this Dictionary<string, uint> dic, string str)
        {
            if (str == null)
                str = "";

            return dic[str];
        }

        public static byte[] ReadRemainingData(this BinaryReader br)
        {
            return br.ReadBytes((int)(br.BaseStream.Length - br.BaseStream.Position));
        }



        
    }
}