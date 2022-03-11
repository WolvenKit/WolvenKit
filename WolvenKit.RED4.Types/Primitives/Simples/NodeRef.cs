
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [RED("NodeRef")]
    [REDType(IsValueType = true)]
    [DebuggerDisplay("{_value}", Type = "NodeRef")]
    public class NodeRef : BaseStringType
    {
        public NodeRef() {}
        private NodeRef(string value) : base(value) {}

        public static implicit operator NodeRef(string value) => new(value);
        public static implicit operator string(NodeRef value) => value._value;

        public override string ToString() => $"NodeRef, Text = '{_value}'";
    }
}
