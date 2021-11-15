using System;
using System.IO;
using RED.CRC32;
using WolvenKit.Common.FNV1A;
using System.Text.RegularExpressions;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CResource : IPrimitive
    {
        public string Name => "raRef:CResource";
        public string Text { get; set; }
        public ulong Key { get; set; }

        public static implicit operator CResource(string value)
        {
            var cres = new CResource();
            var rx = new Regex(@"(\d+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var m = rx.Matches(value);
            if (m.Count == 1)
            {
                cres.Text = value;
                cres.Key = Convert.ToUInt64(m[0].Groups[1].Value, 10);
                return cres;
            }

            cres.Text = value;
            cres.Key = (!string.IsNullOrEmpty(value) && value != "0") ? FNV1A64HashAlgorithm.HashString(value) : 0;
            return cres;
        }

        public override string ToString() => $"{Text} <raRef:CResource 0x{Key:X} / {Key}>";
        public void Serialize(BinaryWriter writer) => writer.Write(Key);
    }

}
