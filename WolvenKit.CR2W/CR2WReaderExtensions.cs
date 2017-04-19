using System.Collections.Generic;
using System.IO;
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
                str = Encoding.Default.GetString(file.ReadBytes(len));
            }
            else
            {
                var sb = new StringBuilder();
                while (true)
                {
                    var c = (char) file.ReadByte();
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
                file.Write(Encoding.Default.GetBytes(str));
            }
            file.Write((byte) 0);
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

        public static CVariable GetVariableByName(this CVector arr, string name)
        {
            for (var i = 0; i < arr.variables.Count; i++)
            {
                if (arr.variables[i].Name == name)
                    return arr.variables[i];
            }
            return null;
        }

        public static CVariable GetVariableByType(this CVector arr, string type)
        {
            for (var i = 0; i < arr.variables.Count; i++)
            {
                if (arr.variables[i].Type == type)
                    return arr.variables[i];
            }
            return null;
        }

        public static CVariable GetVariableByName(this CR2WChunk arr, string name)
        {
            if (arr.data is CVector)
            {
                var vdata = (CVector) arr.data;

                for (var i = 0; i < vdata.variables.Count; i++)
                {
                    if (vdata.variables[i].Name == name)
                        return vdata.variables[i];
                }
            }

            return null;
        }

        public static CVariable GetVariableByName(this CR2WChunk arr, CR2WFile file, string name)
        {
            if (arr.data is CVector)
            {
                var vdata = (CVector) arr.data;

                for (var i = 0; i < vdata.variables.Count; i++)
                {
                    if (vdata.variables[i].Name == name)
                        return vdata.variables[i];
                }
            }
            return null;
        }

        public static CVariable GetVariableByName(this List<CVariable> list, string name)
        {
            foreach (var item in list)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }

            return null;
        }

        public static void CreateConnection(this CR2WChunk chunk, string in_name, string out_name, CR2WChunk out_target)
        {
            var cachedConnections = (CArray) chunk.GetVariableByName("cachedConnections");

            if (cachedConnections == null)
            {
                cachedConnections =
                    (CArray) chunk.cr2w.CreateVariable(chunk, "array:2,0,SCachedConnections", "cachedConnections");
            }

            {
                // connection 1

                var connection = (CVector) cachedConnections.array.Find(delegate(CVariable item)
                {
                    var vec = (CVector) item;
                    if (vec == null)
                        return false;

                    var socketId = (CName) vec.GetVariableByName("socketId");
                    return socketId != null && socketId.Value == in_name;
                });

                if (connection == null)
                {
                    connection = chunk.cr2w.CreateVector(cachedConnections);
                    ((CName) chunk.cr2w.CreateVariable(connection, "CName", "socketId")).Value = in_name;
                }


                var blocks = (CArray) connection.GetVariableByName("blocks");

                if (blocks == null)
                {
                    blocks = (CArray) chunk.cr2w.CreateVariable(connection, "array:2,0,SBlockDesc", "blocks");
                }

                var block = chunk.cr2w.CreateVector(blocks);
                chunk.cr2w.CreatePtr(block, "ptr:CQuestGraphBlock", out_target, "ock");
                ((CName) chunk.cr2w.CreateVariable(block, "CName", "putName")).Value = out_name;
            }
        }
    }
}