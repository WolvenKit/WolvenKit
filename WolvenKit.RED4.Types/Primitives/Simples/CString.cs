using System;
using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CString : IRedPrimitive, IEquatable<CString>
    {
        public string Text { get; set; }

        public static implicit operator CString(string value) => new() { Text = value };
        public static implicit operator string(CString value) => value.Text;

        public override string ToString() => $"String, Text = '{Text}'";


        public override bool Equals(object obj)
        {
            if (obj is CString cObj)
            {
                return Equals(obj);
            }

            return false;
        }

        public bool Equals(CString other)
        {
            if (other == null)
            {
                return false;
            }

            return Text.Equals(other.Text);
        }
    }
}
