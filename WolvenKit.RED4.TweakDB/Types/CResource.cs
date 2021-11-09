using System;
using System.IO;
using RED.CRC32;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CResource : IPrimitive
    {
        public string Name => "raRef:CResource";
        public string Text { get; set; }
        public ulong Key { get; set; }

        public static implicit operator CResource(string value) => new()
        {
            Text = value,
            Key = (!string.IsNullOrEmpty(value) && value != "0") ? FNV1A64HashAlgorithm.HashString(value) : 0 
        };

        public override string ToString() => $"{Text} <raRef:CResource 0x{Key:X} / {Key}>";
        public void Serialize(BinaryWriter writer) => writer.Write(Key);
    }

}
