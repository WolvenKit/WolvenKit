using System;
using System.IO;
using RED.CRC32;
using System.Text.RegularExpressions;
using System.Buffers.Binary;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class TweakDBID : IPrimitive
    {
        public string Name => "TweakDBID";
        public string Text { get; set; }
        public int Length { get; set; }
        public uint Key { get; set; }

        public static implicit operator TweakDBID(string value)
        {
            var t = new TweakDBID();
            var rx = new Regex(@"Tw?e?a?k?DBID\w?:\w?0?x?([0-9A-F]{8})\w?:\w?0?x?([0-9A-F]{2})", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var m = rx.Matches(value);
            if (m.Count == 1)
            {
                t.Text = value;
                t.Key = Convert.ToUInt32(m[0].Groups[1].Value, 16);
                t.Length = Convert.ToUInt16(m[0].Groups[2].Value, 16);
                return t;
            }

            t.Text = value;
            t.Key = Crc32Algorithm.Compute(value);
            t.Length = value.Length;
            return t;
        }

        public override string ToString() => $"{Text} <TweakDBID 0x{String.Format("{0:X8}", Key)}:0x{Length:X2} / {Key}:{Length}>";

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(Key);
            writer.Write((byte)Length);
            writer.Write((byte)0);
            writer.Write((byte)0); 
            writer.Write((byte)0);
        }
    }

}
