namespace WolvenKit.RED4.Types
{
    public class NodeRef : IRedPrimitive
    {
        public string Text { get; set; }

        public static implicit operator NodeRef(string value) => new() { Text = value };
        public static implicit operator string(NodeRef value) => value.Text;

        public override string ToString() => $"String, Text = '{Text}'";
    }
}
