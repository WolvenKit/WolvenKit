using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CString : IRedPrimitive
    {
        public string Text { get; set; }

        public static implicit operator CString(string value) => new() { Text = value };
        public static implicit operator string(CString value) => value.Text;

        public override string ToString() => $"String, Text = '{Text}'";
    }
}
