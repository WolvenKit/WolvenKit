using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CName : IRedPrimitive
    {
        public string Text { get; set; }

        public static implicit operator CName(string value) => new() { Text = value };
        public static implicit operator string(CName value) => value.Text;

        public override string ToString() => $"CName, Text = '{Text}'";
    }
}
