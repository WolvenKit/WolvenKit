using System;
using System.IO;

namespace WolvenKit.RED4.Types
{
    public class CName : IRedPrimitive, IEquatable<CName>
    {
        public string Text { get; set; }

        public static implicit operator CName(string value) => new() { Text = value };
        public static implicit operator string(CName value) => value.Text;

        public override string ToString() => $"CName, Text = '{Text}'";


        public override bool Equals(object obj)
        {
            if (obj is CName cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CName other)
        {
            if (other == null)
            {
                return false;
            }

            return string.Equals(Text, other.Text);
        }
    }
}
