using System.IO;
using WolvenKit.Common.FNV1A;

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
            if (ulong.TryParse(value, out var key))
            {
                cres.Text = value;
                cres.Key = key;
            }
            else
            {
                cres.Text = value;
                cres.Key = !string.IsNullOrEmpty(value) ? FNV1A64HashAlgorithm.HashString(value) : 0;
            }
            return cres;
        }

        public override string ToString() => $"{Text} <raRef:CResource 0x{Key:X} / {Key}>";
        public void Serialize(BinaryWriter writer) => writer.Write(Key);
    }

}
