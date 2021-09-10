using System;

namespace WolvenKit.RED4.Types
{
    public class NodeRef : IRedPrimitive, IEquatable<NodeRef>
    {
        public string Text { get; set; }

        public static implicit operator NodeRef(string value) => new() { Text = value };
        public static implicit operator string(NodeRef value) => value.Text;

        public override string ToString() => $"String, Text = '{Text}'";

        public bool Equals(NodeRef other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Text == other.Text;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((NodeRef)obj);
        }

        public override int GetHashCode() => (Text != null ? Text.GetHashCode() : 0);
    }
}
