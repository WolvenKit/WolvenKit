using System;

namespace WolvenKit.RED4.Types
{
    public class NodeRef : IRedPrimitive, IEquatable<NodeRef>
    {
        public string Text { get; set; }

        public static implicit operator NodeRef(string value) => new() { Text = value };
        public static implicit operator string(NodeRef value) => value.Text;

        public override string ToString() => $"String, Text = '{Text}'";


        public override bool Equals(object obj)
        {
            if (obj is NodeRef cObj)
            {
                return Equals(obj);
            }

            return false;
        }

        public bool Equals(NodeRef other)
        {
            if (other == null)
            {
                return false;
            }

            return Text.Equals(other.Text);
        }
    }
}
