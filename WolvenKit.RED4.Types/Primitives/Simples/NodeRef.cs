using System;

namespace WolvenKit.RED4.Types
{
    public sealed class NodeRef : IRedPrimitive, IEquatable<NodeRef>
    {
        public string Text { get; set; }
        public ulong Unk1 { get; set; }

        public static implicit operator NodeRef(string value) => new() { Text = value };
        public static implicit operator string(NodeRef value) => value.Text;

        public static implicit operator NodeRef(ulong value) => new() { Unk1 = value };
        public static implicit operator ulong(NodeRef value) => value.Unk1;

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
